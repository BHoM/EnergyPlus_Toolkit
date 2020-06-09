using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlusString(this IEnergyPlusClass energyPlusClass)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(energyPlusClass.ClassName + ",\n");

            // TODO - Enable handling of nested objects - get Name attribute as referenced string of nested object

            // This method uses LINQ to order objects attributes by their [Order] attribute ... but it seems that they may already be ordered by their order of definition in the objects.
            //var properties = from property in energyPlusClass.GetType().GetProperties()
            //                 where Attribute.IsDefined(property, typeof(OrderAttribute))
            //                 orderby ((OrderAttribute)property.GetCustomAttributes(typeof(OrderAttribute), false).Single()).Order
            //                 select property;

            // TODO - Replace LINQ method above with non-LINQ below
            List<PropertyInfo> properties = new List<PropertyInfo>();
            foreach (PropertyInfo property in energyPlusClass.GetType().GetProperties())
            {
                if (Attribute.IsDefined(property, typeof(OrderAttribute)))
                {
                    properties.Add(property);
                }
            }

            string formatStringA = "    {0, -30}, !- {1}\n";
            string formatStringB = "    {0, -30}; !- {1}\n";
            int totalCount = properties.Count();
            int incrementor = 0;
            foreach (PropertyInfo property in properties)
            {
                if ((incrementor + 1) == totalCount)
                {
                    sb.AppendFormat(formatStringB, energyPlusClass.PropertyValue(property.Name), property.Name);
                }
                else
                {
                    sb.AppendFormat(formatStringA, energyPlusClass.PropertyValue(property.Name), property.Name);
                }
                incrementor += 1;
            }
            
            return sb.ToString();
        }
    }
}
