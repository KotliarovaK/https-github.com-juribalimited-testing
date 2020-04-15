Feature: CustomListDisplayPart8
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS12602 @DAS14183 @DAS12334 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsDisplayedAfterChangingPinnedColumns
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "DynamicList3" name on "<ListName>" page
	When User opens '<PinnedColumnName>' column settings
	When User selects 'Pin left' option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is displayed
	When User opens '<PinnedColumnName>' column settings
	When User selects 'Pin right' option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is displayed
	When User opens '<PinnedColumnName>' column settings
	When User selects 'No pin' option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList3" name
	And User opens '<PinnedColumnName>' column settings
	And User selects 'Pin left' option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is displayed
	When User opens '<PinnedColumnName>' column settings
	And User selects 'Pin right' option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is displayed
	When User opens '<PinnedColumnName>' column settings
	And User selects 'No pin' option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed

Examples:
	| ListName     | ListLabel        | ColumnName       | PinnedColumnName |
	| Devices      | All Devices      | Device Type      | Hostname         |
	| Applications | All Applications | Vendor           | Application      |
	| Users        | All Users        | Domain           | Username         |
	| Mailboxes    | All Mailboxes    | Mailbox Platform | Email Address    |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12515 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User create static list with "<StaticListName>" name on "<ListName>" page with following items
	| ItemName |
	|          |
	Then "<StaticListName>" list is displayed to user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ListLabel        | ColumnName         | StaticListName |
	| Devices      | All Devices      | Owner Display Name | StaticList5548 |
	| Applications | All Applications | Version            | StaticList8944 |
	| Users        | All Users        | Distinguished Name | StaticList7412 |
	| Mailboxes    | All Mailboxes    | Owner Display Name | StaticList9512 |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12524 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User clicks 'SAVE' button and select 'SAVE AS STATIC LIST' menu button
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
	When User clicks 'SAVE' button and select 'SAVE AS NEW DYNAMIC LIST' menu button
	Then Save and Cancel buttons are displayed on the list panel
	When User clicks Cancel button on the list panel
	Then Save and Cancel buttons are not displayed on the list panel

Examples:
	| ListName     | ListLabel        | ColumnName    | AddColumn            | DynamicListName |
	| Devices      | All Devices      | Hostname      | Device Key           | DynamicList1178 |
	| Applications | All Applications | Application   | Barry'sUse: Category | DynamicList1125 |
	| Users        | All Users        | Username      | GUID                 | DynamicList1195 |
	| Mailboxes    | All Mailboxes    | Email Address | Region               | DynamicList1121 |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12524 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatActionsPanelIsHiddenAfterCancellingProcessOfSavingList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
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
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User types "StaticList7841" static list name
	When User clicks 'CANCEL' button
	Then checkboxes are not displayed for content in the grid
	And Actions panel is not displayed to the user
	And Save to New Custom List element is displayed