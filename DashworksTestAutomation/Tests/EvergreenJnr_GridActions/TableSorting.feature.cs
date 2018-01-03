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
    [NUnit.Framework.DescriptionAttribute("TableSorting")]
    public partial class TableSortingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TableSorting", "\tRuns Table Sorting related tests", ProgrammingLanguage.CSharp, new string[] {
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
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckSortByDateFunctionality")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("TableSorting")]
        [NUnit.Framework.CategoryAttribute("DAS10612")]
        public virtual void EvergreenJnr_DevicesList_CheckSortByDateFunctionality()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckSortByDateFunctionalityInternal();
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
        
        private void EvergreenJnr_DevicesList_CheckSortByDateFunctionalityInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortByDateFunctionality", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Boot Up Date"});
            table1.AddRow(new string[] {
                        "Windows7Mi: Date & Time Task"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "When ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Boot Up Date"});
            table2.AddRow(new string[] {
                        "Windows7Mi: Date & Time Task"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table2, "Then ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table3.AddRow(new string[] {
                        "Windows XP",
                        "15,152"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table3, "Then ");
            testRunner.When("User click on \'Boot Up Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Boot Up Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Boot Up Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Boot Up Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Windows7Mi: Date & Time Task\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Windows7Mi: Date & Time Task\' column in descending or" +
                    "der", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Windows7Mi: Date & Time Task\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Windows7Mi: Date & Time Task\' column in ascending ord" +
                    "er", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("TableSorting")]
        [NUnit.Framework.CategoryAttribute("DAS10612")]
        public virtual void EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckSortByDateFunctionalityInternal();
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
        
        private void EvergreenJnr_ApplicationsList_CheckSortByDateFunctionalityInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality", new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Applications\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Applications\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Barry\'sUse: Package Delivery Date"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table4, "When ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        "Barry\'sUse: Package Delivery Date"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table5, "Then ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table6.AddRow(new string[] {
                        "Software",
                        "94"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table6, "Then ");
            testRunner.When("User click on \'Barry\'sUse: Package Delivery Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Barry\'sUse: Package Delivery Date\' column in descendi" +
                    "ng order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Barry\'sUse: Package Delivery Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Barry\'sUse: Package Delivery Date\' column in ascendin" +
                    "g order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckSortByDateFunctionality")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("TableSorting")]
        [NUnit.Framework.CategoryAttribute("DAS10612")]
        public virtual void EvergreenJnr_MailboxesList_CheckSortByDateFunctionality()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckSortByDateFunctionalityInternal();
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
        
        private void EvergreenJnr_MailboxesList_CheckSortByDateFunctionalityInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckSortByDateFunctionality", new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        "Created Date"});
            table7.AddRow(new string[] {
                        "EmailMigra: Scheduled date"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table7, "When ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Created Date"});
            table8.AddRow(new string[] {
                        "EmailMigra: Scheduled date"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table8, "Then ");
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table9.AddRow(new string[] {
                        "Sonja",
                        "1"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table9, "Then ");
            testRunner.When("User click on \'Created Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Created Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Created Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Created Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'EmailMigra: Scheduled date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'EmailMigra: Scheduled date\' column in descending orde" +
                    "r", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'EmailMigra: Scheduled date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'EmailMigra: Scheduled date\' column in ascending order" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckSortByDateFunctionality")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("TableSorting")]
        [NUnit.Framework.CategoryAttribute("DAS10612")]
        public virtual void EvergreenJnr_UsersList_CheckSortByDateFunctionality()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckSortByDateFunctionalityInternal();
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
        
        private void EvergreenJnr_UsersList_CheckSortByDateFunctionalityInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckSortByDateFunctionality", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table10.AddRow(new string[] {
                        "Last Logon Date"});
            table10.AddRow(new string[] {
                        "MigrationP: Migrated Date"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table10, "When ");
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table11.AddRow(new string[] {
                        "Last Logon Date"});
            table11.AddRow(new string[] {
                        "MigrationP: Migrated Date"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table11, "Then ");
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table12.AddRow(new string[] {
                        "Tim",
                        "147"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table12, "Then ");
            testRunner.When("User click on \'Last Logon Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Last Logon Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Last Logon Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Last Logon Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'MigrationP: Migrated Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'MigrationP: Migrated Date\' column in descending order" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'MigrationP: Migrated Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'MigrationP: Migrated Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianc" +
            "eColumnOnDevicesList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("TableSorting")]
        [NUnit.Framework.CategoryAttribute("DAS11568")]
        public virtual void EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianceColumnOnDevicesList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianceColumnOnDevicesListInternal();
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
        
        private void EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianceColumnOnDevicesListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianc" +
                    "eColumnOnDevicesList", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS11568"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table13.AddRow(new string[] {
                        "Owner Compliance"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table13, "When ");
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table14.AddRow(new string[] {
                        "Owner Compliance"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table14, "Then ");
            testRunner.Then("\"17,225\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Owner Compliance\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Owner Compliance\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("\"17,225\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
