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
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart02")]
    public partial class FiltersFunctionalityPart02Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FiltersFunctionalityPart02.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart02", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoi" +
            "ngBackViaTheBrowserBackButtonForLookupFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10977")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        [NUnit.Framework.TestCaseAttribute("Applications", "Barry\'sUse: Target App", "Python 2.2a4 (SMS_GEN)", "1", "Application", "Python 2.2a4", "Barry\'sUse: Target App is Python 2.2a4 (SMS_GEN)", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "EmailMigra: Migration \\ BT/QMM Switch Status", "Not Started", "729", "Email Address", "alex.cristea@juriba.com", "EmailMigra: Migration \\ BT/QMM Switch Status is Not Started", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserBackButtonForLookupFilters(string listName, string filterName, string filterValue, string rowsCount, string columnName, string objectName, string text, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "Evergreen_FiltersFeature",
                    "FilterFunctionality",
                    "DAS10977",
                    "DAS12351"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoi" +
                    "ngBackViaTheBrowserBackButtonForLookupFilters", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When(string.Format("user select \"{0}\" filter", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When(string.Format("User have created \"Equals\" Lookup filter with column and \"{0}\" option", filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then(string.Format("\"{0}\" is displayed in added filter info", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rowsCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When(string.Format("User perform search by \"{0}\"", objectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.Then("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rowsCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then(string.Format("\"{0}\" is displayed in added filter info", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePa" +
            "geAndGoingBackViaTheBrowserbackButtonForValuesFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10977")]
        [NUnit.Framework.CategoryAttribute("DAS12954")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserbackButtonForValuesFilters()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "Evergreen_FiltersFeature",
                    "FilterFunctionality",
                    "DAS10977",
                    "DAS12954"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePa" +
                    "geAndGoingBackViaTheBrowserbackButtonForValuesFilters", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "Evergreen_FiltersFeature",
                        "FilterFunctionality",
                        "DAS10977",
                        "DAS12954"});
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1901 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1901.AddRow(new string[] {
                            "Microsoft Office 97, Professional Edition"});
#line 36
 testRunner.When("User add \"Application\" filter where type is \"Equals\" with added column and follow" +
                        "ing value:", ((string)(null)), table1901, "When ");
#line hidden
#line 39
 testRunner.Then("\"Application is Microsoft Office 97, Professional Edition\" is displayed in added " +
                        "filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Then("\"5\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.When("User perform search by \"Microsoft Office 97, Professional Edition\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.Then("select all rows checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When("User click content from \"Application\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.Then("\"5\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("\"Application is Microsoft Office 97, Professional Edition\" is displayed in added " +
                        "filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePa" +
            "geAndGoingBackViaTheBrowseBackButtonForListFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10977")]
        [NUnit.Framework.CategoryAttribute("DAS13376")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowseBackButtonForListFilters()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "Evergreen_FiltersFeature",
                    "FilterFunctionality",
                    "DAS10977",
                    "DAS13376",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePa" +
                    "geAndGoingBackViaTheBrowseBackButtonForListFilters", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "Evergreen_FiltersFeature",
                        "FilterFunctionality",
                        "DAS10977",
                        "DAS13376",
                        "Cleanup"});
#line 52
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
                TechTalk.SpecFlow.Table table1902 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1902.AddRow(new string[] {
                            "Application Key"});
#line 53
 testRunner.When("User add following columns using URL to the \"Applications\" page:", ((string)(null)), table1902, "When ");
#line hidden
#line 56
 testRunner.When("User create dynamic list with \"TestListD75CD3\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("\"TestListD75CD3\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1903 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedList",
                            "Association"});
                table1903.AddRow(new string[] {
                            "TestListD75CD3",
                            "Not used on device"});
#line 62
 testRunner.When("User add \"Application (Saved List)\" filter where type is \"In list\" with Selected " +
                        "Value and following Association:", ((string)(null)), table1903, "When ");
#line hidden
#line 65
 testRunner.Then("\"Any Application in list TestListD75CD3 not used on device\" is displayed in added" +
                        " filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("\"17,185\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("User perform search by \"001BAQXT6JWFPI\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.And("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.Then("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.Then("\"17,185\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.Then("\"Any Application in list TestListD75CD3 not used on device\" is displayed in added" +
                        " filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckNumericFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11560")]
        public virtual void EvergreenJnr_DevicesList_CheckNumericFilter()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "Evergreen_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11560"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckNumericFilter", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_FiltersFeature",
                        "FilterFunctionality",
                        "DAS11560"});
#line 75
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
#line 76
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1904 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1904.AddRow(new string[] {
                            "1"});
#line 80
 testRunner.When("User add \"App Count (Installed)\" filter where type is \"Less than\" without added c" +
                        "olumn and following value:", ((string)(null)), table1904, "When ");
#line hidden
#line 83
 testRunner.Then("\"App Count (Installed) is less than 1\" is displayed in added filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.Then("\"5,195\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThat500ErrorInNotDisplayedWhenUserApplyASelect" +
            "edNumericFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11560")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThat500ErrorInNotDisplayedWhenUserApplyASelectedNumericFilter()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11560"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThat500ErrorInNotDisplayedWhenUserApplyASelect" +
                    "edNumericFilter", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS11560"});
#line 87
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
#line 88
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 91
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1905 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1905.AddRow(new string[] {
                            "10"});
#line 92
 testRunner.When("User add \"Device Count (Installed)\" filter where type is \"Less than\" with added c" +
                        "olumn and following value:", ((string)(null)), table1905, "When ");
#line hidden
#line 95
 testRunner.Then("\"Device Count (Installed)\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.Then("\"1,269\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.Then("\"(Device Count (Installed) < 10)\" text is displayed in filter container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatLDAPFilterCategoryHaveAddColumnCheckboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11577")]
        [NUnit.Framework.TestCaseAttribute("accountexpires", "Equals", "9223372036854775807", "Add accountexpires column", null)]
        [NUnit.Framework.TestCaseAttribute("badpasswordtime", "Contains", "13146", "Add badpasswordtime column", null)]
        [NUnit.Framework.TestCaseAttribute("admincount", "Empty", "", "Add admincount column", null)]
        [NUnit.Framework.TestCaseAttribute("employeeid", "Begins with", "ZY or ZX", "Add employeeid column", null)]
        [NUnit.Framework.TestCaseAttribute("whencreated", "Does not contain", "2017", "Add whencreated column", null)]
        [NUnit.Framework.TestCaseAttribute("department", "Ends with", "LongName01234567890123456789012345678901234567890123456789", "Add Department column", null)]
        [NUnit.Framework.TestCaseAttribute("iscriticalsystemobject", "Not empty", "", "Add iscriticalsystemobject column", null)]
        public virtual void EvergreenJnr_UsersList_CheckThatLDAPFilterCategoryHaveAddColumnCheckboxes(string filterName, string operatorValues, string enteredText, string selectedCheckboxes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11577"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatLDAPFilterCategoryHaveAddColumnCheckboxes", null, @__tags);
#line 100
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
#line 101
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.When(string.Format("user select \"{0}\" filter", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When(string.Format("User select \"{0}\" Operator value", operatorValues), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.And(string.Format("User enters \"{0}\" text in Search field at selected Filter", enteredText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1906 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1906.AddRow(new string[] {
                            string.Format("{0}", selectedCheckboxes)});
#line 108
 testRunner.Then("checkboxes are displayed to the User:", ((string)(null)), table1906, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
