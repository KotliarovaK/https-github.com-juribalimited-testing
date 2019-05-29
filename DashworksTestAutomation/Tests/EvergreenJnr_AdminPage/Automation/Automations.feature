Feature: AutomationsPage
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15903 @DAS13467 @DAS16239 @DAS16510 @DAS
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
	Then Counter shows "8 of 10" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15735 @DAS15805
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
	| Run Status  |
	| Scope       |
	| Run         |
	| Actions     |
	| Description |
	Then "FALSE" content is displayed in "Run Status" column
	When User enters "New automation - Alex" text in the Search field for "Automation" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	#Uncommented step after amber message selector fixed
	#Then Warning message with "Are you sure you wish to run 1 automation ?" text is displayed on the Admin page
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	Then "TRUE" content is displayed in "Run Status" column
	When User moves "AM 0904 1" automation to "New automation - Alex" automation
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Processing order" checkbox on the Column Settings panel
	Then User sees following Processing order on the Automation page
	| Values |
	| 1      |
	| 2      |
	| 3      |
	| 4      |
	| 5      |
	| 6      |
	| 7      |
	| 8      |
	| 9      |

#May need to add creation three 'Automations' for this test later??
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15739 @DAS15740 @DAS15741 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuIsWorkedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
#Remove hash after fix issue with 'Run Status' state
	#When User clicks Cog-menu for "AM 150419 I" item on Admin page
	#Then User sees following cog-menu items on Admin page:
	#| items            |
	#| Edit             |
	#| Duplicate        |
	#| Move to top      |
	#| Move to bottom   |
	#| Move to position |
	#| Make active      |
	#| Delete           |
	#When User clicks Cog-menu for "AM 150419 II" item on Admin page
	#Then User sees following cog-menu items on Admin page:
	#| items            |
	#| Edit             |
	#| Duplicate        |
	#| Move to top      |
	#| Move to bottom   |
	#| Move to position |
	#| Make active      |
	#| Delete           |
	When User clicks Cog-menu for "AM 150419 III" item on Admin page
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
	When User enters "AM 150419 III" text in the Search field for "Automation" column
	Then "TRUE" content is displayed for "Active" column
	When User clicks "Make inactive" option in Cog-menu for "AM 150419 III" item on Admin page
	Then "FALSE" content is displayed for "Active" column
	When User clicks Cog-menu for "AM 150419 III" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |
	When User clicks "Make active" option in Cog-menu for "AM 150419 III" item on Admin page
	Then "TRUE" content is displayed for "Active" column
	When User clicks "Edit" option in Cog-menu for "AM 150419 III" item on Admin page
	Then "Update Automation" page is displayed to the user on Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15742 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuMoveToTopOptionWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
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
	#When User clicks Cog-menu for "AM 150419 I" item on Admin page
	#Then User sees following cog-menu items on Admin page:
	#| items            |
	#| Edit             |
	#| Run now          |
	#| Duplicate        |
	#| Move to bottom   |
	#| Move to position |
	#| Make inactive    |
	#| Delete           |
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
	When User clicks "Move to top" option in Cog-menu for "AM 150419 II" item on Admin page
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Automation" column content is displayed in the following order:
	| Items         |
	| AM 150419 II  |
	| AM 150419 I   |
	| AM 150419 III |
	| AM Test 1     |
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
	| AM 150419 II  |
	| AM 150419 I   |
	| AM 150419 III |
	| AM Test 1     |

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
	#When User clicks Cog-menu for "AM Test 1" item on Admin page
	#Then User sees following cog-menu items on Admin page:
	#| items            |
	#| Edit             |
	#| Run now          |
	#| Duplicate        |
	#| Move to top      |
	#| Move to position |
	#| Make inactive    |
	#| Delete           |
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15744 @Not_Ready
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15749 @DAS15750 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatDeleteOptionForAutomationsCogmenuWorksCorrectlyForDifferentRunningState
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
#change item name when state status will be fixed
	When User clicks "Remove" option in Cog-menu for "AM 150419 III" item on Admin page
	Then "AM 150419 III" item is not displayed in the grid on Admin page
	When User clicks "Remove" option in Cog-menu for "AM 150419 II" item on Admin page
	Then Error message with "This automation is currently running" text is displayed
	When User clicks Cog-menu for "AM 150419 II" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |