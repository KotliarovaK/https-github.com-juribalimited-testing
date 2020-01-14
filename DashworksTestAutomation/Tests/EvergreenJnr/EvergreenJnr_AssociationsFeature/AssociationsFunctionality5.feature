Feature: AssociationsFunctionality5
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS18092
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewDeviceOwnerOptionsAreAddedToAssociationsDropdown
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	Then "Entitled to device owner" filter is presented in the filters list
	Then "Used by device owner" filter is presented in the filters list
	When User selects 'Entitled to device owner' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	Then "Used by device owner" filter is presented in the filters list
	Then "Not used by device owner" filter is presented in the filters list
	When User selects 'Not used by device owner' option in 'Search associations' autocomplete of Associations panel
	Then Remove icon displayed in 'false' state for 'Entitled to device owner' association
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console
	Then table content is present

@Evergreen @Associations @DAS18987	@Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListCanBeGeneratedBasedOnOsBranchFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Installed on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Device OS Branch" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks Save button on the list panel
	When User selects Save as dynamic list option
	When User creates new custom list with "AssociationListS18987" name
	Then "AssociationListS18987" list is displayed to user
	When User navigates to the "AssociationListS18987" list
	Then There are no errors in the browser console
	Then table content is present

@Evergreen @Associations @DAS19185
Scenario: EvergreenJnr_ApplicationsList_CheckThatListOfResultsIsNotChangedAfterAddingCpuArchitectureAndManufacturerColumns
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
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