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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Rings
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GridScreenForListScopedProject")]
    public partial class GridScreenForListScopedProjectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GridScreenForListScopedProject.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GridScreenForListScopedProject", "\tCheck grid screen for Devices/Mailboxes Scoped Project", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS12452")]
        [NUnit.Framework.CategoryAttribute("DAS14695")]
        [NUnit.Framework.CategoryAttribute("DAS14697")]
        [NUnit.Framework.CategoryAttribute("DAS15180")]
        [NUnit.Framework.CategoryAttribute("DAS15826")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProjectInternal();
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

        private void EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS12452",
                        "DAS14695",
                        "DAS14697",
                        "DAS15180",
                        "DAS15826",
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
                        "14695_Project",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1, "When ");
#line 13
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("\'\' content is displayed in the \'Devices\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Ring"});
            table2.AddRow(new string[] {
                        ""});
            table2.AddRow(new string[] {
                        "Default"});
            table2.AddRow(new string[] {
                        "Devices"});
#line 15
 testRunner.Then("table with Setting menu column on Admin page is displayed in following order:", ((string)(null)), table2, "Then ");
#line 21
 testRunner.When("User clicks Cog-menu on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table3.AddRow(new string[] {
                        "Edit"});
            table3.AddRow(new string[] {
                        "Duplicate"});
            table3.AddRow(new string[] {
                        "Move to top"});
            table3.AddRow(new string[] {
                        "Move to bottom"});
            table3.AddRow(new string[] {
                        "Move to position"});
#line 22
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table3, "Then ");
#line 29
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User enters \'14695_Ring\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then("Success message is displayed and contains \"The ring has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User enters \'Ring_Test\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("User clicks Default Ring checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("User have opened Column Settings for \"Ring\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("Column Settings was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.When("User select \"Display Order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table4.AddRow(new string[] {
                        "1"});
            table4.AddRow(new string[] {
                        "2"});
            table4.AddRow(new string[] {
                        "3"});
#line 44
 testRunner.Then("User sees following Display order on the Automation page", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table5.AddRow(new string[] {
                        "Unassigned"});
            table5.AddRow(new string[] {
                        "14695_Ring"});
            table5.AddRow(new string[] {
                        "Ring_Test"});
#line 49
 testRunner.Then("\"Ring\" column content is displayed in the following order:", ((string)(null)), table5, "Then ");
#line 54
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("data in table is sorted by \"Ring\" column in ascending order on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("data in table is sorted by \"Ring\" column in descending order on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.When("User clicks Cog-menu on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table6.AddRow(new string[] {
                        "Edit"});
            table6.AddRow(new string[] {
                        "Duplicate"});
            table6.AddRow(new string[] {
                        "Move to top"});
            table6.AddRow(new string[] {
                        "Move to bottom"});
            table6.AddRow(new string[] {
                        "Move to position"});
            table6.AddRow(new string[] {
                        "Set default"});
            table6.AddRow(new string[] {
                        "Delete"});
#line 59
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table7.AddRow(new string[] {
                        "Unassigned"});
#line 68
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table7, "When ");
#line 71
 testRunner.And("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("Warning message with \"This ring will be permanently deleted and any objects withi" +
                    "n it reassigned to the default ring\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.When("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Rings")]
        [NUnit.Framework.CategoryAttribute("DAS12452")]
        [NUnit.Framework.CategoryAttribute("DAS14705")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProjectInternal();
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

        private void EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Rings",
                        "DAS12452",
                        "DAS14705",
                        "Cleanup"});
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 78
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User enters \"Email Migration\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.Then("Page with \'Email Migration\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("\'729\' content is displayed in the \'Mailboxes\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        ""});
            table8.AddRow(new string[] {
                        "Ring"});
            table8.AddRow(new string[] {
                        ""});
            table8.AddRow(new string[] {
                        "Default"});
            table8.AddRow(new string[] {
                        "Mailboxes"});
#line 86
 testRunner.Then("Columns on Admin page is displayed in following order:", ((string)(null)), table8, "Then ");
#line 93
 testRunner.When("User clicks Cog-menu on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table9.AddRow(new string[] {
                        "Edit"});
            table9.AddRow(new string[] {
                        "Duplicate"});
            table9.AddRow(new string[] {
                        "Move to top"});
            table9.AddRow(new string[] {
                        "Move to bottom"});
            table9.AddRow(new string[] {
                        "Move to position"});
#line 94
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table9, "Then ");
#line 101
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User type \"14705_Ring\" Name in the \"Ring name\" field on the \'Email Migration\' Pro" +
                    "ject details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.Then("Success message is displayed and contains \"The ring has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.When("User type \"Ring_Test\" Name in the \"Ring name\" field on the \'Email Migration\' Proj" +
                    "ect details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("data in table is sorted by \"Ring\" column in ascending order on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User clicks Cog-menu on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table10.AddRow(new string[] {
                        "Edit"});
            table10.AddRow(new string[] {
                        "Duplicate"});
            table10.AddRow(new string[] {
                        "Move to top"});
            table10.AddRow(new string[] {
                        "Move to bottom"});
            table10.AddRow(new string[] {
                        "Move to position"});
            table10.AddRow(new string[] {
                        "Set default"});
            table10.AddRow(new string[] {
                        "Delete"});
#line 113
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table10, "Then ");
#line 122
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then("data in table is sorted by \"Ring\" column in descending order on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table11.AddRow(new string[] {
                        "Ring_Test"});
            table11.AddRow(new string[] {
                        "14705_Ring"});
#line 124
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table11, "When ");
#line 128
 testRunner.And("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("Warning message with \"These rings will be permanently deleted and any objects wit" +
                    "hin them reassigned to the default ring\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.When("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

