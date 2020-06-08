Feature: AutomationsCriticality
	Runs Criticality Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18674 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsVisible
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 18674_Automation | 18674       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18727_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown
	Then following Values are displayed in the 'Criticality' dropdown:
	| Options       |
	| No change     |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	Then 'CREATE' button is disabled
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'CREATE' button has tooltip with 'Select at least one value to change' text
	Then 'SAVE & CREATE ANOTHER' button has tooltip with 'Select at least one value to change' text
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then following Values are displayed in the 'Criticality' dropdown:
	| Options       |
	| No change     |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18674 @DAS21240 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomations
	When User creates new Automation via API and open it
	| Name                  | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 18674_Test_Automation | 18674       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18727_Action1' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Core' in the 'Criticality' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Criticality" content is displayed for "Task or Field" column
	Then "Update application attributes" content is displayed for "Type" column
	Then "Core" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '18727_Action1' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'Core' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19311 @DASDAS19601 @DAS19150 @DAS21240 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalitySavingAndRestoringValuesForEvergreen
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 19311_Automation | 19311       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19311_Action1' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'FALSE' in the 'In Catalog' dropdown
	When User selects 'Critical' in the 'Criticality' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "" content is displayed for "Project" column
	Then "Sticky Compliance, In Catalog, Criticality, Rationalisation, Hide From End Users" content is displayed for "Task or Field" column
	Then "Red, False, Critical, Keep, True" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action1' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'RED' content is displayed in 'Sticky Compliance' dropdown
	Then 'KEEP' content is displayed in 'Rationalisation' dropdown
	Then 'FALSE' content is displayed in 'In Catalog' dropdown
	Then 'Critical' content is displayed in 'Criticality' dropdown
	Then 'TRUE' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button has tooltip with 'No changes made' text
	Then 'UPDATE' button is disabled
	#Restoring values
	When User selects 'GREEN' in the 'Sticky Compliance' dropdown
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'FALSE' in the 'Hide From End Users' dropdown
	When User clicks 'UPDATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "" content is displayed for "Project" column
	Then "Sticky Compliance, In Catalog, Criticality, Rationalisation, Hide From End Users" content is displayed for "Task or Field" column
	Then "Green, True, Core, Retire, False" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action1' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'GREEN' content is displayed in 'Sticky Compliance' dropdown
	Then 'RETIRE' content is displayed in 'Rationalisation' dropdown
	Then 'TRUE' content is displayed in 'In Catalog' dropdown
	Then 'Core' content is displayed in 'Criticality' dropdown
	Then 'FALSE' content is displayed in 'Hide From End Users' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19311 @DAS19353 @DASDAS19601 @DAS19150 @DAS21240 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalitySavingAndRestoringValuesForProject
	When User creates new Automation via API and open it
	| Name                  | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 19311_Test_Automation | 19311       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19311_Action2' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'Important' in the 'Criticality' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "USE ME FOR AUTOMATION(DEVICE SCHDLD)" content is displayed for "Project" column
	Then "Criticality, Rationalisation, Hide From End Users" content is displayed for "Task or Field" column
	Then "Important, Keep, True" content is displayed for "Value" column
	When User opens 'Action' column settings
	When User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Update Type" checkbox on the Column Settings panel
	Then "" content is displayed for "Update Type" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action2' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' content is displayed in 'Project or Evergreen' autocomplete
	Then 'KEEP' content is displayed in 'Rationalisation' dropdown
	Then 'Important' content is displayed in 'Criticality' dropdown
	Then 'TRUE' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button has tooltip with 'No changes made' text
	Then 'UPDATE' button is disabled
	#Restoring values
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'FALSE' in the 'Hide From End Users' dropdown
	When User clicks 'UPDATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "USE ME FOR AUTOMATION(DEVICE SCHDLD)" content is displayed for "Project" column
	Then "Criticality, Rationalisation, Hide From End Users" content is displayed for "Task or Field" column
	Then "Core, Uncategorised, False" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action2' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' content is displayed in 'Project or Evergreen' autocomplete
	Then 'UNCATEGORISED' content is displayed in 'Rationalisation' dropdown
	Then 'Core' content is displayed in 'Criticality' dropdown
	Then 'FALSE' content is displayed in 'Hide From End Users' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19312 @DAS19566 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityRunNow
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                  |
	| Microsoft Office XP SP1 |
	When User clicks the Actions button
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList19312" name
	When User refreshes agGrid
	Then "StaticList19312" list is displayed to user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope           | Run    |
	| 19312_Automation | 19312       | true     | false              | StaticList19312 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19312_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'CREATE' button
	#Run Automations
	When User clicks 'Automations' header breadcrumb
	When User enters "19312_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19312_Automation' item from 'Automation' column
	When '19312_Automation' automation '19312_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User refreshes agGrid
	When User enters "19312_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then 'Core' content is displayed in the 'UseMeForAu: Criticality' column
	Then 'KEEP' content is displayed in the 'UseMeForAu: Rationalisation' column
	Then 'TRUE' content is displayed in the 'UseMeForAu: Hide From End Users' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19312 @DAS19566 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityRunNowForEvergreen
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values  |
	| TIFNY 3 |
	When User clicks the Actions button
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User refreshes agGrid
	When User create static list with "TestList19312" name
	Then "TestList19312" list is displayed to user
	When User creates new Automation via API and open it
	| Name                  | Description | IsActive | StopOnFailedAction | Scope         | Run    |
	| Test_19312_Automation | test19312   | true     | false              | TestList19312 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19312_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User clicks 'CREATE' button
	#Run Automations
	When User clicks 'Automations' header breadcrumb
	When User enters "Test_19312_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'Test_19312_Automation' item from 'Automation' column
	When 'Test_19312_Automation' automation '19312_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User refreshes agGrid
	When User enters "Test_19312_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	When User clicks content from "Objects" column
	Then 'All Applications' list should be displayed to the user
	Then 'Core' content is displayed in the 'Criticality' column
	Then 'RED' content is displayed in the 'Sticky Compliance' column
	Then 'KEEP' content is displayed in the 'Evergreen Rationalisation' column
	Then 'TRUE' content is displayed in the 'In Catalog' column
	Then 'TRUE' content is displayed in the 'Hide From End Users' column