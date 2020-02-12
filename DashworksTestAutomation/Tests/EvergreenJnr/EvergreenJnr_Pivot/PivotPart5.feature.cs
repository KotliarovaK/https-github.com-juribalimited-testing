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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_Pivot
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PivotPart5")]
    public partial class PivotPart5Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PivotPart5.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart5", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrder" +
            "ForUsers")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14422")]
        [NUnit.Framework.CategoryAttribute("DAS15252")]
        public virtual void EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForUsers()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForUsersInternal();
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

        private void EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForUsersInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrder" +
                    "ForUsers", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14422",
                        "DAS15252"});
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
                        "City"});
#line 13
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table2.AddRow(new string[] {
                        "Windows7Mi: Communication \\ Group User Radiobutton Readiness Only"});
#line 16
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "Compliance"});
#line 19
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3, "And ");
#line 22
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("data in the table is sorted by \"City\" column in ascending order by default for th" +
                    "e Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("Empty value is displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "NOT APPLICABLE"});
#line 26
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrd" +
            "erForDevices")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14422")]
        [NUnit.Framework.CategoryAttribute("DAS15252")]
        public virtual void EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForDevices()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForDevicesInternal();
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

        private void EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForDevicesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrd" +
                    "erForDevices", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14422",
                        "DAS15252"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 32
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table5.AddRow(new string[] {
                        "Import"});
#line 35
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table6.AddRow(new string[] {
                        "UserEvergr: Stage 1 \\ Dropdown Readiness Date (Computer)"});
#line 38
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table7.AddRow(new string[] {
                        "Compliance"});
#line 41
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table7, "And ");
#line 44
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("data in the table is sorted by \"Import\" column in ascending order by default for " +
                    "the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("Empty value is not displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table8.AddRow(new string[] {
                        "Not Applicable"});
            table8.AddRow(new string[] {
                        "Started"});
            table8.AddRow(new string[] {
                        "Failed"});
            table8.AddRow(new string[] {
                        "Complete"});
#line 48
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayI" +
            "nTheCorrectOrderForUsers")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14423")]
        [NUnit.Framework.CategoryAttribute("DAS15252")]
        public virtual void EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForUsers()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForUsersInternal();
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

        private void EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForUsersInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayI" +
                    "nTheCorrectOrderForUsers", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14423",
                        "DAS15252"});
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 57
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table9.AddRow(new string[] {
                        "Organizational Unit"});
#line 60
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table10.AddRow(new string[] {
                        "Windows7Mi: Application Readiness"});
#line 63
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table11.AddRow(new string[] {
                        "Compliance"});
#line 66
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table11, "And ");
#line 69
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.And("data in the table is sorted by \"Organizational Unit\" column in ascending order by" +
                    " default for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Then("Empty value is displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.Then("color data in the column headers is sorted in correct order for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayI" +
            "nTheCorrectOrderForDevices")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14423")]
        [NUnit.Framework.CategoryAttribute("DAS15252")]
        public virtual void EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForDevices()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForDevicesInternal();
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

        private void EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForDevicesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayI" +
                    "nTheCorrectOrderForDevices", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14423",
                        "DAS15252"});
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 77
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table12.AddRow(new string[] {
                        "Import"});
#line 80
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table13.AddRow(new string[] {
                        "Windows7Mi: Application Readiness"});
#line 83
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table14.AddRow(new string[] {
                        "Compliance"});
#line 86
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table14, "And ");
#line 89
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And("data in the table is sorted by \"Import\" column in ascending order by default for " +
                    "the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("Empty value is not displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("Empty value is displayed on the first place for the Pivot column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("color data in the column headers is sorted in correct order for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayIn" +
            "TheCorrectOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14424")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS15252")]
        [NUnit.Framework.CategoryAttribute("DAS13786")]
        [NUnit.Framework.CategoryAttribute("DAS13823")]
        [NUnit.Framework.CategoryAttribute("DAS16244")]
        public virtual void EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrderInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayIn" +
                    "TheCorrectOrder", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14424",
                        "DAS13865",
                        "DAS15252",
                        "DAS13786",
                        "DAS13823",
                        "DAS16244"});
#line 97
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 98
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table15.AddRow(new string[] {
                        "Barry\'sUse: Audit & Configuration \\ Validate User Device Ownership"});
#line 101
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table16.AddRow(new string[] {
                        "Barry\'sUse: Audit & Configuration \\ Validate User Device Ownership"});
#line 104
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table17.AddRow(new string[] {
                        "2004: Application Readiness"});
#line 107
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table17, "And ");
#line 110
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.And("data in the table is sorted by \"Import\" column in ascending order by default for " +
                    "the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.Then("Empty value is displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table18.AddRow(new string[] {
                        "NOT APPLICABLE"});
            table18.AddRow(new string[] {
                        "AUDIT FAILED"});
#line 114
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrd" +
            "erForApplications")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13865")]
        [NUnit.Framework.CategoryAttribute("DAS14426")]
        public virtual void EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForApplications()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForApplicationsInternal();
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

        private void EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForApplicationsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrd" +
                    "erForApplications", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13865",
                        "DAS14426"});
#line 120
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 121
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table19.AddRow(new string[] {
                        "Import"});
#line 124
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table20.AddRow(new string[] {
                        "UserEvergr: Stage 3"});
#line 127
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table20, "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table21.AddRow(new string[] {
                        "DeviceSche: Readiness"});
#line 130
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table21, "And ");
#line 133
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.Then("data in the table is sorted by \"Import\" column in ascending order by default for " +
                    "the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.Then("color data in the column headers is sorted in correct order for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

