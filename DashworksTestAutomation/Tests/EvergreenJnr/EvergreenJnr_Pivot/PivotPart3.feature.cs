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
    [NUnit.Framework.DescriptionAttribute("PivotPart3")]
    public partial class PivotPart3Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PivotPart3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PivotPart3", "\tRuns Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatTaskValuesAsRowGroupsAreDisplayedInTheCorrectOr" +
            "der")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14377")]
        [NUnit.Framework.CategoryAttribute("DAS13864")]
        public virtual void EvergreenJnr_DevicesList_CheckThatTaskValuesAsRowGroupsAreDisplayedInTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatTaskValuesAsRowGroupsAreDisplayedInTheCorrectOrderInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatTaskValuesAsRowGroupsAreDisplayedInTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatTaskValuesAsRowGroupsAreDisplayedInTheCorrectOr" +
                    "der", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14377",
                        "DAS13864"});
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
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table1.AddRow(new string[] {
                        "UseMeForAu: Ring"});
#line 13
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table2.AddRow(new string[] {
                        "City"});
#line 16
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "Owner Cost Centre"});
#line 19
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table3, "And ");
#line 22
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Then("data in the column headers is sorted in correct order for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("color data in the left-pinned column is sorted in descending order for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrec" +
            "tOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14378")]
        [NUnit.Framework.CategoryAttribute("DAS13864")]
        [NUnit.Framework.CategoryAttribute("DAS13786")]
        [NUnit.Framework.CategoryAttribute("DAS13867")]
        [NUnit.Framework.CategoryAttribute("DAS15376")]
        public virtual void EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrectOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrectOrderInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrectOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrec" +
                    "tOrder", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14378",
                        "DAS13864",
                        "DAS13786",
                        "DAS13867",
                        "DAS15376"});
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 29
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table4.AddRow(new string[] {
                        "Hostname"});
#line 32
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table5.AddRow(new string[] {
                        "Windows7Mi: Pre-Migration \\ Target Date"});
#line 35
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table6.AddRow(new string[] {
                        "Owner Cost Centre"});
#line 38
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table6, "And ");
#line 41
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Then("date in the column headers is sorted in correct order for the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("data in the table is sorted by \"Hostname\" column in ascending order by default fo" +
                    "r the Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "StartDateInclusive",
                        "EndDateInclusive"});
            table7.AddRow(new string[] {
                        "25 Apr 2018",
                        "02 May 2018"});
#line 47
 testRunner.When("User add \"Owner Last Logon Date\" filter where type is \"Between\" without added col" +
                    "umn and Date options", ((string)(null)), table7, "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadine" +
            "ssFieldForMailboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13860")]
        [NUnit.Framework.CategoryAttribute("DAS14555")]
        [NUnit.Framework.CategoryAttribute("DAS15376")]
        public virtual void EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForMailboxes()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForMailboxesInternal();
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

        private void EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForMailboxesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadine" +
                    "ssFieldForMailboxes", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13860",
                        "DAS14555",
                        "DAS15376"});
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 55
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table8.AddRow(new string[] {
                        "MailboxEve: In Scope"});
            table8.AddRow(new string[] {
                        "MailboxEve: Readiness"});
#line 58
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table9.AddRow(new string[] {
                        "City"});
#line 62
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table10.AddRow(new string[] {
                        "MailboxEve: Readiness"});
#line 65
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table10, "And ");
#line 68
 testRunner.When("User selects aggregate function \"Severity\" on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.When("User expanded \"TRUE\" left-pinned value on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value1",
                        "Value2"});
            table11.AddRow(new string[] {
                        "TRUE",
                        "OUT OF SCOPE"});
            table11.AddRow(new string[] {
                        "OUT OF SCOPE",
                        "OUT OF SCOPE"});
            table11.AddRow(new string[] {
                        "PURPLE",
                        "PURPLE"});
            table11.AddRow(new string[] {
                        "NONE",
                        "NONE"});
#line 72
 testRunner.Then("following values are displayed for \"London\" column on Pivot", ((string)(null)), table11, "Then ");
#line 78
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "StartDateInclusive",
                        "EndDateInclusive"});
            table12.AddRow(new string[] {
                        "25 Apr 2018",
                        "02 May 2018"});
#line 80
 testRunner.When("User add \"Last Logon Date\" filter where type is \"Between\" without added column an" +
                    "d Date options", ((string)(null)), table12, "When ");
