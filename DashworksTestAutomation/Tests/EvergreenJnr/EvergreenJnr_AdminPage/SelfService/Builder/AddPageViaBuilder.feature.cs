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
namespace DashworksTestAutomation.Tests.EvergreenJnr.EvergreenJnr_AdminPage.SelfService.Builder
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AddPageViaBuilder")]
    public partial class AddPageViaBuilderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddPageViaBuilder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddPageViaBuilder", "\tSelf Service", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfS" +
            "erviceViaBuilder")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfServiceViaBuilder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfS" +
                    "erviceViaBuilder", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "Cleanup"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId",
                        "scopeName",
                        "Scope"});
            table1.AddRow(new string[] {
                        "1",
                        "TestProj_1",
                        "Test_ID_1",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "1803 Apps"});
#line 10
 testRunner.When("User creates Self Service via API", ((string)(null)), table1, "When ");
#line 13
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_1\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("\'Create Application Page\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("\'CREATE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("\'Page Name\' textbox is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("\'Page Display Name\' textbox is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.When("User enters \'Page_1\' text to \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.When("User enters \'DisplayPage_1\' text to \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.When("User checks \'Show page in self service\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("\'The page has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("User sees item with \'Page\' type and \'Page_1\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("Page with \'DisplayPage_1\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfS" +
            "erviceViaBuilderWithOnlyFiledPageName")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfServiceViaBuilderWithOnlyFiledPageName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfS" +
                    "erviceViaBuilderWithOnlyFiledPageName", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "Cleanup"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId",
                        "scopeName",
                        "Scope"});
            table2.AddRow(new string[] {
                        "1",
                        "TestProj_2",
                        "Test_ID_2",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "1803 Apps"});
#line 32
 testRunner.When("User creates Self Service via API", ((string)(null)), table2, "When ");
#line 35
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_2\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.When("User enters \'Page_2\' text to \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("\'The page has been created\' text is displayed on inline success banner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Then("User sees item with \'Page\' type and \'Page_2\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsUnableToCretePageWit" +
            "hNotProperlyFiledFields")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        [NUnit.Framework.TestCaseAttribute("", "DisplayPage_2", null)]
        [NUnit.Framework.TestCaseAttribute("60_S\"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kknnnljfjndfjk9849804", "254_S\"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjn" +
            "gjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLF" +
            "S\"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjn" +
            "gnrniorngiwep", null)]
        [NUnit.Framework.TestCaseAttribute("41_S\"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kk", "255_AS\"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkj" +
            "ngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NL" +
            "FS\"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngj" +
            "ngnrniorngiwep", null)]
        [NUnit.Framework.TestCaseAttribute("40_S\"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^kk", @"256_AS""ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS""FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep", null)]
        [NUnit.Framework.TestCaseAttribute("39_S\"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^k", @"256_AS""ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS""FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep256_AS""ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS""FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep", null)]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsUnableToCretePageWithNotProperlyFiledFields(string pageName, string pageDisplayName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Evergreen",
                    "Admin",
                    "EvergreenJnr_AdminPage",
                    "SelfService",
                    "DAS19061",
                    "Cleanup"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsUnableToCretePageWit" +
                    "hNotProperlyFiledFields", null, @__tags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId",
                        "scopeName",
                        "Scope"});
            table3.AddRow(new string[] {
                        "1",
                        "TestProj_3",
                        "Test_ID_3",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "1803 Apps"});
#line 47
 testRunner.When("User creates Self Service via API", ((string)(null)), table3, "When ");
#line 50
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_3\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("\'CREATE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When(string.Format("User enters \'{0}\' text to \'Page Name\' textbox", pageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.When(string.Format("User enters \'{0}\' text to \'Page Display Name\' textbox", pageDisplayName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.When("User checks \'Show page in self service\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("\'CREATE\' button is not disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenTheCancelButtonIsClick" +
            "edTheCreatePageConfigurationIsClosedAndTheDefaultViewIsReloaded")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenTheCancelButtonIsClickedTheCreatePageConfigurationIsClosedAndTheDefaultViewIsReloaded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenTheCancelButtonIsClick" +
                    "edTheCreatePageConfigurationIsClosedAndTheDefaultViewIsReloaded", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "Cleanup"});
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId",
                        "scopeName",
                        "Scope"});
            table4.AddRow(new string[] {
                        "1",
                        "TestProj_4",
                        "Test_ID_4",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "1803 Apps"});
