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
    [NUnit.Framework.DescriptionAttribute("PivotPart9")]
    public partial class PivotPart9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PivotPart9.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart9", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDispl" +
            "ayInTheCorrectOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13862")]
        [NUnit.Framework.CategoryAttribute("DAS14373")]
        public virtual void EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrderInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDispl" +
                    "ayInTheCorrectOrder", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13862",
                        "DAS14373"});
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
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table1.AddRow(new string[] {
                        "Application Compliance"});
#line 13
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table2.AddRow(new string[] {
                        "Operating System"});
            table2.AddRow(new string[] {
                        "Service Pack or Build"});
#line 16
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "Owner City"});
#line 20
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3, "And ");
#line 23
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("data in the table is sorted by \"Application Compliance\" column in ascending order" +
                    " by default for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13786")]
        [NUnit.Framework.CategoryAttribute("DAS13868")]
        public virtual void EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrderInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13786",
                        "DAS13868"});
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 29
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table4.AddRow(new string[] {
                        "Compliance"});
#line 32
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table5.AddRow(new string[] {
                        "Group Count"});
#line 35
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table6.AddRow(new string[] {
                        "Device Count"});
#line 38
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table6, "And ");
#line 41
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("numeric data in table is sorted by \"Compliance\" column in descending order for th" +
                    "e Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13863")]
        [NUnit.Framework.CategoryAttribute("DAS14374")]
        public virtual void EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroupInternal();
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

        private void EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroupInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14374"});
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 47
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table7.AddRow(new string[] {
                        "EmailMigra: Status"});
#line 50
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table8.AddRow(new string[] {
                        "Country"});
#line 53
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table9.AddRow(new string[] {
                        "City"});
#line 56
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table9, "And ");
#line 59
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table10.AddRow(new string[] {
                        "Not Onboarded"});
            table10.AddRow(new string[] {
                        "Onboarded"});
            table10.AddRow(new string[] {
                        "Forecast"});
            table10.AddRow(new string[] {
                        "Targeted"});
            table10.AddRow(new string[] {
                        "Scheduled"});
            table10.AddRow(new string[] {
                        "Migrated"});
#line 60
 testRunner.Then("Pivot left-pinned column content is displayed in following order:", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13863")]
        [NUnit.Framework.CategoryAttribute("DAS14374")]
        [NUnit.Framework.CategoryAttribute("DAS15376")]
        public virtual void EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroupInternal();
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

        private void EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroupInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14374",
                        "DAS15376"});
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 71
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table11.AddRow(new string[] {
                        "MigrationP: Status"});
#line 74
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table12.AddRow(new string[] {
                        "Country"});
#line 77
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table13.AddRow(new string[] {
                        "City"});
#line 80
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table13, "And ");
#line 83
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table14.AddRow(new string[] {
                        "Not Onboarded"});
            table14.AddRow(new string[] {
                        "Onboarded"});
            table14.AddRow(new string[] {
                        "Forecast"});
            table14.AddRow(new string[] {
                        "Scheduled"});
            table14.AddRow(new string[] {
                        "Migrated"});
            table14.AddRow(new string[] {
                        "Complete"});
            table14.AddRow(new string[] {
                        "Offboarded"});
#line 84
 testRunner.Then("Pivot left-pinned column content is displayed in following order:", ((string)(null)), table14, "Then ");
#line 93
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "StartDateInclusive",
                        "EndDateInclusive"});
            table15.AddRow(new string[] {
                        "25 Apr 2018",
                        "02 May 2018"});
#line 95
 testRunner.When("User add \"Last Logon Date\" filter where type is \"Between\" without added column an" +
                    "d Date options", ((string)(null)), table15, "When ");
#line 98
 testRunner.Then("\"(Last Logon Date between (2018-04-25, 2018-05-02))\" text is displayed in filter " +
                    "container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13863")]
        [NUnit.Framework.CategoryAttribute("DAS14374")]
        public virtual void EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroupInternal();
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

        private void EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroupInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14374"});
#line 101
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 102
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table16.AddRow(new string[] {
                        "ComputerSc: Status"});
#line 105
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table17.AddRow(new string[] {
                        "Country"});
#line 108
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table18.AddRow(new string[] {
                        "City"});
#line 111
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table18, "And ");
#line 114
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table19.AddRow(new string[] {
                        "Not Onboarded"});
            table19.AddRow(new string[] {
                        "Onboarded"});
            table19.AddRow(new string[] {
                        "Forecast"});
            table19.AddRow(new string[] {
                        "Scheduled"});
            table19.AddRow(new string[] {
                        "Migrated"});
            table19.AddRow(new string[] {
                        "Complete"});
#line 115
 testRunner.Then("Pivot left-pinned column content is displayed in following order:", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13863")]
        [NUnit.Framework.CategoryAttribute("DAS14375")]
        public virtual void EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumnInternal();
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

        private void EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumnInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13863",
                        "DAS14375"});
#line 125
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 126
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table20.AddRow(new string[] {
                        "Building"});
#line 129
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table20, "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table21.AddRow(new string[] {
                        "ComputerSc: Status"});
#line 132
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table22.AddRow(new string[] {
                        "Region"});
#line 135
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table22, "And ");
#line 138
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.Then("Empty value is displayed on the first place for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table23.AddRow(new string[] {
                        "Not Onboarded"});
            table23.AddRow(new string[] {
                        "Onboarded"});
            table23.AddRow(new string[] {
                        "Forecast"});
            table23.AddRow(new string[] {
                        "Scheduled"});
            table23.AddRow(new string[] {
                        "Migrated"});
            table23.AddRow(new string[] {
                        "Complete"});
#line 140
 testRunner.Then("Pivot column headers is displayed in following order:", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

