Feature: CustomListDisplayPart7
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingOrRemovingColumns
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User adds columns to the list
	| ColumnName   |
	| <ColumnName> |
	Then Save to New Custom List element is displayed
	When User removes "<ColumnName>" column by Column panel
	Then Save to New Custom List element is NOT displayed
	When User adds columns to the list
	| ColumnName   |
	| <ColumnName> |
	Then Save to New Custom List element is displayed
	When User adds columns to the list
	| ColumnName      |
	| <NewColumnName> |
	When User adds columns to the list
	| ColumnName       |
	| <MoreColumnName> |
	Then Save to New Custom List element is displayed
	When User have reset all columns
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ListLabel        | ColumnName      | NewColumnName | MoreColumnName       |
	| Devices      | All Devices      | Import          | Country       | Windows7Mi: Category |
	| Applications | All Applications | Application Key | Compliance    | App field 2          |
	| Users        | All Users        | City            | Description   | Floor                |
	| Mailboxes    | All Mailboxes    | Alias           | Time Zone     | Building             |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS14183 @DAS12334
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsDisplayedAfterChangingPinnedColumns
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User opens '<ColumnName>' column settings
	When User selects 'Pin left' option from column settings
	Then '<ListLabel>' list should be displayed to the user
	Then Save to New Custom List element is displayed
	When User opens '<ColumnName>' column settings
	When User selects 'Pin right' option from column settings
	Then '<ListLabel>' list should be displayed to the user
	Then Save to New Custom List element is displayed
	When User opens '<ColumnName>' column settings
	When User selects 'No pin' option from column settings
	Then '<ListLabel>' list should be displayed to the user
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ListLabel        | ColumnName       |
	| Devices      | All Devices      | Device Type      |
	| Applications | All Applications | Vendor           |
	| Users        | All Users        | Domain           |
	| Mailboxes    | All Mailboxes    | Mailbox Platform |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS12738 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomListsAfterAddingOrRemovingColumns
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "DynamicList" name on "<ListName>" page
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName      |
	| <NewColumnName> |
	Then Edit List menu is displayed
	When User adds columns to the list
	| ColumnName         |
	| <AddColumnName>    |
	| <AddAnotherColumn> |
	Then Edit List menu is displayed
	When User have reset all columns
	Then Edit List menu is not displayed
	When User create static list with "StaticList" name on "<ListName>" page with following items
	| ItemName       |
	| <SelectedItem> |
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName      |
	| <NewColumnName> |
	Then Edit List menu is displayed
	When User adds columns to the list
	| ColumnName         |
	| <AddColumnName>    |
	| <AddAnotherColumn> |
	Then Edit List menu is displayed
	When User have reset all columns
	Then Edit List menu is not displayed

Examples:
	| ListName     | ListLabel        | ColumnName    | NewColumnName   | SelectedItem                               | AddColumnName | AddAnotherColumn |
	| Devices      | All Devices      | Hostname      | Import          | 001BAQXT6JWFPI                             | Network Card  | Owner City       |
	| Applications | All Applications | Application   | Application Key | 0004 - Adobe Acrobat Reader 5.0.5 Francais | prK: In Scope | Compliance       |
	| Users        | All Users        | Username      | City            | $6BE000-SUDQ9614UVO8                       | Cost Centre   | Department Name  |
	| Mailboxes    | All Mailboxes    | Email Address | Alias           | 000F977AC8824FE39B8@bclabs.local           | Enabled       | Import           |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10998 @DAS10972 @DAS12602 @Cleanup
Scenario Outline: EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRemovingSearchCriteria
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "<DymamicList>" name on "<ListName>" page
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| <Search>       | <Rows>       |
	Then Edit List menu is not displayed
	Then "<DymamicList>" list is displayed to user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | <NewRows>    |
	Then Edit List menu is not displayed
	Then "<DymamicList>" list is displayed to user
	And Clearing the agGrid Search Box
	Then Edit List menu is not displayed
	Then "<DymamicList>" list is displayed to user
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "<StaticList>" name
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| <Search>       | <Rows>       |
	Then Edit List menu is not displayed
	And "<StaticList>" list is displayed to user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | <NewRows>    |
	Then Edit List menu is not displayed
	And "<StaticList>" list is displayed to user
	And Clearing the agGrid Search Box
	Then Edit List menu is not displayed
	And "<StaticList>" list is displayed to user

Examples:
	| DymamicList    | StaticList    | ListName     | ListLabel        | ColumnName    | Search    | Rows  | NewRows |
	| Dynamic10988_1 | Static10988_1 | Devices      | All Devices      | Hostname      | Centre    | 3,283 | 18      |
	| Dynamic10988_2 | Static10988_2 | Users        | All Users        | Username      | Barland   | 3     | 142     |
	| Dynamic10988_3 | Static10988_3 | Applications | All Applications | Application   | Adobe     | 40    | 1       |
	| Dynamic10988_4 | Static10988_4 | Mailboxes    | All Mailboxes    | Email Address | bc-exch07 | 4,188 | 73      |