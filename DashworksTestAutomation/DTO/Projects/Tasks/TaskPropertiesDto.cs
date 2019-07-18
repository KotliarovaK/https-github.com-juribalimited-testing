﻿using System.ComponentModel;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskPropertiesDto
    {
        private string Id;
        public string ProjectId { get; set; }

        public string Name { get; set; }
        public string Help { get; set; }
        public string StagesNameString { get; set; }
        public string Stages { get; set; }
        public string TaskTypeString { get; set; }
        public TaskTypeEnum TaskType;
        public string ValueTypeString { get; set; }
        public ValueTypeEnum ValueType;
        public string ObjectTypeString { get; set; }
        public TaskObjectTypeEnum ObjectType;
        public string TaskValuesTemplateString { get; set; }
        public TaskValuesTemplateEnum TaskValuesTemplate;
        public bool ApplyToAllCheckbox { get; set; }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
                Id = DatabaseHelper.GetTaskId(this);

            return Id;
        }
    }

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
        Application,
        Mailbox
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