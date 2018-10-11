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
	Then "NotDefaultCapacityUnit13720" text is displayed in the table content
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
	When User clicks content from "Capacity Unit" column
	Then "Devices" tab is selected on the Admin page
	When User selects "Unit Settings" tab on the Capacity Units page
	Then "Unit Settings" tab is selected on the Admin page