Feature: AutomationsLogPart5
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17974 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAutomationDAS17974
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope                             | Run    |
	| 17974_Automation | 17974       | true     | false              | Users Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '17974_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3 \ DDL Slot Task' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Remove' in the 'Update Date' dropdown
	And User clicks 'CREATE' button
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17974_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17974_Automation' item from 'Automation' column
	When '17974_Automation' automation '17974_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17974_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                 |
	| zUserAutom: Stage 3 \ DDL Slot Task        |
	| zUserAutom: Stage 3 \ DDL Slot Task (Date) |
	| zUserAutom: Stage 3 \ DDL Slot Task (Slot) |
	Then 'STARTED' content is displayed in the 'zUserAutom: Stage 3 \ DDL Slot Task' column
	Then '' content is displayed in the 'zUserAutom: Stage 3 \ DDL Slot Task (Date)' column
	Then '' content is displayed in the 'zUserAutom: Stage 3 \ DDL Slot Task (Slot)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17829 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomation
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope                               | Run    |
	| 17829_Automation | 17829       | true     | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '17829_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3 \ Radio Date Owner' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Remove owner' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17829_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17829_Automation' item from 'Automation' column
	When '17829_Automation' automation '17829_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "17829_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                     |
	| zMailboxAu: Stage 3 \ Radio Date Owner         |
	| zMailboxAu: Stage 3 \ Radio Date Owner (Date)  |
	| zMailboxAu: Stage 3 \ Radio Date Owner (Owner) |
	| zMailboxAu: Stage 3 \ Radio Date Owner (Team)  |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Email Address" column by Column panel
	When User removes "Mailbox Platform" column by Column panel
	When User clicks the Columns button
	Then 'NOT STARTED' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Owner' column
	Then '7 Sep 2019' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Owner (Date)' column
	Then 'Unassigned' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Owner (Owner)' column
	Then 'Admin IT' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Owner (Team)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS18207 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionValueIDInTheAutomationLog
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "Applications_Scope" text in the Search field for "Automation" column
	When User selects all rows on the grid
	And User selects 'Run now' in the 'Actions' dropdown
	When User clicks 'RUN' button
	When User clicks 'RUN' button on inline tip banner
	When 'Applications_Scope' automation run has finished
	When 'Applications_Scope' automation 'Action_3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User opens 'Type' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Action Value ID" checkbox on the Column Settings panel
	When User enters "527" text in the Search field for "Action Value ID" column
	Then "Action_3" content is displayed for "Action" column
	When User enters "562" text in the Search field for "Action Value ID" column
	Then "Action_2" content is displayed for "Action" column
	When User enters "498" text in the Search field for "Action Value ID" column
	Then "Action_1" content is displayed for "Action" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS18265 @DAS17786 @DAS18287 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckArchivedObjectNumbersFromAnutomationLogGrid
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope        | Run    |
	| 18265_Automation | 18265       | true     | false              | 2004 Rollout | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18265_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters '0' text to 'Find Value' textbox
	When User enters '1' text to 'Replace Value' textbox
	When User clicks 'CREATE' button
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "18265_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18265_Automation' item from 'Automation' column
	When '18265_Automation' automation '18265_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User opens 'Type' column settings
	When User clicks Column button on the Column Settings panel
	When User select "Operation ID" checkbox on the Column Settings panel
	When User select "Scope" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
	Then content is present in the following newly added columns:
	| ColumnName   |
	| Operation ID |
	When User enters "18265_Automation" text in the Search field for "Automation" column
	When User clicks content from "Scope" column
	Then '2004 Rollout' list should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20065 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckFoundObjectsForRenamedAutomation
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User refreshes agGrid
	When User create dynamic list with "20065_List" name on "Devices" page
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope      | Run    |
	| 20065_Automation | 20065       | true     | false              | 20065_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '20065_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'TestBulkUpdate' option from 'Path' autocomplete
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "20065_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20065_Automation' item from 'Automation' column
	When '20065_Automation' automation '20065_Action' action run has finished
	#Rename Automation
	When User refreshes agGrid
	When User enters "20065_Automation" text in the Search field for "Automation" column
	When User clicks 'Edit' option in Cog-menu for '20065_Automation' item from 'Automation' column
	Then Automation page is displayed correctly
	When User enters 'New_Test_Automation' text to 'Automation Name' textbox
	When User clicks 'UPDATE' button
	#Run Automation
	When User enters "New_Test_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'New_Test_Automation' item from 'Automation' column
	When 'New_Test_Automation' automation '20065_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "20065_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	When User clicks content from "Objects" column
	Then "TestBulkUpdate" content is displayed for "zDeviceAut: Path" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDateAndTimeInAutomationLogGrid
	When User creates new Automation via API
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 36412_Automation | 36412       | true     | false              | All Users | Manual |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "36412_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '36412_Automation' item from 'Automation' column
	When '36412_Automation' automation run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "36412_Automation" text in the Search field for "Automation" column
	Then current date and time are displayed for '36412_Automation' automation