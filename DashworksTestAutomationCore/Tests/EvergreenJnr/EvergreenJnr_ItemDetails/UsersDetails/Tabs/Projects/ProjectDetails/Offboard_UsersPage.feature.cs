﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.UsersDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Offboard_UsersPage", Description="\tRuns Offboard Users Page related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\UsersDetails\\Tabs\\Projects\\ProjectDet" +
        "ails\\Offboard_UsersPage.feature", SourceLine=0)]
    public partial class Offboard_UsersPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Offboard_UsersPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Offboard_UsersPage", "\tRuns Offboard Users Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
            "owWithNoAssotiatedDevicesOnUsersPage", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "Offboard",
                "DAS17964",
                "DAS17990",
                "DAS17000",
                "Cleanup",
                "Not_Ready"}, SourceLine=10)]
        public virtual void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnUsersPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "Offboard",
                    "DAS17964",
                    "DAS17990",
                    "DAS17000",
                    "Cleanup",
                    "Not_Ready"};
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
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 12
 testRunner.When("User navigates to the \'User\' details page for \'01F6D54271D74F1BB8D\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Details page for \'01F6D54271D74F1BB8D\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3280 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3280.AddRow(new string[] {
                            "Hostname"});
                table3280.AddRow(new string[] {
                            "Owned"});
#line 20
 testRunner.And("following columns are displayed on the Item details page:", ((string)(null)), table3280, "And ");
#line hidden
#line 24
 testRunner.When("User deselect all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3281 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3281.AddRow(new string[] {
                            "02X387UQLFP3ISU"});
#line 25
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table3281, "When ");
#line hidden
#line 28
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.When("User enters \"USE ME FOR AUTOMATION(USR SCHDLD)\" text in the Search field for \"Pro" +
                        "ject\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("User navigates to the \'History\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then("\'01F6D54271D74F1BB8D\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.And("\'02X387UQLFP3ISU\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("\'03AK1ZP1C9MPFV\' content is not displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
            "owWithAssotiatedDevicesOnUsersPage", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "Offboard",
                "DAS17964",
                "DAS17990",
                "DAS17000",
                "Cleanup",
                "Not_Ready"}, SourceLine=45)]
        public virtual void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "Offboard",
                    "DAS17964",
                    "DAS17990",
                    "DAS17000",
                    "Cleanup",
                    "Not_Ready"};
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
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 47
 testRunner.When("User navigates to the \'User\' details page for \'01F6D54271D74F1BB8D\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("Details page for \'01F6D54271D74F1BB8D\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3282 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3282.AddRow(new string[] {
                            "Hostname"});
                table3282.AddRow(new string[] {
                            "Owned"});
#line 55
 testRunner.And("following columns are displayed on the Item details page:", ((string)(null)), table3282, "And ");
#line hidden
#line 59
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.When("User enters \"USE ME FOR AUTOMATION(USR SCHDLD)\" text in the Search field for \"Pro" +
                        "ject\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("User navigates to the \'History\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("\'01F6D54271D74F1BB8D\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And("\'02X387UQLFP3ISU\' content is displayed in the \'Item\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
            "owWithoutUserOnUsersPage", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "Offboard",
                "DAS17964",
                "DAS17990",
                "DAS17000"}, SourceLine=73)]
        public virtual void EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnUsersPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "Offboard",
                    "DAS17964",
                    "DAS17990",
                    "DAS17000"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWind" +
                    "owWithoutUserOnUsersPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "Offboard",
                        "DAS17964",
                        "DAS17990",
                        "DAS17000"});
#line 74
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 75
 testRunner.When("User navigates to the \'User\' details page for \'0088FC8A50DD4344B92\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("Details page for \'0088FC8A50DD4344B92\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 82
 testRunner.And("\'Offboarding user BCLABS\\0088FC8A50DD4344B92 (Barland, Steinar). Offboarding an o" +
                        "bject deletes all project related information about it.\' text is displayed on po" +
                        "pup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "Offboard",
                "DAS18036",
                "Zion_NewGrid"}, SourceLine=84)]
        public virtual void EvergreenJnr_UsersList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "Offboard",
                    "DAS18036",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "Offboard",
                        "DAS18036",
                        "Zion_NewGrid"});
#line 85
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 86
 testRunner.When("User navigates to the \'User\' details page for \'0137C8E69921432992B\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("Details page for \'0137C8E69921432992B\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.When("User selects \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3283 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3283.AddRow(new string[] {
                            "Email Address"});
                table3283.AddRow(new string[] {
                            "Owner Display Name"});
                table3283.AddRow(new string[] {
                            "Owned"});
                table3283.AddRow(new string[] {
                            "Bucket"});
#line 93
 testRunner.And("following columns are displayed on the Item details page:", ((string)(null)), table3283, "And ");
#line hidden
#line 99
 testRunner.When("User deselect all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3284 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3284.AddRow(new string[] {
                            "Email Address"});
                table3284.AddRow(new string[] {
                            "Owner Display Name"});
                table3284.AddRow(new string[] {
                            "Owned"});
                table3284.AddRow(new string[] {
                            "Bucket"});
#line 100
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3284, "Then ");
#line hidden
#line 106
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3285 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3285.AddRow(new string[] {
                            "Email Address"});
                table3285.AddRow(new string[] {
                            "Owner Display Name"});
                table3285.AddRow(new string[] {
                            "Owned"});
                table3285.AddRow(new string[] {
                            "Bucket"});
#line 107
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3285, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3286 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table3286.AddRow(new string[] {
                            "Email Address"});
                table3286.AddRow(new string[] {
                            "Owner Display Name"});
#line 113
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Owned\' colum" +
                        "n:", ((string)(null)), table3286, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3287 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3287.AddRow(new string[] {
                            "Owned"});
                table3287.AddRow(new string[] {
                            "Bucket"});
#line 117
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3287, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3288 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table3288.AddRow(new string[] {
                            "Owner Display Name"});
#line 121
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Owned\' colum" +
                        "n:", ((string)(null)), table3288, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3289 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3289.AddRow(new string[] {
                            "Owner Display Name"});
                table3289.AddRow(new string[] {
                            "Owned"});
                table3289.AddRow(new string[] {
                            "Bucket"});
#line 124
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3289, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3290 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table3290.AddRow(new string[] {
                            "Email Address"});
#line 129
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Owned\' colum" +
                        "n:", ((string)(null)), table3290, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3291 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3291.AddRow(new string[] {
                            "Email Address"});
                table3291.AddRow(new string[] {
                            "Owner Display Name"});
                table3291.AddRow(new string[] {
                            "Owned"});
                table3291.AddRow(new string[] {
                            "Bucket"});
#line 132
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3291, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
