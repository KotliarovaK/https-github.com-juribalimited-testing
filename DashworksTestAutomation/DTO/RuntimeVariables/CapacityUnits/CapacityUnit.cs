using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;

namespace DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits
{
    //Created capacity unit names are stored here
    public class CapacityUnits
    {
        public List<CapacityUnitDto> Value { get; set; }

        public CapacityUnits()
        {
            Value = new List<CapacityUnitDto>();
        }
    }
}