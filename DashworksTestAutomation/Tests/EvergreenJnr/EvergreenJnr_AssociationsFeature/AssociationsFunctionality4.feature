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
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
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
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "Network Card Count" filter where type is "Greater than" with added column and following value:
	| Values |
	| 0      |
	When User clicks 'RUN LIST' button
	When User creates 'AssociationList18958' dynamic list
	Then "AssociationList18958" list is displayed to user
	Then table content is present
	When User clicks refresh button in the browser
	Then "AssociationList18958" list is displayed to user
	Then table content is present

@Evergreen @Associations @DAS18969 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorDisplayedWhenUsingOperationBlockInFilter
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
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
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
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
	When User navigates to 'deviceapplications?$filter=(packageManufacturer%20IS%20NOT%20EMPTY%20()%20AND%20packageVersion%20IS%20EMPTY%20()%20AND%20packageName%20CONTAINS%20('0')%20AND%20applicationListId%20IN%20('36')%20AND%20packageKey%20>%202%20AND%20migrationRAG%20EQUALS%20('Unknown'%2C'Green')%20AND%20dashworksFirstSeenDate%20IS%20EMPTY%20()%20AND%20computerEntitlements%20>%3D%200%20AND%20installed%20>%3D%200%20AND%20computerUsage%20<>%205%20AND%20distributionHierarchy%20IS%20NOT%20EMPTY%20()%20AND%20distributionType%20NOT%20EQUALS%20('Altiris%206')%20AND%20packageSite%20IS%20NOT%20EMPTY%20()%20AND%20userEntitlements%20<>%2045%20AND%20userUsage%20<>%203)&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,packageKey,packageSite,distributionType,distributionHierarchy,computerUsage,installed,computerEntitlements,dashworksFirstSeenDate,migrationRAG,userEntitlements,userUsage' url via address line
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console
	Then table content is present
	When User creates 'AssociationList18470' dynamic list
	Then "AssociationList18470" list is displayed to user