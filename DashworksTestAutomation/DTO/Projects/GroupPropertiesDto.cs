using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class GroupPropertiesDto
    {
        public string GroupName { get; set; }
        public OwnedByTeamEnum OwnedByTeam;

        public GroupPropertiesDto()
        {
            OwnedByTeam = EnumExtensions.GetRandomValue<OwnedByTeamEnum>();
        }
    }

    public enum OwnedByTeamEnum
    {
        [Description("Admin IT")]
        AdminIT,
        [Description("IB Team")]
        IBTeam,
        [Description("My Team")]
        MyTeam
    }
}