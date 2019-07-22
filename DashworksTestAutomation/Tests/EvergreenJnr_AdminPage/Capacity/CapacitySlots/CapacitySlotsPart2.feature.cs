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
                        "DAS13441"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to \"User Scheduled Project in Italian & Japanese (Jo)\" project det" +
                    "ails", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("User clicks the \"CREATE SLOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("User type \"CapacitySlotDAS13441\" Name in the \"Slot Name\" field on the Project det" +
                    "ails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("User type \"DAS13441\" Name in the \"Display Name\" field on the Project details page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("User selects \"Device\" in the \"Object Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table1.AddRow(new string[] {
                        "Stage 1 \\ DDL Task for a Computer"});
            table1.AddRow(new string[] {
                        "Stage 1 \\ Date Task for a Computer Italian"});
#line 17
 testRunner.And("User selects next items in the \"Tasks\" dropdown:", ((string)(null)), table1, "And ");
#line 21
 testRunner.And("User clicks on \"Teams\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table2.AddRow(new string[] {
                        "Stage 1 \\ DDL Task for a Computer"});
            table2.AddRow(new string[] {
                        "Stage 1 \\ Date Task for a Computer Italian"});
#line 24
 testRunner.Then("User sees following tiles selected in the \"Tasks\" field:", ((string)(null)), table2, "Then ");
#line 28
 testRunner.When("User selects \"User\" in the \"Object Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
#line 29
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
                        "DAS13866"});
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 34
 testRunner.When("User navigates to \"Project K-Computer Scheduled Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("User clicks the \"CREATE SLOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User type \"CapacitySlot13866\" Name in the \"Slot Name\" field on the Project detail" +
                    "s page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("User type \"DAS13866\" Name in the \"Display Name\" field on the Project details page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("Success message with \"Your capacity slot has been created\" text is displayed on t" +
                    "he Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table4.AddRow(new string[] {
                        "CapacitySlot13866"});
#line 44
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table4, "When ");
#line 47
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("Success message is displayed and contains \"The selected slot has been deleted\" te" +
                    "xt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
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
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 59
 testRunner.When("User navigates to \"User Evergreen Capacity Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table5.AddRow(new string[] {
                        "User Slot 1"});
#line 62
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table5, "When ");
#line 65
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("Warning message with \"The selected slot will be deleted, do you want to proceed?\"" +
                    " text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table6.AddRow(new string[] {
                        "User Slot 2"});
#line 69
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table6, "When ");
#line 72
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
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
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 77
 testRunner.When("User navigates to \"User Scheduled Project in Italian & Japanese (Jo)\" project det" +
                    "ails", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User selects \"Capacity Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("User selects \"Teams and Paths\" option in \"Capacity Mode\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("User selects \"Capacity Units\" option in \"Capacity Mode\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("Success message is displayed and contains \"The project capacity details have been" +
                    " updated\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "IsDefault",
                        "Project"});
            table7.AddRow(new string[] {
                        "Capacity Unit 1",
                        "",
                        "false",
                        "User Scheduled Project in Italian & Japanese (Jo)"});
            table7.AddRow(new string[] {
                        "Capacity Unit 2",
                        "",
                        "false",
                        "User Scheduled Project in Italian & Japanese (Jo)"});
#line 86
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table7, "When ");
#line 90
 testRunner.When("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.And("User clicks the \"CREATE SLOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("User type \"Slot1\" Name in the \"Slot Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User type \"Slot 1\" Name in the \"Display Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created\" t" +
                    "ext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.When("User clicks the \"CREATE SLOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.And("User type \"Slot2\" Name in the \"Slot Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("User type \"Slot 2\" Name in the \"Display Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("User selects \"Capacity Unit 1\" checkbox in the \"Capacity Units\" field on the Proj" +
                    "ect details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created\" t" +
                    "ext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("User clicks the \"CREATE SLOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.And("User type \"Slot3\" Name in the \"Slot Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("User type \"Slot 3\" Name in the \"Display Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("User selects \"Capacity Unit 2\" checkbox in the \"Capacity Units\" field on the Proj" +
                    "ect details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created\" t" +
                    "ext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.When("User clicks the \"CREATE SLOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.And("User type \"Slot4\" Name in the \"Slot Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("User type \"Slot 4\" Name in the \"Display Name\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.Then("User selects \"Teams and Paths\" option in \"Capacity Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then("Success message is displayed and contains \"Your capacity slot has been created\" t" +
                    "ext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.When("User clicks \"Units\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
 testRunner.And("User enters \"Unassigned\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.Then("\"1\" content is displayed in \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.When("User clicks content from \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("\"All Capacity Units\" is displayed in the dropdown filter for \"Capacity Units\" col" +
                    "umn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.And("Rows counter contains \"1\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table8.AddRow(new string[] {
                        "Slot1"});
#line 122
 testRunner.And("User sees next Slots on the Capacity Slots page:", ((string)(null)), table8, "And ");
#line 126
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.And("User clicks \"Units\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("User enters \"Capacity Unit 1\" text in the Search field for \"Capacity Unit\" column" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.Then("\"2\" content is displayed in \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.When("User clicks content from \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
 testRunner.Then("\"Capacity Unit 1,All Capacity Units\" is displayed in the dropdown filter for \"Cap" +
                    "acity Units\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.And("Rows counter contains \"2\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table9.AddRow(new string[] {
                        "Slot1"});
            table9.AddRow(new string[] {
                        "Slot2"});
#line 133
 testRunner.And("User sees next Slots on the Capacity Slots page:", ((string)(null)), table9, "And ");
#line 138
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.And("User clicks \"Units\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("User enters \"Capacity Unit 2\" text in the Search field for \"Capacity Unit\" column" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.Then("\"2\" content is displayed in \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.When("User clicks content from \"Slots\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.Then("\"Capacity Unit 2,All Capacity Units\" is displayed in the dropdown filter for \"Cap" +
                    "acity Units\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.And("Rows counter contains \"2\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "slots"});
            table10.AddRow(new string[] {
                        "Slot1"});
            table10.AddRow(new string[] {
                        "Slot3"});
#line 145
 testRunner.And("User sees next Slots on the Capacity Slots page:", ((string)(null)), table10, "And ");
#line 150
 testRunner.When("User clicks \"Capacity\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.And("User selects \"Slots\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table11.AddRow(new string[] {
                        "Slot1"});
            table11.AddRow(new string[] {
                        "Slot2"});
            table11.AddRow(new string[] {
                        "Slot3"});
            table11.AddRow(new string[] {
                        "Slot4"});
#line 152
 testRunner.And("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table11, "And ");
#line 158
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.Then("Success message is displayed and contains \"The selected slots have been deleted\" " +
                    "text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.When("User selects \"Units\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table12.AddRow(new string[] {
                        "Capacity Unit 1"});
            table12.AddRow(new string[] {
                        "Capacity Unit 2"});
#line 164
 testRunner.And("User select \"Capacity Unit\" rows in the grid", ((string)(null)), table12, "And ");
#line 168
 testRunner.And("User clicks Actions button on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.And("User clicks Delete button in Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.And("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("Success message is displayed and contains \"The selected units have been deleted\" " +
                    "text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.When("User selects \"Capacity Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
 testRunner.Then("User selects \"Teams and Paths\" option in \"Capacity Mode\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 176
 testRunner.Then("Success message is displayed and contains \"The project capacity details have been" +
                    " updated\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

