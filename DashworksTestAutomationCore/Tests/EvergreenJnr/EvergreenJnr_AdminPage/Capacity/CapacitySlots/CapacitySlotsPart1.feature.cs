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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Capacity.CapacitySlots
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CapacitySlotsPart1", Description="\tRuns Capacity related tests on Admin page", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AdminPage\\Capacity\\CapacitySlots\\CapacitySlotsPar" +
        "t1.feature", SourceLine=0)]
    public partial class CapacitySlotsPart1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CapacitySlotsPart1.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacitySlotsPart1", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "Capacity",
                "Slots",
                "DAS13171",
                "DAS13432",
                "DAS13430",
                "DAS13412",
                "DAS13493",
                "DAS13375",
                "DAS13711",
                "DAS17271",
                "DAS18918",
                "Cleanup",
                "Universe"}, SourceLine=8)]
        public virtual void EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Slots",
                    "DAS13171",
                    "DAS13432",
                    "DAS13430",
                    "DAS13412",
                    "DAS13493",
                    "DAS13375",
                    "DAS13711",
                    "DAS17271",
                    "DAS18918",
                    "Cleanup",
                    "Universe"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13171",
                        "DAS13432",
                        "DAS13430",
                        "DAS13412",
                        "DAS13493",
                        "DAS13375",
                        "DAS13711",
                        "DAS17271",
                        "DAS18918",
                        "Cleanup",
                        "Universe"});
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
                TechTalk.SpecFlow.Table table694 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table694.AddRow(new string[] {
                            "ProjectForCapacity13171",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table694, "When ");
#line hidden
#line 13
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("User clicks \'CREATE SLOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.When("User clicks on \'Unlimited\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("\'Unlimited\' textbox is focused", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.Then("\'\' content is displayed in \'Unlimited\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.Then("\"All Capacity Units\" content is displayed in \"Capacity Units\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table695 = new TechTalk.SpecFlow.Table(new string[] {
                            "SlotName",
                            "DisplayName",
                            "CapacityType"});
                table695.AddRow(new string[] {
                            "CapacitySlot1",
                            "DAS13432",
                            "Capacity Units"});
#line 21
 testRunner.And("User creates new Slot", ((string)(null)), table695, "And ");
#line hidden
#line 24
 testRunner.Then("\'Your capacity slot has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table696 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table696.AddRow(new string[] {
                            "Monday"});
                table696.AddRow(new string[] {
                            "Tuesday"});
#line 25
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Capacity Slo" +
                        "t\' column:", ((string)(null)), table696, "When ");
#line hidden
#line 29
 testRunner.Then("\'All Capacity Units\' content is displayed in the \'Capacity Units\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When("User clicks \'CREATE SLOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("User enters \'CapacitySlot1\' text to \'Slot Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("\'A slot already exists with this name\' error message is displayed for \'Slot Name\'" +
                        " field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table697 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "SlotName",
                            "DisplayName"});
                table697.AddRow(new string[] {
                            "ProjectForCapacity13171",
                            "UniqueNameSlot",
                            "DAS13432"});
#line 34
 testRunner.When("User creates new Slot via Api", ((string)(null)), table697, "When ");
#line hidden
#line 37
 testRunner.And("User navigates to newly created Slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("User enters \'NewSlotName\' text to \'Slot Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.When("User enters \'NewDisplayName\' text to \'Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.Then("tooltip is not displayed for \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("\'The capacity slot details have been updated\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.And("\'NewSlotName\' content is displayed in the \'Capacity Slot\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.When("User clicks on \'Capacity Slot\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then("data in table is sorted by \'Capacity Slot\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.When("User clicks on \'Capacity Slot\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("data in table is sorted by \'Capacity Slot\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table698 = new TechTalk.SpecFlow.Table(new string[] {
                            "SlotName",
                            "DisplayName",
                            "CapacityType"});
                table698.AddRow(new string[] {
                            "CapacitySlot2",
                            "DAS13432",
                            "Teams and Paths"});
#line 50
 testRunner.When("User creates new Slot", ((string)(null)), table698, "When ");
#line hidden
#line 53
 testRunner.Then("\'Your capacity slot has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table699 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table699.AddRow(new string[] {
                            "Monday"});
                table699.AddRow(new string[] {
                            "Tuesday"});
#line 54
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Capacity Slo" +
                        "t\' column:", ((string)(null)), table699, "When ");
#line hidden
#line 58
 testRunner.When("User clicks String Filter button for \"Capacity Units\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.When("User selects \"All Capacity Units\" checkbox from String Filter on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("\'No units\' text is displayed in the filter dropdown for the \'Capacity Units\' colu" +
                        "mn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSam" +
            "eSlotWithSameDate", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "Capacity",
                "Override_Dates",
                "DAS13780",
                "Cleanup"}, SourceLine=62)]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSameSlotWithSameDate()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Override_Dates",
                    "DAS13780",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSam" +
                    "eSlotWithSameDate", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Override_Dates",
                        "DAS13780",
                        "Cleanup"});
