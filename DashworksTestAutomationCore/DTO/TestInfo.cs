using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO
{
    public class TestInfo
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public List<string> Tags { get; set; }
    }
}
