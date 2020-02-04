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
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart06")]
    public partial class FiltersFunctionalityPart06Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FiltersFunctionalityPart06.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart06", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynam" +
            "icListAsTheFilteredApplicationSavedList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12202")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynamicListAsTheFilteredApplicationSavedList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynamicListAsTheFilteredApplicationSavedListInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynamicListAsTheFilteredApplicationSavedListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynam" +
                    "icListAsTheFilteredApplicationSavedList", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12202",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Device Count (Entitled)"});
            table1.AddRow(new string[] {
                        "Device Count (Used)"});
            table1.AddRow(new string[] {
                        "Device Count (Installed)"});
#line 10
 testRunner.When("User add following columns using URL to the \"Applications\" page:", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table2.AddRow(new string[] {
                        "Device Count (Entitled)"});
            table2.AddRow(new string[] {
                        "Device Count (Used)"});
            table2.AddRow(new string[] {
                        "Device Count (Installed)"});
#line 15
 testRunner.Then("Content is present in the newly added column", ((string)(null)), table2, "Then ");
#line 20
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "MKS Source Integrity 7.3d"});
#line 22
 testRunner.When("User add \"Application\" filter where type is \"Equals\" with added column and follow" +
                    "ing value:", ((string)(null)), table3, "When ");
#line 25
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("User create dynamic list with \"DynamicList4116\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table4.AddRow(new string[] {
                        "DynamicList4116",
                        "Entitled to device"});
#line 31
 testRunner.When("User add \"Application (Saved List)\" filter where type is \"In list\" with Selected " +
                    "Value and following Association:", ((string)(null)), table4, "When ");
#line 34
 testRunner.Then("\"123\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserS" +
            "urnameFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12875")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilter()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilterInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilterInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserS" +
                    "urnameFilter", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12875"});
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 38
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values",
                        "Association"});
            table5.AddRow(new string[] {
                        "Cotuand",
                        "Entitled to app"});
            table5.AddRow(new string[] {
                        "Courtemanche",
                        ""});
#line 42
 testRunner.When("User add \"User Surname\" filter where type is \"Equals\" with following Value and As" +
                    "sociation:", ((string)(null)), table5, "When ");
#line 46
 testRunner.When("User click Edit button for \"User \" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedList" +
            "Filter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FiltersFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12167")]
        [NUnit.Framework.CategoryAttribute("DAS12056")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedListFilter()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedListFilterInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedListFilterInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedList" +
                    "Filter", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_FiltersFeature",
                        "FiltersFunctionality",
                        "DAS12167",
                        "DAS12056",
                        "Cleanup"});
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 51
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table6.AddRow(new string[] {
                        "YOG2259571"});
#line 55
 testRunner.When("User add \"Username\" filter where type is \"Equals\" without added column and follow" +
                    "ing value:", ((string)(null)), table6, "When ");
#line 58
 testRunner.When("User create dynamic list with \"YOG2259571 Users\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("\"YOG2259571 Users\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table7.AddRow(new string[] {
                        "YOG2259571 Users",
                        "Entitled to app"});
#line 64
 testRunner.When("User add \"User (Saved List)\" filter where type is \"In list\" with Selected Value a" +
                    "nd following Association:", ((string)(null)), table7, "When ");
#line 67
 testRunner.Then("\"4\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.Then("\"Any User in list YOG2259571 Users entitled to app\" is displayed in added filter " +
                    "info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.And("Filter name is colored in the added filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("Filter value is shown in bold in the added filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUse" +
            "rnameAndApplicationSavedList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12181")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedListInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUse" +
                    "rnameAndApplicationSavedList", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12181",
                        "Cleanup"});
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 75
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User create static list with \"StaticList8546\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values",
                        "Association"});
            table8.AddRow(new string[] {
                        "Bob",
                        "Has used app"});
            table8.AddRow(new string[] {
                        "Bob",
                        "Entitled to app"});
            table8.AddRow(new string[] {
                        "Bob",
                        "Owns a device which app was used on"});
            table8.AddRow(new string[] {
                        "Bob",
                        "Owns a device which app is entitled to"});
#line 86
 testRunner.When("User add \"User Username\" filter where type is \"Contains\" with following Value and" +
                    " Association:", ((string)(null)), table8, "When ");
#line 92
 testRunner.When("User create dynamic list with \"UsersBob\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then("\"UsersBob\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table9.AddRow(new string[] {
                        "StaticList8546",
                        "Has used app"});
            table9.AddRow(new string[] {
                        "StaticList8546",
                        "Entitled to app"});
            table9.AddRow(new string[] {
                        "StaticList8546",
                        "Owns a device which app was used on"});
#line 96
 testRunner.When("User Add And \"User (Saved List)\" filter where type is \"In list\" with Selected Val" +
                    "ue and following Association:", ((string)(null)), table9, "When ");
#line 101
 testRunner.Then("\"5\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
