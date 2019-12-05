Feature: UpdateApplicationAttributes
	Runs Update application attributes actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18647 @DAS18461 @Not_Ready
#Waiting for "Update application attributes" on the automation
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
	#Then 'Evergreen' content is displayed in 'Project or Evergreen' dropdown
	When User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
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
	| Empty     |
	| UNKNOWN   |
	| RED       |
	| AMBER     |
	| GREEN     |
	| IGNORE    |
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18715 @DAS19033 @Not_Ready
#Waiting for "Update application attributes" on the automation
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
	When User selects 'Empty' in the 'Sticky Compliance' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '' content is displayed in the 'Sticky Compliance' column
		#Revert 'Update application attributes' changes to default
	When User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'UNKNOWN' in the 'Sticky Compliance' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'UNKNOWN' content is displayed in the 'Sticky Compliance' column