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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ListDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ListDetailsFunctionalityPart7")]
    public partial class ListDetailsFunctionalityPart7Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ListDetailsFunctionalityPart7.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart7", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanel" +
            "AfterListCreation")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12580")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanelAfterListCreation()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanelAfterListCreationInternal();
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

        private void EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanelAfterListCreationInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanel" +
                    "AfterListCreation", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS12580",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table1.AddRow(new string[] {
                        ""});
#line 14
 testRunner.When("User add \"Dashworks First Seen\" filter where type is \"Empty\" with added column an" +
                    "d following value:", ((string)(null)), table1, "When ");
#line 17
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User removes \"Application\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.And("User removes \"Vendor\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("User removes \"Version\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User creates \'TestList5478\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("Save and Cancel buttons are not displayed on the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("\"TestList5478\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectl" +
            "y")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12629")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectlyInternal();
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

        private void EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectl" +
                    "y", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS12629",
                        "Cleanup"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 28
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When("User clicks on \'Application\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.When("User create dynamic list with \"DynamicListFirst\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("\"DynamicListFirst\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User navigates to the \"All Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.When("User clicks on \'Vendor\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.When("User create dynamic list with \"DynamicListSecond5684\" name on \"Applications\" page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("\"DynamicListSecond5684\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table2.AddRow(new string[] {
                        ""});
#line 42
 testRunner.When("User create static list with \"StaticList7844AT\" name on \"Applications\" page with " +
                    "following items", ((string)(null)), table2, "When ");
#line 45
 testRunner.Then("\"StaticList7844AT\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.When("User navigates to the \"DynamicListFirst\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("User navigates to the \"DynamicListSecond5684\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.When("User selects \'Automation Admin 1\' option from \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.When("User clicks \'ACCEPT\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.When("User navigates to the \"DynamicListFirst\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("current user is selected in \'Owner\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchin" +
            "gBetweenTabsWhileAddUserFormIsOpen")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS13066")]
        [NUnit.Framework.CategoryAttribute("DAS15561")]
        [NUnit.Framework.CategoryAttribute("DAS15569")]
        [NUnit.Framework.CategoryAttribute("DAS16403")]
        [NUnit.Framework.CategoryAttribute("DAS16407")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchingBetweenTabsWhileAddUserFormIsOpen()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchingBetweenTabsWhileAddUserFormIsOpenInternal();
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

        private void EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchingBetweenTabsWhileAddUserFormIsOpenInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchin" +
                    "gBetweenTabsWhileAddUserFormIsOpen", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS13066",
                        "DAS15561",
                        "DAS15569",
                        "DAS16403",
                        "DAS16407",
                        "Cleanup"});
#line 60
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 61
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User clicks on \'Application\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.And("User create dynamic list with \"DynamicList13066\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("\"DynamicList13066\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.When("User selects \'Specific users / teams\' in the \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("\'Specific users / teams\' content is displayed in \'Sharing\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("User clicks \'ADD TEAM\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.When("User selects \'1803 Team\' option from \'Team\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("\'ADD TEAM\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.When("User clicks \'ADD TEAM\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.When("User selects \'1803 Team\' option from \'Team\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.When("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("form container is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User selects \'Administrator\' option from \'User\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.When("User selects \'Administrator\' option from \'User\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.When("User selects \'Edit\' in the \'Permission\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.And("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When("User clicks Close panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.And("\"Admin\" Sharing user is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("form container is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.When("User clicks \'ADD USER\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.And("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("User list for sharing is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDeta" +
            "ilsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS13029")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDetailsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDetailsPageInternal();
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

        private void EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDetailsPageInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDeta" +
                    "ilsPage", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS13029",
                        "Cleanup"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 96
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("User clicks on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.And("User create dynamic list with \"ATList13029\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("\"ATList13029\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.When("User clicks the Permissions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("\'Owner\' autocomplete options are sorted in the alphabetical order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

