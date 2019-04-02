Feature: AutomationsPage
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS15903 @DAS13467 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationsLogGridLoads
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User selects "Automation Log" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName |
	| Date       |
	| Type       |
	| Automation |
	| Action     |
	| Run        |
	| Objects    |
	| User       |
	| Duration   |
	| Outcome    |
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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS15735 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckRunStatusColumnOnTheAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	Then Columns on Admin page is displayed in following order:
	| ColumnName  |
	|             |
	|             |
	| Automation  |
	|             |
	| Active      |
	| Run Status  |
	| Scope       |
	| Run         |
	| Action      |
	| Description |
	Then "FALSE" content is displayed in "Run Status" column
	When User enters "AM Auto 1" text in the Search field for "Automation" column
	And User clicks on Actions button
	And User selects "Run Now" in the Actions
	Then "TRUE" content is displayed in "Run Status" column