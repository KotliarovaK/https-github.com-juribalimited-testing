Feature: UpdateTaskValueAutomations1
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18320 @Cleanup
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
	And User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then 'Mailbox Evergreen Capacity Project' content is not displayed in 'Project' autocomplete after search

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @Cleanup
Scenario: EvergreenJnr_AdminPage_Check
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 182481_Automation | 18248       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Dev' option from 'Task' autocomplete

	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'CREATE' button

	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	And User clicks 'CREATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "15 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column
	And User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then 'Mailbox Evergreen Capacity Project' content is not displayed in 'Project' autocomplete after search