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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_FiltersFeature.FilterFunctionality
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart28")]
    public partial class FiltersFunctionalityPart28Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FiltersFunctionalityPart28.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart28", "\tRuns New filters check related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("NewFilterCheck")]
        [NUnit.Framework.CategoryAttribute("DAS10512")]
        [NUnit.Framework.CategoryAttribute("DAS11507")]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Core Application", "Equals, Does not equal, Not empty", "TRUE", "Windows7Mi: Core Application is True", "11", null)]
        [NUnit.Framework.TestCaseAttribute("Babel(Engl: Core Application", "Equals, Does not equal, Not empty", "FALSE", "Babel(Engl: Core Application is False", "302", null)]
        [NUnit.Framework.TestCaseAttribute("Barry\'sUse: Core Application", "Equals, Does not equal, Not empty", "Empty", "Barry\'sUse: Core Application is Empty", "1,145", null)]
        [NUnit.Framework.TestCaseAttribute("ComputerSc: Core Application", "Equals, Does not equal, Not empty", "FALSE", "ComputerSc: Core Application is False", "1,043", null)]
        [NUnit.Framework.TestCaseAttribute("Havoc(BigD: Core Application", "Equals, Does not equal, Not empty", "Empty", "Havoc(BigD: Core Application is Empty", "1,155", null)]
        [NUnit.Framework.TestCaseAttribute("MigrationP: Core Application", "Equals, Does not equal, Not empty", "FALSE", "MigrationP: Core Application is False", "220", null)]
        [NUnit.Framework.TestCaseAttribute("UserSchedu: Core Application", "Equals, Does not equal, Not empty", "Empty", "UserSchedu: Core Application is Empty", "1,242", null)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList(string columnName, string operators, string filterOption, string text, string rowsCount, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheListInternal(columnName,operators,filterOption,text,rowsCount,exampleTags);
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

        private void EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheListInternal(string columnName, string operators, string filterOption, string text, string rowsCount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Applications",
                    "Evergreen_FiltersFeature",
                    "NewFilterCheck",
                    "DAS10512",
                    "DAS11507"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        string.Format("{0}", columnName)});
#line 14
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table1, "When ");
#line 17
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When(string.Format("user select \"{0}\" filter", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then(string.Format("\"{0}\" option is available for this filter", operators), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table2.AddRow(new string[] {
                        string.Format("{0}", filterOption)});
#line 21
 testRunner.When("User have created \"Equals\" filter with column and following options:", ((string)(null)), table2, "When ");
#line 24
 testRunner.Then(string.Format("\"{0}\" is displayed in added filter info", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rowsCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("NewFilterCheck")]
        [NUnit.Framework.CategoryAttribute("DAS10512")]
        [NUnit.Framework.CategoryAttribute("DAS11509")]
        [NUnit.Framework.CategoryAttribute("DAS11507")]
        [NUnit.Framework.CategoryAttribute("DAS11509")]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Hide from End Users", "Equals, Does not equal, Not empty", "FALSE", "Windows7Mi: Hide from End Users is False", "1,067", null)]
        [NUnit.Framework.TestCaseAttribute("Babel(Engl: Hide from End Users", "Equals, Does not equal, Not empty", "Empty", "Babel(Engl: Hide from End Users is Empty", "1,921", null)]
        [NUnit.Framework.TestCaseAttribute("Barry\'sUse: Hide from End Users", "Equals, Does not equal, Not empty", "FALSE", "Barry\'sUse: Hide from End Users is False", "1,078", null)]
        [NUnit.Framework.TestCaseAttribute("ComputerSc: Hide from End Users", "Equals, Does not equal, Not empty", "FALSE", "ComputerSc: Hide from End Users is False", "1,043", null)]
        [NUnit.Framework.TestCaseAttribute("Havoc(BigD: Hide from End Users", "Equals, Does not equal, Not empty", "Empty", "Havoc(BigD: Hide from End Users is Empty", "1,155", null)]
        [NUnit.Framework.TestCaseAttribute("MigrationP: Hide from End Users", "Equals, Does not equal, Not empty", "FALSE", "MigrationP: Hide from End Users is False", "220", null)]
        [NUnit.Framework.TestCaseAttribute("UserSchedu: Hide from End Users", "Equals, Does not equal, Not empty", "Empty", "UserSchedu: Hide from End Users is Empty", "1,242", null)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList(string columnName, string operators, string filterOption, string text, string rowsCount, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheListInternal(columnName,operators,filterOption,text,rowsCount,exampleTags);
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

        private void EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheListInternal(string columnName, string operators, string filterOption, string text, string rowsCount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Applications",
                    "Evergreen_FiltersFeature",
                    "NewFilterCheck",
                    "DAS10512",
                    "DAS11509",
                    "DAS11507",
                    "DAS11509"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList", null, @__tags);
#line 40
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 41
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table3.AddRow(new string[] {
                        string.Format("{0}", columnName)});
#line 45
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table3, "When ");
#line 48
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.When(string.Format("user select \"{0}\" filter", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then(string.Format("\"{0}\" option is available for this filter", operators), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table4.AddRow(new string[] {
                        string.Format("{0}", filterOption)});
#line 52
 testRunner.When("User have created \"Equals\" filter with column and following options:", ((string)(null)), table4, "When ");
#line 55
 testRunner.Then(string.Format("\"{0}\" is displayed in added filter info", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rowsCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrec" +
            "tlyOnDevicesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("NewFilterCheck")]
        [NUnit.Framework.CategoryAttribute("DAS12232")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        [NUnit.Framework.CategoryAttribute("DAS12639")]
        [NUnit.Framework.CategoryAttribute("DAS14288")]
        public virtual void EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnDevicesPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnDevicesPageInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnDevicesPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrec" +
                    "tlyOnDevicesPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_FiltersFeature",
                        "NewFilterCheck",
                        "DAS12232",
                        "DAS12351",
                        "DAS12639",
                        "DAS14288"});
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 72
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table5.AddRow(new string[] {
                        "One"});
            table5.AddRow(new string[] {
                        "Three"});
#line 76
 testRunner.When("User add \"Windows7Mi: Migration \\ Values but no RAG\" filter where type is \"Equals" +
                    "\" without added column and following checkboxes:", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table6.AddRow(new string[] {
                        "Not Applicable"});
            table6.AddRow(new string[] {
                        "Started"});
            table6.AddRow(new string[] {
                        "Failed"});
            table6.AddRow(new string[] {
                        "Complete"});
#line 80
 testRunner.And("User Add And \"UserSchedu: One \\ Radio Rag Date Comp\" filter where type is \"Equals" +
                    "\" with added column and following checkboxes:", ((string)(null)), table6, "And ");
#line 86
 testRunner.Then("\"233\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.When("User create dynamic list with \"Devices_ProjectTaskFilters_AND\" name on \"Devices\" " +
                    "page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("\"Devices_ProjectTaskFilters_AND\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.When("User navigates to the \"Devices_ProjectTaskFilters_AND\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.Then("\"Windows7Mi: Migration \\ Values but no RAG is One or Three\" is displayed in added" +
                    " filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.And("\"UserSchedu: One \\ Radio Rag Date Comp is Not Applicable, Started, Failed or Comp" +
                    "lete\" is displayed in added filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.When("User click Edit button for \"Windows7Mi: Migration \\ Values but no RAG\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Option",
                        "State"});
            table7.AddRow(new string[] {
                        "One",
                        "false"});
            table7.AddRow(new string[] {
                        "Two",
                        "false"});
            table7.AddRow(new string[] {
                        "Three",
                        "true"});
#line 97
 testRunner.And("User change selected checkboxes:", ((string)(null)), table7, "And ");
#line 102
 testRunner.And("User click Edit button for \"UserSchedu: One \\ Radio Rag Date Comp\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("User select \"Does not equal\" Operator value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Option",
                        "State"});
            table8.AddRow(new string[] {
                        "Not Applicable",
                        "true"});
            table8.AddRow(new string[] {
                        "Not Started",
                        "false"});
            table8.AddRow(new string[] {
                        "Started",
                        "false"});
            table8.AddRow(new string[] {
                        "Failed",
                        "false"});
            table8.AddRow(new string[] {
                        "Complete",
                        "false"});
#line 104
 testRunner.And("User change selected checkboxes:", ((string)(null)), table8, "And ");
#line 111
 testRunner.Then("\"1\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User clicks \'SAVE\' button and select \'UPDATE DYNAMIC LIST\' menu button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
