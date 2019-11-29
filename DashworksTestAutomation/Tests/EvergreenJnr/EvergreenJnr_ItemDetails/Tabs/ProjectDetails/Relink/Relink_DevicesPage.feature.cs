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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.Tabs.ProjectDetails.Relink
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Relink_DevicesPage")]
    public partial class Relink_DevicesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Relink_DevicesPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Relink_DevicesPage", "\tRuns Relink related tests on Devices Page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsO" +
            "nDevicesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Relink")]
        [NUnit.Framework.CategoryAttribute("DAS17655")]
        [NUnit.Framework.CategoryAttribute("DAS17831")]
        [NUnit.Framework.CategoryAttribute("DAS18002")]
        [NUnit.Framework.CategoryAttribute("DAS18112")]
        [NUnit.Framework.CategoryAttribute("DAS18284")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPageInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsO" +
                    "nDevicesPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "Relink",
                        "DAS17655",
                        "DAS17831",
                        "DAS18002",
                        "DAS18112",
                        "DAS18284",
                        "Cleanup",
                        "Not_Run"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 11
 testRunner.When("User navigates to the \'Device\' details page for \'06RIV0KXJMHJ1K\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("Details page for \"06RIV0KXJMHJ1K\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When("User switches to the \"Havoc (Big Data)\" project in the Top bar on Item details pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Data"});
            table1.AddRow(new string[] {
                        "Name",
                        "06RIV0KXJMHJ1K"});
            table1.AddRow(new string[] {
                        "Device Owner",
                        "Tonia T. Mason"});
#line 16
 testRunner.Then("User verifies data in the fields on details page", ((string)(null)), table1, "Then ");
#line 20
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("\'Resync owner\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("\'Resync apps\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("\'Resync name\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("User enters \'QSFCLB19N5524S\' in the \'Device\' autocomplete field and selects \'QSFC" +
                    "LB19N5524S\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.When("User selects state \'true\' for \'Resync owner\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.When("User selects state \'true\' for \'Resync apps\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.When("User selects state \'true\' for \'Resync name\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.When("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Warning message with \"This object will be relinked to the selected Evergreen obje" +
                    "ct in this project\" text is displayed on the Project Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("Success message is displayed and contains \"Device successfully relinked\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When("User waits for three seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("Details page for \"QSFCLB19N5524S\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Data"});
            table2.AddRow(new string[] {
                        "Name",
                        "06RIV0KXJMHJ1K"});
            table2.AddRow(new string[] {
                        "Device Owner",
                        "Tonia T. Mason"});
#line 36
 testRunner.And("User verifies data in the fields on details page", ((string)(null)), table2, "And ");
#line 40
 testRunner.When("User clicks \'RESYNC\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And("User clicks \'RESYNC\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("Success message is displayed and contains \"The Evergreen owner of this Device has" +
                    " been queued for onboarding into this project, the change in ownership for this " +
                    "Device will show once this is complete\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("User waits for three seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Data"});
            table3.AddRow(new string[] {
                        "Name",
                        "QSFCLB19N5524S"});
            table3.AddRow(new string[] {
                        "Device Owner",
                        "Gerard C. Kelly"});
#line 45
 testRunner.Then("User verifies data in the fields on details page", ((string)(null)), table3, "Then ");
#line 49
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.And("User enters \'06RIV0KXJMHJ1K\' in the \'Device\' autocomplete field and selects \'06RI" +
                    "V0KXJMHJ1K\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("Success message is displayed and contains \"Device successfully relinked\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When("User waits for three seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.When("User navigates to the \'User\' details page for \'ZHC394580\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.When("User switches to the \"Havoc (Big Data)\" project in the Top bar on Item details pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheO" +
            "bjectWasSuccessfullyRelinked")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Relink")]
        [NUnit.Framework.CategoryAttribute("DAS18043")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinked()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinkedInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinkedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheO" +
                    "bjectWasSuccessfullyRelinked", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "Relink",
                        "DAS18043",
                        "Not_Ready"});
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 67
 testRunner.When("User navigates to the \'Device\' details page for \'FISC5NOXFB8Q7M\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("Details page for \"FISC5NOXFB8Q7M\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("User switches to the \"Havoc (Big Data)\" project in the Top bar on Item details pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.And("User enters \'5XW9ZW6O6HG7IP9\' in the \'Device\' autocomplete field and selects \'5XW" +
                    "9ZW6O6HG7IP9\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.Then("Warning message with \"This object will be relinked to the selected Evergreen obje" +
                    "ct in this project\" text is displayed on the Project Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("Success message is displayed and contains \"The Evergreen owner of this Device has" +
                    " been queued for onboarding into this project, the change in ownership for this " +
                    "Device will show once this is complete\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User navigates to the \'Projects Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("Success message is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.When("User clicks \'RELINK\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.And("User enters \'FISC5NOXFB8Q7M\' in the \'Device\' autocomplete field and selects \'FISC" +
                    "5NOXFB8Q7M\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("User clicks \'RELINK\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.When("User waits for three seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.When("User clicks \"Sherri R. Bautista\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User clicks \'OFFBOARD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.When("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("User clicks \'OFFBOARD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
