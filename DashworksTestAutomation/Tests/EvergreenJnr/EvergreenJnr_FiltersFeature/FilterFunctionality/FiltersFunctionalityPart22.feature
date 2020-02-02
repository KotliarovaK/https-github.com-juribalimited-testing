Feature: FiltersFunctionalityPart22
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @DAS18100 @Cleanup
Scenario: EvergreenJnr_CheckThatNotEmptyOperatorWasAddedToMultipleFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Import Type" filter where type is "Not empty" with added column and Lookup option
    | SelectedValues |
	Then "17,279" rows are displayed in the agGrid
	Then URL contains 'filter=(distributionType%20IS%20NOT%20EMPTY%20())&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,distributionType'
	When User have removed "Import Type" filter
	When User add "Import Type" filter where type is "Does not equal" with added column and Lookup option
    | SelectedValues |
    | Empty          |
	Then "17,279" rows are displayed in the agGrid
	When User creates 'NewFilter_18100_1' dynamic list
	Then "NewFilter_18100_1" list is displayed to user
	Then There are no errors in the browser console

@Evergreen @Devices @Evergreen_FiltersFeature @DAS18100 @Cleanup
Scenario: EvergreenJnr_CheckThatNotEmptyOperatorWasAddedToMultipleFiltersIfFilterWasCreatedViaAddressRow
	When User navigates to 'devices?$filter=(distributionType%20IS%20NOT%20EMPTY%20())&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,distributionType' url via address line
	Then "17,279" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Import Type is not empty" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @DAS18560 @Cleanup
Scenario: EvergreenJnr_CheckThatFilterBasedOnListHavingNotEmptyOperatorCanBeCreated
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Import Type" filter where type is "Not empty" with added column and Lookup option
    | SelectedValues |
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18100_4" name on "Devices" page
	Then "ListForDAS18100_4" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" with following Lookup Value and Association:
    | SelectedValues    | Association    |
    | ListForDAS18100_4 | Used on device |
	When User creates 'SecondList18100' dynamic list
	Then "SecondList18100" list is displayed to user
	Then There are no errors in the browser console

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS18616
Scenario Outline: EvergreenJnr_DevicesList_CheckThatCpuVirtualisationCapableFilterReturnValidResults
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "CPU Virtualisation Capable" filter where type is "Equals" with added column and following checkboxes:
    | SelectedCheckboxes |
    | <Operator>         |
	When User clicks on 'CPU Virtualisation Capable' column header
	Then '<Value>' content is displayed in the 'CPU Virtualisation Capable' column
	When User clicks on 'CPU Virtualisation Capable' column header
	Then '<Value>' content is displayed in the 'CPU Virtualisation Capable' column

Examples:
	| Operator | Value   |
	| Empty    | UNKNOWN |
	| FALSE    | FALSE   |
	| TRUE     | TRUE    |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS18922
Scenario: EvergreenJnr_DevicesList_CheckThatGridDataDisplayedAfterSortingByOwnerCompliance
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Compliance" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Empty          |
	When User clicks on 'Owner Compliance' column header
	Then table content is present

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18387
Scenario Outline: EvergreenJnr_DevicesList_CheckThatZeroCanBeSelectedInRelativeFilter
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When user select "<Filter>" filter
	When User select "<Operator>" Operator value
	When User enters '0' text to 'Value' textbox
	Then User sees instruction 'Enter a value between 0 and 100,000' below 'Value' field
	Then Ahead or Ago dropdown is disabled

Examples:
	| List         | Filter                       | Operator                |
	| Devices      | Boot Up Date                 | Equals (relative)       |
	| Applications | Device Owner Last Logon Date | Before (relative)       |
	| Users        | Last Logon Date              | After (relative)        |
	| Mailboxes    | Created Date                 | On or before (relative) |