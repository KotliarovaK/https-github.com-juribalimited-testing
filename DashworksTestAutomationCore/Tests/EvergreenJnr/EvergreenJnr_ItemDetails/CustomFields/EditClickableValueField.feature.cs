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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.CustomFields
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("EditClickableValueField", Description="\tEdit clickable value field", SourceFile="Tests\\EvergreenJnr\\EvergreenJnr_ItemDetails\\CustomFields\\EditClickableValueField." +
        "feature", SourceLine=0)]
    public partial class EditClickableValueFieldFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "EditClickableValueField.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EditClickableValueField", "\tEdit clickable value field", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_DevicesList_CheckEditableFieldDisplayAndToolTips", new string[] {
                "Evergreen",
                "Devices",
                "EvergreenJnr_ItemDetails",
                "CustomFields",
                "DAS15473",
                "Cleanup"}, SourceLine=8)]
        public virtual void EvergreenJnr_DevicesList_CheckEditableFieldDisplayAndToolTips()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS15473",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckEditableFieldDisplayAndToolTips", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS15473",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table2900 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Computer"});
                table2900.AddRow(new string[] {
                            "CfDAS15473_1",
                            "FlDAS15473_1",
                            "true",
                            "true",
                            "true"});
#line 10
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table2900, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2901 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table2901.AddRow(new string[] {
                            "device",
                            "6648",
                            "CfDAS15473_1",
                            "ValueDAS15473_#$‡!_1"});
#line 13
 testRunner.And("User creates Custom Field via API", ((string)(null)), table2901, "And ");
#line hidden
#line 16
 testRunner.And("User navigates to the \'Device\' details page for \'00YWR8TJU4ZF8V\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("Details page for \'00YWR8TJU4ZF8V\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.When("User doubleclicks on \'ValueDAS15473_#$‡!_1\' cell from \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("Save and Cancel buttons with tooltips are displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckDataIsUpdatedInClickableValue", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "CustomFields",
                "DAS15473",
                "Cleanup"}, SourceLine=22)]
        public virtual void EvergreenJnr_ApplicationsList_CheckDataIsUpdatedInClickableValue()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS15473",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDataIsUpdatedInClickableValue", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS15473",
                        "Cleanup"});
#line 23
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
                TechTalk.SpecFlow.Table table2902 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Application"});
                table2902.AddRow(new string[] {
                            "CfDAS15473_2",
                            "FlDAS15473_2",
                            "true",
                            "true",
                            "true"});
#line 24
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table2902, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2903 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table2903.AddRow(new string[] {
                            "application",
                            "507",
                            "CfDAS15473_2",
                            "ValueDAS15473_2"});
#line 27
 testRunner.And("User creates Custom Field via API", ((string)(null)), table2903, "And ");
#line hidden
#line 30
 testRunner.And("User navigates to the \'Application\' details page for \'ACDSee 8\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.Then("Details page for \'ACDSee 8\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.When("User change text in \'ValueDAS15473_2\' cell from \'Value\' column to \'UPDATED_V\' tex" +
                        "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then("Save and Cancel buttons are NOT displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("\'UPDATED_V\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.When("User doubleclicks on \'UPDATED_V\' cell from \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And("User clicks Cancel button for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then("Save and Cancel buttons are NOT displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.And("\'UPDATED_V\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_ApplicationsList_CheckDataIsUpdatedUsingCogMenu", new string[] {
                "Evergreen",
                "Applications",
                "EvergreenJnr_ItemDetails",
                "CustomFields",
                "DAS17584",
                "Cleanup"}, SourceLine=43)]
        public virtual void EvergreenJnr_ApplicationsList_CheckDataIsUpdatedUsingCogMenu()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Applications",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS17584",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_ApplicationsList_CheckDataIsUpdatedUsingCogMenu", null, new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS17584",
                        "Cleanup"});
#line 44
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
                TechTalk.SpecFlow.Table table2904 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Application"});
                table2904.AddRow(new string[] {
                            "CfDAS17584_1",
                            "FlDAS17584_1",
                            "true",
                            "true",
                            "true"});
#line 45
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table2904, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2905 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table2905.AddRow(new string[] {
                            "application",
                            "750",
                            "CfDAS17584_1",
                            "Value17584_1"});
#line 48
 testRunner.And("User creates Custom Field via API", ((string)(null)), table2905, "And ");
