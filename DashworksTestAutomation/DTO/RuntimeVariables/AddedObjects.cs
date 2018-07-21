using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Objects that were added to the Buckets
    public class AddedObjects
    {
        public Dictionary<string, string> Value { get; set; }

        public AddedObjects()
        {
            Value = new Dictionary<string, string>();
        }
    }
}
