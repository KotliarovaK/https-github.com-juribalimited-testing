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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10781
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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10651
Scenario: Evergreen Jnr_ApplicationsList_Check true-false options and images in filter info
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Hide from End Users" filter
	Then correct true and false options are displayed in filter settings
	When User have created "Equals" filter with "false" column checkbox and following options:
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


@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10754 @DAS-11142 @Delete_Newly_Created_List
Scenario: Evergreen Jnr_UsersList_Check special characters display in filter info
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Display Name" filter
	When User have created "Equals" filter with "true" column checkbox and "O'Conn"/\or#@!()" option
	Then "Display Name" filter is added to the list
	Then Values is displayed in added filter info
	| Values           |
	| O'Conn"/\or#@!() |
	When User create custom list with "TestList" name
	Then "TestList" is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values           |
	| O'Conn"/\or#@!() |
	When User navigates to the "All Users" list
	When User navigates to the "TestList" list
	Then "TestList" is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values           |
	| O'Conn"/\or#@!() |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10781
Scenario: Evergreen Jnr_Applications_Filters_Check that 'Group' and 'Team' related filters is not presented in the list
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Group" filter is not presented in the filters list
	Then "Windows7Mi: Group Key" filter is not presented in the filters list
	Then "Windows7Mi: Team" filter is not presented in the filters list
	Then "Windows7Mi: Team Key" filter is not presented in the filters list
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10776
Scenario: Evergreen Jnr_Devices_Filters_Check that "Empty" and "Not Empty" options is availdable for ObjectKey filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "AD Object Key" filter
	Then "Empty" option is available for this filter
	Then "Not empty" option is available for this filter