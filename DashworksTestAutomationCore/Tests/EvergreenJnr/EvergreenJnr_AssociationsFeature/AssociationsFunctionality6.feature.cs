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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_AssociationsFeature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AssociationsFunctionality6")]
    public partial class AssociationsFunctionality6Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AssociationsFunctionality6.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssociationsFunctionality6", "\tRuns Associations Functionality related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatOrRequestHasCorrectOperatorParameter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18092")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatOrRequestHasCorrectOperatorParameter()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatOrRequestHasCorrectOperatorParameterInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatOrRequestHasCorrectOperatorParameterInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18092"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatOrRequestHasCorrectOperatorParameter", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18092"});
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
 testRunner.Then("\'All Applications\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User navigates to the \"All Device Applications\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When("User selects \'Used on device\' option in \'Search associations\' autocomplete of Ass" +
                        "ociations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When("User selects \'Evergreen\' option from \'Project or Evergreen\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When("User selects \'Entitled to device\' option in \'Search associations\' autocomplete of" +
                        " Associations panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("Associations request has correct operator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckDeviceLocationColumnsAndFilters")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18859")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckDeviceLocationColumnsAndFilters()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckDeviceLocationColumnsAndFiltersInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckDeviceLocationColumnsAndFiltersInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18859",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDeviceLocationColumnsAndFilters", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18859",
                        "Cleanup"});
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
 testRunner.When(@"User navigates to 'deviceapplications?$filter=(country%20EQUALS%20('USA'%2C'Australia'%2C'England')%20AND%20buildingName%20IS%20NOT%20EMPTY%20()%20AND%20city%20NOT%20EQUALS%20('London')%20AND%20floor%20IS%20NOT%20EMPTY%20()%20AND%20locationName%20EQUALS%20('101%20Hudson%20Street%20F20'%2C'101%20Hudson%20Street%20F21'%2C'120%20Collins%20Street%20F5')%20AND%20postalCode%20NOT%20CONTAINS%20('3000')%20AND%20stateCounty%20EQUALS%20('AB'%2C'NULL'%2C'CA'%2C'NJ'%2C'NY'%2C'VIC'))&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,country,buildingName,city,floor,locationName,postalCode,stateCounty&$association=(etd)' url via address line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then(@"URL contains 'deviceapplications?$filter=(country%20EQUALS%20('USA'%2C'Australia'%2C'England')%20AND%20buildingName%20IS%20NOT%20EMPTY%20()%20AND%20city%20NOT%20EQUALS%20('London')%20AND%20floor%20IS%20NOT%20EMPTY%20()%20AND%20locationName%20EQUALS%20('101%20Hudson%20Street%20F20'%2C'101%20Hudson%20Street%20F21'%2C'120%20Collins%20Street%20F5')%20AND%20postalCode%20NOT%20CONTAINS%20('3000')%20AND%20stateCounty%20EQUALS%20('AB'%2C'NULL'%2C'CA'%2C'NJ'%2C'NY'%2C'VIC'))&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,country,buildingName,city,floor,locationName,postalCode,stateCounty&$association=(etd)'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("User creates \'List_DAS18859\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("\"List_DAS18859\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1491 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table1491.AddRow(new string[] {
                            "Device Country"});
                table1491.AddRow(new string[] {
                            "Device Building"});
                table1491.AddRow(new string[] {
                            "Device City"});
                table1491.AddRow(new string[] {
                            "Device Floor"});
#line 31
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table1491, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1492 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table1492.AddRow(new string[] {
                            "Device Location Name"});
                table1492.AddRow(new string[] {
                            "Device Postal Code"});
