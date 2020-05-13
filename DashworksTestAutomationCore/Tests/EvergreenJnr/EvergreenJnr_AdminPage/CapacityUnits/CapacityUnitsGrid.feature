Feature: CapacityUnitsGrid
	Capacity Units Grid

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13169 @DAS13168 @DAS12632 @DAS13012
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	Then data in the table is sorted by "Capacity Unit" column in ascending order by default
	When User clicks Reset Filters button on the Admin page
	Then data in the table is sorted by "Capacity Unit" column in ascending order by default
	When User navigates to the 'Buckets' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Evergreen Icon is displayed to the user
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	Then 'Evergreen' content is displayed in the 'Project' column
	Then 'Evergreen' checkbox is checked in the filter dropdown for the 'Project' column

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12921
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessages
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName          |
	| Evergreen Capacity Unit 1 |
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button
	Then 'This unit will be permanently deleted and any objects within it reassigned to the default unit' text is displayed on inline tip banner
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName          |
	| Evergreen Capacity Unit 2 |
	And User clicks 'DELETE' button
	Then 'These units will be permanently deleted and any objects within them reassigned to the default unit' text is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS14070
Scenario: EvergreenJnr_AdminPage_ChecksThatSumOfObjectsInApplicationsListIsCorrect
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	Then numbers sum in the 'Applications' column is equal to '2223'