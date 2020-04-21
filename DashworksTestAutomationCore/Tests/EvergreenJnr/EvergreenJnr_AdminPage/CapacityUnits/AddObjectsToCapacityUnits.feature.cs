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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.CapacityUnits
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AddObjectsToCapacityUnits", Description="\tAdd Objects To Capacity Units on Admin page", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AdminPage\\CapacityUnits\\AddObjectsToCapacityUnits" +
        ".feature", SourceLine=0)]
    public partial class AddObjectsToCapacityUnitsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AddObjectsToCapacityUnits.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddObjectsToCapacityUnits", "\tAdd Objects To Capacity Units on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChecksThatDevicesAreAddedCorrectly", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "CapacityUnits",
                "DAS12141",
                "DAS13808",
                "DAS14200",
                "DAS14236",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatDevicesAreAddedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "CapacityUnits",
                    "DAS12141",
                    "DAS13808",
                    "DAS14200",
                    "DAS14236",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatDevicesAreAddedCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12141",
                        "DAS13808",
                        "DAS14200",
                        "DAS14236",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table677 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "IsDefault"});
                table677.AddRow(new string[] {
                            "CapacityUnit12141Devices",
                            "Devices",
                            "false"});
#line 10
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table677, "When ");
#line hidden
#line 13
 testRunner.And("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table678 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table678.AddRow(new string[] {
                            "00I0COBFWHOF27"});
                table678.AddRow(new string[] {
                            "00K4CEEQ737BA4L"});
                table678.AddRow(new string[] {
                            "00KLL9S8NRF0X6"});
                table678.AddRow(new string[] {
                            "00KWQ4J3WKQM0G"});
                table678.AddRow(new string[] {
                            "01ERDGD48UDQKE"});
#line 17
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table678, "When ");
#line hidden
#line 24
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("User selects \'Update capacity unit\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.And("User selects \'CapacityUnit12141Devices\' option from \'Capacity Unit\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("Success message with \"5 updates have been queued\" text is displayed on Action pan" +
                        "el", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then("Page with \'Capacity Units\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.When("User enters \"CapacityUnit12141Devices\" text in the Search field for \"Capacity Uni" +
                        "t\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("\'5\' content is displayed in the \'Devices\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChecksThatUsersAreAddedCorrectly", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "CapacityUnits",
                "DAS12141",
                "DAS13808",
                "DAS14200",
                "DAS14236",
                "Cleanup"}, SourceLine=39)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatUsersAreAddedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "CapacityUnits",
                    "DAS12141",
                    "DAS13808",
                    "DAS14200",
                    "DAS14236",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatUsersAreAddedCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12141",
                        "DAS13808",
                        "DAS14200",
                        "DAS14236",
                        "Cleanup"});
#line 40
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
                TechTalk.SpecFlow.Table table679 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "IsDefault"});
                table679.AddRow(new string[] {
                            "CapacityUnit12141Users",
                            "Users",
                            "false"});
#line 41
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table679, "When ");
#line hidden
#line 44
 testRunner.And("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table680 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table680.AddRow(new string[] {
                            "$231000-3AC04R8AR431"});
                table680.AddRow(new string[] {
                            "$6BE000-SUDQ9614UVO8"});
                table680.AddRow(new string[] {
                            "___ ___"});
                table680.AddRow(new string[] {
                            "002B5DC7D4D34D5C895"});
                table680.AddRow(new string[] {
                            "00BDBAEA57334C7C8F4"});
