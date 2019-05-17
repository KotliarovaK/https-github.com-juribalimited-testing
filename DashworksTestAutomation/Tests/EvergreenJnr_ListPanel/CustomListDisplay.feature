﻿Feature: CustomListDisplay
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11003 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInDefaultList
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

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11003 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInDefaultList
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

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11017 @DAS12351 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenDeletingAFilterInCustomList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create dynamic list with "TestListF20A85" name on "Devices" page
	Then "TestListF20A85" list is displayed to user
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

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11017 @DAS12351 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatCustomListCreationBlockIsNotDisplayedWhenResetingAFilterInCustomList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create dynamic list with "TestListE63B7D" name on "Devices" page
	Then "TestListE63B7D" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Directory Type" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User have reset all filters
	Then Edit List menu is displayed

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10998 @DAS10972
Scenario Outline: EvergreenJnr_AllList_CheckThatSearchDoesNotTriggerNewCustomList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| <Search>       | <Rows>       |
	Then Save to New Custom List element is NOT displayed
	And "<ListName>" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | <NewRows>    |
	Then Save to New Custom List element is NOT displayed
	And "<ListName>" list should be displayed to the user
	And Clearing the agGrid Search Box
	And Save to New Custom List element is NOT displayed
	And "<ListName>" list should be displayed to the user

	Examples:
	| ListName     | Search | Rows | NewRows |
	| Devices      | Henry  | 34   | 17      |
	| Users        | Henry  | 67   | 142     |
	| Applications | Hen    | 5    | 1       |
	| Mailboxes    | Henry  | 22   | 73      |

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11081 @DAS11951 @DAS12152 @DAS12602 @DAS15032 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatNewListCreatedMessageForStaticListIsDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TestList4A22A5" name
	Then "TestList4A22A5" list is displayed to user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	And User save changes in list with "UnbelievableTestList" name
	And "UnbelievableTestList" list is displayed to user

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11005 @DAS11489 @DAS12152 @DAS12194 @DAS12199 @DAS12220 @DAS12351 @DAS12602 @DAS12966 @DAS13838 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatListsIsDisplayedInAlphabeticalOrder
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "L TestList Custom List" name on "Users" page
	Then "L TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Another task" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Started            |
	Then "Babel(Engl: Another task" filter is added to the list
	When User create dynamic list with "A TestList Custom List" name on "Users" page
	Then "A TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 000F977AC8824FE39B8 |
	| 002B5DC7D4D34D5C895 |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "KY TestList Static List" name
	Then "KY TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "NINJA TestList Static List" name
	Then "NINJA TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName     |
	| $231000-3AC04R8AR431 |
	And User selects "Create static list" in the Actions dropdown
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
	When User create dynamic list with "X TestList Custom List" name on "Users" page
	Then "X TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then "Users" list should be displayed to the user
	Then lists are sorted in alphabetical order

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11018 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatCustomListCreationBlockIsNotDisplayedWhenUserOpensActionsPanel
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

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11018 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatCustomListCreationBlockIsNotDisplayedAfterStartTypingAListName
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	Then Save to New Custom List element is displayed
	When User clicks Save button on the list panel
	Then User type "Test" into Custom list name field
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User clicks the Actions button
	Then Save to New Custom List element is displayed

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11018 @DAS16242 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatSaveButtonIsInactiveInCustomListCreationBlock
	When User add following columns using URL to the "Users" page:
	| ColumnName          |
	| Compliance          |
	Then Save to New Custom List element is displayed	
	When User clicks Save button on the list panel
	Then User type "Test" into Custom list name field
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 000F977AC8824FE39B8 |
	| 003F5D8E1A844B1FAA5 |
	| 002B5DC7D4D34D5C895 |
	| 003F5D8E1A844B1FAA5 |
	And User selects "Create static list" in the Actions dropdown
	Then User type "Test" into Static list name field
	When User clicks the Actions button
	And User clicks Save button on the list panel
	And User selects Save as new list option
	Then Save button is inactive for Custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11394 @DAS11951 @DAS12152 @DAS12595 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckTheSortOrderIsSavedForExistingListAndNotDeletedAfterClickingResetButtonInColumnsMenu
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User create dynamic list with "Custom List TestName" name on "Devices" page
	Then "Custom List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	And User selects "Create static list" in the Actions dropdown
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

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11011 @DAS12152 @DAS12595 @DAS14783 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatNewlySavedListIsCreatedWithTheCorrectColumnsAndSortsAndTheSameRowsOfData
	When User create static list with "Static List TestName" name on "Devices" page with following items
	| ItemName       |
	| 00HA7MKAVVFDAV |
	| 001PSUMZYOW581 |
	| 00I0COBFWHOF27 |
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
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	And Edit List menu is not displayed
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	Then User removes selected rows
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	Then "2" rows are displayed in the agGrid
	And data in table is sorted by 'Owner Display Name' column in ascending order
	And ColumnName is added to the list
	| ColumnName |
	| Compliance |

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10870 @DAS11951 @DAS12152 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatSortingWillBeWorkForExistingSavedStaticLists 
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00K4CEEQ737BA4L  |
	| 011PLA470S0B9DJ  |
	And User selects "Create static list" in the Actions dropdown
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
	When User update current custom list
	When User click on 'Owner Display Name' column header
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	And Edit List menu is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10870 @DAS11951 @DAS12199 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatSortingWillBeWorkForExistingSavedDynamicLists
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
	When User create dynamic list with "Dynamic List TestName qq2r" name on "Devices" page
	Then "Dynamic List TestName qq2r" list is displayed to user
	When User click on 'Compliance' column header
	Then color data is sorted by 'Compliance' column in ascending order
	And Edit List menu is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10914 @DAS12152 @DAS12199 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatEditListMenuNotDisplayedForActiveList
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
	Then data in table is sorted by 'Compliance' column in ascending order
	When User create dynamic list with "Dynamic List TestName" name on "Devices" page
	Then "Dynamic List TestName" list is displayed to user
	When User navigates to the "All Devices" list
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
	Then data in table is sorted by 'Owner Display Name' column in ascending order
	When User update current custom list
	Then "Static List TestName" list is displayed to user
	When User navigates to the "Dynamic List TestName" list
	Then "Dynamic List TestName" list is displayed to user
	And Edit List menu is not displayed
	When User navigates to the "Static List TestName" list
	Then "Static List TestName" list is displayed to user
	And Edit List menu is not displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11026 @DAS11951 @DAS12199 @DAS13001 @DAS13838 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatEditListMenuNotDisplayedForDifferentFilterTypes
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Readiness" filter where type is "Equals" with added column and "None" Lookup option
	Then "Babel(Engl: Readiness" filter is added to the list
	When User create dynamic list with "Readiness List TestName" name on "Devices" page
	Then "Readiness List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Import Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Generic            |
	Then "Import Type" filter is added to the list
	When User create dynamic list with "MultiSelect List TestName" name on "Devices" page
	Then "MultiSelect List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
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
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Secure Boot Enabled" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	Then "Secure Boot Enabled" filter is added to the list
	When User create dynamic list with "Secure Boot List TestName" name on "Devices" page
	Then "Secure Boot List TestName" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	Then data in table is sorted by 'Application' column in ascending order
	When User create dynamic list with "TestList569889" name on "Applications" page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| TestList569889 | Not used on device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "Applications List TestName" name on "Devices" page
	Then "Applications List TestName" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "MultiSelect List TestName" list
	Then Edit List menu is not displayed
	When User navigates to the "Compliance List TestName" list
	Then Edit List menu is not displayed
	When User navigates to the "Secure Boot List TestName" list
	Then Edit List menu is not displayed
	When User navigates to the "Applications List TestName" list
	Then Edit List menu is not displayed

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
	And "(Compliance = Red or Amber) OR (City = London)" text is displayed in filter container
	When User clicks the Filters button
	Then Filters panel is displayed to the user
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

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10988 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesLists_CheckThatUserIsNotAbleToCreateListsWithSameName
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList993785" name on "Devices" page
	Then "TestList993785" list is displayed to user
	When User navigates to the "All Devices" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User clicks Save button on the list panel
	Then User type "TestList993785" into Custom list name field
	Then Save button is inactive for Custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11655 @DAS11666 @DAS12156 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_DevicesLists_CheckThatTheSavedListWithOwnerDisplayNameFilterIsDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Display Name" filter where type is "<OperatorValues>" with added column and following value:
	| Values |
	|        |
	Then "Owner Display Name" filter is added to the list
	When User create dynamic list with "TestList274E0A" name on "Devices" page
	Then "TestList274E0A" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList274E0A" list
	Then "TestList274E0A" list is displayed to user 
	And Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	And URL contains "<URL>"

