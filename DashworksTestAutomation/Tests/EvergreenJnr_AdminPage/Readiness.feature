Feature: Readiness
	Runs Readiness related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15665 @DAS14994 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOptionsInTheCogMenuForReadinessAreCorrect
	When User clicks Admin on the left-hand menu
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project for DAS15665" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User clicks "Readiness" tab
	When User clicks Cog-menu for "Red" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items                         |
	| Edit                          |
	| Move to top                   |
	| Move to bottom                |
	| Move to position              |
	| Change to ready               |
	| Make default for applications |
	| Delete                        |
	When User clicks Cog-menu for "Green" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items                         |
	| Edit                          |
	| Move to top                   |
	| Move to bottom                |
	| Move to position              |
	| Change to not ready           |
	| Make default for applications |
	| Delete                        |

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15884 @DAS15789 @DAS16131 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAppearWhenDeleteReadiness
	When User clicks Admin on the left-hand menu
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DAS15884_Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User clicks "Readiness" tab
	Then Columns on Admin page is displayed in following order:
	| ColumnName                  |
	| Readiness                   |
	| Tooltip                     |
	| Default for Applications    |
	| Task Values Count           |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| RED              |
	When User clicks on Actions button
	When User clicks Delete button in Actions
	When User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	When User clicks "DELETE" button in the Readiness dialog screen
	Then Success message is displayed and contains "The selected readiness has been deleted" text
	Then There are no errors in the browser console
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| AMBER            |
	When User clicks on Actions button
	When User clicks Delete button in Actions
	When User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	When User clicks "DELETE" button in the Readiness dialog screen
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16131 @DAS16226 @DAS16163 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckReadinessDialogContainerDisplay
	When User clicks Admin on the left-hand menu
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DAS16131_Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User clicks "Readiness" tab
	Then Columns on Admin page is displayed in following order:
	| ColumnName |
	| Readiness  |
	|            |
	| Tooltip    |
	| Ready      |
	| Default for Applications    |
	| Task Values Count           |
	| Applications Count          |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| RED              |
	When User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	And "Delete Readiness" title is displayed in the Readiness Dialog Container
	When User clicks "CANCEL" button in the Readiness dialog screen
	And User select "Readiness" rows in the grid
	| SelectedRowsName |
	| GREEN            |
	And User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	Then "Delete Readinesses" title is displayed in the Readiness Dialog Container
	Then Cancel button in the pop up is colored gray
	Then Delete button in the pop up is colored amber
	When User clicks "DELETE" button in the Readiness dialog screen
	Then Success message is displayed and contains "The selected readinesses have been deleted, changes might not take effect immediately" text
	When User clicks Admin on the left-hand menu
	And User enters "DAS16131_Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16148 @DAS16226 @DAS16163
Scenario: EvergreenJnr_AdminPage_ChecksThatValuesForReadinessGridAreDisplayedProperlyAfterUsingCogMenuOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User enters "1803 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User clicks "Readiness" tab
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "FALSE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks "Change to ready" option in Cog-menu for "Grey" item on Admin page
	Then Success message is displayed and contains "The readiness has been updated" text
	Then Success message is displayed and contains "click here to view the Grey readiness" link
	Then Green banner contains following text "changes might not take effect immediately"
	When User clicks newly created object link
	Then Update Readiness is displayed to the User
	When User clicks the "CANCEL" Action button
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "TRUE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks "Change to not ready" option in Cog-menu for "Grey" item on Admin page
	Then "FALSE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks Reset Filters button on the Admin page
	When User clicks "Change to not ready" option in Cog-menu for "Green" item on Admin page
	Then Success message is displayed and contains "The readiness has been updated" text
	Then Success message is displayed and contains "click here to view the Green readiness" link
	Then Green banner contains following text "changes might not take effect immediately"
	When User clicks newly created object link
	Then Update Readiness is displayed to the User
	When User clicks the "CANCEL" Action button
	When User clicks "Change to ready" option in Cog-menu for "Green" item on Admin page
	When User clicks "Make default for applications" option in Cog-menu for "Apps In Initiation" item on Admin page
	Then Success message is displayed and contains "The readiness has been updated" text
	Then Success message is displayed and contains "click here to view the Light Blue readiness" link
	Then Green banner contains following text "changes might not take effect immediately"
	When User clicks newly created object link
	Then Update Readiness is displayed to the User
	When User clicks the "CANCEL" Action button
	When User clicks "Make default for applications" option in Cog-menu for "Red" item on Admin page
	When User have opened column settings for "Readiness" column
	And User clicks Column button on the Column Settings panel
	And User select "Ready" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then Columns on Admin page is displayed in following order:
	| ColumnName                  |
	| Readiness                   |
	|                             |
	| Tooltip                     |
	| Default for Applications    |
	| Task Values Count           |
	| Applications Count          |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |