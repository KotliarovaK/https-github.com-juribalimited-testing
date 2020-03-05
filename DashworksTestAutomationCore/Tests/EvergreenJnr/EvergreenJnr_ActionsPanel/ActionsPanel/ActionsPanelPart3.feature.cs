// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ActionsPanel.ActionsPanel
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ActionsPanelPart9")]
    public partial class ActionsPanelPart9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ActionsPanelPart3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ActionsPanelPart9", "\tRuns Actions Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckBucketBulkUpdateOptionsOnDevicesListForEvergreenPro" +
            "jectAreDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14140")]
        [NUnit.Framework.CategoryAttribute("DAS15814")]
        public virtual void EvergreenJnr_DevicesList_CheckBucketBulkUpdateOptionsOnDevicesListForEvergreenProjectAreDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS14563",
                    "DAS13960",
                    "DAS14140",
                    "DAS15814"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckBucketBulkUpdateOptionsOnDevicesListForEvergreenPro" +
                    "jectAreDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14140",
                        "DAS15814"});
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
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table22.AddRow(new string[] {
                            "001BAQXT6JWFPI"});
                table22.AddRow(new string[] {
                            "001PSUMZYOW581"});
#line 14
 testRunner.When("User select \"Hostname\" rows in the grid", ((string)(null)), table22, "When ");
#line hidden
#line 18
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("User selects \'Update bucket\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("User selects \'Unassigned\' option from \'Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table23.AddRow(new string[] {
                            "None"});
                table23.AddRow(new string[] {
                            "Owners only"});
                table23.AddRow(new string[] {
                            "All linked users"});
#line 22
 testRunner.Then("following Values are displayed in the \'Also Move Users\' dropdown:", ((string)(null)), table23, "Then ");
#line hidden
#line 27
 testRunner.When("User selects \'Owners only\' in the \'Also Move Users\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("Warning message with \"This operation cannot be undone\" text is displayed on Actio" +
                        "n panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForEvergreenProject" +
            "AreDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14142")]
        public virtual void EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForEvergreenProjectAreDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS14563",
                    "DAS13960",
                    "DAS14142"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForEvergreenProject" +
                    "AreDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14142"});
#line 32
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
#line 33
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table24.AddRow(new string[] {
                            "0072B088173449E3A93"});
                table24.AddRow(new string[] {
                            "00C8BC63E7424A6E862"});
#line 37
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table24, "When ");
#line hidden
#line 41
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("User selects \'Update bucket\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("User selects \'Evergreen\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("User selects \'Unassigned\' option from \'Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table25.AddRow(new string[] {
                            "None"});
                table25.AddRow(new string[] {
                            "Owned devices only"});
                table25.AddRow(new string[] {
                            "All linked devices"});
#line 45
 testRunner.Then("following Values are displayed in the \'Also Move Devices\' dropdown:", ((string)(null)), table25, "Then ");
#line hidden
#line 50
 testRunner.When("User selects \'Owned devices only\' in the \'Also Move Devices\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table26.AddRow(new string[] {
                            "None"});
                table26.AddRow(new string[] {
                            "Owned mailboxes only"});
                table26.AddRow(new string[] {
                            "All linked mailboxes"});
#line 51
 testRunner.Then("following Values are displayed in the \'Also Move Mailboxes\' dropdown:", ((string)(null)), table26, "Then ");
#line hidden
#line 56
 testRunner.When("User selects \'Owned mailboxes only\' in the \'Also Move Mailboxes\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("\'UPDATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForUserScopedProjec" +
            "tAreDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14143")]
        public virtual void EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForUserScopedProjectAreDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS14563",
                    "DAS13960",
                    "DAS14143"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForUserScopedProjec" +
                    "tAreDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14143"});
#line 60
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
#line 61
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table27.AddRow(new string[] {
                            "0072B088173449E3A93"});
                table27.AddRow(new string[] {
                            "00C8BC63E7424A6E862"});
#line 65
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table27, "When ");
#line hidden
#line 69
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("User selects \'Update bucket\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("User selects \'Project\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("User selects \'User Evergreen Capacity Project\' option from \'Project\' autocomplete" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("User selects \'Unassigned\' option from \'Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table28.AddRow(new string[] {
                            "None"});
                table28.AddRow(new string[] {
                            "Owned devices only"});
                table28.AddRow(new string[] {
                            "All linked devices"});
#line 74
 testRunner.Then("following Values are displayed in the \'Also Move Devices\' dropdown:", ((string)(null)), table28, "Then ");
#line hidden
#line 79
 testRunner.When("User selects \'Owned devices only\' in the \'Also Move Devices\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("\'UPDATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForMailboxScopedPro" +
            "jectAreDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14563")]
        [NUnit.Framework.CategoryAttribute("DAS13960")]
        [NUnit.Framework.CategoryAttribute("DAS14160")]
        public virtual void EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForMailboxScopedProjectAreDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS14563",
                    "DAS13960",
                    "DAS14160"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForMailboxScopedPro" +
                    "jectAreDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14563",
                        "DAS13960",
                        "DAS14160"});
#line 83
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
#line 84
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table29.AddRow(new string[] {
                            "0072B088173449E3A93"});
                table29.AddRow(new string[] {
                            "00C8BC63E7424A6E862"});
#line 88
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table29, "When ");
#line hidden
#line 92
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("User selects \'Update bucket\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And("User selects \'Project\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And("User selects \'Mailbox Evergreen Capacity Project\' option from \'Project\' autocompl" +
                        "ete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And("User selects \'Unassigned\' option from \'Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table30.AddRow(new string[] {
                            "None"});
                table30.AddRow(new string[] {
                            "Owners only"});
                table30.AddRow(new string[] {
                            "All linked users"});
#line 97
 testRunner.Then("following Values are displayed in the \'Also Move Mailboxes\' dropdown:", ((string)(null)), table30, "Then ");
#line hidden
#line 102
 testRunner.When("User selects \'Owners only\' in the \'Also Move Mailboxes\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.Then("\'UPDATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMa" +
            "ilboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ActionsPanel")]
        [NUnit.Framework.CategoryAttribute("BulkUpdate")]
        [NUnit.Framework.CategoryAttribute("DAS14421")]
        public virtual void EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMailboxes()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ActionsPanel",
                    "BulkUpdate",
                    "DAS14421"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMa" +
                    "ilboxes", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ActionsPanel",
                        "BulkUpdate",
                        "DAS14421"});
#line 106
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
#line 107
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table31.AddRow(new string[] {
                            "00A5B910A1004CF5AC4"});
#line 109
 testRunner.When("User select \"Username\" rows in the grid", ((string)(null)), table31, "When ");
#line hidden
#line 112
 testRunner.And("User selects \'Bulk update\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And("User selects \'Update capacity unit\' in the \'Bulk Update Type\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("User selects \'Project\' in the \'Project or Evergreen\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("User selects \'Email Migration\' option from \'Project\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.When("User selects \'Unassigned\' option from \'Capacity Unit\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table32.AddRow(new string[] {
                            "None"});
                table32.AddRow(new string[] {
                            "Owned mailboxes only"});
                table32.AddRow(new string[] {
                            "All linked mailboxes"});
#line 117
 testRunner.Then("following Values are displayed in the \'Also Move Mailboxes\' dropdown:", ((string)(null)), table32, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
