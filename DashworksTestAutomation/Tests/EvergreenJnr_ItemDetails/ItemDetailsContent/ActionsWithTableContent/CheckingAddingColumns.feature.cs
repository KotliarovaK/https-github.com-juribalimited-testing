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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsContent.ActionsWithTableContent
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CheckingAddingColumns")]
    public partial class CheckingAddingColumnsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CheckingAddingColumns.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CheckingAddingColumns", "\tRuns Item Details Checking Adding Columns related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSectio" +
            "ns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11732")]
        [NUnit.Framework.CategoryAttribute("DAS12235")]
        [NUnit.Framework.CategoryAttribute("DAS13409")]
        [NUnit.Framework.CategoryAttribute("DAS13657")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Applications", "Evergreen Summary", "Application", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Projects", "Projects", "Project", "Object ID", "Object ID", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Projects", "Projects", "Project", "Object Key", "Object Key", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSections(string pageName, string searchTerm, string mainTabName, string subTabName, string columnName, string checkboxName, string newColumnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSectionsInternal(pageName,searchTerm,mainTabName,subTabName,columnName,checkboxName,newColumnName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSectionsInternal(string pageName, string searchTerm, string mainTabName, string subTabName, string columnName, string checkboxName, string newColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11732",
                    "DAS12235",
                    "DAS13409",
                    "DAS13657",
                    "DAS14923"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSectio" +
                    "ns", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("Details page for \"{0}\" item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And(string.Format("User navigates to the \"{0}\" sub-menu on the Details page", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And(string.Format("User have opened Column Settings for \"{0}\" column in the Details Page table", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And(string.Format("User select \"{0}\" checkbox on the Column Settings panel", checkboxName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 18
 testRunner.Then("following columns added to the table:", ((string)(null)), table1, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 21
 testRunner.And("content is present in the following newly added columns:", ((string)(null)), table2, "And ");
#line 24
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11732")]
        [NUnit.Framework.CategoryAttribute("DAS12235")]
        [NUnit.Framework.CategoryAttribute("DAS12799")]
        [NUnit.Framework.CategoryAttribute("DAS13657")]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Evergreen Detail", "Application", "Application Key", "Application Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Evergreen Detail", "Application", "Advertisement Key", "Advertisement Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Evergreen Detail", "Application", "Group Key", "Group Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Evergreen Detail", "Application", "Collection Key", "Collection Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Advertisements", "Application", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Advertisements", "Application", "Application Key", "Application Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Advertisements", "Application", "Site Key", "Site Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Advertisements", "Application", "Collection Key", "Collection Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Advertisements", "Application", "Program Key", "Program Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Collections", "Collection", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "30BGMTLBM9PTW5", "Hostname", "Applications", "Collections", "Collection", "Site Key", "Site Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Application", "Details", "Advertisements", "Advertisement", "Advertisement Key", "Advertisement Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Application", "Details", "Advertisements", "Advertisement", "Collection Key", "Collection Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Application", "Details", "Programs", "Program", "Program Key", "Program Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Application", "Distribution", "Devices", "Device", "Computer Key", "Computer Key", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "Application", "Distribution", "Devices", "Device", "Owner Object Key", "Owner Object Key", null)]
        [NUnit.Framework.TestCaseAttribute("Mailbox", "aaron.u.flores@dwlabs.local", "Email Address", "Users", "Groups", "Domain", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Mailbox", "aaron.u.flores@dwlabs.local", "Email Address", "Users", "Mailbox Permissions", "Domain", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Mailbox", "aaron.u.flores@dwlabs.local", "Email Address", "Users", "Mailbox Permissions", "Domain", "Via Group Object Key", "Via Group Object Key", null)]
        [NUnit.Framework.TestCaseAttribute("Mailbox", "aaron.u.flores@dwlabs.local", "Email Address", "Users", "Mailbox Permissions", "Domain", "Access Category Key", "Access Category Key", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns(string pageName, string searchTerm, string itemName, string mainTabName, string subTabName, string columnName, string checkboxName, string newColumnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsInternal(pageName,searchTerm,itemName,mainTabName,subTabName,columnName,checkboxName,newColumnName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsInternal(string pageName, string searchTerm, string itemName, string mainTabName, string subTabName, string columnName, string checkboxName, string newColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11732",
                    "DAS12235",
                    "DAS12799",
                    "DAS13657"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns", null, @__tags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 34
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then(string.Format("Details page for \"{0}\" item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And(string.Format("User navigates to the \"{0}\" sub-menu on the Details page", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And(string.Format("User have opened Column Settings for \"{0}\" column in the Details Page table", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And(string.Format("User select \"{0}\" checkbox on the Column Settings panel", checkboxName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table3.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 42
 testRunner.Then("following columns added to the table:", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 45
 testRunner.And("content is present in the following newly added columns:", ((string)(null)), table4, "And ");
#line 48
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTable")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11732")]
        [NUnit.Framework.CategoryAttribute("DAS12235")]
        [NUnit.Framework.TestCaseAttribute("Distribution", "Devices", "Computer Key", null)]
        [NUnit.Framework.TestCaseAttribute("Distribution", "Devices", "Advertisement Key", null)]
        [NUnit.Framework.TestCaseAttribute("Distribution", "Devices", "Collection Key", null)]
        [NUnit.Framework.TestCaseAttribute("Distribution", "Devices", "Program Key", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTable(string mainTabName, string subTabName, string newColumnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTableInternal(mainTabName,subTabName,newColumnName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTableInternal(string mainTabName, string subTabName, string newColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11732",
                    "DAS12235"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTable", null, @__tags);
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 75
 testRunner.When("User navigates to the \'Application\' details page for \'Microsoft Office Visio 2000" +
                    " Solutions - Custom Patterns\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("Details page for \"Microsoft Office Visio 2000 Solutions - Custom Patterns\" item i" +
                    "s displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And(string.Format("User navigates to the \"{0}\" sub-menu on the Details page", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User have opened Column Settings for \"Device\" column in the Details Page table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User select \"Device\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("User select \"Installed\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("User select \"Owner Display Name\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And(string.Format("User select \"{0}\" checkbox on the Column Settings panel", newColumnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 86
 testRunner.Then("following columns added to the table:", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table6.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 89
 testRunner.And("content is present in the following newly added columns:", ((string)(null)), table6, "And ");
#line 92
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections" +
            "")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11732")]
        [NUnit.Framework.CategoryAttribute("DAS12053")]
        [NUnit.Framework.CategoryAttribute("DAS12235")]
        [NUnit.Framework.CategoryAttribute("DAS13004")]
        [NUnit.Framework.CategoryAttribute("DAS13657")]
        [NUnit.Framework.TestCaseAttribute("Compliance", "Application Issues", "Application", "Package Key", "Package Key", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Projects Summary", "Project", "Object ID", "Object ID", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Projects Summary", "Project", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Owner Projects Summary", "Username", "Object Key", "Object Key", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Owner Projects Summary", "Username", "Key", "Key", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Owner Projects Summary", "Username", "Request Type Key", "Request Type Key", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Owner Projects Summary", "Username", "Category Key", "Category Key", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", "Owner Projects Summary", "Username", "Status Key", "Status Key", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections(string mainTabName, string subTabName, string columnName, string checkboxName, string newColumnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSectionsInternal(mainTabName,subTabName,columnName,checkboxName,newColumnName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSectionsInternal(string mainTabName, string subTabName, string columnName, string checkboxName, string newColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11732",
                    "DAS12053",
                    "DAS12235",
                    "DAS13004",
                    "DAS13657"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections" +
                    "", null, @__tags);
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 103
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.When("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.And(string.Format("User navigates to the \'{0}\' left menu item", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And(string.Format("User navigates to the \"{0}\" sub-menu on the Details page", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And(string.Format("User have opened Column Settings for \"{0}\" column in the Details Page table", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And(string.Format("User select \"{0}\" checkbox on the Column Settings panel", checkboxName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 112
 testRunner.Then("following columns added to the table:", ((string)(null)), table7, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        string.Format("{0}", newColumnName)});
#line 115
 testRunner.And("content is present in the following newly added columns:", ((string)(null)), table8, "And ");
#line 118
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTh" +
            "eDetailsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11393")]
        [NUnit.Framework.CategoryAttribute("DAS12765")]
        [NUnit.Framework.CategoryAttribute("DAS13657")]
        public virtual void EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPageInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTh" +
                    "eDetailsPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS11393",
                        "DAS12765",
                        "DAS13657"});
#line 132
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 133
 testRunner.When("User navigates to the \'Device\' details page for \'01WNOSNMP5QLXC\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.Then("Details page for \"01WNOSNMP5QLXC\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.And("User navigates to the \"Projects Summary\" sub-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("User have opened Column Settings for \"Project\" column in the Details Page table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("User select \"Key\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table9.AddRow(new string[] {
                        "Key"});
#line 141
 testRunner.Then("following columns added to the table:", ((string)(null)), table9, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table10.AddRow(new string[] {
                        "Key"});
            table10.AddRow(new string[] {
                        "Project"});
            table10.AddRow(new string[] {
                        "Project Type"});
            table10.AddRow(new string[] {
                        "Bucket"});
            table10.AddRow(new string[] {
                        "Ring"});
            table10.AddRow(new string[] {
                        "Path"});
            table10.AddRow(new string[] {
                        "Workflow"});
            table10.AddRow(new string[] {
                        "Category"});
            table10.AddRow(new string[] {
                        "Status"});
            table10.AddRow(new string[] {
                        "Date"});
            table10.AddRow(new string[] {
                        "Slot"});
            table10.AddRow(new string[] {
                        "Readiness"});
#line 144
 testRunner.And("ColumnName is displayed in following order on the Details page:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Checkbox"});
            table11.AddRow(new string[] {
                        "Key"});
            table11.AddRow(new string[] {
                        "Project"});
            table11.AddRow(new string[] {
                        "Project Type"});
            table11.AddRow(new string[] {
                        "Bucket"});
            table11.AddRow(new string[] {
                        "Ring"});
            table11.AddRow(new string[] {
                        "Path"});
            table11.AddRow(new string[] {
                        "Workflow"});
            table11.AddRow(new string[] {
                        "Category"});
            table11.AddRow(new string[] {
                        "Status"});
            table11.AddRow(new string[] {
                        "Date"});
            table11.AddRow(new string[] {
                        "Slot"});
            table11.AddRow(new string[] {
                        "Readiness"});
#line 158
 testRunner.And("Checkboxes are checked on the Column Settings panel for \"Key\" Column Settings pan" +
                    "el:", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

