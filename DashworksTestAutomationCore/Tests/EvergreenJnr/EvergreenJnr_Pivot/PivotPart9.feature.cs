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
    [TechTalk.SpecRun.FeatureAttribute("PivotPart9", Description="\tRuns Pivot block related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_Pivot\\PivotPart9.feature", SourceLine=0)]
    public partial class PivotPart9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PivotPart9.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart9", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDispl" +
            "ayInTheCorrectOrder", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13862",
                "DAS14373"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrder()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13862",
                    "DAS14373"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDispl" +
                    "ayInTheCorrectOrder", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13862",
                        "DAS14373"});
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
                TechTalk.SpecFlow.Table table3665 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3665.AddRow(new string[] {
                            "Application Compliance"});
#line 13
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3665, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3666 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3666.AddRow(new string[] {
                            "Operating System"});
                table3666.AddRow(new string[] {
                            "Service Pack or Build"});
#line 16
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3666, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3667 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3667.AddRow(new string[] {
                            "Owner City"});
#line 20
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3667, "And ");
#line hidden
#line 23
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.And("data in the table is sorted by \"Application Compliance\" column in ascending order" +
                        " by default for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13786",
                "DAS13868"}, SourceLine=27)]
        public virtual void EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13786",
                    "DAS13868"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13786",
                        "DAS13868"});
#line 28
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
#line 29
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3668 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3668.AddRow(new string[] {
                            "Compliance"});
#line 32
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3668, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3669 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3669.AddRow(new string[] {
                            "Group Count"});
#line 35
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3669, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3670 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3670.AddRow(new string[] {
                            "Device Count"});
#line 38
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3670, "And ");
#line hidden
#line 41
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("numeric data in table is sorted by \"Compliance\" column in descending order for th" +
                        "e Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13863",
                "DAS14374"}, SourceLine=45)]
        public virtual void EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13863",
                    "DAS14374"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14374"});
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
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3671 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3671.AddRow(new string[] {
                            "EmailMigra: Status"});
#line 50
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3671, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3672 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3672.AddRow(new string[] {
                            "Country"});
#line 53
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3672, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3673 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3673.AddRow(new string[] {
                            "City"});
#line 56
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3673, "And ");
#line hidden
#line 59
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3674 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3674.AddRow(new string[] {
                            "Not Onboarded"});
                table3674.AddRow(new string[] {
                            "Onboarded"});
                table3674.AddRow(new string[] {
                            "Forecast"});
                table3674.AddRow(new string[] {
                            "Targeted"});
                table3674.AddRow(new string[] {
                            "Scheduled"});
                table3674.AddRow(new string[] {
                            "Migrated"});
#line 60
 testRunner.Then("Pivot left-pinned column content is displayed in following order:", ((string)(null)), table3674, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13863",
                "DAS14374",
                "DAS15376"}, SourceLine=69)]
        public virtual void EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13863",
                    "DAS14374",
                    "DAS15376"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14374",
                        "DAS15376"});
#line 70
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
#line 71
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3675 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3675.AddRow(new string[] {
                            "2004: Status"});
#line 74
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3675, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3676 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3676.AddRow(new string[] {
                            "Country"});
#line 77
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3676, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3677 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3677.AddRow(new string[] {
                            "City"});
#line 80
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3677, "And ");
#line hidden
#line 83
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3678 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3678.AddRow(new string[] {
                            "Not Onboarded"});
                table3678.AddRow(new string[] {
                            "Onboarded"});
#line 84
 testRunner.Then("Pivot left-pinned column content is displayed in following order:", ((string)(null)), table3678, "Then ");
#line hidden
#line 88
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3679 = new TechTalk.SpecFlow.Table(new string[] {
                            "StartDateInclusive",
                            "EndDateInclusive"});
                table3679.AddRow(new string[] {
                            "25 Apr 2018",
                            "02 May 2018"});
#line 90
 testRunner.When("User add \"Last Logon Date\" filter where type is \"Between\" without added column an" +
                        "d Date options", ((string)(null)), table3679, "When ");
#line hidden
#line 93
 testRunner.Then("\"(Last Logon Date between (2018-04-25, 2018-05-02))\" text is displayed in filter " +
                        "container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13863",
                "DAS14374"}, SourceLine=95)]
        public virtual void EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13863",
                    "DAS14374"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14374"});
#line 96
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
#line 97
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3680 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3680.AddRow(new string[] {
                            "ComputerSc: Status"});
#line 100
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3680, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3681 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3681.AddRow(new string[] {
                            "Country"});
#line 103
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3681, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3682 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3682.AddRow(new string[] {
                            "City"});
#line 106
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3682, "And ");
#line hidden
#line 109
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3683 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3683.AddRow(new string[] {
                            "Not Onboarded"});
                table3683.AddRow(new string[] {
                            "Onboarded"});
                table3683.AddRow(new string[] {
                            "Forecast"});
                table3683.AddRow(new string[] {
                            "Scheduled"});
                table3683.AddRow(new string[] {
                            "Migrated"});
                table3683.AddRow(new string[] {
                            "Complete"});
#line 110
 testRunner.Then("Pivot left-pinned column content is displayed in following order:", ((string)(null)), table3683, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_Pivot",
                "Pivot",
                "DAS13863",
                "DAS14375"}, SourceLine=119)]
        public virtual void EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13863",
                    "DAS14375"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14375"});
#line 120
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
#line 121
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 122
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 123
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3684 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table3684.AddRow(new string[] {
                            "Building"});
#line 124
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table3684, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3685 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table3685.AddRow(new string[] {
                            "ComputerSc: Status"});
#line 127
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3685, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3686 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3686.AddRow(new string[] {
                            "Region"});
#line 130
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3686, "And ");
#line hidden
#line 133
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
 testRunner.Then("Empty value is displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3687 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3687.AddRow(new string[] {
                            "Not Onboarded"});
                table3687.AddRow(new string[] {
                            "Onboarded"});
                table3687.AddRow(new string[] {
                            "Forecast"});
                table3687.AddRow(new string[] {
                            "Scheduled"});
                table3687.AddRow(new string[] {
                            "Migrated"});
                table3687.AddRow(new string[] {
                            "Complete"});
#line 135
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table3687, "Then ");
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
