﻿Feature: AutomationsLogPart3
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17247 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogMessageForDeletedTaskInAction
	#Pre-requisites:
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| 17247Project | All Devices | None            | Standalone Project |
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17247Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Test      |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name          | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| DAS17247_Task | 17247 | Test             | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Pre-requisites:
	And User clicks "Admin" on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User enters '17247_Automation' text to 'Automation Name' textbox
	When User enters '17247' text to 'Description' textbox
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User enters '17247_Action' text to 'Action Name' textbox
	When User selects "Update task value" in the "Action Type" dropdown
	When User selects '17247Project' option from 'Project' autocomplete
	When User selects "Test" in the "Stage" dropdown for Actions
	When User selects "DAS17247_Task" in the "Task" dropdown for Actions
	When User selects "Update" Update Value on Action panel
	When User selects "Not Applicable" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "7 Aug 2019" Date on Action panel
	And User clicks the "CREATE" Action button
	#Delete Task
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17247Project" Project
	When User navigate to "Tasks" tab
	And User removes "DAS17247_Task" Task
	#Run Automation
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	When User enters "17247_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17247_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User enters "17247_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "TASK DOES NOT EXIST" content is displayed for "Outcome" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17681 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInUserScopedUpdateValueDateOwnerCombination
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName      | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| DAS17681_Automation | DAS17681    | true   | false              | Users with Device Count | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "DAS17681_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters 'DAS17681_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' option from 'Project' autocomplete
	When User selects "Stage 1" in the "Stage" dropdown for Actions
	When User selects "Radiobutton Readiness Date Owner Task (User)" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "On Hold" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "1 Aug 2019" Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "1803 Team" Team on Action panel
	When User selects "Akhila Varghese" Owner on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "DAS17681_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "DAS17681_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "DAS17681_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                                 |
	| USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User)         |
	| USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) (Date)  |
	| USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) (Owner) |
	| USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) (Team)  |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Distinguished Name" column by Column panel
	When User removes "Display Name" column by Column panel
	When User removes "Username" column by Column panel
	When User removes "Domain" column by Column panel
	When User clicks the Columns button
	Then "ON HOLD" content is displayed in "USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User)" column
	Then "1 Aug 2019" content is displayed in "USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) (Date)" column
	Then "Akhila Varghese" content is displayed in "USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) (Owner)" column
	Then "1803 Team" content is displayed in "USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) (Team)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17681 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInUserScopedUpdateValueDateOwnerCombinationWithNoChange
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| 17681_Automation | 17681       | true   | false              | Users with Device Count | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17681_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	When User clicks the "CREATE ACTION" Action button
	When User enters '17681_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects "One" in the "Stage" dropdown for Actions
	When User selects "Radio Date Owner User" in the "Task" dropdown for Actions
	And User selects "No change" Update Value on Action panel
	And User selects "No change" Update Date on Action panel
	And User selects "No change" Update Owner on Action panel
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CREATE" Action button have tooltip with "Select at least one value to change" text
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Select at least one value to change" text