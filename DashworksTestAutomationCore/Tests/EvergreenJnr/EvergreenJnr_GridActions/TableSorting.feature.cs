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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_GridActions
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("TableSorting", new string[] {
            "retry:1"}, Description="\tRuns Table Sorting related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_GridActions\\TableSorting.feature", SourceLine=1)]
    public partial class TableSortingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "retry:1"};
        
#line 1 "TableSorting.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TableSorting", "\tRuns Table Sorting related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
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
#line 5
#line hidden
#line 6
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckSortByDateFunctionality", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS10612"}, SourceLine=9)]
        public virtual void EvergreenJnr_DevicesList_CheckSortByDateFunctionality()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS10612"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortByDateFunctionality", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2763 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2763.AddRow(new string[] {
                            "Boot Up Date"});
                table2763.AddRow(new string[] {
                            "Windows7Mi: Computer Information ---- Text fill; Text fill; \\ Date & Time Task"});
#line 11
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table2763, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2764 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table2764.AddRow(new string[] {
                            "Android",
                            "22"});
#line 15
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table2764, "Then ");
#line hidden
#line 18
 testRunner.When("User clicks on \'Boot Up Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("date in table is sorted by \'Boot Up Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("User clicks on \'Boot Up Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("date in table is sorted by \'Boot Up Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2765 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table2765.AddRow(new string[] {
                            "Windows 10",
                            "16,969"});
#line 22
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table2765, "Then ");
#line hidden
#line 25
 testRunner.When("User clicks on \'Windows7Mi: Computer Information ---- Text fill; Text fill; \\ Dat" +
                        "e & Time Task\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("date in table is sorted by \'Windows7Mi: Computer Information ---- Text fill; Text" +
                        " fill; \\ Date & Time Task\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.When("User clicks on \'Windows7Mi: Computer Information ---- Text fill; Text fill; \\ Dat" +
                        "e & Time Task\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("date in table is sorted by \'Windows7Mi: Computer Information ---- Text fill; Text" +
                        " fill; \\ Date & Time Task\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS10612"}, SourceLine=30)]
        public virtual void EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS10612"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
#line 31
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2766 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2766.AddRow(new string[] {
                            "Barry\'sUse: Audit & Configuration \\ Package Delivery Date"});
