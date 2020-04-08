Feature: CreateCustomFieldForAutomations
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Projects
	When User navigate to Manage link
	And User select "Custom Fields" option in Management Console

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17847 @DAS18243 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldValidations
	When User creates new Custom Field
	| FieldName | FieldLabel | AllowExternalUpdate | Enabled | Computer |
	| DAS17847  | 17847      | true                | true    | true     |
	And User navigate to Evergreen URL
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 17847_Automation | 17847       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects '17847' option from 'Custom Field' autocomplete
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds 'Long test value Long test value Long test value Long test value Long test value' value from 'Value' textbox
	When User clicks 'CREATE' button
	#Create Action
	When User removes Custom Field with '17847' label
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "17847_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then "[Custom field not found]" content is displayed for "Task or Field" column
	When User clicks content from "Action" column
	Then "17881_Action" content is displayed in "Action Name" field
	Then 'Update custom field' content is displayed in 'Action Type' dropdown
	Then 'The selected custom field cannot be found' error message is displayed for 'Custom Field' field
	Then '[Custom field not found]' content is displayed in 'Custom Field' textbox

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18166 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldForDisabledCustomFieldOnCreateActionPage
	When User creates new Custom Field
	| FieldName | FieldLabel        | AllowExternalUpdate | Enabled | Computer |
	| DAS18166  | CustomField_18166 | true                | false   | true     |
	And User navigate to Evergreen URL
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18166_Automation | 18166       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	Then 'CustomField_18166' content is not displayed in 'Custom Field' autocomplete after search

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18166 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationsUpdateCustomFieldForDisabledCustomFieldOnUpdateActionPage
	When User creates new Custom Field
	| FieldName | FieldLabel        | AllowExternalUpdate | Enabled | Computer |
	| DAS18166  | CustomField_18166 | true                | false   | true     |
	And User navigate to Evergreen URL
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18166_Automation | 18166       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '17881_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds 'TEST' value from 'Value' textbox
	When User clicks 'CREATE' button
	Then 'The automation action has been created' text is displayed on inline success banner
	#Create Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then 'CustomField_18166' content is not displayed in 'Custom Field' autocomplete after search

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18464 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatObjectsColumnContainsNullOfObjectsForFailedAction
	When User creates new Custom Field
	| FieldName | FieldLabel        | AllowExternalUpdate | Enabled | Computer |
	| DAS18464  | CustomField_18464 | true                | true    | true     |
	And User navigate to Evergreen URL
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18464_Automation | 18464       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action1
	When User clicks 'CREATE ACTION' button
	And User enters '18464_Action1' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	When User clicks 'CREATE' button
	#Create Action2
	When User clicks 'CREATE ACTION' button
	And User enters '18464_Action2' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'CustomField_18464' option from 'Custom Field' autocomplete
	And User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks 'CREATE' button
	#Remove Custom Field
	When User removes Custom Field with 'CustomField_18464' label
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18464_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18464_Automation' item from 'Automation' column
	#Check Automation Log
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18464_Automation" text in the Search field for "Automation" column
	When User enters "0" text in the Search field for "Objects" column
	Then "18464_Action2" content is displayed for "Action" column
	Then "CUSTOM FIELD DOES NOT EXIST" content is displayed for "Outcome" column