Feature: AutomationsLogPart4
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17923
Scenario: EvergreenJnr_AdminPage_CheckThatOutcomeStringFiltersValueAreNotDuplicated
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User navigates to the 'Automation Log' left menu item
	When User clicks String Filter button for "Outcome" column on the Admin page
	Then String filter values are not duplicated

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17683 @Cleanup @Not_Ready
#Waiting for 'zMailbox Sch for Automations Feature' project from GD
Scenario: EvergreenJnr_AdminPage_CheckUpdateAndRemoveTaskValueForUpdateValueInUserScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope                               | Run    |
	| 17683_Automation | 17683       | true     | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17683_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 3' option from 'Stage' autocomplete
	When User selects 'Radio Date Task' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '3 Apr 2019' text to 'Date' datepicker
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "17683_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17683_Automation' item from 'Automation' column
	When '17683_Automation' automation '17683_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17683_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zMailboxAu: Stage 3 \ Radio Date Task        |
	| zMailboxAu: Stage 3 \ Radio Date Task (Date) |
	Then 'NOT STARTED' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Task' column
	Then '3 Apr 2019' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Task (Date)' column
	#Update Action
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "17683_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	And User clicks content from "Action" column
	And User selects 'Remove' in the 'Update Date' dropdown
	And User clicks 'UPDATE' button 
	#Check updated Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "17683_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '17683_Automation' item from 'Automation' column
	When '17683_Automation' automation '17683_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "17683_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zMailboxAu: Stage 3 \ Radio Date Task        |
	| zMailboxAu: Stage 3 \ Radio Date Task (Date) |
	Then 'NOT STARTED' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Task' column
	Then '' content is displayed in the 'zMailboxAu: Stage 3 \ Radio Date Task (Date)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17859 @Cleanup @Not_Ready
#Discuss with Kate how we can change Capacity Slot 7/4/2020
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueForUpdateValueInAppsScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name                | Description | IsActive | StopOnFailedAction | Scope              | Run    |
	| DAS17859_Automation | 17859       | true     | false              | Apps with a Vendor | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters 'DAS17859_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	And User selects 'Stage 2 \ Radio Date Slot App' option from 'Task' autocomplete
	And User selects 'Complete' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '9 Sep 2019' text to 'Date' textbox
	And User selects 'None' in the 'Capacity Slot' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	And User enters "DAS17859_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'DAS17859_Automation' item from 'Automation' column
	When 'DAS17859_Automation' automation 'DAS17859_Action' action run has finished
	And User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	And User enters "DAS17859_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                       |
	| zUserAutom: Stage 2 \ Radio Date Slot App        |
	| zUserAutom: Stage 2 \ Radio Date Slot App (Date) |
	| zUserAutom: Stage 2 \ Radio Date Slot App (Slot) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	When User clicks the Columns button
	Then 'COMPLETE' content is displayed in the 'zUserAutom: Stage 2 \ Radio Date Slot App' column
	Then '9 Sep 2019' content is displayed in the 'zUserAutom: Stage 2 \ Radio Date Slot App (Date)' column
	And '' content is displayed in the 'zUserAutom: Stage 2 \ Radio Date Slot App (Slot)' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17859 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueWithNoChangeDateForUpdateTaskValueInDevocesScopedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope              | Run    |
	| DAS17859_Aut_Test | 17859       | true     | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters 'DAS17859_Action1' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	And User selects 'Stage C' option from 'Stage' autocomplete
	And User selects 'Radio Date Slot Device' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Not Started' in the 'Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	And User enters "DAS17859_Aut_Test" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'DAS17859_Aut_Test' item from 'Automation' column
	When 'DAS17859_Aut_Test' automation 'DAS17859_Action1' action run has finished
	And User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	And User enters "DAS17859_Aut_Test" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                          |
	| zDeviceAut: Stage C \ Radio Date Slot Device        |
	| zDeviceAut: Stage C \ Radio Date Slot Device (Date) |
	| zDeviceAut: Stage C \ Radio Date Slot Device (Slot) |
	Then 'NOT STARTED' content is displayed in the 'zDeviceAut: Stage C \ Radio Date Slot Device' column
	Then '10 Sep 2019' content is displayed in the 'zDeviceAut: Stage C \ Radio Date Slot Device (Date)' column
	Then 'DAS-17846 Slot Device' content is displayed in the 'zDeviceAut: Stage C \ Radio Date Slot Device (Slot)' column