Feature: UpdateTaskValueAutomations4
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17564 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueCapacitySlotValidationsForDevicesAutomation
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17564_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User checks 'Enable capacity' checkbox
	When User clicks 'UPDATE' button
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17564_Project" Project
	Then "Manage Project Details" page is displayed to the user
	#Create Stage
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17564_Stage |
	And User clicks "Create Stage" button
	#Create Task
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17564_Task | 17481 | 17564_Stage      | Normal         | Date            | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Create Slot
	When User creates new Slot via Api
	| Project       | SlotName      | DisplayName | ObjectType | Tasks      |
	| 17564_Project | CapacitySlot1 | 17564_Slot1 | Device     | 17564_Task |
	| 17564_Project | CapacitySlot2 | 17564_Slot2 | Device     | 17564_Task |
	#Create Automation
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17564_Automation | 17564       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17564_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17564_Project' option from 'Project' autocomplete
	When User selects '17564_Stage \ 17564_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	And User selects 'CapacitySlot1' in the 'Capacity Slot' dropdown
	When User clicks 'CREATE' button
	#Update Slots
	When User clicks 'Administration' header breadcrumb
	When User enters "17564_Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Slots' left menu item
	When User clicks content from "Capacity Slot" column
	When User unchecks '17564_Stage \ 17564_Task' option after search from 'Tasks' autocomplete
	When User clicks 'UPDATE' button
	#Check Action content
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17564_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then '[Slot not associated to this task]' content is displayed in 'Capacity Slot' dropdown
	Then 'The selected slot is not associated to this task' error message is displayed for 'Capacity Slot' dropdown
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17564_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17564_Automation' item from 'Automation' column
	When '17564_Automation' automation '17564_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17564_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "SLOT NOT ASSOCIATED TO THE TASK" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17564 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueCapacitySlotValidationsForUsersAutomation
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode               |
	| 17565_Project | All Users | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User checks 'Enable capacity' checkbox
	When User clicks 'UPDATE' button
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17565_Project" Project
	Then "Manage Project Details" page is displayed to the user
	#Create Stage
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17565_Stage |
	And User clicks "Create Stage" button
	#Create Task
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17565_Task | 17481 | 17565_Stage      | Normal         | Date            | User             |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Create Slot
	When User creates new Slot via Api
	| Project       | SlotName      | DisplayName | ObjectType | Tasks      |
	| 17565_Project | CapacitySlot1 | 17565_Slot1 | User       | 17565_Task |
	| 17565_Project | CapacitySlot2 | 17565_Slot2 | User       | 17565_Task |
	#Create Automation
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17565_Automation | 17564       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17565_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17565_Project' option from 'Project' autocomplete
	When User selects '17565_Stage \ 17565_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	And User selects 'CapacitySlot1' in the 'Capacity Slot' dropdown
	When User clicks 'CREATE' button
	#Update Slots
	When User clicks 'Administration' header breadcrumb
	When User enters "17565_Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Slots' left menu item
	When User clicks 'Delete' option in Cog-menu for 'CapacitySlot1' item from 'Capacity Slot' column
	Then 'The selected slot will be deleted, do you want to proceed?' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
	#Check Action content
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17565_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '[Slot not found]' content is displayed in 'Capacity Slot' dropdown
	Then 'The selected slot cannot be found' error message is displayed for 'Capacity Slot' dropdown
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17565_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17565_Automation' item from 'Automation' column
	When '17565_Automation' automation '17565_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17565_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "SLOT DOES NOT EXIST" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17564 @Cleanup @Not_Ready
#Waiting for new banner message on the Create Actions page
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueCapacitySlotValidations
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17566_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User checks 'Enable capacity' checkbox
	When User clicks 'UPDATE' button
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17566_Project" Project
	Then "Manage Project Details" page is displayed to the user
	#Create Stage
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 17566_Stage |
	And User clicks "Create Stage" button
	#Create Task
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 17566_Task | 17481 | 17566_Stage      | Normal         | Date            | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Create Slot
	When User creates new Slot via Api
	| Project       | SlotName      | DisplayName | ObjectType | Tasks      |
	| 17566_Project | CapacitySlot1 | 17564_Slot1 | Device     | 17566_Task |
	#Create Automation
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17566_Automation | 17564       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17564_Action1' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17566_Project' option from 'Project' autocomplete
	When User selects '17566_Stage' option from 'Stage' autocomplete
	When User selects '17566_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	And User selects 'CapacitySlot1' in the 'Capacity Slot' dropdown
	When User clicks 'CREATE' button
	#Update Slots
	When User clicks 'Administration' header breadcrumb
	When User enters "17566_Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Slots' left menu item
	When User clicks content from "Capacity Slot" column
	When User unchecks '17566_Stage \ 17566_Task' option after search from 'Tasks' autocomplete
	When User clicks 'UPDATE' button
	#Check Action content
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17566_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'This action has parameters which are now available for the task type, update the action to add these' text is displayed on inline error banner
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17566_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17566_Automation' item from 'Automation' column
	When '17566_Automation' automation '17566_Project' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17566_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "SLOT NOT ASSOCIATED TO THE TASK" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18669 @DAS20038 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueValidationForUnpublishedTask
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 18669_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18669_Project" Project
	Then "Manage Project Details" page is displayed to the user
	#Create Stage
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18669_Stage |
	And User clicks "Create Stage" button
	#Create Task
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18669_Task | 18669 | 18669_Stage      | Normal         | Date            | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name        | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18669_Task2 | 18669 | 18669_Stage      | Normal         | Date            | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Create Automation
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18669_Automation | 18669       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18669_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18669_Project' option from 'Project' autocomplete
	When User selects '18669_Stage \ 18669_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	When User clicks 'CREATE' button
	#Unpublish Task
	And User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18669_Project" Project
	And User navigate to "Tasks" tab
	And User navigate to "18669_Task" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	#Check Action content
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "18669_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'This task is not published' error message is displayed for 'Task' field
	Then 'UPDATE' button is disabled
	When User selects '18669_Project' option from 'Project' autocomplete
	When User selects '18669_Stage \ 18669_Task2' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18669 @DAS20038 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueValidationForReadOnlyInAutomationsTask
	When Project created via API and opened
	| ProjectName    | Scope       | ProjectTemplate | Mode               |
	| 18669_Project1 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18669_Project1" Project
	Then "Manage Project Details" page is displayed to the user
	#Create Stage
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18669_Stage |
	And User clicks "Create Stage" button
	#Create Task
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18669_Task | 18669 | 18669_Stage      | Normal         | Date            | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name        | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18669_Task2 | 18669 | 18669_Stage      | Normal         | Date            | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Create Automation
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18669_Automation1 | 18669       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18669_Action2' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18669_Project1' option from 'Project' autocomplete
	When User selects '18669_Stage \ 18669_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	When User clicks 'CREATE' button
	#Change Task to READ ONLY
	And User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18669_Project1" Project
	And User navigate to "Tasks" tab
	And User navigate to "18669_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService | Automation |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       | true       |
	And User navigate to Evergreen link
	#Check Action content
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "18669_Automation1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'This task is read-only for automations' error message is displayed for 'Task' field
	Then 'UPDATE' button is disabled
	When User selects '18669_Project1' option from 'Project' autocomplete
	When User selects '18669_Stage \ 18669_Task2' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	And User enters '1 Oct 2019' text to 'Date' datepicker
	Then 'UPDATE' button is not disabled