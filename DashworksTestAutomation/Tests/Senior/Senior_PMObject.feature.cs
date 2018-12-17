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
namespace DashworksTestAutomation.Tests.Senior
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Projects_PMObject")]
    public partial class Projects_PMObjectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Projects_PMObject", "\tRuns Projects Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            testRunner.Given("User is logged in to the Projects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.Retry(2)]
        [NUnit.Framework.DescriptionAttribute("Projects_CheckThatErrorIsNotDisplayedWhenUsedDDLForApplicationsTabOnPMObjectPage")]
        [NUnit.Framework.CategoryAttribute("ProjectsOnSenior")]
        [NUnit.Framework.CategoryAttribute("PMObject")]
        [NUnit.Framework.CategoryAttribute("Applications_tab")]
        [NUnit.Framework.CategoryAttribute("DAS12695")]
        [NUnit.Framework.CategoryAttribute("DAS14003")]
        public virtual void Projects_CheckThatErrorIsNotDisplayedWhenUsedDDLForApplicationsTabOnPMObjectPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Projects_CheckThatErrorIsNotDisplayedWhenUsedDDLForApplicationsTabOnPMObjectPage", new string[] {
                        "ProjectsOnSenior",
                        "PMObject",
                        "Applications_tab",
                        "DAS12695",
                        "DAS14003"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User navigates to \"61085\" Object on PMObject page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Project Object\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"Change Capacity Unit\" button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigate to \"Applications\" tab on PMObject page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Application tab content is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Current State\" View State on Applications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Application tab content is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Target State\" View State on Applications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Application tab content is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Alphabetical\" View Type on Applications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Application tab content is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Consolidated\" View Type on Applications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Application tab content is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User select \"Readiness\" View Type on Applications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Application tab content is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
