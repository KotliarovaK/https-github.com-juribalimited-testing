Feature: Buckets
	Runs Buckets related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170 @DAS13011 @DAS13172 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingMailboxesToTheBucketWhereNoMailboxesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Mailboxes" tab
	Then "No objects found for this bucket" message is displayed on the Admin Page
	When User clicks the "ADD MAILBOX" Action button
	Then No items text is displayed
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170 @DAS13011 @DAS13839 @Remove_Added_Objects_From_Buckets @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingDevicesInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Bangor" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Counter shows "20" found rows
	When User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects        |
	| VXERDNJ3KRJ421 |
	| XV20GW6HJRVE2R |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	And Counter shows "22" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170 @DAS13011 @DAS13172 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingDevicesToTheBucketWhereNoDevicesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "No objects found for this bucket" message is displayed on the Admin Page
	When User clicks the "ADD DEVICE" Action button
	Then No items text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170 @DAS13011 @DAS13172 @DAS13839 @Remove_Added_Objects_From_Buckets @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingUsersInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Bangor" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Users" tab
	Then Counter shows "15" found rows
	When User clicks the "ADD USER" Action button
	Then There are no errors in the browser console
	When User adds following Objects from list
	| Objects   |
	| ADK614179 |
	| AAT858228 |
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And Counter shows "17" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170 @DAS13011 @DAS13839 @Buckets @Remove_Added_Objects_From_Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatMailboxesAreSuccessfullyAddedToBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Birmingham" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Mailboxes" tab
	Then Counter shows "147" found rows
	When User clicks the "ADD MAILBOX" Action button
	And User adds following Objects from list
	| Objects                          |
	| 040698EE82354C17B60@bclabs.local |
	| 04D8FC40F25547E7B4D@bclabs.local |
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	And Counter shows "149" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforBucketsList
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "birmingham" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12760 @DAS13254 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckMessageThatDisplayedWhenDeletingBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket4" in the "Bucket Name" field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket4" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected bucket has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedBucketUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "11770" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created, Click here to view the 11770 bucket" text
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "11770" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Error message with "A bucket already exists with this name" text is displayed
	And Delete "11770" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Buckets
