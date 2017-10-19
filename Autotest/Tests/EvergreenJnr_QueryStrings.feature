﻿#@retry:3
Feature: EvergreenJnr_QueryStrings
	Runs Evergreen URL query strings.

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user

@Evergreen @QueryStrings
Scenario: Evergreen Jnr_QueryString_SortByKeys
Runs Evergreen URL query strings which include being sorted by object key columns.
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
	| Sort by device key              | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,monitorCount,videoCardCount,computerKey&$orderby=computerKey%20desc                                                                                                                                                                                                                                                                                                                 |
	| Sort by user key                | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,objectKey&$orderby=objectKey%20desc                                                                                                                                                                                                                                                                                                                                        |
	| Sort by application key         | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,packageKey&$orderby=packageKey%20asc                                                                                                                                                                                                                                                                                                                                                 |
	| Sort by mailbox key             | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,mailboxKey&$orderby=mailboxKey%20asc                                                                                                                                                                                                                                                                                                                     |
	Then agGrid Main Object List is returned with data
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @QueryStrings
Scenario: Evergreen Jnr_QueryString_AllLists
Runs Evergreen URL query strings for the 4 default all lists.
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
	| All Devices                     | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName                                                                                                                                                                                                                                                                                                                                                                                     |
	| All Users                       | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName                                                                                                                                                                                                                                                                                                                                                                            |
	| All Applications                | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion                                                                                                                                                                                                                                                                                                                                                                                      |
	| All Mailboxes                   | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName                                                                                                                                                                                                                                                                                                                                                          |
	Then agGrid Main Object List is returned with data
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @QueryStrings
Scenario: Evergreen Jnr_QueryString_DateCombo_And_Apostrophe
Runs Evergreen URL query strings which include a date field combos query and filters using apostrophes.
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
	| Date field combo                | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,bootupDate,buildDate,lastSeenDate,firstSeenDate,purchaseDate,warrantyDate,ownerLastLogoffDate,ownerLastLogonDate,project_task_1_9950_2_Task,project_task_1_250_2_Task,project_task_41_12903_2_Task,project_task_41_12785_2_Task,project_task_1_1_2_Task,project_task_1_4_2_Task,project_task_1_3_2_Task,project_task_1_2_2_Task                                                     |
	| Devices owners with apostrophes | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName&$filter=(ownerDisplayName%20CONTAINS%20('O''Connor')%20)%20OR%20(ownerDisplayName%20CONTAINS%20('O''Neill')%20)%20OR%20(ownerDisplayName%20CONTAINS%20('O'''%2C'O''Neal')%20)%20OR%20(ownerDisplayName%20EQUALS%20('O''Connell')%20)                                                                                                                                                |
	| Users with apostrophes          | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName&$filter=(displayName%20CONTAINS%20('O''Connell')%20)%20OR%20(displayName%20CONTAINS%20('O''Neal')%20)%20OR%20(displayName%20CONTAINS%20('O''Neill')%20)%20OR%20(displayName%20CONTAINS%20('O''Connor')%20)%20OR%20(displayName%20CONTAINS%20('O''Donnell')%20)%20OR%20(displayName%20CONTAINS%20('O''Brian')%20)                                                           |
	| Mailboxes with apostrophes      | evergreen/#/mailboxes?$select=mailboxPlatform,serverName,mailboxType,ownerDisplayName,emailAddresses,principalEmailAddress&$filter=(emailAddresses%20CONTAINS%20('o''connell')%20)%20OR%20(emailAddresses%20CONTAINS%20('o''neal')%20)%20OR%20(emailAddresses%20CONTAINS%20('o''neill')%20)%20OR%20(emailAddresses%20CONTAINS%20('o''donnell')%20)%20OR%20(emailAddresses%20CONTAINS%20('o''brien')%20)%20OR%20(principalEmailAddress%20CONTAINS%20('o''connor')%20) |
	Then agGrid Main Object List is returned with data
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @QueryStrings
Scenario: Evergreen Jnr_QueryString_Complex
Runs Evergreen URL query strings that are complex, with lots of columns and advanced filters applied
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When Evergreen QueryStringURL is entered for Complex QueryType
	| QueryType                  | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
	| Devices complex query      | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,migrationRAG,computerKey,distributionType,lastSeenDate,manufacturer,model,oSVersion,oSServicePackName,ownerMigrationRAG,entitledApplications,installedApplications,usedApplications,costCentre&$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown')%20%20AND%20chassisCategory%20EQUALS%20('Desktop'%2C'Laptop'%2C'Mobile')%20%20AND%20installedApplications%20%3E%3D%201%20)&$orderby=migrationRAG%20asc%2ClastSeenDate%20desc                                                                                                                                                                                                                                                                                                                                                                                                                            |
	| Users complex query        | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,userMigrationRAG,commonObjectName,devices,lastLogonDate,objectKey,entitledToDeviceApplications,installedApplications,usedApplications,costCentre,fullDepartmentPath,buildingName,city,country,floor,locationName,project_40_subCategory,project_40_groupName,project_40_ragStatus,project_40_requestType,project_40_objectStatus,project_40_teamName&$filter=(userMigrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown'%2C'Green')%20%20AND%20devices%20%3E%3D%201%20%20AND%20entitledToDeviceApplications%20%3E%3D%201%20%20AND%20lastLogonDate%20%3E%20'2010-12-31'%20%20AND%20directoryName%20EQUALS%20('FR'%2C'DWLABS'%2C'RDLABS'%2C'BCLABS')%20)&$orderby=lastLogonDate%20desc                                                                                                                                                                          |
	| Applications complex query | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,packageKey,migrationRAG,computerEntitlements,installed,distributionType,project_40_applicationReadiness,project_40_hideFromEndUsers,project_40_groupName,project_40_teamName,userEntitlements&$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Green')%20%20AND%20packageName%20CONTAINS%20('Microsoft')%20%20AND%20computerEntitlements%20%3E%3D%201%20%20AND%20userEntitlements%20%3E%3D%201%20)&$orderby=computerEntitlements%20desc%2CuserEntitlements%20desc                                                                                                                                                                                                                                                                                                                                                                                                 |
	| Mailboxes complex query    | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,createdDate,totalDeletedItemSizeMB,disconnectDate,displayName,importType,languageName,lastLogonDate,totalItemSizeMB,retainDeletedItemsDays,usersCount,isActive,databaseName,emailCount,ownerCommonName,ownerParentDistinguishedName,ownerUsername,ownerGivenName,ownerDepartmentFullPath,costCentre,fullDepartmentPath,buildingName,floor,city,country,locationName,project_42_subCategory,project_42_groupName,project_42_ragStatus,project_42_requestType,project_42_objectStatus,project_42_teamName,ownerMigrationRAG&$filter=(ownerMigrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Green'%2C'Unknown')%20%20AND%20emailCount%20%3E%3D%201%20%20AND%20usersCount%20%3E%3D%201%20%20AND%20mailboxPlatform%20EQUALS%20('Exchange%202013'%2C'Exchange%202010')%20)&$orderby=createdDate%20desc%2CemailCount%20desc%2CownerMigrationRAG%20asc |
	Then agGrid Main Object List is returned with data
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out