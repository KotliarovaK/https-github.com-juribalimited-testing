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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ListDetails
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ListDetailsFunctionalityPart8", Description="\tRuns List Details Panel related tests", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ListDetails\\ListDetailsFunctionalityPart8.feature" +
        "", SourceLine=0)]
    public partial class ListDetailsFunctionalityPart8Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ListDetailsFunctionalityPart8.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ListDetailsFunctionalityPart8", "\tRuns List Details Panel related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks(string pageName, string columnName, string targetCell, string selectedRow, string[] exampleTags)
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
                TechTalk.SpecFlow.Table table3342 = new TechTalk.SpecFlow.Table(new string[] {
                            "OptionsName"});
                table3342.AddRow(new string[] {
                            "Copy cell"});
                table3342.AddRow(new string[] {
                            "Copy row"});
                table3342.AddRow(new string[] {
                            "Open in new tab"});
                table3342.AddRow(new string[] {
                            "Open in new window"});
#line 12
 testRunner.Then("User sees context menu with next options", ((string)(null)), table3342, "Then ");
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
                TechTalk.SpecFlow.Table table3343 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3343.AddRow(new string[] {
                            string.Format("{0}", selectedRow)});
#line 23
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnName), ((string)(null)), table3343, "When ");
#line hidden
#line 26
 testRunner.When(string.Format("User right clicks on \'{0}\' cell from \'{1}\' column", targetCell, columnName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3344 = new TechTalk.SpecFlow.Table(new string[] {
                            "OptionsName"});
                table3344.AddRow(new string[] {
                            "Copy cell"});
                table3344.AddRow(new string[] {
                            "Copy row"});
                table3344.AddRow(new string[] {
                            "Copy selected rows"});
                table3344.AddRow(new string[] {
                            "Open in new tab"});
                table3344.AddRow(new string[] {
                            "Open in new window"});
#line 27
 testRunner.Then("User sees context menu with next options", ((string)(null)), table3344, "Then ");
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=38)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks_Devices()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=38)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks_Users()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=38)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks_Applications()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=38)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks_Mailboxes()
        {
#line 9
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks(string pageName, string columnName, string targetCell, string selectedRow, string expectedData, string[] exampleTags)
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
                TechTalk.SpecFlow.Table table3345 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3345.AddRow(new string[] {
                            string.Format("{0}", selectedRow)});
#line 49
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnName), ((string)(null)), table3345, "When ");
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968",
                "DAS20346"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks_Devices()
        {
#line 45
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", "00HA7MKAVVFDAV\\tLaptop\\tWindows 10\\tKris C. Herman", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968",
                "DAS20346"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks_Users()
        {
#line 45
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", "$6BE000-SUDQ9614UVO8\\tBCLABS\\tExchange Online-ApplicationAccount\\tExchange Online" +
                    "-ApplicationAccount.Users.bclabs.local", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks, Applications", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968",
                "DAS20346"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks_Applications()
        {
#line 45
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", "0004 - Adobe Acrobat Reader 5.0.5 Francais\\tAdobe\\t5.0.5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks, Mailboxes", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968",
                "DAS20346"}, SourceLine=57)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks_Mailboxes()
        {
#line 45
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", "000F977AC8824FE39B8@bclabs.local\\tExchange 2007\\tbc-exch07\\tUserMailbox\\tSpruill," +
                    " Shea", ((string[])(null)));
#line hidden
        }
        
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks(string pageName, string columnName, string targetCell, string selectedRow1, string selectedRow2, string expectedData, string[] exampleTags)
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
                TechTalk.SpecFlow.Table table3346 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedRowsName"});
                table3346.AddRow(new string[] {
                            string.Format("{0}", selectedRow1)});
                table3346.AddRow(new string[] {
                            string.Format("{0}", selectedRow2)});
#line 69
 testRunner.When(string.Format("User select \"{0}\" rows in the grid", columnName), ((string)(null)), table3346, "When ");
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks, Devices", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=78)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks_Devices()
        {
#line 65
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks("Devices", "Hostname", "00HA7MKAVVFDAV", "001BAQXT6JWFPI", "001PSUMZYOW581", "001BAQXT6JWFPI\\tDesktop\\tWindows 10\\tNicole P. Braun \\t001PSUMZYOW581\\tLaptop\\tWi" +
                    "ndows 10\\tTricia G. Huang", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks, Users", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=78)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks_Users()
        {
#line 65
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks("Users", "Username", "$6BE000-SUDQ9614UVO8", "000F977AC8824FE39B8", "002B5DC7D4D34D5C895", "000F977AC8824FE39B8\\tBCLABS\\tSpruill, Shea\\tSpruill\\, Shea.Employees.Birmingham.U" +
                    "K.bclabs.local \\t002B5DC7D4D34D5C895\\tDWLABS\\tCollor, Christopher\\tCollor\\, Chri" +
                    "stopher.Users.Birmingham.dwlabs.local", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks, Applicat" +
            "ions", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=78)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks_Applications()
        {
#line 65
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks("Applications", "Application", "0004 - Adobe Acrobat Reader 5.0.5 Francais", "0036 - Microsoft Access 97 SR-2 English", "20040610sqlserverck", "0036 - Microsoft Access 97 SR-2 English\\tMicrosoft\\t8.0 \\t20040610sqlserverck\\tMi" +
                    "crosoft\\t1.0.0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks, Mailboxe" +
            "s", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS12968"}, SourceLine=78)]
        public virtual void EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks_Mailboxes()
        {
#line 65
this.EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks("Mailboxes", "Email Address", "000F977AC8824FE39B8@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local", "0072B088173449E3A93@bclabs.local", "002B5DC7D4D34D5C895@bclabs.local\\tExchange 2013\\tbc-exch13\\tUserMailbox\\tCollor, " +
                    "Christopher \\t0072B088173449E3A93@bclabs.local\\tExchange 2007\\tbc-exch07\\tUserMa" +
                    "ilbox\\tRegister, Donna", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsP" +
            "ane", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS16332",
                "Cleanup"}, SourceLine=84)]
        public virtual void EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsPane()
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
                TechTalk.SpecFlow.Table table3347 = new TechTalk.SpecFlow.Table(new string[] {
                            "SelectedCheckboxes"});
                table3347.AddRow(new string[] {
                            "TRUE"});
#line 88
 testRunner.And("User add \"2004: In Scope\" filter where type is \"Equals\" with added column and fol" +
                        "lowing checkboxes:", ((string)(null)), table3347, "And ");
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked", new string[] {
                "Evergreen",
                "AllLists",
                "EvergreenJnr_ListDetails",
                "ListDetailsFunctionality",
                "DAS17632"}, SourceLine=97)]
        public virtual void EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked()
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
                TechTalk.SpecFlow.Table table3348 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3348.AddRow(new string[] {
                            "Device Key"});
#line 100
 testRunner.When("User add following columns using URL to the \"Devices\" page:", ((string)(null)), table3348, "When ");
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
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
