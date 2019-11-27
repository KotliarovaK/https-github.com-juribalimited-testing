﻿// ------------------------------------------------------------------------------
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
    [NUnit.Framework.DescriptionAttribute("ProjectsPart10")]
    public partial class ProjectsPart10Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProjectsPart10.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectsPart10", "\tRuns Projects related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ChangingApplicationsScopeListToAnotherList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.TestCaseAttribute("All Applications", "DynamicList57", "Applications to add (0 of 2129 selected)", "Applications to add (0 of 39 selected)", null)]
        [NUnit.Framework.TestCaseAttribute("StaticList6379", "All Applications", "Applications to add (0 of 2 selected)", "Applications to add (0 of 2129 selected)", null)]
        public virtual void EvergreenJnr_ChangingApplicationsScopeListToAnotherList(string changingToList1, string changingToList2, string applicationsToAdd1, string applicationsToAdd2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "Cleanup",
                    "Projects"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ChangingApplicationsScopeListToAnotherList", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        "Adobe"});
#line 14
 testRunner.When("User add \"Vendor\" filter where type is \"Equals\" with added column and following v" +
                    "alue:", ((string)(null)), table1, "When ");
#line 17
 testRunner.Then("\"39\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("User create dynamic list with \"DynamicList57\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("\"DynamicList57\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table2.AddRow(new string[] {
                        "ACD Display 3.4"});
            table2.AddRow(new string[] {
                        "Acrobat Reader 4"});
#line 20
 testRunner.When("User create static list with \"StaticList6379\" name on \"Applications\" page with fo" +
                    "llowing items", ((string)(null)), table2, "When ");
