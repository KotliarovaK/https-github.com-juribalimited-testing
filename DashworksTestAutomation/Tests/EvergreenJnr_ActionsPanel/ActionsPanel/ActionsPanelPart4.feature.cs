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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ActionsPanel.ActionsPanel
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ActionsPanelPart4")]
    public partial class ActionsPanelPart4Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ActionsPanelPart4.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ActionsPanelPart4", "\tRuns Actions Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelBu" +
            "tton")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS12864")]
        [NUnit.Framework.CategoryAttribute("DAS12863")]
        [NUnit.Framework.CategoryAttribute("DAS13277")]
        [NUnit.Framework.CategoryAttribute("DAS16826")]
        public virtual void EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelButton()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelButtonInternal();
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

        private void EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelButtonInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelBu" +
                    "tton", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS12864",
                        "DAS12863",
                        "DAS13277",
                        "DAS16826"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table1.AddRow(new string[] {
                        "00OMQQXWA1DRI6"});
            table1.AddRow(new string[] {
                        "00RUUMAH9OZN9A"});
            table1.AddRow(new string[] {
                        "00SH8162NAS524"});
#line 14
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table1, "When ");
#line 19
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table2.AddRow(new string[] {
                        "Update bucket"});
            table2.AddRow(new string[] {
                        "Update capacity unit"});
            table2.AddRow(new string[] {
                        "Update path"});
            table2.AddRow(new string[] {
                        "Update ring"});
            table2.AddRow(new string[] {
                        "Update task value"});
#line 20
 testRunner.Then("following values are displayed in \"Bulk Update Type\" drop-down on Action panel:", ((string)(null)), table2, "Then ");
#line 27
 testRunner.When("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("User selects \"Babel (English, German and French)\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User selects \"Machines\" Path on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.And("Checkboxes are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsD" +
            "llAndInSelectedSection")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS13074")]
        [NUnit.Framework.CategoryAttribute("Do_Not_Run_With_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Do_Not_Run_With_Projects")]
        public virtual void EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsDllAndInSelectedSection()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsDllAndInSelectedSectionInternal();
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

        private void EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsDllAndInSelectedSectionInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsD" +
                    "llAndInSelectedSection", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS13074",
                        "Do_Not_Run_With_AdminPage",
                        "Do_Not_Run_With_Projects"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 36
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table3.AddRow(new string[] {
                        "00OMQQXWA1DRI6"});
#line 40
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table3, "When ");
#line 43
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Projects"});
            table4.AddRow(new string[] {
                        "*Project K-Computer Scheduled Project"});
            table4.AddRow(new string[] {
                        "1803 Rollout"});
            table4.AddRow(new string[] {
                        "Babel (English, German and French)"});
            table4.AddRow(new string[] {
                        "Barry\'s User Project"});
            table4.AddRow(new string[] {
                        "Computer Scheduled Test (Jo)"});
            table4.AddRow(new string[] {
                        "Devices Evergreen Capacity Project"});
            table4.AddRow(new string[] {
                        "Havoc (Big Data)"});
            table4.AddRow(new string[] {
                        "I-Computer Scheduled Project"});
            table4.AddRow(new string[] {
                        "Migration Project Phase 2 (User Project)"});
            table4.AddRow(new string[] {
                        "Project 00 M Computer Scheduled"});
            table4.AddRow(new string[] {
                        "USE ME FOR AUTOMATION(DEVICE SCHDLD)"});
            table4.AddRow(new string[] {
                        "USE ME FOR AUTOMATION(USR SCHDLD)"});
            table4.AddRow(new string[] {
                        "User Evergreen Capacity Project"});
            table4.AddRow(new string[] {
                        "User Scheduled Test (Jo)"});
            table4.AddRow(new string[] {
                        "Windows 10 Migration - Depot"});
            table4.AddRow(new string[] {
                        "Windows 10 Teams and Request Types"});
            table4.AddRow(new string[] {
                        "Windows 10 Updates - Migration"});
            table4.AddRow(new string[] {
                        "Windows 10 Updates - New York"});
            table4.AddRow(new string[] {
                        "Windows 7 Migration (Computer Scheduled Project)"});
            table4.AddRow(new string[] {
                        "zDevice Sch for Automations Feature"});
            table4.AddRow(new string[] {
                        "zUser Sch for Automations Feature"});
#line 45
 testRunner.Then("the following Projects are displayed in opened DLL on Action panel:", ((string)(null)), table4, "Then ");
#line 68
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.And("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("User is expand \"Project Stages: Windows7Mi\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Computer Information ---- Text fill; Text fill;"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Pre-Migration"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Post Migration"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Migration"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Communication"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Command & Control"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Portal Self Service"});
#line 72
 testRunner.And("the following Column subcategories are displayed for open category:", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOn" +
            "DevicesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS13142")]
        public virtual void EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnDevicesPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnDevicesPageInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnDevicesPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOn" +
                    "DevicesPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS13142"});
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 84
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table6.AddRow(new string[] {
                        "00KLL9S8NRF0X6"});
#line 88
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table6, "When ");
#line 91
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User selects \"Barry\'s User Project\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("User selects \"Desktop Replacement\" Path on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.When("User clears Project field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.And("User clicks on Action drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("\"Barry\'s User Project\" Project is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUs" +
            "ersPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS13142")]
        [NUnit.Framework.CategoryAttribute("DAS16826")]
        public virtual void EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUsersPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUsersPageInternal();
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

        private void EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUsersPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUs" +
                    "ersPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS13142",
                        "DAS16826"});
#line 100
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 101
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table7.AddRow(new string[] {
                        "002B5DC7D4D34D5C895"});
#line 105
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table7, "When ");
#line 108
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table8.AddRow(new string[] {
                        "Update bucket"});
            table8.AddRow(new string[] {
                        "Update capacity unit"});
            table8.AddRow(new string[] {
                        "Update path"});
            table8.AddRow(new string[] {
                        "Update ring"});
            table8.AddRow(new string[] {
                        "Update task value"});
#line 109
 testRunner.Then("following values are displayed in \"Bulk Update Type\" drop-down on Action panel:", ((string)(null)), table8, "Then ");
#line 116
 testRunner.When("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
 testRunner.And("User selects \"Havoc (Big Data)\" Project on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("User selects \"User Request Type 2\" Path on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When("User clears Project field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.And("User clicks on Action drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("\"Havoc (Big Data)\" Project is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

