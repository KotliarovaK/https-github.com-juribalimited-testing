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
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GridActions")]
        [NUnit.Framework.CategoryAttribute("ColumnOrder")]
        [NUnit.Framework.CategoryAttribute("DAS10836")]
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
                        "DAS10836"});
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
                        "DAS10836"});
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
                        "DAS10621"});
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
    }
}
#pragma warning restore
#endregion
