Feature: CustomListDisplayPart5
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10647 @DAS13001 @DAS13838 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatDatabaseErrorOccurringOccurringWhenAttemptingToSaveListsInEvergreenAreNotDisplayed 
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Readiness" filter where type is "Equals" with added column and "Amber" Lookup option
	Then "Babel(Engl: Readiness" filter is added to the list
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestName QQRT" name on "Devices" page
	Then "TestName QQRT" list is displayed to user
	And "2" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11465 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesLists_CheckThatAnotherUserCanEditsAndSavesASharedListWithSelectedColumnsWithoutErrors
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Compliance |
	| Device Key |
	When User create dynamic list with "TestListAA0888" name on "Devices" page
	Then "TestListAA0888" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	Then "Everyone can edit" sharing option is selected
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestListAA0888" list
	Then "TestListAA0888" list is displayed to user
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
	When User update current custom list
	And User clicks the Columns button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with "1" account
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestListAA0888" list
	Then "TestListAA0888" list is displayed to user
	And ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Device Key |
	| Import     |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And "Import" subcategory is selected in Column panel
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestListAA0888" list
	Then Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11465 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesLists_CheckThatAnotherUserCanEditsAndSavesASharedListWithSelectedFiltersWithoutErrors
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList0A788F" name on "Devices" page
	Then "TestList0A788F" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	Then "Everyone can edit" sharing option is selected
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList0A788F" list
	Then "TestList0A788F" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User update current custom list
	And User clicks the Filters button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with "1" account
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList0A788F" list
	Then "TestList0A788F" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "(Compliance = Red or Amber) OR (City = London)" text is displayed in filter container
	And "Compliance is Red or Amber" is displayed in added filter info
	And "City is London" is displayed in added filter info
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList0A788F" list
	Then Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11465 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesLists_CheckThatAnotherUserCanEditsAndSavesASharedListWithSortingWithoutErrors
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList9A0AE8" name on "Devices" page
	Then "TestList9A0AE8" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	Then "Everyone can edit" sharing option is selected
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList9A0AE8" list
	Then "TestList9A0AE8" list is displayed to user
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User update current custom list
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with "1" account
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList9A0AE8" list
	Then "TestList9A0AE8" list is displayed to user
	And data in table is sorted by 'Owner Display Name' column in ascending order
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList9A0AE8" list
	Then Edit List menu is not displayed