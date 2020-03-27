Feature: AutomationsLogPart2
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17684 @DAS19117 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDateForUpdateTaskValueActionDAS17684
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17684_Automation | 17684       | true   | false              | Apps with a Vendor | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '17682_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	And User selects 'Stage 1 \ Radiobutton Date App Task' option from 'Task' autocomplete
	Then inline error banner is not displayed
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'No change' in the 'Update Date' dropdown
	Then 'CREATE' button is disabled
	And 'SAVE & CREATE ANOTHER' button is disabled
	When User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Failed' in the 'Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '13 Aug 2019' text to 'Date' textbox
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	And User enters "17684_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17684_Automation' item from 'Automation' column
	When '17684_Automation' automation run has finished
	When '17684_Automation' automation '17682_Action' action run has finished
	And User navigates to the 'Automation Log' left menu item
	And User enters "17684_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	And User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                             |
	| zUserAutom: Stage 1 \ Radiobutton Date App Task        |
	| zUserAutom: Stage 1 \ Radiobutton Date App Task (Date) |
	Then 'FAILED' content is displayed in the 'zUserAutom: Stage 1 \ Radiobutton Date App Task' column
	And '13 Aug 2019' content is displayed in the 'zUserAutom: Stage 1 \ Radiobutton Date App Task (Date)' column


@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17636 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInDeviceScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17636_Automation | 17636       | true   | false              | New York - Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17636_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17636_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Project 00 M Computer Scheduled' option from 'Project' autocomplete
	When User selects 'Planning' option from 'Stage' autocomplete
	When User selects 'Get technical information' option from 'Task' autocomplete
	And User selects 'Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17636_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17636_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
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
	Then 'Started' content is displayed in the 'Pr00: Planning \ Get technical information' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17642 @DAS20360 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInMailboxScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                  | Run    |
	| 17642_Automation | 17642       | true   | false              | Mailbox List (Complex) | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17642_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17642_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Email Migration' option from 'Project' autocomplete
	When User selects 'Comms & Exceptions \ Mailbox Dropdown Non RAG Owner' option from 'Task' autocomplete
	And User selects 'Maybe' in the 'Update Value' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17642_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17642_Automation' item from 'Automation' column
	When '17642_Automation' automation '17642_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17642_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	When User clicks content from "Objects" column
	Then "EmailMigra: Comms & Exceptions \ Mailbox Dropdown Non RAG Owner (Team)" column is not displayed to the user
	Then "EmailMigra: Comms & Exceptions \ Mailbox Dropdown Non RAG Owner (Owner)" column is not displayed to the user
	Then 'Maybe' content is displayed in the 'EmailMigra: Comms & Exceptions \ Mailbox Dropdown Non RAG Owner' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17643 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInApplicationScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17643_Automation | 17643       | true   | false              | Apps with a Vendor | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17643_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17643_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' option from 'Project' autocomplete
	When User selects 'Stage 1' option from 'Stage' autocomplete
	When User selects 'Text Task (App)' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	When User selects 'New Text value' option from 'Value' autocomplete
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17643_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17643_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
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
	Then 'New Text value' content is displayed in the 'USEMEFORA2: Stage 1 \ Text Task (App)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17799 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInDevicesScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17799_Automation | 17799       | true   | false              | New York - Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17799_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17799_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage B' option from 'Stage' autocomplete
	When User selects 'Readiness Date Comp Task' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Started' in the 'Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17799_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17643_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
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
	Then 'STARTED' content is displayed in the 'zDeviceAut: Stage B \ Readiness Date Comp Task' column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	When User clicks the Columns button
	Then '1 Aug 2019' content is displayed in the 'zDeviceAut: Stage B \ Readiness Date Comp Task (Date)' column
	Then 'STARTED' content is displayed in the 'zDeviceAut: Stage B \ Readiness Date Comp Task' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17678 @DAS17859 @DAS17974 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInUserScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                               | Run    |
	| 17678_Automation | 17643       | true   | false              | Mailbox Readiness Columns & Filters | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17678_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17678_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2' option from 'Stage' autocomplete
	When User selects 'Radio Date Slot Mail' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Started' in the 'Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '3 Oct 2019' text to 'Date' datepicker
	And User selects 'Radio Slot' in the 'Capacity Slot' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17678_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17678_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17678_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                        |
	| zMailboxAu: Stage 2 \ Radio Date Slot Mail        |
	| zMailboxAu: Stage 2 \ Radio Date Slot Mail (Date) |
	| zMailboxAu: Stage 2 \ Radio Date Slot Mail (Slot) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Email Address" column by Column panel
	When User clicks the Columns button
	Then 'STARTED' content is displayed in the 'zMailboxAu: Stage 2 \ Radio Date Slot Mail' column
	Then '3 Oct 2019' content is displayed in the 'zMailboxAu: Stage 2 \ Radio Date Slot Mail (Date)' column
	Then 'Radio Slot' content is displayed in the 'zMailboxAu: Stage 2 \ Radio Date Slot Mail (Slot)' column
	#Update Action
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "17678_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	And User clicks content from "Action" column
	And User selects 'Remove' in the 'Update Date' dropdown
	And User clicks 'UPDATE' button 
	#Check updated Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17678_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17678_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17678_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                        |
	| zMailboxAu: Stage 2 \ Radio Date Slot Mail        |
	| zMailboxAu: Stage 2 \ Radio Date Slot Mail (Date) |
	| zMailboxAu: Stage 2 \ Radio Date Slot Mail (Slot) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Email Address" column by Column panel
	When User clicks the Columns button
	Then 'STARTED' content is displayed in the 'zMailboxAu: Stage 2 \ Radio Date Slot Mail' column
	Then '' content is displayed in the 'zMailboxAu: Stage 2 \ Radio Date Slot Mail (Date)' column
	Then '' content is displayed in the 'zMailboxAu: Stage 2 \ Radio Date Slot Mail (Slot)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17682 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueAndOwnerInDevicesScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17682_Automation | 17682       | true   | false              | New York - Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17682_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '17682_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage A' option from 'Stage' autocomplete
	When User selects 'Readiness Owner Task' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Tested' in the 'Value' dropdown
	And User selects 'Tested' in the 'Value' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects 'Admin IT' option from 'Team' autocomplete
	When User selects 'Maryna Kyslyak' option from 'Owner' autocomplete
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17682_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17682_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
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
	Then 'TESTED' content is displayed in the 'zDeviceAut: Stage A \ Readiness Owner Task' column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	When User clicks the Columns button
	Then 'Maryna Kyslyak' content is displayed in the 'zDeviceAut: Stage A \ Readiness Owner Task (Owner)' column
	Then 'Admin IT' content is displayed in the 'zDeviceAut: Stage A \ Readiness Owner Task (Team)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17682 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForRemoveOwnerAndTeamInDevicesScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName     | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 17682_Automation_2 | 17682       | true   | false              | New York - Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17682_Automation_2" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	And User clicks 'CREATE ACTION' button 
	And User enters '17682_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	And User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	And User selects 'Stage C' option from 'Stage' autocomplete
	And User selects 'Readiness Owner Date Don't Change' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Remove owner and team' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	And User clicks 'Automations' header breadcrumb
	And User enters "17682_Automation_2" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17682_Automation_2' item from 'Automation' column
	And User navigates to the 'Automation Log' left menu item
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
	Then 'NOT STARTED' content is displayed in the 'zDeviceAut: Stage C \ Readiness Owner Date Don't Change' column
	And '5 Jul 2019' content is displayed in the 'zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Date)' column
	And 'Unassigned' content is displayed in the 'zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Owner)' column
	And 'Unassigned' content is displayed in the 'zDeviceAut: Stage C \ Readiness Owner Date Don't Change (Team)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17678 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInUserScopedAutomationForRemoveDate
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| AutomationName     | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| 17678_Automation_1 | 17643_1     | true   | false              | Users with Device Count | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17678_Automation_1" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17678_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project' autocomplete
	When User selects 'Stage A' option from 'Stage' autocomplete
	When User selects 'Radiobutton Readiness Date Task No CS' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Failed' in the 'Value' dropdown
	And User selects 'Remove' in the 'Update Date' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17678_Automation_1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17678_Automation_1' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
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
	Then 'FAILED' content is displayed in the 'UseMeForAu: Stage A \ Radiobutton Readiness Date Task No CS' column
	Then '' content is displayed in the 'UseMeForAu: Stage A \ Radiobutton Readiness Date Task No CS (Date)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15945 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatClickingOnTheObjectsCountOpensTheCorrectFilteredList
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User navigates to the 'Automation Log' left menu item
	And User enters "X-Proj Path Reset" text in the Search field for "Automation" column
	And User enters "2" text in the Search field for "Objects" column
	Then "2" content is displayed for "Objects" column
	When User clicks content from "Objects" column
	And User clicks the Filters button
	Then "X-Proj Path Reset is 12/08/2019 18:07:05" is displayed in added filter info

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17430 @DAS17518 @DAS18374 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDateForUpdateTaskValueActionDAS17430
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17430_Automation | 17430       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17430_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Radiobutton Readiness Date Owner Task (User)' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Failed' in the 'Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '19 Nov 2019' text to 'Date' datepicker
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects 'Admin IT' option from 'Team' autocomplete
	When User selects 'Akhila Varghese' option from 'Owner' autocomplete
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17430_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17430_Automation' item from 'Automation' column
	When '17430_Automation' automation '17430_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17430_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then 'FAILED' content is displayed in the 'USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User)' column