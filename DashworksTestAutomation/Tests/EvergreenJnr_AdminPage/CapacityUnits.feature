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

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632
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
	And "NotDefaultCapacityUnit13720" text is displayed in the table content
	When User enters "NotDefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then "FALSE" value is displayed for Default column
	And "" content is displayed in "Devices" column
	And "" content is displayed in "Users" column
	And "" content is displayed in "Mailboxes" column
	And "" content is displayed in "Applications" column
	When User clicks content from "Capacity Unit" column
	Then "Devices" tab is selected on the Admin page
	When User selects "Unit Settings" tab on the Capacity Units page
	Then "Unit Settings" tab is selected on the Admin page
	When User click on Back button
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName            |
	| NotDefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This unit will be permanently deleted and any objects within it reassigned to the default unit" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text

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
	And "DefaultCapacityUnit13720" text is displayed in the table content
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column
	And "" content is displayed in "Devices" column
	And "" content is displayed in "Users" column
	And "" content is displayed in "Mailboxes" column
	And "" content is displayed in "Applications" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "FALSE" value is displayed for Default column
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	Then "Devices" tab is selected on the Admin page
	When User selects "Unit Settings" tab on the Capacity Units page
	Then "Unit Settings" tab is selected on the Admin page
	When User click on Back button
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
	| SelectedRowsName            |
	| DefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatDevicesAreAddedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "CapacityUnit12141" Name in the "Capacity Unit Name" field on the Project details page
	And User type "12141" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12141 capacity unit" link
	And "CapacityUnit12141" text is displayed in the table content
	When User clicks newly created object link
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects         |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 01ERDGD48UDQKE  |
	And User clicks the "ADD DEVICES" Action button
	Then data in table is sorted by "Hostname" column in ascending order by default on the Admin page
	And Success message is displayed and contains "The selected devices have been queued for update, if they do not appear immediately try refreshing the grid" text
	When User refreshes agGrid
		#write step when refresh will be work correctly
	#Then Success message is displayed and contains "" text
	And User close message on the Admin page