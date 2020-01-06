Feature: Buckets
	Runs Buckets related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Buckets @DAS12999 @DAS13420 @DAS13837 @Buckets @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingDevicesFromBuckets
	When User creates new Bucket via api
	| Name        | TeamName | IsDefault |
	| TestBucket6 | Admin IT | false     |
	And User navigates to newly created Bucket
	Then Page with 'TestBucket6' header is displayed to user
	When User navigates to the 'Devices' tab on Project Scope Changes page
	And User clicks 'ADD DEVICE' button 
	And User navigates to the 'Add from buckets' left menu item
	And User adds "Unassigned" objects to bucket
	And User clicks 'ADD DEVICES' button 
	Then 'The selected devices have been added to the selected bucket' text is displayed on inline success banner
	And There are no errors in the browser console
	Then data in table is sorted by 'Hostname' column in ascending order by default
	Then Counter shows "17,225" found rows
	When User click on "Hostname" column header on the Admin page
	Then data in table is sorted by 'Hostname' column in ascending order
	When User click on "Hostname" column header on the Admin page
	Then data in table is sorted by 'Hostname' column in descending order
	When User click on "Type" column header on the Admin page
	Then data in table is sorted by 'Type' column in ascending order
	When User click on "Type" column header on the Admin page
	Then data in table is sorted by 'Type' column in descending order
	When User click on "Operating System" column header on the Admin page
	Then data in table is sorted by 'Operating System' column in ascending order
	When User click on "Operating System" column header on the Admin page
	Then data in table is sorted by 'Operating System' column in descending order
	#When User click on "Owner Display Name" column header on the Admin page
	#Then data in table is sorted by 'Owner Display Name' column in ascending order
	#When User click on "Owner Display Name" column header on the Admin page
	#Then data in table is sorted by 'Owner Display Name' column in descending order
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
	And User selects 'Move To Another Bucket' in the 'Actions' dropdown
	And User clicks 'CONTINUE' button 
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then 'The selected devices have been added to the selected bucket' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13420 @DAS13837 @Buckets @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingMailboxesFromBuckets
	When User creates new Bucket via api
	| Name        | TeamName | IsDefault |
	| TestBucket8 | Admin IT | false     |
	And User navigates to newly created Bucket
	Then Page with 'TestBucket8' header is displayed to user
	When User navigates to the 'Mailboxes' left menu item
	And User clicks 'ADD MAILBOX' button 
	And User navigates to the 'Add from buckets' left menu item
	And User adds "Unassigned" objects to bucket
	And User clicks 'ADD MAILBOXES' button 
	Then 'The selected mailboxes have been added to the selected bucket' text is displayed on inline success banner
	And data in table is sorted by 'Email Address (Primary)' column in ascending order by default
	And Counter shows "14,784" found rows
	When User click on "Email Address (Primary)" column header on the Admin page
	Then data in table is sorted by 'Email Address (Primary)' column in ascending order
	When User click on "Email Address (Primary)" column header on the Admin page
	Then data in table is sorted by 'Email Address (Primary)' column in descending order
	When User click on "Mailbox Platform" column header on the Admin page
	Then data in table is sorted by 'Mailbox Platform' column in ascending order
	When User click on "Mailbox Platform" column header on the Admin page
	Then data in table is sorted by 'Mailbox Platform' column in descending order
	When User click on "Server Name" column header on the Admin page
	Then data in table is sorted by 'Server Name' column in ascending order
	When User click on "Server Name" column header on the Admin page
	Then data in table is sorted by 'Server Name' column in descending order
	When User click on "Mailbox Type" column header on the Admin page
	Then data in table is sorted by 'Mailbox Type' column in ascending order
	When User click on "Mailbox Type" column header on the Admin page
	Then data in table is sorted by 'Mailbox Type' column in descending order
	When User click on "Owner Display Name" column header on the Admin page
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User click on "Owner Display Name" column header on the Admin page
	Then data in table is sorted by 'Owner Display Name' column in descending order
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
	And User selects 'Move To Another Bucket' in the 'Actions' dropdown
	And User clicks 'CONTINUE' button 
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then 'The selected mailboxes have been added to the selected bucket' text is displayed on inline success banner
	And There are no errors in the browser console
	And Delete "TestBucket8" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12905 @DAS12930 @DAS13973 @Buckets @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatAddedObjectsThatWasUsedRemovedBucketAreDisplayedCorrectlyInProjectHistory 
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode      |
	| Project12905 | All Devices | None            | Evergreen |
	When User creates new Bucket via api
	| Name         | TeamName | IsDefault |
	| 1Bucket12905 | K-Team   | false     |
	| 2Bucket12905 | K-Team   | false     |
	And User navigates to newly created Bucket
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User enters "1Bucket12905" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Page with '1Bucket12905' header is displayed to user
	When User clicks 'ADD DEVICE' button 
	When User expands 'UPDATE INPUT DATA' multiselect and selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00HA7MKAVVFDAV  |
	When User clicks "ADD BUCKETS" button
	Then 'The selected devices have been added to the selected bucket' text is displayed on inline success banner
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
	Then Page with '2Bucket12905' header is displayed to user
	When User clicks 'ADD DEVICE' button 
	When User expands 'UPDATE INPUT DATA' multiselect and selects following Objects
	| Objects         |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 00OMQQXWA1DRI6  |
	When User clicks "ADD BUCKETS" button
	Then 'The selected devices have been added to the selected bucket' text is displayed on inline success banner
	Then following Objects are displayed in Buckets table:
	| Objects         |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 00OMQQXWA1DRI6  |
	When User click on Back button
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "Project12905" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with 'Project12905' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
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
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '10 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User click on Back button
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks refresh button in the browser
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Project12905" checkbox from String Filter with item list on the Admin page
	When User enters "1Bucket12905" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button 
	When User clicks 'DELETE' button on inline tip banner
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Project12905" checkbox from String Filter with item list on the Admin page
	When User enters "2Bucket12905" text in the Search field for "Bucket" column
	Then '5' content is displayed in the 'Devices' column
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then '5' content is displayed in the 'Devices' column
	When User enters "2Bucket12905" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button 
	When User clicks 'DELETE' button on inline tip banner
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Project12905" checkbox from String Filter on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then '10' content is displayed in the 'Devices' column
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "Project12905" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with 'Project12905' header is displayed to user
	When User navigates to the 'History' left menu item
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then 'Unassigned' content is displayed in the 'Bucket' column
	When User enters "00I0COBFWHOF27" text in the Search field for "Item" column
	Then "Deleted bucket" italic content is displayed