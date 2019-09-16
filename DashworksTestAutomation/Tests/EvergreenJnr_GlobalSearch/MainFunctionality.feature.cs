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
namespace DashworksTestAutomation.Tests.EvergreenJnr_GlobalSearch
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MainFunctionality")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class MainFunctionalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MainFunctionality.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MainFunctionality", "\tRuns Main Functionality related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
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
#line 5
#line 6
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GlobalSearch_CheckThatErrorMessageIsNotDisplayedAfterTypingThreeSpac" +
            "es")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("MainFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11490")]
        [NUnit.Framework.CategoryAttribute("DAS11745")]
        [NUnit.Framework.CategoryAttribute("DAS11706")]
        [NUnit.Framework.CategoryAttribute("DAS12544")]
        [NUnit.Framework.CategoryAttribute("DAS12047")]
        [NUnit.Framework.CategoryAttribute("DAS12603")]
        [NUnit.Framework.CategoryAttribute("DAS12728")]
        public virtual void EvergreenJnr_GlobalSearch_CheckThatErrorMessageIsNotDisplayedAfterTypingThreeSpaces()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_GlobalSearch_CheckThatErrorMessageIsNotDisplayedAfterTypingThreeSpacesInternal();
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

        private void EvergreenJnr_GlobalSearch_CheckThatErrorMessageIsNotDisplayedAfterTypingThreeSpacesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GlobalSearch_CheckThatErrorMessageIsNotDisplayedAfterTypingThreeSpac" +
                    "es", null, new string[] {
                        "Evergreen",
                        "GlobalSearch",
                        "EvergreenJnr_GlobalSearch",
                        "MainFunctionality",
                        "DAS11490",
                        "DAS11745",
                        "DAS11706",
                        "DAS12544",
                        "DAS12047",
                        "DAS12603",
                        "DAS12728"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 11
 testRunner.When("User type \"   \" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("\"Enter at least 3 characters\" message is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When("User type \"a b\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("Search results are displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.When("User type \" \" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("\"Enter at least 3 characters\" message is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User type \" a b\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Search results are displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User type \"ab \" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("Search results are displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("User type \"%%%ab \" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("\"No results found\" message is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User type \"___ab \" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("Search results are displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("User type \"admin\" in Global Search Field and presses Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("\"No results found\" message is not displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("\"Search results for \"admin\"\" is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.And("\"195\" rows are displayed on the Global Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("list of results is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("User type \"!@#$%^&*()\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("\"No results found\" message is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.When("User type \"______#____-\" in Global Search Field and presses Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("\"Search results for \"______#____-\"\" is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.And("\"1\" rows are displayed on the Global Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("list of results is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("User type \"%SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013\" in Gl" +
                    "obal Search Field and presses Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("\"Search results for \"%SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2" +
                    "013\"\" is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("\"1\" rows are displayed on the Global Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("User type \"\"WPF/E\" (codename) Community Technology Preview (Feb 2007)\" in Global " +
                    "Search Field and presses Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("\"Search results for \"\"WPF/E\" (codename) Community Technology Preview (Feb 2007)\"\"" +
                    " is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And("\'\"WPF/E\" (codename) Community Technology Preview (Feb 2007) (0.8.5.0)\' content is" +
                    " displayed in the \'Name\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.When("User type \"Escaping Test User |\\\\/\\,\\<\\>#\\;+\\\"\\=- |\\\\/\\,\\<\\>#\\;+\\\"\\=-.Users.corp." +
                    "juriba.com\" in Global Search Field and presses Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("\"Search results for \"Escaping Test User |\\\\/\\,\\<\\>#\\;+\\\"\\=- |\\\\/\\,\\<\\>#\\;+\\\"\\=-.U" +
                    "sers.corp.juriba.com\"\" is displayed below Global Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.And("message \"No results found for the current search\" is displayed to the user below " +
                    "Search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_Search_CheckThatGlobalSearchFieldHaveAResetButton")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("MainFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11350")]
        public virtual void EvergreenJnr_DevicesList_Search_CheckThatGlobalSearchFieldHaveAResetButton()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_Search_CheckThatGlobalSearchFieldHaveAResetButtonInternal();
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

        private void EvergreenJnr_DevicesList_Search_CheckThatGlobalSearchFieldHaveAResetButtonInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_Search_CheckThatGlobalSearchFieldHaveAResetButton", null, new string[] {
                        "Evergreen",
                        "GlobalSearch",
                        "EvergreenJnr_GlobalSearch",
                        "MainFunctionality",
                        "DAS11350"});
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 49
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("\"All Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User type \"CheckTheResetButton\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("reset button in Global Search field is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_Search_CheckThat500ErrorMessageIsNotDisplayedAfterEnteringT" +
            "heSpecificCharacters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("MainFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11495")]
        [NUnit.Framework.TestCaseAttribute("Devices", null)]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", null)]
        public virtual void EvergreenJnr_AllLists_Search_CheckThat500ErrorMessageIsNotDisplayedAfterEnteringTheSpecificCharacters(string pageName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_Search_CheckThat500ErrorMessageIsNotDisplayedAfterEnteringTheSpecificCharactersInternal(pageName,exampleTags);
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

        private void EvergreenJnr_AllLists_Search_CheckThat500ErrorMessageIsNotDisplayedAfterEnteringTheSpecificCharactersInternal(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "GlobalSearch",
                    "EvergreenJnr_GlobalSearch",
                    "MainFunctionality",
                    "DAS11495"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_Search_CheckThat500ErrorMessageIsNotDisplayedAfterEnteringT" +
                    "heSpecificCharacters", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 56
 testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then(string.Format("\"All {0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.When("User type \"[^abc]\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then(string.Format("\"All {0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_Search_CheckThatAnyTabCanBeOpenedAfterSearchHasBeenPerformed")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("MainFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS14731")]
        public virtual void EvergreenJnr_Search_CheckThatAnyTabCanBeOpenedAfterSearchHasBeenPerformed()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_Search_CheckThatAnyTabCanBeOpenedAfterSearchHasBeenPerformedInternal();
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

        private void EvergreenJnr_Search_CheckThatAnyTabCanBeOpenedAfterSearchHasBeenPerformedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Search_CheckThatAnyTabCanBeOpenedAfterSearchHasBeenPerformed", null, new string[] {
                        "Evergreen",
                        "GlobalSearch",
                        "EvergreenJnr_GlobalSearch",
                        "MainFunctionality",
                        "DAS14731"});
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 70
 testRunner.When("User type \"jet\" in Global Search Field and presses Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("list of results is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("\"All Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_Search_CheckThatThereIsSameAppearanceOfTheUnknownVersionInTestLangua" +
            "ge")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("MainFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17633")]
        public virtual void EvergreenJnr_Search_CheckThatThereIsSameAppearanceOfTheUnknownVersionInTestLanguage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_Search_CheckThatThereIsSameAppearanceOfTheUnknownVersionInTestLanguageInternal();
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

        private void EvergreenJnr_Search_CheckThatThereIsSameAppearanceOfTheUnknownVersionInTestLanguageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Search_CheckThatThereIsSameAppearanceOfTheUnknownVersionInTestLangua" +
                    "ge", null, new string[] {
                        "Evergreen",
                        "GlobalSearch",
                        "EvergreenJnr_GlobalSearch",
                        "MainFunctionality",
                        "DAS17633"});
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 78
 testRunner.When("User type \"ACDSee 4.0 SendPix & Email Update\" in Global Search Field and presses " +
                    "Enter key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("list of results is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.When("User language is changed to \"Test Language\" via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.And("User navigates to second tab of Search Results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("Version column of Search Results has no Unknown item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.When("User clicks first \"ACDSee 4.0 SendPix & Email Update\" item in grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("Value column of Item Details has no Unknown item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_Search_CheckThatPressToSeeAllResultsWorksInGlobalSearch")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_GlobalSearch")]
        [NUnit.Framework.CategoryAttribute("MainFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17368")]
        public virtual void EvergreenJnr_Search_CheckThatPressToSeeAllResultsWorksInGlobalSearch()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_Search_CheckThatPressToSeeAllResultsWorksInGlobalSearchInternal();
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

        private void EvergreenJnr_Search_CheckThatPressToSeeAllResultsWorksInGlobalSearchInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Search_CheckThatPressToSeeAllResultsWorksInGlobalSearch", null, new string[] {
                        "Evergreen",
                        "GlobalSearch",
                        "EvergreenJnr_GlobalSearch",
                        "MainFunctionality",
                        "DAS17368"});
#line 87
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 88
 testRunner.When("User type \"mail\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("\'Press Enter to see all 133 results\' label is displayed below Global Search field" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.When("User presses Enter key in in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("Counter shows \"133\" found rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

