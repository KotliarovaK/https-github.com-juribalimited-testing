// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_FiltersFeature.FilterFunctionality
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart04")]
    public partial class FiltersFunctionalityPart04Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FiltersFunctionalityPart04.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart04", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
#line hidden
#line 5
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearWhenAddingAdvancedAndStandardF" +
            "ilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11559")]
        public virtual void EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearWhenAddingAdvancedAndStandardFilters()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11559"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearWhenAddingAdvancedAndStandardF" +
                    "ilters", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS11559"});
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 10
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1920 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedList",
                            "Association"});
                table1920.AddRow(new string[] {
                            "Altiris",
                            "Used on device"});
#line 14
 testRunner.When("User add \"Application Import\" filter where type is \"Equals\" with Selected Value a" +
                        "nd following Association:", ((string)(null)), table1920, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1921 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1921.AddRow(new string[] {
                            "07 Dec 2017"});
#line 17
 testRunner.And("User add \"Boot Up Date\" filter where type is \"Equals\" with added column and follo" +
                        "wing value:", ((string)(null)), table1921, "And ");
#line hidden
#line 20
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearAndFullDataIsDisplayedWhenAddi" +
            "ngDifferentFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11741")]
        [NUnit.Framework.CategoryAttribute("DAS13001")]
        public virtual void EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearAndFullDataIsDisplayedWhenAddingDifferentFilters()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11741",
                    "DAS13001"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearAndFullDataIsDisplayedWhenAddi" +
                    "ngDifferentFilters", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS11741",
                        "DAS13001"});
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 24
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1922 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues"});
                table1922.AddRow(new string[] {
                            "Red"});
                table1922.AddRow(new string[] {
                            "Blue"});
                table1922.AddRow(new string[] {
                            "Out Of Scope"});
                table1922.AddRow(new string[] {
                            "Light Blue"});
                table1922.AddRow(new string[] {
                            "Brown"});
                table1922.AddRow(new string[] {
                            "Amber"});
                table1922.AddRow(new string[] {
                            "Really Extremely Orange"});
                table1922.AddRow(new string[] {
                            "Purple"});
                table1922.AddRow(new string[] {
                            "Green"});
                table1922.AddRow(new string[] {
                            "Grey"});
                table1922.AddRow(new string[] {
                            "None"});
#line 28
 testRunner.When("User add \"Windows7Mi: Application Readiness\" filter where type is \"Equals\" with a" +
                        "dded column and Lookup option", ((string)(null)), table1922, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1923 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1923.AddRow(new string[] {
                            "TRUE"});
#line 41
 testRunner.When("User Add And \"Windows7Mi: In Scope\" filter where type is \"Equals\" with added colu" +
                        "mn and following checkboxes:", ((string)(null)), table1923, "When ");
#line hidden
#line 44
 testRunner.Then("full list content is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatc" +
            "hingTheCaption")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11838")]
        [NUnit.Framework.CategoryAttribute("DAS13001")]
        [NUnit.Framework.TestCaseAttribute("Red", "RED", null)]
        [NUnit.Framework.TestCaseAttribute("Blue", "BLUE", null)]
        [NUnit.Framework.TestCaseAttribute("Light Blue", "LIGHT BLUE", null)]
        [NUnit.Framework.TestCaseAttribute("Brown", "BROWN", null)]
        [NUnit.Framework.TestCaseAttribute("Amber", "AMBER", null)]
        [NUnit.Framework.TestCaseAttribute("Really Extremely Orange", "REALLY EXTREMELY ORANGE", null)]
        [NUnit.Framework.TestCaseAttribute("Purple", "PURPLE", null)]
        [NUnit.Framework.TestCaseAttribute("Green", "GREEN", null)]
        [NUnit.Framework.TestCaseAttribute("Grey", "GREY", null)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatchingTheCaption(string selectedCheckbox, string colorName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11838",
                    "DAS13001"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatc" +
                    "hingTheCaption", null, @__tags);
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 49
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1924 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues"});
                table1924.AddRow(new string[] {
                            string.Format("{0}", selectedCheckbox)});
#line 53
 testRunner.When("User add \"ComputerSc: Target App Readiness\" filter where type is \"Equals\" with ad" +
                        "ded column and Lookup option", ((string)(null)), table1924, "When ");
#line hidden
#line 56
 testRunner.Then(string.Format("\'{0}\' content is displayed in all \'ComputerSc: Target App Readiness\' column", colorName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.Then(string.Format("\'{0}\' path is displayed in the \'ComputerSc: Target App Readiness\' column", selectedCheckbox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheApplicationRationalisationIt" +
            "emIsMatchingTheCaption")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS11838")]
        [NUnit.Framework.TestCaseAttribute("FORWARD PATH", null)]
        [NUnit.Framework.TestCaseAttribute("KEEP", null)]
        [NUnit.Framework.TestCaseAttribute("RETIRE", null)]
        [NUnit.Framework.TestCaseAttribute("UNCATEGORISED", null)]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheApplicationRationalisationItemIsMatchingTheCaption(string selectedCheckbox, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS11838"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheApplicationRationalisationIt" +
                    "emIsMatchingTheCaption", null, @__tags);
#line 72
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 73
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1925 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1925.AddRow(new string[] {
                            string.Format("{0}", selectedCheckbox)});
#line 77
 testRunner.When("User add \"ComputerSc: Application Rationalisation\" filter where type is \"Equal\" w" +
                        "ith added column and following checkboxes:", ((string)(null)), table1925, "When ");
#line hidden
#line 80
 testRunner.Then(string.Format("\'{0}\' content is displayed in all \'ComputerSc: Application Rationalisation\' colum" +
                            "n", selectedCheckbox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.Then(string.Format("\'{0}\' path is displayed in the \'ComputerSc: Application Rationalisation\' column", selectedCheckbox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhe" +
            "nDoesnotequalNoneForWindows7MiCategoryFilter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12076")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        public virtual void EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhenDoesnotequalNoneForWindows7MiCategoryFilter()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS12076",
                    "DAS12351"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhe" +
                    "nDoesnotequalNoneForWindows7MiCategoryFilter", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS12076",
                        "DAS12351"});
#line 91
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 92
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1926 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1926.AddRow(new string[] {
                            "None"});
#line 96
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" with added column a" +
                        "nd following checkboxes:", ((string)(null)), table1926, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1927 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1927.AddRow(new string[] {
                            "Windows7Mi: Category"});
#line 99
 testRunner.Then("Content is empty in the column", ((string)(null)), table1927, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1928 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table1928.AddRow(new string[] {
                            "None"});
#line 102
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Does not equal\" without add" +
                        "ed column and following checkboxes:", ((string)(null)), table1928, "When ");
#line hidden
#line 105
 testRunner.When("User clicks on \'Windows7Mi: Category\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1929 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table1929.AddRow(new string[] {
                            "Windows7Mi: Category"});
#line 106
 testRunner.Then("Content is present in the newly added column", ((string)(null)), table1929, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
