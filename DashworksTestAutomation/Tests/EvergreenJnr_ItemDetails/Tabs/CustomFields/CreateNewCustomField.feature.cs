// ------------------------------------------------------------------------------
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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.Tabs.CustomFields
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateNewCustomField")]
    public partial class CreateNewCustomFieldFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
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
 testRunner.Given("User is logged in to the Projects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("User navigate to Manage link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.And("User select \"Custom Fields\" option in Management Console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltipsInternal();
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

        private void EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltipsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Do_Not_Run_With_CustomFields",
                        "Cleanup"});
#line 10
this.ScenarioInitialize(scenarioInfo);
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
#line 11
 testRunner.When("User creates new Custom Field", ((string)(null)), table1, "When ");
#line 16
 testRunner.And("User navigate to Evergreen URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("User navigates to the \'Device\' details page for \'QFI94WAUX17N4I\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("Details page for \"QFI94WAUX17N4I\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.And("User clicks \'ADD CUSTOM FIELD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("\'ADD\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("\'ADD\' button has tooltip with \'Some values are missing or invalid\' text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("\'CANCEL\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.When("User clicks Body container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("\'Custom Field\' autocomplete last option is \'FlDAS16487_1a\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table2.AddRow(new string[] {
                        "FlDAS16487_1b"});
            table2.AddRow(new string[] {
                        "FlDAS16487_1c"});
#line 26
 testRunner.And("\'Custom Field\' autocomplete does NOT have options", ((string)(null)), table2, "And ");
#line 30
 testRunner.When("User selects \'FlDAS16487_1a\' option after search from \'Custom Field\' autocomplete" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("\'ADD\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValueInternal();
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

        private void EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValueInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 34
this.ScenarioInitialize(scenarioInfo);
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
#line 35
 testRunner.When("User creates new Custom Field", ((string)(null)), table3, "When ");
#line 38
 testRunner.And("User navigates to the \'Mailbox\' details page for \'03F0CCD0F3384DE5A9F@bclabs.loca" +
                    "l\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("Details page for \"03F0CCD0F3384DE5A9F@bclabs.local\" item is displayed to the user" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
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
#line 41
 testRunner.And("User creates Custom Field", ((string)(null)), table4, "And ");
#line 44
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                    "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.And("\'\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("\'Custom Fields\' tab is displayed on left menu on the Details page and contains \'1" +
                    "\' count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CreateCustomFieldInternal();
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

        private void EvergreenJnr_UsersList_CreateCustomFieldInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CreateCustomField", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 49
this.ScenarioInitialize(scenarioInfo);
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
#line 50
 testRunner.When("User creates new Custom Field", ((string)(null)), table5, "When ");
#line 53
 testRunner.And("User navigates to the \'User\' details page for \'BrissonTa\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("Details page for \"BrissonTa (Ta Brisson)\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
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
#line 56
 testRunner.And("User creates Custom Field", ((string)(null)), table6, "And ");
#line 59
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                    "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.And("\'Value_@#†_DAS16487_2\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("\'Custom Fields\' tab is displayed on left menu on the Details page and contains \'1" +
                    "\' count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("\"1\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CancelCustomFieldCreationInternal();
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

        private void EvergreenJnr_UsersList_CancelCustomFieldCreationInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CancelCustomFieldCreation", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 65
this.ScenarioInitialize(scenarioInfo);
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
#line 66
 testRunner.When("User creates new Custom Field", ((string)(null)), table7, "When ");
#line 69
 testRunner.And("User navigates to the \'User\' details page for \'VriezeGi\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("Details page for \"VriezeGi (Ginette Vrieze)\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.And("User clicks \'ADD CUSTOM FIELD\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.When("User selects \'FlDAS16487_3\' option from \'Custom Field\' autocomplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.And("User enters \'Somve_Value\' text to \'Value\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("User clicks Cancel button on Add Custom Field popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then("\'Custom Fields\' tab is displayed on left menu on the Details page and contains \'0" +
                    "\' count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CreateCustomFieldWithSameDataInternal();
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

        private void EvergreenJnr_UsersList_CreateCustomFieldWithSameDataInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CreateCustomFieldWithSameData", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16487",
                        "Cleanup"});
#line 79
this.ScenarioInitialize(scenarioInfo);
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
#line 80
 testRunner.When("User creates new Custom Field", ((string)(null)), table8, "When ");
#line 83
 testRunner.And("User navigates to the \'User\' details page for \'OBM473400\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.Then("Details page for \"OBM473400 (Jeannie L. Moreno)\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
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
#line 87
 testRunner.When("User creates Custom Field", ((string)(null)), table9, "When ");
#line 90
 testRunner.Then("\'FlDAS17614_4\' content is displayed in the \'Custom Field\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And("\'Value_17614\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("\'Custom Fields\' tab is displayed on left menu on the Details page and contains \'1" +
                    "\' count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
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
#line 94
 testRunner.When("User creates Custom Field", ((string)(null)), table10, "When ");
#line 97
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                    "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table11.AddRow(new string[] {
                        "FlDAS17614_4"});
            table11.AddRow(new string[] {
                        "FlDAS17614_4"});
#line 98
 testRunner.And("Content in the \'Custom Field\' column is equal to", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table12.AddRow(new string[] {
                        "Value_17614"});
            table12.AddRow(new string[] {
                        "Value_17614"});
#line 102
 testRunner.And("Content in the \'Value\' column is equal to", ((string)(null)), table12, "And ");
#line 106
 testRunner.And("\'Custom Fields\' tab is displayed on left menu on the Details page and contains \'2" +
                    "\' count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("\"2\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
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
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomFieldInternal();
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

        private void EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomFieldInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomField", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS17695",
                        "DAS17960",
                        "Cleanup"});
#line 110
this.ScenarioInitialize(scenarioInfo);
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
#line 111
 testRunner.When("User creates new Custom Field", ((string)(null)), table13, "When ");
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
#line 114
 testRunner.And("User creates Custom Field via API", ((string)(null)), table14, "And ");
#line 118
 testRunner.And("User navigates to the \'User\' details page for \'TAI6096068\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("User clicks Group By button on the Admin page and selects \"Custom Field\" value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("Cog menu is not displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ObjectType",
                        "ObjectId",
                        "FieldName",
                        "Value"});
            table15.AddRow(new string[] {
                        "user",
                        "3532",
                        "FlDAS17695_2",
                        "ValueDAS17695_2C"});
#line 122
 testRunner.When("User creates Custom Field", ((string)(null)), table15, "When ");
#line 125
 testRunner.Then("Success message with \"New custom field value added successfully\" text is displaye" +
                    "d on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.And("\'Custom Fields\' tab is displayed on left menu on the Details page and contains \'3" +
                    "\' count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table16.AddRow(new string[] {
                        "FlDAS17695_2"});
            table16.AddRow(new string[] {
                        "FlDAS17695_2"});
            table16.AddRow(new string[] {
                        "FlDAS17695_2"});
#line 127
 testRunner.And("Content in the \'Custom Field\' column is equal to", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Content"});
            table17.AddRow(new string[] {
                        "ValueDAS17695_2A"});
            table17.AddRow(new string[] {
                        "ValueDAS17695_2B"});
            table17.AddRow(new string[] {
                        "ValueDAS17695_2C"});
#line 132
 testRunner.And("Content in the \'Value\' column is equal to", ((string)(null)), table17, "And ");
#line 137
 testRunner.And("Grid is not grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("\'0\' options are selected in the Group By menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

