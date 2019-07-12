Feature: UsersFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Users @EvergreenJnr_Columns @API
Scenario: EvergreenJnr_UsersList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Users' list
	Then All columns with correct data are returned from the API for 'Users' list

#Remove Not_Run when queries will be added
@Evergreen @Users @EvergreenJnr_Columns @API @Not_Run
Scenario: EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for 'UsersQueryUrls' requests
