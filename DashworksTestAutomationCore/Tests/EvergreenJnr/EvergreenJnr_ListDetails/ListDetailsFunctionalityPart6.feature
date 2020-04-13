Feature: ListDetailsFunctionalityPart6
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12536 @Cleanup
Scenario: EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "DynamicList4587" name on "Users" page
	Then "DynamicList4587" list is displayed to user
	When User navigates to the "All Users" list
	And User clicks on 'Domain' column header
	Then data in table is sorted by 'Domain' column in ascending order
	When User create dynamic list with "DynamicList4781" name on "Users" page
	Then "DynamicList4781" list is displayed to user
	When User clicks 'Delete' option in cogmenu for 'DynamicList4781' list
	When User confirms list removing
	And User navigates to the "DynamicList4587" list
	Then inline success banner is not displayed
	When User clicks the List Details button
	Then Details panel is displayed to the user
	And no Warning message is displayed in the list details panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11498 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsPanelDisplaysIfItWasOpenedFromManageMenu
	When User clicks '<PageName>' on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "<ListName>" name
	Then "<ListName>" list is displayed to user
	When User clicks 'Manage' option in cogmenu for '<ListName>' list
	Then Details panel is displayed to the user

Examples:
	| PageName     | ListName              |
	| Devices      | Devices DAS11498      |
	| Users        | Users DAS11498        |
	| Applications | Applications DAS11498 |
	| Mailboxes    | Mailboxes DAS11498    |

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12535 @DAS12791 @DAS12952 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatListDetailsPanelIsDisplayedAfterSelectingManageFromListPanelMenu
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks on 'Email Address' column header
	When User create dynamic list with "DynamicList4557" name on "Mailboxes" page
	Then "DynamicList4557" list is displayed to user
	When User create static list with "StaticList2845" name on "Mailboxes" page with following items
	| ItemName                         |
	| 000F977AC8824FE39B8@bclabs.local |
	| 002B5DC7D4D34D5C895@bclabs.local |
	Then "StaticList2845" list is displayed to user
	And table content is present
	And "2" rows are displayed in the agGrid
	When User navigates to the "All Mailboxes" list
	When User clicks 'Manage' option in cogmenu for 'DynamicList4557' list
	Then "DynamicList4557" list is displayed to user
	And Details panel is displayed to the user
	When User navigates to the "StaticList2845" list
	Then "StaticList2845" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'StaticList2845' list
	Then "StaticList2845" list is displayed to user
	And Details panel is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12967
Scenario Outline: EvergreenJnr_AllLists_CheckThatAllRowsDisplayedOnGridWhenCreatingStaticListAfterSearch
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "<ListName>" name
	Then "<RowsCount>" rows are displayed in the agGrid
	And Static list grid has "<RowsCount>" rows
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName  |
	| <AddColumn> |
	Then "<RowsCount>" rows are displayed in the agGrid
	And Static list grid still has "<RowsCount>" rows

Examples: 
	| PageName     | SearchTerm       | ListName                           | AddColumn                | RowsCount |
	| Applications | microsoft server | Applications Static List DAS-12967 | UserSchedu: Readiness ID | 29        |
	| Users        | Peterson         | Users Static List DAS-12967        | Compliance               | 28        |
	| Devices      | aba              | Devices Static List DAS-12967      | BIOS Name                | 19        |
	| Mailboxes    | ab1              | Mailboxes Static List DAS-12967    | Alias                    | 14        |