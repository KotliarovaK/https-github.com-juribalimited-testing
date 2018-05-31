using System.ComponentModel;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Steps.Projects;

namespace DashworksTestAutomation.DTO.Projects
{
    public class DetailsDto
    {
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
        public string TaskEmailCcEmailAddress { get; set; }
        public string TaskEmailBccEmailAddress { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public OnboardMailboxUsersWithPermissionsEnum OnboardMailboxUsersWithPermissions;
        public ProjectDto Project { get; set; }

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
            if (Project.ProjectType.Equals(ProjectTypeEnum.ComputerScheduledProject))
            {
                OnboardUsedApplicationsByAssociationTo = OnboardUsedApplicationsByAssociationToEnum.Computer;
            }
            if (Project.ProjectType.Equals(ProjectTypeEnum.MailboxScheduledProject))
            {
                OnboardUsedApplicationsByAssociationTo = OnboardUsedApplicationsByAssociationToEnum.User;
                OnboardMailboxUsersWithPermissions =
                    EnumExtensions.GetRandomValue<OnboardMailboxUsersWithPermissionsEnum>();
            }
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
        Uncategorised
    }

    public enum OnboardUsedApplicationsByAssociationToEnum
    {
        Computer,
        User,
        [Description("Do not onboard")]
        DoNotOnboard
    }

    public enum OnboardMailboxUsersWithPermissionsEnum
    {
        [Description("All Permissions")]
        AllPermissions,
        [Description("Only Permissions in Data")]
        OnlyPermissionsInData
    }
}