Feature: FiltersFunctionalityAllLists
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS11042
Scenario Outline: EvergreenJnr_AllLists_CheckThatPrimaryColumnIsDisplayedAfterAddingAFilterWithColumn
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Contains" with added column and following value:
	| Values        |
	| <FilterValue> |
	Then "<FilterName>" filter is added to the list
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |

Examples: 
	| ListName     | FilterName              | FilterValue | ColumnName    |
	| Devices      | Hostname                | 00          | Hostname      |
	| Applications | Application             | adobe       | Application   |
	| Users        | Username                | aa          | Username      |
	| Mailboxes    | Email Address (Primary) | ale         | Email Address |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS10977 @DAS12351
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserBackButtonForLookupFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User have created "Equals" Lookup filter with column and "<FilterValue>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "<Text>" is displayed in added filter info

Examples: 
	| ListName     | FilterName                                   | FilterValue            | RowsCount | ColumnName    | ObjectName              | Text                                                        |
	| Applications | Barry'sUse: Target App                       | Python 2.2a4 (SMS_GEN) | 1         | Application   | Python 2.2a4            | Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)            |
	| Mailboxes    | EmailMigra: Migration \ BT/QMM Switch Status | Not Started            | 729       | Email Address | alex.cristea@juriba.com | EmailMigra: Migration \ BT/QMM Switch Status is Not Started |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS13201 @DAS14757 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatCreatedCapacityUnitCanBeUsedAsAFilterWhichReturnsCorrectItems
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	And User clicks 'CREATE EVERGREEN CAPACITY UNIT' button 
	And User enters 'CapacityUnit13201' text to 'Capacity Unit Name' textbox
	And User enters '13201' text to 'Description' textbox
	And User clicks 'CREATE' button 
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	| 01P96J2EQ0HZSV   |
	| 00KLL9S8NRF0X6   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "3" rows are displayed in the agGrid
	When User clicks 'Users' on the left-hand menu
	And User clicks the Actions button
	And User select "Username" rows in the grid
	| SelectedRowsName    |
	| 0072B088173449E3A93 |
	| 00DBB114BE1B41B0A38 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "2" rows are displayed in the agGrid
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Actions button
	And User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0105AF7E8E154E87B1A@bclabs.local |
	| 0141713E5CF84ADE907@bclabs.local |
	| 01C4FB7C6D2C4F979BD@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "3" rows are displayed in the agGrid
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Actions button
	And User select "Application" rows in the grid
	| SelectedRowsName         |
	| 20040610sqlserverck      |
	| 7-Zip 9.20 (x64 edition) |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	And User selects 'CapacityUnit13201' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	And User add "Evergreen Capacity Unit" filter where type is "Equals" with added column and Lookup option
	| SelectedValues    |
	| CapacityUnit13201 |
	Then "Evergreen Capacity Unit" filter is added to the list
	And ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	And "2" rows are displayed in the agGrid
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit13201 |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS12537 @DAS12579
Scenario Outline: EvergreenJnr_AllLists_CheckThatContentIsDisplayedInTheAddedColumnAfterApplyingIsNotNoneOperator
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	Then Content is present in the newly added column
	| ColumnName         |
	| <NewlyAddedColumn> |

Examples:
	| ListName  | FilterName           | NewlyAddedColumn     |
	| Mailboxes | EmailMigra: Category | EmailMigra: Category |
	| Devices   | Windows7Mi: Category | Windows7Mi: Category |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS12636 @DAS12481
Scenario Outline: EvergreenJnr_AllLists_CheckThatLocationFilterIsEditedCorrectly
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Postal Code" filter
	And User select "Not empty" Operator value
	And User adds column for the selected filter
	And User clicks Save filter button
	Then Content is present in the newly added column
	| ColumnName  |
	| Postal Code |
	When User Add And "State/County" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then '<FilterValue>' content is displayed in the 'State/County' column
	When User click Edit button for "State/County" filter
	And User deletes the selected lookup filter "<FilterValue>" value
	And User have created "Equals" Lookup filter with column and "Empty" option
	Then "State/County is Empty" is displayed in added filter info
	And Content is empty in the column
	| ColumnName   |
	| State/County |

Examples:
	| ListName  | FilterValue |
	| Devices   | NY          |
	| Users     | NY          |
	| Mailboxes | VIC         |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS13392
Scenario Outline: EvergreenJnr_AllLists_CheckThatSearchBySharpOrAmpersandSymbolWorksInTextFilter
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values |
	| #&     |
	Then "<FilterName>" filter is added to the list
	And message '<Message>' is displayed to the user

