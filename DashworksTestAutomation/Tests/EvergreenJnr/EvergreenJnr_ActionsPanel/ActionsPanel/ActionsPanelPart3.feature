Feature: ActionsPanelPart9
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14140 @DAS15814
Scenario: EvergreenJnr_DevicesList_CheckBucketBulkUpdateOptionsOnDevicesListForEvergreenProjectAreDisplayedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'Unassigned' option from 'Bucket' autocomplete
	Then following Values are displayed in the 'Also Move Users' dropdown:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects 'Owners only' in the 'Also Move Users' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14142
Scenario: EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForEvergreenProjectAreDisplayedCorrectly
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00C8BC63E7424A6E862 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'Unassigned' option from 'Bucket' autocomplete
	Then following Values are displayed in the 'Also Move Devices' dropdown:
	| Options            |
	| None               |
	| Owned devices only |
	| All linked devices |
	When User selects 'Owned devices only' in the 'Also Move Devices' dropdown
	Then following Values are displayed in the 'Also Move Mailboxes' dropdown:
	| Options              |
	| None                 |
	| Owned mailboxes only |
	| All linked mailboxes |
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	Then 'UPDATE' button is not disabled

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14143
Scenario: EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForUserScopedProjectAreDisplayedCorrectly
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00C8BC63E7424A6E862 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'User Evergreen Capacity Project' option from 'Project or Evergreen' autocomplete
	And User selects 'Unassigned' option from 'Bucket' autocomplete
	Then following Values are displayed in the 'Also Move Devices' dropdown:
	| Options            |
	| None               |
	| Owned devices only |
	| All linked devices |
	When User selects 'Owned devices only' in the 'Also Move Devices' dropdown
	Then 'UPDATE' button is not disabled

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14160
Scenario: EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForMailboxScopedProjectAreDisplayedCorrectly
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00C8BC63E7424A6E862 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Mailbox Evergreen Capacity Project' option from 'Project or Evergreen' autocomplete
	And User selects 'Unassigned' option from 'Bucket' autocomplete
	Then following Values are displayed in the 'Also Move Mailboxes' dropdown:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects 'Owners only' in the 'Also Move Mailboxes' dropdown
	Then 'UPDATE' button is not disabled

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14421
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOperationHasCorrectOptionsForAlsoMoveMailboxes
	When User clicks 'Users' on the left-hand menu
	When User clicks the Actions button
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 00A5B910A1004CF5AC4 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	Then following Values are displayed in the 'Also Move Mailboxes' dropdown:
	| Options              |
	| None                 |
	| Owned mailboxes only |
	| All linked mailboxes |