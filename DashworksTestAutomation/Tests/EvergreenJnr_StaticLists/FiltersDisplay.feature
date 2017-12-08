#@retry:3
Feature: FiltersDisplay
	Runs Static Filters Display related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_StaticLists @FiltersDisplay @DAS-10993 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_Check that dynamic filters are cleared for static lists when opened after dynamic lists
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	And "5,130" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 01BQIYGGUW5PRP6  |
	| 020JQ9RO0J4H07X  |
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	And "2" rows are displayed in the agGrid
	When User navigates to the "TestList" list
	Then "5,130" rows are displayed in the agGrid
	When User navigates to the "Static List TestName" list
	Then "2" rows are displayed in the agGrid
	Then Filters Button is dsabled