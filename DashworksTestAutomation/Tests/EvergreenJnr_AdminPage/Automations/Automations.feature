Feature: AutomationsPage
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Update tests with new gold data
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15903 @DAS13467 @DAS16239 @DAS16510 @DAS16511 @DAS16754 @DAS16890 @DAS17222 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationsLogGridLoads
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User selects "Automation Log" tab on the Project details page
	Then "Automations" sub-menu section is expanded
	Then Columns on Admin page is displayed in following order:
	| ColumnName          |
	| Date                |
	| Type                |
	| Automation          |
	| Action              |
	| Run                 |
	| Objects             |
	| Duration (hh:mm:ss) |
	| User                |
	| Outcome             |
	Then Export button is displayed
	Then "SUCCESS" content is displayed in "Outcome" column
	When User have opened column settings for "Date" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Scope Object Type" checkbox on the Column Settings panel
	When User select "Scope" checkbox on the Column Settings panel
	When User select "Action Type" checkbox on the Column Settings panel
	When User select "Action Project" checkbox on the Column Settings panel
	When User select "Action Task or Field" checkbox on the Column Settings panel
	When User select "Action Value" checkbox on the Column Settings panel
	When User select "Action Value ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName           |
	| Scope Object Type    |
	| Scope                |
	| Action Type          |
	| Action Project       |
	| Action Task or Field |
	| Action Value ID      |
	| Action Value         |
	When User clicks String Filter button for "Scope" column on the Admin page
	When User selects "1803 Rollout" checkbox from String Filter on the Admin page
	#Update rows count
	#Then Counter shows "8 of 10" found rows
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	Then "Edit Automation" title is displayed on the Automations page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15735 @DAS15805 @DAS16764 @DAS16728 @DAS17222 @Not_Ready
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
	When User enters "DELAY_2" text in the Search field for "Automation" column
	Then "TRUE" content is displayed in "Active" column
	When User selects all rows on the grid
	Then following Values are displayed in the 'Actions' dropdown:
	| Values        |
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
	When User enters "DELAY_2" text in the Search field for "Automation" column
	Then "TRUE" content is displayed in "Running" column
	When User clicks Cog-menu for "DELAY_2" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make inactive    |
	When User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	When User clicks Delete button in the warning message
	Then Warning message with "Cannot delete a running automation" text is displayed on the Admin page
	When User moves "Applications_Scope" automation to "DELAY_8" automation
	When User have opened column settings for "Automation" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Processing order" checkbox on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page

