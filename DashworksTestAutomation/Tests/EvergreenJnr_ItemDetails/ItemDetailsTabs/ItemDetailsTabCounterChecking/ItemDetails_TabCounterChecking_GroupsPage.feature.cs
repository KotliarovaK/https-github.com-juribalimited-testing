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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsTabs.ItemDetailsTabCounterChecking
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_TabCounterChecking_GroupsPage")]
    public partial class ItemDetails_TabCounterChecking_GroupsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyF" +
            "orGroupsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Groups")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16833")]
        [NUnit.Framework.CategoryAttribute("DAS17415")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyF" +
                    "orGroupsPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16833",
                        "DAS17415",
                        "Not_Ready"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 11
 testRunner.When("User type \"Allowed RODC Password Replication Group\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("User clicks on \"Allowed RODC Password Replication Group\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("Details page for \"Allowed RODC Password Replication Group\" item is displayed to t" +
                    "he user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabName"});
            table1.AddRow(new string[] {
                        "Applications"});
            table1.AddRow(new string[] {
                        "Members"});
#line 14
 testRunner.And("User sees following main-tabs on left menu on the Details page:", ((string)(null)), table1, "And ");
#line 18
 testRunner.And("\"Group\" tab is displayed on left menu on the Details page and NOT contains count " +
                    "of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("\"LDAP\" tab is displayed on left menu on the Details page and NOT contains count o" +
                    "f items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table2.AddRow(new string[] {
                        "Applications"});
            table2.AddRow(new string[] {
                        "Collections"});
#line 21
 testRunner.And("\"Applications\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table2, "And ");
#line 26
 testRunner.And("\"Applications\" tab is displayed on left menu on the Details page and contains cou" +
                    "nt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("\"Collections\" tab is displayed on left menu on the Details page and contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table3.AddRow(new string[] {
                        "User Members"});
            table3.AddRow(new string[] {
                        "Device Members"});
            table3.AddRow(new string[] {
                        "Member Of"});
#line 29
 testRunner.Then("\"Members\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table3, "Then ");
#line 35
 testRunner.And("\"User Members\" tab is displayed on left menu on the Details page and contains cou" +
                    "nt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("\"Device Members\" tab is displayed on left menu on the Details page and contains c" +
                    "ount of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("\"Member Of\" tab is displayed on left menu on the Details page and contains count " +
                    "of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
