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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Teams
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AddMembersToTheTeam", Description="\tAdd Members To The Team", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AdminPage\\Teams\\AddMembersToTheTeam.feature", SourceLine=0)]
    public partial class AddMembersToTheTeamFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AddMembersToTheTeam.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddMembersToTheTeam", "\tAdd Members To The Team", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "DAS13199",
                "DAS13254",
                "DAS13172",
                "Cleanup",
                "Teams",
                "Do_Not_Run_With_Teams",
                "Do_Not_Run_With_Buckets",
                "Set_Default_Team"}, SourceLine=8)]
        public virtual void EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS13199",
                    "DAS13254",
                    "DAS13172",
                    "Cleanup",
                    "Teams",
                    "Do_Not_Run_With_Teams",
                    "Do_Not_Run_With_Buckets",
                    "Set_Default_Team"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12999",
                        "DAS13199",
                        "DAS13254",
                        "DAS13172",
                        "Cleanup",
                        "Teams",
                        "Do_Not_Run_With_Teams",
                        "Do_Not_Run_With_Buckets",
                        "Set_Default_Team"});
#line 9
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
#line 10
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User navigates to the \'Teams\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Page with \'Teams\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When("User clicks \'CREATE TEAM\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("Page with \'Create Team\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("Page with \'Teams\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User clicks \'CREATE TEAM\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("Page with \'Create Team\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("User enters \'TestTeam8\' text to \'Team Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And("User enters \"test\" in the Team Description field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.When("User selects \'Add members from another team\' in the \'Add Members (Optional)\' drop" +
                        "down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1699 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1699.AddRow(new string[] {
                            "Migration Phase 3 Team"});
                table1699.AddRow(new string[] {
                            "Retail Team"});
#line 24
 testRunner.When("User selects following Objects from the expandable multiselect", ((string)(null)), table1699, "When ");
#line hidden
#line 28
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("\'The team has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When("User enters \"My Team\" text in the Search field for \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("\'TRUE\' content is displayed in the \'Default\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("\'Actions\' dropdown is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.When("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then("\'You cannot delete the default team\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.When("User clicks \'CREATE TEAM\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("Page with \'Create Team\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.When("User enters \'TestTeam88\' text to \'Team Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.And("User enters \"test\" in the Team Description field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("User clicks Default Team checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.When("User selects \'Add individual members\' in the \'Add Members (Optional)\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1700 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1700.AddRow(new string[] {
                            "automation_admin1"});
#line 43
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table1700, "And ");
#line hidden
#line 46
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.Then("\'The team has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("User enters \"My Team\" text in the Search field for \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("\'FALSE\' content is displayed in the \'Default\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.When("User clicks content from \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.And("User navigates to the \'Team Settings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("User clicks Default Team checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.Then("\'The team was successfully updated\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_AddingMembersToTheTeam", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "DAS13254",
                "DAS13421",
                "Teams",
                "Cleanup"}, SourceLine=56)]
        public virtual void EvergreenJnr_AdminPage_AddingMembersToTheTeam()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS13254",
                    "DAS13421",
                    "Teams",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_AddingMembersToTheTeam", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12999",
                        "DAS13254",
                        "DAS13421",
                        "Teams",
                        "Cleanup"});
#line 57
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
                TechTalk.SpecFlow.Table table1701 = new TechTalk.SpecFlow.Table(new string[] {
                            "TeamName",
                            "Description",
                            "IsDefault"});
                table1701.AddRow(new string[] {
                            "TestTeam7",
                            "test",
                            "false"});
#line 58
 testRunner.When("User creates new Team via api", ((string)(null)), table1701, "When ");
#line hidden
#line 61
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("User navigates to the \'Teams\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("Page with \'Teams\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.When("User enters \"TestTeam7\" text in the Search field for \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.And("User clicks content from \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.When("User navigates to the \'Team Members\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("User clicks \'ADD MEMBERS\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1702 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1702.AddRow(new string[] {
                            "automation_admin1"});
                table1702.AddRow(new string[] {
                            "automation_admin2"});
                table1702.AddRow(new string[] {
                            "automation_admin3"});
                table1702.AddRow(new string[] {
                            "eugene"});
