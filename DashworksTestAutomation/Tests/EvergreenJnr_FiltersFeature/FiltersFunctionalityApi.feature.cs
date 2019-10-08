﻿// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.EvergreenJnr_FiltersFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityApi")]
    public partial class FiltersFunctionalityApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FiltersFunctionalityApi.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityApi", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatOperatorInSelectedFilterIsDisplayedCorrectlyAPI" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FilterFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11550")]
        [NUnit.Framework.CategoryAttribute("DAS11749")]
        [NUnit.Framework.CategoryAttribute("DAS9583")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.TestCaseAttribute("Application", "Application Name", null)]
        [NUnit.Framework.TestCaseAttribute("Application Custom Fields", "App field 1", null)]
        [NUnit.Framework.TestCaseAttribute("Application Custom Fields", "Application Owner", null)]
        [NUnit.Framework.TestCaseAttribute("Application Custom Fields", "General information field 1", null)]
        [NUnit.Framework.TestCaseAttribute("Application Custom Fields", "App field 2", null)]
        public virtual void EvergreenJnr_DevicesList_CheckThatOperatorInSelectedFilterIsDisplayedCorrectlyAPI(string categoryName, string filterName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FilterFeature",
                    "FilterFunctionality",
                    "DAS11550",
                    "DAS11749",
                    "DAS9583",
                    "API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatOperatorInSelectedFilterIsDisplayedCorrectlyAPI" +
                    "", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "OperatorValues"});
            table1.AddRow(new string[] {
                        "Equals"});
            table1.AddRow(new string[] {
                        "Does not equal"});
            table1.AddRow(new string[] {
                        "Contains"});
            table1.AddRow(new string[] {
                        "Does not contain"});
            table1.AddRow(new string[] {
                        "Begins with"});
            table1.AddRow(new string[] {
                        "Does not begin with"});
            table1.AddRow(new string[] {
                        "Ends with"});
            table1.AddRow(new string[] {
                        "Does not end with"});
            table1.AddRow(new string[] {
                        "Empty"});
            table1.AddRow(new string[] {
                        "Not empty"});
#line 9
 testRunner.Then(string.Format("following operators are displayed in \"{0}\" category for \"{1}\" filter on \"Devices\"" +
                        " page:", categoryName, filterName), ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

