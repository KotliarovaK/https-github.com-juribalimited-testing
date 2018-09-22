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
namespace DashworksTestAutomation.Tests.EvergreenJnr_StaticLists
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PermissionsSettings")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class PermissionsSettingsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PermissionsSettings", "Runs Static List permissions setting related tests", ProgrammingLanguage.CSharp, new string[] {
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
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticLis" +
            "t")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_StaticLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS10945")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS12152")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticLis" +
                    "t", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_StaticLists",
                        "PermissionsSettings",
                        "DAS10945",
                        "DAS11553",
                        "DAS10880",
                        "DAS12152",
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table1.AddRow(new string[] {
                        ""});
            testRunner.When("User create static list with \"Static List TestName23\" name on \"Users\" page with f" +
                    "ollowing items", ((string)(null)), table1, "When ");
            testRunner.Then("\"Static List TestName23\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Everyone can see\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Last Logon Date"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2, "When ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table3.AddRow(new string[] {
                        "Last Logon Date"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table3, "Then ");
            testRunner.Then("Update list option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save as a new list option is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermission" +
            "Level")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_StaticLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS11022")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS12152")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermission" +
                    "Level", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_StaticLists",
                        "PermissionsSettings",
                        "DAS11022",
                        "DAS11553",
                        "DAS10880",
                        "DAS12152",
                        "DAS12602",
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table4.AddRow(new string[] {
                        "001BAQXT6JWFPI"});
            table4.AddRow(new string[] {
                        "00HA7MKAVVFDAV"});
            table4.AddRow(new string[] {
                        "2ML5YDWPRLFWW55"});
            table4.AddRow(new string[] {
                        "700ZHPQ6661CV1N"});
            testRunner.When("User create static list with \"OwnerPrivate\" name on \"Devices\" page with following" +
                    " items", ((string)(null)), table4, "When ");
            testRunner.Then("\"OwnerPrivate\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table5.AddRow(new string[] {
                        "ZZHYOLP1V7STML"});
            table5.AddRow(new string[] {
                        "VMI480Z5UKTLLK"});
            table5.AddRow(new string[] {
                        "6B512UPQFLSOVF"});
            table5.AddRow(new string[] {
                        "CLUSTERSSAS"});
            testRunner.When("User create static list with \"NotOwnerSpecifiedAdmin\" name on \"Devices\" page with" +
                    " following items", ((string)(null)), table5, "When ");
            testRunner.Then("\"NotOwnerSpecifiedAdmin\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Admin\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table6.AddRow(new string[] {
                        "07PZNEOU91VWVH"});
            table6.AddRow(new string[] {
                        "0A88YQHT6IMTTZ"});
            table6.AddRow(new string[] {
                        "0CFTD5FV5F7FDF"});
            table6.AddRow(new string[] {
                        "0E9XQC02MAZUR2"});
            testRunner.When("User create static list with \"NotOwnerSpecifiedEdit\" name on \"Devices\" page with " +
                    "following items", ((string)(null)), table6, "When ");
            testRunner.Then("\"NotOwnerSpecifiedEdit\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Edit\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table7.AddRow(new string[] {
                        "VMI480Z5UKTLLK"});
            table7.AddRow(new string[] {
                        "6B512UPQFLSOVF"});
            table7.AddRow(new string[] {
                        "0CFTD5FV5F7FDF"});
            table7.AddRow(new string[] {
                        "0E9XQC02MAZUR2"});
            testRunner.When("User create static list with \"NotOwnerSpecifiedRead\" name on \"Devices\" page with " +
                    "following items", ((string)(null)), table7, "When ");
            testRunner.Then("\"NotOwnerSpecifiedRead\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Read\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table8.AddRow(new string[] {
                        "TVGU1Y24UU9QBQ"});
            table8.AddRow(new string[] {
                        "O0DOUNEKCY7HXK"});
            table8.AddRow(new string[] {
                        "5PH0YQ5TNBLFZBM"});
            table8.AddRow(new string[] {
                        "SANOFI2-POC"});
            testRunner.When("User create static list with \"NotOwnerEveryoneCanEdit\" name on \"Devices\" page wit" +
                    "h following items", ((string)(null)), table8, "When ");
            testRunner.Then("\"NotOwnerEveryoneCanEdit\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Everyone can edit\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table9.AddRow(new string[] {
                        "9K9Y2LGOD3Z1KW"});
            table9.AddRow(new string[] {
                        "HW9RNYX1SNE3BN"});
            table9.AddRow(new string[] {
                        "CAS"});
            table9.AddRow(new string[] {
                        "WIN8RETAILPRO"});
            testRunner.When("User create static list with \"NotOwnerEveryoneCanSee\" name on \"Devices\" page with" +
                    " following items", ((string)(null)), table9, "When ");
            testRunner.Then("\"NotOwnerEveryoneCanSee\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Everyone can see\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select \"Add to static list\" option in Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Listnames"});
            table10.AddRow(new string[] {
                        "NotOwnerEveryoneCanEdit"});
            table10.AddRow(new string[] {
                        "NotOwnerSpecifiedAdmin"});
            table10.AddRow(new string[] {
                        "NotOwnerSpecifiedEdit"});
            table10.AddRow(new string[] {
                        "OwnerPrivate"});
            testRunner.Then("Following options are available in lists dropdown:", ((string)(null)), table10, "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
