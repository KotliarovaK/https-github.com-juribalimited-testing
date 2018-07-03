@retry:1
Feature: PermissionsSettings
	Runs Static List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_StaticLists @PermissionsSettings @DAS10945 @DAS11553 @DAS10880 @DAS12152 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatNotOwnerUsersDontHavePermissionsToUpdateStaticList
	When User create static list with "Static List TestName23" name on "Users" page with following items
	| ItemName |
	|          |
	Then "Static List TestName23" list is displayed to user
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

@Evergreen @Devices @EvergreenJnr_StaticLists @PermissionsSettings @DAS11022 @DAS11553 @DAS10880 @DAS12152 @DAS12602 @Delete_Newly_Created_List @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatAddRowsOptionsIsAvailableForSpecifiedPermissionLevel
	When User create static list with "OwnerPrivate" name on "Devices" page with following items
	| ItemName        |
	| 001BAQXT6JWFPI  |
	| 00HA7MKAVVFDAV  |
	| 2ML5YDWPRLFWW55 |
	| 700ZHPQ6661CV1N |
	Then "OwnerPrivate" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User create static list with "NotOwnerSpecifiedAdmin" name on "Devices" page with following items
	| ItemName       |
	| ZZHYOLP1V7STML |
	| VMI480Z5UKTLLK |
	| 6B512UPQFLSOVF |
	| CLUSTERSSAS    |
	Then "NotOwnerSpecifiedAdmin" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	And User click Add User button
	And User select current user in Select User dropdown
	And User select "Admin" in Select Access dropdown
	And User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User create static list with "NotOwnerSpecifiedEdit" name on "Devices" page with following items
	| ItemName       |
	| OMHSV0SYAJ1DHH |
	| KT9QOAK2V45HF7 |
	| CAJ7AN9LAW3QEP |
	| OMHSV0SYAJ1DHH |
	Then "NotOwnerSpecifiedEdit" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	And User click Add User button
	And User select current user in Select User dropdown
	And User select "Edit" in Select Access dropdown
	And User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User create static list with "NotOwnerSpecifiedRead" name on "Devices" page with following items
	| ItemName       |
	| U3IKRXYYY4YE0V |
	| EKGSN1N0X9UKRY |
	| EKGSN1N0X9UKRY |
	| W10ASSDUNCAN   |
	Then "NotOwnerSpecifiedRead" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users" sharing option
	And User click Add User button
	And User select current user in Select User dropdown
	And User select "Read" in Select Access dropdown
	And User click Add User button
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User create static list with "NotOwnerEveryoneCanEdit" name on "Devices" page with following items
	| ItemName        |
	| TVGU1Y24UU9QBQ  |
	| O0DOUNEKCY7HXK  |
	| 5PH0YQ5TNBLFZBM |
	| SANOFI2-POC     |
	Then "NotOwnerEveryoneCanEdit" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	And User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User create static list with "NotOwnerEveryoneCanSee" name on "Devices" page with following items
	| ItemName       |
	| 9K9Y2LGOD3Z1KW |
	| HW9RNYX1SNE3BN |
	| CAS            |
	| WIN8RETAILPRO  |
	Then "NotOwnerEveryoneCanSee" list is displayed to user
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
	| NotOwnerEveryoneCanEdit |
	| NotOwnerSpecifiedAdmin  |
	| NotOwnerSpecifiedEdit   |
	| OwnerPrivate            |