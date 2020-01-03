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
#line 15
 testRunner.And("User clicks New Ring ddl in popup of Project Summary section on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("Rings ddl contains data on Project Summary section of the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
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
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 21
 testRunner.When("User navigates to the \'Device\' details page for \'001PSUMZYOW581\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Details page for \'001PSUMZYOW581\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("User clicks \"Tricia G. Huang\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
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
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 29
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And(string.Format("User selects \"{0}\" text from key value grid on the Details Page", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then(string.Format("\'{0}\' text is highlighted", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When(string.Format("User selects \"{0}\" text from key value grid on the Details Page", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
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
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 46
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.When(string.Format("User navigates to the \'{0}\' left submenu item", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And(string.Format("User selects \"{0}\" text from key value grid on the Details Page", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then(string.Format("\'{0}\' text is highlighted", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When(string.Format("User selects \"{0}\" text from key value grid on the Details Page", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
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
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 62
 testRunner.When("User type \"NL00G001\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("User clicks on \"NL00G001\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.When("User selects \"Description\" text from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("\'Description\' text is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.When("User selects \"Unknown\" text from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
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
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 71
 testRunner.When("User navigates to the \'Mailbox\' details page for \'hartmajt@bclabs.local\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("Details page for \'hartmajt@bclabs.local\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User navigates to the \'Mailbox Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.And("User clicks \"hartmajt\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
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
#line 78
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 79
 testRunner.When("User navigates to the \'Device\' details page for \'001BAQXT6JWFPI\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.And("User clicks \"QLL295118\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.Then("Details page for \'QLL295118 (Nicole P. Braun)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.And("URL contains \"user/23726/details/user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.When("User selects \'Havoc (Big Data)\' in the \'Item Details Project\' dropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.And("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("User navigates to the \'Device Owner\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User clicks \"QLL295118\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("Details page for \'QLL295118 (Nicole P. Braun)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.Then("\'Havoc (Big Data)\' content is displayed in \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("URL contains \"user/23726/details/user?$projectId=43\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("User click back button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("Details page for \'001BAQXT6JWFPI\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Then("\'Havoc (Big Data)\' content is displayed in \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.And("User clicks \"Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" +
                    "\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("Details page for \'Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Di" +
                    "alogs\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("\'Havoc (Big Data)\' content is displayed in \'Item Details Project\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.And("URL contains \"application/373/details/application?$projectId=43\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
#line 105
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 106
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.When("User clicks on \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' cell from \'Project\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("Page with \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User navigates to the \'Details\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.And("User clicks \'ADD LANGUAGE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("User selects \"German\" language on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("User opens menu for selected language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.Then("User selects \"Set as default\" option for selected language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.When("User clicks \'Mailboxes\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("\'All Mailboxes\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.When("User perform search by \"001BAQXT6JWFPI\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.And("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("Details page for \'06BB714696274AC895A@bclabs.local\' item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.When("User selects \'USE ME FOR AUTOMATION(MAIL SCHDLD)\' in the \'Item Details Project\' d" +
                    "ropdown with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.And("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("User navigates to the \'Project Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table1.AddRow(new string[] {
                        "Language",
                        "German"});
#line 125
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

