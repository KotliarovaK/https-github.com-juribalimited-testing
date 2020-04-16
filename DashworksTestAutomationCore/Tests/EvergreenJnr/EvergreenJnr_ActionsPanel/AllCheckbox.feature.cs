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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ActionsPanel
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AllCheckbox", Description="\tRuns All Checkbox related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ActionsPanel\\AllCheckbox.feature", SourceLine=0)]
    public partial class AllCheckboxFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AllCheckbox.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AllCheckbox", "\tRuns All Checkbox related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch", new string[] {
                "Evergreen",
                "Users",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10769",
                "DAS10656",
                "DAS12206"}, SourceLine=8)]
        public virtual void EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "Evergreen_ActionsPanel",
                    "AllCheckbox",
                    "DAS10769",
                    "DAS10656",
                    "DAS12206"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch", null, new string[] {
                        "Evergreen",
                        "Users",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS10769",
                        "DAS10656",
                        "DAS12206"});
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
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("The number of rows selected matches the number of rows of the main object list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table242 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table242.AddRow(new string[] {
                            "alain",
                            "42"});
#line 16
 testRunner.And("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table242, "And ");
#line hidden
#line 19
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("User clicks on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("\"42\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("\"41339\" selected rows are displayed in the Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("Clearing the agGrid Search Box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.When("User deselect all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("\"0\" selected rows are displayed in the Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("The number of rows selected matches the number of rows of the main object list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.Then("select all rows checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
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
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel", null, @__tags);
#line 34
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
#line 35
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.Then("checkboxes are not displayed for content in the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel, De" +
            "vices", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10775",
                "DAS10656",
                "DAS12602"}, SourceLine=44)]
        public virtual void EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel_Devices()
        {
#line 34
this.EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel("Devices", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel, Us" +
            "ers", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10775",
                "DAS10656",
                "DAS12602"}, SourceLine=44)]
        public virtual void EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel_Users()
        {
#line 34
this.EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel("Users", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel, Ap" +
            "plications", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10775",
                "DAS10656",
                "DAS12602"}, SourceLine=44)]
        public virtual void EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel_Applications()
        {
#line 34
this.EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel("Applications", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel, Ma" +
            "ilboxes", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10775",
                "DAS10656",
                "DAS12602"}, SourceLine=44)]
        public virtual void EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel_Mailboxes()
        {
#line 34
this.EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel("Mailboxes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_SearchWithinAllRows", new string[] {
                "Evergreen",
                "Devices",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10772",
                "DAS10656",
                "DAS11664",
                "DAS12602"}, SourceLine=50)]
        public virtual void EvergreenJnr_DevicesList_SearchWithinAllRows()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "Evergreen_ActionsPanel",
                    "AllCheckbox",
                    "DAS10772",
                    "DAS10656",
                    "DAS11664",
                    "DAS12602"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_SearchWithinAllRows", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS10772",
                        "DAS10656",
                        "DAS11664",
                        "DAS12602"});
#line 51
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
#line 52
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table243 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table243.AddRow(new string[] {
                            "Mary",
                            "18"});
                table243.AddRow(new string[] {
                            "Henry",
                            "34"});
                table243.AddRow(new string[] {
                            "Yolande Sylvain",
                            "1"});
#line 57
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table243, "Then ");
#line hidden
#line 62
 testRunner.And("Clearing the agGrid Search Box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then("\"17,279\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
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
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest", null, @__tags);
#line 66
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
#line 67
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.Then(string.Format("\"{0}\" selected rows are displayed in the Actions panel", selectedRowsCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.Then("checkboxes are not displayed for content in the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table244 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table244.AddRow(new string[] {
                            string.Format("{0}", selectedRowName)});
#line 77
 testRunner.And(string.Format("User select \"{0}\" rows in the grid", columnname), ((string)(null)), table244, "And ");
#line hidden
#line 80
 testRunner.Then(string.Format("\"{0}\" selected rows are displayed in the Actions panel", selectedRowsCountAfterDiselect), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.And(string.Format("\"{0}\" selected rows are displayed in the Actions panel", selectedRowsCountAfterDiselect), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10656",
                "DAS12602"}, SourceLine=86)]
        public virtual void EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest_Devices()
        {
#line 66
this.EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest("Devices", "17279", "Hostname", "00BDM1JUR8IF419", "17278", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest, Users", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10656",
                "DAS12602"}, SourceLine=86)]
        public virtual void EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest_Users()
        {
#line 66
this.EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest("Users", "41339", "Username", "002B5DC7D4D34D5C895", "41338", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10656",
                "DAS12602"}, SourceLine=86)]
        public virtual void EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest_Applications()
        {
#line 66
this.EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest("Applications", "2223", "Application", "\"WPF/E\" (codename) Community Technology Preview (Feb 2007)", "2222", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10656",
                "DAS12602"}, SourceLine=86)]
        public virtual void EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest_Mailboxes()
        {
#line 66
this.EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest("Mailboxes", "14884", "Email Address", "000F977AC8824FE39B8@bclabs.local", "14883", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditi" +
            "onalColumn", new string[] {
                "Evergreen",
                "AllLists",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS10656",
                "DAS12602"}, SourceLine=92)]
        public virtual void EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditionalColumn()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "Evergreen_ActionsPanel",
                    "AllCheckbox",
                    "DAS10656",
                    "DAS12602"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditi" +
                    "onalColumn", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS10656",
                        "DAS12602"});
#line 93
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
                TechTalk.SpecFlow.Table table245 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table245.AddRow(new string[] {
                            "Enabled"});
                table245.AddRow(new string[] {
                            "Username"});
#line 94
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table245, "When ");
#line hidden
#line 98
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table246 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table246.AddRow(new string[] {
                            "FALSE"});
                table246.AddRow(new string[] {
                            "TRUE"});
#line 100
 testRunner.When("User add \"Enabled\" filter where type is \"Equals\" with added column and following " +
                        "checkboxes:", ((string)(null)), table246, "When ");
#line hidden
#line 104
 testRunner.Then("\"Enabled\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.Then("\"41,339\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.And("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 109
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.Then("\"41339\" selected rows are displayed in the Actions panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick", new string[] {
                "Evergreen",
                "Mailboxes",
                "Evergreen_ActionsPanel",
                "AllCheckbox",
                "DAS11894",
                "DAS12602"}, SourceLine=112)]
        public virtual void EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "Evergreen_ActionsPanel",
                    "AllCheckbox",
                    "DAS11894",
                    "DAS12602"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "Evergreen_ActionsPanel",
                        "AllCheckbox",
                        "DAS11894",
                        "DAS12602"});
#line 113
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
#line 114
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 117
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 119
 testRunner.Then("all checkboxes are checked in the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 120
 testRunner.And("The number of rows selected matches the number of rows of the main object list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
