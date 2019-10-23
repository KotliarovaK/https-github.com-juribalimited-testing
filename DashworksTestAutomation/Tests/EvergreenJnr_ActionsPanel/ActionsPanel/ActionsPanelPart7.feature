Feature: ActionsPanelPart7
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @Cleanup
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForOwnerField
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName  | Password | ConfirmPassword | Roles                |
	| <Name>   | DAS132881 | 1234qwer | 1234qwer        | Project Bulk Updater |
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
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Nov 28, 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User navigate to the bottom of the Action panel
	When User selects 'No change' in the 'Update Owner' dropdown
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
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Jan 9, 2019' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User navigate to the bottom of the Action panel
	When User selects 'No change' in the 'Update Owner' dropdown
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	And User navigate to the top of the Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column

Examples: 
	| Name     | RowName    | NewValue       | DefaultValue   |
	| DAS13280 | CQV0623434 | Complete       | Started        |
	| DAS13281 | BBZ877343  | Failed         | Not Applicable |
	| DAS13282 | DLL972653  | Complete       | Not Started    |
	| DAS13283 | LZI970280  | Not Applicable | Failed         |
	| DAS13284 | ZQX656408  | Not Applicable | Complete       |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13290 @DAS14127 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatDateRemovingIsWorksCorrectly
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13290 | DAS13290 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13290 | 1234qwer |
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
	And User perform search by "LZI970280"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| LZI970280        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Complete' in the 'Value' dropdown
	And User selects 'Remove' in the 'Update Date' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User refreshes agGrid
	Then "Complete" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column
	#returns default object state
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Value' dropdown
	And User selects 'Failed' in the 'Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Nov 23, 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	And User navigate to the bottom of the Action panel
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "Failed" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13291 @DAS14127 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatOwnerRemovingIsWorksCorrectly
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13291 | DAS13291 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13291 | 1234qwer |
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
	And User perform search by "LZI970280"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| LZI970280        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Nov 21, 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User selects 'Remove owner and team' in the 'Update Owner' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	Then "Failed" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column
#returns default object state
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Dec 27, 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "Failed" content is displayed in "Windows7Mi: User Acceptance Test \ Perform User Acceptance Test" column