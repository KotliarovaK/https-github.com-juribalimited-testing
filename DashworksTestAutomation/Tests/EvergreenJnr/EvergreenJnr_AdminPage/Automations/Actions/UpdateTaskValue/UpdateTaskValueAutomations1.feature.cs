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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Automations.Actions.UpdateTaskValue
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UpdateTaskValueAutomations1")]
    public partial class UpdateTaskValueAutomations1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateTaskValueAutomations1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdateTaskValueAutomations1", "\tRuns Update Task Value Actions type related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjec" +
            "tDropdown")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18320")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjectDropdown()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjectDropdownInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjectDropdownInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjec" +
                    "tDropdown", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18320",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table1.AddRow(new string[] {
                        "18320_Automation",
                        "18320",
                        "true",
                        "false",
                        "All Applications",
                        "Manual"});
#line 10
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table1, "When ");
#line 13
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And("User enters \'18320_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("\'Mailbox Evergreen Capacity Project\' content is not displayed in \'Project\' autoco" +
                    "mplete after search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User selects \'1803 Rollout\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.When("User selects \'Pre-Migration\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.When("User selects \'App Workflow\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("User selects \'Not Started\' in the \'Value\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("User clicks content from \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("\'Edit Action\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("\'Mailbox Evergreen Capacity Project\' content is not displayed in \'Project\' autoco" +
                    "mplete after search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValue")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18248")]
        [NUnit.Framework.CategoryAttribute("DAS18276")]
        [NUnit.Framework.CategoryAttribute("DAS18640")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValue()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValueInternal();
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

        private void EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValueInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValue", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18248",
                        "DAS18276",
                        "DAS18640",
                        "Cleanup"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table2.AddRow(new string[] {
                        "182481_Automation",
                        "18248",
                        "true",
                        "false",
                        "All Devices",
                        "Manual"});
#line 32
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table2, "When ");
#line 35
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And("User enters \'18248_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("User selects \'Computer Scheduled Test (Jo)\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.When("User selects \'One\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.When("User selects \'Date Computer\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.When("User selects \'Update relative to current value\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.When("User enters \'999999\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("\'100000\' content is displayed in \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("User enters \'-5\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("\'1\' content is displayed in \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.When("User enters \'2\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("\'CREATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User selects \'Before current value\' in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("User clicks content from \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\'Edit Action\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("\"18248_Action\" content is displayed in \"Action Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("\'Update task value\' content is displayed in \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.Then("\'Computer Scheduled Test (Jo)\' content is displayed in \'Project\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.Then("\'One\' content is displayed in \'Stage\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("\'Date Computer\' content is displayed in \'Task\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("\'2\' content is displayed in \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("\'Days\' value is displayed in the \'Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("\'Before current value\' value is displayed in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValue")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18248")]
        [NUnit.Framework.CategoryAttribute("DAS18276")]
        [NUnit.Framework.CategoryAttribute("DAS18965")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValue()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValueInternal();
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

        private void EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValueInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValue", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18248",
                        "DAS18276",
                        "DAS18965",
                        "Cleanup",
                        "Not_Ready"});
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table3.AddRow(new string[] {
                        "182482_Automation",
                        "18248",
                        "true",
                        "false",
                        "All Applications",
                        "Manual"});
#line 68
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table3, "When ");
#line 71
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.And("User enters \'18248_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.When("User selects \'Computer Scheduled Test (Jo)\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.When("User selects \'One\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("User selects \'Radio Rag Date Owner App\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.When("User selects \'No change\' in the \'Update Value\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table4.AddRow(new string[] {
                        "Update"});
            table4.AddRow(new string[] {
                        "Update relative to current value"});
            table4.AddRow(new string[] {
                        "Update relative to now"});
            table4.AddRow(new string[] {
                        "Remove"});
            table4.AddRow(new string[] {
                        "No change"});
#line 81
 testRunner.Then("following Values are displayed in the \'Update Date\' dropdown:", ((string)(null)), table4, "Then ");
