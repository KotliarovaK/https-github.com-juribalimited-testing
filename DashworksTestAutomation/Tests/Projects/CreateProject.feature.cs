﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.Projects
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateProject")]
    public partial class CreateProjectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateProject", "\tRuns Project related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Projects_CreateProject")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("CreateProject")]
        public virtual void Projects_CreateProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Projects_CreateProject", new string[] {
                        "Projects",
                        "CreateProject"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to Projects link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ProjectShortName",
                        "ProjectDescription",
                        "ProjectType"});
            table1.AddRow(new string[] {
                        "TestProject",
                        "Test",
                        "Test",
                        "Computer Scheduled Project"});
            testRunner.When("User creates Project", ((string)(null)), table1, "When ");
            testRunner.Then("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowOriginalColumn",
                        "IncludeSiteName",
                        "NotApplicableApplications",
                        "InstalledApplications",
                        "EntitledApplications",
                        "TaskEmailCcEmailAddress",
                        "TaskEmailBccEmailAddress",
                        "StartDate",
                        "EndDate"});
            table2.AddRow(new string[] {
                        "true",
                        "true",
                        "true",
                        "true",
                        "true",
                        "Test@test.com",
                        "Test@test.com",
                        "8 May 2012",
                        "10 Apr 2018"});
            testRunner.When("User updating Details page", ((string)(null)), table2, "When ");
            testRunner.And("User navigate to \"Request Types\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Manage Request Types\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Request Type\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table3.AddRow(new string[] {
                        "TestRequestType",
                        "Test"});
            testRunner.Then("User create Request Type", ((string)(null)), table3, "Then ");
            testRunner.When("User navigate to \"Categories\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Categories\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Category\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table4.AddRow(new string[] {
                        "TestCategory",
                        "Test"});
            testRunner.Then("User create Category", ((string)(null)), table4, "Then ");
            testRunner.When("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Stages\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Stage\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "StageName"});
            table5.AddRow(new string[] {
                        "AAA Test"});
            testRunner.Then("User create Stage", ((string)(null)), table5, "Then ");
            testRunner.When("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Tasks\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Task\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Help",
                        "ValueType",
                        "TaskValuesTemplateCheckbox"});
            table6.AddRow(new string[] {
                        "TestTask",
                        "Test",
                        "Radiobutton",
                        "false"});
            testRunner.Then("User create Task for \"AAA Test\" Stage", ((string)(null)), table6, "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Teams\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Team\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "TeamName",
                        "ShortDescription"});
            table7.AddRow(new string[] {
                        "AAA TestTeam",
                        "Test"});
            testRunner.Then("User create Team", ((string)(null)), table7, "Then ");
            testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Groups\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Group\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "GroupName"});
            table8.AddRow(new string[] {
                        "TestGroup"});
            testRunner.Then("User create Group", ((string)(null)), table8, "Then ");
            testRunner.When("User navigate to \"Mail Templates\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Mail Templates\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Mail Template\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "GroupName",
                        "Description",
                        "SubjectLine",
                        "BodyText"});
            table9.AddRow(new string[] {
                        "TestMailTemplate",
                        "Test",
                        "Test",
                        "Test"});
            testRunner.Then("User create Mail Template", ((string)(null)), table9, "Then ");
            testRunner.When("User navigate to \"News\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage News\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Text"});
            table10.AddRow(new string[] {
                        "TestGroup",
                        "Test"});
            testRunner.And("User updating News page", ((string)(null)), table10, "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Projects_checkHowManyGroupInATeam")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("CreateProject")]
        [NUnit.Framework.CategoryAttribute("Teams")]
        public virtual void Projects_CheckHowManyGroupInATeam()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Projects_checkHowManyGroupInATeam", new string[] {
                        "Projects",
                        "CreateProject",
                        "Teams"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to Projects link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ProjectShortName",
                        "ProjectDescription",
                        "ProjectType"});
            table11.AddRow(new string[] {
                        "TestProject",
                        "Test",
                        "Test",
                        "Computer Scheduled Project"});
            testRunner.When("User creates Project", ((string)(null)), table11, "When ");
            testRunner.Then("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Teams\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Team\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "TeamName",
                        "ShortDescription"});
            table12.AddRow(new string[] {
                        "AAA TestTeam",
                        "Test"});
            testRunner.Then("User create Team", ((string)(null)), table12, "Then ");
            testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Groups\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Group\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "GroupName",
                        "Owned By Team"});
            table13.AddRow(new string[] {
                        "TestGroup",
                        "AAA TestTeam"});
            testRunner.Then("User create Group", ((string)(null)), table13, "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Teams\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("groups is displayed in the \"AAA TestTeam\" team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Projects_checkSelfServiceandCapacityTabs")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("CreateProject")]
        [NUnit.Framework.CategoryAttribute("Teams")]
        public virtual void Projects_CheckSelfServiceandCapacityTabs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Projects_checkSelfServiceandCapacityTabs", new string[] {
                        "Projects",
                        "CreateProject",
                        "Teams"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to Projects link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ProjectShortName",
                        "ProjectDescription",
                        "ProjectType"});
            table14.AddRow(new string[] {
                        "TestProject",
                        "Test",
                        "Test",
                        "Computer Scheduled Project"});
            testRunner.When("User creates Project", ((string)(null)), table14, "When ");
            testRunner.Then("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Self Service\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Self Service\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User update Details on Self Service tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User navigate to \"\" button on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
