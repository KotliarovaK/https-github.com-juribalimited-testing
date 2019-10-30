Feature: UpdateTaskValueAutomations4
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17564 @Cleanup @Not_Ready
#Waiting for new banner message on the Create Actions page
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueCapacitySlotValidationsForDevicesAutomation
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 17564_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User clicks "Enable Capacity" checkbox on the Project details page
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
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17564_Automation | 17564       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17564_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '17564_Project' option from 'Project' autocomplete
	When User selects '17564_Stage' option from 'Stage' autocomplete
	When User selects '17564_Task' option from 'Task' autocomplete
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
	When User selects "17564_Stage \ 17564_Task" checkbox in the "Tasks" field on the Project details page
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
	#Then Error message with "This action has parameters which are not shown and no longer applicable to the task type, update the action to remove these" text is displayed
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17564_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17564_Automation" item on Admin page
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17564_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "SLOT NOT ASSOCIATED TO THE TASK" content is displayed for "Outcome" column