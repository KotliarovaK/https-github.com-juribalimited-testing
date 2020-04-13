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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AdminPage.Capacity.Capacity
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CapacityPart1")]
    public partial class CapacityPart1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CapacityPart1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacityPart1", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErro" +
            "rs")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS13720")]
        [NUnit.Framework.CategoryAttribute("DAS13431")]
        [NUnit.Framework.CategoryAttribute("DAS13162")]
        [NUnit.Framework.CategoryAttribute("DAS14037")]
        [NUnit.Framework.CategoryAttribute("DAS15823")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrorsInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrorsInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Units",
                    "DAS13720",
                    "DAS13431",
                    "DAS13162",
                    "DAS14037",
                    "DAS15823",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErro" +
                    "rs", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Units",
                        "DAS13720",
                        "DAS13431",
                        "DAS13162",
                        "DAS14037",
                        "DAS15823",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table826 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table826.AddRow(new string[] {
                            "ProjectForCapacity13720",
                            "All Users",
                            "None",
                            "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table826, "When ");
#line hidden
#line 13
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("\'Capacity Units\' content is displayed in \'Capacity Mode\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("User navigates to the \'Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.And("User enters \"Unassigned\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("Rows counter shows \"1\" of \"1\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User clicks content from \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And("User enters \'Default Capacity Unit\' text to \'Capacity Unit Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("\'The capacity unit details have been updated\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table827 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table827.AddRow(new string[] {
                            "Capacity Unit"});
                table827.AddRow(new string[] {
                            ""});
                table827.AddRow(new string[] {
                            "Description"});
                table827.AddRow(new string[] {
                            "Default"});
                table827.AddRow(new string[] {
                            "Slots"});
                table827.AddRow(new string[] {
                            "Devices"});
                table827.AddRow(new string[] {
                            "Users"});
                table827.AddRow(new string[] {
                            "Applications"});
#line 22
 testRunner.And("grid headers are displayed in the following order", ((string)(null)), table827, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS13431")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnitsInternal();
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

        private void EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnitsInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Units",
                    "DAS13431",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Units",
                        "DAS13431",
                        "Cleanup"});
#line 34
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
                TechTalk.SpecFlow.Table table828 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table828.AddRow(new string[] {
                            "13431DevicesProject",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 35
 testRunner.When("Project created via API and opened", ((string)(null)), table828, "When ");
#line hidden
#line 38
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("User navigates to the \'Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table829 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table829.AddRow(new string[] {
                            "Capacity Unit"});
                table829.AddRow(new string[] {
                            ""});
                table829.AddRow(new string[] {
                            "Description"});
                table829.AddRow(new string[] {
                            "Default"});
                table829.AddRow(new string[] {
                            "Slots"});
                table829.AddRow(new string[] {
                            "Devices"});
                table829.AddRow(new string[] {
                            "Users"});
                table829.AddRow(new string[] {
                            "Applications"});
#line 40
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table829, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnits")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS13431")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnits()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnitsInternal();
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

        private void EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnitsInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Units",
                    "DAS13431",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnits", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Units",
                        "DAS13431",
                        "Cleanup"});
#line 52
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
                TechTalk.SpecFlow.Table table830 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table830.AddRow(new string[] {
                            "13431MailboxesProject",
                            "All Mailboxes",
                            "None",
                            "Standalone Project"});
#line 53
 testRunner.When("Project created via API and opened", ((string)(null)), table830, "When ");
#line hidden
#line 56
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("User navigates to the \'Units\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table831 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table831.AddRow(new string[] {
                            "Capacity Unit"});
                table831.AddRow(new string[] {
                            ""});
                table831.AddRow(new string[] {
                            "Description"});
                table831.AddRow(new string[] {
                            "Default"});
                table831.AddRow(new string[] {
                            "Slots"});
                table831.AddRow(new string[] {
                            "Users"});
                table831.AddRow(new string[] {
                            "Mailboxes"});
                table831.AddRow(new string[] {
                            "Applications"});
#line 58
 testRunner.Then("grid headers are displayed in the following order", ((string)(null)), table831, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Override_Dates")]
        [NUnit.Framework.CategoryAttribute("DAS13723")]
        [NUnit.Framework.CategoryAttribute("DAS13370")]
        [NUnit.Framework.CategoryAttribute("DAS18646")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumnInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumnInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "Capacity",
                    "Override_Dates",
                    "DAS13723",
                    "DAS13370",
                    "DAS18646",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Override_Dates",
                        "DAS13723",
                        "DAS13370",
                        "DAS18646",
                        "Cleanup"});
#line 70
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
                TechTalk.SpecFlow.Table table832 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProjectName",
                            "Scope",
                            "ProjectTemplate",
                            "Mode"});
                table832.AddRow(new string[] {
                            "ProjectForCapacity13723",
                            "All Devices",
                            "None",
                            "Standalone Project"});
#line 71
 testRunner.When("Project created via API and opened", ((string)(null)), table832, "When ");
#line hidden
#line 74
 testRunner.When("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.When("User navigates to the \'Override Dates\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("User clicks \'CREATE OVERRIDE DATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.When("User enters \'5 Jan 2019\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("User clears \'Override End Date\' textbox with backspaces", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("\'An override end date must be entered\' error message is displayed for \'Override E" +
                        "nd Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.When("User enters \'4 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 82
 testRunner.Then("\'CREATE\' button has tooltip with \'Some settings are not valid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("User clears \'Override Start Date\' textbox with backspaces", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.Then("\'An override start date must be entered\' error message is displayed for \'Override" +
                        " Start Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.When("User enters \'4 Oct 2018\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.When("User enters \'7 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.When("User selects \'All\' in the \'Slot\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("\'Your override date has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.Then("\'Unlimited\' content is displayed in the \'Capacity\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.When("User enters \">1\" text in the Search field for \"Capacity\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.Then("Rows counter shows \"1\" of \"1\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.When("User clicks content from \"Start Date\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.When("User enters \'3 Oct 2018\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("\'UPDATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.Then("\'UPDATE\' button has tooltip with \'No changes made\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.When("User enters \'\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.When("User enters \'\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.Then("\'An override end date must be entered\' error message is displayed for \'Override E" +
                        "nd Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.Then("\'An override start date must be entered\' error message is displayed for \'Override" +
                        " Start Date\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.When("User enters \'5 Oct 2019\' text to \'Override Start Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.When("User enters \'5 Oct 2019\' text to \'Override End Date\' datepicker", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.When("User clicks \'UPDATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.Then("\'The override date details have been updated\' text is displayed on inline success" +
                        " banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion