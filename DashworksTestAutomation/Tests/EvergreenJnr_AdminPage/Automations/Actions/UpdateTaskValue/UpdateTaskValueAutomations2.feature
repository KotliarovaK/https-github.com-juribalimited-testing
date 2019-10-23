Feature: UpdateTaskValueAutomations2
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18292 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogForUpdateTaskValueInApplicationsAutomation
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 18292_Automation | 18292       | true   | false              | Apps with a Vendor | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18292_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT Auto App' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18292_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18292_Automation" item on Admin page
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18292_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zUserAutom: Relative BU \ DT Auto App (Date) |
	Then "9 Oct 2019 14:00" content is displayed in "zUserAutom: Relative BU \ DT Auto App (Date)" column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18292_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "18292_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18292_Automation" item on Admin page
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18292_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zUserAutom: Relative BU \ DT Auto App (Date) |
	Then "10 Oct 2019 00:00" content is displayed in "zUserAutom: Relative BU \ DT Auto App (Date)" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18292 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogForUpdateTaskValueInMailboxesAutomation
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope                               | Run    |
	| 182921_Automation | 18292       | true   | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18292_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT Auto Mail' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "182921_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "182921_Automation" item on Admin page
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "182921_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| zMailboxAu: Relative BU \ DT Auto Mail |
	Then "25 Oct 2019" content is displayed in "zMailboxAu: Relative BU \ DT Auto Mail" column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "182921_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "182921_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "182921_Automation" item on Admin page
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "182921_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| zMailboxAu: Relative BU \ DT Auto Mail |
	Then "15 Oct 2019" content is displayed in "zMailboxAu: Relative BU \ DT Auto Mail" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18292 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogForUpdateTaskValueInDevicesAutomation
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 182922_Automation | 18292       | true   | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18292_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT Auto Device' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Not Started' in the 'Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "182922_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "182922_Automation" item on Admin page
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "182922_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                      |
	| zDeviceAut: Relative BU \ DT Auto Device        |
	| zDeviceAut: Relative BU \ DT Auto Device (Date) |
	Then "NOT STARTED" content is displayed in "zDeviceAut: Relative BU \ DT Auto Device" column
	Then "" content is displayed in "zDeviceAut: Relative BU \ DT Auto Device (Date)" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18543 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckTheAvailabilityOfTheUnitsfieldDependingOnTheTask
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 18543_Automation | 18543       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '18543_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3' option from 'Stage' autocomplete
	When User selects 'Date Only with Capacity User' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	Then 'Utils' dropdown is disabled
	#Change task with date and time
	When User selects 'DDL Slot Task' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '10' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	Then 'CREATE' button is not disabled