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
                case "RED":
                    return "rgba(245, 96, 86, 0.5)";
                case "Blocked":
                case "BLOCKED":
                    return "rgba(245, 96, 86, 0.5)";
                case "Amber":
                case "AMBER":
                    return "rgba(235, 175, 37, 0.5)";
                case "Blue":
                case "BLUE":
                    return "rgba(47, 133, 184, 0.5)";
                case "Light Blue":
                case "LIGHT BLUE":
                    return "rgba(71, 209, 209, 0.5)";
                case "Out Of Scope":
                case "OUT OF SCOPE":
                    return "rgba(55, 61, 69, 0.5)";
                case "Brown":
                case "BROWN":
                    return "rgba(153, 118, 84, 0.5)";
                case "Really Extremely Orange":
                case "REALLY EXTREMELY ORANGE":
                    return "rgba(226, 123, 54, 0.5)";
                case "Purple":
                case "PURPLE":
                    return "rgba(186, 94, 186, 0.5)";
                case "Green":
                case "GREEN":
                    return "rgba(126, 189, 56, 0.5)";
                case "Grey":
                case "GREY":
                    return "rgba(128, 139, 153, 0.5)";
                case "Ignore":
                case "IGNORE":
                    return "rgba(198, 203, 210, 0.5)";
                default:
                    throw new Exception($"{colorName} color not found in convertor");
            }
        }

        public static string ConvertToHex(string colorName)
        {
            switch (colorName.ToLower())
            {
               case "green":
                   return "#7ebd38";

               case "rgb(30, 45, 114)":
                   return "#1E2D72";

               case "rgb(143, 20, 64)":
                   return "#571845";

                default:
                   throw new Exception($"{colorName} color not found in convertor");
            }
        }
    }
}