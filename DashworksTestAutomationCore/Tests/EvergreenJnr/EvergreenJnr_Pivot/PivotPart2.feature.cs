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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_Pivot
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("PivotPart2", Description="\tRuns Pivot block related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_Pivot\\PivotPart2.feature", SourceLine=0)]
    public partial class PivotPart2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PivotPart2.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart2", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChang" +
            "esPage", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS14224",
                "DAS14413",
                "DAS19157",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChangesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14224",
                    "DAS14413",
                    "DAS19157",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChang" +
                    "esPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14224",
                        "DAS14413",
                        "DAS19157",
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
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3502 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3502.AddRow(new string[] {
                            "Compliance"});
#line 13
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3502, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3503 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3503.AddRow(new string[] {
                            "City"});
#line 16
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3503, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3504 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3504.AddRow(new string[] {
                            "Cost Centre"});
#line 19
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3504, "And ");
#line hidden
#line 22
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.When("User creates Pivot list with \"Pivot_DAS_14224\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3505 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table3505.AddRow(new string[] {
                            "Pivot_Project_14224",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 25
 testRunner.And("Project created via API and opened", ((string)(null)), table3505, "And ");
#line hidden
#line 28
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("User navigates to the \'Device Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3506 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3506.AddRow(new string[] {
                            "All Devices"});
                table3506.AddRow(new string[] {
                            "2004 Rollout"});
                table3506.AddRow(new string[] {
                            "Auto: X-Proj Paths Scope"});
                table3506.AddRow(new string[] {
                            "Dependant List Filter - BROKEN LIST"});
                table3506.AddRow(new string[] {
                            "Depot Capacity"});
                table3506.AddRow(new string[] {
                            "Migration Type Capacity"});
                table3506.AddRow(new string[] {
                            "New York - Devices"});
                table3506.AddRow(new string[] {
                            "Using App Saved List Readiness Filter"});
#line 31
 testRunner.Then("User sees that \'Scope\' dropdown contains following options:", ((string)(null)), table3506, "Then ");
#line hidden
#line 41
 testRunner.When("User navigates to the \'User Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3507 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3507.AddRow(new string[] {
                            "All Users"});
                table3507.AddRow(new string[] {
                            "Users with Device Count"});
#line 42
 testRunner.Then("User sees that \'User Scope\' dropdown contains following options:", ((string)(null)), table3507, "Then ");
#line hidden
#line 46
 testRunner.When("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3508 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3508.AddRow(new string[] {
                            "All Applications"});
                table3508.AddRow(new string[] {
                            "Apps with a Vendor"});
#line 47
 testRunner.Then("User sees that \'Application Scope\' dropdown contains following options:", ((string)(null)), table3508, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_ChecksThatPivotTableDisplayedCorrectlyAfterRemovingColum" +
            "n", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13765",
                "DAS13833",
                "DAS13855"}, SourceLine=52)]
        public virtual void EvergreenJnr_DevicesList_ChecksThatPivotTableDisplayedCorrectlyAfterRemovingColumn()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13765",
                    "DAS13833",
                    "DAS13855"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatPivotTableDisplayedCorrectlyAfterRemovingColum" +
                    "n", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13765",
                        "DAS13833",
                        "DAS13855"});
#line 53
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
#line 54
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3509 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3509.AddRow(new string[] {
                            "Compliance"});
#line 57
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3509, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3510 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3510.AddRow(new string[] {
                            "City"});
                table3510.AddRow(new string[] {
                            "Description"});
#line 60
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3510, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3511 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3511.AddRow(new string[] {
                            "Owner Cost Centre"});
#line 64
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3511, "And ");
#line hidden
#line 67
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.When("User removes \"Description\" Column for Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("Save button is inactive for Pivot list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.And("No pivot generated message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnSelectedPage", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS14206",
                "DAS14413",
                "DAS14748",
                "DAS13786",
                "DAS13869",
                "Cleanup"}, SourceLine=74)]
        public virtual void EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnSelectedPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14206",
                    "DAS14413",
                    "DAS14748",
                    "DAS13786",
                    "DAS13869",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnSelectedPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14206",
                        "DAS14413",
                        "DAS14748",
                        "DAS13786",
                        "DAS13869",
                        "Cleanup"});
#line 75
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
#line 76
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3512 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3512.AddRow(new string[] {
                            "Common Name"});
#line 79
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3512, "And ");
#line hidden
#line 82
 testRunner.Then("reset button on main panel is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3513 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3513.AddRow(new string[] {
                            "Building"});
