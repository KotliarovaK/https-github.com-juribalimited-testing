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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.AdminSide.PrepareForMVP.Builder
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SelfServiceBuilderContextPanelActions", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatIfdDifferentPageCogmenuIsO" +
            "penedThePageDoesNotLoadInTheBuilderDesignPanel")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS18994")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatIfdDifferentPageCogmenuIsOpenedThePageDoesNotLoadInTheBuilderDesignPanel()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatIfdDifferentPageCogmenuIsOpenedThePageDoesNotLoadInTheBuilderDesignPanelInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatIfdDifferentPageCogmenuIsOpenedThePageDoesNotLoadInTheBuilderDesignPanelInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS18994",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatIfdDifferentPageCogmenuIsO" +
                    "penedThePageDoesNotLoadInTheBuilderDesignPanel", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS18994",
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
                TechTalk.SpecFlow.Table table1222 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1222.AddRow(new string[] {
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
                            "1803 Apps"});
#line 10
    testRunner.When("User creates Self Service via API", ((string)(null)), table1222, "When ");
#line hidden
#line 13
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.When("User navigates to the \'Self Services\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_1\' item from \'Self Service Na" +
                        "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1223 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "ObjectTypeId",
                            "DisplayName",
                            "ShowInSelfService"});
                table1223.AddRow(new string[] {
                            "Test_ID_1",
                            "TestPageName_1",
                            "3",
                            "TestPageDisplayName_1",
                            "true"});
                table1223.AddRow(new string[] {
                            "Test_ID_2",
                            "TestPageName_2",
                            "3",
                            "TestPageDisplayName_2",
                            "true"});
                table1223.AddRow(new string[] {
                            "Test_ID_3",
                            "TestPageName_3",
                            "3",
                            "TestPageDisplayName_3",
                            "true"});
#line 17
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1223, "When ");
#line hidden
#line 22
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
    testRunner.When("User clicks on cogmenu button for item with \'Page\' type and \'TestPageName_3\' name" +
                        " on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("Item with \'Page\' type and \'TestPageDisplayName_1\' name on Self Service Builder Pa" +
                        "nel is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatReorderingCogMenuOptionsDi" +
            "splaysProperlyAccordingToItemsPlaceInRightSidePanel")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS18994")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatReorderingCogMenuOptionsDisplaysProperlyAccordingToItemsPlaceInRightSidePanel()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatReorderingCogMenuOptionsDisplaysProperlyAccordingToItemsPlaceInRightSidePanelInternal();
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

        private void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatReorderingCogMenuOptionsDisplaysProperlyAccordingToItemsPlaceInRightSidePanelInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS18994",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatReorderingCogMenuOptionsDi" +
                    "splaysProperlyAccordingToItemsPlaceInRightSidePanel", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS18994",
                        "Cleanup"});
#line 27
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
                TechTalk.SpecFlow.Table table1224 = new TechTalk.SpecFlow.Table(new string[] {
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
                table1224.AddRow(new string[] {
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
                            "1803 Apps"});
#line 28
    testRunner.When("User creates Self Service via API", ((string)(null)), table1224, "When ");
#line hidden
#line 31
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.When("User navigates to the \'Self Services\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_1\' item from \'Self Service Na" +
                        "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1225 = new TechTalk.SpecFlow.Table(new string[] {
                            "ServiceIdentifier",
                            "Name",
                            "ObjectTypeId",
                            "DisplayName",
                            "ShowInSelfService"});
                table1225.AddRow(new string[] {
                            "Test_ID_1",
                            "TestPageName_1",
                            "3",
                            "TestPageDisplayName_1",
                            "true"});
                table1225.AddRow(new string[] {
                            "Test_ID_2",
                            "TestPageName_2",
                            "3",
                            "TestPageDisplayName_2",
                            "true"});
                table1225.AddRow(new string[] {
                            "Test_ID_3",
                            "TestPageName_3",
                            "3",
                            "TestPageDisplayName_3",
                            "true"});
#line 35
 testRunner.When("User creates new Self Service Page via API", ((string)(null)), table1225, "When ");
#line hidden
#line 40
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1226 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1226.AddRow(new string[] {
                            "Edit"});
                table1226.AddRow(new string[] {
                            "Move to bottom"});
#line 41
    testRunner.Then("User clicks on cogmenu button for item with \'Page\' type and \'TestPageName_1\' name" +
                        " on Self Service Builder Panel and sees the following cogmenu options", ((string)(null)), table1226, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1227 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1227.AddRow(new string[] {
                            "Edit"});
                table1227.AddRow(new string[] {
                            "Move to top"});
                table1227.AddRow(new string[] {
                            "Move to bottom"});
#line 45
 testRunner.Then("User clicks on cogmenu button for item with \'Page\' type and \'TestPageName_2\' name" +
                        " on Self Service Builder Panel and sees the following cogmenu options", ((string)(null)), table1227, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1228 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table1228.AddRow(new string[] {
                            "Edit"});
                table1228.AddRow(new string[] {
                            "Move to top"});
#line 50
 testRunner.Then("User clicks on cogmenu button for item with \'Page\' type and \'TestPageName_3\' name" +
                        " on Self Service Builder Panel and sees the following cogmenu options", ((string)(null)), table1228, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion