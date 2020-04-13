Feature: Criticality
	Runs Criticality Update application attributes actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18845 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckThatUpdateCriticalityIsVisible
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Criticality' dropdown:
	| Options       |
	| No change     |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Criticality' dropdown:
	| Options       |
	| No change     |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19225 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateCriticalityWhenUpdateButtonClicked
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Criticality' dropdown:
	| Options       |
	| No change     |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19225 @DAS19562
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateButtonForEvergreenBulkUpdateCriticality
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                |
	| Criticality               |
	| Sticky Compliance         |
	| Evergreen Rationalisation |
	| In Catalog                |
	| Hide From End Users       |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| Backburner       |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'GREEN' in the 'Sticky Compliance' dropdown
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User selects 'FALSE' in the 'In Catalog' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	When User clicks Close panel button
	Then 'Core' content is displayed in the 'Criticality' column
	Then 'GREEN' content is displayed in the 'Sticky Compliance' column
	Then 'RETIRE' content is displayed in the 'Evergreen Rationalisation' column
	Then 'FALSE' content is displayed in the 'In Catalog' column
	Then 'TRUE' content is displayed in the 'Hide From End Users' column
	#Revert changes
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Uncategorised' in the 'Criticality' dropdown
	When User selects 'Remove' in the 'Sticky Compliance' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User selects 'FALSE' in the 'Hide From End Users' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	When User clicks Close panel button
	Then 'Uncategorised' content is displayed in the 'Criticality' column
	Then '' content is displayed in the 'Sticky Compliance' column
	Then 'KEEP' content is displayed in the 'Evergreen Rationalisation' column
	Then 'TRUE' content is displayed in the 'In Catalog' column
	Then 'FALSE' content is displayed in the 'Hide From End Users' column

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19225 @DAS19562 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateButtonForProjectBulkUpdateCriticality
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                      |
	| UseMeForAu: Criticality         |
	| UseMeForAu: Rationalisation     |
	| UseMeForAu: Hide From End Users |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| AddFlow 4        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project or Evergreen' autocomplete
	When User selects 'Important' in the 'Criticality' dropdown
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'Important' content is displayed in the 'UseMeForAu: Criticality' column
	Then 'RETIRE' content is displayed in the 'UseMeForAu: Rationalisation' column
	Then 'TRUE' content is displayed in the 'UseMeForAu: Hide From End Users' column
	#Revert changes
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' option from 'Project or Evergreen' autocomplete
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'FALSE' in the 'Hide From End Users' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'Core' content is displayed in the 'UseMeForAu: Criticality' column
	Then 'KEEP' content is displayed in the 'UseMeForAu: Rationalisation' column
	Then 'FALSE' content is displayed in the 'UseMeForAu: Hide From End Users' column