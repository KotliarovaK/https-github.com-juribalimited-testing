Feature: AssociationsFunctionality5
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS18092
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewDeviceOwnerOptionsAreAddedToAssociationsDropdown
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then "Used by device owner" filter is presented in the filters list
	When User selects 'Entitled to device owner' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then "Used by device owner" filter is presented in the filters list
	When User selects 'Not used by device owner' option in 'Search associations' autocomplete of Associations panel
	Then Remove icon displayed in 'false' state for 'Entitled to device owner' association
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console
	Then table content is present

@Evergreen @Associations @DAS18987	@Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListCanBeGeneratedBasedOnOsBranchFilter
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Installed on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Device OS Branch" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User clicks 'RUN LIST' button
	Then table content is present
	When User creates 'AssociationListS18987' dynamic list
	Then "AssociationListS18987" list is displayed to user
	When User navigates to the "AssociationListS18987" list
	Then There are no errors in the browser console
	Then table content is present

@Evergreen @Associations @DAS19320
Scenario: EvergreenJnr_ApplicationsList_CheckThat
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User remembers the found rows number
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Manufacturer     |
	| CPU Architecture |
	When User clicks 'RUN LIST' button
	Then table content is present
	Then Rows counter number equals to remembered value

@Evergreen @Associations @DAS19185 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListRunSuccessfullyAfterAddingColumnsForTheSameCustomFieldForDeviceAndApplication
	When User creates new Custom Field via API
	| FieldName      | FieldLabel    | AllowExternalUpdate | Enabled | Computer | Application |
	| CustomDAS19185 | LabelDAS19185 | true                | true    | true     | true        |
	When User navigates to the 'Device' details page for 'QFI94WAUX17N4I' item
	Then Details page for 'QFI94WAUX17N4I' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	And User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'LabelDAS19185' option from 'Custom Field' autocomplete
	When User enters 'Value19185_1' text to 'Value' textbox
	When User clicks 'ADD' button on popup
	When User navigates to the 'Application' details page for 'Access 95' item
	Then Details page for 'Access 95' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	When User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'LabelDAS19185' option from 'Custom Field' autocomplete
	When User enters 'Value19185_2' text to 'Value' textbox
	When User clicks 'ADD' button on popup
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Device LabelDAS19185" filter where type is "Not empty" with added column and following value:
	| Values |
	When User add "App LabelDAS19185" filter where type is "Not empty" with added column and following value:
	| Values |
	When User clicks the Associations button
	When User clicks 'RUN LIST' button
	Then table content is present
	Then There are no errors in the browser console