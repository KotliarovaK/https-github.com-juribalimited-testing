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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ActionsPanel.ActionsPanel
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ActionsPanelPart2")]
    public partial class ActionsPanelPart2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ActionsPanelPart2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ActionsPanelPart2", "\tRuns Actions Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsP" +
            "anelWhenAStaticListDoesNotExist")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS12946")]
        [NUnit.Framework.CategoryAttribute("DAS12864")]
        [NUnit.Framework.CategoryAttribute("DAS13258")]
        [NUnit.Framework.CategoryAttribute("DAS13259")]
        [NUnit.Framework.CategoryAttribute("DAS13260")]
        [NUnit.Framework.CategoryAttribute("DAS13263")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "001PSUMZYOW581", "User Scheduled Test (Jo)", "Two", "Radio Non Rag only Comp", "Not Applicable", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "003F5D8E1A844B1FAA5", "User Scheduled Test (Jo)", "Two", "Radio Non Rag only User", "Not Applicable", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "7zip", "User Scheduled Test (Jo)", "Two", "Radio Non Rag only App", "Not Applicable", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "00BDBAEA57334C7C8F4@bclabs.local", "Email Migration", "Mobile Devices", "Mobile Device Status", "Identified & In Progress", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExist(string pageName, string columnHeader, string rowName, string projectName, string stageName, string taskName, string value, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExistInternal(pageName,columnHeader,rowName,projectName,stageName,taskName,value,exampleTags);
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

        private void EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExistInternal(string pageName, string columnHeader, string rowName, string projectName, string stageName, string taskName, string value, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS12946",
                    "DAS12864",
                    "DAS13258",
                    "DAS13259",
                    "DAS13260",
                    "DAS13263",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsP" +
                    "anelWhenAStaticListDoesNotExist", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnHeader), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.When(string.Format("User create dynamic list with \"DynamicList12946\" name on \"{0}\" page", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("\"DynamicList12946\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table1.AddRow(new string[] {
                        string.Format("{0}", rowName)});
#line 17
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnHeader), ((string)(null)), table1, "When ");
#line 20
 testRunner.And("User clicks on Action drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table2.AddRow(new string[] {
                        "Create static list"});
            table2.AddRow(new string[] {
                        "Bulk update"});
#line 21
 testRunner.Then("following Values are displayed in Action drop-down:", ((string)(null)), table2, "Then ");
#line 25
 testRunner.When("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Bulk Update Type dropdown is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User selects \"Update task value\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\"UPDATE\" Action button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("\"CANCEL\" Action button is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When(string.Format("User selects \"{0}\" Project on Action panel", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And(string.Format("User selects \"{0}\" Stage on Action panel", stageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And(string.Format("User selects \"{0}\" Task on Action panel", taskName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And(string.Format("User selects \"{0}\" Value on Action panel", value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("Warning message with \"Are you sure you want to proceed, this operation cannot be " +
                    "undone.\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.And("User clicks \"UPDATE\" button on message box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("Success message with \"0 of 1 object was in the selected project and has been queu" +
                    "ed\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelW" +
            "henOnlOneStaticListExists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS12946")]
        [NUnit.Framework.CategoryAttribute("DAS12864")]
        [NUnit.Framework.CategoryAttribute("DAS13258")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "001PSUMZYOW581", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "002B5DC7D4D34D5C895", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "20040610sqlserverck", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "00C8BC63E7424A6E862@bclabs.local", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelWhenOnlOneStaticListExists(string pageName, string columnHeader, string rowName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelWhenOnlOneStaticListExistsInternal(pageName,columnHeader,rowName,exampleTags);
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

        private void EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelWhenOnlOneStaticListExistsInternal(string pageName, string columnHeader, string rowName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS12946",
                    "DAS12864",
                    "DAS13258",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelW" +
                    "henOnlOneStaticListExists", null, @__tags);
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 49
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table3.AddRow(new string[] {
                        string.Format("{0}", rowName)});
#line 53
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnHeader), ((string)(null)), table3, "When ");
#line 56
 testRunner.And("User selects \"Create static list\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("User create static list with \"StaticList12946\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("\"StaticList12946\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table4.AddRow(new string[] {
                        string.Format("{0}", rowName)});
#line 61
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnHeader), ((string)(null)), table4, "When ");
#line 64
 testRunner.And("User clicks on Action drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table5.AddRow(new string[] {
                        "Create static list"});
            table5.AddRow(new string[] {
                        "Remove from static list"});
            table5.AddRow(new string[] {
                        "Bulk update"});
#line 65
 testRunner.Then("following Values are displayed in Action drop-down:", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDa" +
            "taOnceTheStaticListHasBeenCreated")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS12946")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Compliance", "Red", "9174", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Compliance", "Red", "9438", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Compliance", "Red", "181", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Owner Compliance", "Green", "14701", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDataOnceTheStaticListHasBeenCreated(string pageName, string filterName, string checkboxes, string selectedRowsCount, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDataOnceTheStaticListHasBeenCreatedInternal(pageName,filterName,checkboxes,selectedRowsCount,exampleTags);
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

        private void EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDataOnceTheStaticListHasBeenCreatedInternal(string pageName, string filterName, string checkboxes, string selectedRowsCount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS12946",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDa" +
                    "taOnceTheStaticListHasBeenCreated", null, @__tags);
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 80
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table6.AddRow(new string[] {
                        string.Format("{0}", checkboxes)});
#line 84
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" without added column and following c" +
                        "heckboxes:", filterName), ((string)(null)), table6, "When ");
