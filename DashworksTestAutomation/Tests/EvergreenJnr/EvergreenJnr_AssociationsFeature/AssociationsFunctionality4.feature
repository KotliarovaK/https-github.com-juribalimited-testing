Feature: AssociationsFunctionality4
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS19059
Scenario: EvergreenJnr_AllDeviceApplications_CheckThatListHavingComplianceColumnCanBeSorted
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Installed on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	When User clicks 'RUN LIST' button
	When User clicks on 'Compliance' column header
	Then color data is sorted by 'Compliance' column in ascending order
	When User clicks on 'Compliance' column header
	Then color data is sorted by 'Compliance' column in descending order

@Evergreen @Associations @DAS18958 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListWithAppliedFilterDisplayedCorrectlyAfterRefreshing
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
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

@Evergreen @Associations @DAS18969 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorDisplayedWhenUsingOperationBlockInFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Device Operating System" filter where type is "Does not equal" with added column and Lookup option
    | SelectedValues |
    | Other          |
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console
	Then table content is present

@Evergreen @Associations @DAS18889
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorWhenSomeNotEmptyFiltersApplied
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<filter>" filter where type is "Not empty" with added column and Lookup option
    | SelectedValues |
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console
	Then table content is present

Examples:
	| filter           |
	| Manufacturer     |
	| CPU Architecture |

@Evergreen @Associations @DAS18470 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckFiltersAndColumnsAvailabilityForAssociations
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	Then the following Filters subcategories are displayed for open category:
    | Subcategories    |
    | App Vendor       |
    | App Version      |
    | Application Name |
    | Device Type      |
    | Hostname         |
	When User closes "Suggested" filter category
	When User expands "Application" filter category
	Then the following Filters subcategories are presented for open category:
    | Subcategories            |
    | Application (Saved List) |
    | Application Key          |
    | Compliance               |
    | Dashworks First Seen     |
    | Device Count (Entitled)  |
    | Device Count (Installed) |
    | Device Count (Used)      |
    | Import                   |
    | Import Type              |
    | Inventory Site           |
    | User Count (Entitled)    |
    | User Count (Used)        |
	When User clicks the Columns button
	Then the following Column subcategories are displayed for open category:
	| Subcategories    |
	| Hostname         |
	| Device Type      |
	| Application Name |
	| App Vendor       |
	| App Version      |
	When User collapses 'Selected Columns' category
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Application Key          |
	| Compliance               |
	| Dashworks First Seen     |
	| Device Count (Entitled)  |
	| Device Count (Installed) |
	| Device Count (Used)      |
	| Import                   |
	| Import Type              |
	| Inventory Site           |
	| User Count (Entitled)    |
	| User Count (Used)        |
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console
	Then table content is present
	When User clicks Save button on the list panel
	When User selects Save as dynamic list option
	When User creates new custom list with "AssociationList18470" name
	Then "AssociationList18470" list is displayed to user