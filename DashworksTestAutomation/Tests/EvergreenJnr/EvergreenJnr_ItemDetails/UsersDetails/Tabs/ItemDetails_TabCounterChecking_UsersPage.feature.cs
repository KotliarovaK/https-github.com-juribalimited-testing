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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.UsersDetails.Tabs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_TabCounterChecking_UsersPage")]
    public partial class ItemDetails_TabCounterChecking_UsersPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ItemDetails_TabCounterChecking_UsersPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_TabCounterChecking_UsersPage", "\tRuns Item Details TabCounterChecking_UsersPage related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyFo" +
            "rUsersPageInEvergreenMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16378")]
        [NUnit.Framework.CategoryAttribute("DAS16418")]
        [NUnit.Framework.CategoryAttribute("DAS16415")]
        [NUnit.Framework.CategoryAttribute("DAS15583")]
        [NUnit.Framework.CategoryAttribute("DAS15348")]
        [NUnit.Framework.CategoryAttribute("DAS17141")]
        [NUnit.Framework.CategoryAttribute("DAS16830")]
        [NUnit.Framework.CategoryAttribute("DAS18198")]
        public virtual void EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenModeInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyFo" +
                    "rUsersPageInEvergreenMode", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16378",
                        "DAS16418",
                        "DAS16415",
                        "DAS15583",
                        "DAS15348",
                        "DAS17141",
                        "DAS16830",
                        "DAS18198"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User navigates to the \'User\' details page for \'0072B088173449E3A93\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Details page for \'0072B088173449E3A93\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabName"});
            table1.AddRow(new string[] {
                        "Details"});
            table1.AddRow(new string[] {
                        "Projects"});
            table1.AddRow(new string[] {
                        "Active Directory"});
            table1.AddRow(new string[] {
                        "Applications"});
            table1.AddRow(new string[] {
                        "Mailboxes"});
            table1.AddRow(new string[] {
                        "Compliance"});
#line 12
 testRunner.And("User sees following parent left menu items", ((string)(null)), table1, "And ");
#line 20
 testRunner.And("\'Devices\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table2.AddRow(new string[] {
                        "User"});
            table2.AddRow(new string[] {
                        "Department and Location"});
            table2.AddRow(new string[] {
                        "Custom Fields"});
#line 22
 testRunner.And("\'Details\' left menu have following submenu items:", ((string)(null)), table2, "And ");
#line 28
 testRunner.And("\'Custom Fields\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("\'Department and Location\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("\'User\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table3.AddRow(new string[] {
                        "Evergreen Details"});
            table3.AddRow(new string[] {
                        "Project Details"});
            table3.AddRow(new string[] {
                        "User Projects"});
            table3.AddRow(new string[] {
                        "Device Project Summary"});
            table3.AddRow(new string[] {
                        "Mailbox Project Summary"});
#line 33
 testRunner.Then("\'Projects\' left menu have following submenu items:", ((string)(null)), table3, "Then ");
#line 41
 testRunner.And("\'User Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("\'Device Project Summary\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("\'Mailbox Project Summary\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("\'Evergreen Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("\'Project Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("User navigates to the \'Active Directory\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table4.AddRow(new string[] {
                        "Groups"});
            table4.AddRow(new string[] {
                        "LDAP"});
#line 48
 testRunner.Then("\'Active Directory\' left menu have following submenu items:", ((string)(null)), table4, "Then ");
#line 54
 testRunner.And("\'Groups\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("\'LDAP\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table5.AddRow(new string[] {
                        "Evergreen Summary"});
            table5.AddRow(new string[] {
                        "Evergreen Detail"});
            table5.AddRow(new string[] {
                        "Evergreen Owned"});
            table5.AddRow(new string[] {
                        "Project Owned"});
            table5.AddRow(new string[] {
                        "Advertisements"});
            table5.AddRow(new string[] {
                        "Collections"});
#line 59
 testRunner.Then("\'Applications\' left menu have following submenu items:", ((string)(null)), table5, "Then ");
#line 68
 testRunner.And("\'Evergreen Summary\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("\'Evergreen Detail\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("\'Evergreen Owned\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("\'Advertisements\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("\'Collections\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.When("User navigates to the \'Mailboxes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table6.AddRow(new string[] {
                        "Mailboxes"});
            table6.AddRow(new string[] {
                        "Mailbox Permissions"});
#line 75
 testRunner.Then("\'Mailboxes\' left menu have following submenu items:", ((string)(null)), table6, "Then ");
