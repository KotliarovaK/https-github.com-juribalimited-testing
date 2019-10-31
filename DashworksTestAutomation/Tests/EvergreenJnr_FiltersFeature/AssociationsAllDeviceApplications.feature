﻿Feature: AssociationsAllDeviceApplications
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18425 @DAS18458 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorAppearsAfterOpenningItemFromCreatedAllDeviceApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	Then Export button is displayed disabled
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks 'RUN LIST' button
	When User click content from "Application Name" column
	Then There are no errors in the browser console

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18425
Scenario: EvergreenJnr_ApplicationsList_CheckThatFirstAssociationsCantBeRemovedIfThereAreTwoMoreAdded
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects 'Not installed on device' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects 'Entitled to device' option in expanded associations list
	Then Remove icon displayed in 'false' state for 'Used on device' association
	Then Remove icon displayed in 'true' state for 'Not installed on device' association
	Then Remove icon displayed in 'true' state for 'Entitled to device' association

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18456 @DAS18530 @18562 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatGridIsNotDisappearedAfterSelectingFilterOnAllDeviceApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18530" name
	When User navigates to the "AssociationList18530" list
	When User clicks the Filters button
	Then table content is present
	When user select "App Vendor" filter
	When User select "Does not equal" Operator value
	When User enters "s" text in Search field at selected Filter
	Then User save change in current filter
	When User clicks 'RUN LIST' button
	When User move 'Hostname' column to 'App Vendor' column
	Then table content is present
	When User click Edit button for "App Vendor" filter
	Then table content is present
	#18530
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18530_1" name
	Then "AssociationList18530_1" list is displayed to user
	Then table content is present
	When User navigates to the "All Device Applications" list
	Then There are no errors in the browser console
	When User navigates to the "AssociationList18530_1" list
	Then There are no errors in the browser console
	When User navigates to the "All Device Applications" list
	Then There are no errors in the browser console

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18489 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatPivotCantBeRunIfAssociationWasRemoved
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks 'RUN LIST' button
	When User selects 'Pivot' in the 'Create' dropdown
	When User clicks the Pivot button
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| App Vendor |
	When User selects the following Columns on Pivot:
	| Columns  |
	| App Version |
	When User selects the following Values on Pivot:
	| Values  |
	| Hostname |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "Pivot18489" name
	Then "Pivot18489" list is displayed to user
	When User navigates to the "Pivot18489" list
	When User clicks the Associations button
	When User removes 'Used on device' association in Association panel
	Then 'RUN PIVOT' button is disabled
	Then 'RUN PIVOT' button has tooltip with 'Use association panel to create a list' text

@Evergreen @AllDeviceApplications @DAS18445 @Cleanup
Scenario: EvergreenJnr_AllDeviceApplications_CheckThatOnlyOneFilterDeletedAfterClickingRemoveIcon
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in expanded associations list
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

@Evergreen @AllDeviceApplications @DAS18531
Scenario: EvergreenJnr_AllDeviceApplications_CheckMessageAppearingAfterResetAssociations
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks the Filters button
	When User add "App Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| 0      |
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks the Associations button
	When User have reset all filters
	Then message 'No device applications found' is displayed to the user
	
#link with DAS-18763 after fail
@Evergreen @AllDeviceApplications @DAS18531 @Cleanup
Scenario: EvergreenJnr_AllDeviceApplications_CheckMessageAppearingAfterDeletedRelatedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User create dynamic list with "DevicesList18531" name on "Devices" page
	Then "DevicesList18531" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" without added column and "DevicesList18531" Lookup option
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18531" name
	Then "AssociationList18531" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User removes custom list with "DevicesList18531" name
	Then list with "DevicesList18531" name is removed
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User navigates to the "AssociationList18531" list
	When User clicks the Associations button
	Then message 'This list has errors' is displayed to the user