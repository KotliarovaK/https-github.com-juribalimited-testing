@retry:1
Feature: PermissionsSettings
	Runs Dynamic List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
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

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @Delete_Newly_Created_List 
Scenario: EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create custom list with "TestList" name
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	When User click Add User button
	When User select current user in Select User dropdown
	When User select "Admin" in Select Access dropdown
	When User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then Delete list button is disabled in List Details panel
	Then Delete List option is NOT available
