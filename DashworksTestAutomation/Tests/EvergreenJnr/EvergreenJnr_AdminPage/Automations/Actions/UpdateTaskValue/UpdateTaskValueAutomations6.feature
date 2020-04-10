Feature: UpdateTaskValueAutomations6
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19656 @Cleanup @Wormhole
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

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19274 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckUpdateRelativeToNowValueForAutomation
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope                   | Run    |
	| 192741_Automation | 19274_19656 | true   | false              | Users with Device Count | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '19274_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Weekdays Task' option from 'Task' autocomplete
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	When User enters '0' text to 'Value' textbox
	When User selects 'days before now' in the 'Units' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "192741_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '192741_Automation' item from 'Automation' column
	When '192741_Automation' automation '19274_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "192741_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then current date is displayed for 'zUserAutom: Stage 2 \ Weekdays Task' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "192741_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '10 Feb 2020' text to 'Date' datepicker
	When User clicks 'UPDATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "192741_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '192741_Automation' item from 'Automation' column
	When '192741_Automation' automation '19274_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "192741_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	When User clicks content from "Objects" column
	Then '10 Feb 2020' content is displayed in the 'zUserAutom: Stage 2 \ Weekdays Task' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19854 @DAS2036 @Cleanup @X_Ray
Scenario: EvergreenJnr_AdminPage_CheckUpdateRelativeToDifferentTaskValue
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope              | Run    |
	| 19854_Automation | 19854       | true     | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '19854_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Original Auto Task' option from 'Task' autocomplete
	When User selects 'Complete' in the 'Update Value' dropdown
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	When User selects 'Stage 2 \ Relative Task' option from 'Relative Task' autocomplete
	When User enters '0' text to 'Value' textbox
	When User selects 'weekdays after task value' in the 'DateUnit' dropdown
	When User clicks 'CREATE' button
	Then 'Complete, zUser Sch for Automations Feature, Stage 2 \ Relative Task, 0 weekday after task value' content is displayed in the 'Value' column
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19854_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19854_Automation' item from 'Automation' column
	When '19854_Automation' automation '19854_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19854_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then '20 Feb 2020' content is displayed in the 'zUserAutom: Stage 1 \ Original Auto Task (Date)' column
	Then 'COMPLETE' content is displayed in the 'zUserAutom: Stage 1 \ Original Auto Task' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19854_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Original Auto Task' option from 'Task' autocomplete
	When User selects 'Complete' in the 'Update Value' dropdown
	When User selects 'Remove' in the 'Update Date' dropdown
	When User clicks 'UPDATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19854_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19854_Automation' item from 'Automation' column
	When '19854_Automation' automation '19854_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19854_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then '' content is displayed in the 'zUserAutom: Stage 1 \ Original Auto Task (Date)' column
	Then 'COMPLETE' content is displayed in the 'zUserAutom: Stage 1 \ Original Auto Task' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20278 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckOwnerDropdownDisplayingAfterSelectingEmptyTeam
	When User creates new Team via api
	| TeamName   | Description | IsDefault |
	| 20278_Test | test        | false     |
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 20278_Automation | 20278       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '20278_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage C \ Readiness Owner Date Don't Change' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '20278_Test' option from 'Team' autocomplete
	When User selects 'Unassigned' option from 'Owner' autocomplete
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20363 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckUpdateTaskValueActionDateWhileEditingAction
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 20364_Automation | 20364       | true   | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '20364_Action' text to 'Action Name' textbox
	When User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Original Auto Task' option from 'Task' autocomplete
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	When User selects 'Update' in the 'Update Value' dropdown
	When User selects 'Complete' in the 'Value' dropdown
	When User selects 'Stage 2 \ Relative Task' option from 'Relative Task' autocomplete
	When User enters '0' text to 'Value' textbox
	When User selects 'Week days' in the 'Units' dropdown
	When User selects 'After task value' in the 'Before or After' dropdown
	When User clicks 'CREATE' button
	When User clicks content from "Action" column
	When User selects 'Update' in the 'Update Date' dropdown
	Then '' content is displayed in 'Date' textbox
	When User enters '2 Mar 2020' text to 'Date' textbox
	When User clicks 'UPDATE' button
	Then 'The automation action has been updated' text is displayed on inline success banner