﻿// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ListDetails
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ListDetailsFunctionalityPart8")]
    public partial class ListDetailsFunctionalityPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ListDetailsFunctionalityPart8.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart8", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12968")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks(string pageName, string columnname, string targetCell, string selectedRow, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS12968"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And(string.Format("User performs right-click on \"{0}\" cell in the grid", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "OptionsName"});
            table1.AddRow(new string[] {
                        "Copy cell"});
            table1.AddRow(new string[] {
                        "Copy row"});
            table1.AddRow(new string[] {
                        "Open in new tab"});
            table1.AddRow(new string[] {
                        "Open in new window"});
#line 12
 testRunner.Then("User sees context menu with next options", ((string)(null)), table1, "Then ");
#line 18
 testRunner.When("User selects \'Copy cell\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then(string.Format("Next data \'{0}\' is copied", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table2.AddRow(new string[] {
                        string.Format("{0}", selectedRow)});
#line 23
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnname), ((string)(null)), table2, "When ");
#line 26
 testRunner.And(string.Format("User performs right-click on \"{0}\" cell in the grid", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "OptionsName"});
            table3.AddRow(new string[] {
                        "Copy cell"});
            table3.AddRow(new string[] {
                        "Copy row"});
            table3.AddRow(new string[] {
                        "Copy selected rows"});
            table3.AddRow(new string[] {
                        "Open in new tab"});
            table3.AddRow(new string[] {
                        "Open in new window"});
#line 27
 testRunner.Then("User sees context menu with next options", ((string)(null)), table3, "Then ");
#line 34
 testRunner.When("User selects \'Copy cell\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then(string.Format("Next data \'{0}\' is copied", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12968")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", "\\t00HA7MKAVVFDAV\\tLaptop\\tWindows 7\\tKris C. Herman", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", "\\t$6BE000-SUDQ9614UVO8\\tBCLABS\\tExchange Online-ApplicationAccount\\tExchange Onli" +
            "ne-ApplicationAccount.Users.bclabs.local", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", "\\t0004 - Adobe Acrobat Reader 5.0.5 Francais\\tAdobe\\t5.0.5", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", "\\t000F977AC8824FE39B8@bclabs.local\\tExchange 2007\\tbc-exch07\\tUserMailbox\\tSpruil" +
            "l, Shea", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks(string pageName, string columnname, string targetCell, string selectedRow, string expectedData, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS12968"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks", null, @__tags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 47
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table4.AddRow(new string[] {
                        string.Format("{0}", selectedRow)});
#line 50
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnname), ((string)(null)), table4, "When ");
#line 53
 testRunner.And(string.Format("User performs right-click on \"{0}\" cell in the grid", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("User selects \'Copy row\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then(string.Format("Next data \'{0}\' is copied", expectedData), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12968")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", "001PSUMZYOW581", "\\t001BAQXT6JWFPI\\tDesktop\\tWindows 7\\tNicole P. Braun \\t001PSUMZYOW581\\tLaptop\\tW" +
            "indows 7\\tTricia G. Huang", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", "002B5DC7D4D34D5C895", "\\t000F977AC8824FE39B8\\tBCLABS\\tSpruill, Shea\\tSpruill\\, Shea.Employees.Birmingham" +
            ".UK.bclabs.local \\t002B5DC7D4D34D5C895\\tDWLABS\\tCollor, Christopher\\tCollor\\, Ch" +
            "ristopher.Users.Birmingham.dwlabs.local", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", "20040610sqlserverck", "\\t0036 - Microsoft Access 97 SR-2 English\\tMicrosoft\\t8.0 \\t20040610sqlserverck\\t" +
            "Microsoft\\t1.0.0", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", "0072B088173449E3A93@bclabs.local", "\\t002B5DC7D4D34D5C895@bclabs.local\\tExchange 2013\\tbc-exch13\\tUserMailbox\\tCollor" +
            ", Christopher \\t0072B088173449E3A93@bclabs.local\\tExchange 2007\\tbc-exch07\\tUser" +
            "Mailbox\\tRegister, Donna", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks(string pageName, string columnname, string targetCell, string selectedRow1, string selectedRow2, string expectedData, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS12968"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks", null, @__tags);
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 67
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedRowsName"});
            table5.AddRow(new string[] {
                        string.Format("{0}", selectedRow1)});
            table5.AddRow(new string[] {
                        string.Format("{0}", selectedRow2)});
#line 70
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnname), ((string)(null)), table5, "When ");
#line 74
 testRunner.And(string.Format("User performs right-click on \"{0}\" cell in the grid", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("User selects \'Copy selected rows\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then(string.Format("Next data \'{0}\' is copied", expectedData), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsP" +
            "ane")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS16332")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsPane()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsP" +
                    "ane", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS16332",
                        "Cleanup"});
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 87
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelectedCheckboxes"});
            table6.AddRow(new string[] {
                        "TRUE"});
#line 89
 testRunner.And("User add \"1803: In Scope\" filter where type is \"Equals\" with added column and fol" +
                    "lowing checkboxes:", ((string)(null)), table6, "And ");
#line 92
 testRunner.And("User create dynamic list with \"TestListName\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.Then("\"TestListName\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.When("User opens manage pane for list with \"TestListName\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.And("User adds \"post\" to list name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Then("\"TestListNamepost\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS17632")]
        public virtual void EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS17632"});
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 100
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ColumnName"});
            table7.AddRow(new string[] {
                        "Device Key"});
#line 101
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table7, "When ");
#line 104
 testRunner.And("User sets includes archived devices in \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("User clicks content from first row of Hostname column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.When("User clicks content from first row of Device Key column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

