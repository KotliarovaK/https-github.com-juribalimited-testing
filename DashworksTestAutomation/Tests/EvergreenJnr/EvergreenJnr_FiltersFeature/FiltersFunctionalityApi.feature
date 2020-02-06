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

@Evergreen @Users @Evergreen_FiltersFeature @NewFilterCheck @API @DAS14629 @DAS14663 @DAS14629
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10776
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

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS13831
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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17579
Scenario: EvergreenJnr_ApplicationsList_CheckUserPostalCodeOptionsDisplaying
	Then following operators are displayed in "User Location" category for "User Postal Code" filter on "Applications" page:
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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194 @DAS16485
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerCustomItemHasCorrectFilterOptions
	Then following operators are displayed in "Device Owner Custom Fields" category for "Device Owner Zip Code" filter on "Applications" page:
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