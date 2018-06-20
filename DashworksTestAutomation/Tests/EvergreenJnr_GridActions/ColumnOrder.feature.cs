﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ColumnOrder")]
    public partial class ColumnOrderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ColumnOrder", "\tRuns Column Order related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearchInternal();
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
        
        private void EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearchInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS10836",
                        "DAS11666",
                        "DAS12325"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User have opened column settings for \"Owner Display Name\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User have select \"Pin Left\" option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Owner Display Name\" column is \"Left\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table1.AddRow(new string[] {
                        "Smith",
                        "11"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table1, "Then ");
            testRunner.Then("\"Owner Display Name\" column is \"Left\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
        public virtual void EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearchInternal();
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
        
        private void EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearchInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS10836",
                        "DAS11664",
                        "DAS12325"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Compliance"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2, "When ");
            testRunner.When("User have opened column settings for \"Compliance\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User have select \"Pin Right\" option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Compliance\" column is \"Right\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table3.AddRow(new string[] {
                        "Smith",
                        "59"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table3, "Then ");
            testRunner.Then("\"Compliance\" column is \"Right\" Pinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilterInternal();
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
        
        private void EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilterInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS10621",
                        "DAS11666",
                        "DAS12156",
                        "DAS12351"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Compliance"});
            table4.AddRow(new string[] {
                        "Boot Up Date"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table4, "When ");
            testRunner.When("User move \'Boot Up Date\' column to \'Hostname\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table5, "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table6.AddRow(new string[] {
                        "None"});
            testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" with added column a" +
                    "nd following checkboxes:", ((string)(null)), table6, "When ");
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
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table7, "Then ");
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumnInternal();
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
        
        private void EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumnInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumn", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS11666",
                        "DAS12156"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Compliance"});
            table8.AddRow(new string[] {
                        "Email Address"});
            testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table8, "When ");
            testRunner.And("User move \'Email Address\' column to \'Username\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User removes \"Distinguished Name\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table9, "Then ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table10.AddRow(new string[] {
                        "User Key"});
            testRunner.When("User add following columns using current URL on \"Users\" page:", ((string)(null)), table10, "When ");
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
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table11, "Then ");
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearchInternal();
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
        
        private void EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearchInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearch", new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_GridActions",
                        "ColumnOrder",
                        "DAS11666",
                        "DAS12156"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table12.AddRow(new string[] {
                        "Email Count"});
            table12.AddRow(new string[] {
                        "Import Type"});
            testRunner.When("User add following columns using URL to the \"Mailboxes\" page:", ((string)(null)), table12, "When ");
            testRunner.When("User move \'Email Count\' column to \'Email Address\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table13, "Then ");
            testRunner.When("User perform search by \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table14, "Then ");
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsDisplayedCorrectlyInternal();
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
        
        private void EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsDisplayedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsD" +
                    "isplayedCorrectly", new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_Columns",
                        "RemoveColumn",
                        "DAS11625"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Applications\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Applications\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User removes \"Application\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Applications\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table15.AddRow(new string[] {
                        "Application"});
            testRunner.And("ColumnName is removed from the list", ((string)(null)), table15, "And ");
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table16.AddRow(new string[] {
                        "Vendor"});
            table16.AddRow(new string[] {
                        "Version"});
            testRunner.Then("Column is displayed in following order:", ((string)(null)), table16, "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturned" +
            "ToDefaultPositionWhenActionsPanelWasOpen")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Columns")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS12345")]
        [NUnit.Framework.CategoryAttribute("DAS12823")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "Device Type", "Operating System", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "Domain", "Display Name", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "Vendor", "Version", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "Mailbox Platform", "Mail Server", new string[0])]
        public virtual void EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturnedToDefaultPositionWhenActionsPanelWasOpen(string pageName, string firstColumnName, string secondColumnName, string toColumnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturnedToDefaultPositionWhenActionsPanelWasOpenInternal(pageName, firstColumnName, secondColumnName, toColumnName, exampleTags);
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
        
        private void EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturnedToDefaultPositionWhenActionsPanelWasOpenInternal(string pageName, string firstColumnName, string secondColumnName, string toColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_Columns",
                    "ColumnOrder",
                    "DAS12345",
                    "DAS12823",
                    "Not_Run"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturned" +
                    "ToDefaultPositionWhenActionsPanelWasOpen", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User move \'{0}\' column to \'{1}\' column", firstColumnName, toColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And(string.Format("User move \'{0}\' column to \'{1}\' column", secondColumnName, toColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedA" +
            "ndReturnedToDefaultPosition")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Columns")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS11836")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Owner Display Name", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "Distinguished Name", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Version", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Owner Display Name", new string[0])]
        public virtual void EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedAndReturnedToDefaultPosition(string pageName, string columnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedAndReturnedToDefaultPositionInternal(pageName, columnName, exampleTags);
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
        
        private void EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedAndReturnedToDefaultPositionInternal(string pageName, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_Columns",
                    "ColumnOrder",
                    "DAS11836"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedA" +
                    "ndReturnedToDefaultPosition", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User removes \"{0}\" column by Column panel", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table17.AddRow(new string[] {
                        string.Format("{0}", columnName)});
            testRunner.Then("ColumnName is removed from the list", ((string)(null)), table17, "Then ");
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table18.AddRow(new string[] {
                        string.Format("{0}", columnName)});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table18, "When ");
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table19.AddRow(new string[] {
                        string.Format("{0}", columnName)});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table19, "Then ");
            testRunner.And("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
