﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_Pivot
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Pivot")]
    public partial class PivotFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Pivot", "Runs Pivot block related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is logged in to the Evergreen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFil" +
            "ter")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14224")]
        [NUnit.Framework.TestCaseAttribute("Applications", "Compliance", "Application Key", "Vendor", "Pivot_Applications_List_14224", "Devices", "Application (Saved List)", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Enabled", "Cost Centre", "Department Full Path", "Pivot_User_List_14224", "Applications", "User (Saved List)", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFilter(string pageNameForPivot, string rowGroups, string columns, string values, string pivotName, string pageNameForFilter, string filterName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14224"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFil" +
                    "ter", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageNameForPivot), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageNameForPivot), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table1.AddRow(new string[] {
                        string.Format("{0}", rowGroups)});
            testRunner.And("User adds the following Row Groups:", ((string)(null)), table1, "And ");
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table2.AddRow(new string[] {
                        string.Format("{0}", columns)});
            testRunner.And("User adds the following Columns:", ((string)(null)), table2, "And ");
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table3.AddRow(new string[] {
                        string.Format("{0}", values)});
            testRunner.And("User adds the following Values:", ((string)(null)), table3, "And ");
            testRunner.And("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User creates Pivot list with \"{0}\" name", pivotName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list is displayed to user", pivotName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", pageNameForFilter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("\"{0}\" list should be displayed to the user", pageNameForFilter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Filters panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks Add New button on the Filter panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And(string.Format("user select \"{0}\" filter", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then(string.Format("\"{0}\" list is not displayed for Saved List filter", pivotName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And(string.Format("User remove list with \"{0}\" name on \"{1}\" page", pivotName, pageNameForPivot), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWit" +
            "hCorrectSubcategories")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14325")]
        [NUnit.Framework.TestCaseAttribute("Devices", null)]
        [NUnit.Framework.TestCaseAttribute("Users", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories(string listName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14325"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWit" +
                    "hCorrectSubcategories", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"ADD ROW GROUP\" button in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees \"Evergreen\" category in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User is expand \"Evergreen\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table4.AddRow(new string[] {
                        "Evergreen Bucket"});
            table4.AddRow(new string[] {
                        "Evergreen Capacity Unit"});
            testRunner.Then("the following Column subcategories are displayed for open category:", ((string)(null)), table4, "Then ");
            testRunner.When("User clicks Close Add Item icon in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks \"ADD COLUMN\" button in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees \"Evergreen\" category in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User is expand \"Evergreen\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table5.AddRow(new string[] {
                        "Evergreen Bucket"});
            table5.AddRow(new string[] {
                        "Evergreen Capacity Unit"});
            testRunner.Then("the following Column subcategories are displayed for open category:", ((string)(null)), table5, "Then ");
            testRunner.When("User clicks Close Add Item icon in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks \"ADD VALUE\" button in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees \"Evergreen\" category in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User is expand \"Evergreen\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table6.AddRow(new string[] {
                        "Evergreen Bucket"});
            table6.AddRow(new string[] {
                        "Evergreen Capacity Unit"});
            testRunner.Then("the following Column subcategories are displayed for open category:", ((string)(null)), table6, "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_ApplicationsList_ChecksThatGroupsColumnsAndValuesContainEvergreenCat" +
            "agoryWithCorrectSubcategories")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Applications")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14325")]
        public virtual void EvergreenJnr_ApplicationsList_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_ChecksThatGroupsColumnsAndValuesContainEvergreenCat" +
                    "agoryWithCorrectSubcategories", new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14325"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Applications\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks \"ADD ROW GROUP\" button in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees \"Evergreen\" category in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User is expand \"Evergreen\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table7.AddRow(new string[] {
                        "Evergreen Capacity Unit"});
            testRunner.Then("the following Column subcategories are displayed for open category:", ((string)(null)), table7, "Then ");
            testRunner.When("User clicks Close Add Item icon in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks \"ADD COLUMN\" button in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees \"Evergreen\" category in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User is expand \"Evergreen\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table8.AddRow(new string[] {
                        "Evergreen Capacity Unit"});
            testRunner.Then("the following Column subcategories are displayed for open category:", ((string)(null)), table8, "Then ");
            testRunner.When("User clicks Close Add Item icon in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks \"ADD VALUE\" button in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User sees \"Evergreen\" category in Pivot panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User closed \"Selected Columns\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User is expand \"Evergreen\" columns category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Subcategories"});
            table9.AddRow(new string[] {
                        "Evergreen Capacity Unit"});
            testRunner.Then("the following Column subcategories are displayed for open category:", ((string)(null)), table9, "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_ChecksThatColumnsCanBeAddedAfterRunningPivot")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14188")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Compliance", "Babel(Engl: Application Readiness", "Last Seen Date", "All Devices", "Build Date", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Compliance", "App Count (Entitled)", "Domain", "All Users", "Common Name", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Alias", "Owner City", "Created Date", "All Mailboxes", "Alias", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "Evergreen Capacity Unit", "Vendor", "All Applications", "Application Key", null)]
        public virtual void EvergreenJnr_AllLists_ChecksThatColumnsCanBeAddedAfterRunningPivot(string listName, string rowGroup, string column, string value, string link, string columnToBeAdded, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_Pivot",
                    "Pivot",
                    "DAS14188"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_ChecksThatColumnsCanBeAddedAfterRunningPivot", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When(string.Format("User clicks \"{0}\" on the left-hand menu", listName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table10.AddRow(new string[] {
                        string.Format("{0}", rowGroup)});
            testRunner.And("User adds the following Row Groups:", ((string)(null)), table10, "And ");
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table11.AddRow(new string[] {
                        string.Format("{0}", column)});
            testRunner.And("User adds the following Columns:", ((string)(null)), table11, "And ");
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table12.AddRow(new string[] {
                        string.Format("{0}", value)});
            testRunner.And("User adds the following Values:", ((string)(null)), table12, "And ");
            testRunner.And("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When(string.Format("User clicks \"{0}\" link in Lists panel", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks the Columns button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table13.AddRow(new string[] {
                        string.Format("{0}", columnToBeAdded)});
            testRunner.And("ColumnName is entered into the search box and the selection is clicked", ((string)(null)), table13, "And ");
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table14.AddRow(new string[] {
                        string.Format("{0}", columnToBeAdded)});
            testRunner.Then("ColumnName is added to the list", ((string)(null)), table14, "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChang" +
            "esPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_Pivot")]
        [NUnit.Framework.CategoryAttribute("Pivot")]
        [NUnit.Framework.CategoryAttribute("DAS14224")]
        [NUnit.Framework.CategoryAttribute("Delete_Newly_Created_Project")]
        public virtual void EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChangesPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChang" +
                    "esPage", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_Pivot",
                        "Pivot",
                        "DAS14224",
                        "Delete_Newly_Created_Project"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.When("User clicks \"Devices\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Devices\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User navigates to Pivot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "RowGroups"});
            table15.AddRow(new string[] {
                        "Compliance"});
            testRunner.And("User adds the following Row Groups:", ((string)(null)), table15, "And ");
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Columns"});
            table16.AddRow(new string[] {
                        "City"});
            testRunner.And("User adds the following Columns:", ((string)(null)), table16, "And ");
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table17.AddRow(new string[] {
                        "Cost Centre"});
            testRunner.And("User adds the following Values:", ((string)(null)), table17, "And ");
            testRunner.And("User clicks the \"RUN PIVOT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Pivot run was completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User creates Pivot list with \"Pivot_DAS_14224\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User clicks Admin on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Admin page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks \"Projects\" link on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Projects\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the \"CREATE PROJECT\" Action button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("\"Create Project\" page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User enters \"Pivot_Project_14224\" in the \"Project Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User selects \"All Devices\" in the Scope Project dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User clicks Create button on the Create Project page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Success message is displayed and contains \"The project has been created\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks newly created object link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("User selects \"Scope Details\" tab on the Project details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User navigates to the \"Device Scope\" tab in the Scope section on the Project deta" +
                    "ils page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table18.AddRow(new string[] {
                        "All Devices"});
            testRunner.Then("following Values are displayed in \"Scope\" drop-down on the Project details page:", ((string)(null)), table18, "Then ");
            testRunner.When("User navigates to the \"User Scope\" tab in the Scope section on the Project detail" +
                    "s page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table19.AddRow(new string[] {
                        "All Users"});
            testRunner.Then("following Values are displayed in \"User Scope\" drop-down on the Project details p" +
                    "age:", ((string)(null)), table19, "Then ");
            testRunner.When("User navigates to the \"Application Scope\" tab in the Scope section on the Project" +
                    " details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Values"});
            table20.AddRow(new string[] {
                        "All Applications"});
            testRunner.Then("following Values are displayed in \"Application Scope\" drop-down on the Project de" +
                    "tails page:", ((string)(null)), table20, "Then ");
            testRunner.And("User remove list with \"Pivot_DAS_14224\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
