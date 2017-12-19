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

@Evergreen @Devices @Evergreen_FiltersFeature @RemoveFilter @DAS-11009 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatResetIsUpdatingRowCount
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance" filter is added to the list
	And "75" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Unknown" values is added to URL
	And "Compliance" column is added to URL
	When User have reset all filters
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,225" rows are displayed in the agGrid
	Then "Compliance" filter is removed from filters

@Evergreen @Devices @Evergreen_FiltersFeature @RemoveFilter @DAS-11044 @DAS-11506
Scenario: EvergreenJnr_DevicesList_CheckThatDeleteByUrlIsUpdatingRowCount
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance" filter is added to the list
	And "75" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Unknown" values is added to URL
	And "Compliance" column is added to URL
	When User is remove filter by URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,225" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Compliance" filter is removed from filters

@Evergreen @Users @Evergreen_FiltersFeature @RemoveFilter @DAS-11009
Scenario: EvergreenJnr_UsersList_CheckThatDeletePartOfFilterFromUrlIsUpdatingRowСount
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	| Green              |
	Then "Compliance" filter is added to the list
	And "41,161" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Red, Amber, Green" values is added to URL
	And "Compliance" column is added to URL
	When User is remove part of filter by URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "41,335" rows are displayed in the agGrid
	Then "Compliance" filter is removed from filters

@Evergreen @Mailboxes @Evergreen_FiltersFeature @RemoveFilter @DAS-10996
Scenario: EvergreenJnr_MailboxesList_CheckThatFiltersIsResetAndDataOnTheGridUpdatedBackToTheFullDataSet
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| London             |
	Then "City" filter is added to the list
	And "1,000" rows are displayed in the agGrid
	And table data is filtered correctly
	When User have reset all filters
	Then "4,835" rows are displayed in the agGrid
	And "City" filter is removed from filters