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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_API_FiltersAndColumns
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UsersFiltersAndColumns")]
    public partial class UsersFiltersAndColumnsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UsersFiltersAndColumns.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UsersFiltersAndColumns", "\tCheck all Columns and Filters via API", ProgrammingLanguage.CSharp, ((string[])(null)));
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
 testRunner.Given("User is logged in to the Evergreen via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckAllColumnsAndFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        public virtual void EvergreenJnr_UsersList_CheckAllColumnsAndFilters()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckAllColumnsAndFiltersInternal();
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

        private void EvergreenJnr_UsersList_CheckAllColumnsAndFiltersInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckAllColumnsAndFilters", null, new string[] {
                        "Evergreen",
                        "Users",
                        "API",
                        "FiltersAndColumns"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 9
 testRunner.Then("All filters with correct data are returned from the API for \'Users\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Then("All columns with correct data are returned from the API for \'Users\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseData")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        [NUnit.Framework.CategoryAttribute("DAS19261")]
        [NUnit.Framework.TestCaseAttribute("Application", "App Count (Installed on Owned Device)", "users?$filter=(installedApplications%20%3D%201)&$select=username,directoryName,di" +
            "splayName,fullyDistinguishedObjectName,installedApplications", null)]
        public virtual void EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseData(string filterCategory, string filterName, string queryString, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseDataInternal(filterCategory,filterName,queryString,exampleTags);
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

        private void EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseDataInternal(string filterCategory, string filterName, string queryString, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Users",
                    "API",
                    "FiltersAndColumns",
                    "DAS19261"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseData", null, @__tags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FilterCategory",
                        "FilterName",
                        "QueryString"});
            table1.AddRow(new string[] {
                        string.Format("{0}", filterCategory),
                        string.Format("{0}", filterName),
                        string.Format("{0}", queryString)});
#line 14
testRunner.Then("Positive number of results returned for requests:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("DAS14629")]
        [NUnit.Framework.CategoryAttribute("DAS14663")]
        [NUnit.Framework.CategoryAttribute("DAS14629")]
        public virtual void EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersListInternal();
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

        private void EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersList", null, new string[] {
                        "Evergreen",
                        "Users",
                        "API",
                        "FiltersAndColumns",
                        "API",
                        "DAS14629",
                        "DAS14663",
                        "DAS14629"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "OperatorValues"});
            table2.AddRow(new string[] {
                        "Equals"});
            table2.AddRow(new string[] {
                        "Does not equal"});
            table2.AddRow(new string[] {
                        "Contains"});
            table2.AddRow(new string[] {
                        "Does not contain"});
            table2.AddRow(new string[] {
                        "Begins with"});
            table2.AddRow(new string[] {
                        "Does not begin with"});
            table2.AddRow(new string[] {
                        "Ends with"});
            table2.AddRow(new string[] {
                        "Does not end with"});
            table2.AddRow(new string[] {
                        "Empty"});
            table2.AddRow(new string[] {
                        "Not empty"});
#line 24
testRunner.Then("following operators are displayed in \"User\" category for \"Primary Device\" filter " +
                    "on \"Users\" page:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("DAS15899")]
        public virtual void EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersListsInternal();
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

        private void EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersListsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists", null, new string[] {
                        "Evergreen",
                        "Users",
                        "API",
                        "FiltersAndColumns",
                        "API",
                        "DAS15899"});
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "value"});
            table3.AddRow(new string[] {
                        "DeviceSche: Stage 2 \\ user DDL task"});
            table3.AddRow(new string[] {
                        "DeviceSche: Stage 2 \\ user radiobutton task"});
            table3.AddRow(new string[] {
                        "DeviceSche: Stage 2 \\ user text task"});
#line 39
 testRunner.Then("the following filter subcategories are displayed for \'Project Tasks: DeviceSche\' " +
                    "category on \'Users\' page:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

