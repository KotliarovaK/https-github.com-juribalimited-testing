Feature: AssociationsAllDeviceApplications
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18425 @DAS18458 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorAppearsAfterOpenningItemFromCreatedAllDeviceApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	Then Associations panel is displayed to the user
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

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18456 @DAS18530 @DAS18562 @DAS18127 @Cleanup
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

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18489 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatPivotCantBeRunIfAssociationWasRemoved
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
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

@Evergreen @AllDeviceApplications @DAS18531 @DAS18763
Scenario: EvergreenJnr_AllDeviceApplications_CheckMessageAppearingAfterResetAssociations
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks the Filters button
	When User add "App Version" filter where type is "Equals" with added column and following value:
	| Values |
	| sss    |
	When User clicks the Associations button
	When User clicks 'RUN LIST' button
	When User have reset all filters
	Then message 'No list generated Use association panel to create a list' is displayed to the user

@Evergreen @AllDeviceApplications @DAS18531 @Cleanup
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
	When User selects 'Used on device' option in expanded associations list
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

@Evergreen @AllDeviceApplications @DAS18424
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

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18379 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAllDevicesApplicationsListCanBeDownloaded
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18379" name
	Then "AssociationList18379" list is displayed to user
	When User clicks Export button on the Admin page
	#TODO: need to develop step that checks file download and works on Bamboo remote machine
	#Then User checks that file "Dashworks-Device-Applications-AssociationList18379" was downloaded

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18426 @Cleanup
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects '<operator1>' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects '<operator2>' option in expanded associations list
	When User clicks Add And button on the Filter panel
	When User selects '<operator3>' option in expanded associations list
	When User clicks 'RUN LIST' button
	When User clicks content from "Hostname" column
	Then Details page for '<hostname>' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User enters "<application>" text in the Search field for "Application" column
	Then '<installed>' content is displayed in the 'Installed' column
	Then '<used>' content is displayed in the 'Used' column
	Then '<entitled>' content is displayed in the 'Entitled' column

Examples: 
	| operator1           | operator2               | operator3               | hostname        | application                   | installed | used    | entitled |
	| Used on device      | Not entitled to device  | Not installed on device | 00BDM1JUR8IF419 | 20040610sqlserverck           | UNKNOWN   | TRUE    | FALSE    |
	| Entitled to device  | Installed on device     | Not used on device      | 001BAQXT6JWFPI  | AddressGrabber Standard       | TRUE      | UNKNOWN | TRUE     |
	| Entitled to device  | Not installed on device | Not used on device      | 00BDM1JUR8IF419 | cdparanoia-libs               | UNKNOWN   | FALSE   | TRUE     |
	| Installed on device | Not entitled to device  | Not used on device      | 00KWQ4J3WKQM0G  | Adobe Reader 6.0.1 - Fran?ais | TRUE      | UNKNOWN | FALSE    |

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18804
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks the Filters button
	When User add "<filter>" filter where type is "Equals" with added column and following value:
	| Values |
	| -1     |
	When User clicks the Associations button
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console

Examples: 
	| filter                       |
	| Device Key                   |
	| Application Key              |
	| CPU Count                    |
	| CPU Count                    |
	| CPU Speed (GHz)              |
	| HDD Count                    |
	| HDD Total Size (GB)          |
	| Memory (GB)                  |
	| Monitor Count                |
	| Network Card Count           |
	| Sound Card Count             |
	| Target Drive Free Space (GB) |
	| Video Card Count             |

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18454 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAndRunninList
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in expanded associations list
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks on 'Hostname' column header
	When User clicks the Columns button
	When User removes "App Vendor" column by Column panel
	When User clicks 'RUN LIST' button
	Then table content is present

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18897 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningList
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in expanded associations list
	When User clicks 'RUN LIST' button
	Then table content is present
	Then All column headers are unique

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18447 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToAllDeviceApplicationsPageFromSavedList
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in expanded associations list
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "AssociationList18447" name
	Then table content is present
	When User navigates to the "All Device Applications" list
	Then table content is present
	Then Associations Button is highlighted
	Then Associations panel is displayed to the user

@Evergreen @AllDeviceApplications @DAS19059
Scenario: EvergreenJnr_AllDeviceApplications_CheckThatListHavingComplianceColumnCanBeSorted
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Installed on device' option in expanded associations list
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	When User clicks 'RUN LIST' button
	When User clicks on 'Compliance' column header
	Then color data is sorted by 'Compliance' column in ascending order
	When User clicks on 'Compliance' column header
	Then color data is sorted by 'Compliance' column in descending order

@Evergreen @AllDeviceApplications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18958 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListWithAppliedFilterDisplayedCorrectlyAfterRefreshing
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in expanded associations list
	When User clicks the Filters button
	When User add "Network Card Count" filter where type is "Greater than" with added column and following value:
	| Values |
	| 0      |
	When User clicks 'RUN LIST' button
	When User clicks Save button on the list panel
	When User selects Save as dynamic list option
	When User creates new custom list with "AssociationList18958" name
	Then "AssociationList18958" list is displayed to user
	Then table content is present
	When User clicks refresh button in the browser
	Then "AssociationList18958" list is displayed to user
	Then table content is present