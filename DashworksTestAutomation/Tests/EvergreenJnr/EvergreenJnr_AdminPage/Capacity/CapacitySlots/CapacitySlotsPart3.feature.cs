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
    [NUnit.Framework.DescriptionAttribute("CapacitySlotsPart3")]
    public partial class CapacitySlotsPart3Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacitySlotsPart3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacitySlotsPart3", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideD" +
            "ate")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Override_Dates")]
        [NUnit.Framework.CategoryAttribute("DAS13779")]
        [NUnit.Framework.CategoryAttribute("DAS14176")]
        [NUnit.Framework.CategoryAttribute("DAS14177")]
        [NUnit.Framework.CategoryAttribute("DAS18894")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDate()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDateInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDateInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideD" +
                    "ate", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Override_Dates",
                        "DAS13779",
                        "DAS14176",
                        "DAS14177",
                        "DAS18894",
                        "Cleanup"});
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
                        "ProjectDAS13779",
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
                        "SlotAvailableFrom",
                        "SlotAvailableTo"});
            table2.AddRow(new string[] {
                        "ProjectDAS13779",
                        "SlotDAS13779",
                        "13779",
                        "29 Oct 2018",
                        "29 Oct 2018"});
#line 13
 testRunner.And("User creates new Slot via Api", ((string)(null)), table2, "And ");
#line 16
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User navigates to the \'Override Dates\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("Create Override Date is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("\'CREATE\' button has tooltip with \'Some settings are not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.When("User enters \'29 Oct 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("\'CREATE\' button has tooltip with \'Some settings are not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("\'CREATE\' button has tooltip with \'Some settings are not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User enters \'29 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\'CREATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User selects \'SlotDAS13779\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("User enters \'0\' text to \'Capacity\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User enters \'29 Oct 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("User enters \'29 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User selects \'SlotDAS13779\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User enters \'0\' text to \'Capacity\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Then("\'An override date already exists with this date range\' error message is displayed" +
                    " for \'Override Start Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.Then("\'An override date already exists with this date range\' error message is displayed" +
                    " for \'Override End Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("User sees \"1\" rows in grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForO" +
            "neSlot")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("Override_Dates")]
        [NUnit.Framework.CategoryAttribute("DAS13442")]
        [NUnit.Framework.CategoryAttribute("DAS13440")]
        [NUnit.Framework.CategoryAttribute("DAS17418")]
        [NUnit.Framework.CategoryAttribute("DAS18894")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlot()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlotInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlotInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForO" +
                    "neSlot", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "Override_Dates",
                        "DAS13442",
                        "DAS13440",
                        "DAS17418",
                        "DAS18894",
                        "Cleanup"});
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table3.AddRow(new string[] {
                        "ProjectDAS13442",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 47
 testRunner.When("Project created via API and opened", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName"});
            table4.AddRow(new string[] {
                        "ProjectDAS13442",
                        "Slot13442",
                        "13442"});
#line 50
 testRunner.And("User creates new Slot via Api", ((string)(null)), table4, "And ");
#line 53
 testRunner.And("User navigates to newly created Slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("User navigates to the \'Override Dates\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("User enters \'1 Sep 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("User enters \'7 Sep 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("User selects \'Slot13442\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("\'Your override date has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.And("User enters \'5 Sep 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("User enters \'10 Sep 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("User selects \'Slot13442\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.Then("\'An override date already exists with this date range\' error message is displayed" +
                    " for \'Override Start Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.Then("\'An override date already exists with this date range\' error message is displayed" +
                    " for \'Override End Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table5.AddRow(new string[] {
                        "Slot13442"});
#line 73
 testRunner.When("User select \"Capacity Slot\" rows in the grid", ((string)(null)), table5, "When ");
#line 76
 testRunner.When("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("\'1 slot and 1 related override date will be deleted, do you wish to proceed?\' tex" +
                    "t is displayed on warning inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreen")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13490")]
        public virtual void EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreen()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreenInternal();
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

        private void EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreenInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreen", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13490"});
