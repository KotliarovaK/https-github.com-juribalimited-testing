Feature: ProjectsPart6
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12336 @DAS12745 @DAS13199 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedAfterAddingObjectsOnTheProjectScopeChangesTab
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12336" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "TestName12336" name is displayed correctly
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestName12336" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User expands multiselect to add objects
	And User selects all objects to the Project
	Then "Devices to add (17279 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	Then "Devices to add (0 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User enters '111' text to 'Search' textbox
	And User selects all objects to the Project
	Then "Devices to add (5 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	And User expands multiselect and selects following Objects
	| Objects         |
	| 07RJRCQQJNBJIJQ |
	| 0CFHJY5A8WLUB0J |
	Then "Devices to add (2 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Scope Details" tab on the Project details page
	Then Warning message is not displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12891 @DAS12894 @DAS13254 @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatCancelButtonIsDisplayedWithCorrectColourOnAdminPage
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12891" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "TestName12891" name is displayed correctly
	Then Success message is displayed and contains "The project has been created" text
	When User enters "TestName12891" text in the Search field for "Project" column
	And User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then User sees Cancel button in banner
	And Cancel button is displayed with correctly color
	When User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11701 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatTheFilterSearchIsNotCaseSensitive
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TESTNAME_capital letters" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "TESTNAME_capital letters" name is displayed correctly
	Then Success message is displayed and contains "The project has been created" text
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "testname_small letters" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "testname_small letters" name is displayed correctly
	Then Success message is displayed and contains "The project has been created" text
	When User enters "TestName" text in the Search field for "Project" column
	Then created Project with "testname_small letters" name is displayed correctly
	Then created Project with "TESTNAME_capital letters" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12680 @DAS12157 @DAS13014 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatDevicesToAddAndRemoveAreChangingAppropriate
	When User create static list with "StaticList6527" name on "Devices" page with following items
	| ItemName        |
	| 00BDM1JUR8IF419 |
	| 011PLA470S0B9DJ |
	Then "StaticList6527" list is displayed to user
	When User create static list with "StaticList6528" name on "Devices" page with following items
	| ItemName       |
	| 041V8ZALQ4XPL9 |
	| 04WJ5P9DN0VEEW |
	Then "StaticList6528" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject" in the "Project Name" field
	And User selects 'StaticList6527' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "DevicesProject" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect to add objects 
	When User selects following Objects from the expandable multiselect
	| Objects         |
	| 00BDM1JUR8IF419 |
	| 011PLA470S0B9DJ |
	Then "Devices to add (2 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Scope Details" tab on the Project details page
	When User selects 'StaticList6528' in the 'Scope' dropdown with wait
	When User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	#Then "Devices to remove (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	And Add Objects panel is collapsed