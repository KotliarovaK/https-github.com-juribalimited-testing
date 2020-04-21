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
    [TechTalk.SpecRun.FeatureAttribute("ListDetailsFunctionalityPart2", Description="\tRuns List Details Panel related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListDetails\\ListDetailsFunctionalityPart2.feature" +
        "", SourceLine=0)]
    public partial class ListDetailsFunctionalityPart2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ListDetailsFunctionalityPart2.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart2", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS10880"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.Then("List details button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists, Device" +
            "s", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880"}, SourceLine=15)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists_Devices()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists("Devices", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880"}, SourceLine=15)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists_Users()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists("Users", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists, Applic" +
            "ations", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880"}, SourceLine=15)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists_Applications()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists("Applications", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists, Mailbo" +
            "xes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880"}, SourceLine=15)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists_Mailboxes()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists("Mailboxes", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists(string pageName, string columnname, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS10880",
                    "DAS11951",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists", null, @__tags);
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
#line 23
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.When(string.Format("User create dynamic list with \"TestListCED2D6\" name on \"{0}\" page", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("\"TestListCED2D6\" name is displayed in list details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.Then("\'Favourite List\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.Then("\'Private\' content is displayed in \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS11951",
                "Cleanup"}, SourceLine=37)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists_Devices()
        {
#line 22
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists("Devices", "Hostname", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS11951",
                "Cleanup"}, SourceLine=37)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists_Users()
        {
#line 22
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists("Users", "Username", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists, Applicatio" +
            "ns", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS11951",
                "Cleanup"}, SourceLine=37)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists_Applications()
        {
#line 22
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists("Applications", "Application", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS11951",
                "Cleanup"}, SourceLine=37)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists_Mailboxes()
        {
#line 22
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists("Mailboxes", "Email Address", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS10880",
                    "DAS12152",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists", null, @__tags);
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
                TechTalk.SpecFlow.Table table3323 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3323.AddRow(new string[] {
                            ""});
#line 45
 testRunner.When(string.Format("User create static list with \"Static List TestName\" name on \"{0}\" page with follo" +
                            "wing items", pageName), ((string)(null)), table3323, "When ");
#line hidden
#line 48
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.Then("\"Static List TestName\" name is displayed in list details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.Then("\'Favourite List\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.Then("\'Private\' content is displayed in \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS12152",
                "Cleanup"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists_Devices()
        {
#line 44
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists("Devices", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS12152",
                "Cleanup"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists_Users()
        {
#line 44
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists("Users", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists, Application" +
            "s", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS12152",
                "Cleanup"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists_Applications()
        {
#line 44
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists("Applications", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS10880",
                "DAS12152",
                "Cleanup"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists_Mailboxes()
        {
#line 44
this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists("Mailboxes", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel(string pageName, string columnname, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS11493",
                    "DAS11951",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel", null, @__tags);
#line 64
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
#line 65
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User creates \'TestListE11493\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("\"TestListE11493\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.When("User selects \'Automation Admin 1\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.Then("List details button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.Then("list with \"TestListE11493\" name is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS11493",
                "DAS11951",
                "Cleanup"}, SourceLine=79)]
        public virtual void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel_Devices()
        {
#line 64
this.EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel("Devices", "Hostname", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS11493",
                "DAS11951",
                "Cleanup"}, SourceLine=79)]
        public virtual void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel_Users()
        {
#line 64
this.EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel("Users", "Username", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel, Applicati" +
            "ons", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS11493",
                "DAS11951",
                "Cleanup"}, SourceLine=79)]
        public virtual void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel_Applications()
        {
#line 64
this.EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel("Applications", "Application", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel, Mailboxes" +
            "", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS11493",
                "DAS11951",
                "Cleanup"}, SourceLine=79)]
        public virtual void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel_Mailboxes()
        {
#line 64
this.EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel("Mailboxes", "Email Address", ((string[])(null)));
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