#line 87
 testRunner.Then(string.Format("\"{0}\" filter is added to the list", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.When("User selects \"Create static list\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.When("User create static list with \"StaticList12946\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then("\"StaticList12946\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.And("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User select all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User clicks on Action drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("DAS12863")]
        [NUnit.Framework.CategoryAttribute("DAS13266")]
        [NUnit.Framework.CategoryAttribute("DAS13284")]
        [NUnit.Framework.CategoryAttribute("DAS16826")]
        public virtual void EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPageInternal();
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

        private void EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "DAS12863",
                        "DAS13266",
                        "DAS13284",
                        "DAS16826"});
#line 109
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 110
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table7.AddRow(new string[] {
                        "TRUE"});
#line 114
 testRunner.When("User add \"Windows7Mi: In Scope\" filter where type is \"Equals\" with added column a" +
                    "nd following checkboxes:", ((string)(null)), table7, "When ");
#line 117
 testRunner.Then("\"Windows7Mi: In Scope\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Windows7Mi: Path"});
#line 120
 testRunner.When("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table8, "When ");
#line 123
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table9.AddRow(new string[] {
                        "001PSUMZYOW581"});
            table9.AddRow(new string[] {
                        "00BDM1JUR8IF419"});
            table9.AddRow(new string[] {
                        "00RUUMAH9OZN9A"});
#line 125
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table9, "When ");
#line 130
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("User selects \"Windows 7 Migration (Computer Scheduled Project)\" Project on Action" +
                    " panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.Then("\"UPDATE\" Action button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.When("User selects \"Computer: PC Rebuild\" Path on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.And("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.Then("Warning message with \"Are you sure you want to proceed, this operation cannot be " +
                    "undone.\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.And("User clicks \"UPDATE\" button on message box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("Success message with \"3 of 3 objects were in the selected project and have been q" +
                    "ueued\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.And("User perform search by \"001PSUMZYOW581\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.Then("\"Computer: PC Rebuild\" content is displayed in \"Windows7Mi: Path\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.When("User perform search by \"00BDM1JUR8IF419\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.Then("\"Computer: PC Rebuild\" content is displayed in \"Windows7Mi: Path\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.When("User perform search by \"00RUUMAH9OZN9A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 145
 testRunner.Then("\"Computer: PC Rebuild\" content is displayed in \"Windows7Mi: Path\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.When("User closes Tools panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.And("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table10.AddRow(new string[] {
                        "001PSUMZYOW581"});
#line 151
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table10, "When ");
#line 154
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.And("User selects \"Windows 7 Migration (Computer Scheduled Project)\" Project on Action" +
                    " panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("User selects \"Computer: Virtual Machine\" Path on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.Then("Warning message with \"Are you sure you want to proceed, this operation cannot be " +
                    "undone.\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.And("User clicks \"UPDATE\" button on message box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.And("Success message with \"1 of 1 object was in the selected project and has been queu" +
                    "ed\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.When("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table11.AddRow(new string[] {
                        "00BDM1JUR8IF419"});
#line 165
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table11, "When ");
#line 168
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.And("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.And("User selects \"Windows 7 Migration (Computer Scheduled Project)\" Project on Action" +
                    " panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.And("User selects \"[This is the Default Request Type for Computer)] \" Path on Action p" +
                    "anel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.And("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
 testRunner.Then("Warning message with \"Are you sure you want to proceed, this operation cannot be " +
                    "undone.\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
 testRunner.And("User clicks \"UPDATE\" button on message box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And("Success message with \"1 of 1 object was in the selected project and has been queu" +
                    "ed\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.When("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 177
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table12.AddRow(new string[] {
                        "00RUUMAH9OZN9A"});
#line 179
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table12, "When ");
#line 182
 testRunner.And("User selects \"Bulk update\" in the Actions dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
 testRunner.And("User selects \"Update path\" Bulk Update Type on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
 testRunner.And("User selects \"Windows 7 Migration (Computer Scheduled Project)\" Project on Action" +
                    " panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
 testRunner.And("User selects \"Computer: Laptop Replacement\" Path on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
 testRunner.And("User clicks the \"UPDATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.Then("Warning message with \"Are you sure you want to proceed, this operation cannot be " +
                    "undone.\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 188
 testRunner.And("User clicks \"UPDATE\" button on message box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
 testRunner.And("Success message with \"1 of 1 object was in the selected project and has been queu" +
                    "ed\" text is displayed on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

