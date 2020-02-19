// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AssociationsFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AssociationsFunctionality3")]
    public partial class AssociationsFunctionality3Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AssociationsFunctionality3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssociationsFunctionality3", "\tRuns Associations Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
            "titledToDeviceFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18426")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Used on device", "Not entitled to device", "Not installed on device", "00BDM1JUR8IF419", "20040610sqlserverck", "UNKNOWN", "TRUE", "FALSE", null)]
        [NUnit.Framework.TestCaseAttribute("Entitled to device", "Installed on device", "Not used on device", "001BAQXT6JWFPI", "AddressGrabber Standard", "TRUE", "UNKNOWN", "TRUE", null)]
        [NUnit.Framework.TestCaseAttribute("Entitled to device", "Not installed on device", "Not used on device", "00BDM1JUR8IF419", "cdparanoia-libs", "UNKNOWN", "FALSE", "TRUE", null)]
        [NUnit.Framework.TestCaseAttribute("Installed on device", "Not entitled to device", "Not used on device", "00KWQ4J3WKQM0G", "Adobe Reader 6.0.1 - Fran?ais", "TRUE", "UNKNOWN", "FALSE", null)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter(string operator1, string operator2, string operator3, string hostname, string application, string installed, string used, string entitled, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilterInternal(operator1,operator2,operator3,hostname,application,installed,used,entitled,exampleTags);
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilterInternal(string operator1, string operator2, string operator3, string hostname, string application, string installed, string used, string entitled, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18426",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
                    "titledToDeviceFilter", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When(string.Format("User selects \'{0}\' option in \'Search associations\' autocomplete of Associations p" +
                        "anel", operator1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.When("User clicks Add And button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.When(string.Format("User selects \'{0}\' option in \'Search associations\' autocomplete of Associations p" +
                        "anel", operator2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.When("User clicks Add And button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.When(string.Format("User selects \'{0}\' option in \'Search associations\' autocomplete of Associations p" +
                        "anel", operator3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.When("User clicks content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", hostname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.When(string.Format("User enters \"{0}\" text in the Search field for \"Application\" column", application), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'Installed\' column", installed), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'Used\' column", used), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'Entitled\' column", entitled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18804")]
        [NUnit.Framework.TestCaseAttribute("Device Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application Key", null)]
        [NUnit.Framework.TestCaseAttribute("CPU Count", null)]
        [NUnit.Framework.TestCaseAttribute("CPU Count", null)]
        [NUnit.Framework.TestCaseAttribute("CPU Speed (GHz)", null)]
        [NUnit.Framework.TestCaseAttribute("HDD Count", null)]
        [NUnit.Framework.TestCaseAttribute("HDD Total Size (GB)", null)]
        [NUnit.Framework.TestCaseAttribute("Memory (GB)", null)]
        [NUnit.Framework.TestCaseAttribute("Monitor Count", null)]
        [NUnit.Framework.TestCaseAttribute("Network Card Count", null)]
        [NUnit.Framework.TestCaseAttribute("Sound Card Count", null)]
        [NUnit.Framework.TestCaseAttribute("Target Drive Free Space (GB)", null)]
        [NUnit.Framework.TestCaseAttribute("Video Card Count", null)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue(string filter, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValueInternal(filter,exampleTags);
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValueInternal(string filter, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18804"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
                    "NegativeValue", null, @__tags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 39
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                    "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        "-1"});
#line 45
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following valu" +
                        "e:", filter), ((string)(null)), table1, "When ");
#line 48
 testRunner.When("User clicks the Associations button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAn" +
            "dRunninList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18454")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAndRunninList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAndRunninListInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAndRunninListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAn" +
                    "dRunninList", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18454",
                        "Cleanup"});
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 70
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.When("User selects \'Entitled to device\' option in \'Search associations\' autocomplete of" +
                    " Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("User clicks on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("User removes \"App Vendor\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningLis" +
            "t")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18897")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningListInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningLis" +
                    "t", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18897",
                        "Cleanup"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 85
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.When("User selects \'Entitled to device\' option in \'Search associations\' autocomplete of" +
                    " Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.Then("All column headers are unique", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToA" +
            "llDeviceApplicationsPageFromSavedList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18447")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToAllDeviceApplicationsPageFromSavedList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToAllDeviceApplicationsPageFromSavedListInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToAllDeviceApplicationsPageFromSavedListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToA" +
                    "llDeviceApplicationsPageFromSavedList", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18447",
                        "Cleanup"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 96
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                    "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.When("User creates \'AssociationList18447\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.Then("Associations Button is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.Then("Associations panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