#line 83
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table3513, "When ");
#line hidden
#line 86
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.Then("data in the table is sorted by \"Common Name\" column in ascending order by default" +
                        " for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("User creates Pivot list with \"Pivot_DAS_14206\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("\"Pivot_DAS_14206\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.And("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.Then("\'ADD ROW GROUP\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.And("\'ADD COLUMN\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And("\'ADD VALUE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnCreatedList", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS14206",
                "Cleanup"}, SourceLine=97)]
        public virtual void EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnCreatedList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14206",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnCreatedList", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14206",
                        "Cleanup"});
#line 98
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
#line 99
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.When("User clicks on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.When("User create dynamic list with \"Dynamic_List_DAS14206\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.Then("\"Dynamic_List_DAS14206\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3514 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3514.AddRow(new string[] {
                            "Common Name"});
#line 107
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3514, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3515 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3515.AddRow(new string[] {
                            "Building"});
#line 110
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3515, "And ");
#line hidden
#line 113
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.When("User creates Pivot list with \"PivotList_DAS_14206\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 116
 testRunner.Then("\"PivotList_DAS_14206\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.When("User navigates to the \"Dynamic_List_DAS14206\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 118
 testRunner.Then("\"Dynamic_List_DAS14206\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 120
 testRunner.Then("\'ADD ROW GROUP\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 121
 testRunner.And("\'ADD COLUMN\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And("\'ADD VALUE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3516 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3516.AddRow(new string[] {
                            "Common Name"});
#line 123
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table3516, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3517 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3517.AddRow(new string[] {
                            "Building"});
#line 126
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3517, "And ");
#line hidden
#line 129
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.When("User clicks \'SAVE\' button and select \'SAVE AS NEW PIVOT\' menu button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 132
 testRunner.Then("Pivot Name field is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnRese" +
            "tButton", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS14413"}, SourceLine=134)]
        public virtual void EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnResetButton()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14413"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnRese" +
                    "tButton", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14413"});
#line 135
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
#line 136
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3518 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3518.AddRow(new string[] {
                            "Compliance"});
#line 139
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3518, "And ");
#line hidden
#line 142
 testRunner.Then("reset button on main panel is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3519 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3519.AddRow(new string[] {
                            "City"});
                table3519.AddRow(new string[] {
                            "Description"});
#line 143
 testRunner.When("User selects the following Columns on Pivot:", ((string)(null)), table3519, "When ");
#line hidden
#line 147
 testRunner.Then("reset button on main panel is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3520 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3520.AddRow(new string[] {
                            "Owner Cost Centre"});
#line 148
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table3520, "When ");
#line hidden
#line 151
 testRunner.Then("reset button on main panel is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 152
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 153
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 154
 testRunner.When("User removes \"City\" Column for Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3521 = new TechTalk.SpecFlow.Table(new string[] {
                            "Value"});
                table3521.AddRow(new string[] {
                            "Owner City"});
#line 155
 testRunner.And("User adds the following \"Columns\" on Pivot:", ((string)(null)), table3521, "And ");
#line hidden
#line 158
 testRunner.And("User clicks reset button on main panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 159
 testRunner.Then("\'ADD ROW GROUP\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 160
 testRunner.And("\'ADD COLUMN\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 161
 testRunner.And("\'ADD VALUE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_ChecksTooltipsOnPivot", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS14379",
                "DAS11291",
                "DAS14745",
                "DAS16399",
                "DAS18912"}, SourceLine=163)]
        public virtual void EvergreenJnr_DevicesList_ChecksTooltipsOnPivot()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14379",
                    "DAS11291",
                    "DAS14745",
                    "DAS16399",
                    "DAS18912"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksTooltipsOnPivot", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14379",
                        "DAS11291",
                        "DAS14745",
                        "DAS16399",
                        "DAS18912"});
#line 164
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
#line 165
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 166
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 167
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 168
 testRunner.And("User clicks \'ADD ROW GROUP\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 169
 testRunner.When("\"Compliance\" value is entered into the search box and the selection is clicked on" +
                        " Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 170
 testRunner.Then("\'DONE\' button has tooltip with \'Confirm changes\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 171
 testRunner.Then("back button on Pivot panel have tooltip with \"Close\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 172
 testRunner.When("User clicks \'DONE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3522 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3522.AddRow(new string[] {
                            "City"});
#line 173
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3522, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3523 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3523.AddRow(new string[] {
                            "Owner Cost Centre"});
#line 176
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3523, "And ");
#line hidden
#line 179
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 180
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 181
 testRunner.Then("\"Row Groups\" plus button have tooltip with \"Add row group\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 182
 testRunner.And("\"Columns\" plus button have tooltip with \"Add column\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 183
 testRunner.And("\"Values\" plus button have tooltip with \"Add value\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 184
 testRunner.And("close button for \"Compliance\" chip have tooltip with \"Delete this item\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 185
 testRunner.And("\"City\" chip have tooltip with \"\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
