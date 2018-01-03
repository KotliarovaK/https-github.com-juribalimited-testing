@retry:1
Feature: Login_Logout
	Runs Profile Details related tests


@Evergreen @Login_Logout
Scenario: EvergreenJnr_Login_Logout_CheckThatLoginAndLogOutWorksCorrectly
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	Then User is logged out
	When User clicks the Switch to Evergreen link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	Then User is logged out