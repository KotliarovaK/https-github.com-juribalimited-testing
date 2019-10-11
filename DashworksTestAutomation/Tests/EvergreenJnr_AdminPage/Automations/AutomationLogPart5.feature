Feature: AutomationsLogPart5
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17974 @Cleanup @Not_Ready
#Waiting for 'zUser Sch for Automations Feature' project
Scenario: EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAutomationDAS17974
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                             | Run    |
	| 17974_Automation | 17974       | true   | false              | Users Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '17974_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3' option from 'Stage' autocomplete
	When User selects 'DDL Slot Task' option from 'Task' autocomplete
	And User selects "No change" Update Value on Action panel
	And User selects 'Remove' in the 'Update Date' dropdown
	And User clicks 'CREATE' button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17974_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17974_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
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
	Then "Started" content is displayed in "zUserAutom: Stage 3 \ DDL Slot Task" column
	Then "" content is displayed in "zUserAutom: Stage 3 \ DDL Slot Task (Date)" column
	Then "" content is displayed in "zUserAutom: Stage 3 \ DDL Slot Task (Slot)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17829 @Cleanup @Not_Ready
#Waiting for 'zMailbox Sch for Automations Feature' project
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerInMailboxScopedAutomation
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                               | Run    |
	| 17829_Automation | 17829       | true   | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '17829_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3' option from 'Stage' autocomplete
	When User selects 'Radio Date Owner' option from 'Task' autocomplete
	And User selects "No change" Update Value on Action panel
	And User selects 'No change' in the 'Update Date' dropdown
	And User selects "Remove owner" Update Owner on Action panel
	And User clicks 'CREATE' button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17829_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17829_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User refreshes agGrid
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
	Then "NOT STARTED" content is displayed in "zMailboxAu: Stage 3 \ Radio Date Owner" column
	Then "7 Sep 2019" content is displayed in "zMailboxAu: Stage 3 \ Radio Date Owner (Date)" column
	Then "Unassigned" content is displayed in "zMailboxAu: Stage 3 \ Radio Date Owner (Owner)" column
	Then "Admin IT" content is displayed in "zMailboxAu: Stage 3 \ Radio Date Owner (Team)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS18207 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionValueIDInTheAutomationLog
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "Applications_Scope" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "Applications_Scope" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User have opened column settings for "Type" column
	And User clicks Column button on the Column Settings panel
	And User select "Action Value ID" checkbox on the Column Settings panel
	When User enters "527" text in the Search field for "Action Value ID" column
	Then "Action_3" content is displayed for "Action" column
	When User enters "562" text in the Search field for "Action Value ID" column
	Then "Action_2" content is displayed for "Action" column
	When User enters "562" text in the Search field for "Action Value ID" column
	Then "Action_2" content is displayed for "Action" column
	When User enters "498" text in the Search field for "Action Value ID" column
	Then "Action_1" content is displayed for "Action" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17786 @DAS18287 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckOpIdColumnInTheAutomationLog
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "Mailboxes_Scope" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "Mailboxes_Scope" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User have opened column settings for "Type" column
	And User clicks Column button on the Column Settings panel
	And User select "Operation ID" checkbox on the Column Settings panel
	When User select "Scope" checkbox on the Column Settings panel
	When User enters "50" text in the Search field for "Objects" column
	Then content is present in the following newly added columns:
	| ColumnName   |
	| Operation ID |
	When User clicks content from "Scope" column
	Then 'All Mailboxes' list should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS18265 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckArchivedObjectNumbersFromAnutomationLogGrid
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope        | Run    |
	| 18265_Automation | 18265       | true   | false              | 1803 Rollout | Manual |
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
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18265_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18265_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "59" text in the Search field for "Objects" column
	And User clicks content from "Objects" column
	Then "59" rows are displayed in the agGrid