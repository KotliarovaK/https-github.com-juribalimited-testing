﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ItemDetailsDisplayFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetailsDisplay", "\tRuns Item Details Display related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                global::DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsDisplayFeature.FeatureSetup(null);
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
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("Login link is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks on the Login link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown(string pageName, string searchCriteria, string columnName, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_All empty fields in item details are displayed as Unknown", @__tags);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_All empty fields in item details are displayed as Unknown: " +
            "Mailboxes")]
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_All empty fields in item details are displayed as Unknown: " +
            "Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AllLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_ItemDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ItemDetailsDisplay")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10438")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PageName", "Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SearchCriteria", "Python 2.2a4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ColumnName", "Application")]
        public virtual void EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown_Applications()
        {
            this.EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown("Applications", "Python 2.2a4", "Application", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_All empty fields in item details are displayed as Unknown: " +
            "Users")]
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_AllLists_All empty fields in item details are displayed as Unknown: " +
            "Devices")]
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
    }
}
#pragma warning restore
#endregion
