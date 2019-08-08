﻿Feature: ProjectsPart5
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11881 @DAS12999 @DAS13297 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatEmptyGreenAlertLineIsNotDisplayedOnProjectScopeChangesPageAfterMakingSomeChangesOnScopePage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11881" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11881" name is displayed correctly
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestName11881" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "Do not include applications" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then All Associations are disabled
	When User selects "Scope Changes" tab on the Project details page
	Then Warning message is not displayed on the Admin page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "Include applications" checkbox on the Project details page
	Then All Associations are selected by default
	Then Scope List dropdown is active
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12155 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatScopePanelHaveCorrectlySizeWhenUsedListWithLongName
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" name on "Devices" page
	Then "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User clicks in the Scope field on the Admin page
	Then Scope DDL have the "658" Width

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12349 @DAS12364 @DAS13199 @DAS15685 @Cleanup @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThat500ISEInvalidColumnNameIsNotDisplayedWhenUsedAppSavedListForFilteringDeviceList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" without added column and following value:
	| Values |
	| 8      |
	And User create dynamic list with "ListName12349" name on "Applications" page
	Then "ListName12349" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList  | Association    |
	| ListName12349 | Used on device |
	Then "Any Application" filter is added to the list
	And "99" rows are displayed in the agGrid
	And "Any Application in list ListName12349 used on device" is displayed in added filter info
	And "(Application (Saved List) = ListName12349 ASSOCIATION = ("used on device"))" text is displayed in filter container
	When User create dynamic list with "SavedList12349" name on "Devices" page
	Then "SavedList12349" list is displayed to user
	When Project created via API and opened
	| ProjectName      | Scope          | ProjectTemplate | Mode               |
	| TestProject12349 | SavedList12349 | None            | Standalone Project |
	Then Project "TestProject12349" is displayed to user
	And There are no errors in the browser console
	Then Error message is not displayed
	When User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 0QLZFK7RHMWJLQM |
	| 0RGBQGA7XOOPJSW |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then There are no errors in the browser console
	Then Error message is not displayed
	When User selects "Scope Details" tab on the Project details page
	Then There are no errors in the browser console
	Then Error message is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12777 @DAS13973 @DAS13530 @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreatingProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject22" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	And There are no errors in the browser console
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "TestProject22" checkbox from String Filter with item list on the Admin page
	And User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then "Unassigned" content is displayed in "Maps to Evergreen" column
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "TestProject22" checkbox from String Filter with item list on the Admin page
	And User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then "Unassigned" content is displayed in "Maps to Evergreen" column
	When User clicks "Projects" link on the Admin page
	When User enters "TestProject22" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item