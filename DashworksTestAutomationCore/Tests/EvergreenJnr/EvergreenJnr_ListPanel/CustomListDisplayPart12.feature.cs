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
    [TechTalk.SpecRun.FeatureAttribute("CustomListDisplayPart12", Description="\tRuns Custom List Creation block related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListPanel\\CustomListDisplayPart12.feature", SourceLine=0)]
    public partial class CustomListDisplayPart12Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomListDisplayPart12.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart12", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS17627",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS17627",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS17627",
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
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3372 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3372.AddRow(new string[] {
                            "001BAQXT6JWFPI"});
                table3372.AddRow(new string[] {
                            "001PSUMZYOW581"});
#line 12
 testRunner.When("User create static list with \"StaticFilterList_1\" name on \"Devices\" page with fol" +
                        "lowing items", ((string)(null)), table3372, "When ");
#line hidden
#line 16
 testRunner.Then("\"StaticFilterList_1\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User clicks on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User create dynamic list with \"DynamicFilterList_1\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("\"DynamicFilterList_1\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3373 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3373.AddRow(new string[] {
                            "Hostname"});
#line 22
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3373, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3374 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3374.AddRow(new string[] {
                            "Hostname"});
#line 25
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3374, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3375 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3375.AddRow(new string[] {
                            "Hostname"});
#line 28
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3375, "And ");
#line hidden
#line 31
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.And("User removes \"Hostname\" Column for Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3376 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3376.AddRow(new string[] {
                            "Floor"});
#line 33
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3376, "And ");
#line hidden
#line 36
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatGridHeaderIsDisplayedCorrectlyAfterClosingLists" +
            "Panel", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS17421",
                "DAS17014",
                "DAS17014"}, SourceLine=42)]
        public virtual void EvergreenJnr_DevicesList_CheckThatGridHeaderIsDisplayedCorrectlyAfterClosingListsPanel()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS17421",
                    "DAS17014",
                    "DAS17014"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatGridHeaderIsDisplayedCorrectlyAfterClosingLists" +
                    "Panel", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS17421",
                        "DAS17014",
                        "DAS17014"});
#line 43
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
#line 44
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User closed list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("Lists panel is hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.Then("User sees correct tooltip for Show Lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect(string listType, string listTitle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS15785"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3377 = new TechTalk.SpecFlow.Table(new string[] {
                            "filterItem"});
                table3377.AddRow(new string[] {
                            "All"});
                table3377.AddRow(new string[] {
                            "Favourite"});
                table3377.AddRow(new string[] {
                            "Not favourite"});
                table3377.AddRow(new string[] {
                            "All"});
                table3377.AddRow(new string[] {
                            "Owned by me"});
                table3377.AddRow(new string[] {
                            "Shared with me"});
                table3377.AddRow(new string[] {
                            "All"});
                table3377.AddRow(new string[] {
                            "Static"});
                table3377.AddRow(new string[] {
                            "Dynamic"});
                table3377.AddRow(new string[] {
                            "All"});
                table3377.AddRow(new string[] {
                            "Standard"});
                table3377.AddRow(new string[] {
                            "Pivot"});
#line 54
 testRunner.And("List filter DDL displays the next options", ((string)(null)), table3377, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect, Devices", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS15785"}, SourceLine=70)]
        public virtual void EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect_Devices()
        {
#line 51
this.EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect("Devices", "All Devices", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect, Users", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS15785"}, SourceLine=70)]
        public virtual void EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect_Users()
        {
#line 51
this.EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect("Users", "All Users", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect, Applications", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS15785"}, SourceLine=70)]
        public virtual void EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect_Applications()
        {
#line 51
this.EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect("Applications", "All Applications", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect, Mailboxes", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS15785"}, SourceLine=70)]
        public virtual void EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect_Mailboxes()
        {
#line 51
this.EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect("Mailboxes", "All Mailboxes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedAfterSavingListWithD" +
            "eviceOwnerSavedListFilter", new string[] {
                "Evergreen",
                "Applications",
                "CustomListDisplay",
                "EvergreenJnr_ListPanel",
                "DAS17472",
                "Cleanup"}, SourceLine=76)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedAfterSavingListWithDeviceOwnerSavedListFilter()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "CustomListDisplay",
                    "EvergreenJnr_ListPanel",
                    "DAS17472",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedAfterSavingListWithD" +
                    "eviceOwnerSavedListFilter", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "CustomListDisplay",
                        "EvergreenJnr_ListPanel",
                        "DAS17472",
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3378 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes",
                            "Association"});
                table3378.AddRow(new string[] {
                            "Users with Device Count",
                            "Used on device"});
#line 82
 testRunner.When("User add \"Device Owner (Saved List)\" filter where type is \"In list\" with selected" +
                        " Expanded Checkboxes and following Association:", ((string)(null)), table3378, "When ");
#line hidden
#line 85
 testRunner.Then("\"100\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.When("User creates \'Test_Application_List_DAS_17472\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("\"Test_Application_List_DAS_17472\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatListCanBeFoundUsingAnyCapsOrSmallLetters", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "CustomListDisplay",
                "DAS18483"}, SourceLine=90)]
        public virtual void EvergreenJnr_DevicesList_CheckThatListCanBeFoundUsingAnyCapsOrSmallLetters()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS18483"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatListCanBeFoundUsingAnyCapsOrSmallLetters", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS18483"});
#line 91
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
#line 92
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.When("User enters \"new\" text in Search field at List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("\'New York - Devices\' list is displayed in the Lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.When("User enters \"New\" text in Search field at List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.Then("\'New York - Devices\' list is displayed in the Lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount(string listType, string listTitle, string url, string requests, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "DAS15785"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount", null, @__tags);
#line 99
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
#line 100
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.Then(string.Format("Number of requests to \'{0}\' is not greater than \'{1}\'", url, requests), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount, Dev" +
            "ices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS15785"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount_Devices()
        {
#line 99
this.EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount("Devices", "All Devices", "/devices", "23", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount, Use" +
            "rs", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS15785"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount_Users()
        {
#line 99
this.EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount("Users", "All Users", "/users", "11", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount, App" +
            "lications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS15785"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount_Applications()
        {
#line 99
this.EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount("Applications", "All Applications", "/applications", "11", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount, Mai" +
            "lboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS15785"}, SourceLine=105)]
        public virtual void EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount_Mailboxes()
        {
#line 99
this.EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount("Mailboxes", "All Mailboxes", "/mailboxes", "11", ((string[])(null)));
#line hidden
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
