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
namespace DashworksTestAutomation.Tests.EvergreenJnr_StaticLists
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class PermissionsSettingsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PermissionsSettings", "\tRuns Static List permissions setting related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "PermissionsSettings")))
            {
                DashworksTestAutomation.Tests.EvergreenJnr_StaticLists.PermissionsSettingsFeature.FeatureSetup(null);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticLis" +
            "t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PermissionsSettings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_StaticLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PermissionsSettings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS10945")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS11553")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS10880")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticListInternal();
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
        
        private void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticListInternal()
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
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"Static List TestName\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Static List TestName\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Everyone can see\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Last Logon Date"});
            testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "When ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Last Logon Date"});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table2, "Then ");
            testRunner.Then("Update list option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Save as a new list option is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermission" +
            "Level")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PermissionsSettings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_StaticLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PermissionsSettings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS11022")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS11553")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS10880")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Delete_Newly_Created_List")]
        public virtual void EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevel()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevelInternal();
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
        
        private void EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevelInternal()
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
                        "Delete_Newly_Created_List"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"OwnerPrivate\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"OwnerPrivate\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"NotOwnerSpecifiedAdmin\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"NotOwnerSpecifiedAdmin\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select \"Admin\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"NotOwnerSpecifiedEdit\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"NotOwnerSpecifiedEdit\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select \"Edit\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"NotOwnerSpecifiedRead\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"NotOwnerSpecifiedRead\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User select \"Read\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"NotOwnerEveryoneCanEdit\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"NotOwnerEveryoneCanEdit\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Everyone can edit\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User create static list with \"NotOwnerEveryoneCanSee\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"NotOwnerEveryoneCanSee\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Listnames"});
            table3.AddRow(new string[] {
                        "OwnerPrivate"});
            table3.AddRow(new string[] {
                        "NotOwnerSpecifiedAdmin"});
            table3.AddRow(new string[] {
                        "NotOwnerSpecifiedEdit"});
            table3.AddRow(new string[] {
                        "NotOwnerEveryoneCanEdit"});
            testRunner.Then("Following options are available in lists dorpdown:", ((string)(null)), table3, "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
