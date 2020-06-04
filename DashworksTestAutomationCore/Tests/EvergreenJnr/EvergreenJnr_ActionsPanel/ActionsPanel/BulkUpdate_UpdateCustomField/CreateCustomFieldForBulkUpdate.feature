Feature: CreateCustomFieldForBulkUpdate
	Runs Create Custom field for Bulk Update Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Projects
	When User navigate to Manage link
	And User select "Custom Fields" option in Management Console

@Evergreen @EvergreenJnr_AdminPage @BulkUpdate @DAS18166 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckBulkUpdateCustomFieldActionsForDisabledCustomField
	When User creates new Custom Field
	| FieldName | FieldLabel | AllowExternalUpdate | Enabled | User |
	| DAS18166  | 18166_CF   | true                | false   | true |
	And User navigate to Evergreen URL
	When User clicks 'Users' on the left-hand menu
	And User clicks the Actions button
	And User select "Display Name" rows in the grid
	| SelectedRowsName |
	| Hunter, Melanie  |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' option from 'Bulk Update Type' autocomplete
	Then '18166_CF' content is not displayed in 'Custom Field' autocomplete after search