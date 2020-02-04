Feature: FiltersFunctionalityPart21
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOperatingSystemFilterWork
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Operating System" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| Other          | Entitled to device |
	Then "4" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17757
Scenario: EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectProperties
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "1803: Status" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Offboarded     |
	Then "4" rows are displayed in the agGrid
	Then Content in the '1803: Status' column is equal to
	| Content    |
	| Offboarded |
	| Offboarded |
	| Offboarded |
	| Offboarded |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18377 @DAS18621 @DAS18686
Scenario Outline: EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRelative
	When User clicks '<List>' on the left-hand menu
	And User clicks the Filters button
	And User add "<Filter>" filter where type is "Equals (relative)" with added column and following value:
	| Values  |
	| <Value> |
	Then There are no errors in the browser console

Examples:
	| List         | Filter                               | Value                                       |
	| Devices      | 1803: Pre-Migration \ Scheduled Date | 1                                           |
	| Applications | Owner Last Logon Date                | 1                                           |
	| Devices      | Owner Last Logon Date                | 2.37457468568568568568658464554575547547547 |

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS18140
Scenario: EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereApplied
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Display Name" filter where type is "Not Empty" with added column and Lookup option
	| SelectedValues |
	When User Add And "Display Name" filter where type is "Contains" with added column and following value:
	| Values |
	| a      |
	When User click Edit button for "Display Name" filter
	When User clicks 'CANCEL' button 
	Then There are no any expanded blocks in Filter panel

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18709
Scenario: EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWork
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Owner Compliance" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	Then "16,819" rows are displayed in the agGrid
	When User have removed "Owner Compliance" filter
	And User add "Owner Compliance" filter where type is "Not empty" with added column and Lookup option
	| SelectedValues |
	Then "16,819" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @DAS18560 @Cleanup
Scenario: EvergreenJnr_CheckThatNoErrorMessageDisplayedAfterOpeningListWithFilterRelatedToDeletedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User create dynamic list with "ListToBeDeleted18560" name on "Devices" page
	Then "ListToBeDeleted18560" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" with following Lookup Value and Association:
    | SelectedValues       | Association    |
    | ListToBeDeleted18560 | Used on device |
	When User creates 'SecondList18560' dynamic list
	Then "SecondList18560" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User removes custom list with "ListToBeDeleted18560" name
	Then list with "ListToBeDeleted18560" name is removed
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "SecondList18560" list
	When User clicks the Filters button
	Then message 'This list could not be processed, it may refer to a list with errors' is displayed to the user