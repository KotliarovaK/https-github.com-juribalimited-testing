Feature: UpdateTaskValueAutomations3
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17481 @DAS18871 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckValidationForTaskThatHasOwner
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17481_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17481_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17481_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17481_Task | 17481 | 17481_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17481_Automation | 17481       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17481_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17481_Project' option from 'Project' autocomplete
	When User selects '17481_Stage \ 17481_Task' option from 'Task' autocomplete
	When User selects 'Not Started' in the 'Update Value' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17481_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "17481_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17481_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on inline error banner

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17481 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckValidationForTaskThatHasDueDate
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17482_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17482_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17482_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17482_Task | 17481 | 17482_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17482_Automation | 17481       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17481_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17482_Project' option from 'Project' autocomplete
	When User selects '17482_Stage \ 17482_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Not Started' in the 'Value' dropdown
	When User selects 'No change' in the 'Update Date' dropdown
	Then inline error banner is displayed
	When User clicks 'CREATE' button
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17482_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "17482_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17482_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Warning message check
	Then 'This action has parameters which are not shown and no longer applicable to the task type, update the action to remove these' text is displayed on inline error banner

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17481 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckValidationForTaskThatHasNotDueDate
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17483_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17483_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17483_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17483_Task | 17481 | 17483_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false           | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17482_Automation | 17481       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17481_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17483_Project' option from 'Project' autocomplete
	When User selects '17483_Stage \ 17483_Task' option from 'Task' autocomplete
	When User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'CREATE' button
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17483_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "17483_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17482_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Warning message check
	Then 'This action has parameters which are now available for the task type, update the action to add these' text is displayed on inline error banner

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17481 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckValidationForTaskThatHasNotOwner
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17484_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17484_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17484_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17484_Task | 17481 | 17484_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17484_Automation | 17481       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17481_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17484_Project' option from 'Project' autocomplete
	When User selects '17484_Stage \ 17484_Task' option from 'Task' autocomplete
	When User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'CREATE' button
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17484_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "17484_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17484_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Warning message check
	Then 'This action has parameters which are now available for the task type, update the action to add these' text is displayed on inline error banner
