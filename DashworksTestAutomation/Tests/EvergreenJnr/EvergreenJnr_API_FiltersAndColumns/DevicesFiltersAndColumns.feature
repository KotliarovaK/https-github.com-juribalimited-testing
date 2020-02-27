Feature: DevicesFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Devices @API @FiltersAndColumns
Scenario: EvergreenJnr_DevicesList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Devices' list
	Then All columns with correct data are returned from the API for 'Devices' list

#sz: removed NotRun tag.
@Evergreen @Devices @API @FiltersAndColumns
Scenario: EvergreenJnr_DevicesList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for 'DevicesQueryUrls' requests

@Evergreen @Devices @API @FiltersAndColumns @DAS11550 @DAS11749 @DAS9583
Scenario Outline: EvergreenJnr_DevicesList_CheckThatOperatorInSelectedFilterIsDisplayedCorrectlyAPI
	Then following operators are displayed in "<CategoryName>" category for "<FilterName>" filter on "Devices" page:
	| OperatorValues      |
	| Equals              |
	| Does not equal      |
	| Contains            |
	| Does not contain    |
	| Begins with         |
	| Does not begin with |
	| Ends with           |
	| Does not end with   |
	| Empty               |
	| Not empty           |

Examples:
	| CategoryName              | FilterName                  |
	| Application               | Application Name            |
	| Application Custom Fields | App field 1                 |
	| Application Custom Fields | Application Owner           |
	| Application Custom Fields | General information field 1 |
	| Application Custom Fields | App field 2                 |

@Evergreen @Devices @API @FiltersAndColumns @DAS10776
Scenario: EvergreenJnr_DevicesList_CheckThatEmptyAndNotEmptyOptionsIsAvaildableForObjectKeyFilter
	Then following operators are displayed in "Computer AD Object" category for "AD Object Key" filter on "Devices" page:
	| OperatorValues           |
	| Equals                   |
	| Does not equal           |
	| Greater than             |
	| Greater than or equal to |
	| Less than                |
	| Less than or equal to    |
	| Empty                    |
	| Not empty                |

@Evergreen @Devices @API @FiltersAndColumns @DAS13831
Scenario: EvergreenJnr_DevicesList_CheckThatDateFilterContainsBetweenOperator
	Then following operators are displayed in "Device" category for "Build Date" filter on "Devices" page:
	| OperatorValues            |
	| Equals                    |
	| Equals (relative)         |
	| Does not equal            |
	| Between                   |
	| Does not equal (relative) |
	| Before                    |
	| Before (relative)         |
	| On or before              |
	| On or before (relative)   |
	| After                     |
	| After (relative)          |
	| On or after               |
	| On or after (relative)    |
	| Empty                     |
	| Not empty                 |

@Evergreen @Devices @API @FiltersAndColumns @DAS17413
Scenario Outline: EvergreenJnr_DevicesList_CheckThatDeviceDepartmentHasCorrectFilterOperators
	Then following operators are displayed in "<Category>" category for "<Filter>" filter on "Devices" page:
	| OperatorValues      | 
	| Equals              |
	| Does not equal      |
	| Not empty           |

	Examples: 
	| Category                  | Filter                   |
	| Organisation              | Department               |
	| Device Owner Organisation | Owner Department Level 1 |
