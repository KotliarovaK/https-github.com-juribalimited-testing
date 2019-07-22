Feature: ActionsPanelPart6
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13268 @DAS13269 @DAS13272 @DAS13273 @DAS13276 @DAS13275 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatActionsPanelIsWorkingCorrectlyWhenSelectedTaskThatHasAnTeamOrOwner
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Barry's User Project" Project on Action panel
	Then Stages are displayed in alphabetical order on Action panel
	When User selects "Audit & Configuration" Stage on Action panel
	Then Tasks are displayed in alphabetical order on Action panel
	When User selects "Validate User Device Ownership" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options               |
	| Update                |
	| No change             |
	When User selects "No change" Update Value on Action panel
	Then the Update Date options are displayed in following order:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	When User selects "No change" Update Date on Action panel
	Then the Update Owner options are displayed in following order:
	| Options      |
	| Update       |
	| Remove Owner |
	| Remove owner and team |
	| No change             |
	When User selects "Update" Update Owner on Action panel
	Then Teams are displayed in alphabetical order on Action panel
	When User selects "Team 0" Team on Action panel
	Then Owner field is not displayed on Action panel
	When User selects "IB Team" Team on Action panel
	Then Owner field is displayed on Action panel
	When User selects "IB User" Owner on Action panel
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
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "User Scheduled Test (Jo)" Project on Action panel
	And User selects "One" Stage on Action panel
	And User selects "Radio Rag Only Comp" Task on Action panel
	And User selects "Started" Value on Action panel
	And User selects "Computer Scheduled Test (Jo)" Project on Action panel
	Then Value field is not displayed on Action panel
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
	When User clicks "Projects" on the left-hand menu
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Computer Information ---- Text fill; Text fill;" Stage on Action panel
	And User selects "Computer Read Only Task in Self Service" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options               |
	| Update                |
	| No change             |
	And the Update Date options are displayed in following order:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	And the Update Owner options are displayed in following order:
	| Options               |
	| Update                |
	| Remove Owner          |
	| Remove owner and team |
	| No change             |
	When User selects "Workstation Text Task" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options   |
	| Update    |
	| Remove    |
	When User selects "Computer Read Only Task in Self Service" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options               |
	| Update                |
	| No change             |
	When User selects "Update" Update Value on Action panel
	And User selects "Started" Value on Action panel
	And User selects "No change" Update Date on Action panel
	And User navigate to the bottom of the Action panel
	And User selects "No change" Update Owner on Action panel
	And User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "CANCEL" button on message box
	Then the amber message is not displayed
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "UPDATE" button on message box
	And Success message with "<MessageText>" text is displayed on Action panel
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

	#Ann.Ilchenko 7/17/19 : waiting for an error response
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @DAS14127 @Cleanup @Not_Run
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForValueField
	When User clicks "Projects" on the left-hand menu
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
	And User selects "No change" Update Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "<NewTeam>" Team on Action panel
	And User navigate to the bottom of the Action panel
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
	And User selects "No change" Update Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "<DefaultTeam>" Team on Action panel
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
	| Name    | RowName    | NewValue       | NewTeam  | DefaultValue   | DefaultTeam         |
	| DAS1321 | CQV0623434 | Complete       | Admin IT | Started        | Administrative Team |
	| DAS1322 | BBZ877343  | Failed         | Admin IT | Not Applicable | Retail Team         |
	| DAS1323 | DLL972653  | Complete       | Admin IT | Not Started    | K-Team              |
	| DAS1324 | LZI970280  | Not Applicable | Admin IT | Failed         | IB Team             |
	| DAS1325 | ZQX656408  | Not Applicable | Admin IT | Complete       | Migration Phase 2   |
