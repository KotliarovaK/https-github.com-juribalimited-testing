Feature: ActionsPanelPart2
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @DAS13259 @DAS13260 @DAS13263 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExist
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<ColumnHeader>' column header
	When User create dynamic list with "DynamicList12946" name on "<PageName>" page
	Then "DynamicList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	Then following Values are displayed in the 'Action' dropdown:
	| Value              |
	| Create static list |
	| Bulk update        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then "UPDATE" Action button is disabled
	And "CANCEL" Action button is active
	When User selects '<ProjectName>' option from 'Project' autocomplete
	And User selects '<StageName>' option from 'Stage' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
	And User selects '<Value>' in the 'Value' dropdown
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "0 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	Then There are no errors in the browser console

Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName              | StageName      | TaskName                | Value                    |
	| Devices      | Hostname      | 001PSUMZYOW581                   | User Scheduled Test (Jo) | Two            | Radio Non Rag only Comp | Not Applicable           |
	| Users        | Username      | 003F5D8E1A844B1FAA5              | User Scheduled Test (Jo) | Two            | Radio Non Rag only User | Not Applicable           |
	| Applications | Application   | 7zip                             | User Scheduled Test (Jo) | Two            | Radio Non Rag only App  | Not Applicable           |
	| Mailboxes    | Email Address | 00BDBAEA57334C7C8F4@bclabs.local | Email Migration          | Mobile Devices | Mobile Device Status    | Identified & In Progress |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelWhenOnlOneStaticListExists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList12946" name
	Then "StaticList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	Then following Values are displayed in the 'Action' dropdown:
	| Value                   |
	| Create static list      |
	| Remove from static list |
	| Bulk update             |

Examples:
	| PageName     | ColumnHeader  | RowName                          |
	| Devices      | Hostname      | 001PSUMZYOW581                   |
	| Users        | Username      | 002B5DC7D4D34D5C895              |
	| Applications | Application   | 20040610sqlserverck              |
	| Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDataOnceTheStaticListHasBeenCreated  
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| <Checkboxes>       |
	Then "<FilterName>" filter is added to the list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList12946" name
	Then "StaticList12946" list is displayed to user
	And table content is present
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	#Then "<SelectedRowsCount>" selected rows are displayed in the Actions panel
	When User clicks 'Action' dropdown

Examples:
	| PageName     | FilterName       | Checkboxes | SelectedRowsCount |
	| Devices      | Compliance       | Red        | 9174              |
	| Users        | Compliance       | Red        | 9438              |
	| Applications | Compliance       | Red        | 181               |
	| Mailboxes    | Owner Compliance | Green      | 14701             |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12863 @DAS13266 @DAS13284 @DAS16826
Scenario: EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Path |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	| 00BDM1JUR8IF419  |
	| 00RUUMAH9OZN9A   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	Then "UPDATE" Action button is disabled
	When User selects 'Computer: PC Rebuild' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "3 of 3 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "001PSUMZYOW581"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Path" column
	When User perform search by "00BDM1JUR8IF419"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Path" column
	When User perform search by "00RUUMAH9OZN9A"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Path" column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Virtual Machine' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects '[This is the Default Request Type for Computer)] ' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00RUUMAH9OZN9A   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Laptop Replacement' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel