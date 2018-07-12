using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created buckets names are stored here
    public class Buckets
    {
        public List<string> Value { get; set; }

        public Buckets()
        {
            Value = new List<string>();
        }
    }
}
