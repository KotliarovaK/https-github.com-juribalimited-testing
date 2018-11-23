Feature: CapacityUnits
	Runs Capacity Units related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13169 @DAS131168 @DAS12632
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyEvergreenUnitsAreDisplayedByDefault
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	And Evergreen Icon is displayed to the user
	And "Unassigned" text is displayed in the table content
	And Evergreen Unit is displayed to the user
	When User clicks String Filter button for "Project" column on the Admin page
	Then "Evergreen" checkbox is checked in the filter dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632 @DAS13626 @DAS14236
Scenario: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "NotDefaultCapacityUnit13720" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the NotDefaultCapacityUnit13720 capacity unit" link
	Then There are no errors in the browser console
	And "NotDefaultCapacityUnit13720" text is displayed in the table content
	When User enters "NotDefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then "FALSE" value is displayed for Default column
	And "" content is displayed in "Devices" column
	And "" content is displayed in "Users" column
	And "" content is displayed in "Mailboxes" column
	And "" content is displayed in "Applications" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName            |
	| NotDefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This unit will be permanently deleted and any objects within it reassigned to the default unit" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12921
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacityUnitsDeletionMessages
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName          |
	| Evergreen Capacity Unit 1 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This unit will be permanently deleted and any objects within it reassigned to the default unit" text is displayed on the Admin page
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName          |
	| Evergreen Capacity Unit 2 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "These units will be permanently deleted and any objects within them reassigned to the default unit" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "DefaultCapacityUnit13720" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User updates the "Default unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the DefaultCapacityUnit13720 capacity unit" link
	Then "DefaultCapacityUnit13720" text is displayed in the table content
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column
	And "" content is displayed in "Devices" column
	And "" content is displayed in "Users" column
	And "" content is displayed in "Mailboxes" column
	And "" content is displayed in "Applications" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "FALSE" value is displayed for Default column
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName         |
	| DefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default unit" text is displayed on the Admin page
	When User close message on the Admin page
	Then "DefaultCapacityUnit13720" text is displayed in the table content
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User selects "Unit Settings" tab on the Capacity Units page
	Then "Default unit" checkbox is checked and cannot be unchecked
	When User click on Back button
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User selects "Unit Settings" tab on the Capacity Units page
	And User updates the "Default unit" checkbox state
	And User clicks the "UPDATE" Action button
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName         |
	| DefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13013 @DAS12926
Scenario: EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameNameInDifferentCase
	When User clicks Admin on the left-hand menu
	And User clicks "Capacity Units" link on the Admin page
	And User clicks the "CREATE UNIT" Action button
	Then "Capacity Units" page should be displayed to the user
	And "Create Capacity Unit" page should be displayed to the user
	When User type "SameNameCaseSensative" Name in the "Capacity Unit Name" field on the Project details page
	And User type "SameNameCaseSensative" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE UNIT" Action button
	And User type "samenamecaseSensative" Name in the "Capacity Unit Name" field on the Project details page
	And User type "SameNameCaseSensative" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	And There are no errors in the browser console
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName         |
	| SameNameCaseSensative |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236
Scenario: EvergreenJnr_AdminPage_ChecksThatDevicesAreAddedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "CapacityUnit12141Devices" Name in the "Capacity Unit Name" field on the Project details page
	And User type "Devices" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12141Devices capacity unit" link
	And "CapacityUnit12141Devices" text is displayed in the table content
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	| 00K4CEEQ737BA4L  |
	| 00KLL9S8NRF0X6   |
	| 00KWQ4J3WKQM0G   |
	| 01ERDGD48UDQKE   |
	And User selects "Bulk Update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project on Action panel
	And User selects "CapacityUnit12141Devices" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "Your changes have successfully been queued, 5 of 5 objects were in the selected project." text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Devices" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Devices" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName         |
	| CapacityUnit12141Devices |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236
