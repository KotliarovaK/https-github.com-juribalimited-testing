Feature: FiltersFunctionalityApi
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11550 @DAS11749 @DAS9583 @API
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
