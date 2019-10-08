﻿// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.EvergreenJnr_GridActions
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ColumnOrder")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class ColumnOrderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ColumnOrder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ColumnOrder", "\tRuns Column Order related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
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
#line 5
#line 6
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS10836")]
        [NUnit.Framework.CategoryAttribute("DAS11666")]
        [NUnit.Framework.CategoryAttribute("DAS12325")]
        public virtual void EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS10836",
                        "DAS11666",
                        "DAS12325"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 11
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When("User have opened column settings for \"Owner Display Name\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When("User have select \"Pin Left\" option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("\"Owner Display Name\" column is \"Left\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table1.AddRow(new string[] {
                        "Smith",
                        "11"});
#line 16
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table1, "Then ");
#line 19
 testRunner.Then("\"Owner Display Name\" column is \"Left\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS10836")]
        [NUnit.Framework.CategoryAttribute("DAS11664")]
        [NUnit.Framework.CategoryAttribute("DAS12325")]
        [NUnit.Framework.CategoryAttribute("DAS14183")]
        public virtual void EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS10836",
                        "DAS11664",
                        "DAS12325",
                        "DAS14183"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 23
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Compliance"});
#line 27
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2, "When ");
#line 30
 testRunner.When("User have opened column settings for \"Compliance\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.When("User have select \"Pin Right\" option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("\"Compliance\" column is \"Right\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table3.AddRow(new string[] {
                        "Smith",
                        "59"});
#line 33
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table3, "Then ");
#line 36
 testRunner.Then("\"Compliance\" column is \"Right\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS10621")]
        [NUnit.Framework.CategoryAttribute("DAS11666")]
        [NUnit.Framework.CategoryAttribute("DAS12156")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        public virtual void EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS10621",
                        "DAS11666",
                        "DAS12156",
                        "DAS12351"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 40
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Compliance"});
            table4.AddRow(new string[] {
                        "Boot Up Date"});
#line 44
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table4, "When ");
#line 48
 testRunner.When("User move \'Boot Up Date\' column to \'Hostname\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        "Hostname"});
            table5.AddRow(new string[] {
                        "Boot Up Date"});
            table5.AddRow(new string[] {
                        "Device Type"});
            table5.AddRow(new string[] {
                        "Operating System"});
            table5.AddRow(new string[] {
                        "Owner Display Name"});
            table5.AddRow(new string[] {
                        "Compliance"});
#line 49
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table5, "Then ");
#line 57
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table6.AddRow(new string[] {
                        "None"});
#line 59
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" with added column a" +
                    "nd following checkboxes:", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        "Hostname"});
            table7.AddRow(new string[] {
                        "Boot Up Date"});
            table7.AddRow(new string[] {
                        "Device Type"});
            table7.AddRow(new string[] {
                        "Operating System"});
            table7.AddRow(new string[] {
                        "Owner Display Name"});
            table7.AddRow(new string[] {
                        "Compliance"});
            table7.AddRow(new string[] {
                        "Windows7Mi: Category"});
#line 62
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumn")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS11666")]
        [NUnit.Framework.CategoryAttribute("DAS12156")]
        public virtual void EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumn", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS11666",
                        "DAS12156"});
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Compliance"});
            table8.AddRow(new string[] {
                        "Email Address"});
#line 74
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table8, "When ");
#line 78
 testRunner.And("User move \'Email Address\' column to \'Username\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User removes \"Distinguished Name\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table9.AddRow(new string[] {
                        "Username"});
            table9.AddRow(new string[] {
                        "Email Address"});
            table9.AddRow(new string[] {
                        "Domain"});
            table9.AddRow(new string[] {
                        "Display Name"});
            table9.AddRow(new string[] {
                        "Compliance"});
#line 82
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table9, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table10.AddRow(new string[] {
                        "User Key"});
#line 89
 testRunner.When("User add following columns using current URL on \"Users\" page:", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table11.AddRow(new string[] {
                        "Username"});
            table11.AddRow(new string[] {
                        "Email Address"});
            table11.AddRow(new string[] {
                        "Domain"});
            table11.AddRow(new string[] {
                        "Display Name"});
            table11.AddRow(new string[] {
                        "Compliance"});
            table11.AddRow(new string[] {
                        "User Key"});
#line 92
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearch")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS11666")]
        [NUnit.Framework.CategoryAttribute("DAS12156")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearch", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS11666",
                        "DAS12156"});
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table12.AddRow(new string[] {
                        "Email Count"});
            table12.AddRow(new string[] {
                        "Import Type"});
