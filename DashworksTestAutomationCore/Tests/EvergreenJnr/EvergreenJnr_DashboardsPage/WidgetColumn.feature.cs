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
    [TechTalk.SpecRun.FeatureAttribute("WidgetColumn", Description="\tRuns tests for Column Widgets creation or editing", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_DashboardsPage\\WidgetColumn.feature", SourceLine=0)]
    public partial class WidgetColumnFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "WidgetColumn.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WidgetColumn", "\tRuns tests for Column Widgets creation or editing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "Widgets",
                "DAS16278",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "Widgets",
                    "DAS16278",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS16278",
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
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2201 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2201.AddRow(new string[] {
                            "Windows7Mi: Status"});
                table2201.AddRow(new string[] {
                            "HDD Total Size (GB)"});
#line 12
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2201, "When ");
#line hidden
#line 16
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2202 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table2202.AddRow(new string[] {
                            "TRUE"});
#line 18
 testRunner.When("User add \"Windows7Mi: In Scope\" filter where type is \"Equals\" with added column a" +
                        "nd following checkboxes:", ((string)(null)), table2202, "When ");
#line hidden
#line 21
 testRunner.When("User waits for \'2\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When("User create dynamic list with \"AListForDAS16278\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("\"AListForDAS16278\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.When("Dashboard with \'DAS16278_Dashboard\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2203 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "SplitBy",
                            "AggregateBy",
                            "AggregateFunction",
                            "OrderBy",
                            "MaxValues",
                            "ShowLegend"});
                table2203.AddRow(new string[] {
                            "Column",
                            "DAS16278_Widget",
                            "AListForDAS16278",
                            "Windows7Mi: Status",
                            "HDD Total Size (GB)",
                            "Sum",
                            "Windows7Mi: Status ASC",
                            "10",
                            "true"});
#line 27
 testRunner.When("User adds new Widget", ((string)(null)), table2203, "When ");
#line hidden
#line 30
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("\'DAS16278_Widget\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2204 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2204.AddRow(new string[] {
                            "Onboarded"});
                table2204.AddRow(new string[] {
                            "Targeted"});
                table2204.AddRow(new string[] {
                            "Scheduled"});
                table2204.AddRow(new string[] {
                            "Migrated"});
                table2204.AddRow(new string[] {
                            "Complete"});
#line 33
 testRunner.Then("Line X labels of \'DAS16278_Widget\' column widget is displayed in following order:" +
                        "", ((string)(null)), table2204, "Then ");
#line hidden
#line 40
 testRunner.When("User clicks \'Edit\' menu option for \'DAS16278_Widget\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.When("User selects \'Windows7Mi: Status DESC\' in the \'OrderBy\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("\'DAS16278_Widget\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2205 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2205.AddRow(new string[] {
                            "Complete"});
                table2205.AddRow(new string[] {
                            "Migrated"});
                table2205.AddRow(new string[] {
                            "Scheduled"});
                table2205.AddRow(new string[] {
                            "Targeted"});
                table2205.AddRow(new string[] {
                            "Onboarded"});
#line 44
 testRunner.Then("Line X labels of \'DAS16278_Widget\' column widget is displayed in following order:" +
                        "", ((string)(null)), table2205, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "DAS15780",
                "Cleanup"}, SourceLine=52)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "DAS15780",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS15780",
                        "Cleanup"});
#line 53
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
#line 54
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2206 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2206.AddRow(new string[] {
                            "DeviceSche: Readiness"});
#line 56
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2206, "When ");
#line hidden
#line 59
 testRunner.When("User move \'DeviceSche: Readiness\' column to \'Hostname\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.When("User move \'Hostname\' column to \'Device Type\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.When("User create dynamic list with \"ListForDas15780\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("\"ListForDas15780\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("Dashboard with \'2004 ProjectDAS15780\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2207 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy",
                            "Drilldown"});
                table2207.AddRow(new string[] {
                            "Column",
                            "SortOrderCheckForDas15780",
                            "ListForDas15780",
                            "Count",
                            "DeviceSche: Readiness",
                            "DeviceSche: Readiness ASC",
                            "Yes"});
