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
namespace DashworksTestAutomation.Tests.EvergreenJnr_DynamicLists
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PermissionsSettings")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class PermissionsSettingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PermissionsSettings", "\tRuns Dynamic List permissions setting related tests", ProgrammingLanguage.CSharp, new string[] {
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
        
        
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicLi" +
            "st")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS10945")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS11951")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicLi" +
                    "st", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_DynamicLists",
                        "PermissionsSettings",
                        "DAS10945",
                        "DAS11553",
                        "DAS10880",
                        "DAS11951",
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User create dynamic list with \"TestList83C1C0\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Everyone can see\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        "Jeremiah S. O\'Connor"});
            testRunner.When("User add \"Display Name\" filter where type is \"Equals\" with added column and follo" +
                    "wing value:", ((string)(null)), table1, "When ");
            testRunner.Then("Update list option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save as a new list option is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS10979")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS11951")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_DynamicLists",
                        "PermissionsSettings",
                        "DAS10979",
                        "DAS11553",
                        "DAS10880",
                        "DAS11951",
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User create dynamic list with \"TestList9507DA\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Admin\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Delete list button is disabled in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Delete List option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        
        
        
        
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDep" +
            "artmentFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS12941")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDepartmentFilter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDep" +
                    "artmentFilter", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_DynamicLists",
                        "PermissionsSettings",
                        "DAS12941",
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User add \"Department\" filter where type is \"Equals\" with added column and \"Techno" +
                    "logy\" Tree List option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User create dynamic list with \"List12941\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User navigates to the \"List12941\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
