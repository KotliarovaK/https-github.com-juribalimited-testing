Feature: RemoveFilter
	Runs Remove Filter related test

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @RemoveFilter @DAS-11009
Scenario: Evergreen Jnr_DevicesList_Check that reset is updating row count
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	And User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance" filter is added to the list
	And "75" rows are displayed in the agGrid
	And table data is filtred currectly
	When User have reset all filters
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,225" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @RemoveFilter @DAS-11044
Scenario: Evergreen Jnr_DevicesList_Check that delete by url is updating row count
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	And User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance" filter is added to the list
	And "75" rows are displayed in the agGrid
	And table data is filtred currectly
	When User is remove filter by URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,225" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Compliance" filter is removed from filters
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @Evergreen_FiltersFeature @RemoveFilter @DAS-11009
Scenario: Evergreen Jnr_UsersList_Check that delete part of filter from url is updating row count
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	And User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	| Green              |
	Then "Compliance" filter is added to the list
	And "41,161" rows are displayed in the agGrid
	And table data is filtred currectly
	When User is remove part of filter by URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "41,335" rows are displayed in the agGrid
	Then "Compliance" filter is removed from filters
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @Evergreen_FilterFeature @RemoveFilter @DAS-10996
Scenario: Evergreen Jnr_MailboxesList_Check that filters is reset and data on the grid updated back to the full data set
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "City" filter
	And User have created "Equals" filter with "true" column checkbox and following options:
	| SelectedCheckboxes |
	| London             |
	Then "City" filter is added to the list
	And "1,000" rows are displayed in the agGrid
	And table data is filtred currectly
	When User have reset all filters
	Then ColumnName is added to the list
	| ColumnName |
	| City       |
	And "4,835" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out