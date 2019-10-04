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
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "1803 Rollout" Project on Action panel
	And User selects "Migration" Stage on Action panel
	And User selects "Migrated Date" Task on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects next Tuesday Date on Action panel
	And User selects "None" value for "Capacity Slot" dropdown on Action panel
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel