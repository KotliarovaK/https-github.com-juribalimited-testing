using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits
{
    class CapacityDetailsDto
    {
        public string Project { get; set; }
        public bool EnableCapacity { get; set; }
        public bool EnforceCapacityOnSelfServicePages { get; set; }
        public bool EnforceCapacityOnProjectObjectPage { get; set; }
        public string CapacityMode { get; set; }

        public int CapacityModeId
        {
            get
            {
                switch (CapacityMode)
                {
                    case "Teams and Paths":
                        return 1;
                    case "Capacity Units":
                        return 2;
                    default:
                        throw new Exception($"Unknown CapacityMode: {CapacityMode}");
                }
            }
        }

        public string CapacityUnits { get; set; }
        public string Percentage { get; set; }
    }
}
