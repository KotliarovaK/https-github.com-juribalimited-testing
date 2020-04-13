Feature: CheckingUpdatedValue2
	Runs Checking Updated Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 3/13/20 GD is only ready on 'Wormhole'
@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19273 @Wormhole
Scenario: EvergreenJnr_UsersList_CheckUpdateRelativeToDifferentTaskValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Stage B \ Original Task |
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
	When User selects 'Stage B \ Original Task' option from 'Task' autocomplete
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	#Waiting for renamed Relative Project dropdown
	#When User selects 'zUser Sch for Automations Feature' option from 'Relative Project' autocomplete
	When User selects 'Stage 2 \ Relative Task' option from 'Relative Task' autocomplete
	When User enters '5' text to 'Value' textbox
	When User selects 'Days' in the 'Units' dropdown
	When User selects 'Before now' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then 'UPDATE' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "15 Feb 2020" content is displayed for "zDeviceAut: Stage B \ Original Task" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage B \ Original Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '20 Feb 2020' text to 'Date' datepicker
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "20 Feb 2020" content is displayed for "zDeviceAut: Stage B \ Original Task" column