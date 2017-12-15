#@retry:3
Feature: PermissionsSettings
	Runs Static List permissions setting related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user


@Evergreen @Users @EvergreenJnr_StaticLists @PermissionsSettings @DAS-10945 @DAS-11553 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_Check that not owner users don't have permissions to update static list
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	Then List details panel is displayed to the user
	When User select "Everyone can see" sharing option
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Last Logon Date |
	Then ColumnName is added to the list
	| ColumnName      |
	| Last Logon Date |
	Then Update list option is NOT available
	And Save as a new list option is available
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out