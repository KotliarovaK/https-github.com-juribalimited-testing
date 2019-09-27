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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Projects
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ProjectsPart14")]
    public partial class ProjectsPart14Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProjectsPart14.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProjectsPart14", "\tRuns Projects related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDispl" +
            "ayedInAlphabeticalOrder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12949")]
        [NUnit.Framework.CategoryAttribute("DAS12609")]
        [NUnit.Framework.CategoryAttribute("DAS12108")]
        [NUnit.Framework.CategoryAttribute("DAS12756")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDisplayedInAlphabeticalOrder()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDisplayedInAlphabeticalOrderInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDisplayedInAlphabeticalOrderInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDispl" +
                    "ayedInAlphabeticalOrder", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12949",
                        "DAS12609",
                        "DAS12108",
                        "DAS12756",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table1.AddRow(new string[] {
                        "project12949",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1, "When ");
#line 13
 testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.And("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("Page with \'Buckets\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Projects in filter dropdown are displayed in alphabetical order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User clicks String Filter button for \"Owned By Team\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("Teams in filter dropdown are displayed in alphabetical order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User enters \"project12949\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table2.AddRow(new string[] {
                        "ADD135461 (Luke W. Clark)"});
            table2.AddRow(new string[] {
                        "ADO048752 (Elena Z. Le)"});
            table2.AddRow(new string[] {
                        "ADX520696 (Bridgett E. Cobb)"});
            table2.AddRow(new string[] {
                        "CKB423934 (Tracie N. Bright)"});
            table2.AddRow(new string[] {
                        "CKB423934 (Tracie N. Bright)"});
#line 26
 testRunner.And("User expands multiselect and selects following Objects", ((string)(null)), table2, "And ");
#line 33
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("Warning message with \"3 users will be added\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("Success message is displayed and contains \"3 objects queued for onboarding, 0 obj" +
                    "ects offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table3.AddRow(new string[] {
                        "Adobe Reader 5ver2.1"});
            table3.AddRow(new string[] {
                        "allCLEAR 6.0 Viewer"});
            table3.AddRow(new string[] {
                        "AnalogX TrackSeek"});
#line 38
 testRunner.And("User expands multiselect and selects following Objects", ((string)(null)), table3, "And ");
#line 43
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("Warning message with \"3 applications will be added\" text is displayed on the Admi" +
                    "n page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("Success message is displayed and contains \"3 objects queued for onboarding, 0 obj" +
                    "ects offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("User navigates to the \'Users\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table4.AddRow(new string[] {
                        "ADD135461 (Luke W. Clark)"});
            table4.AddRow(new string[] {
                        "ADO048752 (Elena Z. Le)"});
            table4.AddRow(new string[] {
                        "ADX520696 (Bridgett E. Cobb)"});
#line 48
 testRunner.Then("following objects were not found", ((string)(null)), table4, "Then ");
#line 53
 testRunner.When("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table5.AddRow(new string[] {
                        "Adobe Reader 5ver2.1"});
            table5.AddRow(new string[] {
                        "allCLEAR 6.0 Viewer"});
            table5.AddRow(new string[] {
                        "AnalogX TrackSeek"});
#line 54
 testRunner.Then("following objects were not found", ((string)(null)), table5, "Then ");
