Feature: UsersFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Users @API @FiltersAndColumns
Scenario: EvergreenJnr_UsersList_CheckAllColumns 
	Then All columns with correct data are returned from the API for 'Users' list

@Evergreen @Users @API @FiltersAndColumns
Scenario: EvergreenJnr_UsersList_CheckAllFilters 
	Then All filters with correct data are returned from the API for 'Users' list

@Evergreen @Users @API @FiltersAndColumns @DAS19261
Scenario Outline: EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseData
Then Positive number of results returned for requests:
	| FilterCategory   | FilterName   | QueryString   |
	| <FilterCategory> | <FilterName> | <QueryString> |

Examples: 
	| FilterCategory | FilterName                            | QueryString                                                                                                                                   |
	| Application    | App Count (Installed on Owned Device) | users?$filter=(installedApplications%20%3D%201)&$select=username,directoryName,displayName,fullyDistinguishedObjectName,installedApplications |
	| Suggested      | Display Name                          | users?$filter=(displayName%20EQUALS%20('Jeremiah%20S.%20O''Connor'))                                                                          |