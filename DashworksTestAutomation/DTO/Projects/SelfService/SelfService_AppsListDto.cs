using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_AppsListDto
    {
        //TODO add a language?
        public bool ShowThisScreen;
        public bool ShowCoreApps;
        public bool ShowTargetStateReadiness;
        public bool ShowRequiredColumnAndSticky;
        public bool ShowOnlyApplication;
        public bool AllowUsersToAddANote;
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