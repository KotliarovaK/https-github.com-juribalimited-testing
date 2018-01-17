using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //We store filter settings in this object
    class Filter
    {
        public string FilterName { get; set; }
        public BaseFilter FilterSettings { get; set; }

        public void CheckFilterDate()
        {
            FilterSettings.CheckFilterDate(FilterName);
        }
    }
}
