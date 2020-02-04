﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_DepartmentAndLocationDto
    {
        public bool ShowScreen { get; set; }
        public bool ShowDepartmentFullPath { get; set; }
        public bool ShowLocationFullPath { get; set; }
        public bool AllowUsersToAddANote { get; set; }
        public bool Department { get; set; }
        public bool DepartmentDoNotPush { get; set; }
        public bool DepartmentPushToOwned { get; set; }
        public bool DepartmentPushToAll { get; set; }
        public bool Location { get; set; }
        public bool LocationDoNotPush { get; set; }
        public bool LocationPushToOwned { get; set; }
        public bool LocationPushToAll { get; set; }
        public bool DepartmentFeed { get; set; }
        public bool HrLocationFeed { get; set; }
        public bool ManualLocationFeed { get; set; }
        public bool HistoricLocationFeed { get; set; }
        public string PageDescription { get; set; }
    }
}