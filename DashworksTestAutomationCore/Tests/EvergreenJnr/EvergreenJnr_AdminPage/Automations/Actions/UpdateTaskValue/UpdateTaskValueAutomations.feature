Feature: UpdateTaskValueAutomations
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17429 @DAS17275 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueAutomationValidationsForDeletedProject
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| 17429Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17429Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17429_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17429_Task | 17429 | 17429_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17429_Automation | 16890       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17429_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17429Project' option from 'Project' autocomplete
	When User selects '17429_Stage \ 17429_Task' option from 'Task' autocomplete
	When User selects 'Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User navigates to the 'Projects' left menu item
	And User enters "17429Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User navigates to the 'Automations' left menu item
	When User enters "17429_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Actions content check
	Then '17429_Action' content is displayed in 'Action Name' textbox
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then '[Project not found]' content is displayed in 'Project' textbox
	#Waiting for _ngcontent on the automaster
	#Then 'The selected project cannot be found' error message is displayed for 'Project' field

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17429 @DAS18739 @DAS19228 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueAutomationValidationsForDeletedStage
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17429Project1 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17429Project1" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName    |
	| 17429_Stage1 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name        | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17429_Task1 | 17429 | 17429_Stage1     | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17429_Automation1 | 16890       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17429_Action1' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17429Project1' option from 'Project' autocomplete
	When User selects '17429_Stage1 \ 17429_Task1' option from 'Task' autocomplete
	When User selects 'Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Delete Stage
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17429Project1" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User removes created Stage
	Then selected Stage was removed
	And Success message is displayed with "Stage successfully deleted." text
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17429_Automation1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Actions content check
	Then "17429_Action1" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then '17429Project1' content is displayed in 'Project' textbox
	Then '[Stage not found]' content is displayed in 'Stage' textbox
	Then 'The selected stage cannot be found' error message is displayed for 'Stage' field

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17429 @DAS18491 @DAS18739 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueAutomationValidationsForDeletedTask
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17429Project2 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17429Project2" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName    |
	| 17429_Stage2 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name        | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17429_Task2 | 17429 | 17429_Stage2     | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17429_Automation2 | 16890       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17429_Action2' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17429Project2' option from 'Project' autocomplete
	When User selects '17429_Stage2' option from 'Stage' autocomplete
	Then inline error banner is displayed
	When User selects '17429_Task2' option from 'Task' autocomplete
	When User selects 'Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Delete Stage
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17429Project2" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User removes "17429_Task2" Task
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17429_Automation2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#DAS18491
	Then "[Task not found]" content is displayed for "Task or Field" column
	#DAS18491
	When User clicks content from "Action" column
	#Actions content check
	Then inline error banner is displayed
	Then "17429_Action2" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then '17429Project2' content is displayed in 'Project' textbox
	Then '17429_Stage2' content is displayed in 'Stage' textbox
	Then '[Task not found]' content is displayed in 'Task' textbox
	Then 'The selected task cannot be found' error message is displayed for 'Task' field
	Then inline error banner is not displayed