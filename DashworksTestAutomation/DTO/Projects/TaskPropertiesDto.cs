using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskPropertiesDto
    {
        public string Name { get; set; }
        public string Help { get; set; }
        //public StageNameEnum StageName;
        public TaskTypeEnum TaskType;
        public ValueTypeEnum ValueType;
        public TaskObjectTypeEnum ObjectType;
        public TaskValuesTemplateEnum TaskValuesTemplate;
        public bool TaskValuesTemplateCheckbox { get; set; }

        public TaskPropertiesDto()
        {
            ObjectType = EnumExtensions.GetRandomValue<TaskObjectTypeEnum>();
            TaskValuesTemplate = EnumExtensions.GetRandomValue<TaskValuesTemplateEnum>();
        }
    }

    //public enum StageNameEnum
    //{
    //}

    public enum TaskTypeEnum
    {
        Normal,
        Group
    }

    public enum ValueTypeEnum
    {
        Radiobutton,
        DropDownList,
        Date,
        Text
    }

    public enum TaskObjectTypeEnum
    {
        User,
        Computer,
        Application
    }

    public enum TaskValuesTemplateEnum
    {
        [Description("Readiness (NNSFC)")]
        ReadinessNnsfc,
        [Description("Readiness (NNSFC) with due date")]
        ReadinessNnsfcWithDueDate,
        [Description("Readiness (NNSFC) with due date & owner")]
        ReadinessNnsfcWithDueDateOwner,
        [Description("No readiness (NNSFC)")]
        NoReadinessNnsfc,
        [Description("No readiness (NNSFC) with due date")]
        NoReadinessNnsfcWithDueDate,
        [Description("No readiness (NNSFC) with due date & owner")]
        NoReadinessNnsfcWithDueDateOwner,
        [Description("No readiness (Off/On)")]
        NoReadinessOffOn,
        [Description("No readiness (No/Yes)")]
        NoReadinessNoYes,
        [Description("No readiness (NA/No/Yes)")]
        NoReadinessNaNoYes,
        [Description("No readiness (NA/Enabled/Disabled)")]
        NoReadinessNaEnabledDisabled,
        [Description("Self Service Screen Confirm")]
        SelfServiceScreenConfirm,
        None
    }
}