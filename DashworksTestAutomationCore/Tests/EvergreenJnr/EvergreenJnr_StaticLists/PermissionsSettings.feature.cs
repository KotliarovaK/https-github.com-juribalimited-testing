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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_StaticLists
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PermissionsSettings")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class PermissionsSettingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "retry:1"};
        
#line 1 "PermissionsSettings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PermissionsSettings", "\tRuns Static List permissions setting related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
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
#line 5
#line hidden
#line 6
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticLis" +
            "t")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_StaticLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS10945")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS12152")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticListInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticListInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_StaticLists",
                    "PermissionsSettings",
                    "DAS10945",
                    "DAS11553",
                    "DAS10880",
                    "DAS12152",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticLis" +
                    "t", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_StaticLists",
                        "PermissionsSettings",
                        "DAS10945",
                        "DAS11553",
                        "DAS10880",
                        "DAS12152",
                        "Cleanup"});
#line 10
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3785 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3785.AddRow(new string[] {
                            ""});
#line 11
 testRunner.When("User create static list with \"Static List TestName23\" name on \"Users\" page with f" +
                        "ollowing items", ((string)(null)), table3785, "When ");
#line hidden
#line 14
 testRunner.Then("\"Static List TestName23\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User selects \'Everyone can see\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When("User selects \'Automation Admin 1\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3786 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3786.AddRow(new string[] {
                            "Last Logon Date"});
#line 21
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table3786, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3787 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3787.AddRow(new string[] {
                            "Last Logon Date"});
#line 24
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table3787, "Then ");
#line hidden
#line 27
 testRunner.Then("Update list option is NOT available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("\'SAVE AS NEW STATIC LIST\' menu button is displayed for \'SAVE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermission" +
            "Level")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_StaticLists")]
        [NUnit.Framework.CategoryAttribute("PermissionsSettings")]
        [NUnit.Framework.CategoryAttribute("DAS11022")]
        [NUnit.Framework.CategoryAttribute("DAS11553")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS12152")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Do_Not_Run_With_PermissionsSettings")]
        public virtual void EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevel()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevelInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevelInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_StaticLists",
                    "PermissionsSettings",
                    "DAS11022",
                    "DAS11553",
                    "DAS10880",
                    "DAS12152",
                    "DAS12602",
                    "Cleanup",
                    "Do_Not_Run_With_PermissionsSettings"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermission" +
                    "Level", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_StaticLists",
                        "PermissionsSettings",
                        "DAS11022",
                        "DAS11553",
                        "DAS10880",
                        "DAS12152",
                        "DAS12602",
                        "Cleanup",
                        "Do_Not_Run_With_PermissionsSettings"});
#line 31
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3788 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Email",
                            "FullName",
                            "Password",
                            "Roles"});
                table3788.AddRow(new string[] {
                            "DAS12602",
                            "Value",
                            "Test DAS12602",
                            "m!gration",
                            "Project Administrator"});
#line 32
 testRunner.When("User create new User via API", ((string)(null)), table3788, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3789 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3789.AddRow(new string[] {
                            "001BAQXT6JWFPI"});
                table3789.AddRow(new string[] {
                            "00HA7MKAVVFDAV"});
                table3789.AddRow(new string[] {
                            "2ML5YDWPRLFWW55"});
                table3789.AddRow(new string[] {
                            "700ZHPQ6661CV1N"});
#line 35
 testRunner.When("User create static list with \"OwnerPrivate\" name on \"Devices\" page with following" +
                        " items", ((string)(null)), table3789, "When ");
#line hidden
#line 41
 testRunner.Then("\"OwnerPrivate\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3790 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3790.AddRow(new string[] {
                            "ZZHYOLP1V7STML"});
                table3790.AddRow(new string[] {
                            "VMI480Z5UKTLLK"});
                table3790.AddRow(new string[] {
                            "6B512UPQFLSOVF"});
                table3790.AddRow(new string[] {
                            "CLUSTERSSAS"});
#line 44
 testRunner.When("User create static list with \"NotOwnerSpecifiedAdmin\" name on \"Devices\" page with" +
                        " following items", ((string)(null)), table3790, "When ");
