Feature: ActionsPanelPart8
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13293 @DAS13359
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBannerMessage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| Havoc(BigD: Stage 0 \ Task 0 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Havoc(BigD: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Havoc(BigD: In Scope" filter is added to the list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Havoc (Big Data)' option from 'Project' autocomplete
	And User selects 'Stage 0' option from 'Stage' autocomplete
	And User selects 'Task 0' option from 'Task' autocomplete
	And User selects "Started" Value on Action panel
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "7578 of 7578 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "STARTED" content is displayed for "Havoc(BigD: Stage 0 \ Task 0" column

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13386
Scenario: EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Pre-Migration' option from 'Stage' autocomplete
	Then following Tasks are displayed in drop-down:
	| Options                |
	| Forecast Date          |
	| Forecast Code          |
	| Target Date            |
	| Scheduled Date         |
	| Laptop Only Task       |
	| Physical Only Task     |
	| VDI Only Task          |
	| Laptop & Physical Task |
	| Target Code            |
	| Scheduled Code         |
	| Further Information    |
	| Targeting Information  |
	| Laptop & Workstation 2 |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13386 @DAS13477
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasks
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 003F5D8E1A844B1FAA5 |
	| 00A5B910A1004CF5AC4 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'User Scheduled Test (Jo)' option from 'Project' autocomplete
	Then following Stage are displayed in drop-down:
	| Options |
	| One     |
	| Two     |
	| Three   |
	When User selects 'One' option from 'Stage' autocomplete
	Then following Tasks are displayed in drop-down:
	| Options                            |
	| Radio Rag only User                |
	| Radio Rag Date User                |
	| Radio Rag Date Owner User          |
	| Text User                          |
	| Radio Rag Only User Req A          |
	| Radio Rag Date User Req A          |
	| Radio Rag Date Owner User Req A    |
	| Radio Rag only User Req B          |
	| Radio Rag Date User Req B          |
	| Radio Rag Date Owner User Req B    |
	| Radio Rag Date Owner Req B         |
	| SS Department and Location Enabled |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14421
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMailboxes
	When User clicks 'Users' on the left-hand menu
	When User clicks the Actions button
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 00A5B910A1004CF5AC4 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Project' in the 'Project or Evergreen' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	And User selects "Unassigned" Capacity Unit on Action panel
	Then following Move Mailboxes are displayed in drop-down:
	| Options              |
	| None                 |
	| Owned mailboxes only |
	| All linked mailboxes |