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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileData")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("AccountDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10756")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileData()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataInternal();
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
        
        private void EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileData", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "AccountDetailsFunctionality",
                        "DAS10756",
                        "Remove_Profile_Changes"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Profile in Account Dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Profile page is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Full Name to \"TestAdmin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User changes Email to \"TestEmail@test.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Error message is not displayed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Success message with \"Account details have been changed\" text is displayed on Acc" +
                    "ount Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"TestAdmin\" is displayed in Full Name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"TestEmail@test.com\" is displayed in Email field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AccountDetails_CheckThatCorrectErrorMessagesAreDisplayed")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("AccountDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS10756")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_AccountDetails_CheckThatCorrectErrorMessagesAreDisplayed()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AccountDetails_CheckThatCorrectErrorMessagesAreDisplayedInternal();
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
        
        private void EvergreenJnr_AccountDetails_CheckThatCorrectErrorMessagesAreDisplayedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AccountDetails_CheckThatCorrectErrorMessagesAreDisplayed", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "AccountDetailsFunctionality",
                        "DAS10756",
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
            testRunner.When("User changes Email to \"TestEmail@test.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User Upload incorrect avatar to Account Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"File uploaded not recognised as an image\" error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User Upload correct avatar to Account Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Success message with \"Image uploaded\" text is displayed on Account Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User picture is changed to uploaded photo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Remove on Account details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Success message with \"Image removed\" text is displayed on Account Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User picture changed to default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataT" +
            "wice")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ProfileDetails")]
        [NUnit.Framework.CategoryAttribute("AccountDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11524")]
        [NUnit.Framework.CategoryAttribute("Remove_Profile_Changes")]
        public virtual void EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwiceInternal();
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
        
        private void EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwiceInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataT" +
                    "wice", new string[] {
                        "Evergreen",
                        "ProfileDetails",
                        "EvergreenJnr_ProfileDetails",
                        "AccountDetailsFunctionality",
                        "DAS11524",
                        "Remove_Profile_Changes"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks Profile in Account Dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Profile page is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User changes Full Name to \"TestAdmin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("User changes Email to \"TestEmail@test.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Update button on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Error message is not displayed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Success message with \"Account details have been changed\" text is displayed on Acc" +
                    "ount Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("\"TestAdmin\" is displayed in Full Name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("\"TestEmail@test.com\" is displayed in Email field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User changes Full Name to \"TestAdm\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Error message is not displayed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Success message with \"Account details have been changed\" text is displayed on Acc" +
                    "ount Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
