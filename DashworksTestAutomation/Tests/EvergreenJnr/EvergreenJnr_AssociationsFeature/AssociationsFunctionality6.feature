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
	When User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then Associations request has correct operator
