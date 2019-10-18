Feature: ActionsPanelPart12
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 3/10/19: fixed on 'radiant'
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15618 @Not_Run
Scenario: EvergreenJnr_DevicesList_ChecksThatCapacityAffectingNonCapacityEnabledDateTasks
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "1803: Migration \ Migrated Date" filter where type is "Not empty" with added column and Date options
	| StartDateInclusive | EndDateInclusive |
	Then "7" rows are displayed in the agGrid
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| CDQ172G3MZS444   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	And User selects 'None' in the 'Capacity Slot' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16125
Scenario: EvergreenJnr_DevicesList_CheckThatChangingProjectOrEvergreenDoesNotMakeBrowserTabUnresponsiveAndDoesNotLoadTheClientProcessor
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00CWZRC4UK6W20   |
	| 00HA7MKAVVFDAV   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	And User selects 'London - Southbank' option from 'Capacity Unit' autocomplete
	#====#
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'I-Computer Scheduled Project' option from 'Project' autocomplete
	And User selects '[Default (Computer)]' option from 'Path' autocomplete
	#====#
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	And User selects 'Project' in the 'Project or Evergreen' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Unassigned' option from 'Ring' autocomplete
	And User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	And User selects 'Evergreen Ring 1' option from 'Ring' autocomplete
	#====#
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Babel (English, German and French)' option from 'Project' autocomplete
	And User selects 'Initiation' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	#====#
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	And User selects 'Evergreen Bucket 1' option from 'Bucket' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel