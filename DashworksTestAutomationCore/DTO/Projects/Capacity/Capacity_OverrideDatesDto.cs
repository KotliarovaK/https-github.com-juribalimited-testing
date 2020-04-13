using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_OverrideDatesDto
    {
        public string Date { get; set; }
        public OverrideTeamEnum OverrideTeam;
        public OverrideRequestTypeEnum OverrideRequestType;
        public int Capacity { get; set; }
        public string Comment { get; set; }

        public Capacity_OverrideDatesDto()
        {
            OverrideTeam = OverrideTeamEnum.AllTeams;
        }
    }

    public enum OverrideTeamEnum
    {
        [Description("[All Teams]")]
        AllTeams
    }

    public enum OverrideRequestTypeEnum
    {
        [Description("[Default (Computer)]")]
        DefaultComputer,
        [Description("[Default (Mailbox)]")]
        DefaultMailbox,
        [Description("[Default (User)]")]
        DefaultUser
    }
}