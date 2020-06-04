Feature: UpdateCustomFieldPart1
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17878 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldForRemoveAllValuesValidation
	When User clicks '<ListName>' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' option from 'Bulk Update Type' autocomplete
	And User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	Then 'UPDATE' button is disabled
	When User selects 'Remove all values' in the 'Update Values' dropdown
	Then 'UPDATE' button is not disabled

Examples:
	| ListName     | ColumnName    | Row                              |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                   |
	| Users        | Username      | 003F5D8E1A844B1FAA5              |
	| Applications | Application   | 7-Zip 16.02 (x64)                |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17878 @DAS18031 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldForReplaceAllValuesValidation
	When User clicks '<ListName>' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' option from 'Bulk Update Type' autocomplete
	And User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace all values' in the 'Update Values' dropdown
	When User adds '1' value from 'Value' textbox
	When User adds '2' value from 'Value' textbox
	When User adds '3' value from 'Value' textbox
	When User adds '4' value from 'Value' textbox
	When User adds '5' value from 'Value' textbox
	When User adds '6' value from 'Value' textbox
	When User adds '7' value from 'Value' textbox
	When User adds '8' value from 'Value' textbox
	When User adds '9' value from 'Value' textbox
	When User adds '10' value from 'Value' textbox
	#DAS18031
	Then 'Value limit has been reached' add button tooltip is displayed for 'Value' textbox
	Then 'UPDATE' button is not disabled

Examples:
	| ListName     | ColumnName    | Row                                        |
	| Devices      | Hostname      | 00YTY8U3ZYP2WT                             |
	| Users        | Username      | 00A5B910A1004CF5AC4                        |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| Mailboxes    | Email Address | 00DB4000EDD84951993@bclabs.local           |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17878 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldForAddToExistingValuesValidation
	When User clicks '<ListName>' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' option from 'Bulk Update Type' autocomplete
	And User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds 'test' value from 'Value' textbox
	Then 'UPDATE' button is not disabled

Examples:
	| ListName     | ColumnName    | Row                                        |
	| Devices      | Hostname      | 00YTY8U3ZYP2WT                             |
	| Users        | Username      | 00A5B910A1004CF5AC4                        |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| Mailboxes    | Email Address | 00DB4000EDD84951993@bclabs.local           |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17878 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldForRemoveSpecificValuesValidation
	When User clicks '<ListName>' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' option from 'Bulk Update Type' autocomplete
	And User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'test' value from 'Value' textbox
	Then 'UPDATE' button is not disabled

Examples:
	| ListName     | ColumnName    | Row                                        |
	| Devices      | Hostname      | 00YTY8U3ZYP2WT                             |
	| Users        | Username      | 00A5B910A1004CF5AC4                        |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| Mailboxes    | Email Address | 00DB4000EDD84951993@bclabs.local           |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS17878 @Not_Ready
#Waiting for "Update custom field" on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckUpdateCustomFieldForReplaceSingleValueValidation
	When User clicks '<ListName>' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <Row>            |
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update custom field' option from 'Bulk Update Type' autocomplete
	And User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	And User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters 'tests' text to 'Find Value' textbox
	Then 'UPDATE' button is disabled
	When User enters '012' text to 'Replace Value' textbox
	Then 'UPDATE' button is not disabled

Examples:
	| ListName     | ColumnName    | Row                                        |
	| Devices      | Hostname      | 00YTY8U3ZYP2WT                             |
	| Users        | Username      | 00A5B910A1004CF5AC4                        |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| Mailboxes    | Email Address | 00DB4000EDD84951993@bclabs.local           |