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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Capacity.CapacitySlots
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CapacitySlotsPart5")]
    public partial class CapacitySlotsPart5Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacitySlotsPart5.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacitySlotsPart5", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectName" +
            "AndSameContent")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13792")]
        [NUnit.Framework.CategoryAttribute("DAS13788")]
        [NUnit.Framework.CategoryAttribute("DAS14241")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectNameAndSameContent()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectNameAndSameContentInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectNameAndSameContentInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectName" +
                    "AndSameContent", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13792",
                        "DAS13788",
                        "DAS14241",
                        "Cleanup",
                        "Not_Run"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table1.AddRow(new string[] {
                        "ProjectForDAS13979",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "Tasks",
                        "CapacityType",
                        "Monday",
                        "Tuesday",
                        "Wednesday",
                        "Thursday",
                        "Friday",
                        "Saturday",
                        "Sunday"});
            table2.AddRow(new string[] {
                        "ProjectForDAS13979",
                        "Slot 13979",
                        "13979",
                        "",
                        "Teams and Paths",
                        "0",
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6"});
#line 13
 testRunner.And("User creates new Slot via Api", ((string)(null)), table2, "And ");
#line 16
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.When("User clicks \"Duplicate\" option in Cog-menu for \"Slot 13979\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created, c" +
                    "lick here to view the Slot 13979 (copy) slot\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "column",
                        "duplicatedValue",
                        "duplicateCount"});
            table3.AddRow(new string[] {
                        "Monday",
                        "0",
                        "2"});
            table3.AddRow(new string[] {
                        "Tuesday",
                        "1",
                        "2"});
            table3.AddRow(new string[] {
                        "Wednesday",
                        "2",
                        "2"});
            table3.AddRow(new string[] {
                        "Thursday",
                        "3",
                        "2"});
            table3.AddRow(new string[] {
                        "Friday",
                        "4",
                        "2"});
            table3.AddRow(new string[] {
                        "Saturday",
                        "5",
                        "2"});
            table3.AddRow(new string[] {
                        "Sunday",
                        "6",
                        "2"});
            table3.AddRow(new string[] {
                        "Paths",
                        "All Paths",
                        "2"});
            table3.AddRow(new string[] {
                        "Teams",
                        "All Teams",
                        "2"});
            table3.AddRow(new string[] {
                        "Capacity Units",
                        "",
                        "2"});
#line 20
 testRunner.And("User sees following duplicates counts for columns:", ((string)(null)), table3, "And ");
#line 32
 testRunner.When("User clicks \"Duplicate\" option in Cog-menu for \"Slot 13979 (copy)\" item on Admin " +
                    "page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created, c" +
                    "lick here to view the Slot 13979 (copy) (copy) slot\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "column",
                        "duplicatedValue",
                        "duplicateCount"});
            table4.AddRow(new string[] {
                        "Monday",
                        "0",
                        "3"});
            table4.AddRow(new string[] {
                        "Tuesday",
                        "1",
                        "3"});
            table4.AddRow(new string[] {
                        "Wednesday",
                        "2",
                        "3"});
            table4.AddRow(new string[] {
                        "Thursday",
                        "3",
                        "3"});
            table4.AddRow(new string[] {
                        "Friday",
                        "4",
                        "3"});
            table4.AddRow(new string[] {
                        "Saturday",
                        "5",
                        "3"});
            table4.AddRow(new string[] {
                        "Sunday",
                        "6",
                        "3"});
            table4.AddRow(new string[] {
                        "Paths",
                        "All Paths",
                        "3"});
            table4.AddRow(new string[] {
                        "Teams",
                        "All Teams",
                        "3"});
            table4.AddRow(new string[] {
                        "Capacity Units",
                        "",
                        "3"});
#line 34
 testRunner.And("User sees following duplicates counts for columns:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table5.AddRow(new string[] {
                        "Slot 13979"});
            table5.AddRow(new string[] {
                        "Slot 13979 (copy)"});
            table5.AddRow(new string[] {
                        "Slot 13979 (copy) (copy)"});
