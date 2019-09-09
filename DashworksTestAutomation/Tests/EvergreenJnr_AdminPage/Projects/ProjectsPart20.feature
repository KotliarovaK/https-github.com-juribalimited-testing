Feature: ProjectsPart20
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#That test have 'not run' tag, because blue banner closes too fast.
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13347 @DAS11978 @DAS16887 @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatBlueBannerIsDisplayedWithCorrectlyText
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project13347" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "Project13347" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects to the Project
	| Objects         |
	| 00K4CEEQ737BA4L |
	| 00YWR8TJU4ZF8V  |
	| 019BFPQGKK5QT8N |
	| 02C80G8RFTPA9E  |
	| 06T5FX3CUY08AE  |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User navigates to the 'Users' left menu item
	And User expands the object to add 
	When User selects all objects to the Project
	And User navigates to the 'Applications' left menu item
	And User expands the object to add 
	And User selects following Objects to the Project
	| Objects                                                                       |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0)          |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 (12.0.2430.0) |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI (12.0.2430.0)                  |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                            |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                                 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Blue banner with "Object updates being queued, please wait" text is displayed
	Then Success message is displayed and contains "14636 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	When User selects "Do not include applications" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Users' left menu item
	When User waits and expands the "Users" panel to remove
	When User selects all objects to the Project
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Blue banner with "Object updates being queued, please wait" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12756 @DAS13586 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectTypesInTheFilterAlphabetised
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DeviceProject56" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "UserProject56" in the "Project Name" field
	And User selects 'All Users' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxProject56" in the "Project Name" field
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks String Filter button for "Type" column on the Admin page
	Then Type of Projects in filter dropdown are displayed in alphabetical order

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12183 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatAllCheckboxesOnScopeDetailsTabAreWorkedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project12183" in the "Project Name" field
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User selects "Include users associated to mailboxes" checkbox on the Project details page
	And User clicks "Owned mailboxes" associated checkbox on the Project details page
	And User clicks "Delegated mailboxes" associated checkbox on the Project details page
	And User clicks "Other mailbox permissions" associated checkbox on the Project details page
	And User clicks "Mailbox folder permissions" associated checkbox on the Project details page
	And User selects "Do not include users" checkbox on the Project details page
	Then "Owned mailboxes" associated checkbox is checked and cannot be unchecked
	And "Delegated mailboxes " associated checkbox is checked and cannot be unchecked
	And "Other mailbox permissions" associated checkbox is checked and cannot be unchecked
	And "Mailbox folder permissions" associated checkbox is checked and cannot be unchecked
	When User selects "Include users associated to mailboxes" checkbox on the Project details page
	Then "Owned mailboxes" associated checkbox is checked
	And "Delegated mailboxes " associated checkbox is checked
	And "Other mailbox permissions" associated checkbox is checked
	And "Mailbox folder permissions" associated checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS13606 @DAS13162
Scenario: EvergreenJnr_AdminPage_CheckThatProjectDetailsIsPopulatedOnTheAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then "Capacity Mode" dropdown is not displayed
	Then "Capacity Units" dropdown is not displayed
	Then "Windows 7 Migration (Computer Scheduled Project)" content is displayed in "Project Name" field
	Then "Windows7Mi" content is displayed in "Project Short Name" field
	Then "Windows 7 Migration Phase 1Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill;" content is displayed in "Project Description" field
	When User navigates to the 'Scope' left menu item
	Then "Scope Details" tab is disabled
	Then "Scope Changes" tab is disabled
	When User navigates to the 'Capacity' left menu item
	Then 'Capacity Mode' dropdown is displayed
	Then 'Capacity Units' dropdown is displayed
	Then "90" content is displayed in "Percentage capacity to reach before showing amber" field
	Then Menu options are displayed in the following order on the Admin page:
	| Options          |
	| Capacity Details |
	| Units            |
	| Slots            |
	| Override Dates   |
	When User clicks "Administration" navigation link on the Admin page
	When User enters "Barry's User Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then "Barry's User Project" content is displayed in "Project Name" field
	Then "Barry'sUse" content is displayed in "Project Short Name" field
	Then "Barry's User Project" content is displayed in "Project Description" field
	When User clicks "Administration" navigation link on the Admin page
	When User enters "Email Migration" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then "Email Migration" content is displayed in "Project Name" field
	Then "EmailMigra" content is displayed in "Project Short Name" field
	Then "" content is displayed in "Project Description" field
	Then There are no errors in the browser console