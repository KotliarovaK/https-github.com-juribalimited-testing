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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent.ActionsWithTableContent
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ColumnGroupingCheck", Description="\tRuns related tests for Column Grouping Check", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ItemDetailsContent\\ActionsWithTableCo" +
        "ntent\\ColumnGroupingCheck.feature", SourceLine=0)]
    public partial class ColumnGroupingCheckFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ColumnGroupingCheck.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ColumnGroupingCheck", "\tRuns related tests for Column Grouping Check", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatItIsPossibleToApplyTheGroupingToTheMigrationColum" +
            "nInTheSelectedProjectOnDevicesTab", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS20645",
                "DAS20614",
                "Zion_NewGrid",
                "Wormhole"}, SourceLine=9)]
        public virtual void EvergreenJnr_UsersList_CheckThatItIsPossibleToApplyTheGroupingToTheMigrationColumnInTheSelectedProjectOnDevicesTab()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20645",
                    "DAS20614",
                    "Zion_NewGrid",
                    "Wormhole"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatItIsPossibleToApplyTheGroupingToTheMigrationColum" +
                    "nInTheSelectedProjectOnDevicesTab", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20645",
                        "DAS20614",
                        "Zion_NewGrid",
                        "Wormhole"});
#line 10
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
#line 11
 testRunner.When("User navigates to the \'User\' details page for \'TOM576324\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("Details page for \'TOM576324\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("User selects \'Project 000 M Computer Scheduled\' in the \'Item Details Project\' dro" +
                        "pdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.And("User navigates to the \'Devices\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3068 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table3068.AddRow(new string[] {
                            "Device Type"});
                table3068.AddRow(new string[] {
                            "Owner Display Name"});
                table3068.AddRow(new string[] {
                            "Operating System"});
#line 15
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Hostname\' co" +
                        "lumn:", ((string)(null)), table3068, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3069 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3069.AddRow(new string[] {
                            "RED"});
#line 20
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Migration" +
                        "\' column:", ((string)(null)), table3069, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3070 = new TechTalk.SpecFlow.Table(new string[] {
                            "Checkboxes",
                            "State"});
                table3070.AddRow(new string[] {
                            "Migration",
                            "true"});
#line 23
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table3070, "When ");
#line hidden
#line 26
 testRunner.Then("Grid is grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnDeviceMembersT" +
            "abForGroupPage", new string[] {
                "Evergreen",
                "Groups",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS20672",
                "Zion_NewGrid",
                "Wormhole"}, SourceLine=29)]
        public virtual void EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnDeviceMembersTabForGroupPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20672",
                    "Zion_NewGrid",
                    "Wormhole"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnDeviceMembersT" +
                    "abForGroupPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20672",
                        "Zion_NewGrid",
                        "Wormhole"});
#line 30
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
#line 31
 testRunner.When("User type \"GSMS-ReportViewer\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("User clicks on \"GSMS-ReportViewer\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.And("Details page for \'GSMS-ReportViewer\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.When("User navigates to the \'Members\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.When("User navigates to the \'User Members\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3071 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table3071.AddRow(new string[] {
                            "Key"});
#line 36
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Username\' co" +
                        "lumn:", ((string)(null)), table3071, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3072 = new TechTalk.SpecFlow.Table(new string[] {
                            "Checkboxes",
                            "State"});
                table3072.AddRow(new string[] {
                            "Key",
                            "true"});
#line 39
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table3072, "When ");
#line hidden
#line 42
 testRunner.Then("Grid is grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByAdvertisementColumnOnAppl" +
            "icationsTabForGroupPage", new string[] {
                "Evergreen",
                "Groups",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS20671",
                "Zion_NewGrid",
                "Wormhole"}, SourceLine=45)]
        public virtual void EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByAdvertisementColumnOnApplicationsTabForGroupPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20671",
                    "Zion_NewGrid",
                    "Wormhole"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByAdvertisementColumnOnAppl" +
                    "icationsTabForGroupPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20671",
                        "Zion_NewGrid",
                        "Wormhole"});
#line 46
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
#line 47
 testRunner.When("User type \"GSMS-ReportViewer\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("User clicks on \"GSMS-ReportViewer\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.And("Details page for \'GSMS-ReportViewer\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.When("User navigates to the \'Applications\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3073 = new TechTalk.SpecFlow.Table(new string[] {
                            "Checkboxes",
                            "State"});
                table3073.AddRow(new string[] {
                            "Advertisement",
                            "true"});
#line 52
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table3073, "When ");
#line hidden
#line 55
 testRunner.Then("Grid is grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatDataInTheGridIsCropedByRingColumnOnOwnerProject" +
            "sSummaryTabForDevicesPage", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS20643",
                "Zion_NewGrid",
                "Wormhole"}, SourceLine=58)]
        public virtual void EvergreenJnr_DevicesList_CheckThatDataInTheGridIsCropedByRingColumnOnOwnerProjectsSummaryTabForDevicesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20643",
                    "Zion_NewGrid",
                    "Wormhole"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatDataInTheGridIsCropedByRingColumnOnOwnerProject" +
                    "sSummaryTabForDevicesPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20643",
                        "Zion_NewGrid",
                        "Wormhole"});
#line 59
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
#line 60
 testRunner.When("User navigates to the \'Device\' details page for the item with \'9114\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("Details page for \'RWAV0TLVTYON4G\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.When("User navigates to the \'Owner Projects Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3074 = new TechTalk.SpecFlow.Table(new string[] {
                            "Checkboxes",
                            "State"});
                table3074.AddRow(new string[] {
                            "Ring",
                            "true"});
#line 64
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table3074, "When ");
#line hidden
#line 67
 testRunner.Then("Grid is grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnApplicationsTa" +
            "bCollectionsSubTabForGroupPage", new string[] {
                "Evergreen",
                "Groups",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS20683",
                "Zion_NewGrid",
                "X_Ray"}, SourceLine=70)]
        public virtual void EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnApplicationsTabCollectionsSubTabForGroupPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20683",
                    "Zion_NewGrid",
                    "X_Ray"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnApplicationsTa" +
                    "bCollectionsSubTabForGroupPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20683",
                        "Zion_NewGrid",
                        "X_Ray"});
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
 testRunner.When("User type \"GSMS-ReportViewer\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("User clicks on \"GSMS-ReportViewer\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.And("Details page for \'GSMS-ReportViewer\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User navigates to the \'Collections\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3075 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table3075.AddRow(new string[] {
                            "Key"});
#line 77
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Collection\' " +
                        "column:", ((string)(null)), table3075, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3076 = new TechTalk.SpecFlow.Table(new string[] {
                            "Checkboxes",
                            "State"});
                table3076.AddRow(new string[] {
                            "Key",
                            "true"});
#line 80
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table3076, "When ");
#line hidden
#line 83
 testRunner.Then("Grid is grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
