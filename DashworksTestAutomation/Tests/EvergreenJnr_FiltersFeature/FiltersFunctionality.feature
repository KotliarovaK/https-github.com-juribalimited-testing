@retry:1
Feature: Functionality
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_FiltersFeature @FiltersFunctionality @DAS10612
Scenario: EvergreenJnr_UsersList_CheckThat500ErrorIsNotReturnedForFilterWithSpecialCharecter
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then "Display Name" filter is added to the list
	And "2" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersFunctionality @DAS10639 @DAS12207
Scenario: EvergreenJnr_ApplicationsList_Check500ErrorIsNotReturnedForBooleanFilterWithUnknownOption
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "1,156" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS10734 @DAS11507 @DAS12351 @DAS12512
Scenario: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxWorksCorrectly
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| A Star Packages     |
	Then "Windows7Mi: Category" filter is added to the list
	Then table data is filtered correctly
	When User clicks refresh button in the browser
	Then full list content is displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11166 @DAS11665 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredAfterGoingBackToTheListAgain
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	Then "Applications" list should be displayed to the user
	When User navigates to the "TestList5D30CF" list
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11042
Scenario Outline: EvergreenJnr_AllLists_CheckThatPrimaryColumnIsDisplayedAfterAddingAFilterWithColumn
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
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

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11042 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsCheckedAfterSavingFilterInANewList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList4A5CD6" name on "Devices" page
	Then "TestList4A5CD6" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList4A5CD6" list
	Then "TestList4A5CD6" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11042
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsCheckedAfterSavingAFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11042
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsUncheckedAfterSavingAFilterAndRemovingAColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is unchecked
	And "Add column" checkbox is not disabled

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS10977 @DAS11507 @DAS12221 @DAS12351
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserBackButtonForCheckboxesFilters
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| <FilterValue>      |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "<Text>" is displayed in added filter info

