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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.Tabs.CustomFields
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DeleteCustomFields")]
    public partial class DeleteCustomFieldsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeleteCustomFields.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeleteCustomFields", "\tDelete Custom fields", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_DevicesList_CheckCustomFieldDeleting")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Devices")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS16489")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_DevicesList_CheckCustomFieldDeleting()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_DevicesList_CheckCustomFieldDeletingInternal();
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

        private void EvergreenJnr_DevicesList_CheckCustomFieldDeletingInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_DevicesList_CheckCustomFieldDeleting", null, new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS16489",
                        "Cleanup"});
#line 9
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
                        "CfDAS16489_1",
                        "FlDAS16489_1",
                        "true",
                        "true",
                        "true"});
#line 10
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ObjectType",
                        "ObjectId",
                        "FieldName",
                        "Value"});
            table2.AddRow(new string[] {
                        "device",
                        "17266",
                        "CfDAS16489_1",
                        "ValueDAS16489_1"});
#line 13
 testRunner.And("User creates Custom Field via API", ((string)(null)), table2, "And ");
#line 17
 testRunner.And("User navigates to the \'Device\' details page for \'WIN-KTJC6PMV2P5\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("Details page for \'WIN-KTJC6PMV2P5\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.When("User clicks \'Delete\' option in Cog-menu for \'FlDAS16489_1\' item from \'Custom Fiel" +
                    "d\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("\'The selected custom field will be permanently deleted\' text is displayed on inli" +
                    "ne tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("User clicks \'CANCEL\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("inline tip banner is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("\'ValueDAS16489_1\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("User clicks \'Delete\' option in Cog-menu for \'FlDAS16489_1\' item from \'Custom Fiel" +
                    "d\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("\'The selected custom field will be permanently deleted\' text is displayed on inli" +
                    "ne tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Success message with \"Custom field value deleted successfully\" text is displayed " +
                    "on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("\'No custom fields found for this device\' message is displayed on empty greed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.And("\'ValueDAS16489_1\' content is not displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("\'Custom Fields\' left submenu item with \'0\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("There are no errors in the browser console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_MailboxesList_DeleteGroupedCustomFields")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Mailboxes")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("CustomFields")]
        [NUnit.Framework.CategoryAttribute("DAS17695")]
        [NUnit.Framework.CategoryAttribute("DAS18362")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_MailboxesList_DeleteGroupedCustomFields()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_MailboxesList_DeleteGroupedCustomFieldsInternal();
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

        private void EvergreenJnr_MailboxesList_DeleteGroupedCustomFieldsInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_MailboxesList_DeleteGroupedCustomFields", null, new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_ItemDetails",
                        "CustomFields",
                        "DAS17695",
                        "DAS18362",
                        "Cleanup"});
#line 37
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
                        "Mailbox"});
            table3.AddRow(new string[] {
                        "CfDAS17695_1",
                        "FlDAS17695_1",
                        "true",
                        "true",
                        "true"});
#line 38
 testRunner.When("User creates new Custom Field via API", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ObjectType",
                        "ObjectId",
                        "FieldName",
                        "Value"});
            table4.AddRow(new string[] {
                        "mailbox",
                        "48731",
                        "CfDAS17695_1",
                        "ValueDAS17695_1A"});
            table4.AddRow(new string[] {
                        "mailbox",
                        "48731",
                        "CfDAS17695_1",
                        "ValueDAS17695_1B"});
#line 41
 testRunner.And("User creates Custom Field via API", ((string)(null)), table4, "And ");
#line 45
 testRunner.And("User navigates to the \'Mailbox\' details page for \'gregoja@bclabs.local\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("Details page for \'gregoja@bclabs.local\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Checkboxes",
                        "State"});
            table5.AddRow(new string[] {
                        "Value",
                        "true"});
#line 48
 testRunner.When("User clicks Group By button and set checkboxes state", ((string)(null)), table5, "When ");
#line 51
 testRunner.Then("Cog menu is not displayed on the Admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("User expands \'ValueDAS17695_1A\' row in the groped grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.When("User clicks \'Delete\' option in Cog-menu for \'FlDAS17695_1\' item from \'Custom Fiel" +
                    "d\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("\'The selected custom field will be permanently deleted\' text is displayed on inli" +
                    "ne tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When("User clicks \'DELETE\' button on inline tip banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("Success message with \"Custom field value deleted successfully\" text is displayed " +
                    "on Action panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.And("Grid is grouped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("\'1\' options are checked in the \'GroupBy\' menu panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.And("\'Custom Fields\' left submenu item with \'1\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("User expands \'ValueDAS17695_1B\' row in the groped grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("\'ValueDAS17695_1A\' content is not displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.And("\'ValueDAS17695_1B\' content is displayed in the \'Value\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

