Feature: ActionsPage
	Runs Actions Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Use different Automation for tests
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @Actions @DAS15427 @DAS15832 @DAS15833
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckThatActionsGridCogMenuShowsTheCorrectOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 030619 Devices 1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Check Cog Menu for the first Action
	When User clicks Cog-menu for "AM 030619 Action 1" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	#Check Cog Menu for the second Action
	When User clicks Cog-menu for "AM 030619 Action 2" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	#Check Cog Menu for the last Action
	When User clicks Cog-menu for "15309_Action" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	When User clicks "Edit" option in Cog-menu for "AM 030619 Action 1" item on Admin page
	Then Edit Action page is displayed to the User
	Then "UPDATE" Action button is displayed
	Then "CANCEL" Action button is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15427 @DAS15428 @DAS16728
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckMoveToOptionWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "QA Automation Users" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	Then Actions dropdown is disabled
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "DAS15427_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the Path dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The automation action has been created" text
	When User clicks "Move to top" option in Cog-menu for "15309_Action" item on Admin page
	Then "Action" column content is displayed in the following order:
    | Items              |
    | 15309_Action       |
    | AM 030619 Action 1 |
    | AM 030619 Action 2 |
    | DAS15427_Action    |
	When User clicks "Move to bottom" option in Cog-menu for "15309_Action" item on Admin page
	Then "Action" column content is displayed in the following order:
    | Items              |
    | AM 030619 Action 1 |
    | AM 030619 Action 2 |
	| DAS15427_Action    |
	| 15309_Action       |
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User move "15309_Action" item to "4" position on Admin page
	Then "Action" column content is displayed in the following order:
    | Items              |
    | AM 030619 Action 1 |
    | AM 030619 Action 2 |
	| DAS15427_Action    |
	| 15309_Action       |
	When User move "15309_Action" item to "1" position on Admin page
	Then "Action" column content is displayed in the following order:
    | Items              |
	| 15309_Action       |
    | AM 030619 Action 1 |
    | AM 030619 Action 2 |
	| DAS15427_Action    |
	When User move "15309_Action" item to "20" position on Admin page
	Then "Action" column content is displayed in the following order:
    | Items              |
    | AM 030619 Action 1 |
    | AM 030619 Action 2 |
	| DAS15427_Action    |
	| 15309_Action       |
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	When User clicks "Delete" option in Cog-menu for "DAS15427_Action" item on Admin page
	Then Warning message with "Are you sure you wish to delete 1 action?" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	When User clicks "Delete" option in Cog-menu for "DAS15427_Action" item on Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected action has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Actions @DAS15428
#Change value after gold data complete added
#Selected automation should have at least three actions
Scenario: EvergreenJnr_AdminPage_CheckActionsReorderingFunctionality
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 030619 Mailboxes 1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User clicks "Actions" tab
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User type "15428_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "[Default (Application)]" in the Path dropdown
	And User clicks the "CREATE" Action button
	When User moves "15428_Action" action to "AM 030619 Mailbox Action 1" action
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	And User select "Processing order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page
	Then "Action" column content is displayed in the following order:
	| Items                      |
	| AM 030619 Mailbox Action 1 |
	| 15428_Action               |
	| AM 030619 Mailbox Action 2 |
	| AM 1                       |
	When User select "Action" rows in the grid
	| SelectedRowsName |
	| 15428_Action     |
	And User removes selected item