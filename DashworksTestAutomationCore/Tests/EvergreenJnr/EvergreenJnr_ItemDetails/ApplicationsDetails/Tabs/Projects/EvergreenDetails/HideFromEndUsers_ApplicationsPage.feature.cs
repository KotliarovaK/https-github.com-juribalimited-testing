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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ApplicationsDetails.Tabs.Projects.EvergreenDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("HideFromEndUsers_ApplicationsPage", Description="\tRuns related tests for Hide From End Users field", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ApplicationsDetails\\Tabs\\Projects\\Eve" +
        "rgreenDetails\\HideFromEndUsers_ApplicationsPage.feature", SourceLine=0)]
    public partial class HideFromEndUsers_ApplicationsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "HideFromEndUsers_ApplicationsPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HideFromEndUsers_ApplicationsPage", "\tRuns related tests for Hide From End Users field", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatHideFromEndUserFieldsAreDisplayedAndWorkin" +
            "gCorrectly", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "HideFromEndUsers",
                "DAS18849",
                "DAS19753",
                "Universe"}, SourceLine=8)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatHideFromEndUserFieldsAreDisplayedAndWorkingCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "HideFromEndUsers",
                    "DAS18849",
                    "DAS19753",
                    "Universe"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatHideFromEndUserFieldsAreDisplayedAndWorkin" +
                    "gCorrectly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "HideFromEndUsers",
                        "DAS18849",
                        "DAS19753",
                        "Universe"});
#line 9
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
#line 10
 testRunner.When("User navigates to the \'Application\' details page for \'ACDSee for Windows 95\' item" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("Details page for \'ACDSee for Windows 95\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2816 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2816.AddRow(new string[] {
                            "Hide From End Users",
                            "FALSE"});
#line 13
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2816, "Then ");
#line hidden
#line 16
 testRunner.When("User selects \'TRUE\' in the dropdown for the \'Hide From End Users\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("\'Hide from end users successfully changed\' text is displayed on inline success ba" +
                        "nner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2817 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2817.AddRow(new string[] {
                            "Hide From End Users",
                            "TRUE"});
#line 19
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2817, "Then ");
#line hidden
#line 22
 testRunner.When("User selects \'FALSE\' in the dropdown for the \'Hide From End Users\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("\'Hide from end users successfully changed\' text is displayed on inline success ba" +
                        "nner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2818 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2818.AddRow(new string[] {
                            "Hide From End Users",
                            "FALSE"});
#line 24
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2818, "Then ");
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
