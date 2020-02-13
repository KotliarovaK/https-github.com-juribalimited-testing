Feature: CustomListDisplayPart2
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS10998 @DAS10972
Scenario Outline: EvergreenJnr_AllList_CheckThatSearchDoesNotTriggerNewCustomList
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| <Search>       | <Rows>       |
	Then Save to New Custom List element is NOT displayed
	And '<ListLabel>' list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | <NewRows>    |
	Then Save to New Custom List element is NOT displayed
	And '<ListLabel>' list should be displayed to the user
	And Clearing the agGrid Search Box
	And Save to New Custom List element is NOT displayed
	And '<ListLabel>' list should be displayed to the user

	Examples:
	| ListName     | ListLabel        | Search | Rows | NewRows |
	| Devices      | All Devices      | Henry  | 34   | 18      |
	| Users        | All Users        | Henry  | 67   | 142     |
	| Applications | All Applications | Hen    | 5    | 1       |
	| Mailboxes    | All Mailboxes    | Henry  | 22   | 73      |

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11081 @DAS11951 @DAS12152 @DAS12602 @DAS15032 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewListCreatedMessageForStaticListIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList4A22A5" name
	Then "TestList4A22A5" list is displayed to user
	When User clicks on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User selects 'SAVE AS NEW STATIC LIST' option from Save menu and creates 'UnbelievableTestList' list
	Then "UnbelievableTestList" list is displayed to user

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11005 @DAS11489 @DAS12152 @DAS12194 @DAS12199 @DAS12220 @DAS12351 @DAS12602 @DAS12966 @DAS13838 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatListsIsDisplayedInAlphabeticalOrder
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "L TestList Custom List" name on "Users" page
	Then "L TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and "Empty" Lookup option
	Then "2004: Readiness" filter is added to the list
	When User create dynamic list with "A TestList Custom List" name on "Users" page
	Then "A TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 000F977AC8824FE39B8 |
	| 002B5DC7D4D34D5C895 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "KY TestList Static List" name
	Then "KY TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "NINJA TestList Static List" name
	Then "NINJA TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName     |
	| $231000-3AC04R8AR431 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "QWER TestList Static List" name
	Then "QWER TestList Static List" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Enabled" filter is added to the list
	When User create dynamic list with "X TestList Custom List" name on "Users" page
	Then "X TestList Custom List" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	Then lists are sorted in alphabetical order

@Evergreen @Users @EvergreenJnr_ListPanel @CustomListDisplay @DAS11018 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatCustomListCreationBlockIsNotDisplayedWhenUserOpensActionsPanel
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
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