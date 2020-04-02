Feature: UpdatePathPart2
	Runs Bulk Update Update path related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS12863 @DAS13277 @DAS16826
Scenario: EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelButton
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00OMQQXWA1DRI6   |
	| 00RUUMAH9OZN9A   |
	| 00SH8162NAS524   |
	And User selects 'Bulk update' in the 'Action' dropdown
	Then following Values are displayed in the 'Bulk Update Type' dropdown:
	| Options              |
	| Update bucket        |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Devices Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Request Type:Device' option from 'Path' autocomplete
	And User clicks 'CANCEL' button 
	Then Actions panel is not displayed to the user
	Then checkboxes are not displayed for content in the grid

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13074 @Do_Not_Run_With_AdminPage @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsDllAndInSelectedSection
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00OMQQXWA1DRI6   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	Then 'Project' autocomplete contains following options:
	| Options                                          |
	| *Project K-Computer Scheduled Project            |
	| 2004 Rollout                                     |
	| Barry's User Project                             |
	| Computer Scheduled Test (Jo)                     |
	| Devices Evergreen Capacity Project               |
	| Havoc (Big Data)                                 |
	| USE ME FOR AUTOMATION(DEVICE SCHDLD)             |
	| USE ME FOR AUTOMATION(USR SCHDLD)                |
	| User Evergreen Capacity Project                  |
	| User Scheduled Test (Jo)                         |
	| Windows 10 Migration - Depot                     |
	| Windows 10 Teams and Request Types               |
	| Windows 10 Updates - Migration                   |
	| Windows 10 Updates - New York                    |
	| Windows 7 Migration (Computer Scheduled Project) |
	| zDevice Sch for Automations Feature              |
	| zUser Sch for Automations Feature                |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User collapses 'Selected Columns' category
	When User moves to the end of categories list
	When User expands 'Project Stages: Windows7Mi' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                                               |
	| Windows7Mi: Computer Information ---- Text fill; Text fill; |
	| Windows7Mi: Pre-Migration                                   |
	| Windows7Mi: Post Migration                                  |
	| Windows7Mi: Migration                                       |
	| Windows7Mi: Communication                                   |
	| Windows7Mi: Command & Control                               |
	| Windows7Mi: Portal Self Service                             |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142
Scenario: EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Barry's User Project' option from 'Project' autocomplete
	And User selects 'Desktop Replacement' option from 'Path' autocomplete
	When User clears 'Project' autocomplete
	When User clicks 'Action' dropdown
	Then 'Barry's User Project' content is displayed in 'Project' autocomplete

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142 @DAS16826
Scenario: EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	And User selects 'Bulk update' in the 'Action' dropdown
	Then following Values are displayed in the 'Bulk Update Type' dropdown:
	| Options              |
	| Update bucket        |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Havoc (Big Data)' option from 'Project' autocomplete
	And User selects 'User Request Type 2' option from 'Path' autocomplete
	When User clears 'Project' autocomplete
	When User clicks 'Action' dropdown
	Then 'Havoc (Big Data)' content is displayed in 'Project' autocomplete

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142 @DAS12864 @DAS13270
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	Then 'Project' autocomplete options are sorted in the alphabetical order
	When User selects 'User Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'Request Type A' option from 'Path' autocomplete
	When User clears 'Project' autocomplete
	When User clicks 'Action' dropdown
	Then 'User Scheduled Test (Jo)' content is displayed in 'Project' autocomplete

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142 @DAS16826
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnMailboxesPage
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00A5B910A1004CF5AC4@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	Then following Values are displayed in the 'Bulk Update Type' dropdown:
	| Options              |
	| Update bucket        |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	And User selects 'Personal Mailbox - VIP' option from 'Path' autocomplete
	When User clears 'Project' autocomplete
	When User clicks 'Action' dropdown
	Then 'Email Migration' content is displayed in 'Project' autocomplete

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16125
Scenario: EvergreenJnr_DevicesList_CheckThatChangingProjectOrEvergreenDoesNotMakeBrowserTabUnresponsiveAndDoesNotLoadTheClientProcessor
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00CWZRC4UK6W20   |
	| 00HA7MKAVVFDAV   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'London - Southbank' option from 'Capacity Unit' autocomplete
	#====#
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	And User selects '[Default (Computer)]' option from 'Path' autocomplete
	#====#
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project or Evergreen' autocomplete
	And User selects 'Unassigned' option from 'Ring' autocomplete
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'Evergreen Ring 1' option from 'Ring' autocomplete
	#====#
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Stage 2 \ Date Task (Computer)' option from 'Task' autocomplete
	#====#
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'Evergreen Bucket 1' option from 'Bucket' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19149
Scenario: EvergreenJnr_DevicesList_ChecksUpdateRingInBulkUpdateTypeTeamToGroupSecurity
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username        | Password  |
 	| TestBulkUpdater | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Bulk Update Roles" list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	Then 'Project or Evergreen' autocomplete is displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'TestBulkUpdate' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User closes Actions panel
	When User refreshes agGrid
	And User perform search by "Z11REX196H34MG"
	Then 'Unassigned' content is displayed in the 'Evergreen Ring' column
	When User clicks cross icon in Table search field
		#Revert Changes
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	Then 'Project or Evergreen' autocomplete is displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "Z11REX196H34MG"
	Then '[Default (Computer)]' content is displayed in the 'zDeviceAut: Path' column

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19149
Scenario: EvergreenJnr_DevicesList_ChecksUpdatePathInBulkUpdateTypeTeamToGroupSecurity
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username        | Password  |
 	| TestBulkUpdater | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Bulk Update Roles" list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'TestBulkUpdate' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 of 2 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "Z11REX196H34MG"
	Then 'TestBulkUpdate' content is displayed in the 'zDeviceAut: Path' column
	When User clicks cross icon in Table search field
		#Revert Changes
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects '[Default (Computer)]' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 of 2 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "Z11REX196H34MG"
	Then '[Default (Computer)]' content is displayed in the 'zDeviceAut: Path' column