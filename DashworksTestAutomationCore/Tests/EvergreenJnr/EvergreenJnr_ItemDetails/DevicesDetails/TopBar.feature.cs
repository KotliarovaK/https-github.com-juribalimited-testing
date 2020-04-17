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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.DevicesDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("TopBar", Description="\tRuns Devices Item Details Top Bar  related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\DevicesDetails\\TopBar.feature", SourceLine=0)]
    public partial class TopBarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TopBar.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TopBar", "\tRuns Devices Item Details Top Bar  related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnDevi" +
            "cesPage", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS15552",
                "DAS16921",
                "DAS16743"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnDevicesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS15552",
                    "DAS16921",
                    "DAS16743"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnDevi" +
                    "cesPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS15552",
                        "DAS16921",
                        "DAS16743"});
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
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User perform search by \"001BAQXT6JWFPI\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2991 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComplianceItems"});
                table2991.AddRow(new string[] {
                            "Overall Compliance"});
                table2991.AddRow(new string[] {
                            "App Compliance"});
                table2991.AddRow(new string[] {
                            "Hardware Compliance"});
#line 15
 testRunner.And("following items are displayed in the top bar:", ((string)(null)), table2991, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnDevice" +
            "sPage", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS14975",
                "DAS15333",
                "DAS16762",
                "DAS17166",
                "DAS17075"}, SourceLine=21)]
        public virtual void EvergreenJnr_DevicesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnDevicesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS14975",
                    "DAS15333",
                    "DAS16762",
                    "DAS17166",
                    "DAS17075"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnDevice" +
                    "sPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS14975",
                        "DAS15333",
                        "DAS16762",
                        "DAS17166",
                        "DAS17075"});
#line 22
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
#line 23
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When("User perform search by \"001BAQXT6JWFPI\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.And("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2992 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComplianceItems"});
                table2992.AddRow(new string[] {
                            "Overall Readiness"});
                table2992.AddRow(new string[] {
                            "App Readiness"});
                table2992.AddRow(new string[] {
                            "Task Readiness"});
#line 29
 testRunner.Then("following items are displayed in the top bar:", ((string)(null)), table2992, "Then ");
#line hidden
#line 34
 testRunner.When("User selects \'USE ME FOR AUTOMATION(DEVICE SCHDLD)\' in the \'Item Details Project\'" +
                        " dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2993 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComplianceItems"});
                table2993.AddRow(new string[] {
                            "Overall Readiness"});
                table2993.AddRow(new string[] {
                            "App Readiness"});
                table2993.AddRow(new string[] {
                            "Task Readiness"});
                table2993.AddRow(new string[] {
                            "Workflow"});
#line 35
 testRunner.Then("following items are displayed in the top bar:", ((string)(null)), table2993, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatValueForUseMeForAutomationProjectIsDisplayedCor" +
            "rectly", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS17166",
                "DAS17355"}, SourceLine=42)]
        public virtual void EvergreenJnr_DevicesList_CheckThatValueForUseMeForAutomationProjectIsDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17166",
                    "DAS17355"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatValueForUseMeForAutomationProjectIsDisplayedCor" +
                    "rectly", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17166",
                        "DAS17355"});
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
#line 44
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User perform search by \"001BAQXT6JWFPI\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.And("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("User selects \'USE ME FOR AUTOMATION(DEVICE SCHDLD)\' in the \'Item Details Project\'" +
                        " dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2994 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComplianceItems",
                            "ColorName"});
                table2994.AddRow(new string[] {
                            "Overall Readiness",
                            "RED"});
                table2994.AddRow(new string[] {
                            "App Readiness",
                            "BLUE"});
                table2994.AddRow(new string[] {
                            "Task Readiness",
                            "PURPLE"});
                table2994.AddRow(new string[] {
                            "Workflow",
                            "Failed"});
#line 50
 testRunner.Then("following items and colors are displayed in the top bar:", ((string)(null)), table2994, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_Devices_CheckThatProjectsSwitcherDoesNotDuplicateItem", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16959"}, SourceLine=57)]
        public virtual void EvergreenJnr_Devices_CheckThatProjectsSwitcherDoesNotDuplicateItem()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16959"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Devices_CheckThatProjectsSwitcherDoesNotDuplicateItem", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16959"});
#line 58
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
#line 59
 testRunner.When("User navigates to the \'Device\' details page for \'00BDM1JUR8IF419\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("Details page for \'00BDM1JUR8IF419\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then("dropdown is not opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2995 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table2995.AddRow(new string[] {
                            "Evergreen"});
#line 62
 testRunner.Then("following Values are not displayed in the \'Item Details Project\' dropdown:", ((string)(null)), table2995, "Then ");
#line hidden
#line 65
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.And("User selects \'Havoc (Big Data)\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then("dropdown is not opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Then("\'Evergreen\' option is first in the \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplaye" +
            "dInAlphabeticalOrder", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16698",
                "DAS17005",
                "DAS15347",
                "DAS16668",
                "DAS16903",
                "DAS16907",
                "DAS16857",
                "DAS17005"}, SourceLine=70)]
        public virtual void EvergreenJnr_DevicesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16698",
                    "DAS17005",
                    "DAS15347",
                    "DAS16668",
                    "DAS16903",
                    "DAS16907",
                    "DAS16857",
                    "DAS17005"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplaye" +
                    "dInAlphabeticalOrder", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16698",
                        "DAS17005",
                        "DAS15347",
                        "DAS16668",
                        "DAS16903",
                        "DAS16907",
                        "DAS16857",
                        "DAS17005"});
#line 71
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
#line 72
 testRunner.When("User navigates to the \'Device\' details page for \'001BAQXT6JWFPI\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.Then("dropdown is not opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.Then("options are sorted in alphabetical order in the \'Item Details Project\' dropdown o" +
                        "n item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.When("User selects \'Devices Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("dropdown is not opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.Then("options are sorted in alphabetical order in the \'Item Details Project\' dropdown o" +
                        "n item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallCompl" +
            "ianceFromTopBarInEvergreenMode", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16857"}, SourceLine=80)]
        public virtual void EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16857"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallCompl" +
                    "ianceFromTopBarInEvergreenMode", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16857"});
#line 81
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
#line 82
 testRunner.When("User navigates to the \'Device\' details page for \'001BAQXT6JWFPI\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.When("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2996 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2996.AddRow(new string[] {
                            "Compliance",
                            "RED"});
#line 85
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2996, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2997 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComplianceItems",
                            "ColorName"});
                table2997.AddRow(new string[] {
                            "Overall Compliance",
                            "RED"});
#line 88
 testRunner.Then("following items and colors are displayed in the top bar:", ((string)(null)), table2997, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallCompl" +
            "ianceFromTopBarInProjectMode", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16857",
                "DAS16928",
                "DAS18405"}, SourceLine=92)]
        public virtual void EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16857",
                    "DAS16928",
                    "DAS18405"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallCompl" +
                    "ianceFromTopBarInProjectMode", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16857",
                        "DAS16928",
                        "DAS18405"});
#line 93
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
#line 94
 testRunner.When("User navigates to the \'Device\' details page for \'001BAQXT6JWFPI\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.When("User selects \'Devices Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                        "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2998 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2998.AddRow(new string[] {
                            "Readiness",
                            "GREY"});
#line 99
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2998, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2999 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComplianceItems",
                            "ColorName"});
                table2999.AddRow(new string[] {
                            "Overall Readiness",
                            "GREY"});
#line 102
 testRunner.Then("following items and colors are displayed in the top bar:", ((string)(null)), table2999, "Then ");
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
