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
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "options"});
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
#line 21
 testRunner.When("User clicks Cog-menu for \'Unassigned\' item in the \'Ring\' column and sees followin" +
                    "g cog-menu options", ((string)(null)), table3, "When ");
#line 28
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("User enters \'14695_Ring\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("\'The ring has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User enters \'Ring_Test\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.When("User clicks Default Ring checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("User opens \'Ring\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("Column Settings was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When("User select \"Display Order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
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
#line 43
 testRunner.Then("User sees following Display order on the Automation page", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table5.AddRow(new string[] {
                        "Unassigned"});
            table5.AddRow(new string[] {
                        "14695_Ring"});
            table5.AddRow(new string[] {
                        "Ring_Test"});
#line 48
 testRunner.Then("Content in the \'Ring\' column is equal to", ((string)(null)), table5, "Then ");
#line 53
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("data in table is sorted by \'Ring\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("data in table is sorted by \'Ring\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "options"});
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
#line 57
 testRunner.When("User clicks Cog-menu for \'Unassigned\' item in the \'Ring\' column and sees followin" +
                    "g cog-menu options", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table7.AddRow(new string[] {
                        "Unassigned"});
#line 66
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table7, "When ");
#line 69
 testRunner.And("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("\'This ring will be permanently deleted and any objects within it reassigned to th" +
                    "e default ring\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 76
 testRunner.When("User navigates to \"Email Migration\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("Page with \'Email Migration\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User navigates to the \'Rings\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("\'729\' content is displayed in the \'Mailboxes\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Ring"});
            table8.AddRow(new string[] {
                        ""});
            table8.AddRow(new string[] {
                        "Default"});
            table8.AddRow(new string[] {
                        "Mailboxes"});
#line 80
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table8, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "options"});
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
#line 86
 testRunner.When("User clicks Cog-menu for \'Unassigned\' item in the \'Ring\' column and sees followin" +
                    "g cog-menu options", ((string)(null)), table9, "When ");
#line 93
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.When("User enters \'14705_Ring\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("\'The ring has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("User clicks \'CREATE PROJECT RING\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("Page with \'Create Project Ring\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When("User enters \'Ring_Test\' text to \'Ring name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.And("User clicks Create button on the Create Ring page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("data in table is sorted by \'Ring\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "options"});
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
#line 104
 testRunner.When("User clicks Cog-menu for \'14705_Ring\' item in the \'Ring\' column and sees followin" +
                    "g cog-menu options", ((string)(null)), table10, "When ");
#line 113
 testRunner.When("User clicks on \'Ring\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.Then("data in table is sorted by \'Ring\' column in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table11.AddRow(new string[] {
                        "Ring_Test"});
            table11.AddRow(new string[] {
                        "14705_Ring"});
#line 115
 testRunner.When("User select \"Ring\" rows in the grid", ((string)(null)), table11, "When ");
#line 119
 testRunner.And("User selects \'Delete\' in the \'Actions\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When("User clicks \'DELETE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.Then("\'These rings will be permanently deleted and any objects within them reassigned t" +
                    "o the default ring\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

