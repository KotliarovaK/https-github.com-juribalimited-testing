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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateSelfServiceViaApi")]
    public partial class CreateSelfServiceViaApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateSelfServiceViaApi.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateSelfServiceViaApi", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19187")]
        [NUnit.Framework.CategoryAttribute("API")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19187",
                        "API"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId"});
            table1.AddRow(new string[] {
                        "1",
                        "TestSelfService_name33",
                        "id191839",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "0"});
#line 9
 testRunner.When("User creates Self Service via API", ((string)(null)), table1, "When ");
#line 12
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateSelfServiceViaApiAndGet")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19187")]
        [NUnit.Framework.CategoryAttribute("API")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateSelfServiceViaApiAndGet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateSelfServiceViaApiAndGet", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19187",
                        "API"});
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId"});
            table2.AddRow(new string[] {
                        "1",
                        "TestSelfService_name28",
                        "id191828",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "0"});
#line 16
    testRunner.When("User creates Self Service via API", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "OldName",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ScopeId"});
            table3.AddRow(new string[] {
                        "TestSelfService_name28",
                        "Updated_name1",
                        "id19187",
                        "true",
                        "1"});
#line 19
 testRunner.When("User updates Self Service via API", ((string)(null)), table3, "When ");
#line 22
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

