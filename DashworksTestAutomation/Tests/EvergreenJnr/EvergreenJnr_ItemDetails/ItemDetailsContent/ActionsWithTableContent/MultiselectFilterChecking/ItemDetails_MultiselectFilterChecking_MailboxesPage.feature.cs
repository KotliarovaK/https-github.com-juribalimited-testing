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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent.ActionsWithTableContent.MultiselectFilterChecking
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_MultiselectFilterChecking_MailboxesPage")]
    public partial class ItemDetails_MultiselectFilterChecking_MailboxesPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ItemDetails_MultiselectFilterChecking_MailboxesPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_MultiselectFilterChecking_MailboxesPage", "\tRuns Multiselect Filter Checking for Mailboxes Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheR" +
            "elatedMultiselectFilterForDetailsTabOnMailboxesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17761")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabOnMailboxesPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabOnMailboxesPageInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabOnMailboxesPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheR" +
                    "elatedMultiselectFilterForDetailsTabOnMailboxesPage", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17761"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'Mailbox\' details page for \'002B5DC7D4D34D5C895@bclabs.loca" +
                    "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \"002B5DC7D4D34D5C895@bclabs.local\" item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User navigates to the \'Email Addresses\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("\'SMTP\' content is displayed in the \'Type\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.Then("\'TRUE\' content is displayed in the \'Reply To\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        "SMTP"});
#line 15
 testRunner.Then("following String Values are displayed in the filter dropdown for the \'Type\' colum" +
                    "n", ((string)(null)), table1, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table2.AddRow(new string[] {
                        "True"});
#line 18
 testRunner.Then("following Boolean Values are displayed in the filter dropdown for the \'Reply To\' " +
                    "column", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheR" +
            "elatedMultiselectFilterForUsersTabOnMailboxesPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17761")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnMailboxesPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnMailboxesPageInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnMailboxesPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheR" +
                    "elatedMultiselectFilterForUsersTabOnMailboxesPage", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17761"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 24
 testRunner.When("User navigates to the \'Mailbox\' details page for \'002B5DC7D4D34D5C895@bclabs.loca" +
                    "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("Details page for \"002B5DC7D4D34D5C895@bclabs.local\" item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.When("User switches to the \"USE ME FOR AUTOMATION(MAIL SCHDLD)\" project in the Top bar " +
                    "on Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.When("User navigates to the \'Users\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.When("User navigates to the \'Users\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("\'TRUE\' content is displayed in the \'Owner\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("\'\' content is displayed in the \'Domain\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "True"});
#line 31
 testRunner.Then("following Boolean Values are displayed in the filter dropdown for the \'Owner\' col" +
                    "umn", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table4.AddRow(new string[] {
                        "Empty"});
#line 34
 testRunner.Then("following String Values are displayed in the filter dropdown for the \'Domain\' col" +
                    "umn", ((string)(null)), table4, "Then ");
#line 37
 testRunner.When("User navigates to the \'Groups\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("\'BCLABS\' content is displayed in the \'Domain\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table5.AddRow(new string[] {
                        "BCLABS"});
#line 39
 testRunner.Then("following String Values are displayed in the filter dropdown for the \'Domain\' col" +
                    "umn", ((string)(null)), table5, "Then ");
#line 42
 testRunner.When("User navigates to the \'Mailbox Permissions\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("\'BCLABS\' content is displayed in the \'Domain\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("\'FullAccess\' content is displayed in the \'Permission\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table6.AddRow(new string[] {
                        "BCLABS"});
#line 45
 testRunner.Then("following String Values are displayed in the filter dropdown for the \'Domain\' col" +
                    "umn", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table7.AddRow(new string[] {
                        "ReadPermission"});
            table7.AddRow(new string[] {
                        "FullAccess"});
            table7.AddRow(new string[] {
                        "DeleteItem"});
            table7.AddRow(new string[] {
                        "ChangePermission"});
            table7.AddRow(new string[] {
                        "ChangeOwner"});
#line 49
 testRunner.Then("following String Values are displayed in the filter dropdown for the \'Permission\'" +
                    " column", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

