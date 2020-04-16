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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.Components
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TextComponent")]
    public partial class TextComponentFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TextComponent.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TextComponent", "\tText Component", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_TextComponentUiCheckForCreatePage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19979")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_TextComponentUiCheckForCreatePage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19979",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_TextComponentUiCheckForCreatePage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19979",
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
                TechTalk.SpecFlow.Table table1537 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1537.AddRow(new string[] {
                            ""});
#line 10
 testRunner.When("User create static list with \"DAS_19979_11\" name on \"Users\" page with following i" +
                        "tems", ((string)(null)), table1537, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1538 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1538.AddRow(new string[] {
                            "DAS_19979_SS_1",
                            "19979_1_SI",
                            "true",
                            "true",
                            "DAS_19979_11"});
#line 13
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1538, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1539 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1539.AddRow(new string[] {
                            "19979_1_SI",
                            "TestPageSs2",
                            "DAS_19979_Page",
                            "true"});
#line 16
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1539, "When ");
#line hidden
#line 19
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs2\' name o" +
                        "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When("User clicks on \'Text\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When("User clicks \'ADD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("Page with \'DAS_19979_SS_1\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.Then("Page with \'Create Text Component\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.Then("\'TestPageSs2\' label with self service parent page name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.Then("text editor is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then("\'\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("\'Show this component\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("\'CREATE\' button has tooltip with \'Some values are missing or not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User enters \'\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("\'Enter a component name\' error message is displayed for \'Component Name\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.Then("\'CREATE\' button has tooltip with \'Some values are missing or not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_TextComponentUiCheckForUpdatePage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19979")]
        [NUnit.Framework.CategoryAttribute("DAS20049")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_TextComponentUiCheckForUpdatePage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19979",
                    "DAS20049",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_TextComponentUiCheckForUpdatePage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19979",
                        "DAS20049",
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
                TechTalk.SpecFlow.Table table1540 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1540.AddRow(new string[] {
                            ""});
#line 38
 testRunner.When("User create static list with \"DAS_19979_22\" name on \"Users\" page with following i" +
                        "tems", ((string)(null)), table1540, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1541 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1541.AddRow(new string[] {
                            "DAS_19979_SS_2",
                            "19979_2_SI",
                            "true",
                            "true",
                            "DAS_19979_22"});
#line 41
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1541, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1542 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1542.AddRow(new string[] {
                            "19979_2_SI",
                            "TestPageSs3",
                            "DAS_19979_Page_2",
                            "true"});
#line 44
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1542, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1543 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ExtraPropertiesText",
                            "ShowInSelfService"});
                table1543.AddRow(new string[] {
                            "Text_Component_Name",
                            "<p>Some_Content</p>",
                            "true"});
#line 47
 testRunner.When("User creates new text component for \'TestPageSs3\' Self Service page via API", ((string)(null)), table1543, "When ");
#line hidden
#line 50
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.When("User selects \'Edit\' cogmenu option for \'Text\' item type with \'Text_Component_Name" +
                        "\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("Page with \'DAS_19979_SS_2\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.Then("Page with \'Edit Text Component\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.Then("\'TestPageSs3\' label with self service parent page name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.Then("\'Text_Component_Name\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.Then("text editor is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1544 = new TechTalk.SpecFlow.Table(new string[] {
                            "text"});
                table1544.AddRow(new string[] {
                            "Some_Content"});
#line 57
 testRunner.Then("text editor contains text", ((string)(null)), table1544, "Then ");
#line hidden
#line 60
 testRunner.Then("\'Show this component\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.Then("\'UPDATE\' button has tooltip with \'No changes made\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("User enters \'\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("\'Enter a component name\' error message is displayed for \'Component Name\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("\'UPDATE\' button has tooltip with \'Some values are missing or not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.When("User enters \'Text_Component_Name\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.When("User clicks Body container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then("\'UPDATE\' button has tooltip with \'No changes made\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.When("User clears text editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.When("User clicks Body container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.Then("\'UPDATE\' button has tooltip with \'Some values are missing or not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.When("User enters \'Some_Content\' text to the text editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.When("User clicks Body container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.Then("\'UPDATE\' button has tooltip with \'No changes made\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("User enters \'_Additional_Text\' text to the text editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.When("User enters \'Updated Name\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
 testRunner.When("User unchecks \'Show this component\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("\'The Updated Name component has been updated\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.Then("Item with \'Page\' type and \'TestPageSs3\' name on Self Service Builder Panel is hig" +
                        "hlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("User selects \'Edit\' cogmenu option for \'Text\' item type with \'Updated Name\' name " +
                        "on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("\'Updated Name\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1545 = new TechTalk.SpecFlow.Table(new string[] {
                            "text"});
                table1545.AddRow(new string[] {
                            "Some_Content_Additional_Text"});
