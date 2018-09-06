// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_FiltersFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RemoveFilter")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class RemoveFilterFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RemoveFilter", "Runs Remove Filter related test", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatResetIsUpdatingRowCount")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("RemoveFilter")]
        [NUnit.Framework.CategoryAttribute("DAS11009")]
        public virtual void EvergreenJnr_DevicesList_CheckThatResetIsUpdatingRowCount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatResetIsUpdatingRowCount", new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_FiltersFeature",
                        "RemoveFilter",
                        "DAS11009"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table1.AddRow(new string[] {
                        "Unknown"});
            testRunner.When("User add \"Compliance\" filter where type is \"Equals\" with added column and followi" +
                    "ng checkboxes:", ((string)(null)), table1, "When ");
            testRunner.Then("\"Compliance\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"75\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Compliance\" filter with \"Unknown\" values is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Compliance\" column is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User have reset all filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Compliance"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table2, "Then ");
            testRunner.And("\"17,225\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Compliance\" filter is removed from filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatDeleteByUrlIsUpdatingRowCount")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("RemoveFilter")]
        [NUnit.Framework.CategoryAttribute("DAS11506")]
        public virtual void EvergreenJnr_DevicesList_CheckThatDeleteByUrlIsUpdatingRowCount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatDeleteByUrlIsUpdatingRowCount", new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_FiltersFeature",
                        "RemoveFilter",
                        "DAS11506"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table3.AddRow(new string[] {
                        "Unknown"});
            testRunner.When("User add \"Compliance\" filter where type is \"Equals\" with added column and followi" +
                    "ng checkboxes:", ((string)(null)), table3, "When ");
            testRunner.Then("\"Compliance\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"75\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Compliance\" filter with \"Unknown\" values is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Compliance\" column is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User is remove filter by URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Compliance"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table4, "Then ");
            testRunner.And("\"17,225\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Compliance\" filter is removed from filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatDeletePartOfFilterFromUrlIsUpdatingRowCount")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("RemoveFilter")]
        [NUnit.Framework.CategoryAttribute("DAS11009")]
        [NUnit.Framework.CategoryAttribute("DAS11044")]
        [NUnit.Framework.CategoryAttribute("DAS12199")]
        public virtual void EvergreenJnr_UsersList_CheckThatDeletePartOfFilterFromUrlIsUpdatingRowCount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatDeletePartOfFilterFromUrlIsUpdatingRowCount", new string[] {
                        "Evergreen",
                        "Users",
                        "Evergreen_FiltersFeature",
                        "RemoveFilter",
                        "DAS11009",
                        "DAS11044",
                        "DAS12199"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        "Compliance"});
            table5.AddRow(new string[] {
                        "Username"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table5, "When ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table6.AddRow(new string[] {
                        "Red"});
            table6.AddRow(new string[] {
                        "Amber"});
            table6.AddRow(new string[] {
                        "Green"});
            testRunner.When("User add \"Compliance\" filter where type is \"Equals\" with added column and followi" +
                    "ng checkboxes:", ((string)(null)), table6, "When ");
            testRunner.Then("\"Compliance\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"41,164\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Compliance\" filter with \"Red, Amber, Green\" values is added to URL on \"Users\" pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Compliance\" column is added to URL on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User is remove part of filter URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        "Compliance"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table7, "Then ");
            testRunner.And("\"41,339\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("\"Compliance\" filter is removed from filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatFiltersIsResetAndDataOnTheGridUpdatedBackToTh" +
            "eFullDataSet")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("RemoveFilter")]
        [NUnit.Framework.CategoryAttribute("DAS10996")]
        [NUnit.Framework.CategoryAttribute("DAS12207")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatFiltersIsResetAndDataOnTheGridUpdatedBackToTheFullDataSet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatFiltersIsResetAndDataOnTheGridUpdatedBackToTh" +
                    "eFullDataSet", new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "Evergreen_FiltersFeature",
                        "RemoveFilter",
                        "DAS10996",
                        "DAS12207"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table8.AddRow(new string[] {
                        "London"});
            testRunner.When("User add \"City\" filter where type is \"Equals\" with added column and following che" +
                    "ckboxes:", ((string)(null)), table8, "When ");
            testRunner.Then("\"City\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"3,294\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User have reset all filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"14,784\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"City\" filter is removed from filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
