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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.Tabs.CustomFields
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateNewCustomField")]
    public partial class CreateNewCustomFieldFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CreateNewCustomField.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateNewCustomField", "\tCreate New Custom Field", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS16487")]
        [NUnit.Framework.CategoryAttribute("Do_Not_Run_With_CustomFields")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Devices",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS16487",
                    "Do_Not_Run_With_CustomFields",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Do_Not_Run_With_CustomFields",
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
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Computer"});
                table1.AddRow(new string[] {
                            "CfDAS16487_1a",
                            "FlDAS16487_1a",
                            "true",
                            "true",
                            "true"});
                table1.AddRow(new string[] {
                            "CfDAS16487_1b",
                            "FlDAS16487_1b",
                            "true",
                            "false",
                            "true"});
                table1.AddRow(new string[] {
                            "CfDAS16487_1c",
                            "FlDAS16487_1c",
                            "true",
                            "true",
                            "false"});
#line 10
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table1, "When ");
#line hidden
#line 15
 testRunner.When("User navigates to the \'Device\' details page for \'QFI94WAUX17N4I\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("Details page for \'QFI94WAUX17N4I\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.And("User clicks \'ADD CUSTOM FIELD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("\'ADD\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.Then("\'ADD\' button has tooltip with \'Some values are missing or invalid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.Then("\'CANCEL\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.When("User clicks Body container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("\'Custom Field\' autocomplete last option is \'FlDAS16487_1a\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Options"});
                table2.AddRow(new string[] {
                            "FlDAS16487_1b"});
                table2.AddRow(new string[] {
                            "FlDAS16487_1c"});
#line 24
 testRunner.And("\'Custom Field\' autocomplete does NOT have options", ((string)(null)), table2, "And ");
#line hidden
#line 28
 testRunner.When("User selects \'FlDAS16487_1a\' option after search from \'Custom Field\' autocomplete" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("\'ADD\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS16487")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Mailboxes",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS16487",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 32
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
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "Mailbox",
                            "Computer",
                            "User",
                            "Application"});
                table3.AddRow(new string[] {
                            "CfDAS16487_1",
                            "FlDAS16487_1",
                            "true",
                            "true",
                            "true",
                            "true",
                            "true",
                            "true"});
#line 33
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table3, "When ");
#line hidden
#line 36
 testRunner.And("User navigates to the \'Mailbox\' details page for \'03F0CCD0F3384DE5A9F@bclabs.loca" +
                        "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then("Details page for \'03F0CCD0F3384DE5A9F@bclabs.local\' item is displayed to the user" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName"});
                table4.AddRow(new string[] {
                            "mailbox",
                            "43801",
                            "FlDAS16487_1"});
#line 39
 testRunner.And("User creates Custom Field", ((string)(null)), table4, "And ");
#line hidden
#line 42
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                        "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("\'\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("\'Custom Fields\' left submenu item with \'1\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CreateCustomField")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS16487")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CreateCustomField()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS16487",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CreateCustomField", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 47
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
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "User"});
                table5.AddRow(new string[] {
                            "CfDAS16487_2",
                            "FlDAS16487_2",
                            "true",
                            "true",
                            "true"});
#line 48
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table5, "When ");
#line hidden
#line 51
 testRunner.And("User navigates to the \'User\' details page for \'BrissonTa\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Then("Details page for \'BrissonTa (Ta Brisson)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table6.AddRow(new string[] {
                            "user",
                            "98968",
                            "FlDAS16487_2",
                            "Value_@#†_DAS16487_2"});
#line 54
 testRunner.And("User creates Custom Field", ((string)(null)), table6, "And ");
#line hidden
#line 57
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                        "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.And("\'Value_@#†_DAS16487_2\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("\'Custom Fields\' left submenu item with \'1\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then("\"1\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CancelCustomFieldCreation")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS16487")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CancelCustomFieldCreation()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS16487",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CancelCustomFieldCreation", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 63
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
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "User"});
                table7.AddRow(new string[] {
                            "CfDAS16487_3",
                            "FlDAS16487_3",
                            "true",
                            "true",
                            "true"});
#line 64
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table7, "When ");
#line hidden
#line 67
 testRunner.And("User navigates to the \'User\' details page for \'VriezeGi\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.Then("Details page for \'VriezeGi (Ginette Vrieze)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.And("User clicks \'ADD CUSTOM FIELD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.When("User selects \'FlDAS16487_3\' option from \'Custom Field\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.And("User enters \'Somve_Value\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.When("User clicks \'CANCEL\' button on popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.Then("\'Custom Fields\' left submenu item with \'0\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CreateCustomFieldWithSameData")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS16487")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CreateCustomFieldWithSameData()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS16487",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CreateCustomFieldWithSameData", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 77
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
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "User"});
                table8.AddRow(new string[] {
                            "CfDAS17614_4",
                            "FlDAS17614_4",
                            "true",
                            "true",
                            "true"});