Examples:
	| OperatorValues | URL                          |
	| Empty          | evergreen/#/devices?$listid= |
	| Not empty      | evergreen/#/devices?$listid= |

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11015 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesLists_CheckThatUserIsNotAbleToCreateListsWithLongNames
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "1234567890123456789012345678901234567890" name on "Devices" page
	Then "1234567890123456789012345678901234567890" list is displayed to user
	When User duplicates list with "1234567890123456789012345678901234567890" name
	Then "123456789012345678901234567890123456782" list is displayed to user
	When User removes custom list with "123456789012345678901234567890123456782" name
	Then list with "123456789012345678901234567890123456782" name is removed
	When User removes custom list with "1234567890123456789012345678901234567890" name
	Then list with "1234567890123456789012345678901234567890" name is removed
	When User clicks the Actions button
	And User select all rows
	And User selects "Create static list" in the Actions dropdown
	When User create static list with "1234567890123456789012345678901234567890111" name
	Then list name automatically changed to "1234567890123456789012345678901234567890" name
	And "1234567890123456789012345678901234567890" list is displayed to user

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS11342
Scenario Outline: EvergreenJnr_AllLists_CheckThatAllListsNamesAreDisplayedCorrectly
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	Then "<AllListName>" list name is displayed correctly

Examples:
	| ListName     | AllListName      |
	| Devices      | All Devices      |
	| Applications | All Applications |
	| Users        | All Users        |
	| Mailboxes    | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsTriggeredOrHiddenAfterAddingOrRemovingColumns
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User adds columns to the list
	| ColumnName   |
	| <ColumnName> |
	Then Save to New Custom List element is displayed
	When User removes "<ColumnName>" column by Column panel
	Then Save to New Custom List element is NOT displayed
	When User adds columns to the list
	| ColumnName   |
	| <ColumnName> |
	Then Save to New Custom List element is displayed
	When User adds columns to the list
	| ColumnName      |
	| <NewColumnName> |
	When User adds columns to the list
	| ColumnName       |
	| <MoreColumnName> |
	Then Save to New Custom List element is displayed
	When User have reset all columns
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ColumnName      | NewColumnName | MoreColumnName       |
	| Devices      | Import          | Country       | Windows7Mi: Category |
	| Applications | Application Key | Compliance    | App field 2          |
	| Users        | City            | Description   | Floor                |
	| Mailboxes    | Alias           | Time Zone     | Building             |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS14183
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheSaveListFunctionIsHiddenAfterChangingPinnedColumns
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User have opened column settings for "<ColumnName>" column
	When User have select "Pin Left" option from column settings
	Then "<ListName>" list should be displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User have opened column settings for "<ColumnName>" column
	When User have select "Pin Right" option from column settings
	Then "<ListName>" list should be displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User have opened column settings for "<ColumnName>" column
	When User have select "No Pin" option from column settings
	Then "<ListName>" list should be displayed to the user
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ColumnName       |
	| Devices      | Device Type      |
	| Applications | Vendor           |
	| Users        | Domain           |
	| Mailboxes    | Mailbox Platform |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS12738 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsTriggeredOrHiddenForCustomListsAfterAddingOrRemovingColumns
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "DynamicList" name on "<ListName>" page
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName      |
	| <NewColumnName> |
	Then Edit List menu is displayed
	When User adds columns to the list
	| ColumnName         |
	| <AddColumnName>    |
	| <AddAnotherColumn> |
	Then Edit List menu is displayed
	When User have reset all columns
	Then Edit List menu is not displayed
	When User create static list with "StaticList" name on "<ListName>" page with following items
	| ItemName       |
	| <SelectedItem> |
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName      |
	| <NewColumnName> |
	Then Edit List menu is displayed
	When User adds columns to the list
	| ColumnName         |
	| <AddColumnName>    |
	| <AddAnotherColumn> |
	Then Edit List menu is displayed
	When User have reset all columns
	Then Edit List menu is not displayed

