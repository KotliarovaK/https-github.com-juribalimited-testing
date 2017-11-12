Feature: AllCheckbox
	Runs All Checkbox related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Search @Users @AllCheckbox @Evergreen_ActionsPanel @DAS-10769
Scenario: Evergreen Jnr_UsersList_Select All Checkbox Status Check After Search
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| alain          | 42           |
	Then Select All selectbox is checked
	Then "42" rows are displayed in the agGrid
	Then "38271" selected rows are displayed in the Actions panel
	When User is deselect all rows
	And User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	And Clearing the agGrid Search Box
	Then Select All selectbox is checked
	Then "42" selected rows are displayed in the Actions panel
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @AllCheckbox @Evergreen_ActionsPanel @DAS-10775
Scenario: Evergreen Jnr_DevicesList_Select All Checkbox status after closing action panel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @AllCheckbox @Evergreen_ActionsPanel @DAS-10775
Scenario: Evergreen Jnr_UsersList_Select All Checkbox status after closing action panel
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @AllCheckbox @Evergreen_ActionsPanel @DAS-10775
Scenario: Evergreen Jnr_ApplicationsList_Select All Checkbox status after closing action panel
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Mailboxes @AllCheckbox @Evergreen_ActionsPanel @DAS-10775
Scenario: Evergreen Jnr_MailboxesList_Select All Checkbox status after closing action panel
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out