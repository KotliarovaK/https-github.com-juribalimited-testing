using System;

//Convertor for URL check.

namespace DashworksTestAutomation.Helpers
{
    internal class FilterOperatorsConvertor
    {
        public static string Convert(string filterOPerator)
        {
            switch (filterOPerator)
            {
                case "is":
                    return "EQUALS";
                case "is not":
                    return "NOT%20EQUALS";
                case ",":
                    return "%2C";
                case "or":
                    return "%2C";
                default:
                    throw new Exception($"{filterOPerator} operator not found in convertor");
            }
        }
    }
}