#line 66
 testRunner.When("User adds new Widget", ((string)(null)), table2207, "When ");
#line hidden
#line 69
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("\'SortOrderCheckForDas15780\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2208 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2208.AddRow(new string[] {
                            "Empty"});
                table2208.AddRow(new string[] {
                            "Out Of Scope"});
                table2208.AddRow(new string[] {
                            "Blue"});
                table2208.AddRow(new string[] {
                            "Light Blue"});
                table2208.AddRow(new string[] {
                            "Red"});
                table2208.AddRow(new string[] {
                            "Brown"});
                table2208.AddRow(new string[] {
                            "Amber"});
                table2208.AddRow(new string[] {
                            "Really Extremely Orange"});
                table2208.AddRow(new string[] {
                            "Purple"});
                table2208.AddRow(new string[] {
                            "Grey"});
#line 72
 testRunner.Then("Line X labels of \'SortOrderCheckForDas15780\' column widget is displayed in follow" +
                        "ing order:", ((string)(null)), table2208, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "DAS12983",
                "Cleanup"}, SourceLine=85)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "DAS12983",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS12983",
                        "Cleanup"});
#line 86
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
#line 87
 testRunner.When("Dashboard with \'Dashboard12983\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2209 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy",
                            "CategoriseBy",
                            "DisplayType",
                            "OrderBy",
                            "AggregateBy",
                            "MaxValues"});
                table2209.AddRow(new string[] {
                            "Column",
                            "ColumnWidget",
                            "All Devices",
                            "Count distinct",
                            "Operating System",
                            "Device Type",
                            "Stacked",
                            "Operating System ASC",
                            "Hostname",
                            "2"});
#line 90
 testRunner.When("User adds new Widget", ((string)(null)), table2209, "When ");
#line hidden
#line 93
 testRunner.When("User selects the Colour Scheme by color code \'rgb(143, 20, 64)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.Then("\'ColumnWidget\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2210 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2210.AddRow(new string[] {
                            "Other"});
                table2210.AddRow(new string[] {
                            "OS X 10.5"});
#line 97
 testRunner.Then("Line X labels of \'ColumnWidget\' column widget is displayed in following order:", ((string)(null)), table2210, "Then ");
#line hidden
#line 101
 testRunner.Then("User sees color code \'rgb(143, 20, 64)\' on the \'ColumnWidget\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited", new string[] {
                "Evergreen",
                "EvergreenJnr_DashboardsPage",
                "DAS12983",
                "Cleanup"}, SourceLine=103)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "EvergreenJnr_DashboardsPage",
                    "DAS12983",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS12983",
                        "Cleanup"});
#line 104
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
#line 105
 testRunner.When("Dashboard with \'Dashboard12983\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When("User checks \'Edit mode\' slide toggle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2211 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy",
                            "AggregateBy",
                            "MaxValues"});
                table2211.AddRow(new string[] {
                            "Column",
                            "ColumnWidget#1",
                            "All Devices",
                            "Count distinct",
                            "Operating System",
                            "Operating System ASC",
                            "Hostname",
                            "2"});
#line 108
 testRunner.When("User adds new Widget", ((string)(null)), table2211, "When ");
#line hidden
#line 111
 testRunner.When("User selects the Colour Scheme by index \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 113
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.Then("\'ColumnWidget#1\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.When("User clicks \'Edit\' menu option for \'ColumnWidget#1\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2212 = new TechTalk.SpecFlow.Table(new string[] {
                            "WidgetType",
                            "Title",
                            "List",
                            "AggregateFunction",
                            "SplitBy",
                            "OrderBy",
                            "AggregateBy",
                            "MaxValues"});
                table2212.AddRow(new string[] {
                            "Pie",
                            "ColumnWidget#2",
                            "All Devices",
                            "Count distinct",
                            "Operating System",
                            "Operating System ASC",
                            "Hostname",
                            "3"});
#line 116
 testRunner.When("User adds new Widget", ((string)(null)), table2212, "When ");
#line hidden
#line 119
 testRunner.When("User selects the Colour Scheme by index \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 120
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 121
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 122
 testRunner.Then("\'ColumnWidget#2\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
