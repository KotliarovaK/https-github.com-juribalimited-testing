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
    [NUnit.Framework.DescriptionAttribute("MailboxesFiltersAndColumns")]
    public partial class MailboxesFiltersAndColumnsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MailboxesFiltersAndColumns.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MailboxesFiltersAndColumns", "\tCheck all Columns and Filters via API", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckAllColumnsAndFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        public virtual void EvergreenJnr_MailboxesList_CheckAllColumnsAndFilters()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckAllColumnsAndFiltersInternal();
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

        private void EvergreenJnr_MailboxesList_CheckAllColumnsAndFiltersInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckAllColumnsAndFilters", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "API",
                        "FiltersAndColumns"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 9
 testRunner.Then("All filters with correct data are returned from the API for \'Mailboxes\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Then("All columns with correct data are returned from the API for \'Mailboxes\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseData")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseData()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseDataInternal();
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

        private void EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseDataInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseData", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "API",
                        "FiltersAndColumns",
                        "Not_Run"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 15
 testRunner.Then("Positive number of results returned for \'MailboxesQueryUrls\' requests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("FiltersAndColumns")]
        [NUnit.Framework.CategoryAttribute("DAS15899")]
        public virtual void EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesListsInternal();
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

        private void EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesListsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "API",
                        "FiltersAndColumns",
                        "DAS15899"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "value"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Completed"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Completed (Slot)"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Forecast"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Forecast (Slot)"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Migrated"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Migrated (Slot)"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Scheduled - mailbox"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Scheduled - mailbox (Slot)"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Target"});
            table1.AddRow(new string[] {
                        "MailboxEve: 1 \\ Target (Slot)"});
#line 19
 testRunner.Then("the following filter subcategories are displayed for \'Project Tasks: MailboxEve\' " +
                    "category on \'Mailboxes\' page:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

