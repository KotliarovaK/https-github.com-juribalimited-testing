﻿// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ItemDetailsDisplay_Api", Description="\tRuns Item Details Display API related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ItemDetailsDisplay_Api.feature", SourceLine=0)]
    public partial class ItemDetailsDisplay_ApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetailsDisplay_Api.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetailsDisplay_Api", "\tRuns Item Details Display API related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
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
 testRunner.Given("User is logged in to the Evergreen via API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI(string pageName, string itemName, string sectionName, string fieldName, string displayState, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11478",
                    "DAS11477",
                    "DAS11476",
                    "API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI", null, @__tags);
#line 8
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
#line 9
 testRunner.When(string.Format("I perform test request to the \"{0}\" API and get \"{1}\" item summary for \"{2}\" sect" +
                            "ion", pageName, itemName, sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then(string.Format("\"{0}\" field display state is \"{1}\" on Details tab API", fieldName, displayState), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI, Variant 0", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11478",
                "DAS11477",
                "DAS11476",
                "API"}, SourceLine=13)]
        public virtual void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI_Variant0()
        {
#line 8
this.EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI("Mailboxes", "alfredo.m.daniel@dwlabs.local", "Mailbox", "Mailbox Database", "True", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI, Variant 1", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11478",
                "DAS11477",
                "DAS11476",
                "API"}, SourceLine=13)]
        public virtual void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI_Variant1()
        {
#line 8
this.EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI("Mailboxes", "alfredo.m.daniel@dwlabs.local", "Mailbox", "Cloud Mail Server", "False", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI, Variant 2", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11478",
                "DAS11477",
                "DAS11476",
                "API"}, SourceLine=13)]
        public virtual void EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI_Variant2()
        {
#line 8
this.EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI("Mailboxes", "alex.cristea@juriba.com", "Mailbox", "Mail Server", "False", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UserList_CheckThatDataDepartmentAndLocationTabIsDisplayedCorrectly", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS17274",
                "API"}, SourceLine=18)]
        public virtual void EvergreenJnr_UserList_CheckThatDataDepartmentAndLocationTabIsDisplayedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17274",
                    "API"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UserList_CheckThatDataDepartmentAndLocationTabIsDisplayedCorrectly", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17274",
                        "API"});
#line 19
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
#line 20
 testRunner.When("I perform test request to the \"Users\" API and get \"002B5DC7D4D34D5C895\" item summ" +
                        "ary for \"Department and Location\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3196 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "DisplayState"});
                table3196.AddRow(new string[] {
                            "Department Name",
                            "True"});
                table3196.AddRow(new string[] {
                            "Department Full Path",
                            "True"});
                table3196.AddRow(new string[] {
                            "Department Code",
                            "True"});
                table3196.AddRow(new string[] {
                            "Cost Centre",
                            "True"});
                table3196.AddRow(new string[] {
                            "Location Name",
                            "True"});
                table3196.AddRow(new string[] {
                            "Region",
                            "True"});
                table3196.AddRow(new string[] {
                            "Country",
                            "True"});
                table3196.AddRow(new string[] {
                            "City",
                            "True"});
                table3196.AddRow(new string[] {
                            "Building Name",
                            "True"});
                table3196.AddRow(new string[] {
                            "Floor",
                            "True"});
                table3196.AddRow(new string[] {
                            "Address 1",
                            "True"});
                table3196.AddRow(new string[] {
                            "Address 2",
                            "True"});
                table3196.AddRow(new string[] {
                            "Address 3",
                            "True"});
                table3196.AddRow(new string[] {
                            "Address 4",
                            "True"});
                table3196.AddRow(new string[] {
                            "State/County",
                            "True"});
                table3196.AddRow(new string[] {
                            "Postal Code",
                            "True"});
#line 21
 testRunner.Then("following fields are displayed with next state on Details tab API", ((string)(null)), table3196, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
