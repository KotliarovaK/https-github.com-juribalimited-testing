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
    }
}
