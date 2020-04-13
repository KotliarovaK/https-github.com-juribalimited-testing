Feature: UpdateApplicationAttributes1
	Runs Update application attributes actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19347 @Not_Ready
#Waiting for 'FORWARD PATH' field below 'Evergreen' option
Scenario: EvergreenJnr_ApplicationsList_CheckTargetApplicationSearchResultsBehaviour
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName          |
	| Image Express Utility 2.0 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	#Check Target Application search for project
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters '107' in the 'Target Application' autocomplete field and selects 'Starbase CodeWright 6.0BETA (107)' value
	#Check Target Application search for project
	When User selects 'zUser Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters '107' in the 'Target Application' autocomplete field and selects 'CodeWright 6.0BETA (107)' value

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19126 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckInCatalogDropdownForUpdateApplicationAttributes
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName          |
	| Image Express Utility 2.0 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' value is displayed in the 'In Catalog' dropdown
	When User selects 'TRUE' in the 'In Catalog' dropdown
	Then 'UPDATE' button is not disabled
	When User selects 'zUser Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	Then 'In Catalog' dropdown is not displayed

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19412 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckUpdateButtonForBulkUpdateInCatalog
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| In Catalog |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName                         |
	|0047 - Microsoft Access 97 SR-2 Francais  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'TRUE' content is displayed in the 'In Catalog' column
	#Revert changes
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'FALSE' in the 'In Catalog' dropdown
	When User clicks 'UPDATE' button
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 update has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then 'FALSE' content is displayed in the 'In Catalog' column