#line 59
 testRunner.When("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("onboarded objects are displayed in the dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingPr" +
            "oject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12755")]
        [NUnit.Framework.CategoryAttribute("DAS12763")]
        [NUnit.Framework.CategoryAttribute("DAS14604")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingProjectInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingPr" +
                    "oject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12755",
                        "DAS12763",
                        "DAS14604",
                        "Cleanup"});
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table6.AddRow(new string[] {
                        "1DevicesProject",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 64
 testRunner.When("Project created via API and opened", ((string)(null)), table6, "When ");
#line 67
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("User navigates to the \'Teams\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("Page with \'Buckets\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("User selects \"Select All\" checkbox from String Filter with item list on the Admin" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User selects \"1DevicesProject\" checkbox from String Filter with item list on the " +
                    "Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("\'Unassigned\' content is displayed in the \'Bucket\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("Page with \'Projects\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.When("User enters \"1DevicesProject\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.And("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("User removes selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("User navigates to the \'Evergreen\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("User navigates to the \'Buckets\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.Then("Page with \'Buckets\' header is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.Then("\"1DevicesProject\" is not displayed in the filter dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("PMObject")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12965")]
        [NUnit.Framework.CategoryAttribute("DAS12485")]
        [NUnit.Framework.CategoryAttribute("DAS12825")]
        [NUnit.Framework.CategoryAttribute("DASDAS14617")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectlyInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "PMObject",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12965",
                        "DAS12485",
                        "DAS12825",
                        "DASDAS14617",
                        "Cleanup",
                        "Not_Run"});
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table7.AddRow(new string[] {
                        "Project12965",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 94
 testRunner.When("Project created via API and opened", ((string)(null)), table7, "When ");
#line 97
 testRunner.Then("Project \"Project12965\" is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("User selects \"Scope\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User selects \"Scope Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.And("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("User selects \"RED\" color in the Application Scope tab on the Project details page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("User selects \"Scope Changes\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("User navigates to the \'Applications\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table8.AddRow(new string[] {
                        "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook"});
#line 105
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table8, "And ");
#line 108
 testRunner.When("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.And("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.Then("Success message is displayed and contains \"1 object queued for onboarding, 0 obje" +
                    "cts offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.When("User selects \"Queue\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table9.AddRow(new string[] {
                        "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook"});
#line 112
 testRunner.Then("following Items are displayed in the Queue table", ((string)(null)), table9, "Then ");
#line 115
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.When("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table10.AddRow(new string[] {
                        "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook"});
#line 117
 testRunner.Then("following Items are displayed in the History table", ((string)(null)), table10, "Then ");
#line 120
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.When("User enters \"ALS - Designing a Microsoft Windows 2000 Dir. Services eBook\" text i" +
                    "n the Search field for \"Item\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.And("User clicks content from \"Item\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.Then("\"Project Object\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.And("Colour of onboarded app is \"Red\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemo" +
            "ve")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Projects")]
        [NUnit.Framework.CategoryAttribute("DAS12496")]
        [NUnit.Framework.CategoryAttribute("DAS12485")]
        [NUnit.Framework.CategoryAttribute("DAS12108")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemove()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemoveInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemoveInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemo" +
                    "ve", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Projects",
                        "DAS12496",
                        "DAS12485",
                        "DAS12108",
                        "Cleanup"});
#line 127
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table11.AddRow(new string[] {
                        "UsersProject2",
                        "All Users",
                        "None",
                        "Standalone Project"});
#line 128
 testRunner.When("Project created via API and opened", ((string)(null)), table11, "When ");
#line 131
 testRunner.Then("Project \"UsersProject2\" is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.When("User selects \"Scope\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.When("User selects \"Scope Changes\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.And("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("User expands multiselect to add objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table12.AddRow(new string[] {
                        "01HMZTRG6OQAOF"});
            table12.AddRow(new string[] {
                        "02C80G8RFTPA9E"});
            table12.AddRow(new string[] {
                        "04FPR090BNW80E"});
            table12.AddRow(new string[] {
                        "05LG3HCJLEDEMTR"});
            table12.AddRow(new string[] {
                        "2QP6MWKI0BM87U"});
            table12.AddRow(new string[] {
                        "2QP6MWKI0BM87U"});
#line 136
 testRunner.And("User selects following Objects from the expandable multiselect", ((string)(null)), table12, "And ");
#line 144
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("Warning message with \"4 devices will be added\" text is displayed on the Admin pag" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then("Success message is displayed and contains \"4 objects queued for onboarding, 0 obj" +
                    "ects offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.When("User selects \"Scope Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.And("User navigates to the \'Device Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.When("User selects \"Do not include owned devices\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.And("User navigates to the \'Application Scope\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("User selects \"Do not include applications\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("User selects \"Scope Changes\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And("User navigates to the \'Devices\' tab on Project Scope Changes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table13.AddRow(new string[] {
                        "01HMZTRG6OQAOF"});
            table13.AddRow(new string[] {
                        "02C80G8RFTPA9E"});
#line 155
 testRunner.And("User expands \'Devices to remove\' multiselect to the \'Devices\' tab on Project Scop" +
                    "e Changes page and selects following Objects", ((string)(null)), table13, "And ");
#line 159
 testRunner.And("User clicks \'UPDATE ALL CHANGES\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.Then("Warning message with \"2 devices will be removed\" text is displayed on the Admin p" +
                    "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.When("User clicks \'UPDATE PROJECT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
 testRunner.Then("Success message with \"0 objects queued for onboarding, 2 objects offboarded\" text" +
                    " is displayed on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.When("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 164
 testRunner.And("User clicks String Filter button for \"Action\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
 testRunner.And("User selects \"Onboard Device Object\" checkbox from String Filter with item list o" +
                    "n the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
 testRunner.Then("Rows counter shows \"2\" of \"6\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

