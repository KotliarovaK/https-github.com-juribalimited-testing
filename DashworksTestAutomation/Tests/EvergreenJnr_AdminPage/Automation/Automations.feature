Feature: AutomationsPage
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Update tests with new gold data
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15903 @DAS13467 @DAS16239 @DAS16510 @DAS16511 @DAS16754 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationsLogGridLoads
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User selects "Automation Log" tab on the Project details page
	Then "Automations" sub-menu section is expanded
	Then Columns on Admin page is displayed in following order:
	| ColumnName       |
	| Date             |
	| Type             |
	| Automation       |
	| Action           |
	| Run              |
	| Objects          |
	| User             |
	| Duration (hh:mm) |
	| Outcome          |
	Then Export button is displayed
	When User have opened column settings for "Date" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Scope Object Type" checkbox on the Column Settings panel
	When User select "Scope" checkbox on the Column Settings panel
	When User select "Action Type" checkbox on the Column Settings panel
	When User select "Action Project" checkbox on the Column Settings panel
	When User select "Action Task or Field" checkbox on the Column Settings panel
	When User select "Action Value" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName           |
	| Scope Object Type    |
	| Scope                |
	| Action Type          |
	| Action Project       |
	| Action Task or Field |
	| Action Value         |
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "1803 Rollout" checkbox from String Filter on the Admin page
	#Update rows count
	#Then Counter shows "8 of 10" found rows
	When User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15735 @DAS15805 @DAS16764 @DAS16728 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckRunStatusColumnOnTheAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	Then Columns on Admin page is displayed in following order:
	| ColumnName  |
	|             |
	| Automation  |
	|             |
	| Active      |
	| Running     |
	| Scope       |
	| Run         |
	| Actions     |
	| Description |
	Then "FALSE" content is displayed in "Running" column
	When User enters "DELAY (DO NOT DELETE)" text in the Search field for "Automation" column
	Then "TRUE" content is displayed in "Active" column
	When User selects all rows on the grid
	Then following items are displayed in the Actions dropdown:
	| Items         |
	| Run now       |
	| Make active   |
	| Make inactive |
	| Delete        |
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	Then Warning message with "Are you sure you wish to run 1 automation?" text is displayed on the Admin page
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User enters "DELAY (DO NOT DELETE)" text in the Search field for "Automation" column
	Then "TRUE" content is displayed in "Run Status" column
	When User clicks Cog-menu for "DELAY (DO NOT DELETE)" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Run now          |
	| Duplicate        |
	| Move to top      |
	| Move to position |
	| Make inactive    |
	#Check Delay Running Automation
	When User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "Cannot delete a running automation" text is displayed on the Admin page
	When User clicks Reset Filters button on the Admin page
	When User moves "AM 110619 Devices" automation to "z-test" automation
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Processing order" checkbox on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page

#Need to use three Automations: inactive, inactive, active
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15739 @DAS15740 @DAS15741 @DAS16764 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuIsWorkedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	#First inactive automation
	When User clicks Cog-menu for "zAutomation Devices" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |
	#Second inactive automation
	When User clicks Cog-menu for "Akhila Edinburgh Computer 1" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |
	#Third active automation
	When User clicks Cog-menu for "Akhila Edinburgh Computer 2" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Run now          |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make inactive    |
	| Delete           |
	When User enters "Akhila Edinburgh Computer 2" text in the Search field for "Automation" column
	Then "TRUE" content is displayed for "Active" column
	When User clicks "Make inactive" option in Cog-menu for "Akhila Edinburgh Computer 2" item on Admin page
	Then "FALSE" content is displayed for "Active" column
	When User clicks Cog-menu for "Akhila Edinburgh Computer 2" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |
	When User clicks "Make active" option in Cog-menu for "Akhila Edinburgh Computer 2" item on Admin page
	Then "TRUE" content is displayed for "Active" column
	When User clicks "Edit" option in Cog-menu for "Akhila Edinburgh Computer 2" item on Admin page
	Then Edit Automation page is displayed to the User
	Then Automation "Akhila Edinburgh Computer 2" is displayed to user

