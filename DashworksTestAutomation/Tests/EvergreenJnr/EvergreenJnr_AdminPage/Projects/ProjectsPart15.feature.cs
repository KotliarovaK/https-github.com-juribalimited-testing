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
    [NUnit.Framework.DescriptionAttribute("ProjectsPart15")]
    public partial class ProjectsPart15Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProjectsPart15.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectsPart15", "\tRuns Projects related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatSelectedBucketsIsDisplayedForOnboardedObjectsInQu" +
            "eueAndHistory")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12787")]
        [NUnit.Framework.CategoryAttribute("DAS13529")]
        [NUnit.Framework.CategoryAttribute("DAS16128")]
        [NUnit.Framework.CategoryAttribute("DAS15201")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatSelectedBucketsIsDisplayedForOnboardedObjectsInQueueAndHistory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatSelectedBucketsIsDisplayedForOnboardedObjectsInQu" +
                    "eueAndHistory", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12787",
                        "DAS13529",
                        "DAS16128",
                        "DAS15201",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table1.AddRow(new string[] {
                        "UsersProject3",
                        "All Users",
                        "None",
                        "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1, "When ");
#line 13
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When("User clicks \'Projects\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("User navigate to \"UsersProject3\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("Project with \"UsersProject3\" name is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("User navigate to \"Groups\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("\"Manage Groups\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("User clicks \"Create Group\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "GroupName"});
            table2.AddRow(new string[] {
                        "UsersProject3Group"});
#line 22
 testRunner.And("User create Group owned existing \"Admin IT\" Team", ((string)(null)), table2, "And ");
#line 25
 testRunner.When("User clicks \"Create Group\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("User navigate to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("User enters \"UsersProject3\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("Page with \'UsersProject3\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User selects \'UsersProject3Group\' in the \'Bucket\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table3.AddRow(new string[] {
                        "003F5D8E1A844B1FAA5 (Hunter, Melanie)"});
#line 34
 testRunner.And("User expands multiselect and selects following Objects", ((string)(null)), table3, "And ");
#line 37
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("\'1 object queued for onboarding, 0 objects offboarded\' text is displayed on succe" +
                    "ss inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("User navigates to the \'Queue\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table4.AddRow(new string[] {
                        "003F5D8E1A844B1FAA5"});
#line 41
 testRunner.Then("following Items are displayed in the Queue table", ((string)(null)), table4, "Then ");
#line 44
 testRunner.Then("\'UsersProject3Group\' content is displayed in the \'Bucket\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.Then("\'Unassigned\' content is displayed in the \'Capacity Unit\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table5.AddRow(new string[] {
                        "Date"});
            table5.AddRow(new string[] {
                        "Item"});
            table5.AddRow(new string[] {
                        "Object Type"});
            table5.AddRow(new string[] {
                        "Action"});
            table5.AddRow(new string[] {
                        "Bucket"});
            table5.AddRow(new string[] {
                        "Capacity Unit"});
            table5.AddRow(new string[] {
                        "Ring"});
#line 46
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table5, "Then ");
#line 55
 testRunner.When("User enters \"Unassigned\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("Rows counter shows \"1\" of \"1\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.When("User navigates to the \'History\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table6.AddRow(new string[] {
                        "003F5D8E1A844B1FAA5"});
#line 58
 testRunner.Then("following Items are displayed in the History table", ((string)(null)), table6, "Then ");
#line 61
 testRunner.And("\'UsersProject3Group\' content is displayed in the \'Bucket\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("\'Unassigned\' content is displayed in the \'Capacity Unit\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        "Date"});
            table7.AddRow(new string[] {
                        "Item"});
            table7.AddRow(new string[] {
                        "Object Type"});
            table7.AddRow(new string[] {
                        "Action"});
            table7.AddRow(new string[] {
                        "Bucket"});
            table7.AddRow(new string[] {
                        "Capacity Unit"});
            table7.AddRow(new string[] {
                        "Ring"});
            table7.AddRow(new string[] {
                        "Status"});
#line 63
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table7, "Then ");
#line 73
 testRunner.When("User enters \"Units\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("Rows counter shows \"0\" of \"1\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatProjectScopeChangesIsLoadedSuccessfullyAfterChang" +
            "ingProjectScopeToACustomList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12157")]
        [NUnit.Framework.CategoryAttribute("DAS18943")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("All Devices", "DAS12157A", "Devices to add (0 of 1 selected)", "DevicesList12157", "User Scope", "User Scope", "UsersList12157", "Users", "Users to add (0 of 1 selected)", "Applications to add (0 of 1 selected)", null)]
        [NUnit.Framework.TestCaseAttribute("All Users", "DAS12157B", "Users to add (0 of 1 selected)", "UsersList12157", "Device Scope", "Device Scope", "DevicesList12157", "Devices", "Devices to add (0 of 1 selected)", "Applications to add (0 of 1 selected)", null)]
        [NUnit.Framework.TestCaseAttribute("All Mailboxes", "DAS12157C", "Mailboxes to add (0 of 1 selected)", "MailboxesList12157", "User Scope", "User Scope", "UsersList12157", "Users", "Users to add (0 of 0 selected)", "Applications to add (0 of 0 selected)", null)]
        public virtual void EvergreenJnr_AdminPage_CheckThatProjectScopeChangesIsLoadedSuccessfullyAfterChangingProjectScopeToACustomList(string mainList, string testName, string objectsToAdd1, string listToScope1, string scopeTab1, string scopeSelectbox, string listToScope2, string scopeChanges1, string objectsToAdd2, string objectsToAdd3, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "AdminPage",
                    "Projects",
                    "DAS12157",
                    "DAS18943",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatProjectScopeChangesIsLoadedSuccessfullyAfterChang" +
                    "ingProjectScopeToACustomList", null, @__tags);
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table8.AddRow(new string[] {
                        "0I29CJMQ159EOR"});
