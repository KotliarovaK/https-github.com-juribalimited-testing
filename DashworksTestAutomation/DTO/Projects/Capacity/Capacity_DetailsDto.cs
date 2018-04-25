using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_DetailsDto
    {
        public bool EnablePlanning;
        public bool DisplayColors;
        public bool EnforceOonSelfServicePage;
        public bool EnforceOnProjectObjectPage;
        public string CapacityToReach { get; set; }
    }
}