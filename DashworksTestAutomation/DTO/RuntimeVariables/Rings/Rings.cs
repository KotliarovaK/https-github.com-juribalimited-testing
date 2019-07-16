using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;

namespace DashworksTestAutomation.DTO.RuntimeVariables.Rings
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
