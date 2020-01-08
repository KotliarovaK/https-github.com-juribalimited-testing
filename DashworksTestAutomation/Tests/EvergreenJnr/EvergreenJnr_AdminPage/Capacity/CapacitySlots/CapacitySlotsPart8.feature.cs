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
    [NUnit.Framework.DescriptionAttribute("CapacitySlotsPart8")]
    public partial class CapacitySlotsPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacitySlotsPart8.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacitySlotsPart8", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnits" +
            "Type")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("Senior_Projects")]
        [NUnit.Framework.CategoryAttribute("DAS13152")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnitsType()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnitsTypeInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnitsTypeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnits" +
                    "Type", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "Senior_Projects",
                        "DAS13152",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Projects\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ShortName",
                        "Description",
                        "Type"});
            table1.AddRow(new string[] {
                        "ProjectForDAS13152",
                        "13152",
                        "",
                        ""});
#line 14
 testRunner.When("User creates new Project on Senior", ((string)(null)), table1, "When ");
#line 17
 testRunner.And("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("\"Manage Stages\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "StageName"});
            table2.AddRow(new string[] {
                        "Stage13152"});
#line 20
 testRunner.And("User create Stage", ((string)(null)), table2, "And ");
#line 23
 testRunner.And("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("\"Manage Tasks\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.When("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Help",
                        "StagesNameString",
                        "TaskTypeString",
                        "ValueTypeString",
                        "ObjectTypeString",
                        "TaskValuesTemplateString"});
            table3.AddRow(new string[] {
                        "Task13152",
                        "13152",
                        "Stage13152",
                        "Normal",
                        "Date",
                        "Computer",
                        ""});
#line 27
 testRunner.And("User creates Task", ((string)(null)), table3, "And ");
#line 30
 testRunner.Then("Success message is displayed with \"Task successfully created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User publishes the task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("selected task was published", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User clicks \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And("User navigate to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User navigates to \"ProjectForDAS13152\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "CapacityType",
                        "Tasks",
                        "CapacityUnits"});
            table4.AddRow(new string[] {
                        "ProjectForDAS13152",
                        "Slot13152",
                        "13152",
                        "Capacity Units",
                        "Stage13152 \\ Task13152",
                        "Unassigned"});
#line 37
 testRunner.And("User creates new Slot via Api", ((string)(null)), table4, "And ");
#line 40
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table5.AddRow(new string[] {
                        "Stage13152 \\ Task13152"});
#line 43
 testRunner.Then("only below options are selected in the \'Tasks\' autocomplete", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table6.AddRow(new string[] {
                        "Unassigned"});
#line 46
 testRunner.Then("only below options are selected in the \'Capacity Units\' autocomplete", ((string)(null)), table6, "Then ");
#line 49
 testRunner.And("\'Device\' content is displayed in \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.When("User selects \'Application\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.And("User checks \'Unassigned\' option after search from \'Capacity Units\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("\'The capacity slot details have been updated\' text is displayed on inline success" +
                    " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\"\" content is displayed in \"Tasks\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("\"All Capacity Units\" content is displayed in \"Capacity Units\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.And("\'Application\' content is displayed in \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndReque" +
            "stTypes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("Senior_Projects")]
        [NUnit.Framework.CategoryAttribute("DAS13152")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypes()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypesInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndReque" +
                    "stTypes", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "Senior_Projects",
                        "DAS13152",
                        "Cleanup"});
#line 60
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 61
 testRunner.When("User clicks \'Projects\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ShortName",
                        "Description",
                        "Type"});
            table7.AddRow(new string[] {
                        "ProjectForDAS13152",
                        "13152",
                        "",
                        ""});
#line 65
 testRunner.When("User creates new Project on Senior", ((string)(null)), table7, "When ");
#line 68
 testRunner.And("User navigate to \"Stages\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("\"Manage Stages\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.When("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "StageName"});
            table8.AddRow(new string[] {
                        "Stage13152"});
#line 71
 testRunner.And("User create Stage", ((string)(null)), table8, "And ");
#line 74
 testRunner.And("User clicks \"Create Stage\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("User navigate to \"Tasks\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then("\"Manage Tasks\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("User clicks \"Create Task\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Help",
                        "StagesNameString",
                        "TaskTypeString",
                        "ValueTypeString",
                        "ObjectTypeString",
                        "TaskValuesTemplateString",
                        "ApplyToAllCheckbox"});
            table9.AddRow(new string[] {
                        "Task13152",
                        "13152 Date",
                        "Stage13152",
                        "Normal",
                        "Date",
                        "Computer",
                        "",
                        "true"});
#line 78
 testRunner.And("User creates Task", ((string)(null)), table9, "And ");
#line 81
 testRunner.Then("Success message is displayed with \"Task successfully created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("User publishes the task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("selected task was published", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User clicks \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.And("User navigate to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("User navigates to \"ProjectForDAS13152\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User clicks \'CREATE SLOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("User enters \'Slot13152\' text to \'Slot Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("User enters \'13152\' text to \'Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User selects \'Teams and Paths\' in the \'Capacity Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("User checks \'Stage13152 \\ Task13152\' option after search from \'Tasks\' autocomplet" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.And("User checks \'Admin IT\' option after search from \'Teams\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("User checks \'[Default (Computer)]\' option after search from \'Paths\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When("User selects \'Device\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("\'Your capacity slot has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("\'Teams and Paths\' value is displayed in the \'Capacity Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table10.AddRow(new string[] {
                        "Stage13152 \\ Task13152"});
#line 103
 testRunner.Then("only below options are selected in the \'Tasks\' autocomplete", ((string)(null)), table10, "Then ");
#line 106
 testRunner.And("\'Device\' content is displayed in \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table11.AddRow(new string[] {
                        "[Default (Computer)]"});
