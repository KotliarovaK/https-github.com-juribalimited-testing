Feature: UpdateCustomFieldAutomations3
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18317 @Cleanup @Not_Ready
#Waiting for 'Phoenix Field' from GD to automation
Scenario: EvergreenJnr_AdminPage_CheckActionsUpdateCustomFieldValues
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18317_Automation | 18317       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18317_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds 'new_value' value from 'Value' textbox
	When User clicks 'CREATE' button 
	#Create Action
	Then There are no errors in the browser console
	Then "new_value" content is displayed for "Value" column