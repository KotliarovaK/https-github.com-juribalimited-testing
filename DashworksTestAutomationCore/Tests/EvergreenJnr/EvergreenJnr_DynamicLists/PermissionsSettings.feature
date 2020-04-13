@retry:1
Feature: PermissionsSettings
	Runs Dynamic List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @DAS11951 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateDynamicList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "TestList83C1C0" name on "Users" page
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User selects 'Automation Admin 1' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then Update list option is NOT available
	Then 'SAVE AS NEW DYNAMIC LIST' menu button is displayed for 'SAVE' button

@Evergreen @Users @EvergreenJnr_DynamicLists @PermissionsSettings @DAS10979 @DAS11553 @DAS10880 @DAS11951 @DAS14263 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatAdminUserButNotOwnerIsNotAbleToDeleteList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "TestList9507DA" name on "Users" page
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'group_add' icon
	Then form container is displayed to the user
	When User selects 'Team 1054' option from 'Team' autocomplete
	When User selects 'Admin' in the 'Permission' dropdown
	When User clicks 'CANCEL' button 
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'person_add' icon
	And User select current user in Select User dropdown
	When User selects 'Admin' in the 'Permission' dropdown
	When User clicks 'ADD USER' button
	When User selects 'Automation Admin 1' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	And User clicks the List Details button
	Then Delete list button is disabled in List Details panel
	And Delete List option is NOT available

@Evergreen @Users @EvergreenJnr_DynamicLists @DAS12941 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatSavedDynamicListIsNotDisplayedInEditModeIfUseDepartmentFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	When User creates 'List_DAS16228' dynamic list
	Then "List_DAS16228" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'group_add' icon
	When User selects 'Team 1' option from 'Team' autocomplete
	When User selects 'Admin' in the 'Permission' dropdown
	When User clicks 'CANCEL' button 
	When User navigates to the "All Devices" list
	Then All lists are unique on the Lists panel

@Evergreen @Devices @EvergreenJnr_DynamicLists @DAS16405 @DAS16555
Scenario: EvergreenJnr_DevicesList_CheckThatExpandIconIsInactiveForOwnerDdlForNonOwnerUserInItemDetails
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "2004 Rollout" list
	Then "2004 Rollout" list is displayed to user
	When User clicks the Permissions button
	Then 'Owner' textbox is disabled