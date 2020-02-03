Feature: FiltersFunctionalityPart28
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11507
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                   | Operators                         | FilterOption | Text                                  | RowsCount |
	| Windows7Mi: Core Application | Equals, Does not equal, Not empty | TRUE         | Windows7Mi: Core Application is True  | 11        |
	| Babel(Engl: Core Application | Equals, Does not equal, Not empty | FALSE        | Babel(Engl: Core Application is False | 302       |
	| Barry'sUse: Core Application | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Core Application is Empty | 1,145     |
	| ComputerSc: Core Application | Equals, Does not equal, Not empty | FALSE        | ComputerSc: Core Application is False | 1,043     |
	| Havoc(BigD: Core Application | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Core Application is Empty | 1,155     |
	| MigrationP: Core Application | Equals, Does not equal, Not empty | FALSE        | MigrationP: Core Application is False | 220       |
	| UserSchedu: Core Application | Equals, Does not equal, Not empty | Empty        | UserSchedu: Core Application is Empty | 1,242     |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11509 @DAS11507 @DAS11509
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                      | Operators                         | FilterOption | Text                                     | RowsCount |
	| Windows7Mi: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | Windows7Mi: Hide from End Users is False | 1,067     |
	| Babel(Engl: Hide from End Users | Equals, Does not equal, Not empty | Empty        | Babel(Engl: Hide from End Users is Empty | 1,921     |
	| Barry'sUse: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | Barry'sUse: Hide from End Users is False | 1,078     |
	| ComputerSc: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | ComputerSc: Hide from End Users is False | 1,043     |
	| Havoc(BigD: Hide from End Users | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Hide from End Users is Empty | 1,155     |
	| MigrationP: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | MigrationP: Hide from End Users is False | 220       |
	| UserSchedu: Hide from End Users | Equals, Does not equal, Not empty | Empty        | UserSchedu: Hide from End Users is Empty | 1,242     |

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