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
        
#line 1 "Senior_Dashboards.feature"
#line hidden
        
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
#line 4
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.Senior_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectlyInternal(pageName,exampleTags);
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

        private void Senior_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectlyInternal(string pageName, string[] exampleTags)
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
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When(string.Format("User navigates to the \"{0}\" page on Dashboards tab", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then(string.Format("\"{0}\" page is displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("User select \"Barry\'s User Project\" Project on toolbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.When("User navigate to \"Barry\'s Pilot Group 1\" group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("content for the \"Barry\'s Pilot Group 1\" group is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPageInternal();
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

        private void Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage", null, new string[] {
                        "Senior",
                        "Dashworks",
                        "Projects_Dashworks",
                        "Senior_Teams",
                        "DAS13000"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 25
 testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User navigate to \"Computer Scheduled Test (Jo)\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("User navigate to \"Teams\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("\"My Team\" Team have a default value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("User navigates to \"My Team\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("Default Team checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User clicks \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And("User navigates to \"Admin IT\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User makes selected Team by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("User clicks \"Update\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("information message is displayed with \"Team was successfully updated.\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("Default Team checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("User clicks \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And("User navigates to \"My Team\" Team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("User makes selected Team by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("User clicks \"Update\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("information message is displayed with \"Team was successfully updated.\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("Default Team checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTaskInternal();
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

        private void Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTaskInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTask", null, new string[] {
                        "Senior",
                        "Dashworks",
                        "Projects_Dashworks",
                        "Senior_Projects",
                        "Senior_Tasks",
                        "DAS14322"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 50
 testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
#line 54
 testRunner.When("User creates new Project on Senior", ((string)(null)), table1, "When ");
#line 57
 testRunner.And("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("\"Manage Stages\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "StageName"});
            table2.AddRow(new string[] {
                        "Stage 14322"});
#line 60
 testRunner.And("User create Stage", ((string)(null)), table2, "And ");
#line 63
 testRunner.And("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
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
#line 66
 testRunner.And("User creates new Task on Senior", ((string)(null)), table3, "And ");
#line 69
 testRunner.Then("Success message is displayed with \"Task successfully created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.When("User navigate to \"Values\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("User clicks \"Add value\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "TaskStatusString",
                        "DefaultValue"});
            table4.AddRow(new string[] {
                        "TestValueName",
                        "Open",
                        "false"});
#line 72
 testRunner.When("User create new Value", ((string)(null)), table4, "When ");
#line 75
 testRunner.And("User clicks \"Save Value\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("User navigate to \"Details\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("\"Edit Task\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.When("User navigate to \"Request Types\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then("\"Edit Task\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.When("User navigate to \"Details\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.When("User removes the Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutErrorInternal();
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

        private void Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutErrorInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutError" +
                    "", null, new string[] {
                        "Senior",
                        "Projects_Dashboards",
                        "Senior_Projects",
                        "DAS14171"});
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 87
 testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User navigate to \"User Scheduled Test (Jo)\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.And("User removes the Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("Error message is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosingValueTypeInternal();
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

        private void Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosingValueTypeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosin" +
                    "gValueType", null, new string[] {
                        "Senior",
                        "Projects_Dashboards",
                        "Senior_Tasks",
                        "DAS13887"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 96
 testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("User navigate to \"Windows 7 Migration (Computer Scheduled Project)\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("Project with \"Windows 7 Migration (Computer Scheduled Project)\" name is displayed" +
                    " correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.And("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("User selects \"Date\" as Task Value Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
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
#line 103
 testRunner.Then("Next items are displayed as options of Object Type property:", ((string)(null)), table5, "Then ");
#line 109
 testRunner.When("User selects \"Text\" as Task Value Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
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
#line 110
 testRunner.Then("Next items are displayed as options of Object Type property:", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

