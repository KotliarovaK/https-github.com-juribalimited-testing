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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Projects
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ProjectsPart8")]
    public partial class ProjectsPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProjectsPart8.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectsPart8", "\tRuns Projects related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.TestCaseAttribute("TestProject9553", "StaticList8891", "Mailboxes", "00A5B910A1004CF5AC4@bclabs.local", "Email Address", "DynamicList9537", null)]
        [NUnit.Framework.TestCaseAttribute("TestProject9554", "StaticList8892", "Users", "003F5D8E1A844B1FAA5", "Username", "DynamicList9538", null)]
        public virtual void EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPage(string projectName, string staticList, string pageName, string item, string columnName, string dynamicList, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPageInternal(projectName,staticList,pageName,item,columnName,dynamicList,exampleTags);
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

        private void EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPageInternal(string projectName, string staticList, string pageName, string item, string columnName, string dynamicList, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "Cleanup",
                    "Cleanup",
                    "Projects"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPage", null, @__tags);
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
 testRunner.When("User selects \'Project\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When(string.Format("User enters \'{0}\' text to \'Project Name\' textbox", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then(string.Format("\'All {0}\' content is displayed in \'Scope\' autocomplete", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("\'The project has been created\' text is displayed on success inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When(string.Format("User enters \"{0}\" text in the Search field for \"Project\" column", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User removes selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table1.AddRow(new string[] {
                        string.Format("{0}", item)});
#line 23
 testRunner.When(string.Format("User create static list with \"{0}\" name on \"{1}\" page with following items", staticList, pageName), ((string)(null)), table1, "When ");
#line 26
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", staticList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User selects \'Project\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When(string.Format("User enters \'{0}\' text to \'Project Name\' textbox", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then(string.Format("\'{0}\' content is displayed in \'Scope\' autocomplete", staticList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("\'The project has been created\' text is displayed on success inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When(string.Format("User enters \"{0}\" text in the Search field for \"Project\" column", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User removes selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And(string.Format("User create dynamic list with \"{0}\" name on \"{1}\" page", dynamicList, pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then(string.Format("\"{0}\" list is displayed to user", dynamicList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When("User selects \'Project\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When(string.Format("User enters \'{0}\' text to \'Project Name\' textbox", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then(string.Format("\'{0}\' content is displayed in \'Scope\' autocomplete", dynamicList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("\'The project has been created\' text is displayed on success inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButton")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("DAS13199")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.TestCaseAttribute("All Mailboxes", "Mailboxes", "003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie)", "1 mailbox will be added", "1 object queued for onboarding, 0 objects offboarded", null)]
        [NUnit.Framework.TestCaseAttribute("All Devices", "Users", "ADC714277 (Dina Q. Knight)", "1 user will be added", "1 object queued for onboarding, 0 objects offboarded", null)]
        public virtual void EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButton(string allListName, string tabName, string objectsToAdd, string warningMessageText, string successMessageText, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButtonInternal(allListName,tabName,objectsToAdd,warningMessageText,successMessageText,exampleTags);
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

        private void EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButtonInternal(string allListName, string tabName, string objectsToAdd, string warningMessageText, string successMessageText, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS13199",
                    "Cleanup",
                    "Projects"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButton", null, @__tags);
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 55
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks \'CREATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("User enters \'TestProject9753\' text to \'Project Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And(string.Format("User selects \'{0}\' option from \'Scope\' autocomplete", allListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("\'The project has been created\' text is displayed on success inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("Page with \'TestProject9753\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.Then("Info message is displayed and contains \"There are no objects in this project, use" +
                    " Scope Changes to add objects to your project\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.And(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", tabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table2.AddRow(new string[] {
                        string.Format("{0}", objectsToAdd)});
#line 70
 testRunner.And("User expands multiselect and selects following Objects", ((string)(null)), table2, "And ");
#line 73
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then(string.Format("\'{0}\' text is displayed on warning inline tip banner", warningMessageText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then(string.Format("\'{0}\' text is displayed on success inline tip banner", successMessageText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBucke" +
            "ts")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("DAS13199")]
        [NUnit.Framework.CategoryAttribute("DAS12781")]
        [NUnit.Framework.CategoryAttribute("DAS12903")]
        [NUnit.Framework.CategoryAttribute("DAS12485")]
        [NUnit.Framework.CategoryAttribute("DAS13803")]
        [NUnit.Framework.CategoryAttribute("DAS13930")]
        [NUnit.Framework.CategoryAttribute("DAS13973")]
        [NUnit.Framework.CategoryAttribute("DAS13530")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBuckets()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBucketsInternal();
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

        private void EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBucketsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBucke" +
                    "ts", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12999",
                        "DAS13199",
                        "DAS12781",
                        "DAS12903",
                        "DAS12485",
                        "DAS13803",
                        "DAS13930",
                        "DAS13973",
                        "DAS13530",
                        "Projects",
                        "Cleanup"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 85
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User clicks \'CREATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.When("User enters \'1MailboxesProject\' text to \'Project Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.When("User selects \'All Mailboxes\' option from \'Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.Then("\'The project has been created\' text is displayed on success inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.When("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.When("User selects \"Select All\" checkbox from String Filter with item list on the Admin" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.When("User selects \"1MailboxesProject\" checkbox from String Filter with item list on th" +
                    "e Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("Rows counter contains \"1\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.Then("\'Unassigned\' content is displayed in the \'Bucket\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.When("User enters \"1MailboxesProject\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.Then("Page with \'1MailboxesProject\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then("\"Mailbox scoped project\" is displayed in the disabled Project Type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.When("User selects \"Clone evergreen buckets to project buckets\" in the Buckets Project " +
                    "dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.Then("\'Match to Evergreen Bucket\' content is displayed in \'Bucket\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
 testRunner.When("User clicks \'Administration\' header breadcrumb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.When("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.When("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.When("User selects \"Select All\" checkbox from String Filter with item list on the Admin" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.When("User selects \"1MailboxesProject\" checkbox from String Filter with item list on th" +
                    "e Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.Then("Rows counter contains \"1\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.Then("\'Unassigned\' content is displayed in the \'Bucket\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCa" +
            "pacityUnitsMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS13530")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCapacityUnitsMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCapacityUnitsModeInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCapacityUnitsModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCa" +
                    "pacityUnitsMode", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS13530",
                        "Projects",
                        "Cleanup"});
#line 128
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 129
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.When("User clicks \'CREATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.When("User enters \'13530Project\' text to \'Project Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.And("User selects \'All Devices\' option from \'Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.Then("\'The project has been created\' text is displayed on success inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.When("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("User selects \"Evergreen\" checkbox from String Filter with item list on the Admin " +
                    "page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("User selects \"13530Project\" checkbox from String Filter with item list on the Adm" +
                    "in page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("Rows counter contains \"1\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.And("\'Unassigned\' content is displayed in the \'Capacity Unit\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
 testRunner.And("User enters \"13530Project\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.Then("Page with \'13530Project\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.When("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 152
 testRunner.And("User selects \'Clone evergreen capacity units to project capacity units\' in the \'C" +
                    "apacity Units\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.Then("\'The project capacity details have been updated\' text is displayed on success inl" +
                    "ine tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.When("User clicks \'Administration\' header breadcrumb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.And("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("User navigates to the \'Capacity Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And("User selects \"Evergreen\" checkbox from String Filter with item list on the Admin " +
                    "page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.And("User selects \"13530Project\" checkbox from String Filter with item list on the Adm" +
                    "in page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.Then("Rows counter contains \"1\" found row of all rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.Then("\'Unassigned\' content is displayed in the \'Capacity Unit\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

