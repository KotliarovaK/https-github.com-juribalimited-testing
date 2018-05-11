using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_AppsListDto
    {
        //TODO add a language?
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

        public SelfService_AppsListDto()
        {
            View = EnumExtensions.GetRandomValue<ViewEnum>();
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
        TargetStateConsolidated
    }
}