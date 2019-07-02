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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsContent
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11478")]
        [NUnit.Framework.CategoryAttribute("DAS11477")]
        [NUnit.Framework.CategoryAttribute("DAS11476")]
        [NUnit.Framework.CategoryAttribute("DAS11510")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "alfredo.m.daniel@dwlabs.local", "Mailbox", "Mailbox Database", "True", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "alfredo.m.daniel@dwlabs.local", "Mailbox", "Cloud Mail Server", "False", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "alex.cristea@juriba.com", "Mailbox", "Mail Server", "False", null)]
        [NUnit.Framework.TestCaseAttribute("Devices", "001BAQXT6JWFPI", "Device Owner", "Last Logoff Date", "False", null)]
        public virtual void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI(string pageName, string itemName, string sectionName, string fieldName, string displayState, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPIInternal(pageName,itemName,sectionName,fieldName,displayState,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPIInternal(string pageName, string itemName, string sectionName, string fieldName, string displayState, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11478",
                    "DAS11477",
                    "DAS11476",
                    "DAS11510",
                    "API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When(string.Format("I perform test request to the \"{0}\" API and get \"{1}\" item summary for \"{2}\" sect" +
                        "ion", pageName, itemName, sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("\"{0}\" field display state is \"{1}\" on Details tab API", fieldName, displayState), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
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
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 22
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.When("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.When("User navigates to the \"Projects\" main-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("User clicks content of Evergreen Ring in Project Summary section on the Details P" +
                    "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User clicks New Ring ddl in popup of Project Summary section on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("Rings ddl contains data on Project Summary section of the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
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
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 33
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User perform search by \"001PSUMZYOW581\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When("User navigates to the \"Details\" main-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.When("User navigates to the \"Device Owner\" sub-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And("User clicks \"Tricia G. Huang\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("Details page for \"LFA418191 (Tricia G. Huang)\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ALlLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13341")]
        [NUnit.Framework.CategoryAttribute("DAS14923")]
        [NUnit.Framework.TestCaseAttribute("Devices", "02C80G8RFTPA9E", "Hostname", "Specification", "Specification", "Manufacturer", "FES0798481167", null)]
        [NUnit.Framework.TestCaseAttribute("Devices", "05PFM2OWVCSCZ1", "Hostname", "Details", "Device", "Hostname", "05PFM2OWVCSCZ1", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "03714167684E45F7A8F", "Username", "Details", "User", "Username", "03714167684E45F7A8F", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Adobe Acrobat Reader 5.0", "Application", "Details", "Application", "Vendor", "Adobe", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "06D7AE4F161F4A3AA7F@bclabs.local", "Email Address", "Details", "Mailbox", "Alias", "06D7AE4F161F4A3AA7F", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPage(string pageName, string searchTerm, string columnName, string mainTabName, string subTabName, string keyToBeSelected, string valueToBeSelected, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageInternal(pageName,searchTerm,columnName,mainTabName,subTabName,keyToBeSelected,valueToBeSelected,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageInternal(string pageName, string searchTerm, string columnName, string mainTabName, string subTabName, string keyToBeSelected, string valueToBeSelected, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPage", null, @__tags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 44
 testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.When(string.Format("User perform search by \"{0}\"", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.And(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When(string.Format("User navigates to the \"{0}\" main-menu on the Details page", mainTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.When(string.Format("User navigates to the \"{0}\" sub-menu on the Details page", subTabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.And(string.Format("User selects \"{0}\" text from key value grid on the Details Page", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then(string.Format("\"{0}\" text selected from key value grid on the Details Page", keyToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When(string.Format("User selects \"{0}\" text from key value grid on the Details Page", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then(string.Format("\"{0}\" text selected from key value grid on the Details Page", valueToBeSelected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 65
 testRunner.When("User type \"NL00G001\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("User clicks on \"NL00G001\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("User selects \"Description\" text from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("\"Description\" text selected from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("User selects \"Unknown\" text from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("\"Unknown\" text selected from key value grid on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 74
 testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("User perform search by \"Joel T. Hartman\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.And("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.When("User navigates to the \"Details\" main-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("User navigates to the \"Mailbox Owner\" sub-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("User clicks \"hartmajt\" link on the Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("Details object page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