#line 63
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
                TechTalk.SpecFlow.Table table700 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table700.AddRow(new string[] {
                            "ProjectDAS13780",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 64
 testRunner.When("Project created via API and opened", ((string)(null)), table700, "When ");
#line hidden
                TechTalk.SpecFlow.Table table701 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "SlotName",
                            "DisplayName",
                            "SlotAvailableFrom",
                            "SlotAvailableTo"});
                table701.AddRow(new string[] {
                            "ProjectDAS13780",
                            "SlotDAS13780_1",
                            "13780_1",
                            "17 Oct 2018",
                            "18 Oct 2018"});
                table701.AddRow(new string[] {
                            "ProjectDAS13780",
                            "SlotDAS13780_2",
                            "13780_2",
                            "17 Oct 2018",
                            "18 Oct 2018"});
#line 67
 testRunner.When("User creates new Slot via Api", ((string)(null)), table701, "When ");
#line hidden
#line 71
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("User navigates to the \'Slots\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("User navigates to the \'Override Dates\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("User enters \'17 Oct 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("User enters \'17 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("User selects \'SlotDAS13780_1\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And("User enters \'0\' text to \'Capacity\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("User enters \'17 Oct 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And("User enters \'17 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("User selects \'SlotDAS13780_2\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.And("User enters \'0\' text to \'Capacity\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("User enters \'17 Oct 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("User enters \'17 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And("User selects \'All\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.Then("\'An override date already exists with this date range\' error message is displayed" +
                        " for \'Override Start Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.Then("\'An override date already exists with this date range\' error message is displayed" +
                        " for \'Override End Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateCapacityUnitOrSlotUsingTheSameN" +
            "ameWithDifferentCase", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "Capacity",
                "Slots",
                "Units",
                "DAS13789",
                "Cleanup"}, SourceLine=95)]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateCapacityUnitOrSlotUsingTheSameNameWithDifferentCase()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Slots",
                    "Units",
                    "DAS13789",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateCapacityUnitOrSlotUsingTheSameN" +
                    "ameWithDifferentCase", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "Units",
                        "DAS13789",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table702 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table702.AddRow(new string[] {
                            "ProjectDAS13789",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 97
 testRunner.When("Project created via API and opened", ((string)(null)), table702, "When ");
#line hidden
                TechTalk.SpecFlow.Table table703 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "SlotName",
                            "DisplayName",
                            "SlotAvailableFrom",
                            "SlotAvailableTo"});
                table703.AddRow(new string[] {
                            "ProjectDAS13789",
                            "capacityslotDAS13789",
                            "DAS13779slot",
                            "28 Oct 2018",
                            "29 Oct 2018"});
#line 100
 testRunner.When("User creates new Slot via Api", ((string)(null)), table703, "When ");
#line hidden
#line 103
 testRunner.And("User navigates to newly created Slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("User enters \'CAPACITYSLOTdas13789\' text to \'Slot Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And("User enters \'das13779SLOT\' text to \'Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("\'The capacity slot details have been updated\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.When("User navigates to the \'Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.And("User clicks \'CREATE PROJECT CAPACITY UNIT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.And("User enters \'capacityunitDAS13789\' text to \'Capacity Unit Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("User enters \'13789\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("User enters \'CAPACITYUINTdas13789\' text to \'Capacity Unit Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.Then("\'The capacity unit details have been updated\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOn" +
            "UpdateCapacitySlotPage", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "Capacity",
                "Slots",
                "DAS13824",
                "DAS14250",
                "Cleanup"}, SourceLine=118)]
        public virtual void EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOnUpdateCapacitySlotPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Slots",
                    "DAS13824",
                    "DAS14250",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOn" +
                    "UpdateCapacitySlotPage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Slots",
                        "DAS13824",
                        "DAS14250",
                        "Cleanup"});
#line 119
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
                TechTalk.SpecFlow.Table table704 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table704.AddRow(new string[] {
                            "ProjectForCapacityDAS13824",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 120
 testRunner.When("Project created via API and opened", ((string)(null)), table704, "When ");
#line hidden
                TechTalk.SpecFlow.Table table705 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "SlotName",
                            "DisplayName",
                            "SlotAvailableFrom",
                            "SlotAvailableTo"});
                table705.AddRow(new string[] {
                            "ProjectForCapacityDAS13824",
                            "CapacitySlotDAS13824",
                            "DAS13824",
                            "29 Oct 2018",
                            "30 Oct 2018"});
#line 123
 testRunner.When("User creates new Slot via Api", ((string)(null)), table705, "When ");
#line hidden
#line 126
 testRunner.And("User navigates to newly created Slot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.When("User clears \'Slot Available From\' textbox with backspaces", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.When("User clears \'Slot Available To\' textbox with backspaces", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 129
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.When("User clicks content from \"Capacity Slot\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 131
 testRunner.Then("\'\' content is displayed in \'Slot Available From\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 132
 testRunner.Then("\'\' content is displayed in \'Slot Available To\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
