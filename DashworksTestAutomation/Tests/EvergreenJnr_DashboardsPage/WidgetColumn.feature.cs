// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_DashboardsPage
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("WidgetColumn")]
    public partial class WidgetColumnFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WidgetColumn.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WidgetColumn", "\tRuns tests for Column Widgets creation or editing", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
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
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS16278")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidgetInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidgetInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS16278",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Windows7Mi: Status"});
            table1.AddRow(new string[] {
                        "HDD Total Size (GB)"});
#line 12
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "And ");
#line 16
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table2.AddRow(new string[] {
                        "TRUE"});
#line 18
 testRunner.When("User Add And \"Windows7Mi: In Scope\" filter where type is \"Equals\" with added colu" +
                    "mn and following checkboxes:", ((string)(null)), table2, "When ");
#line 21
 testRunner.And("User create dynamic list with \"ListForDAS16278\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("\"ListForDAS16278\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("Dashboard with \'DAS16278_Dashboard\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "MaxValues",
                        "ShowLegend"});
            table3.AddRow(new string[] {
                        "Column",
                        "DAS16278_Widget",
                        "ListForDAS16278",
                        "Windows7Mi: Status",
                        "HDD Total Size (GB)",
                        "Sum",
                        "Windows7Mi: Status ASC",
                        "10",
                        "true"});
#line 26
 testRunner.And("User adds new Widget", ((string)(null)), table3, "And ");
#line 29
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("Card \'DAS16278_Widget\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Not Onboarded"});
            table4.AddRow(new string[] {
                        "Onboarded"});
            table4.AddRow(new string[] {
                        "Forecast"});
            table4.AddRow(new string[] {
                        "Targeted"});
            table4.AddRow(new string[] {
                        "Scheduled"});
            table4.AddRow(new string[] {
                        "Migrated"});
            table4.AddRow(new string[] {
                        "Complete"});
            table4.AddRow(new string[] {
                        "Offboarded"});
#line 32
 testRunner.Then("Line X labels of \'DAS16278_Widget\' column widget is displayed in following order:" +
                    "", ((string)(null)), table4, "Then ");
#line 42
 testRunner.When("User clicks Ellipsis menu for \'DAS16278_Widget\' Widget on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.And("User clicks \'Edit\' item from Ellipsis menu on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.When("User selects \'Windows7Mi: Status DESC\' in the \'Order By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("Card \'DAS16278_Widget\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        "Offboarded"});
            table5.AddRow(new string[] {
                        "Complete"});
            table5.AddRow(new string[] {
                        "Migrated"});
            table5.AddRow(new string[] {
                        "Scheduled"});
            table5.AddRow(new string[] {
                        "Targeted"});
            table5.AddRow(new string[] {
                        "Forecast"});
            table5.AddRow(new string[] {
                        "Onboarded"});
            table5.AddRow(new string[] {
                        "Not Onboarded"});
#line 47
 testRunner.Then("Line X labels of \'DAS16278_Widget\' column widget is displayed in following order:" +
                    "", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("DAS15780")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrderingInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrderingInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS15780",
                        "Cleanup"});
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 60
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table6.AddRow(new string[] {
                        "Babel(Engl: Readiness"});
#line 62
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table6, "And ");
#line 65
 testRunner.And("User move \'Babel(Engl: Readiness\' column to \'Hostname\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("User move \'Hostname\' column to \'Device Type\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("User create dynamic list with \"ListForDas15780\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("\"ListForDas15780\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("Dashboard with \'1803 ProjectDAS15780\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "AggregateFunction",
                        "SplitBy",
                        "OrderBy",
                        "Drilldown"});
            table7.AddRow(new string[] {
                        "Column",
                        "SortOrderCheckForDas15780",
                        "ListForDas15780",
                        "Count",
                        "Babel(Engl: Readiness",
                        "Babel(Engl: Readiness ASC",
                        "Yes"});
#line 72
 testRunner.And("User adds new Widget", ((string)(null)), table7, "And ");
#line 75
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("Card \'SortOrderCheckForDas15780\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Empty"});
            table8.AddRow(new string[] {
                        "Out Of Scope"});
            table8.AddRow(new string[] {
                        "Blue"});
            table8.AddRow(new string[] {
                        "Red"});
            table8.AddRow(new string[] {
                        "Amber"});
            table8.AddRow(new string[] {
                        "Green"});
            table8.AddRow(new string[] {
                        "Grey"});
#line 78
 testRunner.And("Line X labels of \'SortOrderCheckForDas15780\' column widget is displayed in follow" +
                    "ing order:", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("DAS12983")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAddedInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAddedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS12983",
                        "Cleanup"});
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 90
 testRunner.When("Dashboard with \'Dashboard12983\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User selects \'Column\' in the \'Widget Type\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("User enters \'ColumnWidget\' as Widget Title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("User selects \'All Devices\' as Widget List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("User selects \'Operating System\' as Widget Split By", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When("User selects \'Count distinct\' in the \'Aggregate Function\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User selects \'Hostname\' in the \'Aggregate By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User selects \'Operating System ASC\' in the \'Order By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.And("User enters \'2\' as Widget Max Values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("User selects the Colour Scheme by index \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("Card \'ColumnWidget\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table9.AddRow(new string[] {
                        "Other"});
            table9.AddRow(new string[] {
                        "OS X 10.5"});
#line 105
 testRunner.And("Line X labels of \'ColumnWidget\' column widget is displayed in following order:", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("DAS12983")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEditedInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEditedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS12983",
                        "Cleanup"});
#line 111
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 112
 testRunner.When("Dashboard with \'Dashboard12983\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("User selects \'Column\' in the \'Widget Type\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("User enters \'ColumnWidget#1\' as Widget Title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("User selects \'All Devices\' as Widget List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("User selects \'Operating System\' as Widget Split By", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When("User selects \'Count distinct\' in the \'Aggregate Function\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.When("User selects \'Hostname\' in the \'Aggregate By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.When("User selects \'Operating System ASC\' in the \'Order By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.And("User enters \'2\' as Widget Max Values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("User selects the Colour Scheme by index \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.Then("Card \'ColumnWidget#1\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.When("User clicks Ellipsis menu for \'ColumnWidget#1\' Widget on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
 testRunner.And("User clicks \'Edit\' item from Ellipsis menu on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("User selects \'Pie\' in the \'Widget Type\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("User enters \'ColumnWidget#2\' as Widget Title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("User selects \'All Devices\' as Widget List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("User selects \'Operating System\' as Widget Split By", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("User selects \'Count distinct\' in the \'Aggregate Function\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.When("User selects \'Hostname\' in the \'Aggregate By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.When("User selects \'Operating System ASC\' in the \'Order By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.And("User enters \'3\' as Widget Max Values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("User selects the Colour Scheme by index \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.Then("Card \'ColumnWidget#2\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