#line 80
 testRunner.And("\'Mailboxes\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("\'Mailbox Permissions\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.When("User navigates to the \'Compliance\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table7.AddRow(new string[] {
                        "Overview"});
            table7.AddRow(new string[] {
                        "Hardware Summary"});
            table7.AddRow(new string[] {
                        "Hardware Rules"});
            table7.AddRow(new string[] {
                        "Application Summary"});
            table7.AddRow(new string[] {
                        "Application Issues"});
#line 84
 testRunner.Then("\'Compliance\' left menu have following submenu items:", ((string)(null)), table7, "Then ");
#line 92
 testRunner.And("\'Application Issues\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("\'Overview\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("\'Hardware Summary\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("\'Hardware Rules\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("\'Application Summary\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyFo" +
            "rUsersPageInProjectMode")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS15583")]
        [NUnit.Framework.CategoryAttribute("DAS16884")]
        public virtual void EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectMode()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectModeInternal();
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

        private void EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectModeInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyFo" +
                    "rUsersPageInProjectMode", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS15583",
                        "DAS16884"});
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 100
 testRunner.When("User navigates to the \'User\' details page for \'0072B088173449E3A93\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("Details page for \'0072B088173449E3A93\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("User selects \'User Evergreen Capacity Project\' in the \'Item Details Project\' drop" +
                    "down with wait", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabName"});
            table8.AddRow(new string[] {
                        "Details"});
            table8.AddRow(new string[] {
                        "Projects"});
            table8.AddRow(new string[] {
                        "Active Directory"});
            table8.AddRow(new string[] {
                        "Applications"});
            table8.AddRow(new string[] {
                        "Mailboxes"});
            table8.AddRow(new string[] {
                        "Compliance"});
#line 103
 testRunner.Then("User sees following parent left menu items", ((string)(null)), table8, "Then ");
#line 111
 testRunner.And("\'Devices\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table9.AddRow(new string[] {
                        "User"});
            table9.AddRow(new string[] {
                        "Department and Location"});
            table9.AddRow(new string[] {
                        "Custom Fields"});
#line 113
 testRunner.And("\'Details\' left menu have following submenu items:", ((string)(null)), table9, "And ");
#line 119
 testRunner.And("\'Custom Fields\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("\'Department and Location\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("\'User\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table10.AddRow(new string[] {
                        "Evergreen Details"});
            table10.AddRow(new string[] {
                        "Project Details"});
            table10.AddRow(new string[] {
                        "User Projects"});
            table10.AddRow(new string[] {
                        "Device Project Summary"});
            table10.AddRow(new string[] {
                        "Mailbox Project Summary"});
#line 124
 testRunner.Then("\'Projects\' left menu have following submenu items:", ((string)(null)), table10, "Then ");
#line 132
 testRunner.And("\'User Projects\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("\'Device Project Summary\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("\'Mailbox Project Summary\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("\'Evergreen Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("\'Project Details\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.When("User navigates to the \'Active Directory\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table11.AddRow(new string[] {
                        "Groups"});
            table11.AddRow(new string[] {
                        "LDAP"});
#line 139
 testRunner.Then("\'Active Directory\' left menu have following submenu items:", ((string)(null)), table11, "Then ");
#line 144
 testRunner.And("\'Groups\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("\'LDAP\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table12.AddRow(new string[] {
                        "Evergreen Summary"});
            table12.AddRow(new string[] {
                        "Evergreen Detail"});
            table12.AddRow(new string[] {
                        "Evergreen Owned"});
            table12.AddRow(new string[] {
                        "Project Owned"});
            table12.AddRow(new string[] {
                        "Advertisements"});
            table12.AddRow(new string[] {
                        "Collections"});
#line 148
 testRunner.Then("\'Applications\' left menu have following submenu items:", ((string)(null)), table12, "Then ");
#line 157
 testRunner.And("\'Evergreen Summary\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("\'Evergreen Detail\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And("\'Advertisements\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("\'Collections\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.When("User navigates to the \'Mailboxes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table13.AddRow(new string[] {
                        "Mailboxes"});
            table13.AddRow(new string[] {
                        "Mailbox Permissions"});
#line 163
 testRunner.Then("\'Mailboxes\' left menu have following submenu items:", ((string)(null)), table13, "Then ");
#line 168
 testRunner.And("\'Mailboxes\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.And("\'Mailbox Permissions\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.When("User navigates to the \'Compliance\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table14.AddRow(new string[] {
                        "Overview"});
            table14.AddRow(new string[] {
                        "Hardware Summary"});
            table14.AddRow(new string[] {
                        "Hardware Rules"});
            table14.AddRow(new string[] {
                        "Application Summary"});
            table14.AddRow(new string[] {
                        "Application Issues"});
