Feature: MainFunctionality
	Runs Profile Details related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @GlobalSearch @EvergreenJnr_GlobalSearch @MainFunctionality @DAS11490
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
	Then Search results are displayed below Global Search field
	When User type "___ab " in Global Search Field
	Then Search results are displayed below Global Search field