#line hidden
#line 51
 testRunner.And("User navigates to the \'Application\' details page for \'PCFriendly\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Then("Details page for \'PCFriendly\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'FlDAS17584_1\' item from \'Custom Field\'" +
                        " column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.And("User save \'UPDATED_UPD\' text in clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("Save and Cancel buttons are NOT displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.And("\'UPDATED_UPD\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'FlDAS17584_1\' item from \'Custom Field\'" +
                        " column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.And("User clicks Cancel button for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.Then("Save and Cancel buttons are NOT displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.And("\'UPDATED_UPD\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckClickableValueSavedOnFocusLost", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_ItemDetails",
                "CustomFields",
                "DAS15473",
                "Cleanup"}, SourceLine=65)]
        public virtual void EvergreenJnr_MailboxesList_CheckClickableValueSavedOnFocusLost()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS15473",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckClickableValueSavedOnFocusLost", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS15473",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table2906 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Mailbox"});
                table2906.AddRow(new string[] {
                            "CfDAS15473_3",
                            "FlDAS15473_3",
                            "true",
                            "true",
                            "true"});
#line 67
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table2906, "When ");
#line hidden
#line 70
 testRunner.And("User navigate to Evergreen URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2907 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table2907.AddRow(new string[] {
                            "mailbox",
                            "46384",
                            "CfDAS15473_3",
                            "ValueDAS15473_3"});
#line 71
 testRunner.And("User creates Custom Field via API", ((string)(null)), table2907, "And ");
#line hidden
#line 74
 testRunner.And("User navigates to the \'Mailbox\' details page for \'0072B088173449E3A93@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.Then("Details page for \'0072B088173449E3A93@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("User change text in \'ValueDAS15473_3\' cell from \'Value\' column to \'UPDATED_Focus_" +
                        "Lost\' text without saving", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.When("User clicks Body container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("Save and Cancel buttons are NOT displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.And("\'UPDATED_Focus_Lost\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("EvergreenJnr_MailboxesList_CheckThatEditingOfTheCustomFieldIsActivatedOnTheObject" +
            "DetailsPageViaTheCogMenuInCaseTheSearchFilterHadBeenApplied", new string[] {
                "Evergreen",
                "Mailboxes",
                "EvergreenJnr_ItemDetails",
                "CustomFields",
                "DAS20064",
                "Cleanup"}, SourceLine=83)]
        public virtual void EvergreenJnr_MailboxesList_CheckThatEditingOfTheCustomFieldIsActivatedOnTheObjectDetailsPageViaTheCogMenuInCaseTheSearchFilterHadBeenApplied()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS20064",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CheckThatEditingOfTheCustomFieldIsActivatedOnTheObject" +
                    "DetailsPageViaTheCogMenuInCaseTheSearchFilterHadBeenApplied", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS20064",
                        "Cleanup"});
#line 84
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
                TechTalk.SpecFlow.Table table2908 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Mailbox"});
                table2908.AddRow(new string[] {
                            "CfDAS20064_3A",
                            "FlDAS20064_3A",
                            "true",
                            "true",
                            "true"});
                table2908.AddRow(new string[] {
                            "CfDAS20064_3B",
                            "FlDAS20064_3B",
                            "true",
                            "true",
                            "true"});
#line 85
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table2908, "When ");
#line hidden
#line 89
 testRunner.And("User navigate to Evergreen URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2909 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table2909.AddRow(new string[] {
                            "mailbox",
                            "46384",
                            "CfDAS20064_3A",
                            "ValueDAS20064_3A"});
                table2909.AddRow(new string[] {
                            "mailbox",
                            "46384",
                            "CfDAS20064_3B",
                            "ValueDAS20064_3B"});
#line 90
 testRunner.And("User creates Custom Field via API", ((string)(null)), table2909, "And ");
#line hidden
#line 94
 testRunner.And("User navigates to the \'Mailbox\' details page for \'0072B088173449E3A93@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.Then("Details page for \'0072B088173449E3A93@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.When("User enters \"DAS20064\" text in the Search field for \"Value\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'FlDAS20064_3B\' item from \'Custom Field" +
                        "\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.Then("Save and Cancel buttons with tooltips are displayed for clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.When("User save \'ValueDAS20064_3B_UPD\' text in clickable value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.When("User clicks button with \'ResetFilters\' aria label", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.When("User enters \"FlDAS20064_3B\" text in the Search field for \"Custom Field\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.Then("\'ValueDAS20064_3B_UPD\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
