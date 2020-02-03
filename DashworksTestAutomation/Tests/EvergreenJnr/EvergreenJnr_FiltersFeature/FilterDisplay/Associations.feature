Feature: Associations
	Runs Associations filters related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS13376
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsFilterIsContainsAllExpectedAssociations
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then Associations is displayed in the filter
		| Associations                   |
		| Used on device                 |
		| Entitled to device             |
		| Installed on device            |
		| Used by device's owner         |
		| Entitled to device's owner     |
		| Not used on device             |
		| Not entitled to device         |
		| Not installed on device        |
		| Not used by device's owner     |
		| Not entitled to device's owner |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11187 @DAS13376
Scenario Outline: EvergreenJnr_DevicesList_CheckThatCustomFiltersAreContainsAllExpectedAssociations
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "<FilterName>" filter from "Application Custom Fields" category
	Then Associations is displayed in the filter
		| Associations                   |
		| Used on device                 |
		| Entitled to device             |
		| Installed on device            |
		| Used by device's owner         |
		| Entitled to device's owner     |
		| Not used on device             |
		| Not entitled to device         |
		| Not installed on device        |
		| Not used by device's owner     |
		| Not entitled to device's owner |

	Examples:
		| FilterName                  |
		| App field 1                 |
		| App field 2                 |
		| Application Owner           |
		| General information field 1 |
		| General information field 2 |
		| General information field 3 |
		| General information field 4 |
		| General information field 5 |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11469
Scenario Outline: EvergreenJnr_DevicesList_CheckThatAssociationSearchInFiltersPanelIsWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User enters "used" in Association search field 
	Then search values in Association section working by specific search criteria

Examples:
	| FilterName                 |
	| Application                |
	| Application Import         |
	| Application Inventory Site |
	| Application Vendor         |
	| Application Version        |
	#| Application Compliance     |
	#| Application (Saved List)   |
	#| Application Import Type    |
	#| Application Name           |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11551 @DAS11550 @DAS11749
Scenario Outline: EvergreenJnr_DevicesList_CheckThatEmptyNotEmptyOperatorsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	When User select "<OperatorValues>" Operator value
	Then Associations panel is displayed in the filter

Examples:
	| OperatorValues |
	| Empty          |
	| Not Empty      |