﻿Feature: Readiness
	Runs Readiness related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15665 @DAS15789 @Delete_Newly_Created_Project @Not_Run
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15884 @Delete_Newly_Created_Project
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