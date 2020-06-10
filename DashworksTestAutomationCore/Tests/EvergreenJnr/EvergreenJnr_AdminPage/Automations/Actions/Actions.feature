Feature: ActionsPage
	Runs Actions Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @Actions @DAS15427 @DAS15832 @DAS15833 @DAS17276 @DAS17625 @DAS17774 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name                  | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_15427 | 15427       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Action 1
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	When User enters '15427_Action1' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	#Action 2
	When User clicks 'SAVE & CREATE ANOTHER' button 
	Then 'The automation action has been created' text is displayed on inline success banner
	When User enters '15427_Action2' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Undetermined' option from 'Path' autocomplete
	And User clicks 'CREATE' button 
	#Action 3
	When User clicks 'CREATE ACTION' button 
	Then Page with 'Test_Automation_15427' header is displayed to user
	When User enters '15427_Action3' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Undetermined' option from 'Path' autocomplete
	And User clicks 'CREATE' button 
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Type       | true  |
	Then Cog menu is not displayed on the Admin page
	And Grid is grouped
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Type       | false |
	When User clicks Cog-menu for '15427_Action1' item in the 'Action' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	#Check Cog Menu for the second Action
	When User clicks Cog-menu for '15427_Action2' item in the 'Action' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	#Check Cog Menu for the last Action
	When User clicks Cog-menu for '15427_Action3' item in the 'Action' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Move to top      |
	| Move to position |
	| Delete           |
	When User clicks 'Edit' option in Cog-menu for '15427_Action1' item from 'Action' column
	#Then Edit Action page is displayed to the User
	Then 'Edit Action' page subheader is displayed to user
	Then 'UPDATE' button is disabled
	Then 'CANCEL' button is displayed
	Then Page with 'Test_Automation_15427' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15427 @DAS15428 @DAS16728 @DAS16976 @DAS17067 @DAS16890 @DAS17594 @DAS17774 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectlyForAutomations
	Given Display order for 'Devices_Scope' automation 'First_Action' action is '1'
	And Display order for 'Devices_Scope' automation 'Secont_Action' action is '2'
	And Display order for 'Devices_Scope' automation 'Third_Action' action is '3'
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "Devices_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	When User enters 'DAS15427_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	Then 'Undetermined' content is displayed in 'Path' textbox
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	Then 'The automation action has been created' text is displayed on inline success banner
	#Investigate downloading file on Remote
	#When User clicks Export button on the Admin page
	#Then User checks that file "Dashworks export" was downloaded
	#Create Action
	When User clicks 'Move to top' option in Cog-menu for 'Secont_Action' item from 'Action' column
	Then Content in the 'Action' column is equal to
	| Content         |
	| Secont_Action   |
	| First_Action    |
	| Third_Action    |
	| DAS15427_Action |
	When User clicks 'Move to bottom' option in Cog-menu for 'First_Action' item from 'Action' column
	Then Content in the 'Action' column is equal to
	| Content         |
	| Secont_Action   |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	When User opens 'Action' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Processing Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in table is sorted by 'Processing Order' column in ascending order by default
	When User moves 'Secont_Action' item from 'Action' column to the '4' position
	Then Content in the 'Action' column is equal to
	| Content         |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	| Secont_Action   |
	When User moves 'Secont_Action' item from 'Action' column to the '1' position
	Then Content in the 'Action' column is equal to
	| Content         |
	| Secont_Action   |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	When User moves 'Secont_Action' item from 'Action' column to the '20' position
	Then Content in the 'Action' column is equal to
	| Content         |
	| Third_Action    |
	| DAS15427_Action |
	| First_Action    |
	| Secont_Action   |
	When User opens 'Action' column settings
	When User clicks Column button on the Column Settings panel
	And User select "Processing Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in table is sorted by 'Processing Order' column in ascending order by default

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15428 @DAS15938 @DAS17186 @DAS17057 @DAS17253 @DAS17625 @DAS17625 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name                     | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_DAS15938 | 15DAS15938  | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Action 1
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	Then following Values are displayed in the 'Action Type' dropdown:
	| Values               |
	| Update bucket        |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User enters '15428_Action_1' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	And User clicks 'CREATE' button 
	#Action 2
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	When User enters '15428_Action_2' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	Then 'Undetermined' content is displayed in 'Path' textbox
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	#Action 3
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	When User enters '15428_Action_3' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	Then 'Undetermined' content is displayed in 'Path' textbox
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	#Action 4
	When User clicks 'CREATE ACTION' button 
	When User enters '15428_Action_3' text to 'Action Name' textbox
	Then 'An action with this name already exists for this automation' error message is displayed for 'Action Name' field
	When User clicks 'CANCEL' button 
	When User moves '15428_Action_1' item from 'Action' column to the '3' position
	When User opens 'Action' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Processing Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in table is sorted by 'Processing Order' column in ascending order by default
	Then Content in the 'Action' column is equal to
	| Content        |
	| 15428_Action_2 |
	| 15428_Action_3 |
	| 15428_Action_1 |
	When User clicks on 'Task or Field' column header
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15938 @DAS17076 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckParametersToCreateUpdatePathAction
#Pre-requisites:
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "City" filter where type is "Equals" with added column and "Melbourne" Lookup option
	When User create dynamic list with "Melbourne Users" name on "Users" page
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'Melbourne User Migration' text to 'Project Name' textbox
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks 'Projects' on the left-hand menu
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
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	Then 'Create Automation' page subheader is displayed to user
	When User enters '' text to 'Automation Name' textbox
	When User enters '' text to 'Description' textbox
	Then 'An automation name must be entered' error message is displayed for 'Automation Name' field
	When User enters 'Melbourne User' text to 'Automation Name' textbox
	When User enters 'Melbourne users' text to 'Description' textbox
	When User selects 'Melbourne Users' option from 'Scope' autocomplete
	When User checks 'Stop on failed action' checkbox
	Then 'CREATE' button is disabled
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks 'CREATE' button 
	Then Create Action page is displayed to the User
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CREATE' button is disabled
	Then 'SAVE & CREATE ANOTHER' button has tooltip with 'Some values are missing or not valid' text
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'CANCEL' button is not disabled
	When User enters '' text to 'Action Name' textbox
	Then 'An action name must be entered' error message is displayed for 'Action Name' field
	When User enters 'Melbourne users' text to 'Action Name' textbox
	Then 'CREATE' button is disabled
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'CANCEL' button is not disabled
	When User selects 'Update path' in the 'Action Type' dropdown
	Then 'CREATE' button is disabled
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'CANCEL' button is not disabled
	When User selects 'Melbourne User Migration' option from 'Project' autocomplete
	Then 'CREATE' button is disabled
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'CANCEL' button is not disabled
	When User selects 'User Migration' option from 'Path' autocomplete
	Then 'SAVE & CREATE ANOTHER' button is not disabled
	Then 'CANCEL' button is not disabled
	When User clicks 'CREATE' button 
	Then 'The automation action has been created' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15425 @DAS16143 @DAS17336 @DAS17367 @DAS17802 @DAS19228 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditActionPage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 15425_Automation | 15425       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '15425_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User selects '[Default (User)]' option from 'Path' autocomplete
	And User clicks 'CREATE' button
	#Create Action
	When User clicks 'Automations' header breadcrumb
	Then There are no errors in the browser console
	When User enters "15425_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User navigates to the 'Actions' left menu item
	When User enters "15425_Action" text in the Search field for "Action" column
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	#Actions content check
	Then "15425_Action" content is displayed in "Action Name" field
	Then 'Update path' content is displayed in 'Action Type' dropdown
	Then 'User Evergreen Capacity Project' content is displayed in 'Project' autocomplete
	Then '[Default (User)]' content is displayed in 'Path' autocomplete
	Then 'UPDATE' button is disabled
	Then 'CANCEL' button is not disabled
	When User enters '' text to 'Action Name' textbox
	Then 'An action name must be entered' error message is displayed for 'Action Name' field
	Then 'UPDATE' button is disabled
	When User enters '15425_Action' text to 'Action Name' textbox
	Then 'UPDATE' button is disabled
	When User enters 'TEST NEW' text to 'Action Name' textbox
	Then 'UPDATE' button is not disabled
	When User selects 'Email Migration' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	Then '' content is displayed in 'Path' autocomplete
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User clicks 'CANCEL' button 
	Then '[Default (User)]' content is displayed in the 'Value' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS16992 @DAS17427 @DAS17625 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForCreateActions
	#Pre-requisites:
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Edinburgh" Lookup option
	And User create dynamic list with "Edinburgh Devices" name on "Devices" page
	And User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'Test17427_Project' text to 'Project Name' textbox
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Test17427_Project" Project
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
	When User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Device Task 1 | DAS16992 | Pre-Migration    | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	When User clicks "Create Task" button
	When User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Device Task 3 | DAS16992 | Pre-Migration    | Group          | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Device Task 2 | DAS16992 | Pre-Migration    | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Device Task 4 | DAS16992 | Pre-Migration    | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Pre-requisites:
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	Then 'Create Automation' page subheader is displayed to user
	When User enters 'DAS16992_Edinburgh_Automation' text to 'Automation Name' textbox
	When User enters 'Task value change' text to 'Description' textbox
	When User selects 'Edinburgh Devices' option from 'Scope' autocomplete
	When User selects 'Manual' in the 'Run' dropdown
	When User checks 'Active' checkbox
	#Create Action
	And User clicks 'CREATE' button 
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'SAVE & CREATE ANOTHER' button has tooltip with 'Some values are missing or not valid' text
	When User enters 'DAS16992_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Test17427_Project' option from 'Project' autocomplete
	When User selects 'Pre-Migration \ Device Task 1' option from 'Task' autocomplete
	When User selects 'Remove' in the 'Update Date' dropdown
	Then 'CREATE' button is not disabled
	When User clicks 'SAVE & CREATE ANOTHER' button
	Then Create Action page is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS16992 @DAS17234 @DAS17625 @DAS19117 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdatingTaskWhichImpactsReadinessOwnerAndDueDate
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Edinburgh" Lookup option
	And User create dynamic list with "EdinburghDevices_17234" name on "Devices" page
	When Project created via API and opened
	| ProjectName       | Scope                  | ProjectTemplate | Mode               |
	| Test16992_Project | EdinburghDevices_17234 | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Test16992_Project" Project
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
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	When User enters '17234_Edinburgh_Automation' text to 'Automation Name' textbox
	When User enters 'Task value change' text to 'Description' textbox
	When User selects 'EdinburghDevices_17234' option from 'Scope' autocomplete
	When User selects 'Manual' in the 'Run' dropdown
	When User checks 'Active' checkbox
	And User clicks 'CREATE' button 
	#Create Action
	When User enters '17234_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Test16992_Project' option from 'Project' autocomplete
	When User selects 'Pre-Migration \ Devices Task 1' option from 'Task' autocomplete
	Then inline error banner is not displayed
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options        |
	| No change      |
	| Not Applicable |
	| Not Started    |
	| Started        |
	| Failed         |
	| Complete       |
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                                   |
	| No change                                 |
	| Update                                    |
	| Update relative to current value          |
	| Update relative to now                    |
	| Update relative to a different task value |
	| Remove                                    |
	Then following Values are displayed in the 'Update Owner' dropdown:
	| Options               |
	| No change             |
	| Update                |
	| Remove owner          |
	| Remove owner and team |
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17544 @DAS19317 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckListOfProjectsOnTheCreateActionsPage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button
	Then Page with 'Automations' header is displayed to user
	When User enters '<AutomationName>' text to 'Automation Name' textbox
	When User enters '17544' text to 'Description' textbox
	When User selects '<Scope>' option from 'Scope' autocomplete
	Then 'List validated' success message for 'Scope' field
	When User selects 'Manual' in the 'Run' dropdown
	When User checks 'Active' checkbox
	And User clicks 'CREATE' button 
	#Create Action
	When User enters '<ActionName>' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '<Project1>' option from 'Project' autocomplete
	When User selects '<Project2>' option from 'Project' autocomplete
	When User selects '<Project3>' option from 'Project' autocomplete

