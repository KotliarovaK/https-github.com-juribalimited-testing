Feature: FiltersFunctionalityDevices
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11560
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @FiltersDisplay @DAS11660 @DAS13376 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatOperatorsForApplicationSavedListFilterIsDisplayedCorrectly
	When User add following columns using URL to the "Applications" page:
		| ColumnName |
		| Compliance |
	When User create dynamic list with "TestSavedList009" name on "Applications" page
	Then "TestSavedList009" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then "In list, Not in list" option is available for this filter

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11559
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11741 @DAS13001
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
	| Empty                   |
	When User Add And "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then full list content is displayed to the user
	And There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS12076 @DAS12351 @DAS20089
Scenario: EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhenDoesnotequalNoneForWindows7MiCategoryFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	Then Content is empty in the column
	| ColumnName           |
	| Windows7Mi: Category |
	When User add "Windows7Mi: Category" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User clicks on 'Windows7Mi: Category' column header
	Then Content is present in the newly added column
	| ColumnName           |
	| Windows7Mi: Category |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS12351
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
	| Windows7Mi: Category                                            | Empty                | 17,248 |
	| Windows7Mi: Migration \ Values but no RAG                       | Three                | 1      |
	| Windows7Mi: Portal Self Service \ SS Application List Completed | Not Applicable       | 5,159  |
	| UserSchedu: Category                                            | Empty                | 17,279 |
	| Havoc(BigD: Path                                                | [Default (Computer)] | 8,403  |
	| ComputerSc: Path                                                | Request Type A       | 132    |
	| UserSchedu: Path                                                | [Default (Computer)] | 689    |
	| UserSchedu: Path                                                | Request Type A       | 60     |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS12522
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS12807
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS13104 @Cleanup
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS13331
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS10020
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS15291
Scenario: EvergreenJnr_DevicesList_CheckSlotsSortOrderForDevicesList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "2004: Pre-Migration \ Scheduled Date (Slot)" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Laptop         |
	When User clicks on '2004: Pre-Migration \ Scheduled Date (Slot)' column header
	Then Content in the '2004: Pre-Migration \ Scheduled Date (Slot)' column is equal to
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
	When User clicks on '2004: Pre-Migration \ Scheduled Date (Slot)' column header
	Then Content in the '2004: Pre-Migration \ Scheduled Date (Slot)' column is equal to
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS16394 @Cleanup @archived
Scenario: EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilterForTheListBasedOnSavedListWithErrors
	When User creates broken list with 'Broken list DAS16394' name on 'Devices' page
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList         | Association |
	| Broken list DAS16394 |             |
	When User creates 'List_DAS16394' dynamic list
	Then "List_DAS16394" list is displayed to user
	Then Create button is disabled on the Base Dashboard Page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Device" filter
	Then Create button is disabled on the Base Dashboard Page

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS16071
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS17411 @Cleanup
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS16178
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS17004
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS17557
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS17715 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckCustomFieldsUsingInFilterAndProjectCreation
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS17757
Scenario: EvergreenJnr_DevicesList_CheckThatOffboardedItemsDontShowAnyOtherProjectProperties
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: Status" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Offboarded     |
	Then "4" rows are displayed in the agGrid
	Then Content in the '2004: Status' column is equal to
	| Content    |
	| Offboarded |
	| Offboarded |
	| Offboarded |
	| Offboarded |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18140
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18709
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18100 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNotEmptyOperatorWasAddedToMultipleFilters
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18100 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNotEmptyOperatorWasAddedToMultipleFiltersIfFilterWasCreatedViaAddressRow
	When User navigates to 'devices?$filter=(distributionType%20IS%20NOT%20EMPTY%20())&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,distributionType' url via address line
	Then "17,279" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Import Type is not empty" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18616
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS19157 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatThereIsNoAbilityToUseListAsFilterOptionIfItHasReferenceFiltersForCurrentProjectAsProjectScopeList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "2004: In Scope" filter where type is "Equals" with added column and Lookup option
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS19460
Scenario: EvergreenJnr_DevicesList_CheckThatCorrectOptionsAreDisplayedForOwnerStatusFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "2004: Owner Status" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes    |
    | Empty         |
    | Not Onboarded |
    | Onboarded     |
    | Offboarded    |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11087 @DAS12114 @DAS12698
Scenario: EvergreenJnr_DevicesList_CheckThatDateAndTimeFiltersWithEqualsValuesAreWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter where type is "Equals" with added column and following value:
		| Values      |
		| 22 Nov 2012 |
	Then "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter is added to the list
	Then "16" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11087 @DAS11090 @DAS12114 @DAS12698
Scenario Outline: EvergreenJnr_DevicesList_CheckThatDateAndTimeFiltersWithDoesNotEqualValuesAreWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Does not equal" with added column and following value:
		| Values  |
		| <Value> |
	Then "<FilterName>" filter is added to the list
	And "<RowCount>" rows are displayed in the agGrid

	Examples:
		| FilterName                                                                     | Value       | RowCount |
		| Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task | 22 Nov 2012 | 17,263   |
		| Build Date                                                                     | 6 Nov 2004  | 17,278   |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11663
Scenario: EvergreenJnr_DevicesList_CheckThatRowCountIsNotDisplayedWhenNoObjectsAreFoundAfterApplyingAFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
		| Values  |
		| Example |
	Then "Hostname" filter is added to the list
	And "" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11575
Scenario: EvergreenJnr_DevicesList_CheckThatFilterLogicForBooleanFieldsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Secure Boot Enabled" filter where type is "Does not equal" with added column and following checkboxes:
		| SelectedCheckboxes |
		| FALSE              |
		| Empty              |
	Then "Secure Boot Enabled" filter is added to the list
	Then table data in column is filtered correctly

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11144 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatChildrenOfTreeBasedFiltersAreIncludedInTheListResultsOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "Sales" Tree List option
	Then "Department" filter is added to the list
	And "3,295" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS13024
Scenario: EvergreenJnr_DevicesList_ChecksThatGridIsDisplayedCorrectlyAfterAddingDeviceOwnerLdapAndComputerAdObjectLdapAttributeFilterToTheDevicesList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner accountexpires" filter where type is "Empty" without added column and following value:
		| Values |
		| 123    |
	When User add "admincount" filter where type is "Empty" without added column and following value:
		| Values |
		| 123    |
	Then "17,279" rows are displayed in the agGrid
	And full list content is displayed to the user
	And There are no errors in the browser console
	And table content is present

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS12232 @DAS12351 @DAS12639 @DAS14288
Scenario: EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Migration \ Values but no RAG" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| One                |
	| Three              |
	When User Add And "UserSchedu: One \ Radio Rag Date Comp" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| Started            |
	| Failed             |
	| Complete           |
	Then "233" rows are displayed in the agGrid
	When User create dynamic list with "Devices_ProjectTaskFilters_AND" name on "Devices" page
	Then "Devices_ProjectTaskFilters_AND" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Devices_ProjectTaskFilters_AND" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Migration \ Values but no RAG is One or Three" is displayed in added filter info
	Then "UserSchedu: One \ Radio Rag Date Comp is Not Applicable, Started, Failed or Complete" is displayed in added filter info
	When User click Edit button for "Windows7Mi: Migration \ Values but no RAG" filter
	When User change selected checkboxes:
	| Option | State |
	| One    | false |
	| Two    | false |
	| Three  | true  |
	When User click Edit button for "UserSchedu: One \ Radio Rag Date Comp" filter
	When User select "Does not equal" Operator value
	When User change selected checkboxes:
	| Option         | State |
	| Not Applicable | true  |
	| Not Started    | false |
	| Started        | false |
	| Failed         | false |
	| Complete       | false |
	Then "1" rows are displayed in the agGrid
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS16726 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewCurrentAndLastSeenFiltersAreAvailableForSelection
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Current             |
	| Dashworks Last Seen |
	And User clicks the Filters button
	And User add "Current" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User add "Dashworks Last Seen" filter where type is "Equals" with added column and "25 Jul 2019" Date filter
	And User creates 'TestNewColumnsAndFilters' dynamic list
	Then "TestNewColumnsAndFilters" list is displayed to user

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11552 @DAS12207 @DAS12639
Scenario: EvergreenJnr_DevicesList_CheckThatRelevantDataSetBeDisplayedAfterEditingFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then message 'No devices found' is displayed to the user
	When User click Edit button for "Compliance" filter
	And User closes "Empty" Chip item in the Filter panel
	When User change selected checkboxes:
		| Option | State |
		| Green  | true  |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS13383 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatColorsInReadinessFilterAreDisplayedCorrectlyAfterSavingList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and Lookup option
		| SelectedValues |
		| Blocked        |
		| Amber          |
	And User creates 'CheckColors13383' dynamic list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "2004: Readiness" filter
	Then color for following values are displayed correctly:
		| Color   |
		| Blocked |
		| Amber   |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS15625
Scenario: EvergreenJnr_DevicesList_CheckThatTaskSlotHasEmptyAndNotEmptyOperators
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
		| ColumnName                                  |
		| 2004: Pre-Migration \ Scheduled Date (Slot) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "2004: Pre-Migration \ Scheduled Date (Slot)" filter
	And User select "Equals" Operator value
	And User enters "Empty" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then Column '2004: Pre-Migration \ Scheduled Date (Slot)' with no data displayed

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS16071
Scenario: EvergreenJnr_DevicesList_CheckThatStatusFilterAvailableOptionsList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Status" filter
	And User clicks in search field in the Filter block
	Then Following checkboxes are available for current opened filter:
		| checkboxes    |
		| Not Onboarded |
		| Onboarded     |
		| Forecast      |
		| Targeted      |
		| Scheduled     |
		| Migrated      |
		| Complete      |
		| Offboarded    |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18375
Scenario: EvergreenJnr_DevicesList_CheckAppearanceOfComplianceValuesInTheFilterBlock
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Compliance" filter
	Then the values are displayed for "applicationCompliance" filter on "Devices" page in the following order:
		| Value   |
		| Empty   |
		| Unknown |
		| Red     |
		| Amber   |
		| Green   |
		| Ignore  |
	When User clicks in search field in the Filter block
	Then No ring icon displayed for Empty item in Lookup

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18367
Scenario Outline: EvergreenJnr_DevicesList_CheckThatThereIsNoEmptyOptionInDeviceAndApplicationSavedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "<List>" filter from "Saved List" category
	When User enters "Empty" text in Search field at selected Lookup Filter
	Then "Empty" checkbox is not available for current opened filter

	Examples:
		| List                     |
		| Device (Saved List)      |
		| Application (Saved List) |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18367
Scenario: EvergreenJnr_DevicesList_CheckThatThereIsNoEmptyOptionInProjectSpecificSavedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "2004: Owner (Saved List)" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18759 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewGroupsFilterIsDisplayedCorrectly
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User closes "Suggested" filter category
	Then Category with counter is displayed on Filter panel
		| Category | Number |
		| Group    | 8      |
	When User expands "Group" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories      |
		| Group              |
		| Group Description  |
		| Group Display Name |
		| Group Domain       |
		| Group Member Count |
		| Group Name         |
		| Group Type         |
		| Group Username     |
	When user select "Group" filter
	Then '50 of 4510 shown' label is displayed in expanded autocomplete
	When User enters "AU\GAPP-A0121127" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User enters "AU\GAPP-A012116D" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User enters "AU\GAPP-A01211A7" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	Then following chips value displayed for 'Search' textbox
		| ChipValue        |
		| AU\GAPP-A0121127 |
		| AU\GAPP-A012116D |
		| 1 more           |
	#SZ: should be uncommented after adding Member placeholder
	#When User selects 'Not a member' in the 'Member' dropdown
	When User clicks 'ADD' button
	Then There are no errors in the browser console
	When User create dynamic list with "GroupList18759" name on "Devices" page
	Then "GroupList18759" list is displayed to user

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS10696 @DAS13376
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsFilterIsContainsAllExpectedAssociations
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then Associations is displayed in the filter
		| Associations                   |
		| Used on device                 |
		| Entitled to device             |
		| Installed on device            |
		| Used by device's owner         |
		| Entitled to device's owner     |
		| Not used on device             |
		| Not entitled to device         |
		| Not installed on device        |
		| Not used by device's owner     |
		| Not entitled to device's owner |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11187 @DAS13376
Scenario Outline: EvergreenJnr_DevicesList_CheckThatCustomFiltersAreContainsAllExpectedAssociations
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "<FilterName>" filter from "Application Custom Fields" category
	Then Associations is displayed in the filter
		| Associations                   |
		| Used on device                 |
		| Entitled to device             |
		| Installed on device            |
		| Used by device's owner         |
		| Entitled to device's owner     |
		| Not used on device             |
		| Not entitled to device         |
		| Not installed on device        |
		| Not used by device's owner     |
		| Not entitled to device's owner |

	Examples:
		| FilterName                  |
		| App field 1                 |
		| App field 2                 |
		| Application Owner           |
		| General information field 1 |
		| General information field 2 |
		| General information field 3 |
		| General information field 4 |
		| General information field 5 |

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11469
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS11551 @DAS11550 @DAS11749
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

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS20619
Scenario: EvergreenJnr_DevicesList_CheckThatNoErrorDisplayedWhenFilterIncludesRadiobuttonEmptyTaskValue
	When User clicks 'Devices' on the left-hand menu
	When User navigates to 'devices?$filter=(project_task_1_8397_1_Task_Value%20EQUALS%20('NULL'))&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,project_task_1_8397_1_Task' url via address line
	Then table content is present
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS20637
Scenario: EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersCanBeDeletedWithoutError
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "UserSchedu: One \ Radio Rag Date Comp Req B" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Started            |
	When User have removed "UserSchedu: One \ Radio Rag Date Comp Req B" filter
	Then 'All Devices' list should be displayed to the user
	Then There are no errors in the browser console
	Then table content is present

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS18829 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatOnboardedItemsAreDisplayedInTheGridAfterApplyingOwnerSavedListFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Mobile         |
	When User clicks Save button on the list panel
	When User create dynamic list with "ProjList_DAS18829" name on "Devices" page
	Then "ProjList_DAS18829" list is displayed to user
	When Project created via API
	| ProjectName         | Scope             | ProjectTemplate | Mode               |
	| MyTestProj_DAS18829 | ProjList_DAS18829 | None            | Standalone Project |
	When User navigates to "MyTestProj_DAS18829" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects          |
	| 3V2EKGQAV6KTCCUW |
	| 9AW0JAIC0GZNQY   |
	| E3YAGUCAPTXGFZSS |
	When User navigates to the 'Users' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects           |
	| Monique Robillard |
	| Tammi C. Francis  |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Users' on the left-hand menu
	When  User clicks the Actions button
	Then Actions panel is displayed to the user
	When User perform search by "YIO4827996"
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| YIO4827996       |
	When User perform search by "KSQ903966"
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| KSQ903966       |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList_DAS18829" name
	Then "StaticList_DAS18829" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "MyTestProj: Owner (Saved List)" filter where type is "In list" without added column and following checkboxes:
	| SelectedCheckboxes  |
	| StaticList_DAS18829 |
	Then "2" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_DevicesList @DAS21224
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationFilterCantBeAppliedWithoutAssociation
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When user select "Application" filter
	When User select "Equals" Operator value
	Then There are no errors in the browser console
	When User enters ""WPF/E" (codename) Community Technology Preview (Feb 2007)" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	Then 'ADD' button is disabled
	