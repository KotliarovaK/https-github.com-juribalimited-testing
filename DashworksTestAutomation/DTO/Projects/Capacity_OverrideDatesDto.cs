using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_OverrideDatesDto
    {
        //TODO filter?
        public string Date { get; set; }
        public OverrideTeamEnum OverrideTeam;
        public OverrideRequestTypeEnum OverrideRequestType;
        public int Capacity { get; set; }
        public string Comment { get; set; }

        public Capacity_OverrideDatesDto()
        {
            OverrideTeam = EnumExtensions.GetRandomValue<OverrideTeamEnum>();
            OverrideRequestType = EnumExtensions.GetRandomValue<OverrideRequestTypeEnum>();
        }
    }

    public enum OverrideTeamEnum
    {
        [Description("Administrative Team")]
        AdministrativeTeam,
        [Description("Another Team Again")]
        AnotherTeamAgain,
        [Description("Application Profilers")]
        ApplicationProfilers,
        [Description("My Team")]
        MyTeam,
        [Description("Team 0")]
        Team0,
        [Description("Retail Team")]
        RetailTeam
    }

    public enum OverrideRequestTypeEnum
    {
        [Description("[All Request Types]")]
        AllRequestTypes,
        [Description("[Default (Computer)]")]
        DefaultComputer
    }
}