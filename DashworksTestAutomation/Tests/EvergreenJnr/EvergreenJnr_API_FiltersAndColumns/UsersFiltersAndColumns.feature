Feature: UsersFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Users @API @FiltersAndColumns
Scenario: EvergreenJnr_UsersList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Users' list
	Then All columns with correct data are returned from the API for 'Users' list

#Remove Not_Run when queries will be added
@Evergreen @Users @API @FiltersAndColumns @Not_Run
Scenario: EvergreenJnr_UsersList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for 'UsersQueryUrls' requests

@Evergreen @Users @API @FiltersAndColumns @API @DAS14629 @DAS14663 @DAS14629
Scenario: EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersList
Then following operators are displayed in "User" category for "Primary Device" filter on "Users" page:
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

@Evergreen @Users @API @FiltersAndColumns @API @DAS15899
Scenario: EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists
	Then the following filter subcategories are displayed for 'Project Tasks: DeviceSche' category on 'Users' page:
	| value                                       |
	| DeviceSche: Stage 2 \ user DDL task         |
	| DeviceSche: Stage 2 \ user radiobutton task |
	| DeviceSche: Stage 2 \ user text task        |
