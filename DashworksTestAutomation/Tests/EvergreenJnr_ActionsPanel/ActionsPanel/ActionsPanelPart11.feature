Feature: ActionsPanelPart11
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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
	And User selects "Project" Project or Evergreen on Action panel
	And User selects 'Mailbox Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects "Unassigned" Ring on Action panel
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
	And User selects "Project" Project or Evergreen on Action panel
	Then following values are displayed in "Project" drop-down with searchfield on Action panel:
	| Options                                  |
	| Barry's User Project                     |
	| Migration Project Phase 2 (User Project) |
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
	And User selects "Evergreen" Project or Evergreen on Action panel
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
	And User selects "Evergreen" Project or Evergreen on Action panel
	Then 'Capacity Unit' autocomplete options are sorted in the alphabetical order

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16844
Scenario: EvergreenJnr_DevicesList_CheckThatBulkUpdateOfArchivedItemsWorks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User sets includes archived devices in 'true'
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "Evergreen Capacity Unit 1" Capacity Unit on Action panel
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then There are no errors in the browser console
	And Success message with "1 update has been queued" text is displayed on Action panel

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS17639 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatSlotIsDisplayedInDDLIfSelectDateWithUnlimitedCapacity
	When User creates new Slot via Api
	| Project      | SlotName   | DisplayName | CapacityType    | ObjectType | Tuesday | Tasks                     |
	| 1803 Rollout | Slot 17639 | 17639       | Teams and Paths | Device     | 10      | Migration \ Migrated Date |
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User selects next Tuesday Date on Action panel
	Then following values are presented in "Capacity Slot" drop-down on Action panel:
	| Options    |
	| None       |
	| Slot 17639 |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @Capacity @Slots @DAS17833 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatFullSlotIsDisplayedWhileRulesShouldHonourTheDateRangeButNotTheTotalCapacity
	When User creates new Slot via Api
	| Project      | SlotName    | DisplayName | CapacityType    | ObjectType | Tuesday | Tasks                     |
	| 1803 Rollout | Slot17833_1 | 17833_1     | Teams and Paths | Device     | 1       | Migration \ Migrated Date |
	| 1803 Rollout | Slot17833_2 | 17833_2     | Teams and Paths | Device     | 2       | Migration \ Migrated Date |
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select all rows
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User selects next Tuesday Date on Action panel
	And User selects 'Slot17833_1' in the 'Capacity Slot' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	And User clicks refresh button in the browser
	And User clicks the Actions button
	And User select all rows
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User selects next Tuesday Date on Action panel
	Then following values are presented in "Capacity Slot" drop-down on Action panel:
	| Options    |
	| None       |
	| Slot17833_1|
	| Slot17833_2|