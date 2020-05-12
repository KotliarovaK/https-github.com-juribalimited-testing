﻿@retry:1
Feature: Query
	Runs Query tests.

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
@Evergreen @Users @Mailboxes @Devices @Applications @EvergreenJnr_QueryStrings @Query @DAS10753 @DAS10615 @DAS10475
Scenario: EvergreenJnr_QueryString_DateComboAndApostrophe
Runs Evergreen URL query strings which include a date field combos query and filters using apostrophes.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                   |
	| Date field combo                | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,bootupDate,buildDate,lastSeenDate,firstSeenDate,purchaseDate,warrantyDate,ownerLastLogoffDate,ownerLastLogonDate,project_task_1_9950_2_Task,project_task_1_250_2_Task,project_task_41_12903_2_Task,project_task_41_12785_2_Task,project_task_1_1_2_Task,project_task_1_4_2_Task,project_task_1_3_2_Task,project_task_1_2_2_Task |
	| Devices owners with apostrophes | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName&$filter=(ownerDisplayName%20CONTAINS%20('O''Connor')%20)%20OR%20(ownerDisplayName%20CONTAINS%20('O''Neill')%20)%20OR%20(ownerDisplayName%20CONTAINS%20('O'''%2C'O''Neal')%20)%20OR%20(ownerDisplayName%20EQUALS%20('O''Connell')%20)                                                                                            |
	| Users with apostrophes          | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName&$filter=(displayName%20CONTAINS%20('O''Connell')%20)%20OR%20(displayName%20CONTAINS%20('O''Neal')%20)%20OR%20(displayName%20CONTAINS%20('O''Neill')%20)%20OR%20(displayName%20CONTAINS%20('O''Connor')%20)%20OR%20(displayName%20CONTAINS%20('O''Donnell')%20)%20OR%20(displayName%20CONTAINS%20('O''Brian')%20)       |
	| Mailboxes with apostrophes      | evergreen/#/mailboxes?$filter=(displayName%20CONTAINS%20('o''donnell'%2C'o''brien'%2C'o''neil')%20)&$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,displayName                                                                                                                                                                                                            |
	Then agGrid Main Object List is returned with data

