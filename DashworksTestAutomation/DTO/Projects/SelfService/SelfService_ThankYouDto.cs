using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_ThankYouDto
    {
        public bool SelfServicePortal { get; set; }
        public bool NavigationMenu { get; set; }
        public bool ChoicesSummary { get; set; }
        public bool IncludeLink { get; set; }
        public string PageDescription { get; set; }
    }
}