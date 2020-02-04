using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created Slots are stored here
    public class Slots
    {
        public List<SlotDto> Value { get; set; }

        public Slots()
        {
            Value = new List<SlotDto>();
        }
    }
}
