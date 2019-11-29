Feature: EvergreenOwned
	Runs Evergreen Owned related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Ann.I. 11/07/19: waiting for gold data
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18198 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatEvergreenOwnedSubtabIsDisplayedCorrectly
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for "ZZP911429" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Owned' left submenu item
	Then 'No applications owned by this user' message is displayed on empty greed
	When User navigates to the 'User' details page for 'FWU5490440' item
	Then Details page for "FWU5490440 (Alain Lambert)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Owned' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	| Compliance  |
	Then Rows counter contains "3" found row of all rows

#Ann.I 11/28/19: ready only for the "terminator".
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18854 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatLinksInEvergreenOwnedSubtabAreWorkingCorrectly
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for "ZZP911429" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Owned' left submenu item
	When User clicks "DirectX 8.1 SDK for Visual Basic" link on the Details Page
	#waiting for the switching process to new Details page to be completed
	#When User waits for three seconds
	Then Details page for "DirectX 8.1 SDK for Visual Basic" item is displayed to the user
	Then User click back button in the browser
	And Details page for "ZZP911429" item is displayed to the user