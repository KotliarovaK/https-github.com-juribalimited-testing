﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DashworksTestAutomation.Tests.EvergreenJnr_QueryStrings
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class QueryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Query", "\tRuns Query tests.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Query")))
            {
                global::DashworksTestAutomation.Tests.EvergreenJnr_QueryStrings.QueryFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("User is on Dashworks Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("Login link is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("User clicks on the Login link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Login Page is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User provides the Login and Password and clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Dashworks homepage is displayed to the user in a logged in state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.When("User clicks the Switch to Evergreen link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Evergreen Dashboards page should be displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_DateCombo_And_Apostrophe")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10753")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10615")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10475")]
        public virtual void EvergreenJnr_QueryString_DateCombo_And_Apostrophe()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_DateCombo_And_Apostrophe", new string[] {
                        "Evergreen",
                        "Users",
                        "Mailboxes",
                        "Devices",
                        "Applications",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-10753",
                        "DAS-10615",
                        "DAS-10475"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table1.AddRow(new string[] {
                        "Date field combo",
                        @"evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,bootupDate,buildDate,lastSeenDate,firstSeenDate,purchaseDate,warrantyDate,ownerLastLogoffDate,ownerLastLogonDate,project_task_1_9950_2_Task,project_task_1_250_2_Task,project_task_41_12903_2_Task,project_task_41_12785_2_Task,project_task_1_1_2_Task,project_task_1_4_2_Task,project_task_1_3_2_Task,project_task_1_2_2_Task"});
            table1.AddRow(new string[] {
                        "Devices owners with apostrophes",
                        @"evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName&$filter=(ownerDisplayName%20CONTAINS%20('O''Connor')%20)%20OR%20(ownerDisplayName%20CONTAINS%20('O''Neill')%20)%20OR%20(ownerDisplayName%20CONTAINS%20('O'''%2C'O''Neal')%20)%20OR%20(ownerDisplayName%20EQUALS%20('O''Connell')%20)"});
            table1.AddRow(new string[] {
                        "Users with apostrophes",
                        @"evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName&$filter=(displayName%20CONTAINS%20('O''Connell')%20)%20OR%20(displayName%20CONTAINS%20('O''Neal')%20)%20OR%20(displayName%20CONTAINS%20('O''Neill')%20)%20OR%20(displayName%20CONTAINS%20('O''Connor')%20)%20OR%20(displayName%20CONTAINS%20('O''Donnell')%20)%20OR%20(displayName%20CONTAINS%20('O''Brian')%20)"});
            table1.AddRow(new string[] {
                        "Mailboxes with apostrophes",
                        "evergreen/#/mailboxes?$filter=(displayName%20CONTAINS%20(\'o\'\'donnell\'%2C\'o\'\'brien" +
                            "\'%2C\'o\'\'neil\')%20)&$select=principalEmailAddress,mailboxPlatform,serverName,mail" +
                            "boxType,ownerDisplayName,displayName"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table1, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_Complex")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10782")]
        public virtual void EvergreenJnr_QueryString_Complex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_Complex", new string[] {
                        "Evergreen",
                        "Users",
                        "Mailboxes",
                        "Devices",
                        "Applications",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-10782"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table2.AddRow(new string[] {
                        "Devices complex query",
                        @"evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,migrationRAG,computerKey,distributionType,lastSeenDate,manufacturer,model,oSVersion,oSServicePackName,ownerMigrationRAG,entitledApplications,installedApplications,usedApplications,costCentre&$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown')%20%20AND%20chassisCategory%20EQUALS%20('Desktop'%2C'Laptop'%2C'Mobile')%20%20AND%20installedApplications%20%3E%3D%201%20)&$orderby=migrationRAG%20asc%2ClastSeenDate%20desc"});
            table2.AddRow(new string[] {
                        "Users complex query",
                        @"evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,userMigrationRAG,commonObjectName,devices,lastLogonDate,objectKey,entitledToDeviceApplications,installedApplications,usedApplications,costCentre,fullDepartmentPath,buildingName,city,country,floor,locationName,project_40_subCategory,project_40_groupName,project_40_ragStatus,project_40_requestType,project_40_objectStatus,project_40_teamName&$filter=(userMigrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown'%2C'Green')%20%20AND%20devices%20%3E%3D%201%20%20AND%20entitledToDeviceApplications%20%3E%3D%201%20%20AND%20lastLogonDate%20%3E%20'2010-12-31'%20%20AND%20directoryName%20EQUALS%20('FR'%2C'DWLABS'%2C'RDLABS'%2C'BCLABS')%20)&$orderby=lastLogonDate%20desc"});
            table2.AddRow(new string[] {
                        "Applications complex query",
                        @"evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,packageKey,migrationRAG,computerEntitlements,installed,distributionType,project_40_applicationReadiness,project_40_hideFromEndUsers,project_40_groupName,project_40_teamName,userEntitlements&$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Green')%20%20AND%20packageName%20CONTAINS%20('Microsoft')%20%20AND%20computerEntitlements%20%3E%3D%201%20%20AND%20userEntitlements%20%3E%3D%201%20)&$orderby=computerEntitlements%20desc%2CuserEntitlements%20desc"});
            table2.AddRow(new string[] {
                        "Mailboxes complex query",
                        @"evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,createdDate,totalDeletedItemSizeMB,disconnectDate,displayName,importType,languageName,lastLogonDate,totalItemSizeMB,retainDeletedItemsDays,usersCount,isActive,databaseName,emailCount,ownerCommonName,ownerParentDistinguishedName,ownerUsername,ownerGivenName,ownerDepartmentFullPath,costCentre,fullDepartmentPath,buildingName,floor,city,country,locationName,project_42_subCategory,project_42_groupName,project_42_ragStatus,project_42_requestType,project_42_objectStatus,project_42_teamName,ownerMigrationRAG&$filter=(ownerMigrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Green'%2C'Unknown')%20%20AND%20emailCount%20%3E%3D%201%20%20AND%20usersCount%20%3E%3D%201%20%20AND%20mailboxPlatform%20EQUALS%20('Exchange%202013'%2C'Exchange%202010')%20)&$orderby=createdDate%20desc%2CemailCount%20desc%2CownerMigrationRAG%20asc"});
            testRunner.When("Evergreen QueryStringURL is entered for Complex QueryType", ((string)(null)), table2, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_AllLists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        public virtual void EvergreenJnr_QueryString_AllLists()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_AllLists", new string[] {
                        "Evergreen",
                        "Users",
                        "Mailboxes",
                        "Devices",
                        "Applications",
                        "EvergreenJnr_QueryStrings",
                        "Query"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table3.AddRow(new string[] {
                        "All Devices",
                        "evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName"});
            table3.AddRow(new string[] {
                        "All Users",
                        "evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedOb" +
                            "jectName"});
            table3.AddRow(new string[] {
                        "All Applications",
                        "evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion"});
            table3.AddRow(new string[] {
                        "All Mailboxes",
                        "evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,ma" +
                            "ilboxType,ownerDisplayName"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table3, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11023")]
        public virtual void EvergreenJnr_QueryString_Applications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_Applications", new string[] {
                        "Evergreen",
                        "Applications",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-11023"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table4.AddRow(new string[] {
                        "Target App",
                        @"evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,project_1_applicationRationalisation,project_1_applicationReadiness,project_1_coreApplication,project_1_hideFromEndUsers,project_1_inScope,project_1_objectID,project_1_projectID,project_1_ragStatus,project_1_ragStatusId,project_1_requestType,project_1_requestTypeId,project_1_tag,project_1_targetApplication"});
            table4.AddRow(new string[] {
                        "Category ID",
                        "evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,p" +
                            "roject_1_subCategory"});
            table4.AddRow(new string[] {
                        "Category",
                        "evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,p" +
                            "roject_1_subCategoryId"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table4, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11023")]
        public virtual void EvergreenJnr_QueryString_Devices()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_Devices", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-11023"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table5.AddRow(new string[] {
                        "Devices",
                        @"evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,bootupDate,biosVersion,oSArchitecture,ownerDomain,entitledApplications,costCentre,locationName,description,lDAP_41,customField_33,project_46_subCategory,project_46_ragStatus,project_46_requestType"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table5, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11023")]
        public virtual void EvergreenJnr_QueryString_Users()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_Users", new string[] {
                        "Evergreen",
                        "Users",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-11023"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table6.AddRow(new string[] {
                        "Devices",
                        "evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedOb" +
                            "jectName,description,usedApplications,departmentCode,buildingName,lDAP_46,custom" +
                            "Field_1,project_46_subCategory,project_46_ragStatus,project_46_requestType"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table6, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-11023")]
        public virtual void EvergreenJnr_QueryString_Mailboxes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_Mailboxes", new string[] {
                        "Evergreen",
                        "Mailboxes",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-11023"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table7.AddRow(new string[] {
                        "Devices",
                        "evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,ma" +
                            "ilboxType,ownerDisplayName,displayName,ownerEmailAddress,departmentCode,location" +
                            "Name,customField_81,project_48_subCategory,project_48_requestType,project_48_tea" +
                            "mName"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table7, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_Applications On Devices List")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10789")]
        public virtual void EvergreenJnr_QueryString_ApplicationsOnDevicesList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_Applications On Devices List", new string[] {
                        "Evergreen",
                        "Devices",
                        "EvergreenJnr_QueryStrings",
                        "Query",
                        "DAS-10789"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table8.AddRow(new string[] {
                        "Apps On Devices",
                        @"evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName&$filter=(application%20EQUALS%20('451')%20WHERE%20(Used%20on%20device,Entitled%20to%20device,Installed%20on%20device,Used%20by%20device's%20owner,Entitled%20to%20device's%20owner))"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table8, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("EvergreenJnr_QueryString_AllLists Sort By Keys")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Evergreen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mailboxes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Devices")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Applications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EvergreenJnr_QueryStrings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("TableSorting")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DAS-10598")]
        public virtual void EvergreenJnr_QueryString_AllListsSortByKeys()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("EvergreenJnr_QueryString_AllLists Sort By Keys", new string[] {
                        "Evergreen",
                        "Users",
                        "Mailboxes",
                        "Devices",
                        "Applications",
                        "EvergreenJnr_QueryStrings",
                        "TableSorting",
                        "DAS-10598"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "QueryType",
                        "QueryStringURL"});
            table9.AddRow(new string[] {
                        "Sort by device key",
                        "evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName," +
                            "monitorCount,videoCardCount,computerKey&$orderby=computerKey%20desc"});
            table9.AddRow(new string[] {
                        "Sort by user key",
                        "evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedOb" +
                            "jectName,objectKey&$orderby=objectKey%20desc"});
            table9.AddRow(new string[] {
                        "Sort by application key",
                        "evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,p" +
                            "ackageKey&$orderby=packageKey%20asc"});
            table9.AddRow(new string[] {
                        "Sort by mailbox key",
                        "evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,ma" +
                            "ilboxType,ownerDisplayName,mailboxKey&$orderby=mailboxKey%20asc"});
            testRunner.When("Evergreen QueryStringURL is entered for Simple QueryType", ((string)(null)), table9, "When ");
            testRunner.Then("agGrid Main Object List is returned with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