Examples:
	| ListName     | ColumnName    | NewColumnName   | SelectedItem                               | AddColumnName | AddAnotherColumn |
	| Devices      | Hostname      | Import          | 001BAQXT6JWFPI                             | Network Card  | Owner City       |
	| Applications | Application   | Application Key | 0004 - Adobe Acrobat Reader 5.0.5 Francais | prK: In Scope | Compliance       |
	| Users        | Username      | City            | $6BE000-SUDQ9614UVO8                       | Cost Centre   | Department Name  |
	| Mailboxes    | Email Address | Alias           | 000F977AC8824FE39B8@bclabs.local           | Enabled       | Import           |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10998 @DAS10972 @DAS12602 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllList_CheckThatTheEditListFunctionIsHiddenAfterAddingChangingAndRemovingSearchCriteria
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "DynamicList2" name on "<ListName>" page
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| <Search>       | <Rows>       |
	Then Edit List menu is not displayed
	Then "DynamicList2" list is displayed to user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | <NewRows>    |
	Then Edit List menu is not displayed
	Then "DynamicList2" list is displayed to user
	And Clearing the agGrid Search Box
	Then Edit List menu is not displayed
	Then "DynamicList2" list is displayed to user
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	When User create static list with "StaticList2" name
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| <Search>       | <Rows>       |
	Then Edit List menu is not displayed
	And "StaticList2" list is displayed to user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | <NewRows>    |
	Then Edit List menu is not displayed
	And "StaticList2" list is displayed to user
	And Clearing the agGrid Search Box
	Then Edit List menu is not displayed
	And "StaticList2" list is displayed to user

