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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.UsersDetails.Tabs.Projects
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("UsersDetails_Projects_EvergreenDetails", Description="\tRuns related tests for Projects > Evergreen Details tab on Users Details page", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\UsersDetails\\Tabs\\Projects\\UsersDetai" +
        "ls_Projects_EvergreenDetails.feature", SourceLine=0)]
    public partial class UsersDetails_Projects_EvergreenDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "UsersDetails_Projects_EvergreenDetails.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UsersDetails_Projects_EvergreenDetails", "\tRuns related tests for Projects > Evergreen Details tab on Users Details page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatErrorMessageIsDisplayedOnTheObjectDetailsPageIfEv" +
            "ergreenBucketChangedByAdminUser", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "ProjectDetailsTab",
                "DAS20323",
                "DAS20382",
                "Cleanup",
                "Wormhole"}, SourceLine=9)]
        public virtual void EvergreenJnr_UsersList_CheckThatErrorMessageIsDisplayedOnTheObjectDetailsPageIfEvergreenBucketChangedByAdminUser()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "ProjectDetailsTab",
                    "DAS20323",
                    "DAS20382",
                    "Cleanup",
                    "Wormhole"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatErrorMessageIsDisplayedOnTheObjectDetailsPageIfEv" +
                    "ergreenBucketChangedByAdminUser", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ProjectDetailsTab",
                        "DAS20323",
                        "DAS20382",
                        "Cleanup",
                        "Wormhole"});
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
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3299 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table3299.AddRow(new string[] {
                            "TestAnalysisEditor",
                            "qa111111"});
#line 12
  testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table3299, "When ");
#line hidden
#line 15
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.When("User navigates to the \'User\' details page for \'00BDBAEA57334C7C8F4\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("Details page for \'00BDBAEA57334C7C8F4\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3300 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table3300.AddRow(new string[] {
                            "Evergreen Bucket",
                            "Evergreen"});
#line 19
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table3300, "Then ");
#line hidden
#line 22
 testRunner.When("User clicks on edit button for \'Evergreen Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.When("User selects \'Manchester\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("\'The selected objects will be moved to Manchester\' text is displayed on inline ti" +
                        "p banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.When("User navigates to \'evergreen/#/user/87443/projects/evergreen\' URL in a new tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.When("User clicks on edit button for \'Evergreen Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.When("User selects \'Birmingham\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("\'The selected objects will be moved to Birmingham, you will no longer be able to " +
                        "edit these objects\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.When("User switches to previous tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("\'You no longer has the permission to edit this User\' text is displayed on inline " +
                        "error banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3301 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table3301.AddRow(new string[] {
                            "Evergreen Bucket",
                            "Birmingham"});
#line 35
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table3301, "Then ");
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
