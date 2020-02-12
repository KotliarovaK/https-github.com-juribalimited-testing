Feature: CustomListDisplayPart4
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10870 @DAS11951 @DAS12152 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatSortingWillBeWorkForExistingSavedStaticLists 
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	| 011PLA470S0B9DJ  |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Import     |
	When User clicks 'SAVE' button and select 'UPDATE STATIC LIST' menu button
	When User clicks on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	And Edit List menu is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10870 @DAS11951 @DAS12199 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatSortingWillBeWorkForExistingSavedDynamicLists
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User add "City" filter where type is "Equals" with added column and "Jersey City" Lookup option
	Then "City" filter is added to the list
	When User create dynamic list with "Dynamic List TestName qq2r" name on "Devices" page
	Then "Dynamic List TestName qq2r" list is displayed to user
	When User clicks on 'Compliance' column header
	Then color data is sorted by 'Compliance' column in ascending order
	And Edit List menu is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10914 @DAS12152 @DAS12199 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatEditListMenuNotDisplayedForActiveList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	| Amber              |
	Then "Compliance" filter is added to the list
	When User clicks on 'Compliance' column header
	Then data in table is sorted by 'Compliance' column in ascending order
	When User create dynamic list with "Dynamic List TestName" name on "Devices" page
	Then "Dynamic List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	| 011PLA470S0B9DJ  |
	| 019BFPQGKK5QT8N  |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Build Date      |
	| First Seen Date |
	Then ColumnName is added to the list
	| ColumnName      |
	| Build Date      |
	| First Seen Date |
	When User clicks on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User clicks 'SAVE' button and select 'UPDATE STATIC LIST' menu button
	Then "Static List TestName" list is displayed to user
	When User navigates to the "Dynamic List TestName" list
	Then "Dynamic List TestName" list is displayed to user
	And Edit List menu is not displayed
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	And Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11026 @DAS11951 @DAS12199 @DAS13001 @DAS13838 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatEditListMenuNotDisplayedForDifferentFilterTypes
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and "Empty" Lookup option
	Then "2004: Readiness" filter is added to the list
	When User create dynamic list with "Readiness List TestName" name on "Devices" page
	Then "Readiness List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Import Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Generic            |
	Then "Import Type" filter is added to the list
	When User create dynamic list with "MultiSelect List TestName" name on "Devices" page
	Then "MultiSelect List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	| Amber              |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "Compliance List TestName" name on "Devices" page
	Then "Compliance List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Secure Boot Enabled" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	Then "Secure Boot Enabled" filter is added to the list
	When User create dynamic list with "Secure Boot List TestName" name on "Devices" page
	Then "Secure Boot List TestName" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	Then data in table is sorted by 'Application' column in ascending order
	When User create dynamic list with "TestList569889" name on "Applications" page
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| TestList569889 | Not used on device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "Applications List TestName" name on "Devices" page
	Then "Applications List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "MultiSelect List TestName" list
	Then Edit List menu is not displayed
	When User navigates to the "Compliance List TestName" list
	Then Edit List menu is not displayed
	When User navigates to the "Secure Boot List TestName" list
	Then Edit List menu is not displayed
	When User navigates to the "Applications List TestName" list
	Then Edit List menu is not displayed