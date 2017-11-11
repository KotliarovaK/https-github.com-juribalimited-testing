#@retry:3
Feature: AddColumnAction
	Runs Add column related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @AddColumnAction @EvergreenJnr_Columns @DAS-10665
Scenario: Evergreen Jnr_Devices Add the Device key column to the devices list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Device Key          |
	Then ColumnName is added to the list
	| ColumnName          |
	| Device Key          |
	And Content is present in the newly added column
	| ColumnName          |
	| Device Key          |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @AddColumnAction @EvergreenJnr_Columns @DAS-10734
Scenario: Evergreen Jnr_ApplicationsList_Add Custom Column Action
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| A Star Packages     |
	Then "Windows7Mi: Category" filter is added to the list
	Then FilterData is displayed for apropriate column
	| FilterData      |
	| A Star Packages |
	| A Star Packages |
	| A Star Packages |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out