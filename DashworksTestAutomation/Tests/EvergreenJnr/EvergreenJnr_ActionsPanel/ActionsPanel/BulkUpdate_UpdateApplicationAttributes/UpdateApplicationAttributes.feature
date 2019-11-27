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
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	Then 'Sticky Compliance' dropdown is not displayed
	When User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then following Values are displayed in the 'Sticky Compliance' dropdown:
	| Options   |
	| No Change |
	| Ignore    |
	| Amber     |
	| Red       |
	| Green     |
	When User selects 'Red' in the 'Sticky Compliance' dropdown
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled