Feature: Relink_UserPage
	Runs Relink related tests on Users Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @User @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323 @Universe
Scenario: EvergreenJnr_UserList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'User' details page for '0231387EA0EE4B428FE' item
	Then Details page for '0231387EA0EE4B428FE' item is displayed to the user
	When User selects 'I-Computer Scheduled Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '551' are displayed in 'User' autocomplete