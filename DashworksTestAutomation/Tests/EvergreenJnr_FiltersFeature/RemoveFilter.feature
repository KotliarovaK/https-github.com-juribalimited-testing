@retry:1
Feature: RemoveFilter
	Runs Remove Filter related test

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @RemoveFilter @DAS11009
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
	And "Compliance" filter with "Unknown" values is added to URL on "Devices" page
	And "Compliance" column is added to URL on "Devices" page
	When User have reset all filters
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,225" rows are displayed in the agGrid
	Then "Compliance" filter is removed from filters

@Evergreen @Devices @Evergreen_FiltersFeature @RemoveFilter @DAS11506
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
	And "Compliance" filter with "Unknown" values is added to URL on "Devices" page
	And "Compliance" column is added to URL on "Devices" page
	When User is remove filter by URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,225" rows are displayed in the agGrid
	#When User clicks the Filters button
	Then "Compliance" filter is removed from filters

@Evergreen @Users @Evergreen_FiltersFeature @RemoveFilter @DAS11009 @DAS11044 @DAS12199
Scenario: EvergreenJnr_UsersList_CheckThatDeletePartOfFilterFromUrlIsUpdatingRowCount
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Username   |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	| Green              |
	Then "Compliance" filter is added to the list
	And "41,164" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Red, Amber, Green" values is added to URL on "Users" page
	And "Compliance" column is added to URL on "Users" page
	When User is remove part of filter URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "41,339" rows are displayed in the agGrid
	Then Filters panel is displayed to the user
	Then "Compliance" filter is removed from filters

@Evergreen @Mailboxes @Evergreen_FiltersFeature @RemoveFilter @DAS10996 @DAS12207
Scenario: EvergreenJnr_MailboxesList_CheckThatFiltersIsResetAndDataOnTheGridUpdatedBackToTheFullDataSet
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| London             |
	Then "City" filter is added to the list
	And "3,294" rows are displayed in the agGrid
	And table data is filtered correctly
	When User have reset all filters
	Then "14,784" rows are displayed in the agGrid
	And "City" filter is removed from filters

@Evergreen @AllLists @Evergreen_FiltersFeature @RemoveFilter @DAS12635 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatCancelingUnsavedFilterDoesNotReloadList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: In Scope" filter
	When User deletes filter and agGrid does not reload
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	#When User clicks the Filters button
	#Then Filters panel is displayed to the user
	When user select "Owner Enabled" filter
	When User cancels filter and agGrid does not reload
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Count (Entitled to Owned Device)" filter where type is "Equals" without added column and following value:
	| Values |
	| 0      |
	When User create dynamic list with "TestList12635" name on "Users" page
	Then "TestList12635" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add And button on the Filter panel
	When user select "Device Count" filter
	When User deletes filter and agGrid does not reload
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	#When User clicks the Filters button
	#Then Filters panel is displayed to the user
	When User add "User Count (Entitled)" filter where type is "Equals" without added column and following value:
	| Values |
	| 100    |
	When User create dynamic list with "TestList12635" name on "Applications" page
	Then "TestList12635" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	When user select "Compliance" filter
	When User deletes filter and agGrid does not reload