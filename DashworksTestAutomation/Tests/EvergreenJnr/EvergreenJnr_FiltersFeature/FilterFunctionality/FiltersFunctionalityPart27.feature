Feature: FiltersFunctionalityPart27
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS12388
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxIsDisplayedForTargetAppIDFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes        |
	| Add Target App ID column |

Examples:
	| FilterName                |
	| Windows7Mi: Target App ID |
	| Babel(Engl: Target App ID |
	| Barry'sUse: Target App ID |
	| ComputerSc: Target App ID |
	| EmailMigra: Target App ID |
	| Havoc(BigD: Target App ID |
	| MigrationP: Target App ID |
	| UserSchedu: Target App ID |
	| prK: Target App ID        |

@Evergreen @AllLists @Evergreen_FiltersFeature @NewFilterCheck @DAS10578 @DAS14159
Scenario Outline: EvergreenJnr_AllLists_CheckThatDashworksFirstSeenFilterIsAddedToTheFilterList
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Dashworks First Seen |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Dashworks First Seen" filter
	Then "Equals, Equals (relative), Does not equal, Between, Does not equal (relative), Before, Before (relative), On or before, On or before (relative), After, After (relative), On or after, On or after (relative), Empty, Not empty" option is available for this filter
	When User have created "Empty" Date filter with column and "" option
	Then "Dashworks First Seen is empty" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on 'Dashworks First Seen' column header
	Then data in table is sorted by 'Dashworks First Seen' column in descending order 

Examples:
	| ListName     | RowsCount |
	| Devices      | 17,219    |
	| Users        | 41,335    |
	| Applications | 2,223     |
	| Mailboxes    | 14,784    |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationReadinessFilterIsAddedToTheList
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
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples:
	| ColumnName                        | Operators                         | FilterOption | Text                                       | RowsCount |
	| Windows7Mi: Application Readiness | Equals, Does not equal, Not empty | Red          | Windows7Mi: Application Readiness is Red   | 27        |
	| Babel(Engl: Application Readiness | Equals, Does not equal, Not empty | Empty        | Babel(Engl: Application Readiness is Empty | 1,921     |
	| Barry'sUse: Application Readiness | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Application Readiness is Empty | 1,145     |
	| ComputerSc: Application Readiness | Equals, Does not equal, Not empty | Green        | ComputerSc: Application Readiness is Green | 911       |
	| Havoc(BigD: Application Readiness | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Application Readiness is Empty | 1,155     |
	| MigrationP: Application Readiness | Equals, Does not equal, Not empty | Blue         | MigrationP: Application Readiness is Blue  | 189       |
	| UserSchedu: Application Readiness | Equals, Does not equal, Not empty | Empty        | UserSchedu: Application Readiness is Empty | 1,242     |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11509 @DAS11507 @DAS11509 @DAS12026
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationRationalisationFilterIsAddedToTheList
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
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples: 
	| ColumnName                              | Operators                         | FilterOption  | Text                                                     | RowsCount |
	| Windows7Mi: Application Rationalisation | Equals, Does not equal, Not empty | RETIRE        | Windows7Mi: Application Rationalisation is Retire        | 85        |
	#| Babel(Engl: Application Rationalisation | Equals, Does not equal | UNCATEGORISED | Babel(Engl: Application Rationalisation is Uncategorised | 302       |
	| Barry'sUse: Application Rationalisation | Equals, Does not equal, Not empty | KEEP          | Barry'sUse: Application Rationalisation is Keep          | 2         |
	| ComputerSc: Application Rationalisation | Equals, Does not equal, Not empty | FORWARD PATH  | ComputerSc: Application Rationalisation is Forward Path  | 15        |
	| Havoc(BigD: Application Rationalisation | Equals, Does not equal, Not empty | UNCATEGORISED | Havoc(BigD: Application Rationalisation is Uncategorised | 1,068     |
	| MigrationP: Application Rationalisation | Equals, Does not equal, Not empty | RETIRE        | MigrationP: Application Rationalisation is Retire        | 1         |
	| UserSchedu: Application Rationalisation | Equals, Does not equal, Not empty | UNCATEGORISED | UserSchedu: Application Rationalisation is Uncategorised | 981       |