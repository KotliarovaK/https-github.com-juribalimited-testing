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
    [TechTalk.SpecRun.FeatureAttribute("CustomListDisplayPart9", Description="\tRuns Custom List Creation block related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListPanel\\CustomListDisplayPart9.feature", SourceLine=0)]
    public partial class CustomListDisplayPart9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomListDisplayPart9.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart9", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedAfterDuplicatingANewStaticL" +
            "istWithALongName", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12656",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedAfterDuplicatingANewStaticListWithALongName()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS12656",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedAfterDuplicatingANewStaticL" +
                    "istWithALongName", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS12656",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table3455 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3455.AddRow(new string[] {
                            "001BAQXT6JWFPI"});
                table3455.AddRow(new string[] {
                            "001PSUMZYOW581"});
#line 10
 testRunner.When("User create static list with \"1111111111111111111111111111111111111111\" name on \"" +
                        "Devices\" page with following items", ((string)(null)), table3455, "When ");
#line hidden
#line 14
 testRunner.Then("\"1111111111111111111111111111111111111111\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.When("User clicks \'Duplicate\' option in cogmenu for \'1111111111111111111111111111111111" +
                        "111111\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("\"111111111111111111111111111111111111112\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatDataFromTheStaticListAreSavedInTheNewListAfterEdi" +
            "ting", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12685",
                "Cleanup"}, SourceLine=21)]
        public virtual void EvergreenJnr_UsersList_CheckThatDataFromTheStaticListAreSavedInTheNewListAfterEditing()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS12685",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatDataFromTheStaticListAreSavedInTheNewListAfterEdi" +
                    "ting", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS12685",
                        "Cleanup"});
#line 22
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
                TechTalk.SpecFlow.Table table3456 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3456.AddRow(new string[] {
                            "003F5D8E1A844B1FAA5"});
                table3456.AddRow(new string[] {
                            "00A5B910A1004CF5AC4"});
#line 23
 testRunner.When("User create static list with \"StaticList1412\" name on \"Users\" page with following" +
                        " items", ((string)(null)), table3456, "When ");
#line hidden
#line 27
 testRunner.Then("\"StaticList1412\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3457 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3457.AddRow(new string[] {
                            "Enabled"});
#line 30
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table3457, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3458 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3458.AddRow(new string[] {
                            "Enabled"});
#line 33
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table3458, "Then ");
#line hidden
#line 36
 testRunner.When("User selects \'SAVE AS NEW STATIC LIST\' option from Save menu and creates \'CustomL" +
                        "ist5588\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("\"CustomList5588\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.When("User clicks \'Duplicate\' option in cogmenu for \'StaticList1412\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.Then("\"StaticList14122\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatStaticListIsDisplayedInTheBottomOfTheListPanelWhe" +
            "nNavigateToTheMainList", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS12630"}, SourceLine=43)]
        public virtual void EvergreenJnr_UsersList_CheckThatStaticListIsDisplayedInTheBottomOfTheListPanelWhenNavigateToTheMainList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS12630"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatStaticListIsDisplayedInTheBottomOfTheListPanelWhe" +
                    "nNavigateToTheMainList", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS12630"});
#line 44
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
                TechTalk.SpecFlow.Table table3459 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3459.AddRow(new string[] {
                            "000F977AC8824FE39B8"});
                table3459.AddRow(new string[] {
                            "00A5B910A1004CF5AC4"});
#line 45
 testRunner.When("User create static list with \"StaticList6542\" name on \"Users\" page with following" +
                        " items", ((string)(null)), table3459, "When ");
#line hidden
#line 49
 testRunner.Then("\"StaticList6542\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then("\'StaticList6542\' list is displayed in the Lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'StaticList6542\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("\"list will be permanently deleted\" message is displayed in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("\"List deleted\" message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateVal" +
            "uesOfFilter", new string[] {
                "Evergreen",
                "Devices",
                "CustomListDisplay",
                "EvergreenJnr_ListPanel",
                "DAS12917"}, SourceLine=57)]
        public virtual void EvergreenJnr_DevicesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "CustomListDisplay",
                    "EvergreenJnr_ListPanel",
                    "DAS12917"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateVal" +
                    "uesOfFilter", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "CustomListDisplay",
                        "EvergreenJnr_ListPanel",
                        "DAS12917"});
#line 58
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
#line 59
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3460 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3460.AddRow(new string[] {
                            "Red"});
                table3460.AddRow(new string[] {
                            "Green"});
#line 63
 testRunner.When("User add \"Application Compliance\" filter where type is \"Equals\" with added column" +
                        " and following checkboxes:", ((string)(null)), table3460, "When ");
#line hidden
#line 67
 testRunner.And("User creates \'Test_Device_Filter_DAS_12917\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("User changes list name to \"EDITED_Device_Filter_DAS_12917\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("User click Edit button for \"Application Compliance\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("User closes \"Red\" Chip item in the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.Then("\"EDITED_Device_Filter_DAS_12917\" edited list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatConfirmationDeletionMessageDoesntDisappearsAfte" +
            "rFewSeconds", new string[] {
                "Evergreen",
                "Devices",
                "CustomListDisplay",
                "EvergreenJnr_ListPanel",
                "DAS17711",
                "Cleanup"}, SourceLine=76)]
        public virtual void EvergreenJnr_DevicesList_CheckThatConfirmationDeletionMessageDoesntDisappearsAfterFewSeconds()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "CustomListDisplay",
                    "EvergreenJnr_ListPanel",
                    "DAS17711",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatConfirmationDeletionMessageDoesntDisappearsAfte" +
                    "rFewSeconds", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "CustomListDisplay",
                        "EvergreenJnr_ListPanel",
                        "DAS17711",
                        "Cleanup"});
#line 77
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
#line 78
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.When("User add \"Device Type\" filter where type is \"Does not equal\" without added column" +
                        " and \"Virtual\" Lookup option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.And("User create dynamic list with \"List17711\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.Then("\"List17711\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.When("User clicks \'Duplicate\' option in cogmenu for \'List17711\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
 testRunner.Then("\"List177112\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.When("User navigates to the \"List177112\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'List177112\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.Then("\"list will be permanently deleted\" message is displayed in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("User waits for \'3\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("\"list will be permanently deleted\" message is displayed in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
