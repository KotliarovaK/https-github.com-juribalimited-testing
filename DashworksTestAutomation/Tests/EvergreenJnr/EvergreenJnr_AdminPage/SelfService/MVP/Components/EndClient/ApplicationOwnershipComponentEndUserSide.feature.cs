// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.MVP.Components.EndClient
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ApplicationOwnershipComponentEndUserSide")]
    public partial class ApplicationOwnershipComponentEndUserSideFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ApplicationOwnershipComponentEndUserSide.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ApplicationOwnershipComponentEndUserSide", "\t\tScenarios related to last End User page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndU" +
            "serSide")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20421")]
        [NUnit.Framework.CategoryAttribute("DAS20322")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("SelfServiceMVP")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndUserSide()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndUserSideInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndUserSideInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndU" +
                    "serSide", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20421",
                        "DAS20322",
                        "Cleanup",
                        "SelfServiceMVP"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "values"});
            table1.AddRow(new string[] {
                        "VSCmdShell"});
#line 10
 testRunner.Given("User resync \'Application\' objects for \'2004 Rollout\' project", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table2.AddRow(new string[] {
                        "VSCmdShell"});
#line 13
 testRunner.When("User create static list with \"DAS_20421\" name on \"Applications\" page with followi" +
                    "ng items", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table3.AddRow(new string[] {
                        "DAS_20421_SS_1",
                        "20421_1_SI",
                        "true",
                        "true",
                        "DAS_20421"});
#line 20
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComponentName",
                        "ProjectName",
                        "OwnerPermission"});
            table4.AddRow(new string[] {
                        "AOC Name",
                        "2004 Rollout",
                        "Allow owner to be removed only"});
#line 23
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                    "via API", ((string)(null)), table4, "When ");
#line 26
 testRunner.When("User navigates to End User landing page with \'20421_1_SI\' Self Service Identifier" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.When("User clicks on \'Remove Owner\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\'Remove Owner\' button is disabled for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstColumn",
                        "SecondColumn"});
            table5.AddRow(new string[] {
                        "Username",
                        ""});
            table5.AddRow(new string[] {
                        "Domain",
                        ""});
            table5.AddRow(new string[] {
                        "Display Name",
                        ""});
#line 29
 testRunner.Then("User sees following items for \'AOC Name\' application ownership component on \'Welc" +
                    "ome\' end user page", ((string)(null)), table5, "Then ");
#line 34
 testRunner.When("User clicks on \'Continue\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.When("User navigates to the \'Application\' details page for \'VSCmdShell\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.When("User selects \'2004 Rollout\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table6.AddRow(new string[] {
                        "App Owner",
                        ""});
#line 39
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndU" +
            "serSide")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20421")]
        [NUnit.Framework.CategoryAttribute("DAS20426")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("SelfServiceMVP")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndUserSide()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndUserSideInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndUserSideInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndU" +
                    "serSide", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20421",
                        "DAS20426",
                        "Cleanup",
                        "SelfServiceMVP"});
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table7.AddRow(new string[] {
                        "DAS_20421_Proj",
                        "All Users",
                        "None",
                        "Standalone Project"});
#line 45
 testRunner.When("Project created via API and opened", ((string)(null)), table7, "When ");
#line 49
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table8.AddRow(new string[] {
                        "024213574157421A9CD (Reyes, Natasha)"});
            table8.AddRow(new string[] {
                        "03C54BC1198843A4A03 (Jones, Tina)"});
#line 52
 testRunner.When("User expands \'Users to add\' multiselect to the \'Users\' tab on Project Scope Chang" +
                    "es page and selects following Objects", ((string)(null)), table8, "When ");
#line 56
 testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
    testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table9.AddRow(new string[] {
                        "VSCmdShell"});
#line 60
    testRunner.When("User expands \'Applications to add\' multiselect to the \'Applications\' tab on Proje" +
                    "ct Scope Changes page and selects following Objects", ((string)(null)), table9, "When ");
#line 63
    testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
    testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table10.AddRow(new string[] {
                        "03C54BC1198843A4A03"});
            table10.AddRow(new string[] {
                        "024213574157421A9CD"});
