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
                        "TestProjectName",
                        "TestText",
                        "TestText",
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
            testRunner.When("User updates the Details page", ((string)(null)), table2, "When ");
            testRunner.And("User navigate to \"Request Types\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Manage Request Types\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Request Type\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table3.AddRow(new string[] {
                        "TestRequestTypeName",
                        "TestText"});
            testRunner.Then("User create Request Type", ((string)(null)), table3, "Then ");
            testRunner.When("User navigate to \"Categories\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Categories\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Category\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table4.AddRow(new string[] {
                        "TestCategoryName",
                        "TestText"});
            testRunner.Then("User create Category", ((string)(null)), table4, "Then ");
            testRunner.When("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Stages\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Stage\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "StageName"});
            table5.AddRow(new string[] {
                        "TestStageName"});
            testRunner.Then("User create Stage", ((string)(null)), table5, "Then ");
            testRunner.When("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Tasks\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Task\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Help",
                        "TaskType",
                        "ValueType",
                        "TaskValuesTemplateCheckbox"});
            table6.AddRow(new string[] {
                        "TestTaskName",
                        "TestText",
                        "Normal",
                        "Radiobutton",
                        "true"});
            testRunner.Then("User create Task", ((string)(null)), table6, "Then ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ValueType",
                        "TaskHaADueDate",
                        "TaskImpactsReadiness",
                        "TaskHasAnOwner",
                        "ShowDetails",
                        "ProjectObject",
                        "BulkUpdate",
                        "SelfService"});
            table7.AddRow(new string[] {
                        "Radiobutton",
                        "true",
                        "false",
                        "false",
                        "false",
                        "true",
                        "false",
                        "true"});
            testRunner.Then("User updates the Task page", ((string)(null)), table7, "Then ");
            testRunner.Then("User publishes the task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Teams\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Team\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "TeamName",
                        "ShortDescription"});
            table8.AddRow(new string[] {
                        "001 TestTeamName",
                        "TestText"});
            testRunner.Then("User create Team", ((string)(null)), table8, "Then ");
            testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Groups\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Group\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "GroupName"});
            table9.AddRow(new string[] {
                        "TestGroupName"});
            testRunner.Then("User create Group", ((string)(null)), table9, "Then ");
            testRunner.When("User navigate to \"Mail Templates\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Mail Templates\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Mail Template\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "SubjectLine",
                        "BodyText"});
            table10.AddRow(new string[] {
                        "TestMailTemplateName",
                        "TestText",
                        "TestText",
                        "TestText"});
            testRunner.Then("User create Mail Template", ((string)(null)), table10, "Then ");
            testRunner.When("User navigate to \"News\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage News\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Text"});
            table11.AddRow(new string[] {
                        "TestTitle",
                        "TestText"});
            testRunner.And("User updating News page", ((string)(null)), table11, "And ");
            testRunner.When("User navigate to \"Self Service\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Self Service\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "EnableSelfServicePortal",
                        "AllowAnonymousUsers",
                        "ThisProjectDefault",
                        "ModeUser",
                        "ModeComputer",
                        "NoLink",
                        "DashworksProjectHomepage",
                        "CustomUrl"});
            table12.AddRow(new string[] {
                        "false",
                        "false",
                        "true",
                        "false",
                        "true",
                        "true",
                        "false",
                        "false"});
            testRunner.Then("User updates the Details on Self Service tab", ((string)(null)), table12, "Then ");
            testRunner.When("User navigate to \"Welcome\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "AllowToSearchForAnotherUser",
                        "AllowToChangeLanguage",
                        "ShowProjectSelector",
                        "ShowMoreDetailsLink",
                        "Type",
                        "PageDescription",
                        "ProjectName"});
            table13.AddRow(new string[] {
                        "true",
                        "false",
                        "false",
                        "true",
                        "Attribute",
                        "TestText",
                        "ProjectName"});
            testRunner.Then("User updates the Welcome on Self Service tab", ((string)(null)), table13, "Then ");
            testRunner.When("User navigate to \"Computer Ownership\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowScreen",
                        "ShowComputers",
                        "ShowCategory",
                        "AllowUsersToSearch",
                        "AllowUsersToSetPrimary",
                        "AllowUsersToAddANote",
                        "LimitMaximum",
                        "LimitMinimum",
                        "PageDescription"});
            table14.AddRow(new string[] {
                        "true",
                        "true",
                        "false",
                        "false",
                        "false",
                        "false",
                        "100",
                        "10",
                        "TestText"});
            testRunner.Then("User updates the Computer Ownership on Self Service tab", ((string)(null)), table14, "Then ");
            testRunner.When("User navigate to \"Department and Location\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowScreen",
                        "ShowDepartmentFullPath",
                        "ShowLocationFullPath",
                        "AllowUsersToAddANote",
                        "Department",
                        "Location",
                        "DepartmentFeed",
                        "HrLocationFeed",
                        "ManualLocationFeed",
                        "HistoricLocationFeed"});
            table15.AddRow(new string[] {
                        "true",
                        "false",
                        "false",
                        "false",
                        "false",
                        "false",
                        "true",
                        "true",
                        "true",
                        "true"});
            testRunner.Then("User updates the Department and Location on Self Service tab", ((string)(null)), table15, "Then ");
            testRunner.When("User navigate to \"Apps List\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowThisScreen",
                        "ShowCoreApps",
                        "ShowTargetStateReadiness",
                        "ShowRequiredColumnAndSticky",
                        "ShowOnlyApplication",
                        "AllowUsersToAddANote",
                        "PageDescription"});
            table16.AddRow(new string[] {
                        "true",
                        "true",
                        "true",
                        "true",
                        "true",
                        "true",
                        "TestText"});
            testRunner.Then("User updates the Apps List on Self Service tab", ((string)(null)), table16, "Then ");
            testRunner.When("User navigate to \"Project Date\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowScreen",
                        "AllowUsersToAddANote",
                        "MinimumHours",
                        "MaximumHours",
                        "PageDescription"});
            table17.AddRow(new string[] {
                        "true",
                        "true",
                        "10",
                        "100",
                        "TestText"});
            testRunner.Then("User updates the Project Date on Self Service tab", ((string)(null)), table17, "Then ");
            testRunner.When("User navigate to \"Other Options 1\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowScreen",
                        "AllowUsersToAddANote",
                        "OnlyOwned",
                        "AllLinked",
                        "PageDescription"});
            table18.AddRow(new string[] {
                        "false",
                        "true",
                        "true",
                        "",
                        "TestText"});
            testRunner.Then("User updates the first Other Options on Self Service tab", ((string)(null)), table18, "Then ");
            testRunner.When("User navigate to \"Other Options 2\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "ShowScreen",
                        "AllowUsersToAddANote",
                        "OnlyOwned",
                        "AllLinked",
                        "PageDescription"});
            table19.AddRow(new string[] {
                        "false",
                        "true",
                        "true",
                        "",
                        "TestText"});
            testRunner.Then("User updates the second Other Options on Self Service tab", ((string)(null)), table19, "Then ");
            testRunner.When("User navigate to \"Thank You\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelfServicePortal",
                        "NavigationMenu",
                        "ChoicesSummary",
                        "IncludeLink",
                        "PageDescription"});
            table20.AddRow(new string[] {
                        "true",
                        "false",
                        "false",
                        "false",
                        "TestText"});
            testRunner.Then("User updates the Thank You on Self Service tab", ((string)(null)), table20, "Then ");
            testRunner.When("User navigate to \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Capacity\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "EnablePlanning",
                        "DisplayColors",
                        "EnforceOonSelfServicePage",
                        "EnforceOnProjectObjectPage",
                        "CapacityToReach"});
            table21.AddRow(new string[] {
                        "true",
                        "true",
                        "true",
                        "false",
                        "23"});
            testRunner.Then("User updates the Details on Capacity tab", ((string)(null)), table21, "Then ");
            testRunner.When("User navigate to \"Override Dates\" on selected tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Date",
                        "Capacity",
                        "Comment"});
            table22.AddRow(new string[] {
                        "03 Apr 2016",
                        "TestText",
                        "TestText"});
            testRunner.Then("User updates the Override Dates on Capacity tab", ((string)(null)), table22, "Then ");
            testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove \"TestGroupName\" Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove \"001 TestTeamName\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove \"TestStageName\" Task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove \"TestStageName\" Stage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ProjectShortName",
                        "ProjectDescription",
                        "ProjectType"});
            table23.AddRow(new string[] {
                        "TestProject",
                        "Test",
                        "Test",
                        "Computer Scheduled Project"});
            testRunner.When("User creates Project", ((string)(null)), table23, "When ");
            testRunner.Then("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Teams\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Team\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "TeamName",
                        "ShortDescription"});
            table24.AddRow(new string[] {
                        "123 onetwo",
                        "Test"});
            testRunner.Then("User create Team", ((string)(null)), table24, "Then ");
            testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Groups\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Group\" create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "GroupName"});
            table25.AddRow(new string[] {
                        "onetwo"});
            testRunner.Then("User create Group", ((string)(null)), table25, "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Manage Teams\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("groups is displayed in the \"123 onetwo\" team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove \"onetwo\" Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove \"123 onetwo\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Details\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("User remove Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