Examples: 
	| ListName     | FilterName  | Message               |
	| Devices      | Hostname    | No devices found      |
	| Users        | Username    | No users found        |
	| Applications | Application | No applications found |
	| Mailboxes    | Mail Server | No mailboxes found    |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS12351
Scenario Outline:EvergreenJnr_AllLists_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseDepartmentFilter
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "<SelectedCheckboxes>" Tree List option
	Then "Department" filter is added to the list
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| PageName  | SelectedCheckboxes      | Rows  |
	| Devices   | Application Development | 873   |
	| Users     | Application Development | 1,858 |
	| Mailboxes | Application Development | 1,118 |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS13145
Scenario Outline: EvergreenJnr_AllLists_ChecksThatApplicationFilterIsNotExcludedApplicationsWhichAreNotLinkedToAnyDevices
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application" filter
	And User clicks in search field for selected Association filter
	Then "50 of 2223 shown" results are displayed in the Filter panel
	And the following values are displayed for "Application" filter on "<PageName>" page:
	| Value                               |
	| Acrobat Reader 6.0.1 (500)          |
	| ACT Data Collection Packages (1104) |
	Then "ACT Data Collection Packages (1104)" is displayed after "Acrobat Reader 6.0.1 (500)" in Application list filter
	When User enters "1104" text in Search field at selected Lookup Filter
	Then "ACT Data Collection Packages (1104)" value is displayed for selected Lookup Filter

Examples:
	| PageName |
	| Devices  |
	#| Users    |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS13381 @DAS14603
Scenario Outline: EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjectAndThenReturningBackToSerachResult
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <FilterValue>      |
	Then "<FilterName>" filter is added to the list
	And "<FilterInfo>" is displayed in added filter info
	When User perform search by "<Search>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "<FilterInfo>" is displayed in added filter info

