using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created Actions for Automations are stored here
    public class AutomationActions
    {
        public List<string> Value { get; set; }

        public AutomationActions()
        {
            Value = new List<string>();
        }
    }
}
