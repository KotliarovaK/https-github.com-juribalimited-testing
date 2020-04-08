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

@Evergreen @Associations @DAS20130 @DAS20450
Scenario: EvergreenJnr_ApplicationsList_CheckThatParticularAssociationWork
	When User navigates to 'userapplications?$association=(project_49_target%20AND%20nubu)' url via address line
	When User clicks 'RUN LIST' button
	Then table content is present
	Then URL contains 'userapplications?$association=(project_49_target%20AND%20nubu)'

@Evergreen @Associations @DAS20130 @DAS20450
Scenario: EvergreenJnr_ApplicationsList_CheckThatParticularFilterWorkWithAssociations
	When User clicks 'Applications' on the left-hand menu
	When User navigates to 'deviceapplications?$filter=(chassisCategory%20EQUALS%20('Desktop'%2C'Laptop'))&$association=(project_1_current%20AND%20nuod%20AND%20netd%20AND%20iod%20AND%20netdo%20AND%20nubdo)' url via address line
	When User clicks 'RUN LIST' button
	Then table content is present
	Then URL contains 'deviceapplications?$filter=(chassisCategory%20EQUALS%20('Desktop'%2C'Laptop'))&$association=(project_1_current%20AND%20nuod%20AND%20netd%20AND%20iod%20AND%20netdo%20AND%20nubdo)'

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS18234 @Remove_Profile_Changes
Scenario: EvergreenJnr_ApplicationsList_CheckAssociationsRunListButtonDisplaying
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Preferences' left menu item
	When User selects 'High Contrast' in the 'Display Mode' dropdown
	When User clicks 'UPDATE' button
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	Then 'RUN LIST' button is disabled
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	Then 'RUN LIST' button is not disabled
	Then 'RUN LIST' button is displayed in high contrast
	When User language is changed to "Test Language" via API
	When User clicks refresh button in the browser
	Then '[9999999]' button is displayed

@Evergreen @Associations @DAS19810 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListCanBeCreatedWithColumnApplicationCustomField
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All User Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project or Evergreen' autocomplete
	When User selects 'Current' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| App Phoenix Field |
	When User clicks 'RUN LIST' button
	Then table content is present
	When User creates 'AssociationList19810Column' dynamic list
	Then "AssociationList19810Column" list is displayed to user

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