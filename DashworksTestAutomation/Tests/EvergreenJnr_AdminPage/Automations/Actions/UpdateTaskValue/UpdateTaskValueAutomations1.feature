﻿Feature: UpdateTaskValueAutomations1
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

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 182481_Automation | 18248       | true   | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Date Computer' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '999999' text to 'Value' textbox
	Then '100000' content is displayed in 'Value' textbox
	When User enters '-5' text to 'Value' textbox
	Then '1' content is displayed in 'Value' textbox
	When User enters '1' text to 'Value' textbox
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Project' textbox
	Then 'One' content is displayed in 'Stage' textbox
	Then 'Date Computer' content is displayed in 'Task' textbox
	Then '1' content is displayed in 'Value' textbox
	Then 'Days' value is displayed in the 'Units' dropdown
	Then 'Before current value' value is displayed in the 'Before or After' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 182482_Automation | 18248       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Radio Rag Date Owner App' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |
	| No change                        |
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'After current value' in the 'Before or After' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Project' textbox
	Then 'One' content is displayed in 'Stage' textbox
	Then 'Radio Rag Date Owner App' content is displayed in 'Task' textbox
	Then '2' content is displayed in 'Value' textbox
	Then 'No change' value is displayed in the 'Update Value' dropdown
	Then 'Update relative to current value' value is displayed in the 'Update Date' dropdown
	Then 'No change' value is displayed in the 'Update Owner' dropdown
	Then 'Days' value is displayed in the 'Units' dropdown
	Then 'After current value' value is displayed in the 'Before or After' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope         | Run    |
	| 182483_Automation | 18248       | true   | false              | All Mailboxes | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Mailbox Evergreen Capacity Project' option from 'Project' autocomplete
	When User selects '1' option from 'Stage' autocomplete
	When User selects 'Completed' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '3' text to 'Value' textbox
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Mailbox Evergreen Capacity Project' content is displayed in 'Project' textbox
	Then '1' content is displayed in 'Stage' textbox
	Then 'Completed' content is displayed in 'Task' textbox
	Then '3' content is displayed in 'Value' textbox
	Then 'Days' value is displayed in the 'Units' dropdown
	Then 'After current value' value is displayed in the 'Before or After' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @Cleanup @Not_Ready
#Waiting for 'Update relative to current value' value in dropdown
Scenario: EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 182484_Automation | 18248       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project' autocomplete
	When User selects 'Project Dates' option from 'Stage' autocomplete
	When User selects 'Forecast Date' option from 'Task' autocomplete
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	Then following Values are displayed in the 'Before or After' dropdown:
	| Options    |
	| Before now |
	| After now  |
	When User enters '4' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'Before now' in the 'Before or After' dropdown
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Barry's User Project' content is displayed in 'Project' textbox
	Then 'Project Dates' content is displayed in 'Stage' textbox
	Then 'Forecast Date' content is displayed in 'Task' textbox
	Then '4' content is displayed in 'Value' textbox
	Then 'Hours' value is displayed in the 'Units' dropdown
	Then 'Update relative to now' value is displayed in the 'Update Date' dropdown
	Then 'Before now' value is displayed in the 'Before or After' dropdown