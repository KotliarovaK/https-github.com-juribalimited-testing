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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.Components
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ApplicationOwnershipComponent")]
    public partial class ApplicationOwnershipComponentFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ApplicationOwnershipComponent.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ApplicationOwnershipComponent", "\tApplication Ownership component", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheck")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20019")]
        [NUnit.Framework.CategoryAttribute("DAS20153")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheck()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheckInternal();
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

        private void EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheckInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20019",
                    "DAS20153",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheck", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20019",
                        "DAS20153",
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
                TechTalk.SpecFlow.Table table1269 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1269.AddRow(new string[] {
                            "DAS_20019_Proj",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 10
 testRunner.When("Project created via API", ((string)(null)), table1269, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1270 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1270.AddRow(new string[] {
                            ""});
#line 13
 testRunner.When("User create static list with \"DAS_20019_1\" name on \"Applications\" page with follo" +
                        "wing items", ((string)(null)), table1270, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1271 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1271.AddRow(new string[] {
                            ""});
#line 16
 testRunner.When("User create static list with \"DAS_20019_11\" name on \"Users\" page with following i" +
                        "tems", ((string)(null)), table1271, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1272 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1272.AddRow(new string[] {
                            "DAS_20019_SS_1",
                            "20019_1_SI",
                            "true",
                            "true",
                            "DAS_20019_1"});
#line 19
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1272, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1273 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1273.AddRow(new string[] {
                            "20019_1_SI",
                            "TestPageSs1",
                            "DAS_20019_Page_1",
                            "true"});
                table1273.AddRow(new string[] {
                            "20019_1_SI",
                            "TestPageSs2",
                            "DAS_20019_Page_2",
                            "true"});
#line 22
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1273, "When ");
#line hidden
#line 26
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.When("User clicks on Add Item button for item with \'Page\' type and \'TestPageSs1\' name o" +
                        "n Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.When("User clicks on \'Application Ownership\' component on dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.When("User clicks \'ADD\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("Page with \'Create App Ownership Component\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.Then("Page with \'Owner\' second level subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1274 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields to display"});
                table1274.AddRow(new string[] {
                            "Username"});
                table1274.AddRow(new string[] {
                            "Domain"});
                table1274.AddRow(new string[] {
                            "Display Name"});
#line 32
 testRunner.Then("following fields to display are displayed on application ownership component page" +
                        "", ((string)(null)), table1274, "Then ");
#line hidden
#line 37
 testRunner.Then("\'TestPageSs1\' label with self service parent page name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.Then("\'\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Then("\'Show this component\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.When("User enters \' \' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.Then("\'Enter a component name\' error message is displayed for \'Component Name\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.Then("\'\' content is displayed in \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1275 = new TechTalk.SpecFlow.Table(new string[] {
                            "values"});
                table1275.AddRow(new string[] {
                            "DAS_20019_Proj"});
#line 44
 testRunner.Then("\'Project\' autocomplete contains following options:", ((string)(null)), table1275, "Then ");
#line hidden
#line 47
 testRunner.Then("\'Do not allow owner to be changed\' radio button is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.Then("\'User Scope\' autocomplete is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("User checks \'Allow owner to be removed only\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("\'User Scope\' autocomplete is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.When("User checks \'Allow owner to be set to another user only\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("\'User Scope\' autocomplete is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("User checks \'Allow owner to be removed or set to another user\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("\'User Scope\' autocomplete is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.Then("\'\' content is displayed in \'User Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1276 = new TechTalk.SpecFlow.Table(new string[] {
                            "values"});
                table1276.AddRow(new string[] {
                            "All Users"});
                table1276.AddRow(new string[] {
                            "DAS_20019_11"});
#line 56
 testRunner.Then("\'User Scope\' autocomplete contains following options:", ((string)(null)), table1276, "Then ");
#line hidden
#line 60
 testRunner.Then("\'User Scope\' autocomplete first option is \'All Users\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1277 = new TechTalk.SpecFlow.Table(new string[] {
                            "fields"});
                table1277.AddRow(new string[] {
                            "Username"});
                table1277.AddRow(new string[] {
                            "Domain"});
                table1277.AddRow(new string[] {
                            "Display Name"});
#line 61
 testRunner.Then("following fields to display are displayed on application ownership component page" +
                        "", ((string)(null)), table1277, "Then ");
#line hidden
#line 66
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.Then("\'CREATE\' button has tooltip with \'Some values are missing or not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EditApplicationOwnershipComponent")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19909")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EditApplicationOwnershipComponent()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EditApplicationOwnershipComponentInternal();
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

        private void EvergreenJnr_AdminPage_EditApplicationOwnershipComponentInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19909",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EditApplicationOwnershipComponent", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19909",
                        "Cleanup"});
#line 70
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
                TechTalk.SpecFlow.Table table1278 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1278.AddRow(new string[] {
                            "DAS_19909_Proj",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 71
 testRunner.When("Project created via API", ((string)(null)), table1278, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1279 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1279.AddRow(new string[] {
                            "DAS_19909_Proj_Up",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 74
 testRunner.When("Project created via API and opened", ((string)(null)), table1279, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1280 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1280.AddRow(new string[] {
                            ""});
#line 77
 testRunner.When("User create static list with \"DAS_19909_2\" name on \"Applications\" page with follo" +
                        "wing items", ((string)(null)), table1280, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1281 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1281.AddRow(new string[] {
                            ""});
#line 80
 testRunner.When("User create static list with \"DAS_19909_3\" name on \"Users\" page with following it" +
                        "ems", ((string)(null)), table1281, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1282 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1282.AddRow(new string[] {
                            "DAS_19909_SS_2",
                            "19909_2_SI",
                            "true",
                            "true",
                            "DAS_19909_2"});
#line 83
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1282, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1283 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "DisplayName",
                            "ShowInSelfService"});
                table1283.AddRow(new string[] {
                            "19909_2_SI",
                            "TestPageSs1",
                            "DAS_19909_Page_1",
                            "true"});
                table1283.AddRow(new string[] {
                            "19909_2_SI",
                            "TestPageSs2",
                            "DAS_19909_Page_2",
                            "true"});
#line 86
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1283, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1284 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission"});
                table1284.AddRow(new string[] {
                            "AOC Name",
                            "DAS_19909_Proj",
                            "Do not allow owner to be changed"});
#line 90
 testRunner.When("User creates new application ownership component for \'TestPageSs1\' Self Service p" +
                        "age via API", ((string)(null)), table1284, "When ");
#line hidden
#line 93
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.When("User selects \'Edit\' cogmenu option for \'Application Ownership\' item type with \'AO" +
                        "C Name\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.When("User waits for info message disappears under \'User Scope\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.Then("Page with \'Edit App Ownership Component\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 98
 testRunner.Then("\'TestPageSs1\' label with self service parent page name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.Then("\'AOC Name\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.Then("\'DAS_19909_Proj\' content is displayed in \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.Then("\'Do not allow owner to be changed\' radio button is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.Then("\'Show this component\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.Then("\'UPDATE\' button has tooltip with \'No changes made\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.When("User enters \'AOC_Updated Name\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When("User selects \'DAS_19909_Proj_Up\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.When("User checks \'Allow owner to be set to another user only\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.When("User selects \'DAS_19909_3\' option from \'User Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.When("User waits for info message disappears under \'User Scope\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.When("User checks \'Show this component\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.When("User selects \'Edit\' cogmenu option for \'Application Ownership\' item type with \'AO" +
                        "C_Updated Name\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.Then("Page with \'Edit App Ownership Component\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.Then("\'TestPageSs1\' label with self service parent page name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.Then("\'AOC_Updated Name\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.Then("\'DAS_19909_Proj_Up\' content is displayed in \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.Then("\'Allow owner to be set to another user only\' radio button is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.Then("\'DAS_19909_3\' content is displayed in \'User Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 120
 testRunner.Then("\'Show this component\' checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CancelApplicationOwnershipComponentEditing")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19909")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CancelApplicationOwnershipComponentEditing()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CancelApplicationOwnershipComponentEditingInternal();
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

        private void EvergreenJnr_AdminPage_CancelApplicationOwnershipComponentEditingInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19909",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CancelApplicationOwnershipComponentEditing", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19909",
                        "Cleanup"});
#line 123
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
                TechTalk.SpecFlow.Table table1285 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1285.AddRow(new string[] {
                            "DAS_19909_Proj",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 124
 testRunner.When("Project created via API", ((string)(null)), table1285, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1286 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table1286.AddRow(new string[] {
                            "DAS_19909_Proj_Up",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 127
 testRunner.When("Project created via API and opened", ((string)(null)), table1286, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1287 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1287.AddRow(new string[] {
                            ""});
#line 130
 testRunner.When("User create static list with \"DAS_19909_2\" name on \"Applications\" page with follo" +
                        "wing items", ((string)(null)), table1287, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1288 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1288.AddRow(new string[] {
                            ""});
#line 133
 testRunner.When("User create static list with \"DAS_19909_3\" name on \"Users\" page with following it" +
                        "ems", ((string)(null)), table1288, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1289 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1289.AddRow(new string[] {
                            "DAS_19909_SS_2",
                            "19909_2_SI",
                            "true",
                            "true",
                            "DAS_19909_2"});
#line 136
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1289, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1290 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission"});
                table1290.AddRow(new string[] {
                            "AOC Name",
                            "DAS_19909_Proj",
                            "Do not allow owner to be changed"});
#line 139
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                        "via API", ((string)(null)), table1290, "When ");
#line hidden
#line 142
 testRunner.When("User navigates to the \'Builder\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 144
 testRunner.When("User selects \'Edit\' cogmenu option for \'Application Ownership\' item type with \'AO" +
                        "C Name\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 145
 testRunner.When("User enters \'AOC_Updated Name\' text to \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 146
 testRunner.When("User selects \'DAS_19909_Proj_Up\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
 testRunner.When("User checks \'Allow owner to be set to another user only\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 148
 testRunner.When("User selects \'DAS_19909_3\' option from \'User Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 149
 testRunner.When("User waits for info message disappears under \'User Scope\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 150
 testRunner.When("User checks \'Show this component\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 151
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 153
 testRunner.When("User selects \'Edit\' cogmenu option for \'Application Ownership\' item type with \'AO" +
                        "C Name\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 154
 testRunner.When("User waits for info message disappears under \'User Scope\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 155
 testRunner.Then("\'AOC Name\' content is displayed in \'Component Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 156
 testRunner.Then("\'DAS_19909_Proj\' content is displayed in \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 157
 testRunner.Then("\'Do not allow owner to be changed\' radio button is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 158
 testRunner.Then("\'User Scope\' autocomplete is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 159
 testRunner.When("User checks \'Allow owner to be set to another user only\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 160
 testRunner.Then("\'\' content is displayed in \'User Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 161
 testRunner.Then("\'Show this component\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
