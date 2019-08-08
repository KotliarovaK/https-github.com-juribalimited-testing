﻿Feature: CustomListDisplayPart9
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS12656 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedAfterDuplicatingANewStaticListWithALongName
	When User create static list with "1111111111111111111111111111111111111111" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "1111111111111111111111111111111111111111" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User duplicates list with "1111111111111111111111111111111111111111" name
	Then "111111111111111111111111111111111111112" list is displayed to user
	Then There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS12685 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatDataFromTheStaticListAreSavedInTheNewListAfterEditing
	When User create static list with "StaticList1412" name on "Users" page with following items
	| ItemName            |
	| 003F5D8E1A844B1FAA5 |
	| 00A5B910A1004CF5AC4 |
	Then "StaticList1412" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Enabled    |
	Then ColumnName is added to the list
	| ColumnName |
	| Enabled    |
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "CustomList5588" name
	Then "CustomList5588" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User duplicates list with "StaticList1412" name
	Then "StaticList14122" list is displayed to user
	Then "2" rows are displayed in the agGrid

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS12630
Scenario: EvergreenJnr_UsersList_CheckThatStaticListIsDisplayedInTheBottomOfTheListPanelWhenNavigateToTheMainList
	When User create static list with "StaticList6542" name on "Users" page with following items
	| ItemName            |
	| 000F977AC8824FE39B8 |
	| 00A5B910A1004CF5AC4 |
	Then "StaticList6542" list is displayed to user
	When User navigates to the "All Users" list
	Then "StaticList6542" list is displayed in the bottom section of the List Panel
	When User clicks Settings button for "StaticList6542" list
	When User clicks Delete button for custom list
	Then "list will be permanently deleted" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	And "List deleted" message is displayed

@Evergreen @Devices @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917
Scenario: EvergreenJnr_DevicesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                | 
	| Green              | 
	And User create custom list with "Test_Device_Filter_DAS_12917" name
	And User clicks the List Details button
	And User changes list name to "EDITED_Device_Filter_DAS_12917"
	And User clicks the Filters button
	And User click Edit button for "Application Compliance" filter
	And User change selected checkboxes:
	| Option | State |
	| Red    | false |
	Then "EDITED_Device_Filter_DAS_12917" edited list is displayed to user