@Evergreen @Users @Mailboxes @Devices @Applications @EvergreenJnr_QueryStrings @Query @DAS10782
Scenario: EvergreenJnr_QueryString_Complex
Runs Evergreen URL query strings that are complex, with lots of columns and advanced filters applied
	When Evergreen QueryStringURL is entered for Complex QueryType
	| QueryType                  | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
	| Devices complex query      | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,migrationRAG,computerKey,distributionType,lastSeenDate,manufacturer,model,oSVersion,oSServicePackName,ownerMigrationRAG,entitledApplications,installedApplications,usedApplications,costCentre&$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown')%20%20AND%20chassisCategory%20EQUALS%20('Desktop'%2C'Laptop'%2C'Mobile')%20%20AND%20installedApplications%20%3E%3D%201%20)&$orderby=migrationRAG%20asc%2ClastSeenDate%20desc                                                                                                                                                                                                                                                                                                                                                                                                                            |
	| Users complex query        | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,userMigrationRAG,commonObjectName,devices,lastLogonDate,objectKey,entitledToDeviceApplications,installedApplications,usedApplications,costCentre,fullDepartmentPath,buildingName,city,country,floor,locationName,project_40_subCategory,project_40_groupName,project_40_ragStatus,project_40_requestType,project_40_objectStatus,project_40_teamName&$filter=(userMigrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown'%2C'Green')%20%20AND%20devices%20%3E%3D%201%20%20AND%20entitledToDeviceApplications%20%3E%3D%201%20%20AND%20lastLogonDate%20%3E%20'2010-12-31'%20%20AND%20directoryName%20EQUALS%20('FR'%2C'DWLABS'%2C'RDLABS'%2C'BCLABS')%20)&$orderby=lastLogonDate%20desc                                                                                                                                                                          |
	| Applications complex query | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,packageKey,migrationRAG,computerEntitlements,installed,distributionType,project_40_applicationReadiness,project_40_hideFromEndUsers,project_40_groupName,project_40_teamName,userEntitlements&$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Green')%20%20AND%20packageName%20CONTAINS%20('Microsoft')%20%20AND%20computerEntitlements%20%3E%3D%201%20%20AND%20userEntitlements%20%3E%3D%201%20)&$orderby=computerEntitlements%20desc%2CuserEntitlements%20desc                                                                                                                                                                                                                                                                                                                                                                                                 |
	| Mailboxes complex query    | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,createdDate,totalDeletedItemSizeMB,disconnectDate,displayName,importType,languageName,lastLogonDate,totalItemSizeMB,retainDeletedItemsDays,usersCount,isActive,databaseName,emailCount,ownerCommonName,ownerParentDistinguishedName,ownerUsername,ownerGivenName,ownerDepartmentFullPath,costCentre,fullDepartmentPath,buildingName,floor,city,country,locationName,project_42_subCategory,project_42_groupName,project_42_ragStatus,project_42_requestType,project_42_objectStatus,project_42_teamName,ownerMigrationRAG&$filter=(ownerMigrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Green'%2C'Unknown')%20%20AND%20emailCount%20%3E%3D%201%20%20AND%20usersCount%20%3E%3D%201%20%20AND%20mailboxPlatform%20EQUALS%20('Exchange%202013'%2C'Exchange%202010')%20)&$orderby=createdDate%20desc%2CemailCount%20desc%2CownerMigrationRAG%20asc |
	Then agGrid Main Object List is returned with data

@Evergreen @Users @Mailboxes @Devices @Applications @EvergreenJnr_QueryStrings @Query
Scenario: EvergreenJnr_QueryString_AllLists
Runs Evergreen URL query strings for the 4 default all lists.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType        | QueryStringURL                                                                                              |
	| All Devices      | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName                            |
	| All Users        | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName                   |
	| All Applications | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion                             |
	| All Mailboxes    | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName |
	Then agGrid Main Object List is returned with data

@Evergreen @Applications @EvergreenJnr_QueryStrings @Query @DAS11023
Scenario: EvergreenJnr_QueryString_Applications
Runs Evergreen URL query strings for the Applications List.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType   | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                      |
	| Target App  | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,project_1_applicationRationalisation,project_1_applicationReadiness,project_1_coreApplication,project_1_hideFromEndUsers,project_1_inScope,project_1_objectID,project_1_projectID,project_1_ragStatus,project_1_ragStatusId,project_1_requestType,project_1_requestTypeId,project_1_tag,project_1_targetApplication |
	| Category ID | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,project_1_subCategory                                                                                                                                                                                                                                                                                               |
	| Category    | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,project_1_subCategoryId                                                                                                                                                                                                                                                                                             |
	Then agGrid Main Object List is returned with data

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS11023
Scenario: EvergreenJnr_QueryString_Devices
Runs Evergreen URL query strings for the Devices List.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType | QueryStringURL                                                                                                                                                                                                                                                                        |
	| Devices   | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,bootupDate,biosVersion,oSArchitecture,ownerDomain,entitledApplications,costCentre,locationName,description,lDAP_41,customField_33,project_46_subCategory,project_46_ragStatus,project_46_requestType |
	Then agGrid Main Object List is returned with data

@Evergreen @Users @EvergreenJnr_QueryStrings @Query @DAS11023
Scenario: EvergreenJnr_QueryString_Users
Runs Evergreen URL query strings for the Users List.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType | QueryStringURL                                                                                                                                                                                                                              |
	| Devices   | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,description,usedApplications,departmentCode,buildingName,lDAP_46,customField_1,project_46_subCategory,project_46_ragStatus,project_46_requestType |
	Then agGrid Main Object List is returned with data

@Evergreen @Mailboxes @EvergreenJnr_QueryStrings @Query @DAS11023
Scenario: EvergreenJnr_QueryString_Mailboxes
Runs Evergreen URL query strings for the Mailboxes List.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType          | QueryStringURL                                                                                                                                                                                                                                                                                                     |
	| Devices            | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,displayName,ownerEmailAddress,departmentCode,locationName,customField_81,project_48_subCategory,project_48_requestType,project_48_teamName                                                             |
	| EmailMigra filters | evergreen/#/mailboxes?$filter=(project_48_inScope%20EQUALS%20('1')%20AND%20project_48_objectStatus%20EQUALS%20('Onboarded'%2C'Forecast'%2C'Targeted'%2C'Scheduled'%2C'Migrated'))&$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,project_48_inScope,project_48_objectStatus |
	| EmailMigra filters | evergreen/#/mailboxes?$filter=(project_48_inScope%20EQUALS%20('1')%20AND%20project_48_objectStatus%20EQUALS%20('Scheduled'))&$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,project_48_inScope,project_48_objectStatus                                                      |
	| EmailMigra filters | evergreen/#/mailboxes?$filter=(project_48_inScope%20EQUALS%20('1')%20AND%20project_48_objectStatus%20EQUALS%20('Onboarded'))&$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,project_48_inScope,project_48_objectStatus                                                      |
	Then agGrid Main Object List is returned with data

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS10789 @DAS13684
Scenario: EvergreenJnr_QueryString_ApplicationsOnDevicesList
Runs Evergreen URL query strings for the Applications on Devices List.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                | QueryStringURL                                                                                                                                            |
	| Application (Saved List) | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName&$filter=(applicationSavedListId%20EQUALS%20('4')%20WHERE%20(uod%2Cubdo)) |
	| Apps On Devices          | evergreen/#/devices?$filter=(application%20EQUALS%20('451')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo))                                                    |
	Then agGrid Main Object List is returned with data

@Evergreen @Users @Mailboxes @Devices @Applications @EvergreenJnr_QueryStrings @Query @TableSorting @DAS10598
Scenario: EvergreenJnr_QueryString_AllListsSortByKeys
Runs Evergreen URL query strings which include being sorted by object key columns.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
	| Sort by device key              | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,monitorCount,videoCardCount,computerKey&$orderby=computerKey%20desc                                                                                                                                                                                                                                                                                                                 |
	| Sort by user key                | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,objectKey&$orderby=objectKey%20desc                                                                                                                                                                                                                                                                                                                                        |
	| Sort by application key         | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,packageKey&$orderby=packageKey%20asc                                                                                                                                                                                                                                                                                                                                                 |
	| Sort by mailbox key             | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,mailboxKey&$orderby=mailboxKey%20asc                                                                                                                                                                                                                                                                                                                     |
	Then agGrid Main Object List is returned with data

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS13179
Scenario Outline: EvergreenJnr_QueryString_AdvancedFilterRowCountCheckForDeviceList
	When Evergreen QueryStringURL is entered for Simple QueryType and appropriate RowCount is displayed
	| QueryType    | QueryStringURL | RowCount |
	| <FilterName> | <QueryString>  | <Rows>   |

Examples:
	| FilterName                                      | QueryString                                                                                                                                                                                                                                   | Rows   |
	| App Count (Entitled)                            | evergreen/#/devices?$filter=(entitledApplications%20%3C%3E%2012)&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,entitledApplications&$orderby=entitledApplications%20desc                                                       | 17,217 |
	| App Count (Installed)                           | evergreen/#/devices?$filter=(installedApplications%20%3E%2012)&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,installedApplications                                                                                             | 94     |
	| App Count (Used)                                | evergreen/#/devices?$filter=(usedApplications%20%3C%2011)&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,installedApplications,usedApplications                                                                                 | 17,185 |
	| Application                                     | evergreen/#/devices?$filter=(application%20NOT%20EQUALS%20('882'%2C'839'%2C'778')%20WHERE%20(netdo%2Cnubdo%2Cnetd%2Cnuod%2Cniod))                                                                                                             | 17,279 |
	| Application                                     | evergreen/#/devices?$filter=(application%20EQUALS%20('882')%20WHERE%20(nuod))                                                                                                                                                                 | 17,279 |
	| Application Compliance                          | evergreen/#/devices?$filter=(applicationMigrationRAG%20EQUALS%20('Red')%20WHERE%20(netdo%2Cnubdo%2Cniod%2Cnetd%2Cnuod))                                                                                                                       | 17,279 |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20EQUALS%20('%25SQL_PRODUCT_SHORT_NAME%25%20Data%20Tools%20-%20BI%20for%20Visual%20Studio%202013')%20WHERE%20(uod%2Cetd%2Cubdo%2Ciod%2Cetdo))                                                    | 2      |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20NOT%20EQUALS%20('%25SQL_PRODUCT_SHORT_NAME%25%20Data%20Tools%20-%20BI%20for%20Visual%20Studio%202013')%20WHERE%20(netdo%2Cnubdo%2Cniod%2Cnetd%2Cnuod))                                         | 17,279 |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20CONTAINS%20('7zip')%20WHERE%20(nuod))                                                                                                                                                          | 17,279 |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20BEGINS%20WITH%20('7zip')%20WHERE%20(ubdo%2Cetd))                                                                                                                                               | 11     |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20DOES%20NOT%20BEGIN%20WITH%20('7zip')%20WHERE%20(nubdo%2Cnetdo))                                                                                                                                | 17,150 |
	| Application Vendor                              | evergreen/#/devices?$filter=(applicationManufacturer%20EQUALS%20('Aaronbock%20Development')%20WHERE%20(etdo))                                                                                                                                 | 98     |
	| Application Vendor                              | evergreen/#/devices?$filter=(applicationManufacturer%20NOT%20EQUALS%20('Aaronbock%20Development')%20WHERE%20(netdo))                                                                                                                          | 12,202 |
	| Application Owner (App Custom Fields)           | evergreen/#/devices?$filter=(applicationCustomField_80%20EQUALS%20('App%20Discovery')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo))                                                                                                              | 1,003  |
	| Application Owner (App Custom Fields)           | evergreen/#/devices?$filter=(applicationCustomField_80%20NOT%20EQUALS%20('App%20Discovery')%20WHERE%20(netdo%2Cnubdo%2Cniod%2Cnetd%2Cnuod))                                                                                                   | 17,279 |
	| Application Owner (App Custom Fields)           | evergreen/#/devices?$filter=(applicationCustomField_80%20NOT%20EQUALS%20('App%20Discovery')%20WHERE%20(iod))                                                                                                                                  | 12,076 |
	| General information field 5 (App Custom Fields) | evergreen/#/devices?$filter=(applicationCustomField_79%20DOES%20NOT%20BEGIN%20WITH%20('General%205')%20WHERE%20(nubdo%2Cniod))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,deviceOwnerCustomField_79                         | 17,279 |
	| General information field 5 (App Custom Fields) | evergreen/#/devices?$filter=(applicationCustomField_79%20ENDS%20WITH%20('0.5')%20WHERE%20(nubdo%2Cnetdo%2Cnuod%2Cnetd%2Cniod))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,deviceOwnerCustomField_79                         | 17,279 |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20DOES%20NOT%20END%20WITH%20('1.1')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo))                                                                                                                   | 17,248 |
	| Application Import                              | evergreen/#/devices?$filter=(applicationImport%20NOT%20EQUALS%20('SCCM%202012%20PS1'%2C'A01%20SMS%20(Spoof%C2%A7'%2C'DC1%20SMS%20(DEV50%C2%A7'%2C'SCCM%202012'%2C'SCCM%202012%20Named%20Instance')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo)) | 5,203  |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20IS%20NOT%20EMPTY%20()%20WHERE%20(niod))                                                                                                                                                        | 5,195  |
	| Application Owner (App Custom Fields)           | evergreen/#/devices?$filter=(applicationCustomField_80%20IS%20NOT%20EMPTY%20()%20WHERE%20(niod))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,deviceOwnerCustomField_79                                                       | 16,228 |

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS13179 @Cleanup
Scenario Outline: EvergreenJnr_QueryString_AdvancedFilterRowCountAndFilterTextCheckForDeviceList
	When Evergreen QueryStringURL is entered for Simple QueryType and appropriate RowCount is displayed
	| QueryType    | QueryStringURL | RowCount |
	| <FilterName> | <QueryString>  | <Rows>   |
	When User create dynamic list with "AdvancedFilterDL1" name on "Devices" page
	Then "AdvancedFilterDL1" list is displayed to user
	When User navigates to the "All Devices" list
	When User navigates to the "AdvancedFilterDL1" list
	Then "AdvancedFilterDL1" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "<FilterInfo>" is displayed in added filter info
		
Examples:
	| FilterName                                      | QueryString                                                                                                                                                                                                                  | Rows   | FilterInfo                                                                                                                                                                                                                                        |
	| App Count (Entitled)                            | evergreen/#/devices?$filter=(entitledApplications%20%3D%2012)&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,entitledApplications&$orderby=entitledApplications%20desc                                         | 62     | App Count (Entitled) is 12                                                                                                                                                                                                                        |
	| App Count (Installed)                           | evergreen/#/devices?$filter=(installedApplications%20%3E%3D%2064)&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,installedApplications                                                                         | 25     | App Count (Installed) is greater than or equal to 64                                                                                                                                                                                              |
	| App Count (Used)                                | evergreen/#/devices?$filter=(usedApplications%20%3C%3D%20100)&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,usedApplications&$orderby=usedApplications%20desc                                                 | 17,279 | App Count (Used) is less than or equal to 100                                                                                                                                                                                                     |
	| Application                                     | evergreen/#/devices?$filter=(application%20EQUALS%20('4093'%2C'4409'%2C'3854'%2C'3992')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo))                                                                                           | 9      | Application 7-Zip 16.02 (x64) (4093), 7-Zip 16.04 (x64) (4409), 7-Zip 9.20 (x64 edition) (3854) or 7-Zip 9.22 (x64 edition) (3992) used on device; entitled to device; installed on device; used by device's owner; or entitled to device's owner |
	| Application                                     | evergreen/#/devices?$filter=(application%20NOT%20EQUALS%20('882')%20WHERE%20(iod))                                                                                                                                           | 12,083 | Application is not Access (882) installed on device                                                                                                                                                                                               |
	| Application Compliance                          | evergreen/#/devices?$filter=(applicationMigrationRAG%20NOT%20EQUALS%20('Red'%2C'Amber'%2C'Green'%2C'Not%20Applicable')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo))                                                            | 4,548  | Application whose Compliance is not Red, Amber, Green or Not Applicable used on device; entitled to device; installed on device; used by device's owner; or entitled to device's owner                                                            |
	| Application Import                              | evergreen/#/devices?$filter=(applicationImport%20EQUALS%20('SCCM%202012%20PS1')%20WHERE%20(netdo%2Cnubdo%2Cniod%2Cnetd%2Cnuod))                                                                                              | 17,279 | Application whose Import is SCCM 2012 PS1 not entitled to device's owner; not used by device's owner; not installed on device; not entitled to device; or not used on device                                                                      |
	| Application Name                                | evergreen/#/devices?$filter=(applicationName%20ENDS%20WITH%20('1.1')%20WHERE%20(nubdo%2Cnetdo%2Cnuod%2Cnetd%2Cniod))                                                                                                         | 17,279 | Application whose Name ends with 1.1 not used by device's owner; not entitled to device's owner; not used on device; not entitled to device; or not installed on device                                                                           |
	| Application Owner (App Custom Fields)           | evergreen/#/devices?$filter=(applicationCustomField_80%20CONTAINS%20('app')%20WHERE%20(nuod))                                                                                                                                | 17,279 | Application Owner contains app not used on device                                                                                                                                                                                                 |
	| Application Owner (App Custom Fields)           | evergreen/#/devices?$filter=(applicationCustomField_80%20BEGINS%20WITH%20('app')%20WHERE%20(iod%2Cubdo))                                                                                                                     | 1,003  | Application Owner begins with app installed on device; or used by device's owner                                                                                                                                                                  |
	| General information field 5 (App Custom Fields) | evergreen/#/devices?$filter=(applicationCustomField_79%20DOES%20NOT%20END%20WITH%20('0.5')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,deviceOwnerCustomField_79 | 115    | General information field 5 does not end with 0.5 used on device; entitled to device; installed on device; used by device's owner; or entitled to device's owner                                                                                  |
	| Application Name                                                                                        | evergreen/#/devices?$filter=(applicationName%20NOT%20EQUALS%20('7zip')%20WHERE%20(ubdo))                                                                                                                                     | 160    | Application whose Name is not 7zip used by device's owner                                                                                                                                                                                         |
	#| Application Owner (App Custom Fields)                                                                   | evergreen/#/devices?$filter=(applicationCustomField_80%20IS%20NOT%20EMPTY%20()%20WHERE%20(niod))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,deviceOwnerCustomField_79                                      | 16,222 |                                                                                                                                                                                                                                                   |
	#| Application Name                                                                                        | evergreen/#/devices?$filter=(applicationName%20IS%20EMPTY%20()%20WHERE%20(iod))                                                                                                                                              | 6      |                                                                                                                                                                                                                                                   |

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS13179 @DAS17398 @Cleanup
Scenario: EvergreenJnr_QueryString_AdvancedFilterRowCountAndFilterTextCheckForDeviceStaticList
	When User create static list with "StaticList13179" name on "Applications" page with following items
	| ItemName |
	|          |
	Then "StaticList13179" list is displayed to user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                                             | QueryStringURL                                                                                                         | ListName        |
	| Application (Saved List) - Static - All rows selected | evergreen/#/devices?$filter=(applicationSavedListId%20EQUALS%20('ListName')%20WHERE%20(uod%2Cetd%2Ciod%2Cubdo%2Cetdo)) | StaticList13179 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Application" filter
	And User selects "StaticList13179" list for Saved List
	And User clicks Save filter button
	When User creates 'DynamicList13179' dynamic list
	Then "DynamicList13179" list is displayed to user
	And "17,248" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	And User navigates to the "DynamicList13179" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "17,248" rows are displayed in the agGrid
	And "Any Application in list StaticList13179 used on device; entitled to device; installed on device; used by device's owner; or entitled to device's owner" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS13179 @DAS17398 @Cleanup
Scenario: EvergreenJnr_QueryString_AdvancedFilterRowCountAndFilterTextCheckForDeviceDynamicList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Vendor' column header
	And User create dynamic list with "Dynamic13179" name on "Applications" page
	Then "Dynamic13179" list is displayed to user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                                            | QueryStringURL                                                                                                              | ListName     |
	| Application (Saved List) - Dynamic - All data sorted | evergreen/#/devices?$filter=(applicationSavedListId%20EQUALS%20('ListName')%20WHERE%20(netdo%2Cnubdo%2Cniod%2Cnetd%2Cnuod)) | Dynamic13179 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Application" filter
	And User selects "Dynamic13179" list for Saved List
	And User clicks Save filter button
	When User creates 'List13179' dynamic list
	Then "List13179" list is displayed to user
	And "17,279" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	And User navigates to the "List13179" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "17,279" rows are displayed in the agGrid
	And "Any Application in list Dynamic13179 not entitled to device's owner; not used by device's owner; not installed on device; not entitled to device; or not used on device" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS13179 @DAS17398 @Cleanup
Scenario: EvergreenJnr_QueryString_AdvancedFilterRowCountAndFilterTextCheckForStaticListWithComplianceIsRedAmberOrUnknownFilter
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                                                                                        | QueryStringURL                                                                                                                                               |
	| Application (Saved List) - Static - Specific rows selected by Compliance = Red, Amber or Unknown | evergreen/#/applications?$filter=(migrationRAG%20EQUALS%20('Red'%2C'Amber'%2C'Unknown'))&$select=packageName,packageManufacturer,packageVersion,migrationRAG |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList12911" name
	Then "StaticList12911" list is displayed to user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                                                                                        | QueryStringURL                                                                                | ListName        |
	| Application (Saved List) - Static - Specific rows selected by Compliance = Red, Amber or Unknown | evergreen/#/devices?$filter=(applicationSavedListId%20EQUALS%20('ListName')%20WHERE%20(niod)) | StaticList12911 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Application" filter
	And User selects "StaticList12911" list for Saved List
	And User clicks Save filter button
	When User creates 'List11179' dynamic list
	Then "List11179" list is displayed to user
	And "7,419" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	And User navigates to the "List11179" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "7,419" rows are displayed in the agGrid
	And "Any Application in list StaticList12911 not installed on device" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_QueryStrings @Query @DAS13179 @DAS17398 @Cleanup
Scenario: EvergreenJnr_QueryString_AdvancedFilterRowCountAndFilterTextCheckForStaticListWithVendorContainsMicrosoftOrAdobeFilter
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                                                          | QueryStringURL                                                                              |
	| Application (Saved List) - Dynamic - With filter applied to Vendor | evergreen/#/applications?$filter=(packageManufacturer%20CONTAINS%20('Microsoft'%2C'Adobe')) |
	And User create dynamic list with "Dynamic13579" name on "Applications" page
	Then "Dynamic13579" list is displayed to user
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                                                                                        | QueryStringURL                                                                               | ListName     |
	| Application (Saved List) - Static - Specific rows selected by Compliance = Red, Amber or Unknown | evergreen/#/devices?$filter=(applicationSavedListId%20EQUALS%20('ListName')%20WHERE%20(uod)) | Dynamic13579 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Application" filter
	And User selects "Dynamic13579" list for Saved List
	And User clicks Save filter button
	When User creates 'List41179' dynamic list
	Then "List41179" list is displayed to user
	And "94" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	And User navigates to the "List41179" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "94" rows are displayed in the agGrid
	And "Any Application in list Dynamic13579 used on device" is displayed in added filter info

@Evergreen @Users @EvergreenJnr_QueryStrings @Query @DAS13179
Scenario Outline: EvergreenJnr_QueryString_AdvancedFilterRowCountCheckForUserList
	When Evergreen QueryStringURL is entered for Simple QueryType and appropriate RowCount is displayed
	| QueryType    | QueryStringURL | RowCount |
	| <FilterName> | <QueryString>  | <Rows>   |

Examples:
	| FilterName                            | QueryString                                                                                                                                 | Rows   |
	| App Count (Entitled)                  | evergreen/#/users?$filter=(entitledApplications%20%3C%3E%2010)                                                                              | 41,307 |
	| App Count (Installed)                 | evergreen/#/users?$filter=(installedApplications%20>%2010)                                                                                  | 772    |
	| App Count (Used)                      | evergreen/#/users?$filter=(usedApplications%20<%2010)                                                                                       | 41,337 |
	| Application                           | evergreen/#/users?$filter=(application%20NOT%20EQUALS%20('493')%20WHERE%20(nioadobu%2Cnetdobu%2Cnuodobu%2Cnetu%2Cnubu))                     | 41,339 |
	| Application                           | evergreen/#/users?$filter=(application%20EQUALS%20('94')%20WHERE%20(netu))                                                                  | 41,243 |
	| Application Compliance                | evergreen/#/users?$filter=(applicationMigrationRag%20EQUALS%20('Unknown')%20WHERE%20(nioadobu%2Cnetdobu%2Cnuodobu%2Cnetu%2Cnubu))           | 41,339 |
	| Application Name                      | evergreen/#/users?$filter=(applicationName%20EQUALS%20('ACDSee%204.0')%20WHERE%20(ubu%2Cetu%2Cuodou%2Cetdobu%2Ciodobu))                     | 139    |
	| Application Name                      | evergreen/#/users?$filter=(applicationName%20NOT%20EQUALS%20('ACDSee%204.0')%20WHERE%20(nioadobu%2Cnuodobu%2Cnetu%2Cnubu%2Cnetdobu))        | 41,339 |
	| Application Name                      | evergreen/#/users?$filter=(applicationName%20CONTAINS%20('%25')%20WHERE%20(netu))                                                           | 36,502 |
	| Application Name                      | evergreen/#/users?$filter=(applicationName%20BEGINS%20WITH%20('A')%20WHERE%20(ubu%2Cetu))                                                   | 946    |
	| Application Name                      | evergreen/#/users?$filter=(applicationName%20DOES%20NOT%20BEGIN%20WITH%20('A')%20WHERE%20(nuodobu%2Cnetdobu))                               | 41,258 |
	| Application Name                      | evergreen/#/users?$filter=(applicationName%20DOES%20NOT%20END%20WITH%20('a')%20WHERE%20(ubu%2Cetu%2Cuodou%2Cetdobu%2Ciodobu))               | 14,956 |
	| Application Vendor                    | evergreen/#/users?$filter=(applicationManufacturer%20EQUALS%20('Aaronbock%20Development')%20WHERE%20(ubu))                                  | 94     |
	| Application Vendor                    | evergreen/#/users?$filter=(applicationManufacturer%20NOT%20EQUALS%20('Abacre')%20WHERE%20(netu))                                            | 36,502 |
	| Application Key                       | evergreen/#/users?$filter=(applicationKey%20%3D%201%20WHERE%20(ubu%2Cetu%2Cuodou%2Cetdobu%2Ciodobu))                                        | 362    |
	| Application Key                       | evergreen/#/users?$filter=(applicationKey%20<>%201%20WHERE%20(nioadobu%2Cnetdobu%2Cnuodobu%2Cnetu%2Cnubu))                                  | 41,339 |
	| Application Key                       | evergreen/#/users?$filter=(applicationKey%20%3E%3D%201%20WHERE%20(ubu))                                                                     | 99     |
	| Application Key                       | evergreen/#/users?$filter=(applicationKey%20<%3D%202%20WHERE%20(netdobu%2Cnubu))                                                            | 41,339 |
	| Application Owner (App Custom Fields) | evergreen/#/users?$filter=(applicationCustomField_80%20EQUALS%20('App%20Discovery')%20WHERE%20(ubu%2Cetu%2Ciodobu%2Cetdobu%2Cuodou))        | 871    |
	#| Application Import                    | evergreen/#/users?$filter=(applicationImport%20NOT%20EQUALS%20('A01%20SMS%20(Spoof%C2%A7')%20WHERE%20(ubu%2Cetu%2Cuodou%2Cetdobu%2Ciodobu)) | 4,910  |
	#| Application Name                      | evergreen/#/users?$filter=(applicationName%20IS%20NOT%20EMPTY%20()%20WHERE%20())                                                            | 26,802 |

@Evergreen @Users @EvergreenJnr_QueryStrings @Query @DAS13179 @Cleanup
Scenario Outline: EvergreenJnr_QueryString_AdvancedFilterRowCountAndFilterTextCheckForUserList
	When Evergreen QueryStringURL is entered for Simple QueryType and appropriate RowCount is displayed
	| QueryType    | QueryStringURL | RowCount |
	| <FilterName> | <QueryString>  | <Rows>   |
	When User create dynamic list with "AdvancedFilterUL1" name on "Users" page
	Then "AdvancedFilterUL1" list is displayed to user
	When User navigates to the "All Users" list
	When User navigates to the "AdvancedFilterUL1" list
	Then "AdvancedFilterUL1" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "<FilterInfo>" is displayed in added filter info

Examples:
	| FilterName             | QueryString                                                                                                                            | Rows   | FilterInfo                                                                                                                                                                                                              |
	| App Count (Entitled)   | evergreen/#/users?$filter=(entitledApplications%20%3D%2010)                                                                            | 32     | App Count (Entitled) is 10                                                                                                                                                                                              |
	| App Count (Installed)  | evergreen/#/users?$filter=(installedApplications%20%3E%3D%2010)                                                                        | 1,068  | App Count (Installed on Owned Device) is greater than or equal to 10                                                                                                                                                                    |
	| App Count (Used)       | evergreen/#/users?$filter=(usedApplications%20%3C%3D%2010)                                                                             | 41,337 | App Count (Used) is less than or equal to 10                                                                                                                                                                            |
	| Application            | evergreen/#/users?$filter=(application%20EQUALS%20('493')%20WHERE%20(ubu%2Cetu%2Cuodou%2Cetdobu%2Ciodobu))                             | 61     | Application "WPF/E" (codename) Community Technology Preview (Feb 2007) (493) used by user; entitled to user; used on a device owned by user; entitled to a device owned by user; or installed on a device owned by user |
	| Application            | evergreen/#/users?$filter=(application%20NOT%20EQUALS%20('493')%20WHERE%20(ubu))                                                       | 99     | Application is not "WPF/E" (codename) Community Technology Preview (Feb 2007) (493) used by user                                                                                                                        |
	| Application Compliance | evergreen/#/users?$filter=(applicationMigrationRag%20NOT%20EQUALS%20('Unknown')%20WHERE%20(ubu%2Cetu%2Cuodou%2Cetdobu%2Ciodobu))       | 14,894 | Application whose Compliance is not Unknown used by user; entitled to user; used on a device owned by user; entitled to a device owned by user; or installed on a device owned by user                                  |
	| Application Name       | evergreen/#/users?$filter=(applicationName%20NOT%20CONTAINS%20('A')%20WHERE%20(ubu))                                                   | 99     | Application whose Name does not contain A used by user                                                                                                                                                                  |
	| Application Name       | evergreen/#/users?$filter=(applicationName%20ENDS%20WITH%20('a')%20WHERE%20(nioadobu%2Cnetdobu%2Cnetu%2Cnuodobu%2Cnubu))               | 41,339 | Application whose Name ends with a not installed on any device owned by user; not entitled to any device owned by user; not entitled to user; not used on any device owned by user; or not used by user                 |
	| Application Key        | evergreen/#/users?$filter=(applicationKey%20>%201%20WHERE%20(netdobu))                                                                 | 26,808 | Application whose Key is greater than 1 not entitled to any device owned by user                                                                                                                                        |
	| Application Key        | evergreen/#/users?$filter=(applicationKey%20<%202%20WHERE%20(ubu%2Cuodou))                                                             | 186    | Application whose Key is less than 2 used by user; or used on a device owned by user                                                                                                                                    |
	#| Application Import     | evergreen/#/users?$filter=(applicationImport%20EQUALS%20('A01%20SMS%20Spoof§')%20WHERE%20(nioadobu%2Cnetdobu%2Cnetu%2Cnuodobu%2Cnubu)) | 41,339 |                                                                                                                                                                                                                         |
	#| Application Name       | evergreen/#/users?$filter=(applicationName%20IS%20EMPTY%20()%20WHERE%20())                                                             | 2      |                                                                                                                                                                                                                         |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS19348 @Cleanup
Scenario: EvergreenJnr_QueryString_AdvancedFilterCheckForStaticListWithRecipientNotEmptyFilter
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType      | QueryStringURL                                                           |
	| Recipient Type | /evergreen/#/mailboxes?$filter=(recipientType%20NOT%20EQUALS%20('NULL')) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Recipient Type is not Empty" is displayed in added filter info
	Then Filter name is colored in the added filter info
	Then Filter value is shown in bold in the added filter info

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18759 @Cleanup
Scenario: EvergreenJnr_QueryString_AdvancedFilterCheckForStaticListWithGroupFilter
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType      | QueryStringURL                                                                                  |
	| Recipient Type | /evergreen/#/devices?$filter=(groupId%20EQUALS%20('26741'%2C'27716'%2C'27402')%20WHERE%20(inm)) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Device is not a member of Group AU\GAPP-A0121127, AU\GAPP-A012116D or AU\GAPP-A01211A7" is displayed in added filter info
	Then Filter name is colored in the added filter info
	Then Filter value is shown in bold in the added filter info