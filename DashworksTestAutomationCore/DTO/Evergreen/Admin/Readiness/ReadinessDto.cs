using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Readiness
{
    public class ReadinessDto
    {
        public string ReadinessName { get; set; }
        public string Tooltip { get; set; }
        public string TemplateId { get; set; }
        public bool Ready { get; set; }
        public bool DefaultForApplications { get; set; }
        public int ProjectId { get; set; }

        public ReadinessDto() { }
    }
}