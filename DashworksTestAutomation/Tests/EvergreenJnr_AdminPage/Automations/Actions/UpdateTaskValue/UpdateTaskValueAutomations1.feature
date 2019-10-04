Feature: UpdateTaskValueAutomations1
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18320 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjectDropdown
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18320_Automation | 18320       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18320_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	Then 'Mailbox Evergreen Capacity Project' content is not displayed in 'Project' autocomplete after search
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects 'Pre-Migration' option from 'Stage' autocomplete
	When User selects 'App Workflow' option from 'Task' autocomplete
	#When User types "Not Started" Value on Action panel
	And User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks content from "Action" column
	Then Edit Action page is displayed to the User
	Then 'Mailbox Evergreen Capacity Project' content is not displayed in 'Project' autocomplete after search