#line 103
 testRunner.When("User add following columns using URL to the \"Mailboxes\" page:", ((string)(null)), table12, "When ");
#line 107
 testRunner.When("User move \'Email Count\' column to \'Email Address\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table13.AddRow(new string[] {
                        "Email Address"});
            table13.AddRow(new string[] {
                        "Email Count"});
            table13.AddRow(new string[] {
                        "Mailbox Platform"});
            table13.AddRow(new string[] {
                        "Mail Server"});
            table13.AddRow(new string[] {
                        "Mailbox Type"});
            table13.AddRow(new string[] {
                        "Owner Display Name"});
            table13.AddRow(new string[] {
                        "Import Type"});
#line 108
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table13, "Then ");
#line 117
 testRunner.When("User perform search by \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table14.AddRow(new string[] {
                        "Email Address"});
            table14.AddRow(new string[] {
                        "Email Count"});
            table14.AddRow(new string[] {
                        "Mailbox Platform"});
            table14.AddRow(new string[] {
                        "Mail Server"});
            table14.AddRow(new string[] {
                        "Mailbox Type"});
            table14.AddRow(new string[] {
                        "Owner Display Name"});
            table14.AddRow(new string[] {
                        "Import Type"});
#line 118
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsD" +
            "isplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Columns")]
        [NUnit.Framework.CategoryAttribute("RemoveColumn")]
        [NUnit.Framework.CategoryAttribute("DAS11625")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsDisplayedCorrectly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsD" +
                    "isplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_Columns",
                        "RemoveColumn",
                        "DAS11625"});
#line 129
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 130
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.When("User removes \"Application\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table15.AddRow(new string[] {
                        "Application"});
#line 136
 testRunner.And("ColumnName is removed from the list", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table16.AddRow(new string[] {
                        "Vendor"});
            table16.AddRow(new string[] {
                        "Version"});
#line 139
 testRunner.Then("Column is displayed in following order:", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturne" +
            "dToDefaultPositionWhenActionsPanelWasOpen")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Columns")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS12345")]
        [NUnit.Framework.CategoryAttribute("DAS12823")]
        [NUnit.Framework.CategoryAttribute("DAS13668")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "Device Type", "Operating System", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "Domain", "Display Name", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "Vendor", "Version", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "Mailbox Platform", "Mail Server", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturnedToDefaultPositionWhenActionsPanelWasOpen(string pageName, string firstColumnName, string secondColumnName, string toColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_Columns",
                    "ColumnOrder",
                    "DAS12345",
                    "DAS12823",
                    "DAS13668"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturne" +
                    "dToDefaultPositionWhenActionsPanelWasOpen", null, @__tags);
#line 145
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 146
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.When(string.Format("User move \'{0}\' column to \'{1}\' column", firstColumnName, toColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.And(string.Format("User move \'{0}\' column to \'{1}\' column", secondColumnName, toColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.Then("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.And("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemoved" +
            "AndReturnedToDefaultPosition")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Columns")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS11836")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Owner Display Name", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Distinguished Name", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Version", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Owner Display Name", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedAndReturnedToDefaultPosition(string pageName, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_Columns",
                    "ColumnOrder",
                    "DAS11836"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemoved" +
                    "AndReturnedToDefaultPosition", null, @__tags);
#line 164
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 165
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 166
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 167
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 169
 testRunner.When(string.Format("User removes \"{0}\" column by Column panel", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table17.AddRow(new string[] {
                        string.Format("{0}", columnName)});
#line 170
 testRunner.Then("ColumnName is removed from the list", ((string)(null)), table17, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table18.AddRow(new string[] {
                        string.Format("{0}", columnName)});
#line 173
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table18, "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table19.AddRow(new string[] {
                        string.Format("{0}", columnName)});
#line 176
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table19, "Then ");
#line 179
 testRunner.And("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

