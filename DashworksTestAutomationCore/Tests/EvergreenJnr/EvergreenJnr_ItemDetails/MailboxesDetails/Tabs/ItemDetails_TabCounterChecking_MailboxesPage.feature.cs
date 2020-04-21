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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.MailboxesDetails.Tabs
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ItemDetails_TabCounterChecking_MailboxesPage", Description="\tRuns Item Details TabCounterChecking_MailboxesPage related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\MailboxesDetails\\Tabs\\ItemDetails_Tab" +
        "CounterChecking_MailboxesPage.feature", SourceLine=0)]
    public partial class ItemDetails_TabCounterChecking_MailboxesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetails_TabCounterChecking_MailboxesPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_TabCounterChecking_MailboxesPage", "\tRuns Item Details TabCounterChecking_MailboxesPage related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
            "lyForMailboxesPageInEvergreenMode", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16378",
                "DAS15583",
                "DAS16905",
                "DAS16832",
                "DAS17143",
                "DAS17521"}, SourceLine=8)]
        public virtual void EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16378",
                    "DAS15583",
                    "DAS16905",
                    "DAS16832",
                    "DAS17143",
                    "DAS17521"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
                    "lyForMailboxesPageInEvergreenMode", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16378",
                        "DAS15583",
                        "DAS16905",
                        "DAS16832",
                        "DAS17143",
                        "DAS17521"});
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
 testRunner.When("User navigates to the \'Mailbox\' details page for \'00B5CCB89AD0404B965@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("Details page for \'00B5CCB89AD0404B965@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3203 = new TechTalk.SpecFlow.Table(new string[] {
                            "TabName"});
                table3203.AddRow(new string[] {
                            "Details"});
                table3203.AddRow(new string[] {
                            "Projects"});
                table3203.AddRow(new string[] {
                            "Users"});
                table3203.AddRow(new string[] {
                            "Trend"});
#line 12
 testRunner.And("User sees following parent left menu items", ((string)(null)), table3203, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3204 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3204.AddRow(new string[] {
                            "Mailbox"});
                table3204.AddRow(new string[] {
                            "Mailbox Owner"});
                table3204.AddRow(new string[] {
                            "Email Addresses"});
                table3204.AddRow(new string[] {
                            "Department and Location"});
                table3204.AddRow(new string[] {
                            "Custom Fields"});
#line 22
 testRunner.And("\'Details\' left menu have following submenu items:", ((string)(null)), table3204, "And ");
#line hidden
#line 30
 testRunner.And("\'Custom Fields\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("\'Email Addresses\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("\'Mailbox\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("\'Mailbox Owner\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("\'Department and Location\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3205 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3205.AddRow(new string[] {
                            "Evergreen Details"});
                table3205.AddRow(new string[] {
                            "Project Details"});
                table3205.AddRow(new string[] {
                            "Mailbox Projects"});
                table3205.AddRow(new string[] {
                            "Mailbox User Projects"});
#line 37
 testRunner.Then("\'Projects\' left menu have following submenu items:", ((string)(null)), table3205, "Then ");
#line hidden
#line 44
 testRunner.And("\'Mailbox Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("\'Mailbox User Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("\'Evergreen Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("\'Project Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.When("User navigates to the \'Users\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3206 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3206.AddRow(new string[] {
                            "Users"});
                table3206.AddRow(new string[] {
                            "Groups"});
                table3206.AddRow(new string[] {
                            "Unresolved Users"});
                table3206.AddRow(new string[] {
                            "Mailbox Permissions"});
                table3206.AddRow(new string[] {
                            "Folder Permissions"});
#line 50
 testRunner.Then("\'Users\' left menu have following submenu items:", ((string)(null)), table3206, "Then ");
#line hidden
#line 58
 testRunner.And("\'Users\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("\'Groups\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("\'Unresolved Users\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("\'Mailbox Permissions\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("\'Folder Permissions\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.When("User navigates to the \'Trend\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3207 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3207.AddRow(new string[] {
                            "Email Count"});
                table3207.AddRow(new string[] {
                            "Mailbox Size"});
                table3207.AddRow(new string[] {
                            "Associated Item Count"});
                table3207.AddRow(new string[] {
                            "Deleted Item Count"});
                table3207.AddRow(new string[] {
                            "Deleted Item Size"});
