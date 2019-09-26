Feature: UpdateCustomFieldAutomations3
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldAddToExistingValues
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope              | Run    |
	| 18187_Automation | 18187       | true   | false              | New York - Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '18187_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds 'xxx' value from 'Value' textbox
	When User adds 'ccc' value from 'Value' textbox
	When User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "zero, ccc, xxx" content is displayed in "Phoenix Field" column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'xxx' value from 'Value' textbox
	When User adds 'ccc' value from 'Value' textbox
	When User clicks the "UPDATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "zero" content is displayed in "Phoenix Field" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldReplaceSingleValue
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope                             | Run    |
	| 18187_Automation_1 | 18187       | true   | false              | Users Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '18187_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters '012345' text to 'Find Value' textbox
	When User enters 'new value' text to 'Replace Value' textbox
	When User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation_1" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "new value" content is displayed in "Phoenix Field" column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds '012345' value from 'Value' textbox
	When User clicks the "UPDATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation_1" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation_1" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "012345" content is displayed in "Phoenix Field" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldRemoveAllValues
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 18187_Automation_2 | 18187       | true   | false              | 1803 Apps | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '18187_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation_2" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "" content is displayed in "Phoenix Field" column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds '1 value' value from 'Value' textbox
	When User clicks the "UPDATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation_2" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation_2" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "1 value" content is displayed in "Phoenix Field" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18187 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckValuesChangingAutomationsUpdateCustomFieldReplaceAllValues
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope                               | Run    |
	| 18187_Automation_3 | 18187       | true   | false              | Mailbox Readiness Columns & Filters | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '18187_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds 'one' value from 'Value' textbox
	When User adds 'two' value from 'Value' textbox
	When User clicks the "CREATE" Action button
	#Create Action
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation_3" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "one, two" content is displayed in "Phoenix Field" column
		#Revert 'Update custom field' changes to default
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	And User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'two' value from 'Value' textbox
	When User clicks the "UPDATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18187_Automation_3" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "18187_Automation_3" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	Then "one" content is displayed in "Phoenix Field" column