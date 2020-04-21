Feature: CustomListDisplayPart5
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10647 @DAS13001 @DAS13838 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatDatabaseErrorOccurringWhenAttemptingToSaveListsInEvergreenAreNotDisplayed 
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and "Amber" Lookup option
	Then "2004: Readiness" filter is added to the list
	When User clicks on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestName QQRT" name on "Devices" page
	Then "TestName QQRT" list is displayed to user
	And "8" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11465 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckThatAnotherUserCanEditsAndSavesASharedListWithSelectedColumnsWithoutErrors
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Compliance |
	| Device Key |
	When User create dynamic list with "ATestListAA0888" name on "Devices" page
	Then "ATestListAA0888" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	Then 'Everyone can edit' content is displayed in 'Sharing' dropdown
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestListAA0888" list
	Then "ATestListAA0888" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Import     |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And "Import" subcategory is selected in Column panel
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	And User clicks the Columns button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with "1" account
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestListAA0888" list
	Then "ATestListAA0888" list is displayed to user
	And ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Device Key |
	| Import     |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And "Import" subcategory is selected in Column panel
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestListAA0888" list
	Then Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11465 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckThatAnotherUserCanEditsAndSavesASharedListWithSelectedFiltersWithoutErrors
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "ATestList0A788F" name on "Devices" page
	Then "ATestList0A788F" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	Then 'Everyone can edit' content is displayed in 'Sharing' dropdown
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestList0A788F" list
	Then "ATestList0A788F" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	And User clicks the Filters button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with "1" account
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestList0A788F" list
	Then "ATestList0A788F" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "(Compliance = Amber or Red) OR (City = London)" text is displayed in filter container
	And "Compliance is Red or Amber" is displayed in added filter info
	And "City is London" is displayed in added filter info
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestList0A788F" list
	Then Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11465 @DAS11951 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckThatAnotherUserCanEditsAndSavesASharedListWithSortingWithoutErrors
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "ATestList9A0AE8" name on "Devices" page
	Then "ATestList9A0AE8" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	Then 'Everyone can edit' content is displayed in 'Sharing' dropdown
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestList9A0AE8" list
	Then "ATestList9A0AE8" list is displayed to user
	When User clicks on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with "1" account
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestList9A0AE8" list
	Then "ATestList9A0AE8" list is displayed to user
	And data in table is sorted by 'Owner Display Name' column in ascending order
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ATestList9A0AE8" list
	Then Edit List menu is not displayed