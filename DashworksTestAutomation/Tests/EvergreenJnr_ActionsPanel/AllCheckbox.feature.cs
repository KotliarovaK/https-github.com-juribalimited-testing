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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ActionsPanel
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AllCheckbox")]
    public partial class AllCheckboxFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AllCheckbox", "Runs All Checkbox related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("Evergreen_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("AllCheckbox")]
        [NUnit.Framework.CategoryAttribute("DAS10769")]
        [NUnit.Framework.CategoryAttribute("DAS10656")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        public virtual void EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch", new string[] {
                        "Evergreen",
                        "Users",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS10769",
                        "DAS10656",
                        "DAS12602"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("The number of rows selected matches the number of rows of the main object list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table1.AddRow(new string[] {
                        "alain",
                        "42"});
            testRunner.And("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table1, "And ");
            testRunner.And("Select All selectbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User click on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Select All selectbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"42\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"41339\" selected rows are displayed in the Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("Clearing the agGrid Search Box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("Select All selectbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User is deselect all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"0\" selected rows are displayed in the Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("The number of rows selected matches the number of rows of the main object list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Select All selectbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("AllCheckbox")]
        [NUnit.Framework.CategoryAttribute("DAS10775")]
        [NUnit.Framework.CategoryAttribute("DAS10656")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        [NUnit.Framework.TestCaseAttribute("Devices", null)]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "Evergreen_ActionsPanel",
                    "AllCheckbox",
                    "DAS10775",
                    "DAS10656",
                    "DAS12602"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Select all checkbox is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_SearchWithinAllRows")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("Evergreen_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("AllCheckbox")]
        [NUnit.Framework.CategoryAttribute("DAS10772")]
        [NUnit.Framework.CategoryAttribute("DAS10656")]
        [NUnit.Framework.CategoryAttribute("DAS11664")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        public virtual void EvergreenJnr_DevicesList_SearchWithinAllRows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_SearchWithinAllRows", new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS10772",
                        "DAS10656",
                        "DAS11664",
                        "DAS12602"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SearchCriteria",
                        "NumberOfRows"});
            table2.AddRow(new string[] {
                        "Mary",
                        "17"});
            table2.AddRow(new string[] {
                        "Henry",
                        "34"});
            table2.AddRow(new string[] {
                        "Yolande Sylvain",
                        "1"});
            testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                    "s are returned", ((string)(null)), table2, "Then ");
            testRunner.And("Clearing the agGrid Search Box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"17,225\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("AllCheckbox")]
        [NUnit.Framework.CategoryAttribute("DAS10656")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        [NUnit.Framework.TestCaseAttribute("Devices", "17225", "Hostname", "00BDM1JUR8IF419", "17224", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "41339", "Username", "$6BE000-SUDQ9614UVO8", "41338", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "2223", "Application", "\"WPF/E\" (codename) Community Technology Preview (Feb 2007)", "2222", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "14784", "Email Address", "000F977AC8824FE39B8@bclabs.local", "14783", null)]
        public virtual void EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest(string pageName, string selectedRowsCount, string columnname, string selectedRowName, string selectedRowsCountAfterDiselect, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "Evergreen_ActionsPanel",
                    "AllCheckbox",
                    "DAS10656",
                    "DAS12602"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" selected rows are displayed in the Actions panel", selectedRowsCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Select all checkbox is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table3.AddRow(new string[] {
                        string.Format("{0}", selectedRowName)});
            testRunner.And(string.Format("User select \"{0}\" rows in the grid", columnname), ((string)(null)), table3, "And ");
            testRunner.Then(string.Format("\"{0}\" selected rows are displayed in the Actions panel", selectedRowsCountAfterDiselect), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And(string.Format("\"{0}\" selected rows are displayed in the Actions panel", selectedRowsCountAfterDiselect), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditi" +
            "onalColumn")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("AllCheckbox")]
        [NUnit.Framework.CategoryAttribute("DAS10656")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        public virtual void EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditionalColumn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditi" +
                    "onalColumn", new string[] {
                        "Evergreen",
                        "AllLists",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS10656",
                        "DAS12602"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Enabled"});
            table4.AddRow(new string[] {
                        "Username"});
            testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table4, "When ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table5.AddRow(new string[] {
                        "FALSE"});
            table5.AddRow(new string[] {
                        "TRUE"});
            testRunner.When("User add \"Enabled\" filter where type is \"Equals\" with added column and following " +
                    "checkboxes:", ((string)(null)), table5, "When ");
            testRunner.Then("\"Enabled\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("\"41,339\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"41339\" selected rows are displayed in the Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("AllCheckbox")]
        [NUnit.Framework.CategoryAttribute("DAS11894")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick", new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS11894",
                        "DAS12602"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("All checkboxes are checked in the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("The number of rows selected matches the number of rows of the main object list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
