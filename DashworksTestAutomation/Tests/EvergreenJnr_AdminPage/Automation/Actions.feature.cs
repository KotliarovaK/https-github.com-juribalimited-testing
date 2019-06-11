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
namespace DashworksTestAutomation.Tests.EvergreenJnr_AdminPage.Automation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ActionsPage")]
    public partial class ActionsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Actions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ActionsPage", "\tRuns Actions Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Automations")]
        [NUnit.Framework.CategoryAttribute("Actions")]
        [NUnit.Framework.CategoryAttribute("DAS15427")]
        [NUnit.Framework.CategoryAttribute("DAS15832")]
        [NUnit.Framework.CategoryAttribute("DAS15833")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptionsInternal();
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

        private void EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptionsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Automations",
                        "Actions",
                        "DAS15427",
                        "DAS15832",
                        "DAS15833",
                        "Not_Ready"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 13
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User enters \"AM 030619 Devices 1\" text in the Search field for \"Automation\" colum" +
                    "n", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.When("User clicks content from \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("Edit Automation page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User clicks \"Actions\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.When("User clicks Cog-menu for \"AM 030619 Action 1\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table1.AddRow(new string[] {
                        "Edit"});
            table1.AddRow(new string[] {
                        "Move to top"});
            table1.AddRow(new string[] {
                        "Move to bottom"});
            table1.AddRow(new string[] {
                        "Move to position"});
            table1.AddRow(new string[] {
                        "Delete"});
#line 23
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table1, "Then ");
#line 31
 testRunner.When("User clicks Cog-menu for \"AM 030619 Action 2\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table2.AddRow(new string[] {
                        "Edit"});
            table2.AddRow(new string[] {
                        "Move to top"});
            table2.AddRow(new string[] {
                        "Move to bottom"});
            table2.AddRow(new string[] {
                        "Move to position"});
            table2.AddRow(new string[] {
                        "Delete"});
