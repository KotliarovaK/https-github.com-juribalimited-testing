#@retry:3
Feature: FiltersDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @DeviceList @FiltersDisplay @Evergreen_FiltersFeature @DAS-10781
Scenario: Evergreen Device_Compliance_Check that 'Add column' option as available
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	Then "Add Compliance column" checkbox is displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @FiltersDisplay @Evergreen_FiltersFeature @DAS-10651
Scenario: Evergreen Jnr_ApplicationsList_Check true-false options and images in filter info
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Hide from End Users" filter
	Then correct true and false options are displayed in filter settings
	When User have created filter with "false" column checkbox and following options:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	Then Values is displayed in added filter info
	| Values      |
	| true, false |
	| Unknown     |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
