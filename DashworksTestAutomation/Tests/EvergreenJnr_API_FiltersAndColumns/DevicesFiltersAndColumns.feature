Feature: DevicesFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Devices @EvergreenJnr_Columns @API @FiltersAndColumns
Scenario: EvergreenJnr_DevicesList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Devices' list
	Then All columns with correct data are returned from the API for 'Devices' list

@Evergreen @Devices @EvergreenJnr_Columns @API @FiltersAndColumns
Scenario: EvergreenJnr_DevicesList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for 'DevicesQueryUrls' requests