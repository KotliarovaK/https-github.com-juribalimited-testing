Feature: AssociationsFunctionality7
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS20187 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectApplicationAssociationsArePersistedOfTheAllValues
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects '*Project K-Computer Scheduled Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Current' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User creates 'Association20187' dynamic list
	When User remembers the found rows number
	When User navigates to the "All Applications" list
	When User navigates to the "All Device Applications" list
	When User navigates to the "Association20187" list
	Then Rows counter number equals to remembered value

@Evergreen @Associations @DAS20131
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserCantAddMoreThanFiveAssociations
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	Then 'ADD NEW' button is disabled
	Then 'ADD NEW' button has tooltip with 'Maximum of 5 association groups are allowed' text