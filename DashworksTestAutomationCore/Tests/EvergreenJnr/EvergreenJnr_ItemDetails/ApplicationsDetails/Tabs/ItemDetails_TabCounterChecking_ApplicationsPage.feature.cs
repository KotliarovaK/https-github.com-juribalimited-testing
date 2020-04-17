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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ApplicationsDetails.Tabs
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ItemDetails_TabCounterChecking_ApplicationsPage", Description="\tRuns Item Details TabCounterChecking_ApplicationsPage related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ApplicationsDetails\\Tabs\\ItemDetails_" +
        "TabCounterChecking_ApplicationsPage.feature", SourceLine=0)]
    public partial class ItemDetails_TabCounterChecking_ApplicationsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetails_TabCounterChecking_ApplicationsPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_TabCounterChecking_ApplicationsPage", "\tRuns Item Details TabCounterChecking_ApplicationsPage related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorr" +
            "ectlyForApplicationsPageInEvergreenMode", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16378",
                "DAS15583",
                "DAS15345",
                "DAS16831",
                "DAS17142",
                "DAS17524"}, SourceLine=8)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInEvergreenMode()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16378",
                    "DAS15583",
                    "DAS15345",
                    "DAS16831",
                    "DAS17142",
                    "DAS17524"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorr" +
                    "ectlyForApplicationsPageInEvergreenMode", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16378",
                        "DAS15583",
                        "DAS15345",
                        "DAS16831",
                        "DAS17142",
                        "DAS17524"});
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
 testRunner.When("User navigates to the \'Application\' details page for \'ABBYY FineReader 8.0 Profes" +
                        "sional Edition\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("Details page for \'ABBYY FineReader 8.0 Professional Edition\' item is displayed to" +
                        " the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2778 = new TechTalk.SpecFlow.Table(new string[] {
                            "TabName"});
                table2778.AddRow(new string[] {
                            "Details"});
                table2778.AddRow(new string[] {
                            "Projects"});
                table2778.AddRow(new string[] {
                            "MSI"});
                table2778.AddRow(new string[] {
                            "Distribution"});
#line 12
 testRunner.Then("User sees following parent left menu items", ((string)(null)), table2778, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2779 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2779.AddRow(new string[] {
                            "Application"});
                table2779.AddRow(new string[] {
                            "Application Owner"});
                table2779.AddRow(new string[] {
                            "Advertisements"});
                table2779.AddRow(new string[] {
                            "Programs"});
                table2779.AddRow(new string[] {
                            "Custom Fields"});
#line 19
 testRunner.And("\'Details\' left menu have following submenu items:", ((string)(null)), table2779, "And ");
#line hidden
#line 27
 testRunner.And("\'Advertisements\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("\'Programs\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("\'Custom Fields\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("\'Application\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("\'Application Owner\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2780 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2780.AddRow(new string[] {
                            "Evergreen Details"});
                table2780.AddRow(new string[] {
                            "Evergreen Incoming Apps"});
                table2780.AddRow(new string[] {
                            "Project Details"});
                table2780.AddRow(new string[] {
                            "Project Incoming Apps"});
                table2780.AddRow(new string[] {
                            "Projects"});
#line 34
 testRunner.Then("\'Projects\' left menu have following submenu items:", ((string)(null)), table2780, "Then ");
#line hidden
#line 42
 testRunner.And("\'Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("\'Evergreen Incoming Apps\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("\'Project Incoming Apps\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("\'Evergreen Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("\'Project Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.When("User navigates to the \'MSI\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2781 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2781.AddRow(new string[] {
                            "MSI Files"});
                table2781.AddRow(new string[] {
                            "AOK"});
#line 49
 testRunner.Then("\'MSI\' left menu have following submenu items:", ((string)(null)), table2781, "Then ");
#line hidden
#line 54
 testRunner.And("\'MSI Files\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("\'AOK\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.When("User navigates to the \'Distribution\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2782 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2782.AddRow(new string[] {
                            "Users"});
                table2782.AddRow(new string[] {
                            "Devices"});
                table2782.AddRow(new string[] {
                            "Groups"});
                table2782.AddRow(new string[] {
                            "AD"});
#line 58
 testRunner.Then("\'Distribution\' left menu have following submenu items:", ((string)(null)), table2782, "Then ");
#line hidden
#line 65
 testRunner.And("\'Users\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("\'Devices\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("\'Groups\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("\'AD\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorr" +
            "ectlyForApplicationsPageInProjectMode", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS15583",
                "DAS16885",
                "DAS17213",
                "DAS16831",
                "DAS17142",
                "DAS17524"}, SourceLine=70)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInProjectMode()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS15583",
                    "DAS16885",
                    "DAS17213",
                    "DAS16831",
                    "DAS17142",
                    "DAS17524"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorr" +
                    "ectlyForApplicationsPageInProjectMode", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS15583",
                        "DAS16885",
                        "DAS17213",
                        "DAS16831",
                        "DAS17142",
                        "DAS17524"});
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
 testRunner.When("User navigates to the \'Application\' details page for \'ABBYY FineReader 8.0 Profes" +
                        "sional Edition\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("Details page for \'ABBYY FineReader 8.0 Professional Edition\' item is displayed to" +
                        " the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.When("User selects \'*Project K-Computer Scheduled Project\' in the \'Item Details Project" +
                        "\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2783 = new TechTalk.SpecFlow.Table(new string[] {
                            "TabName"});
                table2783.AddRow(new string[] {
                            "Details"});
                table2783.AddRow(new string[] {
                            "Projects"});
                table2783.AddRow(new string[] {
                            "MSI"});
                table2783.AddRow(new string[] {
                            "Distribution"});
#line 75
 testRunner.Then("User sees following parent left menu items", ((string)(null)), table2783, "Then ");
#line hidden
#line 81
 testRunner.Then("\'Distribution\' left menu item is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2784 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2784.AddRow(new string[] {
                            "Application"});
                table2784.AddRow(new string[] {
                            "Application Owner"});
                table2784.AddRow(new string[] {
                            "Advertisements"});
                table2784.AddRow(new string[] {
                            "Programs"});
                table2784.AddRow(new string[] {
                            "Custom Fields"});
#line 83
 testRunner.And("\'Details\' left menu have following submenu items:", ((string)(null)), table2784, "And ");
#line hidden
#line 91
 testRunner.And("\'Advertisements\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.And("\'Programs\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("\'Custom Fields\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And("\'Application\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2785 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2785.AddRow(new string[] {
                            "Evergreen Details"});
                table2785.AddRow(new string[] {
                            "Evergreen Incoming Apps"});
                table2785.AddRow(new string[] {
                            "Project Details"});
                table2785.AddRow(new string[] {
                            "Project Incoming Apps"});
                table2785.AddRow(new string[] {
                            "Projects"});
#line 97
 testRunner.Then("\'Projects\' left menu have following submenu items:", ((string)(null)), table2785, "Then ");
#line hidden
#line 105
 testRunner.And("\'Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.And("\'Evergreen Incoming Apps\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.And("\'Project Incoming Apps\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
 testRunner.And("\'Evergreen Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And("\'Project Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.When("User navigates to the \'MSI\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2786 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2786.AddRow(new string[] {
                            "MSI Files"});
                table2786.AddRow(new string[] {
                            "AOK"});
#line 112
 testRunner.Then("\'MSI\' left menu have following submenu items:", ((string)(null)), table2786, "Then ");
#line hidden
#line 117
 testRunner.And("\'MSI Files\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.And("\'AOK\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
