Feature: Rings
	Runs Rings related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS14867 @Rings
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorDisplayedWhenDeletingRing
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Rings" tab
	And User clicks the "CREATE RING" Action button
	Then "Create Ring" page should be displayed to the user
	When User type "TestRing" Name in the "Ring name" field on the Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| TestRing         |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected ring has been deleted" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS14780 @Rings @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForDAS14780" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User enters "ProjectForDAS14780" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "ProjectForDAS14780" is displayed to user
	When User clicks "Details" tab
	Then "Clone evergreen rings to project rings" text value is displayed in the "Rings" dropdown
	When User clicks "Rings" tab
	And User enters "Unassigned" text in the Search field for "Ring" column
	And User clicks content from "Ring" column
	Then Ring settings Maps to evergreen ring is displayed as "Unassigned"
	When User sets "None" value in Maps to evergreen ring field
	Then Ring settings Maps to evergreen ring is displayed as "None"

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS14901 @Rings
Scenario: EvergreenJnr_AdminPage_CheckThatOneRingAddeddAfterMulticlickingCreateButton
	When User clicks Admin on the left-hand menu
	And User clicks "Rings" link on the Admin page
	And User clicks the "CREATE RING" Action button
	And User type "OneRing" Name in the "Ring name" field on the Project details page
	And User doubleclicks Create button on Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User enters "OneRing" text in the Search field for "Ring" column
	Then Counter shows "1" found rows
	And There are no errors in the browser console