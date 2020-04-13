using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Teams
{
    public class TeamDto
    {
        private string Id;

        public string TeamName { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }

        public TeamDto(string id)
        {
            Id = id;
        }

        public TeamDto() { }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = DatabaseHelper.GetTeam(this.TeamName).Id;
            }
            return Id;
        }
    }
}