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
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart18")]
    public partial class FiltersFunctionalityPart18Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FiltersFunctionalityPart18.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart18", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartII")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS15082")]
        [NUnit.Framework.CategoryAttribute("DAS17717")]
        public virtual void EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartII()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS15082",
                    "DAS17717"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartII", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS15082",
                        "DAS17717"});
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
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2045 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values",
                            "Association"});
                table2045.AddRow(new string[] {
                            "",
                            "Used on device"});
                table2045.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2045.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 12
 testRunner.And("User add \"Device IP Address\" filter where type is \"Not empty\" with following Valu" +
                        "e and Association:", ((string)(null)), table2045, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2046 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values",
                            "Association"});
                table2046.AddRow(new string[] {
                            "",
                            "Used on device"});
                table2046.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2046.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 17
 testRunner.And("User Add And \"Device IPv6 Address\" filter where type is \"Not empty\" with followin" +
                        "g Value and Association:", ((string)(null)), table2046, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2047 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values",
                            "Association"});
                table2047.AddRow(new string[] {
                            "",
                            "Used on device"});
                table2047.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2047.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 22
 testRunner.And("User Add And \"Device Manufacturer\" filter where type is \"Not empty\" with followin" +
                        "g Value and Association:", ((string)(null)), table2047, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2048 = new TechTalk.SpecFlow.Table(new string[] {
                            "Number",
                            "Association"});
                table2048.AddRow(new string[] {
                            "0",
                            "Used on device"});
                table2048.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2048.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 27
 testRunner.And("User Add And \"Device Memory (GB)\" filter where type is \"Greater than\" with follow" +
                        "ing Number and Association:", ((string)(null)), table2048, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2049 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values",
                            "Association"});
                table2049.AddRow(new string[] {
                            "",
                            "Used on device"});
                table2049.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2049.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 32
 testRunner.And("User Add And \"Device Model\" filter where type is \"Not empty\" with following Value" +
                        " and Association:", ((string)(null)), table2049, "And ");
#line hidden
#line 37
 testRunner.Then("\"1,032\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartIII")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS15082")]
        public virtual void EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartIII()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS15082"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartIII", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS15082"});
#line 41
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
#line 42
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2050 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes",
                            "Association"});
                table2050.AddRow(new string[] {
                            "FALSE",
                            "Used on device"});
                table2050.AddRow(new string[] {
                            "TRUE",
                            "Entitled to device"});
                table2050.AddRow(new string[] {
                            "UNKNOWN",
                            "Installed on device"});
#line 44
 testRunner.And("User add \"Device TPM Enabled\" filter where type is \"Equals\" with selected Checkbo" +
                        "xes and following Association:", ((string)(null)), table2050, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2051 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values",
                            "Association"});
                table2051.AddRow(new string[] {
                            "",
                            "Used on device"});
                table2051.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2051.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 49
 testRunner.And("User Add And \"Device TPM Version\" filter where type is \"Not empty\" with following" +
                        " Value and Association:", ((string)(null)), table2051, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2052 = new TechTalk.SpecFlow.Table(new string[] {
                            "Number",
                            "Association"});
                table2052.AddRow(new string[] {
                            "0",
                            "Used on device"});
                table2052.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2052.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 54
 testRunner.And("User Add And \"Device Target Drive Free Space (GB)\" filter where type is \"Greater " +
                        "than\" with following Number and Association:", ((string)(null)), table2052, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2053 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues",
                            "Association"});
                table2053.AddRow(new string[] {
                            "Data Centre",
                            "Used on device"});
                table2053.AddRow(new string[] {
                            "Desktop",
                            "Entitled to device"});
                table2053.AddRow(new string[] {
                            "Laptop",
                            "Installed on device"});
                table2053.AddRow(new string[] {
                            "Mobile",
                            ""});
                table2053.AddRow(new string[] {
                            "Other",
                            ""});
                table2053.AddRow(new string[] {
                            "Virtual",
                            ""});
#line 59
 testRunner.And("User Add And \"Device Type\" filter where type is \"Equals\" with following Lookup Va" +
                        "lue and Association:", ((string)(null)), table2053, "And ");