#line 65
 testRunner.When("User create static list with \"DAS_20421_forComponent\" name on \"Users\" page with f" +
                    "ollowing items", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table11.AddRow(new string[] {
                        "VSCmdShell"});
#line 69
 testRunner.When("User create static list with \"DAS_20421\" name on \"Applications\" page with followi" +
                    "ng items", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table12.AddRow(new string[] {
                        "DAS_20421_SS_1",
                        "20421_1_SI",
                        "true",
                        "true",
                        "DAS_20421"});
#line 72
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table12, "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComponentName",
                        "ProjectName",
                        "OwnerPermission",
                        "UserScope"});
            table13.AddRow(new string[] {
                        "AOC Name",
                        "DAS_20421_Proj",
                        "Allow owner to be set to another user only",
                        "DAS_20421_forComponent"});
#line 75
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                    "via API", ((string)(null)), table13, "When ");
#line 78
 testRunner.When("User navigates to End User landing page with \'20421_1_SI\' Self Service Identifier" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("User clicks on \'Change Owner\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then("popup with \'Change Owner\' title is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("\'Owner\' autocomplete is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.Then("\'Change Owner\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.Then("Button \'Change Owner\' has \'Some values are missing or not valid\' tooltip on popup" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User clicks \'Cancel\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("popup is not displayed to User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.When("User clicks on \'Change Owner\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.When("User enters \'Jones\' in the \'Owner\' autocomplete field and selects \'03C54BC1198843" +
                    "A4A03 (Jones, Tina)\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.When("User clicks \'Change Owner\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstColumn",
                        "SecondColumn"});
            table14.AddRow(new string[] {
                        "Username",
                        "03C54BC1198843A4A03"});
            table14.AddRow(new string[] {
                        "Domain",
                        "BCLABS"});
            table14.AddRow(new string[] {
                        "Display Name",
                        "Jones, Tina"});
#line 89
 testRunner.Then("User sees following items for \'AOC Name\' application ownership component on \'Welc" +
                    "ome\' end user page", ((string)(null)), table14, "Then ");
#line 94
 testRunner.When("User clicks on \'Continue\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.When("User navigates to the \'Application\' details page for \'VSCmdShell\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.When("User selects \'DAS_20421_Proj\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table15.AddRow(new string[] {
                        "App Owner",
                        "Jones Tina"});
#line 100
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table15, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserP" +
            "age")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20421")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("SelfServiceMVP")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserPageInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserP" +
                    "age", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20421",
                        "Cleanup",
                        "SelfServiceMVP"});
#line 105
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table16.AddRow(new string[] {
                        "VSCmdShell"});
#line 106
 testRunner.When("User create static list with \"DAS_20421\" name on \"Applications\" page with followi" +
                    "ng items", ((string)(null)), table16, "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "AllowAnonymousUsers",
                        "Scope"});
            table17.AddRow(new string[] {
                        "DAS_20421_SS_1",
                        "20421_1_SI",
                        "true",
                        "true",
                        "DAS_20421"});
#line 113
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table17, "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "ComponentName",
                        "ProjectName",
                        "OwnerPermission"});
            table18.AddRow(new string[] {
                        "AOC Name",
                        "2004 Rollout",
                        "Allow owner to be removed or set to another user"});
#line 116
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                    "via API", ((string)(null)), table18, "When ");
#line 119
 testRunner.When("User navigates to End User landing page with \'20421_1_SI\' Self Service Identifier" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.When("User clicks on \'Change Owner\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.Then("popup with \'Change Owner\' title is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.Then("\'Remove owner\' radio button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.Then("\'Assign an owner\' radio button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.Then("\'Change Owner\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.Then("Button \'Change Owner\' has \'Some values are missing or not valid\' tooltip on popup" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.Then("\'Change Owner\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.Then("\'Cancel\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.When("User checks \'Remove owner\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("\'Change Owner\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.When("User checks \'Assign an owner\' radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
 testRunner.Then("\'Owner\' autocomplete is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.Then("\'Change Owner\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.Then("Button \'Change Owner\' has \'Some values are missing or not valid\' tooltip on popup" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.Then("\'Cancel\' button is not disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