#line 46
 testRunner.And("\"Capacity Slot\" column content is displayed in the following order:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table6.AddRow(new string[] {
                        "Slot 13979 (copy)"});
            table6.AddRow(new string[] {
                        "Slot 13979 (copy) (copy)"});
#line 51
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table6, "When ");
#line 55
 testRunner.When("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("Success message is displayed and contains \"The selected slots have been deleted\" " +
                    "text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("Counter shows \"1\" found rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNames")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS14478")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNames()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNamesInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNamesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNames", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS14478",
                        "Cleanup"});
#line 63
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
                        "ProjectForDAS14478",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 64
 testRunner.When("Project created via API and opened", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "CapacityType"});
            table8.AddRow(new string[] {
                        "ProjectForDAS14478",
                        "Slot 14478",
                        "14478",
                        "Teams and Paths"});
#line 67
 testRunner.And("User creates new Slot via Api", ((string)(null)), table8, "And ");
#line 70
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.When("User clicks \"Duplicate\" option in Cog-menu for \"Slot 14478\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created, c" +
                    "lick here to view the Slot 14478 (copy) slot\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("\"Slot 14478 (copy)\" content is displayed in \"Slot Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.And("\"14478\" content is displayed in \"Display Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValu" +
            "eEnteredInSlotMoveToPositionDialog")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13980")]
        [NUnit.Framework.CategoryAttribute("DAS13981")]
        [NUnit.Framework.CategoryAttribute("DAS17458")]
        public virtual void EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialog()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialogInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialogInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValu" +
                    "eEnteredInSlotMoveToPositionDialog", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13980",
                        "DAS13981",
                        "DAS17458"});
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 80
 testRunner.When("User navigates to \"Windows 7 Migration (Computer Scheduled Project)\" project deta" +
                    "ils", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("User clicks String Filter button for \"Paths\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When("User selects \"No Paths\" checkbox from String Filter on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.When("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.When("User clicks \"Move to position\" option in Cog-menu for \"User Slot\" item on Admin p" +
                    "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.And("User remembers the Move to position dialog size", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("User enters \"1.2\" value in Move to position dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then("User checks that Move to position dialog has the same size", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.And("Button \"Move\" in Move to position dialog is displayed disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("Alert message is displayed and contains \"Enter integer value between 1 and 32767\"" +
                    " text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPo" +
            "sitionIsGreaterThanTotalresocordsNumber")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13791")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPositionIsGreaterThanTotalresocordsNumber()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPositionIsGreaterThanTotalresocordsNumberInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPositionIsGreaterThanTotalresocordsNumberInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPo" +
                    "sitionIsGreaterThanTotalresocordsNumber", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13791",
                        "Cleanup"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table9.AddRow(new string[] {
                        "ProjectForDAS13791",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 96
 testRunner.When("Project created via API and opened", ((string)(null)), table9, "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "CapacityType"});
            table10.AddRow(new string[] {
                        "ProjectForDAS13791",
                        "Slot 10001",
                        "10001",
                        "Teams and Paths"});
            table10.AddRow(new string[] {
                        "ProjectForDAS13791",
                        "Slot 10002",
                        "10002",
                        "Teams and Paths"});
            table10.AddRow(new string[] {
                        "ProjectForDAS13791",
                        "Slot 10003",
                        "10003",
                        "Teams and Paths"});
#line 99
 testRunner.And("User creates new Slot via Api", ((string)(null)), table10, "And ");
#line 104
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table11.AddRow(new string[] {
                        "Slot 10001"});
            table11.AddRow(new string[] {
                        "Slot 10002"});
            table11.AddRow(new string[] {
                        "Slot 10003"});
#line 106
 testRunner.Then("\"Capacity Slot\" column content is displayed in the following order:", ((string)(null)), table11, "Then ");
#line 111
 testRunner.When("User move \"Slot 10001\" item to \"32767\" position on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table12.AddRow(new string[] {
                        "Slot 10002"});
            table12.AddRow(new string[] {
                        "Slot 10003"});
            table12.AddRow(new string[] {
                        "Slot 10001"});
#line 112
 testRunner.Then("\"Capacity Slot\" column content is displayed in the following order:", ((string)(null)), table12, "Then ");
#line 117
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

