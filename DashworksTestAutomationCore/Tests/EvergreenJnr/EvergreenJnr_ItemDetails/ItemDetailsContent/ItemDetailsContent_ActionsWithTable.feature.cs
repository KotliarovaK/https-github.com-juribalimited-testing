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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ItemDetailsContent_ActionsWithTable", Description="\tRuns Item Details Content Actions With Table related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\ItemDetailsContent\\ItemDetailsContent" +
        "_ActionsWithTable.feature", SourceLine=0)]
    public partial class ItemDetailsContent_ActionsWithTableFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetailsContent_ActionsWithTable.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetailsContent_ActionsWithTable", "\tRuns Item Details Content Actions With Table related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
 testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage(string pageName, string selectedName, string countRows, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11091",
                    "DAS14923",
                    "DAS16121",
                    "DAS17305",
                    "Zion_NewGrid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssue" +
                    "sSectionOnTheDetailsPage", null, @__tags);
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
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, selectedName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", selectedName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("User navigates to the \'Compliance\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And("User navigates to the \'Application Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3187 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnHeader"});
                table3187.AddRow(new string[] {
                            "RED"});
                table3187.AddRow(new string[] {
                            "AMBER"});
                table3187.AddRow(new string[] {
                            "GREEN"});
                table3187.AddRow(new string[] {
                            "UNKNOWN"});
                table3187.AddRow(new string[] {
                            "IGNORE"});
#line 14
 testRunner.Then("Name of colors are displayed in following order on the Details Page:", ((string)(null)), table3187, "Then ");
#line hidden
#line 21
 testRunner.When("User navigates to the \'Application Issues\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then(string.Format("\"{0}\" rows found label displays on Details Page", countRows), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("\"Manufacturer\" column is not displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3188 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3188.AddRow(new string[] {
                            "Vendor"});
#line 24
 testRunner.And("following columns added to the table:", ((string)(null)), table3188, "And ");
