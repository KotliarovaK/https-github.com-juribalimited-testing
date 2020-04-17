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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ListDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ListDetailsFunctionalityPart9", Description="\tRuns List Details Panel related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListDetails\\ListDetailsFunctionalityPart9.feature" +
        "", SourceLine=0)]
    public partial class ListDetailsFunctionalityPart9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ListDetailsFunctionalityPart9.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart9", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatArchivedItemStillRemainsInStaticList", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS17651",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckThatArchivedItemStillRemainsInStaticList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS17651",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatArchivedItemStillRemainsInStaticList", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS17651",
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
 testRunner.And("User sets includes archived devices in \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3349 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3349.AddRow(new string[] {
                            "Empty"});
#line 13
 testRunner.And("User select \"Hostname\" rows in the grid", ((string)(null)), table3349, "And ");
#line hidden
#line 16
 testRunner.And("User perform search by \"00I0COBFWHOF27\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3350 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3350.AddRow(new string[] {
                            "00I0COBFWHOF27"});
#line 17
 testRunner.And("User select \"Hostname\" rows in the grid", ((string)(null)), table3350, "And ");
#line hidden
#line 20
 testRunner.And("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("User create static list with \"StaticList17651\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then("\"StaticList17651\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.When("User closes Tools panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When("User navigates to the \"2004 Rollout\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("\"2004 Rollout\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.When("User navigates to the \"StaticList17651\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("\"StaticList17651\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.And("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("Archived devices icon enabled state is \'true\' in toolbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue(string listName, string customValue, string @operator, string columnData, string customColumn, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS17552"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue", null, @__tags);
#line 33
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
#line 34
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3351 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3351.AddRow(new string[] {
                            string.Format("{0}", customValue)});
#line 36
 testRunner.And(string.Format("User add \"{0}\" filter where type is \"{1}\" with added column and following value:", customColumn, @operator), ((string)(null)), table3351, "And ");
#line hidden
#line 39
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'{1}\' column", columnData, customColumn), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue, Devices" +
            "", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS17552"}, SourceLine=42)]
        public virtual void EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue_Devices()
        {
#line 33
this.EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue("Devices", "aaa", "Equals", "0.665371384, 1kk, 2kk, 3kk, aaa, bbb, ccc", "ComputerCustomField", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue, Mailbox" +
            "es", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS17552"}, SourceLine=42)]
        public virtual void EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue_Mailboxes()
        {
#line 33
this.EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue("Mailboxes", "aaa", "Equals", "1kk, 2kk, 3kk, aaa, bbb, ccc", "Mailbox Filter 1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue, Applica" +
            "tions", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS17552"}, SourceLine=42)]
        public virtual void EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue_Applications()
        {
#line 33
this.EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue("Applications", "aaa", "Equals", "1kk, 2 kk, 3kk, abdc, aaa, bbb", "App field 1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxDisplayedInListDetails", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18089"}, SourceLine=47)]
        public virtual void EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxDisplayedInListDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS18089"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxDisplayedInListDetails", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS18089"});
#line 48
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
#line 49
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.When("User navigates to the \"2004 Rollout\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then("\"2004 Rollout\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("User checks \'Archived Devices Included\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("Archived devices icon enabled state is \'true\' in toolbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.Then("\'SAVE AS NEW STATIC LIST\' menu button is displayed for \'SAVE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckArchivedItemsIconDisplayingAfterDeselectingArchived" +
            "Items", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS17440",
                "Cleanup"}, SourceLine=58)]
        public virtual void EvergreenJnr_DevicesList_CheckArchivedItemsIconDisplayingAfterDeselectingArchivedItems()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS17440",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckArchivedItemsIconDisplayingAfterDeselectingArchived" +
                    "Items", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS17440",
                        "Cleanup"});
#line 59
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
#line 60
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.And("User sets includes archived devices in \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("User create dynamic list with \"List17440\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.When("User navigates to the \"List17440\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.When("User checks \'Archived Devices Included\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.Then("Archived devices icon enabled state is \'false\' in toolbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Then("\'SAVE AS NEW DYNAMIC LIST\' menu button is displayed for \'SAVE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails(string pageName, string listToNavigate, string list, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS18089"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails" +
                    "", null, @__tags);
#line 71
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
#line 72
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listToNavigate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.When(string.Format("User navigates to the \"{0}\" list", list), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.And("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.And("\'Archived devices included\' label is not displayed in List Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails" +
            ", Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18089"}, SourceLine=80)]
        public virtual void EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails_Users()
        {
#line 71
this.EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails("Users", "All Users", "Users Readiness Columns & Filters", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails" +
            ", Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18089"}, SourceLine=80)]
        public virtual void EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails_Applications()
        {
#line 71
this.EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails("Applications", "All Applications", "2004 Apps", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails" +
            ", Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18089"}, SourceLine=80)]
        public virtual void EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails_Mailboxes()
        {
#line 71
this.EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails("Mailboxes", "All Mailboxes", "Mailbox Pivot (Complex)", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList(string lists, string filter, string searchTerm, string listName, string listType, string data, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS18127",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList", null, @__tags);
#line 86
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
#line 87
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", lists), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3352 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3352.AddRow(new string[] {
                            string.Format("{0}", searchTerm)});
#line 89
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following valu" +
                            "e:", filter), ((string)(null)), table3352, "When ");
#line hidden
#line 92
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", listName, lists), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.When(string.Format("User navigates to the \"{0}\" list", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.Then(string.Format("\'{0}\' label is displayed in List Details", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.Then(string.Format("\'{0}\' label is displayed in List Details", data), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList, De" +
            "vices", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18127",
                "Cleanup"}, SourceLine=100)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList_Devices()
        {
#line 86
this.EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList("Devices", "Hostname", "00CWZRC4UK6W20", "ADynamicDevices18127", "List Type: Dynamic", "Data: Devices", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList, Ap" +
            "plications", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18127",
                "Cleanup"}, SourceLine=100)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList_Applications()
        {
#line 86
this.EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList("Applications", "Application", "Microsoft Office 97, Professional Edition", "ADynamicApplications18127", "List Type: Dynamic", "Data: Applications", ((string[])(null)));
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
