Feature: DevicesFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Devices @API @FiltersAndColumns
Scenario: EvergreenJnr_DevicesList_CheckAllColumns 
	Then All columns with correct data are returned from the API for 'Devices' list

@Evergreen @Devices @API @FiltersAndColumns
Scenario: EvergreenJnr_DevicesList_CheckAllFilters 
	Then All filters with correct data are returned from the API for 'Devices' list

@Evergreen @Devices @API @FiltersAndColumns
Scenario Outline: EvergreenJnr_DevicesList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for requests:
	| FilterCategory   | FilterName   | QueryString   |
	| <FilterCategory> | <FilterName> | <QueryString> |

Examples: 
	| FilterCategory | FilterName           | QueryString                                                                                                                                                                     |
	| Suggested      | Windows7Mi: Category | devices?$filter=(project_1_subCategoryId%20EQUALS%20('NULL'%2C'76'))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,project_1_subCategoryId,project_1_subCategory |
