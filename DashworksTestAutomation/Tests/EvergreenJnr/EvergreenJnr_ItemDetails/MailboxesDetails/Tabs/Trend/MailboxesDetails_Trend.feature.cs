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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.MailboxesDetails.Tabs.Trend
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MailboxesDetails_Trend")]
    public partial class MailboxesDetails_TrendFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MailboxesDetails_Trend.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MailboxesDetails_Trend", "\tRuns related tests for Trend tab", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisp" +
            "layed")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS12245")]
        [NUnit.Framework.CategoryAttribute("DAS12321")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayedInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisp" +
                    "layed", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS12245",
                        "DAS12321"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'Mailbox\' details page for \'julia.bell@juriba.com\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.When("User navigates to the \'Trend\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("Highcharts graphic is displayed on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("User navigates to the \'Trend\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

