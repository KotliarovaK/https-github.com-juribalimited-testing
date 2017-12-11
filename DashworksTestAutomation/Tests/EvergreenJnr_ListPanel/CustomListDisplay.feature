Feature: CustomListDisplay
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11003
Scenario: EvergreenJnr_DevicesList_Check that custom list creation block is not displayed when deleting a filter in default list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User have removed "Windows7Mi: Category" filter
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11003
Scenario: EvergreenJnr_DevicesList_Check that custom list creation block is not displayed when reseting a filter in default list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11017 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that custom list creation block is not displayed when deleting a filter in custom list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Directory Type" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User have removed "Windows7Mi: Category" filter
	Then Edit List menu is displayed
	When User have removed "Directory Type" filter
	Then Edit List menu is displayed
	When User update current custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11017 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that custom list creation block is not displayed when reseting a filter in custom list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Directory Type" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User have reset all filters
	Then Edit List menu is displayed
	When User update current custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10998
Scenario: EvergreenJnr_DevicesList_agGrid_Check that Search does not trigger new Custom List
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Henry          | 34           |
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10704
Scenario: EvergreenJnr_DevicesList_agGrid_Check that quick search doesn't triggers new list menu
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11081 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_agGrid_Check that 'new list created' message for static list is displayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "TestList" name
	Then "TestList" list is displayed to user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in descending order
	Then User save changes in list with "UnbelievableTestList" name
	Then "UnbelievableTestList" list is displayed to user
	And "New list created" message is displayed

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11005 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_Check that lists is displayed in alphabetical order
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create custom list with "L TestList Custom Filter" name
	Then "L TestList Custom Filter" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Another task" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Started            |
	Then "Babel(Engl: Another task" filter is added to the list
	When User create custom list with "A TestList Custom Filter" name
	Then "A TestList Custom Filter" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AAD1011948       |
	| AAH0343264       |
	And User create static list with "KY TestList Static List" name
	Then "KY TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AAQ9911340       |
	And User create static list with "QWER TestList Static List" name
	Then "QWER TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Enabled" filter is added to the list
	When User create custom list with "X TestList Custom List" name
	Then "X TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	Then lists are sorted in alphabetical order

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11018
Scenario: EvergreenJnr_UsersList_Check that custom list creation block is not displayed when user opens actions panel
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User clicks the Actions button
	Then Save to New Custom List element is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11394 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check the sort order is saved for existing list and not deleted after clicking "Reset" button in "Columns" menu
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User create custom list with "Custom List TestName" name
	Then "Custom List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 01BQIYGGUW5PRP6  |
	| 020JQ9RO0J4H07X  |
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User update current custom list
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "Custom List TestName" list
	Then "Custom List TestName" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User have reset all columns
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User have reset all columns
	Then data in table is sorted by 'Owner Display Name' column in ascending order

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-11011 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that newly saved list is created with the correct columns and sorts and the same rows of data
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 011PLA470S0B9DJ  |
	| 020JQ9RO0J4H07X  |
	And User create static list with "Static List TestName" name
	Then "Static List TestName" list is displayed to user
	Then "3" rows are displayed in the agGrid
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in descending order
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	And Edit List menu is not displayed
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 020JQ9RO0J4H07X  |
	Then User is removed selected rows
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	And "2" rows are displayed in the agGrid
	And data in table is sorted by 'Owner Display Name' column in descending order
	And ColumnName is added to the list
	| ColumnName |
	| Compliance |

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10870 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList__Check that sorting will be work for existing saved static lists 
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 011PLA470S0B9DJ  |
	| 020JQ9RO0J4H07X  |
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
	Then User save changes in list with "Static List TestName 1" name
	Then "Static List TestName 1" list is displayed to user
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in descending order
	And Edit List menu is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10870 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList__Check that sorting will be work for existing saved dynamic lists
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User add "City" filter where type is "Equals" with added column and "Jersey City" Lookup option
	Then "City" filter is added to the list
	When User create custom list with "Dynamic List TestName" name
	Then "Dynamic List TestName" list is displayed to user
	When User click on 'Compliance' column header
	Then data in table is sorted by 'Compliance' column in descending order
	And Edit List menu is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS-10870 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList__Check that edit list menu not displayed for active list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	| Amber              |
	Then "Compliance" filter is added to the list
	When User click on 'Compliance' column header
	Then data in table is sorted by 'Compliance' column in descending order
	When User create custom list with "Dynamic List TestName" name
	Then "Dynamic List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 011PLA470S0B9DJ  |
	| 020JQ9RO0J4H07X  |
	| 03063X2ZUCDN0A1  |
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
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in descending order
	When User update current custom list
	Then "Static List TestName" list is displayed to user
	When User navigates to the "Dynamic List TestName" list
	Then "Dynamic List TestName" list is displayed to user
	And Edit List menu is not displayed
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	And Edit List menu is not displayed