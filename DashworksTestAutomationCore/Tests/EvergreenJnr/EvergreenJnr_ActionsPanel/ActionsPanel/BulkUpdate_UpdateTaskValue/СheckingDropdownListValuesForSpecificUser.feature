Feature: СheckingDropdownListValuesForSpecificUser
	Runs Checking Dropdown List Values For Specific User related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#AnnI 6/2/20: DAS21304 fixed only for 'Yellow_Dwarf'
@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13264 @DAS13265 @DAS13278 @DAS14448 @DAS21304 @Cleanup @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckThatUpdateAndCancelButtonsAreEnabledWhenUserLoggedWithProjectBulkUpdaterRole
	When User create new User via API
	| Username   | Email | FullName | Password  | Roles                 |
	| <UserName> | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| <UserName> | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects '<ProjectName>' option from 'Project' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
	And User selects '<UpdateDate>' in the 'Update Date' dropdown
	Then 'UPDATE' button is not disabled
	And 'CANCEL' button is not disabled
	When User clicks 'UPDATE' button 
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'CANCEL' button
	Then inline tip banner is not displayed
	And 'UPDATE' button is not disabled
	And 'CANCEL' button is not disabled
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "<UserName>" User

Examples:
	| UserName              | PageName     | ColumnName    | RowName                                  | ProjectName                  | TaskName                                      | UpdateDate |
	| DAS13264_Devices      | Devices      | Hostname      | 00CWZRC4UK6W20                           | Computer Scheduled Test (Jo) | One \ Date Computer                           | Remove     |
	| DAS13264_Users        | Users        | Username      | 0088FC8A50DD4344B92                      | Barry's User Project         | Project Dates \ Scheduled Date                | Remove     |
	| DAS13264_Applications | Applications | Application   | 0047 - Microsoft Access 97 SR-2 Francais | Barry's User Project         | Audit & Configuration \ Package Delivery Date | Remove     |
	| DAS13264_Mailboxes    | Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local         | Email Migration              | Pre-Migration \ Out Of Office Start Date      | Remove     |

	#AnnI 6/2/20: DAS21304 fixed only for 'Yellow_Dwarf'
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13268 @DAS13269 @DAS13272 @DAS13273 @DAS13276 @DAS13275 @DAS21304 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_DevicesList_ChecksThatActionsPanelIsWorkingCorrectlyWhenSelectedTaskThatHasAnTeamOrOwner
	When User create new User via API
	| Username | Email | FullName | Password  | Roles                 |
	| DAS13268 | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password  |
	| DAS13268 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects 'Barry's User Project' option from 'Project' autocomplete
	Then 'Task' autocomplete options are sorted in the alphabetical order
	When User selects 'Audit & Configuration \ Validate User Device Ownership' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options        |
	| No change      |
	| Not Applicable |
	| Awaiting Audit |
	| Audit Failed   |
	| Audit Complete |
	When User selects 'No change' in the 'Update Value' dropdown
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                                   |
	| No change                                 |
	| Update                                    |
	| Update relative to current value          |
	| Update relative to now                    |
	| Update relative to a different task value |
	| Remove                                    |
	When User selects 'No change' in the 'Update Date' dropdown
	Then following Values are displayed in the 'Update Owner' dropdown:
	| Options               |
	| No change             |
	| Update                |
	| Remove owner          |
	| Remove owner and team |
	When User selects 'Update' in the 'Update Owner' dropdown
	Then 'Team' autocomplete options are sorted in the alphabetical order
	When User selects 'Team 0' option from 'Team' autocomplete
	When User navigate to the bottom of the Action panel
	Then 'Owner' textbox is displayed
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

	#AnnI 6/2/20: DAS21304 fixed only for 'Yellow_Dwarf'
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13280 @DAS21304 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_DevicesList_CheckThatClearingAValueResetsSubsequentValues
	When User create new User via API
	| Username | Email | FullName | Password  | Roles                 |
	| DAS13280 | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password  |
	| DAS13280 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Stage 1 \ Dropdown Readiness Date (Computer)' option from 'Task' autocomplete
	When User selects 'Started' in the 'Update Value' dropdown
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

	#AnnI 6/2/20: DAS21304 fixed only for 'Yellow_Dwarf'
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13281 @DAS13284 @DAS13285 @DAS21304 @Cleanup @Yellow_Dwarf
Scenario Outline: EvergreenJnr_DevicesList_ChecksThatDllOptionsAreDisplayedCorrectly
	When User create new User via API
	| Username   | Email | FullName | Password  | Roles                 |
	| <Username> | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| <Username> | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	When User enters 'Computer Read Only Task in Self Service' in the 'Task' autocomplete field and selects 'Computer Information ---- Text fill; Text fill; \ Computer Read Only Task in Self Service' value
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options        |
	| No change      |
	| Not Applicable |
	| Not Started    |
	| Started        |
	| Failed         |
	| Complete       |
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                                   |
	| No change                                 |
	| Update                                    |
	| Update relative to current value          |
	| Update relative to now                    |
	| Update relative to a different task value |
	| Remove                                    |
	Then following Values are displayed in the 'Update Owner' dropdown:
	| Options               |
	| No change             |
	| Update                |
	| Remove owner          |
	| Remove owner and team |
	When User enters 'Workstation Text Task' in the 'Task' autocomplete field and selects 'Computer Information ---- Text fill; Text fill; \ Workstation Text Task' value
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options   |
	| Update    |
	| Remove    |
	When User enters 'Computer Read Only Task in Self Service' in the 'Task' autocomplete field and selects 'Computer Information ---- Text fill; Text fill; \ Computer Read Only Task in Self Service' value
	Then following Values are displayed in the 'Update Value' dropdown:
	| Options        |
	| No change      |
	| Not Applicable |
	| Not Started    |
	| Started        |
	| Failed         |
	| Complete       |
	When User selects 'Started' in the 'Update Value' dropdown
	And User selects 'No change' in the 'Update Date' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'CANCEL' button
	Then inline tip banner is not displayed
	When User navigate to the bottom of the Action panel
	When User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
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
	And User removes "<Username>" User

Examples:
	| Username   | RowName        | MessageText                                                   |
	| DAS13281_1 | 00HA7MKAVVFDAV | 1 of 1 object was in the selected project and has been queued |
	| DAS13281_2 | 00I0COBFWHOF27 | 0 of 1 object was in the selected project and has been queued |

	#AnnI. 2/21/20 Will be checked on Monday with Marina.
	#It looks like access has changed. Need to update the test.
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @DAS14127 @Cleanup @Not_Ready
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForDateField
	When User create new User via API
	| Username | Email | FullName | Password  | Roles                 |
	| <Name>   | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password  |
	| <Name>   | m!gration |
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
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Jan 20, 2019' text to 'Date' datepicker
	When User focus on 'Capacity Slot' dropdown
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User focus on 'Update Owner' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User navigate to the bottom of the Action panel
	When User selects '<NewTeam>' option from 'Team' autocomplete
	When User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	And Success message is hidden after five seconds
	When User refreshes agGrid
	Then '<DefaultValue>' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column
	#returns default object state
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' option from 'Bulk Update Type' autocomplete
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User Acceptance Test' option from 'Stage' autocomplete
	And User selects 'Perform User Acceptance Test' option from 'Task' autocomplete
	And User selects 'No change' in the 'Update Value' dropdown
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters 'Jan 20, 2019' text to 'Date' datepicker
	When User focus on 'Capacity Slot' dropdown
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User focus on 'Update Owner' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User navigate to the bottom of the Action panel
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