#line 78
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table8, "When ");
#line hidden
#line 81
 testRunner.And("User navigates to the \'User\' details page for \'OBM473400\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.Then("Details page for \'OBM473400 (Jeannie L. Moreno)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.Then("\'No custom fields found for this user\' message is displayed on empty greed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table9.AddRow(new string[] {
                            "user",
                            "17884",
                            "FlDAS17614_4",
                            "Value_17614"});
#line 85
 testRunner.When("User creates Custom Field", ((string)(null)), table9, "When ");
#line hidden
#line 88
 testRunner.Then("\'FlDAS17614_4\' content is displayed in the \'Custom Field\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.And("\'Value_17614\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And("\'Custom Fields\' left submenu item with \'1\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("\"1\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table10.AddRow(new string[] {
                            "user",
                            "98968",
                            "FlDAS17614_4",
                            "Value_17614"});
#line 92
 testRunner.When("User creates Custom Field", ((string)(null)), table10, "When ");
#line hidden
#line 95
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                        "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table11.AddRow(new string[] {
                            "FlDAS17614_4"});
                table11.AddRow(new string[] {
                            "FlDAS17614_4"});
#line 96
 testRunner.And("Content in the \'Custom Field\' column is equal to", ((string)(null)), table11, "And ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table12.AddRow(new string[] {
                            "Value_17614"});
                table12.AddRow(new string[] {
                            "Value_17614"});
#line 100
 testRunner.And("Content in the \'Value\' column is equal to", ((string)(null)), table12, "And ");
#line hidden
#line 104
 testRunner.And("\'Custom Fields\' left submenu item with \'2\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.Then("\"2\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomField")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS17695")]
        [NUnit.Framework.CategoryAttribute("DAS17960")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomField()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Users",
                    "EvergreenJnr_ItemDetails",
                    "CustomFields",
                    "DAS17695",
                    "DAS17960",
                    "Cleanup"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomField", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS17695",
                        "DAS17960",
                        "Cleanup"});
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
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "FieldName",
                            "FieldLabel",
                            "AllowExternalUpdate",
                            "Enabled",
                            "User"});
                table13.AddRow(new string[] {
                            "CfDAS17695_2",
                            "FlDAS17695_2",
                            "true",
                            "true",
                            "true"});
#line 109
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table13, "When ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table14.AddRow(new string[] {
                            "user",
                            "3532",
                            "CfDAS17695_2",
                            "ValueDAS17695_2A"});
                table14.AddRow(new string[] {
                            "user",
                            "3532",
                            "CfDAS17695_2",
                            "ValueDAS17695_2B"});
#line 112
 testRunner.And("User creates Custom Field via API", ((string)(null)), table14, "And ");
#line hidden
#line 116
 testRunner.And("User navigates to the \'User\' details page for \'TAI6096068\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Checkboxes",
                            "State"});
                table15.AddRow(new string[] {
                            "Custom Field",
                            "true"});
#line 118
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table15, "When ");
#line hidden
#line 121
 testRunner.Then("Cog menu is not displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "ObjectType",
                            "ObjectId",
                            "FieldName",
                            "Value"});
                table16.AddRow(new string[] {
                            "user",
                            "3532",
                            "FlDAS17695_2",
                            "ValueDAS17695_2C"});
#line 122
 testRunner.When("User creates Custom Field", ((string)(null)), table16, "When ");
#line hidden
#line 125
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                        "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 126
 testRunner.And("\'Custom Fields\' left submenu item with \'3\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table17.AddRow(new string[] {
                            "FlDAS17695_2"});
                table17.AddRow(new string[] {
                            "FlDAS17695_2"});
                table17.AddRow(new string[] {
                            "FlDAS17695_2"});
#line 127
 testRunner.And("Content in the \'Custom Field\' column is equal to", ((string)(null)), table17, "And ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table18.AddRow(new string[] {
                            "ValueDAS17695_2A"});
                table18.AddRow(new string[] {
                            "ValueDAS17695_2B"});
                table18.AddRow(new string[] {
                            "ValueDAS17695_2C"});
#line 132
 testRunner.And("Content in the \'Value\' column is equal to", ((string)(null)), table18, "And ");
#line hidden
#line 137
 testRunner.And("Grid is not grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 138
 testRunner.Then("\'0\' options are checked in the \'GroupBy\' menu panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
