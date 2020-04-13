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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent.ActionsWithTableContent
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CheckingColumnsOrder")]
    public partial class CheckingColumnsOrderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CheckingColumnsOrder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CheckingColumnsOrder", "\tRuns Item Details Checking Columns Order related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDet" +
            "ailsPageForProjectMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17182")]
        [NUnit.Framework.CategoryAttribute("DAS17218")]
        [NUnit.Framework.CategoryAttribute("DAS11053")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDetailsPageForProjectMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDetailsPageForProjectModeInternal();
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

        private void EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDetailsPageForProjectModeInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17182",
                    "DAS17218",
                    "DAS11053",
                    "DAS14923",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDet" +
                    "ailsPageForProjectMode", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17182",
                        "DAS17218",
                        "DAS11053",
                        "DAS14923",
                        "Zion_NewGrid"});
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
 testRunner.When("User navigates to the \'User\' details page for \'ZZP911429\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("Details page for \'ZZP911429\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User navigates to the \'Devices\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2798 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2798.AddRow(new string[] {
                            "Hostname"});
                table2798.AddRow(new string[] {
                            "Device Type"});
                table2798.AddRow(new string[] {
                            "Owner Display Name"});
                table2798.AddRow(new string[] {
                            "Operating System"});
                table2798.AddRow(new string[] {
                            "Compliance"});
#line 13
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table2798, "Then ");
#line hidden
#line 20
 testRunner.When("User selects \'User Evergreen Capacity Project\' in the \'Item Details Project\' drop" +
                        "down with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2799 = new TechTalk.SpecFlow.Table(new string[] {
                            "checkboxes"});
                table2799.AddRow(new string[] {
                            "Operating System"});
#line 21
 testRunner.When("User clicks following checkboxes from Column Settings panel for the \'Hostname\' co" +
                        "lumn:", ((string)(null)), table2799, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2800 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table2800.AddRow(new string[] {
                            "Hostname"});
                table2800.AddRow(new string[] {
                            "Device Type"});
                table2800.AddRow(new string[] {
                            "Owner"});
                table2800.AddRow(new string[] {
                            "Owner Display Name"});
                table2800.AddRow(new string[] {
                            "Readiness"});
                table2800.AddRow(new string[] {
                            "Path"});
                table2800.AddRow(new string[] {
                            "Category"});
                table2800.AddRow(new string[] {
                            "Application Readiness"});
                table2800.AddRow(new string[] {
                            "Stage 1"});
#line 24
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table2800, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
