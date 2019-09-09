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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.CapacityUnits
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CapacityUnitsGrid")]
    public partial class CapacityUnitsGridFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacityUnitsGrid.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacityUnitsGrid", "\tCapacity Units Grid", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS13169")]
        [NUnit.Framework.CategoryAttribute("DAS13168")]
        [NUnit.Framework.CategoryAttribute("DAS12632")]
        [NUnit.Framework.CategoryAttribute("DAS13012")]
        public virtual void EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefaultInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefaultInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS13169",
                        "DAS13168",
                        "DAS12632",
                        "DAS13012"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("\"Capacity Units\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.Then("data in the table is sorted by \"Capacity Unit\" column in ascending order by defau" +
                    "lt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("data in the table is sorted by \"Capacity Unit\" column in ascending order by defau" +
                    "lt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("Evergreen Icon is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("\'Unassigned\' content is displayed in the \'Capacity Unit\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("Evergreen Unit is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("\"Evergreen\" checkbox is checked in the filter dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessages" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS12921")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessages()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessagesInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessagesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessages" +
                    "", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12921"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 28
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("\"Capacity Units\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table1.AddRow(new string[] {
                        "Evergreen Capacity Unit 1"});
#line 33
 testRunner.When("User select \"Capacity Unit\" rows in the grid", ((string)(null)), table1, "When ");
#line 36
 testRunner.And("User clicks on Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("User selects \"Delete\" in the Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("Warning message with \"This unit will be permanently deleted and any objects withi" +
                    "n it reassigned to the default unit\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table2.AddRow(new string[] {
                        "Evergreen Capacity Unit 2"});
#line 40
 testRunner.When("User select \"Capacity Unit\" rows in the grid", ((string)(null)), table2, "When ");
#line 43
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("Warning message with \"These units will be permanently deleted and any objects wit" +
                    "hin them reassigned to the default unit\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrect")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS14070")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrect()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrectInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrect", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS14070"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 48
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("\"Capacity Units\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.Then("sum of objects in \"Applications\" list is \"2223\" on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

