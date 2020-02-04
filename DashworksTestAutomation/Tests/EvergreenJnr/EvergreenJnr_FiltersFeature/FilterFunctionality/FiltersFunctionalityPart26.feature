Feature: FiltersFunctionalityPart26
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppFilterIsAddedToTheList
	When User add following columns using URL to the "Applications" page:
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
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples:
	| ColumnName             | Operators                         | FilterOption      | Text                                        | RowsCount |
	| Windows7Mi: Target App | Equals, Does not equal, Not empty | WebZIP (A01)      | Windows7Mi: Target App is WebZIP (A01)      | 3         |
	| Babel(Engl: Target App | Equals, Does not equal, Not empty | sndconfig         | Babel(Engl: Target App is sndconfig         | 1         |
	| Barry'sUse: Target App | Equals, Does not equal, Not empty | World Watch (A01) | Barry'sUse: Target App is World Watch (A01) | 1         |
	| ComputerSc: Target App | Equals, Does not equal, Not empty | World Watch (A01) | ComputerSc: Target App is World Watch (A01) | 1         |
	| Havoc(BigD: Target App | Equals, Does not equal, Not empty | WebZIP (A01)      | Havoc(BigD: Target App is WebZIP (A01)      | 1         |
	| MigrationP: Target App | Equals, Does not equal, Not empty | Zune (A01)        | MigrationP: Target App is Zune (A01)        | 1         |
	| UserSchedu: Target App | Equals, Does not equal, Not empty | Zune (A01)        | UserSchedu: Target App is Zune (A01)        | 1         |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828 @DAS14287
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppKeyFilterIsAddedToTheList
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
	When User have create "Equals" Values filter with column and following options:
	| Values         |
	| <FilterOption> |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples:
	| ColumnName                 | Operators                                                                                        | FilterOption | Text                               | RowsCount |
	| Windows7Mi: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1051         | Windows7Mi: Target App Key is 1051 | 4         |
	| Babel(Engl: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 15           | Babel(Engl: Target App Key is 15   | 1         |
	| Barry'sUse: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 115          | Barry'sUse: Target App Key is 115  | 1         |
	| ComputerSc: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1060         | ComputerSc: Target App Key is 1060 | 1         |
	| Havoc(BigD: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1050         | Havoc(BigD: Target App Key is 1050 | 1         |
	| MigrationP: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 960          | MigrationP: Target App Key is 960  | 1         |
	| UserSchedu: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1            | UserSchedu: Target App Key is 1    | 1         |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppReadinessFilterIsAddedToTheList
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
	| ColumnName                       | Operators                         | FilterOption | Text                                      | RowsCount |
	| Windows7Mi: Target App Readiness | Equals, Does not equal, Not empty | Red          | Windows7Mi: Target App Readiness is Red   | 28        |
	| Babel(Engl: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Babel(Engl: Target App Readiness is Empty | 1,921     |
	| Barry'sUse: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Target App Readiness is Empty | 1,145     |
	| ComputerSc: Target App Readiness | Equals, Does not equal, Not empty | Green        | ComputerSc: Target App Readiness is Green | 913       |
	| Havoc(BigD: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Target App Readiness is Empty | 1,155     |
	| MigrationP: Target App Readiness | Equals, Does not equal, Not empty | Blue         | MigrationP: Target App Readiness is Blue  | 189       |
	| UserSchedu: Target App Readiness | Equals, Does not equal, Not empty | Grey         | UserSchedu: Target App Readiness is Grey  | 981       |

	@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS12388
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxIsDisplayedForTargetAppKeyFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes        |
	| Add Target App Key column |

Examples:
	| FilterName                 |
	| Windows7Mi: Target App Key |
	| Babel(Engl: Target App Key |
	| Barry'sUse: Target App Key |
	| ComputerSc: Target App Key |
	| Havoc(BigD: Target App Key |
	| MigrationP: Target App Key |
	| UserSchedu: Target App Key |
	| prK: Target App Key        |