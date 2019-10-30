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

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18411 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedContentIsUpdatedAfterChangingUpdateValues
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18411_Automation | 18411       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18411_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters '0' text to 'Find Value' textbox
	When User enters '12' text to 'Replace Value' textbox
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User selects 'Replace single value' in the 'Update Values' dropdown
	Then '' content is displayed in 'Find Value' textbox
	Then '' content is displayed in 'Replace Value' textbox

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18705 @Cleanup @Not_Ready
#Waiting for DAS18705 fixed on autorelease
Scenario: EvergreenJnr_AdminPage_CheckActionsValueForDuplacatedAutomation
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18705_Automation  | 18705       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18705_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds '1' value from 'Value' textbox
	When User clicks 'CREATE' button
	#Duplicate Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18705_Automation" text in the Search field for "Automation" column
	When User clicks "Duplicate" option in Cog-menu for "18705_Automation" item on Admin page
	When User enters "18705_Automation2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then "18705_Action" content is displayed in "Action Name" field
	Then 'Update custom field' content is displayed in 'Action Type' dropdown
	Then 'Phoenix Field' content is displayed in 'Custom Field' textbox
	Then 'Replace all values' content is displayed in 'Update Values' dropdown
	Then '1' chip value displayed for 'Value' textbox
	When User clicks 'Automations' header breadcrumb
	When User enters "18705_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	And User removes selected item