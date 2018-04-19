using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class GroupPropertiesDto
    {
        public string GroupName { get; set; }
        public OwnedByTeamEnum OwnedByTeam;
    }

    public enum OwnedByTeamEnum
    {
        [Description("AAA TestTeam")]
        AAATestTeam,
        [Description("Admin IT")]
        AdminIT,
        [Description("IB Team")]
        IBTeam,
        [Description("My Team")]
        MyTeam,
        [Description("Team 0")]
        Team0
    }
}