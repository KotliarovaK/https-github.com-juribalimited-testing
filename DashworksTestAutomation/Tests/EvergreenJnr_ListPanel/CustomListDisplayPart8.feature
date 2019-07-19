Feature: CustomListDisplayPart8
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS12602 @DAS14183 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsHiddenAfterChangingPinnedColumns
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "DynamicList3" name on "<ListName>" page
	When User have opened column settings for "<PinnedColumnName>" column
	When User have select "Pin Left" option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	When User have select "Pin Right" option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	When User have select "No Pin" option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is not displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList3" name
	And User have opened column settings for "<PinnedColumnName>" column
	And User have select "Pin Left" option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	And User have select "Pin Right" option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	And User have select "No Pin" option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed

Examples:
	| ListName     | ColumnName       | PinnedColumnName |
	| Devices      | Device Type      | Hostname         |
	| Applications | Vendor           | Application      |
	| Users        | Domain           | Username         |
	| Mailboxes    | Mailbox Platform | Email Address    |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12515 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User create static list with "<StaticListName>" name on "<ListName>" page with following items
	| ItemName |
	|          |
	Then "<StaticListName>" list is displayed to user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ColumnName         | StaticListName |
	| Devices      | Owner Display Name | StaticList5548 |
	| Applications | Version            | StaticList8944 |
	| Users        | Distinguished Name | StaticList7412 |
	| Mailboxes    | Owner Display Name | StaticList9512 |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12524 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User clicks Save button on the list panel
	And User selects Save as new list option
	Then Save and Cancel buttons are displayed on the list panel
	When User clicks Cancel button on the list panel
	Then Save and Cancel buttons are not displayed on the list panel
	When User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName  |
	| <AddColumn> |
	Then ColumnName is added to the list
	| ColumnName  |
	| <AddColumn> |
	When User clicks Save button on the list panel
	When User selects Save as new list option
	Then Save and Cancel buttons are displayed on the list panel
	When User clicks Cancel button on the list panel
	Then Save and Cancel buttons are not displayed on the list panel

Examples:
	| ListName     | ColumnName    | AddColumn            | DynamicListName |
	| Devices      | Hostname      | Device Key           | DynamicList1178 |
	| Applications | Application   | Barry'sUse: Category | DynamicList1125 |
	| Users        | Username      | GUID                 | DynamicList1195 |
	| Mailboxes    | Email Address | Region               | DynamicList1121 |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12524 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatActionsPanelIsHiddenAfterCancellingProcessOfSavingList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Device Count (Used) |
	Then ColumnName is added to the list
	| ColumnName          |
	| Device Count (Used) |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save and Cancel buttons are not displayed on the list panel
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User types "StaticList7841" static list name
	And User clicks Cancel button on the Actions panel
	Then Checkboxes are not displayed
	And Actions panel is not displayed to the user
	And Save to New Custom List element is displayed