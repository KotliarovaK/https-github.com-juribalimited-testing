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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AssociationsFeature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AssociationsFunctionality1", Description="\tRuns Associations Functionality related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AssociationsFeature\\AssociationsFunctionality1.fe" +
        "ature", SourceLine=0)]
    public partial class AssociationsFunctionality1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AssociationsFunctionality1.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssociationsFunctionality1", "\tRuns Associations Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatNoErrorAppearsAfterOpenningItemFromCreatedAl" +
            "lDeviceApplicationsList", new string[] {
                "Evergreen",
                "Associations",
                "DAS18425",
                "DAS18458",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatNoErrorAppearsAfterOpenningItemFromCreatedAllDeviceApplicationsList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18425",
                    "DAS18458",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatNoErrorAppearsAfterOpenningItemFromCreatedAl" +
                    "lDeviceApplicationsList", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18425",
                        "DAS18458",
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("Associations panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.Then("Export button is displayed disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User click content from \"Application Name\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatFirstAssociationsCantBeRemovedIfThereAreTw" +
            "oMoreAdded", new string[] {
                "Evergreen",
                "Associations",
                "DAS18425"}, SourceLine=21)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatFirstAssociationsCantBeRemovedIfThereAreTwoMoreAdded()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18425"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatFirstAssociationsCantBeRemovedIfThereAreTw" +
                    "oMoreAdded", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18425"});
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.When("User clicks Add And button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.When("User selects \'Not installed on device\' option in \'Search associations\' autocomple" +
                        "te of Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.When("User clicks Add And button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.When("User selects \'Entitled to device\' option in \'Search associations\' autocomplete of" +
                        " Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("Remove icon displayed in \'false\' state for \'Used on device\' association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.Then("Remove icon displayed in \'true\' state for \'Not installed on device\' association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.Then("Remove icon displayed in \'true\' state for \'Entitled to device\' association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatGridIsNotDisappearedAfterSelectingFilterOn" +
            "AllDeviceApplicationsPage", new string[] {
                "Evergreen",
                "Associations",
                "DAS18456",
                "DAS18530",
                "DAS18562",
                "DAS18127",
                "Cleanup"}, SourceLine=38)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatGridIsNotDisappearedAfterSelectingFilterOnAllDeviceApplicationsPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18456",
                    "DAS18530",
                    "DAS18562",
                    "DAS18127",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatGridIsNotDisappearedAfterSelectingFilterOn" +
                    "AllDeviceApplicationsPage", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18456",
                        "DAS18530",
                        "DAS18562",
                        "DAS18127",
                        "Cleanup"});
#line 39
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
#line 40
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.When("User creates \'AssociationList18530\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.When("User navigates to the \"AssociationList18530\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.When("user select \"App Vendor\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.When("User select \"Does not equal\" Operator value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.When("User enters \"s\" text in Search field at selected Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.When("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("User move \'Hostname\' column to \'App Vendor\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.When("User click Edit button for \"App Vendor\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.When("User clicks \'SAVE\' button and select \'UPDATE DYNAMIC LIST\' menu button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Then("\'List Type: Dynamic\' label is displayed in List Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("\'Data: Device Applications\' label is displayed in List Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.When("User navigates to the \"AssociationList18530\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatPivotCantBeRunIfAssociationWasRemoved", new string[] {
                "Evergreen",
                "Associations",
                "DAS18489",
                "Cleanup"}, SourceLine=75)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatPivotCantBeRunIfAssociationWasRemoved()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18489",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatPivotCantBeRunIfAssociationWasRemoved", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18489",
                        "Cleanup"});
#line 76
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
#line 77
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.Then("No pivot generated message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1690 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table1690.AddRow(new string[] {
                            "App Vendor"});
#line 85
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table1690, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1691 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table1691.AddRow(new string[] {
                            "App Version"});
#line 88
 testRunner.When("User selects the following Columns on Pivot:", ((string)(null)), table1691, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1692 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1692.AddRow(new string[] {
                            "Hostname"});
#line 91
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table1692, "When ");
#line hidden
#line 94
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.When("User creates Pivot list with \"Pivot18489\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.Then("\"Pivot18489\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 98
 testRunner.When("User navigates to the \"Pivot18489\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.When("User clicks the Associations button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.When("User removes \'Used on device\' association in Association panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.Then("\'RUN PIVOT\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.Then("\'RUN PIVOT\' button has tooltip with \'Use association panel to create a list\' text" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesLists_CheckThatPivotManagerIsNotOpenedByDefault", new string[] {
                "Evergreen",
                "DevicesLists",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS19937",
                "DAS19887",
                "Cleanup"}, SourceLine=104)]
        public virtual void EvergreenJnr_DevicesLists_CheckThatPivotManagerIsNotOpenedByDefault()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "DevicesLists",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS19937",
                    "DAS19887",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatPivotManagerIsNotOpenedByDefault", null, new string[] {
                        "Evergreen",
                        "DevicesLists",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS19937",
                        "DAS19887",
                        "Cleanup"});
#line 105
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
#line 106
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.Then("Associations panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
 testRunner.Then("\"Pivot\" panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1693 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table1693.AddRow(new string[] {
                            "App Vendor"});
#line 116
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table1693, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1694 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table1694.AddRow(new string[] {
                            "App Version"});
#line 119
 testRunner.When("User selects the following Columns on Pivot:", ((string)(null)), table1694, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1695 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1695.AddRow(new string[] {
                            "Hostname"});
#line 122
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table1695, "When ");
#line hidden
#line 125
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 126
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.When("User creates Pivot list with \"DAS19937_Pivot\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.Then("\"DAS19937_Pivot\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.Then("\'List Type: Dynamic Pivot\' label is displayed in List Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 132
 testRunner.Then("\'Data: Device Applications\' label is displayed in List Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 133
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 134
 testRunner.Then("\"Associations\" panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 135
 testRunner.When("User navigates to the \"DAS19937_Pivot\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 136
 testRunner.Then("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 137
 testRunner.Then("Pivot panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.Then("Associations panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
