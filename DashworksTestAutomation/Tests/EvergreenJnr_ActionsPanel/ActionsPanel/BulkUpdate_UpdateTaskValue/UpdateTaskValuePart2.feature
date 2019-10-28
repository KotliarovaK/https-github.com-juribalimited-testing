﻿Feature: UpdateTaskValuePart2
	Runs Bulk Update Update task value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13268 @DAS13269 @DAS13272 @DAS13273 @DAS13276 @DAS13275 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatActionsPanelIsWorkingCorrectlyWhenSelectedTaskThatHasAnTeamOrOwner
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13268 | DAS13268 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13268 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Barry's User Project' option from 'Project' autocomplete
	Then 'Stage' autocomplete options are sorted in the alphabetical order
	When User selects 'Audit & Configuration' option from 'Stage' autocomplete
	Then 'Task' autocomplete options are sorted in the alphabetical order
	When User selects 'Validate User Device Ownership' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options               |
	| Update                |
	| No change             |
	When User selects 'No change' in the 'Update Value' dropdown
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	When User selects 'No change' in the 'Update Date' dropdown
	Then following Values are displayed in the 'Update Owner' dropdown:
	| Options      |
	| Update       |
	| Remove owner |
	| Remove owner and team |
	| No change             |
	When User selects 'Update' in the 'Update Owner' dropdown
	Then 'Team' autocomplete options are sorted in the alphabetical order
	When User selects 'Team 0' option from 'Team' autocomplete
	Then 'Owner' textbox is not displayed
	When User selects 'IB Team' option from 'Team' autocomplete
	Then 'Owner' textbox is displayed
	When User selects 'IB User' option from 'Owner' autocomplete
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13268" User

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13280 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatClearingAValueResetsSubsequentValuesr
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13280 | DAS13280 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13280 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'User Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'One' option from 'Stage' autocomplete
	And User selects 'Radio Rag Only Comp' option from 'Task' autocomplete
	When User selects 'Started' in the 'Value' dropdown
	And User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	Then 'Value' dropdown is not displayed
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13280" User

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13281 @DAS13284 @DAS13285 @Cleanup
Scenario Outline: EvergreenJnr_DevicesList_ChecksThatDllOptionsAreDisplayedCorrectly
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13281 | DAS13281 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13281 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer Information ---- Text fill; Text fill;' option from 'Stage' autocomplete
	And User selects 'Computer Read Only Task in Self Service' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options               |
	| Update                |
	| No change             |
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	Then following Values are displayed in the 'Update Owner' dropdown:
	| Options               |
	| Update                |
	| Remove owner          |
	| Remove owner and team |
	| No change             |
	When User selects 'Workstation Text Task' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options   |
	| Update    |
	| Remove    |
	When User selects 'Computer Read Only Task in Self Service' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options               |
	| Update                |
	| No change             |
	When User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Started' in the 'Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	And User navigate to the bottom of the Action panel
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'CANCEL' button
	Then the amber message is not displayed
	When User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "<MessageText>" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13281" User

Examples:
	| RowName        | MessageText                                                   |
	| 00HA7MKAVVFDAV | 1 of 1 object was in the selected project and has been queued |
	| 00I0COBFWHOF27 | 0 of 1 object was in the selected project and has been queued |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @DAS14127 @DAS18267 @Cleanup
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForValueField
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| <Name>   | Value    | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| <Name>   | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                      |
	| Windows7Mi: User Acceptance Test \ Perform User Acceptance Test |
	And User perform search by "<RowName>"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects '<NewValue>' in the 'Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '<NewTeam>' option from 'Team' autocomplete
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	Then "<NewValue>" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column
		#returns default object state
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects '<DefaultValue>' in the 'Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '<DefaultTeam>' option from 'Team' autocomplete
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	And User navigate to the top of the Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column

Examples:
	| Name    | RowName    | NewValue       | NewTeam  | DefaultValue   | DefaultTeam         |
	| DAS1321 | CQV0623434 | Complete       | Admin IT | Started        | Administrative Team |
	| DAS1322 | BBZ877343  | Failed         | Admin IT | Not Applicable | Retail Team         |
	| DAS1323 | DLL972653  | Complete       | Admin IT | Not Started    | K-Team              |
	| DAS1324 | LZI970280  | Not Applicable | Admin IT | Failed         | IB Team             |
	| DAS1325 | ZQX656408  | Not Applicable | Admin IT | Complete       | Migration Phase 2   |

#Awaiting Lisa's response and updating the autotest scenario 
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @DAS14127 @Cleanup @Not_Run
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForDateField
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| <Name>   | DAS13288 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| <Name>   | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                      |
	| Windows7Mi: User Acceptance Test \ Perform User Acceptance Test |
	And User perform search by "<RowName>"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Nov 29, 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '<NewTeam>' option from 'Team' autocomplete
	When User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column
	#returns default object state
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Jan 5, 2019' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '<DefaultTeam>' option from 'Team' autocomplete
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	And User navigate to the top of the Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

Examples:
	| Name    | RowName    | NewTeam  | DefaultTeam         | DefaultValue   |
	| DAS1330 | CQV0623434 | Admin IT | Administrative Team | Complete       |
	| DAS1331 | BBZ877343  | Admin IT | Retail Team         | Failed         |
	| DAS1332 | DLL972653  | Admin IT | K-Team              | Complete       |
	| DAS1333 | LZI970280  | Admin IT | IB Team             | Not Applicable |
	| DAS1334 | ZQX656408  | Admin IT | Migration Phase 2   | Not Applicable |