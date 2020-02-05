Feature: FiltersFunctionalityPart29
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @Evergreen_FiltersFeature @NewFilterCheck @DAS11830 @DAS14288
Scenario Outline: EvergreenJnr_AllLists_CheckThatOptionsIsAvailableForFiltersOfProjectTaskCategories
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "Empty, Off, On" checkbox is available for this filter

Examples:
	| PageName     | FilterName                           |
	| Users        | ComputerSc: One \ User Off/On        |
	| Devices      | ComputerSc: One \ Computer Off/On    |
	| Applications | ComputerSc: One \ Application Off/On |

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS16726 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewCurrentAndLastSeenFiltersAreAvailableForSelection
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Current             |
	| Dashworks Last Seen |
	And User clicks the Filters button
	And User add "Current" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User add "Dashworks Last Seen" filter where type is "Equals" with added column and "25 Jul 2019" Date filter
	And User creates 'TestNewColumnsAndFilters' dynamic list
	Then "TestNewColumnsAndFilters" list is displayed to user