#line 24
 testRunner.Then("\"StaticList6379\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table3.AddRow(new string[] {
                        "DevicesProject4",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 26
 testRunner.When("Project created via API and opened", ((string)(null)), table3, "When ");
#line 29
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("\"Applications to add (0 of 2129 selected)\" is displayed to the user in the Projec" +
                    "t Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.When("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.And(string.Format("User selects \'{0}\' in the \'Application Scope\' dropdown with wait", changingToList1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", applicationsToAdd1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.When("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And(string.Format("User selects \'{0}\' in the \'Application Scope\' dropdown with wait", changingToList2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", applicationsToAdd2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ChangingUsersScopeListToAnotherListForUserProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("DAS13973")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.TestCaseAttribute("All Users", "StaticList6329", "Clone from Evergreen to Project", "Users to add (0 of 41339 selected)", "Users to add (0 of 2 selected)", null)]
        [NUnit.Framework.TestCaseAttribute("StaticList6329", "DynamicList37", "Standalone Project", "Users to add (0 of 2 selected)", "Users to add (0 of 92 selected)", null)]
        public virtual void EvergreenJnr_ChangingUsersScopeListToAnotherListForUserProject(string changingToList1, string changingToList2, string mode, string objectsToAdd1, string objectsToAdd2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS13973",
                    "Cleanup",
                    "Projects"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ChangingUsersScopeListToAnotherListForUserProject", null, @__tags);
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 54
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table4.AddRow(new string[] {
                        "DEV50"});
#line 58
 testRunner.When("User add \"Domain\" filter where type is \"Equals\" with added column and Lookup opti" +
                    "on", ((string)(null)), table4, "When ");
#line 61
 testRunner.Then("\"92\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("User create dynamic list with \"DynamicList37\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("\"DynamicList37\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table5.AddRow(new string[] {
                        "barbosaj"});
            table5.AddRow(new string[] {
                        "clarkc"});
#line 64
 testRunner.When("User create static list with \"StaticList6329\" name on \"Users\" page with following" +
                    " items", ((string)(null)), table5, "When ");
#line 68
 testRunner.Then("\"StaticList6329\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table6.AddRow(new string[] {
                        "DevicesProject5",
                        "All Users",
                        "None",
                        string.Format("{0}", mode)});
#line 70
 testRunner.When("Project created via API and opened", ((string)(null)), table6, "When ");
#line 74
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("\"Users to add (0 of 41339 selected)\" is displayed to the user in the Project Scop" +
                    "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And(string.Format("User selects \'{0}\' in the \'Scope\' dropdown with wait", changingToList1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.And(string.Format("User selects \'{0}\' in the \'Scope\' dropdown with wait", changingToList2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChangingDynamicListToAllListForUserAndMailboxProjects")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("DAS18943")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Operating System", "Windows 8", "28", "All Users", "All Devices", "Devices", "Device Scope", "Devices to add (0 of 16819 selected)", "StaticList6429", "Devices to add (0 of 24 selected)", "Devices to add (0 of 16819 selected)", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Domain", "CA", "850", "All Mailboxes", "All Users", "Users", "User Scope", "Users to add (0 of 14747 selected)", "DynamicList17", "Users to add (0 of 0 selected)", "Users to add (0 of 14747 selected)", null)]
        public virtual void EvergreenJnr_AdminPage_ChangingDynamicListToAllListForUserAndMailboxProjects(string listName, string filterName, string filterValue, string rows, string projectList, string allList, string scopeChanges, string scopeDetails, string objectsToAdd, string changingToList, string objectsToAdd1, string objectsToAdd2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS18943",
                    "Cleanup",
                    "Projects"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChangingDynamicListToAllListForUserAndMailboxProjects", null, @__tags);
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 94
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then(string.Format("\'All {0}\' list should be displayed to the user", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table7.AddRow(new string[] {
                        string.Format("{0}", filterValue)});
#line 98
 testRunner.When(string.Format("User add \"{0}\" filter where type is \"Equals\" with added column and Lookup option", filterName), ((string)(null)), table7, "When ");
#line 101
 testRunner.Then(string.Format("\"{0}\" rows are displayed in the agGrid", rows), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When(string.Format("User create dynamic list with \"DynamicList58\" name on \"{0}\" page", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("\"DynamicList58\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table8.AddRow(new string[] {
                        "DevicesProject8",
                        string.Format("{0}", projectList),
                        "None",
                        "Standalone Project"});
#line 104
 testRunner.When("Project created via API and opened", ((string)(null)), table8, "When ");
#line 107
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.When(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeChanges), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.When(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.And(string.Format("User selects \'DynamicList58\' in the \'{0}\' dropdown with wait", scopeDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.When(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeChanges), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.When(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.And(string.Format("User selects \'{0}\' in the \'{1}\' dropdown with wait", allList, scopeDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.When(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeChanges), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ChangingApplicationScopeListToAnotherListForUserProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS12999")]
        [NUnit.Framework.CategoryAttribute("DAS13297")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.TestCaseAttribute("All Applications", "StaticList6429", "Applications to add (0 of 2081 selected)", "Applications to add (0 of 2 selected)", null)]
        [NUnit.Framework.TestCaseAttribute("StaticList6429", "DynamicList17", "Applications to add (0 of 2 selected)", "Applications to add (0 of 1612 selected)", null)]
        public virtual void EvergreenJnr_ChangingApplicationScopeListToAnotherListForUserProject(string changingToList1, string changingToList2, string objectsToAdd1, string objectsToAdd2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS13297",
                    "Cleanup",
                    "Projects"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ChangingApplicationScopeListToAnotherListForUserProject", null, @__tags);
#line 131
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 132
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table9.AddRow(new string[] {
                        "97.1.0.0918(1031)"});
#line 136
 testRunner.When("User add \"Version\" filter where type is \"Does not contain\" with added column and " +
                    "following value:", ((string)(null)), table9, "When ");
#line 139
 testRunner.Then("\"1,741\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.When("User create dynamic list with \"DynamicList17\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("\"DynamicList17\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table10.AddRow(new string[] {
                        "WMI Tools"});
            table10.AddRow(new string[] {
                        "Windows Live Toolbar"});
#line 142
 testRunner.When("User create static list with \"StaticList6429\" name on \"Applications\" page with fo" +
                    "llowing items", ((string)(null)), table10, "When ");
#line 146
 testRunner.Then("\"StaticList6429\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table11.AddRow(new string[] {
                        "DevicesProject9",
                        "All Users",
                        "None",
                        "Standalone Project"});
#line 148
 testRunner.When("Project created via API and opened", ((string)(null)), table11, "When ");
#line 151
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 154
 testRunner.Then("\"Applications to add (0 of 2081 selected)\" is displayed to the user in the Projec" +
                    "t Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.When("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
 testRunner.And(string.Format("User selects \'{0}\' in the \'Application Scope\' dropdown with wait", changingToList1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 160
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.When("User navigates to the \'Scope Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
 testRunner.When("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.And(string.Format("User selects \'{0}\' in the \'Application Scope\' dropdown with wait", changingToList2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.When("User navigates to the \'Scope Changes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 165
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 166
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 167
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

