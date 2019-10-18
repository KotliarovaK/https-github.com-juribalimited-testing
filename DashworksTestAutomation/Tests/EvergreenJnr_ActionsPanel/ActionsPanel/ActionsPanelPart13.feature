Feature: ActionsPanelPart13
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18269 @DAS18245 @Not_Ready
#Waiting for 'Update relative to now'
Scenario: EvergreenJnr_UsersList_CheckRelativeUpdatesToTaskValues
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Relative BU \ DT BU App |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Begins with" with added column and following value:
	| Values |
	| boot   |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU App' option from 'Task' autocomplete
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	When User enters '5' text to 'Value' textbox
	When User selects 'After now' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with " " text is displayed on Action panel
	When User refreshes agGrid
	Then "+5 days from current" content is displayed for "zDeviceAut: Relative BU \ DT BU App" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18269 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now'
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithDateAndTimeProperties
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Date Computer' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18233 @Not_Ready
#Waiting for 'Update relative to now'
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithRadiobuttonProperties
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Radio Rag Date Owner' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |
	| No change                        |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18270 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithDateTaskOnlyProperties
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Date Computer' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	Then 'Days' content is displayed in 'Units' dropdown
	Then 'After current value' content is displayed in 'Before or After' dropdown
	When User enters '999999' text to 'Value' textbox
	Then '100000' content is displayed in 'Value' textbox
	When User enters '-5' text to 'Value' textbox
	Then '1' content is displayed in 'Value' textbox
	Then following Values are displayed in the 'Before or After' dropdown:
	| Options              |
	| Before current value |
	| After current value  |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18281 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithDateAndTimeTaskProperties
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Barry's User Project' option from 'Project' autocomplete
	When User selects 'Project Dates' option from 'Stage' autocomplete
	When User selects 'Forecast Date' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '12' text to 'Value' textbox
	When User selects 'Days' in the 'Units' dropdown
	Then 'After current value' content is displayed in 'Before or After' dropdown
	When User selects 'Before current value' in the 'Before or After' dropdown