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
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart12")]
    public partial class FiltersFunctionalityPart12Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FiltersFunctionalityPart12.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart12", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTarge" +
            "tAppFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS13377")]
        public virtual void EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTargetAppFilter()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTargetAppFilterInternal();
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

        private void EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTargetAppFilterInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTarge" +
                    "tAppFilter", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS13377"});
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
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table1.AddRow(new string[] {
                        "Python 2.2a4 (SMS_GEN)"});
#line 14
 testRunner.When("User add \"Barry\'sUse: Target App\" filter where type is \"Equals\" with added column" +
                    " and Lookup option", ((string)(null)), table1, "When ");
#line 17
 testRunner.Then("\"Barry\'sUse: Target App\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("\"Barry\'sUse: Target App is Python 2.2a4 (SMS_GEN)\" is displayed in added filter i" +
                    "nfo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("User click content from \"Application\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And("\"Barry\'sUse: Target App is Python 2.2a4 (SMS_GEN)\" is displayed in added filter i" +
                    "nfo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjec" +
            "tAndThenReturningBackToSerachResult")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS13381")]
        [NUnit.Framework.CategoryAttribute("DAS14603")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "Babel(Engl: Category", "None", "00KLL9S8NRF0X6", "Babel(Engl: Category is None", null)]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "Babel(Engl: In Scope", "FALSE", "00I0COBFWHOF27", "Babel(Engl: In Scope is False", null)]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "ComputerSc: Path", "Request Type A", "47NK3ATE5DM2HD", "ComputerSc: Path is Request Type A", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "Havoc(BigD: Hide from End Users", "UNKNOWN", "Adobe Flash Player 10 ActiveX (10.0.12.36)", "Havoc(BigD: Hide from End Users is Unknown", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "MigrationP: Core Application", "FALSE", "Adobe Download Manager 2.0 (Remove Only)", "MigrationP: Core Application is False", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "EmailMigra: Mobile Devices \\ Device Type", "Not Identified", "238BAE24882E48BFA9F@bclabs.local", "EmailMigra: Mobile Devices \\ Device Type is Not Identified", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjectAndThenReturningBackToSerachResult(string pageName, string columnName, string filterName, string filterValue, string search, string filterInfo, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjectAndThenReturningBackToSerachResultInternal(pageName,columnName,filterName,filterValue,search,filterInfo,exampleTags);
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

        private void EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjectAndThenReturningBackToSerachResultInternal(string pageName, string columnName, string filterName, string filterValue, string search, string filterInfo, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS13381",
                    "DAS14603"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjec" +
                    "tAndThenReturningBackToSerachResult", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 27
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table2.AddRow(new string[] {
                        string.Format("{0}", filterValue)});
#line 31
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following chec" +
                        "kboxes:", filterName), ((string)(null)), table2, "When ");
#line 34
 testRunner.Then(string.Format("\"{0}\" filter is added to the list", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And(string.Format("\"{0}\" is displayed in added filter info", filterInfo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When(string.Format("User perform search by \"{0}\"", search), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And(string.Format("\"{0}\" is displayed in added filter info", filterInfo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativ" +
            "eAssociation")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12214")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativeAssociation()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativeAssociationInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativeAssociationInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativ" +
                    "eAssociation", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12214"});
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 54
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values",
                        "Association"});
            table3.AddRow(new string[] {
                        "1 May 2011",
                        "Has used app"});
            table3.AddRow(new string[] {
                        "",
                        "Entitled to app"});
            table3.AddRow(new string[] {
                        "",
                        "Owns a device which app was used on"});
            table3.AddRow(new string[] {
                        "",
                        "Owns a device which app is entitled to"});
            table3.AddRow(new string[] {
                        "",
                        "Owns a device which app is installed on"});
#line 58
 testRunner.When("User add \"User Last Logon Date\" filter where type is \"After\" with following Data " +
                    "and Association:", ((string)(null)), table3, "When ");
#line 65
 testRunner.Then("\"1,206\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.When("User click Edit button for \" Last Logon Date\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("only positive Associations is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When("User is deselect \"Has used app\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.And("User is deselect \"Entitled to app\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("User is deselect \"Owns a device which app was used on\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("User is deselect \"Owns a device which app is entitled to\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("User is deselect \"Owns a device which app is installed on\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("User select \"Has not used app\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("only negative Associations is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User select \"Not entitled to app\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.And("User select \"Does not own a device which app was used on\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("User select \"Does not own a device which app is entitled to\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("User select \"Does not own a device which app is installed on\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("\"2,223\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values",
                        "Association"});
            table4.AddRow(new string[] {
                        "Adobe",
                        "Used on device"});
#line 85
 testRunner.When("User add \"Application Name\" filter where type is \"Begins with\" with following Val" +
                    "ue and Association:", ((string)(null)), table4, "When ");
#line 88
 testRunner.When("User click Edit button for \"Application \" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("only positive Associations is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.When("User is deselect \"Used on device\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.And("User select \"Not used on device\" in Association", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("only negative Associations is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoe" +
            "sntEqualValues")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12211")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValues()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValuesInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValuesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoe" +
                    "sntEqualValues", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12211"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 96
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values",
                        "Association"});
            table5.AddRow(new string[] {
                        "26 Apr 2018",
                        "Has used app"});
#line 100
 testRunner.When("User add \"User Last Logon Date\" filter where type is \"Does not equal\" with follow" +
                    "ing Data and Association:", ((string)(null)), table5, "When ");
#line 103
 testRunner.Then("\"100\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.When("User click Edit button for \" Last Logon Date\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("User changes filter type to \"Equals\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.Then("message \'No applications found\' is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

