using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    public class TeamName 
    {
        public List<string> Value { get; set; }

        public TeamName()
        {
            Value = new List<string>();
        }
    }
}
