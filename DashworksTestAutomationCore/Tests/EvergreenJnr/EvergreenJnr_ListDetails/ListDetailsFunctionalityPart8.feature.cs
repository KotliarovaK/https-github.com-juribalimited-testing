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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ListDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ListDetailsFunctionalityPart8")]
    public partial class ListDetailsFunctionalityPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
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
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks(string pageName, string columnName, string targetCell, string selectedRow, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorksInternal(pageName,columnName,targetCell,selectedRow,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorksInternal(string pageName, string columnName, string targetCell, string selectedRow, string[] exampleTags)
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
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks", null, @__tags);
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
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.When(string.Format("User right clicks on \'{0}\' cell from \'{1}\' column", targetCell, columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3372 = new TechTalk.SpecFlow.Table(new string[] {
                            "OptionsName"});
                table3372.AddRow(new string[] {
                            "Copy cell"});
                table3372.AddRow(new string[] {
                            "Copy row"});
                table3372.AddRow(new string[] {
                            "Open in new tab"});
                table3372.AddRow(new string[] {
                            "Open in new window"});
#line 12
 testRunner.Then("User sees context menu with next options", ((string)(null)), table3372, "Then ");
#line hidden
#line 18
 testRunner.When("User selects \'Copy cell\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then(string.Format("Next data \'{0}\' is copied", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("User clicks refresh button in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3373 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3373.AddRow(new string[] {
                            string.Format("{0}", selectedRow)});
#line 23
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnName), ((string)(null)), table3373, "When ");
#line hidden
#line 26
 testRunner.When(string.Format("User right clicks on \'{0}\' cell from \'{1}\' column", targetCell, columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3374 = new TechTalk.SpecFlow.Table(new string[] {
                            "OptionsName"});
                table3374.AddRow(new string[] {
                            "Copy cell"});
                table3374.AddRow(new string[] {
                            "Copy row"});
                table3374.AddRow(new string[] {
                            "Copy selected rows"});
                table3374.AddRow(new string[] {
                            "Open in new tab"});
                table3374.AddRow(new string[] {
                            "Open in new window"});
#line 27
 testRunner.Then("User sees context menu with next options", ((string)(null)), table3374, "Then ");
#line hidden
#line 34
 testRunner.When("User selects \'Copy cell\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then(string.Format("Next data \'{0}\' is copied", targetCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12968")]
        [NUnit.Framework.CategoryAttribute("DAS20346")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", "00HA7MKAVVFDAV\\tLaptop\\tWindows 10\\tKris C. Herman", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", "$6BE000-SUDQ9614UVO8\\tBCLABS\\tExchange Online-ApplicationAccount\\tExchange Online" +
            "-ApplicationAccount.Users.bclabs.local", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", "0004 - Adobe Acrobat Reader 5.0.5 Francais\\tAdobe\\t5.0.5", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", "000F977AC8824FE39B8@bclabs.local\\tExchange 2007\\tbc-exch07\\tUserMailbox\\tSpruill," +
            " Shea", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks(string pageName, string columnName, string targetCell, string selectedRow, string expectedData, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorksInternal(pageName,columnName,targetCell,selectedRow,expectedData,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorksInternal(string pageName, string columnName, string targetCell, string selectedRow, string expectedData, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS12968",
                    "DAS20346"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks", null, @__tags);
#line 45
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
#line 46
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3375 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3375.AddRow(new string[] {
                            string.Format("{0}", selectedRow)});
#line 49
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnName), ((string)(null)), table3375, "When ");
#line hidden
#line 52
 testRunner.When(string.Format("User right clicks on \'{0}\' cell from \'{1}\' column", targetCell, columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.And("User selects \'Copy row\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.Then(string.Format("Next data \'{0}\' is copied", expectedData), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("AllLists")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ListDetails")]
        [NUnit.Framework.CategoryAttribute("ListDetailsFunctionality")]
        [NUnit.Framework.CategoryAttribute("DAS12968")]
        [NUnit.Framework.TestCaseAttribute("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", "001PSUMZYOW581", "001BAQXT6JWFPI\\tDesktop\\tWindows 10\\tNicole P. Braun \\t001PSUMZYOW581\\tLaptop\\tWi" +
            "ndows 10\\tTricia G. Huang", null)]
        [NUnit.Framework.TestCaseAttribute("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", "002B5DC7D4D34D5C895", "000F977AC8824FE39B8\\tBCLABS\\tSpruill, Shea\\tSpruill\\, Shea.Employees.Birmingham.U" +
            "K.bclabs.local \\t002B5DC7D4D34D5C895\\tDWLABS\\tCollor, Christopher\\tCollor\\, Chri" +
            "stopher.Users.Birmingham.dwlabs.local", null)]
        [NUnit.Framework.TestCaseAttribute("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", "20040610sqlserverck", "0036 - Microsoft Access 97 SR-2 English\\tMicrosoft\\t8.0 \\t20040610sqlserverck\\tMi" +
            "crosoft\\t1.0.0", null)]
        [NUnit.Framework.TestCaseAttribute("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", "0072B088173449E3A93@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local\\tExchange 2013\\tbc-exch13\\tUserMailbox\\tCollor, " +
            "Christopher \\t0072B088173449E3A93@bclabs.local\\tExchange 2007\\tbc-exch07\\tUserMa" +
            "ilbox\\tRegister, Donna", null)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks(string pageName, string columnName, string targetCell, string selectedRow1, string selectedRow2, string expectedData, string[] exampleTags)
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorksInternal(pageName,columnName,targetCell,selectedRow1,selectedRow2,expectedData,exampleTags);
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

        private void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorksInternal(string pageName, string columnName, string targetCell, string selectedRow1, string selectedRow2, string expectedData, string[] exampleTags)
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
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks", null, @__tags);
#line 65
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
#line 66
 testRunner.When(string.Format("User clicks \'{0}\' on the left-hand menu", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.And("User clicks the Actions button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.Then("Actions panel is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3376 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3376.AddRow(new string[] {
                            string.Format("{0}", selectedRow1)});
                table3376.AddRow(new string[] {
                            string.Format("{0}", selectedRow2)});
#line 69
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnName), ((string)(null)), table3376, "When ");
#line hidden
#line 73
 testRunner.When(string.Format("User right clicks on \'{0}\' cell from \'{1}\' column", targetCell, columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.And("User selects \'Copy selected rows\' option in context menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.Then(string.Format("Next data \'{0}\' is copied", expectedData), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsPaneInternal();
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

        private void EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsPaneInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS16332",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsP" +
                    "ane", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS16332",
                        "Cleanup"});
#line 85
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
#line 86
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.And("User clicks the Filters button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3377 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3377.AddRow(new string[] {
                            "TRUE"});
#line 88
 testRunner.And("User add \"2004: In Scope\" filter where type is \"Equals\" with added column and fol" +
                        "lowing checkboxes:", ((string)(null)), table3377, "And ");
#line hidden
#line 91
 testRunner.And("User create dynamic list with \"TestListName4682\" name on \"Devices\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.Then("\"TestListName4682\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.When("User clicks \'Manage\' option in cogmenu for \'TestListName4682\' list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.And("User adds \"post\" to list name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.Then("\"TestListName4682post\" list is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClickedInternal();
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

        private void EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClickedInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "AllLists",
                    "EvergreenJnr_ListDetails",
                    "ListDetailsFunctionality",
                    "DAS17632"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked", null, new string[] {
                        "Evergreen",
                        "AllLists",
                        "EvergreenJnr_ListDetails",
                        "ListDetailsFunctionality",
                        "DAS17632"});
#line 98
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
#line 99
 testRunner.When("User clicks \'Devices\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3378 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3378.AddRow(new string[] {
                            "Device Key"});
#line 100
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table3378, "When ");
#line hidden
#line 103
 testRunner.And("User sets includes archived devices in \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("User clicks content from first row of Hostname column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.When("User clicks content from first row of Device Key column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.Then("\'All Devices\' list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
