using System;
using System.Collections.Generic;
using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_ProjectDateDto
    {
        public bool ShowThisScreen { get; set; }
        public ShowComputerNameEnum ShowComputerName;
        public bool AllowUsersToAddANote { get; set; }
        public string MinimumHours { get; set; }
        public string MaximumHours { get; set; }
        //TODO Additional Tasks
        public string PageDescription { get; set; }

        public SelfService_ProjectDateDto()
        {
            ShowComputerName = EnumExtensions.GetRandomValue<ShowComputerNameEnum>();
        }
    }

    public enum ShowComputerNameEnum
    {
        [Description("Do not show")]
        DoNotShow,
        [Description("REMOTE_HOST")]
        RemoteHost,
        [Description("X-Forwarded-For")]
        XForwardedFor,
    }
}