#line 32
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table2, "Then ");
#line 40
 testRunner.When("User clicks Cog-menu for \"15309_Action\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "items"});
            table3.AddRow(new string[] {
                        "Edit"});
            table3.AddRow(new string[] {
                        "Move to top"});
            table3.AddRow(new string[] {
                        "Move to bottom"});
            table3.AddRow(new string[] {
                        "Move to position"});
            table3.AddRow(new string[] {
                        "Delete"});
#line 41
 testRunner.Then("User sees following cog-menu items on Admin page:", ((string)(null)), table3, "Then ");
#line 48
 testRunner.When("User clicks \"Edit\" option in Cog-menu for \"AM 030619 Action 1\" item on Admin page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("Edit Action page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.Then("\"UPDATE\" Action button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.Then("\"CANCEL\" Action button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Actions")]
        [NUnit.Framework.CategoryAttribute("DAS15427")]
        [NUnit.Framework.CategoryAttribute("DAS15428")]
        [NUnit.Framework.CategoryAttribute("DAS16728")]
        [NUnit.Framework.CategoryAttribute("DAS16976")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectlyInternal();
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

        private void EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectly", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Actions",
                        "DAS15427",
                        "DAS15428",
                        "DAS16728",
                        "DAS16976",
                        "Not_Ready"});
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 57
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("User enters \"QA Automation Users\" text in the Search field for \"Automation\" colum" +
                    "n", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.When("User clicks content from \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.When("User clicks \"Actions\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("Actions dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("User clicks the \"CREATE ACTION\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("Create Action page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("User type \"DAS15427_Action\" Name in the \"Action Name\" field on the Automation det" +
                    "ails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.When("User selects \"Update path\" in the \"Action Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.When("User selects \"1803 Rollout\" in the Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.When("User selects \"Undetermined\" in the Path dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Then("Success message is displayed and contains \"The automation action has been created" +
                    "\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.When("User clicks \"Move to top\" option in Cog-menu for \"15309_Action\" item on Admin pag" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table4.AddRow(new string[] {
                        "15309_Action"});
            table4.AddRow(new string[] {
                        "AM 030619 Action 1"});
            table4.AddRow(new string[] {
                        "AM 030619 Action 2"});
            table4.AddRow(new string[] {
                        "DAS15427_Action"});
#line 74
 testRunner.Then("\"Action\" column content is displayed in the following order:", ((string)(null)), table4, "Then ");
#line 80
 testRunner.When("User clicks \"Move to bottom\" option in Cog-menu for \"15309_Action\" item on Admin " +
                    "page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table5.AddRow(new string[] {
                        "AM 030619 Action 1"});
            table5.AddRow(new string[] {
                        "AM 030619 Action 2"});
            table5.AddRow(new string[] {
                        "DAS15427_Action"});
            table5.AddRow(new string[] {
                        "15309_Action"});
#line 81
 testRunner.Then("\"Action\" column content is displayed in the following order:", ((string)(null)), table5, "Then ");
#line 87
 testRunner.When("User have opened column settings for \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("User select \"Processing order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("numeric data in \"Processing order\" column is sorted in ascending order by default" +
                    " on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.When("User move \"15309_Action\" item to \"4\" position on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table6.AddRow(new string[] {
                        "AM 030619 Action 1"});
            table6.AddRow(new string[] {
                        "AM 030619 Action 2"});
            table6.AddRow(new string[] {
                        "DAS15427_Action"});
            table6.AddRow(new string[] {
                        "15309_Action"});
#line 93
 testRunner.Then("\"Action\" column content is displayed in the following order:", ((string)(null)), table6, "Then ");
#line 99
 testRunner.When("User move \"15309_Action\" item to \"1\" position on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table7.AddRow(new string[] {
                        "15309_Action"});
            table7.AddRow(new string[] {
                        "AM 030619 Action 1"});
            table7.AddRow(new string[] {
                        "AM 030619 Action 2"});
            table7.AddRow(new string[] {
                        "DAS15427_Action"});
#line 100
 testRunner.Then("\"Action\" column content is displayed in the following order:", ((string)(null)), table7, "Then ");
#line 106
 testRunner.When("User move \"15309_Action\" item to \"20\" position on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table8.AddRow(new string[] {
                        "AM 030619 Action 1"});
            table8.AddRow(new string[] {
                        "AM 030619 Action 2"});
            table8.AddRow(new string[] {
                        "DAS15427_Action"});
            table8.AddRow(new string[] {
                        "15309_Action"});
#line 107
 testRunner.Then("\"Action\" column content is displayed in the following order:", ((string)(null)), table8, "Then ");
#line 113
 testRunner.When("User have opened column settings for \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("User select \"Processing order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.Then("numeric data in \"Processing order\" column is sorted in ascending order by default" +
                    " on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.When("User clicks \"Delete\" option in Cog-menu for \"DAS15427_Action\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.Then("Warning message with \"This action will be permanently deleted\" text is displayed " +
                    "on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.When("User clicks Cancel button in the warning message on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.When("User clicks \"Delete\" option in Cog-menu for \"DAS15427_Action\" item on Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.When("User clicks Delete button in the warning message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then("Success message is displayed and contains \"The selected action has been deleted\" " +
                    "text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Actions")]
        [NUnit.Framework.CategoryAttribute("DAS15428")]
        [NUnit.Framework.CategoryAttribute("DAS15938")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckActionsReorderingFunctionalityInternal();
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

        private void EvergreenJnr_AdminPage_CheckActionsReorderingFunctionalityInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Actions",
                        "DAS15428",
                        "DAS15938",
                        "Not_Ready"});