Examples:
	| ListName     | ColumnName    | Search    | Rows  | NewRows |
	| Devices      | Hostname      | Centre    | 3,284 | 17      |
	| Users        | Username      | Barland   | 3     | 142     |
	| Applications | Application   | Adobe     | 40    | 1       |
	| Mailboxes    | Email Address | bc-exch07 | 4,188 | 73      |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10972 @DAS12602 @DAS14183 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheEditListFunctionIsHiddenAfterChangingPinnedColumns
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create dynamic list with "DynamicList3" name on "<ListName>" page
	When User have opened column settings for "<PinnedColumnName>" column
	When User have select "Pin Left" option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	When User have select "Pin Right" option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	When User have select "No Pin" option from column settings
	Then "DynamicList3" list is displayed to user
	Then Edit List menu is not displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList3" name
	And User have opened column settings for "<PinnedColumnName>" column
	And User have select "Pin Left" option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	And User have select "Pin Right" option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed
	When User have opened column settings for "<PinnedColumnName>" column
	And User have select "No Pin" option from column settings
	Then "StaticList3" list is displayed to user
	And Edit List menu is not displayed

Examples:
	| ListName     | ColumnName       | PinnedColumnName |
	| Devices      | Device Type      | Hostname         |
	| Applications | Vendor           | Application      |
	| Users        | Domain           | Username         |
	| Mailboxes    | Mailbox Platform | Email Address    |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12515 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatNewCustomListMenuIsHiddenInTheListPanelAfterClickingActionsButton
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed
	When User create static list with "<StaticListName>" name on "<ListName>" page with following items
	| ItemName |
	|          |
	Then "<StaticListName>" list is displayed to user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ColumnName         | StaticListName |
	| Devices      | Owner Display Name | StaticList5548 |
	| Applications | Version            | StaticList8944 |
	| Users        | Distinguished Name | StaticList7412 |
	| Mailboxes    | Owner Display Name | StaticList9512 |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12524 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatSaveAndCancelButtonAreHiddenAfterCancellingProcessOfSavingList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User clicks Save button on the list panel
	And User selects Save as new list option
	Then Save and Cancel buttons are displayed on the list panel
	When User clicks Cancel button on the list panel
	Then Save and Cancel buttons are not displayed on the list panel
	When User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName  |
	| <AddColumn> |
	Then ColumnName is added to the list
	| ColumnName  |
	| <AddColumn> |
	When User clicks Save button on the list panel
	When User selects Save as new list option
	Then Save and Cancel buttons are displayed on the list panel
	When User clicks Cancel button on the list panel
	Then Save and Cancel buttons are not displayed on the list panel

