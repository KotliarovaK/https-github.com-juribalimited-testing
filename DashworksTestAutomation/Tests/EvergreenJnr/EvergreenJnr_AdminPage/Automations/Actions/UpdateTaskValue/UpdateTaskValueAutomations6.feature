Feature: UpdateTaskValueAutomations6
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19656 @Cleanup @Void
Scenario: EvergreenJnr_AdminPage_CheckUnitsDropDownForUpdateTaskValue
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| 19656_Automation | 19656       | true   | false              | Users with Device Count | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '19656_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Weekdays Task' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '5' text to 'Value' textbox
	When User selects 'Week days' in the 'Units' dropdown
	When User selects 'After current value' in the 'Before or After' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19656_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19656_Automation' item from 'Automation' column
	When '19656_Automation' automation '19656_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19656_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then '24 Feb 2020' content is displayed in the 'zUserAutom: Stage 2 \ Weekdays Task' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19656_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '17 Feb 2020' text to 'Date' datepicker
	When User clicks 'UPDATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19656_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19656_Automation' item from 'Automation' column
	When '19656_Automation' automation '19656_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19656_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then '17 Feb 2020' content is displayed in the 'zUserAutom: Stage 2 \ Weekdays Task' column