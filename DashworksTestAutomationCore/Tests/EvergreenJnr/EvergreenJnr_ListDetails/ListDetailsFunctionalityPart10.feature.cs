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
    [TechTalk.SpecRun.FeatureAttribute("ListDetailsFunctionalityPart10", Description="\tRuns List Details Panel related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListDetails\\ListDetailsFunctionalityPart10.featur" +
        "e", SourceLine=0)]
    public partial class ListDetailsFunctionalityPart10Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ListDetailsFunctionalityPart10.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart10", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList(string lists, string column, string row, string listName, string listType, string data, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", lists), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3342 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3342.AddRow(new string[] {
                            string.Format("{0}", row)});
#line 12
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", column), ((string)(null)), table3342, "When ");
#line hidden
#line 15
 testRunner.When("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When(string.Format("User create static list with \"{0}\" name", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When(string.Format("User navigates to the \"{0}\" list", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.Then(string.Format("\'{0}\' label is displayed in List Details", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then(string.Format("\'{0}\' label is displayed in List Details", data), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList, Use" +
            "rs", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18127",
                "Cleanup"}, SourceLine=25)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList_Users()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList("Users", "Username", "$231000-3AC04R8AR431", "AStaticUsers18127", "List Type: Static", "Data: Users", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList, Mai" +
            "lboxes", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18127",
                "Cleanup"}, SourceLine=25)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList_Mailboxes()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "AStaticApplications18127", "List Type: Static", "Data: Mailboxes", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot(string lists, string rowGroup, string column, string value, string pivotName, string listType, string data, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot", null, @__tags);
#line 30
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
#line 31
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", lists), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3343 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3343.AddRow(new string[] {
                            string.Format("{0}", rowGroup)});
#line 33
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table3343, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3344 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3344.AddRow(new string[] {
                            string.Format("{0}", column)});
#line 36
 testRunner.When("User selects the following Columns on Pivot:", ((string)(null)), table3344, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3345 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3345.AddRow(new string[] {
                            string.Format("{0}", value)});
#line 39
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table3345, "When ");
#line hidden
#line 42
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.When(string.Format("User creates Pivot list with \"{0}\" name", pivotName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", pivotName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When(string.Format("User navigates to the \"{0}\" list", pivotName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.Then(string.Format("\'{0}\' label is displayed in List Details", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.Then(string.Format("\'{0}\' label is displayed in List Details", data), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot, Devices", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18127",
                "Cleanup"}, SourceLine=53)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot_Devices()
        {
#line 30
this.EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot("Devices", "Hostname", "Owner Compliance", "Owner City", "APivotDevices18127", "List Type: Dynamic Pivot", "Data: Devices", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot, Mailboxe" +
            "s", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18127",
                "Cleanup"}, SourceLine=53)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot_Mailboxes()
        {
#line 30
this.EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot("Mailboxes", "Alias", "Owner City", "Created Date", "APivotMailboxes18127", "List Type: Dynamic Pivot", "Data: Mailboxes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatNoRedBannerWithErrorIsDisplayedAfterSelectingLi" +
            "stWithTheAppliedAdvancedFilterOn", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS18376",
                "Cleanup"}, SourceLine=57)]
        public virtual void EvergreenJnr_DevicesList_CheckThatNoRedBannerWithErrorIsDisplayedAfterSelectingListWithTheAppliedAdvancedFilterOn()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS18376",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatNoRedBannerWithErrorIsDisplayedAfterSelectingLi" +
                    "stWithTheAppliedAdvancedFilterOn", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS18376",
                        "Cleanup"});
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
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3346 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3346.AddRow(new string[] {
                            "001PSUMZYOW581"});
                table3346.AddRow(new string[] {
                            "00CWZRC4UK6W20"});
#line 61
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table3346, "When ");
#line hidden
#line 65
 testRunner.When("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.When("User create static list with \"StaticDeviceList18376\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3347 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedList",
                            "Association"});
                table3347.AddRow(new string[] {
                            "StaticDeviceList18376",
                            "Used on device"});
#line 70
 testRunner.When("User add \"Device (Saved List)\" filter where type is \"In list\" with Selected Value" +
                        " and following Association:", ((string)(null)), table3347, "When ");
#line hidden
#line 73
 testRunner.When("User create dynamic list with \"ApplicationsDynamicList18376\" name on \"Application" +
                        "s\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.When("User navigates to \"2004 Rollout\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.When("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("User selects \'ApplicationsDynamicList18376\' in the \'Application Scope\' dropdown w" +
                        "ith wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("inline error banner is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatPermissionPanelContinuesToWorkAfterReselectingS" +
            "haringOption", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS20393",
                "Cleanup"}, SourceLine=83)]
        public virtual void EvergreenJnr_DevicesList_CheckThatPermissionPanelContinuesToWorkAfterReselectingSharingOption()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS20393",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatPermissionPanelContinuesToWorkAfterReselectingS" +
                    "haringOption", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS20393",
                        "Cleanup"});
#line 84
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
#line 85
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3348 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3348.AddRow(new string[] {
                            "CPU Virtualisation Capable"});
#line 86
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table3348, "When ");
#line hidden
#line 89
 testRunner.When("User create dynamic list with \"List20393\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("\"List20393\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.When("User selects \'Specific users / teams\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.When("User clicks \'group_add\' icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.When("User selects \'Private\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.When("User selects \'Specific users / teams\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3349 = new TechTalk.SpecFlow.Table(new string[] {
                            "User",
                            "Permission"});
                table3349.AddRow(new string[] {
                            "Automation Admin 1",
                            "Admin"});
#line 96
 testRunner.When("User adds user to list of shared person", ((string)(null)), table3349, "When ");
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
