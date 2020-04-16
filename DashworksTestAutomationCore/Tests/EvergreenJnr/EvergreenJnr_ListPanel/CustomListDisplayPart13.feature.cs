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
    [TechTalk.SpecRun.FeatureAttribute("CustomListDisplayPart13", Description="\tRuns Custom List Creation block related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListPanel\\CustomListDisplayPart13.feature", SourceLine=0)]
    public partial class CustomListDisplayPart13Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomListDisplayPart13.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart13", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList(string listType, string listTitle, string column, string listName1, string listName2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "DAS13122",
                    "DAS13125",
                    "DAS13126",
                    "DAS13123",
                    "DAS13127",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When(string.Format("User clicks on \'{0}\' column header", column), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", listName1, listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", listName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When(string.Format("User clicks \'Set default\' option in cogmenu for \'{0}\' list", listName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When(string.Format("User clicks on \'{0}\' column header", column), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", listName2, listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.When(string.Format("User clicks \'Set default\' option in cogmenu for \'{0}\' list", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.When(string.Format("User clicks \'Remove default\' option in cogmenu for \'{0}\' list", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS13122",
                "DAS13125",
                "DAS13126",
                "DAS13123",
                "DAS13127",
                "Cleanup"}, SourceLine=29)]
        public virtual void EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList_Devices()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList("Devices", "All Devices", "Hostname", "DeviceDefault1", "DeviceDefault2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS13122",
                "DAS13125",
                "DAS13126",
                "DAS13123",
                "DAS13127",
                "Cleanup"}, SourceLine=29)]
        public virtual void EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList_Users()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList("Users", "All Users", "Username", "UserDefault1", "UserDefault2", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList(string listType, string listTitle, string listName1, string listName2, string itemName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "DAS13122",
                    "DAS13125",
                    "DAS13126",
                    "DAS13123",
                    "DAS13127",
                    "DAS13135",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3415 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3415.AddRow(new string[] {
                            string.Format("{0}", itemName)});
#line 37
 testRunner.When(string.Format("User create static list with \"{0}\" name on \"{1}\" page with following items", listName1, listType), ((string)(null)), table3415, "When ");
#line hidden
#line 40
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", listName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.When(string.Format("User clicks \'Set default\' option in cogmenu for \'{0}\' list", listName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", listName2, listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When(string.Format("User clicks \'Set default\' option in cogmenu for \'{0}\' list", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When(string.Format("User clicks \'Remove default\' option in cogmenu for \'{0}\' list", listName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS13122",
                "DAS13125",
                "DAS13126",
                "DAS13123",
                "DAS13127",
                "DAS13135",
                "Cleanup"}, SourceLine=54)]
        public virtual void EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList_Applications()
        {
#line 34
this.EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList("Applications", "All Applications", "ApplicationDefault1", "ApplicationDefault2", "Microsoft SDK Update February 2003 (5.2.3790.0)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS13122",
                "DAS13125",
                "DAS13126",
                "DAS13123",
                "DAS13127",
                "DAS13135",
                "Cleanup"}, SourceLine=54)]
        public virtual void EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList_Mailboxes()
        {
#line 34
this.EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList("Mailboxes", "All Mailboxes", "MailboxDefault1", "MailboxDefault2", "000F977AC8824FE39B8@bclabs.local", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_Devices_CheckThatDefaultListOptionInDetailsPanelWorks", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListPanel",
                "DAS13129",
                "DAS13130",
                "Cleanup"}, SourceLine=58)]
        public virtual void EvergreenJnr_Devices_CheckThatDefaultListOptionInDetailsPanelWorks()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "DAS13129",
                    "DAS13130",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Devices_CheckThatDefaultListOptionInDetailsPanelWorks", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListPanel",
                        "DAS13129",
                        "DAS13130",
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
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.When("User clicks on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.When("User create dynamic list with \"DeviceListToTestDefault\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("\"DeviceListToTestDefault\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("User selects state \'true\' for \'Default List\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("\'DeviceListToTestDefault\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_Devices_CheckThatNewUserHasNoDefaultListSet", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "DAS13185",
                "Cleanup"}, SourceLine=71)]
        public virtual void EvergreenJnr_Devices_CheckThatNewUserHasNoDefaultListSet()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "DAS13185",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Devices_CheckThatNewUserHasNoDefaultListSet", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "DAS13185",
                        "Cleanup"});
#line 72
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
                TechTalk.SpecFlow.Table table3416 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Email",
                            "FullName",
                            "Password",
                            "Roles"});
                table3416.AddRow(new string[] {
                            "DAS13129",
                            "Value",
                            "FN13129",
                            "m!gration",
                            "Project Administrator"});
#line 73
 testRunner.When("User create new User via API", ((string)(null)), table3416, "When ");
#line hidden
#line 76
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3417 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table3417.AddRow(new string[] {
                            "DAS13129",
                            "m!gration"});
#line 77
 testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table3417, "When ");
#line hidden
#line 80
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_Devices_CheckDefaultListIsResetIfItWasNoLongerAvalaible", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ListPanel",
                "DAS13136",
                "Cleanup"}, SourceLine=83)]
        public virtual void EvergreenJnr_Devices_CheckDefaultListIsResetIfItWasNoLongerAvalaible()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "DAS13136",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Devices_CheckDefaultListIsResetIfItWasNoLongerAvalaible", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "DAS13136",
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
                TechTalk.SpecFlow.Table table3418 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Email",
                            "FullName",
                            "Password",
                            "Roles"});
                table3418.AddRow(new string[] {
                            "DAS13136_1",
                            "Value",
                            "FN_13136_1",
                            "m!gration",
                            "Project Administrator"});
                table3418.AddRow(new string[] {
                            "DAS13136_2",
                            "Value",
                            "FN_13136_2",
                            "m!gration",
                            "Project Administrator"});
#line 85
 testRunner.When("User create new User via API", ((string)(null)), table3418, "When ");
#line hidden
#line 89
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3419 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table3419.AddRow(new string[] {
                            "DAS13136_1",
                            "m!gration"});
#line 90
 testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table3419, "When ");
#line hidden
#line 93
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.When("User clicks on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.When("User create dynamic list with \"DAS13136forShare\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.Then("\"DAS13136forShare\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.When("User selects \'Everyone can see\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3420 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table3420.AddRow(new string[] {
                            "DAS13136_2",
                            "m!gration"});
#line 100
 testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table3420, "When ");
#line hidden
#line 103
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.When("User clicks \'Set default\' option in cogmenu for \'DAS13136forShare\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 105
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3421 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table3421.AddRow(new string[] {
                            "DAS13136_1",
                            "m!gration"});
#line 106
 testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table3421, "When ");
#line hidden
#line 109
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'DAS13136forShare\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.When("User confirms list removing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3422 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table3422.AddRow(new string[] {
                            "DAS13136_2",
                            "m!gration"});
#line 113
 testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table3422, "When ");
#line hidden
#line 116
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 117
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
