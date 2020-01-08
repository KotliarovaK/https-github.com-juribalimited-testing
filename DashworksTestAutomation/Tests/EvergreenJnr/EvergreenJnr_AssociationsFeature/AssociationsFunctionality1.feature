Feature: AssociationsFunctionality1
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18425 @DAS18458 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorAppearsAfterOpenningItemFromCreatedAllDeviceApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	Then Associations panel is displayed to the user
	Then Export button is displayed disabled
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	When User click content from "Application Name" column
	Then There are no errors in the browser console

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18425
Scenario: EvergreenJnr_ApplicationsList_CheckThatFirstAssociationsCantBeRemovedIfThereAreTwoMoreAdded
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Not installed on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	Then Remove icon displayed in 'false' state for 'Used on device' association
	Then Remove icon displayed in 'true' state for 'Not installed on device' association
	Then Remove icon displayed in 'true' state for 'Entitled to device' association

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18456 @DAS18530 @DAS18562 @DAS18127 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatGridIsNotDisappearedAfterSelectingFilterOnAllDeviceApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
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
	When User clicks Save filter button
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
	#==>18127
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then 'List Type: Dynamic' label is displayed in List Details
	Then 'Data: Device Applications' label is displayed in List Details
	#==<
	When User navigates to the "All Device Applications" list
	Then There are no errors in the browser console
	When User navigates to the "AssociationList18530_1" list
	Then There are no errors in the browser console
	When User navigates to the "All Device Applications" list
	Then There are no errors in the browser console

@Evergreen @AllDeviceApplications @AssociationsFunctionality @DAS18489 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatPivotCantBeRunIfAssociationWasRemoved
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	When User selects 'Pivot' in the 'Create' dropdown
	Then No pivot generated message is displayed
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