#line 78
 testRunner.When("User create static list with \"DevicesList12157\" name on \"Devices\" page with follo" +
                    "wing items", ((string)(null)), table8, "When ");
#line 81
 testRunner.Then("\"DevicesList12157\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table9.AddRow(new string[] {
                        "TSI892249"});
#line 82
 testRunner.When("User create static list with \"UsersList12157\" name on \"Users\" page with following" +
                    " items", ((string)(null)), table9, "When ");
#line 85
 testRunner.Then("\"UsersList12157\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table10.AddRow(new string[] {
                        "elsonje@bclabs.local"});
#line 86
 testRunner.When("User create static list with \"MailboxesList12157\" name on \"Mailboxes\" page with f" +
                    "ollowing items", ((string)(null)), table10, "When ");
#line 89
 testRunner.Then("\"MailboxesList12157\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table11.AddRow(new string[] {
                        "Adobe SVG Viewer 3.0"});
#line 90
 testRunner.When("User create static list with \"ApplicationsStaticList12157\" name on \"Applications\"" +
                    " page with following items", ((string)(null)), table11, "When ");
#line 93
 testRunner.Then("\"ApplicationsStaticList12157\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table12.AddRow(new string[] {
                        string.Format("{0}", testName),
                        string.Format("{0}", mainList),
                        "None",
                        "Standalone Project"});
#line 94
 testRunner.When("Project created via API and opened", ((string)(null)), table12, "When ");
#line 97
 testRunner.Then(string.Format("Page with \'{0}\' header is displayed to user", testName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When(string.Format("User selects \'{0}\' in the \'Scope\' dropdown with wait", listToScope1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.And(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeTab1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And(string.Format("User selects \'{0}\' in the \'{1}\' dropdown with wait", listToScope2, scopeSelectbox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.When("User selects \"Include applications\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.And("User selects \'ApplicationsStaticList12157\' in the \'Application Scope\' dropdown wi" +
                    "th wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.When(string.Format("User navigates to the \'{0}\' tab on Project Scope Changes page", scopeChanges1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then(string.Format("\"{0}\" is displayed to the user in the Project Scope Changes section", objectsToAdd3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatItemsToAddValuesAreNotCachedAfterScopeOptionsChan" +
            "geOnProjectDetailsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("DAS11981")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatItemsToAddValuesAreNotCachedAfterScopeOptionsChangeOnProjectDetailsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatItemsToAddValuesAreNotCachedAfterScopeOptionsChan" +
                    "geOnProjectDetailsPage", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "DAS11981",
                        "Projects",
                        "Cleanup"});
#line 120
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table13.AddRow(new string[] {
                        "DAS11981",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 121
 testRunner.When("Project created via API and opened", ((string)(null)), table13, "When ");
#line 124
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.And("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "CheckboxesToBeClicked"});
            table14.AddRow(new string[] {
                        "Entitled to the device"});
            table14.AddRow(new string[] {
                        "Installed on the device"});
            table14.AddRow(new string[] {
                        "Used by the device owner on any device"});
            table14.AddRow(new string[] {
                        "Used on the device by the device owner"});
            table14.AddRow(new string[] {
                        "Used on the device by any user"});
#line 126
 testRunner.And("User checks following checkboxes:", ((string)(null)), table14, "And ");
#line 133
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.Then("\"Applications to add (0 of 212 selected)\" is displayed to the user in the Project" +
                    " Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.Then("\"Users to add (0 of 14629 selected)\" is displayed to the user in the Project Scop" +
                    "e Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.When("User navigates to the \'Scope Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.And("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("User checks \'Entitled to the device\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("User navigates to the \'User Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("User selects \"Do not include device owners\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("\"Applications to add (0 of 1059 selected)\" is displayed to the user in the Projec" +
                    "t Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then("\"Users to add (0 of 0 selected)\" is displayed to the user in the Project Scope Ch" +
                    "anges section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_TheGreenBannerIsNotDisplayedIfBannerWasBeShownOnce")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS13428")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_TheGreenBannerIsNotDisplayedIfBannerWasBeShownOnce()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_TheGreenBannerIsNotDisplayedIfBannerWasBeShownOnce", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS13428",
                        "Cleanup"});
#line 150
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table15.AddRow(new string[] {
                        "Project13428",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 151
 testRunner.When("Project created via API and opened", ((string)(null)), table15, "When ");
#line 154
 testRunner.Then("Page with \'Project13428\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
 testRunner.And("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table16.AddRow(new string[] {
                        "0623U41CZ73RV2Q"});
#line 159
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table16, "And ");
#line 162
 testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.And("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.Then("\'1 object queued for onboarding, 0 objects offboarded\' text is displayed on succe" +
                    "ss inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 165
 testRunner.When("User navigates to the \'Queue\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table17.AddRow(new string[] {
                        "0623U41CZ73RV2Q"});
#line 166
 testRunner.Then("following Items are displayed in the Queue table", ((string)(null)), table17, "Then ");
#line 169
 testRunner.When("User navigates to the \'History\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table18.AddRow(new string[] {
                        "0623U41CZ73RV2Q"});
#line 170
 testRunner.Then("following Items are displayed in the History table", ((string)(null)), table18, "Then ");
#line 173
 testRunner.When("User navigates to the \'Scope Changes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
 testRunner.Then("Success message is not displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