#line 88
 testRunner.When("User selects \'Update relative to current value\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.When("User enters \'2\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.When("User selects \'After current value\' in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.When("User selects \'No change\' in the \'Update Owner\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("\'The automation action has been created\' text is displayed on inline success bann" +
                    "er", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Then("\"2 days after current value\" content is displayed for \"Value\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User clicks content from \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("\'Edit Action\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Then("\"18248_Action\" content is displayed in \"Action Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("\'Update task value\' content is displayed in \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("\'Computer Scheduled Test (Jo)\' content is displayed in \'Project\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("\'One\' content is displayed in \'Stage\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.Then("\'Radio Rag Date Owner App\' content is displayed in \'Task\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.Then("\'2\' content is displayed in \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.Then("\'No change\' value is displayed in the \'Update Value\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.Then("\'Update relative to current value\' value is displayed in the \'Update Date\' dropdo" +
                    "wn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.Then("\'No change\' value is displayed in the \'Update Owner\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.Then("\'Days\' value is displayed in the \'Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.Then("\'After current value\' value is displayed in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValue")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18248")]
        [NUnit.Framework.CategoryAttribute("DAS18276")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValue()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValueInternal();
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

        private void EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValueInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValue", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18248",
                        "DAS18276",
                        "Cleanup",
                        "Not_Ready"});
#line 113
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table5.AddRow(new string[] {
                        "182483_Automation",
                        "18248",
                        "true",
                        "false",
                        "All Mailboxes",
                        "Manual"});
#line 114
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table5, "When ");
#line 117
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.And("User enters \'18248_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.When("User selects \'Mailbox Evergreen Capacity Project\' option from \'Project\' autocompl" +
                    "ete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.When("User selects \'1\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.When("User selects \'Completed\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table6.AddRow(new string[] {
                        "Update"});
            table6.AddRow(new string[] {
                        "Update relative to current value"});
            table6.AddRow(new string[] {
                        "Update relative to now"});
            table6.AddRow(new string[] {
                        "Remove"});
#line 126
 testRunner.Then("following Values are displayed in the \'Update Date\' dropdown:", ((string)(null)), table6, "Then ");
#line 132
 testRunner.When("User selects \'Update relative to current value\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.When("User enters \'3\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.When("User clicks content from \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.Then("\'Edit Action\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.Then("\"18248_Action\" content is displayed in \"Action Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.Then("\'Update task value\' content is displayed in \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.Then("\'Mailbox Evergreen Capacity Project\' content is displayed in \'Project\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
 testRunner.Then("\'1\' content is displayed in \'Stage\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.Then("\'Completed\' content is displayed in \'Task\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.Then("\'3\' content is displayed in \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.Then("\'Days\' value is displayed in the \'Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 145
 testRunner.Then("\'After current value\' value is displayed in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValue")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18248")]
        [NUnit.Framework.CategoryAttribute("DAS18276")]
        [NUnit.Framework.CategoryAttribute("DAS19117")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValue()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValueInternal();
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

        private void EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValueInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValue", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18248",
                        "DAS18276",
                        "DAS19117",
                        "Cleanup"});
#line 148
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table7.AddRow(new string[] {
                        "182484_Automation",
                        "18248",
                        "true",
                        "false",
                        "All Users",
                        "Manual"});
#line 149
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table7, "When ");
#line 152
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.And("User enters \'18248_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("User selects \'Update task value\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.When("User selects \'Barry\'s User Project\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.When("User selects \'Project Dates\' option from \'Stage\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 160
 testRunner.When("User selects \'Forecast Date\' option from \'Task\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
 testRunner.Then("inline error banner is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.When("User selects \'Update relative to now\' in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table8.AddRow(new string[] {
                        "Before now"});
            table8.AddRow(new string[] {
                        "After now"});
#line 163
 testRunner.Then("following Values are displayed in the \'Before or After\' dropdown:", ((string)(null)), table8, "Then ");
#line 167
 testRunner.When("User enters \'4\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
 testRunner.When("User selects \'Hours\' in the \'Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 169
 testRunner.When("User selects \'Before now\' in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 170
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.When("User clicks content from \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.Then("\'Edit Action\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
 testRunner.Then("\"18248_Action\" content is displayed in \"Action Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.Then("\'Update task value\' content is displayed in \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.Then("\'Barry\'s User Project\' content is displayed in \'Project\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 177
 testRunner.Then("\'Project Dates\' content is displayed in \'Stage\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.Then("\'Forecast Date\' content is displayed in \'Task\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 179
 testRunner.Then("\'4\' content is displayed in \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.Then("\'Hours\' value is displayed in the \'Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
 testRunner.Then("\'Update relative to now\' value is displayed in the \'Update Date\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 182
 testRunner.Then("\'Before now\' value is displayed in the \'Before or After\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

