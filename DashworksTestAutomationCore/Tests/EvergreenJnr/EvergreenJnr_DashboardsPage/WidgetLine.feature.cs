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
    [TechTalk.SpecRun.FeatureAttribute("WidgetLine", Description="\tRuns tests for Line Widgets creation or editing", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_DashboardsPage\\WidgetLine.feature", SourceLine=0)]
    public partial class WidgetLineFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "WidgetLine.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WidgetLine", "\tRuns tests for Line Widgets creation or editing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByIn" +
            "Dropdown", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS15737",
                "DAS15662",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdown()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS15737",
                    "DAS15662",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByIn" +
                    "Dropdown", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS15737",
                        "DAS15662",
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
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2216 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2216.AddRow(new string[] {
                            "prK: Application Readiness"});
#line 11
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table2216, "When ");
#line hidden
#line 14
 testRunner.And("User create dynamic list with \"TestList_DAS15737\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("Dashboard with \'Dashboard for DAS15737\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.When("User selects \'Line\' in the \'WidgetType\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And("User enters \'DAS15737\' as Widget Title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When("User selects \'TestList_DAS15737\' option from \'List\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When("User selects \'prK: Application Readiness\' in the \'SplitBy\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When("User selects \'Count\' in the \'AggregateFunction\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.When("User selects \'prK: Application Readiness ASC\' in the \'OrderBy\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.When("User clicks \'Colour Scheme\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("Colour Scheme dropdown is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.Then("\'Show data labels\' checkbox is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then("\'Show legend\' checkbox is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPag" +
            "e", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS16069",
                "Cleanup"}, SourceLine=30)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS16069",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPag" +
                    "e", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS16069",
                        "Cleanup"});
#line 31
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
#line 32
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("user select \"Device Type\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("User clicks in search field in the Filter block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("User enters \"Desktop\" text in Search field at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("User clicks checkbox at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2217 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2217.AddRow(new string[] {
                            "2004: Pre-Migration \\ Scheduled Date"});
#line 41
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2217, "And ");
#line hidden
#line 44
 testRunner.And("User create dynamic list with \"2004 ScheduleDAS16069\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("\"2004 ScheduleDAS16069\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("Dashboard with \'2004 ProjectDAS16069\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2218 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateBy",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy",
                            "Drilldown"});
                table2218.AddRow(new string[] {
                            "Line",
                            "Project ScheduleDAS16069",
                            "2004 ScheduleDAS16069",
                            "Hostname",
                            "Count distinct",
                            "2004: Pre-Migration \\ Scheduled Date",
                            "2004: Pre-Migration \\ Scheduled Date ASC",
                            "Yes"});
#line 49
 testRunner.And("User adds new Widget", ((string)(null)), table2218, "And ");
#line hidden
#line 52
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("\'Project ScheduleDAS16069\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2219 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetName",
                            "NumberOfPoint",
                            "Tooltip"});
                table2219.AddRow(new string[] {
                            "Project ScheduleDAS16069",
                            "1",
                            "5 Nov 2018 4"});
#line 56
 testRunner.Then("Tooltip is displayed for the point of Line widget", ((string)(null)), table2219, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2220 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetName",
                            "NumberOfPoint"});
                table2220.AddRow(new string[] {
                            "Project ScheduleDAS16069",
                            "1"});
#line 59
 testRunner.When("User clicks point of Line widget", ((string)(null)), table2220, "When ");
#line hidden
#line 62
 testRunner.Then("\"4\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2221 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2221.AddRow(new string[] {
                            "Hostname"});
                table2221.AddRow(new string[] {
                            "Device Type"});
                table2221.AddRow(new string[] {
                            "Operating System"});
                table2221.AddRow(new string[] {
                            "Owner Display Name"});
                table2221.AddRow(new string[] {
                            "2004: Pre-Migration \\ Scheduled Date"});
#line 63
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table2221, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCo" +
            "rrectlyOnDashboard", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS15920",
                "DAS15662",
                "Cleanup"}, SourceLine=71)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboard()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS15920",
                    "DAS15662",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCo" +
                    "rrectlyOnDashboard", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS15920",
                        "DAS15662",
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
#line 73
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2222 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2222.AddRow(new string[] {
                            "Device Application Compliance"});
                table2222.AddRow(new string[] {
                            "Compliance"});
#line 74
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table2222, "When ");
#line hidden
#line 78
 testRunner.And("User create dynamic list with \"ListForDas15920\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("Dashboard with \'DashboardForDas15920\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2223 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy",
                            "Drilldown"});
                table2223.AddRow(new string[] {
                            "Line",
                            "LineWidgetForDas15920",
                            "ListForDas15920",
                            "Count",
                            "Device Application Compliance",
                            "Device Application Compliance ASC",
                            "Yes"});
#line 82
 testRunner.And("User adds new Widget", ((string)(null)), table2223, "And ");
