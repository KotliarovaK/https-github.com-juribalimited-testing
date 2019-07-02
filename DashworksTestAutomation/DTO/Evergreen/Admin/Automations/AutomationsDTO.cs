using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        public bool Active { get; set; }
        public int AutomationId => -1;
        public string AutomationName { get; set; }
        public string Run { get; set; }
        public string AutomationSqlAgentJobId { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        //public string ObjectTypeId { get; set; }
        public bool StopOnFailedAction { get; set; }

        public AutomationsDto() { }
    }
}