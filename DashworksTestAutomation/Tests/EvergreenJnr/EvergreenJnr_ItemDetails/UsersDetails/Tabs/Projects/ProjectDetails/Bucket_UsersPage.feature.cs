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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.UsersDetails.Tabs.Projects.ProjectDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Bucket_UsersPage")]
    public partial class Bucket_UsersPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Bucket_UsersPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Bucket_UsersPage", "\tRuns related tests for Bucket field", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyFor" +
            "AssociatedDevices")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("ProjectDetailsTab")]
        [NUnit.Framework.CategoryAttribute("DAS18227")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedDevices()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedDevicesInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedDevicesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyFor" +
                    "AssociatedDevices", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "ProjectDetailsTab",
                        "DAS18227",
                        "Zion_NewGrid"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'User\' details page for the item with \'23726\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \'QLL295118 (Nicole P. Braun)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User selects \'Havoc (Big Data)\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.When("User clicks on edit button for \'Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("\'MOVE\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Then("\'Select the bucket to move this user to. Select devices associated to this user t" +
                    "o move at the same time.\' text is displayed on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table1.AddRow(new string[] {
                        "Hostname"});
            table1.AddRow(new string[] {
                        "Owned"});
            table1.AddRow(new string[] {
                        "Bucket"});
#line 18
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table1, "Then ");
#line 23
 testRunner.When("User selects \'Group102\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("\'The selected objects will be moved to Group102\' text is displayed on inline tip " +
                    "banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAsso" +
            "ciatedDevices")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("ProjectDetailsTab")]
        [NUnit.Framework.CategoryAttribute("DAS18227")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedDevices()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedDevicesInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedDevicesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAsso" +
                    "ciatedDevices", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "ProjectDetailsTab",
                        "DAS18227",
                        "Cleanup"});
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 29
 testRunner.When("User navigates to the \'User\' details page for the item with \'228\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Details page for \'BGW6256640 (Talon Brochu)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User selects \'Havoc (Big Data)\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.When("User clicks on edit button for \'Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.When("User selects \'Group111\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("\'The selected objects successfully moved to Group111\' text is displayed on inline" +
                    " success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table2.AddRow(new string[] {
                        "Bucket",
                        "Group111"});
#line 39
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2, "Then ");
#line 42
 testRunner.When("User clicks on edit button for \'Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table3.AddRow(new string[] {
                        "Group111"});
#line 43
 testRunner.Then("\'Bucket\' column contains following content", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyFor" +
            "AssociatedMailboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("ProjectDetailsTab")]
        [NUnit.Framework.CategoryAttribute("DAS18227")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedMailboxes()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedMailboxesInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedMailboxesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyFor" +
                    "AssociatedMailboxes", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "ProjectDetailsTab",
                        "DAS18227",
                        "Zion_NewGrid"});
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 49
 testRunner.When("User navigates to the \'User\' details page for the item with \'92682\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("Details page for \'003F5D8E1A844B1FAA5 (Hunter, Melanie)\' item is displayed to the" +
                    " user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User selects \'Mailbox Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                    "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.When("User clicks on edit button for \'Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\'MOVE\' button is disabled on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("\'Select the bucket to move this user to. Select mailboxes associated to this user" +
                    " to move at the same time.\' text is displayed on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table4.AddRow(new string[] {
                        "Email Address"});
            table4.AddRow(new string[] {
                        "Owner Display Name"});
            table4.AddRow(new string[] {
                        "Owned"});
            table4.AddRow(new string[] {
                        "Bucket"});
#line 57
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table4, "Then ");
#line 63
 testRunner.When("User selects \'A Group with AdminIT team\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("\'The selected objects will be moved to A Group with AdminIT team\' text is display" +
                    "ed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAsso" +
            "ciatedMailboxes")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("ProjectDetailsTab")]
        [NUnit.Framework.CategoryAttribute("DAS18227")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedMailboxes()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedMailboxesInternal();
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

        private void EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedMailboxesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAsso" +
                    "ciatedMailboxes", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "ProjectDetailsTab",
                        "DAS18227",
                        "Cleanup"});
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 69
 testRunner.When("User navigates to the \'User\' details page for the item with \'89891\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("Details page for \'01DE1433D11E44E6A4A (Anderson, Nancy)\' item is displayed to the" +
                    " user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.When("User selects \'Mailbox Evergreen Capacity Project\' in the \'Item Details Project\' d" +
                    "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.When("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.When("User clicks on edit button for \'Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.When("User selects \'A Group with AdminIT team\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("\'The selected objects successfully moved to A Group with AdminIT team\' text is di" +
                    "splayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table5.AddRow(new string[] {
                        "Bucket",
                        "A Group with AdminIT team"});
#line 79
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table5, "Then ");
#line 82
 testRunner.When("User clicks on edit button for \'Bucket\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table6.AddRow(new string[] {
                        "A Group with AdminIT team"});
#line 83
 testRunner.Then("\'Bucket\' column contains following content", ((string)(null)), table6, "Then ");
#line 86
 testRunner.When("User selects \'Unassigned\' option from \'Move Bucket\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.When("User clicks \'MOVE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