#Need to use three Automations: inactive, inactive, active
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15742 @DAS16764 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuMoveToTopOptionWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	#Update after gold data was complete
	Then Columns on Admin page is displayed in following order:
    | ColumnName       |
    |                  |
    | Automation       |
    |                  |
    | Processing order |
    | Active           |
    | Run Status       |
    | Scope            |
    | Run              |
    | Actions          |
    | Description      |
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User clicks "Move to top" option in Cog-menu for "Add data" item on Admin page
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items        |
	| AM 150419 II |
	| Add data     |
	When User clicks "Administration" navigation link on the Admin page
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items        |
	| AM 150419 II |
	| Add data     |

#Need to use three Automations: inactive, inactive, active
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15743 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuMoveToBottomOptionWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	#Update after gold data was complete
	When User clicks Cog-menu for "AM Test 1" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Run now          |
	| Duplicate        |
	| Move to top      |
	| Move to position |
	| Make inactive    |
	| Delete           |
	When User clicks Cog-menu for "AM 150419 II" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Run now          |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make inactive    |
	| Delete           |
	When User clicks "Move to bottom" option in Cog-menu for "AM 150419 II" item on Admin page
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items         |
	| AM 150419 I   |
	| AM 150419 III |
	| AM Test 1     |
	| AM 150419 II  |
	When User clicks "Administration" navigation link on the Admin page
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items         |
	| AM 150419 I   |
	| AM 150419 III |
	| AM Test 1     |
	| AM 150419 II  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15744 @DAS16764 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuMoveToPositionOptionWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User move "AM 150419 II" item to "2" position on Admin page
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items         |
	| AM 150419 I   |
	| AM 150419 II  |
	| AM 150419 III |
	| AM Test 1     |
	When User move "AM 150419 I" item to "100" position on Admin page
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items         |
	| AM 150419 II  |
	| AM 150419 III |
	| AM Test 1     |
	| AM 150419 I   |
	When User move " AM 150419 II" item to "1" position on Admin page
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items         |
	| AM 150419 II  |
	| AM 150419 III |
	| AM Test 1     |
	| AM 150419 I   |

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15749 @DAS15750 @DAS16899 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatDeleteOptionForAutomationsCogmenuWorksCorrectlyForDifferentRunningState
#Use specific Automation (Delay) that run longer
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
#change item name when state status will be fixed
	When User clicks "Run now" option in Cog-menu for "Delay_Automation" item on Admin page
	When User clicks the "RUN" Action button
	Then Warning message with "Are you sure you wish to run 1 automation?" text is displayed on the Admin page
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks "Delete" option in Cog-menu for "Delay_Automation" item on Admin page
	Then "Delay_Automation" item is not displayed in the grid on Admin page
	Then Error message with "This automation is currently running" text is displayed
	When User clicks Cog-menu for "Delay_Automation" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15634 @DAS15756 @DAS15754 @Not_Ready
#Change value after gold data complete added
Scenario: EvergreenJnr_AdminPage_CheckThatActionsGridLoadsWithActionsForAnAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 030619 Devices 1" text in the Search field for "Automation" column
	Then "2" content is displayed in "Actions" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	Then Counter shows "2" found rows
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	|               |
	| Action        |
	|               |
	| Type          |
	| Project       |
	| Task or Field |
	| Value         |
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "ActionId" checkbox on the Column Settings panel
	When User select "Processing order" checkbox on the Column Settings panel
	When User select "ActionTypeId" checkbox on the Column Settings panel
	When User select "Project ID" checkbox on the Column Settings panel
	Then Columns on Admin page is displayed in following order:
	| ColumnName       |
	|                  |
	| ActionId         |
	| Action           |
	|                  |
	| Processing order |
	| ActionTypeId     |
	| Type             |
	| Project ID       |
	| Project          |
	| Task or Field    |
	| Value            |
	#Check that grid has at least three actions
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "15309_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the Path dropdown
	And User clicks the "CREATE" Action button
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Processing order" checkbox on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16764 @DAS16998 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckDeleteAutomationFunctionality
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "16764_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "16764" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	When User clicks newly created object link
	Then "All Devices" content is displayed in the Scope Automation dropdown
	When User clicks "Automations" navigation link on the Admin page
	When User clicks "Delete" option in Cog-menu for "16764_Automation" item on Admin page
	Then Warning message with "Are you sure you wish to delete 1 automation?" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	When User clicks "Delete" option in Cog-menu for "16764_Automation" item on Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "1 automation deleted" text