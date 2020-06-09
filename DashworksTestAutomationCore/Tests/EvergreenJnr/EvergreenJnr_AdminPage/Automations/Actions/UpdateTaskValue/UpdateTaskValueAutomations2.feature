Feature: UpdateTaskValueAutomations2
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18292 @DAS20360 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogForUpdateTaskValueInApplicationsAutomation
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope              | Run    |
	| 18292_Automation | 18292       | true     | false              | Apps with a Vendor | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18292_Action1' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU \ DT Auto App' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'hours before current value' in the 'Units' dropdown
	And User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18292_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18292_Automation' item from 'Automation' column
	When '18292_Automation' automation '18292_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "18292_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zUserAutom: Relative BU \ DT Auto App (Date) |
	Then '9 Oct 2019 14:00' content is displayed in the 'zUserAutom: Relative BU \ DT Auto App (Date)' column
	Then "zUserAutom: Relative BU \ DT Auto App" column is not displayed to the user
		#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18292_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'hours after current value' in the 'Units' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "18292_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18292_Automation' item from 'Automation' column
	When '18292_Automation' automation '18292_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18292_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zUserAutom: Relative BU \ DT Auto App (Date) |
	Then '10 Oct 2019 00:00' content is displayed in the 'zUserAutom: Relative BU \ DT Auto App (Date)' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18292 @DAS18739 @DAS17675 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogForUpdateTaskValueInMailboxesAutomation
	When User creates new Automation via API and open it
	| Name                | Description | IsActive | StopOnFailedAction | Scope                               | Run    |
	| Test18292Automation | 18292       | true     | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18292_Action2' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU \ DT Auto Mail' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'days after current value' in the 'Units' dropdown
	And User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "Test18292Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'Test18292Automation' item from 'Automation' column
	When 'Test18292Automation' automation '18292_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "Test18292Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	Then '25 Oct 2019' content is displayed in the 'zMailboxAu: Relative BU \ DT Auto Mail' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "Test18292Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then inline error banner is not displayed
	When User selects 'days before current value' in the 'Units' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "Test18292Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'Test18292Automation' item from 'Automation' column
	When 'Test18292Automation' automation '18292_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "Test18292Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	Then '15 Oct 2019' content is displayed in the 'zMailboxAu: Relative BU \ DT Auto Mail' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18292 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogForUpdateTaskValueInDevicesAutomation
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope              | Run    |
	| 182922_Automation | 18292       | true     | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18292_Action3' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU \ DT Auto Device' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Not Started' in the 'Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "182922_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '182922_Automation' item from 'Automation' column
	When '182922_Automation' automation '18292_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "182922_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                      |
	| zDeviceAut: Relative BU \ DT Auto Device        |
	| zDeviceAut: Relative BU \ DT Auto Device (Date) |
	Then 'NOT STARTED' content is displayed in the 'zDeviceAut: Relative BU \ DT Auto Device' column
	Then '' content is displayed in the 'zDeviceAut: Relative BU \ DT Auto Device (Date)' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18543 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckTheAvailabilityOfTheUnitsfieldDependingOnTheTask
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 18543_Automation | 18543       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18543_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3 \ Date Only with Capacity User' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	Then 'Units' dropdown is disabled
	#Change task with date and time
	When User selects 'DDL Slot Task' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18619 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDropdownAfterChangingItem
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18619_Automation | 18619       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18619_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Rag Date Comp' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Remove' in the 'Update Date' dropdown
	When User clicks 'CREATE' button
	#Check Value dropdown
	When User clicks content from "Action" column
	Then 'Remove' content is displayed in 'Update Date' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS18644 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckRemoveOwnerOptionWhenTaskDoesNotHaveDate
	#Pre-requisites:
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| DAS18644_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "DAS18644_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName      |
	| DAS18644_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| DAS18644_Task | DAS18644 | DAS18644_Stage   | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Pre-requisites:
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18644_Automation | 18644       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18644_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'DAS18644_Project' option from 'Project' autocomplete
	When User selects 'DAS18644_Stage \ DAS18644_Task' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	Then following Values are displayed in the 'Update Owner' dropdown:
	| Options               |
	| No change             |
	| Update                |
	| Remove owner          |
	| Remove owner and team |