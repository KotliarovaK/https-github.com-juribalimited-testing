﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Projects
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ProjectsPart13")]
    public partial class ProjectsPart13Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProjectsPart13.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectsPart13", "\tRuns Projects related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void ScenarioTearDown()
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
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatOnlyFilteredListObjectsAreUsedAsAScopeOfProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12892")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        public virtual void EvergreenJnr_AdminPage_CheckThatOnlyFilteredListObjectsAreUsedAsAScopeOfProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatOnlyFilteredListObjectsAreUsedAsAScopeOfProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12892",
                        "Cleanup",
                        "Cleanup",
                        "Projects"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table1.AddRow(new string[] {
                        "Windows Vista"});
#line 14
 testRunner.When("User add \"Operating System\" filter where type is \"Equals\" with added column and L" +
                    "ookup option", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table2.AddRow(new string[] {
                        "Desktop"});
#line 17
 testRunner.When("User Add And \"Device Type\" filter where type is \"Equals\" with added column and Lo" +
                    "okup option", ((string)(null)), table2, "When ");
#line 20
 testRunner.Then("\"222\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("User create dynamic list with \"DynamicList4811\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("\"DynamicList4811\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table3.AddRow(new string[] {
                        "DevicesProject1982",
                        "DynamicList4811",
                        "None",
                        "Standalone Project"});
#line 23
 testRunner.When("Project created via API and opened", ((string)(null)), table3, "When ");
#line 26
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("\"Devices to add (0 of 222 selected)\" is displayed to the user in the Project Scop" +
                    "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatProjectNameEditedInSeniorIsUpdatedInAdminTab")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("UpdatingName")]
        [NUnit.Framework.CategoryAttribute("DAS13096")]
        [NUnit.Framework.CategoryAttribute("DAS15994")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatProjectNameEditedInSeniorIsUpdatedInAdminTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatProjectNameEditedInSeniorIsUpdatedInAdminTab", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "UpdatingName",
                        "DAS13096",
                        "DAS15994",
                        "Cleanup",
                        "Projects"});
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table4.AddRow(new string[] {
                        "10_Project13096",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 33
 testRunner.When("Project created via API and opened", ((string)(null)), table4, "When ");
#line 36
 testRunner.Then("Page with \'10_Project13096\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.When("User click on Back button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.When("User enters \"10_Project13096\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("\'10_Project13096\' content is displayed in the \'Project\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("User clicks \'Projects\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.When("User navigate to \"10_Project13096\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("Project with \"10_Project13096\" name is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.And("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.When("User updates Project Name to \"1_Project13096 upd on Senior\" on Senior", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.When("User clicks \"Update\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("Success message is displayed with \"Project was successfully updated\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.When("User navigate to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("User enters \"1_Project13096 upd on Senior\" text in the Search field for \"Project\"" +
                    " column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("\'1_Project13096 upd on Senior\' content is displayed in the \'Project\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("User removes selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateFo" +
            "rDynamicList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12776")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForDynamicList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateFo" +
                    "rDynamicList", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12776",
                        "Cleanup"});
#line 60
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 61
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User clicks on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.And("User create dynamic list with \"DynamicList5588\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("\"DynamicList5588\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table5.AddRow(new string[] {
                        "TestProject12776",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 66
 testRunner.When("Project created via API and opened", ((string)(null)), table5, "When ");
#line 69
 testRunner.Then("Page with \'TestProject12776\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table6.AddRow(new string[] {
                        "SZ46M6IS71DPZ1"});
#line 73
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table6, "And ");
#line 76
 testRunner.And("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table7.AddRow(new string[] {
                        "ACD252468 (Nicolas O. Mc Millan)"});
#line 78
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table7, "And ");
#line 81
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("\'1 device will be added, 1 user will be added\' text is displayed on warning inlin" +
                    "e tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.Then("multiselect is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("multiselect is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("\'2 objects queued for onboarding, 0 objects offboarded\' text is displayed on succ" +
                    "ess inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.Then("\'UPDATE ALL CHANGES\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.And("\"Devices to add (0 of 17278 selected)\" is displayed to the user in the Project Sc" +
                    "ope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("multiselect is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.Then("\"Users to add (0 of 14628 selected)\" is displayed to the user in the Project Scop" +
                    "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.Then("multiselect is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.When("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table8.AddRow(new string[] {
                        "AAK881049 (Miguel W. Owen)"});
#line 95
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table8, "And ");
#line 98
 testRunner.Then("\'UPDATE ALL CHANGES\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.When("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table9.AddRow(new string[] {
                        "00SH8162NAS524"});
#line 101
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table9, "And ");
#line 104
 testRunner.Then("\'UPDATE ALL CHANGES\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateFo" +
            "rStaticList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12776")]
        [NUnit.Framework.CategoryAttribute("DAS13973")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForStaticList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateFo" +
                    "rStaticList", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12776",
                        "DAS13973",
                        "Cleanup"});
#line 108
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table10.AddRow(new string[] {
                        "00CFE13AAE104724AF5"});
            table10.AddRow(new string[] {
                        "00BDBAEA57334C7C8F4"});
            table10.AddRow(new string[] {
                        "000F977AC8824FE39B8"});
#line 109
 testRunner.When("User create static list with \"StaticList12776\" name on \"Users\" page with followin" +
                    "g items", ((string)(null)), table10, "When ");
#line 114
 testRunner.Then("\"StaticList12776\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table11.AddRow(new string[] {
                        "TestProject12777",
                        "All Users",
                        "None",
                        "Clone from Evergreen to Project"});
#line 115
 testRunner.When("Project created via API and opened", ((string)(null)), table11, "When ");
#line 118
 testRunner.Then("Page with \'TestProject12777\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Then("\'Clone evergreen buckets to project buckets\' content is displayed in \'Buckets\' dr" +
                    "opdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.When("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.Then("\'Clone evergreen capacity units to project capacity units\' content is displayed i" +
                    "n \'Capacity Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table12.AddRow(new string[] {
                        "00BDBAEA57334C7C8F4 (Basa, Rogelio)"});
            table12.AddRow(new string[] {
                        "00CFE13AAE104724AF5 (Hardieway, Linda)"});
#line 125
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table12, "And ");
#line 129
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.Then("\'2 users will be added\' text is displayed on warning inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("multiselect is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.When("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.Then("multiselect is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("\'2 objects queued for onboarding, 0 objects offboarded\' text is displayed on succ" +
                    "ess inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.Then("\'UPDATE ALL CHANGES\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.Then("\"Users to add (0 of 41337 selected)\" is displayed to the user in the Project Scop" +
                    "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.When("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.Then("multiselect is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
 testRunner.Then("multiselect is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.When("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table13.AddRow(new string[] {
                        "000F977AC8824FE39B8 (Spruill, Shea)"});
#line 144
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table13, "And ");
#line 147
 testRunner.Then("\'UPDATE ALL CHANGES\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

