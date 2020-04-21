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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ApplicationsDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CapacityUnit_ApplicationsPage", Description="\tRuns related tests for Capacity Unit fields", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ApplicationsDetails\\Tabs\\Projects\\Pro" +
        "jectDetails\\CapacityUnit_ApplicationPage.feature", SourceLine=0)]
    public partial class CapacityUnit_ApplicationsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CapacityUnit_ApplicationPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacityUnit_ApplicationsPage", "\tRuns related tests for Capacity Unit fields", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatValueForCapacityUnitIsChangingSuccessfully" +
            "", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "ProjectDetailsTab",
                "DAS19538",
                "Cleanup",
                "Set_Default_Capacity_Unit"}, SourceLine=8)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatValueForCapacityUnitIsChangingSuccessfully()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "ProjectDetailsTab",
                    "DAS19538",
                    "Cleanup",
                    "Set_Default_Capacity_Unit"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatValueForCapacityUnitIsChangingSuccessfully" +
                    "", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "ProjectDetailsTab",
                        "DAS19538",
                        "Cleanup",
                        "Set_Default_Capacity_Unit"});
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
                TechTalk.SpecFlow.Table table2835 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "IsDefault",
                            "Project"});
                table2835.AddRow(new string[] {
                            "cu_DAS19538_3",
                            "DAS19538",
                            "false",
                            "USE ME FOR AUTOMATION(USR SCHDLD)"});
#line 10
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table2835, "When ");
#line hidden
#line 13
 testRunner.When("User navigates to the \'Application\' details page for the item with \'419\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("Details page for \'ACDSee 4.0\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User clicks on edit button for \'Capacity Unit\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("\'MOVE\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("User selects \'cu_DAS19538_3\' option from \'Capacity Unit\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("\'Application successfully moved to cu_DAS19538_3\' text is displayed on inline suc" +
                        "cess banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2836 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2836.AddRow(new string[] {
                            "Capacity Unit",
                            "cu_DAS19538_3"});
#line 24
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2836, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatCriticalityFieldsAreDisplayedAndWorkingCor" +
            "rectly", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS18607",
                "DAS19651",
                "DAS19318"}, SourceLine=28)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatCriticalityFieldsAreDisplayedAndWorkingCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS18607",
                    "DAS19651",
                    "DAS19318"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatCriticalityFieldsAreDisplayedAndWorkingCor" +
                    "rectly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS18607",
                        "DAS19651",
                        "DAS19318"});
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
 testRunner.When("User navigates to the \'Application\' details page for \'GogoTools version 2.1.0.9\' " +
                        "item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("Details page for \'GogoTools version 2.1.0.9\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2837 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2837.AddRow(new string[] {
                            "Criticality",
                            "Uncategorised"});
#line 33
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2837, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2838 = new TechTalk.SpecFlow.Table(new string[] {
                            "Value"});
                table2838.AddRow(new string[] {
                            "Core"});
                table2838.AddRow(new string[] {
                            "Critical"});
                table2838.AddRow(new string[] {
                            "Important"});
                table2838.AddRow(new string[] {
                            "Not Important"});
                table2838.AddRow(new string[] {
                            "Uncategorised"});
#line 36
 testRunner.Then("following Values are displayed in the dropdown for the \'Criticality\' field:", ((string)(null)), table2838, "Then ");
#line hidden
#line 43
 testRunner.When("User selects \'Important\' in the dropdown for the \'Criticality\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("\'Criticality successfully changed\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2839 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2839.AddRow(new string[] {
                            "Criticality",
                            "Important"});
#line 46
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2839, "Then ");
#line hidden
#line 49
 testRunner.When("User selects \'Uncategorised\' in the dropdown for the \'Criticality\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2840 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2840.AddRow(new string[] {
                            "Criticality",
                            "Uncategorised"});
#line 50
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2840, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatAllFieldsAreAensitiveToSecurityRequirement" +
            "sForAnalysisEditorRole", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS18852",
                "DAS19651",
                "DAS19318",
                "Universe"}, SourceLine=54)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAllFieldsAreAensitiveToSecurityRequirementsForAnalysisEditorRole()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS18852",
                    "DAS19651",
                    "DAS19318",
                    "Universe"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAllFieldsAreAensitiveToSecurityRequirement" +
                    "sForAnalysisEditorRole", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS18852",
                        "DAS19651",
                        "DAS19318",
                        "Universe"});
#line 55
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
#line 56
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2841 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table2841.AddRow(new string[] {
                            "TestBucketAuto",
                            "123456"});
#line 57
  testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table2841, "When ");
#line hidden
#line 60
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.When("User navigates to the \'Application\' details page for \'ACDSee for Windows 95\' item" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("Details page for \'ACDSee for Windows 95\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2842 = new TechTalk.SpecFlow.Table(new string[] {
                            "Value"});
                table2842.AddRow(new string[] {
                            "TRUE"});
                table2842.AddRow(new string[] {
                            "FALSE"});
#line 64
 testRunner.Then("following Values are displayed in the dropdown for the \'In Catalog\' field:", ((string)(null)), table2842, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2843 = new TechTalk.SpecFlow.Table(new string[] {
                            "Value"});
                table2843.AddRow(new string[] {
                            "Core"});
                table2843.AddRow(new string[] {
                            "Critical"});
                table2843.AddRow(new string[] {
                            "Important"});
                table2843.AddRow(new string[] {
                            "Not Important"});
                table2843.AddRow(new string[] {
                            "Uncategorised"});
#line 68
 testRunner.Then("following Values are displayed in the dropdown for the \'Criticality\' field:", ((string)(null)), table2843, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2844 = new TechTalk.SpecFlow.Table(new string[] {
                            "Value"});
                table2844.AddRow(new string[] {
                            "TRUE"});
                table2844.AddRow(new string[] {
                            "FALSE"});
#line 75
 testRunner.Then("following Values are displayed in the dropdown for the \'Hide From End Users\' fiel" +
                        "d:", ((string)(null)), table2844, "Then ");
#line hidden
#line 79
 testRunner.When("User clicks on edit button for \'Evergreen Capacity Unit\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
