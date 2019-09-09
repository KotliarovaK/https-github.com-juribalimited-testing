Feature: AutomationsLogPart1
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS16890 @DAS17063 @DAS17364 @DAS17402 @DAS17425 @DAS17774 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckAutomationsLogGridForRunningAutomationWithDeletedProject
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| 16890Project | All Devices | None            | Standalone Project |
	And User clicks Admin on the left-hand menu
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope       | Run    |
	| 16890_Automation | 16890       | true   | false              | All Devices | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks Export button on the Admin page
	Then User checks that file "Dashworks export" was downloaded
	When User enters "16890_Automation" text in the Search field for "Automation" column
	When User click content from "Automation" column
	When User clicks "Actions" tab
	#Action 1
	When User clicks the "CREATE ACTION" Action button
	When User enters '16890_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '16890Project' option from 'Project' autocomplete
	When User selects "[Default (Computer)]" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks the "CREATE ACTION" Action button
	When User enters 'New_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project' autocomplete
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
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "New_Action" checkbox from String Filter with item list on the Admin page
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Outcome" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Outcome" column on the Admin page
	When User selects "PROJECT DOES NOT EXIST" checkbox from String Filter with item list on the Admin page
	Then "16890_Action" content is displayed for "Action" column
	When User clicks String Filter button for "Outcome" column on the Admin page
	When User selects "PROJECT DOES NOT EXIST" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Outcome" column on the Admin page
	When User selects "ONE OR MORE ACTIONS FAILED" checkbox from String Filter with item list on the Admin page
	Then "16890_Automation" content is displayed for "Automation" column

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17104 @DAS17110 @DAS17169 @DAS17774 @Cleanup @Not_Ready
#Use Inactive automation
Scenario: EvergreenJnr_AdminPage_CheckThatInactiveAutomationShouldBeLoggedButNotRun
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17104_Automation | 17104       | false  | false              | All Users | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17104_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User selects "Automation Log" tab on the Project details page
	When User clicks Group By button on the Admin page and selects "Automation" value
	Then Cog menu is not displayed on the Admin page
	Then Grid is grouped
	When User clicks Group By button on the Admin page and selects "Automation" value
	Then Date column shows Date and Time values
	When User enters "17104_Automation" text in the Search field for "Automation" column
	Then "INACTIVE AUTOMATION" content is displayed for "Outcome" column
	When User clicks Export button on the Admin page
	Then User checks that file "Dashworks export" was downloaded
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "SUCCESS" content is displayed for "Outcome" column

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17104 @DAS16974 @DAS16316 @DAS17263 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckSuccessfulRunInOutcomeColumn
#Use correct, active Automation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Create Automation" title is displayed on the Automations page
	When User enters 'D16974_Automation' text to 'Automation Name' textbox
	When User enters '1745104' text to 'Description' textbox
	When User selects "All Users" in the Scope Automation dropdown
	Then "CREATE" Action button is disabled
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks the "CREATE" Action button
	When User enters 'D16974_Action' text to 'Action Name' textbox
	When User selects 'Update path' in the 'Action Type' dropdown
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User selects "[Default (User)]" in the "Path" dropdown for Actions
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "D16974_Automation" text in the Search field for "Automation" column
	When User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Run now" in the Actions
	When User clicks the "RUN" Action button
	When User clicks "RUN" button in the warning message on Admin page
	Then Success message is displayed and contains "1 automation started," text
	When User selects "Automation Log" tab on the Project details page
	When User enters "D16974_Automation" text in the Search field for "Automation" column
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

@Evergreen @EvergreenJnr_AdminPage @AutomationLog @Automations @DAS17011 @DAS17374 @DAS17370 @DAS17367 @Cleanup
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
	When User enters '17011_Automation' text to 'Automation Name' textbox
	When User enters '17011' text to 'Description' textbox
	When User selects "17011_List" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	When User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Create Automation" title is displayed on the Automations page
	When User enters '17011_Automation_1' text to 'Automation Name' textbox
	When User enters '17011_1' text to 'Description' textbox
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	When User clicks the "CREATE" Action button
	Then Create Action page is displayed to the User
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
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
	Then 'This list has errors' error message is displayed for 'Scope' field
	Then "UPDATE" Action button have tooltip with "Some values are missing or not valid" text
	#DAS-17374
	When User clicks the "CANCEL" Action button
	When User clicks "Projects" link on the Admin page
	When User clicks "Automations" link on the Admin page
	When User enters "17011_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Filling field error is not displayed
	When User clicks the "CANCEL" Action button
	When User enters "17011_Automation" text in the Search field for "Automation" column
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
	When User enters '<AutomationName>' text to 'Automation Name' textbox
	When User enters '17212' text to 'Description' textbox
	When User selects "<Scope>" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17774 @Not_Ready
#Run steps after fixing Boolean sorting
Scenario: EvergreenJnr_AdminPage_CheckSortingAutomationsLogGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User selects "Automation Log" tab on the Project details page
	When User click on 'Date' column header
	Then date in table is sorted by "Date" column in descending order on the Admin page
	When User click on 'Date' column header
	Then date in table is sorted by "Date" column in ascending order on the Admin page
	When User click on 'Type' column header
	Then data in table is sorted by "Type" column in ascending order on the Admin page
	When User click on 'Type' column header
	Then data in table is sorted by "Type" column in descending order on the Admin page
	When User click on 'Automation' column header
	Then data in table is sorted by "Automation" column in ascending order on the Admin page
	When User click on 'Automation' column header
	Then data in table is sorted by "Automation" column in descending order on the Admin page
	When User click on 'Action' column header
	Then data in table is sorted by "Action" column in ascending order on the Admin page
	When User click on 'Action' column header
	Then data in table is sorted by "Action" column in descending order on the Admin page
	When User click on 'Run' column header
	Then data in table is sorted by "Run" column in ascending order on the Admin page
	When User click on 'Run' column header
	Then data in table is sorted by "Run" column in descending order on the Admin page
	When User click on 'Objects' column header
	Then numeric data in table is sorted by "Objects" column in descending order on the Admin page
	When User click on 'Objects' column header
	Then numeric data in table is sorted by "Objects" column in ascending order on the Admin page
	When User click on 'Duration (hh:mm:ss)' column header
	Then data in table is sorted by "Duration (hh:mm:ss)" column in ascending order on the Admin page
	When User click on 'Duration (hh:mm:ss)' column header
	Then data in table is sorted by "Duration (hh:mm:ss)" column in descending order on the Admin page
	When User click on 'User' column header
	Then data in table is sorted by "User" column in ascending order on the Admin page
	When User click on 'User' column header
	Then data in table is sorted by "User" column in descending order on the Admin page
	When User click on 'Outcome' column header
	Then Boolean data in table is sorted by "Outcome" column in ascending order on the Admin page
	When User click on 'Outcome' column header
	Then Boolean data in table is sorted by "Outcome" column in descending order on the Admin page