Feature: UpdateApplicationAttributesAutomations
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18727 @Cleanup @Not_Ready
#Waiting 'Update custom field' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesForAutomations
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 18727_Automation | 18727       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18727_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	When User selects 'Red' in the 'Sticky Compliance' dropdown
	Then 'CREATE' button is disabled
	Then 'SAVE AND CREATE ANOTHER' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'SAVE AND CREATE ANOTHER' button has tooltip with 'Some values are missing or not valid' text
	Then Add button for 'Value' textbox is disabled
	Then 'Enter a value' add button tooltip is displayed for 'Value' textbox
	When User enters 'test' text to 'Value' textbox
	Then 'Add value' add button tooltip is displayed for 'Value' textbox
	When User adds '1' value from 'Value' textbox
	Then 'CREATE' button is not disabled
	Then 'SAVE AND CREATE ANOTHER' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'SAVE AND CREATE ANOTHER' button is not disabled
	#Create Action