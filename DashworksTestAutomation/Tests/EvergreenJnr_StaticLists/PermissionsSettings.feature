@retry:1
Feature: PermissionsSettings
	Runs Static List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_StaticLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @DAS12152 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	When User clicks the List Details button
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

@Evergreen @Devices @EvergreenJnr_StaticLists @PermissionsSettings @DAS11022 @DAS11553 @DAS10880 @DAS12152 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "OwnerPrivate" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "OwnerPrivate" list
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "NotOwnerSpecifiedAdmin" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "NotOwnerSpecifiedAdmin" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	When User click Add User button
	When User select current user in Select User dropdown
	When User select "Admin" in Select Access dropdown
	When User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "NotOwnerSpecifiedEdit" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "NotOwnerSpecifiedEdit" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	When User click Add User button
	When User select current user in Select User dropdown
	When User select "Edit" in Select Access dropdown
	When User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "NotOwnerSpecifiedRead" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "NotOwnerSpecifiedRead" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	When User click Add User button
	When User select current user in Select User dropdown
	When User select "Read" in Select Access dropdown
	When User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "NotOwnerEveryoneCanEdit" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "NotOwnerEveryoneCanEdit" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "NotOwnerEveryoneCanSee" name
	#Workaround for DAS-11570. Remove after fix
	#When User navigates to the "NotOwnerEveryoneCanSee" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can see" sharing option
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User select "Add to static list" option in Actions panel
	Then Following options are available in lists dropdown:
	| Listnames               |
	| OwnerPrivate            |
	| NotOwnerSpecifiedAdmin  |
	| NotOwnerSpecifiedEdit   |
	| NotOwnerEveryoneCanEdit |