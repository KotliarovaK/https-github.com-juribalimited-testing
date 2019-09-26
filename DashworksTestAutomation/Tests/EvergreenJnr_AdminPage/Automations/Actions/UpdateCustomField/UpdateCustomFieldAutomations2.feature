Feature: UpdateCustomFieldAutomations2
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Projects
	When User navigate to Manage link
	And User select "Custom Fields" option in Management Console

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17847 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldValidations
	When User creates new Custom Field
	| FieldName | FieldLabel | AllowExternalUpdate | Enabled | Computer |
	| DAS17847  | 17847      | true                | true    | true     |
	And User navigate to Evergreen URL
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 17847_Automation | 17847       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'DAS17847' option from 'Custom Field' autocomplete
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds 'Long test value Long test value Long test value Long test value Long test value' value from 'Value' textbox
	#Create Action
	When User clicks the "CREATE" Action button
	When User removes Custom Field with 'DAS17847' label
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17847_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then width of the 'Value' column is '500' pixels
	Then "[Custom field not found]" content is displayed for "Task or Field" column
	When User clicks content from "Action" column
	Then "17881_Action" content is displayed in "Action Name" field
	Then 'Replace single value' content is displayed in 'Update Values' dropdown
	Then 'Update custom field' text value is displayed in the 'Action Type' dropdown
	Then '17847' content is displayed in 'Custom Field' textbox
	Then 'Long test value Long test value Long test value Long test value Long test value' content is displayed in 'Value' textbox
	Then 'The selected custom field has not been found' error message is displayed for 'Custom Field' field
	Then '[Custom field not found]' value is displayed in the 'Custom Field' dropdown