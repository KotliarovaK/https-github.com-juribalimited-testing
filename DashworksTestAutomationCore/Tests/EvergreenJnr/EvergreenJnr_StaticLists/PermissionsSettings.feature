@retry:1
Feature: PermissionsSettings
	Runs Static List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_StaticLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @DAS12152 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticList
	When User create static list with "Static List TestName23" name on "Users" page with following items
	| ItemName |
	|          |
	Then "Static List TestName23" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User selects 'Automation Admin 1' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Last Logon Date |
	Then ColumnName is added to the list
	| ColumnName      |
	| Last Logon Date |
	Then Update list option is NOT available
	Then 'SAVE AS NEW STATIC LIST' menu button is displayed for 'SAVE' button

@Evergreen @Devices @EvergreenJnr_StaticLists @PermissionsSettings @DAS11022 @DAS11553 @DAS10880 @DAS12152 @DAS12602 @Cleanup @Do_Not_Run_With_PermissionsSettings
Scenario: EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevel
	When User create new User via API
	| Username | Email | FullName      | Password  | Roles                 |
	| DAS12602 | Value | Test DAS12602 | m!gration | Project Administrator |
	When User create static list with "OwnerPrivate" name on "Devices" page with following items
	| ItemName        |
	| 001BAQXT6JWFPI  |
	| 00HA7MKAVVFDAV  |
	| 2ML5YDWPRLFWW55 |
	| 700ZHPQ6661CV1N |
	Then "OwnerPrivate" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User create static list with "NotOwnerSpecifiedAdmin" name on "Devices" page with following items
	| ItemName       |
	| ZZHYOLP1V7STML |
	| VMI480Z5UKTLLK |
	| 6B512UPQFLSOVF |
	| CLUSTERSSAS    |
	Then "NotOwnerSpecifiedAdmin" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'person_add' icon
	And User select current user in Select User dropdown
	When User selects 'Admin' in the 'Permission' dropdown
	When User clicks 'ADD USER' button
	When User selects 'Test DAS12602' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User create static list with "NotOwnerSpecifiedEdit" name on "Devices" page with following items
	| ItemName       |
	| 07PZNEOU91VWVH |
	| 0A88YQHT6IMTTZ |
	| 0CFTD5FV5F7FDF |
	| 0E9XQC02MAZUR2 |
	Then "NotOwnerSpecifiedEdit" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'person_add' icon
	And User select current user in Select User dropdown
	When User selects 'Edit' in the 'Permission' dropdown
	When User clicks 'ADD USER' button
	When User selects 'Test DAS12602' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User create static list with "NotOwnerSpecifiedRead" name on "Devices" page with following items
	| ItemName       |
	| VMI480Z5UKTLLK |
	| 6B512UPQFLSOVF |
	| 0CFTD5FV5F7FDF |
	| 0E9XQC02MAZUR2 |
	Then "NotOwnerSpecifiedRead" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'person_add' icon
	And User select current user in Select User dropdown
	When User selects 'Read' in the 'Permission' dropdown
	When User clicks 'ADD USER' button
	When User selects 'Test DAS12602' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User create static list with "NotOwnerEveryoneCanEdit" name on "Devices" page with following items
	| ItemName        |
	| TVGU1Y24UU9QBQ  |
	| O0DOUNEKCY7HXK  |
	| 5PH0YQ5TNBLFZBM |
	| SANOFI2-POC     |
	Then "NotOwnerEveryoneCanEdit" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	When User selects 'Test DAS12602' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User create static list with "NotOwnerEveryoneCanSee" name on "Devices" page with following items
	| ItemName       |
	| 9K9Y2LGOD3Z1KW |
	| HW9RNYX1SNE3BN |
	| CAS            |
	| WIN8RETAILPRO  |
	Then "NotOwnerEveryoneCanSee" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User selects 'Test DAS12602' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Add to static list' in the 'Action' dropdown
	Then following Values are displayed in the 'Choose static list' dropdown:
	| Listnames               |
	| NotOwnerEveryoneCanEdit |
	| NotOwnerSpecifiedAdmin  |
	| NotOwnerSpecifiedEdit   |
	| OwnerPrivate            |