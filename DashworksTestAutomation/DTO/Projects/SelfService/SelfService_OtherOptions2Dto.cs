using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_OtherOptions2Dto
    {
        //TODO add a language?
        public bool ShowScreen { get; set; }
        public bool AllowUsersToAddANote { get; set; }
        public bool OnlyOwned { get; set; }
        public bool AllLinked { get; set; }
        //TODO User Task Name?!?
        //TODO Computer Task Name?!?
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
    }
}