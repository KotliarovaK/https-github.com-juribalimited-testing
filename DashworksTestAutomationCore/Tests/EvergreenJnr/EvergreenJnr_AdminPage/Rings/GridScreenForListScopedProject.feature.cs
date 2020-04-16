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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Rings
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GridScreenForListScopedProject")]
    public partial class GridScreenForListScopedProjectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GridScreenForListScopedProject.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GridScreenForListScopedProject", "\tCheck grid screen for Devices/Mailboxes Scoped Project", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS12452")]
        [NUnit.Framework.CategoryAttribute("DAS14695")]
        [NUnit.Framework.CategoryAttribute("DAS14697")]
        [NUnit.Framework.CategoryAttribute("DAS15180")]
        [NUnit.Framework.CategoryAttribute("DAS15826")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Rings",
                    "DAS12452",
                    "DAS14695",
                    "DAS14697",
                    "DAS15180",
                    "DAS15826",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS12452",
                        "DAS14695",
                        "DAS14697",
                        "DAS15180",
                        "DAS15826",
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
                TechTalk.SpecFlow.Table table1162 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1162.AddRow(new string[] {
                            "14695_Project",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1162, "When ");
#line hidden
#line 13
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("\'\' content is displayed in the \'Devices\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1163 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1163.AddRow(new string[] {
                            "Ring"});
                table1163.AddRow(new string[] {
                            ""});
                table1163.AddRow(new string[] {
                            "Default"});
                table1163.AddRow(new string[] {
                            "Devices"});
#line 15
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table1163, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1164 = new TechTalk.SpecFlow.Table(new string[] {
                            "options"});
                table1164.AddRow(new string[] {
                            "Edit"});
                table1164.AddRow(new string[] {
                            "Duplicate"});
                table1164.AddRow(new string[] {
                            "Move to top"});
                table1164.AddRow(new string[] {
                            "Move to bottom"});
                table1164.AddRow(new string[] {
                            "Move to position"});
#line 21
 testRunner.When("User clicks Cog-menu for \'Unassigned\' item in the \'Ring\' column and sees followin" +
                        "g cog-menu options", ((string)(null)), table1164, "When ");
#line hidden
#line 28
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When("User enters \'14695_Ring\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("\'The ring has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.When("User enters \'Ring_Test\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.When("User clicks Default Ring checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.When("User opens \'Ring\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then("Column Settings was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.When("User select \"Display Order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1165 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1165.AddRow(new string[] {
                            "1"});
                table1165.AddRow(new string[] {
                            "2"});
                table1165.AddRow(new string[] {
                            "3"});
#line 43
 testRunner.Then("User sees following Display order on the Automation page", ((string)(null)), table1165, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1166 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table1166.AddRow(new string[] {
                            "Unassigned"});
                table1166.AddRow(new string[] {
                            "14695_Ring"});
                table1166.AddRow(new string[] {
                            "Ring_Test"});
#line 48
 testRunner.Then("Content in the \'Ring\' column is equal to", ((string)(null)), table1166, "Then ");
#line hidden
#line 53
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("data in table is sorted by \'Ring\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then("data in table is sorted by \'Ring\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1167 = new TechTalk.SpecFlow.Table(new string[] {
                            "options"});
                table1167.AddRow(new string[] {
                            "Edit"});
                table1167.AddRow(new string[] {
                            "Duplicate"});
                table1167.AddRow(new string[] {
                            "Move to top"});
                table1167.AddRow(new string[] {
                            "Move to bottom"});
                table1167.AddRow(new string[] {
                            "Move to position"});
                table1167.AddRow(new string[] {
                            "Set default"});
                table1167.AddRow(new string[] {
                            "Delete"});
#line 57
 testRunner.When("User clicks Cog-menu for \'Unassigned\' item in the \'Ring\' column and sees followin" +
                        "g cog-menu options", ((string)(null)), table1167, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1168 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table1168.AddRow(new string[] {
                            "Unassigned"});
#line 66
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table1168, "When ");
#line hidden
#line 69
 testRunner.And("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("\'This ring will be permanently deleted and any objects within it reassigned to th" +
                        "e default ring\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS12452")]
        [NUnit.Framework.CategoryAttribute("DAS14705")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Rings",
                    "DAS12452",
                    "DAS14705",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS12452",
                        "DAS14705",
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
 testRunner.When("User navigates to \"Email Migration\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("Page with \'Email Migration\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("\'729\' content is displayed in the \'Mailboxes\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1169 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1169.AddRow(new string[] {
                            "Ring"});
                table1169.AddRow(new string[] {
                            ""});
                table1169.AddRow(new string[] {
                            "Default"});
                table1169.AddRow(new string[] {
                            "Mailboxes"});
#line 80
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table1169, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1170 = new TechTalk.SpecFlow.Table(new string[] {
                            "options"});
                table1170.AddRow(new string[] {
                            "Edit"});
                table1170.AddRow(new string[] {
                            "Duplicate"});
                table1170.AddRow(new string[] {
                            "Move to top"});
                table1170.AddRow(new string[] {
                            "Move to bottom"});
                table1170.AddRow(new string[] {
                            "Move to position"});
#line 86
 testRunner.When("User clicks Cog-menu for \'Unassigned\' item in the \'Ring\' column and sees followin" +
                        "g cog-menu options", ((string)(null)), table1170, "When ");
#line hidden
#line 93
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.When("User enters \'14705_Ring\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.Then("\'The ring has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 98
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.When("User enters \'Ring_Test\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.Then("data in table is sorted by \'Ring\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1171 = new TechTalk.SpecFlow.Table(new string[] {
                            "options"});
                table1171.AddRow(new string[] {
                            "Edit"});
                table1171.AddRow(new string[] {
                            "Duplicate"});
                table1171.AddRow(new string[] {
                            "Move to top"});
                table1171.AddRow(new string[] {
                            "Move to bottom"});
                table1171.AddRow(new string[] {
                            "Move to position"});
                table1171.AddRow(new string[] {
                            "Set default"});
                table1171.AddRow(new string[] {
                            "Delete"});
#line 104
 testRunner.When("User clicks Cog-menu for \'14705_Ring\' item in the \'Ring\' column and sees followin" +
                        "g cog-menu options", ((string)(null)), table1171, "When ");
#line hidden
#line 113
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.Then("data in table is sorted by \'Ring\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1172 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table1172.AddRow(new string[] {
                            "Ring_Test"});
                table1172.AddRow(new string[] {
                            "14705_Ring"});
#line 115
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table1172, "When ");
#line hidden
#line 119
 testRunner.And("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 121
 testRunner.Then("\'These rings will be permanently deleted and any objects within them reassigned t" +
                        "o the default ring\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 122
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
