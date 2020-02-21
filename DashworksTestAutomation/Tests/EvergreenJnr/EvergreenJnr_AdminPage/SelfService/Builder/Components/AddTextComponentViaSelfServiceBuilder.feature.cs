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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.Builder.Components
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AddTextComponentViaSelfServiceBuilder")]
    public partial class AddTextComponentViaSelfServiceBuilderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddTextComponentViaSelfServiceBuilder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddTextComponentViaSelfServiceBuilder", "\tAdd text component via Self Service builder", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserSeesProperTootltipForA" +
            "ddItemButton")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserSeesProperTootltipForAddItemButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserSeesProperTootltipForA" +
                    "ddItemButton", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19982",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table1.AddRow(new string[] {
                        ""});
#line 10
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table2.AddRow(new string[] {
                        "TestProj_1",
                        "Test_ID_1",
                        "true",
                        "true",
                        "SelfServiceStaticAppList"});
#line 13
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table3.AddRow(new string[] {
                        "Test_ID_1",
                        "TestPageSs1",
                        "TestPageSsDisplay",
                        "false"});
#line 16
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table3, "When ");
#line 19
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
    testRunner.Then("User sees \'Add Component\' tootltip text of Add Item button for item with \'Page\' t" +
                    "ype and \'TestPageSs1\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTheAddComponentPopUpHasALi" +
            "stOfAvailableComponents")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTheAddComponentPopUpHasAListOfAvailableComponents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTheAddComponentPopUpHasALi" +
                    "stOfAvailableComponents", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19982",
                        "Cleanup"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table4.AddRow(new string[] {
                        ""});
#line 25
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table5.AddRow(new string[] {
                        "TestProj_2",
                        "Test_ID_2",
                        "true",
                        "true",
                        "SelfServiceStaticAppList"});
#line 28
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table6.AddRow(new string[] {
                        "Test_ID_2",
                        "TestPageSs2",
                        "TestPageSsDisplay",
                        "false"});
#line 31
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table6, "When ");
#line 34
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs2\' name o" +
                    "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("popup with \'Add Component\' title is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Then("User sees \'Text\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.Then("User sees \'Application Ownership\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatAfterClickOnComponentItWil" +
            "lBeHighlightedAndAddButtonEnabled")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatAfterClickOnComponentItWillBeHighlightedAndAddButtonEnabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatAfterClickOnComponentItWil" +
                    "lBeHighlightedAndAddButtonEnabled", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19982",
                        "Cleanup"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table7.AddRow(new string[] {
                        ""});
#line 43
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table8.AddRow(new string[] {
                        "TestProj_3",
                        "Test_ID_3",
                        "true",
                        "true",
                        "SelfServiceStaticAppList"});
#line 46
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table9.AddRow(new string[] {
                        "Test_ID_3",
                        "TestPageSs3",
                        "TestPageSsDisplay",
                        "false"});
#line 49
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table9, "When ");
#line 52
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
    testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs3\' name o" +
                    "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\'ADD\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("\'CANCEL\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("Button \'ADD\' has \'Select a component\' tooltip on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
    testRunner.When("User clicks on \'Text\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("\'CANCEL\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("\'ADD\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("\'Text\' component on dialog is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenUserClickedOnAddButton" +
            "ThePopupWillBeRemovedAndBuildeDesignSurfaceShowsCorrecComponentConfigurationPage" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenUserClickedOnAddButtonThePopupWillBeRemovedAndBuildeDesignSurfaceShowsCorrecComponentConfigurationPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenUserClickedOnAddButton" +
                    "ThePopupWillBeRemovedAndBuildeDesignSurfaceShowsCorrecComponentConfigurationPage" +
                    "", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19982",
                        "Cleanup"});
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table10.AddRow(new string[] {
                        ""});
#line 65
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table11.AddRow(new string[] {
                        "TestProj_4",
                        "Test_ID_4",
                        "true",
                        "true",
                        "SelfServiceStaticAppList"});
#line 68
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table12.AddRow(new string[] {
                        "Test_ID_4",
                        "TestPageSs4",
                        "TestPageSsDisplay",
                        "false"});
#line 71
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table12, "When ");
#line 74
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
    testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs4\' name o" +
                    "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
    testRunner.When("User clicks on \'Text\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("popup is displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("User clicks \'ADD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then("popup is not displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("\'CREATE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.Then("\'CANCEL\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.Then("\'CANCEL\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.Then("\'Show this component\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.Then("Page with \'Create Text Component\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneAppl" +
            "icationOwnershipInToFirstPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneApplicationOwnershipInToFirstPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneAppl" +
                    "icationOwnershipInToFirstPage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19982",
                        "DAS19982",
                        "Cleanup"});
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table13.AddRow(new string[] {
                        ""});
#line 90
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table14.AddRow(new string[] {
                        "TestProj_4",
                        "Test_ID_4",
                        "true",
                        "true",
                        "SelfServiceStaticAppList"});
#line 93
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table14, "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table15.AddRow(new string[] {
                        "Test_ID_4",
                        "TestPageSs4_1",
                        "TestPageSsDisplay",
                        "false"});
#line 96
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table15, "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table16.AddRow(new string[] {
                        "Test_ID_4",
                        "TestPageSs4_2",
                        "TestPageSsDisplay",
                        "false"});
#line 99
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table16, "When ");
#line 102
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
    testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs4_1\' name" +
                    " on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.When("User clicks on \'Application Ownership\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.When("User clicks \'ADD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.When("User enters \'OwnComp_1\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.When("User selects \'User Evergreen Capacity Project\' option from \'Project\' autocomplete" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs4_1\' name" +
                    " on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("\'Application Ownership\' component on dialog is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatLastPageDoesNotAllowAnyInt" +
            "eractiveComponentToBeAdded")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("DAS19982")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatLastPageDoesNotAllowAnyInteractiveComponentToBeAdded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatLastPageDoesNotAllowAnyInt" +
                    "eractiveComponentToBeAdded", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19982",
                        "DAS19982",
                        "Cleanup"});
#line 114
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table17.AddRow(new string[] {
                        ""});
#line 115
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table17, "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table18.AddRow(new string[] {
                        "TestProj_5",
                        "Test_ID_5",
                        "true",
                        "true",
                        "SelfServiceStaticAppList"});
#line 118
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table18, "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table19.AddRow(new string[] {
                        "Test_ID_5",
                        "TestPageSs_1",
                        "TestPageSsDisplay",
                        "false"});
#line 121
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table19, "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "DisplayName",
                        "ShowInSelfService"});
            table20.AddRow(new string[] {
                        "Test_ID_5",
                        "TestPageSs_2",
                        "TestPageSsDisplay",
                        "false"});
#line 124
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table20, "When ");
#line 127
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs_2\' name " +
                    "on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("\'Application Ownership\' component on dialog is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