#Need to use three Automations: inactive, inactive, active
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15431 @DAS15739 @DAS15740 @DAS15741 @DAS16764 @DAS17222 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCogMenuIsWorkedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName        | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 15431_First_Inactive  | DAS15431    | false  | false              | All Users | Manual |
	| 15431_Second_Inactive | DAS15431    | false  | false              | All Users | Manual |
	| 15431_Third_Active    | DAS15431    | true   | false              | All Users | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	#First inactive automation
	When User clicks Cog-menu for "15431_First_Inactive" item on Admin page
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
	When User clicks Cog-menu for "15431_Second_Inactive" item on Admin page
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
	When User clicks Cog-menu for "15431_Third_Active" item on Admin page
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
	When User enters "15431_Third_Active" text in the Search field for "Automation" column
	Then "TRUE" content is displayed for "Active" column
	When User clicks "Make inactive" option in Cog-menu for "15431_Third_Active" item on Admin page
	When User enters "15431_Third_Active" text in the Search field for "Automation" column
	Then "FALSE" content is displayed for "Active" column
	When User clicks Cog-menu for "15431_Third_Active" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make active      |
	| Delete           |
	When User clicks "Make active" option in Cog-menu for "15431_Third_Active" item on Admin page
	When User enters "15431_Third_Active" text in the Search field for "Automation" column
	Then "TRUE" content is displayed for "Active" column
	When User clicks "Edit" option in Cog-menu for "15431_Third_Active" item on Admin page
	Then "Edit Automation" title is displayed on the Automations page
	Then Automation "15431_Third_Active" is displayed to user

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
    | Running          |
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
#Update after gold data was complete
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
	When User clicks "Run now" option in Cog-menu for "DELAY - do not delete3" item on Admin page
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
	When User enters "DELAY - do not delete3" text in the Search field for "Automation" column
	When User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	When User clicks Delete button in the warning message
	Then Warning message with "Cannot delete a running automation" text is displayed on the Admin page
	When User clicks Cog-menu for "DELAY - do not delete3" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Make inactive    |

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15634 @DAS15756 @DAS15754 @DAS17277 @Not_Ready
#Change value after gold data complete added
Scenario: EvergreenJnr_AdminPage_CheckThatActionsGridLoadsWithActionsForAnAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 030619 Devices 145" text in the Search field for "Automation" column
	Then "3" content is displayed in "Actions" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	Then Counter shows "3" found rows
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
	When User select "Action ID" checkbox on the Column Settings panel
	When User select "Processing order" checkbox on the Column Settings panel
	When User select "Action Type ID" checkbox on the Column Settings panel
	When User select "Project ID" checkbox on the Column Settings panel
	Then Columns on Admin page is displayed in following order:
	| ColumnName       |
	|                  |
	| Action ID        |
	| Action           |
	|                  |
	| Processing order |
	| Action Type ID   |
	| Type             |
	| Project ID       |
	| Project          |
	| Task or Field    |
	| Value            |
	#Check that grid has at least three actions
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User enters '15309_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
	When User selects 'Undetermined' option from 'Path' autocomplete
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "click here to view the 15309_Action action" link
	When User have opened column settings for "Action" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Processing order" checkbox on the Column Settings panel
	Then numeric data in "Processing order" column is sorted in ascending order by default on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16764 @DAS16998 @DAS15757 @DAS15423 @DAS16936 @DAS17095 @DAS17083 @DAS16475 @DAS17290 @DAS17277 @DAS17336 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckDeleteAutomationFunctionality
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Create Automation" title is displayed on the Automations page
	When User enters '16764_Automation' text to 'Automation Name' textbox
	When User enters '16764' text to 'Description' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User selects "Active" checkbox on the Automation Page
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "click here to view the 16764_Automation automation" link
	When User clicks newly created object link
	Then Automation page is displayed correctly
	Then 'All Devices' content is displayed in 'Scope' textbox
	Then "16764" content is displayed in "Description" field
	Then 'Manual' text value is displayed in the 'Run' dropdown
	Then "Active" checkbox is checked on the Admin page
	Then "Stop on failed action" checkbox is checked on the Admin page
	Then "UPDATE" Action button is disabled
	Then "CANCEL" Action button is active
	Then "UPDATE" Action button have tooltip with "Some values are missing or not valid" text
	#Wait for "RUN NOW" button
	#Then "RUN NOW" Action button is active
	When User clicks "Automations" navigation link on the Admin page
	When User enters "16764_Automation" text in the Search field for "Automation" column
	When User clicks "Delete" option in Cog-menu for "16764_Automation" item on Admin page
	Then Warning message with "This automation will be permanently deleted" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	When User clicks "Delete" option in Cog-menu for "16764_Automation" item on Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "1 automation deleted" text
	When User selects "Automation Log" tab on the Project details page
	When User selects "Automations" tab on the Project details page
	Then Success message is not displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15767 @DAS15423 @Not_Ready
#Change value after gold data complete added
#For Mailboxes Automations
Scenario: EvergreenJnr_AdminPage_CheckThatEditAutomationScopeListIsLoadedWithCorrectLists
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 030619 Mailboxes 1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then "Edit Automation" title is displayed on the Automations page
	Then following lists are displayed in the Scope dropdown:
	| Lists            |
	| Users (0)        |
	| Applications (0) |
	| Mailboxes (0)    |
	| All Devices      |
	| 1803 Rollout     |

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15886 @DAS15423 @DAS16317 @DAS16316 @DAS17223 @DAS17336 @DAS17275 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatEditAutomationScopeShowsCorrectTextForDeletedList
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Belfast" Lookup option
	And User create dynamic list with "DAS15423_List" name on "Devices" page
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	When User enters 'DAS15423_Automation' text to 'Automation Name' textbox
	When User enters 'DAS15423' text to 'Description' textbox
	When User selects 'DAS15423_List' option from 'Scope' autocomplete
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks newly created object link
	Then Automation page is displayed correctly
	Then 'DAS15423_List' content is displayed in 'Scope' textbox
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User navigates to the "DAS15423_List" list
	Then "DAS15423_List" list is displayed to user
	When User removes custom list with "DAS15423_List" name
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	When User enters "DAS15423_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	Then '[List not found]' content is displayed in 'Scope' textbox
	#Waiting for 'The selected list cannot be found' error message is displayed for 'Scope' field on the automation
	#DAS17275
	#Then 'The selected list cannot be found' error message is displayed for 'Scope' field
	#DAS17275
	#Update after DAS-17336 fixed
	#When User navigates to the 'Actions' left menu item
	#Then Edit Action page is displayed to the User
	#When User navigates to the 'Details' left menu item
	When User clicks the "CANCEL" Action button
	When User enters "DAS15423_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "DAS15423_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User enters "DAS15423_Automation" text in the Search field for "Automation" column
	Then "LIST NOT FOUND" content is displayed for "Outcome" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16899 @DAS17071 @DAS17216 @DAS17216 @Not_Ready
