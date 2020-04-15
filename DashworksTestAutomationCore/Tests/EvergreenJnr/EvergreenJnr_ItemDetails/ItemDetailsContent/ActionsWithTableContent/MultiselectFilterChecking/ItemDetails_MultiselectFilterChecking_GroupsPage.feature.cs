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
namespace DashworksTestAutomationCore.Tests.EvergreenJnr.EvergreenJnr_ItemDetails.ItemDetailsContent.ActionsWithTableContent.MultiselectFilterChecking
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemDetails_MultiselectFilterChecking_GroupsPage")]
    public partial class ItemDetails_MultiselectFilterChecking_GroupsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemDetails_MultiselectFilterChecking_GroupsPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ItemDetails_MultiselectFilterChecking_GroupsPage", "\tRuns Multiselect Filter Checking for Groups Page related tests", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRela" +
            "tedMultiselectFilterForMembersTabOnGroupsPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Groups")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS17761")]
        [NUnit.Framework.CategoryAttribute("DAS20491")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMembersTabOnGroupsPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMembersTabOnGroupsPageInternal();
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

        private void EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMembersTabOnGroupsPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS17761",
                    "DAS20491",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRela" +
                    "tedMultiselectFilterForMembersTabOnGroupsPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS17761",
                        "DAS20491",
                        "Zion_NewGrid"});
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
 testRunner.When("User type \"Schema Admins\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("User clicks on \"Schema Admins\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.And("Details page for \'Schema Admins\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.When("User navigates to the \'Members\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.When("User navigates to the \'User Members\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("\'DEV50\' content is displayed in the \'Domain\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.Then("\'TRUE\' content is displayed in the \'Enabled\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.When("User opens \'Username\' column settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("User select \"Username\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("User select \"Directory Type\" checkbox on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("User clicks Column button on the Column Settings panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3161 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3161.AddRow(new string[] {
                            "DEV50"});
#line 22
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Domain\' c" +
                        "olumn:", ((string)(null)), table3161, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3162 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3162.AddRow(new string[] {
                            "True"});
#line 25
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Enabled\' " +
                        "column:", ((string)(null)), table3162, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3163 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3163.AddRow(new string[] {
                            "Active Directory"});
#line 28
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Directory" +
                        " Type\' column:", ((string)(null)), table3163, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabCollecti" +
            "onsSubTabForGroupPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Groups")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS20490")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabCollectionsSubTabForGroupPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabCollectionsSubTabForGroupPageInternal();
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

        private void EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabCollectionsSubTabForGroupPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20490",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabCollecti" +
                    "onsSubTabForGroupPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20490",
                        "Zion_NewGrid"});
#line 33
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
#line 34
 testRunner.When("User type \"Schema Admins\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then("User clicks on \"Schema Admins\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("Details page for \'Schema Admins\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.When("User navigates to the \'Collections\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3164 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table3164.AddRow(new string[] {
                            "All Active Directory Security Groups"});
                table3164.AddRow(new string[] {
                            "All User Groups"});
#line 39
 testRunner.Then("Content in the \'Collection\' column is equal to", ((string)(null)), table3164, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3165 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table3165.AddRow(new string[] {
                            "JuribaDEV50"});
                table3165.AddRow(new string[] {
                            "JuribaDEV50"});
#line 43
 testRunner.Then("Content in the \'Site\' column is equal to", ((string)(null)), table3165, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3166 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table3166.AddRow(new string[] {
                            "SMS/SCCM 2007"});
                table3166.AddRow(new string[] {
                            "SMS/SCCM 2007"});
#line 47
 testRunner.Then("Content in the \'Import Type\' column is equal to", ((string)(null)), table3166, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3167 = new TechTalk.SpecFlow.Table(new string[] {
                            "Content"});
                table3167.AddRow(new string[] {
                            "DC1 SMS (DEV50)"});
                table3167.AddRow(new string[] {
                            "DC1 SMS (DEV50)"});
#line 51
 testRunner.Then("Content in the \'Import\' column is equal to", ((string)(null)), table3167, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3168 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3168.AddRow(new string[] {
                            "All Active Directory Security Groups"});
                table3168.AddRow(new string[] {
                            "All User Groups"});
#line 55
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Collectio" +
                        "n\' column:", ((string)(null)), table3168, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3169 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3169.AddRow(new string[] {
                            "JuribaDEV50"});
#line 59
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Site\' col" +
                        "umn:", ((string)(null)), table3169, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3170 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3170.AddRow(new string[] {
                            "SMS/SCCM 2007"});
#line 62
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Import Ty" +
                        "pe\' column:", ((string)(null)), table3170, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3171 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3171.AddRow(new string[] {
                            "DC1 SMS (DEV50)"});
#line 65
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Import\' c" +
                        "olumn:", ((string)(null)), table3171, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabApplicat" +
            "ionsSubTabForGroupPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Groups")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS20489")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        public virtual void EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabApplicationsSubTabForGroupPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabApplicationsSubTabForGroupPageInternal();
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

        private void EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabApplicationsSubTabForGroupPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20489",
                    "Zion_NewGrid"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabApplicat" +
                    "ionsSubTabForGroupPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20489",
                        "Zion_NewGrid"});
#line 70
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
#line 71
 testRunner.When("User type \"GSMS-ReportViewer\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.Then("User clicks on \"GSMS-ReportViewer\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.And("Details page for \'GSMS-ReportViewer\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.When("User navigates to the \'Applications\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.When("User navigates to the \'Applications\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3172 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3172.AddRow(new string[] {
                            "Application"});
                table3172.AddRow(new string[] {
                            "Version"});
                table3172.AddRow(new string[] {
                            "Manufacturer"});
                table3172.AddRow(new string[] {
                            "Compliance"});
                table3172.AddRow(new string[] {
                            "Site"});
                table3172.AddRow(new string[] {
                            "Advertisement"});
                table3172.AddRow(new string[] {
                            "Collection"});
                table3172.AddRow(new string[] {
                            "Program"});
