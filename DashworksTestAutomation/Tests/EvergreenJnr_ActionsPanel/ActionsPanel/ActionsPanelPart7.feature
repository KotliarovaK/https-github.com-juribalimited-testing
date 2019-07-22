Feature: ActionsPanelPart7
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 7/17/19 : waiting for an error response
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @DAS14127 @Not_Run
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForDateField
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	And User perform search by "<RowName>"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "No change" Update Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Nov 29, 2018" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "<NewTeam>" Team on Action panel
	When User navigate to the bottom of the Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	#Then "<DefaultValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	#returns default object state
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "No change" Update Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Jan 5, 2019" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "<DefaultTeam>" Team on Action panel
	And User navigate to the bottom of the Action panel
	And User clicks the "UPDATE" Action button
	And User navigate to the top of the Action panel
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "<Name>" User

Examples: 
	| Name    | RowName    | NewTeam  | DefaultTeam         | DefaultValue   |
	| DAS1330 | CQV0623434 | Admin IT | Administrative Team | Complete       |
	| DAS1331 | BBZ877343  | Admin IT | Retail Team         | Failed         |
	| DAS1332 | DLL972653  | Admin IT | K-Team              | Complete       |
	| DAS1333 | LZI970280  | Admin IT | IB Team             | Not Applicable |
	| DAS1334 | ZQX656408  | Admin IT | Migration Phase 2   | Not Applicable |

	#Ann.Ilchenko 7/17/19 : waiting for an error response
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @Not_Run
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForOwnerField
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	And User perform search by "<RowName>"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "Update" Update Value on Action panel
	And User selects "<NewValue>" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Nov 28, 2018" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	When User navigate to the bottom of the Action panel
	And User selects "No change" Update Owner on Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	Then "<NewValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "Update" Update Value on Action panel
	And User selects "<DefaultValue>" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Jan 9, 2019" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	When User navigate to the bottom of the Action panel
	And User selects "No change" Update Owner on Action panel
	And User navigate to the bottom of the Action panel
	And User clicks the "UPDATE" Action button
	And User navigate to the top of the Action panel
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "<Name>" User

Examples: 
	| Name     | RowName    | NewValue       | DefaultValue   |
	| DAS13280 | CQV0623434 | Complete       | Started        |
	| DAS13281 | BBZ877343  | Failed         | Not Applicable |
	| DAS13282 | DLL972653  | Complete       | Not Started    |
	| DAS13283 | LZI970280  | Not Applicable | Failed         |
	| DAS13284 | ZQX656408  | Not Applicable | Complete       |

	#Ann.Ilchenko 7/17/19 : waiting for an error response
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13290 @DAS14127 @Not_Run
Scenario: EvergreenJnr_UsersList_ChecksThatDateRemovingIsWorksCorrectly
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	And User perform search by "LZI970280"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| LZI970280        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "Update" Update Value on Action panel
	And User selects "Complete" Value on Action panel
	And User selects "Remove" Update Date on Action panel
	And User selects "No change" Update Owner on Action panel
	And User navigate to the bottom of the Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User refreshes agGrid
	Then "Complete" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "Update" Update Value on Action panel
	And User selects "Failed" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Nov 23, 2018" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	And User navigate to the bottom of the Action panel
	And User selects "No change" Update Owner on Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "Failed" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13290" User

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13291 @DAS14127 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatOwnerRemovingIsWorksCorrectly
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	And User perform search by "LZI970280"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| LZI970280        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "No change" Update Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Nov 21, 2018" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	And User selects "Remove owner and team" Update Owner on Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	Then "Failed" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User Acceptance Test" Stage on Action panel
	And User selects "Perform User Acceptance Test" Task on Action panel
	And User selects "No change" Update Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "Dec 27, 2018" Date on Action panel
	And User selects "User Slot" value for "Capacity Slot" dropdown on Action panel
	And User selects "No change" Update Owner on Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "Failed" content is displayed for "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13291" User
