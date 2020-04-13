Feature: InCatalog_ApplicationsPage
	Runs related tests for In Catalog field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18607
Scenario: EvergreenJnr_ApplicationsList_CheckThatInCatalogFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'GogoTools version 2.1.0.9' item
	Then Details page for 'GogoTools version 2.1.0.9' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| In Catalog  | FALSE         |
	When User selects 'TRUE' in the dropdown for the 'In Catalog' field
	Then 'In catalog successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title      | Value |
	| In Catalog | TRUE  |
	When User selects 'FALSE' in the dropdown for the 'In Catalog' field
	Then following content is displayed on the Details Page
	| Title      | Value |
	| In Catalog | FALSE |