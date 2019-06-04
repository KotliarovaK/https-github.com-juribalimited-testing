using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created capacity unit names are stored here
    public class Automation
    {
        public List<AutomationsDto> Value { get; set; }

        public Automation()
        {
            Value = new List<AutomationsDto>();
        }
    }
}