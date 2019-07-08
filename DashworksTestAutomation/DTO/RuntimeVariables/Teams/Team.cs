using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Created team names are stored here
    public class Team
    {
        public List<TeamDto> Value { get; set; }

        public Team()
        {
            Value = new List<TeamDto>();
        }
    }
}