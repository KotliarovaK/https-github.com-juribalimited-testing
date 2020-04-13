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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.GroupDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_TabCounterChecking_GroupsPage")]
    public partial class ItemDetails_TabCounterChecking_GroupsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetails_TabCounterChecking_GroupsPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_TabCounterChecking_GroupsPage", "\tRuns Item Details TabCounterChecking_GroupsPage related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyF" +
            "orGroupsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Groups")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16833")]
        [NUnit.Framework.CategoryAttribute("DAS17415")]
        public virtual void EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForGroupsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForGroupsPageInternal();
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

        private void EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForGroupsPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16833",
                    "DAS17415"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyF" +
                    "orGroupsPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16833",
                        "DAS17415"});
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
#line 10
 testRunner.When("User type \"Allowed RODC Password Replication Group\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("User clicks on \"Allowed RODC Password Replication Group\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.And("Details page for \'Allowed RODC Password Replication Group\' item is displayed to t" +
                        "he user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2739 = new TechTalk.SpecFlow.Table(new string[] {
                            "TabName"});
                table2739.AddRow(new string[] {
                            "Applications"});
                table2739.AddRow(new string[] {
                            "Members"});
#line 13
 testRunner.And("User sees following parent left menu items", ((string)(null)), table2739, "And ");
#line hidden
#line 17
 testRunner.And("\'Group\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("\'LDAP\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2740 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2740.AddRow(new string[] {
                            "Applications"});
                table2740.AddRow(new string[] {
                            "Collections"});
#line 21
 testRunner.Then("\'Applications\' left menu have following submenu items:", ((string)(null)), table2740, "Then ");
#line hidden
#line 26
 testRunner.And("\'Applications\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("\'Collections\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("User navigates to the \'Members\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2741 = new TechTalk.SpecFlow.Table(new string[] {
                            "SubTabName"});
                table2741.AddRow(new string[] {
                            "User Members"});
                table2741.AddRow(new string[] {
                            "Device Members"});
                table2741.AddRow(new string[] {
                            "Member Of"});
#line 30
 testRunner.Then("\'Members\' left menu have following submenu items:", ((string)(null)), table2741, "Then ");
#line hidden
#line 36
 testRunner.And("\'User Members\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("\'Device Members\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("\'Member Of\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion