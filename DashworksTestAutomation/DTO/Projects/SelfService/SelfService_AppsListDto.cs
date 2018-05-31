using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_AppsListDto
    {
        public bool ShowThisScreen { get; set; }
        public bool ShowCoreApps { get; set; }
        public bool ShowTargetStateReadiness { get; set; }
        public bool ShowRequiredColumnAndSticky { get; set; }
        public bool ShowOnlyApplication { get; set; }
        public bool AllowUsersToAddANote { get; set; }
        public ViewEnum View;
        //TODO Additional Tasks
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
        public ProjectDto Project { get; set; }

        public SelfService_AppsListDto()
        {
            if (Project.ProjectType.Equals(ProjectTypeEnum.ComputerScheduledProject))
            {
                View = ViewEnum.ComparisonConsolidated;
            }
            if (Project.ProjectType.Equals(ProjectTypeEnum.MailboxScheduledProject))
            {
                View = ViewEnum.TargetState;
            }
        }
    }

    public enum ViewEnum
    {
        [Description("Comparison, Expanded")]
        ComparisonExpanded,
        [Description("Comparison, Consolidated")]
        ComparisonConsolidated,
        [Description("Current State, Consolidated")]
        CurrentStateConsolidated,
        [Description("Target State, Consolidated")]
        TargetStateConsolidated,
        Comparison,
        [Description("Current State")]
        CurrentState,
        [Description("Target State")]
        TargetState,
    }
}