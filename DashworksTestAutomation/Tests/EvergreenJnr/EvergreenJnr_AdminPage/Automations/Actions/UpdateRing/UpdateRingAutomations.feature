Feature: UpdateRingAutomations
	Runs Update Ring Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17556 @Cleanup @Wormhole
Scenario Outline: EvergreenJnr_AdminPage_CheckActionTypeDropdownValuesForMainListsType
	When User creates new Automation via API and open it
	| AutomationName        | Description | Active | StopOnFailedAction | Scope      | Run    |
	| Test_Automation_17556 | 17556       | true   | false              | <ListName> | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	Then following Values are displayed in the 'Action Type' dropdown:
	| Values              |
	| Update bucket       |
	| Update custom field |
	| Update path         |
	| Update ring         |
	| Update task value   |
		 
Examples:
	| ListName      |
	| All Devices   |
	| All Users     |
	| All Mailboxes |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17556 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckActionTypeDropdownValuesForApplicationsLists
	When User creates new Automation via API and open it
	| AutomationName      | Description | Active | StopOnFailedAction | Scope            | Run    |
	| AppAutomation_17556 | 17556       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	Then following Values are displayed in the 'Action Type' dropdown:
	| Values                        |
	| Update bucket                 |
	| Update application attributes |
	| Update custom field           |
	| Update path                   |
	| Update task value             |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17556 @Cleanup @Wormhole
Scenario Outline: EvergreenJnr_AdminPage_CheckAlsoMoveUsersFunctionality
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope      | Run    |
	| 17556_Automation | 17556       | true   | false              | <ListName> | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17556_Action' text to 'Action Name' textbox
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	Then 'None' content is displayed in 'Also Move Users' dropdown
	When User selects 'None' in the 'Also Move Users' dropdown
	Then 'CREATE' button is not disabled

Examples:
	| ListName      |
	| All Devices   |
	| All Mailboxes |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17556 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckAlsoMoveDevicesAndMailboxesFunctionality
	When User creates new Automation via API and open it
	| AutomationName         | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17556_Automation_Users | 17556       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17556_Action' text to 'Action Name' textbox
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	Then 'Also Move Devices' dropdown is not displayed
	Then 'CREATE' button is not disabled
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then '' content is displayed in 'Ring' textbox
	When User selects 'Unassigned' option from 'Ring' autocomplete
	Then 'None' content is displayed in 'Also Move Devices' dropdown
	Then 'None' content is displayed in 'Also Move Mailboxes' dropdown
	When User selects 'None' in the 'Also Move Devices' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17556 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckEditActionPageForUpdateRing
	When User creates new Automation via API and open it
	| AutomationName        | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17556_Automation_Ring | 17556       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17556_Action' text to 'Action Name' textbox
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	When User clicks 'CREATE' button
	#Check Action Grid
	Then 'Update ring' content is displayed in the 'Type' column
	Then 'Ring' content is displayed in the 'Task or Field' column
	Then 'Unassigned, All linked devices, Owned mailboxes only' content is displayed in the 'Value' column
	#Check Edit Action Page
	When User clicks 'Administration' header breadcrumb
	#When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "17556_Automation_Ring" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'Update ring' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'Unassigned' content is displayed in 'Ring' autocomplete
	Then 'All linked devices' content is displayed in 'Also Move Devices' dropdown
	Then 'Owned mailboxes only' content is displayed in 'Also Move Mailboxes' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19083 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateRingForEvergreenAllLinkedDevices
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 00C8BC63E7424A6E862 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList19083" name
	Then "TestList19083" list is displayed to user
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope         | Run    |
	| 19083_Automation | 19083       | true   | false              | TestList19083 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '19083_Action' text to 'Action Name' textbox
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'SY_Ring 1' option from 'Ring' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19083_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19083_Automation' item from 'Automation' column
	When '19083_Automation' automation '19083_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "19083_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'SY_Ring 1' content is displayed in the 'Evergreen Ring' column
		#Revert changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19083_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "19083_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19083_Automation' item from 'Automation' column
	When '19083_Automation' automation '19083_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "19083_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'Unassigned' content is displayed in the 'Evergreen Ring' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19083 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateRingForProjects
	#Create list
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 00C8BC63E7424A6E862 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "AutoTestList19083" name
	Then "AutoTestList19083" list is displayed to user
	#Create Project
	When Project created via API and opened
	| ProjectName     | Scope             | ProjectTemplate | Mode               |
	| NewProject19083 | AutoTestList19083 | None            | Standalone Project |
	#Create Ring
	When User navigates to the 'Rings' left menu item
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters 'TestRing19083' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	Then 'The ring has been created' text is displayed on inline success banner
	#Create Automation
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope             | Run    |
	| 19083_Automation | 19083       | true   | false              | AutoTestList19083 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '19083_Action' text to 'Action Name' textbox
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'SY_Ring 1' option from 'Ring' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19083_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19083_Automation' item from 'Automation' column
	When '19083_Automation' automation '19083_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "19083_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'SY_Ring 1' content is displayed in the 'Evergreen Ring' column