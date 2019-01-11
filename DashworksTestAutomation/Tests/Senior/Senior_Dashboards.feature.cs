﻿// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.Senior
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Projects_Dashboards")]
    public partial class Projects_DashboardsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Projects_Dashboards", "\tRuns Projects Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senior_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectly")]
        [NUnit.Framework.CategoryAttribute("Senior")]
        [NUnit.Framework.CategoryAttribute("Dashworks")]
        [NUnit.Framework.CategoryAttribute("Senior_Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12651")]
        [NUnit.Framework.TestCaseAttribute("User Dashboard", null)]
        [NUnit.Framework.TestCaseAttribute("Computer Dashboard", null)]
        public virtual void Senior_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectly(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Senior",
                    "Dashworks",
                    "Senior_Projects",
                    "DAS12651"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectly", null, @__tags);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User navigates to the \"{0}\" page on Dashboards tab", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" page is displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Barry\'s User Project\" Project on toolbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User navigate to \"Barry\'s Pilot Group 1\" group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("content for the \"Barry\'s Pilot Group 1\" group is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage")]
        [NUnit.Framework.CategoryAttribute("Senior")]
        [NUnit.Framework.CategoryAttribute("Dashworks")]
        [NUnit.Framework.CategoryAttribute("Projects_Dashworks")]
        [NUnit.Framework.CategoryAttribute("Senior_Teams")]
        [NUnit.Framework.CategoryAttribute("DAS13000")]
        public virtual void Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage", null, new string[] {
                        "Senior",
                        "Dashworks",
                        "Projects_Dashworks",
                        "Senior_Teams",
                        "DAS13000"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Computer Scheduled Test (Jo)\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"My Team\" Team have a default value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigates to \"My Team\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Default Team checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigates to \"Admin IT\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User makes selected Team by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Update\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("information message is displayed with \"Team was successfully updated.\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Default Team checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigates to \"My Team\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User makes selected Team by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Update\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("information message is displayed with \"Team was successfully updated.\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Default Team checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTask")]
        [NUnit.Framework.CategoryAttribute("Senior")]
        [NUnit.Framework.CategoryAttribute("Dashworks")]
        [NUnit.Framework.CategoryAttribute("Projects_Dashworks")]
        [NUnit.Framework.CategoryAttribute("Senior_Projects")]
        [NUnit.Framework.CategoryAttribute("Senior_Tasks")]
        [NUnit.Framework.CategoryAttribute("DAS14322")]
        public virtual void Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTask()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTask", null, new string[] {
                        "Senior",
                        "Dashworks",
                        "Projects_Dashworks",
                        "Senior_Projects",
                        "Senior_Tasks",
                        "DAS14322"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ShortName",
                        "Description",
                        "Type"});
            table1.AddRow(new string[] {
                        "ProjectForDAS14322",
                        "14322",
                        "",
                        ""});
            testRunner.When("User creates new Project on Senior", ((string)(null)), table1, "When ");
            testRunner.And("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Manage Stages\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "StageName"});
            table2.AddRow(new string[] {
                        "Stage 14322"});
            testRunner.And("User create Stage", ((string)(null)), table2, "And ");
            testRunner.And("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Help",
                        "StagesName",
                        "TaskType",
                        "ValueType",
                        "ObjectType",
                        "TaskValuesTemplate"});
            table3.AddRow(new string[] {
                        "for 14322",
                        "for 14322",
                        "Stage 14322",
                        "Normal",
                        "Radiobutton",
                        "User",
                        "None"});
            testRunner.And("User creates new Task on Senior", ((string)(null)), table3, "And ");
            testRunner.Then("Success message is displayed with \"Task successfully created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Values\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks \"Add value\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "TaskStatusString",
                        "DefaultValue"});
            table4.AddRow(new string[] {
                        "TestValueName",
                        "Open",
                        "false"});
            testRunner.When("User create new Value", ((string)(null)), table4, "When ");
            testRunner.And("User clicks \"Save Value\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Edit Task\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigate to \"Request Types\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Edit Task\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigate to \"Details\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User removes the Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutError" +
            "")]
        [NUnit.Framework.CategoryAttribute("Senior")]
        [NUnit.Framework.CategoryAttribute("Projects_Dashboards")]
        [NUnit.Framework.CategoryAttribute("Senior_Projects")]
        [NUnit.Framework.CategoryAttribute("DAS14171")]
        public virtual void Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutError()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutError" +
                    "", null, new string[] {
                        "Senior",
                        "Projects_Dashboards",
                        "Senior_Projects",
                        "DAS14171"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"User Scheduled Test (Jo)\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User removes the Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Error message is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosin" +
            "gValueType")]
        [NUnit.Framework.CategoryAttribute("Senior")]
        [NUnit.Framework.CategoryAttribute("Projects_Dashboards")]
        [NUnit.Framework.CategoryAttribute("Senior_Tasks")]
        [NUnit.Framework.CategoryAttribute("DAS13887")]
        public virtual void Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosingValueType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosin" +
                    "gValueType", null, new string[] {
                        "Senior",
                        "Projects_Dashboards",
                        "Senior_Tasks",
                        "DAS13887"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Windows 7 Migration (Computer Scheduled Project)\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Project with \"Windows 7 Migration (Computer Scheduled Project)\" name is displayed" +
                    " correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User selects \"Date\" as Task Value Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table5.AddRow(new string[] {
                        "[Select]"});
            table5.AddRow(new string[] {
                        "User"});
            table5.AddRow(new string[] {
                        "Computer"});
            table5.AddRow(new string[] {
                        "Application"});
            testRunner.Then("Next items are displayed as options of Object Type property:", ((string)(null)), table5, "Then ");
            testRunner.When("User selects \"Text\" as Task Value Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table6.AddRow(new string[] {
                        "[Select]"});
            table6.AddRow(new string[] {
                        "User"});
            table6.AddRow(new string[] {
                        "Computer"});
            table6.AddRow(new string[] {
                        "Application"});
            testRunner.Then("Next items are displayed as options of Object Type property:", ((string)(null)), table6, "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