Scenario: EvergreenJnr_AdminPage_ChecksThatUsersAreAddedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "CapacityUnit12141Users" Name in the "Capacity Unit Name" field on the Project details page
	And User type "Users" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12141Users capacity unit" link
	And "CapacityUnit12141Users" text is displayed in the table content
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName     |
	| $231000-3AC04R8AR431 |
	| $6BE000-SUDQ9614UVO8 |
	| ___ ___              |
	| 002B5DC7D4D34D5C895  |
	| 00BDBAEA57334C7C8F4  |
	And User selects "Bulk Update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project on Action panel
	And User selects "CapacityUnit12141Users" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "Your changes have successfully been queued, 5 of 5 objects were in the selected project." text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Users" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Users" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName       |
	| CapacityUnit12141Users |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236
Scenario: EvergreenJnr_AdminPage_ChecksThatMailboxesAreAddedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "CapacityUnit12141Mailboxes" Name in the "Capacity Unit Name" field on the Project details page
	And User type "Mailboxes" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12141Mailboxes capacity unit" link
	And "CapacityUnit12141Mailboxes" text is displayed in the table content
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	| 002B5DC7D4D34D5C895@bclabs.local |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	| 0072B088173449E3A93@bclabs.local |
	| 00A5B910A1004CF5AC4@bclabs.local |
	And User selects "Bulk Update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project on Action panel
	And User selects "CapacityUnit12141Mailboxes" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "Your changes have successfully been queued, 5 of 5 objects were in the selected project." text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Mailboxes" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Mailboxes" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName           |
	| CapacityUnit12141Mailboxes |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236 @DAS14237 @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatApplicationsAreAddedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "CapacityUnit12141Applications" Name in the "Capacity Unit Name" field on the Project details page
	And User type "Applications" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12141Applications capacity unit" link
	And "CapacityUnit12141Applications" text is displayed in the table content
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                                |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007)      |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI                  |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	| ACD FotoCanvas 2.0 Trial                                        |
	And User selects "Bulk Update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project on Action panel
	And User selects "CapacityUnit12141Applications" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "Your changes have successfully been queued, 5 of 5 objects were in the selected project." text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Applications" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Applications" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName              |
	| CapacityUnit12141Applications |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @Not_Run @archived
Scenario: EvergreenJnr_AdminPage_ChecksThatSortingWorksCorrectlyOnTheCapacityUnitsPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "Capacity Unit Sorting" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks newly created object link
	And User selects "Devices" tab on the Capacity Units page
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00HA7MKAVVFDAV  |
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected devices have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User selects "Users" tab on the Capacity Units page
	Then "Users" tab is selected on the Admin page
	When User clicks the "ADD USER" Action button
	And User selects following Objects
	| Objects                                          |
	| BCLABS\002B5DC7D4D34D5C895 (Collor, Christopher) |
	| DWLABS\003F5D8E1A844B1FAA5 (Hunter, Melanie)     |
	| BCLABS\01AE08330912421F891 (Adlawan, Belen)      |
	| DWLABS\02171CE96D0244BBB80 (Bernardo, Anita)     |
	| BCLABS\024213574157421A9CD (Reyes, Natasha)      |
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected users have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User selects "Mailboxes" tab on the Capacity Units page
	Then "Mailboxes" tab is selected on the Admin page
	When User clicks the "ADD MAILBOX" Action button
	And User selects following Objects
	| Objects                          |
	| 000F977AC8824FE39B8@bclabs.local |
	| 002B5DC7D4D34D5C895@bclabs.local |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	| 0072B088173449E3A93@bclabs.local |
	| 00A5B910A1004CF5AC4@bclabs.local |
	And User clicks the "ADD MAILBOXES" Action button
	Then Success message is displayed and contains "The selected mailboxes have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User selects "Applications" tab on the Capacity Units page
	Then "Applications" tab is selected on the Admin page
	When User clicks the "ADD APPLICATION" Action button
	And User selects following Objects
	| Objects                                                         |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007)      |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI                  |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	| 0036 - Microsoft Access 97 SR-2 English                         |
	And User clicks the "ADD APPLICATIONS" Action button
	Then Success message is displayed and contains "The selected applications have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User click on Back button
	And User enters "ss" text in the Search field for "Capacity Unit" column
	Then "Unassigned" text is displayed in the table content
	And "1" rows are displayed in the agGrid on Capacity Units page
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Default" column on the Admin page
	When User clicks "True" checkbox from boolean filter on the Admin page
	Then "1" rows are displayed in the agGrid on Capacity Units page
	When User clicks Reset Filters button on the Admin page
	And User enters "=5" text in the Search field for "Devices" column
	Then "1" rows are displayed in the agGrid on Capacity Units page
	When User clicks Reset Filters button on the Admin page
	And User click on "Capacity Unit" column header on the Admin page
	Then data in table is sorted by "Capacity Unit" column in ascending order on the Admin page	
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	When User enters "Capacity Unit Sorting" text in the Search field for "Capacity Unit" column
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName      |
	| Capacity Unit Sorting |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @Not_Run @archived
