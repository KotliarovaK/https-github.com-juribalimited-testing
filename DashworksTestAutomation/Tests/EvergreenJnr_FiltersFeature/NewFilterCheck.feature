#@retry:3
Feature: NewFilterCheck
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS-10828
Scenario Outline: EvergreenJnr_ApplicationsList_Check that Target App filter is added to the list
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

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS-10828
Scenario Outline: EvergreenJnr_ApplicationsList_Check that Target App Key filter is added to the list
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

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS-10828
Scenario Outline: EvergreenJnr_ApplicationsList_Check that Target App Readiness filter is added to the list
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