Feature: ActionsPage
	Runs Actions Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @Actions @DAS15427 @DAS15832 @DAS15833 @DAS17276 @DAS17625 @DAS17774 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName        | Description | Active | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_15427 | 15427       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User clicks "Actions" tab
	#Action 1
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User enters '15427_Action1' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects "Undetermined" in the "Path" dropdown for Actions
	#Action 2
	When User clicks the "SAVE AND CREATE ANOTHER" Action button
	Then Success message is displayed and contains "The automation action has been created" text
	When User enters '15427_Action2' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects "Undetermined" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	#Action 3
	When User clicks the "CREATE ACTION" Action button
	Then 'Test_Automation_15427' page header is displayed to the User
	When User enters '15427_Action3' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects "Undetermined" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	And User clicks Group By button on the Admin page and selects "Type" value
	Then Cog menu is not displayed on the Admin page
	And Grid is grouped
	When User clicks Group By button on the Admin page and selects "Type" value
	And User clicks Cog-menu for "15427_Action1" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	#Check Cog Menu for the second Action
	When User clicks Cog-menu for "15427_Action2" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	#Check Cog Menu for the last Action
	When User clicks Cog-menu for "15427_Action3" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	When User clicks "Edit" option in Cog-menu for "15427_Action1" item on Admin page
	Then Edit Action page is displayed to the User
	And "UPDATE" Action button is displayed
	And "CANCEL" Action button is displayed
	And 'Test_Automation_15427' page header is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15427 @DAS15428 @DAS16728 @DAS16976 @DAS17067 @DAS16890 @DAS17594 @DAS17774
Scenario: EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectlyForAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Devices_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User enters 'DAS15427_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	Then Success message is displayed and contains "The automation action has been created" text
	When User clicks Export button on the Admin page
	Then User checks that file "Dashworks export" was downloaded
	#Create Action
	When User clicks "Move to top" option in Cog-menu for "Secont_Action" item on Admin page
	Then "Action" column content is displayed in the following order:
	| Items           |
	| Secont_Action   |
	| First_Action    |
	| Third_Action    |
	| DAS15427_Action |
	When User clicks "Move to bottom" option in Cog-menu for "First_Action" item on Admin page
	Then "Action" column content is displayed in the following order:
	| Items           |
	| Secont_Action   |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User move "Secont_Action" item to "4" position on Admin page
	Then "Action" column content is displayed in the following order:
	| Items           |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	| Secont_Action   |
	When User move "Secont_Action" item to "1" position on Admin page
	Then "Action" column content is displayed in the following order:
	| Items           |
	| Secont_Action   |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	When User move "Secont_Action" item to "20" position on Admin page
	Then "Action" column content is displayed in the following order:
	| Items           |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	| Secont_Action   |
	When User have opened column settings for "Action" column
	When User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User clicks "Delete" option in Cog-menu for "DAS15427_Action" item on Admin page
	Then Warning message with "This action will be permanently deleted" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	When User clicks "Delete" option in Cog-menu for "DAS15427_Action" item on Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected action has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15428 @DAS15938 @DAS17186 @DAS17057 @DAS17253 @DAS17625 @DAS17625 @Cleanup @Not_Ready
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName           | Description | Active | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_DAS15938 | DAS15938    | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	Then "Edit Automation" title is displayed on the Automations page
	When User clicks "Actions" tab
	#Action 1
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	Then following Values are displayed in "Action Type" drop-down on the Admin page:
	| Values            |
	| Update path       |
	| Update task value |
	When User enters '15428_Action_1' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects "Undetermined" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	#Action 2
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User enters '15428_Action_2' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	#Action 3
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User enters '15428_Action_3' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	#Action 4
	When User clicks the "CREATE ACTION" Action button
	When User enters '15428_Action_3' text to 'Action Name' textbox
	Then 'An action with this name already exists for this automation' error message is displayed for 'Action Name' field
	When User clicks the "CANCEL" Action button
	When User moves '15428_Action_1' item to '15428_Action_3' item in the 'Action' column
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Action" column content is displayed in the following order:
	| Items          |
	| 15428_Action_2 |
	| 15428_Action_1 |
	| 15428_Action_3 |
	When User click on 'Task or Field' column header
	Then There are no errors in the browser console

