using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskProperties_EmailsDto
    {
        public DaysEnum Days;
        public TaskDueEnum TaskDue;
        public bool CountDays { get; set; }
        public MailTemplateEnum MailTemplate;
        public ImportanceEnum Importance;
        public bool SendOnceOnly { get; set; }
        public bool RequestTypesAll { get; set; }
        public bool ApllyEmailToAll { get; set; }
        public GroupTypeEnum GroupType;
        public string To { get; set; }

        public TaskProperties_EmailsDto()
        {
            Days = EnumExtensions.GetRandomValue<DaysEnum>();
            TaskDue = EnumExtensions.GetRandomValue<TaskDueEnum>();
            Importance = EnumExtensions.GetRandomValue<ImportanceEnum>();
            GroupType = EnumExtensions.GetRandomValue<GroupTypeEnum>();
        }

        public enum DaysEnum
        {
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five
        }

        public enum TaskDueEnum
        {
            Before,
            After
        }

        public enum MailTemplateEnum
        {
        }

        public enum ImportanceEnum
        {
            Low,
            Normal,
            High
        }

        public enum GroupTypeEnum
        {
            User,
            Computer
        }
    }
}