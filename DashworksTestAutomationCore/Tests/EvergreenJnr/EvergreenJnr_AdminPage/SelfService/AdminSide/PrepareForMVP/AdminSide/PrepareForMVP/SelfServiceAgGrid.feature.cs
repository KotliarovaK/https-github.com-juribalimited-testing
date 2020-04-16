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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.AdminSide.PrepareForMVP
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SelfServiceGrid")]
    public partial class SelfServiceGridFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SelfServiceAgGrid.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SelfServiceGrid", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckGeneralViewOfSelfServiceAgGrid")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19392")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckGeneralViewOfSelfServiceAgGrid()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19392",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckGeneralViewOfSelfServiceAgGrid", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19392",
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
                TechTalk.SpecFlow.Table table1408 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceId",
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "ObjectType",
                            "ObjectTypeId",
                            "StartDate",
                            "EndDate",
                            "SelfServiceURL",
                            "AllowAnonymousUsers",
                            "ScopeId",
                            "scopeName"});
                table1408.AddRow(new string[] {
                            "1",
                            "ATestSelfService_name1",
                            "id193851",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1408.AddRow(new string[] {
                            "2",
                            "BTestSelfService_name2",
                            "id193852",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1408.AddRow(new string[] {
                            "3",
                            "CTestSelfService_name3",
                            "id193853",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1408.AddRow(new string[] {
                            "4",
                            "DTestSelfService_name4",
                            "id193854",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1408.AddRow(new string[] {
                            "5",
                            "FTestSelfService_name5",
                            "id193855",
                            "true",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 10
    testRunner.When("User creates Self Service via API", ((string)(null)), table1408, "When ");
#line hidden
#line 17
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1409 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1409.AddRow(new string[] {
                            "Self Service Name"});
                table1409.AddRow(new string[] {
                            ""});
                table1409.AddRow(new string[] {
                            "Enabled"});
                table1409.AddRow(new string[] {
                            "Scope"});
                table1409.AddRow(new string[] {
                            "Primary Object Type"});
                table1409.AddRow(new string[] {
                            "Self Service URL"});
                table1409.AddRow(new string[] {
                            "Created By"});
                table1409.AddRow(new string[] {
                            "Created Date"});
#line 19
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table1409, "Then ");
#line hidden
#line 29
 testRunner.When("User clicks on \'Self Service Name\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
    testRunner.Then("data in table is sorted by \'Self Service Name\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckSelfServiceAgGridSelection")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19392")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckSelfServiceAgGridSelection()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19392",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckSelfServiceAgGridSelection", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19392",
                        "Cleanup"});
#line 33
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
                TechTalk.SpecFlow.Table table1410 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceId",
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "ObjectType",
                            "ObjectTypeId",
                            "StartDate",
                            "EndDate",
                            "SelfServiceURL",
                            "AllowAnonymousUsers",
                            "ScopeId",
                            "scopeName"});
                table1410.AddRow(new string[] {
                            "1",
                            "A_TestSelection_name1",
                            "id193851",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1410.AddRow(new string[] {
                            "2",
                            "B_TestSelection_name2",
                            "id193852",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1410.AddRow(new string[] {
                            "3",
                            "C_TestSelection_name3",
                            "id193853",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1410.AddRow(new string[] {
                            "4",
                            "D_TestSelection_name4",
                            "id193854",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1410.AddRow(new string[] {
                            "5",
                            "F_TestSelection_name5",
                            "id193855",
                            "true",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 34
    testRunner.When("User creates Self Service via API", ((string)(null)), table1410, "When ");
#line hidden
#line 41
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("select all rows checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
    testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
    testRunner.Then("all checkboxes are checked in the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User deselect all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("select all rows checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("User enters \"A_TestSelection_name1\" text in the Search field for \"Self Service Na" +
                        "me\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("Select All checkbox have indeterminate checked state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatSelfServiceCogMenuDisplaysProperly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19392")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatSelfServiceCogMenuDisplaysProperly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19392",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSelfServiceCogMenuDisplaysProperly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19392",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table1411 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceId",
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "ObjectType",
                            "ObjectTypeId",
                            "StartDate",
                            "EndDate",
                            "SelfServiceURL",
                            "AllowAnonymousUsers",
                            "ScopeId",
                            "scopeName"});
                table1411.AddRow(new string[] {
                            "1",
                            "TestSelfServiceCogMenu_name1",
                            "id193851",
                            "false",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
                table1411.AddRow(new string[] {
                            "5",
                            "TestSelfServiceCogMenu_name5",
                            "id193855",
                            "true",
                            "Devimdmdmm",
                            "3",
                            "2019-12-10T21:34:47.24",
                            "2019-12-31T21:34:47.24",
                            "URL",
                            "true",
                            "2",
                            "bob"});
#line 54
    testRunner.When("User creates Self Service via API", ((string)(null)), table1411, "When ");
#line hidden
#line 58
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1412 = new TechTalk.SpecFlow.Table(new string[] {
                            "options"});
                table1412.AddRow(new string[] {
                            "Edit"});
                table1412.AddRow(new string[] {
                            "Enable"});
                table1412.AddRow(new string[] {
                            "Delete"});
#line 60
 testRunner.When("User clicks Cog-menu for \'TestSelfServiceCogMenu_name1\' item in the \'Self Service" +
                        " Name\' column and sees following cog-menu options", ((string)(null)), table1412, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1413 = new TechTalk.SpecFlow.Table(new string[] {
                            "options"});
                table1413.AddRow(new string[] {
                            "Edit"});
                table1413.AddRow(new string[] {
                            "Disable"});
                table1413.AddRow(new string[] {
                            "Delete"});
#line 65
 testRunner.When("User clicks Cog-menu for \'TestSelfServiceCogMenu_name5\' item in the \'Self Service" +
                        " Name\' column and sees following cog-menu options", ((string)(null)), table1413, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
