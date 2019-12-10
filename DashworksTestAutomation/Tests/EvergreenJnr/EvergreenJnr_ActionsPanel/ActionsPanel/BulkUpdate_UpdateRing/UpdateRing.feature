Feature: UpdateRing
	Runs Bulk Update Update ring related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19149
Scenario: EvergreenJnr_DevicesList_ChecksUpdateRingInBulkUpdateTypeTeamToGroupSecurity
	When User clicks 'Projects' on the left-hand menu
	When User navigate to Manage link
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username        | Password  |
	| TestBulkUpdater | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Bulk Update Roles" list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	When User selects 'Evergreen Ring 1' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "9ETO002HMASTNX"
	Then 'Evergreen Ring 1' content is displayed in the 'Evergreen Ring' column
	When User clicks cross icon in Table search field
	And User perform search by "Z11REX196H34MG"
	Then 'Unassigned' content is displayed in the 'Evergreen Ring' column
	When User clicks cross icon in Table search field
		#Revert Changes
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update ring' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	When User selects 'Unassigned' option from 'Ring' autocomplete
	And User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel