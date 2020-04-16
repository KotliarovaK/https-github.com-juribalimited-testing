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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_DashboardsPage
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("WidgetHalfDonut", Description="\tRuns tests for Half Donut Widgets creation or editing", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_DashboardsPage\\WidgetHalfDonut.feature", SourceLine=0)]
    public partial class WidgetHalfDonutFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "WidgetHalfDonut.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WidgetHalfDonut", "\tRuns tests for Half Donut Widgets creation or editing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatOrderByShowsCorrectOptionsForHalfDonut", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS15918"}, SourceLine=8)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatOrderByShowsCorrectOptionsForHalfDonut()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS15918"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatOrderByShowsCorrectOptionsForHalfDonut", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS15918"});
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
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2184 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy"});
                table2184.AddRow(new string[] {
                            "Half donut",
                            "WidgetForDAS15918",
                            "2004 Rollout",
                            "Count",
                            "2004: Pre-Migration \\ Ready to Migrate"});
#line 12
 testRunner.And("User adds new Widget", ((string)(null)), table2184, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2185 = new TechTalk.SpecFlow.Table(new string[] {
                            "items"});
                table2185.AddRow(new string[] {
                            "2004: Pre-Migration \\ Ready to Migrate ASC"});
                table2185.AddRow(new string[] {
                            "2004: Pre-Migration \\ Ready to Migrate DESC"});
                table2185.AddRow(new string[] {
                            "Count ASC"});
                table2185.AddRow(new string[] {
                            "Count DESC"});
#line 15
 testRunner.Then("User sees following options for Order By selector on Create Widget page:", ((string)(null)), table2185, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero(string widgetType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS16167",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetRes" +
                    "ultsAreAllZero", null, @__tags);
#line 23
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
#line 24
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2186 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2186.AddRow(new string[] {
                            "HDD Total Size (GB)"});
#line 25
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table2186, "When ");
#line hidden
#line 28
 testRunner.And("User create dynamic list with \"DAS16167_HddList\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("Dashboard with \'DAS16167_HddList\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2187 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "SplitBy",
                            "AggregateFunction",
                            "AggregateBy",
                            "OrderBy"});
                table2187.AddRow(new string[] {
                            string.Format("{0}", widgetType),
                            "HddListDAS16167",
                            "DAS16167_HddList",
                            "Operating System",
                            "Minimum",
                            "HDD Total Size (GB)",
                            "HDD Total Size (GB) Minimum ASC"});
#line 32
 testRunner.And("User adds new Widget", ((string)(null)), table2187, "And ");
#line hidden
#line 35
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("\'All values are 0\' message is displayed in Preview", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("\'HddListDAS16167\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.And("\'All values are 0\' message is displayed in \'HddListDAS16167\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetRes" +
            "ultsAreAllZero, Pie", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS16167",
                "Cleanup"}, SourceLine=42)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero_Pie()
        {
#line 23
this.EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero("Pie", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetRes" +
            "ultsAreAllZero, Donut", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS16167",
                "Cleanup"}, SourceLine=42)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero_Donut()
        {
#line 23
this.EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero("Donut", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetRes" +
            "ultsAreAllZero, Half donut", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS16167",
                "Cleanup"}, SourceLine=42)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero_HalfDonut()
        {
#line 23
this.EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero("Half donut", ((string[])(null)));
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