Examples: 
	| ListName     | FilterName                      | FilterValue    | RowsCount | ColumnName    | ObjectName                                | Text                                       |
	| Devices      | Babel(Engl: Category            | None           | 17,225    | Hostname      | 01COJATLYVAR7A6                           | Babel(Engl: Category is None               |
	| Devices      | Barry'sUse: In Scope            | FALSE          | 15,896    | Hostname      | 00BDM1JUR8IF419                           | Barry'sUse: In Scope is false              |
	| Devices      | ComputerSc: Request Type        | Request Type A | 132       | Hostname      | 46DIQRWG3BM6K9Z                           | ComputerSc: Request Type is Request Type A |
	| Applications | Havoc(BigD: Hide from End Users | UNKNOWN        | 1,156     | Application   | Microsoft Silverlight 2 SDK (2.0.31005.0) | Havoc(BigD: Hide from End Users is Unknown |
	| Applications | MigrationP: Core Application    | FALSE          | 220       | Application   | Quartus II Programmer 4.0                 | MigrationP: Core Application is false      |
	| Mailboxes    | EmailMigra: Device Type         | Not Identified | 729       | Email Address | alex.cristea@juriba.com                   | EmailMigra: Device Type is Not Identified  |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS10977 @DAS12351
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserBackButtonForLookupFilters
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
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
	| ListName     | FilterName                       | FilterValue            | RowsCount | ColumnName    | ObjectName              | Text                                             |
	| Applications | Barry'sUse: Target App           | Python 2.2a4 (SMS_GEN) | 1         | Application   | Python 2.2a4            | Barry'sUse: Target App is Python 2.2a4 (SMS_GEN) |
	| Mailboxes    | EmailMigra: BT/QMM Switch Status | Not Started            | 729       | Email Address | alex.cristea@juriba.com | EmailMigra: BT/QMM Switch Status is Not Started  |

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS10977
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserbackButtonForValuesFilters
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                    |
	| Microsoft Office 97, Professional Edition |
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info
	Then "5" rows are displayed in the agGrid
	When User perform search by "Microsoft Office 97, Professional Edition"
	And User click content from "Application" column
	Then User click back button in the browser
	Then "5" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS10977 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowseBackButtonForListFilters
	When User add following columns using URL to the "Applications" page:
	| ColumnName      |
	| Application Key |
	When User create dynamic list with "TestListD75CD3" name on "Applications" page
	Then "TestListD75CD3" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| TestListD75CD3 | Not used on device |
	Then "Application in list TestListD75CD3 not used on device" is displayed in added filter info
	Then "17,126" rows are displayed in the agGrid
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then User click back button in the browser
	Then "17,126" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Application in list TestListD75CD3 not used on device" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11560
Scenario: EvergreenJnr_DevicesList_CheckNumericFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Count (Installed)" filter where type is "Less than" without added column and following value:
	| Values |
	| 1      |
	Then "App Count (Installed) is less than 1" is displayed in added filter info
	Then "5,141" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11469
Scenario Outline: EvergreenJnr_DevicesList_CheckThatAssociationSearchInFiltersPanelIsWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User enters "used" in Association search field 
	Then search values in Association section working by specific search criteria

Examples:
	| FilterName                 |
	| Application                |
	| Application Compliance     |
	| Application (Saved List)   |
	| Application Import         |
	| Application Import Type    |
	| Application Inventory Site |
	| Application Name           |
	| Application Vendor         |
	| Application Version        |

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11560
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorInNotDisplayedWhenUserApplyASelectedNumericFilter 
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Installed)" filter where type is "Less than" with added column and following value:
	| Values |
	| 10     |
	Then "Device Count (Installed)" filter is added to the list
	Then "1,269" rows are displayed in the agGrid
	Then "(Device Count (Installed) < 10)" text is displayed in filter container

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11551 @DAS11550 @DAS11749
Scenario Outline: EvergreenJnr_DevicesList_CheckThatEmptyNotEmptyOperatorsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	When User select "<OperatorValues>" Operator value
	Then Associations panel is displayed in the filter

Examples:
	| OperatorValues |
	| Empty          |
	| Not Empty      |

@Evergreen @Users @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11577
Scenario Outline: EvergreenJnr_UsersList_CheckThatLDAPFilterCategoryHaveAddColumnCheckboxes
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11550 @DAS11749 @API
Scenario Outline: EvergreenJnr_DevicesList_CheckThatOperatorInSelectedFilterIsDisplayedCorrectlyAPI
	Then following operators are displayed in "<CategoryName>" category for "<FilterName>" filter on "Devices" page:
	| OperatorValues      |
	| Equals              |
	| Does not equal      |
	| Contains            |
	| Does not contain    |
	| Begins with         |
	| Does not begin with |
	| Ends with           |
	| Does not end with   |
	| Empty               |
	| Not empty           |

Examples:
	| CategoryName              | FilterName                  |
	| Application               | Application Name            |
	| Application Custom Fields | App field 1                 |
	| Application Custom Fields | Application Owner           |
	| Application Custom Fields | General information field 1 |
	| Application Custom Fields | App field 2                 |

@Evergreen @Users @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11738 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatToolTipShownWithEditFilterTextWhenEditingAFilterDisplayed 
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User navigate to Edit button for "Compliance" filter
	Then tooltip is displayed with "Edit Filter" text for edit filter button

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11678
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWhenEnteringInvalidData
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Build Date" filter where type is "Equals" with added column and following value:
	| Values |
	| 1      |
	Then Save button is not available on the Filter panel

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11559
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearWhenAddingAdvancedAndStandardFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Import" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association    |
	| Altiris        | Used on device |
	And User add "Boot Up Date" filter where type is "Equals" with added column and following value:
	| Values      |
	| 07 Dec 2017 |
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11741
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearAndFullDataIsDisplayedWhenAddingDifferentFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11760 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWithoutTheFilterValue
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	And User select "Not entitled to device" in Association 
	Then Save button is not available on the Filter panel
	When User have reset all filters
	And User add "Application Name" filter where type is "Equals" with following Value and Association:
	| Values | Association    |
	| adobe  | Used on device |
	And User create dynamic list with "TestListF58LY5" name on "Devices" page
	Then Edit List menu is not displayed

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11838
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatchingTheCaption
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Target App Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues     |
	| <SelectedCheckbox> |
	Then "<ColorName>" color is matching the caption

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

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11838
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheApplicationRationalisationItemIsMatchingTheCaption
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Application Rationalisation" filter where type is "Equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <SelectedCheckbox> |
	Then "<ImageName>" image is matching the caption

Examples:
	| SelectedCheckbox | ImageName     |
	| FORWARD PATH     | FORWARD PATH  |
	| KEEP             | KEEP          |
	| RETIRE           | RETIRE        |
	| UNCATEGORISED    | UNCATEGORISED |

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12076 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhenDoesnotequalNoneForWindows7MiCategoryFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User click on 'Windows7Mi: Category' column header
	Then Content is present in the newly added column
	| ColumnName           |
	| Windows7Mi: Category |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12537 @DAS12579
Scenario Outline: EvergreenJnr_AllLists_CheckThatContentIsDisplayedInTheAddedColumnAfterApplyingIsNotNoneOperator
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
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

@Evergreen @Mailboxes @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12543 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_CheckThatEditFilterElementsBlockIsDisplayedCorrectlyOnTheFiltersPanel
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
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

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12636
Scenario Outline: EvergreenJnr_AllLists_CheckThatLocationFilterIsEditedCorrectly
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "State/County" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then "<FilterValue>" text is displayed in the table content
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

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS11824
Scenario: EvergreenJnr_DevicesList_CheckingThatError500IsNotDisplayedAfterUsingSpecialCharactersIntoTheApplicationNameFilterAndRefreshingThePage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Equals" with following Value and Association:
	| Values | Association            |
	| __     | Entitled to device     |
	Then "Application Name" filter is added to the list
	When User clicks refresh button in the browser
	Then "Devices" list should be displayed to the user
	And "(Application Name = __ ASSOCIATION = (entitled to device))" text is displayed in filter container

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12202 @Delete_Newly_Created_List
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
	When User click on 'Device Count (Entitled)' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "StaticList6581" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6581 | Entitled to device |
	Then "38" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12875
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Surname" filter where type is "Equals" with following Value and Association:
	| Values       | Association     |
	| Cotuand      | Entitled to app |
	| Courtemanche |                 |
	When User click Edit button for "User " filter
	Then There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12167 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedListFilter
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" without added column and following value:
	| Values     |
	| YOG2259571 |
	When User create dynamic list with "YOG2259571 Users" name on "Users" page
	Then "YOG2259571 Users" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList     | Association     |
	| YOG2259571 Users | Entitled to app |
	Then "4" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12181 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Contains" without added column and following value:
	| Values |
	| Bob    |
	When User create dynamic list with "UsersBob" name on "Users" page
	Then "UsersBob" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association                         |
	| UsersBob     | Has used app                        |
	| UsersBob     | Entitled to app                     |
	| UsersBob     | Owns a device which app was used on |
	Then "1" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12827 @DAS12812
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserLastLogonDateFilterWorksCorrectly
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 30 Apr 2018 | Has used app |
	Then message 'No applications found' is displayed to the user
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12058 @Delete_Newly_Created_List
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

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12058 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName          |
	| Windows7Mi: Application Rationalisation          |
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

@Evergreen @Applications @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12200
Scenario: EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association  |
	| FR\APB5713645  | Has used app |
	Then "1" rows are displayed in the agGrid
	When User click Edit button for "User" filter
	When User is deselect "Has used app" in Association
	When User select "Has not used app" in Association
	And User clicks Save filter button
	Then "2,222" rows are displayed in the agGrid

@Evergreen @DevicesList @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                                | SelectedCheckboxes   | Rows   |
	| Windows7Mi: Category                      | None                 | 17,194 |
	| Windows7Mi: Values but no RAG             | Three                | 1      |
	| Windows7Mi: SS Application List Completed | Not Applicable       | 5,161  |
	| Babel(Engl: Category                      | None                 | 17,225 |
	| Barry'sUse: Category                      | None                 | 17,225 |
	| ComputerSc: Category                      | None                 | 17,059 |
	| ICSP: Category                            | None                 | 17,217 |
	| MigrationP: Category                      | None                 | 17,220 |
	| Babel(Engl: Request Type                  | Machines             | 62     |
	| ComputerSc: Request Type                  | Request Type A       | 132    |
	| ICSP: Request Type                        | [Default (Computer)] | 8      |
	| MigrationP: Request Type                  | [Default (Computer)] | 41     |
	| prK: Request Type                         | [Default (Computer)] | 31     |
	| UserSchedu: Request Type                  | Request Type A       | 60     |
	| Windows7Mi: Request Type                  | Computer: PC Rebuild | 1      |
	
@Evergreen @UsersList @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_UsersList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                                  | SelectedCheckboxes | Rows   |
	| Windows7Mi: Category                        | Terminated         | 1      |
	| Windows7Mi: Read Only on Bulk Update Page   | Not Applicable     | 4,642  |
	| Babel(Engl: Category                        | The first          | 8      |
	| Barry'sUse: Category                        | None               | 41,339 |
	| ComputerSc: Category                        | None               | 41,339 |
	| EmailMigra: Category                        | None               | 41,339 |
	| ICSP: Category                              | i-user category    | 8      |
	| MigrationP: Category                        | None               | 41,339 |
	| prK: Category                               | user category K    | 25     |
	| UserSchedu: Category                        | None               | 41,339 |
	| Babel(Engl: Request Type                    | Overseers          | 34     |
	| ComputerSc: Request Type                    | Request Type A     | 92     |
	| ComputerSc: Group User Default Request Type | Not Applicable     | 1,789  |
	| ComputerSc: Group User No Request Type      | Not Applicable     | 1,981  |
	| EmailMigra: Request Type                    | Standard User      | 720    |
	| Havoc(BigD: Request Type                    | [Default (User)]   | 7,578  |
	| ICSP: Request Type                          | [Default (User)]   | 8      |
	| MigrationP: Request Type                    | VIP                | 2      |
	| prK: Request Type                           | [Default (User)]   | 36     |
	| UserSchedu: Request Type                    | Request Type A     | 38     |
	| UserSchedu: Group User Default Request Type | Not Applicable     | 679    |
	| Windows7Mi: Request Type                    | User: VIP          | 6      |

@Evergreen @ApplicationsList @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                 | SelectedCheckboxes          | Rows  |
	| Windows7Mi: Category       | A Star Packages             | 3     |
	| Windows7Mi: Technical Test | Started                     | 4     |
	| Babel(Engl: Category       | None                        | 2,223 |
	| ComputerSc: Category       | None                        | 2,223 |
	| EmailMigra: Category       | None                        | 2,223 |
	| Havoc(BigD: Category       | None                        | 2,223 |
	| ICSP: Category             | i-app category              | 148   |
	| MigrationP: Category       | None                        | 2,223 |
	| prK: Category              | app category K              | 196   |
	| UserSchedu: Category       | None                        | 2,223 |
	| Babel(Engl: Request Type   | Tools                       | 302   |
	| ComputerSc: Request Type   | Request Type A              | 55    |
	| EmailMigra: Request Type   | Public Folder               | 50    |
	| Havoc(BigD: Request Type   | [Default (Application)]     | 1,067 |
	| ICSP: Request Type         | [Default (Application)]     | 148   |
	| MigrationP: Request Type   | Group A Application         | 1     |
	| prK: Request Type          | [Default (Application)]     | 231   |
	| UserSchedu: Request Type   | Request Type A              | 47    |
	| Windows7Mi: Request Type   | Application: Request Type A | 7     |

@Evergreen @MailboxesList @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_MailboxesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName               | SelectedCheckboxes     | Rows  |
	| EmailMigra: Category     | Mailbox Category A     | 6     |
	| EmailMigra: Request Type | Personal Mailbox - VIP | 6     |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseDepartmentFilter
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "<SelectedCheckboxes>" Tree List option
	Then "Department" filter is added to the list
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| PageName  | SelectedCheckboxes      | Rows  |
	| Devices   | Application Development | 873   |
	| Users     | Application Development | 1,857 |
	| Mailboxes | Application Development | 1,118 |