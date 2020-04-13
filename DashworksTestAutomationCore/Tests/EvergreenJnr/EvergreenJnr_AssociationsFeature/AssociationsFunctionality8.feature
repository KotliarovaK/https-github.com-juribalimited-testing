Feature: AssociationsFunctionality8
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS19810 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListCanBeCreatedWithFilterApplicationCustomField
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All User Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project or Evergreen' autocomplete
	When User selects 'Current' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Phoenix Field" filter where type is "Not empty" with added column and following value:
	| Values |
	When User clicks 'RUN LIST' button
	Then table content is present
	When User creates 'AssociationList19810Filter' dynamic list
	Then "AssociationList19810Filter" list is displayed to user
