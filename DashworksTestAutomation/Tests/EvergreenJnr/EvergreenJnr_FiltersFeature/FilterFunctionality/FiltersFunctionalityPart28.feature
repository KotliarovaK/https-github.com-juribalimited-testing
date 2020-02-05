Feature: FiltersFunctionalityPart28
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS12232 @DAS12351 @DAS12639 @DAS14288
Scenario: EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Migration \ Values but no RAG" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| One                |
	| Three              |
	And User Add And "UserSchedu: One \ Radio Rag Date Comp" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| Started            |
	| Failed             |
	| Complete           |
	Then "233" rows are displayed in the agGrid
	When User create dynamic list with "Devices_ProjectTaskFilters_AND" name on "Devices" page
	Then "Devices_ProjectTaskFilters_AND" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Devices_ProjectTaskFilters_AND" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Migration \ Values but no RAG is One or Three" is displayed in added filter info
	And "UserSchedu: One \ Radio Rag Date Comp is Not Applicable, Started, Failed or Complete" is displayed in added filter info
	When User click Edit button for "Windows7Mi: Migration \ Values but no RAG" filter
	And User change selected checkboxes:
	| Option | State |
	| One    | false |
	| Two    | false |
	| Three  | true  |
	And User click Edit button for "UserSchedu: One \ Radio Rag Date Comp" filter
	And User select "Does not equal" Operator value
	And User change selected checkboxes:
	| Option         | State |
	| Not Applicable | true  |
	| Not Started    | false |
	| Started        | false |
	| Failed         | false |
	| Complete       | false |
	Then "1" rows are displayed in the agGrid
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button