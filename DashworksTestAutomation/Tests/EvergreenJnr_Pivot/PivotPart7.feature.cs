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
    [NUnit.Framework.DescriptionAttribute("PivotPart7")]
    public partial class PivotPart7Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PivotPart7.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart7", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUser" +
            "s")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14429")]
        public virtual void EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUsers()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUsersInternal();
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

        private void EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUsersInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUser" +
                    "s", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14429"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table1.AddRow(new string[] {
                        "Domain"});
#line 13
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table2.AddRow(new string[] {
                        "Compliance"});
#line 16
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "UserEvergr: Readiness"});
#line 19
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3, "And ");
#line 22
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("data in the table is sorted by \"Domain\" column in ascending order by default for " +
                    "the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "UNKNOWN"});
            table4.AddRow(new string[] {
                        "RED"});
            table4.AddRow(new string[] {
                        "AMBER"});
            table4.AddRow(new string[] {
                        "GREEN"});
            table4.AddRow(new string[] {
                        "IGNORE"});
#line 25
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDe" +
            "vices")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14429")]
        public virtual void EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevices()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevicesInternal();
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

        private void EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevicesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDe" +
                    "vices", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14429"});
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 35
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table5.AddRow(new string[] {
                        "Inventory Site"});
#line 38
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table6.AddRow(new string[] {
                        "Compliance"});
#line 41
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table7.AddRow(new string[] {
                        "1803: Readiness"});
#line 44
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table7, "And ");
#line 47
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("data in the table is sorted by \"Inventory Site\" column in ascending order by defa" +
                    "ult for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "UNKNOWN"});
            table8.AddRow(new string[] {
                        "RED"});
            table8.AddRow(new string[] {
                        "AMBER"});
            table8.AddRow(new string[] {
                        "GREEN"});
#line 50
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrect" +
            "Order")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14430")]
        public virtual void EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrectOrderInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrect" +
                    "Order", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14430"});
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 59
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table9.AddRow(new string[] {
                        "Hostname"});
#line 62
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table10.AddRow(new string[] {
                        "Owner Compliance"});
#line 65
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table11.AddRow(new string[] {
                        "Owner City"});
#line 68
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table11, "And ");
#line 71
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.And("data in the table is sorted by \"Hostname\" column in ascending order by default fo" +
                    "r the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table12.AddRow(new string[] {
                        "UNKNOWN"});
            table12.AddRow(new string[] {
                        "RED"});
            table12.AddRow(new string[] {
                        "AMBER"});
            table12.AddRow(new string[] {
                        "GREEN"});
            table12.AddRow(new string[] {
                        "IGNORE"});
#line 74
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppl" +
            "iedToTheCustomList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS15139")]
        [NUnit.Framework.CategoryAttribute("DAS13833")]
        [NUnit.Framework.CategoryAttribute("DAS13843")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppliedToTheCustomList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppliedToTheCustomListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppliedToTheCustomListInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppl" +
                    "iedToTheCustomList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS15139",
                        "DAS13833",
                        "DAS13843",
                        "Cleanup"});
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 84
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table13.AddRow(new string[] {
                        "Red"});
#line 88
 testRunner.When("User add \"Application Compliance\" filter where type is \"Equals\" with added column" +
                    " and following checkboxes:", ((string)(null)), table13, "When ");
#line 91
 testRunner.Then("\"Application Compliance\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.When("User create dynamic list with \"TestListForDAS15139\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then("\"TestListForDAS15139\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("\'ADD ROW GROUP\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.And("\'ADD COLUMN\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("\'ADD VALUE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.When("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("\'ADD ROW GROUP\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.And("\'ADD COLUMN\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("\'ADD VALUE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("Actions panel is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckResetButtonOnPivot")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13833")]
        [NUnit.Framework.CategoryAttribute("DAS13844")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckResetButtonOnPivot()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckResetButtonOnPivotInternal();
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

        private void EvergreenJnr_DevicesList_CheckResetButtonOnPivotInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckResetButtonOnPivot", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13833",
                        "DAS13844",
                        "Cleanup"});
