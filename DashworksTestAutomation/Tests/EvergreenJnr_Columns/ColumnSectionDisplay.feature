#@retry:3
Feature: ColumnSectionDisplay
	Runs Add column related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @ColumnSectionDisplay @EvergreenJnr_Columns @DAS-10584
Scenario: Evergreen Jnr_ApplicationsList_Check category heading when all columns from category are added
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User add all Columns from specific category
	| CategoryName |
	| Application  |
	Then "0" subcategories is displayed for "Application" category
	#Maximize/Minimize button is still displayed even category is empty. This is known issue
	#Because of this below assertion is commented
	#Then Maximize or Minimize button is not displayed for "Applications" category
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out