#line 91
 testRunner.Then("text editor contains text", ((string)(null)), table1545, "Then ");
#line hidden
#line 94
 testRunner.Then("\'Show this component\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_TextComponentUiCheckForCancelUpdateFunctionality")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20049")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_TextComponentUiCheckForCancelUpdateFunctionality()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20049",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_TextComponentUiCheckForCancelUpdateFunctionality", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20049",
                        "Cleanup"});
#line 97
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
                TechTalk.SpecFlow.Table table1546 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1546.AddRow(new string[] {
                            ""});
#line 98
 testRunner.When("User create static list with \"DAS_20049_33\" name on \"Users\" page with following i" +
                        "tems", ((string)(null)), table1546, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1547 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1547.AddRow(new string[] {
                            "DAS_20049_SS_3",
                            "20049_3_SI",
                            "true",
                            "true",
                            "DAS_20049_33"});
#line 101
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1547, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1548 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1548.AddRow(new string[] {
                            "20049_3_SI",
                            "TestPageSs4",
                            "DAS_20049_Page_2",
                            "true"});
#line 104
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1548, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1549 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ExtraPropertiesText",
                            "ShowInSelfService"});
                table1549.AddRow(new string[] {
                            "Text_Component_Name",
                            "<p>Some_Content</p>",
                            "true"});
#line 107
 testRunner.When("User creates new text component for \'TestPageSs4\' Self Service page via API", ((string)(null)), table1549, "When ");
#line hidden
#line 110
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.When("User selects \'Edit\' cogmenu option for \'Text\' item type with \'Text_Component_Name" +
                        "\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.When("User enters \'Updated Name\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.When("User enters \'Additional Text\' text to the text editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.When("User unchecks \'Show this component\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 117
 testRunner.Then("Item with \'Page\' type and \'TestPageSs4\' name on Self Service Builder Panel is hig" +
                        "hlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.When("User selects \'Edit\' cogmenu option for \'Text\' item type with \'Text_Component_Name" +
                        "\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 119
 testRunner.Then("\'Text_Component_Name\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 120
 testRunner.Then("\'Show this component\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1550 = new TechTalk.SpecFlow.Table(new string[] {
                            "text"});
                table1550.AddRow(new string[] {
                            "Additional Text"});
#line 121
 testRunner.Then("text editor does not contains text", ((string)(null)), table1550, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatTextEditorOptionsIsAvailableForTextComponent")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20160")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatTextEditorOptionsIsAvailableForTextComponent()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20160",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatTextEditorOptionsIsAvailableForTextComponent", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20160",
                        "Cleanup"});
#line 126
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
                TechTalk.SpecFlow.Table table1551 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1551.AddRow(new string[] {
                            "VSCmdShell"});
#line 127
 testRunner.When("User create static list with \"DAS_20160\" name on \"Applications\" page with followi" +
                        "ng items", ((string)(null)), table1551, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1552 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1552.AddRow(new string[] {
                            "DAS_20160_SS_3",
                            "20160_3_SI",
                            "true",
                            "true",
                            "DAS_20160"});
#line 130
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1552, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1553 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ExtraPropertiesText",
                            "ShowInSelfService"});
                table1553.AddRow(new string[] {
                            "Text_Component_Name",
                            "<p>Some_Content</p>",
                            "true"});
#line 133
 testRunner.When("User creates new text component for \'Welcome\' Self Service page via API", ((string)(null)), table1553, "When ");
#line hidden
#line 136
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
 testRunner.When("User selects \'Edit\' cogmenu option for \'Text\' item type with \'Text_Component_Name" +
                        "\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 138
 testRunner.Then("formatting options are displayed on the text component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1554 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1554.AddRow(new string[] {
                            "Heading 1"});
                table1554.AddRow(new string[] {
                            "Heading 2"});
                table1554.AddRow(new string[] {
                            "Heading 3"});
                table1554.AddRow(new string[] {
                            "Heading 4"});
                table1554.AddRow(new string[] {
                            "Heading 5"});
                table1554.AddRow(new string[] {
                            "Normal"});
#line 139
 testRunner.Then("header format options are displayed on the text component", ((string)(null)), table1554, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
