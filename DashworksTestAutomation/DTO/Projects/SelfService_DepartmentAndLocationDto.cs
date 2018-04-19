using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_DepartmentAndLocationDto
    {
        //TODO add a language?
        public bool ShowScreen;
        public bool ShowDepartmentFullPath;
        public bool ShowLocationFullPath;
        public bool AllowUsersToAddANote;
        public bool Department;
        public bool Location;
        //TODO 6 checkbox 
        public bool ShowDepartmentFeed;
        //TODO Additional Tasks
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
        public bool ShowHRLocationFeed;
        public bool ShowManualLocationFeed;
        public bool ShowHistoricLocationFeed;
    }
}