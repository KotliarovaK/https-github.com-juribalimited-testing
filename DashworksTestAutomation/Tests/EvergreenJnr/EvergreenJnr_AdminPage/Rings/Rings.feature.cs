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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Rings
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Rings")]
    public partial class RingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Rings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Rings", "\tRuns Rings related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS14780")]
        [NUnit.Framework.CategoryAttribute("DAS13530")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChangedInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChangedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS14780",
                        "DAS13530",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table1.AddRow(new string[] {
                        "ProjectForDAS14780",
                        "All Devices",
                        "None",
                        "Clone from Evergreen to Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1, "When ");
#line 13
 testRunner.Then("Page with \'ProjectForDAS14780\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("\'Clone evergreen rings to project rings\' content is displayed in \'Rings\' dropdown" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And("User enters \"Unassigned\" text in the Search field for \"Ring\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User clicks content from \"Ring\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("Ring settings Maps to evergreen ring is displayed as \"Unassigned\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User sets \"None\" value in Maps to evergreen ring field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("Ring settings Maps to evergreen ring is displayed as \"None\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.When("User clicks \'Administration\' header breadcrumb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("User clicks Yes button in Leave Page Warning", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("User selects \"Select All\" checkbox from String Filter with item list on the Admin" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User selects \"ProjectForDAS14780\" checkbox from String Filter with item list on t" +
                    "he Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table2.AddRow(new string[] {
                        "Unassigned"});
#line 31
 testRunner.Then("Content in the \'Bucket\' column is equal to", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdown")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS12452")]
        [NUnit.Framework.CategoryAttribute("DAS14690")]
        [NUnit.Framework.CategoryAttribute("DAS14691")]
        [NUnit.Framework.CategoryAttribute("DAS15370")]
        [NUnit.Framework.CategoryAttribute("DAS14692")]
        [NUnit.Framework.CategoryAttribute("DAS14695")]
        [NUnit.Framework.CategoryAttribute("DAS15415")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdown()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdownInternal();
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

        private void EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdownInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdown", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS12452",
                        "DAS14690",
                        "DAS14691",
                        "DAS15370",
                        "DAS14692",
                        "DAS14695",
                        "DAS15415",
                        "Cleanup"});
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table3.AddRow(new string[] {
                        "14690_Project",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 37
 testRunner.When("Project created via API and opened", ((string)(null)), table3, "When ");
#line 40
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.When("User clicks content from \"Ring\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("\"Unassigned\" content is displayed in \"Ring name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Then("\"Unassigned\" content is displayed in \"Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.When("User enters \'NewDescription\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("\'UPDATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.Then("\"Default Ring\" checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.Then("\'Maps to Evergreen Ring\' dropdown is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("\'TRUE\' content is displayed in the \'Default\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User opens \'Ring\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("User select \"Maps to Evergreen\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Maps to Evergreen"});
#line 55
 testRunner.Then("Content is empty in the column", ((string)(null)), table4, "Then ");
#line 58
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.And("User changes Project Name to \"New_14690_Project\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.Then("\"14690_Pro\" content is displayed in \"Project Short Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("User changes Project Short Name to \"New_Short\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("\"14690_Project\" content is displayed in \"Project Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User changes Project Description to \"New_14690_Description\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.When("User selects \"Clone evergreen buckets to project buckets\" in the Buckets Project " +
                    "dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("\"Device scoped project\" is displayed in the disabled Project Type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.When("User selects \"Clone evergreen buckets to project buckets\" in the Buckets Project " +
                    "dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("\'Use project rings\' content is displayed in \'Rings\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When("User selects \'Clone evergreen rings to project rings\' in the \'Rings\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.When("User clicks \'Projects\' header breadcrumb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.When("User enters \"New_14690_Project\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Then("Page with \'New_14690_Project\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("\'Clone evergreen buckets to project buckets\' content is displayed in \'Buckets\' dr" +
                    "opdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.Then("\'Clone evergreen rings to project rings\' content is displayed in \'Rings\' dropdown" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.Then("\"New_Short\" content is displayed in \"Project Short Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRows")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS15906")]
        public virtual void EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRows()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRowsInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRowsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRows", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS15906"});
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 80
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.And("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.Then("Page with \'Rings\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Checkboxes",
                        "State"});
            table5.AddRow(new string[] {
                        "Ring",
                        "true"});
#line 85
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table5, "When ");
#line 88
 testRunner.Then("Cog menu is not displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

