using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created projects names are stored here
    public class Projects
    {
        public List<string> Value { get; set; }

        public Projects()
        {
            Value = new List<string>();
        }
    }
}
