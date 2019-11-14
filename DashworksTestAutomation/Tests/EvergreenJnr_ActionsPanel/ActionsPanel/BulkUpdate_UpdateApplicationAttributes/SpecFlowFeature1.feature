Feature: Update application attributes
	Runs Update application attributes actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18647 @Not_Ready
#Waiting for "Update application attributes" on the automation
Scenario: EvergreenJnr_ApplicationsList_CheckBulkUpdateUpdateStickyComplianceFields
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select " " rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'test' value from 'Value' textbox
	Then 'UPDATE' button is not disabled