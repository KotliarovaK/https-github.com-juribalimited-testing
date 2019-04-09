Feature: AutomationsPage
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15903 @DAS13467 @DAS16239
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationsLogGridLoads
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User selects "Automation Log" tab on the Project details page
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
	#Then Warning message with "Are you sure you wish to run 1 automation ?" text is displayed on the Admin page
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	#Then "TRUE" content is displayed in "Run Status" column
	When User moves "AM 0904 1" automation to "New automation - Alex" automation
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Processing order" checkbox on the Column Settings panel
	Then User sees following Processing order on the Automation page
	Then following content is displayed in the "Processing order" column
         | Values |
         |        |