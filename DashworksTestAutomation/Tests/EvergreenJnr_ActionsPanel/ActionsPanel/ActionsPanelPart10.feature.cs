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
    [NUnit.Framework.DescriptionAttribute("ActionsPanelPart10")]
    public partial class ActionsPanelPart10Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ActionsPanelPart10.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ActionsPanelPart10", "\tRuns Actions Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxS" +
            "copedProjectAreDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14161")]
        public virtual void EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxScopedProjectAreDisplayedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxScopedProjectAreDisplayedCorrectlyInternal();
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

        private void EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxScopedProjectAreDisplayedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxS" +
                    "copedProjectAreDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14161"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table1.AddRow(new string[] {
                        "00BDBAEA57334C7C8F4@bclabs.local"});
            table1.AddRow(new string[] {
                        "016E1B57C2DD4FCC986@bclabs.local"});
#line 14
 testRunner.When("User select \"Email Address\" rows in the grid", ((string)(null)), table1, "When ");
#line 18
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("User selects \"Update bucket\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("User selects \"Project\" Project or Evergreen on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("User selects \"Mailbox Evergreen Capacity Project\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User selects \"Unassigned\" option in \"Bucket\" field on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table2.AddRow(new string[] {
                        "None"});
            table2.AddRow(new string[] {
                        "Owners only"});
            table2.AddRow(new string[] {
                        "All linked users"});
#line 23
 testRunner.Then("following values are displayed in \"Also Move Users\" drop-down on Action panel:", ((string)(null)), table2, "Then ");
#line 28
 testRunner.When("User selects \"Owners only\" option in \"Also Move Users\" drop-down on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("\"UPDATE\" Action button is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnly" +
            "DisplayedEvergreenOrMailboxScopedProjects")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14162")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnlyDisplayedEvergreenOrMailboxScopedProjects()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnlyDisplayedEvergreenOrMailboxScopedProjectsInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnlyDisplayedEvergreenOrMailboxScopedProjectsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnly" +
                    "DisplayedEvergreenOrMailboxScopedProjects", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14162"});
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 33
 testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table3.AddRow(new string[] {
                        "00BDBAEA57334C7C8F4@bclabs.local"});
            table3.AddRow(new string[] {
                        "016E1B57C2DD4FCC986@bclabs.local"});
#line 37
 testRunner.When("User select \"Email Address\" rows in the grid", ((string)(null)), table3, "When ");
#line 41
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User selects \"Update bucket\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("User selects \"Project\" Project or Evergreen on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table4.AddRow(new string[] {
                        "Email Migration"});
            table4.AddRow(new string[] {
                        "Mailbox Evergreen Capacity Project"});
#line 44
 testRunner.Then("following values are displayed in \"Project\" drop-down with searchfield on Action " +
                    "panel:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplic" +
            "ationsList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14164")]
        [NUnit.Framework.CategoryAttribute("DAS16826")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplicationsList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplicationsListInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplicationsListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplic" +
                    "ationsList", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14164",
                        "DAS16826"});
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 51
 testRunner.When("User clicks \"Applications\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("\"Applications\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table5.AddRow(new string[] {
                        "%SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI"});
            table5.AddRow(new string[] {
                        "\"WPF/E\" (codename) Community Technology Preview (Feb 2007)"});
#line 55
 testRunner.When("User select \"Application\" rows in the grid", ((string)(null)), table5, "When ");
#line 59
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table6.AddRow(new string[] {
                        "Update capacity unit"});
            table6.AddRow(new string[] {
                        "Update path"});
            table6.AddRow(new string[] {
                        "Update task value"});
#line 60
 testRunner.Then("following values are displayed in \"Bulk Update Type\" drop-down on Action panel:", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlot")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS15291")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlot()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlotInternal();
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

        private void EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlotInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlot", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS15291",
                        "Not_Run"});
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 68
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table7.AddRow(new string[] {
                        "001BAQXT6JWFPI"});
#line 72
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table7, "When ");
#line 75
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("User selects \"Update task value\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("User selects \"1803 Rollout\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("User selects \"Pre-Migration\" Stage on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User selects \"Scheduled Date\" Task on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User selects \"Update\" Update Date on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User selects \"23 Nov 2018\" Date on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table8.AddRow(new string[] {
                        "None"});
            table8.AddRow(new string[] {
                        "Birmingham Morning"});
            table8.AddRow(new string[] {
                        "Birmingham Afternoon"});
            table8.AddRow(new string[] {
                        "Manchester Morning"});
            table8.AddRow(new string[] {
                        "Manchester Afternoon"});
            table8.AddRow(new string[] {
                        "London - City Morning"});
            table8.AddRow(new string[] {
                        "London - City Afternoon"});
            table8.AddRow(new string[] {
                        "London - Southbank Morning"});
            table8.AddRow(new string[] {
                        "London - Southbank Afternoon"});
#line 84
 testRunner.Then("following values are displayed in \"Capacity Slot\" drop-down on Action panel:", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckDisplayingOfTooltipsInDatePickerOfBulkUpdate")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FilterFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17103")]
        public virtual void EvergreenJnr_AllLists_CheckDisplayingOfTooltipsInDatePickerOfBulkUpdate()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckDisplayingOfTooltipsInDatePickerOfBulkUpdateInternal();
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

        private void EvergreenJnr_AllLists_CheckDisplayingOfTooltipsInDatePickerOfBulkUpdateInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDisplayingOfTooltipsInDatePickerOfBulkUpdate", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_FilterFeature",
                        "FilterFunctionality",
                        "DAS17103"});
#line 97
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 98
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table9.AddRow(new string[] {
                        "00I0COBFWHOF27"});
#line 100
 testRunner.And("User select \"Hostname\" rows in the grid", ((string)(null)), table9, "And ");
#line 103
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("User selects \"Update task value\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("User selects \"1803 Rollout\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("User selects \"Pre-Migration\" Stage on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("User selects \"Scheduled Date\" Task on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("User selects \"Update\" Update Date on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("User selects \"6 Nov 2018\" Date on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("User clicks datepicker for Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("User selects \"6\" day selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("User clicks datepicker for Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.Then("Day with \"5\" number displayed green in Datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.And("Datepicker has tooltip with \"8\" rows for value \"5\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.When("User selects \"5\" day selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table10.AddRow(new string[] {
                        "Birmingham Morning"});
            table10.AddRow(new string[] {
                        "London - City Morning"});
            table10.AddRow(new string[] {
                        "London - Southbank Morning"});
            table10.AddRow(new string[] {
                        "London Depot 09:00 - 11:00"});
            table10.AddRow(new string[] {
                        "London Depot 11:00 - 13:00"});
            table10.AddRow(new string[] {
                        "London Depot 13:00 - 15:00"});
            table10.AddRow(new string[] {
                        "London Depot 15:00 - 17:00"});
#line 116
 testRunner.Then("following values are presented in \"Capacity Slot\" drop-down on Action panel:", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table11.AddRow(new string[] {
                        "Manchester Morning"});
#line 125
 testRunner.And("following values are not presented in \"Capacity Slot\" drop-down on Action panel:", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