Examples: 
	| PageName     | ColumnName    | FilterName                               | FilterValue    | Search                                     | FilterInfo                                                 |
	| Devices      | Hostname      | Havoc(BigD: Category                     | Empty          | 019BFPQGKK5QT8N                            | Havoc(BigD: Category is Empty                              |
	| Devices      | Hostname      | Havoc(BigD: In Scope                     | FALSE          | 08HRHU20R2JY3W                             | Havoc(BigD: In Scope is False                              |
	| Devices      | Hostname      | ComputerSc: Path                         | Request Type A | 47NK3ATE5DM2HD                             | ComputerSc: Path is Request Type A                         |
	| Applications | Application   | Havoc(BigD: Hide From End Users          | Empty          | Adobe Flash Player 10 ActiveX (10.0.12.36) | Havoc(BigD: Hide From End Users is Empty                   |
	| Applications | Application   | Barry'sUse: In Scope                     | FALSE          | Amazon Redshift ODBC Driver 64-bit         | Barry'sUse: In Scope is False                              |
	| Mailboxes    | Email Address | EmailMigra: Mobile Devices \ Device Type | Not Identified | 238BAE24882E48BFA9F@bclabs.local           | EmailMigra: Mobile Devices \ Device Type is Not Identified |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS14524
Scenario Outline: EvergreenJnr_AllLists_CheckRowsCountedForOrganizationalUnitFilterWithSelectedValue
	When User clicks '<Page>' on the left-hand menu
	Then 'All <Page>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "<Type>" with added column and following value:
	| Values  |
	| <Value> |
	Then "<FilterName>" filter is added to the list
	And "<Rows>" rows are displayed in the agGrid

Examples:
	| Page         | FilterName                | Type        | Value                  | Rows   |
	| Devices      | Owner Organisational Unit | Equals      | Users.Cardiff.UK.local | 1,458  |
	| Devices      | Owner Organisational Unit | Contains    | Users                  | 11,665 |
	| Users        | Organisational Unit       | Begins with | Users                  | 23,728 |
	| Mailboxes    | Owner Organisational Unit | Not Empty   |                        | 14,837 |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS16912
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplinceNoneOptionIsTranslatedInFilter
	When User clicks '<ListName>' on the left-hand menu
	And User language is changed to "Deutsch" via API
	And User clicks refresh button in the browser
	And User clicks the Filters button
	And user select "<TranslatedColumnName>" filter
	Then Following checkboxes are available for current opened filter:
	| checkboxes |
	| Leer       |
	| Unbekannt  |
	| Rot        |
	| Bernstein  |
	| Grün       |
	| Ignorieren |

Examples: 
	| ListName     | TranslatedColumnName        |
	| Devices      | Anwendungskonformität       |
	| Users        | Geräteanwendungskonformität |
	| Applications | Konformität                 |
	| Mailboxes    | Konformität des Inhabers    |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS18377 @DAS18621 @DAS18686
Scenario Outline: EvergreenJnr_AllLists_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRelative
	When User clicks '<List>' on the left-hand menu
	And User clicks the Filters button
	And User add "<Filter>" filter where type is "Equals (relative)" with added column and following value:
	| Values  |
	| <Value> |
	Then There are no errors in the browser console

Examples:
	| List         | Filter                               | Value                                       |
	| Devices      | 2004: Pre-Migration \ Scheduled Date | 1                                           |
	| Applications | Owner Last Logon Date                | 1                                           |
	| Devices      | Owner Last Logon Date                | 2.37457468568568568568658464554575547547547 |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS18387
Scenario Outline: EvergreenJnr_AllLists_CheckThatZeroCanBeSelectedInRelativeFilter
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When user select "<Filter>" filter
	When User select "<Operator>" Operator value
	When User enters '-1' text to 'dayValue' textbox
	Then '0' content is displayed in 'dayValue' textbox
	Then User sees '0 to 100000' hint below 'dayValue' field
	When User enters '100001' text to 'dayValue' textbox
	Then '100000' content is displayed in 'dayValue' textbox
	Then User sees '0 to 100000' hint below 'dayValue' field

Examples:
	| List         | Filter                       | Operator                |
	| Devices      | Boot Up Date                 | Equals (relative)       |
	| Applications | Device Owner Last Logon Date | Before (relative)       |
	| Users        | Last Logon Date              | After (relative)        |
	| Mailboxes    | Created Date                 | On or before (relative) |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS19669
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterStaysWorkingAfterAddingDepartmentFilter
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When User add "<Filter>" filter where type is "Equals" with added column and "Empty" Tree List option
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	When User clicks the Filters button
	Then "<Filter> is Empty" is displayed in added filter info

Examples:
	| List      | Filter           |
	| Devices   | Owner Department |
	| Users     | Department       |
	| Mailboxes | Owner Department |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS10578 @DAS14159
Scenario Outline: EvergreenJnr_AllLists_CheckThatDashworksFirstSeenFilterIsAddedToTheFilterList
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Dashworks First Seen |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Dashworks First Seen" filter
	Then "Equals, Equals (relative), Does not equal, Between, Does not equal (relative), Before, Before (relative), On or before, On or before (relative), After, After (relative), On or after, On or after (relative), Empty, Not empty" option is available for this filter
	When User have created "Empty" Date filter with column and "" option
	Then "Dashworks First Seen is empty" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on 'Dashworks First Seen' column header
	Then data in table is sorted by 'Dashworks First Seen' column in descending order 

Examples:
	| ListName     | RowsCount |
	| Devices      | 17,219    |
	| Users        | 41,335    |
	| Applications | 2,223     |
	| Mailboxes    | 14,784    |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS11830 @DAS14288
Scenario Outline: EvergreenJnr_AllLists_CheckThatOptionsIsAvailableForFiltersOfProjectTaskCategories
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "Empty, Off, On" checkbox is available for this filter

Examples:
	| PageName     | FilterName                           |
	| Users        | ComputerSc: One \ User Off/On        |
	| Devices      | ComputerSc: One \ Computer Off/On    |
	| Applications | ComputerSc: One \ Application Off/On |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS10771 @DAS10972 @DAS14748
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoneOptionIsAvailableForFilters
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then Save to New Custom List element is displayed
	When User click Edit button for "<FilterName>" filter
	Then User changes filter type to "Does not equal"
	Then Save to New Custom List element is displayed
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then Save to New Custom List element is displayed
	When User Add And "<NewFilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Red                |
	When User Add And "<NewFilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Amber              |
	Then Save to New Custom List element is displayed
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed

	Examples:
		| PageName     | FilterName           | NewFilterName    |
		| Devices      | Windows7Mi: Category | Compliance       |
		| Users        | UserSchedu: Category | Compliance       |
		| Applications | Havoc(BigD: Category | Compliance       |
		| Mailboxes    | EmailMigra: Category | Owner Compliance |

@Evergreen @Evergreen_FiltersFeature @Filter_AllLists @DAS11088
Scenario Outline: EvergreenJnr_AllLists_CheckThatConsoleErrorsAreNotDisplayedForDateFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then There are no errors in the browser console

	Examples:
		| ListName     | FilterName                                                                     |
		| Devices      | Build Date                                                                     |
		| Devices      | Owner Last Logon Date                                                          |
		| Devices      | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task |
		| Users        | Barry'sUse: Project Dates \ Scheduled Date                                     |
		| Applications | UserSchedu: Three \ Date App Req A                                             |
		| Mailboxes    | Created Date                                                                   |
