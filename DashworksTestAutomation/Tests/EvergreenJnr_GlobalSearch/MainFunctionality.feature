﻿@retry:1
Feature: MainFunctionality
	Runs Main Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @GlobalSearch @EvergreenJnr_GlobalSearch @MainFunctionality @DAS11490 @DAS11745 @DAS11706 @DAS12544 @DAS12047
Scenario: EvergreenJnr_GlobalSearch_CheckThatErrorMessageIsNotDisplayedAfterTypingThreeSpaces
	When User type "   " in Global Search Field
	Then "Enter at least 3 characters" message is displayed below Global Search field
	When User type "a b" in Global Search Field
	Then Search results are displayed below Global Search field
	When User type " " in Global Search Field
	Then "Enter at least 3 characters" message is displayed below Global Search field
	When User type " a b" in Global Search Field
	Then Search results are displayed below Global Search field
	When User type "ab " in Global Search Field
	Then Search results are displayed below Global Search field
	When User type "%%%ab " in Global Search Field
	Then "No results found" message is displayed below Global Search field
	When User type "___ab " in Global Search Field
	Then Search results are displayed below Global Search field
	When User type "admin" in Global Search Field and presses Enter key
	Then "Search results for "admin"" is displayed below Global Search field
	And "195" rows are displayed on the Global Search
	And list of results is displayed to the user
	When User type "______#____-" in Global Search Field and presses Enter key
	Then "Search results for "______#____-"" is displayed below Global Search field
	And "1" rows are displayed on the Global Search
	And list of results is displayed to the user
	When User type "!@#$%^&*()" in Global Search Field
	Then "No results found" message is displayed below Global Search field
	And There are no errors in the browser console