#line hidden
#line 85
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.Then("\'Show data labels\' checkbox is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.Then("\'LineWidgetForDas15920\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.And("Line chart displayed in \'LineWidgetForDas15920\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "DAS15544",
                "Cleanup"}, SourceLine=91)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "DAS15544",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS15544",
                        "Cleanup"});
#line 92
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
#line 93
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2224 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2224.AddRow(new string[] {
                            "Service Pack or Build"});
#line 94
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table2224, "When ");
#line hidden
#line 97
 testRunner.And("User create dynamic list with \"ListForDas15544\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("Dashboard with \'2004 ProjectDAS15544\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2225 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy",
                            "Drilldown"});
                table2225.AddRow(new string[] {
                            "Line",
                            "SortOrderCheckForDas15544",
                            "ListForDas15544",
                            "Count",
                            "Service Pack or Build",
                            "Service Pack or Build ASC",
                            "Yes"});
#line 101
 testRunner.And("User adds new Widget", ((string)(null)), table2225, "And ");
#line hidden
#line 104
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.Then("\'SortOrderCheckForDas15544\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2226 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2226.AddRow(new string[] {
                            "Empty"});
                table2226.AddRow(new string[] {
                            "No Service Pack"});
                table2226.AddRow(new string[] {
                            "Service Pack 1"});
                table2226.AddRow(new string[] {
                            "Service Pack 2"});
                table2226.AddRow(new string[] {
                            "Service Pack 3"});
                table2226.AddRow(new string[] {
                            "Service Pack 3, v.6055"});
                table2226.AddRow(new string[] {
                            "Windows 8.0"});
                table2226.AddRow(new string[] {
                            "Windows 8.1"});
                table2226.AddRow(new string[] {
                            "1507"});
                table2226.AddRow(new string[] {
                            "1607"});
#line 107
 testRunner.And("Line X labels of \'SortOrderCheckForDas15544\' widget is displayed in following ord" +
                        "er:", ((string)(null)), table2226, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS15462"}, SourceLine=120)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS15462"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS15462"});
#line 121
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
#line 122
 testRunner.When("User clicks \'Dashboards\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2227 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateBy",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy"});
                table2227.AddRow(new string[] {
                            "Line",
                            "Project AllDevicesDAS15462",
                            "All Devices",
                            "Hostname",
                            "Count distinct",
                            "Operating System",
                            "Operating System ASC"});
#line 125
 testRunner.And("User adds new Widget", ((string)(null)), table2227, "And ");
#line hidden
#line 128
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("\'Project AllDevicesDAS15462\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2228 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetName",
                            "NumberOfPoint",
                            "Tooltip"});
                table2228.AddRow(new string[] {
                            "Project AllDevicesDAS15462",
                            "2",
                            "OS X 10.5 1"});
#line 132
 testRunner.Then("Tooltip is displayed for the point of Line widget", ((string)(null)), table2228, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadines" +
            "sOrComplianceFields", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS17825",
                "Cleanup"}, SourceLine=136)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadinessOrComplianceFields()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS17825",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadines" +
                    "sOrComplianceFields", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS17825",
                        "Cleanup"});
#line 137
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
#line 138
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2229 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2229.AddRow(new string[] {
                            "Windows7Mi: Application Readiness"});
                table2229.AddRow(new string[] {
                            "Application Compliance"});
#line 140
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2229, "And ");
#line hidden
#line 144
 testRunner.And("User create dynamic list with \"ListForDAS17825\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.Then("\"ListForDAS17825\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 146
 testRunner.When("Dashboard with \'DAS17825_Dashboard\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 148
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2230 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "SplitBy",
                            "AggregateFunction",
                            "OrderBy"});
                table2230.AddRow(new string[] {
                            "Line",
                            "WidgetForDAS17825",
                            "ListForDAS17825",
                            "Windows7Mi: Application Readiness",
                            "Count",
                            "Count ASC"});
#line 149
 testRunner.And("User adds new Widget", ((string)(null)), table2230, "And ");
#line hidden
#line 152
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 153
 testRunner.And("Color Scheme dropdown displayed with \'Readiness\' placeholder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.Then("\'Colour Scheme\' dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 155
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 156
 testRunner.Then("\'WidgetForDAS17825\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 157
 testRunner.And("Line chart displayed in \'WidgetForDAS17825\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 158
 testRunner.When("User clicks \'Edit\' menu option for \'WidgetForDAS17825\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 159
 testRunner.When("User selects \'Application Compliance\' in the \'SplitBy\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 160
 testRunner.When("User selects \'Application Compliance ASC\' in the \'OrderBy\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 161
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 162
 testRunner.And("Color Scheme dropdown displayed with \'Compliance\' placeholder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 163
 testRunner.Then("\'Colour Scheme\' dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 164
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 165
 testRunner.Then("\'WidgetForDAS17825\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 166
 testRunner.And("Line chart displayed in \'WidgetForDAS17825\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
