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
	And User selects 'Update ring' option from 'Bulk Update Type' autocomplete
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
	And User selects 'Update ring' option from 'Bulk Update Type' autocomplete
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

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19004 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckBulkUpdateMessageWhenProcessingOffboardedObject
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| Project_19004 | All Devices | None            | Standalone Project |
	When User navigates to "Project_19004" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	When User clicks 'UPDATE ALL CHANGES' button 
	Then '2 devices will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigates to 'Onboarding History' page of Onboarding on Senior
	When User selects 'Project_19004' project in Project dropdown
	When User clicks '001PSUMZYOW581' value in History grid
	Then "Project Object" page is displayed to the user
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User selects 'Project_19004' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'OFFBOARD' button 
	When User waits for '2' seconds
	When User clicks 'OFFBOARD' button on popup
	When User clicks 'OFFBOARD' button on popup
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Actions button
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update ring' option from 'Bulk Update Type' autocomplete
	When User selects 'Project_19004' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "0 of 1 object was in the selected project and has been queued" text is displayed on Action panel