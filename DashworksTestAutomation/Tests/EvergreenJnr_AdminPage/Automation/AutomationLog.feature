Feature: AutomationsLogPage
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS16890 @DAS17063 @DAS17364 @DAS17402 @DAS17425
Scenario: EvergreenJnr_AdminPage_CheckAutomationsLogGridForRunningAutomationWithDeletedProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	And User enters "16890Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Automations" link on the Admin page
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "16890_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "16890" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	When User type "16890_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "16890Project" in the Project dropdown
	When User selects "[Default (Computer)]" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks the "CREATE ACTION" Action button
	When User type "New_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User clicks "Projects" link on the Admin page
	And User enters "16890Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "Automations" link on the Admin page
	When User enters "16890_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "(Blanks)" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "New_Action" checkbox from String Filter with item list on the Admin page
	Then "PROJECT DOES NOT EXIST" content is displayed for "Outcome" column
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "16890_Action" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "New_Action" checkbox from String Filter with item list on the Admin page
	Then "SUCCESS" content is displayed for "Outcome" column
	Then some data is displayed in the "Objects" column
	When User clicks Reset Filters button on the Admin page
	When User enters "16890_Automation" text in the Search field for "Automation" column
	Then "ONE OR MORE ACTIONS FAILED" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17104 @DAS17110 @DAS17169 @Not_Ready
#Use Inactive automation
Scenario: EvergreenJnr_AdminPage_CheckThatInactiveAutomationShouldBeLoggedButNotRun
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 240619 Mailboxes" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User selects "Automation Log" tab on the Project details page
	Then Date column shows Date and Time values
	When User enters "AM 240619 Mailboxes" text in the Search field for "Automation" column
	Then "INACTIVE AUTOMATION" content is displayed for "Outcome" column
	When User clicks Export button on the Admin page
	Then User checks that file "Dashworks export" was downloaded
	Then User verifies "Outcome" column content in the "Dashworks export" downloaded file
	| ColumnContent       |
	| INACTIVE AUTOMATION |
	| SUCCESS             |
	| INACTIVE AUTOMATION |
	| SUCCESS             |
	| INACTIVE AUTOMATION |
	| SUCCESS             |

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17104 @DAS16974 @DAS16316 @DAS17263 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckSuccessfulRunInOutcomeColumn
#Use correct, active Automation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "AM 1.7.19 Application" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User selects "Automation Log" tab on the Project details page
	When User enters "AM 1.7.19 Application" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Start" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Action Finish" checkbox from String Filter with item list on the Admin page
	Then "Manual" content is displayed for "Run" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Action Start" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Action Finish" checkbox from String Filter with item list on the Admin page
	Then "Manual" content is displayed for "Run" column

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS16316 @DAS16319 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckOutcomeValueForAnAutomationThatIsAlreadyRunning
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks "Run now" option in Cog-menu for "DELAY - do not delete2" item on Admin page
	When User clicks refresh button in the browser
	When User clicks "Run now" option in Cog-menu for "DELAY - do not delete2" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User enters "DELAY - do not delete2" text in the Search field for "Automation" column
	Then "AUTOMATION IS ALREADY RUNNING" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17011 @DAS17374 @DAS17370 @DAS17367 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckBrokenListValidationWhenRunningAnAutomation
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "Country" filter where type is "Equals" with added column and "England" Lookup option
	And User create dynamic list with "17011_List" name on "Devices" page
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "17011_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "17011" Name in the "Description" field on the Automation details page
	When User selects "17011_List" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "17011_Automation_1" Name in the "Automation Name" field on the Automation details page
	When User type "17011_1" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "17011_List" list
	Then "17011_List" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList                             | Association        |
	| Application List (Complex) - BROKEN LIST | Entitled to device |
	When User update current custom list
	When User clicks Admin on the left-hand menu
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17011_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Filling field error with "This list has errors" text is displayed
	Then "UPDATE" Action button have tooltip with "Some values are missing or not valid" text
	#DAS-17374
	When User clicks the "CANCEL" Action button
	When User clicks "Projects" link on the Admin page
	When User clicks "Automations" link on the Admin page
	When User enters "17011_Automation_1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Filling field error is not displayed
	When User clicks the "CANCEL" Action button
	When User clicks "Run now" option in Cog-menu for "17011_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks refresh button in the browser
	When User enters "17011_Automation" text in the Search field for "Automation" column
	Then "LIST HAS ERRORS" content is displayed for "Outcome" column

@Evergreen @Admin @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17212 @Not_Ready 
Scenario Outline: EvergreenJnr_AdminPage_CheckSuccessfulRunningAutomationWithMainListsInTheScope
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "<AutomationName>" Name in the "Automation Name" field on the Automation details page
	When User type "17212" Name in the "Description" field on the Automation details page
	When User selects "<Scope>" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "<AutomationName>" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User selects "Automation Log" tab on the Project details page
	When User enters "<AutomationName>" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column

Examples:
	| AutomationName     | Scope            |
	| 17212_Devices      | All Devices      |
	| 17212_Users        | All Users        |
	| 17212_Applications | All Applications |
	| 17212_Mailboxes    | All Mailboxes    |