#line 37
 testRunner.When("User selects the following Columns on Pivot:", ((string)(null)), table1492, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1493 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1493.AddRow(new string[] {
                            "Device Region"});
                table1493.AddRow(new string[] {
                            "Device State County"});
#line 41
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table1493, "When ");
#line hidden
#line 45
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.When("User creates Pivot list with \"Pivot_DAS18859\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("\"Pivot_DAS18859\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("User navigates to the \"List_DAS18859\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.When("User removes \"Device Postal Code\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("\'(Edited)\' prefix for active list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.Then("\'SAVE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_CheckThatListWithAllDeviceOsFiltersCanBeCreated")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Associations")]
        [NUnit.Framework.CategoryAttribute("DAS18467")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_ApplicationsList_CheckThatListWithAllDeviceOsFiltersCanBeCreated()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_ApplicationsList_CheckThatListWithAllDeviceOsFiltersCanBeCreatedInternal();
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

        private void EvergreenJnr_ApplicationsList_CheckThatListWithAllDeviceOsFiltersCanBeCreatedInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Associations",
                    "DAS18467",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckThatListWithAllDeviceOsFiltersCanBeCreated", null, new string[] {
                        "Evergreen",
                        "Associations",
                        "DAS18467",
                        "Cleanup"});
#line 57
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
#line 58
 testRunner.When(@"User navigates to 'deviceapplications?$filter=(oSCategory%20NOT%20EQUALS%20('NULL')%20AND%20oSArchitecture%20EQUALS%20('64')%20AND%20oSName%20NOT%20EQUALS%20('NULL')%20AND%20oSVersion%20EQUALS%20('Service%20Pack%204')%20AND%20oSServicePackName%20NOT%20EQUALS%20('NULL'%2C'No%20Service%20Pack'%2C'Service%20Pack%201')%20AND%20oSBranch%20EQUALS%20('NULL')%20AND%20oSServicingState%20EQUALS%20('Expired'%2C'NULL'%2C'Expire%20soon'%2C'Current'))&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,oSCategory,oSArchitecture,oSName,oSServicePackName,oSVersion,oSBranch,oSServicingState&$association=(etd)' url via address line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("table content is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then(@"URL contains 'deviceapplications?$filter=(oSCategory%20NOT%20EQUALS%20('NULL')%20AND%20oSArchitecture%20EQUALS%20('64')%20AND%20oSName%20NOT%20EQUALS%20('NULL')%20AND%20oSVersion%20EQUALS%20('Service%20Pack%204')%20AND%20oSServicePackName%20NOT%20EQUALS%20('NULL'%2C'No%20Service%20Pack'%2C'Service%20Pack%201')%20AND%20oSBranch%20EQUALS%20('NULL')%20AND%20oSServicingState%20EQUALS%20('Expired'%2C'NULL'%2C'Expire%20soon'%2C'Current'))&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,oSCategory,oSArchitecture,oSName,oSServicePackName,oSVersion,oSBranch,oSServicingState&$association=(etd)'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.When("User creates \'List_DAS18467\' dynamic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.Then("\"List_DAS18467\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When("User selects \'Pivot\' in the \'Create\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1494 = new TechTalk.SpecFlow.Table(new string[] {
                            "RowGroups"});
                table1494.AddRow(new string[] {
                            "Device OS Branch"});
                table1494.AddRow(new string[] {
                            "Device OS Architecture"});
                table1494.AddRow(new string[] {
                            "Device OS Full Name"});
#line 65
 testRunner.When("User selects the following Row Groups on Pivot:", ((string)(null)), table1494, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1495 = new TechTalk.SpecFlow.Table(new string[] {
                            "Columns"});
                table1495.AddRow(new string[] {
                            "Device OS Servicing State"});
                table1495.AddRow(new string[] {
                            "Device Operating System"});
#line 70
 testRunner.When("User selects the following Columns on Pivot:", ((string)(null)), table1495, "When ");
#line hidden
                TechTalk.SpecFlow.Table table1496 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table1496.AddRow(new string[] {
                            "Device Service Pack or Build"});
#line 74
 testRunner.When("User selects the following Values on Pivot:", ((string)(null)), table1496, "When ");
#line hidden
#line 77
 testRunner.When("User clicks \'RUN PIVOT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.When("User creates Pivot list with \"Pivot_DAS18467\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("\"Pivot_DAS18467\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.When("User navigates to the \"List_DAS18467\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.When("User removes \"Device OS Full Name\" column by Column panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
 testRunner.Then("\'(Edited)\' prefix for active list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.Then("\'SAVE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.When("User have removed \"Device OS Architecture\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.When("User clicks \'RUN LIST\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("\'(Edited)\' prefix for active list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.Then("\'SAVE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
