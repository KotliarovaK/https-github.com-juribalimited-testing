Feature: ActionsPanelPart9
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14140 @DAS15814
Scenario: EvergreenJnr_DevicesList_CheckBucketBulkUpdateOptionsOnDevicesListForEvergreenProjectAreDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	| 001PSUMZYOW581   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "Unassigned" option in "Bucket" field on Action panel
	Then following values are displayed in "Also Move Users" drop-down on Action panel:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects "Owners only" option in "Also Move Users" drop-down on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14142
Scenario: EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForEvergreenProjectAreDisplayedCorrectly
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00C8BC63E7424A6E862 |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "Unassigned" option in "Bucket" field on Action panel
	Then following values are displayed in "Also Move Devices" drop-down on Action panel:
	| Options            |
	| None               |
	| Owned devices only |
	| All linked devices |
	When User selects "Owned devices only" option in "Also Move Devices" drop-down on Action panel
	Then following values are displayed in "Also Move Mailboxes" drop-down on Action panel:
	| Options              |
	| None                 |
	| Owned mailboxes only |
	| All linked mailboxes |
	When User selects "Owned mailboxes only" option in "Also Move Mailboxes" drop-down on Action panel
	Then "UPDATE" Action button is active

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14143
Scenario: EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForUserScopedProjectAreDisplayedCorrectly
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00C8BC63E7424A6E862 |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	And User selects "User Evergreen Capacity Project" Project on Action panel
	And User selects "Unassigned" option in "Bucket" field on Action panel
	Then following values are displayed in "Also Move Devices" drop-down on Action panel:
	| Options            |
	| None               |
	| Owned devices only |
	| All linked devices |
	When User selects "Owned devices only" option in "Also Move Devices" drop-down on Action panel
	Then "UPDATE" Action button is active

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14160
Scenario: EvergreenJnr_UsersList_CheckBucketBulkUpdateOptionsOnUsersListForMailboxScopedProjectAreDisplayedCorrectly
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00C8BC63E7424A6E862 |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	And User selects "Mailbox Evergreen Capacity Project" Project on Action panel
	And User selects "Unassigned" option in "Bucket" field on Action panel
	Then following values are displayed in "Also Move Mailboxes" drop-down on Action panel:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects "Owners only" option in "Also Move Mailboxes" drop-down on Action panel
	Then "UPDATE" Action button is active
