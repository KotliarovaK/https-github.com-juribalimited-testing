Feature: CapacityUnitsGrid
	Capacity Units Grid

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13169 @DAS13168 @DAS12632 @DAS13012
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User navigates to the 'Capacity Units' left menu item
	Then "Capacity Units" page should be displayed to the user
	Then data in the table is sorted by "Capacity Unit" column in ascending order by default
	When User clicks Reset Filters button on the Admin page
	Then data in the table is sorted by "Capacity Unit" column in ascending order by default
	When User navigates to the 'Buckets' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Evergreen Icon is displayed to the user
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	And Evergreen Unit is displayed to the user
	When User clicks String Filter button for "Project" column on the Admin page
	Then "Evergreen" checkbox is checked in the filter dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12921
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessages
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User navigates to the 'Capacity Units' left menu item
	Then "Capacity Units" page should be displayed to the user
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName          |
	| Evergreen Capacity Unit 1 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This unit will be permanently deleted and any objects within it reassigned to the default unit" text is displayed on the Admin page
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName          |
	| Evergreen Capacity Unit 2 |
	And User clicks Delete button
	Then Warning message with "These units will be permanently deleted and any objects within them reassigned to the default unit" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS14070
Scenario: EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrect
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User navigates to the 'Capacity Units' left menu item
	Then "Capacity Units" page should be displayed to the user
	Then sum of objects in "Applications" list is "2223" on the Admin page