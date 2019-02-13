using System;

//Convertor for colors check.

namespace DashworksTestAutomation.Helpers
{
    internal class ColorsConvertor
    {
        public static string Convert(string colorName)
        {
            switch (colorName)
            {
                case "Red":
                    return "rgba(245, 96, 86, 0.5)";
                case "Amber":
                    return "rgba(235, 175, 37, 0.5)";
                case "Blue":
                    return "rgba(47, 133, 184, 0.5)";
                case "Light Blue":
                    return "rgba(71, 209, 209, 0.5)";
                case "Out Of Scope":
                    return "rgba(55, 61, 69, 0.5)";
                case "Brown":
                    return "rgba(153, 118, 84, 0.5)";
                case "Really Extremely Orange":
                    return "rgba(226, 123, 54, 0.5)";
                case "Purple":
                    return "rgba(186, 94, 186, 0.5)";
                case "Green":
                    return "rgba(126, 189, 56, 0.5)";
                case "Grey":
                    return "rgba(128, 139, 153, 0.5)";
                case "None":
                    return "rgba(198, 203, 210, 0.5)";
                default:
                    throw new Exception($"{colorName} color not found in convertor");
            }
        }
    }
}