using System;
using System.Collections.Generic;
using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_ProjectDateDto
    {
        public bool ShowThisScreen { get; set; }
        public string ShowComputerNameString { get; set; }
        public ShowComputerNameEnum ShowComputerName;
        public bool AllowUsersToAddANote { get; set; }
        public string MinimumHours { get; set; }
        public string MaximumHours { get; set; }
        public string PageDescription { get; set; }
    }

    public enum ShowComputerNameEnum
    {
        [Description("Do not show")]
        DoNotShow,
        [Description("REMOTE_HOST")]
        RemoteHost,
        [Description("X-Forwarded-For")]
        XForwardedFor,
        Other
    }
}