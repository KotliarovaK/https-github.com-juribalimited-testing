using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created Rings objects are stored here
    class Rings
    {
        public List<RingDto> Value { get; set; }

        public Rings()
        {
            Value = new List<RingDto>();
        }
    }
}
