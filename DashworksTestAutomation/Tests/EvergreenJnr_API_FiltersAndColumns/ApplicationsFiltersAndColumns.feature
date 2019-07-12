Feature: ApplicationsFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Applications @EvergreenJnr_Columns @API
Scenario: EvergreenJnr_ApplicationsList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Applications' list
	Then All columns with correct data are returned from the API for 'Applications' list

#Remove Not_Run when queries will be added
@Evergreen @Applications @EvergreenJnr_Columns @API @Not_Run
Scenario: EvergreenJnr_ApplicationsList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for 'ApplicationsQueryUrls' requests