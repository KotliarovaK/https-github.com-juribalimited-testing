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
    [NUnit.Framework.DescriptionAttribute("CapacitySlotsPart2")]
    public partial class CapacitySlotsPart2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacitySlotsPart2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacitySlotsPart2", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapac" +
            "itySlotForm")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13441")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapacitySlotForm()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapacitySlotFormInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapacitySlotFormInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapac" +
                    "itySlotForm", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13441",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "ObjectType",
                        "Tasks"});
            table1.AddRow(new string[] {
                        "User Scheduled Project in Italian & Japanese (Jo)",
                        "CapacitySlotDAS13441",
                        "DAS13441",
                        "Device",
                        "Stage 1 \\ DDL Task for a Computer‡Stage 1 \\ Date Task for a Computer Italian"});
#line 10
 testRunner.When("User creates new Slot via Api", ((string)(null)), table1, "When ");
#line 13
 testRunner.And("User navigates to newly created Slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table2.AddRow(new string[] {
                        "Stage 1 \\ DDL Task for a Computer"});
            table2.AddRow(new string[] {
                        "Stage 1 \\ Date Task for a Computer Italian"});
#line 14
 testRunner.Then("User sees following tiles selected in the \"Tasks\" field:", ((string)(null)), table2, "Then ");
#line 18
 testRunner.When("User selects \"User\" in the \"Object Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
#line 19
 testRunner.Then("User sees following tiles selected in the \"Tasks\" field:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticu" +
            "larProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13866")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProjectInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticu" +
                    "larProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13866",
                        "Cleanup"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName"});
            table4.AddRow(new string[] {
                        "Project K-Computer Scheduled Project",
                        "CapacitySlot13866",
                        "DAS13866"});
#line 24
 testRunner.When("User creates new Slot via Api", ((string)(null)), table4, "When ");
#line 27
 testRunner.When("User navigates to \"Project K-Computer Scheduled Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table5.AddRow(new string[] {
                        "CapacitySlot13866"});
#line 30
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table5, "When ");
#line 33
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("Success message is displayed and contains \"The selected slot has been deleted\" te" +
                    "xt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessages" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS12921")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessages()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessagesInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessagesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessages" +
                    "", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS12921"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 42
 testRunner.When("User navigates to \"User Evergreen Capacity Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table6.AddRow(new string[] {
                        "User Slot 1"});
#line 45
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table6, "When ");
#line 48
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("Warning message with \"The selected slot will be deleted, do you want to proceed?\"" +
                    " text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table7.AddRow(new string[] {
                        "User Slot 2"});
#line 52
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table7, "When ");
#line 55
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.Then("Warning message with \"The selected slots will be deleted, do you want to proceed?" +
                    "\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13835")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPageInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13835",
                        "Cleanup"});
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 60
 testRunner.When("User navigates to \"User Scheduled Project in Italian & Japanese (Jo)\" project det" +
                    "ails", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User selects \"Capacity Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("User selects \"Teams and Paths\" option in \"Capacity Mode\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("User selects \"Capacity Units\" option in \"Capacity Mode\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("Success message is displayed and contains \"The project capacity details have been" +
                    " updated\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "IsDefault",
                        "Project"});
            table8.AddRow(new string[] {
                        "Capacity Unit 1",
                        "",
                        "false",
                        "User Scheduled Project in Italian & Japanese (Jo)"});
            table8.AddRow(new string[] {
                        "Capacity Unit 2",
                        "",
                        "false",
                        "User Scheduled Project in Italian & Japanese (Jo)"});
#line 69
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "CapacityUnits",
                        "CapacityType"});
            table9.AddRow(new string[] {
                        "User Scheduled Project in Italian & Japanese (Jo)",
                        "Slot1",
                        "Slot 1",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "User Scheduled Project in Italian & Japanese (Jo)",
                        "Slot2",
                        "Slot 2",
                        "Capacity Unit 1",
                        ""});
            table9.AddRow(new string[] {
                        "User Scheduled Project in Italian & Japanese (Jo)",
                        "Slot3",
                        "Slot 3",
                        "Capacity Unit 2",
                        ""});
            table9.AddRow(new string[] {
                        "User Scheduled Project in Italian & Japanese (Jo)",
                        "Slot4",
                        "Slot 4",
                        "",
                        "Teams and Paths"});
#line 74
 testRunner.And("User creates new Slot via Api", ((string)(null)), table9, "And ");
#line 81
 testRunner.When("User clicks \"Units\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.And("User enters \"Unassigned\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.Then("\"1\" content is displayed in \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User clicks content from \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("\"All Capacity Units\" is displayed in the dropdown filter for \"Capacity Units\" col" +
                    "umn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.And("Rows counter contains \"1\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table10.AddRow(new string[] {
                        "Slot1"});
#line 87
 testRunner.And("User sees next Slots on the Capacity Slots page:", ((string)(null)), table10, "And ");
#line 91
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("User clicks \"Units\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User enters \"Capacity Unit 1\" text in the Search field for \"Capacity Unit\" column" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("\"2\" content is displayed in \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.When("User clicks content from \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("\"Capacity Unit 1,All Capacity Units\" is displayed in the dropdown filter for \"Cap" +
                    "acity Units\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.And("Rows counter contains \"2\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table11.AddRow(new string[] {
                        "Slot1"});
            table11.AddRow(new string[] {
                        "Slot2"});
#line 98
 testRunner.And("User sees next Slots on the Capacity Slots page:", ((string)(null)), table11, "And ");
#line 103
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.And("User clicks \"Units\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("User enters \"Capacity Unit 2\" text in the Search field for \"Capacity Unit\" column" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.Then("\"2\" content is displayed in \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.When("User clicks content from \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.Then("\"Capacity Unit 2,All Capacity Units\" is displayed in the dropdown filter for \"Cap" +
                    "acity Units\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.And("Rows counter contains \"2\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table12.AddRow(new string[] {
                        "Slot1"});
            table12.AddRow(new string[] {
                        "Slot3"});
#line 110
 testRunner.And("User sees next Slots on the Capacity Slots page:", ((string)(null)), table12, "And ");
#line 115
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table13.AddRow(new string[] {
                        "Slot1"});
            table13.AddRow(new string[] {
                        "Slot2"});
            table13.AddRow(new string[] {
                        "Slot3"});
            table13.AddRow(new string[] {
                        "Slot4"});
#line 117
 testRunner.And("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table13, "And ");
#line 123
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.Then("Success message is displayed and contains \"The selected slots have been deleted\" " +
                    "text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.When("User selects \"Units\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table14.AddRow(new string[] {
                        "Capacity Unit 1"});
            table14.AddRow(new string[] {
                        "Capacity Unit 2"});
#line 129
 testRunner.And("User select \"Capacity Unit\" rows in the grid", ((string)(null)), table14, "And ");
#line 133
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.Then("Success message is displayed and contains \"The selected units have been deleted\" " +
                    "text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.When("User selects \"Capacity Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.Then("User selects \"Teams and Paths\" option in \"Capacity Mode\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("Success message is displayed and contains \"The project capacity details have been" +
                    " updated\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
