Feature: AutomationsLogPart3
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17247 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogMessageForDeletedTaskInAction
	#Pre-requisites:
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| 17247Project | All Devices | None            | Standalone Project |
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17247Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Test      |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name          | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| DAS17247_Task | 17247 | Test             | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Pre-requisites:
	And User clicks "Admin" on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "17247_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "17247" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	#Create Action
	When User type "17247_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update task value" in the "Action Type" dropdown
	When User selects "17247Project" in the Project dropdown
	When User selects "Test" in the "Stage" dropdown for Actions
	When User selects "DAS17247_Task" in the "Task" dropdown for Actions
	When User selects "Update" Update Value on Action panel
	When User selects "Not Applicable" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "7 Aug 2019" Date on Action panel
	And User clicks the "CREATE" Action button
	#Delete Task
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "17247Project" Project
	When User navigate to "Tasks" tab
	And User removes "DAS17247_Task" Task
	#Run Automation
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	When User enters "17247_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17247_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User enters "17247_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "TASK DOES NOT EXIST" content is displayed for "Outcome" column