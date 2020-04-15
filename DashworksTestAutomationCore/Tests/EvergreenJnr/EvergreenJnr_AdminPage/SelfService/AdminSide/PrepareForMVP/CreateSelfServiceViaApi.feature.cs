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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateSelfServiceViaApi")]
    public partial class CreateSelfServiceViaApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19187")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19187",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19187",
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
                TechTalk.SpecFlow.Table table1569 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1569.AddRow(new string[] {
                            "1",
                            "TestSelfService_name3_test",
                            "id193803",
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
 testRunner.When("User creates Self Service via API", ((string)(null)), table1569, "When ");
#line hidden
#line 12
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.Then("User deletes the Self Services via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGrid")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS18948")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGrid()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGridInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGridInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS18948",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGrid", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS18948",
                        "API",
                        "Cleanup"});
#line 16
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
                TechTalk.SpecFlow.Table table1570 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1570.AddRow(new string[] {
                            "1",
                            "TestSelfService_name54_test",
                            "id193854",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 17
 testRunner.When("User creates Self Service via API", ((string)(null)), table1570, "When ");
#line hidden
#line 20
 testRunner.Then("User checks the Self Services Grid via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToEnableSelfServiceViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19478")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToEnableSelfServiceViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUserIsAbleToEnableSelfServiceViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUserIsAbleToEnableSelfServiceViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19478",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToEnableSelfServiceViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19478",
                        "API",
                        "Cleanup"});
#line 23
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
                TechTalk.SpecFlow.Table table1571 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1571.AddRow(new string[] {
                            "1",
                            "TestSelfService_name3_test",
                            "id193806",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 24
 testRunner.When("User creates Self Service via API", ((string)(null)), table1571, "When ");
#line hidden
#line 27
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("User enables Self Service with \'id193806\' identifier via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("User deletes the Self Services via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToDisableSelfServiceViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19478")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToDisableSelfServiceViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUserIsAbleToDisableSelfServiceViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUserIsAbleToDisableSelfServiceViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19478",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToDisableSelfServiceViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19478",
                        "API",
                        "Cleanup"});
#line 33
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
                TechTalk.SpecFlow.Table table1572 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1572.AddRow(new string[] {
                            "1",
                            "TestSelfService_name3_test",
                            "id193808",
                            "true",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 34
 testRunner.When("User creates Self Service via API", ((string)(null)), table1572, "When ");
#line hidden
#line 37
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.Then("User disables Self Service with \'id193808\' identifier via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Then("User deletes the Self Services via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServiceViaApi")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19478")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServiceViaApi()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServiceViaApiInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServiceViaApiInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19478",
                    "API",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServiceViaApi", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19478",
                        "API",
                        "Cleanup"});
#line 43
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
                TechTalk.SpecFlow.Table table1573 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1573.AddRow(new string[] {
                            "1",
                            "TestSelfService_name3_test",
                            "id193803",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 44
 testRunner.When("User creates Self Service via API", ((string)(null)), table1573, "When ");
#line hidden
#line 47
 testRunner.Then("User checks the Self Service via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.Then("User deletes the Self Services via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
