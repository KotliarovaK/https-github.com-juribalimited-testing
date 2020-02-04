using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created Automation names are stored here
    public class Automations
    {
        public List<AutomationsDto> Value { get; set; }

        public Automations()
        {
            Value = new List<AutomationsDto>();
        }
    }
}