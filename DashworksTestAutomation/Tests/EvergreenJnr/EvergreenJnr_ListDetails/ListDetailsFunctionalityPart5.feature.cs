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
    [NUnit.Framework.DescriptionAttribute("ListDetailsFunctionalityPart5")]
    public partial class ListDetailsFunctionalityPart5Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ListDetailsFunctionalityPart5.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart5", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesSta" +
            "ticLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12075")]
        [NUnit.Framework.CategoryAttribute("DAS12578")]
        [NUnit.Framework.CategoryAttribute("DAS12791")]
        [NUnit.Framework.CategoryAttribute("DAS12952")]
        [NUnit.Framework.CategoryAttribute("DAS14222")]
        [NUnit.Framework.CategoryAttribute("DAS15551")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesStaticLists()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesStaticListsInternal();
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

        private void EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesStaticListsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesSta" +
                    "ticLists", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS12075",
                        "DAS12578",
                        "DAS12791",
                        "DAS12952",
                        "DAS14222",
                        "DAS15551",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table1.AddRow(new string[] {
                        "Python 2.2a4"});
            table1.AddRow(new string[] {
                        "Quartus II Programmer 4.0"});
            table1.AddRow(new string[] {
                        "Multi Edit 9 Client"});
#line 10
 testRunner.When("User create static list with \"Application12075\" name on \"Applications\" page with " +
                    "following items", ((string)(null)), table1, "When ");
#line 15
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.Then("\"3\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table2.AddRow(new string[] {
                        "Application12075",
                        "Used on device"});
#line 21
 testRunner.When("User add \"Application (Saved List)\" filter where type is \"In list\" with Selected " +
                    "Value and following Association:", ((string)(null)), table2, "When ");
#line 24
 testRunner.And("User create dynamic list with \"Devices12075\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("User navigates to the \"Application12075\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\"Application12075\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'Application12075\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("\"Application12075\" list \"list is used by 1 list, do you wish to proceed?\" message" +
                    " is displayed in the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'Application12075\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.When("User confirms list removing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.And("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User navigates to the \"Devices12075\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("\"Any Application in list [List not found] used on device\" is displayed in added f" +
                    "ilter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("message \'This list could not be processed, it may refer to a list with errors\' is" +
                    " displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesLis" +
            "ts")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12075")]
        [NUnit.Framework.CategoryAttribute("DAS12578")]
        [NUnit.Framework.CategoryAttribute("DAS12791")]
        [NUnit.Framework.CategoryAttribute("DAS12952")]
        [NUnit.Framework.CategoryAttribute("DAS14222")]
        [NUnit.Framework.CategoryAttribute("DAS15551")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesLists()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesListsInternal();
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

        private void EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesListsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesLis" +
                    "ts", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS12075",
                        "DAS12578",
                        "DAS12791",
                        "DAS12952",
                        "DAS14222",
                        "DAS15551",
                        "Cleanup"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table3.AddRow(new string[] {
                        "Microsoft SDK Update February 2003 (5.2.3790.0)"});
            table3.AddRow(new string[] {
                        "Quartus II Programmer 4.0"});
            table3.AddRow(new string[] {
                        "Mindreef SOAPscope 4.0"});
#line 43
 testRunner.When("User create static list with \"Application3_12075\" name on \"Applications\" page wit" +
                    "h following items", ((string)(null)), table3, "When ");
#line 48
 testRunner.Then("\"Application3_12075\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("\"3\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table4.AddRow(new string[] {
                        "Application3_12075",
                        "Used on device"});
#line 55
 testRunner.When("User add \"Application (Saved List)\" filter where type is \"In list\" with Selected " +
                    "Value and following Association:", ((string)(null)), table4, "When ");
#line 58
 testRunner.And("User create dynamic list with \"Devices3_12075\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.Then("\"Devices3_12075\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table5.AddRow(new string[] {
                        "Application3_12075",
                        "Entitled to device"});
