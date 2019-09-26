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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsTabs.ItemDetailsTabCounterChecking
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
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"All Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User perform search by \"00B5CCB89AD0404B965@bclabs.local\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
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
#line 15
 testRunner.And("User sees following main-tabs on left menu on the Details page:", ((string)(null)), table1, "And ");
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
#line 25
 testRunner.And("\"Details\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table2, "And ");
#line 33
 testRunner.And("\"Custom Fields\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("\"Email Addresses\" tab is displayed on left menu on the Details page and contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("\"Mailbox\" tab is displayed on left menu on the Details page and NOT contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("\"Mailbox Owner\" tab is displayed on left menu on the Details page and NOT contain" +
                    "s count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("\"Department and Location\" tab is displayed on left menu on the Details page and N" +
                    "OT contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
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
#line 40
 testRunner.Then("\"Projects\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table3, "Then ");
#line 45
 testRunner.And("\"Project Details\" sub-tab is displayed with disabled state on left menu on the De" +
                    "tails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("\"Mailbox Projects\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("\"Mailbox User Projects\" tab is displayed on left menu on the Details page and con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("\"Evergreen Details\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("\"Project Details\" tab is displayed on left menu on the Details page and NOT conta" +
                    "ins count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
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
#line 53
 testRunner.Then("\"Users\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table4, "Then ");
#line 61
 testRunner.And("\"Users\" tab is displayed on left menu on the Details page and contains count of i" +
                    "tems", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("\"Groups\" tab is displayed on left menu on the Details page and contains count of " +
                    "items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("\"Unresolved Users\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("\"Mailbox Permissions\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("\"Folder Permissions\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
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
#line 68
 testRunner.Then("\"Trend\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table5, "Then ");
#line 76
 testRunner.And("\"Email Count\" tab is displayed on left menu on the Details page and NOT contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("\"Mailbox Size (MB)\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("\"Associated Item Count\" tab is displayed on left menu on the Details page and NOT" +
                    " contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("\"Deleted Item Count\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
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
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 84
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("\"All Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.When("User perform search by \"00B5CCB89AD0404B965@bclabs.local\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.And("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.Then("Details page for \"00B5CCB89AD0404B965@bclabs.local\" item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
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
#line 90
 testRunner.Then("User sees following main-tabs on left menu on the Details page:", ((string)(null)), table6, "Then ");
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
#line 97
 testRunner.And("\"Details\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table7, "And ");
#line 105
 testRunner.And("\"Custom Fields\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("\"Email Addresses\" tab is displayed on left menu on the Details page and contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("\"Mailbox\" tab is displayed on left menu on the Details page and NOT contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("\"Mailbox Owner\" tab is displayed on left menu on the Details page and NOT contain" +
                    "s count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("\"Department and Location\" tab is displayed on left menu on the Details page and N" +
                    "OT contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
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
#line 112
 testRunner.Then("\"Projects\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table8, "Then ");
#line 119
 testRunner.And("\"Mailbox Projects\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("\"Mailbox User Projects\" tab is displayed on left menu on the Details page and con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("\"Evergreen Details\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("\"Project Details\" tab is displayed on left menu on the Details page and NOT conta" +
                    "ins count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
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
#line 125
 testRunner.Then("\"Users\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table9, "Then ");
#line 133
 testRunner.And("\"Users\" tab is displayed on left menu on the Details page and contains count of i" +
                    "tems", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("\"Groups\" tab is displayed on left menu on the Details page and contains count of " +
                    "items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("\"Unresolved Users\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("\"Mailbox Permissions\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("\"Folder Permissions\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
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
#line 140
 testRunner.Then("\"Trend\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table10, "Then ");
#line 148
 testRunner.And("\"Email Count\" tab is displayed on left menu on the Details page and NOT contains " +
                    "count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("\"Mailbox Size (MB)\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.And("\"Associated Item Count\" tab is displayed on left menu on the Details page and NOT" +
                    " contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.And("\"Deleted Item Count\" tab is displayed on left menu on the Details page and NOT co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("\"Deleted Item Size (MB)\" tab is displayed on left menu on the Details page and NO" +
                    "T contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