#line hidden
#line 27
 testRunner.Then("string filter is displayed for \'Vendor\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssue" +
            "sSectionOnTheDetailsPage, Device", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11091",
                "DAS14923",
                "DAS16121",
                "DAS17305",
                "Zion_NewGrid"}, SourceLine=30)]
        public virtual void EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage_Device()
        {
#line 9
this.EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage("Device", "001BAQXT6JWFPI", "2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssue" +
            "sSectionOnTheDetailsPage, User", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11091",
                "DAS14923",
                "DAS16121",
                "DAS17305",
                "Zion_NewGrid"}, SourceLine=30)]
        public virtual void EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage_User()
        {
#line 9
this.EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage("User", "EKS951231", "4", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField(string pageName, string searchTerm, string tabName, string selectedColumn, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11762",
                    "DAS12235",
                    "DAS13813",
                    "DAS14923",
                    "Zion_NewGrid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilte" +
                    "rTextField", null, @__tags);
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
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", tabName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And(string.Format("User opens \'{0}\' column settings", selectedColumn), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("User clicks Filter button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.When("User enters \"123455465\" text in the Filter field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.When("User clears Filter field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilte" +
            "rTextField, Device", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11762",
                "DAS12235",
                "DAS13813",
                "DAS14923",
                "Zion_NewGrid"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField_Device()
        {
#line 35
this.EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField("Device", "30BGMTLBM9PTW5", "Applications", "Application", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilte" +
            "rTextField, Application", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11762",
                "DAS12235",
                "DAS13813",
                "DAS14923",
                "Zion_NewGrid"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField_Application()
        {
#line 35
this.EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField("Application", "Microsoft Office Visio 2000 Solutions - Custom Patterns", "MSI", "File Name", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilte" +
            "rTextField, Mailbox", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11762",
                "DAS12235",
                "DAS13813",
                "DAS14923",
                "Zion_NewGrid"}, SourceLine=46)]
        public virtual void EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField_Mailbox()
        {
#line 35
this.EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField("Mailbox", "aaron.u.flores@dwlabs.local", "Users", "Username", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn(string subMenuName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS11647",
                    "Zion_NewGrid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn", null, @__tags);
#line 52
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
#line 53
 testRunner.When("User navigates to the \'Device\' details page for \'30BGMTLBM9PTW5\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("Details page for \'30BGMTLBM9PTW5\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.When(string.Format("User navigates to the \'{0}\' left submenu item", subMenuName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("\"87\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.When("User opens \'Site\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.And("User selects \'Autosize this column\' option from column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then("Site column has standard size", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn, Adve" +
            "rtisements", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11647",
                "Zion_NewGrid"}, SourceLine=63)]
        public virtual void EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn_Advertisements()
        {
#line 52
this.EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn("Advertisements", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn, Coll" +
            "ections", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS11647",
                "Zion_NewGrid"}, SourceLine=63)]
        public virtual void EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn_Collections()
        {
#line 52
this.EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn("Collections", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages(string pageName, string searchTerm, string mainTab, string subTab, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "ALlLists",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS12491",
                    "DAS14923",
                    "Zion_NewGrid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages", null, @__tags);
#line 68
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
#line 69
 testRunner.When(string.Format("User navigates to the \'{0}\' details page for \'{1}\' item", pageName, searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then(string.Format("Details page for \'{0}\' item is displayed to the user", searchTerm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.When(string.Format("User navigates to the \'{0}\' left menu item", mainTab), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.And(string.Format("User navigates to the \'{0}\' left submenu item", subTab), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("\"1\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages, Appl" +
            "ication", new string[] {
                "Evergreen",
                "ALlLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS12491",
                "DAS14923",
                "Zion_NewGrid"}, SourceLine=76)]
        public virtual void EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages_Application()
        {
#line 68
this.EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages("Application", "IEWatch 2.1", "MSI", "MSI Files", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages, User" +
            "", new string[] {
                "Evergreen",
                "ALlLists",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS12491",
                "DAS14923",
                "Zion_NewGrid"}, SourceLine=76)]
        public virtual void EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages_User()
        {
#line 68
this.EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages("User", "01A921EFD05545818AA", "Mailboxes", "Mailboxes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSumma" +
            "rySection", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16009",
                "DAS15951",
                "DAS20748",
                "Zion_NewGrid"}, SourceLine=80)]
        public virtual void EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSummarySection()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16009",
                    "DAS15951",
                    "DAS20748",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSumma" +
                    "rySection", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16009",
                        "DAS15951",
                        "DAS20748",
                        "Zion_NewGrid"});
#line 81
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
#line 82
 testRunner.When("User navigates to the \'Device\' details page for \'001BAQXT6JWFPI\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3189 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3189.AddRow(new string[] {
                            "Application"});
                table3189.AddRow(new string[] {
                            "Vendor"});
                table3189.AddRow(new string[] {
                            "Version"});
                table3189.AddRow(new string[] {
                            "Compliance"});
                table3189.AddRow(new string[] {
                            "Installed"});
                table3189.AddRow(new string[] {
                            "Used"});
                table3189.AddRow(new string[] {
                            "Entitled"});
#line 84
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3189, "Then ");
#line hidden
#line 93
 testRunner.When("User navigates to the \'Evergreen Detail\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.Then("\"Application\" column is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.When("User opens \'Vendor\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("User select \"Application\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("User select \"Vendor\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3190 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3190.AddRow(new string[] {
                            "Version"});
                table3190.AddRow(new string[] {
                            "Compliance"});
                table3190.AddRow(new string[] {
                            "Association"});
                table3190.AddRow(new string[] {
                            "Advertisement"});
                table3190.AddRow(new string[] {
                            "Collection"});
                table3190.AddRow(new string[] {
                            "Program"});
                table3190.AddRow(new string[] {
                            "Installed Date"});
                table3190.AddRow(new string[] {
                            "Used By"});
                table3190.AddRow(new string[] {
                            "Used Date"});
                table3190.AddRow(new string[] {
                            "Used Duration (Mins)"});
#line 100
 testRunner.Then("following columns are displayed on the Item details page:", ((string)(null)), table3190, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectD" +
            "etailsPage", new string[] {
                "Evergreen",
                "Users",
                "EvergreenJnr_ItemDetails",
                "ItemDetailsDisplay",
                "DAS16719",
                "Zion_NewGrid"}, SourceLine=113)]
        public virtual void EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectDetailsPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS16719",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectD" +
                    "etailsPage", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16719",
                        "Zion_NewGrid"});
#line 114
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
#line 115
 testRunner.When("User navigates to the \'User\' details page for \'AAD1011948\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 116
 testRunner.Then("Details page for \'AAD1011948\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.When("User navigates to the \'Compliance\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 118
 testRunner.When("User navigates to the \'Hardware Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 119
 testRunner.Then("table is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
