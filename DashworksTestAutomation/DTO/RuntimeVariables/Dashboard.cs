using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{

    public class Dashboard
    {
        public DashboardDto Value { get; set; }

        public Dashboard()
        {
            Value = new DashboardDto();
        }
    }
}