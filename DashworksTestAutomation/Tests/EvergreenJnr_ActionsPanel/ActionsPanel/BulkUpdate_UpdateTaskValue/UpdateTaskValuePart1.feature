Feature: UpdateTaskValuePart1
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithBeforeCurrentValueUpdateDate
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Relative BU \ DT BU Dev |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "14 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "15 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithNoChangeUpdateValue
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                |
	| zUserAutom: Relative BU \ DT BU Us (Date) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 2176236000044A2CA08 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Us' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	When User refreshes agGrid
	#Then '16 Oct 2019' content is displayed in the 'zUserAutom: Relative BU \ DT BU Us (Date)' column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Us' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	#Then '16 Oct 2019' content is displayed in the 'zUserAutom: Relative BU \ DT BU Us (Date)' column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithAfterCurrentValueUpdate
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zMailboxAu: Relative BU \ DT BU Users (Date) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 06C02CDC00044A7DB59 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Users' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "" content is displayed for "zMailboxAu: Relative BU \ DT BU Users (Date)" column