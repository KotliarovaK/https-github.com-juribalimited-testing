Feature: FiltersFunctionalityPart27
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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
