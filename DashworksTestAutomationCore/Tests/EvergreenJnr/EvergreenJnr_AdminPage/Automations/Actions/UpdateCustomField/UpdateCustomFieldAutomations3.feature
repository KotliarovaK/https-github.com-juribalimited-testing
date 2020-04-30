Feature: UpdateCustomFieldAutomations3
	Runs Update Custom field Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18317 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionsUpdateCustomFieldValues
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18317_Automation | 18317       | true     | false              | All Devices | Manual |
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
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18411_Automation | 18411       | true     | false              | All Devices | Manual |
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

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18705 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionsValueForDuplacatedAutomation
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 18705_Automation | 18705       | true     | false              | All Devices | Manual |
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
	When User clicks 'Duplicate' option in Cog-menu for '18705_Automation' item from 'Automation' column
	When User clicks refresh button in the browser
	When User enters "18705_Automation2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	Then "18705_Action" content is displayed in "Action Name" field
	Then 'Update custom field' content is displayed in 'Action Type' dropdown
	Then 'Phoenix Field' content is displayed in 'Custom Field' textbox
	Then 'Replace all values' content is displayed in 'Update Values' dropdown
	Then following chips value displayed for 'Value' textbox
	| ChipValue |
	| 1         |
	When User clicks 'Automations' header breadcrumb
	When User enters "18705_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	And User removes selected item

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20116 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionFinishForAutomationsWereRunningAtTheSameTime
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API
	| Name              | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| 20116_Automation1 | 20116       | true     | false              | All Devices | Manual |
	| 20116_Automation2 | 20116       | true     | false              | All Devices | Manual |
	| 20116_Automation3 | 20116       | true     | false              | All Devices | Manual |
	| 20116_Automation4 | 20116       | true     | false              | All Devices | Manual |
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "20116_Automation1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action1
	When User clicks 'CREATE ACTION' button 
	And User enters '20116_Action1' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'Phoenix' value from 'Value' textbox
	When User clicks 'CREATE' button 
	#Create Action2
	When User clicks 'Automations' header breadcrumb
	When User enters "20116_Automation2" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks 'CREATE ACTION' button 
	And User enters '20116_Action2' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'Phoenix' value from 'Value' textbox
	When User clicks 'CREATE' button
	#Create Action3
	When User clicks 'Automations' header breadcrumb
	When User enters "20116_Automation3" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks 'CREATE ACTION' button 
	And User enters '20116_Action3' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'Phoenix' value from 'Value' textbox
	When User clicks 'CREATE' button
	#Create Action4
	When User clicks 'Automations' header breadcrumb
	When User enters "20116_Automation4" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks 'CREATE ACTION' button 
	And User enters '20116_Action4' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'Phoenix' value from 'Value' textbox
	When User clicks 'CREATE' button
	#Run Automations
	When User clicks 'Automations' header breadcrumb
	When User enters "20116_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	And User selects 'Run now' in the 'Actions' dropdown
	When User clicks 'RUN' button 
	When User clicks 'RUN' button on inline tip banner
	When User navigates to the 'Automation Log' left menu item
	When '20116_Automation1' automation '20116_Action1' action run has finished
	When '20116_Automation2' automation '20116_Action2' action run has finished
	When '20116_Automation3' automation '20116_Action3' action run has finished
	When '20116_Automation4' automation '20116_Action4' action run has finished
	When User clicks refresh button in the browser
	When User enters "20116_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "Action Finish" content is displayed for "Type" column
	When User enters "20116_Automation2" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	Then "Action Finish" content is displayed for "Type" column
	When User enters "20116_Automation3" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	Then "Action Finish" content is displayed for "Type" column
	When User enters "20116_Automation4" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	Then "Action Finish" content is displayed for "Type" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20248 @DAS20388 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckErrorForRunAutomationBasedOnNotValidList
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "ComputerSc: Group Stage \ Group Computer No Request Type (Team)" filter where type is "Equals" with added column and "My Team" Lookup option
	When User refreshes agGrid
	When User create dynamic list with "20248_TestList" name on "Devices" page
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope          | Run    |
	| 20248_Automation | 20248       | true     | false              | 20248_TestList | Manual |
	Then Automation page is displayed correctly
	Then 'This list uses, or refers to a list that uses, a value of "My Team" which is not valid as an automation scope' error message is displayed for 'Scope' field
	When User navigates to the 'Actions' left menu item
	When User waits for info message disappears under 'Scope' field
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '20248_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters 'firstTest' text to 'Find Value' textbox
	When User enters 'secondTest' text to 'Replace Value' textbox
	When User clicks 'CREATE' button
	#Run Automations
	When User clicks 'Automations' header breadcrumb
	When User enters "20248_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '20248_Automation' item from 'Automation' column
	When '20248_Automation' automation run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "20248_Automation" text in the Search field for "Automation" column
	Then "LIST HAS ERRORS" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS20394 @DAS16318 @DAS20473 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckRenamedListDisplayingInAutomationLog
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Type" filter where type is "Equals" with added column and "Mobile" Lookup option
	When User refreshes agGrid
	When User create dynamic list with "16318_TestList" name on "Devices" page
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope          | Run    |
	| 16318_Automation | 16318       | true     | false              | 16318_TestList | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button 
	And User enters '16318_Action' text to 'Action Name' textbox
	And User selects 'Update custom field' in the 'Action Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters 'test12' text to 'Find Value' textbox
	When User enters 'testQa' text to 'Replace Value' textbox
	When User clicks 'CREATE' button
	#Run Automations
	When User clicks 'Automations' header breadcrumb
	When User enters "16318_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '16318_Automation' item from 'Automation' column
	When '16318_Automation' automation '16318_Action' action run has finished
	#Rename Scoped List
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "16318_TestList" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User changes list name to "Renamed_16318_TestList"
	Then "Renamed_16318_TestList" name is displayed in list details panel
	#Chaeck Scoped List name 
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User navigates to the 'Automation Log' left menu item
	When User enters "16318_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	When User opens 'Action' column settings
	When User clicks Column button on the Column Settings panel
	When User select "Scope" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
	Then "Renamed_16318_TestList" content is displayed for "Scope" column
	When User clicks content from "Scope" column
	Then "Renamed_16318_TestList" list is displayed to user