using System;

//Convertor for colors check.

namespace DashworksTestAutomation.Helpers
{
    internal class ColorWidgetConvertor
    {
        public static string ConvertComplianceColorWidget(string colorName)
        {
            switch (colorName)
            {
                case "Really Extremely Orange":
                    return "rgba(226, 123, 54, 1)";
                case "Pink":
                    return "rgba(226, 116, 171, 1)";
                case "Amber":
                    return "rgba(235, 175, 37, 1)";
                case "Grey":
                    return "rgba(128, 139, 153, 1)";
                case "Green":
                    return "rgba(126, 189, 56, 1)";
                case "Red":
                    return "rgba(245, 96, 86, 1)";

                default:
                    throw new Exception($"{colorName} color not found in convertor");
            }
        }
    }
}