#line 65
 testRunner.Then("\'Trend\' left menu have following submenu items:", ((string)(null)), table3207, "Then ");
#line hidden
#line 73
 testRunner.And("\'Email Count\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("\'Mailbox Size\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("\'Associated Item Count\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("\'Deleted Item Count\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("\'Deleted Item Size\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
            "lyForMailboxesPageInProjectMode", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS15583",
                "DAS16906",
                "DAS16832",
                "DAS17143",
                "DAS17521"}, SourceLine=79)]
        public virtual void EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectMode()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS15583",
                    "DAS16906",
                    "DAS16832",
                    "DAS17143",
                    "DAS17521"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
                    "lyForMailboxesPageInProjectMode", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS15583",
                        "DAS16906",
                        "DAS16832",
                        "DAS17143",
                        "DAS17521"});
#line 80
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
#line 81
 testRunner.When("User navigates to the \'Mailbox\' details page for \'00B5CCB89AD0404B965@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("Details page for \'00B5CCB89AD0404B965@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("User selects \'Mailbox Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3208 = new TechTalk.SpecFlow.Table(new string[] {
                            "TabName"});
                table3208.AddRow(new string[] {
                            "Details"});
                table3208.AddRow(new string[] {
                            "Projects"});
                table3208.AddRow(new string[] {
                            "Users"});
                table3208.AddRow(new string[] {
                            "Trend"});
#line 84
 testRunner.Then("User sees following parent left menu items", ((string)(null)), table3208, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3209 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3209.AddRow(new string[] {
                            "Mailbox"});
                table3209.AddRow(new string[] {
                            "Mailbox Owner"});
                table3209.AddRow(new string[] {
                            "Email Addresses"});
                table3209.AddRow(new string[] {
                            "Department and Location"});
                table3209.AddRow(new string[] {
                            "Custom Fields"});
#line 91
 testRunner.And("\'Details\' left menu have following submenu items:", ((string)(null)), table3209, "And ");
#line hidden
#line 99
 testRunner.And("\'Custom Fields\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And("\'Email Addresses\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And("\'Mailbox\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("\'Mailbox Owner\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.And("\'Department and Location\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3210 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3210.AddRow(new string[] {
                            "Evergreen Details"});
                table3210.AddRow(new string[] {
                            "Project Details"});
                table3210.AddRow(new string[] {
                            "Mailbox Projects"});
                table3210.AddRow(new string[] {
                            "Mailbox User Projects"});
#line 106
 testRunner.Then("\'Projects\' left menu have following submenu items:", ((string)(null)), table3210, "Then ");
#line hidden
#line 113
 testRunner.And("\'Mailbox Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("\'Mailbox User Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("\'Evergreen Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And("\'Project Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.When("User navigates to the \'Users\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3211 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3211.AddRow(new string[] {
                            "Users"});
                table3211.AddRow(new string[] {
                            "Groups"});
                table3211.AddRow(new string[] {
                            "Unresolved Users"});
                table3211.AddRow(new string[] {
                            "Mailbox Permissions"});
                table3211.AddRow(new string[] {
                            "Folder Permissions"});
#line 119
 testRunner.Then("\'Users\' left menu have following submenu items:", ((string)(null)), table3211, "Then ");
#line hidden
#line 127
 testRunner.And("\'Users\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.And("\'Groups\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And("\'Unresolved Users\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("\'Mailbox Permissions\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.And("\'Folder Permissions\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 133
 testRunner.When("User navigates to the \'Trend\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3212 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table3212.AddRow(new string[] {
                            "Email Count"});
                table3212.AddRow(new string[] {
                            "Mailbox Size"});
                table3212.AddRow(new string[] {
                            "Associated Item Count"});
                table3212.AddRow(new string[] {
                            "Deleted Item Count"});
                table3212.AddRow(new string[] {
                            "Deleted Item Size"});
#line 134
 testRunner.Then("\'Trend\' left menu have following submenu items:", ((string)(null)), table3212, "Then ");
#line hidden
#line 142
 testRunner.And("\'Email Count\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 143
 testRunner.And("\'Mailbox Size\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.And("\'Associated Item Count\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.And("\'Deleted Item Count\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 146
 testRunner.And("\'Deleted Item Size\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
