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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.EndUserSide
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("GeneralEndUser", Description="\tGeneral scenarios related to End User pages", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AdminPage\\SelfService\\EndUserSide\\GeneralEndUser." +
        "feature", SourceLine=0)]
    public partial class GeneralEndUserFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GeneralEndUser.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GeneralEndUser", "\tGeneral scenarios related to End User pages", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisP" +
            "ageButtonIsntPresent", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "SelfService",
                "DAS20330",
                "Cleanup",
                "SelfService"}, SourceLine=8)]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisPageButtonIsntPresent()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20330",
                    "Cleanup",
                    "SelfService"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisP" +
                    "ageButtonIsntPresent", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20330",
                        "Cleanup",
                        "SelfService"});
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
                TechTalk.SpecFlow.Table table1667 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1667.AddRow(new string[] {
                            "DAS_20330_Proj_1",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1667, "When ");
#line hidden
#line 14
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1668 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1668.AddRow(new string[] {
                            "024213574157421A9CD (Reyes, Natasha)"});
                table1668.AddRow(new string[] {
                            "03C54BC1198843A4A03 (Jones, Tina)"});
#line 17
 testRunner.When("User expands \'Users to add\' multiselect to the \'Users\' tab on Project Scope Chang" +
                        "es page and selects following Objects", ((string)(null)), table1668, "When ");
#line hidden
#line 21
 testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
    testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1669 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1669.AddRow(new string[] {
                            "VSCmdShell"});
#line 25
    testRunner.When("User expands \'Applications to add\' multiselect to the \'Applications\' tab on Proje" +
                        "ct Scope Changes page and selects following Objects", ((string)(null)), table1669, "When ");
#line hidden
#line 28
    testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
    testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1670 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1670.AddRow(new string[] {
                            "03C54BC1198843A4A03"});
                table1670.AddRow(new string[] {
                            "024213574157421A9CD"});
#line 30
 testRunner.When("User create static list with \"DAS_20330_forComponent_1\" name on \"Users\" page with" +
                        " following items", ((string)(null)), table1670, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1671 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1671.AddRow(new string[] {
                            "VSCmdShell"});
#line 34
 testRunner.When("User create static list with \"DAS_20330_1\" name on \"Applications\" page with follo" +
                        "wing items", ((string)(null)), table1671, "When ");
#line hidden
#line 38
 testRunner.When("User navigates to the \'Application\' details page for \'VSCmdShell\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.When("User selects \'DAS_20330_Proj_1\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User clicks on edit button for \'App Owner\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.When("User enters \'Natasha\' in the \'User\' autocomplete field and selects \'BCLABS\\024213" +
                        "574157421A9CD (79951) - Reyes, Natasha\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1672 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1672.AddRow(new string[] {
                            "DAS_20330_SS_1",
                            "20330_1_SI",
                            "true",
                            "true",
                            "DAS_20330_1"});
#line 46
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1672, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1673 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ExtraPropertiesText",
                            "ShowInSelfService"});
                table1673.AddRow(new string[] {
                            "Text_Component_Name_1",
                            "<p>normal</p>",
                            "true"});
#line 49
 testRunner.When("User creates new text component for \'Welcome\' Self Service page via API", ((string)(null)), table1673, "When ");
#line hidden
#line 53
 testRunner.When("User navigates to End User landing page with \'20330_1_SI\' Self Service Identifier" +
                        ", \'DAS_20330_1 \' scope list and \'DAS_20330_Proj_1\' project name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("\'Undo all changes I made on this page\' button is not displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1674 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission",
                            "UserScope"});
                table1674.AddRow(new string[] {
                            "AOC Name",
                            "DAS_20330_Proj_1",
                            "Do not allow owner to be changed",
                            "DAS_20330_forComponent_1"});
