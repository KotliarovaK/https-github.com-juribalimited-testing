Feature: UpdateCustomField
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17878 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldForRemoveAllValues
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	And User selects "Bulk update" in the Actions dropdown
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' in the 'Custome Field' dropdown
	When User selects 'Remove all values' in the 'Update Values' dropdown

	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box

Examples:
	| ListName     | ColumnName    | Row                              | RowName                                  | ProjectName                        |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                   |                                          | Babel (English, German and French) |
	| Users        | Username      | 003F5D8E1A844B1FAA5              |                                          | Barry's User Project               |
	| Applications | Application   | 7-Zip 16.02 (x64)                | 0047 - Microsoft Access 97 SR-2 Francais | Barry's User Project               |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local |                                          |                                    |