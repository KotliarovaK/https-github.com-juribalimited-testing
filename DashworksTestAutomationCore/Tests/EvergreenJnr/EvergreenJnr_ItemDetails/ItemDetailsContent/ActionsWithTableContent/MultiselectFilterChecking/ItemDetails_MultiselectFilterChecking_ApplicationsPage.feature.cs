﻿// ------------------------------------------------------------------------------
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
    [TechTalk.SpecRun.FeatureAttribute("ItemDetails_MultiselectFilterChecking_ApplicationsPage", Description="\tRuns Multiselect Filter Checking for Applications Page related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ItemDetailsContent\\ActionsWithTableCo" +
        "ntent\\MultiselectFilterChecking\\ItemDetails_MultiselectFilterChecking_Applicatio" +
        "nsPage.feature", SourceLine=0)]
    public partial class ItemDetails_MultiselectFilterChecking_ApplicationsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetails_MultiselectFilterChecking_ApplicationsPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_MultiselectFilterChecking_ApplicationsPage", "\tRuns Multiselect Filter Checking for Applications Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
            "heRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS17761",
                "Zion_NewGrid"}, SourceLine=8)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage()
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
                TechTalk.SpecFlow.Table table3077 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3077.AddRow(new string[] {
                            "True"});
#line 14
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Active\' c" +
                        "olumn:", ((string)(null)), table3077, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
            "heRelatedMultiselectFilterForMsiTabOnApplicationsPage", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS17761",
                "Zion_NewGrid"}, SourceLine=18)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPage()
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
                TechTalk.SpecFlow.Table table3078 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3078.AddRow(new string[] {
                            "AOK Import"});
#line 31
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Source\' c" +
                        "olumn:", ((string)(null)), table3078, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3079 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3079.AddRow(new string[] {
                            "ChangeBASE AOK"});
#line 34
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Source Ty" +
                        "pe\' column:", ((string)(null)), table3079, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3080 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3080.AddRow(new string[] {
                            "GREEN"});
#line 37
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Complianc" +
                        "e\' column:", ((string)(null)), table3080, "Then ");
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
                TechTalk.SpecFlow.Table table3081 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3081.AddRow(new string[] {
                            "AOK Import"});
#line 44
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Source\' c" +
                        "olumn:", ((string)(null)), table3081, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3082 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3082.AddRow(new string[] {
                            "Windows 7"});
#line 47
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'AOK Repor" +
                        "t\' column:", ((string)(null)), table3082, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3083 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3083.AddRow(new string[] {
                            "GREEN"});
#line 50
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Compatibi" +
                        "lity\' column:", ((string)(null)), table3083, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInT" +
            "heRelatedMultiselectFilterForDistributionTabOnApplicationsPage", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS17761",
                "Zion_NewGrid"}, SourceLine=54)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPage()
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
                TechTalk.SpecFlow.Table table3084 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3084.AddRow(new string[] {
                            "True"});
#line 63
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Installed" +
                        "\' column:", ((string)(null)), table3084, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3085 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3085.AddRow(new string[] {
                            "Unknown"});
#line 66
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Used\' col" +
                        "umn:", ((string)(null)), table3085, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3086 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3086.AddRow(new string[] {
                            "True"});
#line 69
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Entitled\'" +
                        " column:", ((string)(null)), table3086, "Then ");
#line hidden
#line 72
 testRunner.When("User navigates to the \'AD\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("\'UK\' content is displayed in the \'Domain\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3087 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3087.AddRow(new string[] {
                            "AU"});
                table3087.AddRow(new string[] {
                            "CA"});
                table3087.AddRow(new string[] {
                            "UK"});
                table3087.AddRow(new string[] {
                            "US-E"});
                table3087.AddRow(new string[] {
                            "US-W"});
#line 74
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Domain\' c" +
                        "olumn:", ((string)(null)), table3087, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