Scenario: EvergreenJnr_AdminPage_ChecksThatMovementOfTheObjectWorksCorrectlyOnThePowerUnitPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "CapacityUnit12141" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks newly created object link
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00I0COBFWHOF27  |
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected devices have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User clicks refresh button in the browser
	Then "5" rows are displayed in the agGrid on Capacity Units page
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User clicks on Actions button
	And User selects "Move to another unit" in the Actions
	And User clicks the "CONTINUE" Action button
	Then "Move To Another Capacity Unit" is displayed on the Admin page
	When User moves selected objects to "[Unassigned]" Capacity Unit
	Then Success message is displayed and contains "The selected object has been added to the selected capacity unit" text
	#Then "4" rows are displayed in the agGrid on Capacity Units page
	When User click on Back button
	When User enters "CapacityUnit12141" text in the Search field for "Capacity Unit" column
	Then "4" content is displayed in "Devices" column
	When User enters "CapacityUnit12141" text in the Search field for "Capacity Unit" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit12141 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS14172 @DAS14236
Scenario: EvergreenJnr_AdminPage_CheckThatTheUpdateCapacityUnitSettingsIsWorkingCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "Capacity Unit Settings" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks newly created object link
	When User type "Capacity Unit Settings upd" Name in the "Capacity Unit Name" field on the Project details page
	And User type "upd" Name in the "Description" field on the Project details page
	And User updates the "Default unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	Then "Capacity Unit Settings upd" text is displayed in the table content
	When User enters "Capacity Unit Settings upd" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User selects "Unit Settings" tab on the Capacity Units page
	And User updates the "Default unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column
	When User enters "Capacity Unit Settings upd" text in the Search field for "Capacity Unit" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName           |
	| Capacity Unit Settings upd |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13481 @Not_Run @archived
Scenario: EvergreenJnr_AdminPage_ChecksThatValueForEmptyOwnerObjectKeyOnCapacityUnitsIsDisplayedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "OwnerObjectKey13481" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks newly created object link
	And User selects "Devices" tab on the Capacity Units page
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects   |
	| TIMSTRAIN |
	| Macbook1  |
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected devices have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User clicks refresh button in the browser
	When User have opened Column Settings for "Hostname" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Owner Object Key" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName       |
	| Owner Object Key |
	When User enters "TIMSTRAIN" text in the Search field for "Hostname" column
	Then "" content is displayed in "Owner Object Key" column
	When User enters "Macbook1" text in the Search field for "Hostname" column
	Then "" content is displayed in "Owner Object Key" column
	When User selects "Mailboxes" tab on the Capacity Units page
	Then "Mailboxes" tab is selected on the Admin page
	When User clicks the "ADD MAILBOX" Action button
	And User selects following Objects
	| Objects                   |
	| alex.cristea@juriba.com   |
	| alex.melnychuk@juriba.com |
	And User clicks the "ADD MAILBOXES" Action button
	Then Success message is displayed and contains "The selected mailboxes have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User have opened Column Settings for "Email Address" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Owner Object Key" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName       |
	| Owner Object Key |
	When User enters "alex.cristea@juriba.com" text in the Search field for "Email Address" column
	Then "" content is displayed in "Owner Object Key" column
	When User enters "alex.melnychuk@juriba.com" text in the Search field for "Email Address" column
	Then "" content is displayed in "Owner Object Key" column
	When User click on Back button
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName    |
	| OwnerObjectKey13481 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message