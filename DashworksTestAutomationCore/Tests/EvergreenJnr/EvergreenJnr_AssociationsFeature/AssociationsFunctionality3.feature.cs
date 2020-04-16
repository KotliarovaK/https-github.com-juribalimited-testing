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
    [TechTalk.SpecRun.FeatureAttribute("AssociationsFunctionality3", Description="\tRuns Associations Functionality related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AssociationsFeature\\AssociationsFunctionality3.fe" +
        "ature", SourceLine=0)]
    public partial class AssociationsFunctionality3Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AssociationsFunctionality3.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssociationsFunctionality3", "\tRuns Associations Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter(string operator1, string operator2, string operator3, string hostname, string application, string installed, string used, string entitled, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18426",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
                    "titledToDeviceFilter", null, @__tags);
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
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.When(string.Format("User selects \'{0}\' option in \'Search associations\' autocomplete of Associations p" +
                            "anel", operator1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When("User clicks Add And button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When(string.Format("User selects \'{0}\' option in \'Search associations\' autocomplete of Associations p" +
                            "anel", operator2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User clicks Add And button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.When(string.Format("User selects \'{0}\' option in \'Search associations\' autocomplete of Associations p" +
                            "anel", operator3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When("User clicks content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", hostname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When(string.Format("User enters \"{0}\" text in the Search field for \"Application\" column", application), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'Installed\' column", installed), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'Used\' column", used), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then(string.Format("\'{0}\' content is displayed in the \'Entitled\' column", entitled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
            "titledToDeviceFilter, Variant 0", new string[] {
                "Evergreen",
                "Associations",
                "DAS18426",
                "Cleanup"}, SourceLine=31)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter_Variant0()
        {
#line 9
this.EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter("Used on device", "Not entitled to device", "Not installed on device", "00BDM1JUR8IF419", "20040610sqlserverck", "UNKNOWN", "TRUE", "FALSE", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
            "titledToDeviceFilter, Variant 1", new string[] {
                "Evergreen",
                "Associations",
                "DAS18426",
                "Cleanup"}, SourceLine=31)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter_Variant1()
        {
#line 9
this.EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter("Entitled to device", "Installed on device", "Not used on device", "001BAQXT6JWFPI", "AddressGrabber Standard", "TRUE", "UNKNOWN", "TRUE", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
            "titledToDeviceFilter, Variant 2", new string[] {
                "Evergreen",
                "Associations",
                "DAS18426",
                "Cleanup"}, SourceLine=31)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter_Variant2()
        {
#line 9
this.EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter("Entitled to device", "Not installed on device", "Not used on device", "00BDM1JUR8IF419", "cdparanoia-libs", "UNKNOWN", "FALSE", "TRUE", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEn" +
            "titledToDeviceFilter, Variant 3", new string[] {
                "Evergreen",
                "Associations",
                "DAS18426",
                "Cleanup"}, SourceLine=31)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter_Variant3()
        {
#line 9
this.EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter("Installed on device", "Not entitled to device", "Not used on device", "00KWQ4J3WKQM0G", "Adobe Reader 6.0.1 - Fran?ais", "TRUE", "UNKNOWN", "FALSE", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue(string filter, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18804"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
                    "NegativeValue", null, @__tags);
#line 38
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
#line 39
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1698 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1698.AddRow(new string[] {
                            "-1"});
#line 45
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following valu" +
                            "e:", filter), ((string)(null)), table1698, "When ");
#line hidden
#line 48
 testRunner.When("User clicks the Associations button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 0", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant0()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Device Key", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 1", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant1()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Application Key", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 2", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant2()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("CPU Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 3", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant3()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("CPU Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 4", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant4()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("CPU Speed (GHz)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 5", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant5()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("HDD Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 6", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant6()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("HDD Total Size (GB)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 7", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant7()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Memory (GB)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 8", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant8()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Monitor Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 9", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant9()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Network Card Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 10", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant10()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Sound Card Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 11", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant11()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Target Drive Free Space (GB)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWith" +
            "NegativeValue, Variant 12", new string[] {
                "Evergreen",
                "Associations",
                "DAS18804"}, SourceLine=53)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue_Variant12()
        {
#line 38
this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue("Video Card Count", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAn" +
            "dRunninList", new string[] {
                "Evergreen",
                "Associations",
                "DAS18454",
                "Cleanup"}, SourceLine=68)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAndRunninList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18454",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAn" +
                    "dRunninList", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18454",
                        "Cleanup"});
#line 69
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
#line 70
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.When("User selects \'Entitled to device\' option in \'Search associations\' autocomplete of" +
                        " Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.When("User clicks on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.When("User removes \"App Vendor\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningLis" +
            "t", new string[] {
                "Evergreen",
                "Associations",
                "DAS18897",
                "Cleanup"}, SourceLine=83)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18897",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningLis" +
                    "t", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18897",
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.When("User selects \'Entitled to device\' option in \'Search associations\' autocomplete of" +
                        " Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 91
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.Then("All column headers are unique", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToA" +
            "llDeviceApplicationsPageFromSavedList", new string[] {
                "Evergreen",
                "Associations",
                "DAS18447",
                "Cleanup"}, SourceLine=94)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToAllDeviceApplicationsPageFromSavedList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18447",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToA" +
                    "llDeviceApplicationsPageFromSavedList", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18447",
                        "Cleanup"});
#line 95
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
#line 96
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.When("User creates \'AssociationList18447\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 104
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 105
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.Then("Associations Button is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.Then("Associations panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
