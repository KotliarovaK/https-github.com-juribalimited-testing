using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Russian,
        [Description("Mailbox Scheduled Project")]
        MailboxScheduledProject
    }
}