Feature: FiltersFunctionalityPart10
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12807
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationFilterWorksCorrectlyForDifferentAssociationTypes
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "Application" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association         |
	| ACD Display 3.4 | Installed on device |
	Then "944" rows are displayed in the agGrid
	When User click Edit button for "Application" filter
	And User is deselect "Installed on device" Association for Application filter with Lookup value
	And User select "Not installed on device" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "16,335" rows are displayed in the agGrid
	When User have reset all filters
	And User add Advanced "Application" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association    |
	| ACD Display 3.4 | Used on device |
	Then message 'No devices found' is displayed to the user
	When User click Edit button for "Application" filter
	And User is deselect "Used on device" Association for Application filter with Lookup value
	And User select "Not used on device" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "17,279" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13104 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatAddAndButtonIsDisplayedWhenAddingTwoOrMoreFiltersUsingTheSameFieldAndClearingOneOfTheFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance is Red" is displayed in added filter info
	When User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	Then "Compliance is Green" is displayed in added filter info
	When User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance is Unknown" is displayed in added filter info
	Then Add And button is displayed on the Filter panel
	When User have removed "Compliance" filter
	Then Add And button is displayed on the Filter panel