#line 71
 testRunner.When("User creates Self Service via API", ((string)(null)), table4, "When ");
#line 74
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_4\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("\'Create Application Page\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.When("User enters \'Page_4\' text to \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.When("User enters \'DisplayPage_4\' text to \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.When("User checks \'Show page in self service\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.When("User clicks \'CREATE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("User sees item with \'Page\' type and \'Page_4\' name on Self Service Builder Panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.When("User clicks \'CREATE PAGE\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.When("User enters \'Page_44\' text to \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.When("User enters \'DisplayPage_44\' text to \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("\'CREATE PAGE\' button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.Then("Page with \'DisplayPage_4\' subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenCancelButtonIsClickedW" +
            "hileCreatingVeryFirstPageForTheSelfServiceThenCreatePageFormReturnsToTheDefaultS" +
            "tate")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenCancelButtonIsClickedWhileCreatingVeryFirstPageForTheSelfServiceThenCreatePageFormReturnsToTheDefaultState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenCancelButtonIsClickedW" +
                    "hileCreatingVeryFirstPageForTheSelfServiceThenCreatePageFormReturnsToTheDefaultS" +
                    "tate", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "Cleanup"});
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId",
                        "scopeName",
                        "Scope"});
            table5.AddRow(new string[] {
                        "1",
                        "TestProj_5",
                        "Test_ID_5",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "1803 Apps"});
#line 94
 testRunner.When("User creates Self Service via API", ((string)(null)), table5, "When ");
#line 97
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_5\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("\'Create Application Page\' page subheader is displayed to user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("User enters \'Page_5\' text to \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.When("User enters \'DisplayPage_5\' text to \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.When("User checks \'Show page in self service\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.When("User clicks \'CANCEL\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("\'Show page in self service\' checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.Then("\'\' content is displayed in \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.Then("\'\' content is displayed in \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("\'CREATE\' button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatValidationMessageDisplaysI" +
            "fUserLeftPageNameEmpty")]
        [NUnit.Framework.CategoryAttribute("Evergreen")]
        [NUnit.Framework.CategoryAttribute("Admin")]
        [NUnit.Framework.CategoryAttribute("EvergreenJnr_AdminPage")]
        [NUnit.Framework.CategoryAttribute("SelfService")]
        [NUnit.Framework.CategoryAttribute("DAS19061")]
        [NUnit.Framework.CategoryAttribute("Cleanup")]
        public virtual void EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatValidationMessageDisplaysIfUserLeftPageNameEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatValidationMessageDisplaysI" +
                    "fUserLeftPageNameEmpty", null, new string[] {
                        "Evergreen",
                        "Admin",
                        "EvergreenJnr_AdminPage",
                        "SelfService",
                        "DAS19061",
                        "Cleanup"});
#line 113
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ServiceId",
                        "Name",
                        "ServiceIdentifier",
                        "Enabled",
                        "ObjectType",
                        "ObjectTypeId",
                        "StartDate",
                        "EndDate",
                        "SelfServiceURL",
                        "AllowAnonymousUsers",
                        "ScopeId",
                        "scopeName",
                        "Scope"});
            table6.AddRow(new string[] {
                        "1",
                        "TestProj_5",
                        "Test_ID_5",
                        "false",
                        "Devimdmdmm",
                        "3",
                        "2019-12-10T21:34:47.24",
                        "2019-12-31T21:34:47.24",
                        "URL",
                        "true",
                        "2",
                        "bob",
                        "1803 Apps"});
#line 114
 testRunner.When("User creates Self Service via API", ((string)(null)), table6, "When ");
#line 117
    testRunner.When("User clicks \'Admin\' on the left-hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.When("User navigates to the \'Self Services\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.When("User clicks \'Edit\' option in Cog-menu for \'TestProj_5\' item from \'Self Service Na" +
                    "me\' column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("Self Service Details page is displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("User navigates to the \'Builder\' left menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.When("User enters \'Page_5\' text to \'Page Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.When("User enters \'DisplayPage_5\' text to \'Page Display Name\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.When("User clears \'Page Name\' textbox with backspaces", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.Then("\'A page name must be entered\' error message is displayed for \'Page Name\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

