using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskProperties_DetailsDto
    {
        public ValueTypeUpdateEnum ValueType;
        public bool TaskHaADueDate { get; set; }
        public string DateModeString { get; set; }
        public DateModeEnum DateMode;
        public string TextModeString { get; set; }
        public TextModeEnum TextMode;
        public string TaskProjectRoleString { get; set; }
        public TaskProjectRoleEnum TaskProjectRole;
        public bool TaskImpactsReadiness { get; set; }
        public bool TaskHasAnOwner { get; set; }
        public bool ShowDetails { get; set; }
        public bool ProjectObject { get; set; }
        public bool GroupTaskDashboard { get; set; }
        public bool BulkUpdate { get; set; }
        public bool SelfService { get; set; }
    }

    public enum ValueTypeUpdateEnum
    {
        Radiobutton,
        DropDownList,
        Date,
        Text
    }

    public enum DateModeEnum
    {
        [Description("Date Only")]
        DateOnly,
        [Description("Date & Time")]
        DateTime
    }

    public enum TextModeEnum
    {
        [Description("Single Line")]
        SingleLine,
        [Description("Multiple Line")]
        MultipleLine
    }

    public enum TaskProjectRoleEnum
    {
        [Description("Self Service Enabled (Computer mode)")]
        SelfServiceEnabledComputerMode,
        [Description("Readiness (NNSFC with due date & owner)")]
        ReadinessNnsfcWithDueDateOwner,
        Workflow,
        [Description("Email Notifications (User)")]
        EmailNotificationsUser,
        [Description("Self Service Applications List Completed (User mode)")]
        SelfServiceApplicationsListCompletedUserMode,
        [Description("Self Service Applications List Enabled (User mode)")]
        SelfServiceApplicationsListEnabledUserMode,
        [Description("Self Service Computer Ownership Completed (User mode)")]
        SelfServiceComputerOwnershipCompletedUserMode,
        [Description("Self Service Applications List Enabled (User mode)")]
        SelfServiceComputerOwnershipEnabledUserMode,
        [Description("Self Service Department & Location Completed (User mode)")]
        SelfServiceDepartmentLocationCompletedUserMode,
        [Description("Self Service Department & Location Enabled (User mode)")]
        SelfServiceDepartmentLocationEnabledUserMode,
        [Description("Completed Date")]
        CompletedDate,
        [Description("Forecast Date")]
        ForecastDate,
        [Description("Migrated Date")]
        MigratedDate,
        [Description("Scheduled Date")]
        ScheduledDate,
        [Description("Self Service Applications List Completed Date  (Computer mode)")]
        SelfServiceApplicationsListCompletedDateComputerMode,
        [Description("Self Service Computer Ownership Completed Date  (Computer mode)")]
        SelfServiceComputerOwnershipCompletedDateComputerMode,
        [Description("Self Service Department & Location Completed Date  (Computer mode)")]
        SelfServiceDepartmentLocationCompletedDateComputerMode,
        [Description("Self Service Other Options 1 Completed Date  (Computer mode)")]
        SelfServiceOtherOptions1CompletedDateComputerMode,
        [Description("Self Service Other Options 2 Completed Date  (Computer mode)")]
        SelfServiceOtherOptions2CompletedDateComputerMode,
        [Description("Self Service Project Date Completed Date  (Computer mode)")]
        SelfServiceProjectDateCompletedDateComputerMode,
        [Description("Target Date")]
        TargetDate,
        None
    }
}