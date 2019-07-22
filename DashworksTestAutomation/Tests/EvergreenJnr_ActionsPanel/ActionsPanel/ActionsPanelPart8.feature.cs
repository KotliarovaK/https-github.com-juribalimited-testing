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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ActionsPanel.ActionsPanel
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ActionsPanelPart8")]
    public partial class ActionsPanelPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ActionsPanelPart8.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ActionsPanelPart8", "\tRuns Actions Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBann" +
            "erMessage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS12864")]
        [NUnit.Framework.CategoryAttribute("DAS13293")]
        [NUnit.Framework.CategoryAttribute("DAS13359")]
        public virtual void EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBannerMessage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBannerMessageInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBannerMessageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBann" +
                    "erMessage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS12864",
                        "DAS13293",
                        "DAS13359"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Havoc(BigD: Task 0"});
#line 14
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "When ");
#line 17
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table2.AddRow(new string[] {
                        "TRUE"});
#line 19
 testRunner.When("User add \"Havoc(BigD: In Scope\" filter where type is \"Equals\" with added column a" +
                    "nd following checkboxes:", ((string)(null)), table2, "When ");
#line 22
 testRunner.Then("\"Havoc(BigD: In Scope\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User selects \"Update task value\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("User selects \"Havoc (Big Data)\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User selects \"Stage 0\" Stage on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User selects \"Task 0\" Task on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("User selects \"Started\" Value on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then("the amber message is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.And("User clicks \"UPDATE\" button on message box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("Success message with \"7578 of 7578 objects were in the selected project and have " +
                    "been queued\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("\"STARTED\" content is displayed for \"Havoc(BigD: Task 0\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasks" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS13386")]
        public virtual void EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasks()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasksInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasksInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasks" +
                    "", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS13386"});
#line 40
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 41
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table3.AddRow(new string[] {
                        "001BAQXT6JWFPI"});
            table3.AddRow(new string[] {
                        "001PSUMZYOW581"});
#line 45
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table3, "When ");
#line 49
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("User selects \"Update task value\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("User selects \"Windows 7 Migration (Computer Scheduled Project)\" Project on Action" +
                    " panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("User selects \"Pre-Migration\" Stage on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table4.AddRow(new string[] {
                        "Forecast Date"});
            table4.AddRow(new string[] {
                        "Forecast Code"});
            table4.AddRow(new string[] {
                        "Target Date"});
            table4.AddRow(new string[] {
                        "Scheduled Date"});
            table4.AddRow(new string[] {
                        "Laptop Only Task"});
            table4.AddRow(new string[] {
                        "Physical Only Task"});
            table4.AddRow(new string[] {
                        "VDI Only Task"});
            table4.AddRow(new string[] {
                        "Laptop & Physical Task"});
            table4.AddRow(new string[] {
                        "Target Code"});
            table4.AddRow(new string[] {
                        "Scheduled Code"});
            table4.AddRow(new string[] {
                        "Further Information"});
            table4.AddRow(new string[] {
                        "Targeting Information"});
            table4.AddRow(new string[] {
                        "Laptop & Workstation 2"});
#line 53
 testRunner.Then("following Tasks are displayed in drop-down:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS13386")]
        [NUnit.Framework.CategoryAttribute("DAS13477")]
        public virtual void EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasks()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasksInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasksInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasks", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS13386",
                        "DAS13477"});
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 71
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table5.AddRow(new string[] {
                        "003F5D8E1A844B1FAA5"});
            table5.AddRow(new string[] {
                        "00A5B910A1004CF5AC4"});
#line 75
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table5, "When ");
#line 79
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User selects \"Update task value\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User selects \"User Scheduled Test (Jo)\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table6.AddRow(new string[] {
                        "One"});
            table6.AddRow(new string[] {
                        "Two"});
            table6.AddRow(new string[] {
                        "Three"});
#line 82
 testRunner.Then("following Stage are displayed in drop-down:", ((string)(null)), table6, "Then ");
#line 87
 testRunner.When("User selects \"One\" Stage on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table7.AddRow(new string[] {
                        "Radio Rag only User"});
            table7.AddRow(new string[] {
                        "Radio Rag Date User"});
            table7.AddRow(new string[] {
                        "Radio Rag Date Owner User"});
            table7.AddRow(new string[] {
                        "Text User"});
            table7.AddRow(new string[] {
                        "Radio Rag Only User Req A"});
            table7.AddRow(new string[] {
                        "Radio Rag Date User Req A"});
            table7.AddRow(new string[] {
                        "Radio Rag Date Owner User Req A"});
            table7.AddRow(new string[] {
                        "Radio Rag only User Req B"});
            table7.AddRow(new string[] {
                        "Radio Rag Date User Req B"});
            table7.AddRow(new string[] {
                        "Radio Rag Date Owner User Req B"});
            table7.AddRow(new string[] {
                        "Radio Rag Date Owner Req B"});
            table7.AddRow(new string[] {
                        "SS Department and Location Enabled"});
#line 88
 testRunner.Then("following Tasks are displayed in drop-down:", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMa" +
            "ilboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14421")]
        public virtual void EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMailboxes()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMailboxesInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMailboxesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMa" +
                    "ilboxes", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14421"});
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 105
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table8.AddRow(new string[] {
                        "00A5B910A1004CF5AC4"});
#line 107
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table8, "When ");
#line 110
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("User selects \"Update capacity unit\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("User selects \"Project\" Project or Evergreen on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("User selects \"Email Migration\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("User selects \"Unassigned\" Capacity Unit on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table9.AddRow(new string[] {
                        "None"});
            table9.AddRow(new string[] {
                        "Owned mailboxes only"});
            table9.AddRow(new string[] {
                        "All linked mailboxes"});
#line 115
 testRunner.Then("following Move Mailboxes are displayed in drop-down:", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

