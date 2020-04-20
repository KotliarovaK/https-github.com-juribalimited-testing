Feature: CreateActionsPart1
	Create Actions functionality tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17511 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonForActionsWorksCorrectly
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name                  | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_17511 | 17511       | true     | false              | All Devices | Manual |
	Then 'Edit Automation' page subheader is displayed to user
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '15427_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	When User selects '[Default (Computer)]' option from 'Path' autocomplete
	When User clicks 'CREATE' button
	When User navigates to the 'Details' left menu item
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User enters '15427_NewName' text to 'Action Name' textbox
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	When User selects '[Default (Computer)]' option from 'Path' autocomplete
	And User clicks 'UPDATE' button
	When User clicks content from "Action" column
	Then "15427_NewName" content is displayed in "Action Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17428 @DAS17600 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckUpdateTaskValueEditPageLoadsProjectStageTask
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	When User enters '<AutomationName>' text to 'Automation Name' textbox
	When User enters 'DAS17428' text to 'Description' textbox
	When User selects '<Scope>' option from 'Scope' autocomplete
	When User checks 'Active' checkbox
	When User selects 'Manual' in the 'Run' dropdown
	When User clicks 'CREATE' button 
	When User enters 'Update Migrated devices to Started' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects '<Project>' option from 'Project' autocomplete
	When User selects '<Task>' option from 'Task' autocomplete
	Then 'CREATE' button is disabled
	When User selects 'Not Started' in the 'Value' dropdown
	When User clicks 'CREATE' button 
	When User clicks content from "Action" column
	Then "Update Migrated devices to Started" content is displayed in "Action Name" field
	And 'Update task value' content is displayed in 'Action Type' dropdown
	And '<Project>' content is displayed in 'Project' textbox
	And '<Task>' content is displayed in 'Task' textbox
	Then 'Not Started' content is displayed in 'Value' dropdown

Examples:
	| AutomationName                | Scope            | Project                              | Task                                                   |
	| 17428_Automation_Devices      | All Devices      | USE ME FOR AUTOMATION(DEVICE SCHDLD) | Stage A \ Workflow task                                |
	| 17428_Automation_Users        | All Users        | USE ME FOR AUTOMATION(USR SCHDLD)    | Stage 1 \ Radiobutton Readiness Date Owner Task (User) |
	| 17428_Automation_Applications | All Applications | User Scheduled Test (Jo)             | One \ Radio Rag only Rag App                           |
	| 17428_Automation_Mailboxes    | All Mailboxes    | zMailbox Sch for Automations Feature | Stage 3 \ Radio Date Owner                             |

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17691 @DAS17625 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatStageWithoutCorrectTasksIsNotDisplayedForActions
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS17691_Project | All Users | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "DAS17691_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName      |
	| Stage_DAS17691 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name        | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Normal Task | DAS17691 | Stage_DAS17691   | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	When User clicks "Create Task" button
	When User creates Task
	| Name       | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Group Task | DAS17691 | Stage_DAS17691   | Group          | Radiobutton     | User             |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17691_Automation | DAS17691    | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17691_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	Then 'DAS17691_Project' content is not displayed in 'Project' autocomplete after search

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17738 @DAS17625 @DAS19117 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDateForUpdateTaskValueAction
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17738_Automation | 17430       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	Then 'All Devices' content is displayed in 'Scope' textbox
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17738_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Rag Date Comp' option from 'Task' autocomplete
	Then inline error banner is not displayed
	When User selects 'Failed' in the 'Update Value' dropdown
	When User selects 'No change' in the 'Update Date' dropdown
	Then 'CREATE' button is not disabled
	When User selects 'No change' in the 'Update Value' dropdown
	Then 'CREATE' button is disabled
	When User selects 'Failed' in the 'Update Value' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17615 @DAS17619 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatEditActionsPageWithRemoveOwnerIsLoadedCorrectly
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17619_Automation | 17619       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters 'Update Migrated devices' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Rag Date Owner User Req B' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Remove owner' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "17619_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Actions content check
	Then "Update Migrated devices" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	And 'One \ Radio Rag Date Owner User Req B' content is displayed in 'Task' textbox
	Then 'No change' value is displayed in the 'Update Value' dropdown
	Then 'No change' value is displayed in the 'Update Date' dropdown
	Then 'Remove owner' value is displayed in the 'Update Owner' dropdown