﻿Feature: Functionality
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_FiltersFeature @FiltersFunctionality @DAS10612
Scenario: EvergreenJnr_UsersList_CheckThat500ErrorIsNotReturnedForFilterWithSpecialCharecter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then "Display Name" filter is added to the list
	And "2" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersFunctionality @DAS10639 @DAS12207
Scenario: EvergreenJnr_ApplicationsList_Check500ErrorIsNotReturnedForBooleanFilterWithUnknownOption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "1,156" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS10734 @DAS11507 @DAS12351 @DAS12512
Scenario: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxWorksCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| A Star Packages     |
	Then "Windows7Mi: Category" filter is added to the list
	Then table data is filtered correctly
	When User clicks refresh button in the browser
	Then User sees "3" rows in grid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11166 @DAS11665 @DAS13172 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredAfterGoingBackToTheListAgain
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                       |
	| Microsoft Office 97, Professional Edition    |
	| Microsoft Office 97, Developer Edition Tools |
	| Microsoft Office 97, Standard Edition        |
	Then "Application" filter is added to the list
	When User create dynamic list with "TestList5D30CF" name on "Applications" page
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "TestList5D30CF" list
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info

@Evergreen @AllLists @Evergreen_FiltersFeature @FilterFunctionality @DAS11042
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

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS11042 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsCheckedAfterSavingFilterInANewList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList4A5CD6" name on "Devices" page
	Then "TestList4A5CD6" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList4A5CD6" list
	Then "TestList4A5CD6" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS11042
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsCheckedAfterSavingAFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS11042
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsUncheckedAfterSavingAFilterAndRemovingAColumn
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	When User clicks the Columns button
	When User removes "Compliance" column by Column panel
	When User clicks the Filters button
	#When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is unchecked
	And "Add column" checkbox is not disabled

@Evergreen @AllLists @Evergreen_FiltersFeature @FilterFunctionality @DAS10977 @DAS11507 @DAS12221 @DAS12351 @archived
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserBackButtonForCheckboxesFilters
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| <FilterValue>      |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	Then "1" rows are displayed in the agGrid
	When User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "1" rows are displayed in the agGrid
	Then "<Text>" is displayed in added filter info