Examples:
	| ListName     | ColumnName    | AddColumn            | DynamicListName |
	| Devices      | Hostname      | Device Key           | DynamicList1178 |
	| Applications | Application   | Barry'sUse: Category | DynamicList1125 |
	| Users        | Username      | GUID                 | DynamicList1195 |
	| Mailboxes    | Email Address | Region               | DynamicList1121 |

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS12524 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatActionsPanelIsHiddenAfterCancellingProcessOfSavingList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Device Count (Used) |
	Then ColumnName is added to the list
	| ColumnName          |
	| Device Count (Used) |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	Then Save and Cancel buttons are not displayed on the list panel
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User types "StaticList7841" static list name
	And User clicks Cancel button on the Actions panel
	Then Checkboxes are not displayed
	And Actions panel is not displayed to the user
	And Save to New Custom List element is displayed

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS12656 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedAfterDuplicatingANewStaticListWithALongName
	When User create static list with "1111111111111111111111111111111111111111" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "1111111111111111111111111111111111111111" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User duplicates list with "1111111111111111111111111111111111111111" name
	Then "111111111111111111111111111111111111112" list is displayed to user
	Then There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS12685 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatDataFromTheStaticListAreSavedInTheNewListAfterEditing
	When User create static list with "StaticList1412" name on "Users" page with following items
	| ItemName            |
	| 003F5D8E1A844B1FAA5 |
	| 00A5B910A1004CF5AC4 |
	Then "StaticList1412" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Enabled    |
	Then ColumnName is added to the list
	| ColumnName |
	| Enabled    |
	When User clicks Save button on the list panel
	When User selects Save as new list option
	When User creates new custom list with "CustomList5588" name
	Then "CustomList5588" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User duplicates list with "StaticList1412" name
	Then "StaticList14122" list is displayed to user
	Then "2" rows are displayed in the agGrid

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS12630
Scenario: EvergreenJnr_UsersList_CheckThatStaticListIsDisplayedInTheBottomOfTheListPanelWhenNavigateToTheMainList
	When User create static list with "StaticList6542" name on "Users" page with following items
	| ItemName            |
	| 000F977AC8824FE39B8 |
	| 00A5B910A1004CF5AC4 |
	Then "StaticList6542" list is displayed to user
	When User navigates to the "All Users" list
	Then "StaticList6542" list is displayed in the bottom section of the List Panel
	When User clicks Settings button for "StaticList6542" list
	When User clicks Delete button for custom list
	Then "list will be permanently deleted" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	And "List deleted" message is displayed