#line 32
 testRunner.When("User add following columns using URL to the \"Applications\" page:", ((string)(null)), table2766, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2767 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table2767.AddRow(new string[] {
                            "Software",
                            "94"});
#line 35
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table2767, "Then ");
#line hidden
#line 38
 testRunner.When("User clicks on \'Barry\'sUse: Audit & Configuration \\ Package Delivery Date\' column" +
                        " header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("date in table is sorted by \'Barry\'sUse: Audit & Configuration \\ Package Delivery " +
                        "Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.When("User clicks on \'Barry\'sUse: Audit & Configuration \\ Package Delivery Date\' column" +
                        " header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.Then("date in table is sorted by \'Barry\'sUse: Audit & Configuration \\ Package Delivery " +
                        "Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckSortByDateFunctionality", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS10612"}, SourceLine=43)]
        public virtual void EvergreenJnr_MailboxesList_CheckSortByDateFunctionality()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS10612"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckSortByDateFunctionality", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
#line 44
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2768 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2768.AddRow(new string[] {
                            "Created Date"});
                table2768.AddRow(new string[] {
                            "EmailMigra: Pre-Migration \\ Scheduled date"});
#line 45
 testRunner.When("User add following columns using URL to the \"Mailboxes\" page:", ((string)(null)), table2768, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2769 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table2769.AddRow(new string[] {
                            "Office",
                            "38"});
#line 49
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table2769, "Then ");
#line hidden
#line 52
 testRunner.When("User clicks on \'Created Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("date in table is sorted by \'Created Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("User clicks on \'Created Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("date in table is sorted by \'Created Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.When("User clicks on \'EmailMigra: Pre-Migration \\ Scheduled date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("date in table is sorted by \'EmailMigra: Pre-Migration \\ Scheduled date\' column in" +
                        " descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.When("User clicks on \'EmailMigra: Pre-Migration \\ Scheduled date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then("date in table is sorted by \'EmailMigra: Pre-Migration \\ Scheduled date\' column in" +
                        " ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckSortByDateFunctionality", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS10612"}, SourceLine=61)]
        public virtual void EvergreenJnr_UsersList_CheckSortByDateFunctionality()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS10612"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckSortByDateFunctionality", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS10612"});
#line 62
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2770 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2770.AddRow(new string[] {
                            "Last Logon Date"});
                table2770.AddRow(new string[] {
                            "Barry\'sUse: Project Dates \\ Migrated Date"});
#line 63
 testRunner.When("User add following columns using URL to the \"Users\" page:", ((string)(null)), table2770, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2771 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table2771.AddRow(new string[] {
                            "Tim",
                            "147"});
#line 67
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table2771, "Then ");
#line hidden
#line 70
 testRunner.When("User clicks on \'Last Logon Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("date in table is sorted by \'Last Logon Date\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.When("User clicks on \'Last Logon Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("date in table is sorted by \'Last Logon Date\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.When("User clicks on \'Barry\'sUse: Project Dates \\ Migrated Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then("date in table is sorted by \'Barry\'sUse: Project Dates \\ Migrated Date\' column in " +
                        "descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.When("User clicks on \'Barry\'sUse: Project Dates \\ Migrated Date\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("date in table is sorted by \'Barry\'sUse: Project Dates \\ Migrated Date\' column in " +
                        "ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianc" +
            "eColumnOnDevicesList", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS11568"}, SourceLine=79)]
        public virtual void EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianceColumnOnDevicesList()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS11568"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianc" +
                    "eColumnOnDevicesList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_GridActions",
                        "TableSorting",
                        "DAS11568"});
#line 80
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
#line 5
this.FeatureBackground();
#line hidden
#line 81
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2772 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2772.AddRow(new string[] {
                            "Owner Compliance"});
#line 85
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2772, "When ");
#line hidden
#line 88
 testRunner.Then("\"17,279\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("User clicks on \'Owner Compliance\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("color data is sorted by \'Owner Compliance\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.Then("\"17,279\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate(string listName, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS11951"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate", null, @__tags);
#line 94
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
#line 5
this.FeatureBackground();
#line hidden
#line 95
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in descending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS11951"}, SourceLine=103)]
        public virtual void EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate_Devices()
        {
#line 94
this.EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate("Devices", "Hostname", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS11951"}, SourceLine=103)]
        public virtual void EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate_Users()
        {
#line 94
this.EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate("Users", "Domain", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate, Application" +
            "s", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS11951"}, SourceLine=103)]
        public virtual void EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate_Applications()
        {
#line 94
this.EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate("Applications", "Version", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS11951"}, SourceLine=103)]
        public virtual void EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate_Mailboxes()
        {
#line 94
this.EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate("Mailboxes", "Owner Display Name", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList(string listName, string columnName, string allListName, string dynamicListName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_GridActions",
                    "TableSorting",
                    "DAS12545",
                    "DAS14287",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList", null, @__tags);
#line 110
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
#line 5
this.FeatureBackground();
#line hidden
#line 111
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 113
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2773 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2773.AddRow(new string[] {
                            string.Format("{0}", columnName)});
#line 115
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table2773, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2774 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2774.AddRow(new string[] {
                            string.Format("{0}", columnName)});
#line 118
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table2774, "Then ");
#line hidden
#line 121
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 122
 testRunner.Then(string.Format("numeric data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 123
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", dynamicListName, listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", dynamicListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 125
 testRunner.When(string.Format("User navigates to the \"{0}\" list", allListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 126
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", allListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.When(string.Format("User navigates to the \"{0}\" list", dynamicListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", dynamicListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2775 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2775.AddRow(new string[] {
                            string.Format("{0}", columnName)});
#line 129
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table2775, "Then ");
#line hidden
#line 132
 testRunner.Then(string.Format("numeric data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 133
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS12545",
                "DAS14287",
                "Cleanup"}, SourceLine=136)]
        public virtual void EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList_Devices()
        {
#line 110
this.EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList("Devices", "ComputerSc: Team ID", "All Devices", "DynamicList4857", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS12545",
                "DAS14287",
                "Cleanup"}, SourceLine=136)]
        public virtual void EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList_Users()
        {
#line 110
this.EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList("Users", "UserEvergr: Team ID", "All Users", "DynamicList1857", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS12545",
                "DAS14287",
                "Cleanup"}, SourceLine=136)]
        public virtual void EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList_Applications()
        {
#line 110
this.EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList("Applications", "ComputerSc: Project ID", "All Applications", "DynamicList2857", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_GridActions",
                "TableSorting",
                "DAS12545",
                "DAS14287",
                "Cleanup"}, SourceLine=136)]
        public virtual void EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList_Mailboxes()
        {
#line 110
this.EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList("Mailboxes", "EmailMigra: Team ID", "All Mailboxes", "DynamicList3857", ((string[])(null)));
#line hidden
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
