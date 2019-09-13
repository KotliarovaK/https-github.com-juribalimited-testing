Feature: UpdateCustomFieldPart2
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17292 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldValues
	When User clicks "<ListName>" on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects '<CustomFieldValue>' option from 'Custom Field' autocomplete
	Then '<MissingContent>' content is not displayed in 'Custom Field' autocomplete
	Then "UPDATE" Action button is disabled

Examples:
	| ListName     | ColumnName    | Row                              | CustomFieldValue  | MissingContent      |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                   | Computer Warranty | Zip Code            |
	| Users        | Username      | 003F5D8E1A844B1FAA5              | Telephone         | App field 2         |
	| Applications | Application   | 7-Zip 16.02 (x64)                | Application Owner | Mailbox Filter 1    |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Mailbox Filter 2  | Friendly Model Name |