#line 110
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 111
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table14.AddRow(new string[] {
                        "Hostname"});
#line 114
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table15.AddRow(new string[] {
                        "Owner Compliance"});
#line 117
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table16.AddRow(new string[] {
                        "Owner City"});
#line 120
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table16, "And ");
#line 123
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.When("User creates Pivot list with \"PivotList_DAS_13844\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.Then("\"PivotList_DAS_13844\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.When("User clicks the Pivot button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table17.AddRow(new string[] {
                        "Owner City"});
#line 129
 testRunner.And("User adds the following \"Columns\" on Pivot:", ((string)(null)), table17, "And ");
#line 132
 testRunner.Then("reset button on main panel is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.When("User clicks reset button on main panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.Then("\'ADD ROW GROUP\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.And("\'ADD COLUMN\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("\'ADD VALUE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.And("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table18.AddRow(new string[] {
                        "Hostname"});
#line 140
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table18, "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table19.AddRow(new string[] {
                        "Owner Compliance"});
#line 143
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table20.AddRow(new string[] {
                        "Owner City"});
#line 146
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table20, "And ");
#line 150
 testRunner.Then("\'RUN PIVOT\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.And("\'SAVE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.When("User clicks reset button on main panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
 testRunner.Then("\'ADD ROW GROUP\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.And("\'ADD COLUMN\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("\'ADD VALUE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table21.AddRow(new string[] {
                        "Hostname"});
#line 158
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table21, "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table22.AddRow(new string[] {
                        "Owner Compliance"});
#line 161
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table23.AddRow(new string[] {
                        "Owner City"});
#line 164
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table23, "And ");
#line 168
 testRunner.Then("\'RUN PIVOT\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 169
 testRunner.And("\'SAVE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 171
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
 testRunner.And("\'SAVE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
 testRunner.When("User clicks reset button on main panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
 testRunner.Then("\'ADD ROW GROUP\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.And("\'ADD COLUMN\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("\'ADD VALUE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table24.AddRow(new string[] {
                        "Application Compliance"});
#line 179
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table24, "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table25.AddRow(new string[] {
                        "Operating System"});
#line 182
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table25, "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table26.AddRow(new string[] {
                        "Owner General information field 1"});
#line 185
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table26, "And ");
#line 188
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 189
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 190
 testRunner.When("User creates Pivot list with \"PivotList_DAS_13844_1\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 191
 testRunner.Then("\"PivotList_DAS_13844_1\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 192
 testRunner.When("User clicks the Pivot button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 193
 testRunner.And("User clicks reset button on main panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
 testRunner.Then("\'ADD ROW GROUP\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.And("\'ADD COLUMN\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.And("\'ADD VALUE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.And("\'SAVE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
 testRunner.And("\'RUN PIVOT\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnMana" +
            "gerButton")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13833")]
        [NUnit.Framework.CategoryAttribute("DAS13842")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnManagerButton()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnManagerButtonInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnManagerButtonInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnMana" +
                    "gerButton", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13833",
                        "DAS13842",
                        "Cleanup"});
#line 201
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 202
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 203
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 204
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 205
 testRunner.Then("\"Pivot\" panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table27.AddRow(new string[] {
                        "Application Compliance"});
#line 206
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table27, "When ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table28.AddRow(new string[] {
                        "Operating System"});
#line 209
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table28, "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table29.AddRow(new string[] {
                        "App Count (Entitled)"});
#line 212
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table29, "And ");
#line 215
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 216
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 217
 testRunner.When("User creates Pivot list with \"PivotList_DAS13842\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 218
 testRunner.Then("\"PivotList_DAS13842\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 219
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 220
 testRunner.And("User navigates to the \"PivotList_DAS13842\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 221
 testRunner.Then("\"PivotList_DAS13842\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 222
 testRunner.When("User clicks \'Manage\' Settings menu item for \'PivotList_DAS13842\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 223
 testRunner.Then("\"Dynamic Pivot Details\" panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

