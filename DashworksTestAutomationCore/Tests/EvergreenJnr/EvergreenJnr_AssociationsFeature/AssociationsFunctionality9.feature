Feature: AssociationsFunctionality9
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS21074
Scenario: EvergreenJnr_Applications_CheckThatNoErrorAppearsRunningDifferentLists
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Application Devices" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	Then There are no errors in the browser console
	When User navigates to the "All User Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used by user' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	Then There are no errors in the browser console