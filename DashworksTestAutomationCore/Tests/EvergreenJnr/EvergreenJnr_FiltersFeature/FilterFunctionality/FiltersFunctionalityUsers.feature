Feature: FiltersFunctionalityUsers
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS10612
Scenario: EvergreenJnr_UsersList_CheckThat500ErrorIsNotReturnedForFilterWithSpecialCharecter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then "Display Name" filter is added to the list
	Then "2" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS11577
Scenario Outline: EvergreenJnr_UsersList_CheckThatLDAPFilterCategoryHaveAddColumnCheckboxes
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User select "<OperatorValues>" Operator value
	When User enters "<EnteredText>" text in Search field at selected Filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |

Examples:
	| FilterName             | OperatorValues   | EnteredText                                                | SelectedCheckboxes                |
	| accountexpires         | Equals           | 9223372036854775807                                        | Add accountexpires column         |
	| badpasswordtime        | Contains         | 13146                                                      | Add badpasswordtime column        |
	| admincount             | Empty            |                                                            | Add admincount column             |
	| employeeid             | Begins with      | ZY or ZX                                                   | Add employeeid column             |
	| whencreated            | Does not contain | 2017                                                       | Add whencreated column            |
	| department             | Ends with        | LongName01234567890123456789012345678901234567890123456789 | Add Department column             |
	| iscriticalsystemobject | Not empty        |                                                            | Add iscriticalsystemobject column |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS12167 @DAS12056 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedListFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" without added column and following value:
	| Values     |
	| YOG2259571 |
	When User create dynamic list with "YOG2259571 Users" name on "Users" page
	Then "YOG2259571 Users" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList     | Association     |
	| YOG2259571 Users | Entitled to app |
	Then "4" rows are displayed in the agGrid
	Then "Any User in list YOG2259571 Users entitled to app" is displayed in added filter info
	Then Filter name is colored in the added filter info
	Then Filter value is shown in bold in the added filter info
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS12181 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList8546" name
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Username" filter where type is "Contains" with following Value and Association:
	| Values | Association                            |
	| Bob    | Has used app                           |
	| Bob    | Entitled to app                        |
	| Bob    | Owns a device which app was used on    |
	| Bob    | Owns a device which app is entitled to |
	When User create dynamic list with "UsersBob" name on "Applications" page
	Then "UsersBob" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "User (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association                         |
	| StaticList8546 | Has used app                        |
	| StaticList8546 | Entitled to app                     |
	| StaticList8546 | Owns a device which app was used on |
	Then "5" rows are displayed in the agGrid
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS12351
Scenario Outline: EvergreenJnr_UsersList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                                                       | SelectedCheckboxes | Rows   |
	| Windows7Mi: Category                                             | Terminated         | 1      |
	| Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page | Not Applicable     | 4,642  |
	| Barry'sUse: Category                                             | Empty              | 41,339 |
	| Havoc(BigD: Path                                                 | [Default (User)]   | 7,578  |
	| UserSchedu: Group Stage \ Group User Default Request Type        | Not Applicable     | 679    |
	| ComputerSc: Group Stage \ Group User Default Request Type        | Not Applicable     | 1,809  |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS12804 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatSavedStaticListIsNotShownInEditMode
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| AU             |
	Then "Domain" filter is added to the list
	When  User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AAO798996        |
	| AGC788194        |
	| AIU705098        |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList8543" name
	Then "StaticList8543" list is displayed to user
	Then Edit List menu is not displayed
	Then URL contains 'evergreen/#/users?$listid='

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS13384 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatEditButtonIsDisplayedOnFiltersSectionIfEditFormOpenWhenYouSaveList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "UserSched2: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Light Blue     |
	| Out Of Scope   |
	| Blue           |
	Then "UserSched2: Readiness" filter is added to the list
	When User click Edit button for "UserSched2: Readiness" filter
	When User creates 'DynamicList13384' dynamic list
	Then "DynamicList13384" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Edit button is displayed correctly for "UserSched2: Readiness" filter

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS9820 @DAS13296
Scenario Outline: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxFiltersCanBeUsedOnUsersPage
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values   |
	| <Values> |
	Then "<RowsCount>" rows are displayed in the agGrid
	Then There are no errors in the browser console

Examples: 
	| FilterName             | Values | RowsCount        |
	| Device Count           | 6      | 1                |
	| Group Count            | 13     | 32               |
	| Mailbox Count (Access) | 3      | 6                |
	#| Mailbox Count (Owned)  | 4      | to_be_determined |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS14629 @DAS14664 @DAS14669
Scenario: EvergreenJnr_UsersList_PrimaryDeviceChipsCanBeRemoved
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Primary Device" filter
	#Equals Operator value
	When User select "Equals" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not equal Operator value
	When User select "Does not equal" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Contains Operator value
	When User select "Contains" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not contain Operator value
	When User select "Does not contain" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Begins with Operator value
	When User select "Begins with" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not begin with Operator value
	When User select "Does not begin with" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Ends with Operator value
	When User select "Ends with" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not end with Operator value
	When User select "Does not end with" Operator value
	When User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS15246 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatUrlOfSavedListHasNoEmptyParameters
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Windows7Mi: Communication \ Send Applications List - User Object Task (Team)" filter
	When User clicks in search field in the Filter block
	When User enters "Unassigned" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User create dynamic list with "TestList15246" name on "Users" page
	Then "TestList15246" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User navigates to the "TestList15246" list
	Then "TestList15246" list is displayed to user
	Then URL contains 'evergreen/#/users?$listid='
	Then URL contains only "listid" filter

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS15291
Scenario: EvergreenJnr_UsersList_CheckSlotsSortOrderForUsersList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User Add And "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| BCLABS         |
	When User clicks on 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column is equal to
	| Content     |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 2 |
	| User Slot 2 |
	When User clicks on 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column is equal to
	| Content     |
	| User Slot 2 |
	| User Slot 2 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS15807
Scenario: EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Language" filter where type is "Equals" with added column and Lookup option
	| SelectedValues  |
	| English         |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS17004
Scenario: EvergreenJnr_UsersList_CheckDepartmentLevelFilterItems
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Sales            |
	| Finance         |
	When User Add And "Department Level 2" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Marketing      |
	When User Add And "Department Level 3" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Admin              |
	| Support            |
	| Helpdesk           |
	Then "1,800" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS17715 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckCustomFieldsUsingInFilterAndPivotsCreation
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "Application Owner" filter where type is "Not empty" with following Value and Association:
	| Values | Association                        |
	|        | Entitled to a device owned by user |
	#counter can be updated
	Then "918" rows are displayed in the agGrid
	Then There are no errors in the browser console
	When User create dynamic list with "TestList_DAS17715" name on "Users" page
	Then "TestList_DAS17715" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups    |
	| Display Name |
	When User selects the following Values on Pivot:
	| Values   |
	| Zip Code |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS17715_Pivot" name
	Then There are no errors in the browser console

#Then "71" rows are displayed in the agGrid
@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS11552 @DAS12207
Scenario: EvergreenJnr_UsersList_CheckThatRelevantDataSetBeDisplayedAfterResettingFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then "Enabled" filter is added to the list
	Then message 'No users found' is displayed to the user
	When User have reset all filters
	Then 'All Users' list should be displayed to the user
	Then "41,339" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS11144 @DAS12351
Scenario: EvergreenJnr_UsersList_CheckThatChildrenOfTreeBasedFiltersAreIncludedInTheListResultsOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Does not equal" with added column and "Support" Tree List option
	Then "Department" filter is added to the list
	Then "35,082" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS14629 @DAS14664 @DAS14665 @DAS14667
Scenario Outline: EvergreenJnr_UsersList_CheckThatPrimaryDeviceOperatorsShowTextBoxCorrectly
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Primary Device" filter
	When User select "<OperatorValue>" Operator value
	Then User Description field is not displayed
	When User clicks 'CANCEL' button
	When user select "Primary Device" filter
	When User select "<OperatorValue>" Operator value
	Then User Description field is not displayed
	When User adds column for the selected filter
	When User clicks Save filter button
	Then ColumnName is added to the list
		| ColumnName     |
		| Primary Device |
	Then "<RowsCount>" rows are displayed in the agGrid

	Examples:
		| OperatorValue | RowsCount |
		| Empty         | 28,117    |
		| Not empty     | 13,222    |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS12232 @DAS12351 @DAS14288
Scenario: EvergreenJnr_UsersList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| Started            |
	| Failed             |
	| Complete           |
	When User Add And "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	Then "4,641" rows are displayed in the agGrid
	When User create dynamic list with "Users_ProjectTaskFilters_AND" name on "Users" page
	Then "Users_ProjectTaskFilters_AND" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User navigates to the "Users_ProjectTaskFilters_AND" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page is Not Applicable, Started, Failed or Complete" is displayed in added filter info
	Then "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent is Not Applicable" is displayed in added filter info
	When User click Edit button for "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page" filter
	When User select "Does not equal" Operator value
	When User change selected checkboxes:
	| Option         | State |
	| Not Applicable | false |
	| Not Started    | true  |
	| Started        | true  |
	| Failed         | true  |
	| Complete       | true  |
	When User click Edit button for "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent" filter
	When User change selected checkboxes:
	| Option         | State |
	| Not Applicable | true  |
	| Not Sent       | false |
	| Sent           | true  |
	Then "4,642" rows are displayed in the agGrid
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS19714
Scenario: EvergreenJnr_UsersList_CheckThatThereIsNoErrorAfterTryingToFilterDataByWrongDate
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When user select "Last Logon Date" filter
	When User enters 'R.1111' text in 'Date' Search field
	When User clicks Body container
	When User enters 'R.' text in 'Date' Search field
	When User clicks 'ADD' button
	Then 'ADD' button is disabled
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS18367
Scenario Outline: EvergreenJnr_UsersList_CheckThatThereIsNoEmptyOptionInInListFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "<List>" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

	Examples:
		| List                     |
		| User (Saved List)        |
		| Application (Saved List) |

@Evergreen @Evergreen_FiltersFeature @Filter_UsersList @DAS21015 @Cleanup
Scenario Outline: EvergreenJnr_UsersList_ChecksThatMailboxFiltersWorksAndCanBeSavedAsPartOfList
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When user select "Mailbox" filter
	When User select "Equals" Operator value
	When User enters "000F977AC8824FE39B8@bclabs.local" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks 'ADD' button
	Then table content is present
	Then There are no errors in the browser console
	When User create dynamic list with "UsersList_21015" name on "Users" page
	Then "UsersList_21015" list is displayed to user