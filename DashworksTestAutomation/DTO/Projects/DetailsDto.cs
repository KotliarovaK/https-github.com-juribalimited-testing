using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.ModelBinding;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Steps.Projects;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.DTO.Projects
{
    public class DetailsDto
    {
        public Dictionary<int, string> ReadinessForOnboardedApplications;
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

        public DetailsDto()
        {
            ReadinessForOnboardedApplications = new Dictionary<int, string>();
            DefaultValueForShowLinkedObjects = EnumExtensions.GetRandomValue<DefaultValueForShowLinkedObjectsEnum>();
            DefaultViewForProjectObjectApplicationsTab1 =
                EnumExtensions.GetRandomValue<DefaultViewForProjectObjectApplicationsTab1Enum>();
            DefaultViewForProjectObjectApplicationsTab2 =
                EnumExtensions.GetRandomValue<DefaultViewForProjectObjectApplicationsTab2Enum>();
            DefaultValueForApplicationRationalization =
                EnumExtensions.GetRandomValue<DefaultValueForApplicationRationalizationEnum>();
        }
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
        //Uncategorized
    }

    public enum OnboardUsedApplicationsByAssociationToEnum
    {
        User,
        Computer,
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