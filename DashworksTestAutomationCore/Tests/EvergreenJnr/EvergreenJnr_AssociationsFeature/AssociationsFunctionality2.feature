Feature: AssociationsFunctionality2
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS18445 @Cleanup
Scenario: EvergreenJnr_AllDeviceApplications_CheckThatOnlyOneFilterDeletedAfterClickingRemoveIcon
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User creates 'AssociationList18445' dynamic list
	Then "AssociationList18445" list is displayed to user
	When User navigates to the "AssociationList18445" list
	When User clicks the Associations button
	When User removes 'Used on device' association in Association panel
	Then Remove icon displayed in 'true' state for 'Entitled to device' association

@Evergreen @Associations @DAS18531 @DAS18763
Scenario: EvergreenJnr_AllDeviceApplications_CheckMessageAppearingAfterResetAssociations
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "App Version" filter where type is "Equals" with added column and following value:
	| Values |
	| sss    |
	When User clicks the Associations button
	When User clicks 'RUN LIST' button
	When User have reset all filters
	Then message 'No list generated Use association panel to create a list' is displayed to the user

@Evergreen @Associations @DAS18531 @Cleanup
Scenario: EvergreenJnr_AllDeviceApplications_CheckMessageAppearingAfterDeletedRelatedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User create dynamic list with "ADevicesList18531" name on "Devices" page
	Then "ADevicesList18531" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" without added column and "ADevicesList18531" Lookup option
	When User clicks 'RUN LIST' button
	When User creates 'AssociationList18531' dynamic list
	Then "AssociationList18531" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Delete' option in cogmenu for 'ADevicesList18531' list
	When User confirms list removing
	Then list with "ADevicesList18531" name is removed
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	Then message 'No list generated Use association panel to create a list' is displayed to the user

@Evergreen @Associations @DAS18424
Scenario Outline: EvergreenJnr_AllDeviceApplications_CheckThatAddAndButtonIsNotDisplayedIfAllPossibleAssociationsAreAdded
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator1>' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator2>' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator3>' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator4>' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator5>' option in 'Search associations' autocomplete of Associations panel
	#sz: should be updated after implementation DAS-19580
	#Then Add And button is not displayed on the Filter panel

Examples: 
	| operator1          | operator2              | operator3               | operator4                | operator5            |
	| Used on device     | Entitled to device     | Installed on device     | Entitled to device owner | Used by device owner |
	| Used on device     | Not entitled to device | Not installed on device | Entitled to device owner | Used by device owner |
	| Entitled to device | Not used on device     | Installed on device     | Entitled to device owner | Used by device owner |

@Evergreen @Associations @DAS18379 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAllDevicesApplicationsListCanBeDownloaded
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	When User creates 'AssociationList18379' dynamic list
	Then "AssociationList18379" list is displayed to user
	When User clicks Export button on the Admin page
	#TODO: need to develop step that checks file download and works on Bamboo remote machine
	#Then User checks that file "Dashworks-Device-Applications-AssociationList18379" was downloaded