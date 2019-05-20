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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.CapacityUnits
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateCapacityUnit")]
    public partial class CreateCapacityUnitFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateCapacityUnit.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateCapacityUnit", "\tCreate Capacity Unit", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS12632")]
        [NUnit.Framework.CategoryAttribute("DAS13626")]
        [NUnit.Framework.CategoryAttribute("DAS14236")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_Capacity_Unit")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectlyInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12632",
                        "DAS13626",
                        "DAS14236",
                        "Delete_Newly_Created_Capacity_Unit"});
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
 testRunner.When("User clicks \"Capacity Units\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("\"Capacity Units\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("User clicks the \"CREATE EVERGREEN CAPACITY UNIT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("User type \"NotDefaultCapacityUnit13720\" Name in the \"Capacity Unit Name\" field on" +
                    " the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("User type \"13720\" Name in the \"Description\" field on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("Success message is displayed and contains \"The capacity unit has been created\" te" +
                    "xt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("Success message is displayed and contains \"Click here to view the NotDefaultCapac" +
                    "ityUnit13720 capacity unit\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("\"NotDefaultCapacityUnit13720\" text is displayed in the table content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("User enters \"NotDefaultCapacityUnit13720\" text in the Search field for \"Capacity " +
                    "Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("\"FALSE\" value is displayed for Default column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("\"\" content is displayed in \"Devices\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("\"\" content is displayed in \"Users\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("\"\" content is displayed in \"Mailboxes\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("\"\" content is displayed in \"Applications\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table1.AddRow(new string[] {
                        "NotDefaultCapacityUnit13720"});
#line 28
 testRunner.When("User select \"Capacity Unit\" rows in the grid", ((string)(null)), table1, "When ");
#line 31
 testRunner.And("User clicks on Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User selects \"Delete\" in the Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("Warning message with \"This unit will be permanently deleted and any objects withi" +
                    "n it reassigned to the default unit\" text is displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Then("Delete and Cancel buttons are available in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("Success message is displayed and contains \"The selected unit has been deleted\" te" +
                    "xt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS12632")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_Capacity_Unit")]
        [NUnit.Framework.CategoryAttribute("Do_Not_Run_With_CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("Set_Default_Capacity_Unit")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectlyInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS12632",
                        "Delete_Newly_Created_Capacity_Unit",
                        "Do_Not_Run_With_CapacityUnits",
                        "Set_Default_Capacity_Unit"});
#line 40
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 41
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "IsDefault"});
            table2.AddRow(new string[] {
                        "DefaultCapacityUnit13720",
                        "13720",
                        "true"});
#line 43
 testRunner.When("User creates new Capacity Unit via api", ((string)(null)), table2, "When ");
#line 46
 testRunner.And("User clicks \"Capacity Units\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("\"DefaultCapacityUnit13720\" text is displayed in the table content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.When("User enters \"DefaultCapacityUnit13720\" text in the Search field for \"Capacity Uni" +
                    "t\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("\"TRUE\" value is displayed for Default column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.And("\"\" content is displayed in \"Devices\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("\"\" content is displayed in \"Users\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("\"\" content is displayed in \"Mailboxes\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("\"\" content is displayed in \"Applications\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("User enters \"Unassigned\" text in the Search field for \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\"FALSE\" value is displayed for Default column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("User enters \"DefaultCapacityUnit13720\" text in the Search field for \"Capacity Uni" +
                    "t\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table3.AddRow(new string[] {
                        "DefaultCapacityUnit13720"});
#line 57
 testRunner.And("User select \"Capacity Unit\" rows in the grid", ((string)(null)), table3, "And ");
#line 60
 testRunner.And("User clicks on Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("User selects \"Delete\" in the Actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User clicks Delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.Then("Warning message with \"You cannot delete the default unit\" text is displayed on th" +
                    "e Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.When("User close message on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("\"DefaultCapacityUnit13720\" text is displayed in the table content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.When("User enters \"DefaultCapacityUnit13720\" text in the Search field for \"Capacity Uni" +
                    "t\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.And("User clicks content from \"Capacity Unit\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("User selects \"Evergreen Capacity Unit Settings\" tab on the Capacity Units page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("\"Default Unit\" checkbox is checked and cannot be unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameName" +
            "InDifferentCase")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("CapacityUnits")]
        [NUnit.Framework.CategoryAttribute("DAS13013")]
        [NUnit.Framework.CategoryAttribute("DAS12926")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_Capacity_Unit")]
        public virtual void EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameNameInDifferentCase()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameNameInDifferentCaseInternal();
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

        private void EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameNameInDifferentCaseInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameName" +
                    "InDifferentCase", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "CapacityUnits",
                        "DAS13013",
                        "DAS12926",
                        "Delete_Newly_Created_Capacity_Unit"});
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 73
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "IsDefault"});
            table4.AddRow(new string[] {
                        "SameNameCaseSensative",
                        "SameNameCaseSensative",
                        "false"});
#line 74
 testRunner.And("User creates new Capacity Unit via api", ((string)(null)), table4, "And ");
#line 77
 testRunner.And("User clicks \"Capacity Units\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.When("User clicks the \"CREATE EVERGREEN CAPACITY UNIT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.And("User type \"samenamecaseSensative\" Name in the \"Capacity Unit Name\" field on the P" +
                    "roject details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("User type \"SameNameCaseSensative\" Name in the \"Description\" field on the Project " +
                    "details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("Error message with \"A capacity unit already exists with this name\" text is displa" +
                    "yed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

