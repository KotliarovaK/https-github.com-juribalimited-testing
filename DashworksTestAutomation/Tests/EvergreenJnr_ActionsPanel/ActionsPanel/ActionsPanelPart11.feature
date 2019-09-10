Feature: ActionsPanelPart11
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16059
Scenario: EvergreenJnr_MailboxesList_ChecksThatNoErrorDisplayedWhenBulkUpdateMailboxRings
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
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
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update ring" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	And User selects "Mailbox Evergreen Capacity Project" Project on Action panel
	And User selects "Unassigned" Ring on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And There are no errors in the browser console
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16356
Scenario: EvergreenJnr_UsersList_CheckThatOnUserboxListForRingBulkUpdateOptionsOnlyDisplayedUserScopedProjects 
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName     |
	| $231000-3AC04R8AR431 |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update ring" Bulk Update Type on Action panel
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
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	Then options for "Bucket" field are displayed in alphabetical order on Action panel

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16822
Scenario: EvergreenJnr_DevicesList_CheckThatSortOrderForEvergreenCapacityUnitsInBulkUpdateIsCorrect
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	Then options for "Capacity Unit" field are displayed in alphabetical order on Action panel

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16844
Scenario: EvergreenJnr_DevicesList_CheckThatBulkUpdateOfArchivedItemsWorks
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User sets includes archived devices in "true"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "Evergreen Capacity Unit 1" Capacity Unit on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And There are no errors in the browser console
	And Success message with "1 update has been queued" text is displayed on Action panel