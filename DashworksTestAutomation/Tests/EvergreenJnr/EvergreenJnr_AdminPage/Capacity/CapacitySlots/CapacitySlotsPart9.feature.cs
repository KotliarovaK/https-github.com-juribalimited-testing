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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Capacity.CapacitySlots
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CapacitySlotsPart9")]
    public partial class CapacitySlotsPart9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacitySlotsPart9.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacitySlotsPart9", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlot")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS15878")]
        [NUnit.Framework.CategoryAttribute("DAS15291")]
        public virtual void EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlot()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlotInternal();
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

        private void EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlotInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlot", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS15878",
                        "DAS15291"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to \"2004 Rollout\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("User moves \"Birmingham Morning\" slot to \"Manchester Morning\" slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table1.AddRow(new string[] {
                        "Birmingham Afternoon"});
            table1.AddRow(new string[] {
                        "Birmingham Morning"});
            table1.AddRow(new string[] {
                        "Manchester Morning"});
            table1.AddRow(new string[] {
                        "Manchester Afternoon"});
            table1.AddRow(new string[] {
                        "London - City Morning"});
            table1.AddRow(new string[] {
                        "London - City Afternoon"});
            table1.AddRow(new string[] {
                        "London - Southbank Morning"});
            table1.AddRow(new string[] {
                        "London - Southbank Afternoon"});
            table1.AddRow(new string[] {
                        "London Depot 09:00 - 11:00"});
            table1.AddRow(new string[] {
                        "London Depot 11:00 - 13:00"});
            table1.AddRow(new string[] {
                        "London Depot 13:00 - 15:00"});
            table1.AddRow(new string[] {
                        "London Depot 15:00 - 17:00"});
#line 14
 testRunner.Then("Content in the \'Capacity Slot\' column is equal to", ((string)(null)), table1, "Then ");
#line 28
 testRunner.When("User moves \"Birmingham Afternoon\" slot to \"Manchester Morning\" slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table2.AddRow(new string[] {
                        "Birmingham Morning"});
            table2.AddRow(new string[] {
                        "Birmingham Afternoon"});
            table2.AddRow(new string[] {
                        "Manchester Morning"});
            table2.AddRow(new string[] {
                        "Manchester Afternoon"});
            table2.AddRow(new string[] {
                        "London - City Morning"});
            table2.AddRow(new string[] {
                        "London - City Afternoon"});
            table2.AddRow(new string[] {
                        "London - Southbank Morning"});
            table2.AddRow(new string[] {
                        "London - Southbank Afternoon"});
            table2.AddRow(new string[] {
                        "London Depot 09:00 - 11:00"});
            table2.AddRow(new string[] {
                        "London Depot 11:00 - 13:00"});
            table2.AddRow(new string[] {
                        "London Depot 13:00 - 15:00"});
            table2.AddRow(new string[] {
                        "London Depot 15:00 - 17:00"});
#line 29
 testRunner.Then("Content in the \'Capacity Slot\' column is equal to", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreen")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("DAS13671")]
        public virtual void EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreen()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreenInternal();
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

        private void EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreenInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreen", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "DAS13671"});
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 46
 testRunner.When("User navigates to \"Email Migration\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("User enters \"Slot 2018-05-01 - 2019-05-31[Team: 3; RequestType: 458]\" text in the" +
                    " Search field for \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("User clicks close button for \"Pre-Migration \\ Scheduled date\" chip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table3.AddRow(new string[] {
                        "Migration \\ BT/QMM agent switch date"});
            table3.AddRow(new string[] {
                        "Migration \\ Migrated date"});
            table3.AddRow(new string[] {
                        "Post-Migration \\ Completed date"});
            table3.AddRow(new string[] {
                        "Pre-Migration \\ Forecast date"});
            table3.AddRow(new string[] {
                        "Pre-Migration \\ Mailbox Radiobutton RAG Date & Time Owner"});
            table3.AddRow(new string[] {
                        "Pre-Migration \\ Out Of Office End Date"});
            table3.AddRow(new string[] {
                        "Pre-Migration \\ Out Of Office Start Date"});
            table3.AddRow(new string[] {
                        "Pre-Migration \\ Scheduled date"});
            table3.AddRow(new string[] {
                        "Pre-Migration \\ Target date"});
#line 52
 testRunner.Then("\'Tasks\' autocomplete have following checkbox options", ((string)(null)), table3, "Then ");
