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

            

            List<PropertyInfo> properties = new List<PropertyInfo>();
            foreach (PropertyInfo property in energyPlusClass.GetType().GetProperties())
            {
                if (Attribute.IsDefined(property, typeof(OrderAttribute)))
                {
                    properties.Add(property);
                }
            }

            // TODO - Enable handling of geometries here to account for nested Points/Vertices
            // TODO - IF CONTAINS List<Point> do X, if contains List<string> do other thing

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
            sb.Append("\n");
            
            return sb.ToString();
        }
    }
}
