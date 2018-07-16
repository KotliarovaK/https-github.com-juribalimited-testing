﻿@retry:1
Feature: ActionsPanel
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS10859 @DAS12602 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatAfterInterruptingProcessSelectingAllRowsAtActionsPanelProgressIndicatorDoesNotContinueToRun
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	When User click on 'Username' column header
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User click content from "Username" column
	Then User click back button in the browser
	And "Users" list should be displayed to the user
	Then Actions panel is displayed to the user
	Then Actions message container is displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS10860
Scenario: EvergreenJnr_UsersList_CheckThatAfterClosingActionsPanelTheActionsButtonIsNotShownInRed
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions button is active
	When User clicks the Actions button
	Then Actions button is not active

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS12932
Scenario: EvergreenJnr_UsersList_CheckThatUserWithoutRelevantRolesCannotSeeBulkUpdateOptionInActionsPanel
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	When User create new User
	| Username        | FullName     | Password | ConfirmPassword | Roles |
	| 000WithoutRoles | WithoutRoles | 1234qwer | 1234qwer        |       |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username        | Password |
	| 000WithoutRoles | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	| 0088FC8A50DD4344B92 |
	When User clicks on Action drop-down
	Then following Values are displayed in Action drop-down:
	| Value              |
	| Create static list |
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	Then following Roles are available for User:
	| Roles                     |
	| Dashworks Users           |
	| Dashworks Evergreen Users |
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	When User removes "000WithoutRoles" User

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12932
Scenario: EvergreenJnr_DevicesList_CheckThatUserWithoutJustTheProjectAdministratorRoleCanStillBulkUpdateObjects
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	When User create new User
	| Username   | FullName             | Password | ConfirmPassword | Roles                |
	| 000WithPBU | Project Bulk Updater | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username   | Password |
	| 000WithPBU | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	When User perform search by "0DTXL41673EW7O"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 0DTXL41673EW7O   |
	And User selects "Bulk Update" in the Actions dropdown
	When User selects 
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	When User removes "000WithoutRoles" User