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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ListPanel
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CustomListDisplayPart11")]
    public partial class CustomListDisplayPart11Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CustomListDisplayPart11.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart11", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13637")]
        [NUnit.Framework.CategoryAttribute("DAS13640")]
        [NUnit.Framework.CategoryAttribute("DAS13643")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectlyInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectly", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS13637",
                        "DAS13640",
                        "DAS13643",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table1.AddRow(new string[] {
                        "001BAQXT6JWFPI"});
            table1.AddRow(new string[] {
                        "001PSUMZYOW581"});
#line 12
 testRunner.When("User create static list with \"StaticFilterList_2\" name on \"Devices\" page with fol" +
                    "lowing items", ((string)(null)), table1, "When ");
#line 16
 testRunner.Then("\"StaticFilterList_2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.When("User click on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.When("User create dynamic list with \"DynamicFilterList_2\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("\"DynamicFilterList_2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table2.AddRow(new string[] {
                        "Application Compliance"});
#line 22
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table3.AddRow(new string[] {
                        "Operating System"});
#line 25
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table4.AddRow(new string[] {
                        "App Count (Entitled)"});
#line 28
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table4, "And ");
#line 31
 testRunner.When("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("User creates Pivot list with \"PivotDynamicFilterList_2\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("\"PivotDynamicFilterList_2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table5.AddRow(new string[] {
                        "Build Date"});
#line 37
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table6.AddRow(new string[] {
                        "Application Compliance"});
#line 40
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table7.AddRow(new string[] {
                        "Owner General information field 1"});
#line 43
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table7, "And ");
#line 46
 testRunner.When("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.When("User creates Pivot list with \"PivotFilterList_2\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("\"PivotFilterList_2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.When("User apply \"Standard\" filter to lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("\"DynamicFilterList_2\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.And("\"StaticFilterList_2\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("\"PivotDynamicFilterList_2\" list is not displayed in the bottom section of the Lis" +
                    "t Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("\"PivotFilterList_2\" list is not displayed in the bottom section of the List Panel" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.When("User enters \"2\" text in Search field at List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("\"DynamicFilterList_2\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.And("\"StaticFilterList_2\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("\"PivotDynamicFilterList_2\" list is not displayed in the bottom section of the Lis" +
                    "t Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("\"PivotFilterList_2\" list is not displayed in the bottom section of the List Panel" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.When("User apply \"Pivot\" filter to lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("\"DynamicFilterList_2\" list is not displayed in the bottom section of the List Pan" +
                    "el", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.And("\"StaticFilterList_2\" list is not displayed in the bottom section of the List Pane" +
                    "l", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("\"PivotDynamicFilterList_2\" list is displayed in the bottom section of the List Pa" +
                    "nel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("\"PivotFilterList_2\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("User enters \"2\" text in Search field at List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("\"DynamicFilterList_2\" list is not displayed in the bottom section of the List Pan" +
                    "el", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.And("\"StaticFilterList_2\" list is not displayed in the bottom section of the List Pane" +
                    "l", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("\"PivotDynamicFilterList_2\" list is displayed in the bottom section of the List Pa" +
                    "nel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("\"PivotFilterList_2\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13637")]
        [NUnit.Framework.CategoryAttribute("DAS13643")]
        public virtual void EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectlyInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectly", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS13637",
                        "DAS13643"});
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 74
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("User apply \"Not favourite\" filter to lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("\"1803 Rollout\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User apply \"Favourite\" filter to lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("\"1803 Rollout\" list is not displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.When("User enters \"1803\" text in Search field at List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("\"1803 Rollout\" list is not displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectly")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS13637")]
        [NUnit.Framework.CategoryAttribute("DAS13643")]
        public virtual void EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectly()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectlyInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectlyInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectly", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS13637",
                        "DAS13643"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 85
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.When("User apply \"Shared with me \" filter to lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("\"1803 Rollout\" list is displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("User apply \"Owned by me \" filter to lists panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.Then("\"1803 Rollout\" list is not displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.When("User enters \"1803\" text in Search field at List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.Then("\"1803 Rollout\" list is not displayed in the bottom section of the List Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17627")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettingsInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettingsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS17627",
                        "Cleanup"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 96
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemName"});
            table8.AddRow(new string[] {
                        "001BAQXT6JWFPI"});
            table8.AddRow(new string[] {
                        "001PSUMZYOW581"});
#line 98
 testRunner.When("User create static list with \"StaticFilterList_1\" name on \"Devices\" page with fol" +
                    "lowing items", ((string)(null)), table8, "When ");
#line 102
 testRunner.Then("\"StaticFilterList_1\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User navigates to the \"All Devices\" list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.When("User click on \'Hostname\' column header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.When("User create dynamic list with \"DynamicFilterList_1\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.Then("\"DynamicFilterList_1\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table9.AddRow(new string[] {
                        "Hostname"});
#line 108
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table10.AddRow(new string[] {
                        "Hostname"});
#line 111
 testRunner.And("User selects the following Columns on Pivot:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table11.AddRow(new string[] {
                        "Hostname"});
#line 114
 testRunner.And("User selects the following Values on Pivot:", ((string)(null)), table11, "And ");
#line 117
 testRunner.When("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.And("User removes \"Hostname\" Column for Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table12.AddRow(new string[] {
                        "Floor"});
#line 119
 testRunner.And("User selects the following Row Groups on Pivot:", ((string)(null)), table12, "And ");
#line 122
 testRunner.When("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