#line 63
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.And("User clicks \'CREATE SLOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.When("User checks \'Shared Mailbox\' option after search from \'Paths\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table4.AddRow(new string[] {
                        "Migration \\ BT/QMM agent switch date"});
            table4.AddRow(new string[] {
                        "Migration \\ Migrated date"});
            table4.AddRow(new string[] {
                        "Post-Migration \\ Completed date"});
            table4.AddRow(new string[] {
                        "Pre-Migration \\ Forecast date"});
            table4.AddRow(new string[] {
                        "Pre-Migration \\ Mailbox Radiobutton RAG Date & Time Owner"});
            table4.AddRow(new string[] {
                        "Pre-Migration \\ Out Of Office End Date"});
            table4.AddRow(new string[] {
                        "Pre-Migration \\ Out Of Office Start Date"});
            table4.AddRow(new string[] {
                        "Pre-Migration \\ Scheduled date"});
            table4.AddRow(new string[] {
                        "Pre-Migration \\ Target date"});
#line 66
 testRunner.Then("\'Tasks\' autocomplete have following checkbox options", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelection")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("DAS13671")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelection()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelectionInternal();
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

        private void EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelectionInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelection", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "DAS13671",
                        "Cleanup"});
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 80
 testRunner.When("User clicks \'Projects\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("User navigate to \"Devices Evergreen Capacity Project\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("Project with \"Devices Evergreen Capacity Project\" name is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.And("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Help",
                        "StagesNameString",
                        "TaskTypeString",
                        "ValueTypeString",
                        "ObjectTypeString",
                        "TaskValuesTemplateString"});
            table5.AddRow(new string[] {
                        "WO Task13671",
                        "13671",
                        "Stage 1",
                        "Normal",
                        "Date",
                        "Computer",
                        ""});
#line 86
 testRunner.And("User creates Task", ((string)(null)), table5, "And ");
#line 89
 testRunner.Then("Success message is displayed with \"Task successfully created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.When("User publishes the task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.When("User navigates to \"Devices Evergreen Capacity Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("User clicks \'CREATE SLOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("User enters \'Slot13671\' text to \'Slot Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("User enters \'13671\' text to \'Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("User selects \'Teams and Paths\' in the \'Capacity Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("User checks \'[Default (Computer)]\' option after search from \'Paths\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("User checks \'Stage 1 \\ WO Task13671\' option after search from \'Tasks\' autocomplet" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.Then("\'Your capacity slot has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ChipValue"});
            table6.AddRow(new string[] {
                        "Stage 1 \\ WO Task13671"});
#line 103
 testRunner.Then("following chips value displayed in the \'Tasks\' textbox", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatDisplayOrderIsResetAfterSlotDeletion")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13147")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatDisplayOrderIsResetAfterSlotDeletion()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatDisplayOrderIsResetAfterSlotDeletionInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatDisplayOrderIsResetAfterSlotDeletionInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatDisplayOrderIsResetAfterSlotDeletion", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13147",
                        "Cleanup"});
#line 108
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table7.AddRow(new string[] {
                        "ProjectForDAS13147",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 109
 testRunner.When("Project created via API and opened", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "CapacityUnits",
                        "CapacityType"});
            table8.AddRow(new string[] {
                        "ProjectForDAS13147",
                        "Slot 1",
                        "Slot 1",
                        "Unassigned",
                        ""});
            table8.AddRow(new string[] {
                        "ProjectForDAS13147",
                        "Slot 2",
                        "Slot 2",
                        "",
                        "Teams and Paths"});
            table8.AddRow(new string[] {
                        "ProjectForDAS13147",
                        "Slot 3",
                        "Slot 3",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "ProjectForDAS13147",
                        "Slot 4",
                        "Slot 4",
                        "",
                        ""});
#line 112
 testRunner.And("User creates new Slot via Api", ((string)(null)), table8, "And ");
#line 118
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table9.AddRow(new string[] {
                        "Slot 3"});
#line 120
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table9, "When ");
#line 123
 testRunner.When("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.And("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.Then("\'The selected slot has been deleted\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.When("User opens \'Capacity Slot\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.Then("Column Settings was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.When("User select \"Display Order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table10.AddRow(new string[] {
                        "1"});
            table10.AddRow(new string[] {
                        "2"});
            table10.AddRow(new string[] {
                        "3"});
#line 132
 testRunner.Then("User sees following Display order on the Automation page", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

