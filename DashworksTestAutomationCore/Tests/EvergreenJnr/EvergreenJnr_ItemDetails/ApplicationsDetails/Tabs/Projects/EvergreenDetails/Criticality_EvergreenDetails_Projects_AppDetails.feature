Feature: Criticality_EvergreenDetails_Projects_AppDetails
	Runs related tests for Criticality field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
@Evergreen @Applications @EvergreenJnr_ItemDetails @EvergreenDetailsTab @DAS18607 @DAS19651 @DAS19318
Scenario: EvergreenJnr_ApplicationsList_CheckThatCriticalityFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'GogoTools version 2.1.0.9' item
	Then Details page for 'GogoTools version 2.1.0.9' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |
	Then following Values are displayed in the dropdown for the 'Criticality' field:
	| Value         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	When User selects 'Important' in the dropdown for the 'Criticality' field
	Then 'Criticality successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title       | Value     |
	| Criticality | Important |
	When User selects 'Uncategorised' in the dropdown for the 'Criticality' field
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |