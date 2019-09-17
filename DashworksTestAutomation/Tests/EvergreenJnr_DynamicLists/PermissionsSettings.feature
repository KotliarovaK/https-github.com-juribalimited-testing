@retry:1
Feature: PermissionsSettings
	Runs Dynamic List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @DAS11951 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicList
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "TestList83C1C0" name on "Users" page
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

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS10979 @DAS11553 @DAS10880 @DAS11951 @DAS14263 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "TestList9507DA" name on "Users" page
	And User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users / teams" sharing option
	When User clicks the "ADD TEAM" Action button
	Then form container is displayed to the user
	When User selects the "Team 1054" team for sharing
	And User select "Admin" in Select Access dropdown
	When User clicks the "CANCEL" Action button
	When User select "Specific users" sharing option
	And User click Add User button
	And User select current user in Select User dropdown
	And User select "Admin" in Select Access dropdown
	And User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	And User clicks the List Details button
	Then Delete list button is disabled in List Details panel
	And Delete List option is NOT available

@Evergreen @Users @EvergreenJnr_DynamicLists @DAS12941 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDepartmentFilter
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "Technology" Tree List option
	Then "Department" filter is added to the list
	Then "7,021" rows are displayed in the agGrid
	When User create dynamic list with "DAS12941" name on "Users" page
	When User navigates to the "All Users" list
	When User navigates to the "DAS12941" list
	Then Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_DynamicLists @DAS16228 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatSharedItemIsNotDuplicatedWhenUserShareItForTheTeamToWhichHeAlsoBelongs
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks on 'Hostname' column header
	When User create custom list with "List_DAS16228" name
	Then "List_DAS16228" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users / teams" sharing option
	When User clicks the "ADD TEAM" Action button
	When User selects the "Team 1" team for sharing
	And User select "Admin" in Permission dropdown
	When User clicks the "CANCEL" Action button
	When User navigates to the "All Devices" list
	Then All lists are unique on the Lists panel

@Evergreen @Devices @EvergreenJnr_DynamicLists @DAS16405 @DAS16555
Scenario: EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserInItemDetails
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User navigates to the "1803 Rollout" list
	Then "1803 Rollout" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	Then Owner Drop-down list is disabled on List details panel