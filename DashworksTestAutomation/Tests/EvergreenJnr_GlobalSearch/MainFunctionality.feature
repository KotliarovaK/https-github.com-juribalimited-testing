@retry:1
Feature: MainFunctionality
	Runs Main Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @GlobalSearch @EvergreenJnr_GlobalSearch @MainFunctionality @DAS11490 @DAS11745 @DAS11706 @DAS12544 @DAS12047 @DAS12603 @DAS12728
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
	Then "No results found" message is not displayed below Global Search field
	Then "Search results for "admin"" is displayed below Global Search field
	And "195" rows are displayed on the Global Search
	And list of results is displayed to the user
	When User type "!@#$%^&*()" in Global Search Field
	Then "No results found" message is displayed below Global Search field
	When User type "______#____-" in Global Search Field and presses Enter key
	Then "Search results for "______#____-"" is displayed below Global Search field
	And "1" rows are displayed on the Global Search
	And list of results is displayed to the user
	When User type "%SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013" in Global Search Field and presses Enter key
	Then "Search results for "%SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013"" is displayed below Global Search field
	And "1" rows are displayed on the Global Search
	When User type ""WPF/E" (codename) Community Technology Preview (Feb 2007)" in Global Search Field and presses Enter key
	Then "Search results for ""WPF/E" (codename) Community Technology Preview (Feb 2007)"" is displayed below Global Search field
	Then ""WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0)" text is displayed in the table content
	When User type "Escaping Test User |\\/\,\<\>#\;+\"\=- |\\/\,\<\>#\;+\"\=-.Users.corp.juriba.com" in Global Search Field and presses Enter key
	Then "Search results for "Escaping Test User |\\/\,\<\>#\;+\"\=- |\\/\,\<\>#\;+\"\=-.Users.corp.juriba.com"" is displayed below Global Search field
	Then message "No results found for the current search" is displayed to the user below Search results
	And There are no errors in the browser console