#Change value after gold data complete added
#Run at least two automations
#Add to Gold data Test_Automation1 and Test_Automation2 automations
Scenario: EvergreenJnr_AdminPage_CheckRunNowFunctionalityToRunMoreThanOneAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Test_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	Then Warning message with "Are you sure you wish to run 2 automations?" text is displayed on the Admin page
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "2 automations started," text
	When User selects "Automation Log" tab on the Project details page
	When User enters "Test_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User enters "Test_Automation2" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17172 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckRunNowfunctionalityInBulkActions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "DAS-15949 - all users scope" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User enters "Devices_Scope" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17171 @DAS17003 @DAS17260 @Not_Ready
#Use specific Automation (Delay) that run longer
Scenario: EvergreenJnr_AdminPage_CheckUpdateAndCreateActionsFunctionalityForAutomationThatIsRunning
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "Delay" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "DELAY - do not delete" item on Admin page
	When User enters "DELAY - do not delete" text in the Search field for "Automation" column
	When User clicks "Make inactive" option in Cog-menu for "DELAY - do not delete" item on Admin page
	Then Error message with "This automation is currently running" text is displayed
	When User enters "DELAY - do not delete" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks the "CREATE ACTION" Action button
	Then Create Action page is displayed to the User
	When User enters '17171_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects 'Migration Project Phase 2 (User Project)' option from 'Project' autocomplete
	When User selects '[Default (User)]' option from 'Path' autocomplete
	When User clicks the "CREATE" Action button
	Then Error message with "This automation is currently running" text is displayed
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User enters 'NewAction' text to 'Action Name' textbox
	When User clicks the "UPDATE" Action button
	Then Error message with "This automation is currently running" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17003 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_ChechAutomationsPermissions
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username  | FullName | Password | ConfirmPassword | Roles                 |
	| 17003User | 17003    | 1234qwer | 1234qwer        | Project Administrator |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username  | Password |
	| 17003User | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	Then "Automations" tab is not displayed to the User on Admin Page Navigation
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "17003User" User

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17003 @DAS17789 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_ChechAutomationsPermissionsForScopeDropdownLists
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username  | FullName | Password | ConfirmPassword | Roles                 |
	| DAS_17003 | 17003    | 1234qwer | 1234qwer        | Project Administrator |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username  | Password |
	| DAS_17003 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "City" filter where type is "Equals" with added column and "Belfast" Lookup option
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "17003_List" name
	Then "17003_List" list is displayed to user
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
	When User clicks the "CREATE AUTOMATION" Action button
	When User selects '17003_List' option from 'Scope' autocomplete
	When User clicks "Projects" on the left-hand menu
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS_17003" User

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15949 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatDeviceLisFiltertHasAppropriateAutomation
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "Device Type" filter where type is "Equals" with added column and "Virtual" Lookup option
	And User create dynamic list with "DAS15949_List" name on "Devices" page
	#create automation
	And User creates new Automation via API and open it
	| AutomationName      | Description | Active | StopOnFailedAction | Scope         | Run    |
	| DAS15949_Automation | DAS15949    | true   | false              | DAS15949_List | Manual |
	And User navigates to the 'Actions' left menu item
	#create action #1
	And User clicks the "CREATE ACTION" Action button
	And User enters '15949_Action_1' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Laptop Replacement' option from 'Path' autocomplete
	And User clicks the "CREATE" Action button
	#create action #2
	And User clicks the "CREATE ACTION" Action button
	And User enters '15949_Action_2' text to 'Action Name' textbox
	And User selects 'Update path' in the 'Action Type' dropdown
	And User selects 'Barry's User Project' option from 'Project' autocomplete
	And User selects 'Desktop Replacement' option from 'Path' autocomplete
	And User clicks the "CREATE" Action button
	#run automation
	And User clicks "Automations" link on the Admin page
	And User clicks "Run now" option in Cog-menu for "DAS15949_Automation" item on Admin page and wait for processing
	#cjheck filters
	And User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "DAS15949_Automation" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
	| Subcategories                        |
	| DAS15949_Automation \ 15949_Action_1 |
	| DAS15949_Automation \ 15949_Action_2 |
	When User clears search textbox in Filters panel
	And user select "DAS15949_Automation \ 15949_Action_1" filter
	And User select "Equals" Operator value
	And User select first checkbox from available options
	And User clicks Save filter button
	Then "5,179" rows are displayed in the agGrid
	#check log
	When User clicks Admin on the left-hand menu
	And User clicks "Automations" link on the Admin page
	And User selects "Automation Log" tab on the Project details page
	And User enters "DAS15949_Automation" text in the Search field for "Automation" column
	And User clicks String Filter button for "Action" column on the Admin page
	And User selects "Select All" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Action" column on the Admin page
	And User selects "15949_Action_1" checkbox from String Filter with item list on the Admin page
	Then "5179" content is displayed in "Objects" column