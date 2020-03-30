Feature: AssociationsFunctionality6
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS18092
Scenario: EvergreenJnr_ApplicationsList_CheckThatOrRequestHasCorrectOperatorParameter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then Associations request has correct operator

@Evergreen @Associations @DAS18859 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceLocationColumnsAndFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
		| ColumnName     |
		| Device Country |
	When User clicks the Columns button
	When User clicks 'RUN LIST' button
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "Device Country" filter where type is "Equals" with added column and Lookup option
		| SelectedValues |
		| USA            |
		| Australia      |
		| England        |
	When User Add And "Device Building" filter where type is "Not empty" with added column and Lookup option
		| SelectedValues |
	When User Add And "Device City" filter where type is "Does not equal" with added column and Lookup option
		| SelectedValues |
		| London         |
	When User Add And "Device Floor" filter where type is "Not empty" with added column and Lookup option
		| SelectedValues |
	When User Add And "Device Location Name" filter where type is "Equals" with added column and Lookup option
		| SelectedValues        |
		| 101 Hudson Street F20 |
		| 101 Hudson Street F21 |
		| 120 Collins Street F5 |
	When User Add And "Device Postal Code" filter where type is "Does not contain" with added column and following value:
		| Values |
		| 3000   |
	When User Add And "Device State County" filter where type is "Equals" with added column and Lookup option
		| SelectedValues |
		| AB             |
		| Empty          |
		| CA             |
		| NJ             |
		| NY             |
		| VIC            |
	When User clicks 'RUN LIST' button
	When User creates 'List_DAS18859' dynamic list
	Then "List_DAS18859" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
		| RowGroups       |
		| Device Country  |
		| Device Building |
		| Device City     |
		| Device Floor    |
	When User selects the following Columns on Pivot:
		| Columns              |
		| Device Location Name |
		| Device Postal Code   |
	When User selects the following Values on Pivot:
		| Values              |
		| Device Region       |
		| Device State County |
	When User clicks 'RUN PIVOT' button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS18859" name
	Then "Pivot_DAS18859" list is displayed to user
	When User navigates to the "List_DAS18859" list
	When User clicks the Columns button
	When User removes "Device Postal Code" column by Column panel
	When User clicks 'RUN LIST' button
	Then '(Edited)' prefix for active list is displayed to user
	Then 'SAVE' button is not disabled