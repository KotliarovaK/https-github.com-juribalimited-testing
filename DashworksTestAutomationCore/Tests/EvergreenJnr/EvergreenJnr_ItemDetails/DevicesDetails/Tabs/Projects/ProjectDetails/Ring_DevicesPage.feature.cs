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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.DevicesDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Ring_DevicesPage", Description="\tRuns related tests for Ring field", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\DevicesDetails\\Tabs\\Projects\\ProjectD" +
        "etails\\Ring_DevicesPage.feature", SourceLine=0)]
    public partial class Ring_DevicesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Ring_DevicesPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Ring_DevicesPage", "\tRuns related tests for Ring field", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatValueForRingIsChangingSuccessfully", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ProjectDetailsTab",
                "DAS17144",
                "DAS17163",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckThatValueForRingIsChangingSuccessfully()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ProjectDetailsTab",
                    "DAS17144",
                    "DAS17163",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatValueForRingIsChangingSuccessfully", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ProjectDetailsTab",
                        "DAS17144",
                        "DAS17163",
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
                TechTalk.SpecFlow.Table table2953 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "IsDefault",
                            "Project"});
                table2953.AddRow(new string[] {
                            "RingDAS17144_1",
                            "DAS17144",
                            "false",
                            "2004 Rollout"});
                table2953.AddRow(new string[] {
                            "RingDAS17144_2",
                            "DAS17144",
                            "false",
                            "2004 Rollout"});
#line 10
 testRunner.When("User creates new Ring via api", ((string)(null)), table2953, "When ");
#line hidden
#line 14
 testRunner.When("User navigates to the \'Device\' details page for \'CDBR7TV3Y9T2ITS\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("Details page for \'CDBR7TV3Y9T2ITS\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.When("User selects \'2004 Rollout\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User selects \'RingDAS17144_1\' in the dropdown for the \'Ring\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("\'Device successfully moved to RingDAS17144_1\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2954 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2954.AddRow(new string[] {
                            "Ring",
                            "RingDAS17144_1"});
#line 21
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2954, "Then ");
#line hidden
#line 24
 testRunner.When("User navigates to \'evergreen/#/admin/project/63/rings\' URL in a new tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2955 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table2955.AddRow(new string[] {
                            "RingDAS17144_2"});
#line 25
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table2955, "When ");
#line hidden
#line 28
 testRunner.When("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.And("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.Then("\'The selected ring has been deleted\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User switches to previous tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.When("User selects \'RingDAS17144_2\' in the dropdown for the \'Ring\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("\'Ring does not exist\' text is displayed on inline error banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_ChecksthatThePermissionIsWorkingCorrectlyForTheRingField" +
            "", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ProjectDetailsTab",
                "DAS17144",
                "Cleanup"}, SourceLine=36)]
        public virtual void EvergreenJnr_DevicesList_ChecksthatThePermissionIsWorkingCorrectlyForTheRingField()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ProjectDetailsTab",
                    "DAS17144",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksthatThePermissionIsWorkingCorrectlyForTheRingField" +
                    "", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ProjectDetailsTab",
                        "DAS17144",
                        "Cleanup"});
#line 37
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
                TechTalk.SpecFlow.Table table2956 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Email",
                            "FullName",
                            "Password",
                            "Roles"});
                table2956.AddRow(new string[] {
                            "UserDAS17144",
                            "Value",
                            "DAS17144",
                            "m!gration",
                            "Project Computer Object Editor"});
#line 38
 testRunner.When("User create new User via API", ((string)(null)), table2956, "When ");
#line hidden
#line 41
 testRunner.When("User clicks the Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2957 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table2957.AddRow(new string[] {
                            "UserDAS17144",
                            "m!gration"});
#line 42
  testRunner.When("User is logged in to the Evergreen as", ((string)(null)), table2957, "When ");
#line hidden
#line 45
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User navigates to the \'Device\' details page for \'CDBR7TV3Y9T2ITS\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("Details page for \'CDBR7TV3Y9T2ITS\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("User selects \'2004 Rollout\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then("arrow for editing the \'Ring\' field is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatListOfRingsIsDisplayedCorrectlyOnTheDetailsPage" +
            "", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ProjectDetailsTab",
                "DAS17144"}, SourceLine=53)]
        public virtual void EvergreenJnr_DevicesList_CheckThatListOfRingsIsDisplayedCorrectlyOnTheDetailsPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ProjectDetailsTab",
                    "DAS17144"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatListOfRingsIsDisplayedCorrectlyOnTheDetailsPage" +
                    "", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ProjectDetailsTab",
                        "DAS17144"});
#line 54
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
#line 55
 testRunner.When("User navigates to the \'Device\' details page for \'CDBR7TV3Y9T2ITS\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then("Details page for \'CDBR7TV3Y9T2ITS\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.When("User selects \'2004 Rollout\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2958 = new TechTalk.SpecFlow.Table(new string[] {
                            "Value"});
                table2958.AddRow(new string[] {
                            "Unassigned"});
                table2958.AddRow(new string[] {
                            "Pilot"});
                table2958.AddRow(new string[] {
                            "Early Adopters"});
                table2958.AddRow(new string[] {
                            "IT Users"});
                table2958.AddRow(new string[] {
                            "Business Wave 1"});
                table2958.AddRow(new string[] {
                            "Business Wave 2"});
                table2958.AddRow(new string[] {
                            "Business Wave 3"});
                table2958.AddRow(new string[] {
                            "Critical Systems"});
#line 60
 testRunner.Then("following Values are displayed in the dropdown for the \'Ring\' field:", ((string)(null)), table2958, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatRingFieldIsDisplayedDependingOnTheProjectScopeF" +
            "orDevicePage", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ProjectDetailsTab",
                "DAS19948"}, SourceLine=71)]
        public virtual void EvergreenJnr_DevicesList_CheckThatRingFieldIsDisplayedDependingOnTheProjectScopeForDevicePage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ProjectDetailsTab",
                    "DAS19948"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatRingFieldIsDisplayedDependingOnTheProjectScopeF" +
                    "orDevicePage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ProjectDetailsTab",
                        "DAS19948"});
#line 72
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
#line 73
 testRunner.When("User navigates to the \'Device\' details page for the item with \'6793\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.Then("Details page for \'00KWQ4J3WKQM0G\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.When("User selects \'USE ME FOR AUTOMATION(DEVICE SCHDLD)\' in the \'Item Details Project\'" +
                        " dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2959 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Value"});
                table2959.AddRow(new string[] {
                            "Ring",
                            "Unassigned"});
#line 78
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2959, "Then ");
#line hidden
#line 81
 testRunner.When("User selects \'USE ME FOR AUTOMATION(USR SCHDLD)\' in the \'Item Details Project\' dr" +
                        "opdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("\'Ring\' field is not displayed in the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
