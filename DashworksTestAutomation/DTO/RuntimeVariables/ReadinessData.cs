using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Probably should be changed to DTO
    public class ReadinessData
    {
        public string Name { get; set; }
        public string ToolTip { get; set; }
        public string Ready { get; set; }
        public string Default { get; set; }
    }
}
