Feature: UpdateCustomFieldAutomations2
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @DAS18374 @DAS18179 @DAS20274 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldAddToExistingValues
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope              | Run    |
	| 18187_Automation | 18187       | true     | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18187_Action1' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds 'bla¿ck' value from 'Value' textbox
	When User adds ''green'' value from 'Value' textbox
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation' item from 'Automation' column
	When '18187_Automation' automation '18187_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	When User opens 'Action' column settings
	When User clicks Column button on the Column Settings panel
	When User select "Action Task or Field" checkbox on the Column Settings panel
	When User select "Action Value" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
	Then "Phoenix Field" content is displayed for "Action Task or Field" column
	Then "bla¿ck, 'green'" content is displayed for "Action Value" column
	When User clicks content from "Objects" column
	Then 'bla¿ck, 'green', zero' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'bla¿ck' value from 'Value' textbox
	When User adds ''green'' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation' item from 'Automation' column
	When '18187_Automation' automation '18187_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	Then 'zero' content is displayed in the 'Phoenix Field' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @DAS18374 @DAS18374 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldReplaceSingleValue
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope                             | Run    |
	| 18187_Automation_1 | 18187       | true     | false              | Users Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18187_Action2' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters '012345' text to 'Find Value' textbox
	When User enters 'new value' text to 'Replace Value' textbox
	When User clicks 'CREATE' button
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation_1' item from 'Automation' column
	When '18187_Automation_1' automation '18187_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then 'new value' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds '012345' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation_1' item from 'Automation' column
	When '18187_Automation_1' automation '18187_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then '012345' content is displayed in the 'Phoenix Field' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @DAS18374 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldRemoveAllValues
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope        | Run    |
	| 18187_Automation_2 | 18187       | true     | false              | 2004 Rollout | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18187_Action3' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation_2' item from 'Automation' column
	When '18187_Automation_2' automation '18187_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then '' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds '1 value' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation_2' item from 'Automation' column
	When '18187_Automation_2' automation '18187_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then '1 value' content is displayed in the 'Phoenix Field' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @DAS18374 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldReplaceAllValues
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope                               | Run    |
	| 18187_Automation_3 | 18187       | true     | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18187_Action4' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds 'one' value from 'Value' textbox
	When User adds 'two' value from 'Value' textbox
	When User clicks 'CREATE' button 
	#Create Action
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation_3' item from 'Automation' column
	When '18187_Automation_3' automation '18187_Action4' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then 'one, two' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'two' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18187_Automation_3' item from 'Automation' column
	When '18187_Automation_3' automation '18187_Action4' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then 'one' content is displayed in the 'Phoenix Field' column