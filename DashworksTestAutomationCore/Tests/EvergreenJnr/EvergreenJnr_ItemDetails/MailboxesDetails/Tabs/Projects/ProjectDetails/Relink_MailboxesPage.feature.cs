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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.MailboxesDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Relink_MailboxesPage", Description="\tRuns Relink related tests on Mailboxes Page", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\MailboxesDetails\\Tabs\\Projects\\Projec" +
        "tDetails\\Relink_MailboxesPage.feature", SourceLine=0)]
    public partial class Relink_MailboxesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Relink_MailboxesPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Relink_MailboxesPage", "\tRuns Relink related tests on Mailboxes Page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetail" +
            "sOnMailboxesPage", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_ItemDetails",
                "Relink",
                "DAS18002",
                "DAS18112",
                "DAS18284",
                "Cleanup",
                "Not_Run"}, SourceLine=9)]
        public virtual void EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "Relink",
                    "DAS18002",
                    "DAS18112",
                    "DAS18284",
                    "Cleanup",
                    "Not_Run"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetail" +
                    "sOnMailboxesPage", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "Relink",
                        "DAS18002",
                        "DAS18112",
                        "DAS18284",
                        "Cleanup",
                        "Not_Run"});
#line 10
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
#line 11
 testRunner.When("User navigates to the \'Mailbox\' details page for \'01A921EFD05545818AA@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("Details page for \'01A921EFD05545818AA@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("User selects \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3233 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Data"});
                table3233.AddRow(new string[] {
                            "Name",
                            "01A921EFD05545818AA@bclabs.local"});
                table3233.AddRow(new string[] {
                            "Mailbox Owner",
                            "Leon, Nacoma"});
#line 16
 testRunner.Then("User verifies data in the fields on details page", ((string)(null)), table3233, "Then ");
#line hidden
#line 20
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("\'Resync owner and users\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("\'Resync name\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When("User enters \'04D158C83A0142F3B79\' in the \'Mailbox\' autocomplete field and selects" +
                        " \'04D158C83A0142F3B79@bclabs.local\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When("User selects state \'true\' for \'Resync owner and users\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.When("User selects state \'true\' for \'Resync name\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.When("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("\'This object will be relinked to the selected Evergreen object in this project\' t" +
                        "ext is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.When("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("\'Mailbox successfully relinked\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User waits for \'3\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("Details page for \'04D158C83A0142F3B79@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3234 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Data"});
                table3234.AddRow(new string[] {
                            "Name",
                            "01A921EFD05545818AA@bclabs.local"});
                table3234.AddRow(new string[] {
                            "Mailbox Owner",
                            "Leon, Nacoma"});
#line 34
 testRunner.And("User verifies data in the fields on details page", ((string)(null)), table3234, "And ");
#line hidden
#line 38
 testRunner.When("User clicks \'RESYNC\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And("User clicks \'RESYNC\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then("\'The Evergreen owner of this Mailbox has been queued for onboarding into this pro" +
                        "ject, the change in ownership for this Mailbox will show once this is complete\' " +
                        "text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.When("User waits for \'3\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3235 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Data"});
                table3235.AddRow(new string[] {
                            "Name",
                            "04D158C83A0142F3B79@bclabs.local"});
                table3235.AddRow(new string[] {
                            "Mailbox Owner",
                            "Jin, Jh"});
#line 43
 testRunner.Then("User verifies data in the fields on details page", ((string)(null)), table3235, "Then ");
#line hidden
#line 47
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.And("User enters \'01A921EFD05545818AA\' in the \'Mailbox\' autocomplete field and selects" +
                        " \'01A921EFD05545818AA@bclabs.local\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.Then("\'Mailbox successfully relinked\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("User waits for \'3\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When("User navigates to the \'User\' details page for \'04D158C83A0142F3B79\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("User selects \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS19335"}, SourceLine=62)]
        public virtual void EvergreenJnr_MailboxesList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS19335"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19335"});
#line 63
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
#line 64
 testRunner.When("User navigates to the \'Mailbox\' details page for \'00DB4000EDD84951993@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.Then("Details page for \'00DB4000EDD84951993@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.When("User selects \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then("Button \'RELINK\' has \'Select a mailbox\' tooltip on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringP" +
            "artOfObjectKeyToAutocomplete", new string[] {
                "Evergreen",
                "Mailbox",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS19323",
                "Universe"}, SourceLine=73)]
        public virtual void EvergreenJnr_MailboxList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailbox",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS19323",
                    "Universe"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringP" +
                    "artOfObjectKeyToAutocomplete", null, new string[] {
                        "Evergreen",
                        "Mailbox",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19323",
                        "Universe"});
#line 74
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
#line 75
 testRunner.When("User navigates to the \'Mailbox\' details page for \'0072B088173449E3A93@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("Details page for \'0072B088173449E3A93@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.When("User selects \'Mailbox Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("only options having search term \'993\' are displayed in \'Mailbox\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
