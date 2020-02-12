Feature: CustomListDisplayPart9
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
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Duplicate' option in cogmenu for '1111111111111111111111111111111111111111' list
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
	When User selects 'SAVE AS NEW STATIC LIST' option from Save menu and creates 'CustomList5588' list
	Then "CustomList5588" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks 'Duplicate' option in cogmenu for 'StaticList1412' list
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
	Then 'StaticList6542' list is displayed in the Lists panel
	When User clicks 'Delete' option in cogmenu for 'StaticList6542' list
	Then "list will be permanently deleted" message is displayed in the lists panel
	When User clicks 'DELETE' button
	Then "List deleted" message is displayed

@Evergreen @Devices @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917
Scenario: EvergreenJnr_DevicesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                | 
	| Green              | 
	And User creates 'Test_Device_Filter_DAS_12917' dynamic list
	And User clicks the List Details button
	And User changes list name to "EDITED_Device_Filter_DAS_12917"
	And User clicks the Filters button
	And User click Edit button for "Application Compliance" filter
	And User closes "Red" Chip item in the Filter panel
	And User clicks 'UPDATE' button
	Then "EDITED_Device_Filter_DAS_12917" edited list is displayed to user

@Evergreen @Devices @CustomListDisplay @EvergreenJnr_ListPanel @DAS17711 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatConfirmationDeletionMessageDoesntDisappearsAfterFewSeconds
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Does not equal" without added column and "Virtual" Lookup option
	And User create dynamic list with "List17711" name on "Devices" page
	Then "List17711" list is displayed to user
	When User clicks 'Duplicate' option in cogmenu for 'List17711' list
	Then "List177112" list is displayed to user
	When User navigates to the "List177112" list
	When User clicks 'Delete' option in cogmenu for 'List177112' list
	Then "list will be permanently deleted" message is displayed in the lists panel
	When User waits for '3' seconds
	Then "list will be permanently deleted" message is displayed in the lists panel