#line 64
 testRunner.When("User add \"Application (Saved List)\" filter where type is \"In list\" with Selected " +
                    "Value and following Association:", ((string)(null)), table5, "When ");
#line 67
 testRunner.And("User create dynamic list with \"Devices4_12075\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("\"Devices4_12075\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.When("User navigates to the \"Application3_12075\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("\"Application3_12075\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'Application3_12075\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("\"Application3_12075\" list \"list is used by 2 lists, do you wish to proceed?\" mess" +
                    "age is displayed in the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'Application3_12075\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.When("User confirms list removing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.And("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("User navigates to the \"Devices3_12075\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.And("\"Any Application in list [List not found] used on device\" is displayed in added f" +
                    "ilter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("message \'This list could not be processed, it may refer to a list with errors\' is" +
                    " displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependencies" +
            "Lists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12075")]
        [NUnit.Framework.CategoryAttribute("DAS12578")]
        [NUnit.Framework.CategoryAttribute("DAS14222")]
        [NUnit.Framework.CategoryAttribute("DAS15551")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependenciesLists()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependenciesListsInternal();
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

        private void EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependenciesListsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependencies" +
                    "Lists", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS12075",
                        "DAS12578",
                        "DAS14222",
                        "DAS15551",
                        "Cleanup"});
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 87
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User clicks on \'Application\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.And("User create dynamic list with \"Application4\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table6.AddRow(new string[] {
                        "Compliance"});
#line 91
 testRunner.And("User add following columns using URL to the \"Applications\" page:", ((string)(null)), table6, "And ");
#line 94
 testRunner.And("User create dynamic list with \"Application5\" name on \"Applications\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedList",
                        "Association"});
            table7.AddRow(new string[] {
                        "Application4",
                        "Used on device"});
            table7.AddRow(new string[] {
                        "Application5",
                        "Used on device"});
#line 99
 testRunner.When("User add \"Application (Saved List)\" filter where type is \"In list\" with Selected " +
                    "Value and following Association:", ((string)(null)), table7, "When ");
#line 103
 testRunner.And("User create dynamic list with \"ATDevices4\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.When("User navigates to the \"Application4\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("\"Application4\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'Application4\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.Then("\"Application4\" list \"list is used by 1 list, do you wish to proceed?\" message is " +
                    "displayed in the list panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.When("User clicks \'Delete\' option in cogmenu for \'Application4\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.When("User confirms list removing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.And("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.When("User navigates to the \"ATDevices4\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.And("\"Any Application in list [List not found] or Application5 used on device\" is disp" +
                    "layed in added filter info", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeleting" +
            "AnotherListForDynamicAndStaticLists")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12536")]
        [NUnit.Framework.CategoryAttribute("DAS12791")]
        [NUnit.Framework.CategoryAttribute("DAS12952")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicAndStaticLists()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicAndStaticListsInternal();
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

        private void EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicAndStaticListsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeleting" +
                    "AnotherListForDynamicAndStaticLists", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS12536",
                        "DAS12791",
                        "DAS12952",
                        "Cleanup"});
#line 120
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 121
 testRunner.When("User clicks \'Users\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("\'All Users\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
 testRunner.When("User clicks on \'Username\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.Then("data in table is sorted by \'Username\' column in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.When("User create dynamic list with \"DynamicList2569\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.Then("\"DynamicList2569\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.When("User navigates to the \"All Users\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table8.AddRow(new string[] {
                        "000F977AC8824FE39B8"});
            table8.AddRow(new string[] {
                        "002B5DC7D4D34D5C895"});
#line 128
 testRunner.And("User create static list with \"StaticList2584\" name on \"Users\" page with following" +
                    " items", ((string)(null)), table8, "And ");
#line 132
 testRunner.Then("\"StaticList2584\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.And("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("\"2\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.When("User clicks Delete list button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.And("User navigates to the \"DynamicList2569\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.Then("inline success banner is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.When("User clicks the List Details button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("Details panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.And("no Warning message is displayed in the list details panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

