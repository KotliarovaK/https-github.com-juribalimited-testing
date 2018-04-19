using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_CapacityDto
    {
        public TeamEnum Team;
        public RequestTypeEnum RequestType;
        //TODO Request Type [Default(Computer)]

        public Capacity_CapacityDto()
        {
            Team = EnumExtensions.GetRandomValue<TeamEnum>();
            RequestType = EnumExtensions.GetRandomValue<RequestTypeEnum>();
        }
    }

    public enum TeamEnum
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

    public enum RequestTypeEnum
    {
        [Description("[Select]")]
        Select,
        [Description("[Default (Computer)]")]
        DefaultComputer
    }
}