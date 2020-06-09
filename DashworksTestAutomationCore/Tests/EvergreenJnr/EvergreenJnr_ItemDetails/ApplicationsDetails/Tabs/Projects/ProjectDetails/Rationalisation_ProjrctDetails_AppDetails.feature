Feature: Rationalisation_ProjrctDetails_AppDetails
		Runs related tests for Rationalisation field in Project mode

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20949
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorrectlyInProjectMode
	When User navigates to the 'Application' details page for the item with '983' ID
	Then Details page for 'Mozilla Sunbird (0.2a.)' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |