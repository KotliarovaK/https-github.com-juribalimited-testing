﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ApplicationsDetails.Tabs.Projects
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AppDetails_Projects_EvergreenIncomingApps.feature", Description="\tRuns related tests for Projects > Evergreen Incoming Apps tab", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ApplicationsDetails\\Tabs\\Projects\\App" +
        "Details_Projects_EvergreenIncomingApps.feature", SourceLine=0)]
    public partial class AppDetails_Projects_EvergreenIncomingApps_FeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AppDetails_Projects_EvergreenIncomingApps.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AppDetails_Projects_EvergreenIncomingApps.feature", "\tRuns related tests for Projects > Evergreen Incoming Apps tab", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatTableOnEvergreenIncomingAppsTabIsDisplayed" +
            "Correctly", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ProjectsTab",
                "DAS19242",
                "Not_Ready"}, SourceLine=9)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTableOnEvergreenIncomingAppsTabIsDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ProjectsTab",
                    "DAS19242",
                    "Not_Ready"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTableOnEvergreenIncomingAppsTabIsDisplayed" +
                    "Correctly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ProjectsTab",
                        "DAS19242",
                        "Not_Ready"});
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 11
 testRunner.When("User navigates to the \'Application\' details page for the item with \'1\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("Details page for \'Python 2.2a4\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.When("User navigates to the \'Evergreen Incoming Apps\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("\'Evergreen Incoming Apps\' left submenu item with \'4\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.Then("Counter shows \"4\" found rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2849 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2849.AddRow(new string[] {
                            "Application"});
                table2849.AddRow(new string[] {
                            "Vendor"});
                table2849.AddRow(new string[] {
                            "Version"});
                table2849.AddRow(new string[] {
                            "Compliance"});
                table2849.AddRow(new string[] {
                            "In Catalog"});
                table2849.AddRow(new string[] {
                            "Criticality"});
                table2849.AddRow(new string[] {
                            "Hide From End Users"});
#line 17
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table2849, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersValueIsAdjustedOnTheEvergr" +
            "eenIncomingAppsTabAccordingToTheChangesMadeOnTheAppropriateApplicationDetailsPag" +
            "e", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ProjectsTab",
                "DAS20026",
                "Not_Ready"}, SourceLine=28)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersValueIsAdjustedOnTheEvergreenIncomingAppsTabAccordingToTheChangesMadeOnTheAppropriateApplicationDetailsPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ProjectsTab",
                    "DAS20026",
                    "Not_Ready"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersValueIsAdjustedOnTheEvergr" +
                    "eenIncomingAppsTabAccordingToTheChangesMadeOnTheAppropriateApplicationDetailsPag" +
                    "e", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ProjectsTab",
                        "DAS20026",
                        "Not_Ready"});
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 30
 testRunner.When("User navigates to the \'Application\' details page for the item with \'1\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("Details page for \'Python 2.2a4\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.When("User selects \'TRUE\' in the dropdown for the \'In Catalog\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.When("User selects \'TRUE\' in the dropdown for the \'Hide From End Users\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.When("User navigates to the \'Evergreen Incoming Apps\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.When("User enters \"(.*)\" text in the Search field for \"Application\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("\'TRUE\' content is displayed in the \'In Catalog\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Then("\'TRUE\' content is displayed in the \'Hide From End Users\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_ChecksThatIncomingAppCounterIsDynamicallyUpdatedAft" +
            "erChangingTheRationalisationOfTheTargetAppToTheForwardPathValue", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ProjectsTab",
                "DAS20071",
                "Not_Ready"}, SourceLine=42)]
        public virtual void EvergreenJnr_ApplicationsList_ChecksThatIncomingAppCounterIsDynamicallyUpdatedAfterChangingTheRationalisationOfTheTargetAppToTheForwardPathValue()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ProjectsTab",
                    "DAS20071",
                    "Not_Ready"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_ChecksThatIncomingAppCounterIsDynamicallyUpdatedAft" +
                    "erChangingTheRationalisationOfTheTargetAppToTheForwardPathValue", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ProjectsTab",
                        "DAS20071",
                        "Not_Ready"});
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 44
 testRunner.When("User navigates to the \'Application\' details page for the item with \'1\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("Details page for \'Python 2.2a4\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.When("User navigates to the \'Evergreen Incoming Apps\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("\'Evergreen Incoming Apps\' left submenu item with \'4\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.Then("Counter shows \"4\" found rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.When("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.When("User enters \'Corel WordPerfect\' in the \'Application\' autocomplete field and selec" +
                        "ts \'Corel WordPerfect 8 (327)\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.When("User navigates to the \'Evergreen Incoming Apps\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("\'Evergreen Incoming Apps\' left submenu item with \'0\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.Then("\'No Evergreen incoming apps found for this application\' message is displayed on e" +
                        "mpty greed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOn" +
            "EvergreenIncomingAppsTab", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ProjectsTab",
                "DAS20286",
                "Not_Ready"}, SourceLine=61)]
        public virtual void EvergreenJnr_ApplicationsList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOnEvergreenIncomingAppsTab()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ProjectsTab",
                    "DAS20286",
                    "Not_Ready"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOn" +
                    "EvergreenIncomingAppsTab", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ProjectsTab",
                        "DAS20286",
                        "Not_Ready"});
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 63
 testRunner.When("User navigates to the \'Application\' details page for the item with \'839\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("Details page for \'Access 95\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.When("User navigates to the \'Evergreen Incoming Apps\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("User enters \"11.2.5058.0\" text in the Search field for \"Version\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("\'Empty\' content is displayed in the \'Application\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
