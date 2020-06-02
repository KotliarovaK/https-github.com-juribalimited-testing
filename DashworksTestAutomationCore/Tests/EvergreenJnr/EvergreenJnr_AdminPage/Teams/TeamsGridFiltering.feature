Feature: TeamsGridFiltering
	Teams Grid Filtering

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforTeamsList
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Teams' left menu item
	And User enters "K-Team" text in the Search field for "Team" column
	Then Rows counter contains "2" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @DAS12999 @DAS13471 @Teams @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForTeams
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User opens 'Team' column settings
	When User clicks Filter button in the Column Settings panel on the Teams Page
	When User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console
	When User enters "Administrative Team" text in the Search field for "Team" column
	Then Rows counter contains "1" found row of all rows
	When User clicks content from "Team" column
	Then Page with 'Administrative Team' header is displayed to user
	When User opens 'Username' column settings
	When User clicks Filter button in the Column Settings panel on the Teams Page
	When User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console
	When User click on Back button
	When User unchecks following checkboxes in the filter dropdown menu for the 'Default' column:
	| checkboxes |
	| True       |
	Then Rows counter shows more than "2793" found rows of all rows
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	Then Content is present in the table on the Admin page
	When User enters "Team 10" text in the Search field for "Description" column
	Then Rows counter contains "111" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User enters "0" text in the Search field for "Evergreen Buckets" column
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User enters "3" text in the Search field for "Project Buckets" column
	When User clicks Reset Filters button on the Admin page
	When User enters "Retail Team" text in the Search field for "Team" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User enters "12" text in the Search field for "Members" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User click on "Team" column header on the Admin page
	#Remove hash after fix sort order
	#Then data in table is sorted by 'Team' column in ascending order
	When User scrolls grid to the top
	When User click on "Team" column header on the Admin page
	Then data in table is sorted by 'Team' column in descending order
	When User scrolls grid to the top
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by 'Description' column in ascending order
	When User scrolls grid to the top
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by 'Description' column in descending order
	When User scrolls grid to the top
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by 'Members' column in descending order
	When User scrolls grid to the top
	When User click on "Members" column header on the Admin page
	Then all cells in the 'Members' column are empty
	When User scrolls grid to the top
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in ascending order
	When User scrolls grid to the top
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in descending order
	When User scrolls grid to the top
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by 'Evergreen Buckets' column in descending order
	When User scrolls grid to the top
	When User click on "Evergreen Buckets" column header on the Admin page
	Then all cells in the 'Evergreen Buckets' column are empty
	When User scrolls grid to the top
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by 'Project Buckets' column in descending order
	When User scrolls grid to the top
	When User click on "Project Buckets" column header on the Admin page
	Then all cells in the 'Project Buckets' column are empty
	Then There are no errors in the browser console