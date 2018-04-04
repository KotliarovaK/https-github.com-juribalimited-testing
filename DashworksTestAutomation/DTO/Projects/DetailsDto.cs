using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class DetailsDto
    {
        public DefaultReadinessForOnboardedApplicationsEnum DefaultReadinessForOnboardedApplications;
        public DefaultValueForShowLinkedObjectsEnum DefaultValueForShowLinkedObjects;
        public DefaultViewForProjectObjectApplicationsTab1Enum DefaultViewForProjectObjectApplicationsTab1;
        public DefaultViewForProjectObjectApplicationsTab2Enum DefaultViewForProjectObjectApplicationsTab2;
        public DefaultValueForApplicationRationalizationEnum DefaultValueForApplicationRationalization;
        public bool ShowOriginalApplicationColumnOnApplicationDashboards { get; set; }
        public bool IncludeSiteNameInApplicationName { get; set; }
        public bool OnboardNotApplicableApplications { get; set; }
        public bool OnboardInstalledApplicationsByAssociation { get; set; }
        public bool OnboardEntitledApplicationsByAssociation { get; set; }
        public OnboardUsedApplicationsByAssociationToEnum OnboardUsedApplicationsByAssociationTo;
        //public string MasterHTMLEmailTemplate { get; set; }
        //Attachments
        public string TaskEmailCcEmailAddress { get; set; }
        public string TaskEmailBccEmailAddress { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
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
        Computer,
        User,
        [Description("Do not onboard")]
        DoNotOnboard
    }
}