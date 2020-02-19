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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddTextComponentViaSelfServiceBuilder", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        "scopeName",
                        "Scope"});
            table2.AddRow(new string[] {
                        "1",
                        "TestProj_1",
                        "Test_ID_1",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "SelfServiceStaticAppList"});
#line 13
 testRunner.When("User creates Self Service via API", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "ObjectTypeId",
                        "DisplayName",
                        "ShowInSelfService"});
            table3.AddRow(new string[] {
                        "Test_ID_1",
                        "TestPageSs1",
                        "3",
                        "TestPageSsDisplay",
                        "false"});
#line 16
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table3, "When ");
#line 19
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.When("User navigates to the \'Self Services\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_1\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
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
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table4.AddRow(new string[] {
                        ""});
#line 28
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
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
                        "scopeName",
                        "Scope"});
            table5.AddRow(new string[] {
                        "1",
                        "TestProj_2",
                        "Test_ID_2",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "SelfServiceStaticAppList"});
#line 31
 testRunner.When("User creates Self Service via API", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "ObjectTypeId",
                        "DisplayName",
                        "ShowInSelfService"});
            table6.AddRow(new string[] {
                        "Test_ID_1",
                        "TestPageSs2",
                        "3",
                        "TestPageSsDisplay",
                        "false"});
#line 34
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table6, "When ");
#line 37
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.When("User navigates to the \'Self Services\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_2\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
    testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs2\' name o" +
                    "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("popup with \'Add Component\' title is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("User sees \'Text\' component on dialog page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.Then("User sees \'Application Ownership\' component on dialog page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table7.AddRow(new string[] {
                        ""});
#line 49
 testRunner.When("User create static list with \"SelfServiceStaticAppList\" name on \"Applications\" pa" +
                    "ge with following items", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
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
                        "scopeName",
                        "Scope"});
            table8.AddRow(new string[] {
                        "1",
                        "TestProj_3",
                        "Test_ID_3",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "SelfServiceStaticAppList"});
#line 52
 testRunner.When("User creates Self Service via API", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceIdentifier",
                        "Name",
                        "ObjectTypeId",
                        "DisplayName",
                        "ShowInSelfService"});
            table9.AddRow(new string[] {
                        "Test_ID_3",
                        "TestPageSs3",
                        "3",
                        "TestPageSsDisplay",
                        "false"});
#line 55
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table9, "When ");
#line 58
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.When("User navigates to the \'Self Services\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_3\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
    testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs3\' name o" +
                    "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("\'ADD\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.Then("\'CANCEL\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.Then("Button \'ADD\' has \'Select a component\' tooltip on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
    testRunner.When("User clicks on \'Text\' component on dialog page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("\'CANCEL\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.Then("\'ADD\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.Then("\'Text\' component on dialog page is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

