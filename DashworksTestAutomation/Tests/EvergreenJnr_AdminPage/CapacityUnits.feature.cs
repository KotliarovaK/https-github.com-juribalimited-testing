// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CapacityUnits")]
    public partial class CapacityUnitsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacityUnits", "\tRuns Capacity Units related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS13169")]
        public virtual void EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault", new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS13169"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Capacity Units\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Capacity Units\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("\"Unassigned\" text is displayed in the table content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Evergreen Unit is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Evergreen\" checkbox is checked in the filter dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
