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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_FiltersFeature.FilterFunctionality
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart16")]
    public partial class FiltersFunctionalityPart16Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FiltersFunctionalityPart16.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart16", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilter" +
            "ForTheListBasedOnSavedListWithErrors")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS16394")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilterForTheListBasedOnSavedListWithErrors()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilterForTheListBasedOnSavedListWithErrorsInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilterForTheListBasedOnSavedListWithErrorsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilter" +
                    "ForTheListBasedOnSavedListWithErrors", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS16394",
                        "Cleanup"});
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
                        "SelectedList",
                        "Association"});
            table1.AddRow(new string[] {
                        "Device List (Complex) - BROKEN LIST",
                        ""});
#line 14
 testRunner.When("User add \"Device (Saved List)\" filter where type is \"In list\" with Selected Value" +
                    " and following Association:", ((string)(null)), table1, "When ");
#line 17
 testRunner.When("User creates \'List_DAS16394\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("\"List_DAS16394\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("Create button is disabled on the Base Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.When("User click Edit button for \" Device\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("Create button is disabled on the Base Dashboard Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS15807")]
        public virtual void EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserListInternal();
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

        private void EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserList", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS15807"});
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 27
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table2.AddRow(new string[] {
                        "English"});
#line 31
 testRunner.When("User add \"Windows7Mi: Language\" filter where type is \"Equals\" with added column a" +
                    "nd Lookup option", ((string)(null)), table2, "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS16071")]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Status", "Not Onboarded", "12,100", null)]
        [NUnit.Framework.TestCaseAttribute("Windows7Mi: Status", "Offboarded", "20", null)]
        public virtual void EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilter(string filterName, string selectedCheckboxes, string rows, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilterInternal(filterName,selectedCheckboxes,rows,exampleTags);
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

        private void EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilterInternal(string filterName, string selectedCheckboxes, string rows, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS16071"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilter", null, @__tags);
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 37
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table3.AddRow(new string[] {
                        string.Format("{0}", selectedCheckboxes)});
#line 41
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and Lookup option", filterName), ((string)(null)), table3, "When ");
#line 44
 testRunner.Then(string.Format("\"{0}\" filter is added to the list", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.Then("table data is filtered correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rows), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17411")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS17411",
                        "Cleanup"});
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 55
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Windows7Mi: Name"});
#line 57
 testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Name"});
#line 60
 testRunner.Then("ColumnName is added to the list", ((string)(null)), table5, "Then ");
#line 63
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table6.AddRow(new string[] {
                        ""});
#line 64
 testRunner.And("User add \"Windows7Mi: Name\" filter where type is \"Not empty\" with added column an" +
                    "d following value:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table7.AddRow(new string[] {
                        "00"});
#line 67
 testRunner.And("User Add And \"Windows7Mi: Name\" filter where type is \"Contains\" with added column" +
                    " and following value:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table8.AddRow(new string[] {
                        "fpi"});
#line 70
 testRunner.And("User Add And \"Windows7Mi: Name\" filter where type is \"Does not contain\" with adde" +
                    "d column and following value:", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table9.AddRow(new string[] {
                        "2"});
#line 73
 testRunner.And("User Add And \"Windows7Mi: Name\" filter where type is \"Begins with\" with added col" +
                    "umn and following value:", ((string)(null)), table9, "And ");
#line 76
 testRunner.Then("\"4\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS16178")]
        public virtual void EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounter()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounterInternal();
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

        private void EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounterInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounter", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS16178"});
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 80
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table10.AddRow(new string[] {
                        ""});
#line 82
 testRunner.And("User add \"Windows7Mi: Owner Username\" filter where type is \"Not empty\" with added" +
                    " column and following value:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table11.AddRow(new string[] {
                        "to"});
#line 85
 testRunner.And("User Add And \"Windows7Mi: Owner Display Name\" filter where type is \"Does not begi" +
                    "n with\" with added column and following value:", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table12.AddRow(new string[] {
                        "1"});
#line 88
 testRunner.And("User Add And \"Windows7Mi: Owner Username\" filter where type is \"Contains\" with ad" +
                    "ded column and following value:", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table13.AddRow(new string[] {
                        "9"});
#line 91
 testRunner.And("User Add And \"Windows7Mi: Owner Display Name\" filter where type is \"Does not end " +
                    "with\" with added column and following value:", ((string)(null)), table13, "And ");
#line 94
 testRunner.Then("\"2,471\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItems")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17004")]
        public virtual void EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItems()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItemsInternal();
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

        private void EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItemsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItems", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS17004"});
#line 97
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 98
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table14.AddRow(new string[] {
                        "Support"});
            table14.AddRow(new string[] {
                        "Technology"});
#line 100
 testRunner.And("User add \"Department Level 1\" filter where type is \"Equals\" with added column and" +
                    " following checkboxes:", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table15.AddRow(new string[] {
                        "Facilities"});
            table15.AddRow(new string[] {
                        "Application Development"});
#line 104
 testRunner.And("User Add And \"Department Level 2\" filter where type is \"Equals\" with added column" +
                    " and Lookup option", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table16.AddRow(new string[] {
                        "Admin"});
            table16.AddRow(new string[] {
                        "Support"});
            table16.AddRow(new string[] {
                        "Helpdesk"});
#line 108
 testRunner.And("User Add And \"Department Level 3\" filter where type is \"Does not equal\" without a" +
                    "dded column and following checkboxes:", ((string)(null)), table16, "And ");
#line 113
 testRunner.Then("\"1,699\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
