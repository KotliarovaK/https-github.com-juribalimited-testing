using System.Collections.Generic;
using System.ComponentModel;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class ProjectDto
    {
        public string ProjectName { get; set; }
        public string ProjectShortName { get; set; }
        public string ProjectDescription { get; set; }
        public ProjectTypeEnum ProjectType;
        public DefaultLanguageEnum DefaultLanguage;
        public DetailsDto Details { get; set; }
        public List<RequestTypesDto> ReqestTypes { get; set; }
        public RequestType_DetailsDto RequestTypeDetails { get; set; }
        public CategoryPropertiesDto Categories { get; set; }
        public List<StagesPropertiesDto> Stages { get; set; }
        public TaskPropertiesDto Tasks { get; set; }
        public TaskProperties_DetailsDto TaskPropertiesDetails { get; set; }
        public TaskProperties_ValuesDto TaskPropertiesValues { get; set; }
        public TaskProperties_EmailsDto TaskPropertiesEmails { get; set; }
        public TeamPropertiesDto TeamProperties { get; set; }
        public List<GroupPropertiesDto> GroupProperties { get; set; }
        public MailTemplatePropertiesDto MailTemplateProperties { get; set; }
        public NewsDto News { get; set; }
        public ManageUsersDto ManageUsers { get; set; }

        public ProjectDto()
        {
            DefaultLanguage = EnumExtensions.GetRandomValue<DefaultLanguageEnum>();
            ProjectType = ProjectTypeEnum.ComputerScheduledProject;
            GroupProperties = new List<GroupPropertiesDto>();
            ReqestTypes = new List<RequestTypesDto>();
            Stages = new List<StagesPropertiesDto>();
        }
    }

    public enum ProjectTypeEnum
    {
        [Description("Computer Scheduled Project")]
        ComputerScheduledProject,
        [Description("User Scheduled Project")]
        UserScheduledProject,
        [Description("Mailbox Scheduled Project")]
        MailboxScheduledProject
    }

    public enum DefaultLanguageEnum
    {
        Arabic,
        [Description("British English")]
        BritishEnglish,
        English,
        Polish,
        Russian
    }
}