Feature: ActionsPanelPart4
	Runs Actions Panel related tests

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
	Then following values are displayed in "Bulk Update Type" drop-down on Action panel:
	| Options              |
	| Update bucket        |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Babel (English, German and French)' option from 'Project' autocomplete
	And User selects "Machines" Path on Action panel
	And User clicks 'CANCEL' button 
	Then Actions panel is not displayed to the user
	And Checkboxes are not displayed

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
	| 1803 Rollout                                     |
	| Babel (English, German and French)               |
	| Barry's User Project                             |
	| Computer Scheduled Test (Jo)                     |
	| Devices Evergreen Capacity Project               |
	| Havoc (Big Data)                                 |
	| I-Computer Scheduled Project                     |
	| Migration Project Phase 2 (User Project)         |
	| Project 00 M Computer Scheduled                  |
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
	And User closed "Selected Columns" columns category
	And User is expand "Project Stages: Windows7Mi" columns category
	And the following Column subcategories are displayed for open category:
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
	And User selects "Desktop Replacement" Path on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "Barry's User Project" Project is displayed on Action panel

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
	Then following values are displayed in "Bulk Update Type" drop-down on Action panel:
	| Options              |
	| Update bucket        |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Havoc (Big Data)' option from 'Project' autocomplete
	And User selects "User Request Type 2" Path on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "Havoc (Big Data)" Project is displayed on Action panel