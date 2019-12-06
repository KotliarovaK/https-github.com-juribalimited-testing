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
	Then Success message is displayed and contains "The automation action has been created" text
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
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on error inline tip banner
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18712 @DAS18677 @Cleanup @Not_Ready
#Waiting for updated Validation messages on the automation
Scenario: EvergreenJnr_AdminPage_CheckBannerMessageActionsGridValueDisplayAfterTaskChangingToTaskWithNoOwner
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
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
	Then Success message is displayed and contains "The automation action has been created" text
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
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on error inline tip banner
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
	Then Success message is displayed and contains "The automation action has been created" text
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
	Then 'The configuration of this task has changed, this action has parameters that are not shown and no longer valid, update the action to remove these' text is displayed on error inline tip banner
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
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18712_Automation3 | 18712       | true   | false              | All Devices | Manual |
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
	Then 'The configuration of this task has changed, this action no longer has the correct parameters, update the action to change these' text is displayed on error inline tip banner
	Then 'UPDATE' button is disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19065 @Cleanup @Not_Ready
#Waiting for DAS-19065 fixed
Scenario: EvergreenJnr_AdminPage_CheckThatProjectColumnChangedAfterUpdatingAction
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 19065_Automation  | 19065       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18705_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects 'Pre-Migration' option from 'Stage' autocomplete
	When User selects 'Device Priority' option from 'Task' autocomplete
	When User selects 'Medium' in the 'Value' dropdown
	When User clicks 'CREATE' button
	Then "1803 Rollout" content is displayed for "Project" column
	When User clicks content from "Action" column
	When User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks 'UPDATE' button
	Then "" content is displayed for "Project" column