#line 83
 testRunner.Then("\"(Last Logon Date between (2018-04-25, 2018-05-02))\" text is displayed in filter " +
                    "container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForRead" +
            "inessFieldForApplications")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13860")]
        [NUnit.Framework.CategoryAttribute("DAS14555")]
        [NUnit.Framework.CategoryAttribute("DAS13786")]
        [NUnit.Framework.CategoryAttribute("DAS13771")]
        [NUnit.Framework.CategoryAttribute("DAS15376")]
        [NUnit.Framework.CategoryAttribute("DAS17669")]
        public virtual void EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForApplications()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForApplicationsInternal();
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

        private void EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForApplicationsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForRead" +
                    "inessFieldForApplications", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13860",
                        "DAS14555",
                        "DAS13786",
                        "DAS13771",
                        "DAS15376",
                        "DAS17669"});
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 87
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table13.AddRow(new string[] {
                        "Vendor"});
            table13.AddRow(new string[] {
                        "Application"});
#line 90
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table14.AddRow(new string[] {
                        "Inventory Site"});
#line 94
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table15.AddRow(new string[] {
                        "ComputerSc: Target App Readiness"});
#line 97
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table15, "And ");
#line 100
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("user select \"Vendor\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.When("User select \"Equals\" Operator value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.When("User enters \"Microsoft\" text in Search field at selected Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.When("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.When("User clicks the Pivot button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.When("User selects aggregate function \"Severity\" on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.When("User expanded \"Microsoft\" left-pinned value on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value1",
                        "Value2"});
            table16.AddRow(new string[] {
                        "Microsoft",
                        "BLUE"});
            table16.AddRow(new string[] {
                        "\"WPF/E\" (codename) Community Technology Preview (Feb 2007)",
                        "GREEN"});
            table16.AddRow(new string[] {
                        "0036 - Microsoft Access 97 SR-2 English",
                        "LIGHT BLUE"});
            table16.AddRow(new string[] {
                        "0047 - Microsoft Access 97 SR-2 Francais",
                        "GREEN"});
#line 111
 testRunner.Then("following values are displayed for \"TierA Site01\" column on Pivot", ((string)(null)), table16, "Then ");
#line 117
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "StartDateInclusive",
                        "EndDateInclusive",
                        "Association"});
            table17.AddRow(new string[] {
                        "25 Apr 2018",
                        "02 May 2018",
                        "Has used app"});
#line 119
 testRunner.When("User add \"User Last Logon Date\" filter where type is \"Between\" with following Dat" +
                    "e options and Associations:", ((string)(null)), table17, "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFi" +
            "eldForUsers")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13860")]
        [NUnit.Framework.CategoryAttribute("DAS14555")]
        public virtual void EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForUsers()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForUsersInternal();
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

        private void EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForUsersInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFi" +
                    "eldForUsers", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13860",
                        "DAS14555"});
#line 126
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 127
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table18.AddRow(new string[] {
                        "Building"});
            table18.AddRow(new string[] {
                        "Floor"});
#line 130
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table18, "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table19.AddRow(new string[] {
                        "Country"});
#line 134
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table20.AddRow(new string[] {
                        "Babel(Engl: Application Readiness"});
#line 137
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table20, "And ");
#line 140
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.When("user select \"Country\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.When("User select \"Equals\" Operator value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.When("User enters \"USA\" text in Search field at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 145
 testRunner.When("User clicks checkbox at selected Lookup Filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 146
 testRunner.When("User clicks Save filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.When("User clicks the Pivot button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
 testRunner.When("User selects aggregate function \"Severity\" on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.When("User expanded \"101 Hudson Street\" left-pinned value on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value1",
                        "Value2"});
            table21.AddRow(new string[] {
                        "101 Hudson Street",
                        "BLUE"});
            table21.AddRow(new string[] {
                        "20",
                        "IGNORE"});
            table21.AddRow(new string[] {
                        "21",
                        "BLUE"});
#line 152
 testRunner.Then("following values are displayed for \"USA\" column on Pivot", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadiness" +
            "FieldForDevices")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS13860")]
        [NUnit.Framework.CategoryAttribute("DAS14555")]
        [NUnit.Framework.CategoryAttribute("DAS17669")]
        public virtual void EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForDevices()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForDevicesInternal();
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

        private void EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForDevicesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadiness" +
                    "FieldForDevices", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS13860",
                        "DAS14555",
                        "DAS17669"});
#line 159
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 160
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table22.AddRow(new string[] {
                        "Country"});
            table22.AddRow(new string[] {
                        "City"});
#line 163
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table23.AddRow(new string[] {
                        "Manufacturer"});
#line 167
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table23, "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table24.AddRow(new string[] {
                        "1803: Readiness"});
#line 170
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table24, "And ");
#line 173
 testRunner.When("User selects aggregate function \"Severity\" on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
 testRunner.And("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.When("User expanded \"USA\" left-pinned value on Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value1",
                        "Value2"});
            table25.AddRow(new string[] {
                        "USA",
                        "BLOCKED"});
            table25.AddRow(new string[] {
                        "Los Angeles",
                        "GREEN"});
            table25.AddRow(new string[] {
                        "San Diego",
                        "BLOCKED"});
#line 177
 testRunner.Then("following values are displayed for \"Asus\" column on Pivot", ((string)(null)), table25, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