#line 81
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 82
 testRunner.When("User navigates to \"User Scheduled Test (Jo)\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.Then("\'40\' content is displayed in the \'Monday\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.And("User changes value to \"0\" for \"Monday\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then("\'The capacity slot details have been updated\' text is displayed on inline success" +
                    " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.And("\'0\' content is displayed in the \'Monday\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("User changes value to \"40\" for \"Monday\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectType")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Slots")]
        [NUnit.Framework.CategoryAttribute("DAS13608")]
        [NUnit.Framework.CategoryAttribute("DAS13472")]
        public virtual void EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectType()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectTypeInternal();
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

        private void EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectTypeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectType", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13608",
                        "DAS13472"});
#line 96
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 97
 testRunner.When("User navigates to \"Email Migration\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table6.AddRow(new string[] {
                        "Pre-Migration \\ Scheduled date"});
#line 101
 testRunner.Then("only below options are selected in the \'Tasks\' autocomplete", ((string)(null)), table6, "Then ");
#line 104
 testRunner.When("User clicks on \"Paths\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table7.AddRow(new string[] {
                        "Personal Mailbox"});
            table7.AddRow(new string[] {
                        "Public Folder"});
            table7.AddRow(new string[] {
                        "Shared Mailbox"});
            table7.AddRow(new string[] {
                        "Personal Mailbox - VIP"});
            table7.AddRow(new string[] {
                        "Personal Mailbox - EA"});
#line 105
 testRunner.Then("following checkbox items are displayed in the dropdown:", ((string)(null)), table7, "Then ");
#line 112
 testRunner.When("User selects \'User\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then("\"\" content is displayed in \"Tasks\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.When("User clicks on \"Paths\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table8.AddRow(new string[] {
                        "Standard User"});
            table8.AddRow(new string[] {
                        "VIP User"});
#line 115
 testRunner.Then("following checkbox items are displayed in the dropdown:", ((string)(null)), table8, "Then ");
#line 119
 testRunner.When("User selects \'Application\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("\"\" content is displayed in \"Tasks\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("User clicks on \"Paths\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table9.AddRow(new string[] {
                        "Public Folder"});
            table9.AddRow(new string[] {
                        "Sharepoint Application"});
#line 122
 testRunner.Then("following checkbox items are displayed in the dropdown:", ((string)(null)), table9, "Then ");
#line 126
 testRunner.When("User clicks \'Projects\' header breadcrumb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.And("User clicks Yes button in Leave Page Warning", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.When("User navigates to \"Windows 7 Migration (Computer Scheduled Project)\" project deta" +
                    "ils", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table10.AddRow(new string[] {
                        "Pre-Migration \\ Scheduled Date"});
#line 132
 testRunner.Then("only below options are selected in the \'Tasks\' autocomplete", ((string)(null)), table10, "Then ");
#line 135
 testRunner.When("User clicks on \"Paths\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table11.AddRow(new string[] {
                        "[This is the Default Request Type for Computer)]"});
            table11.AddRow(new string[] {
                        "Computer: PC Rebuild"});
            table11.AddRow(new string[] {
                        "Computer: Workstation Replacement"});
            table11.AddRow(new string[] {
                        "Computer: Laptop Replacement"});
            table11.AddRow(new string[] {
                        "Computer: Virtual Machine"});
#line 136
 testRunner.Then("following checkbox items are displayed in the dropdown:", ((string)(null)), table11, "Then ");
#line 143
 testRunner.When("User selects \'User\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.Then("\"\" content is displayed in \"Tasks\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 145
 testRunner.When("User clicks on \"Paths\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table12.AddRow(new string[] {
                        "[Default (User)]"});
            table12.AddRow(new string[] {
                        "User: No Agent"});
            table12.AddRow(new string[] {
                        "User: VIP"});
            table12.AddRow(new string[] {
                        "User; Maternity"});
#line 146
 testRunner.Then("following checkbox items are displayed in the dropdown:", ((string)(null)), table12, "Then ");
#line 152
 testRunner.When("User selects \'Application\' in the \'Object Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
 testRunner.Then("\"\" content is displayed in \"Tasks\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.When("User clicks on \"Paths\" dropdown on the Capacity Slots page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table13.AddRow(new string[] {
                        "[Default (Application)]"});
            table13.AddRow(new string[] {
                        "Application: Request Type A"});
            table13.AddRow(new string[] {
                        "Application: Request Type B"});
#line 155
 testRunner.Then("following checkbox items are displayed in the dropdown:", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

