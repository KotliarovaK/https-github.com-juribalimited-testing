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
