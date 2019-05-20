using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created capacity unit names are stored here
    public class CapacityUnit
    {
        public List<CapacityUnitDto> Value { get; set; }

        public CapacityUnit()
        {
            Value = new List<CapacityUnitDto>();
        }
    }
}