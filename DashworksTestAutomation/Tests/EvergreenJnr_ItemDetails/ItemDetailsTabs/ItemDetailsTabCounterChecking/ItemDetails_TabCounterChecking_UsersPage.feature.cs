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
namespace DashworksTestAutomation.Tests.EvergreenJnr_ItemDetails.ItemDetailsTabs.ItemDetailsTabCounterChecking
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
                        "DAS16830"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 10
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("User perform search by \"0072B088173449E3A93\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.When("User click content from \"Username\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("Details page for \"0072B088173449E3A93\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 15
 testRunner.Then("User sees following main-tabs on left menu on the Details page:", ((string)(null)), table1, "Then ");
#line 23
 testRunner.Then("\"Devices\" tab is displayed on left menu on the Details page and contains count of" +
                    " items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table2.AddRow(new string[] {
                        "User"});
            table2.AddRow(new string[] {
                        "Department and Location"});
            table2.AddRow(new string[] {
                        "Custom Fields"});
#line 25
 testRunner.Then("\"Details\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table2, "Then ");
#line 31
 testRunner.Then("\"Custom Fields\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.Then("\"Department and Location\" tab is displayed on left menu on the Details page and N" +
                    "OT contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then("\"User\" tab is displayed on left menu on the Details page and NOT contains count o" +
                    "f items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table3.AddRow(new string[] {
                        "Evergreen Details"});
            table3.AddRow(new string[] {
                        "User Projects"});
            table3.AddRow(new string[] {
                        "Device Project Summary"});
            table3.AddRow(new string[] {
                        "Mailbox Project Summary"});
#line 35
 testRunner.Then("\"Projects\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table3, "Then ");
#line 41
 testRunner.Then("\"Project Details\" sub-tab is displayed with disabled state on left menu on the De" +
                    "tails page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Then("\"User Projects\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("\"Device Project Summary\" tab is displayed on left menu on the Details page and co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.Then("\"Mailbox Project Summary\" tab is displayed on left menu on the Details page and c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.Then("\"Evergreen Details\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.Then("\"Project Details\" tab is displayed on left menu on the Details page and NOT conta" +
                    "ins count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table4.AddRow(new string[] {
                        "Groups"});
            table4.AddRow(new string[] {
                        "LDAP"});
#line 49
 testRunner.Then("\"Active Directory\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table4, "Then ");
#line 55
 testRunner.Then("\"Groups\" tab is displayed on left menu on the Details page and contains count of " +
                    "items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("\"Active Directory\" tab is displayed on left menu on the Details page and NOT cont" +
                    "ains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("\"LDAP\" tab is displayed on left menu on the Details page and NOT contains count o" +
                    "f items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table5.AddRow(new string[] {
                        "Evergreen Summary"});
            table5.AddRow(new string[] {
                        "Evergreen Detail"});
            table5.AddRow(new string[] {
                        "Advertisements"});
            table5.AddRow(new string[] {
                        "Collections"});
#line 59
 testRunner.Then("\"Applications\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table5, "Then ");
#line 66
 testRunner.Then("\"Evergreen Summary\" tab is displayed on left menu on the Details page and contain" +
                    "s count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.Then("\"Evergreen Detail\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.Then("\"Advertisements\" tab is displayed on left menu on the Details page and contains c" +
                    "ount of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.Then("\"Collections\" tab is displayed on left menu on the Details page and contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table6.AddRow(new string[] {
                        "Mailboxes"});
            table6.AddRow(new string[] {
                        "Mailbox Permissions"});
