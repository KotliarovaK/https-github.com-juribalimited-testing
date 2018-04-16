using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class DetailsDto
    {
        public string ProjectName { get; set; }
        public string ProjectShortName { get; set; }
        public string ProjectDescription { get; set; }
        public DefaultReadinessForOnboardedApplicationsEnum DefaultReadinessForOnboardedApplications;
        public DefaultValueForShowLinkedObjectsEnum DefaultValueForShowLinkedObjects;
        public DefaultViewForProjectObjectApplicationsTab1Enum DefaultViewForProjectObjectApplicationsTab1;
        public DefaultViewForProjectObjectApplicationsTab2Enum DefaultViewForProjectObjectApplicationsTab2;
        public DefaultValueForApplicationRationalizationEnum DefaultValueForApplicationRationalization;
        public bool ShowOriginalColumn { get; set; }
        public bool IncludeSiteName{ get; set; }
        public bool NotApplicableApplications { get; set; }
        public bool InstalledApplications { get; set; }
        public bool EntitledApplications { get; set; }
        public OnboardUsedApplicationsByAssociationToEnum OnboardUsedApplicationsByAssociationTo;
        public string MasterHtmlEmailTemplate { get; set; }
        public string Attachments { get; set; }
        public string TaskEmailCcEmailAddress { get; set; }
        public string TaskEmailBccEmailAddress { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public DetailsDto()
        {
            DefaultReadinessForOnboardedApplications =
                EnumExtensions.GetRandomValue<DefaultReadinessForOnboardedApplicationsEnum>();
            DefaultValueForShowLinkedObjects = EnumExtensions.GetRandomValue<DefaultValueForShowLinkedObjectsEnum>();
            DefaultViewForProjectObjectApplicationsTab1 =
                EnumExtensions.GetRandomValue<DefaultViewForProjectObjectApplicationsTab1Enum>();
            DefaultViewForProjectObjectApplicationsTab2 =
                EnumExtensions.GetRandomValue<DefaultViewForProjectObjectApplicationsTab2Enum>();
            DefaultValueForApplicationRationalization =
                EnumExtensions.GetRandomValue<DefaultValueForApplicationRationalizationEnum>();
            OnboardUsedApplicationsByAssociationTo =
                EnumExtensions.GetRandomValue<OnboardUsedApplicationsByAssociationToEnum>();
        }
    }

    public enum DefaultReadinessForOnboardedApplicationsEnum
    {
        [Description("Out Of Scope")]
        OutOfScope,
        Blue,
        [Description("Light Blue")]
        LightBlue,
        Red,
        Brown,
        Amber,
        [Description("Really Extremely Orange")]
        ReallyExtremelyOrange,
        Purple,
        Green,
        Grey,
        None
    }

    public enum DefaultValueForShowLinkedObjectsEnum
    {
        Yes,
        No
    }

    public enum DefaultViewForProjectObjectApplicationsTab1Enum
    {
        [Description("Current State")]
        CurrentState,
        [Description("Target State")]
        TargetState,
        Comparison
    }

    public enum DefaultViewForProjectObjectApplicationsTab2Enum
    {
        [Description("Group by Object")]
        GroupbyObject,
        Alphabetical,
        Consolidated,
        Readiness
    }

    public enum DefaultValueForApplicationRationalizationEnum
    {
        Retire,
        Keep,
        Uncategorized
    }

    public enum OnboardUsedApplicationsByAssociationToEnum
    {
        //Computer,
        User,
        [Description("Do not onboard")]
        DoNotOnboard
    }
}