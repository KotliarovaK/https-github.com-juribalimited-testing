﻿@retry:1
Feature: ActionsPanel
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS-10859 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatAfterInterruptingProcessSelectingAllRowsAtActionsPanelProgressIndicatorIsNotContinuesToRun
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User click content from "Username" column
	Then User click back button in the browser
	And "Users" list should be displayed to the user
	#question to Lisa
	#And Actions panel is not displayed to the user