﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_Columns
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AddColumnActionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddColumnAction", "\tRuns Add column related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "AddColumnAction")))
            {
                global::DashworksTestAutomation.Tests.EvergreenJnr_Columns.AddColumnActionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("Login link is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks on the Login link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_DevicesList_Add the Device key column to the devices list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddColumnAction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_Columns")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddColumnAction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10665")]
        public virtual void EvergreenJnr_DevicesList_AddTheDeviceKeyColumnToTheDevicesList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_Add the Device key column to the devices list", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Columns",
                        "AddColumnAction",
                        "DAS-10665"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Device Key"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "When ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Device Key"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table2, "Then ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table3.AddRow(new string[] {
                        "Device Key"});
            testRunner.And("Content is present in the newly added column", ((string)(null)), table3, "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
