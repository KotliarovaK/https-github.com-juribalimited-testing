using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Store created Dashboards here
    public class Dashboards
    {
        public List<DashboardDto> Value { get; set; }

        public Dashboards()
        {
            Value = new List<DashboardDto>();
        }
    }
}