#line hidden
#line 67
 testRunner.Then("\"361\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterI")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS15082")]
        public virtual void EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterI()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS15082"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterI", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS15082"});
#line 70
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
#line 71
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2054 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes",
                            "Association"});
                table2054.AddRow(new string[] {
                            "Empty",
                            "Used on device"});
                table2054.AddRow(new string[] {
                            "32",
                            "Entitled to device"});
                table2054.AddRow(new string[] {
                            "64",
                            "Installed on device"});
#line 73
 testRunner.And("User add \"Device OS Architecture\" filter where type is \"Equals\" with selected Che" +
                        "ckboxes and following Association:", ((string)(null)), table2054, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2055 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes",
                            "Association"});
                table2055.AddRow(new string[] {
                            "Current Branch",
                            "Not entitled to device"});
                table2055.AddRow(new string[] {
                            "",
                            "Not installed on device"});
                table2055.AddRow(new string[] {
                            "",
                            "Not used on device"});
#line 78
 testRunner.And("User Add And \"Device OS Branch\" filter where type is \"Does not equal\" with select" +
                        "ed Checkboxes and following Association:", ((string)(null)), table2055, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2056 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues",
                            "Association"});
                table2056.AddRow(new string[] {
                            "Android 4.3",
                            "Used on device"});
                table2056.AddRow(new string[] {
                            "Empty",
                            "Entitled to device"});
                table2056.AddRow(new string[] {
                            "Android 4.4",
                            "Installed on device"});
                table2056.AddRow(new string[] {
                            "Android 5.0",
                            ""});
                table2056.AddRow(new string[] {
                            "Android 5.1",
                            ""});
#line 83
 testRunner.And("User Add And \"Device OS Full Name\" filter where type is \"Equals\" with following L" +
                        "ookup Value and Association:", ((string)(null)), table2056, "And ");
#line hidden
#line 90
 testRunner.Then("\"4\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterII")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS15082")]
        public virtual void EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterII()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS15082"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterII", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS15082"});
#line 93
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
#line 94
 testRunner.When("User clicks \'Applications\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2057 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes",
                            "Association"});
                table2057.AddRow(new string[] {
                            "Empty",
                            "Used on device"});
                table2057.AddRow(new string[] {
                            "",
                            "Entitled to device"});
                table2057.AddRow(new string[] {
                            "",
                            "Installed on device"});
#line 96
 testRunner.And("User add \"Device OS Servicing State\" filter where type is \"Does not equal\" with s" +
                        "elected Checkboxes and following Association:", ((string)(null)), table2057, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2058 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues",
                            "Association"});
                table2058.AddRow(new string[] {
                            "10.0",
                            "Used on device"});
                table2058.AddRow(new string[] {
                            "10.0.10240",
                            "Entitled to device"});
                table2058.AddRow(new string[] {
                            "Empty",
                            "Installed on device"});
                table2058.AddRow(new string[] {
                            "10.0.15063",
                            ""});
                table2058.AddRow(new string[] {
                            "10.0.14393",
                            ""});
#line 101
 testRunner.And("User Add And \"Device OS Version Number\" filter where type is \"Equals\" with follow" +
                        "ing Lookup Value and Association:", ((string)(null)), table2058, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2059 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedValues",
                            "Association"});
                table2059.AddRow(new string[] {
                            "Service Pack 1",
                            "Used on device"});
                table2059.AddRow(new string[] {
                            "Empty",
                            "Entitled to device"});
                table2059.AddRow(new string[] {
                            "No Service Pack",
                            "Installed on device"});
                table2059.AddRow(new string[] {
                            "Service Pack 2",
                            ""});
                table2059.AddRow(new string[] {
                            "Service Pack 3",
                            ""});
#line 108
 testRunner.And("User Add And \"Device Service Pack or Build\" filter where type is \"Equals\" with fo" +
                        "llowing Lookup Value and Association:", ((string)(null)), table2059, "And ");
#line hidden
#line 115
 testRunner.Then("\"170\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
