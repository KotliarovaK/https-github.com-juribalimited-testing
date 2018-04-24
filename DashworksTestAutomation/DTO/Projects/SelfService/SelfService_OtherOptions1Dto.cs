using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_OtherOptions1Dto
    {
        //TODO add a language?
        public bool ShowScreen;
        public bool AllowUsersToAddANote;
        public bool OnlyOwned;
        public bool AllLinked;
        //TODO User Task Name?!?
        //TODO Computer Task Name?!?
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
    }
}