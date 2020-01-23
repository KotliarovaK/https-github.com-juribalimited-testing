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