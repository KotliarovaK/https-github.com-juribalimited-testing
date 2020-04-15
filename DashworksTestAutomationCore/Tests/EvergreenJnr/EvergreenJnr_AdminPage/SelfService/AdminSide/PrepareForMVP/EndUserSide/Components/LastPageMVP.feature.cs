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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.EndUserSide.Components
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LastPageMVP")]
    public partial class LastPageMVPFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "LastPageMVP.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LastPageMVP", "\t\tScenarios related to last End User page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEndUserLastPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20325")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("SelfServiceMVP")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEndUserLastPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEndUserLastPageInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEndUserLastPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20325",
                    "Cleanup",
                    "SelfServiceMVP"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEndUserLastPage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20325",
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
                TechTalk.SpecFlow.Table table1643 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1643.AddRow(new string[] {
                            "VSCmdShell"});
#line 10
 testRunner.When("User create static list with \"DAS_20325\" name on \"Applications\" page with followi" +
                        "ng items", ((string)(null)), table1643, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1644 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1644.AddRow(new string[] {
                            "DAS_20325_SS_1",
                            "20325_1_SI",
                            "true",
                            "true",
                            "DAS_20325"});
#line 17
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1644, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1645 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission"});
                table1645.AddRow(new string[] {
                            "AOC Name",
                            "2004 Rollout",
                            "Do not allow owner to be changed"});
#line 20
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                        "via API", ((string)(null)), table1645, "When ");
#line hidden
#line 23
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("User sees item with \'Text\' type and \'Thank You\' name on Self Service Builder Pane" +
                        "l", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When("User navigates to End User landing page with \'20325_1_SI\' Self Service Identifier" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.When("User clicks on \'Continue\' button on end user Self Service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("Header is displayed on End User page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("Subject Title \'Application: VSCmdShell\' is displayed on End User page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Then("\'Continue\' button is not displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("\'Undo all changes I made on this page\' button is not displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.Then("\'Back\' button displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.Then("User sees \'Thank You\' text component \'Thank You\' on end user page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.Then("User sees \'You have completed the self service.\' text styled as \'Normal\' in \'Than" +
                        "k You\' Text Component of \'Thank You\' on end user page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.Then("User sees \'You can now close the page.\' text styled as \'Normal\' in \'Thank You\' Te" +
                        "xt Component of \'Thank You\' on end user page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEndUserPageDisplayedCorrec" +
            "tly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20291")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEndUserPageDisplayedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEndUserPageDisplayedCorrectlyInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEndUserPageDisplayedCorrectlyInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20291",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEndUserPageDisplayedCorrec" +
                    "tly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20291",
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
                TechTalk.SpecFlow.Table table1646 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1646.AddRow(new string[] {
                            "VSCmdShell"});
#line 38
 testRunner.When("User create static list with \"DAS_20291\" name on \"Applications\" page with followi" +
                        "ng items", ((string)(null)), table1646, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1647 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1647.AddRow(new string[] {
                            "DAS_20291_SS_1",
                            "20291_1_SI",
                            "true",
                            "true",
                            "DAS_20291"});
#line 45
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1647, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1648 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission"});
                table1648.AddRow(new string[] {
                            "AOC Name",
                            "2004 Rollout",
                            "Allow owner to be set to another user only"});
#line 48
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                        "via API", ((string)(null)), table1648, "When ");
#line hidden
#line 51
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.And("User selects \'Edit\' cogmenu option for \'Page\' item type with \'Welcome\' name on Se" +
                        "lf Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("User enters \'First Page\' text to \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.Then("Page with \'First Page\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.When("User navigates to End User landing page with \'20291_1_SI\' Self Service Identifier" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("Subject Title \'Application: VSCmdShell\' is displayed on End User page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.Then("Page with \'First Page\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.Then("\'Continue\' button displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.Then("\'Back\' button displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then("\'Back\' button is disabled for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_CheckComponentOnEndUserPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS20342")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_CheckComponentOnEndUserPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_CheckComponentOnEndUserPageInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_CheckComponentOnEndUserPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS20342",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_CheckComponentOnEndUserPage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS20342",
                        "Cleanup"});
#line 64
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
                TechTalk.SpecFlow.Table table1649 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table1649.AddRow(new string[] {
                            "VSCmdShell"});
#line 65
 testRunner.When("User create static list with \"DAS_20342\" name on \"Applications\" page with followi" +
                        "ng items", ((string)(null)), table1649, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1650 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "ServiceIdentifier",
                            "Enabled",
                            "AllowAnonymousUsers",
                            "Scope"});
                table1650.AddRow(new string[] {
                            "DAS_20342_SS_1",
                            "20342_1_SI",
                            "true",
                            "true",
                            "DAS_20342"});
#line 72
 testRunner.When("User creates Self Service via API and open it", ((string)(null)), table1650, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1651 = new TechTalk.SpecFlow.Table(new string[] {
                            "ComponentName",
                            "ProjectName",
                            "OwnerPermission",
                            "ShowInSelfService"});
                table1651.AddRow(new string[] {
                            "AOC Name",
                            "2004 Rollout",
                            "Do not allow owner to be changed",
                            "true"});
#line 75
 testRunner.When("User creates new application ownership component for \'Welcome\' Self Service page " +
                        "via API", ((string)(null)), table1651, "When ");
#line hidden
#line 78
 testRunner.When("User navigates to End User landing page with \'20342_1_SI\' Self Service Identifier" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("\'Owner\' button is not displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.Then("\'Remove Owner\' button is not displayed for End User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1652 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstColumn",
                            "SecondColumn"});
                table1652.AddRow(new string[] {
                            "Username",
                            "VGZ6407126"});
                table1652.AddRow(new string[] {
                            "Domain",
                            "FR"});
                table1652.AddRow(new string[] {
                            "Display Name",
                            "Arlette Sicard"});
#line 81
 testRunner.Then("User sees following items for \'AOC Name\' application ownership component on \'Welc" +
                        "ome\' end user page", ((string)(null)), table1652, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
