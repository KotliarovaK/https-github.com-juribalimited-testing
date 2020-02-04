Feature: FiltersFunctionalityPart10
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12855
Scenario: EvergreenJnr_ApplicationsList_CheckThatDataIsDisplayedCorrectlyForAdvancedUserFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Does not equal" with following Lookup Value and Association:
	| SelectedValues | Association                         |
	| FR\RZM6552051  | Owns a device which app was used on |
	Then "100" rows are displayed in the agGrid
	Then table content is present

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

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12804 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatSavedStaticListIsNotShownInEditMode
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| AU             |
	Then "Domain" filter is added to the list
	When  User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AAO798996        |
	| AGC788194        |
	| AIU705098        |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList8543" name
	Then "StaticList8543" list is displayed to user
	And Edit List menu is not displayed
	And URL contains 'evergreen/#/users?$listid='

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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13414 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatApplicationListWhichIncludeADateBasedAdvancedFilterAreSavedAndNotOpenedInEditMode
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 12 Sep 2018 | Has used app |
	Then "User whose Last Logon Date" filter is added to the list
	When User create dynamic list with "DAS13414" name on "Applications" page
	Then "DAS13414" list is displayed to user
	And URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed
	When User navigates to the "All Applications" list
	And User navigates to the "DAS13414" list
	Then URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed