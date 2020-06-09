Feature: CreateActionsPart2
	Create Actions functionality tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17615 @DAS17617 @DAS19117 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatEditActionsPageWithUpdateOwnerIsLoadedCorrectly
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17617_Automation | 17617       | true     | false              | All Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17617_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters 'Update Migrated devices' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Rag Date Owner Comp Req B' option from 'Task' autocomplete
	Then inline error banner is not displayed
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '2004 Team' option from 'Team' autocomplete
	When User selects 'Akhila Varghese' option from 'Owner' autocomplete
	When User clicks 'CREATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "17617_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Actions content check
	Then "Update Migrated devices" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'One \ Radio Rag Date Owner Comp Req B' content is displayed in 'Task' textbox
	Then 'No change' value is displayed in the 'Update Value' dropdown
	Then 'No change' value is displayed in the 'Update Date' dropdown
	Then 'Update' value is displayed in the 'Update Owner' dropdown
	Then "2004 Team" content is displayed in "Team" field
	Then "Akhila Varghese" content is displayed in "Owner" field

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18432 @DAS18739 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatTheFieldIsBlankAfterChangingProject
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| 18432Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "18432Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 18432_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 18432_Task | 18432 | 18432_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18432_Automation | 18432       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18432_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '18432Project' option from 'Project' autocomplete
	When User selects '18432_Stage \ 18432_Task' option from 'Task' autocomplete
	When User selects 'Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User navigates to the 'Projects' left menu item
	And User enters "18432Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User navigates to the 'Automations' left menu item
	When User enters "18432_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#DAS18491
	Then "[Project not found]" content is displayed for "Project" column
	#DAS18491
	When User clicks content from "Action" column
	#Actions content check
	Then inline error banner is not displayed
	Then '18432_Action' content is displayed in 'Action Name' textbox
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then '[Project not found]' content is displayed in 'Project' textbox
	When User selects '2004 Rollout' option from 'Project' autocomplete
	Then '' content is displayed in 'Task' textbox

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS18484 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonIsInactiveWhileChangingActionType
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18484_Automation | 18484       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18484_Action' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	When User clicks 'CREATE' button 
	When User clicks content from "Action" column
	Then 'UPDATE' button is disabled
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User clicks 'UPDATE' button 
	When User clicks content from "Action" column
	Then 'UPDATE' button is disabled
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User clicks 'UPDATE' button
	When User clicks content from "Action" column
	Then 'UPDATE' button is disabled 