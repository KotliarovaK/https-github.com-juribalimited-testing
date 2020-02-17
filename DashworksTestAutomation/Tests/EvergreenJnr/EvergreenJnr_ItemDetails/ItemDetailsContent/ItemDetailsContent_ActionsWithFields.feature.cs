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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetailsContent_ActionsWithFields")]
    public partial class ItemDetailsContent_ActionsWithFieldsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ItemDetailsContent_ActionsWithFields.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetailsContent_ActionsWithFields", "\tRuns Item Details Content Actions With Fields related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS14941")]
        [NUnit.Framework.CategoryAttribute("DAS12963")]
        public virtual void EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSettingInternal();
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

        private void EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSettingInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS14941",
                        "DAS12963"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When("User clicks on edit button for \'Evergreen Ring\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table1.AddRow(new string[] {
                        "Unassigned"});
            table1.AddRow(new string[] {
                        "Evergreen Ring 1"});
            table1.AddRow(new string[] {
                        "Evergreen Ring 3"});
            table1.AddRow(new string[] {
                        "TestBulkUpdate"});
#line 15
 testRunner.Then("\'New Ring\' autocomplete contains following options:", ((string)(null)), table1, "Then ");
#line 21
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantU" +
            "serDetailsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS12690")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        public virtual void EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPageInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantU" +
                    "serDetailsPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS12690",
                        "DAS14923"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 25
 testRunner.When("User navigates to the \'Device\' details page for \'001PSUMZYOW581\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Details page for \'001PSUMZYOW581\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("User clicks \"Tricia G. Huang\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("Details page for \'LFA418191 (Tricia G. Huang)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSele" +
            "ctedMainMenu")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ALlLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13341")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        [NUnit.Framework.TestCaseAttribute("Device", "02C80G8RFTPA9E", "Specification", "Manufacturer", "FES0798481167", null)]
        [NUnit.Framework.TestCaseAttribute("Device", "05PFM2OWVCSCZ1", "Details", "Hostname", "05PFM2OWVCSCZ1", null)]
        [NUnit.Framework.TestCaseAttribute("User", "03714167684E45F7A8F", "User", "Domain", "BCLABS", null)]
        [NUnit.Framework.TestCaseAttribute("Application", "Adobe Acrobat Reader 5.0", "Details", "Vendor", "Adobe", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedMainMenu(string pageName, string searchTerm, string mainTabName, string keyToBeSelected, string valueToBeSelected, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedMainMenuInternal(pageName,searchTerm,mainTabName,keyToBeSelected,valueToBeSelected,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedMainMenuInternal(string pageName, string searchTerm, string mainTabName, string keyToBeSelected, string valueToBeSelected, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "ALlLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS13341",
                    "DAS14923"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSele" +
                    "ctedMainMenu", null, @__tags);
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 33
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And(string.Format("User selects \"{0}\" text from key value grid on the Details Page", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then(string.Format("\'{0}\' text is highlighted", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When(string.Format("User selects \"{0}\" text from key value grid on the Details Page", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then(string.Format("\'{0}\' text is highlighted", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSele" +
            "ctedSubMenu")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ALlLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13341")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        [NUnit.Framework.TestCaseAttribute("Device", "05PFM2OWVCSCZ1", "Device", "Hostname", "05PFM2OWVCSCZ1", null)]
        [NUnit.Framework.TestCaseAttribute("User", "03714167684E45F7A8F", "User", "Domain", "BCLABS", null)]
        [NUnit.Framework.TestCaseAttribute("Mailbox", "06D7AE4F161F4A3AA7F@bclabs.local", "Mailbox", "Alias", "06D7AE4F161F4A3AA7F", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedSubMenu(string pageName, string searchTerm, string subTabName, string keyToBeSelected, string valueToBeSelected, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedSubMenuInternal(pageName,searchTerm,subTabName,keyToBeSelected,valueToBeSelected,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedSubMenuInternal(string pageName, string searchTerm, string subTabName, string keyToBeSelected, string valueToBeSelected, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "ALlLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS13341",
                    "DAS14923"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSele" +
                    "ctedSubMenu", null, @__tags);
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 50
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When(string.Format("User navigates to the \'{0}\' left submenu item", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.And(string.Format("User selects \"{0}\" text from key value grid on the Details Page", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then(string.Format("\'{0}\' text is highlighted", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When(string.Format("User selects \"{0}\" text from key value grid on the Details Page", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then(string.Format("\'{0}\' text is highlighted", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13341")]
        [NUnit.Framework.CategoryAttribute("archived")]
        public virtual void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPageInternal();
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

        private void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPage", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS13341",
                        "archived"});
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 66
 testRunner.When("User type \"NL00G001\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("User clicks on \"NL00G001\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When("User selects \"Description\" text from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("\'Description\' text is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.When("User selects \"Unknown\" text from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("\'Unknown\' text is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheReleva" +
            "ntUserDetailsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS12690")]
        [NUnit.Framework.CategoryAttribute("DAS12321")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPageInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheReleva" +
                    "ntUserDetailsPage", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS12690",
                        "DAS12321",
                        "DAS14923"});
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 75
 testRunner.When("User navigates to the \'Mailbox\' details page for \'hartmajt@bclabs.local\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("Details page for \'hartmajt@bclabs.local\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("User navigates to the \'Mailbox Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And("User clicks \"hartmajt\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.Then("Details object page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWith" +
            "AProjectIdAtTheEnd")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17180")]
        public virtual void EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEnd()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEndInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEndInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWith" +
                    "AProjectIdAtTheEnd", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17180"});
#line 82
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 83
 testRunner.When("User navigates to the \'Device\' details page for \'001BAQXT6JWFPI\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.When("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.And("User clicks \"QLL295118\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.Then("Details page for \'QLL295118 (Nicole P. Braun)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("URL contains \'user/23726/details/user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.When("User selects \'Havoc (Big Data)\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("User clicks \"QLL295118\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.Then("Details page for \'QLL295118 (Nicole P. Braun)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.Then("\'Havoc (Big Data)\' content is displayed in \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.And("URL contains \'user/23726/details/user?$projectId=43\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("\'Havoc (Big Data)\' content is displayed in \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.And("User clicks \"Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" +
                    "\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.Then("Details page for \'Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Di" +
                    "alogs\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.Then("\'Havoc (Big Data)\' content is displayed in \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.And("URL contains \'application/373/details/application?$projectId=43\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefi" +
            "nedInTheAdminPageAsTheDefaultLanguage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17768")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefinedInTheAdminPageAsTheDefaultLanguage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefinedInTheAdminPageAsTheDefaultLanguageInternal();
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

        private void EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefinedInTheAdminPageAsTheDefaultLanguageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefi" +
                    "nedInTheAdminPageAsTheDefaultLanguage", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17768",
                        "Not_Ready"});
#line 109
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 110
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.When("User clicks on \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' cell from \'Project\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.Then("Page with \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
 testRunner.And("User clicks \'ADD LANGUAGE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("User selects \"German\" language on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("User opens menu for selected language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.Then("User selects \"Set as default\" option for selected language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.When("User perform search by \"001BAQXT6JWFPI\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.And("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.Then("Details page for \'06BB714696274AC895A@bclabs.local\' item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.When("User selects \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' in the \'Item Details Project\' d" +
                    "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table2.AddRow(new string[] {
                        "Language",
                        "German"});
#line 129
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

