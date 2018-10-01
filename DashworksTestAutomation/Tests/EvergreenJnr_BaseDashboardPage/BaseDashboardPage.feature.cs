// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.EvergreenJnr_BaseDashboardPage
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BaseDashboardPage")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class BaseDashboardPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BaseDashboardPage", "\tRuns Base Dashboard Page related tests", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckThatColumnHeaderFontWidthConformsToDesign")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS11656")]
        [NUnit.Framework.TestCaseAttribute("Devices", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", new string[0])]
        public virtual void EvergreenJnr_AllList_CheckThatColumnHeaderFontWidthConformsToDesign(string listName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_BaseDashboardPage",
                    "BaseDashboardPage",
                    "DAS11656"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatColumnHeaderFontWidthConformsToDesign", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Appropriate header font weight is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"v5.2.9.0\" Application version is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckDefaultSortOrderOnTheLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS11618")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", new string[0])]
        public virtual void EvergreenJnr_AllList_CheckDefaultSortOrderOnTheLists(string listName, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_BaseDashboardPage",
                    "BaseDashboardPage",
                    "DAS11618"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckDefaultSortOrderOnTheLists", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then(string.Format("The first cell of the table matches to default sorting \"{0}\" list", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then(string.Format("data in the table is sorted by \"{0}\" column in ascending order by default", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatSaveListFunctionIsAvailableAfterSortingColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS11988")]
        [NUnit.Framework.CategoryAttribute("DAS10972")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "Device Type", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "Domain", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "Vendor", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "Mailbox Platform", new string[0])]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveListFunctionIsAvailableAfterSortingColumns(string listName, string columnName, string addSortOrders, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_BaseDashboardPage",
                    "BaseDashboardPage",
                    "DAS11988",
                    "DAS10972"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSaveListFunctionIsAvailableAfterSortingColumns", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When(string.Format("User click on \'{0}\' column header", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When(string.Format("User click on \'{0}\' column header", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckThatNoConsoleErrorsAreDisplayedAfterQuicklyNavigateBetw" +
            "eenMainTabs")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS11895")]
        public virtual void EvergreenJnr_AllList_CheckThatNoConsoleErrorsAreDisplayedAfterQuicklyNavigateBetweenMainTabs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatNoConsoleErrorsAreDisplayedAfterQuicklyNavigateBetw" +
                    "eenMainTabs", new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_BaseDashboardPage",
                        "BaseDashboardPage",
                        "DAS11895"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User quickly navigate to \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User quickly navigate to \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User quickly navigate to \"Applications\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User quickly navigate to \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatURLsAreUpdatedAfterAddingSortingAndColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS12174")]
        public virtual void EvergreenJnr_DevicesList_CheckThatURLsAreUpdatedAfterAddingSortingAndColumns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatURLsAreUpdatedAfterAddingSortingAndColumns", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_BaseDashboardPage",
                        "BaseDashboardPage",
                        "DAS12174"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Owner Cost Centre"});
            table1.AddRow(new string[] {
                        "ComputerSc: In Scope"});
            table1.AddRow(new string[] {
                        "Windows7Mi: Object ID"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "When ");
            testRunner.Then("\"Cost Centre\" column is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"ComputerSc: In Scope\" column is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"Windows7Mi: Object ID\" column is added to URL on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User click on \'Owner Cost Centre\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Owner Cost Centre\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Ascending order sorted on \"Owner Cost Centre\" column is displayed in URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("default URL is displayed on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatURLsAreUpdatedAfterAddingFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS12174")]
        [NUnit.Framework.CategoryAttribute("DAS13001")]
        public virtual void EvergreenJnr_UsersList_CheckThatURLsAreUpdatedAfterAddingFilters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatURLsAreUpdatedAfterAddingFilters", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_BaseDashboardPage",
                        "BaseDashboardPage",
                        "DAS12174",
                        "DAS13001"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table2.AddRow(new string[] {
                        "Red"});
            testRunner.When("User add \"Compliance\" filter where type is \"Equals\" with added column and followi" +
                    "ng checkboxes:", ((string)(null)), table2, "When ");
            testRunner.Then("\"Compliance\" column is added to URL on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table3.AddRow(new string[] {
                        "Green"});
            testRunner.When("User add \"Compliance\" filter where type is \"Equals\" with added column and followi" +
                    "ng checkboxes:", ((string)(null)), table3, "When ");
            testRunner.Then("Appropriate filter is added to URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("default URL is displayed on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User add \"Babel(Engl: Readiness\" filter where type is \"Equals\" with added column " +
                    "and \"Blue\" Lookup option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Appropriate filter is added to URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatActionsDetailsColumnsFiltersButtonsAreNotClicka" +
            "bleWhenOpenedNotificationsAndUserProfilesDropdownBlocks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS11641")]
        public virtual void EvergreenJnr_DevicesList_CheckThatActionsDetailsColumnsFiltersButtonsAreNotClickableWhenOpenedNotificationsAndUserProfilesDropdownBlocks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatActionsDetailsColumnsFiltersButtonsAreNotClicka" +
                    "bleWhenOpenedNotificationsAndUserProfilesDropdownBlocks", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_BaseDashboardPage",
                        "BaseDashboardPage",
                        "DAS11641"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Account Profile dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Account Profile menu is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click User Notifications button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Notifications message is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckThatEditListFunctionIsAvailableAfterSortingColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS10972")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "Device Type", "UserSchedu: Readiness ID", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "Domain", "UserSchedu: Readiness ID", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "Vendor", "UserSchedu: Readiness ID", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "Mailbox Platform", "EmailMigra: Readiness ID", new string[0])]
        public virtual void EvergreenJnr_AllList_CheckThatEditListFunctionIsAvailableAfterSortingColumns(string listName, string columnName, string addSortOrders, string addColumn, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_BaseDashboardPage",
                    "BaseDashboardPage",
                    "DAS10972",
                    "DAS12602",
                    "Delete_Newly_Created_List"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatEditListFunctionIsAvailableAfterSortingColumns", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        string.Format("{0}", addColumn)});
            testRunner.And("User adds columns to the list", ((string)(null)), table4, "And ");
            testRunner.When(string.Format("User create dynamic list with \"DynamicList1\" name on \"{0}\" page", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User selects \"Create static list\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User create static list with \"StaticList1\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", addSortOrders), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User click on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatToolTipIsDisplayedWithCreateProjectButtonFromAn" +
            "UnsavedList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS11693")]
        [NUnit.Framework.CategoryAttribute("DAS12867")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        public virtual void EvergreenJnr_DevicesList_CheckThatToolTipIsDisplayedWithCreateProjectButtonFromAnUnsavedList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatToolTipIsDisplayedWithCreateProjectButtonFromAn" +
                    "UnsavedList", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_BaseDashboardPage",
                        "BaseDashboardPage",
                        "DAS11693",
                        "DAS12867",
                        "DAS12999",
                        "Projects"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Applications\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Applications\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Create button is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Hostname\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Create button on the Base Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("tooltip is displayed with \"This list must be saved before using it to create a pr" +
                    "oject\" text for Create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Create Project button is disabled on the Base Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatEmptyLinkIsDisplayedIfThereAreNoData")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("BaseDashboardPage")]
        [NUnit.Framework.CategoryAttribute("DAS12337")]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", new string[0])]
        public virtual void EvergreenJnr_AllLists_CheckThatEmptyLinkIsDisplayedIfThereAreNoData(string listName, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_BaseDashboardPage",
                    "BaseDashboardPage",
                    "DAS12337"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatEmptyLinkIsDisplayedIfThereAreNoData", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then(string.Format("Empty link is displayed for first row in the \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
