using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    class CapacityDetails
    {
        public List<CapacityDetailsDto> Value { get; set; }

        public CapacityDetails()
        {
            Value = new List<CapacityDetailsDto>();
        }
    }
}