#line 69
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table1702, "And ");
#line hidden
#line 75
 testRunner.And("User clicks \'ADD USERS\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.Then("\'The selected users have been added\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.When("User click on \"Username\" column header on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.When("User click on \"Username\" column header on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("data in table is sorted by \'Username\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.When("User click on \"Full Name\" column header on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("data in table is sorted by \'Full Name\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("User click on \"Full Name\" column header on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.Then("data in table is sorted by \'Full Name\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.When("User enters \"Admin\" text in the Search field for \"Full Name\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.Then("Rows counter shows \"3\" of \"4\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.When("User enters \"automation_admin1\" text in the Search field for \"Username\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.Then("Rows counter shows \"1\" of \"4\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("\'Actions\' dropdown is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.When("User selects \'Remove Members\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.When("User clicks \'REMOVE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.Then("inline warning banner is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.When("User clicks \'REMOVE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("\'The selected user has been removed\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.When("User enters \"automation_admin2\" text in the Search field for \"Username\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.And("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("User selects \'Add to another team\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And("User clicks \'CONTINUE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.When("User selects \'Team 1\' option from \'Select a new team\' autocomplete without search" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.And("User clicks \'ADD USERS\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.Then("\'The selected user was added to team Team 1\' text is displayed on inline success " +
                        "banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChecksThatSelectANewTeamDropdownAreWorkingCorrectly", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12326",
                "DAS16130",
                "Teams",
                "Cleanup"}, SourceLine=104)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatSelectANewTeamDropdownAreWorkingCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12326",
                    "DAS16130",
                    "Teams",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatSelectANewTeamDropdownAreWorkingCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12326",
                        "DAS16130",
                        "Teams",
                        "Cleanup"});
#line 105
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
                TechTalk.SpecFlow.Table table1703 = new TechTalk.SpecFlow.Table(new string[] {
                            "TeamName",
                            "Description",
                            "IsDefault"});
                table1703.AddRow(new string[] {
                            "DAS12326",
                            "12326",
                            "false"});
#line 106
 testRunner.When("User creates new Team via api", ((string)(null)), table1703, "When ");
#line hidden
#line 109
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.When("User navigates to the \'Teams\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.Then("Page with \'Teams\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 113
 testRunner.When("User enters \"DAS12326\" text in the Search field for \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.And("User clicks content from \"Team\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("User navigates to the \'Team Members\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And("User clicks \'ADD MEMBERS\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1704 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1704.AddRow(new string[] {
                            "automation_admin1"});
                table1704.AddRow(new string[] {
                            "automation_admin2"});
                table1704.AddRow(new string[] {
                            "automation_admin3"});
#line 117
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table1704, "And ");
#line hidden
#line 122
 testRunner.And("User clicks \'ADD USERS\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.Then("\'The selected users have been added\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 124
 testRunner.When("User enters \"admin1\" text in the Search field for \"Username\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 125
 testRunner.And("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 126
 testRunner.And("User selects \'Add to another team\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.And("User clicks \'CONTINUE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1705 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1705.AddRow(new string[] {
                            "Migration Phase 2"});
                table1705.AddRow(new string[] {
                            "Migration Phase 3 Team"});
                table1705.AddRow(new string[] {
                            "My Team"});
#line 128
 testRunner.Then("only below options are displayed in \'Select a new team\' autocomplete after search" +
                        " by \'M\' text", ((string)(null)), table1705, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_CheckThatNoErrorAppearsAfterCreatingTeamHavingChosenMember" +
            "sInNotSelectedAddMembersOption", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS18614",
                "Cleanup",
                "Teams",
                "Do_Not_Run_With_Teams"}, SourceLine=134)]
        public virtual void EvergreenJnr_AdminPage_CheckThatNoErrorAppearsAfterCreatingTeamHavingChosenMembersInNotSelectedAddMembersOption()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS18614",
                    "Cleanup",
                    "Teams",
                    "Do_Not_Run_With_Teams"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatNoErrorAppearsAfterCreatingTeamHavingChosenMember" +
                    "sInNotSelectedAddMembersOption", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS18614",
                        "Cleanup",
                        "Teams",
                        "Do_Not_Run_With_Teams"});
#line 135
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
#line 136
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.When("User navigates to the \'Teams\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.Then("Page with \'Teams\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.When("User clicks \'CREATE TEAM\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 141
 testRunner.Then("Page with \'Create Team\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 142
 testRunner.When("User enters \'TestTeam18614\' text to \'Team Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 143
 testRunner.When("User enters \"test\" in the Team Description field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 144
 testRunner.When("User selects \'Add members from another team\' in the \'Add Members (Optional)\' drop" +
                        "down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 145
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1706 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1706.AddRow(new string[] {
                            "2004 Team"});
#line 146
 testRunner.When("User selects following Objects from the expandable multiselect", ((string)(null)), table1706, "When ");
#line hidden
#line 149
 testRunner.When("User selects \'Add individual members\' in the \'Add Members (Optional)\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 150
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 151
 testRunner.Then("Chips for \'Search\' field are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 152
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 153
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 154
 testRunner.Then("\'The team has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
