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
#line 10
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("User clicks the \"CREATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("\"Create Project\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("User enters \"project12949\" in the \"Project Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And("User selects \"All Devices\" in the Scope Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User clicks Create button on the Create Project page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("Success message is displayed and contains \"The project has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.When("User clicks \"Buckets\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("\"Buckets\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("Projects in filter dropdown are displayed in alphabetical order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("User clicks String Filter button for \"Owned By Team\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Teams in filter dropdown are displayed in alphabetical order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User enters \"project12949\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.When("User clicks content from \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.When("User clicks \"Users\" tab in the Project Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.When("User expands the object to add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table1.AddRow(new string[] {
                        "ADD135461 (Luke W. Clark)"});
            table1.AddRow(new string[] {
                        "ADO048752 (Elena Z. Le)"});
            table1.AddRow(new string[] {
                        "ADX520696 (Bridgett E. Cobb)"});
            table1.AddRow(new string[] {
                        "CKB423934 (Tracie N. Bright)"});
            table1.AddRow(new string[] {
                        "CKB423934 (Tracie N. Bright)"});
#line 33
 testRunner.And("User selects following Objects", ((string)(null)), table1, "And ");
#line 40
 testRunner.And("User clicks the \"UPDATE ALL CHANGES\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("Warning message with \"3 users will be added\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.When("User clicks the \"UPDATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("Success message is displayed and contains \"3 objects queued for onboarding, 0 obj" +
                    "ects offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("User clicks \"Applications\" tab in the Project Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.When("User expands the object to add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table2.AddRow(new string[] {
                        "Adobe Reader 5ver2.1"});
            table2.AddRow(new string[] {
                        "allCLEAR 6.0 Viewer"});
            table2.AddRow(new string[] {
                        "AnalogX TrackSeek"});
#line 46
 testRunner.And("User selects following Objects", ((string)(null)), table2, "And ");
#line 51
 testRunner.And("User clicks the \"UPDATE ALL CHANGES\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("Warning message with \"3 applications will be added\" text is displayed on the Admi" +
                    "n page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("User clicks the \"UPDATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("Success message is displayed and contains \"3 objects queued for onboarding, 0 obj" +
                    "ects offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When("User clicks \"Users\" tab in the Project Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table3.AddRow(new string[] {
                        "ADD135461 (Luke W. Clark)"});
            table3.AddRow(new string[] {
                        "ADO048752 (Elena Z. Le)"});
            table3.AddRow(new string[] {
                        "ADX520696 (Bridgett E. Cobb)"});
#line 56
 testRunner.Then("following objects were not found", ((string)(null)), table3, "Then ");
#line 61
 testRunner.When("User clicks \"Applications\" tab in the Project Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table4.AddRow(new string[] {
                        "Adobe Reader 5ver2.1"});
            table4.AddRow(new string[] {
                        "allCLEAR 6.0 Viewer"});
            table4.AddRow(new string[] {
                        "AnalogX TrackSeek"});
#line 62
 testRunner.Then("following objects were not found", ((string)(null)), table4, "Then ");
#line 67
 testRunner.When("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
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
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 72
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("User clicks the \"CREATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("\"Create Project\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User enters \"1DevicesProject\" in the \"Project Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.And("User selects \"All Devices\" in the Scope Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User clicks Create button on the Create Project page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("Success message is displayed and contains \"The project has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.When("User clicks \"Buckets\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.When("User clicks \"Teams\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.When("User clicks \"Buckets\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("\"Buckets\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User clicks Reset Filters button on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.When("User selects \"Select All\" checkbox from String Filter with item list on the Admin" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.When("User selects \"1DevicesProject\" checkbox from String Filter with item list on the " +
                    "Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("\"Unassigned\" text is displayed in the table content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User enters \"1DevicesProject\" text in the Search field for \"Project\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.And("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("User removes selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.When("User clicks \"Evergreen\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.When("User clicks \"Buckets\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("\"Buckets\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User clicks String Filter button for \"Project\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
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
#line 107
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 108
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.When("User clicks the \"CREATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then("\"Create Project\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.When("User enters \"Project12965\" in the \"Project Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.And("User selects \"All Devices\" in the Scope Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("User clicks Create button on the Create Project page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.Then("created Project with \"Project12965\" name is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.And("Success message is displayed and contains \"The project has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("Project \"Project12965\" is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("User selects \"Scope Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.And("User navigates to the \"Application Scope\" tab in the Scope section on the Project" +
                    " details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("User selects \"RED\" color in the Application Scope tab on the Project details page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("User selects \"Scope Changes\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("User clicks \"Applications\" tab in the Project Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("User expands the object to add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table5.AddRow(new string[] {
                        "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook"});
#line 127
 testRunner.And("User selects following Objects", ((string)(null)), table5, "And ");
#line 130
 testRunner.When("User clicks the \"UPDATE ALL CHANGES\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
 testRunner.And("User clicks the \"UPDATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.Then("Success message is displayed and contains \"1 object queued for onboarding, 0 obje" +
                    "cts offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.When("User selects \"Queue\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table6.AddRow(new string[] {
                        "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook"});
#line 134
 testRunner.Then("following Items are displayed in the Queue table", ((string)(null)), table6, "Then ");
#line 137
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.When("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table7.AddRow(new string[] {
                        "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook"});
#line 139
 testRunner.Then("following Items are displayed in the History table", ((string)(null)), table7, "Then ");
#line 142
 testRunner.When("User refreshes agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.When("User enters \"ALS - Designing a Microsoft Windows 2000 Dir. Services eBook\" text i" +
                    "n the Search field for \"Item\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.And("User clicks content from \"Item\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("\"Project Object\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
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
#line 149
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 150
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
 testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.When("User clicks the \"CREATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.Then("\"Create Project\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.When("User enters \"UsersProject2\" in the \"Project Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
 testRunner.And("User selects \"All Users\" in the Scope Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("User clicks Create button on the Create Project page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.Then("Success message is displayed and contains \"The project has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
 testRunner.Then("Project \"UsersProject2\" is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.When("User selects \"Scope Changes\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.And("User clicks \"Devices\" tab in the Project Scope Changes section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.And("User expands the object to add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table8.AddRow(new string[] {
                        "01HMZTRG6OQAOF"});
            table8.AddRow(new string[] {
                        "02C80G8RFTPA9E"});
            table8.AddRow(new string[] {
                        "04FPR090BNW80E"});
            table8.AddRow(new string[] {
                        "05LG3HCJLEDEMTR"});
            table8.AddRow(new string[] {
                        "2QP6MWKI0BM87U"});
            table8.AddRow(new string[] {
                        "2QP6MWKI0BM87U"});
#line 165
 testRunner.And("User selects following Objects", ((string)(null)), table8, "And ");
#line 173
 testRunner.And("User clicks the \"UPDATE ALL CHANGES\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.Then("Warning message with \"4 devices will be added\" text is displayed on the Admin pag" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.When("User clicks the \"UPDATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 176
 testRunner.Then("Success message is displayed and contains \"4 objects queued for onboarding, 0 obj" +
                    "ects offboarded\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 177
 testRunner.When("User selects \"Scope Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 178
 testRunner.And("User navigates to the \"Device Scope\" tab in the Scope section on the Project deta" +
                    "ils page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.When("User selects \"Do not include owned devices\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 180
 testRunner.And("User navigates to the \"Application Scope\" tab in the Scope section on the Project" +
                    " details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.When("User selects \"Do not include applications\" checkbox on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 182
 testRunner.When("User selects \"Scope Changes\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Objects"});
            table9.AddRow(new string[] {
                        "01HMZTRG6OQAOF"});
            table9.AddRow(new string[] {
                        "02C80G8RFTPA9E"});
#line 183
 testRunner.When("User adds following Objects to the Project on \"Devices\" tab", ((string)(null)), table9, "When ");
#line 187
 testRunner.When("User clicks the \"UPDATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 188
 testRunner.Then("Success message with \"0 objects queued for onboarding, 2 objects offboarded\" text" +
                    " is displayed on the Projects page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 189
 testRunner.When("User selects \"History\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 190
 testRunner.When("User clicks String Filter button for \"Action\" column on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 191
 testRunner.When("User selects \"Onboard Computer Object\" checkbox from String Filter with item list" +
                    " on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 192
 testRunner.Then("Rows counter shows \"2\" of \"6\" rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

