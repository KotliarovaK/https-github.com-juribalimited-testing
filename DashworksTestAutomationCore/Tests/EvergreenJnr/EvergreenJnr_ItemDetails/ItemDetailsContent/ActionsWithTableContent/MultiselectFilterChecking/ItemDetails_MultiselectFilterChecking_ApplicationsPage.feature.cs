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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent.ActionsWithTableContent.MultiselectFilterChecking
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_MultiselectFilterChecking_ApplicationsPage")]
    public partial class ItemDetails_MultiselectFilterChecking_ApplicationsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetails_MultiselectFilterChecking_ApplicationsPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_MultiselectFilterChecking_ApplicationsPage", "\tRuns Multiselect Filter Checking for Applications Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
            "heRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17761")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPageInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17761",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
                    "heRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17761",
                        "Zion_NewGrid"});
#line 9
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
#line 10
 testRunner.When("User navigates to the \'Application\' details page for \'Accessible FormNet Fill 2.2" +
                        "\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("Details page for \'Accessible FormNet Fill 2.2\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User navigates to the \'Advertisements\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("\'TRUE\' content is displayed in the \'Active\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3121 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3121.AddRow(new string[] {
                            "True"});
#line 14
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Active\' c" +
                        "olumn:", ((string)(null)), table3121, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
            "heRelatedMultiselectFilterForMsiTabOnApplicationsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17761")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPageInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17761",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
                    "heRelatedMultiselectFilterForMsiTabOnApplicationsPage", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17761",
                        "Zion_NewGrid"});
#line 19
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
#line 20
 testRunner.When("User navigates to the \'Application\' details page for \'Accessible FormNet Fill 2.2" +
                        "\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("Details page for \'Accessible FormNet Fill 2.2\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.When("User navigates to the \'MSI\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.When("User navigates to the \'MSI Files\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.And("User opens \'File Name\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("User select \"Product Code\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then("\'AOK Import\' content is displayed in the \'Source\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Then("\'ChangeBASE AOK\' content is displayed in the \'Source Type\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("\'GREEN\' content is displayed in the \'Compliance\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3122 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3122.AddRow(new string[] {
                            "AOK Import"});
#line 31
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Source\' c" +
                        "olumn:", ((string)(null)), table3122, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3123 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3123.AddRow(new string[] {
                            "ChangeBASE AOK"});
#line 34
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Source Ty" +
                        "pe\' column:", ((string)(null)), table3123, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3124 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3124.AddRow(new string[] {
                            "GREEN"});
#line 37
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Complianc" +
                        "e\' column:", ((string)(null)), table3124, "Then ");
#line hidden
#line 40
 testRunner.When("User navigates to the \'AOK\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.Then("\'AOK Import\' content is displayed in the \'Source\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.Then("\'Windows 7\' content is displayed in the \'AOK Report\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.Then("\'GREEN\' content is displayed in the \'Compatibility\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3125 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3125.AddRow(new string[] {
                            "AOK Import"});
#line 44
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Source\' c" +
                        "olumn:", ((string)(null)), table3125, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3126 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3126.AddRow(new string[] {
                            "Windows 7"});
#line 47
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'AOK Repor" +
                        "t\' column:", ((string)(null)), table3126, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3127 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3127.AddRow(new string[] {
                            "GREEN"});
#line 50
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Compatibi" +
                        "lity\' column:", ((string)(null)), table3127, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
            "heRelatedMultiselectFilterForDistributionTabOnApplicationsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17761")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPageInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17761",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
                    "heRelatedMultiselectFilterForDistributionTabOnApplicationsPage", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17761",
                        "Zion_NewGrid"});
#line 55
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
#line 56
 testRunner.When("User navigates to the \'Application\' details page for \'Accessible FormNet Fill 2.2" +
                        "\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("Details page for \'Accessible FormNet Fill 2.2\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.When("User navigates to the \'Distribution\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.When("User navigates to the \'Devices\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("\'TRUE\' content is displayed in the \'Installed\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then("\'UNKNOWN\' content is displayed in the \'Used\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.Then("\'TRUE\' content is displayed in the \'Entitled\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3128 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3128.AddRow(new string[] {
                            "True"});
#line 63
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Installed" +
                        "\' column:", ((string)(null)), table3128, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3129 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3129.AddRow(new string[] {
                            "Unknown"});
#line 66
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Used\' col" +
                        "umn:", ((string)(null)), table3129, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3130 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3130.AddRow(new string[] {
                            "True"});
#line 69
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Entitled\'" +
                        " column:", ((string)(null)), table3130, "Then ");
#line hidden
#line 72
 testRunner.When("User navigates to the \'AD\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("\'UK\' content is displayed in the \'Domain\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3131 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3131.AddRow(new string[] {
                            "AU"});
                table3131.AddRow(new string[] {
                            "CA"});
                table3131.AddRow(new string[] {
                            "UK"});
                table3131.AddRow(new string[] {
                            "US-E"});
                table3131.AddRow(new string[] {
                            "US-W"});
#line 74
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Domain\' c" +
                        "olumn:", ((string)(null)), table3131, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
