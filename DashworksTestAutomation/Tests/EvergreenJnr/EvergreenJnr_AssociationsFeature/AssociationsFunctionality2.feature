Feature: AssociationsFunctionality2
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18445 @Cleanup
Scenario: EvergreenJnr_AllDeviceApplications_CheckThatOnlyOneFilterDeletedAfterClickingRemoveIcon
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18445" name
	Then "AssociationList18445" list is displayed to user
	When User navigates to the "AssociationList18445" list
	When User clicks the Associations button
	When User removes 'Used on device' association in Association panel
	Then Remove icon displayed in 'true' state for 'Entitled to device' association

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18531 @DAS18763
Scenario: EvergreenJnr_AllDeviceApplications_CheckMessageAppearingAfterResetAssociations
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "App Version" filter where type is "Equals" with added column and following value:
	| Values |
	| sss    |
	When User clicks the Associations button
	When User clicks 'RUN LIST' button
	When User have reset all filters
	Then message 'No list generated Use association panel to create a list' is displayed to the user

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18531 @Cleanup
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
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" without added column and "ADevicesList18531" Lookup option
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18531" name
	Then "AssociationList18531" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User removes custom list with "ADevicesList18531" name
	Then list with "ADevicesList18531" name is removed
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	Then message 'No list generated Use association panel to create a list' is displayed to the user

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18424
Scenario Outline: EvergreenJnr_AllDeviceApplications_CheckThatAddAndButtonIsNotDisplayedIfAllPossibleAssociationsAreAdde
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects '<operator1>' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects '<operator2>' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects '<operator3>' option in expanded associations list
	Then Add And button is not displayed on the Filter panel

Examples: 
	| operator1          | operator2              | operator3               |
	| Used on device     | Entitled to device     | Installed on device     |
	| Used on device     | Not entitled to device | Not installed on device |
	| Entitled to device | Not used on device     | Installed on device     |

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18379 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAllDevicesApplicationsListCanBeDownloaded
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18379" name
	Then "AssociationList18379" list is displayed to user
	When User clicks Export button on the Admin page
	#TODO: need to develop step that checks file download and works on Bamboo remote machine
	#Then User checks that file "Dashworks-Device-Applications-AssociationList18379" was downloaded