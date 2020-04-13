Feature: CustomListDisplayPart3
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11018 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatCustomListCreationBlockIsNotDisplayedAfterStartTypingAListName
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	Then Save to New Custom List element is displayed
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and types 'Test' list name
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User clicks the Actions button
	Then Save to New Custom List element is displayed

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11018 @DAS16242
Scenario: EvergreenJnr_UsersList_CheckThatSaveButtonIsInactiveInCustomListCreationBlock
	When User add following columns using URL to the "Users" page:
	| ColumnName          |
	| Compliance          |
	Then Save to New Custom List element is displayed
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and types 'Test' list name
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 000F977AC8824FE39B8 |
	| 003F5D8E1A844B1FAA5 |
	| 002B5DC7D4D34D5C895 |
	| 003F5D8E1A844B1FAA5 |
	And User selects 'Create static list' in the 'Action' dropdown
	Then User type "Test" into Static list name field
	When User clicks the Actions button
	And User selects 'SAVE AS STATIC LIST' option from Save menu
	Then Save button is inactive for Custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11394 @DAS11951 @DAS12152 @DAS12595 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckTheSortOrderIsSavedForExistingListAndNotDeletedAfterClickingResetButtonInColumnsMenu
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User clicks on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User create dynamic list with "Custom List TestName" name on "Devices" page
	Then "Custom List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	When User clicks on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User clicks 'SAVE' button and select 'UPDATE STATIC LIST' menu button
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Custom List TestName" list
	Then "Custom List TestName" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User have reset all columns
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User have reset all columns
	Then data in table is sorted by 'Owner Display Name' column in ascending order

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11011 @DAS12152 @DAS12595 @DAS14783 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewlySavedListIsCreatedWithTheCorrectColumnsAndSortsAndTheSameRowsOfData
	When User create static list with "Static List TestName" name on "Devices" page with following items
	| ItemName       |
	| 00HA7MKAVVFDAV |
	| 001PSUMZYOW581 |
	| 00I0COBFWHOF27 |
	Then "Static List TestName" list is displayed to user
	Then "3" rows are displayed in the agGrid
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User clicks on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	And Edit List menu is not displayed
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	Then User removes selected rows
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	Then "2" rows are displayed in the agGrid
	And data in table is sorted by 'Owner Display Name' column in ascending order
	And ColumnName is added to the list
	| ColumnName |
	| Compliance |