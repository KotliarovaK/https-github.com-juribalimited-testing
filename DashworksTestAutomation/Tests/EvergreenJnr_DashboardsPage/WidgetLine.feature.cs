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
    [NUnit.Framework.DescriptionAttribute("WidgetLine")]
    public partial class WidgetLineFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WidgetLine.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WidgetLine", "\tRuns tests for Line Widgets creation or editing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByIn" +
            "Dropdown")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS15737")]
        [NUnit.Framework.CategoryAttribute("DAS15662")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdown()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdownInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdownInternal()
        {
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
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "prK: Application Readiness"});
#line 11
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table1, "When ");
#line 14
 testRunner.And("User create dynamic list with \"TestList_DAS15737\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("Dashboard with \'Dashboard for DAS15737\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User selects \'Line\' in the \'Widget Type\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("User enters \'DAS15737\' as Widget Title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("User selects \'TestList_DAS15737\' as Widget List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("User selects \'prK: Application Readiness\' in the \'Split By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User selects \'Count\' in the \'Aggregate Function\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("User selects \'prK: Application Readiness ASC\' in the \'Order By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("User clicks on the Colour Scheme dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("Colour Scheme dropdown is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("\'Data Label\' checkbox is not displayed on the Create Widget page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPag" +
            "e")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS16069")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPageInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPag" +
                    "e", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS16069",
                        "Cleanup"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 31
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("user select \"Device Type\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User clicks in search field in the Filter block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User enters \"Desktop\" text in Search field at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("User clicks checkbox at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "1803: Pre-Migration \\ Scheduled Date"});
#line 40
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2, "And ");
#line 43
 testRunner.And("User create dynamic list with \"1803 ScheduleDAS16069\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("\"1803 ScheduleDAS16069\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.When("Dashboard with \'1803 ProjectDAS16069\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "AggregateBy",
                        "AggregateFunction",
                        "SplitBy",
                        "OrderBy",
                        "Drilldown"});
            table3.AddRow(new string[] {
                        "Line",
                        "Project ScheduleDAS16069",
                        "1803 ScheduleDAS16069",
                        "Hostname",
                        "Count distinct",
                        "1803: Pre-Migration \\ Scheduled Date",
                        "1803: Pre-Migration \\ Scheduled Date ASC",
                        "Yes"});
#line 48
 testRunner.And("User adds new Widget", ((string)(null)), table3, "And ");
#line 51
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("Card \'Project ScheduleDAS16069\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.When("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetName",
                        "NumberOfPoint",
                        "Tooltip"});
            table4.AddRow(new string[] {
                        "Project ScheduleDAS16069",
                        "1",
                        "5 Nov 2018 4"});
#line 55
 testRunner.Then("Tooltip is displayed for the point of Line widget", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetName",
                        "NumberOfPoint"});
            table5.AddRow(new string[] {
                        "Project ScheduleDAS16069",
                        "1"});
#line 58
 testRunner.When("User clicks point of Line widget", ((string)(null)), table5, "When ");
#line 61
 testRunner.Then("Save as a new list option is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.And("\"4\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table6.AddRow(new string[] {
                        "Hostname"});
            table6.AddRow(new string[] {
                        "Device Type"});
            table6.AddRow(new string[] {
                        "Operating System"});
            table6.AddRow(new string[] {
                        "Owner Display Name"});
            table6.AddRow(new string[] {
                        "1803: Pre-Migration \\ Scheduled Date"});
#line 63
 testRunner.And("Column is displayed in following order:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCo" +
            "rrectlyOnDashboard")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS15920")]
        [NUnit.Framework.CategoryAttribute("DAS15662")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboard()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboardInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboardInternal()
        {
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
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 73
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        "Device Application Compliance"});
            table7.AddRow(new string[] {
                        "Compliance"});
#line 74
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table7, "When ");
#line 78
 testRunner.And("User create dynamic list with \"ListForDas15920\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("Dashboard with \'DashboardForDas15920\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "AggregateFunction",
                        "SplitBy",
                        "OrderBy",
                        "Drilldown"});
            table8.AddRow(new string[] {
                        "Line",
                        "LineWidgetForDas15920",
                        "ListForDas15920",
                        "Count",
                        "Device Application Compliance",
                        "Device Application Compliance ASC",
                        "Yes"});
#line 82
 testRunner.And("User adds new Widget", ((string)(null)), table8, "And ");
