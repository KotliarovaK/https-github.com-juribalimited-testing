Feature: AutomationsGrid
	Runs Automations Grid related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774 @Do_Not_Run_With_Automations @Do_Not_Run_With_Actions @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckFiltersForAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks String Filter button for "Active" column on the Admin page
	When User selects "True" checkbox from String Filter on the Admin page
	Then "Inactive_Automation" content is displayed for "Automation" column
	Then "FALSE" content is displayed in "Active" column
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "All Mailboxes" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "All Users" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "Auto: X-Proj Paths Scope" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "Empty" checkbox from String Filter on the Admin page
	Then "All Devices" content is displayed in "Scope" column
	When User clicks Reset Filters button on the Admin page
	And User enters "3" text in the Search field for "Actions" column
	Then Rows counter shows "4" of "16" rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Delay" text in the Search field for "Automation" column
	Then Rows counter shows "8" of "16" rows
	When User clicks Reset Filters button on the Admin page
	When User clicks Group By button on the Admin page and selects "Active" value
	Then Cog menu is not displayed on the Admin page
	Then Grid is grouped

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774 @Not_Ready
#Run steps after fixing Boolean sorting
Scenario: EvergreenJnr_AdminPage_CheckSortingAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks on 'Automation' column header
	Then data in table is sorted by "Automation" column in ascending order on the Admin page
	When User clicks on 'Automation' column header
	Then data in table is sorted by "Automation" column in descending order on the Admin page
	When User clicks on 'Active' column header
	Then Boolean data in table is sorted by "Active" column in ascending order on the Admin page
	When User clicks on 'Active' column header
	Then Boolean data in table is sorted by "Active" column in descending order on the Admin page
	When User clicks on 'Running' column header
	Then Boolean data in table is sorted by "Running" column in ascending order on the Admin page
	When User clicks on 'Running' column header
	Then Boolean data in table is sorted by "Running" column in descending order on the Admin page
	When User clicks on 'Scope' column header
	Then data in table is sorted by "Scope" column in ascending order on the Admin page
	When User clicks on 'Scope' column header
	Then data in table is sorted by "Scope" column in descending order on the Admin page
	When User clicks on 'Run' column header
	Then data in table is sorted by "Run" column in ascending order on the Admin page
	When User clicks on 'Run' column header
	Then data in table is sorted by "Run" column in descending order on the Admin page
	When User clicks on 'Actions' column header
	Then numeric data in table is sorted by "Actions" column in descending order on the Admin page
	When User clicks on 'Actions' column header
	Then numeric data in table is sorted by "Actions" column in ascending order on the Admin page
	When User clicks on 'Description' column header
	Then data in table is sorted by "Description" column in ascending order on the Admin page
	When User clicks on 'Description' column header
	Then data in table is sorted by "Description" column in descending order on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774
Scenario: EvergreenJnr_AdminPage_CheckUnsavedChangesPopUp
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User click content from "Automation" column
	When User enters 'NewName' text to 'Automation Name' textbox
	When User clicks 'Automations' header breadcrumb
	Then "You have unsaved changes. Are you sure you want to leave the page?" text is displayed in the warning message
	Then "YES" button is displayed in the warning message
	Then "NO" button is displayed in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17286
Scenario: EvergreenJnr_AdminPage_CheckCreatedByAndCreatedDateColumnOnTheAutomationsGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Created By" checkbox on the Column Settings panel
	When User select "Created Date" checkbox on the Column Settings panel
	When User clicks on 'Created By' column header
	Then data in table is sorted by 'Created By' column in ascending order
	When User clicks on 'Created By' column header
	Then data in table is sorted by 'Created By' column in descending order
	When User clicks on 'Created Date' column header
	Then date in table is sorted by 'Created Date' column in descending order
	When User clicks on 'Created Date' column header
	Then date in table is sorted by 'Created Date' column in ascending order
	When User enters "[User not found]" text in the Search field for "Created By" column
	Then Rows counter contains "7" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User enters '9 Aug 2019' text in the Search field for 'Created Date' datepicker
	Then Rows counter contains "6" found row of all rows