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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Automation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateAutomayions")]
    public partial class CreateAutomayionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateAutomation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateAutomayions", "\tCreate Automations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckActionGridInAutomations")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS15309")]
        [NUnit.Framework.CategoryAttribute("DAS15626")]
        [NUnit.Framework.CategoryAttribute("DAS16880")]
        [NUnit.Framework.CategoryAttribute("DAS16931")]
        [NUnit.Framework.CategoryAttribute("DAS17102")]
        [NUnit.Framework.CategoryAttribute("DAS17630")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckActionGridInAutomations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckActionGridInAutomations", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS15309",
                        "DAS15626",
                        "DAS16880",
                        "DAS16931",
                        "DAS17102",
                        "DAS17630",
                        "Remove_Profile_Changes",
                        "Not_Ready"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User clicks the \"CREATE AUTOMATION\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Create Automation page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User enters \'15309_laptop\' text to \'Automation Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.When("User enters \'15309\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ListName"});
            table1.AddRow(new string[] {
                        "All Devices"});
            table1.AddRow(new string[] {
                        "All Device Types"});
            table1.AddRow(new string[] {
                        "All Users"});
            table1.AddRow(new string[] {
                        "All Applications"});
            table1.AddRow(new string[] {
                        "All Mailboxes"});
#line 21
 testRunner.Then("Main lists are displayed correctly in the Scope dropdown", ((string)(null)), table1, "Then ");
#line 28
 testRunner.When("User selects \"All Devices\" in the Scope Automation dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.When("User selects \"Active\" checkbox on the Automation Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.When("User selects \"Stop on failed action\" checkbox on the Automation Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("\"CREATE\" Action button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.When("User selects \"Manual\" in the \"Run\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("User clicks \"Actions\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("\"No actions found\" message is displayed on the Admin Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.Then("\"CREATE ACTION\" Action button is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatCreateAutomationFieldsIsNotPopulatedWithPreviousl" +
            "yCreatedAutomation")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS16801")]
        [NUnit.Framework.CategoryAttribute("DAS15764")]
        [NUnit.Framework.CategoryAttribute("DAS15423")]
        [NUnit.Framework.CategoryAttribute("DAS17134")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckThatCreateAutomationFieldsIsNotPopulatedWithPreviouslyCreatedAutomation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatCreateAutomationFieldsIsNotPopulatedWithPreviousl" +
                    "yCreatedAutomation", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS16801",
                        "DAS15764",
                        "DAS15423",
                        "DAS17134",
                        "Not_Ready"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 40
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("User clicks the \"CREATE AUTOMATION\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("Create Automation page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table2.AddRow(new string[] {
                        "Manual"});
            table2.AddRow(new string[] {
                        "After Transform"});
            table2.AddRow(new string[] {
                        "Scheduled: Dashworks Daily"});
#line 46
 testRunner.Then("following Values are displayed in \"Run\" drop-down on the Admin page:", ((string)(null)), table2, "Then ");
#line 51
 testRunner.When("User enters \'DAS16801_Automation\' text to \'Automation Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.When("User enters \'DAS16801\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.When("User selects \"1803 Rollout\" in the Scope Automation dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.When("User selects \"Manual\" in the \"Run\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.When("User selects \"Active\" checkbox on the Automation Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("User clicks \"Automations\" navigation link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.When("User clicks the \"CREATE AUTOMATION\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("\"Description\" field is empty on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("\"Automation Name\" field is empty on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("\"Scope\" field is empty on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("\"Active\" checkbox is unchecked on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User enters \'DAS16801_Automation_Second\' text to \'Automation Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.When("User enters \'DAS16801\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.When("User selects \"1803 Rollout\" in the Scope Automation dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.When("User selects \"Manual\" in the \"Run\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.When("User selects \"Active\" checkbox on the Automation Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.When("User enters \'DAS16801_Automation\' text to \'Automation Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("\'An automation with this name already exists\' error message is displayed for \'Aut" +
                    "omation Name\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatAdminTabIsHighlightedAfterClickingOnAutomation")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("DAS16801")]
        [NUnit.Framework.CategoryAttribute("DAS16805")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckThatAdminTabIsHighlightedAfterClickingOnAutomation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatAdminTabIsHighlightedAfterClickingOnAutomation", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "DAS16801",
                        "DAS16805",
                        "Not_Ready"});
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 75
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("User clicks content from \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then("Edit Automation page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("\"Admin\" left-hand menu is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

