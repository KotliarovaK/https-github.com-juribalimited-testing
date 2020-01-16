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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ApplicationsDetails.Tabs.Projects
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EvergreenDetails")]
    public partial class EvergreenDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EvergreenDetails.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EvergreenDetails", "\tRuns Evergreen Details related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTheTargetAppForForwardPathRationalisationI" +
            "sChangedAfterChangingTheTargetAppWhenForwardPathRationalisationAlreadySelected")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS19189")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTheTargetAppForForwardPathRationalisationIsChangedAfterChangingTheTargetAppWhenForwardPathRationalisationAlreadySelected()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatTheTargetAppForForwardPathRationalisationIsChangedAfterChangingTheTargetAppWhenForwardPathRationalisationAlreadySelectedInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatTheTargetAppForForwardPathRationalisationIsChangedAfterChangingTheTargetAppWhenForwardPathRationalisationAlreadySelectedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTheTargetAppForForwardPathRationalisationI" +
                    "sChangedAfterChangingTheTargetAppWhenForwardPathRationalisationAlreadySelected", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19189",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'Application\' details page for \'\"WPF/E\" (codename) Communit" +
                    "y Technology Preview (Feb 2007)\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \'\"WPF/E\" (codename) Community Technology Preview (Feb 2007)\' ite" +
                    "m is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.When("User enters \'Corel WordPerfect\' in the \'Application\' autocomplete field and selec" +
                    "ts \'Corel WordPerfect 8 (327)\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table1.AddRow(new string[] {
                        "Target App",
                        "Corel WordPerfect 8"});
#line 18
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table1, "Then ");
#line 21
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.When("User enters \'Rosoft MP3 Encoder, Limited Edition\' in the \'Application\' autocomple" +
                    "te field and selects \'Rosoft Engineering Rosoft MP3 Encoder, Limited Edition (49" +
                    "5)\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table2.AddRow(new string[] {
                        "Target App",
                        "Rosoft Engineering Rosoft MP3 Encoder, Limited Edition"});
#line 24
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table2, "Then ");
#line 27
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.When("User selects \'UNCATEGORISED\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorre" +
            "ctly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS19026")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorrectlyInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorre" +
                    "ctly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19026",
                        "Not_Run"});
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 34
 testRunner.When("User navigates to the \'Application\' details page for \'Mozilla Sunbird (0.2a.)\' it" +
                    "em", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("Details page for \'Mozilla Sunbird (0.2a.)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("\'UPDATE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.Then("\'CANCEL\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        "FORWARD PATH"});
            table3.AddRow(new string[] {
                        "KEEP"});
            table3.AddRow(new string[] {
                        "RETIRE"});
            table3.AddRow(new string[] {
                        "UNCATEGORISED"});
#line 41
 testRunner.Then("following Values are displayed in the \'Rationalisation\' dropdown:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTheRationalisationValuesAreAppliedSuccessf" +
            "ully")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS19026")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTheRationalisationValuesAreAppliedSuccessfully()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatTheRationalisationValuesAreAppliedSuccessfullyInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatTheRationalisationValuesAreAppliedSuccessfullyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTheRationalisationValuesAreAppliedSuccessf" +
                    "ully", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19026",
                        "Cleanup"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 50
 testRunner.When("User navigates to the \'Application\' details page for the item with \'675\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("Details page for \'Music Visualizer Library 1.0\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.When("User selects \'RETIRE\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table4.AddRow(new string[] {
                        "Rationalisation",
                        "RETIRE"});
#line 57
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table4, "Then ");
#line 60
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.When("User selects \'UNCATEGORISED\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.When("User navigates to the \'Application\' details page for the item with \'676\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("Details page for \'Microsoft Internet Explorer 5.5 SP2 MUI Pack\' item is displayed" +
                    " to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.When("User enters \'Corel WordPerfect\' in the \'Application\' autocomplete field and selec" +
                    "ts \'Corel WordPerfect 8 (327)\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table5.AddRow(new string[] {
                        "Rationalisation",
                        "FORWARD PATH"});
#line 71
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table5, "Then ");
#line 74
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.When("User selects \'UNCATEGORISED\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.When("User navigates to the \'Application\' details page for the item with \'983\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("Details page for \'Mozilla Sunbird (0.2a.)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.When("User enters \'Microsoft Office Simplified Chinese Support\' in the \'Application\' au" +
                    "tocomplete field and selects \'Microsoft Office Simplified Chinese Support\' value" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table6.AddRow(new string[] {
                        "Rationalisation",
                        "FORWARD PATH"});
#line 85
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table6, "Then ");
#line 88
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.When("User selects \'KEEP\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table7.AddRow(new string[] {
                        "Rationalisation",
                        "KEEP"});