Examples: 
	| ListName     | FilterName                      | FilterValue    | RowsCount | ColumnName    | ObjectName                                | Text                                       |
	| Devices      | Babel(Engl: Category            | None           | 17,225    | Hostname      | 01COJATLYVAR7A6                           | Babel(Engl: Category is None               |
	| Devices      | Barry'sUse: In Scope            | FALSE          | 15,896    | Hostname      | 00BDM1JUR8IF419                           | Barry'sUse: In Scope is false              |
	| Devices      | ComputerSc: Path                | Request Type A | 132       | Hostname      | 46DIQRWG3BM6K9Z                           | ComputerSc: Request Type is Request Type A |
	| Applications | Havoc(BigD: Hide from End Users | UNKNOWN        | 1,156     | Application   | Microsoft Silverlight 2 SDK (2.0.31005.0) | Havoc(BigD: Hide from End Users is Unknown |
	| Applications | MigrationP: Core Application    | FALSE          | 220       | Application   | Quartus II Programmer 4.0                 | MigrationP: Core Application is false      |
	| Mailboxes    | EmailMigra: Device Type         | Not Identified | 729       | Email Address | alex.cristea@juriba.com                   | EmailMigra: Device Type is Not Identified  |

@Evergreen @AllLists @Evergreen_FiltersFeature @FilterFunctionality @DAS10977 @DAS12351
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

@Evergreen @Applications @Evergreen_FiltersFeature @FilterFunctionality @DAS10977 @DAS12954
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserbackButtonForValuesFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                    |
	| Microsoft Office 97, Professional Edition |
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info
	Then "5" rows are displayed in the agGrid
	When User perform search by "Microsoft Office 97, Professional Edition"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	Then select all rows checkbox is unchecked
	When User click content from "Application" column
	Then User click back button in the browser
	Then "5" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info

@Evergreen @Applications @Evergreen_FiltersFeature @FilterFunctionality @DAS10977 @DAS13376 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowseBackButtonForListFilters
	When User add following columns using URL to the "Applications" page:
	| ColumnName      |
	| Application Key |
	When User create dynamic list with "TestListD75CD3" name on "Applications" page
	Then "TestListD75CD3" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| TestListD75CD3 | Not used on device |
	Then "Any Application in list TestListD75CD3 not used on device" is displayed in added filter info
	Then "17,185" rows are displayed in the agGrid
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then User click back button in the browser
	Then "17,185" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Any Application in list TestListD75CD3 not used on device" is displayed in added filter info

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS11560
Scenario: EvergreenJnr_DevicesList_CheckNumericFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Count (Installed)" filter where type is "Less than" without added column and following value:
	| Values |
	| 1      |
	Then "App Count (Installed) is less than 1" is displayed in added filter info
	Then "5,195" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11469
Scenario Outline: EvergreenJnr_DevicesList_CheckThatAssociationSearchInFiltersPanelIsWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User enters "used" in Association search field 
	Then search values in Association section working by specific search criteria

Examples:
	| FilterName                 |
	| Application                |
	| Application Import         |
	| Application Inventory Site |
	| Application Vendor         |
	| Application Version        |
	#| Application Compliance     |
	#| Application (Saved List)   |
	#| Application Import Type    |
	#| Application Name           |
	

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11560
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorInNotDisplayedWhenUserApplyASelectedNumericFilter 
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Installed)" filter where type is "Less than" with added column and following value:
	| Values |
	| 10     |
	Then "Device Count (Installed)" filter is added to the list
	Then "1,269" rows are displayed in the agGrid
	Then "(Device Count (Installed) < 10)" text is displayed in filter container

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11551 @DAS11550 @DAS11749
Scenario Outline: EvergreenJnr_DevicesList_CheckThatEmptyNotEmptyOperatorsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	When User select "<OperatorValues>" Operator value
	Then Associations panel is displayed in the filter

Examples:
	| OperatorValues |
	| Empty          |
	| Not Empty      |

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11577
Scenario Outline: EvergreenJnr_UsersList_CheckThatLDAPFilterCategoryHaveAddColumnCheckboxes
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User select "<OperatorValues>" Operator value
	And User enters "<EnteredText>" text in Search field at selected Filter
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

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11738 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatToolTipShownWithEditFilterTextWhenEditingAFilterDisplayed 
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User navigate to Edit button for "Compliance" filter
	Then tooltip is displayed with "Edit Filter" text for edit filter button

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11678
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWhenEnteringInvalidData
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Build Date" filter where type is "Equals" with added column and following value:
	| Values |
	| 1      |
	Then Save button is not available on the Filter panel

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13201 @DAS14757
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
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
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
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
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
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
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
	And User selects 'Evergreen' in the 'Also Move Users' dropdown
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

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11559
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearWhenAddingAdvancedAndStandardFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Import" filter where type is "Equals" with Selected Value and following Association:
	| SelectedList | Association    |
	| Altiris      | Used on device |
	And User add "Boot Up Date" filter where type is "Equals" with added column and following value:
	| Values      |
	| 07 Dec 2017 |
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11741 @DAS13001
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearAndFullDataIsDisplayedWhenAddingDifferentFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Application Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues          |
	| Red                     |
	| Blue                    |
	| Out Of Scope            |
	| Light Blue              |
	| Brown                   |
	| Amber                   |
	| Really Extremely Orange |
	| Purple                  |
	| Green                   |
	| Grey                    |
	| None                    |
	When User Add And "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then full list content is displayed to the user
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11760 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWithoutTheFilterValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	And User enters "testText" text in Search field at selected Filter
	And User clicks Add button for input filter value
	And User select "Not entitled to device" Association for Application filter with Lookup value
	When User clicks 'UPDATE' button 
	Then "Application whose Name is testText not entitled to device" is displayed in added filter info
	When User create dynamic list with "TestListF58LY5" name on "Devices" page
	Then Edit List menu is not displayed
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Application " filter
	Then Search field in selected Filter is empty

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11838 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatchingTheCaption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Target App Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues     |
	| <SelectedCheckbox> |
	Then '<ColorName>' content is displayed in all 'ComputerSc: Target App Readiness' column
	Then '<SelectedCheckbox>' path is displayed in the 'ComputerSc: Target App Readiness' column

Examples:
	| SelectedCheckbox        | ColorName               |
	| Red                     | RED                     |
	| Blue                    | BLUE                    |
	| Light Blue              | LIGHT BLUE              |
	| Brown                   | BROWN                   |
	| Amber                   | AMBER                   |
	| Really Extremely Orange | REALLY EXTREMELY ORANGE |
	| Purple                  | PURPLE                  |
	| Green                   | GREEN                   |
	| Grey                    | GREY                    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11838
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheApplicationRationalisationItemIsMatchingTheCaption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Application Rationalisation" filter where type is "Equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <SelectedCheckbox> |
	Then '<SelectedCheckbox>' content is displayed in all 'ComputerSc: Application Rationalisation' column
	Then '<SelectedCheckbox>' path is displayed in the 'ComputerSc: Application Rationalisation' column

Examples:
	| SelectedCheckbox |
	| FORWARD PATH     |
	| KEEP             |
	| RETIRE           |
	| UNCATEGORISED    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12076 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhenDoesnotequalNoneForWindows7MiCategoryFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	Then Content is empty in the column
	| ColumnName           |
	| Windows7Mi: Category |
	When User add "Windows7Mi: Category" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	When User clicks on 'Windows7Mi: Category' column header
	Then Content is present in the newly added column
	| ColumnName           |
	| Windows7Mi: Category |

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12537 @DAS12579
Scenario Outline: EvergreenJnr_AllLists_CheckThatContentIsDisplayedInTheAddedColumnAfterApplyingIsNotNoneOperator
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	Then Content is present in the newly added column
	| ColumnName         |
	| <NewlyAddedColumn> |

Examples:
	| ListName  | FilterName           | NewlyAddedColumn     |
	| Mailboxes | EmailMigra: Category | EmailMigra: Category |
	| Devices   | Windows7Mi: Category | Windows7Mi: Category |

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12543 @DAS13001 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatEditFilterElementsBlockIsDisplayedCorrectlyOnTheFiltersPanel
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Light Blue     |
	Then Content is present in the newly added column
	| ColumnName            |
	| EmailMigra: Readiness |
	When User create dynamic list with "TestListF544Y5" name on "Mailboxes" page
	Then "TestListF544Y5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
	| Values     |
	| Light Blue |
	When User click Edit button for "EmailMigra: Readiness" filter
	Then "Add column" checkbox is checked
	And "EmailMigra: Readiness" filter is displayed in the Filters panel

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12636 @DAS12481
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



@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedAfterApplyingAStaticListWithApplicationSavedListFilter
	When User add following columns using URL to the "Applications" page:
	| ColumnName              |
	| Device Count (Entitled) |
	Then Content is present in the newly added column
	| ColumnName              |
	| Device Count (Entitled) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                     |
	| Exemples de conception de bases de données |
	When User clicks on 'Device Count (Entitled)' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList6581" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6581 | Entitled to device |
	Then "38" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingAStaticListAsTheFilteredApplicationSavedList
	When User add following columns using URL to the "Applications" page:
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	Then Content is present in the newly added column
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                    |
	| MKS Source Integrity 7.3d |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList6778" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6778 | Entitled to device |
	Then "123" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynamicListAsTheFilteredApplicationSavedList
	When User add following columns using URL to the "Applications" page:
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	Then Content is present in the newly added column
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                    |
	| MKS Source Integrity 7.3d |
	When User clicks the Filters button
	And User create dynamic list with "DynamicList4116" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association        |
	| DynamicList4116 | Entitled to device |
	Then "123" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12875
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Surname" filter where type is "Equals" with following Value and Association:
	| Values       | Association     |
	| Cotuand      | Entitled to app |
	| Courtemanche |                 |
	When User click Edit button for "User " filter
	Then There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FiltersFeature @FiltersFunctionality @DAS12167 @DAS12056 @Cleanup
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
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	And There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12181 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList8546" name
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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12181 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorIsDisplayedAfterAddingFewAdvancedFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Does not equal" with following Lookup Value and Association:
	| SelectedValues              | Association  |
	| DWLABS\$231000-3AC04R8AR431 | Has used app |
	When User add "User Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values     | Association     |
	| 1 Feb 2018 | Entitled to app |
	When User add "User SID" filter where type is "Begins with" with following Value and Association:
	| Values | Association                         |
	| 555    | Owns a device which app was used on |
	Then "247" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12181 @DAS11561 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorIsDisplayedAfterAddingFewAdvancedFiltersAndFewStandardFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Compliance" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association  |
	| Red                | Has used app |
	When User add "User Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association     |
	| TRUE               | Entitled to app |
	When User Add And "User Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values      | Association     |
	| 15 Feb 2016 | Entitled to app |
	When User add "Application" filter where type is "Contains" with added column and following value:
	| Values |
	| Office |
	When User add "Vendor" filter where type is "Contains" with added column and following value:
	| Values    |
	| Microsoft |
	Then "1,514" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12827 @DAS12812
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserLastLogonDateFilterWorksCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 30 Apr 2018 | Has used app |
	Then message 'No applications found' is displayed to the user
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12058 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupCurrentStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Group (Current State)" filter where type is "Equal" without added column and "Parkfield Office" Lookup option
	And User click Edit button for "Windows7Mi: Group (Current State)" filter
	And User enters "Administration" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then "34" rows are displayed in the agGrid
	When User create dynamic list with "Project Group (Current State)" name on "Applications" page
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FORWARD PATH       |
	Then "1" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| RETIRE             |
	Then "4" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "8" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	Then "21" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12058 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Group (Target State)" filter where type is "Equal" without added column and "Parkfield Office" Lookup option
	And User click Edit button for "Windows7Mi: Group (Target State)" filter
	And User enters "Administration" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then "29" rows are displayed in the agGrid
	When User create dynamic list with "Project Group (Target State)" name on "Applications" page
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "9" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	Then "20" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| RETIRE			 |
	Then message 'No applications found' is displayed to the user
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FORWARD PATH		 |
	Then message 'No applications found' is displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12200
Scenario: EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association  |
	| FR\APB5713645  | Has used app |
	Then "1" rows are displayed in the agGrid
	When User click Edit button for "User" filter
	When User is deselect "Has used app" Association for Application filter with Lookup value
	When User select "Has not used app" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "2,222" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                                                      | SelectedCheckboxes   | Rows   |
	| Windows7Mi: Category                                            | None                 | 17,248 |
	| Windows7Mi: Migration \ Values but no RAG                       | Three                | 1      |
	| Windows7Mi: Portal Self Service \ SS Application List Completed | Not Applicable       | 5,159  |
	| MigrationP: Category                                            | None                 | 17,274 |
	| Babel(Engl: Path                                                | Machines             | 62     |
	| ComputerSc: Path                                                | Request Type A       | 132    |
	| MigrationP: Path                                                | [Default (Computer)] | 41     |
	| UserSchedu: Path                                                | Request Type A       | 60     |
	
@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
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
	| Barry'sUse: Category                                             | None               | 41,339 |
	| Havoc(BigD: Path                                                 | [Default (User)]   | 7,578  |
	| UserSchedu: Group Stage \ Group User Default Request Type        | Not Applicable     | 679    |
	| ComputerSc: Group Stage \ Group User Default Request Type        | Not Applicable     | 1,809  |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid
	
Examples:
	| FilterName                                           | SelectedCheckboxes | Rows  |
	| Windows7Mi: Category                                 | A Star Packages    | 3     |
	| Windows7Mi: Application Information \ Technical Test | Started            | 4     |
	| EmailMigra: Category                                 | None               | 2,223 |
	| UserSchedu: Category                                 | None               | 2,223 |
	| Babel(Engl: Path                                     | Tools              | 302   |
	| EmailMigra: Path                                     | Public Folder      | 49    |
	| UserSchedu: Path                                     | Request Type A     | 47    |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13392
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

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_MailboxesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnMailboxesPage
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples:
	| FilterName           | SelectedCheckboxes     | Rows |
	| EmailMigra: Category | Mailbox Category A     | 6    |
	| EmailMigra: Path     | Personal Mailbox - VIP | 6    |

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseDepartmentFilter
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

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12522
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedAfterApplyingGBFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values   |
	| <Values> |
	Then "<RowsCount>" rows are displayed in the agGrid
	And There are no errors in the browser console

Examples: 
	| FilterName                   | Values | RowsCount |
	| Memory (GB)                  | 20.48  | 2         |
	| HDD Total Size (GB)          | 152.77 | 2         |
	| Target Drive Free Space (GB) | 995.54 | 1         |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12855
Scenario: EvergreenJnr_ApplicationsList_CheckThatDataIsDisplayedCorrectlyForAdvancedUserFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Does not equal" with following Lookup Value and Association:
	| SelectedValues | Association                         |
	| FR\RZM6552051  | Owns a device which app was used on |
	Then "100" rows are displayed in the agGrid
	Then table content is present

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12807
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationFilterWorksCorrectlyForDifferentAssociationTypes
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "Application" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association         |
	| ACD Display 3.4 | Installed on device |
	Then "944" rows are displayed in the agGrid
	When User click Edit button for "Application" filter
	And User is deselect "Installed on device" Association for Application filter with Lookup value
	And User select "Not installed on device" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "16,335" rows are displayed in the agGrid
	When User have reset all filters
	And User add Advanced "Application" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association    |
	| ACD Display 3.4 | Used on device |
	Then message 'No devices found' is displayed to the user
	When User click Edit button for "Application" filter
	And User is deselect "Used on device" Association for Application filter with Lookup value
	And User select "Not used on device" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "17,279" rows are displayed in the agGrid

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12804 @Cleanup
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
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList8543" name
	Then "StaticList8543" list is displayed to user
	And Edit List menu is not displayed
	And URL contains 'evergreen/#/users?$listid='

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13104 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatAddAndButtonIsDisplayedWhenAddingTwoOrMoreFiltersUsingTheSameFieldAndClearingOneOfTheFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance is Red" is displayed in added filter info
	When User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	Then "Compliance is Green" is displayed in added filter info
	When User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance is Unknown" is displayed in added filter info
	Then Add And button is displayed on the Filter panel
	When User have removed "Compliance" filter
	Then Add And button is displayed on the Filter panel

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13414 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatApplicationListWhichIncludeADateBasedAdvancedFilterAreSavedAndNotOpenedInEditMode
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 12 Sep 2018 | Has used app |
	Then "User whose Last Logon Date" filter is added to the list
	When User create dynamic list with "DAS13414" name on "Applications" page
	Then "DAS13414" list is displayed to user
	And URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed
	When User navigates to the "All Applications" list
	And User navigates to the "DAS13414" list
	Then URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13384 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatEditButtonIsDisplayedOnFiltersSectionIfEditFormOpenWhenYouSaveList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "MigrationP: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Light Blue     |
	| Out Of Scope   |
	| Blue           |
	Then "MigrationP: Readiness" filter is added to the list
	When User click Edit button for "MigrationP: Readiness" filter
	And User creates 'DynamicList13384' dynamic list
	Then "DynamicList13384" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Edit button is displayed correctly for "MigrationP: Readiness" filter

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13588
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsingUserLDAPFilterDoesNotProduceServerError
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "badpasswordtime" filter where type is "Equals" with following Value and Association:
	| Values | Association     |
	| test   | Has used app    |
	|        | Entitled to app |
	Then There are no errors in the browser console
	And 'All Applications' list should be displayed to the user
	And message 'No applications found' is displayed to the user 

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13331
Scenario: EvergreenJnr_DevicesList_ChecksThatUsedByDevicesOwnerApplicationToDeviceAssociationReturnCorrectData
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" with following Number and Association:
	| Number | Association            |
	| 86     | Used by device's owner |
	Then "Application whose Key" filter is added to the list
	And "Application whose Key is 86 used by device's owner" is displayed in added filter info
	And "154" rows are displayed in the agGrid

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS9820 @DAS13296
Scenario Outline: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxFiltersCanBeUsedOnUsersPage
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values   |
	| <Values> |
	Then "<RowsCount>" rows are displayed in the agGrid
	And There are no errors in the browser console

Examples: 
	| FilterName             | Values | RowsCount        |
	| Device Count           | 6      | 1                |
	| Group Count            | 13     | 32               |
	| Mailbox Count (Access) | 3      | 6                |
	#| Mailbox Count (Owned)  | 4      | to_be_determined |

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13145
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
	Then "1 shown" results are displayed in the Filter panel
	And "ACT Data Collection Packages (1104)" value is displayed for selected Lookup Filter

Examples:
	| PageName |
	| Devices  |
	#| Users    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13473 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatIfListWithAnAdvancedUserDescriptionIsEmptyFilterIsSavedAndOpenedNotInEditMode
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User Description" filter where type is "Empty" with following Lookup Value and Association:
	| SelectedValues | Association     |
	|                | Has used app    |
	|                | Entitled to app |
	Then "User whose Description" filter is added to the list
	And "User whose Description is empty has used app; or entitled to app" is displayed in added filter info
	When User creates 'DAS13473' dynamic list
	Then "DAS13473" list is displayed to user
	And "113" rows are displayed in the agGrid
	And URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed
	When User navigates to the "All Applications" list
	And User navigates to the "DAS13473" list
	Then "113" rows are displayed in the agGrid
	Then URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13377
Scenario: EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTargetAppFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Barry'sUse: Target App" filter where type is "Equals" with added column and Lookup option
	| SelectedValues         |
	| Python 2.2a4 (SMS_GEN) |
	Then "Barry'sUse: Target App" filter is added to the list
	And "Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)" is displayed in added filter info
	When User click content from "Application" column
	Then User click back button in the browser
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)" is displayed in added filter info

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13381 @DAS14603
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
	| Devices      | Hostname      | Babel(Engl: Category                     | None           | 00KLL9S8NRF0X6                             | Babel(Engl: Category is None                               |
	| Devices      | Hostname      | Babel(Engl: In Scope                     | FALSE          | 00I0COBFWHOF27                             | Babel(Engl: In Scope is False                              |
	| Devices      | Hostname      | ComputerSc: Path                         | Request Type A | 47NK3ATE5DM2HD                             | ComputerSc: Path is Request Type A                         |
	| Applications | Application   | Havoc(BigD: Hide from End Users          | UNKNOWN        | Adobe Flash Player 10 ActiveX (10.0.12.36) | Havoc(BigD: Hide from End Users is Unknown                 |
	| Applications | Application   | MigrationP: Core Application             | FALSE          | Adobe Download Manager 2.0 (Remove Only)   | MigrationP: Core Application is False                      |
	| Mailboxes    | Email Address | EmailMigra: Mobile Devices \ Device Type | Not Identified | 238BAE24882E48BFA9F@bclabs.local           | EmailMigra: Mobile Devices \ Device Type is Not Identified |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12214
Scenario: EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativeAssociation
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "After" with following Data and Association:
	| Values     | Association                             |
	| 1 May 2011 | Has used app                            |
	|            | Entitled to app                         |
	|            | Owns a device which app was used on     |
	|            | Owns a device which app is entitled to  |
	|            | Owns a device which app is installed on |
	Then "1,206" rows are displayed in the agGrid
	When User click Edit button for " Last Logon Date" filter
	Then only positive Associations is displayed
	When User is deselect "Has used app" in Association
	And User is deselect "Entitled to app" in Association
	And User is deselect "Owns a device which app was used on" in Association
	And User is deselect "Owns a device which app is entitled to" in Association
	And User is deselect "Owns a device which app is installed on" in Association
	And User select "Has not used app" in Association
	Then only negative Associations is displayed
	When User select "Not entitled to app" in Association
	And User select "Does not own a device which app was used on" in Association
	And User select "Does not own a device which app is entitled to" in Association
	And User select "Does not own a device which app is installed on" in Association
	And User clicks Save filter button
	Then "2,223" rows are displayed in the agGrid
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Begins with" with following Value and Association:
	| Values | Association    |
	| Adobe  | Used on device |
	When User click Edit button for "Application " filter
	Then only positive Associations is displayed
	When User is deselect "Used on device" in Association
	And User select "Not used on device" in Association
	Then only negative Associations is displayed

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12211
Scenario: EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValues
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Does not equal" with following Data and Association:
	| Values      | Association  |
	| 26 Apr 2018 | Has used app |
	Then "100" rows are displayed in the agGrid
	When User click Edit button for " Last Logon Date" filter
	Then User changes filter type to "Equals"
	Then message 'No applications found' is displayed to the user 

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12216 @DAS12212
Scenario: EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValuesForUserDescription
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Does not equal" with following Value and Association:
	| Values                                                                                                                                                                                                                                                                                                                                                          | Association  |
	| Sed quad ut novum vobis regit, et pladior venit.  Tam quo, et nomen transit. Pro linguens imaginator pars fecit.  Et quad                                                                                                                                                                                                                                       | Has used app |
	| Tam quo, et pladior venit.  Tam quo, et quis gravis delerium.  Versus esset in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum.                                                                                                                                                                                                 | Has used app |
	| Quad rarendum habitatio quoque plorum in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum.  Multum gravum et nomen transit. Multum gravum et pladior venit.  Tam quo, et bono quorum glavans e funem.  Quad rarendum habitatio quoque plorum in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum. | Has used app |
	| Longam, e gravis et quis gravis delerium.  Versus esset in volcans essit.  Pro linguens non apparens vantis. Sed quad ut novum eggredior.  Longam, e gravis delerium.  Versus esset in volcans essit.  Pro linguens non quo linguens imaginator pars fecit.  Et quad fecit, non apparens vantis. Sed                                                            | Has used app |
	| Sed quad fecit, non quo linguens non trepicandor si quad fecit, non trepicandor si nomen transit. Id eudis quo plorum in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum.  Multum gravum et pladior venit.  Tam quo, et quis gravis et nomen transit. Sed quad ut novum eggredior.  Longam, e gravis et bono                    | Has used app |
	Then "User whose Description" filter is added to the list
	And "100" rows are displayed in the agGrid
	And There are no errors in the browser console
	When User click Edit button for "User " filter
	Then User changes filter type to "Equals"
	And "19" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS10020
Scenario: EvergreenJnr_DevicesList_CheckDeviceOwnerLDAPColumnsAndFilters
	When User add following columns using URL to the "Devices" page:
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Display Name" filter
	When User select "Empty" Operator value
	And User clicks Save filter button
	Then "460" rows are displayed in the agGrid
	Then Content is empty in the column
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |
	When User clicks on 'Owner title' column header
	Then Content is empty in the column
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14629 @DAS14664 @DAS14669
Scenario: EvergreenJnr_UsersList_PrimaryDeviceChipsCanBeRemoved
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Primary Device" filter
	#Equals Operator value
	When User select "Equals" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not equal Operator value
	When User select "Does not equal" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Contains Operator value
	When User select "Contains" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not contain Operator value
	When User select "Does not contain" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Begins with Operator value
	When User select "Begins with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not begin with Operator value
	When User select "Does not begin with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Ends with Operator value
	When User select "Ends with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not end with Operator value
	When User select "Does not end with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_DevicesList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: Windows7Mi        | 12     |
	| Project Owner: Windows7Mi  | 12     |
	| Project Tasks: Windows7Mi  | 91     |
	| Project Stages: Windows7Mi | 7      |
	| Project: UserEvergr        | 11     |
	| Project Owner: UserEvergr  | 12     |
	| Project Tasks: UserEvergr  | 12     |
	| Project Stages: UserEvergr | 1      |
	And Category is not displayed in the Filter panel
	| Category                   |
	| Project: EmailMigra        |
	| Project Tasks: EmailMigra  |
	| Project Stages: EmailMigra |

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_UsersList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: Windows7Mi        | 11     |
	| Project Tasks: Windows7Mi  | 79     |
	| Project Stages: Windows7Mi | 6      |
	| Project: UserEvergr        | 12     |
	| Project Tasks: UserEvergr  | 26     |
	| Project Stages: UserEvergr | 2      |
	| Project: EmailMigra        | 11     |
	| Project Tasks: EmailMigra  | 9      |
	| Project Stages: EmailMigra | 3      |

@Evergreen @Applicatios @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_ApplicationsList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: Windows7Mi        | 23     |
	#| Project User: Windows7Mi   | 12     |
	#| Project Device: Windows7Mi | 13     |
	| Project Tasks: Windows7Mi  | 24     |
	| Project Stages: Windows7Mi | 2      |
	| Project: UserEvergr        | 23     |
	#| Project User: UserEvergr   | 12     |
	#| Project Device: UserEvergr | 13     |
	| Project Tasks: UserEvergr  | 14     |
	| Project Stages: UserEvergr  | 1      |
	| Project: EmailMigra        | 23     |
	#| Project User: EmailMigra   | 12     |
	| Project Tasks: EmailMigra  | 5      |
	| Project Stages: EmailMigra | 1      |

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_MailboxesList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: EmailMigra        | 11     |
	| Project Tasks: EmailMigra  | 54     |
	| Project Stages: EmailMigra | 6      |
	| Project: MailboxEve        | 11     |
	| Project Tasks: MailboxEve  | 15     |
	And Category is not displayed in the Filter panel
	| Category                   |
	| Project: Windows7Mi        |
	| Project Tasks: Windows7Mi  |
	| Project Stages: Windows7Mi |
	| Project: UserEvergr        |
	| Project Tasks: UserEvergr  |
	| Project Stages:UserEvergr  |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersFunctionality @DAS14524
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
	| Devices      | Owner Organizational Unit | Equals      | Users.Cardiff.UK.local | 1,458  |
	| Devices      | Owner Organizational Unit | Contains    | Users                  | 11,665 |
	| Users        | Organizational Unit       | Begins with | Users                  | 23,728 |
	| Mailboxes    | Owner Organizational Unit | Not Empty   |                        | 14,747 |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersFunctionality @DAS14524 @DAS15223
Scenario: EvergreenJnr_ApplicationsList_CheckRowsCountedForOwnerOrganizationalUnitFilterWithEmptyValue
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Organizational Unit" filter where type is "Empty" with following Value and Association:
	| Values | Association                             |
	|        | Has used app                            |
	|        | Entitled to app                         |
	|        | Owns a device which app was used on     |
	|        | Owns a device which app is entitled to  |
	|        | Owns a device which app is installed on |
	Then "User whose Organizational Unit" filter is added to the list
	And "215" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_DevicesList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: 1803       | 1      |
	| Project Rings: Babel(Engl | 1      |
	| Project Rings: ComputerSc | 1      |
	| Project Rings: DeviceSche | 1      |
	| Project Rings: Havoc(BigD | 1      |
	| Project Rings: ICSP       | 1      |
	| Project Rings: prK        | 1      |
	| Project Rings: Windows101 | 1      |
	| Project Rings: Windows102 | 1      |
	| Project Rings: Windows10T | 1      |
	| Project Rings: Windows10U | 1      |
	| Project Rings: Windows7Mi | 1      |

@Evergreen @Users @Evergreen_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_UsersList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: Barry'sUse | 1      |
	| Project Rings: MigrationP | 1      |
	| Project Rings: UserEvergr | 1      |
	| Project Rings: UserSched2 | 1      |
	| Project Rings: UserSchedu | 1      |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_MailboxesList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: EmailMigra | 1      |
	| Project Rings: MailboxEve | 1      |

@Evergreen @Applications @Evergreen_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_ApplicationsList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category            | Number |

@Evergreen @Users @Evergreen_FiltersFeature @FilterFunctionality @DAS15246 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUrlOfSavedListHasNoEmptyParameters
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And user select "Windows7Mi: Communication \ Send Applications List - User Object Task (Team)" filter
	And User clicks in search field in the Filter block
	And User enters "Unassigned" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	When User create dynamic list with "TestList15246" name on "Users" page
	Then "TestList15246" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User navigates to the "TestList15246" list
	Then "TestList15246" list is displayed to user
	And URL contains 'evergreen/#/users?$listid='
	And URL contains only "listid" filter

@Evergreen @Users @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_UsersList_CheckSlotsSortOrderForUsersList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
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

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_DevicesList_CheckSlotsSortOrderForDevicesList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "1803: Pre-Migration \ Scheduled Date (Slot)" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Laptop         |
	When User clicks on '1803: Pre-Migration \ Scheduled Date (Slot)' column header
	Then Content in the '1803: Pre-Migration \ Scheduled Date (Slot)' column is equal to
	| Content                    |
	| Birmingham Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| London - City Morning      |
	| London - Southbank Morning |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	When User clicks on '1803: Pre-Migration \ Scheduled Date (Slot)' column header
	Then Content in the '1803: Pre-Migration \ Scheduled Date (Slot)' column is equal to
	| Content                    |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	| London - Southbank Morning |
	| London - City Morning      |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Birmingham Morning         |

@Evergreen @Applications @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_ApplicationsList_CheckSlotsSortOrderForApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User clicks on 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column is equal to
	| Content            |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 2 |
	When User clicks on 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column is equal to
	| Content            |
	| Application Slot 2 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_MailboxesList_CheckSlotsSortOrderForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "MailboxEve: 1 \ Scheduled - mailbox (Slot)" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User Add And "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values                    |
	| Spruill, Shea             |
	| Bandyopadhyay, Sudipta    |
	| Balanceactiv, Info        |
	When User clicks on 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column header
	Then Content in the 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column is equal to
	| Content                                            |
	| CA -Mailbox-Nov 1, 2018-Nov 10, 2018               |
	| CA -Mailbox-Nov 11, 2018-Nov 30, 2018              |
	| TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\RT=A\T=Admin |
	When User clicks on 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column header
	Then Content in the 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column is equal to
	| Content                                            |
	| TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\RT=A\T=Admin |
	| CA -Mailbox-Nov 11, 2018-Nov 30, 2018              |
	| CA -Mailbox-Nov 1, 2018-Nov 10, 2018               |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16394 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilterForTheListBasedOnSavedListWithErrors
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList                        | Association |
	| Device List (Complex) - BROKEN LIST |             |
	When User creates 'List_DAS16394' dynamic list
	Then "List_DAS16394" list is displayed to user
	Then Create button is disabled on the Base Dashboard Page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Device" filter
	Then Create button is disabled on the Base Dashboard Page

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15807
Scenario: EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Language" filter where type is "Equals" with added column and Lookup option
	| SelectedValues  |
	| English         |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16071
Scenario Outline: EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues       |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName         | SelectedCheckboxes | Rows   |
	| Windows7Mi: Status | Not Onboarded      | 12,100 |
	| Windows7Mi: Status | Offboarded         | 20     |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17411 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForList
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Name |
	Then ColumnName is added to the list
	| ColumnName       |
	| Windows7Mi: Name |
	When User clicks the Filters button
	And User add "Windows7Mi: Name" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	And User Add And "Windows7Mi: Name" filter where type is "Contains" with added column and following value:
    | Values |
    | 00     |
	And User Add And "Windows7Mi: Name" filter where type is "Does not contain" with added column and following value:
    | Values |
    | fpi    |
	And User Add And "Windows7Mi: Name" filter where type is "Begins with" with added column and following value:
    | Values |
    | 2      |
	Then "4" rows are displayed in the agGrid

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17411
Scenario Outline: EvergreenJnr_Lists_CheckThatProjectNameIsNotDisplayedForNotDevicesList
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Columns button
	And User enters "Windows7Mi: Name" text in Search field at Columns Panel
	Then Category with counter is displayed on Columns panel
	| Category            | Number |

	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Windows7Mi: Name" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category            | Number |

Examples: 
	| ListName		| 
	| Applications	| 
	| Mailboxes		| 
	| Users			|

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16178
Scenario: EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounter
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Windows7Mi: Owner Username" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	And User Add And "Windows7Mi: Owner Display Name" filter where type is "Does not begin with" with added column and following value:
    | Values |
    | to     |
	And User Add And "Windows7Mi: Owner Username" filter where type is "Contains" with added column and following value:
    | Values |
    | 1    |
	And User Add And "Windows7Mi: Owner Display Name" filter where type is "Does not end with" with added column and following value:
    | Values |
    | 9      |
	Then "2,471" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItems
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Support            |
	| Technology         |
	And User Add And "Department Level 2" filter where type is "Equals" with added column and Lookup option
	| SelectedValues          |
	| Facilities              |
	| Application Development |
	And User Add And "Department Level 3" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Admin              |
	| Support            |
	| Helpdesk           |
	Then "1,699" rows are displayed in the agGrid

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_UsersList_CheckDepartmentLevelFilterItems
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Sales            |
	| Finance         |
	And User Add And "Department Level 2" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Marketing      |
	And User Add And "Department Level 3" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Admin              |
	| Support            |
	| Helpdesk           |
	Then "1,800" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_ApplicationsList_CheckDepartmentLevelFilterItems
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Department Level 1" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Sales              | Used on device      |
	| Support            | Entitled to device  |
	| Technology         | Installed on device |
	Then "854" rows are displayed in the agGrid

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_MailboxesList_CheckDepartmentLevelFilterItems
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Support            |
	| Technology         |
	Then "6,707" rows are displayed in the agGrid

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16912
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplinceNoneOptionIsTranslatedInFilter
	When User clicks '<ListName>' on the left-hand menu
	And User language is changed to "Deutsch" via API
	And User clicks refresh button in the browser
	And User clicks the Filters button
	And user select "<TranslatedColumnName>" filter
	Then Following checkboxes are available for current opened filter:
	| checkboxes |
	| Unbekannt  |
	| Rot        |
	| Bernstein  |
	| Grün       |
	| Keine      |

Examples: 
	| ListName     | TranslatedColumnName        |
	| Devices      | Anwendungskonformität       |
	| Users        | Geräteanwendungskonformität |
	| Applications | Konformität                 |
	| Mailboxes    | Konformität des Inhabers    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	When User add "Device CPU Architecture" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device CPU Speed (GHz)" filter where type is "Does not equal" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Format" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device HDD Total Size (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "2,128" rows are displayed in the agGrid
	
@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082 @DAS17717
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device IP Address" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device IPv6 Address" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Manufacturer" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Memory (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Model" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "1,032" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartIII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device TPM Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| FALSE              | Used on device      |
	| TRUE               | Entitled to device  |
	| UNKNOWN            | Installed on device |
	And User Add And "Device TPM Version" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Target Drive Free Space (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association         |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Type" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Data Centre    | Used on device      |
	| Desktop        | Entitled to device  |
	| Laptop         | Installed on device |
	| Mobile         |                     |
	| Other          |                     |
	| Virtual        |                     |
	Then "361" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device OS Architecture" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Empty              | Used on device      |
	| 32                 | Entitled to device  |
	| 64                 | Installed on device |
	And User Add And "Device OS Branch" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association             |
	| Current Branch     | Not entitled to device  |
	|                    | Not installed on device |
	|                    | Not used on device      |
	And User Add And "Device OS Full Name" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Android 4.3    | Used on device      |
	| Empty          | Entitled to device  |
	| Android 4.4    | Installed on device |
	| Android 5.0    |                     |
	| Android 5.1    |                     |
	Then "4" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device OS Servicing State" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Empty              | Used on device      |
	|                    | Entitled to device  |
	|                    | Installed on device |
	And User Add And "Device OS Version Number" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| 10.0           | Used on device      |
	| 10.0.10240     | Entitled to device  |
	| Empty          | Installed on device |
	| 10.0.15063     |                     |
	| 10.0.14393     |                     |
	And User Add And "Device Service Pack or Build" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association         |
	| Service Pack 1  | Used on device      |
	| Empty           | Entitled to device  |
	| No Service Pack | Installed on device |
	| Service Pack 2  |                     |
	| Service Pack 3  |                     |
	Then "170" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	When User add "Device Owner Building" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Owner City" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Belfast        | Used on device      |
	| Los Angeles    | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Compliance" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Red                | Used on device      |
	|                    | Entitled to device  |
	|                    | Installed on device |
	And User Add And "Device Owner Country" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association             |
	| Empty          | Not installed on device |
	|                | Not entitled to device  |
	|                | Not used on device      |
	Then "846" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Department" filter where type is "Equals" with selected Expanded Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Finance            | Used on device      |
	| Sales              | Entitled to device  |
	| Support            | Installed on device |
	| Technology         |                     |
	And User Add And "Device Owner Description" filter where type is "Does not begin with" with following Value and Association:
	| Values | Association         |
	| pro       | Not installed on device     |
	Then "854" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartIII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Display Name" filter where type is "Contains" with following Value and Association:
	| Values  | Association         |
	| Aceline | Entitled to device  |
	|         | Installed on device |
	And User Add And "Device Owner Domain" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Owner Email Address" filter where type is "Ends with" with following Value and Association:
	| Values          | Association         |
	| demo.juriba.com | Entitled to device  |
	|                 | Installed on device |
	And User Add And "Device Owner Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| TRUE               | Entitled to device  |
	|                    | Installed on device |
	Then "23" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartIV
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Floor" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Empty          | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Given Name" filter where type is "Does not end with" with following Value and Association:
	| Values | Association         |
	| sdsds  | Entitled to device  |
	|        | Installed on device |
	Then "1,139" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartV
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Home Directory" filter where type is "Begins with" with following Value and Association:
	| Values         | Association         |
	| \\\\fileserver | Used on device      |
	|                | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Home Drive" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association        |
	| H:                 | Entitled to device |
	And User Add And "Device Owner Username" filter where type is "Does not equal" with following Value and Association:
	| Values     | Association             |
	| ZZW1565756 | Not installed on device |
	When User Add And "Device Owner Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values     | Association        |
	| 8 Aug 2019 | Entitled to device |
	And User Add And "Device Owner Key" filter where type is "Greater than" with following Number and Association:
	| Number | Association        |
	| 4      | Entitled to device |
	And User Add And "Device Owner Region" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| Empty          | Entitled to device |
	| US-E           |                    |
	Then "213" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartVI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Telephone" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User add "Device Owner Zip Code" filter where type is "Begins with" with following Value and Association:
	| Values | Association         |
	| EC1    | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "18" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17557
Scenario: EvergreenJnr_DevicesList_CheckThatSerialNumberToETLComputerAdded
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Serial Number" filter where type is "Not empty" with added column and following value:
	| Values        |
	And User Add And "Serial Number" filter where type is "Does not equal" with added column and following value:
	| Values        |
	| CET2826853682 |
	And User Add And "Serial Number" filter where type is "Contains" with added column and following value:
	| Values |
	| 034    |
	And User Add And "Serial Number" filter where type is "Does not contain" with added column and following value:
	| Values |
	| 9889   |
	And User Add And "Serial Number" filter where type is "Does not begin with" with added column and following value:
	| Values |
	| davi   |
	And User Add And "Serial Number" filter where type is "Ends with" with added column and following value:
	| Values |
	| 4      |
	| 5      |
	| 8      |
	| 6      |
	And User Add And "Serial Number" filter where type is "Does not end with" with added column and following value:
	| Values |
	| 436    |
	Then "54" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17557
Scenario: EvergreenJnr_DevicesList_CheckThatNo500ErrorOnApplicationPageAfterUpdatingTheAdvancedFilterWithTheEmptyValueOfTheEqualsDoesNotEqualsField
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Virtual Machine Host" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	|                | Used on device      |
	|                | Entitled to device  |
	|                | Installed on device |
	Then 'UPDATE' button is disabled

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17715 @Cleanup
Scenario: EvergreenJnr_DevicedList_CheckCustomFieldsUsingInFilterAndProjectCreation
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "ComputerCustomField" filter where type is "Equals" with added column and following value:
	| Values      |
	| 0.606355351 |
	Then "1" rows are displayed in the agGrid
	And There are no errors in the browser console
	When User create dynamic list with "TestList_DAS17715" name on "Devices" page
	Then "TestList_DAS17715" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Projects' header is displayed to user
	When User enters 'TestProjectFor17715' text to 'Project Name' textbox
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	And There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17715 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckCustomFieldsUsingInFilterAndPivotsCreation
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User add "Application Owner" filter where type is "Not empty" with following Value and Association:
	| Values | Association                        |
	|        | Entitled to a device owned by user |
	#counter can be updated
	Then "918" rows are displayed in the agGrid
	And There are no errors in the browser console
	When User create dynamic list with "TestList_DAS17715" name on "Users" page
	Then "TestList_DAS17715" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups    |
	| Display Name |
	And User selects the following Values on Pivot:
	| Values   |
	| Zip Code |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS17715_Pivot" name
	Then There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17715 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckCustomFieldsUsingInFilterAndWidgetCreation
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device ComputerCustomField" filter where type is "Not empty" with following Value and Association:
	| Values | Association        |
	|        | Entitled to device |
	#counter can be updated
	Then "842" rows are displayed in the agGrid
	And There are no errors in the browser console
	When User create dynamic list with "TestList_DAS17715" name on "Applications" page
	Then "TestList_DAS17715" list is displayed to user
	When Dashboard with 'Dashboard for DAS17715' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List              | Type       |
	| Card       | WidgetForDAS17715 | TestList_DAS17715 | First Cell |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOperatingSystemFilterWork
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Operating System" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| Other          | Entitled to device |
	Then "4" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17757
Scenario: EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectProperties
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "1803: Status" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Offboarded     |
	Then "4" rows are displayed in the agGrid
	Then Content in the '1803: Status' column is equal to
	| Content    |
	| Offboarded |
	| Offboarded |
	| Offboarded |
	| Offboarded |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18377 @DAS18621 @DAS18686
Scenario Outline: EvergreenJnr_DevicesList_CheckThatThereIsNoErrorAfterSavingListWithFilterEqualsRelative
	When User clicks '<List>' on the left-hand menu
	And User clicks the Filters button
	And User add "<Filter>" filter where type is "Equals (relative)" with added column and following value:
	| Values  |
	| <Value> |
	Then There are no errors in the browser console

Examples:
	| List         | Filter                               | Value                                       |
	| Devices      | 1803: Pre-Migration \ Scheduled Date | 1                                           |
	| Applications | Owner Last Logon Date                | 1                                           |
	| Devices      | Owner Last Logon Date                | 2.37457468568568568568658464554575547547547 |

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS18140
Scenario: EvergreenJnr_DevicesList_CheckCancelFilterButtonWorkIfSameFiltersWereApplied
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Display Name" filter where type is "Not Empty" with added column and Lookup option
	| SelectedValues |
	When User Add And "Display Name" filter where type is "Contains" with added column and following value:
	| Values |
	| a      |
	When User click Edit button for "Display Name" filter
	When User clicks 'CANCEL' button 
	Then There are no any expanded blocks in Filter panel

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18709
Scenario: EvergreenJnr_DevicesList_CheckDeviceOwnerComplianceFilterWork
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Owner Compliance" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	Then "16,819" rows are displayed in the agGrid
	When User have removed "Owner Compliance" filter
	And User add "Owner Compliance" filter where type is "Not empty" with added column and Lookup option
	| SelectedValues |
	Then "16,819" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @DAS18560 @Cleanup
Scenario: EvergreenJnr_CheckThatNoErrorMessageDisplayedAfterOpeningListWithFilterRelatedToDeletedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User create dynamic list with "ListToBeDeleted18560" name on "Devices" page
	Then "ListToBeDeleted18560" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" with following Lookup Value and Association:
    | SelectedValues       | Association    |
    | ListToBeDeleted18560 | Used on device |
	When User creates 'SecondList18560' dynamic list
	Then "SecondList18560" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User removes custom list with "ListToBeDeleted18560" name
	Then list with "ListToBeDeleted18560" name is removed
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "SecondList18560" list
	When User clicks the Filters button
	Then message 'This list could not be processed, it may refer to a list with errors' is displayed to the user

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

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersFunctionality @DAS19384
Scenario: EvergreenJnr_ApplicationsList_CheckzzMailboxAuOwnerInScopeFilterWork
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| zMailboxAu: Owner In Scope |
	Then Content is present in the newly added column
	| ColumnName                 |
	| zMailboxAu: Owner In Scope |
	Then "14,784" rows are displayed in the agGrid
	When User clicks on 'zMailboxAu: Owner In Scope' column header
	Then data in table is sorted by 'zMailboxAu: Owner In Scope' column in descending order
	When User clicks on 'zMailboxAu: Owner In Scope' column header
	Then data in table is sorted by 'zMailboxAu: Owner In Scope' column in ascending order
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "zMailboxAu: Owner In Scope" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| Empty              |
	Then "zMailboxAu: Owner In Scope" filter is added to the list
	Then "14,784" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19550
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorDisplayedWhenFilteringListBySavedList
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Owner (Saved List)" filter where type is "In list" with selected Checkboxes and following Association:
	| SelectedCheckboxes      | Association    |
	| Users with Device Count | Used on device |
	Then There are no errors in the browser console

@Evergreen @Devices @Evergreen_FiltersFeature @DAS19157 @Cleanup
Scenario: EvergreenJnr_CheckThatThereIsNoAbilityToUseListAsFilterOptionIfItHasReferenceFiltersForCurrentProjectAsProjectScopeList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "1803: In Scope" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | TRUE           |
	Then table content is present
	When User create dynamic list with "ListForDAS19157" name on "Devices" page
	Then "ListForDAS19157" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Device (Saved List)" filter
	Then 'ListForDAS19157' checkbox is not displayed

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19669
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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19669
Scenario: EvergreenJnr_Applications_CheckThatFilterStaysWorkingAfterAddingDepartmentFilter
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Owner Department" filter where type is "Equals" with following Tree List option and Association:
	| Value | Association    |
	| Empty | Used on device |
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	When User clicks the Filters button
	Then "Device Owner whose Department is Empty used on device" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19460
Scenario: EvergreenJnr_Devices_CheckThatCorrectOptionsAreDisplayedForOwnerStatusFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "1803: Owner Status" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes    |
    | Empty         |
    | Not Onboarded |
    | Onboarded     |
    | Offboarded    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19713
Scenario: EvergreenJnr_ApplicationsList_CheckThatErrorsDoNotAppearWhenAddingInvalidDateFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Boot Up Date" filter
	When User changes filter date to "13 Dec 2017"
	When User changes filter date to "R."
	When User select "Installed on device" in Association
	When User clicks 'ADD' button
	Then There are no errors in the browser console