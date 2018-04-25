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
    }
}