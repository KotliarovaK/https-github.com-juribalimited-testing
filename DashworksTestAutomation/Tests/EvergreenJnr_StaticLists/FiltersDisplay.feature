﻿@retry:1
Feature: FiltersDisplay
	Runs Static Filters Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_StaticLists @FiltersDisplay @DAS10993 @DAS12152 @DAS12351 @DAS13389 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatDynamicFiltersAreClearedForStaticListsWhenOpenedAfterDynamicLists
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create dynamic list with "TestListE5FC4A" name on "Devices" page
	Then "TestListE5FC4A" list is displayed to user
	And "17,194" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User create static list with "Static List TestName14" name on "Devices" page with following items
	| ItemName       |
	| 0281Z79JGPVPH4 |
	| 00HA7MKAVVFDAV |
	Then "Static List TestName14" list is displayed to user
	And "2" rows are displayed in the agGrid
	When User navigates to the "TestListE5FC4A" list
	Then "17,194" rows are displayed in the agGrid
	When User navigates to the "Static List TestName14" list
	Then "2" rows are displayed in the agGrid
	And Filters Button is disabled
	And Filter button on AGgrid is disabled

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10978 @DAS12034 @DAS12221 @DAS12232 @DAS12351 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatFiltersAndColumnsAreRestoredForSavedList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Portal Self Service \ SS Application List Completed" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| No                 |
	Then "Windows7Mi: Portal Self Service \ SS Application List Completed" filter is added to the list
	When User create dynamic list with "TestList886350" name on "Devices" page
	Then "TestList886350" list is displayed to user
	And "5,179" rows are displayed in the agGrid
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList886350" list
	Then "TestList886350" list is displayed to user
	And "5,179" rows are displayed in the agGrid
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Windows7Mi: Portal Self Service \ SS Application List Completed is Not Applicable or No" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_StaticLists @FiltersDisplay @DAS10695 @DAS12152 @DAS12966 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenAddingExistingObjectToStaticList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	| 011PLA470S0B9DJ  |
	| 019BFPQGKK5QT8N  |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TopFour TestName" name
	Then "TopFour TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then "Devices" list should be displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TopTwo TestName" name
	Then "TopTwo TestName" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	Then User add selected rows in "TopFour TestName" list
	Then "TopFour TestName" list is displayed to user
	And "4" rows are displayed in the agGrid