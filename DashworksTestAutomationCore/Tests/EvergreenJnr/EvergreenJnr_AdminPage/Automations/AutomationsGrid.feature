Feature: AutomationsGrid
	Runs Automations Grid related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774 @Do_Not_Run_With_Automations @Do_Not_Run_With_Actions
Scenario: EvergreenJnr_AdminPage_CheckFiltersForAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks String Filter button for "Active" column on the Admin page
	When User selects "True" checkbox from String Filter on the Admin page
	Then "Inactive_Automation" content is displayed for "Automation" column
	Then 'FALSE' content is displayed in the 'Active' column
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "Auto: X-Proj Paths Scope" checkbox from String Filter on the Admin page
	Then 'Auto: X-Proj Paths Scope' content is displayed in the 'Scope' column
	When User clicks Reset Filters button on the Admin page
	When User enters "3" text in the Search field for "Actions" column
	When User enters "test" text in the Search field for "Description" column
	Then 'Devices_Scope' content is displayed in the 'Automation' column
	When User clicks Reset Filters button on the Admin page
	When User enters "Delay" text in the Search field for "Automation" column
	Then Rows counter contains "8" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Active     | true  |
	Then Cog menu is not displayed on the Admin page
	Then Grid is grouped

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774 @Do_Not_Run_With_Automations @Do_Not_Run_With_Actions
Scenario: EvergreenJnr_AdminPage_CheckSortingAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks on 'Automation' column header
	Then data in table is sorted by 'Automation' column in ascending order
	When User clicks on 'Automation' column header
	Then data in table is sorted by 'Automation' column in descending order
	#Run steps after fixing Boolean sorting
	#When User clicks on 'Active' column header
	#Then boolean data is sorted by 'Active' column in ascending order
	#When User clicks on 'Active' column header
	#Then boolean data is sorted by 'Active' column in descending order
	#When User clicks on 'Running' column header
	#Then boolean data is sorted by 'Running' column in ascending order
	#When User clicks on 'Running' column header
	#Then boolean data is sorted by 'Running' column in descending order
	When User clicks on 'Scope' column header
	Then data in table is sorted by 'Scope' column in ascending order
	When User clicks on 'Scope' column header
	Then data in table is sorted by 'Scope' column in descending order
	When User clicks on 'Run' column header
	Then data in table is sorted by 'Run' column in ascending order
	When User clicks on 'Run' column header
	Then data in table is sorted by 'Run' column in descending order
	When User clicks on 'Actions' column header
	Then numeric data in table is sorted by 'Actions' column in descending order
	When User clicks on 'Actions' column header
	Then numeric data in table is sorted by 'Actions' column in ascending order
	When User clicks on 'Description' column header
	Then data in table is sorted by 'Description' column in ascending order
	When User clicks on 'Description' column header
	Then data in table is sorted by 'Description' column in descending order

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774
Scenario: EvergreenJnr_AdminPage_CheckUnsavedChangesPopUp
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User click content from "Automation" column
	When User enters 'NewName' text to 'Automation Name' textbox
	When User clicks 'Automations' header breadcrumb
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup
	Then "YES" button is displayed in the warning message
	Then "NO" button is displayed in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17286
Scenario: EvergreenJnr_AdminPage_CheckCreatedByAndCreatedDateColumnOnTheAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User opens 'Automation' column settings
	When User clicks Column button on the Column Settings panel
	When User select "Description" checkbox on the Column Settings panel
	When User select "Created By" checkbox on the Column Settings panel
	When User clicks on 'Created By' column header
	Then data in table is sorted by 'Created By' column in ascending order
	When User clicks on 'Created By' column header
	Then data in table is sorted by 'Created By' column in descending order
	When User enters "[User not found]" text in the Search field for "Created By" column
	Then Rows counter contains "7" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User opens 'Automation' column settings
	When User select "Created By" checkbox on the Column Settings panel
	When User select "Created Date" checkbox on the Column Settings panel
	When User clicks on 'Created Date' column header
	Then date in table is sorted by 'Created Date' column in descending order
	When User clicks on 'Created Date' column header
	Then date in table is sorted by 'Created Date' column in ascending order
	When User enters '9 Aug 2019' text in the Search field for 'Created Date' datepicker
	Then Rows counter contains "6" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS18346 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckObjectTypeFieldOnAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User opens 'Automation' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object Type" checkbox on the Column Settings panel
	When User clicks String Filter button for "Object Type" column
	When User selects "Devices" checkbox from String Filter on the Admin page
	Then "DAS-15949 - all users scope" content is displayed for "Automation" column
	When User clicks content from "Automation" column
	Then 'Users' content is displayed in 'Object Type' autocomplete

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20328 @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckScopeClickableLinkOnTheAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "AV Automation - CF" text in the Search field for "Automation" column
	When User enters "Devices_Scope" text in the Search field for "Automation" column
	When User clicks content from "Scope" column
	Then 'All Devices' list should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS21033 @Yellow_Dwarf
Scenario: EvergreenJnr_AdminPage_CheckGroupAutomationsByScope
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Scope      | true  |
	Then Cog menu is not displayed on the Admin page
	Then Grid is grouped
	When User expands 'All Users' row in the groped grid
	Then "DAS-15949 - all users scope" content is displayed for "Automation" column