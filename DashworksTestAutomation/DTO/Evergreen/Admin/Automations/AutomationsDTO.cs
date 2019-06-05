using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        private string Id;

        public string Name { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        public string Run { get; set; }
        public bool Active { get; set; }
        public bool StopOnFailedAction { get; set; }

        public AutomationsDto(string id)
        {
            Id = id;
        }
    }
}