#line hidden
#line 50
 testRunner.Then("\"NotOwnerSpecifiedAdmin\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.When("User selects \'Specific users / teams\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.When("User clicks \'person_add\' icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.When("User selects \'Admin\' in the \'Permission\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.When("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.When("User selects \'Test DAS12602\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3791 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3791.AddRow(new string[] {
                            "07PZNEOU91VWVH"});
                table3791.AddRow(new string[] {
                            "0A88YQHT6IMTTZ"});
                table3791.AddRow(new string[] {
                            "0CFTD5FV5F7FDF"});
                table3791.AddRow(new string[] {
                            "0E9XQC02MAZUR2"});
#line 61
 testRunner.When("User create static list with \"NotOwnerSpecifiedEdit\" name on \"Devices\" page with " +
                        "following items", ((string)(null)), table3791, "When ");
#line hidden
#line 67
 testRunner.Then("\"NotOwnerSpecifiedEdit\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.When("User selects \'Specific users / teams\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.When("User clicks \'person_add\' icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.When("User selects \'Edit\' in the \'Permission\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.When("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.When("User selects \'Test DAS12602\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3792 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3792.AddRow(new string[] {
                            "VMI480Z5UKTLLK"});
                table3792.AddRow(new string[] {
                            "6B512UPQFLSOVF"});
                table3792.AddRow(new string[] {
                            "0CFTD5FV5F7FDF"});
                table3792.AddRow(new string[] {
                            "0E9XQC02MAZUR2"});
#line 78
 testRunner.When("User create static list with \"NotOwnerSpecifiedRead\" name on \"Devices\" page with " +
                        "following items", ((string)(null)), table3792, "When ");
#line hidden
#line 84
 testRunner.Then("\"NotOwnerSpecifiedRead\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.When("User selects \'Specific users / teams\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.When("User clicks \'person_add\' icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.And("User select current user in Select User dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.When("User selects \'Read\' in the \'Permission\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.When("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 91
 testRunner.When("User selects \'Test DAS12602\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3793 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3793.AddRow(new string[] {
                            "TVGU1Y24UU9QBQ"});
                table3793.AddRow(new string[] {
                            "O0DOUNEKCY7HXK"});
                table3793.AddRow(new string[] {
                            "5PH0YQ5TNBLFZBM"});
                table3793.AddRow(new string[] {
                            "SANOFI2-POC"});
#line 95
 testRunner.When("User create static list with \"NotOwnerEveryoneCanEdit\" name on \"Devices\" page wit" +
                        "h following items", ((string)(null)), table3793, "When ");
#line hidden
#line 101
 testRunner.Then("\"NotOwnerEveryoneCanEdit\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.When("User selects \'Everyone can edit\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.When("User selects \'Test DAS12602\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 105
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3794 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3794.AddRow(new string[] {
                            "9K9Y2LGOD3Z1KW"});
                table3794.AddRow(new string[] {
                            "HW9RNYX1SNE3BN"});
                table3794.AddRow(new string[] {
                            "CAS"});
                table3794.AddRow(new string[] {
                            "WIN8RETAILPRO"});
#line 108
 testRunner.When("User create static list with \"NotOwnerEveryoneCanSee\" name on \"Devices\" page with" +
                        " following items", ((string)(null)), table3794, "When ");
#line hidden
#line 114
 testRunner.Then("\"NotOwnerEveryoneCanSee\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 116
 testRunner.When("User selects \'Everyone can see\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 117
 testRunner.When("User selects \'Test DAS12602\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 118
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 119
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 120
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 121
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 122
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 123
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.When("User selects \'Add to static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3795 = new TechTalk.SpecFlow.Table(new string[] {
                            "Listnames"});
                table3795.AddRow(new string[] {
                            "NotOwnerEveryoneCanEdit"});
                table3795.AddRow(new string[] {
                            "NotOwnerSpecifiedAdmin"});
                table3795.AddRow(new string[] {
                            "NotOwnerSpecifiedEdit"});
                table3795.AddRow(new string[] {
                            "OwnerPrivate"});
#line 125
 testRunner.Then("following Values are displayed in the \'Choose static list\' dropdown:", ((string)(null)), table3795, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
