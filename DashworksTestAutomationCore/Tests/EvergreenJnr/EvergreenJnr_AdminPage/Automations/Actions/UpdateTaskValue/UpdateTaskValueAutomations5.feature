Feature: UpdateTaskValueAutomations5
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18712 @DAS18677 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckBannerMessageActionsGridValueDisplayAfterTaskChangingToTaskWithNoDueDate
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 18712_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18712_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18712_Task | 17481 | 18712_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18712_Automation | 18712       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18712_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18712_Project' option from 'Project' autocomplete
	When User selects '18712_Stage' option from 'Stage' autocomplete
	When User selects '18712_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Failed' in the 'Value' dropdown
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '1 Nov 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '1803 Team' option from 'Team' autocomplete
	When User selects 'Akhila Varghese' option from 'Owner' autocomplete
	When User clicks 'CREATE' button
	#Check Actions grid
	Then 'The automation action has been created' text is displayed on inline success banner
	Then "Failed, 2019-11-01, 1803 Team, Akhila Varghese" content is displayed for "Value" column
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "18712_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "18712_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Check Actions grid
	Then "Failed, 1803 Team, Akhila Varghese" content is displayed for "Value" column
	When User clicks content from "Action" column
	#Warning message check
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on inline error banner
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18712 @DAS18677 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckBannerMessageActionsGridValueDisplayAfterTaskChangingToTaskWithNoOwner
	When Project created via API and opened
	| ProjectName    | Scope       | ProjectTemplate | Mode               |
	| 18712_Project1 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project1" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18712_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18712_Task | 17481 | 18712_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18712_Automation1 | 18712       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18712_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18712_Project1' option from 'Project' autocomplete
	When User selects '18712_Stage' option from 'Stage' autocomplete
	When User selects '18712_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Failed' in the 'Value' dropdown
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '1 Nov 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '1803 Team' option from 'Team' autocomplete
	When User selects 'Akhila Varghese' option from 'Owner' autocomplete
	When User clicks 'CREATE' button
	#Check Actions grid
	Then 'The automation action has been created' text is displayed on inline success banner
	Then "Failed, 2019-11-01, 1803 Team, Akhila Varghese" content is displayed for "Value" column
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project1" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "18712_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "18712_Automation1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Check Actions grid
	Then "Failed, 2019-11-01" content is displayed for "Value" column
	When User clicks content from "Action" column
	#Warning message check
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on inline error banner
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18712 @DAS18677 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckBannerMessageActionsGridValueDisplayAfterTaskChangingToTaskWithNoOwnerAndNoDueDate
	When Project created via API and opened
	| ProjectName    | Scope       | ProjectTemplate | Mode               |
	| 18712_Project2 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project2" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18712_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18712_Task | 17481 | 18712_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18712_Automation2 | 18712       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18712_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18712_Project2' option from 'Project' autocomplete
	When User selects '18712_Stage' option from 'Stage' autocomplete
	When User selects '18712_Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Failed' in the 'Value' dropdown
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '1 Nov 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '1803 Team' option from 'Team' autocomplete
	When User selects 'Akhila Varghese' option from 'Owner' autocomplete
	When User clicks 'CREATE' button
	#Check Actions grid
	Then 'The automation action has been created' text is displayed on inline success banner
	Then "Failed, 2019-11-01, 1803 Team, Akhila Varghese" content is displayed for "Value" column
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project2" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "18712_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "18712_Automation2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Check Actions grid
	Then "Failed" content is displayed for "Value" column
	When User clicks content from "Action" column
	#Warning message check
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on inline error banner
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18712 @DAS18677 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateButtonStateAfterTaskChangingToTaskWithNoOwnerAndNoDueDate
	When Project created via API and opened
	| ProjectName    | Scope       | ProjectTemplate | Mode               |
	| 18712_Project3 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project3" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18712_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18712_Task | 17481 | 18712_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18712_Automation3 | 18712       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18712_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18712_Project3' option from 'Project' autocomplete
	When User selects '18712_Stage' option from 'Stage' autocomplete
	When User selects '18712_Task' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '1 Nov 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '1803 Team' option from 'Team' autocomplete
	When User selects 'Akhila Varghese' option from 'Owner' autocomplete
	When User clicks 'CREATE' button
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18712_Project3" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "18712_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "18712_Automation3" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Warning message check
	Then 'The configuration of this task has changed, this action no longer has the correct parameters, update the action to change these' text is displayed on inline error banner
	Then 'UPDATE' button is disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19065 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectColumnChangedAfterUpdatingAction
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 19065_Automation | 19065       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18705_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Pre-Migration \ Device Priority' option from 'Task' autocomplete
	When User selects 'Medium' in the 'Value' dropdown
	When User clicks 'CREATE' button
	Then "2004 Rollout" content is displayed for "Project" column
	When User clicks content from "Action" column
	When User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks 'UPDATE' button
	Then "" content is displayed for "Project" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18716 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckImprovementsForCapacityDisabledCase
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18716_Automation | 18716       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18705_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage C \ Date Only with Capacity' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '1 Sep 2019' text to 'Date' datepicker
	When User selects 'DAS-17846 Slot Device' in the 'Capacity Slot' dropdown
	When User clicks 'CREATE' button
	#Create Action
	When User clicks 'Administration' header breadcrumb
	When User enters "zDevice Sch for Automations Feature" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User checks 'Enable Capacity' checkbox
	When User clicks 'UPDATE' button
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18716_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#delete refresh
	When User clicks refresh button in the browser
	#delete refresh
	Then 'This action has parameters which are not shown and no longer applicable to the task type, update the action to remove these' text is displayed on inline error banner
	#Revert default Capacity position
	When User clicks 'Administration' header breadcrumb
	When User enters "zDevice Sch for Automations Feature" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User checks 'Enable Capacity' checkbox
	When User clicks 'UPDATE' button

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20013 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorMessageAppearsOnEditActionScreenIfSlotWasNotSelected
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values              |
	| 09CDC1FCD0C843E3B1C |
	When User refreshes agGrid
	When User create dynamic list with "20013_List" name on "Users" page
	When Project created via API and opened
	| ProjectName   | Scope      | ProjectTemplate | Mode               |
	| 20013_Project | 20013_List | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "20013_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 20013_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 20013_Task | 20013 | 20013_Stage      | Normal         | Date            | User             |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Slot via Api
	| Project       | SlotName   | DisplayName | CapacityType   | ObjectType | Sunday | Tasks                    |
	| 20013_Project | slot_20013 | slot_20013  | Capacity Units | User       | 0      | 20013_Stage \ 20013_Task |
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope      | Run    |
	| 20013_Automation | 20013       | true     | false              | 20013_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '20013_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '20013_Project' option from 'Project' autocomplete
	When User selects '20013_Stage \ 20013_Task' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '12' text to 'Value' textbox
	When User selects 'days before current value' in the 'Units' dropdown
	When User clicks 'CREATE' button
	When User clicks content from "Action" column
	Then inline error banner is not displayed