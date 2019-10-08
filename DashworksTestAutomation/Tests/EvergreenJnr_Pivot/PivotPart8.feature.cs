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
namespace DashworksTestAutomation.Tests.EvergreenJnr_Pivot
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PivotPart8")]
    public partial class PivotPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PivotPart8.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart8", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredL" +
            "ist")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13833")]
        [NUnit.Framework.CategoryAttribute("DAS13846")]
        [NUnit.Framework.CategoryAttribute("DAS16994")]
        public virtual void EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredL" +
                    "ist", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13833",
                        "DAS13846",
                        "DAS16994"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        "4553"});
#line 14
 testRunner.When("User add \"Device Key\" filter where type is \"Equals\" with added column and followi" +
                    "ng value:", ((string)(null)), table1, "When ");
#line 17
 testRunner.Then("\"Device Key\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.And("User clicks \'ADD COLUMN\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("\"5\" subcategories is displayed for \"Suggested\" category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("\"Device Key\" subcategory is selected in Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("User adds the \"Device Key\" category on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("\"Selected Filters\" section is not displayed in the Columns panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("\"Device Key\" subcategory is selected in Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingLis" +
            "tsPanel")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13119")]
        [NUnit.Framework.CategoryAttribute("DAS13652")]
        [NUnit.Framework.CategoryAttribute("DAS13637")]
        [NUnit.Framework.CategoryAttribute("DAS17421")]
        [NUnit.Framework.CategoryAttribute("DAS13649")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingListsPanel()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingListsPanelInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingListsPanelInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingLis" +
                    "tsPanel", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13119",
                        "DAS13652",
                        "DAS13637",
                        "DAS17421",
                        "DAS13649",
                        "Cleanup"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 28
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table2.AddRow(new string[] {
                        "Application Compliance"});
#line 31
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table3.AddRow(new string[] {
                        "Operating System"});
#line 34
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table4.AddRow(new string[] {
                        "App Count (Entitled)"});
#line 37
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table4, "And ");
#line 40
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.When("User creates Pivot list with \"PivotList_DAS13652\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("\"PivotList_DAS13652\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("User closed list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("Lists panel is hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("\"PivotList_DAS13652\" list name is displayed correctly on top tools panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("\"RUN PIVOT\" Action button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("Export button is displayed in panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS11103")]
        [NUnit.Framework.CategoryAttribute("DAS11264")]
        [NUnit.Framework.CategoryAttribute("DAS11360")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "Compliance", "Babel(Engl: Application Readiness", "Last Seen Date", "OS Branch", "Devices_List_11103", "Application Compliance", "Red", "Operating System", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "Compliance", "App Count (Entitled)", "Domain", "Dashworks First Seen", "Users_List_11103", "Compliance", "Red", "User", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "Alias", "Owner City", "Created Date", "Alias", "Mailboxes_List_11103", "Enabled", "TRUE", "Mailbox", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "All Applications", "Application", "Evergreen Capacity Unit", "Vendor", "Application Owner", "Applications_List_11103", "Compliance", "Red", "Custom Fields", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectly(string pageName, string pageLabel, string rowGroup, string column, string value, string additionalValue, string listName, string filterName, string valuesForFilter, string categoryName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectlyInternal(pageName,pageLabel,rowGroup,column,value,additionalValue,listName,filterName,valuesForFilter,categoryName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectlyInternal(string pageName, string pageLabel, string rowGroup, string column, string value, string additionalValue, string listName, string filterName, string valuesForFilter, string categoryName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS11103",
                    "DAS11264",
                    "DAS11360",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectly", null, @__tags);
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 52
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", pageLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table5.AddRow(new string[] {
                        string.Format("{0}", valuesForFilter)});
#line 56
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and following chec" +
                        "kboxes:", filterName), ((string)(null)), table5, "When ");
#line 59
 testRunner.Then(string.Format("\"{0}\" filter is added to the list", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.When(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", listName, pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table6.AddRow(new string[] {
                        string.Format("{0}", rowGroup)});
#line 63
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table7.AddRow(new string[] {
                        string.Format("{0}", column)});
#line 66
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table8.AddRow(new string[] {
                        string.Format("{0}", value)});
#line 69
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table8, "And ");
#line 72
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table9.AddRow(new string[] {
                        string.Format("{0}", additionalValue)});
#line 73
 testRunner.And("User adds the following \"Values\" on Pivot:", ((string)(null)), table9, "And ");
#line 76
 testRunner.Then(string.Format("\"{0}\" chip for Value is displayed", value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Then(string.Format("\"{0}\" chip for Value is displayed", additionalValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When(string.Format("User clicks close button for \"{0}\" chip", additionalValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then(string.Format("\"{0}\" chip for Value is not displayed", additionalValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.When("User clicks Plus button for \"Values\" Pivot value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.When(string.Format("User enters \"{0}\" text in Search field at Columns Panel", additionalValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.When("User closed \"Suggested\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then(string.Format("\"{0}\" subcategory is displayed for \"{1}\" category", additionalValue, categoryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValues")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS11103")]
        [NUnit.Framework.CategoryAttribute("DAS13819")]
        [NUnit.Framework.CategoryAttribute("DAS13818")]
        [NUnit.Framework.CategoryAttribute("DAS13817")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValues()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValuesInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValuesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValues", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS11103",
                        "DAS13819",
                        "DAS13818",
                        "DAS13817",
                        "Cleanup"});
#line 94
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 95
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table10.AddRow(new string[] {
                        "HDD Count"});
#line 98
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Option"});
            table11.AddRow(new string[] {
                        "Count"});
            table11.AddRow(new string[] {
                        "Sum"});
            table11.AddRow(new string[] {
                        "Min"});
            table11.AddRow(new string[] {
                        "Max"});
            table11.AddRow(new string[] {
                        "Avg"});
#line 101
 testRunner.Then("following aggregate function are available in dropdown:", ((string)(null)), table11, "Then ");
#line 108
 testRunner.When("User clicks close button for \"HDD Count\" chip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table12.AddRow(new string[] {
                        "Build Date"});
#line 109
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Option"});
            table13.AddRow(new string[] {
                        "Count"});
            table13.AddRow(new string[] {
                        "First"});
            table13.AddRow(new string[] {
                        "Last"});
#line 112
 testRunner.Then("following aggregate function are available in dropdown:", ((string)(null)), table13, "Then ");
#line 117
 testRunner.When("User clicks close button for \"Build Date\" chip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table14.AddRow(new string[] {
                        "Owner City"});
#line 118
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Option"});
            table15.AddRow(new string[] {
                        "Count"});
#line 121
 testRunner.Then("following aggregate function are available in dropdown:", ((string)(null)), table15, "Then ");
#line 124
 testRunner.When("User clicks close button for \"Owner City\" chip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectO" +
            "rder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13862")]
        [NUnit.Framework.CategoryAttribute("DAS14372")]
        [NUnit.Framework.CategoryAttribute("DAS14373")]
        [NUnit.Framework.TestCaseAttribute("Operating System", "Owner Compliance", null)]
        [NUnit.Framework.TestCaseAttribute("Service Pack or Build", "Owner Compliance", null)]
        [NUnit.Framework.TestCaseAttribute("Application Compliance", "Operating System", null)]
        [NUnit.Framework.TestCaseAttribute("Application Compliance", "Service Pack or Build", null)]
        public virtual void EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectOrder(string rowGroups, string columns, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectOrderInternal(rowGroups,columns,exampleTags);
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

        private void EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectOrderInternal(string rowGroups, string columns, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS13862",
                    "DAS14372",
                    "DAS14373"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectO" +
                    "rder", null, @__tags);
#line 127
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 128
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table16.AddRow(new string[] {
                        string.Format("{0}", rowGroups)});
#line 131
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table17.AddRow(new string[] {
                        string.Format("{0}", columns)});
#line 134
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table18.AddRow(new string[] {
                        "Owner City"});
#line 137
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table18, "And ");
#line 140
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.And(string.Format("data in the table is sorted by \"{0}\" column in ascending order by default for the" +
                        " Pivot", rowGroups), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDis" +
            "playInTheCorrectOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13862")]
        [NUnit.Framework.CategoryAttribute("DAS14372")]
        public virtual void EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDisplayInTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDisplayInTheCorrectOrderInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDisplayInTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDis" +
                    "playInTheCorrectOrder", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13862",
                        "DAS14372"});
#line 152
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 153
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 154
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table19.AddRow(new string[] {
                        "Operating System"});
            table19.AddRow(new string[] {
                        "Service Pack or Build"});
#line 156
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table20.AddRow(new string[] {
                        "Owner Compliance"});
#line 160
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table20, "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table21.AddRow(new string[] {
                        "Owner City"});
#line 163
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table21, "And ");
#line 166
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 168
 testRunner.And("data in the table is sorted by \"Operating System\" column in ascending order by de" +
                    "fault for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

