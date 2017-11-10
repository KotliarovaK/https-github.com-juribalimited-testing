﻿Feature: AllCheckbox
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

@Evergreen @Search @Users @AllCheckbox @Evergreen_FiltersFeature @DAS-10769
Scenario: Evergreen Jnr_DevicesList_Select All Checkbox Status Check After Search
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
