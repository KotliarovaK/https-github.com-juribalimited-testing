Feature: ListDetailsFunctionalityPart9
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17651 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatArchivedItemStillRemainsInStaticList
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in "true"
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User perform search by "00I0COBFWHOF27"
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList17651" name
	Then "StaticList17651" list is displayed to user
	And "2" rows are displayed in the agGrid
	When User navigates to the "1803 Rollout" list
	Then "1803 Rollout" list is displayed to user
	When User navigates to the "StaticList17651" list
	Then "StaticList17651" list is displayed to user
	And "2" rows are displayed in the agGrid

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17552
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCustomFieldFiltersAndColumnsAreMultiValue
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
Scenario: EvergreenJnr_DashboardsPage_CheckThatArchivedItemsCheckboxDisplayedInListDetails
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks "1803 Rollout" list name in left panel
	And User clicks the List Details button
	Then List details panel is displayed to the user
	And 'Archived devices included' label is displayed in List Details

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18089
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatArchivedItemsCheckboxINotDisplayedInListDetails
	When User clicks '<PageName>' on the left-hand menu
	Then '<ListToNavigate>' list should be displayed to the user
	When User clicks "<List>" list name in left panel
	And User clicks the List Details button
	Then List details panel is displayed to the user
	And 'Archived devices included' label is not displayed in List Details

Examples: 
	| PageName     | ListToNavigate   | List                              |
	| Users        | All Users        | Users Readiness Columns & Filters |
	| Applications | All Applications | 1803 Apps                         |
	| Mailboxes    | All Mailboxes    | Mailbox Pivot (Complex)           |