#line 91
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table7, "Then ");
#line 94
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.When("User selects \'UNCATEGORISED\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatRationalisationFromKeepToForwardPathIsCons" +
            "istentWithProjectRationalisationBehaviour")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS19448")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.CategoryAttribute("Not_Run")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatRationalisationFromKeepToForwardPathIsConsistentWithProjectRationalisationBehaviour()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatRationalisationFromKeepToForwardPathIsConsistentWithProjectRationalisationBehaviourInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatRationalisationFromKeepToForwardPathIsConsistentWithProjectRationalisationBehaviourInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatRationalisationFromKeepToForwardPathIsCons" +
                    "istentWithProjectRationalisationBehaviour", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19448",
                        "Cleanup",
                        "Not_Run"});
#line 100
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 102
 testRunner.When("User navigates to the \'Application\' details page for the item with \'251\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("Details page for \'AnalogX TrackSeek\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.When("User enters \'PID Control Toolset 6.0\' in the \'Application\' autocomplete field and" +
                    " selects \'National Instruments NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7" +
                    ".1) 7.1.0\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table8.AddRow(new string[] {
                        "Rationalisation",
                        "FORWARD PATH"});
            table8.AddRow(new string[] {
                        "Target App",
                        "National Instruments NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) 7.1.0"});
#line 110
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table8, "Then ");
#line 115
 testRunner.When("User navigates to the \'Application\' details page for the item with \'151\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.Then("Details page for \'NI LabVIEW PID Control Toolset 6.0\' item is displayed to the us" +
                    "er", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table9.AddRow(new string[] {
                        "Rationalisation",
                        "KEEP"});
#line 119
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table9, "Then ");
#line 123
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.When("User enters \'Carbon Copy Agent Package\' in the \'Application\' autocomplete field a" +
                    "nd selects \'Altiris Carbon Copy Agent Package 6.2.1144\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table10.AddRow(new string[] {
                        "Rationalisation",
                        "FORWARD PATH"});
            table10.AddRow(new string[] {
                        "Target App",
                        "Altiris Carbon Copy Agent Package 6.2.1144"});
#line 128
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table10, "Then ");
#line 133
 testRunner.When("User navigates to the \'Application\' details page for the item with \'251\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.Then("Details page for \'AnalogX TrackSeek\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Value"});
            table11.AddRow(new string[] {
                        "Rationalisation",
                        "FORWARD PATH"});
            table11.AddRow(new string[] {
                        "Target App",
                        "Altiris Carbon Copy Agent Package 6.2.1144"});
#line 137
 testRunner.Then("following content is displayed on the Details Page", ((string)(null)), table11, "Then ");
#line 141
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
 testRunner.When("User selects \'KEEP\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.When("User navigates to the \'Application\' details page for the item with \'151\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 145
 testRunner.Then("Details page for \'NI LabVIEW PID Control Toolset 6.0\' item is displayed to the us" +
                    "er", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.When("User selects \'KEEP\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 150
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTextOfTheAmberMessageAfterTryingToChangeRa" +
            "tionalisationFromKeepToAnotherOneIsDisplayedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS19694")]
        [NUnit.Framework.CategoryAttribute("Universe")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTextOfTheAmberMessageAfterTryingToChangeRationalisationFromKeepToAnotherOneIsDisplayedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatTextOfTheAmberMessageAfterTryingToChangeRationalisationFromKeepToAnotherOneIsDisplayedCorrectlyInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatTextOfTheAmberMessageAfterTryingToChangeRationalisationFromKeepToAnotherOneIsDisplayedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTextOfTheAmberMessageAfterTryingToChangeRa" +
                    "tionalisationFromKeepToAnotherOneIsDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS19694",
                        "Universe"});
#line 153
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 154
 testRunner.When("User navigates to the \'Application\' details page for the item with \'389\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.Then("Details page for \'ACDSee 4.0.2 PowerPack Trial Version\' item is displayed to the " +
                    "user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 160
 testRunner.When("User enters \'Acrobat Reader 3.01\' in the \'Application\' autocomplete field and sel" +
                    "ects \'Acrobat Reader 3.01\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
 testRunner.When("User navigates to the \'Application\' details page for the item with \'705\' ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.Then("Details page for \'Acrobat Reader 3.01\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
 testRunner.When("User navigates to the \'Projects\' parent left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 165
 testRunner.And("User navigates to the \'Evergreen Details\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 167
 testRunner.When("User selects \'RETIRE\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 169
 testRunner.Then("\'Any apps forward pathed to this app will be changed to be Uncategorised and the " +
                    "forward path removed\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 170
 testRunner.When("User clicks \'CANCEL\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 171
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 172
 testRunner.When("User selects \'UNCATEGORISED\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
 testRunner.Then("\'Any apps forward pathed to this app will be changed to be Uncategorised and the " +
                    "forward path removed\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.When("User clicks \'CANCEL\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 176
 testRunner.When("User clicks on edit button for \'Rationalisation\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 177
 testRunner.When("User selects \'FORWARD PATH\' in the \'Rationalisation\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 178
 testRunner.When("User enters \'zip\' in the \'Application\' autocomplete field and selects \'7zip (2015" +
                    ")\' value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 179
 testRunner.When("User clicks \'UPDATE\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 180
 testRunner.Then("\'Any apps forward pathed to this app will remain Forward Pathed and will be targe" +
                    "ted to the application selected above\' text is displayed on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

