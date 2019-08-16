Feature: CreateAction
	Create Actions functionality tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17511 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonForActionsWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName        | Description | Active | StopOnFailedAction | Scope       | Run    |
	| Test_Automation_17511 | 17511       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Test_Automation_15427" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User type "15427_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "USE ME FOR AUTOMATION(DEVICE SCHDLD)" in the Project dropdown
	When User selects "[Default (Computer)]" in the "Path" dropdown for Actions
	When User clicks the "CREATE" Action button
	When User selects "Details" tab on the Project details page
	When User selects "Actions" tab on the Project details page
	When User clicks content from "Action" column
	When User type "15427_NewName" Name in the "Action Name" field on the Automation details page
	When User selects "USE ME FOR AUTOMATION(DEVICE SCHDLD)" in the Project dropdown
	When User selects "[Default (Computer)]" in the "Path" dropdown for Actions
	And User clicks the "UPDATE" Action button
	When User clicks content from "Action" column
	Then "15427_NewName" content is displayed in "Action Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17428 @DAS17600 @Not_Ready
Scenario Outline: EvergreenJnr_AdminPage_CheckUpdateTaskValueEditPageLoadsProjectStageTask
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "<AutomationName>" Name in the "Automation Name" field on the Automation details page
	When User type "DAS17428" Name in the "Description" field on the Automation details page
	When User selects "<Scope>" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects "Manual" in the "Run" dropdown
	When User clicks the "CREATE" Action button
	When User type "Update Migrated devices to Started" Name in the "Action Name" field on the Automation details page
	When User selects "Update task value" in the "Action Type" dropdown
	When User selects "<Project>" in the Project dropdown
	When User selects "<Stage>" in the "Stage" dropdown for Actions
	When User selects "<Task>" in the "Task" dropdown for Actions
	Then "CREATE" Action button is disabled
	When User selects "Started" Value on Action panel
	When User clicks the "CREATE" Action button
	When User clicks content from "Action" column
	Then "Update Migrated devices to Started" content is displayed in "Action Name" field
	Then "Update task value" text value is displayed in the "Action Type" dropdown
	Then "<Project>" value is displayed in the "Project" dropdown for Automation
	Then "<Stage>" value is displayed in the "Stage" dropdown for Automation
	Then "<Task>" value is displayed in the "Task" dropdown for Automation
	#Remove # after Value dropdown fixed
	#Then "Started" text value is displayed in the "Value" dropdown

Examples:
	| AutomationName                | Scope            | Project                              | Stage   | Task                   |
	| 17428_Automation_Devices      | All Devices      | USE ME FOR AUTOMATION(DEVICE SCHDLD) | Stage A | Workflow task          |
	| 17428_Automation_Users        | All Users        | USE ME FOR AUTOMATION(USR SCHDLD)    | Stage 1 | Test A                 |
	| 17428_Automation_Applications | All Applications | User Scheduled Test (Jo)             | One     | Radio Rag only Rag App |
	| 17428_Automation_Mailboxes    | All Mailboxes    | USE ME FOR AUTOMATION(MAIL SCHDLD)   | Stage 1 | Test A                 |

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17691 @DAS17625 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatStageWithoutCorrectTasksIsNotDisplayedForActions
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS17691_Project | All Users | None            | Standalone Project |
	When User clicks "Projects" on the left-hand menu
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
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17691_Automation | DAS17691    | true   | false              | All Users | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17691_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	And User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User type "17691_Action" Name in the "Action Name" field on the Automation details page
	And User selects "Update task value" in the "Action Type" dropdown
	And User selects "DAS17691_Project" in the Project dropdown
	Then "Stage" dropdown is not displayed on the Admin Settings screen

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17738 @DAS17625 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDateForUpdateTaskValueAction
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17738_Automation | 17430       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17738_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	Then "All Devices" content is displayed in the Scope Automation dropdown
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User type "17738_Action" Name in the "Action Name" field on the Automation details page
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects "Computer Scheduled Test (Jo)" in the Project dropdown
	When User selects "One" in the "Stage" dropdown for Actions
	When User selects "Radio Rag Date Comp" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Failed" Value on Action panel
	And User selects "No change" Update Date on Action panel
	Then "CREATE" Action button is active
	When User selects "No change" value for "Update" dropdown on Action panel
	Then "CREATE" Action button is disabled
	When User selects "Update" value for "No change" dropdown on Action panel
	And User selects "Failed" Value on Action panel
	Then "CREATE" Action button is active
	#Actions content check
	Then "Update Migrated devices" content is displayed in "Action Name" field
	Then "Update task value" text value is displayed in the "Action Type" dropdown
	Then "One" value is displayed in the "Stage" dropdown for Automation
	Then "Radio Rag Date Owner Comp Req B" value is displayed in the "Task" dropdown for Automation
	Then "No change" value is displayed in the "Update Value" dropdown
	Then "No change" value is displayed in the "Update Date" dropdown
	Then "Update" value is displayed in the "Update Owner" dropdown
	Then "1803 Team" content is displayed in "Team" field
	Then "Akhila Varghese" content is displayed in "Owner" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS17615 @DAS17619 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatEditActionsPageWithRemoveOwnerIsLoadedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17619_Automation | 17619       | true   | false              | All Users | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17619_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User type "Update Migrated devices" Name in the "Action Name" field on the Automation details page
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects "Computer Scheduled Test (Jo)" in the Project dropdown
	When User selects "One" in the "Stage" dropdown for Actions
	When User selects "Radio Rag Date Owner User Req B" in the "Task" dropdown for Actions
	And User selects "No change" Update Value on Action panel
	And User selects "No change" Update Date on Action panel
	And User selects "Remove" Update Owner on Action panel
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17619_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	When User clicks content from "Action" column
	#Actions content check
	Then "Update Migrated devices" content is displayed in "Action Name" field
	Then "Update task value" text value is displayed in the "Action Type" dropdown
	Then "One" value is displayed in the "Stage" dropdown for Automation
	Then "Radio Rag Date Owner Comp Req B" value is displayed in the "Task" dropdown for Automation
	Then "No change" value is displayed in the "Update Value" dropdown
	Then "No change" value is displayed in the "Update Date" dropdown
	Then "Remove" value is displayed in the "Update Owner" dropdown