@retry:1
Feature: NewFilterCheck
	Runs New filters full check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName             | Operators              | FilterOption | Text                                        | RowsCount |
	| Windows7Mi: Target App | Equals, Does not equal | WebZIP       | Windows7Mi: Target App is WebZIP (985)      | 3         |
	| Babel(Engl: Target App | Equals, Does not equal | sndconfig    | Babel(Engl: Target App is sndconfig (499)   | 1         |
	| Barry'sUse: Target App | Equals, Does not equal | World Watch  | Barry'sUse: Target App is World Watch (303) | 1         |
	| ComputerSc: Target App | Equals, Does not equal | World Watch  | ComputerSc: Target App is World Watch (303) | 1         |
	| Havoc(BigD: Target App | Equals, Does not equal | WebZIP       | Havoc(BigD: Target App is WebZIP (985)      | 1         |
	| MigrationP: Target App | Equals, Does not equal | Zune         | MigrationP: Target App is Zune (316)        | 1         |
	| UserSchedu: Target App | Equals, Does not equal | Zune         | UserSchedu: Target App is Zune (316)        | 1         |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppKeyFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                 | Operators                                                                                         | FilterOption | Text                               | RowsCount |
	| Windows7Mi: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1051         | Windows7Mi: Target App Key is 1051 | 4         |
	| Babel(Engl: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 15           | Babel(Engl: Target App Key is 15   | 1         |
	| Barry'sUse: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 115          | Barry'sUse: Target App Key is 115  | 1         |
	| ComputerSc: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1060         | ComputerSc: Target App Key is 1060 | 1         |
	| Havoc(BigD: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1050         | Havoc(BigD: Target App Key is 1050 | 1         |
	| MigrationP: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 960          | MigrationP: Target App Key is 960  | 1         |
	| UserSchedu: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1            | UserSchedu: Target App Key is 1    | 1         |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppReadinessFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                       | Operators              | FilterOption | Text                                      | RowsCount |
	| Windows7Mi: Target App Readiness | Equals, Does not equal | Red          | Windows7Mi: Target App Readiness is Red   | 28        |
	| Babel(Engl: Target App Readiness | Equals, Does not equal | None         | Babel(Engl: Target App Readiness is None  | 302       |
	| Barry'sUse: Target App Readiness | Equals, Does not equal | None         | Barry'sUse: Target App Readiness is None  | 1,045     |
	| ComputerSc: Target App Readiness | Equals, Does not equal | Green        | ComputerSc: Target App Readiness is Green | 920       |
	| Havoc(BigD: Target App Readiness | Equals, Does not equal | None         | Havoc(BigD: Target App Readiness is None  | 1,067     |
	| MigrationP: Target App Readiness | Equals, Does not equal | Blue         | MigrationP: Target App Readiness is Blue  | 189       |
	| UserSchedu: Target App Readiness | Equals, Does not equal | Grey         | UserSchedu: Target App Readiness is Grey  | 981       |

@Evergreen @AllLists @Evergreen_FiltersFeature @NewFilterCheck @DAS10578
Scenario Outline: EvergreenJnr_AllLists_CheckThatDashworksFirstSeenFilterIsAddedToTheFilterList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Dashworks First Seen |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Dashworks First Seen" filter
	Then "Equals, Does not equal, Before, After, Empty, Not empty" option is available for this filter
	When User have created "Empty" Date filter with column and "" option
	Then "Dashworks First Seen is empty" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User click on 'Dashworks First Seen' column header
	Then data in table is sorted by 'Dashworks First Seen' column in descending order 

Examples: 
	| ListName     | RowsCount |
	| Devices      | 17,225    |
	| Users        | 41,335    |
	| Applications | 2,223     |
	| Mailboxes    | 4,835     |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationReadinessFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                        | Operators              | FilterOption | Text                                       | RowsCount |
	| Windows7Mi: Application Readiness | Equals, Does not equal | Red          | Windows7Mi: Application Readiness is Red   | 27        |
	| Babel(Engl: Application Readiness | Equals, Does not equal | None         | Babel(Engl: Application Readiness is None  | 302       |
	| Barry'sUse: Application Readiness | Equals, Does not equal | None         | Barry'sUse: Application Readiness is None  | 1,072     |
	| ComputerSc: Application Readiness | Equals, Does not equal | Green        | ComputerSc: Application Readiness is Green | 913       |
	| Havoc(BigD: Application Readiness | Equals, Does not equal | None         | Havoc(BigD: Application Readiness is None  | 1,067     |
	| MigrationP: Application Readiness | Equals, Does not equal | Blue         | MigrationP: Application Readiness is Blue  | 189       |
	| UserSchedu: Application Readiness | Equals, Does not equal | None         | UserSchedu: Application Readiness is None  | 981       |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11509 @DAS11507 @DAS11509
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationRationalisationFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                              | Operators              | FilterOption  | Text                                                     | RowsCount |
	| Windows7Mi: Application Rationalization | Equals, Does not equal | RETIRE        | Windows7Mi: Application Rationalization is Retire        | 85        |
	| Babel(Engl: Application Rationalization | Equals, Does not equal | UNCATEGORISED | Babel(Engl: Application Rationalization is Uncategorised | 302       |
	| Barry'sUse: Application Rationalization | Equals, Does not equal | KEEP          | Barry'sUse: Application Rationalization is Keep          | 2         |
	| ComputerSc: Application Rationalization | Equals, Does not equal | FORWARD PATH  | ComputerSc: Application Rationalization is Forward Path  | 10        |
	| Havoc(BigD: Application Rationalization | Equals, Does not equal | UNCATEGORISED | Havoc(BigD: Application Rationalization is Uncategorised | 1,067     |
	| MigrationP: Application Rationalization | Equals, Does not equal | RETIRE        | MigrationP: Application Rationalization is Retire        | 1         |
	| UserSchedu: Application Rationalization | Equals, Does not equal | UNCATEGORISED | UserSchedu: Application Rationalization is Uncategorised | 981       |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11507
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                   | Operators              | FilterOption | Text                                    | RowsCount |
	| Windows7Mi: Core Application | Equals, Does not equal | TRUE         | Windows7Mi: Core Application is true    | 11        |
	| Babel(Engl: Core Application | Equals, Does not equal | FALSE        | Babel(Engl: Core Application is false   | 302       |
	| Barry'sUse: Core Application | Equals, Does not equal | UNKNOWN      | Barry'sUse: Core Application is Unknown | 1,146     |
	| ComputerSc: Core Application | Equals, Does not equal | FALSE        | ComputerSc: Core Application is false   | 1,033     |
	| Havoc(BigD: Core Application | Equals, Does not equal | UNKNOWN      | Havoc(BigD: Core Application is Unknown | 1,156     |
	| MigrationP: Core Application | Equals, Does not equal | FALSE        | MigrationP: Core Application is false   | 220       |
	| UserSchedu: Core Application | Equals, Does not equal | UNKNOWN      | UserSchedu: Core Application is Unknown | 1,242     |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11509 @DAS11507 @DAS11509
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                      | Operators              | FilterOption | Text                                       | RowsCount |
	| Windows7Mi: Hide from End Users | Equals, Does not equal | FALSE        | Windows7Mi: Hide from End Users is false   | 1,067     |
	| Babel(Engl: Hide from End Users | Equals, Does not equal | UNKNOWN      | Babel(Engl: Hide from End Users is Unknown | 1,921     |
	| Barry'sUse: Hide from End Users | Equals, Does not equal | FALSE        | Barry'sUse: Hide from End Users is false   | 1,077     |
	| ComputerSc: Hide from End Users | Equals, Does not equal | FALSE        | ComputerSc: Hide from End Users is false   | 1,033     |
	| Havoc(BigD: Hide from End Users | Equals, Does not equal | UNKNOWN      | Havoc(BigD: Hide from End Users is Unknown | 1,156     |
	| MigrationP: Hide from End Users | Equals, Does not equal | FALSE        | MigrationP: Hide from End Users is false   | 220       |
	| UserSchedu: Hide from End Users | Equals, Does not equal | UNKNOWN      | UserSchedu: Hide from End Users is Unknown | 1,242     |