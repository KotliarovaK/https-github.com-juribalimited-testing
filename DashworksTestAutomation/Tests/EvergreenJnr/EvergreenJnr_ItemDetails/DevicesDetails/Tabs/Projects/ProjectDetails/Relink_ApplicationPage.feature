Feature: Relink_ApplicationPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Application @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323 @Universe
Scenario: EvergreenJnr_ApplicationList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'Application' details page for '7-Zip 16.04 (x64)' item
	Then Details page for '7-Zip 16.04 (x64)' item is displayed to the user
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '230' are displayed in 'Application' autocomplete