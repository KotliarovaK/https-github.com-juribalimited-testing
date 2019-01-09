﻿// ------------------------------------------------------------------------------
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
    [NUnit.Framework.DescriptionAttribute("DashboardsPage")]
    public partial class DashboardsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DashboardsPage", "\tRuns Dashboards Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDe" +
            "vicesPageWithProperItems")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("DAS13114")]
        [NUnit.Framework.CategoryAttribute("DAS13721")]
        [NUnit.Framework.CategoryAttribute("archived")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDevicesPageWithProperItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDe" +
                    "vicesPageWithProperItems", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "DAS13114",
                        "DAS13721",
                        "archived"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Unknown\" section from \"Windows 10 Branch\" circle chart on Dashboards" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"16\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS14358")]
        public virtual void EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "Widgets",
                        "DAS14358"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Ellipsis menu for \"Top 10 App Vendors\" Widget on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table1.AddRow(new string[] {
                        "Edit"});
            table1.AddRow(new string[] {
                        "Duplicate"});
            table1.AddRow(new string[] {
                        "Move to start"});
            table1.AddRow(new string[] {
                        "Move to end"});
            table1.AddRow(new string[] {
                        "Move to position"});
            table1.AddRow(new string[] {
                        "Delete"});
            testRunner.Then("User sees following Ellipsis menu items on Dashboards page:", ((string)(null)), table1, "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("Sections")]
        [NUnit.Framework.CategoryAttribute("DAS14358")]
        public virtual void EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "Sections",
                        "DAS14358"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Ellipsis menu for Section having \"Operating System\" Widget on Dashboa" +
                    "rds page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table2.AddRow(new string[] {
                        "Hide"});
            table2.AddRow(new string[] {
                        "1 column"});
            table2.AddRow(new string[] {
                        "3 column"});
            table2.AddRow(new string[] {
                        "Duplicate"});
            table2.AddRow(new string[] {
                        "Move to top"});
            table2.AddRow(new string[] {
                        "Move to bottom"});
            table2.AddRow(new string[] {
                        "Move to position"});
            table2.AddRow(new string[] {
                        "Delete"});
            testRunner.Then("User sees following Ellipsis menu items on Dashboards page:", ((string)(null)), table2, "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicated")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS14358")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicated", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "Widgets",
                        "DAS14358"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User remembers number of Sections and Widgets on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Ellipsis menu for \"Device Profile\" Widget on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Duplicate\" item from Ellipsis menu on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees Widget with \"Cloned - Device Profile\" name on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User sees number of Widgets increased by \"1\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User deletes \"Cloned - Device Profile\" Widget on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("Sections")]
        [NUnit.Framework.CategoryAttribute("DAS14358")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "Sections",
                        "DAS14358"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks Edit mode trigger on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User remembers number of Sections and Widgets on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Ellipsis menu for Section having \"Domain Profile\" Widget on Dashboard" +
                    "s page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Duplicate\" item from Ellipsis menu on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees number of Sections increased by \"1\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User sees number of Widgets increased by \"4\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User deletes duplicated Section having \"Domain Profile\" Widget on Dashboards page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggreg" +
            "ateByDateColumn")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_List")]
        [NUnit.Framework.CategoryAttribute("DAS14668")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggreg" +
                    "ateByDateColumn", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "Widgets",
                        "Delete_Newly_Created_List",
                        "DAS14668"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table3.AddRow(new string[] {
                        "ICSP: i-Schedule"});
            testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table3, "And ");
            testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table4.AddRow(new string[] {
                        "00KLL9S8NRF0X6"});
            table4.AddRow(new string[] {
                        "00OMQQXWA1DRI6"});
            table4.AddRow(new string[] {
                        "00SH8162NAS524"});
            testRunner.And("User select \"Hostname\" rows in the grid", ((string)(null)), table4, "And ");
            testRunner.And("User selects \"Create static list\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User create static list with \"TestList_DAS14668\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Dashboards\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks the \"CREATE DASHBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User creates new Dashboard with \"Dashboard for DAS14668\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks the \"ADD WIDGET\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table5.AddRow(new string[] {
                        "Pie",
                        "Test_Widget_DAS14668_1",
                        "TestList_DAS14668",
                        "ICSP: i-Schedule",
                        "ICSP: i-Schedule",
                        "Count",
                        "ICSP: i-Schedule ASC",
                        "",
                        "5",
                        ""});
            testRunner.And("User creates new Widget", ((string)(null)), table5, "And ");
            testRunner.Then("User sees widget with the next name \"Test_Widget_DAS14668_1\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the \"ADD WIDGET\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table6.AddRow(new string[] {
                        "Pie",
                        "Test_Widget_DAS14668_2",
                        "TestList_DAS14668",
                        "ICSP: i-Schedule",
                        "ICSP: i-Schedule",
                        "Count Distinct",
                        "ICSP: i-Schedule DESC",
                        "",
                        "20",
                        ""});
            testRunner.And("User creates new Widget", ((string)(null)), table6, "And ");
            testRunner.Then("User sees widget with the next name \"Test_Widget_DAS14668_2\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Settings button for \"Dashboard for DAS14668\" dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Delete button for custom list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Delete button on the warning message in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        [NUnit.Framework.CategoryAttribute("DAS14586")]
        [NUnit.Framework.TestCaseAttribute("Line", "All Devices Widget For DAS_14586", "All Devices", "Hostname", "Device Type", "Count", "Hostname DESC", "Cloned - All Devices Widget For DAS_14586", "false", null)]
        [NUnit.Framework.TestCaseAttribute("Pie", "All Users Widget For DAS_14586", "All Users", "Username", "Display Name", "Count Distinct", "Username ASC", "Cloned - All Users Widget For DAS_14586", "false", null)]
        [NUnit.Framework.TestCaseAttribute("Bar", "All Applications Widget For DAS_14586", "All Applications", "Application", "Vendor", "Count", "Vendor DESC", "Cloned - All Applications Widget For DAS_14586", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Column", "All Mailboxes Widget For DAS_14586", "All Mailboxes", "Email Address", "Mail Server", "Count Distinct", "Mail Server ASC", "Cloned - All Mailboxes Widget For DAS_14586", "true", null)]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists(string type, string title, string list, string splitBy, string aggregateBy, string aggregateFunctio, string orderBy, string titleCloned, string showLegend, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Dashboards",
                    "Widgets",
                    "DAS14586"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists" +
                    "", null, @__tags);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks the \"CREATE DASHBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User creates new Dashboard with \"Dashboard for DAS14586\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks the \"ADD WIDGET\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table7.AddRow(new string[] {
                        string.Format("{0}", type),
                        string.Format("{0}", title),
                        string.Format("{0}", list),
                        string.Format("{0}", splitBy),
                        string.Format("{0}", aggregateBy),
                        string.Format("{0}", aggregateFunctio),
                        string.Format("{0}", orderBy),
                        "",
                        "10",
                        string.Format("{0}", showLegend)});
            testRunner.And("User creates new Widget", ((string)(null)), table7, "And ");
            testRunner.And("User remembers number of Sections and Widgets on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And(string.Format("User clicks Ellipsis menu for \"{0}\" Widget on Dashboards page", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"Duplicate\" item from Ellipsis menu on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees number of Sections increased by \"0\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User sees number of Widgets increased by \"1\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And(string.Format("User sees Widget with \"{0}\" name on Dashboards page", titleCloned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks Settings button for \"Dashboard for DAS14586\" dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Delete button for custom list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Delete button on the warning message in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavi" +
            "ngInvalidName")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("DAS14587")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavi" +
                    "ngInvalidName", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "DAS14587",
                        "Widgets"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks the \"CREATE DASHBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User creates new Dashboard with \"Dashboard for DAS14587\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"New dashboard created\" message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the \"ADD WIDGET\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table8.AddRow(new string[] {
                        "Pie",
                        "",
                        "All Devices",
                        "Device Type",
                        "Hostname",
                        "Count",
                        "Device Type ASC",
                        "",
                        "10",
                        ""});
            testRunner.And("User creates new Widget", ((string)(null)), table8, "And ");
            testRunner.Then("Error message with \"Widget Title should not be empty\" text is displayed on Widget" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table9.AddRow(new string[] {
                        "",
                        "Dashboard for DAS14587",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            testRunner.When("User creates new Widget", ((string)(null)), table9, "When ");
            testRunner.Then("User sees widget with the next name \"Dashboard for DAS14587\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Settings button for \"Dashboard for DAS14587\" dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Delete button for custom list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Delete button on the warning message in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("DAS14685")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        public virtual void EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget" +
                    "", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "DAS14685",
                        "Widgets"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks the \"CREATE DASHBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User creates new Dashboard with \"Dashboard for DAS14685\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"New dashboard created\" message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the \"ADD WIDGET\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table10.AddRow(new string[] {
                        "Table",
                        "WidgetForDAS14685",
                        "All Applications",
                        "Application",
                        "Application",
                        "Count",
                        "Application ASC",
                        "",
                        "10",
                        ""});
            testRunner.And("User creates new Widget", ((string)(null)), table10, "And ");
            testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User sees widget with the next name \"WidgetForDAS14685\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Settings button for \"Dashboard for DAS14685\" dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Delete button for custom list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Delete button on the warning message in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Dashboards")]
        [NUnit.Framework.CategoryAttribute("DAS14578")]
        [NUnit.Framework.CategoryAttribute("DAS14584")]
        [NUnit.Framework.CategoryAttribute("Widgets")]
        public virtual void EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars", null, new string[] {
                        "Evergreen",
                        "Dashboards",
                        "DAS14578",
                        "DAS14584",
                        "Widgets"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("User clicks the \"CREATE DASHBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User creates new Dashboard with \"Dashboard for DAS14578\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"New dashboard created\" message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the \"ADD WIDGET\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "WidgetType",
                        "Title",
                        "List",
                        "SplitBy",
                        "AggregateBy",
                        "AggregateFunction",
                        "OrderBy",
                        "TableOrientation",
                        "MaxValues",
                        "ShowLegend"});
            table11.AddRow(new string[] {
                        "Table",
                        "Line with one hundred and seven chars Line with one hundred and seven chars Line " +
                            "with one hundred and seven",
                        "All Applications",
                        "Application",
                        "Application",
                        "Count",
                        "Application ASC",
                        "Horizontal",
                        "10",
                        ""});
            testRunner.And("User creates new Widget", ((string)(null)), table11, "And ");
            testRunner.Then("User sees widget with the next name \"Line with one hundred and seven chars Line w" +
                    "ith one hundred and seven chars Line with one hundred an\" on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Widget name \"Line with one hundred and seven chars Line with one hundred and seve" +
                    "n chars Line with one hundred an\" has word break style on Dashboards page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks Settings button for \"Dashboard for DAS14578\" dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Delete button for custom list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Delete button on the warning message in the lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
