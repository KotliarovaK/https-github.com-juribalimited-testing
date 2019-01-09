Feature: Rings
	Runs Rings related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS1467 @Rings
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


