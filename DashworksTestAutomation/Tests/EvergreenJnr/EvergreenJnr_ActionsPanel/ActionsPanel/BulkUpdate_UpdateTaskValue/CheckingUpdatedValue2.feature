Feature: CheckingUpdatedValue2
	Runs Checking Updated Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19273 @Void
Scenario: EvergreenJnr_UsersList_CheckUpdateRelativeToDifferentTaskValue
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| ???????????????????????????? |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values             |
	| MagicDraw UML 4.51 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '?????????????????????????' option from 'Project' autocomplete
	When User selects '????????????????' option from 'Task' autocomplete
	When User selects 'Update relative to a different task valuel' in the 'Update Date' dropdown
	When User selects '?????????????????????????' option from 'Project' autocomplete
	When User selects '????????????????' option from 'Relative Task' autocomplete
	When User enters '5' text to 'Value' textbox
	When User selects 'Days' in the 'Units' dropdown
	When User selects 'After now' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then 'UPDATE' button is displayed on inline tip banner
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "??????????" content is displayed for "??????????????" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '?????????????????????????' option from 'Project' autocomplete
	When User selects '????????????????' option from 'Task' autocomplete
	When User selects 'Update relative to a different task valuel' in the 'Update Date' dropdown
	When User selects '?????????????????????????' option from 'Project' autocomplete
	When User selects '????????????????' option from 'Relative Task' autocomplete
	When User enters '5' text to 'Value' textbox
	When User selects 'Days' in the 'Units' dropdown
	When User selects 'After now' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then 'UPDATE' button is displayed on inline tip banner
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "??????????" content is displayed for "??????????????" column