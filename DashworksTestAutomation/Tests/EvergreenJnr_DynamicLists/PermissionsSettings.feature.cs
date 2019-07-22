// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PermissionsSettings")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class PermissionsSettingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PermissionsSettings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PermissionsSettings", "\tRuns Dynamic List permissions setting related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
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
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicListInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicLi" +
                    "st", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_DynamicLists",
                        "PermissionsSettings",
                        "DAS10945",
                        "DAS11553",
                        "DAS10880",
                        "DAS11951",
                        "Cleanup"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 11
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When("User click on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.When("User create dynamic list with \"TestList83C1C0\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("User select \"Everyone can see\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        "Jeremiah S. O\'Connor"});
#line 23
 testRunner.When("User add \"Display Name\" filter where type is \"Equals\" with added column and follo" +
                    "wing value:", ((string)(null)), table1, "When ");
#line 26
 testRunner.Then("Update list option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("Save as a new list option is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS10979")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS11951")]
        [NUnit.Framework.CategoryAttribute("DAS14263")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteListInternal();
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

        private void EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_DynamicLists",
                        "PermissionsSettings",
                        "DAS10979",
                        "DAS11553",
                        "DAS10880",
                        "DAS11951",
                        "DAS14263",
                        "Cleanup"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 31
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User click on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User create dynamic list with \"TestList9507DA\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When("User select \"Specific users / teams\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.When("User clicks the \"ADD TEAM\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("form container is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When("User selects the \"Team 1054\" team for sharing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.And("User select \"Admin\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("User clicks the \"CANCEL\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.When("User select \"Specific users\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("User select \"Admin\" in Select Access dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("User click Add User button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("Delete list button is disabled in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.And("Delete List option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDep" +
            "artmentFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("DAS12941")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDepartmentFilter()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDepartmentFilterInternal();
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

        private void EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDepartmentFilterInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDep" +
                    "artmentFilter", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_DynamicLists",
                        "DAS12941",
                        "Cleanup"});
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 57
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("User add \"Department\" filter where type is \"Equals\" with added column and \"Techno" +
                    "logy\" Tree List option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("\"Department\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("\"7,021\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.When("User create dynamic list with \"DAS12941\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.When("User navigates to the \"DAS12941\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatSharedItemIsNotDuplicatedWhenUserShareItForTheT" +
            "eamToWhichHeAlsoBelongs")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("DAS16228")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatSharedItemIsNotDuplicatedWhenUserShareItForTheTeamToWhichHeAlsoBelongs()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatSharedItemIsNotDuplicatedWhenUserShareItForTheTeamToWhichHeAlsoBelongsInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatSharedItemIsNotDuplicatedWhenUserShareItForTheTeamToWhichHeAlsoBelongsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatSharedItemIsNotDuplicatedWhenUserShareItForTheT" +
                    "eamToWhichHeAlsoBelongs", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_DynamicLists",
                        "DAS16228",
                        "Cleanup"});
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 71
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("User is logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User clicks on the Login link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table2.AddRow(new string[] {
                        "automation_admin1",
                        "m!gration"});
#line 77
 testRunner.When("User login with following credentials:", ((string)(null)), table2, "When ");
#line 80
 testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.When("User click on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.When("User create custom list with \"List_DAS16228\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("\"List_DAS16228\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.When("User select \"Specific users / teams\" sharing option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.When("User clicks the \"ADD TEAM\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.When("User selects the \"Team 1\" team for sharing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.And("User select \"Admin\" in Permission dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("User clicks the \"CANCEL\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("All lists are unique on the Lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserI" +
            "nItemDetails")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DynamicLists")]
        [NUnit.Framework.CategoryAttribute("DAS16405")]
        [NUnit.Framework.CategoryAttribute("DAS16555")]
        public virtual void EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserInItemDetails()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserInItemDetailsInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserInItemDetailsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserI" +
                    "nItemDetails", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_DynamicLists",
                        "DAS16405",
                        "DAS16555"});
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 100
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("User navigates to the \"1803 Rollout\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("\"1803 Rollout\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.Then("Owner Drop-down list is disabled on List details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