#line 55
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                        "via API", ((string)(null)), table1674, "When ");
#line hidden
#line 59
 testRunner.When("User navigates to End User landing page with \'20330_1_SI\' Self Service Identifier" +
                        ", \'DAS_20330_1 \' scope list and \'DAS_20330_Proj_1\' project name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("\'Undo all changes I made on this screen\' button is not displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisP" +
            "ageButtonWorksCorrectly", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "SelfService",
                "DAS20330",
                "Cleanup",
                "SelfService"}, SourceLine=62)]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisPageButtonWorksCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20330",
                    "Cleanup",
                    "SelfService"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisP" +
                    "ageButtonWorksCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20330",
                        "Cleanup",
                        "SelfService"});
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
                TechTalk.SpecFlow.Table table1675 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1675.AddRow(new string[] {
                            "DAS_20330_Proj_2",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 64
 testRunner.When("Project created via API and opened", ((string)(null)), table1675, "When ");
#line hidden
#line 68
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1676 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1676.AddRow(new string[] {
                            "024213574157421A9CD (Reyes, Natasha)"});
                table1676.AddRow(new string[] {
                            "03C54BC1198843A4A03 (Jones, Tina)"});
#line 71
 testRunner.When("User expands \'Users to add\' multiselect to the \'Users\' tab on Project Scope Chang" +
                        "es page and selects following Objects", ((string)(null)), table1676, "When ");
#line hidden
#line 75
 testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
    testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1677 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table1677.AddRow(new string[] {
                            "VSCmdShell"});
#line 79
    testRunner.When("User expands \'Applications to add\' multiselect to the \'Applications\' tab on Proje" +
                        "ct Scope Changes page and selects following Objects", ((string)(null)), table1677, "When ");
#line hidden
#line 82
    testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
    testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1678 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1678.AddRow(new string[] {
                            "03C54BC1198843A4A03"});
                table1678.AddRow(new string[] {
                            "024213574157421A9CD"});
#line 84
 testRunner.When("User create static list with \"DAS_20330_forComponent_2\" name on \"Users\" page with" +
                        " following items", ((string)(null)), table1678, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1679 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1679.AddRow(new string[] {
                            "VSCmdShell"});
#line 88
 testRunner.When("User create static list with \"DAS_20330_2\" name on \"Applications\" page with follo" +
                        "wing items", ((string)(null)), table1679, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1680 = new TechTalk.SpecFlow.Table(new string[] {
                            "values"});
                table1680.AddRow(new string[] {
                            "VSCmdShell"});
#line 91
 testRunner.Given("User resync \'Application\' objects for \'DAS_20330_Proj_2\' project", ((string)(null)), table1680, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1681 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1681.AddRow(new string[] {
                            "DAS_20330_SS_2",
                            "20330_2_SI",
                            "true",
                            "true",
                            "DAS_20330_2"});
#line 94
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1681, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1682 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission",
                            "UserScope"});
                table1682.AddRow(new string[] {
                            "AOC Name",
                            "DAS_20330_Proj_2",
                            "Allow owner to be removed or set to another user",
                            "DAS_20330_forComponent_2"});
#line 97
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                        "via API", ((string)(null)), table1682, "When ");
#line hidden
#line 100
 testRunner.When("User navigates to End User landing page with \'20330_2_SI\' Self Service Identifier" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.Then("\'Undo all changes I made on this page\' button is disabled for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.Then("\'Undo all changes I made on this page\' button has tooltip with \'You have not made" +
                        " any changes yet\' text on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.When("User clicks on \'Change Owner\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.When("User checks \'Remove owner\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 105
 testRunner.When("User clicks \'Change Owner\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When("User clicks on \'Undo all changes I made on this page\' button on end user Self Ser" +
                        "vice page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1683 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstColumn",
                            "SecondColumn"});
                table1683.AddRow(new string[] {
                            "Username",
                            "VGZ6407126"});
                table1683.AddRow(new string[] {
                            "Domain",
                            "FR"});
                table1683.AddRow(new string[] {
                            "Display Name",
                            "Arlette Sicard"});
#line 107
 testRunner.Then("User sees following items for \'AOC Name\' application ownership component on \'Welc" +
                        "ome\' end user page", ((string)(null)), table1683, "Then ");
#line hidden
#line 112
 testRunner.When("User clicks on \'Change Owner\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.When("User checks \'Assign an owner\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.When("User enters \'Jones\' in the \'Owner\' autocomplete field and selects \'03C54BC1198843" +
                        "A4A03 (Jones, Tina)\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
 testRunner.When("User clicks \'Change Owner\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1684 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstColumn",
                            "SecondColumn"});
                table1684.AddRow(new string[] {
                            "Username",
                            "03C54BC1198843A4A03"});
                table1684.AddRow(new string[] {
                            "Domain",
                            "BCLABS"});
                table1684.AddRow(new string[] {
                            "Display Name",
                            "Jones, Tina"});
#line 116
 testRunner.Then("User sees following items for \'AOC Name\' application ownership component on \'Welc" +
                        "ome\' end user page", ((string)(null)), table1684, "Then ");
#line hidden
#line 121
 testRunner.When("User clicks on \'Undo all changes I made on this page\' button on end user Self Ser" +
                        "vice page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1685 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstColumn",
                            "SecondColumn"});
                table1685.AddRow(new string[] {
                            "Username",
                            "VGZ6407126"});
                table1685.AddRow(new string[] {
                            "Domain",
                            "FR"});
                table1685.AddRow(new string[] {
                            "Display Name",
                            "Arlette Sicard"});
#line 122
 testRunner.Then("User sees following items for \'AOC Name\' application ownership component on \'Welc" +
                        "ome\' end user page", ((string)(null)), table1685, "Then ");
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
