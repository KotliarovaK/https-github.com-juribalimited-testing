Feature: ActionsPanelPart2
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelWhenOnlOneStaticListExists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList12946" name
	Then "StaticList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	Then following Values are displayed in the 'Action' dropdown:
	| Value                   |
	| Create static list      |
	| Remove from static list |
	| Bulk update             |

Examples:
	| PageName     | ColumnHeader  | RowName                          |
	| Devices      | Hostname      | 001PSUMZYOW581                   |
	| Users        | Username      | 002B5DC7D4D34D5C895              |
	| Applications | Application   | 20040610sqlserverck              |
	| Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDataOnceTheStaticListHasBeenCreated  
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| <Checkboxes>       |
	Then "<FilterName>" filter is added to the list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList12946" name
	Then "StaticList12946" list is displayed to user
	And table content is present
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	#Then "<SelectedRowsCount>" selected rows are displayed in the Actions panel
	When User clicks 'Action' dropdown

Examples:
	| PageName     | FilterName       | Checkboxes | SelectedRowsCount |
	| Devices      | Compliance       | Red        | 9174              |
	| Users        | Compliance       | Red        | 9438              |
	| Applications | Compliance       | Red        | 181               |
	| Mailboxes    | Owner Compliance | Green      | 14701             |

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16059
Scenario: EvergreenJnr_MailboxesList_ChecksThatNoErrorDisplayedWhenBulkUpdateMailboxRings
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| MailboxEve: Ring |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	And User selects 'Mailbox Evergreen Capacity Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then There are no errors in the browser console
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16356
Scenario: EvergreenJnr_UsersList_CheckThatOnUserboxListForRingBulkUpdateOptionsOnlyDisplayedUserScopedProjects 
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName     |
	| $231000-3AC04R8AR431 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	Then 'Project or Evergreen' autocomplete contains following options:
	| Options                                  |
	| Barry's User Project                     |
	| Project with associated broken list      |
	| User Evergreen Capacity Project          |
	| User Scheduled Test (Jo)                 |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16640
Scenario: EvergreenJnr_DevicesList_CheckThatSortOrderForEvergreenBucketsInBulkUpdateIsCorrect
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'Bucket' autocomplete options are sorted in the alphabetical order

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16822 @Do_Not_Run_With_Capacity @Do_Not_Run_With_CapacityUnits
Scenario: EvergreenJnr_DevicesList_CheckThatSortOrderForEvergreenCapacityUnitsInBulkUpdateIsCorrect
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'Capacity Unit' autocomplete options are sorted in the alphabetical order