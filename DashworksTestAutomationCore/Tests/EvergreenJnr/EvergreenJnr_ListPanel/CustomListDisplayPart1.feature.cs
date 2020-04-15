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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ListPanel
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CustomListDisplayPart1")]
    public partial class CustomListDisplayPart1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomListDisplayPart1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart1", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeleti" +
            "ngAFilterInDefaultList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11003")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        public virtual void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInDefaultList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInDefaultListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInDefaultListInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS11003",
                    "DAS12351"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeleti" +
                    "ngAFilterInDefaultList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS11003",
                        "DAS12351"});
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
                TechTalk.SpecFlow.Table table3369 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3369.AddRow(new string[] {
                            "Empty"});
#line 14
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" without added colum" +
                        "n and following checkboxes:", ((string)(null)), table3369, "When ");
#line hidden
#line 17
 testRunner.Then("\"Windows7Mi: Category\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User have removed \"Windows7Mi: Category\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenReseti" +
            "ngAFilterInDefaultList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11003")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        public virtual void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInDefaultList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInDefaultListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInDefaultListInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS11003",
                    "DAS12351"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenReseti" +
                    "ngAFilterInDefaultList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS11003",
                        "DAS12351"});
#line 22
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
#line 23
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3370 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3370.AddRow(new string[] {
                            "Empty"});
#line 27
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" without added colum" +
                        "n and following checkboxes:", ((string)(null)), table3370, "When ");
#line hidden
#line 30
 testRunner.Then("\"Windows7Mi: Category\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User have reset all filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeleti" +
            "ngAFilterInCustomList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11017")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInCustomList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInCustomListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInCustomListInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS11017",
                    "DAS12351",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeleti" +
                    "ngAFilterInCustomList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS11017",
                        "DAS12351",
                        "Cleanup"});
#line 35
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
#line 36
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3371 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3371.AddRow(new string[] {
                            "Empty"});
#line 40
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" without added colum" +
                        "n and following checkboxes:", ((string)(null)), table3371, "When ");
#line hidden
#line 43
 testRunner.Then("\"Windows7Mi: Category\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.When("User create dynamic list with \"TestListF20A85\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("\"TestListF20A85\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3372 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3372.AddRow(new string[] {
                            "Generic"});
#line 48
 testRunner.When("User add \"Directory Type\" filter where type is \"Equals\" without added column and " +
                        "following checkboxes:", ((string)(null)), table3372, "When ");
#line hidden
#line 51
 testRunner.Then("\"Directory Type\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.When("User have removed \"Windows7Mi: Category\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("User have removed \"Directory Type\" filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenReseti" +
            "ngAFilterInCustomList")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS11017")]
        [NUnit.Framework.CategoryAttribute("DAS12351")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInCustomList()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInCustomListInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInCustomListInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS11017",
                    "DAS12351",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenReseti" +
                    "ngAFilterInCustomList", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ListPanel",
                        "CustomListDisplay",
                        "DAS11017",
                        "DAS12351",
                        "Cleanup"});
#line 58
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
#line 59
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3373 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3373.AddRow(new string[] {
                            "Empty"});
#line 63
 testRunner.When("User add \"Windows7Mi: Category\" filter where type is \"Equals\" without added colum" +
                        "n and following checkboxes:", ((string)(null)), table3373, "When ");
#line hidden
#line 66
 testRunner.Then("\"Windows7Mi: Category\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("User create dynamic list with \"TestListE63B7D\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then("\"TestListE63B7D\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3374 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3374.AddRow(new string[] {
                            "Generic"});
#line 71
 testRunner.When("User add \"Directory Type\" filter where type is \"Equals\" without added column and " +
                        "following checkboxes:", ((string)(null)), table3374, "When ");
#line hidden
#line 74
 testRunner.Then("\"Directory Type\" filter is added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.When("User have reset all filters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
