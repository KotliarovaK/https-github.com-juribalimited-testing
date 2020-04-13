Feature: UpdateRing
	Runs Bulk Update Update ring related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19149
Scenario: EvergreenJnr_DevicesList_ChecksUpdateRingInBulkUpdateTypeTeamToGroupSecurity
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username        | Password  |
 	| TestBulkUpdater | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Bulk Update Roles" list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	Then 'Project or Evergreen' autocomplete is displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'TestBulkUpdate' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User closes Actions panel
	When User refreshes agGrid
	And User perform search by "Z11REX196H34MG"
	Then 'Unassigned' content is displayed in the 'Evergreen Ring' column
	When User clicks cross icon in Table search field
		#Revert Changes
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	Then 'Project or Evergreen' autocomplete is displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "Z11REX196H34MG"
	Then '[Default (Computer)]' content is displayed in the 'zDeviceAut: Path' column