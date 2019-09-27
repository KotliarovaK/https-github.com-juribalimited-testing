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
    [NUnit.Framework.DescriptionAttribute("WidgetBar")]
    public partial class WidgetBarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WidgetBar.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WidgetBar", "\tRuns tests for Bar Widgets creation or editing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpec" +
            "ificColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS15356")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumns()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumnsInternal();
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

        private void EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumnsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpec" +
                    "ificColumns", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_DashboardsPage",
                        "Widgets",
                        "DAS15356",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Secure Boot Enabled"});
            table1.AddRow(new string[] {
                        "Manufacturer"});
            table1.AddRow(new string[] {
                        "Compliance"});
#line 10
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table1, "When ");
#line 15
 testRunner.And("User clicks on \'Manufacturer\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("data in table is sorted by \'Manufacturer\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User create dynamic list with \"List15356\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.And("User clicks \'Dashboards\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "MaxValues",
                        "ShowLegend"});
            table2.AddRow(new string[] {
                        "Bar",
                        "WidgetForDAS15356",
                        "List15356",
                        "Secure Boot Enabled",
                        "Device Type",
                        "Count distinct",
                        "Secure Boot Enabled ASC",
                        "10",
                        "true"});
#line 21
 testRunner.And("User adds new Widget", ((string)(null)), table2, "And ");
#line 24
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceLis" +
            "tHasNoRows")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_DashboardsPage")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS16167")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Pie", null)]
        [NUnit.Framework.TestCaseAttribute("Bar", null)]
        [NUnit.Framework.TestCaseAttribute("Column", null)]
        [NUnit.Framework.TestCaseAttribute("Line", null)]
        [NUnit.Framework.TestCaseAttribute("Donut", null)]
        [NUnit.Framework.TestCaseAttribute("Half donut", null)]
        [NUnit.Framework.TestCaseAttribute("Table", null)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceListHasNoRows(string widgetType, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceListHasNoRowsInternal(widgetType,exampleTags);
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

        private void EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceListHasNoRowsInternal(string widgetType, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceLis" +
                    "tHasNoRows", null, @__tags);
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 31
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "ZZZZ"});
#line 33
 testRunner.And("User add \"Owner Display Name\" filter where type is \"Equals\" with added column and" +
                    " following value:", ((string)(null)), table3, "And ");
#line 36
 testRunner.And("User clicks Save button on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("User create dynamic list with \"ListForDAS16167\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("\"ListForDAS16167\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.When("Dashboard with \"DAS16167_Dashboard\" name created via API and opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User clicks \'ADD WIDGET\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateFunction",
                        "OrderBy"});
            table4.AddRow(new string[] {
                        string.Format("{0}", widgetType),
                        "WidgetForDAS16167",
                        "ListForDAS16167",
                        "Operating System",
                        "Count",
                        "Operating System ASC"});
#line 42
 testRunner.And("User adds new Widget", ((string)(null)), table4, "And ");
#line 45
 testRunner.Then("Widget Preview is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("\'This list does not contain any rows\' message is displayed in Preview", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("\"WidgetForDAS16167\" Widget is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("\'This list does not contain any rows\' message is displayed in \'WidgetForDAS16167\'" +
                    " widget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