@Evergreen @Devices @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Compliance" filter from "Application" category
	When User change selected checkboxes:
	| Option | State |
	| Red    | true  |
	When User add "Application Compliance" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association        |
	| Red                | Used on device     |
	| Green              | Entitled to device |
	And User create custom list with "Test_Device_Filter_DAS_12917" name
	And User clicks the List Details button
	And User changes list name to "EDITED_Device_Filter_DAS_12917"
	And User clicks the Filters button
	And User click Edit button for "Application " filter
	And User change selected checkboxes:
	| Option | State |
	| Red    | false |
	Then "EDITED_Device_Filter_DAS_12917" edited list is displayed to user

@Evergreen @Applications @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917 
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	And User create custom list with "Test_Application_Filter_DAS_12917" name
	And User clicks the List Details button
	And User changes list name to "EDITED_Application_Filter_DAS_12917"
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Compliance" filter
	And User change selected checkboxes:
	| Option | State |
	| Amber  | false |
	Then "EDITED_Application_Filter_DAS_12917" edited list is displayed to user

@Evergreen @Mailboxes @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "Before" with added column and "11 Dec 2017" Date filter
	And User create custom list with "Test_Mailbox_Filter_DAS_12917" name
	And User clicks the List Details button
	And User changes list name to "EDITED_Mailbox_Filter_DAS_12917"
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Created Date" filter
	And User changes filter date to "13 Dec 2017"
	Then "EDITED_Mailbox_Filter_DAS_12917" edited list is displayed to user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS12891 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatCancelButtonIsDisplayedWithCorrectlyColorOnListPanel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList12891" name on "Devices" page
	Then "TestList12891" list is displayed to user
	When User click Delete button for custom list with "TestList12891" name
	Then Cancel button is displayed with correctly color
	Then User confirm removed list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13639 @DAS13643 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatListTypeFilterForCreatedListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User create static list with "StaticFilterList_1" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	When User click on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_1" name on "Devices" page
	Then "DynamicFilterList_1" list is displayed to user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotDynamicFilterList_1" name
	Then "PivotDynamicFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Build Date |
	And User selects the following Columns on Pivot:
	| Columns                |
	| Application Compliance | 
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotFilterList_1" name
	Then "PivotFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	When User apply "Dynamic" filter to lists panel
	Then "DynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is not displayed in the bottom section of the List Panel
	When User enters "1" text in Search field at List Panel
	Then "DynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is not displayed in the bottom section of the List Panel
	When User apply "Static" filter to lists panel
	Then "DynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is displayed in the bottom section of the List Panel
	When User enters "1" text in Search field at List Panel
	Then "DynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is displayed in the bottom section of the List Panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13640 @DAS13643 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User create static list with "StaticFilterList_2" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	When User click on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_2" name on "Devices" page
	Then "DynamicFilterList_2" list is displayed to user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotDynamicFilterList_2" name
	Then "PivotDynamicFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Build Date |
	And User selects the following Columns on Pivot:
	| Columns                |
	| Application Compliance | 
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotFilterList_2" name
	Then "PivotFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	When User apply "Standard" filter to lists panel
	Then "DynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is not displayed in the bottom section of the List Panel
	When User enters "2" text in Search field at List Panel
	Then "DynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is not displayed in the bottom section of the List Panel
	When User apply "Pivot" filter to lists panel
	Then "DynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is not displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is displayed in the bottom section of the List Panel
	When User enters "2" text in Search field at List Panel
	Then "DynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is not displayed in the bottom section of the List Panel	
	And "PivotDynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is displayed in the bottom section of the List Panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13643
Scenario: EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User apply "Not favourite" filter to lists panel
	Then "1803 Rollout" list is displayed in the bottom section of the List Panel
	When User apply "Favourite" filter to lists panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel
	When User enters "1803" text in Search field at List Panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13643
Scenario: EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User apply "Shared with me " filter to lists panel
	Then "1803 Rollout" list is displayed in the bottom section of the List Panel
	When User apply "Owned by me " filter to lists panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel
	When User enters "1803" text in Search field at List Panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel