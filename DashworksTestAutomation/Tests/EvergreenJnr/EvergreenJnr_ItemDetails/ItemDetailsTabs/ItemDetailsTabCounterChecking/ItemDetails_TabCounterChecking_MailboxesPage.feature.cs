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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsTabs.ItemDetailsTabCounterChecking
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_TabCounterChecking_MailboxesPage")]
    public partial class ItemDetails_TabCounterChecking_MailboxesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ItemDetails_TabCounterChecking_MailboxesPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_TabCounterChecking_MailboxesPage", "\tRuns Item Details TabCounterChecking_MailboxesPage related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
            "lyForMailboxesPageInEvergreenMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16378")]
        [NUnit.Framework.CategoryAttribute("DAS15583")]
        [NUnit.Framework.CategoryAttribute("DAS16905")]
        [NUnit.Framework.CategoryAttribute("DAS16832")]
        [NUnit.Framework.CategoryAttribute("DAS17143")]
        [NUnit.Framework.CategoryAttribute("DAS17521")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenModeInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
                    "lyForMailboxesPageInEvergreenMode", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16378",
                        "DAS15583",
                        "DAS16905",
                        "DAS16832",
                        "DAS17143",
                        "DAS17521"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'Mailbox\' details page for \'00B5CCB89AD0404B965@bclabs.loca" +
                    "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \"00B5CCB89AD0404B965@bclabs.local\" item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabName"});
            table1.AddRow(new string[] {
                        "Details"});
            table1.AddRow(new string[] {
                        "Projects"});
            table1.AddRow(new string[] {
                        "Users"});
            table1.AddRow(new string[] {
                        "Trend"});
#line 12
 testRunner.And("User sees following parent left menu items", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table2.AddRow(new string[] {
                        "Mailbox"});
            table2.AddRow(new string[] {
                        "Mailbox Owner"});
            table2.AddRow(new string[] {
                        "Email Addresses"});
            table2.AddRow(new string[] {
                        "Department and Location"});
            table2.AddRow(new string[] {
                        "Custom Fields"});
#line 22
 testRunner.And("\"Details\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table2, "And ");
#line 30
 testRunner.And("\"Custom Fields\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("\"Email Addresses\" tab is displayed on left menu on the Details page and contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("\"Mailbox\" tab is displayed on left menu on the Details page and NOT contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("\"Mailbox Owner\" tab is displayed on left menu on the Details page and NOT contain" +
                    "s count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("\"Department and Location\" tab is displayed on left menu on the Details page and N" +
                    "OT contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table3.AddRow(new string[] {
                        "Evergreen Details"});
            table3.AddRow(new string[] {
                        "Mailbox Projects"});
            table3.AddRow(new string[] {
                        "Mailbox User Projects"});
#line 37
 testRunner.Then("\"Projects\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table3, "Then ");
#line 42
 testRunner.And("\"Project Details\" sub-tab is displayed with disabled state on left menu on the De" +
                    "tails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("\"Mailbox Projects\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("\"Mailbox User Projects\" tab is displayed on left menu on the Details page and con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("\"Evergreen Details\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("\"Project Details\" tab is displayed on left menu on the Details page and NOT conta" +
                    "ins count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.When("User navigates to the \'Users\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table4.AddRow(new string[] {
                        "Users"});
            table4.AddRow(new string[] {
                        "Groups"});
            table4.AddRow(new string[] {
                        "Unresolved Users"});
            table4.AddRow(new string[] {
                        "Mailbox Permissions"});
            table4.AddRow(new string[] {
                        "Folder Permissions"});
#line 50
 testRunner.Then("\"Users\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table4, "Then ");
#line 58
 testRunner.And("\"Users\" tab is displayed on left menu on the Details page and contains count of i" +
                    "tems", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("\"Groups\" tab is displayed on left menu on the Details page and contains count of " +
                    "items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("\"Unresolved Users\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("\"Mailbox Permissions\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("\"Folder Permissions\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("User navigates to the \'Trend\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table5.AddRow(new string[] {
                        "Email Count"});
            table5.AddRow(new string[] {
                        "Mailbox Size (MB)"});
            table5.AddRow(new string[] {
                        "Associated Item Count"});
            table5.AddRow(new string[] {
                        "Deleted Item Count"});
            table5.AddRow(new string[] {
                        "Deleted Item Size (MB)"});
#line 65
 testRunner.Then("\"Trend\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table5, "Then ");
#line 73
 testRunner.And("\"Email Count\" tab is displayed on left menu on the Details page and NOT contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("\"Mailbox Size (MB)\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("\"Associated Item Count\" tab is displayed on left menu on the Details page and NOT" +
                    " contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("\"Deleted Item Count\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("\"Deleted Item Size (MB)\" tab is displayed on left menu on the Details page and NO" +
                    "T contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
            "lyForMailboxesPageInProjectMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS15583")]
        [NUnit.Framework.CategoryAttribute("DAS16906")]
        [NUnit.Framework.CategoryAttribute("DAS16832")]
        [NUnit.Framework.CategoryAttribute("DAS17143")]
        [NUnit.Framework.CategoryAttribute("DAS17521")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectModeInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrect" +
                    "lyForMailboxesPageInProjectMode", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS15583",
                        "DAS16906",
                        "DAS16832",
                        "DAS17143",
                        "DAS17521"});
#line 80
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 81
 testRunner.When("User navigates to the \'Mailbox\' details page for \'00B5CCB89AD0404B965@bclabs.loca" +
                    "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("Details page for \"00B5CCB89AD0404B965@bclabs.local\" item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.When("User switches to the \"Mailbox Evergreen Capacity Project\" project in the Top bar " +
                    "on Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabName"});
            table6.AddRow(new string[] {
                        "Details"});
            table6.AddRow(new string[] {
                        "Projects"});
            table6.AddRow(new string[] {
                        "Users"});
            table6.AddRow(new string[] {
                        "Trend"});
