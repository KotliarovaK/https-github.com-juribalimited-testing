﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Projects
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ProjectsPart11", Description="\tRuns Projects related tests on Admin page", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_AdminPage\\Projects\\ProjectsPart11.feature", SourceLine=0)]
    public partial class ProjectsPart11Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ProjectsPart11.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectsPart11", "\tRuns Projects related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        public virtual void EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject(string changingToList1, string changingToList2, string objectsToAdd1, string objectsToAdd2, string[] exampleTags)
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
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 10
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table901 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table901.AddRow(new string[] {
                            "Exchange 2003"});
#line 14
 testRunner.When("User add \"Mailbox Platform\" filter where type is \"Equals\" without added column an" +
                        "d following checkboxes:", ((string)(null)), table901, "When ");
#line hidden
#line 17
 testRunner.Then("\"6\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User create dynamic list with \"DynamicList77\" name on \"Mailboxes\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("\"DynamicList77\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table902 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table902.AddRow(new string[] {
                            "ZVF5144799@bclabs.local"});
                table902.AddRow(new string[] {
                            "zunigamn@bclabs.local"});
#line 20
 testRunner.When("User create static list with \"StaticList1429\" name on \"Mailboxes\" page with follo" +
                        "wing items", ((string)(null)), table902, "When ");
#line hidden
#line 24
 testRunner.Then("\"StaticList1429\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.Then("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table903 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table903.AddRow(new string[] {
                            "MailboxesProject3",
                            "All Mailboxes",
                            "None",
                            "Standalone Project"});
#line 26
 testRunner.When("Project created via API and opened", ((string)(null)), table903, "When ");
#line hidden
#line 29
 testRunner.And("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.Then("\"Mailboxes to add (0 of 14884 selected)\" is displayed to the user in the Project " +
                        "Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.And(string.Format("User selects \'{0}\' in the \'Scope\' dropdown with wait", changingToList1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.And(string.Format("User selects \'{0}\' in the \'Scope\' dropdown with wait", changingToList2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject, All Mailboxe" +
            "s", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "Cleanup",
                "Projects"}, SourceLine=43)]
        public virtual void EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject_AllMailboxes()
        {
#line 9
this.EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject("All Mailboxes", "StaticList1429", "Mailboxes to add (0 of 14884 selected)", "Mailboxes to add (0 of 2 selected)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject, StaticList14" +
            "29", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "Cleanup",
                "Projects"}, SourceLine=43)]
        public virtual void EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject_StaticList1429()
        {
#line 9
this.EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject("StaticList1429", "DynamicList77", "Mailboxes to add (0 of 2 selected)", "Mailboxes to add (0 of 6 selected)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChangingUserScopePermissionsForMailboxProject", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "Cleanup",
                "Projects"}, SourceLine=47)]
        public virtual void EvergreenJnr_AdminPage_ChangingUserScopePermissionsForMailboxProject()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "Cleanup",
                    "Projects"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChangingUserScopePermissionsForMailboxProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12999",
                        "Cleanup",
                        "Projects"});
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table904 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table904.AddRow(new string[] {
                            "TestName11881",
                            "All Mailboxes",
                            "None",
                            "Standalone Project"});
#line 49
 testRunner.When("Project created via API and opened", ((string)(null)), table904, "When ");
#line hidden
#line 52
 testRunner.Then("Page with \'TestName11881\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("User navigates to the \'User Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("User selects \"Do not include users\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("Scope List dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.Then("User Scope checkboxes are disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.Then("Application Scope tab is hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("\"Users to add (0 of 0 selected)\" is displayed to the user in the Project Scope Ch" +
                        "anges section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.And("User navigates to the \'User Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("User selects \"Include users associated to mailboxes\" checkbox on the Project deta" +
                        "ils page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("Scope List dropdown is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.Then("User Scope checkboxes are active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Then("Application Scope tab is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("\"Users to add (0 of 14757 selected)\" is displayed to the user in the Project Scop" +
                        "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_ChangingApplicationScopePermissionsForMailboxProject", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "Cleanup",
                "Projects"}, SourceLine=73)]
        public virtual void EvergreenJnr_AdminPage_ChangingApplicationScopePermissionsForMailboxProject()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "Cleanup",
                    "Projects"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChangingApplicationScopePermissionsForMailboxProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12999",
                        "Cleanup",
                        "Projects"});