#line 128
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 129
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.When("User enters \"AM 110619 Devices\" text in the Search field for \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.When("User clicks content from \"Automation\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.When("User clicks \"Actions\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.When("User clicks the \"CREATE ACTION\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.Then("Create Action page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table9.AddRow(new string[] {
                        "Update path"});
#line 138
 testRunner.Then("following Values are displayed in \"Action Type\" drop-down on the Admin page:", ((string)(null)), table9, "Then ");
#line 141
 testRunner.When("User type \"15428_Action\" Name in the \"Action Name\" field on the Automation detail" +
                    "s page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
 testRunner.When("User selects \"Update path\" in the \"Action Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.When("User selects \"1803 Rollout\" in the Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.When("User selects \"[Default (Application)]\" in the Path dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 145
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.When("User moves \"15428_Action\" action to \"AM 030619 Mailbox Action 1\" action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.When("User have opened column settings for \"Action\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("User select \"Processing order\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.Then("numeric data in \"Processing order\" column is sorted in ascending order by default" +
                    " on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Items"});
            table10.AddRow(new string[] {
                        "AM 030619 Mailbox Action 1"});
            table10.AddRow(new string[] {
                        "15428_Action"});
            table10.AddRow(new string[] {
                        "AM 030619 Mailbox Action 2"});
            table10.AddRow(new string[] {
                        "AM 1"});
#line 152
 testRunner.Then("\"Action\" column content is displayed in the following order:", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table11.AddRow(new string[] {
                        "15428_Action"});
#line 158
 testRunner.When("User select \"Action\" rows in the grid", ((string)(null)), table11, "When ");
#line 161
 testRunner.And("User removes selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathAction")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("Actions")]
        [NUnit.Framework.CategoryAttribute("DAS15938")]
        [NUnit.Framework.CategoryAttribute("Not_Ready")]
        public virtual void EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathAction()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathActionInternal();
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

        private void EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathActionInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathAction", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "Actions",
                        "DAS15938",
                        "Not_Ready"});
#line 165
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 167
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.And("User add \"City\" filter where type is \"Equals\" with added column and \"Melbourne\" L" +
                    "ookup option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.And("User create dynamic list with \"Melbourne Users\" name on \"Users\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.And("User clicks Create Project from the main list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("\"Create Project\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.Then("Create Project button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
 testRunner.When("User enters \"Melbourne User Migration\" in the \"Project Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 175
 testRunner.Then("Create Project button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.When("User clicks Create button on the Create Project page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 177
 testRunner.Then("Success message is displayed and contains \"The project has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.When("User clicks \"Create Request Type\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 179
 testRunner.When("User clicks \"Projects\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 180
 testRunner.Then("\"Projects Home\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
 testRunner.When("User navigate to \"User Migration\" Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 182
 testRunner.Then("Project with \"User Migration\" name is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 183
 testRunner.And("\"Manage Project Details\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
 testRunner.When("User navigate to \"Request Types\" tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 185
 testRunner.Then("\"Manage Request Types\" page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 186
 testRunner.When("User clicks \"Create Request Type\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "ObjectTypeString"});
            table12.AddRow(new string[] {
                        "User Migration",
                        "DAS15938",
                        "User"});
#line 187
 testRunner.And("User create Request Type", ((string)(null)), table12, "And ");
#line 191
 testRunner.When("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 192
 testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.When("User clicks \"Automations\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 194
 testRunner.Then("\"Automations\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.When("User clicks the \"CREATE AUTOMATION\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 196
 testRunner.Then("Create Automation page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.When("User type \"Melbourne User\" Name in the \"Automation Name\" field on the Automation " +
                    "details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
 testRunner.When("User type \"Melbourne users\" Name in the \"Description\" field on the Automation det" +
                    "ails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 199
 testRunner.When("User selects \"Melbourne Users\" in the Scope Automation dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 200
 testRunner.When("User selects \"Stop on failed action\" checkbox on the Automation Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
 testRunner.Then("\"CREATE\" Action button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
 testRunner.When("User selects \"Manual\" in the \"Run\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 203
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
 testRunner.Then("Create Action page is displayed to the User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 205
 testRunner.When("User type \"Melbourne users\" Name in the \"Action Name\" field on the Automation det" +
                    "ails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 206
 testRunner.When("User selects \"Update path\" in the \"Action Type\" dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 207
 testRunner.When("User selects \"Melbourne User Migration\" in the Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 208
 testRunner.When("User selects \"User Migration\" in the Path dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 209
 testRunner.And("User clicks the \"CREATE\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 210
 testRunner.Then("Success message is displayed and contains \"The automation action has been created" +
                    "\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

