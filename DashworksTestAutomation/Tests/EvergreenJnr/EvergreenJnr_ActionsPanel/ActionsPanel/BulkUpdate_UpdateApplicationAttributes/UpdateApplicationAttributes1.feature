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

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19126 @Not_Ready
#Waiting 'In Catalog' dropdown for Update application attributes
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
	When User selects 'zUser Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	Then 'In Catalog' dropdown is not displayed