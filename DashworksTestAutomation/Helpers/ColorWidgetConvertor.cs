using System;

//Convertor for colors check.

namespace DashworksTestAutomation.Helpers
{
    internal class ColorWidgetConvertor
    {
        public static string Convert(string colorName)
        {
            switch (colorName)
            {
                case "Pink":
                    return "rgb(226, 116, 171)";
                case "Amber":
                    return "rgb(235, 175, 37)";
                default:
                    throw new Exception($"{colorName} color not found in convertor");
            }
        }

        public static string ConvertComplianceColorWidget(string colorName)
        {
            switch (colorName)
            {
                case "Pink":
                    return "rgb(226, 116, 171)";
                case "Amber":
                    return "rgba(226, 123, 54, 0.5)";
                case "Grey":
                    return "rgba(128, 139, 153, 0.5)";
                case "Green":
                    return "rgba(126, 189, 56, 1)";
                default:
                    throw new Exception($"{colorName} color not found in convertor");
            }
        }
    }
}
