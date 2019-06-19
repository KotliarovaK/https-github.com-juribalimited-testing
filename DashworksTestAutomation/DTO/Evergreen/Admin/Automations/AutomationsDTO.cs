using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        private string Id;

        public string AutomationName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool StopOnFailedAction { get; set; }
        public string Scope { get; set; }
        public string Run { get; set; }

        public AutomationsDto(string id)
        {
            Id = id;
        }

        public AutomationsDto() { }

        //public string GetId()
        //{
        //    if (string.IsNullOrEmpty(Id))
        //    {
        //        Id = DatabaseHelper.(this.Name).Id;
        //    }
        //    return Id;
        //}
    }
}