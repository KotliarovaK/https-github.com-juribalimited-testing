using System;
using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_ComputerOwnershipDto
    {
        //TODO add a language?
        public bool ShowScreen;
        public ComputerNameEnum ShowComputerName;
        public bool ShowComputers;
        public bool ShowCategory;
        public bool AllowUsersToSearch;
        public bool AllowUsersToSetPrimary;
        public bool AllowUsersToAddANote;
        public string LimitMaximum  { get; set; }
        public string LimitMinimum { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
        //TODO Request Types for Computer Search
        //TODO Categories for Computer Search
        //TODO Additional Tasks

        public SelfService_ComputerOwnershipDto()
        {
            ShowComputerName = EnumExtensions.GetRandomValue<ComputerNameEnum>();
        }
    }

    public enum ComputerNameEnum
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