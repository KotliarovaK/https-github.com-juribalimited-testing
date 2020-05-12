Feature: ListDetailsFunctionalityPart9
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17651 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatArchivedItemStillRemainsInStaticList
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in 'true'
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User perform search by "00I0COBFWHOF27"
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList17651" name
	Then "StaticList17651" list is displayed to user
	When User closes Tools panel
	Then "2" rows are displayed in the agGrid
	When User navigates to the "2004 Rollout" list
	Then "2004 Rollout" list is displayed to user
	When User navigates to the "StaticList17651" list
	Then "StaticList17651" list is displayed to user
	And "2" rows are displayed in the agGrid
	And Archived devices icon enabled state is 'true' in toolbar

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17552
Scenario Outline: EvergreenJnr_AllLists_CheckThatCustomFieldFiltersAndColumnsAreMultiValue
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	And User add "<CustomColumn>" filter where type is "<Operator>" with added column and following value:
	| Values        |
	| <CustomValue> |
	Then '<ColumnData>' content is displayed in the '<CustomColumn>' column

Examples: 
	| ListName     | CustomValue | Operator | ColumnData                                | CustomColumn        |
	| Devices      | aaa         | Equals   | 0.665371384, 1kk, 2kk, 3kk, aaa, bbb, ccc | ComputerCustomField |
	| Mailboxes    | aaa         | Equals   | 1kk, 2kk, 3kk, aaa, bbb, ccc              | Mailbox Filter 1    |
	| Applications | aaa         | Equals   | 1kk, 2 kk, 3kk, abdc, aaa, bbb            | App field 1         |

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18089
Scenario: EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxDisplayedInListDetails
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "2004 Rollout" list
	Then "2004 Rollout" list is displayed to user
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User checks 'Archived Devices Included' checkbox
	Then Archived devices icon enabled state is 'true' in toolbar
	Then 'SAVE AS NEW STATIC LIST' menu button is displayed for 'SAVE' button

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17440 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckArchivedItemsIconDisplayingAfterDeselectingArchivedItems
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in 'true'
	And User create dynamic list with "List17440" name on "Devices" page
	When User navigates to the "List17440" list
	And User clicks the List Details button
	Then Details panel is displayed to the user
	When User unchecks 'Archived Devices Included' checkbox
	Then Archived devices icon enabled state is 'false' in toolbar
	Then 'SAVE AS NEW DYNAMIC LIST' menu button is displayed for 'SAVE' button

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18089
Scenario Outline: EvergreenJnr_DevicesList_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails
	When User clicks '<PageName>' on the left-hand menu
	Then '<ListToNavigate>' list should be displayed to the user
	When User navigates to the "<List>" list
	And User clicks the List Details button
	Then Details panel is displayed to the user
	And 'Archived devices included' label is not displayed in List Details

Examples: 
	| PageName     | ListToNavigate   | List                              |
	| Users        | All Users        | Users Readiness Columns & Filters |
	| Applications | All Applications | 2004 Apps                         |
	| Mailboxes    | All Mailboxes    | Mailbox Pivot (Complex)           |

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18127 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForDynamicList
	When User clicks '<Lists>' on the left-hand menu
	When User clicks the Filters button
	When User add "<Filter>" filter where type is "Equals" with added column and following value:
	| Values       |
	| <SearchTerm> |
	When User create dynamic list with "<ListName>" name on "<Lists>" page
	When User navigates to the "<ListName>" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then '<ListType>' label is displayed in List Details
	Then '<Data>' label is displayed in List Details

Examples: 
| Lists        | Filter      | SearchTerm                                | ListName                  | ListType           | Data               |
| Devices      | Hostname    | 00CWZRC4UK6W20                            | ADynamicDevices18127      | List Type: Dynamic | Data: Devices      |
| Applications | Application | Microsoft Office 97, Professional Edition | ADynamicApplications18127 | List Type: Dynamic | Data: Applications |