#line 85
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.Then("\'Data Label\' checkbox is not displayed on the Create Widget page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("Card \'LineWidgetForDas15920\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.And("Line chart displayed in \'LineWidgetForDas15920\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("DAS15544")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrderInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "DAS15544",
                        "Cleanup"});
#line 92
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 93
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table9.AddRow(new string[] {
                        "Service Pack or Build"});
#line 94
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table9, "When ");
#line 97
 testRunner.And("User create dynamic list with \"ListForDas15544\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("Dashboard with \'1803 ProjectDAS15544\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "AggregateFunction",
                        "SplitBy",
                        "OrderBy",
                        "Drilldown"});
            table10.AddRow(new string[] {
                        "Line",
                        "SortOrderCheckForDas15544",
                        "ListForDas15544",
                        "Count",
                        "Service Pack or Build",
                        "Service Pack or Build ASC",
                        "Yes"});
#line 101
 testRunner.And("User adds new Widget", ((string)(null)), table10, "And ");
#line 104
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.Then("Card \'SortOrderCheckForDas15544\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table11.AddRow(new string[] {
                        "Empty"});
            table11.AddRow(new string[] {
                        "No Service Pack"});
            table11.AddRow(new string[] {
                        "Service Pack 1"});
            table11.AddRow(new string[] {
                        "Service Pack 2"});
            table11.AddRow(new string[] {
                        "Service Pack 3"});
            table11.AddRow(new string[] {
                        "Service Pack 3, v.6055"});
            table11.AddRow(new string[] {
                        "Windows 8.0"});
            table11.AddRow(new string[] {
                        "Windows 8.1"});
            table11.AddRow(new string[] {
                        "1507"});
            table11.AddRow(new string[] {
                        "1607"});
#line 107
 testRunner.And("Line X labels of \'SortOrderCheckForDas15544\' widget is displayed in following ord" +
                    "er:", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS15462")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCountInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCountInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS15462"});
#line 121
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 122
 testRunner.When("User clicks \'Dashboards\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "AggregateBy",
                        "AggregateFunction",
                        "SplitBy",
                        "OrderBy"});
            table12.AddRow(new string[] {
                        "Line",
                        "Project AllDevicesDAS15462",
                        "All Devices",
                        "Hostname",
                        "Count distinct",
                        "Operating System",
                        "Operating System ASC"});
#line 125
 testRunner.And("User adds new Widget", ((string)(null)), table12, "And ");
#line 128
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("Card \'Project AllDevicesDAS15462\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.When("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetName",
                        "NumberOfPoint",
                        "Tooltip"});
            table13.AddRow(new string[] {
                        "Project AllDevicesDAS15462",
                        "2",
                        "OS X 10.5 1"});
#line 132
 testRunner.Then("Tooltip is displayed for the point of Line widget", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadines" +
            "sOrComplianceFields")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS17825")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadinessOrComplianceFields()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadinessOrComplianceFieldsInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadinessOrComplianceFieldsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadines" +
                    "sOrComplianceFields", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS17825",
                        "Cleanup"});
#line 137
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 138
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table14.AddRow(new string[] {
                        "Windows7Mi: Application Readiness"});
            table14.AddRow(new string[] {
                        "Application Compliance"});
#line 140
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table14, "And ");
#line 144
 testRunner.And("User create dynamic list with \"ListForDAS17825\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("\"ListForDAS17825\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.When("Dashboard with \'DAS17825_Dashboard\' name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.When("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateFunction",
                        "OrderBy"});
            table15.AddRow(new string[] {
                        "Line",
                        "WidgetForDAS17825",
                        "ListForDAS17825",
                        "Windows7Mi: Application Readiness",
                        "Count",
                        "Count ASC"});
#line 149
 testRunner.And("User adds new Widget", ((string)(null)), table15, "And ");
#line 152
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.And("Color Scheme dropdown displayed with \'Readiness Colour Scheme\' placeholder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And("Color Scheme dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("Card \'WidgetForDAS17825\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
 testRunner.And("Line chart displayed in \'WidgetForDAS17825\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.When("User clicks Ellipsis menu for \'WidgetForDAS17825\' Widget on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.And("User clicks \'Edit\' item from Ellipsis menu on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("User selects \'Application Compliance\' as Widget Split By", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.When("User selects \'Application Compliance ASC\' in the \'Order By\' Widget dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.And("Color Scheme dropdown displayed with \'Compliance Colour Scheme\' placeholder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.And("Color Scheme dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 166
 testRunner.Then("Card \'WidgetForDAS17825\' Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 167
 testRunner.And("Line chart displayed in \'WidgetForDAS17825\' widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

