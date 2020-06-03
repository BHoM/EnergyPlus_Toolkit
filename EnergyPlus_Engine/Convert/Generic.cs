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

            // TODO - Replace with proper CSharp method
            // TODO - Enable handling of nested objects - get Name attribute as referenced string of nested object

            var properties = from property in energyPlusClass.GetType().GetProperties()
                             where Attribute.IsDefined(property, typeof(OrderAttribute))
                             orderby ((OrderAttribute)property
                                       .GetCustomAttributes(typeof(OrderAttribute), false)
                                       .Single()).Order
                             select property;

            string formatString = "    {0}, !- {1}\n";
            int totalCount = properties.Count();
            int incrementor = 0;
            foreach (PropertyInfo property in properties)
            {
                if ((incrementor + 1) == totalCount)
                {
                    sb.AppendFormat(formatString.Replace(",", ";"), energyPlusClass.PropertyValue(property.Name), property.Name);
                }
                else
                {
                    sb.AppendFormat(formatString, energyPlusClass.PropertyValue(property.Name), property.Name);
                }
                incrementor += 1;
            }
            
            return sb.ToString();
        }
    }
}