Scenario: EvergreenJnr_AdminPage_CreatingDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "TRUE" value is displayed for Default column
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket5" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User updates the "Default Bucket" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket5" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	And User enters "NewBucket5" in the "Bucket Name" field
	And User selects "I-Team" team in the Team dropdown on the Buckets page
	And User clicks the "UPDATE BUCKET" Action button
	Then Success message is displayed and contains "The NewBucket5 bucket has been updated" text
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Bucket" column
	And User clicks "Bucket Settings" tab
	And User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "NewBucket5" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12939 @Buckets 
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderOfBucketsAfterCreateOrUpdateOrDeleteAction
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	And User creates following buckets in Administration:
	| Buckets | Teams    |
	| 1ba     | Admin IT |
	| 2ab     | K-Team   |
	| aaa     | Admin IT |
	| aab     | I-Team   |
	| aba     | Admin IT |
	| waa     | IB Team  |
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User enters "1ba" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Bucket Settings" tab
	And User enters "a1ba" in the "Bucket Name" field
	And User clicks the "UPDATE BUCKET" Action button
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User deletes "aab" Bucket in the Administration
	And User clicks refresh button in the browser
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	And Delete following Buckets in the Administration:
	| Buckets    |
	| 2ab        |
	| a1ba       |
	| aaa        |
	| aba        |
	| waa        |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13420 @DAS13837 @Buckets @Delete_Newly_Created_Bucket @Buckets @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingDevicesFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket6" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket6" bucket details is displayed to the user
	When User clicks "Devices" tab
	And User clicks the "ADD DEVICE" Action button
	And User clicks "Add from buckets" tab on the Buckets page
	And User adds "Unassigned" objects to bucket
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	And There are no errors in the browser console
	Then data in table is sorted by "Hostname" column in ascending order by default on the Admin page
	Then Counter shows "17,225" found rows
	When User click on "Hostname" column header on the Admin page
	Then data in table is sorted by "Hostname" column in ascending order on the Admin page
	When User click on "Hostname" column header on the Admin page
	Then data in table is sorted by "Hostname" column in descending order on the Admin page
	When User click on "Type" column header on the Admin page
	Then data in table is sorted by "Type" column in ascending order on the Admin page
	When User click on "Type" column header on the Admin page
	Then data in table is sorted by "Type" column in descending order on the Admin page
	When User click on "Operating System" column header on the Admin page
	Then data in table is sorted by "Operating System" column in ascending order on the Admin page
	When User click on "Operating System" column header on the Admin page
	Then data in table is sorted by "Operating System" column in descending order on the Admin page
	#When User click on "Owner Display Name" column header on the Admin page
	#Then data in table is sorted by "Owner Display Name" column in ascending order on the Admin page
	#When User click on "Owner Display Name" column header on the Admin page
	#Then data in table is sorted by "Owner Display Name" column in descending order on the Admin page
	When User enters "00KWQ4J3WKQM0G" text in the Search field for "Hostname" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Windows 2000" text in the Search field for "Operating System" column
	Then Counter shows "8" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Erin R. Lucero" text in the Search field for "Owner Display Name" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Type" column on the Admin page
	And User selects "Laptop" checkbox from String Filter on the Admin page
	Then Counter shows "13,417" found rows
	When User clicks Reset Filters button on the Admin page
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Move To Another Bucket" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13253 @DAS13420 @Buckets
Scenario: EvergreenJnr_AdminPage_AddingUsersFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket7" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket7" bucket details is displayed to the user
	When User clicks "Users" tab
	And User clicks the "ADD USER" Action button
	And User clicks "Add from buckets" tab on the Buckets page
	And User adds "Unassigned" objects to bucket
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And There are no errors in the browser console
	And data in table is sorted by "Username" column in ascending order by default on the Admin page
	Then Counter shows "41,339" found rows
	#When User click on "Username" column header on the Admin page
	#Then data in table is sorted by "Username" column in ascending order on the Admin page
	#When User click on "Username" column header on the Admin page
	#Then data in table is sorted by "Username" column in descending order on the Admin page
	When User click on "Domain" column header on the Admin page
	Then data in table is sorted by "Domain" column in ascending order on the Admin page
	When User click on "Domain" column header on the Admin page
	Then data in table is sorted by "Domain" column in descending order on the Admin page
	#When User click on "Display Name" column header on the Admin page
	#Then data in table is sorted by "Display Name" column in ascending order on the Admin page
	#When User click on "Display Name" column header on the Admin page
	#Then data in table is sorted by "Display Name" column in descending order on the Admin page
	#When User click on "Distinguished Name" column header on the Admin page
	#Then data in table is sorted by "Distinguished Name" column in ascending order on the Admin page
	#When User click on "Distinguished Name" column header on the Admin page
	#Then data in table is sorted by "Distinguished Name" column in descending order on the Admin page
	When User enters "ZygmontKi" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "UK" text in the Search field for "Domain" column
	Then Counter shows "4,649" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Anitra" text in the Search field for "Display Name" column
	Then Counter shows "18" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Paula" text in the Search field for "Distinguished Name" column
	Then Counter shows "38" found rows
	When User clicks Reset Filters button on the Admin page
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Move To Another Bucket" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And Delete "TestBucket7" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13420 @DAS13837 @Buckets @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingMailboxesFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket8" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket8" bucket details is displayed to the user
	When User clicks "Mailboxes" tab
	And User clicks the "ADD MAILBOX" Action button
	And User clicks "Add from buckets" tab on the Buckets page
	And User adds "Unassigned" objects to bucket
	And User clicks the "ADD MAILBOXES" Action button
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	And data in table is sorted by "Email Address (Primary)" column in ascending order by default on the Admin page
	And Counter shows "14,784" found rows
	When User click on "Email Address (Primary)" column header on the Admin page
	Then data in table is sorted by "Email Address (Primary)" column in ascending order on the Admin page
	When User click on "Email Address (Primary)" column header on the Admin page
	Then data in table is sorted by "Email Address (Primary)" column in descending order on the Admin page
	When User click on "Mailbox Platform" column header on the Admin page
	Then data in table is sorted by "Mailbox Platform" column in ascending order on the Admin page
	When User click on "Mailbox Platform" column header on the Admin page
	Then data in table is sorted by "Mailbox Platform" column in descending order on the Admin page
	When User click on "Server Name" column header on the Admin page
	Then data in table is sorted by "Server Name" column in ascending order on the Admin page
	When User click on "Server Name" column header on the Admin page
	Then data in table is sorted by "Server Name" column in descending order on the Admin page
	When User click on "Mailbox Type" column header on the Admin page
	Then data in table is sorted by "Mailbox Type" column in ascending order on the Admin page
	When User click on "Mailbox Type" column header on the Admin page
	Then data in table is sorted by "Mailbox Type" column in descending order on the Admin page
	When User click on "Owner Display Name" column header on the Admin page
	Then data in table is sorted by "Owner Display Name" column in ascending order on the Admin page
	When User click on "Owner Display Name" column header on the Admin page
	Then data in table is sorted by "Owner Display Name" column in descending order on the Admin page
	When User enters "zoumasu" text in the Search field for "Email Address (Primary)" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "dw-exch13" text in the Search field for "Server Name" column
	Then Counter shows "4,670" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "UserMailbox" text in the Search field for "Mailbox Type" column
	Then Counter shows "14,778" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Rogelio" text in the Search field for "Owner Display Name" column
	Then Counter shows "8" found rows
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Mailbox Platform" column on the Admin page
	And User selects "Exchange 2013" checkbox from String Filter on the Admin page
	Then Counter shows "7,370" found rows
	When User clicks Reset Filters button on the Admin page
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Move To Another Bucket" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	And There are no errors in the browser console
	And Delete "TestBucket8" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12997 @DAS13837 @Buckets @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderOfDevicesAndUsersAndMailboxesListsOfParticularBucket
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	And User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then data in table is sorted by "Hostname" column in ascending order by default on the Admin page
	When User clicks "Users" tab
	Then data in table is sorted by "Username" column in ascending order by default on the Admin page
	When User clicks "Mailboxes" tab
	Then data in table is sorted by "Email Address (Primary)" column in ascending order by default on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnBucketsGrids
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	And User selects all rows on the grid
	And User clicks Reset Filters button on the Admin page
	Then User sees "1" of "558" rows selected label
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User selects all rows on the grid
	Then User sees "17225" of "17225" rows selected label
	When User clicks "Users" tab
	And User selects all rows on the grid
	Then User sees "41339" of "41339" rows selected label
	When User clicks "Mailboxes" tab
	And User selects all rows on the grid
	Then User sees "14784" of "14784" rows selected label

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11748 @Buckets @Delete_Newly_Created_Bucket
Scenario: EvergreenJnr_AdminPage_CheckThatNotificationMessageIsDisplayedAfterUpdatingBucketToDefaultType
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket2" in the "Bucket Name" field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "TestBucket2" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	And User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "TestBucket2" bucket has been updated is displayed on the Buckets page
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Bucket Settings" tab
	Then Default Bucket checkbox is selected
	When User click on Back button
	And User enters "Unassigned" text in the Search field for "Bucket" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Bucket" column
	And User clicks "Bucket Settings" tab
	And User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11879 @DAS12742 @DAS12752 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSpecificWarningMessageIsNotDisplayedAfterTryingToDeleteNonDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Bucket Settings" tab
	Then Default Bucket checkbox is selected
	When User click on Back button
	When User clicks Reset Filters button on the Admin page
	And User enters "Chicago" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	When User clicks Delete button
	Then "You can not delete the default bucket" warning message is not displayed on the Buckets page
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	#Then Counter shows "558" found rows
	When User have opened Column Settings for "Bucket" column
	And User clicks Filter button on the Column Settings panel
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User have opened Column Settings for "Devices" column
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then Content is present in the table on the Admin page
	Then There are no errors in the browser console
	When User have opened Column Settings for "Default" column
	When User clicks "True" checkbox from String Filter on the Admin page
	Then There are no errors in the browser console
	When User have opened Column Settings for "Project" column
	When User clicks "Select All" checkbox from String Filter on the Admin page
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	#Add sorting check for "Bucket" column
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in ascending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in ascending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in descending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11891 @DAS11747 @DAS13471 @Delete_Newly_Created_Bucket @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyBucketName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	Then Search fields for "Devices" column contain correctly value
	Then Search fields for "Users" column contain correctly value
	Then Search fields for "Mailboxes" column contain correctly value
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters " " in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	Then Create Bucket button is disabled
	When User clicks "Buckets" link on the Admin page
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket1" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket1" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Error message with "A bucket already exists with this name" text is displayed
	And There are no errors in the browser console
	Then Delete "TestBucket1" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12905 @DAS12930 @Buckets @Delete_Newly_Created_Bucket @Delete_Newly_Created_Project @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatAddedObjectsThatWasUsedRemovedBucketAreDisplayedCorrectlyInProjectHistory 
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "1Bucket12905" in the "Bucket Name" field
	And User selects "K-Team" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "2Bucket12905" in the "Bucket Name" field
	And User selects "K-Team" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project12905" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "1Bucket12905" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "1Bucket12905" bucket details is displayed to the user
	When User clicks the "ADD DEVICE" Action button
	When User adds following Objects from list
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00HA7MKAVVFDAV  |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	Then following Objects are displayed in Buckets table:
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00HA7MKAVVFDAV  |
	When User click on Back button
	When User enters "2Bucket12905" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "2Bucket12905" bucket details is displayed to the user
	When User clicks the "ADD DEVICE" Action button
	When User adds following Objects from list
	| Objects         |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 00OMQQXWA1DRI6  |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	Then following Objects are displayed in Buckets table:
	| Objects         |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 00OMQQXWA1DRI6  |
	When User click on Back button
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12905" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Project12905" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00HA7MKAVVFDAV  |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 00OMQQXWA1DRI6  |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "10 objects queued for onboarding, 0 objects offboarded" text
	When User click on Back button
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks refresh button in the browser
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Project12905" checkbox from String Filter on the Admin page
	When User enters "1Bucket12905" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	When User clicks Delete button in the warning message
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Project12905" checkbox from String Filter on the Admin page
	When User enters "2Bucket12905" text in the Search field for "Bucket" column
	Then "5" content is displayed in "Devices" column
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "5" content is displayed in "Devices" column
	When User enters "2Bucket12905" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	When User clicks Delete button in the warning message
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Project12905" checkbox from String Filter on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "10" content is displayed in "Devices" column
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12905" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Project12905" is displayed to user
	When User selects "History" tab on the Project details page
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Bucket" column
	When User enters "00I0COBFWHOF27" text in the Search field for "Item" column
	Then "Deleted bucket" italic content is displayed in "Bucket" column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12331 @Buckets @Delete_Newly_Created_Bucket
Scenario: EvergreenJnr_AdminPage_ChecksThatWarningNotificationIsDisappearedAfterSwitchingFocusToAnotherBucket 
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "1Bucket12331" in the "Bucket Name" field
	And User selects "K-Team" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "2Bucket12331" in the "Bucket Name" field
	And User selects "K-Team" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 1Bucket12331     |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 1Bucket12331     |
	Then "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" warning message is not displayed on the Buckets page
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 2Bucket12331     |
	Then "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" warning message is not displayed on the Buckets page