Examples:
	| AutomationName     | Scope            | ActionName    | Project1                 | Project2                           | Project3                           |
	| 17544_Automation   | All Devices      | 17544_Action1 | User Scheduled Test (Jo) | 2004 Rollout                       | Barry's User Project               |
	| 17544_Automation_1 | All Users        | 17544_Action2 | User Scheduled Test (Jo) | 2004 Rollout                       | Email Migration                    |
	| 17544_Automation_2 | All Applications | 17544_Action3 | User Scheduled Test (Jo) | 2004 Rollout                       | Email Migration                    |
	| 17544_Automation-3 | All Mailboxes    | 17544_Action4 | Email Migration          | Mailbox Evergreen Capacity Project | USE ME FOR AUTOMATION(MAIL SCHDLD) |

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17542 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateTaskValueIsDisplayInAutomationsLog
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	When User enters 'Test_Automation_17542' text to 'Automation Name' textbox
	When User enters 'DAS17542' text to 'Description' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User checks 'Active' checkbox
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	Then Create Action page is displayed to the User
	When User enters 'DAS17542_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	When User selects 'Stage A \ Workflow task' option from 'Task' autocomplete
	And User selects 'Started' in the 'Value' dropdown
	When User clicks 'CREATE' button 
	Then "Stage A \ Workflow task" content is displayed for "Task or Field" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17602 @DAS17604 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditPageLoadingForUpdateTextValue
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17602_Automation | 17602       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17602_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Text Computer' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	When User enters 'To be updated' text to 'Value' textbox
	And User clicks 'CREATE' button
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17602_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Update task value' in the 'Action Type' dropdown
	#Actions content check
	Then "17602_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'One \ Text Computer' content is displayed in 'Task' textbox
	Then 'Update' value is displayed in the 'Update Value' dropdown
	Then 'To be updated' content is displayed in 'Value' textbox

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17602 @DAS17605 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditPageLoadingForRemoveTextValue
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17605_Automation | 17605       | true     | false              | All Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17605_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action with
	When User clicks 'CREATE ACTION' button 
	When User enters '17605_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Text Computer' option from 'Task' autocomplete
	When User selects 'Remove' in the 'Update Value' dropdown
	And User clicks 'CREATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "17605_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Update task value' in the 'Action Type' dropdown
	#Actions content check
	Then "17605_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Project' autocomplete
	Then 'One \ Text Computer' content is displayed in 'Task' autocomplete
	Then 'Remove' value is displayed in the 'Update Value' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17602 @DAS17606 @DAS19117 @DAS20455 @DAS20455 @DAS20721 @DAS20720 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditPageLoadingForUpdateDate
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17606_Automation | 17606       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action with
	When User clicks 'CREATE ACTION' button 
	When User enters '17606_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Date Computer' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '5 Aug 2019' text to 'Date' datepicker
	When User clicks 'CREATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "17606_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Update task value' in the 'Action Type' dropdown
	#Actions content check
	Then 'UPDATE' button is disabled
	Then "17606_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Project' autocomplete
	Then 'One \ Date Computer' content is displayed in 'Task' autocomplete
	Then 'Update' value is displayed in the 'Update Date' dropdown
	Then "5 Aug 2019" content is displayed in "Date" field
	#Update Action
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	When User selects 'One \ Radio Rag Date Comp' option from 'Relative Task' autocomplete
	When User enters '2' text to 'Value' textbox
	When User selects 'days after task value' in the 'DateUnit' dropdown
	When User clicks 'UPDATE' button
	Then 'The automation action has been updated' text is displayed on inline success banner
	When User clicks content from "Action" column
	Then 'UPDATE' button is disabled
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Relative Project' autocomplete
	Then 'One \ Radio Rag Date Comp' content is displayed in 'Relative Task' autocomplete
	Then 'days after task value' value is displayed in the 'DateUnit' dropdown
	Then '2' content is displayed in 'Value' textbox
	#Update Action
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '5 Aug 2019' text to 'Date' datepicker
	When User clicks 'UPDATE' button
	Then 'The automation action has been updated' text is displayed on inline success banner
	When User clicks content from "Action" column
	Then 'UPDATE' button is disabled
	Then 'Update' value is displayed in the 'Update Date' dropdown
	Then "5 Aug 2019" content is displayed in "Date" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17797 @DAS17816 @DAS19117 @DAS17485 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThanActionFieldsAreNotPrepopulatedWithOldData
	When User creates new Automation via API and open it
	| Name     | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| DAS17797 | 17797       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Action
	When User clicks 'CREATE ACTION' button 
	When User enters 'DAS17797_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Rag Date Owner' option from 'Task' autocomplete
	Then inline error banner is not displayed
	When User selects 'Complete' in the 'Update Value' dropdown
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '31 Aug 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '2004 Team' option from 'Team' autocomplete
	When User selects 'Unassigned' option from 'Owner' autocomplete
	When User clicks 'CREATE' button 
	#Test
	When User enters "DAS17797_Action" text in the Search field for "Action" column
	And User clicks content from "Action" column
	#DAS-17816 =>
	Then 'UPDATE' button is disabled
	Then 'CANCEL' button is not disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#DAS-17816 <=
	When User selects 'One \ Radio Rag only Comp' option from 'Task' autocomplete
	When User clicks Body container
	When User selects 'One \ Radio Rag Date Owner' option from 'Task' autocomplete
	Then 'No change' content is displayed in 'Update Value' dropdown
	Then 'No change' content is displayed in 'Update Date' dropdown
	Then 'No change' content is displayed in 'Update Owner' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17744 @DAS17485 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckValueDataInTheGridForActions
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values     |
	| BVX3396756 |
	When User clicks the Actions button
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "ListDAS17485" name
	When User refreshes agGrid
	Then "ListDAS17485" list is displayed to user
	When User creates new Automation via API and open it
	| Name     | Description | IsActive | StopOnFailedAction | Scope        | Run    |
	| DAS17744 | 17744       | true     | false              | ListDAS17485 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Action
	And User clicks 'CREATE ACTION' button 
	And User enters 'DAS17744_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'One \ Radio Rag Date Owner User Req A' option from 'Task' autocomplete
	When User selects 'Started' in the 'Update Value' dropdown
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '4 Sep 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '2004 Team' option from 'Team' autocomplete
	When User selects 'Unassigned' option from 'Owner' autocomplete
	When User clicks datepicker icon
	When User selects '5' day in the Datepicker
	And User clicks 'CREATE' button
	Then 'Started, 2019-09-05, 2004 Team' content is displayed in the 'Value' column
	When User clicks 'Automations' header breadcrumb
	#Run Automations
	When User enters "DAS17744" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'DAS17744' item from 'Automation' column
	When 'DAS17744' automation 'DAS17744_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User refreshes agGrid
	When User enters "DAS17744" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	When User removes "Username" column by Column panel
	When User removes "Display Name" column by Column panel
	When User clicks the Columns button
	Then 'Unassigned' content is displayed in the 'ComputerSc: One \ Radio Rag Date Owner User Req A (Owner)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17772 @DAS17948 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatActionTaskSelectboxIsDisplayedForSpecificData
	When User creates new Automation via API and open it
	| Name     | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| DAS17772 | 17772       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Action
	And User clicks 'CREATE ACTION' button
	And User enters 'DAS17772_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	Then 'Task' autocomplete does NOT have options
	| Options         |
	| Read only tasks |
	When User clicks 'Users' on the left-hand menu
	When User clicks 'YES' button on popup
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	| 00A5B910A1004CF5AC4 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	Then 'Task' autocomplete does NOT have options
	| Options         |
	| Read only tasks |

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17778 @Do_Not_Run_With_Capacity @Cleanup 
Scenario: EvergreenJnr_AdminPage_CheckCapacitySlotDataForActions
	When User creates new Automation via API and open it
	| Name    | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| DA17778 | 17778       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Action 1
	When User clicks 'CREATE ACTION' button 
	When User enters '17778 None' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Devices Evergreen Capacity Project' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Scheduled Date' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '15 Aug 2019' text to 'Date' datepicker
	When User selects 'None' in the 'Capacity Slot' dropdown
	When User clicks 'CREATE' button 
	#Action 2
	And User clicks 'CREATE ACTION' button 
	And User enters '17778 Slot' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'Devices Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Stage 1 \ Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '2 Jun 2019' text to 'Date' datepicker
	And User selects 'Scheduled Slot' in the 'Capacity Slot' dropdown
	And User clicks 'CREATE' button 
	#Test
	When User enters "17778 None" text in the Search field for "Action" column
	And User clicks content from "Action" column
	Then 'None' content is displayed in 'Capacity Slot' dropdown
	When User navigates to the 'Details' left menu item
	And User navigates to the 'Actions' left menu item
	When User enters "17778 Slot" text in the Search field for "Action" column
	And User clicks content from "Action" column
	Then 'Scheduled Slot' content is displayed in 'Capacity Slot' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS18886 @DAS20667 @Yellow_Dwarf
Scenario: EvergreenJnr_AdminPage_CheckUpdateButtonStateOnEditActionPage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "Users_Scope" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then "" content is displayed for "Update Type" column
	Then grid headers are displayed in the following order
	| ColumnName           |
	| Action               |
	|                      |
	| Type                 |
	| Project or Evergreen |
	| Task or Field        |
	| Update Type          |
	| Value                |
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17588
Scenario: EvergreenJnr_ApplicationsList_CheckAutomationsCategoryOrder
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	Then Category Automations displayed before projects categories

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS19066 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckValidationForActionName
	When User creates new Automation via API and open it
	| Name     | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| DAS19066 | 19066       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters ' ' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	Then 'An action name must be entered' error message is displayed for 'Action Name' field
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @Actions @DAS21094 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AdminPage_CheckActionNameValidationAfterClickingSaveAndCreateAnother
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name                  | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_21094 | 21094       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Action 1
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	When User enters '21094_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	#Action 2
	When User clicks 'SAVE & CREATE ANOTHER' button 
	Then 'The automation action has been created' text is displayed on inline success banner
	When User enters '21094_Action' text to 'Action Name' textbox
	Then 'An action with this name already exists for this automation' error message is displayed for 'Action Name' field