#line 48
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table680, "When ");
#line hidden
#line 55
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("User selects \'Update capacity unit\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.And("User selects \'CapacityUnit12141Users\' option from \'Capacity Unit\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("Success message with \"5 updates have been queued\" text is displayed on Action pan" +
                        "el", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("Page with \'Capacity Units\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("User enters \"CapacityUnit12141Users\" text in the Search field for \"Capacity Unit\"" +
                        " column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then("\'5\' content is displayed in the \'Users\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChecksThatApplicationsAreAddedCorrectly", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "CapacityUnits",
                "DAS12141",
                "DAS13808",
                "DAS14200",
                "DAS14236",
                "DAS14237",
                "DAS14757",
                "DAS16124",
                "Cleanup"}, SourceLine=70)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatApplicationsAreAddedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "CapacityUnits",
                    "DAS12141",
                    "DAS13808",
                    "DAS14200",
                    "DAS14236",
                    "DAS14237",
                    "DAS14757",
                    "DAS16124",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatApplicationsAreAddedCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12141",
                        "DAS13808",
                        "DAS14200",
                        "DAS14236",
                        "DAS14237",
                        "DAS14757",
                        "DAS16124",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table681 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "IsDefault"});
                table681.AddRow(new string[] {
                            "CapacityUnit12141Applications",
                            "Applications",
                            "false"});
#line 72
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table681, "When ");
#line hidden
#line 75
 testRunner.And("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table682 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table682.AddRow(new string[] {
                            "\"WPF/E\" (codename) Community Technology Preview (Feb 2007)"});
                table682.AddRow(new string[] {
                            "%SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013"});
                table682.AddRow(new string[] {
                            "%SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI"});
                table682.AddRow(new string[] {
                            "0004 - Adobe Acrobat Reader 5.0.5 Francais"});
                table682.AddRow(new string[] {
                            "0036 - Microsoft Access 97 SR-2 English"});
#line 79
 testRunner.When("User select \"Application\" rows in the grid", ((string)(null)), table682, "When ");
#line hidden
#line 86
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("User selects \'Update capacity unit\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.And("User selects \'CapacityUnit12141Applications\' option from \'Capacity Unit\' autocomp" +
                        "lete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.Then("Success message with \"5 updates have been queued\" text is displayed on Action pan" +
                        "el", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.Then("Page with \'Capacity Units\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 98
 testRunner.When("User enters \"CapacityUnit12141Applications\" text in the Search field for \"Capacit" +
                        "y Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.Then("\'5\' content is displayed in the \'Applications\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChecksThatMailboxesAreAddedCorrectly", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "CapacityUnits",
                "DAS12141",
                "DAS13808",
                "DAS14200",
                "DAS14236",
                "Cleanup"}, SourceLine=101)]
        public virtual void EvergreenJnr_AdminPage_ChecksThatMailboxesAreAddedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "CapacityUnits",
                    "DAS12141",
                    "DAS13808",
                    "DAS14200",
                    "DAS14236",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatMailboxesAreAddedCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12141",
                        "DAS13808",
                        "DAS14200",
                        "DAS14236",
                        "Cleanup"});
#line 102
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
                TechTalk.SpecFlow.Table table683 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "IsDefault"});
                table683.AddRow(new string[] {
                            "CapacityUnit12141Mailboxes",
                            "Mailboxes",
                            "false"});
#line 103
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table683, "When ");
#line hidden
#line 106
 testRunner.And("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table684 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table684.AddRow(new string[] {
                            "000F977AC8824FE39B8@bclabs.local"});
                table684.AddRow(new string[] {
                            "002B5DC7D4D34D5C895@bclabs.local"});
                table684.AddRow(new string[] {
                            "003F5D8E1A844B1FAA5@bclabs.local"});
                table684.AddRow(new string[] {
                            "0072B088173449E3A93@bclabs.local"});
                table684.AddRow(new string[] {
                            "00A5B910A1004CF5AC4@bclabs.local"});
#line 110
 testRunner.When("User select \"Email Address\" rows in the grid", ((string)(null)), table684, "When ");
#line hidden
#line 117
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.And("User selects \'Update capacity unit\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 120
 testRunner.And("User selects \'CapacityUnit12141Mailboxes\' option from \'Capacity Unit\' autocomplet" +
                        "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
 testRunner.Then("Success message with \"5 updates have been queued\" text is displayed on Action pan" +
                        "el", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 124
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 125
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 126
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 127
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.Then("Page with \'Capacity Units\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.When("User enters \"CapacityUnit12141Mailboxes\" text in the Search field for \"Capacity U" +
                        "nit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("\'5\' content is displayed in the \'Mailboxes\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
