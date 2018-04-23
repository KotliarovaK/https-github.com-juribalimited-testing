using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_ThankYouDto
    {
        //TODO add a language?
        public bool ShowInTheSelfServicePortal;
        public bool ShowInTheNavigationMenu;
        public bool ShowChoicesSummary;
        public bool IncludeLink;
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
    }
}