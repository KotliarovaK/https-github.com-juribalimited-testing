Feature: UpdateBucketAutomations
	Runs Update Bucket Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17339 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckAlsoMoveUsersFunctionalityForUpdateBucket
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope      | Run    |
	| <AutomationName> | 17339       | true     | false              | <ListName> | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '<ActionName>' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	Then 'None' content is displayed in 'Also Move Users' dropdown
	When User selects 'Owners only' in the 'Also Move Users' dropdown
	Then 'CREATE' button is not disabled

Examples:
	| AutomationName    | ActionName    | ListName      |
	| 17339_Automation1 | 17339_Action1 | All Devices   |
	| 17339_Automation2 | 17339_Action2 | All Mailboxes |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17339 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAlsoMoveDevicesAndMailboxesFunctionalityForUpdateBucket
	When User creates new Automation via API and open it
	| Name                   | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17339_Automation_Users | 17339       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	Then 'Edit Automation' page subheader is displayed to user
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17339_Action3' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Barry's Pilot Group 1' option from 'Bucket' autocomplete
	Then 'None' content is displayed in 'Also Move Devices' dropdown
	Then 'CREATE' button is not disabled
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then '' content is displayed in 'Bucket' textbox
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	Then 'None' content is displayed in 'Also Move Devices' dropdown
	Then 'None' content is displayed in 'Also Move Mailboxes' dropdown
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS17339 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditActionPageForUpdateBucket
	When User creates new Automation via API and open it
	| Name                    | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 17339_Automation_Bucket | 17339       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	When User enters '17339_Action4' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	When User clicks 'CREATE' button
	#Check Action Grid
	Then 'Update bucket' content is displayed in the 'Type' column
	Then 'Bucket' content is displayed in the 'Task or Field' column
	Then 'Unassigned, All linked devices, Owned mailboxes only' content is displayed in the 'Value' column
	#Check Edit Action Page
	When User clicks 'Administration' header breadcrumb
	When User navigates to the 'Automations' left menu item
	When User enters "17339_Automation_Bucket" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then 'Update bucket' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'Unassigned' content is displayed in 'Bucket' autocomplete
	Then 'All linked devices' content is displayed in 'Also Move Devices' dropdown
	Then 'Owned mailboxes only' content is displayed in 'Also Move Mailboxes' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18397 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateBucketForEvergreenAllLinkedDevicesAndAllLinkedMailboxes
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 00CFE13AAE104724AF5 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList18397" name
	Then "TestList18397" list is displayed to user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope         | Run    |
	| 18397_Automation | 18397       | true     | false              | TestList18397 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18397_Action1' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'BucketforAuto' option from 'Bucket' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'All linked mailboxes' in the 'Also Move Mailboxes' dropdown
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18397_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_Automation' item from 'Automation' column
	When '18397_Automation' automation '18397_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18397_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'BucketforAuto' content is displayed in the 'Evergreen Bucket' column
		#Revert changes to default
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18397_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	When User clicks 'UPDATE' button 
	When User clicks 'Automations' header breadcrumb
	When User enters "18397_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_Automation' item from 'Automation' column
	When '18397_Automation' automation '18397_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18397_Automation" text in the Search field for "Automation" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'Unassigned' content is displayed in the 'Evergreen Bucket' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18397 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateBucketForProjects
	#Create list
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YWR8TJU4ZF8V   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "AutoTestList18397" name
	Then "AutoTestList18397" list is displayed to user
	#Create Automation
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope             | Run    |
	| 18397_Automation1 | 18397       | true     | false              | AutoTestList18397 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18397_Action2' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'TestGroup' option from 'Bucket' autocomplete
	When User selects 'All linked users' in the 'Also Move Users' dropdown
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18397_Automation1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_Automation1' item from 'Automation' column
	When '18397_Automation1' automation '18397_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18397_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then 'TestGroup' content is displayed in the 'zDeviceAut: Bucket' column
	
@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18397 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateBucketForDeletedBucket
	#Create Bucket
	When User creates new Bucket via api
	| Name             | TeamName | IsDefault |
	| 18397_TestBucket | Admin IT | false     |
	#Create list
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 01COJATLYVAR7A6  |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "18397_TestList" name
	Then "18397_TestList" list is displayed to user
	#Create Automation
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope          | Run    |
	| 18397_2_Automation | 18397       | true     | false              | 18397_TestList | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18397_Action3' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '18397_TestBucket' option from 'Bucket' autocomplete
	When User selects 'Owners only' in the 'Also Move Users' dropdown
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18397_2_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_2_Automation' item from 'Automation' column
	When '18397_2_Automation' automation '18397_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "18397_2_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	Then '1' content is displayed in the 'Objects' column
	When User clicks content from "Objects" column
	Then '18397_TestBucket' content is displayed in the 'Evergreen Bucket' column
	#Delete Bucket
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 18397_TestBucket |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected bucket has been deleted' text is displayed on inline success banner
	#Run Automation
	When User navigates to the 'Automations' left menu item
	When User enters "18397_2_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_2_Automation' item from 'Automation' column
	When '18397_2_Automation' automation '18397_Action3' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "18397_2_Automation" text in the Search field for "Automation" column
	Then "ONE OR MORE ACTIONS FAILED" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	Then '1' content is displayed in the 'Objects' column
	Then "BUCKET DOES NOT EXIST" content is displayed for "Outcome" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then '[Bucket not found]' content is displayed in the 'Value' column
	When User clicks content from "Action" column
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then '[Bucket not found]' content is displayed in 'Bucket' autocomplete
	Then 'The selected bucket cannot be found' error message is displayed for 'Bucket' field
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	Then No error message is displayed for 'Bucket' field
	Then 'UPDATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18397 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationLogUpdateBucketForDeletedProject
	#Create list
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0105AF7E8E154E87B1A@bclabs.local |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "18397_TestList1" name
	Then "18397_TestList1" list is displayed to user
	#Create Project
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| 18397_Project | All Mailboxes | None            | Standalone Project |
	Then Page with '18397_Project' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	When User expands multiselect and selects following Objects
	| Objects                          |
	| 0105AF7E8E154E87B1A@bclabs.local |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	#Create Automation
	When User creates new Automation via API and open it
	| Name               | Description | IsActive | StopOnFailedAction | Scope           | Run    |
	| 18397_3_Automation | 18397       | true     | false              | 18397_TestList1 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '18397_Action4' text to 'Action Name' textbox
	When User selects 'Update bucket' in the 'Action Type' dropdown
	When User selects '18397_Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	When User clicks 'CREATE' button 
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18397_3_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_3_Automation' item from 'Automation' column
	When '18397_3_Automation' automation '18397_Action4' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "18397_3_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	Then '1' content is displayed in the 'Objects' column
	#Delete Project
	When User navigates to the 'Projects' left menu item
	And User enters "18397_Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	#Run Automation
	When User navigates to the 'Automations' left menu item
	When User enters "18397_3_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18397_3_Automation' item from 'Automation' column
	When '18397_3_Automation' automation '18397_Action4' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "18397_3_Automation" text in the Search field for "Automation" column
	Then "ONE OR MORE ACTIONS FAILED" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
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
	When User selects 'Amsterdam' option from 'Bucket' autocomplete
	Then No error message is displayed for 'Project or Evergreen' field
	Then 'UPDATE' button is not disabled