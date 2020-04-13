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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.AdminSide.PrepareForMVP.Builder
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CerateSelfServicePageViaBuilder")]
    public partial class CerateSelfServicePageViaBuilderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CerateSelfServicePageViaBuilderApi.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CerateSelfServicePageViaBuilder", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19061",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApi", null, new string[] {
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
                TechTalk.SpecFlow.Table table1215 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1215.AddRow(new string[] {
                            "1",
                            "SsTest_DAS19061_1",
                            "id1906113",
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
 testRunner.When("User creates Self Service via API", ((string)(null)), table1215, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1216 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "ObjectTypeId",
                            "DisplayName",
                            "ShowInSelfService"});
                table1216.AddRow(new string[] {
                            "id1906113",
                            "TestPageSs",
                            "3",
                            "TestPageSsDisplay",
                            "true"});
#line 12
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1216, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1217 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1217.AddRow(new string[] {
                            "id1906113",
                            "TestPageSs",
                            "TestPageSsDisplay",
                            "true"});
#line 15
 testRunner.Then("Self Service Page with below data is created", ((string)(null)), table1217, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19061",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "API",
                        "Cleanup"});
#line 20
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
                TechTalk.SpecFlow.Table table1218 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1218.AddRow(new string[] {
                            "1",
                            "SsTest_DAS19061_2",
                            "id1906114",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 21
 testRunner.When("User creates Self Service via API", ((string)(null)), table1218, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1219 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "ObjectTypeId",
                            "DisplayName",
                            "ShowInSelfService"});
                table1219.AddRow(new string[] {
                            "id1906114",
                            "TestPageSs2",
                            "3",
                            "TestPageSsDisplay",
                            "false"});
#line 24
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1219, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1220 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1220.AddRow(new string[] {
                            "id1906114",
                            "TestPageSs2",
                            "TestPageSsDisplay",
                            "false"});
#line 27
 testRunner.Then("Self Service Page with below data is created", ((string)(null)), table1220, "Then ");
#line hidden
#line 30
 testRunner.When("User deletes \'TestPageSs2\' Self Service Page with \'id1906114\' identifier via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("\'id1906114\' Self Service does not contains any pages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
