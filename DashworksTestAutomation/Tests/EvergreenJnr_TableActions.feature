#@retry:3
Feature: EvergreenJnr_TableActions
	Runs Evergreen Table actions related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @TableActions @Applications
Scenario: Evergreen Jnr_Applications add custom column action
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have selected following options and clicks save button
	| SelectedOptionName  |
	| A Star Packages     |
	| Add Category column |
	Then "Windows7Mi: Category" filter is added to the list
	Then FilterData is displayed for apropriate column
	| FilterData      |
	| A Star Packages |
	| A Star Packages |
	| A Star Packages |