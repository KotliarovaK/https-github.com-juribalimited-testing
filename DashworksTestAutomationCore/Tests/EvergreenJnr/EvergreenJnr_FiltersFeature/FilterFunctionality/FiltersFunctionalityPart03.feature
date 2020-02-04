Feature: FiltersFunctionalityPart03
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13201 @DAS14757
Scenario: EvergreenJnr_AllLists_CheckThatCreatedCapacityUnitCanBeUsedAsAFilterWhichReturnsCorrectItems
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	And User clicks 'CREATE EVERGREEN CAPACITY UNIT' button 
	And User enters 'CapacityUnit13201' text to 'Capacity Unit Name' textbox
	And User enters '13201' text to 'Description' textbox
	And User clicks 'CREATE' button 
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	| 01P96J2EQ0HZSV   |
	| 00KLL9S8NRF0X6   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "3" rows are displayed in the agGrid
	When User clicks 'Users' on the left-hand menu
	And User clicks the Actions button
	And User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00DBB114BE1B41B0A38 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "2" rows are displayed in the agGrid
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Actions button
	And User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0105AF7E8E154E87B1A@bclabs.local |
	| 0141713E5CF84ADE907@bclabs.local |
	| 01C4FB7C6D2C4F979BD@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "3" rows are displayed in the agGrid
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Actions button
	And User select "Application" rows in the grid
	| SelectedRowsName         |
	| 20040610sqlserverck      |
	| 7-Zip 9.20 (x64 edition) |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "2" rows are displayed in the agGrid
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit13201 |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner