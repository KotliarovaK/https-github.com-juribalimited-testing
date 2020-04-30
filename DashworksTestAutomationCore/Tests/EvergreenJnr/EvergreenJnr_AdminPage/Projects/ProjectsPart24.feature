Feature: ProjectsPart24
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS16816 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatFillingFieldErrorIsNotDisplayed
	When User clicks 'Users' on the left-hand menu
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType | QueryStringURL                                                                                                                                  |
	| Username  | evergreen/#/users?$filter=(username%20EQUALS%20('AOG7951336'%2C'AOJ5740774'%2C'AOO9780350'%2C'AOS4843193'%2C'APA3392254%20%20'%2C'APB5713645')) |
	And User create dynamic list with "DAS16816_List" name on "Users" page
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DAS16816_Project_Users' text to 'Project Name' textbox
	And User selects 'DAS16816_List' option from 'Scope' autocomplete
	Then Filling field error is not displayed
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	#For Mailboxes filter
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType    | QueryStringURL                                                                                                                                                                                        |
	| Mailbox GUID | evergreen/#/mailboxes?$filter=(exchangeGUID%20CONTAINS%20('180a2898-9ab2-4b7e-88cc-f86afb36210a'))&$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,exchangeGUID |
	And User create dynamic list with "DAS16816_MailboxesList" name on "Mailboxes" page
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DAS16816_Project_Mailboxes' text to 'Project Name' textbox
	And User selects 'DAS16816_MailboxesList' option from 'Scope' autocomplete
	Then Filling field error is not displayed
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	#For Devices filter
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType  | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
	| Department | evergreen/#/devices?$filter=(hostname%20NOT%20CONTAINS%20('001BAQXT6J')%20AND%20chassisCategory%20EQUALS%20('Desktop'%2C'Laptop'%2C'Data%20Centre')%20AND%20buildDate%20<%20'2019-06-04'%20AND%20buildDate%20BEFORE%20RELATIVE%20(10000_day_ago)%20AND%20hDDTotalSpaceGB%20>%2010.78%20AND%20project_63_ragStatusId%20NOT%20EQUALS%20('1520'%2C'1527')%20AND%20project_63_inScope%20EQUALS%20('0'%2C'1')%20AND%20migrationRAG%20EQUALS%20('Unknown'%2C'Red'%2C'Amber'%2C'Green'%2C'Not%20Applicable')%20AND%20deviceListId%20NOT%20IN%20('18')%20AND%20oSCategory%20NOT%20EQUALS%20('OS%20X%2010.9')%20AND%20processorVirtualisationCapable%20EQUALS%20('0'%2C'1'%2C'NULL')%20AND%20applicationManufacturer%20NOT%20EQUALS%20('Abacus%20Internet')%20WHERE%20(nubdo)%20AND%20DepartmentKey%20NOT%20EQUALS%20('16'))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,buildDate,hDDTotalSpaceGB,project_63_ragStatus,project_63_inScope,migrationRAG,processorVirtualisationCapable,project_owner_38_ownerBucket,departmentName,fullDepartmentPath&$orderby=hDDTotalSpaceGB%20asc |
	And User create dynamic list with "DAS16816_DevicesList" name on "Devices" page
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DAS16816_Project_Devices' text to 'Project Name' textbox
	And User selects 'DAS16816_DevicesList' option from 'Scope' autocomplete
	Then Filling field error is not displayed
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS15666 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatTrueValueDisplayedInGridForEvergreenProject
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '15666Project' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "15666Project" text in the Search field for "Project" column
	Then 'TRUE' content is displayed in the 'Evergreen' column 

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17122 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckRedErrorMessageOnScopeChangesIfBrokenListIsSetInProjectScope
	When User creates broken list with 'Broken list DAS17122' name on 'Applications' page
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Country" filter where type is "Equals" with added column and "England" Lookup option
	And User create dynamic list with "17122_List" name on "Devices" page
	When Project created via API and opened
	| ProjectName   | Scope      | ProjectTemplate | Mode               |
	| 17122_Project | 17122_List | None            | Standalone Project |
	Then Page with '17122_Project' header is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "17122_List" list
	Then "17122_List" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList         | Association        |
	| Broken list DAS17122 | Entitled to device |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Projects' left menu item
	When User enters "17122_Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then "The scope changes could not be loaded, there may be an error with one of the lists referred to in the scope details" error in the Scope Changes displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17510
Scenario: EvergreenJnr_AdminPage_CheckHidePanelIconOverlappingInScopeChanges
	When User navigates to "Mailbox Evergreen Capacity Project" project details
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User hides side panel in project details page
	Then Button toggle zindex is greater than tab zindex