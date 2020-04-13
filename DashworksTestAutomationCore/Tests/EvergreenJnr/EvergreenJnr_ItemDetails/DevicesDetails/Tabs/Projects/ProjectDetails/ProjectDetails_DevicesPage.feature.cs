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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.DevicesDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ProjectDetails_DevicesPage")]
    public partial class ProjectDetails_DevicesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProjectDetails_DevicesPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectDetails_DevicesPage", "\tRuns Projec tDetails tests on Devices Page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_ChecksThatAppOwnerLinkFromProjectDetailsTabForProjectMod" +
            "eRedirectToCorrectTabWithSelectedProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ProjectDetailsTab")]
        [NUnit.Framework.CategoryAttribute("DAS19884")]
        public virtual void EvergreenJnr_DevicesList_ChecksThatAppOwnerLinkFromProjectDetailsTabForProjectModeRedirectToCorrectTabWithSelectedProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_ChecksThatAppOwnerLinkFromProjectDetailsTabForProjectModeRedirectToCorrectTabWithSelectedProjectInternal();
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

        private void EvergreenJnr_DevicesList_ChecksThatAppOwnerLinkFromProjectDetailsTabForProjectModeRedirectToCorrectTabWithSelectedProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatAppOwnerLinkFromProjectDetailsTabForProjectMod" +
                    "eRedirectToCorrectTabWithSelectedProject", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ProjectDetailsTab",
                        "DAS19884"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'Device\' details page for \'H9XKR00M5DLCNU\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \'H9XKR00M5DLCNU\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User selects \'User Evergreen Capacity Project\' in the \'Item Details Project\' drop" +
                    "down with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("User clicks \"Ruth S. Douglas\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("Details page for \'WZW872666 (Ruth S. Douglas)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Then("\'User Evergreen Capacity Project\' content is displayed in \'Item Details Project\' " +
                    "dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.Then("\'Details\' left menu item is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("\'User\' left submenu item is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("\'Projects\' left menu item is collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
