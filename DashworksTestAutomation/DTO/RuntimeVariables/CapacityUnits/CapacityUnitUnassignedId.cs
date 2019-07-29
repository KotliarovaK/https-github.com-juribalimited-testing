using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;

namespace DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits
{
    //This is default Capacity Unit and we should know it ID to make it default again or restore old name/description
    class CapacityUnitUnassignedId
    {
        public List<CapacityUnitDto> Value { get; set; }

        public CapacityUnitUnassignedId()
        {
            Value = new List<CapacityUnitDto>();
        }
    }
}