#line 172
 testRunner.Then("\'Compliance\' left menu have following submenu items:", ((string)(null)), table14, "Then ");
#line 180
 testRunner.And("\'Application Issues\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And("\'Hardware Rules\' left submenu item with some count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And("\'Overview\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
 testRunner.And("\'Hardware Summary\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
 testRunner.And("\'Application Summary\' left submenu item is displayed without count", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfF" +
            "ieldsInTheTable")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS16830")]
        [NUnit.Framework.CategoryAttribute("Do_Not_Run_With_Projects")]
        public virtual void EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfFieldsInTheTable()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfFieldsInTheTableInternal();
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

        private void EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfFieldsInTheTableInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfF" +
                    "ieldsInTheTable", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS16830",
                        "Do_Not_Run_With_Projects"});
#line 187
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 188
 testRunner.When("User navigates to the \'User\' details page for \'ACG370114\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 189
 testRunner.Then("Details page for \'ACG370114\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 190
 testRunner.And("\'Custom Fields\' left submenu item with \'3\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
 testRunner.When("User navigates to the \'Custom Fields\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 192
 testRunner.Then("\"3\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 194
 testRunner.And("User navigates to the \'User Projects\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.Then("\'User Projects\' left submenu item with \'7\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.And("\"7\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.When("User navigates to the \'Device Project Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
 testRunner.Then("\'Device Project Summary\' left submenu item with \'14\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.And("\"14\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.When("User navigates to the \'Devices\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
 testRunner.Then("\'Devices\' left submenu item with \'2\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
 testRunner.And("\"2\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 204
 testRunner.And("User navigates to the \'Evergreen Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 205
 testRunner.Then("\'Evergreen Summary\' left submenu item with \'7\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 206
 testRunner.And("\"7\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
 testRunner.When("User navigates to the \'Evergreen Detail\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 208
 testRunner.Then("\'Evergreen Detail\' left submenu item with \'16\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 209
 testRunner.And("\"16\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 210
 testRunner.When("User navigates to the \'Compliance\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 211
 testRunner.And("User navigates to the \'Hardware Rules\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 212
 testRunner.Then("\'Hardware Rules\' left submenu item with \'2\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 213
 testRunner.And("\"2\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 214
 testRunner.When("User navigates to the \'Application Issues\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 215
 testRunner.Then("\'Application Issues\' left submenu item with \'2\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 216
 testRunner.And("\"2\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
 testRunner.When("User navigates to the \'User\' details page for \'0137C8E69921432992B\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 218
 testRunner.Then("Details page for \'0137C8E69921432992B\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 219
 testRunner.When("User navigates to the \'Projects\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 220
 testRunner.And("User navigates to the \'Mailbox Project Summary\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 221
 testRunner.Then("\'Mailbox Project Summary\' left submenu item with \'2\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 222
 testRunner.And("\"2\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
 testRunner.When("User navigates to the \'Active Directory\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 224
 testRunner.And("User navigates to the \'Groups\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 225
 testRunner.Then("\'Groups\' left submenu item with \'1\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 226
 testRunner.And("\"1\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 227
 testRunner.When("User navigates to the \'Mailboxes\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 228
 testRunner.And("User navigates to the \'Mailboxes\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 229
 testRunner.Then("\'Mailboxes\' left submenu item with \'1\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 230
 testRunner.And("\"1\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 231
 testRunner.When("User navigates to the \'User\' details page for \'allanj\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 232
 testRunner.Then("Details page for \'allanj\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 233
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 234
 testRunner.And("User navigates to the \'Advertisements\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 235
 testRunner.Then("\'Advertisements\' left submenu item with \'5\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 236
 testRunner.And("\"5\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 237
 testRunner.When("User navigates to the \'Collections\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 238
 testRunner.Then("\'Collections\' left submenu item with \'9\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 239
 testRunner.And("\"9\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollecti" +
            "onsForThisUser")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17769")]
        public virtual void EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollectionsForThisUser()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollectionsForThisUserInternal();
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

        private void EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollectionsForThisUserInternal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollecti" +
                    "onsForThisUser", null, new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17769"});
#line 242
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 243
 testRunner.When("User navigates to the \'User\' details page for \'allanj\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 244
 testRunner.Then("Details page for \'allanj (Jo Allan)\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 245
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 246
 testRunner.And("User navigates to the \'Collections\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 247
 testRunner.Then("\"9\" rows found label displays on Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 248
 testRunner.And("\'Collections\' left submenu item with \'9\' count is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

