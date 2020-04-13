Feature: ProjectsPart20
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13347 @DAS11978 @DAS16887 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatBlueBannerIsDisplayedWithCorrectlyText
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13347 | All Devices | None            | Standalone Project |
	Then Page with 'Project13347' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands 'Devices to add' multiselect to the 'Devices' tab on Project Scope Changes page and selects following Objects
	| Objects         |
	| 00K4CEEQ737BA4L |
	| 00YWR8TJU4ZF8V  |
	| 019BFPQGKK5QT8N |
	| 02C80G8RFTPA9E  |
	| 06T5FX3CUY08AE  |
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands 'Users to add' multiselect to the 'Users' tab on Project Scope Changes page and selects following Objects
	| Objects                        |
	| AAC860150 (Kerrie D. Ruiz)     |
	| AAD1011948 (Pinabel Cinq-Mars) |
	| AAM044531 (Dustin R. Alvarez)  |
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands 'Applications to add' multiselect to the 'Applications' tab on Project Scope Changes page and selects following Objects
	| Objects                                                                       |
	| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002)                              |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 (12.0.2430.0) |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI (12.0.2430.0)                  |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                            |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                                 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then Blue banner with "Object updates being queued, please wait" text is displayed
	Then '13 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	#waiting for the process to be completed
	When User waits for '3' seconds
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	When User selects "Do not include device owners" checkbox on the Project details page
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects "Do not include applications" checkbox on the Project details page
	#wait until the settings are applied
	When User waits for '3' seconds
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands 'Users to remove' multiselect to the 'Users' tab on Project Scope Changes page and selects following Objects
	| Objects                        |
	| AAC860150 (Kerrie D. Ruiz)     |
	| AAD1011948 (Pinabel Cinq-Mars) |
	| AAM044531 (Dustin R. Alvarez)  |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then Blue banner with "Object updates being queued, please wait" text is displayed
	Then '0 objects queued for onboarding, 3 objects offboarded' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12756 @DAS13586 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectTypesInTheFilterAlphabetised
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DeviceProject56' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'UserProject56' text to 'Project Name' textbox
	And User selects 'All Users' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'MailboxProject56' text to 'Project Name' textbox
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	Then options are sorted in alphabetical order in dropdown for 'Type' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12183 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatAllCheckboxesOnScopeDetailsTabAreWorkedCorrectly
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'Project12183' text to 'Project Name' textbox
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects "Include users associated to mailboxes" checkbox on the Project details page
	And User checks 'Owned mailboxes' checkbox
	And User checks 'Delegated mailboxes' checkbox
	And User checks 'Other mailbox permissions' checkbox
	And User checks 'Mailbox folder permissions' checkbox
	And User selects "Do not include users" checkbox on the Project details page
	Then "Owned mailboxes" associated checkbox is checked and cannot be unchecked
	And "Delegated mailboxes" associated checkbox is checked and cannot be unchecked
	And "Other mailbox permissions" associated checkbox is checked and cannot be unchecked
	And "Mailbox folder permissions" associated checkbox is checked and cannot be unchecked
	When User selects "Include users associated to mailboxes" checkbox on the Project details page
	Then "Owned mailboxes" associated checkbox is checked
	And "Delegated mailboxes" associated checkbox is checked
	And "Other mailbox permissions" associated checkbox is checked
	And "Mailbox folder permissions" associated checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS13606 @DAS13162
Scenario: EvergreenJnr_AdminPage_CheckThatProjectDetailsIsPopulatedOnTheAdminPage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then 'Capacity Mode' dropdown is not displayed
	Then 'Capacity Units' dropdown is not displayed
	Then "Windows 7 Migration (Computer Scheduled Project)" content is displayed in "Project Name" field
	Then "Windows7Mi" content is displayed in "Project Short Name" field
	Then "Windows 7 Migration Phase 1Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill; Test fill;" content is displayed in "Project Description" field
	When User navigates to the 'Scope' left menu item
	Then 'Scope' left menu have following submenu items:
	| Options              |
	| Scope Details        |
	| Scope Changes        |
	| Automated Onboarding |
	| Queue                |
	| History              |
	When User navigates to the 'Capacity' left menu item
	Then 'Capacity Mode' dropdown is displayed
	Then 'Capacity Units' dropdown is displayed
	Then "90" content is displayed in "Percentage capacity to reach before showing amber" field
	Then 'Capacity' left menu have following submenu items:
	| Options          |
	| Capacity Details |
	| Units            |
	| Slots            |
	| Override Dates   |
	When User clicks 'Administration' header breadcrumb
	When User enters "Barry's User Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then "Barry's User Project" content is displayed in "Project Name" field
	Then "Barry'sUse" content is displayed in "Project Short Name" field
	Then "Barry's User Project" content is displayed in "Project Description" field
	When User clicks 'Administration' header breadcrumb
	When User enters "Email Migration" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then "Email Migration" content is displayed in "Project Name" field
	Then "EmailMigra" content is displayed in "Project Short Name" field
	Then "" content is displayed in "Project Description" field
	Then There are no errors in the browser console