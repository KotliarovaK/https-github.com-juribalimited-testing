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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ProjectDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Offboard")]
    public partial class OffboardFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Offboard.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Offboard", "\tRuns Offboard related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPa" +
            "geWhichHasAssociatedObjects")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Offboard")]
        [NUnit.Framework.CategoryAttribute("DAS17843")]
        [NUnit.Framework.CategoryAttribute("DAS17926")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "063X2ZOB8V3GUY", "Hostname", "I-Computer Scheduled Project", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "ANN485030", "Username", "I-Computer Scheduled Project", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "06A573B6200A4A10BC2@bclabs.local", "Email Address", "Mailbox Evergreen Capacity Project", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasAssociatedObjects(string pageName, string loadedPage, string itemName, string columnName, string projectName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasAssociatedObjectsInternal(pageName,loadedPage,itemName,columnName,projectName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasAssociatedObjectsInternal(string pageName, string loadedPage, string itemName, string columnName, string projectName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "Offboard",
                    "DAS17843",
                    "DAS17926",
                    "Cleanup",
                    "Not_Ready"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPa" +
                    "geWhichHasAssociatedObjects", null, @__tags);
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 12
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", loadedPage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When(string.Format("User perform search by \"{0}\"", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then(string.Format("Details page for \"{0}\" item is displayed to the user", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When(string.Format("User switches to the \"{0}\" project in the Top bar on Item details page", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.And("User navigates to the \"Project Details\" sub-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("User clicks the \"OFFBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("Dialog Pop-up is displayed for User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.When("User clicks the \"OFFBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("Warning message with \"The selected objects will be offboarded, this cannot be und" +
                    "one\" text is displayed on the Project Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.When("User clicks the \"OFFBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("\'Projects\' page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.When(string.Format("User enters \"{0}\" text in the Search field for \"Project\" column", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.And("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And(string.Format("User enters \"{0}\" text in the Search field for \"Item\" column", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then(string.Format("\"{0}\" content is displayed in \"Item\" column", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPa" +
            "geWhichHasNoAssociatedObjects")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("Offboard")]
        [NUnit.Framework.CategoryAttribute("DAS17843")]
        [NUnit.Framework.CategoryAttribute("DAS17926")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "02M88BG4P29EEM", "Hostname", "I-Computer Scheduled Project", "This device will be offboarded, this cannot be undone", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "0088FC8A50DD4344B92", "Username", "I-Computer Scheduled Project", "This user will be offboarded, this cannot be undone", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "alex.cristea@juriba.com", "Email Address", "Email Migration", "This mailbox will be offboarded, this cannot be undone", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasNoAssociatedObjects(string pageName, string loadedPage, string itemName, string columnName, string projectName, string message, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasNoAssociatedObjectsInternal(pageName,loadedPage,itemName,columnName,projectName,message,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasNoAssociatedObjectsInternal(string pageName, string loadedPage, string itemName, string columnName, string projectName, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "Offboard",
                    "DAS17843",
                    "DAS17926",
                    "Cleanup",
                    "Not_Ready"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPa" +
                    "geWhichHasNoAssociatedObjects", null, @__tags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 47
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", loadedPage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.When(string.Format("User perform search by \"{0}\"", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.And(string.Format("User click content from \"{0}\" column", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then(string.Format("Details page for \"{0}\" item is displayed to the user", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When(string.Format("User switches to the \"{0}\" project in the Top bar on Item details page", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.And("User navigates to the \"Project Details\" sub-menu on the Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("User clicks the \"OFFBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.Then("Dialog Pop-up is displayed for User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.When("User clicks the \"OFFBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then(string.Format("Warning message with \"{0}\" text is displayed on the Project Details Page", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks the \"OFFBOARD\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("\'Admin\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("\'Projects\' page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When(string.Format("User enters \"{0}\" text in the Search field for \"Project\" column", projectName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("User navigates to the \'Scope\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.And("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And(string.Format("User enters \"{0}\" text in the Search field for \"Item\" column", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then(string.Format("\"{0}\" content is displayed in \"Item\" column", itemName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

