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
        public bool DepartmentDoNotPush;
        public bool DepartmentPushToOwned;
        public bool PushToAll;
        public bool Location;
        public bool LocationDoNotPush;
        public bool LocationPushToOwned;
        public bool LocationPushToAll;
        public bool DepartmentFeed;
        //TODO Additional Tasks
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
        public bool HrLocationFeed;
        public bool ManualLocationFeed;
        public bool HistoricLocationFeed;
    }
}