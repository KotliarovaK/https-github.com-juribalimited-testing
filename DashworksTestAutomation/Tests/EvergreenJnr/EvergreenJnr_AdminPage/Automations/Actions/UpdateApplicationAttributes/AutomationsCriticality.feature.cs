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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Automations.Actions.UpdateApplicationAttributes
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AutomationsCriticality")]
    public partial class AutomationsCriticalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AutomationsCriticality.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AutomationsCriticality", "\tRuns Criticality Update Application Attributes Actions type related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsV" +
            "isible")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18674")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Universe")]
        public virtual void EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsVisible()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsVisibleInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsVisibleInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsV" +
                    "isible", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18674",
                        "Cleanup",
                        "Universe"});
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
                        "18674_Automation",
                        "18674",
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
 testRunner.And("User enters \'18727_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User selects \'Update application attributes\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("\'No change\' content is displayed in \'Criticality\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("\'No change\' content is displayed in \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("\'No change\' content is displayed in \'Sticky Compliance\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("\'No change\' content is displayed in \'In Catalog\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table2.AddRow(new string[] {
                        "No change"});
            table2.AddRow(new string[] {
                        "Core"});
            table2.AddRow(new string[] {
                        "Critical"});
            table2.AddRow(new string[] {
                        "Important"});
            table2.AddRow(new string[] {
                        "Not Important"});
            table2.AddRow(new string[] {
                        "Uncategorised"});
#line 24
 testRunner.Then("following Values are displayed in the \'Criticality\' dropdown:", ((string)(null)), table2, "Then ");
#line 32
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then("\'SAVE AND CREATE ANOTHER\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.Then("\'CREATE\' button has tooltip with \'Select at least one value to change\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Then("\'SAVE AND CREATE ANOTHER\' button has tooltip with \'Select at least one value to c" +
                    "hange\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User selects \'1803 Rollout\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("\'No change\' content is displayed in \'Criticality\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Then("\'No change\' content is displayed in \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table3.AddRow(new string[] {
                        "No change"});
            table3.AddRow(new string[] {
                        "Core"});
            table3.AddRow(new string[] {
                        "Critical"});
            table3.AddRow(new string[] {
                        "Important"});
            table3.AddRow(new string[] {
                        "Not Important"});
            table3.AddRow(new string[] {
                        "Uncategorised"});
#line 39
 testRunner.Then("following Values are displayed in the \'Criticality\' dropdown:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomations")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS18674")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Universe")]
        public virtual void EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomations()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomationsInternal();
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

        private void EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomationsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomations", null, new string[] {
                        "Evergreen",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS18674",
                        "Cleanup",
                        "Universe"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "AutomationName",
                        "Description",
                        "Active",
                        "StopOnFailedAction",
                        "Scope",
                        "Run"});
            table4.AddRow(new string[] {
                        "18674_Test_Automation",
                        "18674",
                        "true",
                        "false",
                        "All Applications",
                        "Manual"});
#line 50
 testRunner.When("User creates new Automation via API and open it", ((string)(null)), table4, "When ");
#line 53
 testRunner.Then("Automation page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.When("User navigates to the \'Actions\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.When("User clicks \'CREATE ACTION\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("User enters \'18727_Action\' text to \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("User selects \'Update application attributes\' in the \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.When("User selects \'Core\' in the \'Criticality\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("\"Criticality\" content is displayed for \"Task or Field\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.Then("\"Update application attributes\" content is displayed for \"Type\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.Then("\"Core\" content is displayed for \"Value\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("User clicks content from \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("\'Edit Action\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.Then("\'18727_Action\' content is displayed in \'Action Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.Then("\'Update application attributes\' content is displayed in \'Action Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.Then("\'Evergreen\' content is displayed in \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.Then("\'Core\' content is displayed in \'Criticality\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.Then("\'No change\' content is displayed in \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.Then("\'No change\' content is displayed in \'Sticky Compliance\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.Then("\'No change\' content is displayed in \'In Catalog\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

