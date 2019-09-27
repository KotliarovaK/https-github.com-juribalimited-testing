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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Automations
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AutomationsLogPart5")]
    public partial class AutomationsLogPart5Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AutomationLogPart5.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AutomationsLogPart5", "\tRuns Automation Log Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAut" +
            "omationDAS17974")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS17974")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAutomationDAS17974()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAutomationDAS17974Internal();
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

        private void EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAutomationDAS17974Internal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAut" +
                    "omationDAS17974", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS17974",
                        "Cleanup",
                        "Not_Ready"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 11
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table1.AddRow(new string[] {
                        "17974_Automation",
                        "17974",
                        "true",
                        "false",
                        "Users Readiness Columns & Filters",
                        "Manual"});
#line 13
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table1, "When ");
#line 16
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.When("User enters \'17974_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("User selects \'zUser Sch for Automations Feature\' option from \'Project\' autocomple" +
                    "te", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.When("User selects \'Stage 3\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.When("User selects \'DDL Slot Task\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.And("User selects \"No change\" Update Value on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("User selects \"Remove\" Update Date on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("User clicks \"Automations\" navigation link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.When("User enters \"17974_Automation\" text in the Search field for \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.When("User clicks \"Run now\" option in Cog-menu for \"17974_Automation\" item on Admin pag" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.When("User selects \"Automation Log\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.When("User enters \"17974_Automation\" text in the Search field for \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("\"SUCCESS\" content is displayed for \"Outcome\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User clicks String Filter button for \"Type\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("User selects \"Automation Finish\" checkbox from String Filter with item list on th" +
                    "e Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("User clicks content from \"Objects\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "zUserAutom: Stage 3 \\ DDL Slot Task"});
            table2.AddRow(new string[] {
                        "zUserAutom: Stage 3 \\ DDL Slot Task (Date)"});
            table2.AddRow(new string[] {
                        "zUserAutom: Stage 3 \\ DDL Slot Task (Slot)"});
#line 41
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2, "When ");
#line 46
 testRunner.Then("\"Started\" content is displayed in \"zUserAutom: Stage 3 \\ DDL Slot Task\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.Then("\"\" content is displayed in \"zUserAutom: Stage 3 \\ DDL Slot Task (Date)\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.Then("\"\" content is displayed in \"zUserAutom: Stage 3 \\ DDL Slot Task (Slot)\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomatio" +
            "n")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS17829")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomation()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomationInternal();
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

        private void EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomationInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomatio" +
                    "n", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS17829",
                        "Cleanup",
                        "Not_Ready"});
#line 52
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 53
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table3.AddRow(new string[] {
                        "17829_Automation",
                        "17829",
                        "true",
                        "false",
                        "Mailbox Readiness Columns & Filters",
                        "Manual"});
#line 55
 testRunner.When("User creates new Automation via API", ((string)(null)), table3, "When ");
#line 58
 testRunner.When("User navigates to the \'Automations\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("Page with \'Automations\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.When("User enters \"17829_Automation\" text in the Search field for \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("User clicks content from \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.When("User enters \'17829_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When("User selects \'zMailbox Sch for Automations Feature\' option from \'Project\' autocom" +
                    "plete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.When("User selects \'Stage 3\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.When("User selects \'Radio Date Owner\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("User selects \"No change\" Update Value on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("User selects \"No change\" Update Date on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("User selects \"Remove owner\" Update Owner on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("User clicks \"Automations\" navigation link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.When("User enters \"17829_Automation\" text in the Search field for \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.When("User clicks \"Run now\" option in Cog-menu for \"17829_Automation\" item on Admin pag" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("User selects \"Automation Log\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.When("User enters \"17829_Automation\" text in the Search field for \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("\"SUCCESS\" content is displayed for \"Outcome\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User clicks String Filter button for \"Type\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.When("User selects \"Automation Finish\" checkbox from String Filter with item list on th" +
                    "e Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.And("User clicks content from \"Objects\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "zMailboxAu: Stage 3 \\ Radio Date Owner"});
            table4.AddRow(new string[] {
                        "zMailboxAu: Stage 3 \\ Radio Date Owner (Date)"});
            table4.AddRow(new string[] {
                        "zMailboxAu: Stage 3 \\ Radio Date Owner (Owner)"});
            table4.AddRow(new string[] {
                        "zMailboxAu: Stage 3 \\ Radio Date Owner (Team)"});
#line 89
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table4, "When ");
#line 95
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User removes \"Email Address\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User removes \"Mailbox Platform\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("\"NOT STARTED\" content is displayed in \"zMailboxAu: Stage 3 \\ Radio Date Owner\" co" +
                    "lumn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("\"7 Sep 2019\" content is displayed in \"zMailboxAu: Stage 3 \\ Radio Date Owner (Dat" +
                    "e)\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("\"Unassigned\" content is displayed in \"zMailboxAu: Stage 3 \\ Radio Date Owner (Own" +
                    "er)\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.Then("\"Admin IT\" content is displayed in \"zMailboxAu: Stage 3 \\ Radio Date Owner (Team)" +
                    "\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

