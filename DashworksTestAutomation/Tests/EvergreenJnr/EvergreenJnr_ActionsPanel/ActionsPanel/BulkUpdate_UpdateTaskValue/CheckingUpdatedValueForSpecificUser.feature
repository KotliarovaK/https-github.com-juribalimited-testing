Feature: CheckingUpdatedValueForSpecificUser
	Runs Checking Updated Value For Specific User related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @DAS14127 @DAS18267 @Cleanup
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForValueField
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
	Then warning inline tip banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
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
	And User selects 'No change' in the 'Update Date' dropdown
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects '<DefaultTeam>' option from 'Team' autocomplete
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	And User navigate to the top of the Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '<DefaultValue>' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column

Examples:
	| Name    | RowName    | NewValue       | NewTeam  | DefaultValue   | DefaultTeam         |
	| DAS1321 | CQV0623434 | Complete       | Admin IT | Started        | Administrative Team |
	| DAS1322 | BBZ877343  | Failed         | Admin IT | Not Applicable | Retail Team         |
	| DAS1323 | DLL972653  | Complete       | Admin IT | Not Started    | K-Team              |
	| DAS1324 | LZI970280  | Not Applicable | Admin IT | Failed         | IB Team             |
	| DAS1325 | ZQX656408  | Not Applicable | Admin IT | Complete       | Migration Phase 2   |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287 @Cleanup
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForOwnerField
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
	Then warning inline tip banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
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
	And User enters '9 Jan 2019' text to 'Date' datepicker
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
	| Name       | RowName    | NewValue       | DefaultValue   |
	| DAS13280   | CQV0623434 | Complete       | Started        |
	| DAS13281_1 | BBZ877343  | Failed         | Not Applicable |
	| DAS13282   | DLL972653  | Complete       | Not Started    |
	| DAS13283   | LZI970280  | Not Applicable | Failed         |
	| DAS13284   | ZQX656408  | Not Applicable | Complete       |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13290 @DAS14127 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatDateRemovingIsWorksCorrectly
	When User create new User via API
	| Username | Email | FullName | Password  | Roles                 |
	| DAS13290 | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password  |
	| DAS13290 | m!gration |
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
	Then warning inline tip banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
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
	Then warning inline tip banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'Failed' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13291 @DAS14127 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatOwnerRemovingIsWorksCorrectly
	When User create new User via API
	| Username | Email | FullName | Password  | Roles                 |
	| DAS13291 | Value | Test     | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password  |
	| DAS13291 | m!gration |
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
	And User enters '21 Nov 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User selects 'Remove owner and team' in the 'Update Owner' dropdown
	And User clicks 'UPDATE' button 
	Then warning inline tip banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
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
	And User enters '27 Dec 2018' text to 'Date' datepicker
	And User selects 'User Slot' in the 'Capacity Slot' dropdown
	When User selects 'No change' in the 'Update Owner' dropdown
	And User clicks 'UPDATE' button 
	Then warning inline tip banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'Failed' content is displayed in the 'Windows7Mi: User Acceptance Test \ Perform User Acceptance Test' column