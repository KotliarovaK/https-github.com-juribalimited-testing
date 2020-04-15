// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.Builder
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SelfServiceBuilderContextPanelActions")]
    public partial class SelfServiceBuilderContextPanelActionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SelfServiceBuilderContextPanelActions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SelfServiceBuilderContextPanelActions", "\tScenarios to test Builder Panel", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperCogMenuOptionsArePre" +
            "sentAndMoveToOptionsWorksProperly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20407")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("SelfServiceMVP")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperCogMenuOptionsArePresentAndMoveToOptionsWorksProperly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperCogMenuOptionsArePresentAndMoveToOptionsWorksProperlyInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperCogMenuOptionsArePresentAndMoveToOptionsWorksProperlyInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20407",
                    "Cleanup",
                    "SelfServiceMVP"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperCogMenuOptionsArePre" +
                    "sentAndMoveToOptionsWorksProperly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20407",
                        "Cleanup",
                        "SelfServiceMVP"});
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
                TechTalk.SpecFlow.Table table1180 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1180.AddRow(new string[] {
                            "VSCmdShell"});
#line 10
 testRunner.When("User create static list with \"DAS_20407\" name on \"Applications\" page with followi" +
                        "ng items", ((string)(null)), table1180, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1181 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1181.AddRow(new string[] {
                            "DAS_20407_SS_1",
                            "20407_1_SI",
                            "true",
                            "true",
                            "DAS_20407"});
#line 13
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1181, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1182 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ExtraPropertiesText",
                            "ShowInSelfService"});
                table1182.AddRow(new string[] {
                            "Text_Component_Name_1",
                            "<p>Sunt haud pauci homĭnes,</p>",
                            "true"});
                table1182.AddRow(new string[] {
                            "Text_Component_Name_2",
                            "<p>Sunt haud pauci homĭnes,</p>",
                            "true"});
                table1182.AddRow(new string[] {
                            "Text_Component_Name_3",
                            "<p>Sunt haud pauci homĭnes,</p>",
                            "true"});
#line 16
 testRunner.When("User creates new text component for \'Welcome\' Self Service page via API", ((string)(null)), table1182, "When ");
#line hidden
#line 21
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1183 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1183.AddRow(new string[] {
                            "Edit"});
                table1183.AddRow(new string[] {
                            "Move to bottom"});
                table1183.AddRow(new string[] {
                            "Move to position"});
                table1183.AddRow(new string[] {
                            "Delete"});
#line 22
 testRunner.Then("User clicks on cogmenu button for item with \'Text\' type and \'Text_Component_Name_" +
                        "1\' name on Self Service Builder Panel and sees the following cogmenu options", ((string)(null)), table1183, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1184 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1184.AddRow(new string[] {
                            "Edit"});
                table1184.AddRow(new string[] {
                            "Move to top"});
                table1184.AddRow(new string[] {
                            "Move to bottom"});
                table1184.AddRow(new string[] {
                            "Move to position"});
                table1184.AddRow(new string[] {
                            "Delete"});
#line 28
 testRunner.Then("User clicks on cogmenu button for item with \'Text\' type and \'Text_Component_Name_" +
                        "2\' name on Self Service Builder Panel and sees the following cogmenu options", ((string)(null)), table1184, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1185 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1185.AddRow(new string[] {
                            "Edit"});
                table1185.AddRow(new string[] {
                            "Move to top"});
                table1185.AddRow(new string[] {
                            "Move to position"});
                table1185.AddRow(new string[] {
                            "Delete"});
#line 35
 testRunner.Then("User clicks on cogmenu button for item with \'Text\' type and \'Text_Component_Name_" +
                        "3\' name on Self Service Builder Panel and sees the following cogmenu options", ((string)(null)), table1185, "Then ");
#line hidden
#line 41
 testRunner.When("User selects \'Move to bottom\' cogmenu option for \'Text\' item type with \'Text_Comp" +
                        "onent_Name_2\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User selects \'Move to top\' cogmenu option for \'Text\' item type with \'Text_Compone" +
                        "nt_Name_3\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.When("User moves item with type \'Text\' and \'Text_Component_Name_1\' name to \'3\' position" +
                        " on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1186 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentType",
                            "ComponentName",
                            "ComponentPosition"});
                table1186.AddRow(new string[] {
                            "Text",
                            "Text_Component_Name_1",
                            "3"});
                table1186.AddRow(new string[] {
                            "Text",
                            "Text_Component_Name_2",
                            "2"});
                table1186.AddRow(new string[] {
                            "Text",
                            "Text_Component_Name_3",
                            "1"});
#line 44
 testRunner.Then("User sees component on position in \'Welcome\' page of Self Service Builder Panel", ((string)(null)), table1186, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEditAndDeleteOptionsWorksP" +
            "roperly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20407")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("SelfServiceMVP")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEditAndDeleteOptionsWorksProperly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEditAndDeleteOptionsWorksProperlyInternal();
                    return;
                }
                catch (System.Exception exc)
                {
                    lastException = exc;
                }
                if (((i + 1)
                     <= 1))
                {
                    testRunner.OnScenarioEnd();
                }
            }
            if ((lastException != null))
            {
                throw lastException;
            }
        }

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEditAndDeleteOptionsWorksProperlyInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20407",
                    "Cleanup",
                    "SelfServiceMVP"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEditAndDeleteOptionsWorksP" +
                    "roperly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20407",
                        "Cleanup",
                        "SelfServiceMVP"});
#line 51
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
                TechTalk.SpecFlow.Table table1187 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1187.AddRow(new string[] {
                            "VSCmdShell"});
#line 52
 testRunner.When("User create static list with \"DAS_20407\" name on \"Applications\" page with followi" +
                        "ng items", ((string)(null)), table1187, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1188 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1188.AddRow(new string[] {
                            "DAS_20407_SS_2",
                            "20407_2_SI",
                            "true",
                            "true",
                            "DAS_20407"});
#line 55
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1188, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1189 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ExtraPropertiesText",
                            "ShowInSelfService"});
                table1189.AddRow(new string[] {
                            "Text_Component_Name_Original",
                            "<p>Sunt haud pauci homĭnes,</p>",
                            "true"});
#line 58
 testRunner.When("User creates new text component for \'Welcome\' Self Service page via API", ((string)(null)), table1189, "When ");
#line hidden
#line 61
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.When("User selects \'Edit\' cogmenu option for \'Text\' item type with \'Text_Component_Name" +
                        "_Original\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.When("User clears \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.When("User enters \'Text_Component_Name_Renamed\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.Then("User sees item with \'Text\' type and \'Text_Component_Name_Renamed\' name on Self Se" +
                        "rvice Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("User selects \'Delete\' cogmenu option for \'Text\' item type with \'Text_Component_Na" +
                        "me_Renamed\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("User doesn\'t see item with \'Text\' type and \'Text_Component_Name_Renamed\' name on " +
                        "Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
