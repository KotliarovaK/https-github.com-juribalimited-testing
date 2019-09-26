﻿Feature: UpdateCustomFieldAutomations1
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17881 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldReplaceAllValues
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17881_Automation | 17881       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace all values' in the 'Update Values' dropdown
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	Then Add button for 'Value' textbox is disabled
	Then 'Enter a value' add button tooltip is displayed for 'Value' textbox
	When User enters 'test' text to 'Value' textbox
	Then 'Add value' add button tooltip is displayed for 'Value' textbox
	When User adds '1' value from 'Value' textbox
	Then "CREATE" Action button is active
	Then "SAVE AND CREATE ANOTHER" Action button is active
	Then "CANCEL" Action button is active
	Then "SAVE AND CREATE ANOTHER" Action button is active
	#Create Action

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17881 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldAddToExistingValues
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope         | Run    |
	| 17881_Automation_2 | 17881       | true   | false              | All Mailboxes | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	When User adds 'TEST' value from 'Value' textbox
	Then "CREATE" Action button is active
	Then "SAVE AND CREATE ANOTHER" Action button is active
	Then "CANCEL" Action button is active
	Then "SAVE AND CREATE ANOTHER" Action button is active
	#Create Action

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17881 @DAS17289 @DAS17751 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldRemoveAllValues
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17881_Automation_3 | 17881       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	Then following Values are displayed in the 'Update Values' dropdown:
	| Values                 |
	| Replace all values     |
	| Add to existing values |
	| Replace single value   |
	| Remove all values      |
	| Remove specific values |
	When User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The automation action has been created" text
	#Create Action
	When User clicks content from "Action" column
	Then Edit Action page is displayed to the User
	Then "UPDATE" Action button is disabled
	Then "UPDATE" Action button have tooltip with "No changes made" text
	Then 'Remove all values' content is displayed in 'Update Values' dropdown
	Then "17881_Action" content is displayed in "Action Name" field
	Then 'Update custom field' text value is displayed in the 'Action Type' dropdown
	Then 'Phoenix Field' content is displayed in 'Custom Field' textbox
	When User enters 'New_Action' text to 'Action Name' textbox
	Then "UPDATE" Action button is active

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17881 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldRemoveSpecificValues
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 17881_Automation_4 | 17881       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Remove specific values' in the 'Update Values' dropdown
	Then "CREATE" Action button is disabled
	Then "SAVE AND CREATE ANOTHER" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some values are missing or not valid" text
	Then "SAVE AND CREATE ANOTHER" Action button have tooltip with "Some values are missing or not valid" text
	When User adds '1' value from 'Value' textbox
	Then "CREATE" Action button is active
	Then "SAVE AND CREATE ANOTHER" Action button is active
	Then "CANCEL" Action button is active
	Then "SAVE AND CREATE ANOTHER" Action button is active
	#Create Action

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17881 @DAS17751 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldReplaceSingleValue
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName     | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17881_Automation_4 | 17881       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters 'first value' text to 'Find Value' textbox
	When User enters 'second' text to 'Replace Value' textbox
	When User clicks the "SAVE AND CREATE ANOTHER" Action button
	Then Success message is displayed and contains "The automation action has been created" text
	#Create Action
	Then Create Action page is displayed to the User
	When User clicks the "CANCEL" Action button
	When User clicks content from "Action" column
	Then Edit Action page is displayed to the User
	Then "UPDATE" Action button is disabled
	Then "UPDATE" Action button have tooltip with "No changes made" text
	Then 'Replace single value' content is displayed in 'Update Values' dropdown
	Then "17881_Action" content is displayed in "Action Name" field
	Then 'Update custom field' text value is displayed in the 'Action Type' dropdown
	Then 'Phoenix Field' content is displayed in 'Custom Field' textbox
	Then 'first value' content is displayed in 'Find Value' textbox
	Then 'second' content is displayed in 'Replace Value' textbox