#line 84
 testRunner.Then("User sees following parent left menu items", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table7.AddRow(new string[] {
                        "Mailbox"});
            table7.AddRow(new string[] {
                        "Mailbox Owner"});
            table7.AddRow(new string[] {
                        "Email Addresses"});
            table7.AddRow(new string[] {
                        "Department and Location"});
            table7.AddRow(new string[] {
                        "Custom Fields"});
#line 91
 testRunner.And("\"Details\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table7, "And ");
#line 99
 testRunner.And("\"Custom Fields\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("\"Email Addresses\" tab is displayed on left menu on the Details page and contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("\"Mailbox\" tab is displayed on left menu on the Details page and NOT contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("\"Mailbox Owner\" tab is displayed on left menu on the Details page and NOT contain" +
                    "s count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("\"Department and Location\" tab is displayed on left menu on the Details page and N" +
                    "OT contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table8.AddRow(new string[] {
                        "Evergreen Details"});
            table8.AddRow(new string[] {
                        "Project Details"});
            table8.AddRow(new string[] {
                        "Mailbox Projects"});
            table8.AddRow(new string[] {
                        "Mailbox User Projects"});
#line 106
 testRunner.Then("\"Projects\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table8, "Then ");
#line 113
 testRunner.And("\"Mailbox Projects\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("\"Mailbox User Projects\" tab is displayed on left menu on the Details page and con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("\"Evergreen Details\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("\"Project Details\" tab is displayed on left menu on the Details page and NOT conta" +
                    "ins count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.When("User navigates to the \'Users\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table9.AddRow(new string[] {
                        "Users"});
            table9.AddRow(new string[] {
                        "Groups"});
            table9.AddRow(new string[] {
                        "Unresolved Users"});
            table9.AddRow(new string[] {
                        "Mailbox Permissions"});
            table9.AddRow(new string[] {
                        "Folder Permissions"});
#line 119
 testRunner.Then("\"Users\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table9, "Then ");
#line 127
 testRunner.And("\"Users\" tab is displayed on left menu on the Details page and contains count of i" +
                    "tems", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("\"Groups\" tab is displayed on left menu on the Details page and contains count of " +
                    "items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("\"Unresolved Users\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("\"Mailbox Permissions\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("\"Folder Permissions\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("User navigates to the \'Trend\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table10.AddRow(new string[] {
                        "Email Count"});
            table10.AddRow(new string[] {
                        "Mailbox Size (MB)"});
            table10.AddRow(new string[] {
                        "Associated Item Count"});
            table10.AddRow(new string[] {
                        "Deleted Item Count"});
            table10.AddRow(new string[] {
                        "Deleted Item Size (MB)"});
#line 134
 testRunner.Then("\"Trend\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table10, "Then ");
#line 142
 testRunner.And("\"Email Count\" tab is displayed on left menu on the Details page and NOT contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("\"Mailbox Size (MB)\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("\"Associated Item Count\" tab is displayed on left menu on the Details page and NOT" +
                    " contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("\"Deleted Item Count\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.And("\"Deleted Item Size (MB)\" tab is displayed on left menu on the Details page and NO" +
                    "T contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

