using System.Collections.Generic;
using System.ComponentModel;
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
        public RequestTypesDto ReqestType { get; set; }
        public CategoryPropertiesDto Categories { get; set; }
        public StagePropertiesDto Stages { get; set; }
        public TaskPropertiesDto Tasks { get; set; }
        public TeamPropertiesDto TeamProperties { get; set; }
        public List<GroupPropertiesDto> GroupProperties { get; set; }
        public MailTemplatePropertiesDto MailTemplateProperties { get; set; }
        public NewsDto News { get; set; }

        public ProjectDto()
        {
            DefaultLanguage = EnumExtensions.GetRandomValue<DefaultLanguageEnum>();
            GroupProperties = new List<GroupPropertiesDto>();
            ProjectType = ProjectTypeEnum.ComputerScheduledProject;
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