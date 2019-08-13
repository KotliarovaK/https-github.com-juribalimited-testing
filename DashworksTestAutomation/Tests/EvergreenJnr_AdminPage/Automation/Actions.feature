Feature: ActionsPage
	Runs Actions Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @Actions @DAS15427 @DAS15832 @DAS15833 @DAS17276 @Not_Ready
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	#Delete Creating Automation after gold data complete
	When User creates new Automation via API
	| AutomationName        | Description | Active | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_15427 | 15427       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Test_Automation_15427" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Action 1
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "15427_Action1" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	When User clicks the "CREATE" Action button
	#Action 2
	When User clicks the "CREATE ACTION" Action button
	When User type "15427_Action2" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	When User clicks the "CREATE" Action button
	#Action 3
	When User clicks the "CREATE ACTION" Action button
	Then "Test_Automation_15427" object name is displayed to the User
	When User type "15427_Action3" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	When User clicks the "CREATE" Action button
	When User clicks Cog-menu for "15427_Action1" item on Admin page
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
	Then "UPDATE" Action button is displayed
	Then "CANCEL" Action button is displayed
	Then "Test_Automation_15427" object name is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15427 @DAS15428 @DAS16728 @DAS16976 @DAS17067 @DAS16890 @DAS17594 @Not_Ready
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectlyForAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName        | Description | Active | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_15427 | 15427       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Test_Automation_15427" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Action 1
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "DAS15427_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	#Action 2
	When User clicks the "CREATE ACTION" Action button
	When User type "DAS15427_Action_1" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	#Action 3
	When User clicks the "CREATE ACTION" Action button
	When User type "DAS15427_Action_2" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The automation action has been created" text
	When User clicks "Move to top" option in Cog-menu for "DAS15427_Action_2" item on Admin page
	Then "Action" column content is displayed in the following order:
	| Items             |
	| DAS15427_Action_2 |
	| DAS15427_Action   |
	| DAS15427_Action_1 |
	When User clicks "Move to bottom" option in Cog-menu for "DAS15427_Action_2" item on Admin page
	Then "Action" column content is displayed in the following order:
	| Items             |
	| DAS15427_Action   |
	| DAS15427_Action_1 |
	| DAS15427_Action_2 |
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User move "DAS15427_Action_2" item to "7" position on Admin page
	Then "Action" column content is displayed in the following order:
	| Items             |
	| DAS15427_Action   |
	| DAS15427_Action_1 |
	| DAS15427_Action_2 |
	When User move "DAS15427_Action_2" item to "1" position on Admin page
	Then "Action" column content is displayed in the following order:
	| Items             |
	| DAS15427_Action_2 |
	| DAS15427_Action   |
	| DAS15427_Action_1 |
	When User move "DAS15427_Action_2" item to "20" position on Admin page
	Then "Action" column content is displayed in the following order:
	| Items             |
	| DAS15427_Action   |
	| DAS15427_Action_1 |
	| DAS15427_Action_2 |
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15428 @DAS15938 @DAS17186 @DAS17057 @DAS17253 @Not_Ready
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName           | Description | Active | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_DAS15938 | DAS15938    | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Test_Automation_DAS15938" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Action 1
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	Then following Values are displayed in "Action Type" drop-down on the Admin page:
	| Values            |
	| Update path       |
	| Update task value |
	When User type "15428_Action_1" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	#Action 2
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "DAS15427_Action_2" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	#Action 3
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "DAS15427_Action_2" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	Then "Undetermined" content is displayed in the Path Automation dropdown
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	#Action 4
	When User clicks the "CREATE ACTION" Action button
	When User type "15428_Action_3" Name in the "Action Name" field on the Automation details page
	Then Filling field error with "An action with this name already exists for this automation" text is displayed
	When User clicks the "CANCEL" Action button
	When User clicks "YES" button in the Warning Pop-up message
	When User moves "DAS15427_Action_1" action to "DAS15427_Action_3" action
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Action" column content is displayed in the following order:
	| Items             |
	| DAS15427_Action_2 |
	| DAS15427_Action_1 |
	| DAS15427_Action_3 |
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
	Then Create Automation page is displayed to the User
	When User type "" Name in the "Automation Name" field on the Automation details page
	When User type "" Name in the "Description" field on the Automation details page
	Then Filling field error with "An automation name must be entered" text is displayed
	When User type "Melbourne User" Name in the "Automation Name" field on the Automation details page
	When User type "Melbourne users" Name in the "Description" field on the Automation details page
	When User selects "Melbourne Users" in the Scope Automation dropdown
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	Then Create Action page is displayed to the User
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User type "" Name in the "Action Name" field on the Automation details page
	Then Filling field error with "An action name must be entered" text is displayed
	When User type "Melbourne users" Name in the "Action Name" field on the Automation details page
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User selects "Update path" in the "Action Type" dropdown
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User selects "Melbourne User Migration" in the Project dropdown
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CANCEL" Action button is active
	When User selects "User Migration" in the "Path" dropdown for Actions
	Then "SAVE AND CREATE ANOTHER" Action button is active
	Then "CANCEL" Action button is active
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The automation action has been created" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15425 @DAS16143 @DAS17336 @DAS17367 @Not_Ready
#Change value after gold data complete added
Scenario: EvergreenJnr_AdminPage_CheckEditActionPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "15425_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "15425" Name in the "Description" field on the Automation details page
	When User selects "All Users" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User type "15425_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "User Evergreen Capacity Project" in the Project dropdown
	When User selects "[Default (User)]" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "15425_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then "UPDATE" Action button have tooltip with "No changes made" text
	When User clicks "Actions" tab
	When User enters "15425_Action" text in the Search field for "Action" column
	When User clicks content from "Action" column
	Then Edit Action page is displayed to the User
	Then "15425_Action" content is displayed in "Action Name" field
	Then "[Default (User)]" value is displayed in the "Path" dropdown for Automation
	Then "Update path" text value is displayed in the "Action Type" dropdown
	Then "UPDATE" Action button is disabled
	Then "CANCEL" Action button is active
	When User type "" Name in the "Action Name" field on the Automation details page
	Then Filling field error with "An action name must be entered" text is displayed
	Then "UPDATE" Action button is disabled
	When User type "15425_Action" Name in the "Action Name" field on the Automation details page
	Then "UPDATE" Action button is disabled
	When User type "TEST NEW" Name in the "Action Name" field on the Automation details page
	Then "UPDATE" Action button is active
	When User selects "Migration Project Phase 2 (User Project)" in the Project dropdown
	Then "UPDATE" Action button is disabled
	Then "" value is displayed in the "Path" dropdown for Automation
	Then "UPDATE" Action button have tooltip with "Some values are missing or not valid" text
	When User clicks the "CANCEL" Action button
	Then Actions page is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS16992 @DAS17427 @Cleanup @Not_Ready
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
	Then Create Automation page is displayed to the User
	When User type "DAS16992_Edinburgh_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "Task value change" Name in the "Description" field on the Automation details page
	When User selects "Edinburgh Devices" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	#Create Action
	And User clicks the "CREATE" Action button
	Then "CREATE" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	When User type "DAS16992_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update task value" in the "Action Type" dropdown
	When User selects "Edinburgh Devices Migration" in the Project dropdown
	When User selects "Pre-Migration" in the "Stage" dropdown for Actions
	Then following items are displayed in the "Task" dropdown for Actions:
	| Values        |
	| Device Task 1 |
	When User selects "Device Task 1" in the "Task" dropdown for Actions
	When User selects "Unknown" Value for Actions
	Then "CREATE" Action button is active
	When User clicks the "SAVE AND CREATE ANOTHER" Action button
	Then Create Action page is displayed to the User
	#Add steps for running Automation (DAS-17427)

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS16992 @DAS17234 @Cleanup @Not_Ready
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
	Then Create Automation page is displayed to the User
	When User type "17234_Edinburgh_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "Task value change" Name in the "Description" field on the Automation details page
	When User selects "EdinburghDevices_17234" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User type "17234_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update task value" in the "Action Type" dropdown
	When User selects "Edinburgh Devices Migration" in the Project dropdown
	When User selects "Pre-Migration" in the "Stage" dropdown for Actions
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17544 @Not_Ready
Scenario Outline: EvergreenJnr_AdminPage_CheckListOfProjectsOnTheCreateActionsPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "<AutomationName>" Name in the "Automation Name" field on the Automation details page
	When User type "17544" Name in the "Description" field on the Automation details page
	When User selects "<Scope>" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User type "17544_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "<Project1>" in the Project dropdown
	When User selects "<Project2>" in the Project dropdown
	When User selects "<Project3>" in the Project dropdown

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
	Then Create Automation page is displayed to the User
	When User type "Test_Automation_17542" Name in the "Automation Name" field on the Automation details page
	When User type "DAS17542" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	#Create Action
	Then Create Action page is displayed to the User
	When User type "DAS17542_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update task value" in the "Action Type" dropdown
	When User selects "USE ME FOR AUTOMATION(DEVICE SCHDLD)" in the Project dropdown
	When User selects "Stage A" in the "Stage" dropdown for Actions
	When User selects "Workflow task" in the "Task" dropdown for Actions
	And User selects "Started" Value on Action panel
	When User clicks the "CREATE" Action button
	Then "Workflow task" content is displayed for "Task or Field" column