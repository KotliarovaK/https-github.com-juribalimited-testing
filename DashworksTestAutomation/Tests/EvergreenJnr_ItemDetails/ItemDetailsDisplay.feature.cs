﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ItemDetailsDisplayFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetailsDisplay", "\tRuns Item Details Display related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ItemDetailsDisplay")))
            {
                DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsDisplayFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown(string pageName, string searchCriteria, string columnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownInternal(pageName, searchCriteria, columnName, exampleTags);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown: Mailboxes" +
            "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AllLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10438")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PageName", "Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SearchCriteria", "azuresync3@juriba1.onmicrosoft.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ColumnName", "Email Address")]
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown_Mailboxes()
        {
            this.EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown("Mailboxes", "azuresync3@juriba1.onmicrosoft.com", "Email Address", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown: Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AllLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10438")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PageName", "Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SearchCriteria", "ABW1509426")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ColumnName", "Username")]
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown_Users()
        {
            this.EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown("Users", "ABW1509426", "Username", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown: Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AllLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10438")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PageName", "Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SearchCriteria", "01BQIYGGUW5PRP6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ColumnName", "Hostname")]
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown_Devices()
        {
            this.EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown("Devices", "01BQIYGGUW5PRP6", "Hostname", ((string[])(null)));
        }
        
        private void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownInternal(string pageName, string searchCriteria, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS-10438"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User perform search by \"{0}\"", searchCriteria), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User navigates to the \"Details\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Unknown text is displayed for empty fields for \"Department and Location\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMai" +
            "lboxDetailsWhereThereIsNoMailboxOwner")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11531")]
        public virtual void EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwner()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwnerInternal();
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
        
        private void EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwnerInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMai" +
                    "lboxDetailsWhereThereIsNoMailboxOwner", new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS-11531"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User perform search by \"alex.cristea@juriba.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"No mailbox owner found for this mailbox\" text is displayed for \"Mailbox Owner\" s" +
                    "ection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        public virtual void EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab(string emailAddress, string fieldName, string displayState, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTabInternal(emailAddress, fieldName, displayState, exampleTags);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11478")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11477")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11476")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "alfredo.m.daniel@dwlabs.local")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FieldName", "Mailbox Database")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DisplayState", "true")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab_Variant0()
        {
            this.EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab("alfredo.m.daniel@dwlabs.local", "Mailbox Database", "true", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11478")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11477")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11476")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "alfredo.m.daniel@dwlabs.local")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FieldName", "Cloud Mail Server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DisplayState", "false")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab_Variant1()
        {
            this.EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab("alfredo.m.daniel@dwlabs.local", "Cloud Mail Server", "false", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11478")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11477")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11476")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "alex.cristea@juriba.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FieldName", "Mail Server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DisplayState", "false")]
        public virtual void EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab_Variant2()
        {
            this.EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab("alex.cristea@juriba.com", "Mail Server", "false", ((string[])(null)));
        }
        
        private void EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTabInternal(string emailAddress, string fieldName, string displayState, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS-11478",
                    "DAS-11477",
                    "DAS-11476"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Mailboxes\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Mailboxes\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User perform search by \"{0}\"", emailAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User click content from \"Email Address\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then(string.Format("\"{0}\" field display state is \"{1}\" on Details tab", fieldName, displayState), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwn" +
            "erBlockOfDeviceDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11510")]
        public virtual void EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetails()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetailsInternal();
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
        
        private void EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetailsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwn" +
                    "erBlockOfDeviceDetails", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS-11510"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User click content from \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigates to the \"Details\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"Device Owner\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Last Logoff Date\" field display state is \"false\" on Details tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
