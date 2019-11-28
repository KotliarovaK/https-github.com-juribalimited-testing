Feature: ProjectOwned
	Runs Project Owned related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#upd Ann.I. 11/07/19: waiting for gold data
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17808 @DAS18408 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatProjectOwnedSubtabIsDisplayedCorrectly
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for "ZZP911429" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then 'No applications owned by this user' message is displayed on empty greed
	When User navigates to the 'User' details page for 'LYZ6880619' item
	Then Details page for "LYZ6880619 " item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then "1" rows found label displays on Details Page
	When User opens 'Current App' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Current App" checkbox on the Column Settings panel
	And User select "Target App" checkbox on the Column Settings panel
	And User select "Target App Readiness" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName      |
	| Vendor          |
	| Version         |
	| Rationalisation |
	| Target App Core |
	| Path            |
	| Category        |
	| Workflow        |
	| Date            |
	| App Readiness   |
	| Stage 3         |

#Ann.I. 11/07/19: waiting for gold data
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18700 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatRationalisationColumnIsDisplayedCorrectlyOnProjectOwnedTab 
	When User navigates to the 'User' details page for 'FWU5490440' item
	Then Details page for "FWU5490440" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then "Rationalisation" column is displayed to the user
	Then following Boolean Values are displayed in the filter dropdown for the 'Rationalisation' column
	| Values        |
	| FORWARD PATH  |
	| KEEP          |
	| UNCATEGORISED |
	When User closes Checkbox filter
	Then 'Rationalisation' column contains following content
	| Content       |
	| KEEP          |
	| UNCATEGORISED |
	| FORWARD PATH  |

	#Ann.I 11/28/19: ready only for the "terminator".
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18743 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatLinksInProjectOwnedSubtabAreWorkingCorrectly
	When User navigates to the 'User' details page for 'LYZ6880619' item
	Then Details page for "LYZ6880619 " item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	When User clicks "Quartus II 2.0 Web Edition Full" link on the Details Page
	#waiting for the switching process to Senior page to be completed
	#When User waits for three seconds
	Then Details page for "Quartus II 2.0 Web Edition Full" item is displayed to the user
	Then User click back button in the browser
	And Details page for "LYZ6880619" item is displayed to the user