#line 76
 testRunner.Then("ColumnName is displayed in following order on the Details page:", ((string)(null)), table3172, "Then ");
#line hidden
#line 86
 testRunner.Then("\'Microsoft Report Viewer Redistributable 2005 (8.0.50727.42)\' content is displaye" +
                        "d in the \'Application\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.Then("\'8.0.50727.42\' content is displayed in the \'Version\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.Then("\'Microsoft Corporation\' content is displayed in the \'Manufacturer\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.Then("\'UNKNOWN\' content is displayed in the \'Compliance\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.Then("\'JuribaDEV50\' content is displayed in the \'Site\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.Then("\'\' content is displayed in the \'Advertisement\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.Then("\'ReportViewer\' content is displayed in the \'Collection\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.Then("\'Per-system unattended\' content is displayed in the \'Program\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3173 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3173.AddRow(new string[] {
                            "UNKNOWN"});
#line 94
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Complianc" +
                        "e\' column:", ((string)(null)), table3173, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3174 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3174.AddRow(new string[] {
                            "JuribaDEV50"});
#line 97
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Site\' col" +
                        "umn:", ((string)(null)), table3174, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnMembersTabDeviceMember" +
            "sSubTabForGroupPage")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Groups")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_ItemDetails")]
        [NUnit.Framework.CategoryAttribute("ItemDetailsDisplay")]
        [NUnit.Framework.CategoryAttribute("DAS20492")]
        [NUnit.Framework.CategoryAttribute("Zion_NewGrid")]
        [NUnit.Framework.CategoryAttribute("Wormhole")]
        public virtual void EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnMembersTabDeviceMembersSubTabForGroupPage()
        {
            System.Exception lastException = null;
            for (int i = 0; (i <= 1); i = (i + 1))
            {
                try
                {
                    this.EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnMembersTabDeviceMembersSubTabForGroupPageInternal();
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

        private void EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnMembersTabDeviceMembersSubTabForGroupPageInternal()
        {
            string[] tagsOfScenario = new string[] {
                    "Evergreen",
                    "Groups",
                    "EvergreenJnr_ItemDetails",
                    "ItemDetailsDisplay",
                    "DAS20492",
                    "Zion_NewGrid",
                    "Wormhole"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnMembersTabDeviceMember" +
                    "sSubTabForGroupPage", null, new string[] {
                        "Evergreen",
                        "Groups",
                        "EvergreenJnr_ItemDetails",
                        "ItemDetailsDisplay",
                        "DAS20492",
                        "Zion_NewGrid",
                        "Wormhole"});
#line 103
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
#line 104
 testRunner.When("User type \"GSMS-ReportViewer\" in Global Search Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 105
 testRunner.Then("User clicks on \"GSMS-ReportViewer\" search result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.And("Details page for \'GSMS-ReportViewer\' item is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.When("User navigates to the \'Members\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.When("User navigates to the \'Device Members\' left submenu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3175 = new TechTalk.SpecFlow.Table(new string[] {
                            "ColumnName"});
                table3175.AddRow(new string[] {
                            "Hostname"});
                table3175.AddRow(new string[] {
                            "Owner Username"});
                table3175.AddRow(new string[] {
                            "Owner Display Name"});
                table3175.AddRow(new string[] {
                            "Operating System"});
#line 109
 testRunner.Then("ColumnName is displayed in following order on the Details page:", ((string)(null)), table3175, "Then ");
#line hidden
#line 115
 testRunner.When("User enters \"W1383515700\" text in the Search field for \"Hostname\" column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 116
 testRunner.Then("\'W1383515700\' content is displayed in the \'Hostname\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.Then("\'Empty\' content is displayed in the \'Owner Username\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.Then("\'Empty\' content is displayed in the \'Owner Display Name\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.Then("\'\' content is displayed in the \'Operating System\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3176 = new TechTalk.SpecFlow.Table(new string[] {
                            "Values"});
                table3176.AddRow(new string[] {
                            "Empty"});
#line 120
 testRunner.Then("following checkboxes are displayed in the filter dropdown menu for the \'Operating" +
                        " System\' column:", ((string)(null)), table3176, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }

    }
}
#pragma warning restore
#endregion
