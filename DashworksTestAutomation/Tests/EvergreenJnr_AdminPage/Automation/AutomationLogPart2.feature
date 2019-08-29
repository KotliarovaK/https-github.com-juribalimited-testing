Feature: AutomationsLogPart2
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17430 @DAS17518 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDateForUpdateTaskValueActionDAS17430
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17430_Automation | 17430       | true   | false              | All Users | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17430_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17430_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' option from 'Project' autocomplete
	When User selects "Stage 1" in the "Stage" dropdown for Actions
	When User selects "Radiobutton Readiness Date Owner Task (User)" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Started" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "19 Nov 2019" Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "Admin IT" Team on Action panel
	When User selects "Akhila Varghese" Owner on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17430_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17430_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User enters "17430_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                         |
	| USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) |
	Then "STARTED" content is displayed in "USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17636 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInDeviceScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17636_Automation | 17636       | true   | false              | New York - Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17636_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17636_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'Project 00 M Computer Scheduled' option from 'Project' autocomplete
	When User selects "Planning" in the "Stage" dropdown for Actions
	When User selects "Get technical information" in the "Task" dropdown for Actions
	And User selects "Started" Value on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17636_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17636_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17636_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                 |
	| Pr00: Planning \ Get technical information |
	Then "Started" content is displayed in "Pr00: Planning \ Get technical information" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17642 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInMailboxScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                  | Run    |
	| 17642_Automation | 17642       | true   | false              | Mailbox List (Complex) | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17642_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17642_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'Email Migration' option from 'Project' autocomplete
	When User selects "Comms & Exceptions" in the "Stage" dropdown for Actions
	When User selects "Mailbox Dropdown Non RAG Owner" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Maybe" Value on Action panel
	And User selects "No change" Update Owner on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17642_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17642_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17642_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                      |
	| EmailMigra: Comms & Exceptions \ Mailbox Dropdown Non RAG Owner |
	Then "Maybe" content is displayed in "EmailMigra: Comms & Exceptions \ Mailbox Dropdown Non RAG Owner" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17643 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInApplicationScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17643_Automation | 17643       | true   | false              | Apps with a Vendor | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17643_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17643_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' option from 'Project' autocomplete
	When User selects "Stage 1" in the "Stage" dropdown for Actions
	When User selects "Text Task (App)" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	When User types "New Text value" Value on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17643_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17643_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17643_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                      |
	| USEMEFORA2: Stage 1 \ Text Task (App) |
	Then "New Text value" content is displayed in "USEMEFORA2: Stage 1 \ Text Task (App)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17799 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInDevicesScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17799_Automation | 17799       | true   | false              | New York - Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17799_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17799_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects "Stage B" in the "Stage" dropdown for Actions
	When User selects "Readiness Date Comp Task" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Started" Value on Action panel
	And User selects "No change" Update Date on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17799_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17799_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17799_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                            |
	| zDeviceAut: Stage B \ Readiness Date Comp Task        |
	| zDeviceAut: Stage B \ Readiness Date Comp Task (Date) |
	Then "STARTED" content is displayed in "zDeviceAut: Stage B \ Readiness Date Comp Task" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	When User clicks the Columns button
	Then "1 Aug 2019" content is displayed in "zDeviceAut: Stage B \ Readiness Date Comp Task (Date)" column
	Then "STARTED" content is displayed in "zDeviceAut: Stage B \ Readiness Date Comp Task" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17678 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInUserScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| 17678_Automation | 17643       | true   | false              | Users with Device Count | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17678_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17678_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' option from 'Project' autocomplete
	When User selects "Stage 2" in the "Stage" dropdown for Actions
	When User selects "Radiobutton Readiness Date Task" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Started" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "15 Aug 2019" Date on Action panel
	And User selects "Radiobutton Readiness Date Slot" value for "Capacity Slot" dropdown on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17678_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17678_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17678_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                   |
	| USEMEFORA2: Stage 2 \ Radiobutton Readiness Date Task        |
	| USEMEFORA2: Stage 2 \ Radiobutton Readiness Date Task (Date) |
	| USEMEFORA2: Stage 2 \ Radiobutton Readiness Date Task (Slot) |
	Then "STARTED" content is displayed in "USEMEFORA2: Stage 2 \ Radiobutton Readiness Date Task" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Distinguished Name" column by Column panel
	When User removes "Display Name" column by Column panel
	When User clicks the Columns button
	Then "15 Aug 2019" content is displayed in "USEMEFORA2: Stage 2 \ Radiobutton Readiness Date Task (Date)" column
	Then "Radiobutton Readiness Date Slot" content is displayed in "USEMEFORA2: Stage 2 \ Radiobutton Readiness Date Task (Slot)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17682 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueAndOwnerInDevicesScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17682_Automation | 17682       | true   | false              | New York - Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17682_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17682_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects "Stage A" in the "Stage" dropdown for Actions
	When User selects "Readiness Owner Task" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	When User selects "Tested" Value on Action panel
	And User selects "Tested" Value on Action panel
	When User selects "Update" Update Owner on Action panel
	When User selects "Admin IT" Team on Action panel
	When User selects "Maryna Kyslyak" Owner on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17682_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17682_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17682_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                         |
	| zDeviceAut: Stage A \ Readiness Owner Task         |
	| zDeviceAut: Stage A \ Readiness Owner Task (Owner) |
	| zDeviceAut: Stage A \ Readiness Owner Task (Team)  |
	Then "TESTED" content is displayed in "zDeviceAut: Stage A \ Readiness Owner Task" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	When User clicks the Columns button
	Then "Maryna Kyslyak" content is displayed in "zDeviceAut: Stage A \ Readiness Owner Task (Owner)" column
	Then "Admin IT" content is displayed in "zDeviceAut: Stage A \ Readiness Owner Task (Team)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17682 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerAndTeamInDevicesScopedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName     | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17682_Automation_2 | 17682       | true   | false              | New York - Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17682_Automation_2" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	And User clicks the "CREATE ACTION" Action button
	And User enters '17682_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	And User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	And User selects "Stage C" in the "Stage" dropdown for Actions
	And User selects "Readiness Owner Date Don't Change" in the "Task" dropdown for Actions
	And User selects "No change" Update Value on Action panel
	And User selects "No change" Update Date on Action panel
	And User selects "Remove owner and team" Update Owner on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	And User clicks "Automations" navigation link on the Admin page
	And User enters "17682_Automation_2" text in the Search field for "Automation" column
	And User clicks "Run now" option in Cog-menu for "17682_Automation_2" item on Admin page
	And User selects "Automation Log" tab on the Project details page
	And User clicks refresh button in the browser
	And User enters "17682_Automation_2" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	And User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                      |
	| zDeviceAut: Stage C \ Readiness Owner Date Don't Change         |
	| zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Date)  |
	| zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Owner) |
	| zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Team)  |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	And User removes "Owner Display Name" column by Column panel
	And User removes "Device Type" column by Column panel
	And User clicks the Columns button
	Then "NOT STARTED" content is displayed in "zDeviceAut: Stage C \ Readiness Owner Date Don't Change" column
	And "5 Jul 2019" content is displayed in "zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Date)" column
	And "Unassigned" content is displayed in "zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Owner)" column
	And "Unassigned" content is displayed in "zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Team)" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17678 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInUserScopedAutomationForRemoveDate
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName     | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| 17678_Automation_1 | 17643_1     | true   | false              | Users with Device Count | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17678_Automation_1" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	When User enters '17678_Action' text to 'Action Name' textbox
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	When User selects "Stage A" in the "Stage" dropdown for Actions
	When User selects "Radiobutton Readiness Date Task No CS" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Failed" Value on Action panel
	And User selects "Remove" Update Date on Action panel
	And User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17678_Automation_1" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17678_Automation_1" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17678_Automation_1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                   |
	| UseMeForAu: Stage A \ Radiobutton Readiness Date Task No CS        |
	| UseMeForAu: Stage A \ Radiobutton Readiness Date Task No CS (Date) |
	Then "FAILED" content is displayed in "UseMeForAu: Stage A \ Radiobutton Readiness Date Task No CS" column
	Then "" content is displayed in "UseMeForAu: Stage A \ Radiobutton Readiness Date Task No CS (Date)" column