#Remove Pre-requisites after adding it to Gold data
@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15938 @DAS17076 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathAction
#Pre-requisites:
	When User clicks "Users" on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Melbourne" Lookup option
	And User create dynamic list with "Melbourne Users" name on "Users" page
	And User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	Then Create Project button is disabled
	When User enters "Melbourne User Migration" in the "Project Name" field
	Then Create Project button is enabled
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Melbourne User Migration" Project
	Then Project with "Melbourne User Migration" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name           | Description | ObjectTypeString |
	| User Migration | DAS15938    | User             |
	When User navigate to Evergreen link
#Pre-requisites:
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Create Automation" title is displayed on the Automations page
	When User enters '' text to 'Automation Name' textbox
	When User enters '' text to 'Description' textbox
	Then 'An automation name must be entered' error message is displayed for 'Automation Name' field
	When User enters 'Melbourne User' text to 'Automation Name' textbox
	When User enters 'Melbourne users' text to 'Description' textbox
	When User selects "Melbourne Users" in the Scope Automation dropdown
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks the "CREATE" Action button
	Then Create Action page is displayed to the User
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User enters '' text to 'Action Name' textbox
	Then 'An action name must be entered' error message is displayed for 'Action Name' field
	When User enters 'Melbourne users' text to 'Action Name' textbox
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User selects 'Update path' in the 'Action Type' dropdown
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User selects 'Melbourne User Migration' option from 'Project' autocomplete
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User selects "User Migration" in the "Path" dropdown for Actions
	Then "SAVE AND CREATE ANOTHER" Action button is active
	Then "CANCEL" Action button is active
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The automation action has been created" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15425 @DAS16143 @DAS17336 @DAS17367 @DAS17802 @Not_Ready
#Change value after gold data complete added
Scenario: EvergreenJnr_AdminPage_CheckEditActionPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Create Automation" title is displayed on the Automations page
	When User enters '15425_Automation' text to 'Automation Name' textbox
	When User enters '15425' text to 'Description' textbox
	When User selects "All Users" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User enters '15425_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User selects "[Default (User)]" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	Then There are no errors in the browser console
	When User enters "15425_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then "UPDATE" Action button have tooltip with "No changes made" text
	When User clicks "Actions" tab
	When User enters "15425_Action" text in the Search field for "Action" column
	When User clicks content from "Action" column
	Then Edit Action page is displayed to the User
	Then "15425_Action" content is displayed in "Action Name" field
	Then '[Default (User)]' value is displayed in the 'Path' dropdown
	Then 'Update path' text value is displayed in the 'Action Type' dropdown
	Then "UPDATE" Action button is disabled
	Then "CANCEL" Action button is active
	When User enters '' text to 'Action Name' textbox
	Then 'An action name must be entered' error message is displayed for 'Action Name' field
	Then "UPDATE" Action button is disabled
	When User enters '15425_Action' text to 'Action Name' textbox
	Then "UPDATE" Action button is disabled
	When User enters 'TEST NEW' text to 'Action Name' textbox
	Then "UPDATE" Action button is active
	When User selects 'Migration Project Phase 2 (User Project)' option from 'Project' autocomplete
	Then "UPDATE" Action button is disabled
	Then '' value is displayed in the 'Path' dropdown
	Then "UPDATE" Action button have tooltip with "Some values are missing or not valid" text
	When User clicks the "CANCEL" Action button
	Then Actions page is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS16992 @DAS17427 @DAS17625 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForCreateActions
	#Add Pre-requisites to Gold Data
	#Pre-requisites:
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Edinburgh" Lookup option
	And User create dynamic list with "Edinburgh Devices" name on "Devices" page
	And User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	Then Create Project button is disabled
	When User enters "Edinburgh Devices Migration" in the "Project Name" field
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Edinburgh Devices Migration" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName     |
	| Pre-Migration |
	And User clicks "Create Stage" button
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Migration |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesName    | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Device Task 1 | DAS16992 | Pre-Migration | Normal   | Date      | Computer   |                    |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesName    | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Device Task 3 | DAS16992 | Pre-Migration | Group    | Date      | Computer   |                    |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesName    | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Device Task 2 | DAS16992 | Pre-Migration | Normal   | Date      | Computer   |                    |                    |
	Then Success message is displayed with "Task successfully created" text
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesName    | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Device Task 4 | DAS16992 | Pre-Migration | Normal   | Date      | Computer   |                    |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Pre-requisites:
	And User clicks "Admin" on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Create Automation" title is displayed on the Automations page
	When User enters 'DAS16992_Edinburgh_Automation' text to 'Automation Name' textbox
	When User enters 'Task value change' text to 'Description' textbox
	When User selects "Edinburgh Devices" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	#Create Action
	And User clicks the "CREATE" Action button
	Then "CREATE" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	When User enters 'DAS16992_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Edinburgh Devices Migration' option from 'Project' autocomplete
	When User selects 'Pre-Migration' option from 'Stage' autocomplete
	Then following items are displayed in the "Task" dropdown for Actions:
	| Values        |
	| Device Task 1 |
	When User selects "Device Task 1" in the "Task" dropdown for Actions
	When User selects "Unknown" Value for Actions
	Then "CREATE" Action button is active
	When User clicks the "SAVE AND CREATE ANOTHER" Action button
	Then Create Action page is displayed to the User
	#Add steps for running Automation (DAS-17427)

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS16992 @DAS17234 @DAS17625 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdatingTaskWhichImpactsReadinessOwnerAndDueDate
	#Add Pre-requisites to Gold Data
	#Pre-requisites:
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Edinburgh" Lookup option
	And User create dynamic list with "EdinburghDevices_17234" name on "Devices" page
	When Project created via API and opened
	| ProjectName                 | Scope                  | ProjectTemplate | Mode               |
	| Edinburgh Devices Migration | EdinburghDevices_17234 | None            | Standalone Project |
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Edinburgh Devices Migration" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName     |
	| Pre-Migration |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name           | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Devices Task 1 | 17234 | Pre-Migration    | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Pre-requisites:
	And User clicks "Admin" on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	When User enters '17234_Edinburgh_Automation' text to 'Automation Name' textbox
	When User enters 'Task value change' text to 'Description' textbox
	When User selects "EdinburghDevices_17234" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User enters '17234_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Edinburgh Devices Migration' option from 'Project' autocomplete
	When User selects 'Pre-Migration' option from 'Stage' autocomplete
	When User selects "User Task 1" in the "Task" dropdown for Actions
	Then following Values are displayed in "Update Value" drop-down on the Admin page:
	| Options   |
	| Update    |
	| No change |
	Then following Values are displayed in "Update Date" drop-down on the Admin page:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	Then following Values are displayed in "Update Owner" drop-down on the Admin page:
	| Options               |
	| Update                |
	| Remove owner          |
	| Remove owner and team |
	| No change             |
	When User selects "Unknown" Value for Actions
	Then "UPDATE" Action button is active
	When User clicks the "SAVE AND CREATE ANOTHER" Action button
	Then Create Action page is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17544 @Cleanup @Not_Ready
