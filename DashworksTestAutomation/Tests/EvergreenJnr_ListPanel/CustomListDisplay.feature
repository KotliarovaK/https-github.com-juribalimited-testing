Feature: DisplayCustomListCreation
	Runs Deisplay Custom List Creation block related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11003
Scenario: Evergreen Jnr_DevicesList_Check that custom list creation block is not displayed when deleting a filter in default list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with "false" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User have removed "Windows7Mi: Category" filter
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11003
Scenario: Evergreen Jnr_DevicesList_Check that custom list creation block is not displayed when reseting a filter in default list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with "false" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11017 @Delete_Newly_Created_List
Scenario: Evergreen Jnr_DevicesList_Check that custom list creation block is not displayed when deleting a filter in custom list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Directory Type" filter
	When User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User have removed "Windows7Mi: Category" filter
	Then Edit List menu is displayed
	When User have removed "Directory Type" filter
	Then Edit List menu is displayed
	When User update current custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11017 @Delete_Newly_Created_List
Scenario: Evergreen Jnr_DevicesList_Check that custom list creation block is not displayed when reseting a filter in custom list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Directory Type" filter
	When User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User have reset all filters
	Then Edit List menu is displayed
	When User update current custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10998
Scenario: Evergreen Jnr_DevicesList_agGrid_Check that Search does not trigger new Custom List
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Henry          | 34           |
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10704
Scenario: Evergreen Jnr_DevicesList_agGrid_Check that quick search doesn't triggers new list menu
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out