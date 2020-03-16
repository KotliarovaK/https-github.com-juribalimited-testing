Feature: UpdateApplicationAttributes
	Runs Update application attributes actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18647 @DAS18461
Scenario: EvergreenJnr_ApplicationsList_CheckBulkUpdateUpdateStickyComplianceValidation
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	Then 'Sticky Compliance' dropdown is not displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	When User navigate to the bottom of the Action panel
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Rationalisation' dropdown:
	| Options       |
	| No change     |
	| FORWARD PATH  |
	| KEEP          |
	| RETIRE        |
	| UNCATEGORISED |
	Then following Values are displayed in the 'Sticky Compliance' dropdown:
	| Options   |
	| No change |
	| Remove    |
	| UNKNOWN   |
	| RED       |
	| AMBER     |
	| GREEN     |
	| IGNORE    |
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18715 @DAS19033
Scenario: EvergreenJnr_ApplicationsList_CheckBulkUpdateUpdateStickyCompliance
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| Sticky Compliance |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName                         |
	|0047 - Microsoft Access 97 SR-2 Francais  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Remove' in the 'Sticky Compliance' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '' content is displayed in the 'Sticky Compliance' column
	#Revert 'Update application attributes' changes to default
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'UNKNOWN' in the 'Sticky Compliance' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'UNKNOWN' content is displayed in the 'Sticky Compliance' column

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19252 @DAS18463 @Not_Ready
#Waiting for "Update application attributes" on the automation
Scenario: EvergreenJnr_ApplicationsList_CheckBulkUpdateUpdateRationalisationDDLDisplay
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| Sticky Compliance |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName                         |
	|0047 - Microsoft Access 97 SR-2 Francais  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Rationalisation' dropdown:
	| Options       |
	| No change     |
	| FORWARD PATH  |
	| KEEP          |
	| RETIRE        |
	| UNCATEGORISED |
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'Sticky Compliance' dropdown is not displayed
	Then following Values are displayed in the 'Rationalisation' dropdown:
	| Options       |
	| FORWARD PATH  |
	| KEEP          |
	| RETIRE        |
	| UNCATEGORISED |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19213
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForDevicesScopedProject
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName                         |
	|0047 - Microsoft Access 97 SR-2 Francais  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19213
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForUserScopedProject
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName                         |
	|0047 - Microsoft Access 97 SR-2 Francais  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'RETIRE' in the 'Rationalisation' dropdown

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19213
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForMailboxesScopedProject
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName                         |
	|0047 - Microsoft Access 97 SR-2 Francais  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19236 @Not_Ready
#Waiting for 'Target Application'
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForSelectedForwardPathEvergreen
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName   |
	| CodeWright 6.0BETA |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters '2' text to 'Target Application' textbox
	Then validation message 'Enter at least 3 characters' is displayed below 'Target Application' field
	When User selects 'Starbase CodeWright 6.0BETA (107)' option from 'Target Application' autocomplete
	When User enters 'xine-devel' text to 'Target Application' textbox
	Then validation message 'No results found' is displayed below 'Target Application' field

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19236 @Not_Ready
#Waiting for 'Target Application'
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForSelectedForwardPath
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName   |
	| CodeWright 6.0BETA |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Wise for Windows Installer 4.02 Evaluation' in the 'Target Application' autocomplete field and selects 'Wise for Windows Installer 4.02 Evaluation (162997)' value
	When User enters 'xine-devel' text to 'Target Application' textbox
	Then validation message 'No results found' is displayed below 'Target Application' field
	When User enters 'Zune (03.01.0620.00)' text to 'Target Application' textbox
	Then validation message 'No results found' is displayed below 'Target Application' field

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18463
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForUpdateRationalisationValidations
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName   |
	| CodeWright 6.0BETA |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18516 @Not_Ready
#Waiting for 'Rationalisation' dropdown
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesWhenUpdateButtonIsClicked
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                |
	| Evergreen Rationalisation |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName   |
	| CodeWright 6.0BETA |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	#And User perform search by "Z11REX196H34MG"
	Then 'KEEP' content is displayed in the 'Evergreen Rationalisation' column
	#Revert Changes
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'UNCATEGORISED' content is displayed in the 'Evergreen Rationalisation' column

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18516 @Not_Ready
#Waiting for 'Rationalisation' dropdown
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateApplicationAttributesForUpdateButtonIsClicked
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                |
	| Evergreen Rationalisation |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName          |
	| Image Express Utility 2.0 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'PlexTools Professional V2.21' in the 'Target Application' autocomplete field and selects 'PlexTools Professional V2.21' value
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	#And User perform search by "Z11REX196H34MG"
	Then 'FORWARD PATH' content is displayed in the 'Evergreen Rationalisation' column
	#Revert Changes
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'UNCATEGORISED' content is displayed in the 'Evergreen Rationalisation' column