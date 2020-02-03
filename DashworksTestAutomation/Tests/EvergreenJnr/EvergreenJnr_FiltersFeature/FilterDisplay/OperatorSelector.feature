Feature: OperatorSelector
	Runs operator selector related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10776
Scenario: EvergreenJnr_DevicesList_CheckThatEmptyAndNotEmptyOptionsIsAvaildableForObjectKeyFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "AD Object Key" filter
	Then "Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to, Empty, Not empty" option is available for this filter

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11660 @DAS13376 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatOperatorsForApplicationSavedListFilterIsDisplayedCorrectly
	When User add following columns using URL to the "Applications" page:
		| ColumnName |
		| Compliance |
	When User create dynamic list with "TestSavedList009" name on "Applications" page
	Then "TestSavedList009" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then "In list, Not in list" option is available for this filter

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS13831
Scenario: EvergreenJnr_DevicesList_CheckThatDateFilterContainsBetweenOperator
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Build Date" filter
	Then "Equals, Equals (relative), Does not equal, Between, Does not equal (relative), Before, Before (relative), On or before, On or before (relative), After, After (relative), On or after, On or after (relative), Empty, Not empty" option is available for this filter

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17579
Scenario: EvergreenJnr_ApplicationsList_CheckUserPostalCodeOptionsDisplaying
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And user select "User Postal Code" filter
	Then following operator options available:
		| operator            |
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
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And user select "Device Owner Zip Code" filter
	And User select "Does not equal" Operator value
	And User select "Contains" Operator value
	And User select "Does not contain" Operator value
	And User select "egins with" Operator value
	And User select "Does not begin with" Operator value
	And User select "Ends with" Operator value
	And User select "Does not end with" Operator value
	And User select "Empty" Operator value
	And User select "Not empty" Operator value