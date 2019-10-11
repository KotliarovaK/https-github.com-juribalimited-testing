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
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("User selects \'Update bucket\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("User selects \'Project\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("User selects \'Mailbox Evergreen Capacity Project\' option from \'Project\' autocompl" +
                    "ete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User selects \'Unassigned\' option from \'Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User selects \'Update bucket\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("User selects \'Project\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table4.AddRow(new string[] {
                        "Email Migration"});
            table4.AddRow(new string[] {
                        "Mailbox Evergreen Capacity Project"});
#line 44
 testRunner.Then("\'Project\' autocomplete contains following options:", ((string)(null)), table4, "Then ");
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table6.AddRow(new string[] {
                        "Update capacity unit"});
            table6.AddRow(new string[] {
                        "Update custom field"});
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
        [NUnit.Framework.CategoryAttribute("DAS18368")]
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
                        "DAS18368",
                        "Not_Run"});
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 70
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table7.AddRow(new string[] {
                        "001BAQXT6JWFPI"});
#line 74
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table7, "When ");
#line 77
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("User selects \'Update task value\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User selects \'1803 Rollout\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User selects \'Pre-Migration\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User selects \'Scheduled Date\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("User selects \'Update\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("User enters \'23 Nov 2018\' text to \'Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
            table8.AddRow(new string[] {
                        "London Depot 09:00 - 11:00"});
            table8.AddRow(new string[] {
                        "London Depot 11:00 - 13:00"});
            table8.AddRow(new string[] {
                        "London Depot 13:00 - 15:00"});
            table8.AddRow(new string[] {
                        "London Depot 15:00 - 17:00"});
#line 84
 testRunner.Then("following values are displayed in \"Capacity Slot\" drop-down on Action panel:", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdate")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("DAS17103")]
        public virtual void EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdate()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdateInternal();
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

        private void EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdateInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdate", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ActionsPanel",
                        "DAS17103"});
#line 101
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 102
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table9.AddRow(new string[] {
                        "00I0COBFWHOF27"});
#line 104
 testRunner.And("User select \"Hostname\" rows in the grid", ((string)(null)), table9, "And ");
#line 107
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("User selects \'Update task value\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("User selects \'1803 Rollout\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("User selects \'Pre-Migration\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("User selects \'Scheduled Date\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("User selects \'Update\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("User enters \'6 Nov 2018\' text to \'Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("User clicks datepicker icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("User selects \'6\' day in the Datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("User waits for three seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("User clicks datepicker icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.Then("\'5\' day is displayed green in the Datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.And("Datepicker has tooltip with \'8\' rows for \'5\' day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.When("User selects \'5\' day in the Datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 122
 testRunner.Then("following values are presented in \"Capacity Slot\" drop-down on Action panel:", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table11.AddRow(new string[] {
                        "Manchester Afternoon"});
#line 131
 testRunner.And("following values are not presented in \"Capacity Slot\" drop-down on Action panel:", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePicker")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("DAS17580")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePicker()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePickerInternal();
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

        private void EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePickerInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePicker", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ActionsPanel",
                        "DAS17580",
                        "Cleanup"});
#line 136
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "SlotName",
                        "DisplayName",
                        "CapacityType",
                        "ObjectType",
                        "Sunday",
                        "Tasks"});
            table12.AddRow(new string[] {
                        "User Evergreen Capacity Project",
                        "slot1",
                        "slot 1",
                        "Capacity Units",
                        "User",
                        "0",
                        "Stage 2 \\ Scheduled Date"});
            table12.AddRow(new string[] {
                        "User Evergreen Capacity Project",
                        "slot2",
                        "slot 2",
                        "Capacity Units",
                        "User",
                        "5",
                        "Stage 2 \\ Scheduled Date"});
            table12.AddRow(new string[] {
                        "User Evergreen Capacity Project",
                        "slot3",
                        "slot 3",
                        "Capacity Units",
                        "User",
                        "",
                        "Stage 2 \\ Scheduled Date"});
#line 137
 testRunner.When("User creates new Slot via Api", ((string)(null)), table12, "When ");
#line 142
 testRunner.And("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table13.AddRow(new string[] {
                        "Exchange Online-ApplicationAccount"});
#line 144
 testRunner.And("User select \"Display Name\" rows in the grid", ((string)(null)), table13, "And ");
#line 147
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("User selects \'Update task value\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("User selects \'User Evergreen Capacity Project\' option from \'Project\' autocomplete" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.And("User selects \'Stage 2\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.And("User selects \'Scheduled Date\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("User selects \'Update\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("User clicks datepicker icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.Then("All \'Sunday\' days are green in the Datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

