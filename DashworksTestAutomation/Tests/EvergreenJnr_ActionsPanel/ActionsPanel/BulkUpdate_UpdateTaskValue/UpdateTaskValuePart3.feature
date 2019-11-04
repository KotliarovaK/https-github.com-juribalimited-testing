Feature: UpdateTaskValuePart3
	Runs Bulk Update Update task value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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
	Then '<NewValue>' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column
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
	Then '<DefaultValue>' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column

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
	Then 'Complete' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column
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
	Then 'Failed' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column

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
	Then 'Failed' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column
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
	Then 'Failed' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13293 @DAS13359
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBannerMessage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| Havoc(BigD: Stage 0 \ Task 0 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Havoc(BigD: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Havoc(BigD: In Scope" filter is added to the list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Havoc (Big Data)' option from 'Project' autocomplete
	And User selects 'Stage 0' option from 'Stage' autocomplete
	And User selects 'Task 0' option from 'Task' autocomplete
	And User selects 'Started' in the 'Value' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "7578 of 7578 objects were in the selected project and have been queued" text is displayed on Action panel
	#wait for the process to complete
	When User waits for three seconds
	When User refreshes agGrid
	Then "STARTED" content is displayed for "Havoc(BigD: Stage 0 \ Task 0" column
	#returns default object state
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Havoc (Big Data)' option from 'Project' autocomplete
	And User selects 'Stage 0' option from 'Stage' autocomplete
	And User selects 'Task 0' option from 'Task' autocomplete
	And User selects 'Not Started' in the 'Value' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "7578 of 7578 objects were in the selected project and have been queued" text is displayed on Action panel
	#wait for the process to complete
	When User waits for three seconds
	When User refreshes agGrid
	Then "NOT STARTED" content is displayed for "Havoc(BigD: Stage 0 \ Task 0" column

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13386
Scenario: EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Pre-Migration' option from 'Stage' autocomplete
	Then only below options are displayed in the 'Task' autocomplete
	| Options                |
	| Forecast Date          |
	| Forecast Code          |
	| Target Date            |
	| Scheduled Date         |
	| Laptop Only Task       |
	| Physical Only Task     |
	| VDI Only Task          |
	| Laptop & Physical Task |
	| Target Code            |
	| Scheduled Code         |
	| Further Information    |
	| Targeting Information  |
	| Laptop & Workstation 2 |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13386 @DAS13477
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasks
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 003F5D8E1A844B1FAA5 |
	| 00A5B910A1004CF5AC4 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'User Scheduled Test (Jo)' option from 'Project' autocomplete
	Then only below options are displayed in the 'Stage' autocomplete
	| Options |
	| One     |
	| Two     |
	| Three   |
	When User selects 'One' option from 'Stage' autocomplete
	Then only below options are displayed in the 'Task' autocomplete
	| Options                            |
	| Radio Rag only User                |
	| Radio Rag Date User                |
	| Radio Rag Date Owner User          |
	| Text User                          |
	| Radio Rag Only User Req A          |
	| Radio Rag Date User Req A          |
	| Radio Rag Date Owner User Req A    |
	| Radio Rag only User Req B          |
	| Radio Rag Date User Req B          |
	| Radio Rag Date Owner User Req B    |
	| Radio Rag Date Owner Req B         |
	| SS Department and Location Enabled |

#Ann.Ilchenko 10/2/19: remove 'not run' tag when 'DAS18368' bug will be fixed.
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15291 @DAS18368 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlot
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Pre-Migration' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '23 Nov 2018' text to 'Date' datepicker
	Then following Values are displayed in the 'Capacity Slot' dropdown:
	| Options                      |
	| None                         |
	| Birmingham Morning           |
	| Birmingham Afternoon         |
	| Manchester Morning           |
	| Manchester Afternoon         |
	| London - City Morning        |
	| London - City Afternoon      |
	| London - Southbank Morning   |
	| London - Southbank Afternoon |
	| London Depot 09:00 - 11:00   |
	| London Depot 11:00 - 13:00   |
	| London Depot 13:00 - 15:00   |
	| London Depot 15:00 - 17:00   |