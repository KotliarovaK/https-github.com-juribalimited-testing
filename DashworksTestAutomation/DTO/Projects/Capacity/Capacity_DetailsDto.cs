using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_DetailsDto
    {
        public bool EnablePlanning { get; set; }
        public bool DisplayColors { get; set; }
        public bool EnforceOonSelfServicePage { get; set; }
        public bool EnforceOnProjectObjectPage { get; set; }
        public string CapacityToReach { get; set; }
    }
}