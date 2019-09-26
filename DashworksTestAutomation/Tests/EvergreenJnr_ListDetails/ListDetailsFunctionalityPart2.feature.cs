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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ListDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ListDetailsFunctionalityPart2")]
    public partial class ListDetailsFunctionalityPart2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ListDetailsFunctionalityPart2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart2", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.TestCaseAttribute("Devices", null)]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists(string pageName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultListsInternal(pageName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultListsInternal(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS10880"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("\"All {0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then("List details button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS11951")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", null)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists(string pageName, string columnname, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicListsInternal(pageName,columnname,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicListsInternal(string pageName, string columnname, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS10880",
                    "DAS11951",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists", null, @__tags);
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 23
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then(string.Format("\"All {0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When(string.Format("User create dynamic list with \"TestListCED2D6\" name on \"{0}\" page", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("\"TestListCED2D6\" name is displayed in list details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("List is NOT marked as favorite", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.Then("current user is selected as a owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then("\"Private\" sharing option is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10880")]
        [NUnit.Framework.CategoryAttribute("DAS12152")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", null)]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", null)]
        public virtual void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists(string pageName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticListsInternal(pageName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticListsInternal(string pageName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS10880",
                    "DAS12152",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists", null, @__tags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table1.AddRow(new string[] {
                        ""});
#line 44
 testRunner.When(string.Format("User create static list with \"Static List TestName\" name on \"{0}\" page with follo" +
                        "wing items", pageName), ((string)(null)), table1, "When ");
#line 47
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.Then("\"Static List TestName\" name is displayed in list details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.Then("List is NOT marked as favorite", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.Then("current user is selected as a owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("\"Private\" sharing option is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11493")]
        [NUnit.Framework.CategoryAttribute("DAS11951")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel(string pageName, string columnname, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanelInternal(pageName,columnname,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanelInternal(string pageName, string columnname, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS11493",
                    "DAS11951",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel", null, @__tags);
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 63
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then(string.Format("\"All {0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("User create custom list with \"TestListE11493\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("\"TestListE11493\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("List details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.When("User select \"Automation Admin 1\" as a Owner of a list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.And("User click Accept button in List Details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("List details button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.And("list with \"TestListE11493\" name is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And(string.Format("\"All {0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

