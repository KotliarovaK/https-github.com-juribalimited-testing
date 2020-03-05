// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_FiltersFeature.FilterFunctionality
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart08")]
    public partial class FiltersFunctionalityPart08Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FiltersFunctionalityPart08.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart08", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplica" +
            "tionListWorksCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12058")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplicationListWorksCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS12058",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplica" +
                    "tionListWorksCorrectly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12058",
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
                TechTalk.SpecFlow.Table table1966 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1966.AddRow(new string[] {
                            "Windows7Mi: Application Rationalisation"});
#line 10
 testRunner.When("User add following columns using URL to the \"Applications\" page:", ((string)(null)), table1966, "When ");
#line hidden
#line 13
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("User add \"Windows7Mi: Group (Target State)\" filter where type is \"Equal\" without " +
                        "added column and \"Parkfield Office\" Lookup option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.And("User click Edit button for \"Windows7Mi: Group (Target State)\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("User enters \"Administration\" text in Search field at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("User clicks checkbox at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.Then("\"29\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.When("User create dynamic list with \"Project Group (Target State)\" name on \"Application" +
                        "s\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1967 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1967.AddRow(new string[] {
                            "KEEP"});
#line 24
 testRunner.When("User Add And \"Windows7Mi: Application Rationalisation\" filter where type is \"Equa" +
                        "l\" without added column and following checkboxes:", ((string)(null)), table1967, "When ");
#line hidden
#line 27
 testRunner.Then("\"9\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("User have removed \"Windows7Mi: Application Rationalisation\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1968 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1968.AddRow(new string[] {
                            "UNCATEGORISED"});
#line 29
 testRunner.And("User Add And \"Windows7Mi: Application Rationalisation\" filter where type is \"Equa" +
                        "l\" without added column and following checkboxes:", ((string)(null)), table1968, "And ");
#line hidden
#line 32
 testRunner.Then("\"20\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When("User have removed \"Windows7Mi: Application Rationalisation\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1969 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1969.AddRow(new string[] {
                            "RETIRE"});
#line 34
 testRunner.And("User Add And \"Windows7Mi: Application Rationalisation\" filter where type is \"Equa" +
                        "l\" without added column and following checkboxes:", ((string)(null)), table1969, "And ");
#line hidden
#line 37
 testRunner.Then("message \'No applications found\' is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.When("User have removed \"Windows7Mi: Application Rationalisation\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1970 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1970.AddRow(new string[] {
                            "FORWARD PATH"});
#line 39
 testRunner.And("User Add And \"Windows7Mi: Application Rationalisation\" filter where type is \"Equa" +
                        "l\" without added column and following checkboxes:", ((string)(null)), table1970, "And ");
#line hidden
#line 42
 testRunner.Then("message \'No applications found\' is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12200")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS12200"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12200"});
#line 45
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
#line 46
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1971 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues",
                            "Association"});
                table1971.AddRow(new string[] {
                            "FR\\APB5713645",
                            "Has used app"});
#line 50
 testRunner.When("User add Advanced \"User\" filter where type is \"Equals\" with following Lookup Valu" +
                        "e and Association:", ((string)(null)), table1971, "When ");
#line hidden
#line 53
 testRunner.Then("\"1\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("User click Edit button for \"User\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("User is deselect \"Has used app\" Association for Application filter with Lookup va" +
                        "lue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.When("User select \"Has not used app\" Association for Application filter with Lookup val" +
                        "ue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.And("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.Then("\"2,222\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUse" +
            "SelectedFilterOnDevicesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Category", "None", "17,248", null)]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Migration \\ Values but no RAG", "Three", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Portal Self Service \\ SS Application List Completed", "Not Applicable", "5,159", null)]
        [NUnit.Framework.TestCaseAttribute("MigrationP: Category", "None", "17,274", null)]
        [NUnit.Framework.TestCaseAttribute("Babel(Engl: Path", "Machines", "62", null)]
        [NUnit.Framework.TestCaseAttribute("ComputerSc: Path", "Request Type A", "132", null)]
        [NUnit.Framework.TestCaseAttribute("MigrationP: Path", "[Default (Computer)]", "41", null)]
        [NUnit.Framework.TestCaseAttribute("UserSchedu: Path", "Request Type A", "60", null)]
        public virtual void EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnDevicesPage(string filterName, string selectedCheckboxes, string rows, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS12351"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUse" +
                    "SelectedFilterOnDevicesPage", null, @__tags);
#line 61
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
#line 62
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1972 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1972.AddRow(new string[] {
                            string.Format("{0}", selectedCheckboxes)});
#line 66
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following chec" +
                            "kboxes:", filterName), ((string)(null)), table1972, "When ");
#line hidden
#line 69
 testRunner.Then(string.Format("\"{0}\" filter is added to the list", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.Then("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rows), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSe" +
            "lectedFilterOnUsersPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Category", "Terminated", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Stage for User Tasks \\ Read Only on Bulk Update Page", "Not Applicable", "4,642", null)]
        [NUnit.Framework.TestCaseAttribute("Barry\'sUse: Category", "None", "41,339", null)]
        [NUnit.Framework.TestCaseAttribute("Havoc(BigD: Path", "[Default (User)]", "7,578", null)]
        [NUnit.Framework.TestCaseAttribute("UserSchedu: Group Stage \\ Group User Default Request Type", "Not Applicable", "679", null)]
        [NUnit.Framework.TestCaseAttribute("ComputerSc: Group Stage \\ Group User Default Request Type", "Not Applicable", "1,809", null)]
        public virtual void EvergreenJnr_UsersList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnUsersPage(string filterName, string selectedCheckboxes, string rows, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS12351"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSe" +
                    "lectedFilterOnUsersPage", null, @__tags);
#line 85
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
#line 86
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1973 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1973.AddRow(new string[] {
                            string.Format("{0}", selectedCheckboxes)});
#line 90
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following chec" +
                            "kboxes:", filterName), ((string)(null)), table1973, "When ");
#line hidden
#line 93
 testRunner.Then(string.Format("\"{0}\" filter is added to the list", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.Then("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rows), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