#line 74
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table905 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table905.AddRow(new string[] {
                            "TestName12881",
                            "All Mailboxes",
                            "None",
                            "Standalone Project"});
#line 75
 testRunner.When("Project created via API and opened", ((string)(null)), table905, "When ");
#line hidden
#line 78
 testRunner.Then("Page with \'TestName12881\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.And("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And("User selects \"Include applications\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.Then("Scope List dropdown is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.Then("Application Scope checkboxes are active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.When("User selects \"Do not include applications\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.Then("Scope List dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("\"Applications to add (0 of 0 selected)\" is displayed to the user in the Project S" +
                        "cope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AdminPage_OnboardingMailboxesUsersApplicationsObjectsUsingUpdateAllC" +
            "hangesButton", new string[] {
                "Evergreen",
                "Admin",
                "EvergreenJnr_AdminPage",
                "AdminPage",
                "DAS12999",
                "DAS13199",
                "Cleanup",
                "Project_Creation_and_Scope",
                "Projects"}, SourceLine=91)]
        public virtual void EvergreenJnr_AdminPage_OnboardingMailboxesUsersApplicationsObjectsUsingUpdateAllChangesButton()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "DAS12999",
                    "DAS13199",
                    "Cleanup",
                    "Project_Creation_and_Scope",
                    "Projects"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_OnboardingMailboxesUsersApplicationsObjectsUsingUpdateAllC" +
                    "hangesButton", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS12999",
                        "DAS13199",
                        "Cleanup",
                        "Project_Creation_and_Scope",
                        "Projects"});
#line 92
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 93
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.When("User clicks \'CREATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.Then("Page with \'Create Project\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.When("User enters \'TestProject65\' text to \'Project Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
 testRunner.And("User selects \'All Mailboxes\' option from \'Scope\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.Then("\'The project has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.Then("Info message is displayed and contains \"There are no objects in this project, use" +
                        " Scope Changes to add objects to your project\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 105
 testRunner.Then("Page with \'TestProject65\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.Then("\"Mailboxes to add (0 of 14884 selected)\" is displayed to the user in the Project " +
                        "Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table906 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table906.AddRow(new string[] {
                            "003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie)"});
                table906.AddRow(new string[] {
                            "00DB4000EDD84951993@bclabs.local (CSC, SS)"});
#line 108
 testRunner.When("User expands multiselect and selects following Objects", ((string)(null)), table906, "When ");
#line hidden
#line 112
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.Then("\"Users to add (0 of 14757 selected)\" is displayed to the user in the Project Scop" +
                        "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table907 = new TechTalk.SpecFlow.Table(new string[] {
                            "Objects"});
                table907.AddRow(new string[] {
                            "02E0346DF7804F25835 (Gill, Donna)"});
                table907.AddRow(new string[] {
                            "037AF4CF47C1452D8A4 (Vanetti, Joe)"});
#line 114
 testRunner.When("User expands multiselect and selects following Objects", ((string)(null)), table907, "When ");
#line hidden
#line 125
 testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 126
 testRunner.And("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.Then("\'4 objects queued for onboarding, 0 objects offboarded\' text is displayed on inli" +
                        "ne success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.When("User navigates to the \'Mailboxes\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("\"Mailboxes to add (0 of 14882 selected)\" is displayed to the user in the Project " +
                        "Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 132
 testRunner.Then("\"Users to add (0 of 14755 selected)\" is displayed to the user in the Project Scop" +
                        "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
