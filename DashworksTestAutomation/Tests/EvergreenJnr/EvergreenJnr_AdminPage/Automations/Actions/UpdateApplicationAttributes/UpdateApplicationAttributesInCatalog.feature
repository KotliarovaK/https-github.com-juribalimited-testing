Feature: UpdateApplicationAttributesInCatalog
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19259 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckAutomationsActionsInCatalogCreateEditPageDisplay
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 19259_Automation | 19259       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19259_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'InCatalog' dropdown is not displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' value is displayed in the 'In Catalog' dropdown
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Select at least one value to change' text
	When User selects 'TRUE ' in the 'In Catalog' dropdown
	When User clicks 'CREATE' button
	#Check Action Grid
	Then "In Catalog" content is displayed for "Task or Field" column
	When User clicks content from "Action" column
	#Check Edit Action Page
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'TRUE' value is displayed in the 'In Catalog' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text