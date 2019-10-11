Feature: ProjectOwned
	Runs Project Owned related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#this functionality is not ready yet
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17808 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatProjectOwnedSubtabIsDisplayedCorrectly
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for "ZZP911429" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Applications' left menu item
	When User navigates to the "Project Owned" sub-menu on the Details page
	Then "No applications owned by this user" message is displayed on the Details Page
	#When User navigates to the 'User' details page for 'AAH0343264' item
	#Then Details page for "AAH0343264" item is displayed to the user
	#When User switches to the "Barry's User Project" project in the Top bar on Item details page
	#When User navigates to the 'Applications' left menu item
	#When User navigates to the "Project Owned" sub-menu on the Details page
	#Then Rows counter contains "3" found row of all rows
#remove comment and update test when data will be added
	#Then following columns are displayed on the Item details page:
	#| ColumnName           |
	#| Current App          |
	#| Vendor               |
	#| Version              |
	#| Target App           |
	#| Rationalisation      |
	#| Target App Core      |
	#| Target App Readiness |
	#| Path                 |
	#| Category             |
	#| Workflow             |
	#| Date                 |
	#| App Readiness        |
	#| Project Stages       |