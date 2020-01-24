Feature: AutomationsCriticality
	Runs Criticality Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18674 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckThatApplicationAttributesCriticalityForAutomationsIsVisible
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18674_Automation | 18674       | true   | false              | All Applications | Manual |
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
	Then 'SAVE AND CREATE ANOTHER' button is disabled
	Then 'CREATE' button has tooltip with 'Select at least one value to change' text
	Then 'SAVE AND CREATE ANOTHER' button has tooltip with 'Select at least one value to change' text
	When User selects '1803 Rollout' option from 'Project or Evergreen' autocomplete
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

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18674 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalityForAutomations
	When User creates new Automation via API and open it
	| AutomationName        | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18674_Test_Automation | 18674       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18727_Action' text to 'Action Name' textbox
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
	Then '18727_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'Core' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19311 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalitySavingAndRestoringValuesForEvergreen
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 19311_Automation | 19311       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19311_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'FALSE' in the 'In Catalog' dropdown
	When User selects 'Critical' in the 'Criticality' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "" content is displayed for "Project" column
	Then "Sticky Compliance, Rationalisation, In Catalog, Criticality" content is displayed for "Task or Field" column
	Then "Red, Keep, False, Critical" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'RED' content is displayed in 'Sticky Compliance' dropdown
	Then 'KEEP' content is displayed in 'Rationalisation' dropdown
	Then 'FALSE' content is displayed in 'In Catalog' dropdown
	Then 'Critical' content is displayed in 'Criticality' dropdown
	Then 'UPDATE' button has tooltip with 'No changes made' text
	Then 'UPDATE' button is disabled
	#Restoring values
	When User selects 'GREEN' in the 'Sticky Compliance' dropdown
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User selects 'Core' in the 'Criticality' dropdown
	When User clicks 'UPDATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "" content is displayed for "Project" column
	Then "Sticky Compliance, Rationalisation, In Catalog, Criticality" content is displayed for "Task or Field" column
	Then "Green, Retire, True, Core, False" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'GREEN' content is displayed in 'Sticky Compliance' dropdown
	Then 'RETIRE' content is displayed in 'Rationalisation' dropdown
	Then 'TRUE' content is displayed in 'In Catalog' dropdown
	Then 'Core' content is displayed in 'Criticality' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19311 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesCriticalitySavingAndRestoringValuesForProject
	When User creates new Automation via API and open it
	| AutomationName        | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 19311_Test_Automation | 19311       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19311_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'Important' in the 'Criticality' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "USE ME FOR AUTOMATION(DEVICE SCHDLD)" content is displayed for "Project" column
	Then "Rationalisation, Criticality" content is displayed for "Task or Field" column
	Then "Keep, Important" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' content is displayed in 'Project or Evergreen' autocomplete
	Then 'KEEP' content is displayed in 'Rationalisation' dropdown
	Then 'Important' content is displayed in 'Criticality' dropdown
	Then 'UPDATE' button has tooltip with 'No changes made' text
	Then 'UPDATE' button is disabled
	#Restoring values
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	When User selects 'Core' in the 'Criticality' dropdown
	When User clicks 'UPDATE' button
	#Actions grid check
	Then "Update application attributes" content is displayed for "Type" column
	Then "USE ME FOR AUTOMATION(DEVICE SCHDLD)" content is displayed for "Project" column
	Then "Rationalisation, Criticality" content is displayed for "Task or Field" column
	Then "Uncategorised, Core" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '19311_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' content is displayed in 'Project or Evergreen' autocomplete
	Then 'UNCATEGORISED' content is displayed in 'Rationalisation' dropdown
	Then 'Core' content is displayed in 'Criticality' dropdown