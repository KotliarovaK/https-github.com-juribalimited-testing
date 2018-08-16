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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ProfileDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AccountDetailsFunctionality")]
    [NUnit.Framework.CategoryAttribute("retry:1")]
    public partial class AccountDetailsFunctionalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountDetailsFunctionality", "\tRuns Profile Details related tests", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileData")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("UserProfile")]
        [NUnit.Framework.CategoryAttribute("DAS10756")]
        [NUnit.Framework.CategoryAttribute("DAS12947")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileData", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "UserProfile",
                        "DAS10756",
                        "DAS12947",
                        "Remove_Profile_Changes"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Profile in Account Dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Profile page is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Full Name to \"TestAdmin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User changes Email to \"automation2@juriba.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Error message is not displayed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"TestAdmin\" is displayed in Full Name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"automation2@juriba.com\" is displayed in Email field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UserProfile_CheckThatCorrectErrorMessagesAreDisplayed")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("UserProfile")]
        [NUnit.Framework.CategoryAttribute("DAS10756")]
        [NUnit.Framework.CategoryAttribute("DAS12947")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_UserProfile_CheckThatCorrectErrorMessagesAreDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UserProfile_CheckThatCorrectErrorMessagesAreDisplayed", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "UserProfile",
                        "DAS10756",
                        "DAS12947",
                        "Remove_Profile_Changes"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Profile in Account Dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Profile page is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clears Full name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Enter your full name\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Full Name to \"Administrator\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User clears Email field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Enter your email address\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Email to \"testEmail\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Enter a valid email address\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Email to \"@test.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Enter a valid email address\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Email to \"TestEmail@test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("\"Enter a valid email address\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Email to \"automation2@juriba.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User Upload incorrect avatar to Account Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"The file uploaded is not recognised as an image\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User Upload correct avatar to Account Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Success message with \"Image changed\" text is displayed on Account Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User picture is changed to uploaded photo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Remove on Account details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Success message with \"Image removed\" text is displayed on Account Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User picture changed to default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwic" +
            "e")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("UserProfile")]
        [NUnit.Framework.CategoryAttribute("DAS11524")]
        [NUnit.Framework.CategoryAttribute("DAS12947")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwic" +
                    "e", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "UserProfile",
                        "DAS11524",
                        "DAS12947",
                        "Remove_Profile_Changes"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Profile in Account Dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Profile page is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Full Name to \"TestAdmin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User changes Email to \"automation2@juriba.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Error message is not displayed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"TestAdmin\" is displayed in Full Name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"automation2@juriba.com\" is displayed in Email field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User changes Full Name to \"TestAdm\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Error message is not displayed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UserProfile_CheckThatDefaultListPageSizeIs1000API")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FilterFeature")]
        [NUnit.Framework.CategoryAttribute("UserProfile")]
        [NUnit.Framework.CategoryAttribute("DAS11723")]
        [NUnit.Framework.CategoryAttribute("API")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_UserProfile_CheckThatDefaultListPageSizeIs1000API()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UserProfile_CheckThatDefaultListPageSizeIs1000API", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_FilterFeature",
                        "UserProfile",
                        "DAS11723",
                        "API",
                        "Not_Run"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("default list page Size is \"1000\" and Cache \"10\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UserProfile_CheckThatNotificationMessageDisappearsAfter5Seconds")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("UserProfile")]
        [NUnit.Framework.CategoryAttribute("DAS11646")]
        [NUnit.Framework.CategoryAttribute("DAS12947")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_UserProfile_CheckThatNotificationMessageDisappearsAfter5Seconds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UserProfile_CheckThatNotificationMessageDisappearsAfter5Seconds", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "UserProfile",
                        "DAS11646",
                        "DAS12947",
                        "Remove_Profile_Changes"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Profile in Account Dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Profile page is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigates to the \"Preferences\" page on Account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User changes language to \"English US\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Update button on Preferences page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Notification message is displayed for a few seconds on Preferences page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes language to \"Français\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Preferences page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("page elements are translated into French", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
