Feature: EvergreenOwned
	Runs Evergreen Owned related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18198
Scenario: EvergreenJnr_UsersList_CheckThatEvergreenOwnedSubtabIsDisplayedCorrectly
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for "ZZP911429" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Evergreen Owned" sub-menu on the Details page
	Then "No applications owned by this user" message is displayed on the Details Page
#remove comment and update test when data will be added
	#Then following columns are displayed on the Item details page:
	#| ColumnName  |
	#| Application |
	#| Vendor      |
	#| Version     |
	#| Compliance  |
	#Then Rows counter contains "(.*)" found row of all rows