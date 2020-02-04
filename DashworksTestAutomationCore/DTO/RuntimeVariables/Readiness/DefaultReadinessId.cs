using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables.Readiness
{
    //Store default Readiness ID for specific project 
    public class DefaultReadinessId
    {
        //ProjectId and ReadinessId
        public IList<KeyValuePair<int, int>> Value { get; set; }

        public DefaultReadinessId()
        {
            Value = new List<KeyValuePair<int, int>>();
        }
    }
}
