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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ApplicationsDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TopBar")]
    public partial class TopBarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TopBar.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TopBar", "\tRuns Application Item Details Top Bar  related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyO" +
            "nApplicationsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS15552")]
        [NUnit.Framework.CategoryAttribute("DAS16921")]
        [NUnit.Framework.CategoryAttribute("DAS16743")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPageInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyO" +
                    "nApplicationsPage", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS15552",
                        "DAS16921",
                        "DAS16743"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'Application\' details page for \'ABBYY FineReader 8.0 Profes" +
                    "sional Edition\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \'ABBYY FineReader 8.0 Professional Edition\' item is displayed to" +
                    " the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table1.AddRow(new string[] {
                        "Overall Compliance"});
#line 12
 testRunner.Then("following items are displayed in the top bar:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnA" +
            "pplicationsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS14975")]
        [NUnit.Framework.CategoryAttribute("DAS15333")]
        [NUnit.Framework.CategoryAttribute("DAS16762")]
        [NUnit.Framework.CategoryAttribute("DAS17166")]
        [NUnit.Framework.CategoryAttribute("DAS17075")]
        [NUnit.Framework.CategoryAttribute("DAS17355")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPageInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnA" +
                    "pplicationsPage", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS14975",
                        "DAS15333",
                        "DAS16762",
                        "DAS17166",
                        "DAS17075",
                        "DAS17355"});
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 18
 testRunner.When("User navigates to the \'Application\' details page for \'ABBYY FineReader 8.0 Profes" +
                    "sional Edition\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("Details page for \'ABBYY FineReader 8.0 Professional Edition\' item is displayed to" +
                    " the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User selects \'Windows 7 Migration (Computer Scheduled Project)\' in the \'Item Deta" +
                    "ils Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComplianceItems"});
            table2.AddRow(new string[] {
                        "Overall Readiness"});
            table2.AddRow(new string[] {
                        "App Readiness"});
            table2.AddRow(new string[] {
                        "Task Readiness"});
            table2.AddRow(new string[] {
                        "Workflow"});
#line 21
 testRunner.Then("following items are displayed in the top bar:", ((string)(null)), table2, "Then ");
#line 27
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                    "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComplianceItems"});
            table3.AddRow(new string[] {
                        "Overall Readiness"});
            table3.AddRow(new string[] {
                        "App Readiness"});
            table3.AddRow(new string[] {
                        "Task Readiness"});
#line 28
 testRunner.Then("following items are displayed in the top bar:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavoc" +
            "BigDataProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17002")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProjectInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavoc" +
                    "BigDataProject", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17002"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 36
 testRunner.When("User navigates to the \'Application\' details page for \'ACD Display 3.4\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("Details page for \'ACD Display 3.4\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When("User selects \'Havoc (Big Data)\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table4.AddRow(new string[] {
                        "Readiness",
                        "RED"});
            table4.AddRow(new string[] {
                        "App Readiness",
                        "RED"});
#line 41
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComplianceItems",
                        "ColorName"});
            table5.AddRow(new string[] {
                        "Overall Readiness",
                        "RED"});
            table5.AddRow(new string[] {
                        "App Readiness",
                        "RED"});
#line 45
 testRunner.Then("following items and colors are displayed in the top bar:", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDis" +
            "playedInAlphabeticalOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16698")]
        [NUnit.Framework.CategoryAttribute("DAS17005")]
        [NUnit.Framework.CategoryAttribute("DAS15347")]
        [NUnit.Framework.CategoryAttribute("DAS16668")]
        [NUnit.Framework.CategoryAttribute("DAS16903")]
        [NUnit.Framework.CategoryAttribute("DAS16907")]
        [NUnit.Framework.CategoryAttribute("DAS16857")]
        [NUnit.Framework.CategoryAttribute("DAS17005")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrderInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDis" +
                    "playedInAlphabeticalOrder", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16698",
                        "DAS17005",
                        "DAS15347",
                        "DAS16668",
                        "DAS16903",
                        "DAS16907",
                        "DAS16857",
                        "DAS17005"});
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 52
 testRunner.When("User navigates to the \'Application\' details page for \'7zip\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("Details page for \'7zip\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("dropdown is not opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.Then("options are sorted in alphabetical order in the \'Item Details Project\' dropdown o" +
                    "n item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("User selects \'Computer Scheduled Test (Jo)\' in the \'Item Details Project\' dropdow" +
                    "n with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("dropdown is not opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.Then("options are sorted in alphabetical order in the \'Item Details Project\' dropdown o" +
                    "n item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverall" +
            "ComplianceFromTopBarInEvergreenMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16857")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenModeInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverall" +
                    "ComplianceFromTopBarInEvergreenMode", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16857"});
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 62
 testRunner.When("User navigates to the \'Application\' details page for \'7zip\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("Details page for \'7zip\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.When("User navigates to the \'Application\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table6.AddRow(new string[] {
                        "Compliance",
                        "UNKNOWN"});
#line 65
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComplianceItems",
                        "ColorName"});
            table7.AddRow(new string[] {
                        "Overall Compliance",
                        "UNKNOWN"});
#line 68
 testRunner.Then("following items and colors are displayed in the top bar:", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverall" +
            "ComplianceFromTopBarInProjectMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16857")]
        [NUnit.Framework.CategoryAttribute("DAS16928")]
        [NUnit.Framework.CategoryAttribute("DAS18405")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectModeInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverall" +
                    "ComplianceFromTopBarInProjectMode", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16857",
                        "DAS16928",
                        "DAS18405"});
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 74
 testRunner.When("User navigates to the \'Application\' details page for \'7zip\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("Details page for \'7zip\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("User selects \'Devices Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                    "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table8.AddRow(new string[] {
                        "Readiness",
                        "GREY"});
#line 79
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table8, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComplianceItems",
                        "ColorName"});
            table9.AddRow(new string[] {
                        "Overall Readiness",
                        "GREY"});
#line 82
 testRunner.Then("following items and colors are displayed in the top bar:", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