#line 71
 testRunner.Then("\"Mailboxes\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table6, "Then ");
#line 76
 testRunner.Then("\"Mailboxes\" tab is displayed on left menu on the Details page and contains count " +
                    "of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Then("\"Mailbox Permissions\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 79
 testRunner.Then("\"Compliance\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table7, "Then ");
#line 87
 testRunner.Then("\"Application Issues\" tab is displayed on left menu on the Details page and contai" +
                    "ns count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.Then("\"Overview\" tab is displayed on left menu on the Details page and NOT contains cou" +
                    "nt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.Then("\"Hardware Summary\" tab is displayed on left menu on the Details page and NOT cont" +
                    "ains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.Then("\"Hardware Rules\" tab is displayed on left menu on the Details page and contains c" +
                    "ount of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.Then("\"Application Summary\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 94
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line 95
 testRunner.When("User clicks \"Users\" on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("\"Users\" list should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("User perform search by \"0072B088173449E3A93\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User click content from \"Username\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("Details page for \"0072B088173449E3A93\" item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When("User switches to the \"User Evergreen Capacity Project\" project in the Top bar on " +
                    "Item details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 101
 testRunner.Then("User sees following main-tabs on left menu on the Details page:", ((string)(null)), table8, "Then ");
#line 109
 testRunner.Then("\"Devices\" tab is displayed on left menu on the Details page and contains count of" +
                    " items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table9.AddRow(new string[] {
                        "User"});
            table9.AddRow(new string[] {
                        "Department and Location"});
            table9.AddRow(new string[] {
                        "Custom Fields"});
#line 111
 testRunner.Then("\"Details\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table9, "Then ");
#line 117
 testRunner.Then("\"Custom Fields\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.Then("\"Department and Location\" tab is displayed on left menu on the Details page and N" +
                    "OT contains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Then("\"User\" tab is displayed on left menu on the Details page and NOT contains count o" +
                    "f items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 121
 testRunner.Then("\"Projects\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table10, "Then ");
#line 129
 testRunner.Then("\"User Projects\" tab is displayed on left menu on the Details page and contains co" +
                    "unt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("\"Device Project Summary\" tab is displayed on left menu on the Details page and co" +
                    "ntains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("\"Mailbox Project Summary\" tab is displayed on left menu on the Details page and c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.Then("\"Evergreen Details\" tab is displayed on left menu on the Details page and NOT con" +
                    "tains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.Then("\"Project Details\" tab is displayed on left menu on the Details page and NOT conta" +
                    "ins count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table11.AddRow(new string[] {
                        "Groups"});
            table11.AddRow(new string[] {
                        "LDAP"});
#line 135
 testRunner.Then("\"Active Directory\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table11, "Then ");
#line 140
 testRunner.Then("\"Groups\" tab is displayed on left menu on the Details page and contains count of " +
                    "items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
 testRunner.Then("\"LDAP\" tab is displayed on left menu on the Details page and NOT contains count o" +
                    "f items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table12.AddRow(new string[] {
                        "Evergreen Summary"});
            table12.AddRow(new string[] {
                        "Evergreen Detail"});
            table12.AddRow(new string[] {
                        "Advertisements"});
            table12.AddRow(new string[] {
                        "Collections"});
#line 143
 testRunner.Then("\"Applications\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table12, "Then ");
#line 150
 testRunner.Then("\"Evergreen Summary\" tab is displayed on left menu on the Details page and contain" +
                    "s count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.Then("\"Evergreen Detail\" tab is displayed on left menu on the Details page and contains" +
                    " count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.Then("\"Advertisements\" tab is displayed on left menu on the Details page and contains c" +
                    "ount of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.Then("\"Collections\" tab is displayed on left menu on the Details page and contains coun" +
                    "t of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "SubTabName"});
            table13.AddRow(new string[] {
                        "Mailboxes"});
            table13.AddRow(new string[] {
                        "Mailbox Permissions"});
#line 155
 testRunner.Then("\"Mailboxes\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table13, "Then ");
#line 160
 testRunner.Then("\"Mailboxes\" tab is displayed on left menu on the Details page and contains count " +
                    "of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.Then("\"Mailbox Permissions\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 163
 testRunner.Then("\"Compliance\" main-menu on the Details page contains following sub-menu:", ((string)(null)), table14, "Then ");
#line 171
 testRunner.Then("\"Application Issues\" tab is displayed on left menu on the Details page and contai" +
                    "ns count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
 testRunner.Then("\"Overview\" tab is displayed on left menu on the Details page and NOT contains cou" +
                    "nt of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.Then("\"Hardware Summary\" tab is displayed on left menu on the Details page and NOT cont" +
                    "ains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
 testRunner.Then("\"Hardware Rules\" tab is displayed on left menu on the Details page and contains c" +
                    "ount of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.Then("\"Application Summary\" tab is displayed on left menu on the Details page and NOT c" +
                    "ontains count of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion

