Feature: UpdateCustomFieldPart2
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17292
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldValues
	When User clicks '<ListName>' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects '<CustomFieldValue>' option from 'Custom Field' autocomplete
	Then '<MissingContent>' content is not displayed in 'Custom Field' autocomplete after search
	Then 'UPDATE' button is disabled

Examples:
	| ListName     | ColumnName    | Row                              | CustomFieldValue  | MissingContent      |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                   | Computer Warranty | Zip Code            |
	| Users        | Username      | 003F5D8E1A844B1FAA5              | Telephone         | App field 2         |
	| Applications | Application   | 7-Zip 16.02 (x64)                | Application Owner | Mailbox Filter 1    |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Mailbox Filter 2  | Friendly Model Name |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18045 @DAS18027
Scenario: EvergreenJnr_DevicesList_CheckUpdateCustomFieldUpdatingValuesForRemoveAllValues
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Begins with" with added column and following value:
	| Values |
	| 001    |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove all values' in the 'Update Values' dropdown
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds '111' value from 'Value' textbox
	When User adds '000' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '000, 111' content is displayed in the 'Phoenix Field' column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18045 @DAS18031 @DAS18027
Scenario: EvergreenJnr_UsersList_CheckUpdateCustomFieldUpdatingValuesForAddToExistingValues
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Begins with" with added column and following value:
	| Values |
	| 002    |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Add to existing values' in the 'Update Values' dropdown
	#DAS18031
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#DAS18031
	When User adds 'alpha' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'alpha, beta' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace all values' in the 'Update Values' dropdown
	#DAS18031
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#DAS18031
	When User adds 'beta' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18045 @DAS18031 @DAS18027
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateCustomFieldUpdatingValuesForReplaceSingleValue
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Begins with" with added column and following value:
	| Values |
	| Easy   |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	#DAS18031
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#DAS18031
	When User enters 'first value' text to 'Find Value' textbox
	When User enters 'second' text to 'Replace Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'second' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters 'second' text to 'Find Value' textbox
	When User enters 'first value' text to 'Replace Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18045 @DAS18031 @DAS18027 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario: EvergreenJnr_MailboxesList_CheckUpdateCustomFieldUpdatingValuesForReplaceSingleValue
	When User clicks 'Mailboxes' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Email Address (Primary)" filter where type is "Begins with" with added column and following value:
	| Values |
	| 00b    |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Phoenix Field |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	#DAS18031
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'Enter a value' add button tooltip is displayed for 'Value' textbox
	Then Add button for 'Value' textbox is disabled
	When User enters 'test' text to 'Value' textbox
	Then 'Add value' add button tooltip is displayed for 'Value' textbox
	When User adds '01' value from 'Value' textbox
	#DAS18031
	When User adds 'three' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '02' content is displayed in the 'Phoenix Field' column
		#Revert 'Update custom field' changes to default
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds '01' value from 'Value' textbox
	When User adds 'three' value from 'Value' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 updates have been queued" text is displayed on Action panel