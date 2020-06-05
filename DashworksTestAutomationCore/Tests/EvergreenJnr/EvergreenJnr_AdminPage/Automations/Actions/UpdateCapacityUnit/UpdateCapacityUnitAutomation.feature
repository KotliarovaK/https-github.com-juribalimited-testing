Feature: UpdateCapacityUnitAutomations
	Runs Update Capacity Unit Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17288 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckAlsoMoveUsersFunctionalityForUpdateCapacityUnit
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope      | Run    |
	| <AutomationName> | 17288       | true     | false              | <ListName> | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '<ActionName>' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	Then 'None' content is displayed in 'Also Move Users' dropdown
	When User selects 'Owners only' in the 'Also Move Users' dropdown
	Then 'CREATE' button is not disabled

Examples:
	| AutomationName    | ActionName    | ListName      |
	| 17288_Automation1 | 17288_Action1 | All Devices   |
	| 17288_Automation2 | 17288_Action2 | All Mailboxes |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17288 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAlsoMoveDevicesAndMailboxesFunctionalityUpdateCapacityUnit
	When User creates new Automation via API and open it
	| Name                   | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17288_Automation_Users | 17288       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17288_Action' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	Then 'Also Move Mailboxes' dropdown is not displayed
	Then 'None' content is displayed in 'Also Move Devices' dropdown
	Then 'CREATE' button is not disabled
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then '' content is displayed in 'Capacity Unit' textbox
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	Then 'None' content is displayed in 'Also Move Devices' dropdown
	When User selects 'None' in the 'Also Move Devices' dropdown
	When User selects 'None' in the 'Also Move Mailboxes' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	Then 'CREATE' button is not disabled
	Then 'SAVE & CREATE ANOTHER' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17288 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditActionPageForUpdateCapacityUnit
	When User creates new Automation via API and open it
	| Name                | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17288_Automation_UC | 17288       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17288_Action' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	When User clicks 'CREATE' button
	#Check Action Grid
	Then 'Update capacity unit' content is displayed in the 'Type' column
	Then 'Capacity Unit' content is displayed in the 'Task or Field' column
	Then 'Unassigned, All linked devices, Owned mailboxes only' content is displayed in the 'Value' column
	#Check Edit Action Page
	When User clicks 'Administration' header breadcrumb
	When User navigates to the 'Automations' left menu item
	When User enters "17288_Automation_UC" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'Update capacity unit' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'Unassigned' content is displayed in 'Capacity Unit' autocomplete
	Then 'All linked devices' content is displayed in 'Also Move Devices' dropdown
	Then 'Owned mailboxes only' content is displayed in 'Also Move Mailboxes' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20409 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateCapacityUnitForEvergreenAllLinkedDevicesAndAllLinkedMailboxes
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	When User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList20409" name
	Then "TestList20409" list is displayed to user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope         | Run    |
	| 20409_Automation | 20409       | true     | false              | TestList20409 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '20409_Action1' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'London - City' option from 'Capacity Unit' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'All linked mailboxes' in the 'Also Move Mailboxes' dropdown
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "20409_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_Automation' item from 'Automation' column
	When '20409_Automation' automation '20409_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "20409_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'London - City' content is displayed in the 'Evergreen Capacity Unit' column
		#Revert changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "20409_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "20409_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_Automation' item from 'Automation' column
	When '20409_Automation' automation '20409_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "20409_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'Unassigned' content is displayed in the 'Evergreen Capacity Unit' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20409 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateCapacityUnitForProjects
	#Create list
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 011PLA470S0B9DJ  |
	When User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "AutoTestList20409" name
	Then "AutoTestList20409" list is displayed to user
	#Create Project
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project20409 | All Devices | None            | Standalone Project |
	Then Page with 'Project20409' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	When User expands multiselect and selects following Objects
	| Objects         |
	| 011PLA470S0B9DJ |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	#Create Automation
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope             | Run    |
	| 20409_Automation1 | 20409       | true     | false              | AutoTestList20409 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '20409_Action2' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Project20409' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "20409_Automation1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_Automation1' item from 'Automation' column
	When '20409_Automation1' automation '20409_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "20409_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'All Devices' list should be displayed to the user
	Then 'Unassigned' content is displayed in the 'Project204: Capacity Unit' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20409 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateCapacityUnitForDeletedCapacityUnit
	#Create Capacity Unit
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Capacity Unit via api
	| Name                  | Description | IsDefault |
	| TestCapacityUnit20409 | 20409       | false     |
	#Create list
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList204091" name
	Then "TestList204091" list is displayed to user
	#Create Automation
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope          | Run    |
	| 20409_2_Automation | 20409       | true     | false              | TestList204091 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '20409_Action3' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'TestCapacityUnit20409' option from 'Capacity Unit' autocomplete
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "20409_2_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_2_Automation' item from 'Automation' column
	When '20409_2_Automation' automation '20409_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "20409_2_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	#Delete Capacity Unit
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName      |
	| TestCapacityUnit20409 |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'This unit will be permanently deleted and any objects within it reassigned to the default unit' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
	Then 'The selected unit has been deleted' text is displayed on inline success banner
	#Run Automation
	When User navigates to the 'Automations' left menu item
	When User enters "20409_2_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_2_Automation' item from 'Automation' column
	When '20409_2_Automation' automation '20409_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "20409_2_Automation" text in the Search field for "Automation" column
	Then "ONE OR MORE ACTIONS FAILED" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	Then "CAPACITY UNIT DOES NOT EXIST" content is displayed for "Outcome" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then '[Capacity unit not found]' content is displayed in the 'Value' column
	When User clicks content from "Action" column
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then '[Capacity unit not found]' content is displayed in 'Capacity Unit' autocomplete
	Then 'The selected capacity unit cannot be found' error message is displayed for 'Capacity Unit' field
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	Then No error message is displayed for 'Capacity Unit' field
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20409 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateCapacityUnitForDeletedProject
	#Create list
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "120409_TestList" name
	Then "120409_TestList" list is displayed to user
	#Create Project
	When Project created via API and opened
	| ProjectName    | Scope         | ProjectTemplate | Mode               |
	| 120409_Project | All Mailboxes | None            | Standalone Project |
	Then Page with '120409_Project' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	When User expands multiselect and selects following Objects
	| Objects                          |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	#Create Automation
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope           | Run    |
	| 20409_3_Automation | 20409       | true     | false              | 120409_TestList | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '20409_Action4' text to 'Action Name' textbox
	When User selects 'Update capacity unit' in the 'Action Type' dropdown
	When User selects '120409_Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "20409_3_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_3_Automation' item from 'Automation' column
	When '20409_3_Automation' automation '20409_Action4' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "20409_3_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	#Delete Project
	When User navigates to the 'Projects' left menu item
	And User enters "120409_Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	#Run Automation
	When User navigates to the 'Automations' left menu item
	When User enters "20409_3_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20409_3_Automation' item from 'Automation' column
	When '20409_3_Automation' automation '20409_Action4' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "20409_3_Automation" text in the Search field for "Automation" column
	Then "ONE OR MORE ACTIONS FAILED" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	Then "PROJECT DOES NOT EXIST" content is displayed for "Outcome" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then '[Project not found]' content is displayed in the 'Project' column
	Then '' content is displayed in the 'Value' column
	Then '' content is displayed in the 'Task or Field' column
	When User clicks content from "Action" column
	Then '[Project not found]' content is displayed in 'Project or Evergreen' autocomplete
	#Then 'The selected project cannot be found' error message is displayed for 'Project or Evergreen' field
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	Then No error message is displayed for 'Project or Evergreen' field
	Then 'UPDATE' button is not disabled