Feature: FiltersFunctionalityPart13
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS10020
Scenario: EvergreenJnr_DevicesList_CheckDeviceOwnerLDAPColumnsAndFilters
	When User add following columns using URL to the "Devices" page:
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Display Name" filter
	When User select "Empty" Operator value
	And User clicks Save filter button
	Then "460" rows are displayed in the agGrid
	Then Content is empty in the column
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |
	When User clicks on 'Owner title' column header
	Then Content is empty in the column
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |