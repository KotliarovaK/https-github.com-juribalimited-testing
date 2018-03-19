using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Helpers
{
    class FilterOperatorsConvertor
    {
        public static string Convert(string filterOPerator)
        {
            switch (filterOPerator)
            {
                case "is":
                    return "EQUALS";
                case "is not":
                    return "NOT";
                default:
                    throw new Exception($"{filterOPerator} operator not found in convertor");
            }
        }
    }
}
