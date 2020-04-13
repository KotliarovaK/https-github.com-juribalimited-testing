Feature: HideFromEndUsers
	Runs Hide From End Users Update application attributes actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19129 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersIsVisible
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
	Then 'No change' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button is disabled
	Then 'CANCEL' button is not disabled
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Hide From End Users' dropdown:
	| Options   |
	| No change |
	| TRUE      |
	| FALSE     |
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown
	Then 'No change' content is displayed in 'Hide From End Users' dropdown
	Then 'CANCEL' button is not disabled
	Then 'UPDATE' button has tooltip with 'Select at least one value to change' text
	Then following Values are displayed in the 'Hide From End Users' dropdown:
	| Options   |
	| No change |
	| TRUE      |
	| FALSE     |