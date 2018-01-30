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
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetailsDisplay")]
    public partial class ItemDetailsDisplayFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetailsDisplay", "\tRuns Item Details Display related tests", ProgrammingLanguage.CSharp, new string[] {
                        "retry:1"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
            testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS10438")]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "azuresync3@juriba1.onmicrosoft.com", "Email Address", new string[0])]
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
        
        private void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownInternal(string pageName, string searchCriteria, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS10438"};
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMai" +
            "lboxDetailsWhereThereIsNoMailboxOwner")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11531")]
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
                        "DAS11531"});
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownOnAPI")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS10438")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "azuresync3@juriba1.onmicrosoft.com", "Department and Location", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "ABW1509426", "Department and Location", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Devices", "01BQIYGGUW5PRP6", "Department and Location", new string[0])]
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownOnAPI(string pageName, string itemName, string sectionName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownOnAPIInternal(pageName, itemName, sectionName, exampleTags);
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
        
        private void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownOnAPIInternal(string pageName, string itemName, string sectionName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS10438",
                    "Not_Run",
                    "API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownOnAPI", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("I perform test request to the \"{0}\" API and get \"{1}\" item summary for \"{2}\" sect" +
                        "ion", pageName, itemName, sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"Unknown\" text displayed for \"{0}\" empty fields", sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
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
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "alfredo.m.daniel@dwlabs.local", "Mailbox", "Mailbox Database", "True", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "alfredo.m.daniel@dwlabs.local", "Mailbox", "Cloud Mail Server", "False", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "alex.cristea@juriba.com", "Mailbox", "Mail Server", "False", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Devices", "001BAQXT6JWFPI", "Device Owner", "Last Logoff Date", "False", new string[0])]
        public virtual void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI(string pageName, string itemName, string sectionName, string fieldName, string displayState, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPIInternal(pageName, itemName, sectionName, fieldName, displayState, exampleTags);
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("I perform test request to the \"{0}\" API and get \"{1}\" item summary for \"{2}\" sect" +
                        "ion", pageName, itemName, sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" field display state is \"{1}\" on Details tab API", fieldName, displayState), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPages")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11721")]
        [NUnit.Framework.TestCaseAttribute("Devices", "001BAQXT6JWFPI", "Hostname", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Users", "002B5DC7D4D34D5C895", "Username", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Applications", "Acrobat Reader 4", "Application", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "00BDBAEA57334C7C8F4@bclabs.local", "Email Address", new string[0])]
        public virtual void EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPages(string pageName, string objectName, string columnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPagesInternal(pageName, objectName, columnName, exampleTags);
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
        
        private void EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPagesInternal(string pageName, string objectName, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS11721"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPages", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User perform search by \"{0}\"", objectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("Group Icon for \"{0}\" page is displayed", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