Scenario Outline: EvergreenJnr_AdminPage_CheckListOfProjectsOnTheCreateActionsPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	When User enters '<AutomationName>' text to 'Automation Name' textbox
	When User enters '17544' text to 'Description' textbox
	When User selects "<Scope>" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User enters '17544_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '<Project1>' option from 'Project' autocomplete
	When User selects '<Project2>' option from 'Project' autocomplete
	When User selects '<Project3>' option from 'Project' autocomplete

Examples:
	| AutomationName     | Scope            | Project1                 | Project2                           | Project3                           |
	| 17544_Automation   | All Devices      | User Scheduled Test (Jo) | 1803 Rollout                       | Email Migration                    |
	| 17544_Automation_1 | All Users        | User Scheduled Test (Jo) | 1803 Rollout                       | Email Migration                    |
	| 17544_Automation_2 | All Applications | User Scheduled Test (Jo) | 1803 Rollout                       | Email Migration                    |
	| 17544_Automation-3 | All Mailboxes    | Email Migration          | Mailbox Evergreen Capacity Project | USE ME FOR AUTOMATION(MAIL SCHDLD) |

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17542 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateTaskValueIsDisplayInAutomationsLog
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	When User enters 'Test_Automation_17542' text to 'Automation Name' textbox
	When User enters 'DAS17542' text to 'Description' textbox
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks the "CREATE" Action button
	#Create Action
	Then Create Action page is displayed to the User
	When User enters 'DAS17542_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	When User selects 'Stage A' option from 'Stage' autocomplete
	When User selects "Workflow task" in the "Task" dropdown for Actions
	And User selects "Started" Value on Action panel
	When User clicks the "CREATE" Action button
	Then "Workflow task" content is displayed for "Task or Field" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17602 @DAS17604 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckEditPageLoadingForUpdateTextValue
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17602_Automation | 17602       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17602_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17602_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects "Text Computer" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	When User types "To be updated" Value on Action panel
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17602_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	When User clicks content from "Action" column
	When User selects 'Update task value' in the 'Action Type' dropdown
	#Actions content check
	Then "17602_Action" content is displayed in "Action Name" field
	Then 'Update task value' text value is displayed in the 'Action Type' dropdown
	Then 'One' value is displayed in the 'Stage' dropdown
	Then 'Text Computer' value is displayed in the 'Task' dropdown
	Then 'Text Computer' value is displayed in the 'Task' dropdown
	Then 'Update' value is displayed in the 'Update Value' dropdown
	Then "To be updated" text is displayed in "Value" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17602 @DAS17605 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckEditPageLoadingForRemoveTextValue
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17605_Automation | 17605       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17605_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Create Action with
	When User clicks the "CREATE ACTION" Action button
	When User enters '17605_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects "Text Computer" in the "Task" dropdown for Actions
	When User selects "Remove" in the "Update Value" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17605_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	When User clicks content from "Action" column
	When User selects 'Update task value' in the 'Action Type' dropdown
	#Actions content check
	Then "17605_Action" content is displayed in "Action Name" field
	Then 'Update task value' text value is displayed in the 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' value is displayed in the 'Project' dropdown
	Then 'One' value is displayed in the 'Stage' dropdown
	Then 'Text Computer' value is displayed in the 'Task' dropdown
	Then 'Remove' value is displayed in the 'Update Value' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17602 @DAS17606 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckEditPageLoadingForUpdateDate
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17606_Automation | 17606       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17606_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Create Action with
	When User clicks the "CREATE ACTION" Action button
	When User enters '17606_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects "Date Computer" in the "Task" dropdown for Actions
	And User selects "Update" Update Date on Action panel
	And User selects "5 Aug 2019" Date on Action panel
	#Delete After clarifications
	When User selects "None" in the "Capacity Slot" dropdown for Actions
	#Delete After clarifications
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17606_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	When User clicks content from "Action" column
	When User selects 'Update task value' in the 'Action Type' dropdown
	#Actions content check
	Then "17606_Action" content is displayed in "Action Name" field
	Then 'Update task value' text value is displayed in the 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' value is displayed in the 'Project' dropdown
	Then 'One' value is displayed in the 'Stage' dropdown
	Then 'Date Computer' value is displayed in the 'Task' dropdown
	Then 'Update' value is displayed in the 'Update Date' dropdown
	Then "5 Aug 2019" content is displayed in "Date" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17797 @DAS17816 @Not_Ready @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThanActionFieldsAreNotPrepopulatedWithOldData
	When User creates new Automation via API and open it
	| AutomationName | Description | Active | StopOnFailedAction | Scope       | Run    |
	| DAS17797       | 17797       | true   | false              | All Devices | Manual |
	And User clicks "Actions" tab
	#Action
	And User clicks the "CREATE ACTION" Action button
	And User enters 'DAS17797_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'One' option from 'Stage' autocomplete
	And User selects "Radio Rag Date Owner" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Complete" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "31 Aug 2019" Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "1803 Team" Team on Action panel
	And User selects "Lisa Bailey" Owner on Action panel
	And User clicks the "CREATE" Action button
	#Test
	When User enters "DAS17797_Action" text in the Search field for "Action" column
	And User clicks content from "Action" column
	#DAS-17816 =>
	Then "UPDATE" Action button is disabled
	Then "CANCEL" Action button is active
	Then "UPDATE" Action button have tooltip with "No changes made" text
	#DAS-17816 <=
	When User selects "Radio Rag only Comp" in the "Task" dropdown for Actions
	And User clicks Body container
	And User selects "Radio Rag Date Owner" in the "Task" dropdown for Actions
	Then 'Update Value' content is displayed in 'Update Value' dropdown
	And 'Update Date' content is displayed in 'Update Date' dropdown
	And 'Update Owner' content is displayed in 'Update Owner' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17744 @Not_Ready @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckValueDataInTheGridForActions
	When User creates new Automation via API and open it
	| AutomationName | Description | Active | StopOnFailedAction | Scope     | Run    |
	| DAS17744       | 17744       | true   | false              | All Users | Manual |
	And User clicks "Actions" tab
	#Action
	And User clicks the "CREATE ACTION" Action button
	And User enters 'DAS17744_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'One' option from 'Stage' autocomplete
	And User selects "Radio Rag Date Owner User Req A" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Started" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "5 Sep 2019" Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "1803 Team" Team on Action panel
	And User selects "Lisa Bailey" Owner on Action panel
	And User clicks the "CREATE" Action button
	#Test
	When User enters "DAS17744_Action" text in the Search field for "Action" column
	Then "Started, 2019-09-05, 1803 Team, Lisa Bailey" content is displayed in "Value" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17772 @Not_Ready @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatActionStageSelectboxIsDisplayedForSpecificData
	When User creates new Automation via API and open it
	| AutomationName | Description | Active | StopOnFailedAction | Scope     | Run    |
	| DAS17772       | 17772       | true   | false              | All Users | Manual |
	And User clicks "Actions" tab
	#Action
	And User clicks the "CREATE ACTION" Action button
	And User enters 'DAS17772_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	Then '' content is displayed in 'Stage' autocomplete
	Then 'Stage' autocomplete does NOT have options
	| Options         |
	| Read only tasks |
	Then only below options are displayed in the 'Stage' autocomplete
	| Options |
	| Stage 1 |
	| Stage 2 |
	| Stage 3 |

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17778 @Not_Ready @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckCapacitySlotDataForActions
	When User creates new Automation via API and open it
	| AutomationName | Description | Active | StopOnFailedAction | Scope       | Run    |
	| DA17778        | 17778       | true   | false              | All Devices | Manual |
	And User clicks "Actions" tab
	#Action 1
	And User clicks the "CREATE ACTION" Action button
	And User enters '17778 None' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'Devices Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Stage 1' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '15 Aug 2019' text to 'Date' datepicker
	And User selects 'None' in the 'Capacity Slot' dropdown
	And User clicks the "CREATE" Action button
	#Action 2
	And User clicks the "CREATE ACTION" Action button
	And User enters '17778 Slot' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'Devices Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Stage 1' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '2 Jun 2019' text to 'Date' datepicker
	And User selects 'Scheduled Slot' in the 'Capacity Slot' dropdown
	And User clicks the "CREATE" Action button
	#Test
	When User enters "17778 None" text in the Search field for "Action" column
	And User clicks content from "Action" column
	Then 'None' content is displayed in 'Capacity Slot' dropdown
	When User clicks "Details" tab
	And User clicks "Actions" tab
	When User enters "17778 Slot" text in the Search field for "Action" column
	And User clicks content from "Action" column
	Then 'Scheduled Slot' content is displayed in 'Capacity Slot' dropdown