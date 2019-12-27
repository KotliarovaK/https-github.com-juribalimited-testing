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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.UsersDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Offboard_UsersPage")]
    public partial class Offboard_UsersPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Offboard_UsersPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Offboard_UsersPage", "\tRuns Offboard Users Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 4
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
            "owWithNoAssotiatedDevicesOnUsersPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Offboard")]
        [NUnit.Framework.CategoryAttribute("DAS17964")]
        [NUnit.Framework.CategoryAttribute("DAS17990")]
        [NUnit.Framework.CategoryAttribute("DAS17000")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnUsersPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnUsersPageInternal();
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

        private void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnUsersPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
                    "owWithNoAssotiatedDevicesOnUsersPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "Offboard",
                        "DAS17964",
                        "DAS17990",
                        "DAS17000",
                        "Cleanup",
                        "Not_Ready"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 12
 testRunner.When("User navigates to the \'User\' details page for \'01F6D54271D74F1BB8D\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Details page for \'01F6D54271D74F1BB8D\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("User switches to the \"USE ME FOR AUTOMATION(USR SCHDLD)\" project in the Top bar o" +
                    "n Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Hostname"});
            table1.AddRow(new string[] {
                        "Owned"});
#line 20
 testRunner.And("following columns are displayed on the Item details page:", ((string)(null)), table1, "And ");
#line 24
 testRunner.When("User deselect all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table2.AddRow(new string[] {
                        "02X387UQLFP3ISU"});
#line 25
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table2, "When ");
#line 28
 testRunner.Then("\"02X387UQLFP3ISU\" chip have tooltip with \"02X387UQLFP3ISU\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User enters \"USE ME FOR AUTOMATION(USR SCHDLD)\" text in the Search field for \"Pro" +
                    "ject\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("User navigates to the \'History\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("\'01F6D54271D74F1BB8D\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And("\'02X387UQLFP3ISU\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("\'03AK1ZP1C9MPFV\' content is not displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
            "owWithAssotiatedDevicesOnUsersPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Offboard")]
        [NUnit.Framework.CategoryAttribute("DAS17964")]
        [NUnit.Framework.CategoryAttribute("DAS17990")]
        [NUnit.Framework.CategoryAttribute("DAS17000")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPageInternal();
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

        private void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
                    "owWithAssotiatedDevicesOnUsersPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "Offboard",
                        "DAS17964",
                        "DAS17990",
                        "DAS17000",
                        "Cleanup",
                        "Not_Ready"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 48
 testRunner.When("User navigates to the \'User\' details page for \'01F6D54271D74F1BB8D\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("Details page for \'01F6D54271D74F1BB8D\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.When("User switches to the \"USE ME FOR AUTOMATION(USR SCHDLD)\" project in the Top bar o" +
                    "n Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table3.AddRow(new string[] {
                        "Hostname"});
            table3.AddRow(new string[] {
                        "Owned"});
#line 56
 testRunner.And("following columns are displayed on the Item details page:", ((string)(null)), table3, "And ");
#line 60
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("User enters \"USE ME FOR AUTOMATION(USR SCHDLD)\" text in the Search field for \"Pro" +
                    "ject\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("User navigates to the \'History\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("\'01F6D54271D74F1BB8D\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.And("\'02X387UQLFP3ISU\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
            "owWithoutUserOnUsersPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Offboard")]
        [NUnit.Framework.CategoryAttribute("DAS17964")]
        [NUnit.Framework.CategoryAttribute("DAS17990")]
        [NUnit.Framework.CategoryAttribute("DAS17000")]
        public virtual void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnUsersPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnUsersPageInternal();
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

        private void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnUsersPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
                    "owWithoutUserOnUsersPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "Offboard",
                        "DAS17964",
                        "DAS17990",
                        "DAS17000"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 76
 testRunner.When("User navigates to the \'User\' details page for \'0088FC8A50DD4344B92\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("Details page for \'0088FC8A50DD4344B92\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User switches to the \"USE ME FOR AUTOMATION(USR SCHDLD)\" project in the Top bar o" +
                    "n Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.And("\'Offboarding user BCLABS\\0088FC8A50DD4344B92 (Barland, Steinar). Offboarding an o" +
                    "bject deletes all project related information about it.\' text is displayed on po" +
                    "pup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

