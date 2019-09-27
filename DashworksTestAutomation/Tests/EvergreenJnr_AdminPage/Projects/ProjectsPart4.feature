﻿Feature: ProjectsPart4
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11700 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIdColumnIsAddedAndDisplayedCorrectlyToTheAdminProjectGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' header is displayed to user
	When User enters "TestProject11700" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CREATE' button 
	When User have opened Column Settings for "Project" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Project ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Project ID |
	And content is present in the following newly added columns:
	| ColumnName |
	| Project ID |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11985 @DAS12857 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectNameIsDisplayedCorrectlyWhenSpecialSymbolsAreUsedInTheProjectName
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' header is displayed to user
	When User enters "<TestProject11985>" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "<TestProject11985>" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12364 @DAS12999 @DAS13199 @DAS13297 @DAS12485 @DAS12108 @DAS12645 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIsUpdatedWithoutErrors
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| TestProject12364 | All Users | None            | Standalone Project |
	When User navigates to the 'Projects' left menu item
	Then Project "TestProject12364" is displayed to user
	When User selects "Scope" tab on the Project details page
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text	
	When User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 41339 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters 'child' text to 'Search' textbox
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters '' text to 'Search' textbox
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects                               |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	| 01FF97A1FFAC48A1803 (Aultman, Chanel) |
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then "Devices to add (0 of 16819 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect to add objects 
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters 'wpq' text to 'Search' textbox
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters '' text to 'Search' textbox
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects from the expandable multiselect
	| Objects        |
	| 0SH2BQ3EPXTEWN |
	| 30LA8G32UF7HQC |
	| 174HB6RFAHA5CT |
	| 174HB6RFAHA5CT |
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect to add objects 
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters 'office 1' text to 'Search' textbox
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters '' text to 'Search' textbox
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects from the expandable multiselect
	| Objects                                          |
	| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002) |
	| Backburner (2.1.2.0)                             |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then Success message is displayed and contains "6 objects queued for onboarding, 0 objects offboarded" text
	Then "Applications to add (0 of 2079 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then "Devices to add (0 of 16817 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 41337 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11729 @DAS13199 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedIfTryToRemoveCreatedListThatUsedInAnyProject
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "TestDynamicList11729" name on "Devices" page
	Then "TestDynamicList11729" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' header is displayed to user
	When User enters "TestName11729" in the "Project Name" field
	And User selects 'TestDynamicList11729' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11729" name is displayed correctly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Settings button for "TestDynamicList11729" list
	And User clicks Delete button for custom list
	Then "TestDynamicList11729" list "list is used by 1 project, do you wish to proceed?" message is displayed in the list panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "TestName11729" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName11729" is displayed to user
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	And There are no errors in the browser console