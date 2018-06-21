using System;
using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_ComputerOwnershipDto
    {
        //TODO add a language?
        public bool ShowScreen { get; set; }
        public ComputerNameEnum ShowComputerName;
        public bool ShowComputers { get; set; }
        public bool ShowCategory { get; set; }
        public bool AllowUsersToSearch { get; set; }
        public bool AllowUsersToSetPrimary { get; set; }
        public bool AllowUsersToAddANote { get; set; }
        public string LimitMaximum  { get; set; }
        public string LimitMinimum { get; set; }
        public string PageDescription { get; set; }
        public ProjectDto Project { get; set; }


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
        XForwardedFor
    }
}