﻿Feature: TeamsGridFiltering
	Teams Grid Filtering

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforTeamsList
	When User clicks Admin on the left-hand menu
	And User clicks "Teams" link on the Admin page
	And User enters "K-Team" text in the Search field for "Team" column
	Then Rows counter contains "2" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @DAS12999 @DAS13471 @Teams @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForTeams
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User have opened Column Settings for "Team" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User enters "Administrative Team" text in the Search field for "Team" column
	Then Rows counter contains "1" found row of all rows
	When User clicks content from "Team" column
	Then "Administrative Team" team details is displayed to the user
	When User have opened Column Settings for "Username" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User click on Back button
	When User clicks String Filter button for "Default" column on the Admin page
	When User clicks "True" checkbox from boolean filter on the Admin page
	Then Rows counter shows more than "2793" found rows of all rows
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	Then Content is present in the table on the Admin page
	When User enters "Team 10" text in the Search field for "Description" column
	Then Rows counter contains "111" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User enters "0" text in the Search field for "Evergreen Buckets" column
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User enters "3" text in the Search field for "Project Buckets" column
	And User enters "Retail Team" text in the Search field for "Team" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User enters "12" text in the Search field for "Members" column
	Then Rows counter contains "2" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User click on "Team" column header on the Admin page
	#Remove hash after fix sort order
	#Then data in table is sorted by "Team" column in ascending order on the Admin page
	When User click on "Team" column header on the Admin page
	Then data in table is sorted by "Team" column in descending order on the Admin page
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by "Description" column in ascending order on the Admin page
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by "Description" column in descending order on the Admin page
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by "Members" column in descending order on the Admin page
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by "Members" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in ascending order
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in descending order
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Evergreen Buckets" column in descending order on the Admin page
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Evergreen Buckets" column in ascending order on the Admin page
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Project Buckets" column in descending order on the Admin page
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Project Buckets" column in ascending order on the Admin page
	And There are no errors in the browser console