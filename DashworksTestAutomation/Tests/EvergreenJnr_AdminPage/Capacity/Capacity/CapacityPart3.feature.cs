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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Capacity.Capacity
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CapacityPart3")]
    public partial class CapacityPart3Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CapacityPart3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CapacityPart3", "\tRuns Capacity related tests on Admin page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDiff" +
            "erentProject")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS13166")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProject()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProjectInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProjectInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDiff" +
                    "erentProject", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Units",
                        "DAS13166",
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
                        "ProjectForDAS13945",
                        "All Mailboxes",
                        "None",
                        "Standalone Project"});
#line 10
 testRunner.When("Project created via API and opened", ((string)(null)), table1, "When ");
#line 13
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("User selects \"Units\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("User clicks \'CREATE PROJECT CAPACITY UNIT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User enters \'Manchester\' text to \'Capacity Unit Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User enters \'Manchester Operations\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("Success message is displayed and contains \"The capacity unit has been created\" te" +
                    "xt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("Counter shows \"2\" found rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Units")]
        [NUnit.Framework.CategoryAttribute("DAS13945")]
        [NUnit.Framework.CategoryAttribute("DAS12672")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpaceInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpaceInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "Units",
                        "DAS13945",
                        "DAS12672",
                        "Cleanup"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table2.AddRow(new string[] {
                        "ProjectForDAS13945",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 25
 testRunner.When("Project created via API and opened", ((string)(null)), table2, "When ");
#line 28
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User selects \"Units\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User clicks \'CREATE PROJECT CAPACITY UNIT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("User enters \' test1\' text to \'Capacity Unit Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User enters \'13945\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("Error message is not displayed on the Capacity Units page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "units"});
            table3.AddRow(new string[] {
                        "Unassigned"});
            table3.AddRow(new string[] {
                        "test1"});
#line 35
 testRunner.And("User sees next Units on the Capacity Units page:", ((string)(null)), table3, "And ");
#line 39
 testRunner.When("User selects \"Units\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("User clicks \'CREATE PROJECT CAPACITY UNIT\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User enters \' test1\' text to \'Capacity Unit Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User enters \'13945_2\' text to \'Description\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("Error message with \"A capacity unit already exists with this name\" text is displa" +
                    "yed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "units"});
            table4.AddRow(new string[] {
                        "Unassigned"});
            table4.AddRow(new string[] {
                        "test1"});
#line 45
 testRunner.And("User sees next Units on the Capacity Units page:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnits")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("DAS13159")]
        [NUnit.Framework.CategoryAttribute("DAS13754")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnits()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnitsInternal();
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

        private void EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnitsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnits", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Capacity",
                        "DAS13159",
                        "DAS13754",
                        "Cleanup"});
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table5.AddRow(new string[] {
                        "13159ProjectForCapacity",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 52
 testRunner.When("Project created via API and opened", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "IsDefault",
                        "Project"});
            table6.AddRow(new string[] {
                        "CapacityUnit13790",
                        "",
                        "false",
                        "13159ProjectForCapacity"});
            table6.AddRow(new string[] {
                        "NewUnit",
                        "",
                        "false",
                        "13159ProjectForCapacity"});
            table6.AddRow(new string[] {
                        "13159",
                        "",
                        "false",
                        "13159ProjectForCapacity"});
            table6.AddRow(new string[] {
                        "A13159Unit",
                        "",
                        "false",
                        "13159ProjectForCapacity"});
#line 55
 testRunner.And("User creates new Capacity Unit via api", ((string)(null)), table6, "And ");
#line 61
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User selects \"Units\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table7.AddRow(new string[] {
                        "Unassigned"});
            table7.AddRow(new string[] {
                        "13159"});
            table7.AddRow(new string[] {
                        "A13159Unit"});
            table7.AddRow(new string[] {
                        "CapacityUnit13790"});
            table7.AddRow(new string[] {
                        "NewUnit"});
#line 63
 testRunner.Then("\"Capacity Unit\" column content is displayed in the following order:", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUn" +
            "its")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("AdminPage")]
        [NUnit.Framework.CategoryAttribute("Capacity")]
        [NUnit.Framework.CategoryAttribute("Senior_Projects")]
        [NUnit.Framework.CategoryAttribute("DAS14029")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnits()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnitsInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnitsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUn" +
                    "its", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "AdminPage",
                        "Capacity",
                        "Senior_Projects",
                        "DAS14029",
                        "Cleanup"});
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 73
 testRunner.When("User clicks \'Projects\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.When("User clicks create Project button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("\"Create Project\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "ShortName",
                        "Description",
                        "Type"});
            table8.AddRow(new string[] {
                        "Project14029 Snr",
                        "13498",
                        "",
                        ""});
#line 77
 testRunner.When("User creates new Project on Senior", ((string)(null)), table8, "When ");
#line 80
 testRunner.And("User navigate to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("User navigates to \"Project14029 Snr\" project details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("User selects \"Capacity Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.Then("Capacity Units value is displayed for Capacity Mode field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProjectName",
                        "Scope",
                        "ProjectTemplate",
                        "Mode"});
            table9.AddRow(new string[] {
                        "Project14029",
                        "All Devices",
                        "None",
                        "Standalone Project"});
#line 86
 testRunner.When("Project created via API and opened", ((string)(null)), table9, "When ");
#line 89
 testRunner.And("User navigates to the \'Capacity\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User selects \"Capacity Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("Capacity Units value is displayed for Capacity Mode field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

