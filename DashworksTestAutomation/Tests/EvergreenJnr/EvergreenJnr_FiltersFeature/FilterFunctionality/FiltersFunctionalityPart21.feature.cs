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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_FiltersFeature.FilterFunctionality
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FiltersFunctionalityPart21")]
    public partial class FiltersFunctionalityPart21Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FiltersFunctionalityPart21.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FiltersFunctionalityPart21", "\tRuns Filters Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectPropertie" +
            "s")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17757")]
        public virtual void EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectProperties()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectPropertiesInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectPropertiesInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectPropertie" +
                    "s", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS17757"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 11
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table1.AddRow(new string[] {
                        "Offboarded"});
#line 13
 testRunner.When("User add \"1803: Status\" filter where type is \"Equals\" with added column and Looku" +
                    "p option", ((string)(null)), table1, "When ");
#line 16
 testRunner.Then("\"4\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table2.AddRow(new string[] {
                        "Offboarded"});
            table2.AddRow(new string[] {
                        "Offboarded"});
            table2.AddRow(new string[] {
                        "Offboarded"});
            table2.AddRow(new string[] {
                        "Offboarded"});
#line 17
 testRunner.Then("Content in the \'1803: Status\' column is equal to", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRe" +
            "lative")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS18377")]
        [NUnit.Framework.CategoryAttribute("DAS18621")]
        [NUnit.Framework.CategoryAttribute("DAS18686")]
        [NUnit.Framework.TestCaseAttribute("Devices", "1803: Pre-Migration \\ Scheduled Date", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Owner Last Logon Date", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Devices", "Owner Last Logon Date", "2.37457468568568568568658464554575547547547", null)]
        public virtual void EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRelative(string list, string filter, string value, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRelativeInternal(list,filter,value,exampleTags);
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

        private void EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRelativeInternal(string list, string filter, string value, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_FiltersFeature",
                    "FilterFunctionality",
                    "DAS18377",
                    "DAS18621",
                    "DAS18686"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRe" +
                    "lative", null, @__tags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 26
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", list), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        string.Format("{0}", value)});
#line 28
 testRunner.And(string.Format("User add \"{0}\" filter where type is \"Equals (relative)\" with added column and fol" +
                        "lowing value:", filter), ((string)(null)), table3, "And ");
#line 31
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereApplied")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("Evergreen_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS18140")]
        public virtual void EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereApplied()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereAppliedInternal();
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

        private void EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereAppliedInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereApplied", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "Evergreen_FiltersFeature",
                        "FilterFunctionality",
                        "DAS18140"});
#line 40
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 41
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
#line 44
 testRunner.When("User add \"Display Name\" filter where type is \"Not Empty\" with added column and Lo" +
                    "okup option", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table5.AddRow(new string[] {
                        "a"});
#line 46
 testRunner.When("User Add And \"Display Name\" filter where type is \"Contains\" with added column and" +
                    " following value:", ((string)(null)), table5, "When ");
#line 49
 testRunner.When("User click Edit button for \"Display Name\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("There are no any expanded blocks in Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWork")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_FiltersFeature")]
        [NUnit.Framework.CategoryAttribute("FilterFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS18709")]
        public virtual void EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWork()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWorkInternal();
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

        private void EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWorkInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWork", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_FiltersFeature",
                        "FilterFunctionality",
                        "DAS18709"});
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 55
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
            table6.AddRow(new string[] {
                        "Empty"});
#line 57
 testRunner.And("User add \"Owner Compliance\" filter where type is \"Does not equal\" with added colu" +
                    "mn and Lookup option", ((string)(null)), table6, "And ");
#line 60
 testRunner.Then("\"16,819\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("User have removed \"Owner Compliance\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedValues"});
#line 62
 testRunner.And("User add \"Owner Compliance\" filter where type is \"Not empty\" with added column an" +
                    "d Lookup option", ((string)(null)), table7, "And ");
#line 64
 testRunner.Then("\"16,819\" rows are displayed in the agGrid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

