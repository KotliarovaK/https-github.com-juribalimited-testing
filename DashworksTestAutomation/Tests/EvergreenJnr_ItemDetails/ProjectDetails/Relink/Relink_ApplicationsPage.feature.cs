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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ProjectDetails.Relink
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Relink_ApplicationsPage")]
    public partial class Relink_ApplicationsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Relink_ApplicationsPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Relink_ApplicationsPage", "\tRuns Relink related tests on Applications Page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDet" +
            "ailsOnApplicationsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Relink")]
        [NUnit.Framework.CategoryAttribute("DAS18002")]
        [NUnit.Framework.CategoryAttribute("DAS18112")]
        [NUnit.Framework.CategoryAttribute("DAS17899")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPageInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDet" +
                    "ailsOnApplicationsPage", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "Relink",
                        "DAS18002",
                        "DAS18112",
                        "DAS17899",
                        "Not_Ready"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 11
 testRunner.When("User navigates to the \'Application\' details page for \'ActiveCGM Browser Netscape " +
                    "Plugin V6P07\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("Details page for \"ActiveCGM Browser Netscape Plugin V6P07\" item is displayed to t" +
                    "he user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When("User switches to the \"USE ME FOR AUTOMATION(USR SCHDLD)\" project in the Top bar o" +
                    "n Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("User navigates to the \"Project Details\" sub-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table1.AddRow(new string[] {
                        "Name",
                        "ActiveCGM Browser Netscape Plugin V6P07"});
            table1.AddRow(new string[] {
                        "App Owner",
                        ""});
#line 16
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table1, "Then ");
#line 20
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("Dialog Pop-up is displayed for User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("\'Resync name\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User enters \'002\' in the \'Application\' autocomplete field and selects \'Altera Qua" +
                    "rtus II Programmer 4.0 4.0\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("User selects state \'true\' for \'Resync name\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Warning message with \"This object will be relinked to the selected Evergreen obje" +
                    "ct in this project\" text is displayed on the Project Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("Success message is displayed and contains \"Application successfully relinked\" tex" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("Details page for \"Altera Quartus II Programmer 4.0 4.0\" item is displayed to the " +
                    "user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table2.AddRow(new string[] {
                        "Name",
                        "ActiveCGM Browser Netscape Plugin V6P07"});
            table2.AddRow(new string[] {
                        "App Owner",
                        ""});
#line 30
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2, "Then ");
#line 34
 testRunner.When("User clicks \'RESYNC\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.When("User clicks \'RESYNC\' button in Dialog Pop-up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("Success message is displayed and contains \"Application successfully resynced\" tex" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table3.AddRow(new string[] {
                        "Name",
                        "Altera Quartus II Programmer 4.0 4.0"});
            table3.AddRow(new string[] {
                        "App Owner",
                        ""});
#line 37
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

