Feature: FiltersFunctionalityPart30
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreeargetAppKeyFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "1803: Target App Key" filter where type is "Does not equal" with added column and following value:
	| Values |
	| 12     |
	When User creates 'DAS18875_list1' dynamic list
	Then "DAS18875_list1" list is displayed to user
	When User clicks the Filters button
	Then "1803: Target App Key is not 12" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckTargetAppVendorFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App Vendor" filter where type is "Contains" with added column and following value:
	| Values |
	| Adobe  |
	When User creates 'DAS18875_list2' dynamic list
	Then "DAS18875_list2" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App Vendor contains Adobe" is displayed in added filter info
	Then 'Adobe Systems, Inc.' content is displayed in the 'Evergreen Target App Vendor' column

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenTargetAppVersionFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App Version" filter where type is "Does not contain" with added column and following value:
	| Values    |
	| Microsoft |
	When User creates 'DAS18875_list3' dynamic list
	Then "DAS18875_list3" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App Version does not contain Microsoft" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckTargetAppReadinessFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "1803: Target App Readiness" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	When User creates 'DAS18875_list4' dynamic list
	Then "DAS18875_list4" list is displayed to user
	When User clicks the Filters button
	Then "1803: Target App Readiness is not empty" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18896 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenRationalisationFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Rationalisation" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	When User creates 'DAS18896_list' dynamic list
	Then "DAS18896_list" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Rationalisation is Uncategorised" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS19262 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenTargetAppNameFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App Name" filter where type is "Not empty" with added column and following value:
	| Values |
	When User creates 'DAS19262_list' dynamic list
	Then "DAS19262_list" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App Name is not empty" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS19262 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenTargetAppFilterWithNoTargetApplication
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App" filter where type is "Equals" with added column and "No Target Application" Lookup option
	When User creates 'DAS192621_list' dynamic list
	Then "DAS192621_list" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App is No Target Application" is displayed in added filter info