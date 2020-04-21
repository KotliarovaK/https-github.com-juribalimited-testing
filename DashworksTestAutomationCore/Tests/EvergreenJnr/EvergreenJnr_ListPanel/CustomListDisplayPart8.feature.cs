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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ListPanel
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CustomListDisplayPart8", Description="\tRuns Custom List Creation block related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListPanel\\CustomListDisplayPart8.feature", SourceLine=0)]
    public partial class CustomListDisplayPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomListDisplayPart8.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart8", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns(string listName, string listLabel, string columnName, string pinnedColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS10972",
                    "DAS12602",
                    "DAS14183",
                    "DAS12334",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedC" +
                    "olumns", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When(string.Format("User create dynamic list with \"DynamicList3\" name on \"{0}\" page", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When(string.Format("User opens \'{0}\' column settings", pinnedColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User selects \'Pin left\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("\"DynamicList3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.When(string.Format("User opens \'{0}\' column settings", pinnedColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.When("User selects \'Pin right\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("\"DynamicList3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.When(string.Format("User opens \'{0}\' column settings", pinnedColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.When("User selects \'No pin\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("\"DynamicList3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.And("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("User create static list with \"StaticList3\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("User opens \'{0}\' column settings", pinnedColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("User selects \'Pin left\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then("\"StaticList3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.And("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When(string.Format("User opens \'{0}\' column settings", pinnedColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.And("User selects \'Pin right\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("\"StaticList3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.And("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.When(string.Format("User opens \'{0}\' column settings", pinnedColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.And("User selects \'No pin\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("\"StaticList3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedC" +
            "olumns, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS10972",
                "DAS12602",
                "DAS14183",
                "DAS12334",
                "Cleanup"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns_Devices()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns("Devices", "All Devices", "Device Type", "Hostname", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedC" +
            "olumns, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS10972",
                "DAS12602",
                "DAS14183",
                "DAS12334",
                "Cleanup"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns_Applications()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns("Applications", "All Applications", "Vendor", "Application", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedC" +
            "olumns, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS10972",
                "DAS12602",
                "DAS14183",
                "DAS12334",
                "Cleanup"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns_Users()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns("Users", "All Users", "Domain", "Username", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedC" +
            "olumns, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS10972",
                "DAS12602",
                "DAS14183",
                "DAS12334",
                "Cleanup"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns_Mailboxes()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns("Mailboxes", "All Mailboxes", "Mailbox Platform", "Email Address", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton(string listName, string listLabel, string columnName, string staticListName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS12515",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClicki" +
                    "ngActionsButton", null, @__tags);
#line 53
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
#line 54
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.Then("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3450 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3450.AddRow(new string[] {
                            ""});
#line 62
 testRunner.When(string.Format("User create static list with \"{0}\" name on \"{1}\" page with following items", staticListName, listName), ((string)(null)), table3450, "When ");
#line hidden
#line 65
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", staticListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Then("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClicki" +
            "ngActionsButton, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12515",
                "Cleanup"}, SourceLine=74)]
        public virtual void EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton_Devices()
        {
#line 53
this.EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton("Devices", "All Devices", "Owner Display Name", "StaticList5548", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClicki" +
            "ngActionsButton, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12515",
                "Cleanup"}, SourceLine=74)]
        public virtual void EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton_Applications()
        {
#line 53
this.EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton("Applications", "All Applications", "Version", "StaticList8944", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClicki" +
            "ngActionsButton, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12515",
                "Cleanup"}, SourceLine=74)]
        public virtual void EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton_Users()
        {
#line 53
this.EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton("Users", "All Users", "Distinguished Name", "StaticList7412", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClicki" +
            "ngActionsButton, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12515",
                "Cleanup"}, SourceLine=74)]
        public virtual void EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton_Mailboxes()
        {
#line 53
this.EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton("Mailboxes", "All Mailboxes", "Owner Display Name", "StaticList9512", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList(string listName, string listLabel, string columnName, string addColumn, string dynamicListName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS12524",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcess" +
                    "OfSavingList", null, @__tags);
#line 81
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
#line 82
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.When("User clicks \'SAVE\' button and select \'SAVE AS STATIC LIST\' menu button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("Save and Cancel buttons are displayed on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.When("User clicks Cancel button on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("Save and Cancel buttons are not displayed on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", dynamicListName, listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 91
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3451 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3451.AddRow(new string[] {
                            string.Format("{0}", addColumn)});
#line 93
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table3451, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3452 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3452.AddRow(new string[] {
                            string.Format("{0}", addColumn)});
#line 96
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table3452, "Then ");
#line hidden
#line 99
 testRunner.When("User clicks \'SAVE\' button and select \'SAVE AS NEW DYNAMIC LIST\' menu button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.Then("Save and Cancel buttons are displayed on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.When("User clicks Cancel button on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("Save and Cancel buttons are not displayed on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcess" +
            "OfSavingList, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12524",
                "Cleanup"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList_Devices()
        {
#line 81
this.EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList("Devices", "All Devices", "Hostname", "Device Key", "DynamicList1178", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcess" +
            "OfSavingList, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12524",
                "Cleanup"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList_Applications()
        {
#line 81
this.EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList("Applications", "All Applications", "Application", "Barry\'sUse: Category", "DynamicList1125", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcess" +
            "OfSavingList, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12524",
                "Cleanup"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList_Users()
        {
#line 81
this.EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList("Users", "All Users", "Username", "GUID", "DynamicList1195", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcess" +
            "OfSavingList, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12524",
                "Cleanup"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList_Mailboxes()
        {
#line 81
this.EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList("Mailboxes", "All Mailboxes", "Email Address", "Region", "DynamicList1121", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatActionsPanelIsHiddenAfterCancellingProcessOfSaving" +
            "List", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12524",
                "Cleanup"}, SourceLine=111)]
        public virtual void EvergreenJnr_AllLists_CheckThatActionsPanelIsHiddenAfterCancellingProcessOfSavingList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS12524",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatActionsPanelIsHiddenAfterCancellingProcessOfSaving" +
                    "List", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS12524",
                        "Cleanup"});
#line 112
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
#line 113
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 116
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3453 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3453.AddRow(new string[] {
                            "Device Count (Used)"});
#line 117
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table3453, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3454 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3454.AddRow(new string[] {
                            "Device Count (Used)"});
#line 120
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table3454, "Then ");
#line hidden
#line 123
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 125
 testRunner.Then("Save and Cancel buttons are not displayed on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 126
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 127
 testRunner.And("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.And("User types \"StaticList7841\" static list name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("checkboxes are not displayed for content in the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.And("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.And("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
