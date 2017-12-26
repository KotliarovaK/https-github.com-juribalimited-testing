﻿@retry:1
Feature: PermissionsSettings
	Runs Dynamic List permissions setting related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS-10945 @DAS-11553 @DAS-10880 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in descending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	And User navigates to the "TestList" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can see" sharing option
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then Update list option is NOT available
	And Save as a new list option is available

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS-10945 @DAS-11553 @DAS-10880 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in descending order
	When User create custom list with "TestList" name
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	When User click Add User button
	When User select 'Administrator' in Select User dropdown
	When User select "Admin" in Select Access dropdown
	When User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then Delete list button is disabled in List Details panel
	Then Delete List option is NOT available
