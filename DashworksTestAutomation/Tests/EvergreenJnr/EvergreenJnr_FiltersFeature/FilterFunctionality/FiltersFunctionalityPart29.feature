Feature: FiltersFunctionalityPart29
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_FiltersFeature @NewFilterCheck @DAS12232 @DAS12351 @DAS14288
Scenario: EvergreenJnr_UsersList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| Started            |
	| Failed             |
	| Complete           |
	And User Add And "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	Then "4,641" rows are displayed in the agGrid
	When User create dynamic list with "Users_ProjectTaskFilters_AND" name on "Users" page
	Then "Users_ProjectTaskFilters_AND" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User navigates to the "Users_ProjectTaskFilters_AND" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page is Not Applicable, Started, Failed or Complete" is displayed in added filter info
	And "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent is Not Applicable" is displayed in added filter info
	When User click Edit button for "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page" filter
	And User select "Does not equal" Operator value
	And User change selected checkboxes:
	| Option         | State |
	| Not Applicable | false |
	| Not Started    | true  |
	| Started        | true  |
	| Failed         | true  |
	| Complete       | true  |
	And User click Edit button for "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent" filter
	And User change selected checkboxes:
	| Option         | State |
	| Not Applicable | true  |
	| Not Sent       | false |
	| Sent           | true  |
	Then "4,642" rows are displayed in the agGrid
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button

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

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18875 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckStickyComplianceFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Sticky Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	When User creates 'DAS18875_list' dynamic list
	Then "DAS18875_list" list is displayed to user
	When User clicks the Filters button
	Then "Sticky Compliance is Red" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckTargetAppFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "1803: Target App" filter where type is "Equals" with added column and Lookup option
	| SelectedValues      |
	| Multi Edit 9 Client |
	When User creates 'DAS18875_list' dynamic list
	Then "DAS18875_list" list is displayed to user
	When User clicks the Filters button
	Then "1803: Target App is Multi Edit 9 Client" is displayed in added filter info