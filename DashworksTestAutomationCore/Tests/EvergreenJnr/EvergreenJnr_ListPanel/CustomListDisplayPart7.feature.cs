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
    [NUnit.Framework.DescriptionAttribute("CustomListDisplayPart7")]
    public partial class CustomListDisplayPart7Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomListDisplayPart7.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomListDisplayPart7", "\tRuns Custom List Creation block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingO" +
            "rRemovingColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS10972")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "Import", "Country", "Windows7Mi: Category", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "All Applications", "Application Key", "Compliance", "App field 2", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "City", "Description", "Floor", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "Alias", "Time Zone", "Building", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingOrRemovingColumns(string listName, string listLabel, string columnName, string newColumnName, string moreColumnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingOrRemovingColumnsInternal(listName,listLabel,columnName,newColumnName,moreColumnName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingOrRemovingColumnsInternal(string listName, string listLabel, string columnName, string newColumnName, string moreColumnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS10972"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingO" +
                    "rRemovingColumns", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("Columns panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3463 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3463.AddRow(new string[] {
                            string.Format("{0}", columnName)});
#line 14
 testRunner.When("User adds columns to the list", ((string)(null)), table3463, "When ");
#line hidden
#line 17
 testRunner.Then("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When(string.Format("User removes \"{0}\" column by Column panel", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3464 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3464.AddRow(new string[] {
                            string.Format("{0}", columnName)});
#line 20
 testRunner.When("User adds columns to the list", ((string)(null)), table3464, "When ");
#line hidden
#line 23
 testRunner.Then("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3465 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3465.AddRow(new string[] {
                            string.Format("{0}", newColumnName)});
#line 24
 testRunner.When("User adds columns to the list", ((string)(null)), table3465, "When ");
#line hidden
                TechTalk.SpecFlow.Table table3466 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3466.AddRow(new string[] {
                            string.Format("{0}", moreColumnName)});
#line 27
 testRunner.When("User adds columns to the list", ((string)(null)), table3466, "When ");
#line hidden
#line 30
 testRunner.Then("Save to New Custom List element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("User have reset all columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsHiddenAfterChangingPinnedColu" +
            "mns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS10972")]
        [NUnit.Framework.CategoryAttribute("DAS14183")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "Device Type", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "All Applications", "Vendor", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "Domain", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "Mailbox Platform", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsHiddenAfterChangingPinnedColumns(string listName, string listLabel, string columnName, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsHiddenAfterChangingPinnedColumnsInternal(listName,listLabel,columnName,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsHiddenAfterChangingPinnedColumnsInternal(string listName, string listLabel, string columnName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS10972",
                    "DAS14183"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsHiddenAfterChangingPinnedColu" +
                    "mns", null, @__tags);
#line 42
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
#line 43
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When(string.Format("User opens \'{0}\' column settings", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.When("User selects \'Pin left\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When(string.Format("User opens \'{0}\' column settings", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.When("User selects \'Pin right\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When(string.Format("User opens \'{0}\' column settings", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When("User selects \'No pin\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.Then("Save to New Custom List element is NOT displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomLis" +
            "tsAfterAddingOrRemovingColumns")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS10972")]
        [NUnit.Framework.CategoryAttribute("DAS12738")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "Hostname", "Import", "001BAQXT6JWFPI", "Network Card", "Owner City", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "All Applications", "Application", "Application Key", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "prK: In Scope", "Compliance", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "Username", "City", "$6BE000-SUDQ9614UVO8", "Cost Centre", "Department Name", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "Email Address", "Alias", "000F977AC8824FE39B8@bclabs.local", "Enabled", "Import", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomListsAfterAddingOrRemovingColumns(string listName, string listLabel, string columnName, string newColumnName, string selectedItem, string addColumnName, string addAnotherColumn, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomListsAfterAddingOrRemovingColumnsInternal(listName,listLabel,columnName,newColumnName,selectedItem,addColumnName,addAnotherColumn,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomListsAfterAddingOrRemovingColumnsInternal(string listName, string listLabel, string columnName, string newColumnName, string selectedItem, string addColumnName, string addAnotherColumn, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS10972",
                    "DAS12738",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomLis" +
                    "tsAfterAddingOrRemovingColumns", null, @__tags);
#line 66
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
#line 67
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.When(string.Format("User create dynamic list with \"DynamicList\" name on \"{0}\" page", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3467 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3467.AddRow(new string[] {
                            string.Format("{0}", newColumnName)});
#line 73
 testRunner.And("User adds columns to the list", ((string)(null)), table3467, "And ");
#line hidden
#line 76
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3468 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3468.AddRow(new string[] {
                            string.Format("{0}", addColumnName)});
                table3468.AddRow(new string[] {
                            string.Format("{0}", addAnotherColumn)});
#line 77
 testRunner.When("User adds columns to the list", ((string)(null)), table3468, "When ");
#line hidden
#line 81
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 82
 testRunner.When("User have reset all columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3469 = new TechTalk.SpecFlow.Table(new string[] {
                            "ItemName"});
                table3469.AddRow(new string[] {
                            string.Format("{0}", selectedItem)});
#line 84
 testRunner.When(string.Format("User create static list with \"StaticList\" name on \"{0}\" page with following items" +
                            "", listName), ((string)(null)), table3469, "When ");
#line hidden
#line 87
 testRunner.When("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3470 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3470.AddRow(new string[] {
                            string.Format("{0}", newColumnName)});
#line 88
 testRunner.And("User adds columns to the list", ((string)(null)), table3470, "And ");
#line hidden
#line 91
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3471 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3471.AddRow(new string[] {
                            string.Format("{0}", addColumnName)});
                table3471.AddRow(new string[] {
                            string.Format("{0}", addAnotherColumn)});
#line 92
 testRunner.When("User adds columns to the list", ((string)(null)), table3471, "When ");
#line hidden
#line 96
 testRunner.Then("Edit List menu is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.When("User have reset all columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRe" +
            "movingSearchCriteria")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListPanel")]
        [NUnit.Framework.CategoryAttribute("CustomListDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS10998")]
        [NUnit.Framework.CategoryAttribute("DAS10972")]
        [NUnit.Framework.CategoryAttribute("DAS12602")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("Devices", "All Devices", "Hostname", "Centre", "3,283", "18", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "All Users", "Username", "Barland", "3", "142", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "All Applications", "Application", "Adobe", "40", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "All Mailboxes", "Email Address", "bc-exch07", "4,188", "73", null)]
        public virtual void EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRemovingSearchCriteria(string listName, string listLabel, string columnName, string search, string rows, string newRows, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRemovingSearchCriteriaInternal(listName,listLabel,columnName,search,rows,newRows,exampleTags);
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

        private void EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRemovingSearchCriteriaInternal(string listName, string listLabel, string columnName, string search, string rows, string newRows, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListPanel",
                    "CustomListDisplay",
                    "DAS10998",
                    "DAS10972",
                    "DAS12602",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRe" +
                    "movingSearchCriteria", null, @__tags);
#line 108
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
#line 109
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.When(string.Format("User clicks on \'{0}\' column header", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.Then(string.Format("data in table is sorted by \'{0}\' column in ascending order", columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 113
 testRunner.When(string.Format("User create dynamic list with \"DynamicList2\" name on \"{0}\" page", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3472 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table3472.AddRow(new string[] {
                            string.Format("{0}", search),
                            string.Format("{0}", rows)});
#line 114
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table3472, "Then ");
#line hidden
#line 117
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.Then("\"DynamicList2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3473 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table3473.AddRow(new string[] {
                            "Mary",
                            string.Format("{0}", newRows)});
#line 119
 testRunner.And("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table3473, "And ");
#line hidden
#line 122
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 123
 testRunner.Then("\"DynamicList2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 124
 testRunner.And("Clearing the agGrid Search Box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 125
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 126
 testRunner.Then("\"DynamicList2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.Then(string.Format("\'{0}\' list should be displayed to the user", listLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.When("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.When("User selects all rows on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 132
 testRunner.And("User selects \'Create static list\' in the \'Action\' dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 133
 testRunner.When("User create static list with \"StaticList2\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3474 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table3474.AddRow(new string[] {
                            string.Format("{0}", search),
                            string.Format("{0}", rows)});
#line 134
 testRunner.Then("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table3474, "Then ");
#line hidden
#line 137
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.And("\"StaticList2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3475 = new TechTalk.SpecFlow.Table(new string[] {
                            "SearchCriteria",
                            "NumberOfRows"});
                table3475.AddRow(new string[] {
                            "Mary",
                            string.Format("{0}", newRows)});
#line 139
 testRunner.And("User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRow" +
                        "s are returned", ((string)(null)), table3475, "And ");
#line hidden
#line 142
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 143
 testRunner.And("\"StaticList2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.And("Clearing the agGrid Search Box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.Then("Edit List menu is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 146
 testRunner.And("\"StaticList2\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