#line 107
 testRunner.Then("only below options are selected in the \'Paths\' autocomplete", ((string)(null)), table11, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table12.AddRow(new string[] {
                        "Admin IT"});
#line 110
 testRunner.Then("only below options are selected in the \'Teams\' autocomplete", ((string)(null)), table12, "Then ");
#line 114
 testRunner.When("User selects \'Application\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.And("User checks \'Admin IT\' option after search from \'Teams\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("User checks \'1803 Team\' option after search from \'Teams\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("User checks \'[Default (Application)]\' option after search from \'Paths\' autocomple" +
                    "te", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.Then("\'The capacity slot details have been updated\' text is displayed on inline success" +
                    " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("\'Teams and Paths\' content is displayed in \'Capacity Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.And("\'Application\' content is displayed in \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table13.AddRow(new string[] {
                        "[Default (Application)]"});
            table13.AddRow(new string[] {
                        "[Default (Computer)]"});
#line 124
 testRunner.Then("only below options are selected in the \'Paths\' autocomplete", ((string)(null)), table13, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table14.AddRow(new string[] {
                        "1803 Team"});
#line 128
 testRunner.Then("only below options are selected in the \'Teams\' autocomplete", ((string)(null)), table14, "Then ");
#line 131
 testRunner.When("User selects \'Capacity Units\' in the \'Capacity Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("\'Capacity Units\' content is displayed in \'Capacity Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectF" +
            "ilteredLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS14967")]
        [NUnit.Framework.CategoryAttribute("DAS15291")]
        [NUnit.Framework.CategoryAttribute("DAS18538")]
        [NUnit.Framework.CategoryAttribute("DAS14967")]
        [NUnit.Framework.TestCaseAttribute("Devices", null)]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", null)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectFilteredLists(string listName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectFilteredListsInternal(listName,exampleTags);
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

        private void EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectFilteredListsInternal(string listName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Units",
                    "DAS14967",
                    "DAS15291",
                    "DAS18538",
                    "DAS14967"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectF" +
                    "ilteredLists", null, @__tags);
#line 138
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 139
 testRunner.When("User navigates to \"User Evergreen Capacity Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table15.AddRow(new string[] {
                        "User Slot 1"});
            table15.AddRow(new string[] {
                        "User Slot 2"});
            table15.AddRow(new string[] {
                        "Device Slot 1"});
            table15.AddRow(new string[] {
                        "Device Slot 2"});
            table15.AddRow(new string[] {
                        "Application Slot 1"});
            table15.AddRow(new string[] {
                        "Application Slot 2"});
#line 142
 testRunner.Then("Content in the \'Capacity Slot\' column is equal to", ((string)(null)), table15, "Then ");
#line 150
 testRunner.When("User navigates to the \'Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.And("User enters \"Evergreen Capacity Unit 3\" text in the Search field for \"Capacity Un" +
                    "it\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And(string.Format("User remembers value in \"{0}\" column", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And(string.Format("User clicks content from \"{0}\" column", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.And("Rows counter number equals to remembered value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.And("\"UserEvergr: Capacity Unit\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table16.AddRow(new string[] {
                        "Evergreen Capacity Unit 3"});
#line 159
 testRunner.And("Values is displayed in added filter info", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table17.AddRow(new string[] {
                        "is"});
#line 162
 testRunner.And("Options is displayed in added filter info", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectF" +
            "ilteredLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS14967")]
        [NUnit.Framework.CategoryAttribute("DAS15291")]
        [NUnit.Framework.CategoryAttribute("DAS18538")]
        [NUnit.Framework.CategoryAttribute("DAS14967")]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", null)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectFilteredLists(string listName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectFilteredListsInternal(listName,exampleTags);
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

        private void EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectFilteredListsInternal(string listName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Units",
                    "DAS14967",
                    "DAS15291",
                    "DAS18538",
                    "DAS14967"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectF" +
                    "ilteredLists", null, @__tags);
#line 173
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 174
 testRunner.When("User navigates to \"Mailbox Evergreen Capacity Project\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 175
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table18.AddRow(new string[] {
                        "CA -Mailbox-Nov 1, 2018-Nov 10, 2018"});
            table18.AddRow(new string[] {
                        "CA -Mailbox-Nov 11, 2018-Nov 30, 2018"});
            table18.AddRow(new string[] {
                        "TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\\RT=A\\T=Admin"});
            table18.AddRow(new string[] {
                        "TRT-Dec 1, 2018-Dec 31, 2018 - Unlimited"});
            table18.AddRow(new string[] {
                        "CA-Mailbox-Jan 1, 2018-Oct 31, 2018"});
#line 177
 testRunner.Then("Content in the \'Capacity Slot\' column is equal to", ((string)(null)), table18, "Then ");
#line 184
 testRunner.When("User navigates to the \'Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 185
 testRunner.And("User enters \"Unassigned\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
 testRunner.And(string.Format("User remembers value in \"{0}\" column", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.And(string.Format("User clicks content from \"{0}\" column", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 189
 testRunner.And("Rows counter number equals to remembered value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 191
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 192
 testRunner.And("\"MailboxEve: Capacity Unit\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table19.AddRow(new string[] {
                        "Unassigned"});
#line 193
 testRunner.And("Values is displayed in added filter info", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table20.AddRow(new string[] {
                        "is"});
#line 196
 testRunner.And("Options is displayed in added filter info", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

