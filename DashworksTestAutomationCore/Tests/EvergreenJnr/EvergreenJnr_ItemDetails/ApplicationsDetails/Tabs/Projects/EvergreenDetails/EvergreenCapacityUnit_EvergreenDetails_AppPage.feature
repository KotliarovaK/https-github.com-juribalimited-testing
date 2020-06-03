Feature: EvergreenCapacityUnit_EvergreenDetails_AppPage
	Runs related tests for Evergreen Capacity Units field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @EvergreenDetailsTab @EvergreenCapacityUnits @DAS21410 @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_ChecksThatNamesOfTheEvergreenCapacityUnitsOnTheEvergreenDetailsTabAreDisplayedAccordingToTheAdminPage
	When User navigates to the 'Application' details page for the item with '839' ID
	Then Details page for 'Access 95' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Details' left submenu item
	Then following Values are displayed in the dropdown for the 'Evergreen Capacity Unit' field:
	| Value                     |
	| Unassigned                |
	| Birmingham                |
	| Evergreen Capacity Unit 1 |
	| Evergreen Capacity Unit 2 |
	| Evergreen Capacity Unit 3 |
	| London - City             |
	| London - Southbank        |
	| Manchester                |
	| New York                  |