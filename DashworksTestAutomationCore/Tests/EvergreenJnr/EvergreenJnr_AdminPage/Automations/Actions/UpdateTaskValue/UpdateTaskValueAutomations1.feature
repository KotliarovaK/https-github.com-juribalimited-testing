Feature: UpdateTaskValueAutomations1
	Runs Update Task Value Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18320 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectWithoutTasksForScopeIsNotDisplayedInProjectDropdown
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 18320_Automation | 18320       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18320_Action' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	Then 'Mailbox Evergreen Capacity Project' content is not displayed in 'Project' autocomplete after search
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Pre-Migration \ App Workflow' option from 'Task' autocomplete
	And User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'CREATE' button 
	#Create Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then 'Mailbox Evergreen Capacity Project' content is not displayed in 'Project' autocomplete after search

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @DAS18640 @DAS19274 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDevicesAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 182481_Automation | 18248       | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action1' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Date Computer' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '0' text to 'Value' textbox
	Then User sees '0 to 100,000' hint below 'Value' field
	Then '0' content is displayed in 'Value' autocomplete
	When User enters '999999' text to 'Value' textbox
	Then User sees '0 to 100,000' red hint below 'Value' field
	When User enters '-5' text to 'Value' textbox
	Then User sees '0 to 100,000' red hint below 'Value' field
	When User enters '2' text to 'Value' textbox
	Then 'CREATE' button is not disabled
	When User selects 'days before current value' in the 'Units' dropdown
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action1" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Project' textbox
	Then 'One \ Date Computer' content is displayed in 'Task' textbox
	Then '2' content is displayed in 'Value' textbox
	Then 'days before current value' value is displayed in the 'Units' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @DAS18965 @DAS18886 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckApplicationsAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 182482_Automation | 18248       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action2' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Rag Date Owner App' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                                   |
	| No change                                 |
	| Update                                    |
	| Update relative to current value          |
	| Update relative to now                    |
	| Update relative to a different task value |
	| Remove                                    |
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'days after current value' in the 'Units' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'CREATE' button
	Then 'The automation action has been created' text is displayed on inline success banner
	#Check Actions grid
	Then "2 days after current value" content is displayed for "Value" column
	When User opens 'Action' column settings
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Update Type" checkbox on the Column Settings panel
	Then "Update relative to current value" content is displayed for "Update Type" column
	Then grid headers are displayed in the following order
	| ColumnName    |
	| Action        |
	|               |
	| Type          |
	| Project       |
	| Task or Field |
	| Update Type   |
	| Value         |
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action2" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Computer Scheduled Test (Jo)' content is displayed in 'Project' textbox
	Then 'One \ Radio Rag Date Owner App' content is displayed in 'Task' textbox
	Then '2' content is displayed in 'Value' textbox
	Then 'No change' value is displayed in the 'Update Value' dropdown
	Then 'Update relative to current value' value is displayed in the 'Update Date' dropdown
	Then 'No change' value is displayed in the 'Update Owner' dropdown
	Then 'days after current value' value is displayed in the 'Units' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckMailboxesAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope         | Run    |
	| 182483_Automation | 18248       | true     | false              | All Mailboxes | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action3' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Mailbox Evergreen Capacity Project' option from 'Project' autocomplete
	When User selects '1 \ Completed' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                                   |
	| Update                                    |
	| Update relative to current value          |
	| Update relative to now                    |
	| Update relative to a different task value |
	| Remove                                    |
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '3' text to 'Value' textbox
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action3" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Mailbox Evergreen Capacity Project' content is displayed in 'Project' textbox
	Then '1 \ Completed' content is displayed in 'Task' textbox
	Then '3' content is displayed in 'Value' textbox
	Then 'days before current value' value is displayed in the 'Units' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18248 @DAS18276 @DAS19117 @DAS19274 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUsersAutomationsUpdateRelativeToCurrentValue
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 182484_Automation | 18248       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18248_Action4' text to 'Action Name' textbox
	And User selects 'Update task value' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project' autocomplete
	When User selects 'Project Dates \ Forecast Date' option from 'Task' autocomplete
	Then inline error banner is not displayed
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	When User enters '0' text to 'Value' textbox
	Then User sees '0 to 100,000' hint below 'Value' field
	Then '0' content is displayed in 'Value' autocomplete
	Then following Values are displayed in the 'Units' dropdown:
	| Options             |
	| days before now     |
	| days after now      |
	| weekdays before now |
	| weekdays after now  |
	| hours before now    |
	| hours after now     |
	When User enters '4' text to 'Value' textbox
	When User selects 'hours before now' in the 'Units' dropdown
	And User clicks 'CREATE' button
	#Check created Action
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then "18248_Action4" content is displayed in "Action Name" field
	Then 'Update task value' content is displayed in 'Action Type' dropdown
	Then 'Barry's User Project' content is displayed in 'Project' textbox
	Then 'Project Dates \ Forecast Date' content is displayed in 'Task' textbox
	Then '4' content is displayed in 'Value' textbox
	Then 'hours before now' value is displayed in the 'Units' dropdown
	Then 'Update relative to now' value is displayed in the 'Update Date' dropdown