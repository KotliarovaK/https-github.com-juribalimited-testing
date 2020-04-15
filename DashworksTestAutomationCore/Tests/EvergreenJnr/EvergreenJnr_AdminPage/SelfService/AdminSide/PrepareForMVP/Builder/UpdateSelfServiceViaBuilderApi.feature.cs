// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.Builder
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UpdateSelfServiceViaBuilderApi")]
    public partial class UpdateSelfServiceViaBuilderApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "UpdateSelfServiceViaBuilderApi.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdateSelfServiceViaBuilderApi", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUsderIsAbleToUpdateSelfServicePageViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUsderIsAbleToUpdateSelfServicePageViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUsderIsAbleToUpdateSelfServicePageViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUsderIsAbleToUpdateSelfServicePageViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19061",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUsderIsAbleToUpdateSelfServicePageViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "API",
                        "Cleanup"});
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table1464 = new TechTalk.SpecFlow.Table(new string[] {
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
                            "ScopeId",
                            "scopeName"});
                table1464.AddRow(new string[] {
                            "1",
                            "SsTest_DAS19061_3",
                            "id1906115",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 9
 testRunner.When("User creates Self Service via API", ((string)(null)), table1464, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1465 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "ObjectTypeId",
                            "DisplayName",
                            "ShowInSelfService"});
                table1465.AddRow(new string[] {
                            "id1906115",
                            "TestPageSs3",
                            "3",
                            "TestPageSsDisplay3",
                            "true"});
#line 12
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1465, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1466 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "ObjectTypeId",
                            "DisplayName",
                            "ShowInSelfService"});
                table1466.AddRow(new string[] {
                            "id1906115",
                            "UpdatedName_3",
                            "3",
                            "TestPageSsDisplay_New4",
                            "false"});
#line 15
 testRunner.When("User updates \'TestPageSs3\' Self Service Page via API", ((string)(null)), table1466, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1467 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1467.AddRow(new string[] {
                            "id1906115",
                            "UpdatedName_3",
                            "TestPageSsDisplay_New4",
                            "false"});
#line 18
 testRunner.Then("Self Service Page with below data is created", ((string)(null)), table1467, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
