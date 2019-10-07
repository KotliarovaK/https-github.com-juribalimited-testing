Feature: FiltersDisplay
	Runs Dynamic Filters Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS15374 @Cleanup
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatDatesDisplayIsRegionSpecific
	When User language is changed to "<Language>" via API
	And User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "1803: Pre-Migration \ Scheduled Date" filter where type is "<Option>" with added column and following value:
    | Values         |
    | <ExpectedDate> |
	Then "1803: Pre-Migration \ Scheduled Date" filter is added to the list
	And Values is displayed in added filter info
    | Values         |
    | <ExpectedDate> |

	Examples:
    | Language   | Option | ExpectedDate  |
    | english us | Equals | Jul 10, 2019  |
    | english uk | Equals | 10 Jul 2019   |
    | deutsch    | Gleich | 10. Juli 2019 |
    | français   | Avant  | 10 juil. 2019 |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10651
Scenario: EvergreenJnr_ApplicationsList_CheckTrueFalseOptionsAndImagesInFilterInfo
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Hide from End Users" filter
	Then correct true and false options are displayed in filter settings
	When User have created "Equals" filter without column and following options:
    | SelectedCheckboxes |
    | TRUE               |
    | FALSE              |
    | Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	Then Values is displayed in added filter info
    | Values |
    | True   |
    | False  |
    | Empty  |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10754 @DAS11142 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckSpecialCharactersDisplayInFilterInfo
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
    | Values           |
    | O'Conn"/\or#@!() |
	Then "Display Name" filter is added to the list
	And Values is displayed in added filter info
    | Values           |
    | O'Conn"/\or#@!() |
	When User create dynamic list with "TestList66E313" name on "Users" page
	Then "TestList66E313" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
    | Values           |
    | O'Conn"/\or#@!() |
	When User navigates to the "All Users" list
	When User navigates to the "TestList66E313" list
	Then "TestList66E313" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
    | Values           |
    | O'Conn"/\or#@!() |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10781 @DAS11507
Scenario: EvergreenJnr_ApplicationsList_CheckThatGroupAndTeamRelatedFiltersIsNotPresentedInTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Group" filter is not presented in the filters list
	Then "Windows7Mi: Group Key" filter is not presented in the filters list
	Then "Windows7Mi: Team" filter is not presented in the filters list
	Then "Windows7Mi: Team Key" filter is not presented in the filters list

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10776
Scenario: EvergreenJnr_DevicesList_CheckThatEmptyAndNotEmptyOptionsIsAvaildableForObjectKeyFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "AD Object Key" filter
	Then "Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to, Empty, Not empty" option is available for this filter

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS10781 @DAS11573
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnOptionIsAvailableForFilters
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
    | SelectedCheckboxes   |
    | <SelectedCheckboxes> |

	Examples:
    | PageName     | FilterName            | SelectedCheckboxes               |
    | Devices      | Operating System      | Add Operating System column      |
    | Devices      | City                  | Add City column                  |
    | Users        | Zip Code              | Add Zip Code column              |
    | Applications | Application Owner     | Add Application Owner column     |
    | Mailboxes    | Mailbox Filter 1      | Add Mailbox Filter 1 column      |
    | Devices      | Compliance            | Add Compliance column            |
    | Mailboxes    | Owner Department Code | Add Owner Department Code column |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS11187 @DAS13376
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnOptionIsNotAvailableForApplicationCustomFieldsFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Owner" filter from "Application Custom Fields" category
	Then "Add column" checkbox is not displayed

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS10771 @DAS10972 @DAS14748
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoneOptionIsAvailableForFilters
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
    | SelectedCheckboxes |
    | None               |
	Then Save to New Custom List element is displayed
	When User click Edit button for "<FilterName>" filter
	Then User changes filter type to "Does not equal"
	Then Save to New Custom List element is displayed
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
    | SelectedCheckboxes |
    | None               |
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Hostname" filter
	And User have create "Equals" Values filter with column and following options:
    | Values          |
    | 00BDM1JUR8IF419 |
	Then "Hostname" filter is added to the list
	Then Values is displayed in added filter info
    | Values          |
    | 00BDM1JUR8IF419 |
	When User create dynamic list with "TestList5256A5" name on "Devices" page
	Then "TestList5256A5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
    | Values          |
    | 00BDM1JUR8IF419 |
	When User navigates to the "All Devices" list
	When User navigates to the "TestList5256A5" list
	Then "TestList5256A5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
    | Values          |
    | 00BDM1JUR8IF419 |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12199 @DAS12220 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
    | SelectedCheckboxes |
    | Red                |
    | Amber              |
    | Green              |
	Then "Compliance" filter is added to the list
	Then Values is displayed in added filter info
    | Values |
    | Red    |
    | Amber  |
    | Green  |
	When User create dynamic list with "Users - Nav between lists" name on "Users" page
	Then "Users - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
    | Values |
    | Red    |
    | Amber  |
    | Green  |
	When User navigates to the "All Users" list
	When User navigates to the "Users - Nav between lists" list
	Then "Users - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
    | Values |
    | Red    |
    | Amber  |
    | Green  |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Entitled)" filter where type is "Greater than or equal to" with added column and following value:
    | Values |
    | 1      |
	Then "Device Count (Entitled)" filter is added to the list
	And Values is displayed in added filter info
    | Values |
    | 1      |
	When User create dynamic list with "Apps - Nav between lists" name on "Applications" page
	Then "Apps - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
    | Values |
    | 1      |
	When User navigates to the "All Applications" list
	When User navigates to the "Apps - Nav between lists" list
	Then "Apps - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
    | Values |
    | 1      |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12114 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "Before" with added column and following value:
    | Values      |
    | 17 Nov 2017 |
	Then "Created Date" filter is added to the list
	And Values is displayed in added filter info
    | Values      |
    | 17 Nov 2017 |
	When User create dynamic list with "Mailboxes - Nav between lists" name on "Mailboxes" page
	Then "Mailboxes - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
    | Values      |
    | 17 Nov 2017 |
	When User navigates to the "All Mailboxes" list
	When User navigates to the "Mailboxes - Nav between lists" list
	Then "Mailboxes - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
    | Values      |
    | 17 Nov 2017 |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_DevicesList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "<operatorValue>" with added column and following value:
    | Values         |
    | <filterOption> |
	Then "Hostname" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values                |
    | <operatorValueInInfo> |

	Examples:
    | operatorValue    | filterOption    | rowsCount | operatorValueInInfo |
    | Equals           | 00BDM1JUR8IF419 | 1         | is                  |
    | Does not equal   | 00BDM1JUR8IF419 | 17,278    | is not              |
    | Contains         | 00B             | 6         | contains            |
    | Does not contain | 00BDM1J         | 17,278    | does not contain    |
    | Begins with      | 00              | 14        | begins with         |
    | Ends with        | 41              | 7         | ends with           |
    | Empty            |                 |           | is empty            |
    | Not empty        |                 | 17,279    | is not empty        |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12199 @DAS12220
Scenario Outline: EvergreenJnr_UsersList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "<operatorValue>" with added column and following checkboxes:
    | SelectedCheckboxes |
    | <filterOption>     |
	Then "Compliance" filter is added to the list
	#And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values                |
    | <operatorValueInInfo> |

	Examples:
    | operatorValue  | filterOption | rowsCount | operatorValueInInfo |
    | Equals         | Red          | 9,438     | is                  |
    | Does not equal | Red          | 31,901    | is not              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Entitled)" filter where type is "<operatorValue>" with added column and following value:
    | Values         |
    | <filterOption> |
	Then "Device Count (Entitled)" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values                |
    | <operatorValueInInfo> |

	Examples:
    | operatorValue            | filterOption | rowsCount | operatorValueInInfo         |
    | Equals                   | 1            | 2         | is                          |
    | Does not equal           | 1            | 2,221     | is not                      |
    | Greater than             | 1            | 1,057     | is greater than             |
    | Greater than or equal to | 1            | 1,059     | is greater than or equal to |
    | Less than                | 1            | 1,164     | is less than                |
    | Less than or equal to    | 1            | 1,166     | is less than or equal to    |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12114
Scenario Outline: EvergreenJnr_MailboxesList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "<operatorValue>" with added column and following value:
    | Values         |
    | <filterOption> |
	Then "Created Date" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values                |
    | <operatorValueInInfo> |

	Examples:
    | operatorValue  | filterOption | rowsCount | operatorValueInInfo |
    | Not empty      |              | 14,778    | is not empty        |
    | Does not equal | 8 Mar 2016   | 14,781    | is not              |
    | Equals         | 8 Mar 2016   | 3         | is                  |
    | Empty          |              | 6         | is empty            |
    | Before         | 8 Mar 2016   | 4,699     | is before           |
    | After          | 8 Mar 2016   | 10,076    | is after            |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS11090 @DAS12114 @DAS12698
Scenario Outline: EvergreenJnr_DevicesList_CheckThatFilterOperatorsIsCorrectInFilterInfoDatetime
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter where type is "<operatorValue>" with added column and following value:
    | Values         |
    | <filterOption> |
	Then "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values                |
    | <operatorValueInInfo> |

	Examples:
    | operatorValue  | filterOption | rowsCount | operatorValueInInfo |
    | Equals         | 22 Nov 2012  | 16        | is                  |
    | Does not equal | 22 Nov 2012  | 17,263    | is not              |
    | Before         | 22 Nov 2012  | 1         | is before           |
    | After          | 14 May 2012  | 16        | is after            |
    | Empty          |              | 17,262    | is empty            |
    | Not empty      |              | 17        | is not empty        |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_UsersList_CheckThatFilterOperatorsIsCorrectInFilterInfoEnabled
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "<operatorValue>" with added column and following checkboxes:
    | SelectedCheckboxes |
    | <filterOption>     |
	Then "Enabled" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values                |
    | <operatorValueInInfo> |

	Examples:
	    	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
    | Equals         | TRUE         | 41,231    | is                  |
    | Does not equal | TRUE         | 108       | is not              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS11512 @DAS13376 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatApplicationSavedListFilterIsWorkingCorrect
	When User add following columns using URL to the "Applications" page:
    | ColumnName      |
    | Application Key |
	When User create dynamic list with "TestList2854B3" name on "Applications" page
	Then "TestList2854B3" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
    | SelectedList   | Association        |
    | TestList2854B3 | Not used on device |
	Then "Any Application" filter is added to the list
	And "17,185" rows are displayed in the agGrid
	And Options is displayed in added filter info
    | Values  |
    | in list |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS13376
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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11142 @DAS11665 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatBracketsAreDisplayedCorrectlyInFilterInfo
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
    | Values                                    |
    | wxPython 2.5.3.1 (unicode) for Python 2.3 |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Equals" with added column and following value:
    | Values                                               |
    | NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
    | Windows Installer SDK (Version 2.0) (3718.1)         |
    | Janus Systems Controls for Microsoft .NET (TRIAL)    |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Contains" with added column and following value:
    | Values                 |
    | (Version 6.0) (3672.1) |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Ends With" with added column and following value:
    | Values            |
    | (self-installing) |
	Then "Application" filter is added to the list
	When User create dynamic list with "TestList3065CC" name on "Applications" page
	Then "TestList3065CC" list is displayed to user
	And "6" rows are displayed in the agGrid
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "TestList3065CC" list
	And User clicks the Filters button
	Then "TestList3065CC" list is displayed to user
	And "6" rows are displayed in the agGrid
	And Edit List menu is not displayed
	And Values is displayed in added filter info
    | Values                                               |
    | wxPython 2.5.3.1 (unicode) for Python 2.3            |
    | NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
    | Windows Installer SDK (Version 2.0) (3718.1)         |
    | Janus Systems Controls for Microsoft .NET (TRIAL)    |
    | (Version 6.0) (3672.1)                               |
    | (self-installing)                                    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11142 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatApostrophesAreDisplayedCorrectlyInFilterInfo
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Display Name" filter where type is "Contains" with added column and following value:
    | Values |
    | '      |
	Then "Owner Display Name" filter is added to the list
	And "129" rows are displayed in the agGrid

@Evergreen @AllLists @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11351
Scenario Outline: EvergreenJnr_AllLists_DevicesList_CheckThatAddColumnOptionIsAvailableForOwnerDepartmentFilter
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Department" filter
	Then checkboxes are displayed to the User:
    | SelectedCheckboxes                    |
    | Add Owner Department Name column      |
    | Add Owner Department Full Path column |

	Examples:
    | PageName  |
    | Mailboxes |
    | Devices   |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11087 @DAS12114 @DAS12698
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

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11087 @DAS11090 @DAS12114 @DAS12698
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11187 @DAS13376
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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11165
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedForFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
    | Values                             |
    | DirectX SDK (Version 8.1) (3663.0) |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Equals" with added column and following value:
    | Values                                                     |
    | "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	Then "Application" filter is added to the list
	And "(Application = DirectX SDK (Version 8.1) (3663.0)) OR (Application = "WPF/E" (codename) Community Technology Preview (Feb 2007))" text is displayed in filter container

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheComplianceAndImportFiltersContainerIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
    | SelectedCheckboxes |
    | Unknown            |
    | Red                |
    | Amber              |
    | Green              |
	Then "Compliance" filter is added to the list
	When User add "Import" filter where type is "Does not equal" with added column and "A01 SMS (Spoof)" Lookup option
	Then "Import" filter is added to the list
	Then "(Compliance = Unknown, Red, Amber or Green) OR (Import != A01 SMS (Spoof))" text is displayed in filter container

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheDepartmentCodeFilterContainerIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department Code" filter where type is "Contains" with added column and following value:
    | Values |
    | ABC    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Does not contain" with added column and following value:
    | Values |
    | ACV    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Begins with" with added column and following value:
    | Values |
    | AXZ    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Ends with" with added column and following value:
    | Values |
    | YQA    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Empty" without added column and following value:
    | Values |
    |        |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Not empty" without added column and following value:
    | Values |
    |        |
	Then "Department Code" filter is added to the list
	Then "(Department Code ~ ABC) OR (Department Code !~ ACV) OR (Department Code BEGINS WITH AXZ) OR (Department Code ENDS WITH YQA) OR (Department Code = EMPTY) OR (Department Code != EMPTY)" text is displayed in filter container

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheBootUpDateAndCpuCountFiltersContainerIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Boot Up Date" filter where type is "Before" with added column and "14 Dec 2017" Date filter
	Then "Boot Up Date" filter is added to the list
	When User add "Boot Up Date" filter where type is "After" with added column and "3 Dec 2017" Date filter
	Then "Boot Up Date" filter is added to the list
	When User add "CPU Count" filter where type is "Greater than" with added column and following value:
    | Values |
    | 66     |
	Then "CPU Count" filter is added to the list
	When User add "CPU Count" filter where type is "Greater than or equal to" with added column and following value:
    | Values |
    | 12     |
	Then "CPU Count" filter is added to the list
	When User add "CPU Count" filter where type is "Less than" with added column and following value:
    | Values |
    | 31     |
	Then "CPU Count" filter is added to the list
	When User add "CPU Count" filter where type is "Less than or equal to" with added column and following value:
    | Values |
    | 13     |
	Then "CPU Count" filter is added to the list
	Then "(Boot Up Date < 2017-12-14) OR (Boot Up Date > 2017-12-03) OR (CPU Count > 66) OR (CPU Count >= 12) OR (CPU Count < 31) OR (CPU Count <= 13)" text is displayed in filter container

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10790 @DAS13206 @DAS13178 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationFiltersBeingAppliedAgainstTheDevicesListAreRestoredCorrectlyAndAreShownInTheFiltersPanel
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "Application" filter where type is "Equals" with following Lookup Value and Association:
    | SelectedValues | Association        |
    | 7zip (2015)    | Entitled to device |
	Then "Application" filter is added to the list
	Then "11" rows are displayed in the agGrid
	Then "(Application = 7zip (2015) ASSOCIATION = ("entitled to device"))" text is displayed in filter container
	Then "Application 7zip (2015) entitled to device" is displayed in added filter info
	When User create dynamic list with "TestList44C8B6" name on "Devices" page
	Then "TestList44C8B6" list is displayed to user
	When User navigates to the "All Devices" list
	When User navigates to the "TestList44C8B6" list
	Then "TestList44C8B6" list is displayed to user
	Then "11" rows are displayed in the agGrid
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "(Application = 7zip (2015) ASSOCIATION = ("entitled to device"))" text is displayed in filter container
	And "Application 7zip (2015) entitled to device" is displayed in added filter info

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11539
Scenario: EvergreenJnr_DevicesList_CheckThatFilterCategoriesAreClosedAfterClearingAFilterSearchValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And User enters "date" text in Search field at Filters Panel
	Then Minimize buttons are displayed for all category in Filters panel
	When User clears search textbox in Filters panel
	Then Maximize buttons are displayed for all category in Filters panel

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11552 @DAS12207 @DAS12639
Scenario: EvergreenJnr_DevicesList_CheckThatRelevantDataSetBeDisplayedAfterEditingFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
    | SelectedCheckboxes |
    | None               |
	Then message 'No devices found' is displayed to the user
	When User click Edit button for "Compliance" filter
	And User closes "None" Chip item in the Filter panel
	When User change selected checkboxes:
    | Option | State |
    | Green  | true  |

#Then "71" rows are displayed in the agGrid
@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS11552 @DAS12207
Scenario: EvergreenJnr_UsersList_CheckThatRelevantDataSetBeDisplayedAfterResettingFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" with added column and following checkboxes:
    | SelectedCheckboxes |
    | UNKNOWN            |
	Then "Enabled" filter is added to the list
	And message 'No users found' is displayed to the user
	When User have reset all filters
	Then 'All Users' list should be displayed to the user
	And "41,339" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelevantDataSetBeDisplayedAfterRemovingFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Import Type" filter where type is "Equals" with added column and following checkboxes:
    | SelectedCheckboxes |
    | App-V              |
	Then "Import Type" filter is added to the list
	And message 'No applications found' is displayed to the user
	When User have removed "Import Type" filter
	Then 'All Applications' list should be displayed to the user
	And "2,223" rows are displayed in the agGrid

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_MailboxesList_CheckThatRelevantDataSetBeDisplayedAfterNavigatingToANewList
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Does not equal" with added column and following checkboxes:
    | SelectedCheckboxes |
    | FALSE              |
    | TRUE               |
	Then "Enabled" filter is added to the list
	And message 'No mailboxes found' is displayed to the user
	When User navigates to the "All Mailboxes" list
	Then 'All Mailboxes' list should be displayed to the user
	And "14,784" rows are displayed in the agGrid

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11467 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatMultipleFilterCriteriaToApplicationNameDisplayedCorrectlyWhenUsingTheContainsOperator
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Contains" with following Value and Association:
    | Values    | Association         |
    | adobe     | Installed on device |
    | microsoft |                     |
	Then "Application whose Name" filter is added to the list
	And "Application whose Name contains adobe or microsoft installed on device" is displayed in added filter info
	When User create dynamic list with "TestListF9A187" name on "Devices" page
	Then "TestListF9A187" list is displayed to user
	And "10,257" rows are displayed in the agGrid
	And Edit List menu is not displayed
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "(Application Name ~ (adobe, microsoft) ASSOCIATION = (installed on device))" text is displayed in filter container

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @DAS12152 @DAS12602 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThat500ErrorIsNotDisplayedForStaticListAfterRemovingAssociationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListTestName" name
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
    | SelectedList       | Association        |
    | StaticListTestName | Not used on device |
	Then "Any Application in list StaticListTestName not used on device" is displayed in added filter info
	When User create dynamic list with "TestList8D5C03" name on "Devices" page
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	Then User remove list with "StaticListTestName" name on "Applications" page
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList8D5C03" list
	Then "TestList8D5C03" list is displayed to user

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThat500ErrorIsNotDisplayedForDynamicListAfterRemovingAssociationsList
	When User add following columns using URL to the "Applications" page:
    | ColumnName      |
    | Application Key |
	When User create dynamic list with "TestList5E021D" name on "Applications" page
	Then "TestList5E021D" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
    | SelectedList   | Association        |
    | TestList5E021D | Not used on device |
	Then "Any Application in list TestList5E021D not used on device" is displayed in added filter info
	When User create dynamic list with "TestList5E021D" name on "Devices" page
	Then "TestList5E021D" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	Then User remove list with "TestList5E021D" name on "Applications" page
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList5E021D" list
	Then "TestList5E021D" list is displayed to user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11663
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11575
Scenario: EvergreenJnr_DevicesList_CheckThatFilterLogicForBooleanFieldsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Secure Boot Enabled" filter where type is "Does not equal" with added column and following checkboxes:
    | SelectedCheckboxes |
    | FALSE              |
    | UNKNOWN            |
	Then "Secure Boot Enabled" filter is added to the list
	Then table data in column is filtered correctly

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11660 @DAS13376 @Cleanup
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

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11619
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisabledForAlreadySelectedColumn
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "Add column"checkbox is checked and cannot be unchecked

	Examples:
    | ListName     | FilterName              |
    | Devices      | Hostname                |
    | Devices      | Device Type             |
    | Devices      | Operating System        |
    | Devices      | Owner Display Name      |
    | Users        | Username                |
    | Users        | Domain                  |
    | Users        | Display Name            |
    | Users        | Distinguished Name      |
    | Applications | Application             |
    | Applications | Vendor                  |
    | Applications | Version                 |
    | Mailboxes    | Email Address (Primary) |
    | Mailboxes    | Mailbox Platform        |
    | Mailboxes    | Mail Server             |
    | Mailboxes    | Mailbox Type            |
    | Mailboxes    | Owner Display Name      |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11088
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

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11829
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisplayedForOrganisationCategoryFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
    | SelectedCheckboxes   |
    | <SelectedCheckboxes> |

	Examples:
    | ListName  | FilterName                 | SelectedCheckboxes                    |
    | Devices   | Department Name            | Add Department Name column            |
    | Devices   | Department Full Path       | Add Department Full Path column       |
    | Devices   | Owner Department Name      | Add Owner Department Name column      |
    | Devices   | Owner Department Full Path | Add Owner Department Full Path column |
    | Mailboxes | Department Name            | Add Department Name column            |
    | Mailboxes | Department Full Path       | Add Department Full Path column       |
    | Mailboxes | Owner Department Name      | Add Owner Department Name column      |
    | Mailboxes | Owner Department Full Path | Add Owner Department Full Path column |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS11831
Scenario: EvergreenJnr_MailboxesList_CheckThatResultCounterDoesNotDisappearAfterDeletingTheCharactersInEmailMigraTeamFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Team" filter where type is "Equals" without added column and following value:
    | Values |
    | 55     |
	Then "50 of 55 shown" results are displayed in the Filter panel
	When User deletes one character from the Search field
	Then "50" of all shown label displays in the Filter panel

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS12100
Scenario: EvergreenJnr_DevicesList_CheckThatMailboxOwnerFilterCategoryIsNotDisplayedOnDeviceList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Mailbox Owner" section is not displayed in the Filter panel

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11144 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatChildrenOfTreeBasedFiltersAreIncludedInTheListResultsOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "Sales" Tree List option
	Then "Department" filter is added to the list
	And "3,295" rows are displayed in the agGrid

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS11144 @DAS12351
Scenario: EvergreenJnr_UsersList_CheckThatChildrenOfTreeBasedFiltersAreIncludedInTheListResultsOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Does not equal" with added column and "Support" Tree List option
	Then "Department" filter is added to the list
	And "35,082" rows are displayed in the agGrid

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12205 @DAS12624 @DAS13376 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatFilterTextDisplaysActualListName
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "ApplicationList" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
    | SelectedList    | Association        |
    | ApplicationList | Entitled to device |
	When User create dynamic list with "DevicesList" name on "Devices" page
	And User clicks the List Details button
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "DevicesList" list
	Then "DevicesList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] entitled to device" is displayed in added filter info

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12121 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatTextInTheFilterPanelDisplaysTheCurrentListName
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "ApplicationList1" name on "Applications" page
	And User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Vendor' column header
	And User create dynamic list with "ApplicationList2" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
    | SelectedList     | Association    |
    | ApplicationList1 | Used on device |
	When User create dynamic list with "DevicesList1" name on "Devices" page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "(Application (Saved List) = ApplicationList1 ASSOCIATION = ("used on device"))" text is displayed in filter container
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User removes custom list with "ApplicationList1" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "DevicesList1" list
	#Then "(Application (Saved List) = {LIST_ID} ASSOCIATION = ("used on device"))" text is displayed in filter container for "ApplicationList1" list name
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	When User click Edit button for " Application" filter
	Then "ApplicationList2" list is displayed for Saved List filter

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
    | SelectedCheckboxes |
    | Empty              |
	And User create custom list with "<CustomList>" name
	And User navigates to the "<AllList>" list
	And User navigates to the "<CustomList>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "<FilterInfo>" is displayed in added filter info

	Examples:
    | ListName  | FilterName | CustomList   | AllList       | FilterInfo         |
    | Devices   | OS Branch  | TestList5433 | All Devices   | OS Branch is Empty |
    | Mailboxes | Country    | TestList5436 | All Mailboxes | Country is Empty   |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11466
Scenario: EvergreenJnr_DevicesList_CheckingThatVendorFilterIsDisplayedInApplicationCategory
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Vendor" filter from "Application" category
	Then setting section for "Application Vendor" filter is loaded

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12854 @DAS12812 @DAS12056
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectValuesAreDisplayedforUserKeyFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Key" filter where type is "Less than" with following Number and Association:
    | Number | Association     |
    | 2      | Entitled to app |
	Then Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	When User Add And "User Key" filter where type is "Greater than" with following Number and Association:
    | Number | Association     |
    | 8      | Entitled to app |
	Then Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	Then "User whose Key is less than 2 entitled to app" is displayed in added filter info
	And "User whose Key is greater than 8 entitled to app" is displayed in added filter info

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @DAS12785 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatFloorFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Floor" filter
	When User select "Equals" Operator value
	When User enters "Empty" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks Save filter button
	And User create custom list with "TestList5434" name
	And User navigates to the "All Users" list
	And User navigates to the "TestList5434" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Floor is Empty" is displayed in added filter info
	When User click Edit button for "Floor" filter
	Then "Empty" value is displayed in the filter info

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserRegionFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Region" filter where type is "Equals" with Selected Value and following Association:
    | SelectedList | Association  |
    | Empty        | Has used app |
	And User create custom list with "TestList5435" name
	And User navigates to the "All Applications" list
	And User navigates to the "TestList5435" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "User whose Region is Empty has used app" is displayed in added filter info

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12940 @DAS13201 @DAS14325
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketAndCapacityUnitSubcategoriesPlacedInEvergreenCategoryInFiltersPanel
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Evergreen" section is displayed in the Filter panel
	When User closes "Suggested" filter category
	And User expands "Evergreen" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories           |
    | Evergreen Bucket        |
    | Evergreen Capacity Unit |
    | Evergreen Ring          |

	Examples:
    | ListName  |
    | Devices   |
    | Users     |
    | Mailboxes |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS13201 @DAS14325
Scenario: EvergreenJnr_ApplicationsList_CheckThatCapacityUnitSubcategoryPlacedInEvergreenCategoryInFiltersPanel
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Evergreen" section is displayed in the Filter panel
	When User closes "Suggested" filter category
	And User expands "Evergreen" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories           |
    | Evergreen Capacity Unit |

#'archived' tag was added, because "Evergreen" option in "Mode" dropdown is not available now.
@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @Projects @Cleanup @DAS13201 @archived
Scenario: EvergreenJnr_AllLists_CheckThatParticularProjectCapacityUnitFilterShowsProperItems
	When User clicks 'Admin' on the left-hand menu
	And User clicks 'CREATE PROJECT' button 
	And User enters "13201" in the "Project Name" field
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	When User selects "Evergreen" in the "Mode" dropdown
	When User clicks Create button on the Create Project page
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "DeviceSche: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes              |
    | Project Capacity Unit 1 |
    | Project Capacity Unit 2 |
    | Unassigned              |
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "UserEvergr: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes                |
    | Evergreen Capacity Unit 1 |
    | Evergreen Capacity Unit 2 |
    | Evergreen Capacity Unit 3 |
    | Unassigned                |
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "13201: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes |
    | Unassigned |
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "DeviceSche: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes              |
    | Project Capacity Unit 1 |
    | Project Capacity Unit 2 |
    | Unassigned              |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12940
Scenario: EvergreenJnr_AllLists_CheckThatDeletedBucketIsNotAvailableInEvergreenBucketFilter
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	And User clicks 'CREATE EVERGREEN BUCKET' button 
	And User enters "Bucket_DAS12940_to_be_deleted" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks 'CREATE' button 
	And User select "Bucket" rows in the grid
    | SelectedRowsName              |
    | Bucket_DAS12940_to_be_deleted |
	And User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13201 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatDeletedCapacityUnitIsNotAvailableInEvergreenCapacityUnitFilter
	When User creates new Capacity Unit via api
    | Name                                 | Description | IsDefault |
    | Capacity_Unit_DAS13201_to_be_deleted | 13201       | false     |
	And User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	And User select "Capacity Unit" rows in the grid
    | SelectedRowsName                     |
    | Capacity_Unit_DAS13201_to_be_deleted |
	And User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12812 @DAS12056
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTextInTheAdvancedFilterWithCheckboxesIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with selected Checkboxes and following Association:
    | SelectedCheckboxes | Association  |
    | <Checkbox>         | Has used app |
	Then "<FilterInfo>" is displayed in added filter info
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info

	Examples:
    | FilterName      | Checkbox | FilterInfo                                |
    | User Enabled    | FALSE    | User whose Enabled is False has used app  |
    | User Compliance | Red      | User whose Compliance is Red has used app |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12812 @DAS12056
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTextInTheAdvancedFilterInfoIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "<FilterType>" with following Value and Association:
    | Values        | Association  |
    | <FilterValue> | Has used app |
	Then "<FilterInfo>" is displayed in added filter info
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info

	Examples:
    | FilterName    | FilterType  | FilterValue   | FilterInfo                                             |
    | User SID      | Begins with | S-1-5-99      | User whose SID begins with S-1-5-99 has used app       |
    | User GUID     | Begins with | 180a2898-9ab2 | User whose GUID begins with 180a2898-9ab2 has used app |
    | User Username | Contains    | ZDP           | User whose Username contains ZDP has used app          |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS13024
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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12908
Scenario: EvergreenJnr_ApplicationsList_ChecksThatAdvancedFilterOfUserWhoseFilterNameIsEmptyIsWorkingCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Empty" with following Value and Association:
    | Values | Association     |
    |        | Entitled to app |
	Then "113" rows are displayed in the agGrid
	Then table content is present
	When User have reset all filters
	Then "2,223" rows are displayed in the agGrid
	When User add "User Building" filter where type is "Equals" with following Lookup Value and Association:
    | SelectedValues | Association     |
    | Empty          | Entitled to app |
	Then "245" rows are displayed in the agGrid
	And table content is present

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS13183
Scenario: EvergreenJnr_UsersList_CheckThatApplicationManufacturerFilterChangedToApplicationVendor
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then "Application Manufacturer" filter is not presented in the filters list
	And "Application Vendor" filter is presented in the filters list

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS9820 @DAS13296 @DAS14629 @DAS14659 @DAS14629
Scenario: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxFiltersAvailableUnderUserCategoryInFiltersPanelOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "User" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories                 |
    | Common Name                   |
    | Compliance                    |
    | Dashworks First Seen          |
    | Description                   |
    | Device Application Compliance |
    | Device Count                  |
    | Device Hardware Compliance    |
    | Directory Type                |
    | Email Address                 |
    | Enabled                       |
    | Given Name                    |
    | Group Count                   |
    | GUID                          |
    | Home Directory                |
    | Home Drive                    |
    | Last Logon Date               |
    | Mailbox Count (Access)        |
    | Mailbox Count (Owned)         |
    | Organizational Unit           |
    | Parent Distinguished Name     |
    | Primary Device                |
    | SID                           |
    | Surname                       |
    | User (Saved List)             |
    | User Application Compliance   |
    | User Key                      |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13182
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddNewOptionAvailableAfterClickOnAllOptionInListsPanelWhileFiltersSectionExpanded
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And User clicks "<LinkName>" link in Lists panel
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And Add New button is displayed on the Filter panel

	Examples:
    | ListName     | LinkName         |
    | Devices      | All Devices      |
    | Users        | All Users        |
    | Applications | All Applications |
    | Mailboxes    | All Mailboxes    |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13391 @DAS15776
Scenario Outline: EvergreenJnr_AllLists_CheckThatSelectedColumnsSectionIsExpandedByDefaultInFiltersPanel
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then User sees "Suggested" section expanded by default in Filters panel

	Examples:
    | ListName     |
    | Devices      |
    | Users        |
    | Applications |
    | Mailboxes    |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12793 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheValueInTheFiltersPanelIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Equals" with following Lookup Value and Association:
    | SelectedValues | Association     |
    | AAD1011948     | Entitled to app |
	Then "4" rows are displayed in the agGrid
	When User create dynamic list with "UsersFilterList" name on "Applications" page
	Then "UsersFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User" filter
	Then "FR\AAD1011948 (Pinabel Cinq-Mars)" value is displayed in the filter info
	And There are no errors in the browser console
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12819 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheUserDescriptionFieldIsNotDisplayedForEmptyNotEmptyOptions
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Contains" with following Value and Association:
    | Values | Association     |
    | Aw     | Entitled to app |
	Then "3" rows are displayed in the agGrid
	When User create dynamic list with "UsersDescriptionFilterList" name on "Applications" page
	Then "UsersDescriptionFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User " filter
	And User select "Empty" Operator value
	Then User Description field is not displayed
	When User select "Not empty" Operator value
	Then User Description field is not displayed

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13383 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatColorsInReadinessFilterAreDisplayedCorrectlyAfterSavingList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Readiness" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Red            |
    | Amber          |
	And User create custom list with "CheckColors13383" name
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Babel(Engl: Readiness" filter
	Then color for following values are displayed correctly:
    | Color |
    | Red   |
    | Amber |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS12547
Scenario: EvergreenJnr_MailboxesList_CheckThatOwnerFloorValuesAreSortedInTheFilterBlock
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Floor" filter
	When User clicks in search field in the Filter block
	Then the values are displayed for "OwnerFloor" filter on "Mailboxes" page in the following order:
    | Value |
    | Empty |
    | 0     |
    | 1     |
    | 2     |
    | 3     |
    | 4     |
    | 5     |
    | 6     |
    | 11    |
    | 12    |
    | 18    |
    | 19    |
    | 20    |
    | 21    |
    | 25    |
    | 26    |
    | 49    |
    | 51    |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS14629 @DAS14664 @DAS14665 @DAS14667
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

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS13831
Scenario: EvergreenJnr_DevicesList_CheckThatDateFilterContainsBetweenOperator
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Build Date" filter
	Then "Equals, Equals (relative), Does not equal, Between, Does not equal (relative), Before, Before (relative), On or before, On or before (relative), After, After (relative), On or after, On or after (relative), Empty, Not empty" option is available for this filter

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13831 @DAS15376
Scenario: EvergreenJnr_AllLists_CheckThatBetweenOperatorIsDisplayedInTheDateFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Build Date" filter where type is "Between" with added column and Date options
    | StartDateInclusive | EndDateInclusive |
    | 17 Feb 2017        | 08 Aug 2017      |
	Then "27" rows are displayed in the agGrid
	Then '17 Feb 2017' content is displayed in the 'Build Date' column
	Then '8 Aug 2017' content is displayed in the 'Build Date' column
	Then "(Build Date between (2017-02-17, 2017-08-08))" text is displayed in filter container
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" with added column and Date options
    | StartDateInclusive | EndDateInclusive |
    | 25 Apr 2018        | 02 May 2018      |
	Then "22" rows are displayed in the agGrid
	Then '25 Apr 2018' content is displayed in the 'Last Logon Date' column
	Then '2 May 2018' content is displayed in the 'Last Logon Date' column
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "Between" with added column and Date options
    | StartDateInclusive | EndDateInclusive |
    | 14 Sep 2016        | 22 Jun 2017      |
	Then "7" rows are displayed in the agGrid
	Then '14 Sep 2016' content is displayed in the 'Created Date' column
	Then '22 Jun 2017' content is displayed in the 'Created Date' column
	Then "(Created Date between (2016-09-14, 2017-06-22))" text is displayed in filter container
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "MigrationP: Package Stage \ Date Task for Package Stage" filter where type is "Between" with added column and Date options
    | StartDateInclusive | EndDateInclusive |
    | 11 Nov 2012        | 22 Nov 2019      |
	Then "19" rows are displayed in the agGrid
	Then '12 Nov 2012' content is displayed in the 'MigrationP: Package Stage \ Date Task for Package Stage' column
	Then '22 Nov 2012' content is displayed in the 'MigrationP: Package Stage \ Date Task for Package Stage' column
	Then "(MigrationP: Package Stage \ Date Task for Package Stage between (2012-11-11, 2019-11-22))" text is displayed in filter container

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS13831 @DAS15376
Scenario: EvergreenJnr_ApplicationsList_CheckThatBetweenOperatorIsDisplayedInTheUserLastLogonDateFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Between" with following Date options and Associations:
    | StartDateInclusive | EndDateInclusive | Association                             |
    | 11 Nov 2012        | 22 Nov 2019      | Has used app                            |
    |                    |                  | Entitled to app                         |
    |                    |                  | Owns a device which app was used on     |
    |                    |                  | Owns a device which app is entitled to  |
    |                    |                  | Owns a device which app is installed on |
	Then "979" rows are displayed in the agGrid
	Then "(User Last Logon Date between (2012-11-11, 2019-11-22) ASSOCIATION = (has used app, entitled to app, owns a device which app was used on, owns a device which app is entitled to, owns a device which app is installed on))" text is displayed in filter container

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS15376 @DAS15331
Scenario Outline: EvergreenJnr_AllList_CheckFilterTextInThePopOutPanelForBetweenOperator
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" with added column and Date options
    | StartDateInclusive | EndDateInclusive |
    | 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

	Examples:
    | ListName  |
    | Mailboxes |
    | Users     |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS15625
Scenario: EvergreenJnr_DevicesList_CheckThatTaskSlotHasEmptyAndNotEmptyOperators
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
    | ColumnName                                  |
    | 1803: Pre-Migration \ Scheduled Date (Slot) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "1803: Pre-Migration \ Scheduled Date (Slot)" filter
	And User select "Equals" Operator value
	And User enters "Empty" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then Column "1803: Pre-Migration \ Scheduled Date (Slot)" with no data displayed

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_DevicesList_CheckStageNameInTheFiltestForDevicesLists
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: DeviceSche" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories                                        |
    | DeviceSche: Stage 1 \ Completed Date                 |
    | DeviceSche: Stage 1 \ Completed Date (Slot)          |
    | DeviceSche: Stage 1 \ Forecast Date                  |
    | DeviceSche: Stage 1 \ Forecast Date (Slot)           |
    | DeviceSche: Stage 1 \ Group Task                     |
    | DeviceSche: Stage 1 \ Group Task (Date)              |
    | DeviceSche: Stage 1 \ Group Task (Slot)              |
    | DeviceSche: Stage 1 \ Migrated Date                  |
    | DeviceSche: Stage 1 \ Migrated Date (Slot)           |
    | DeviceSche: Stage 1 \ Scheduled Date                 |
    | DeviceSche: Stage 1 \ Scheduled Date (Slot)          |
    | DeviceSche: Stage 1 \ Target Date                    |
    | DeviceSche: Stage 1 \ Target Date (Slot)             |
    | DeviceSche: Stage 2 \ radiobutton task               |
    | DeviceSche: Stage 2 \ radiobutton task w/date        |
    | DeviceSche: Stage 2 \ radiobutton task w/date (Date) |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: DeviceSche" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories                               |
    | DeviceSche: Stage 2 \ user DDL task         |
    | DeviceSche: Stage 2 \ user radiobutton task |
    | DeviceSche: Stage 2 \ user text task        |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_ApplicationsList_CheckStageNameInTheFiltestForApplicationsLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: DeviceSche" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories                              |
    | DeviceSche: Stage 2 \ app date task        |
    | DeviceSche: Stage 2 \ app radiobutton task |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: MailboxEve" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories                              |
    | MailboxEve: 1 \ Completed                  |
    | MailboxEve: 1 \ Completed (Slot)           |
    | MailboxEve: 1 \ Forecast                   |
    | MailboxEve: 1 \ Forecast (Slot)            |
    | MailboxEve: 1 \ Migrated                   |
    | MailboxEve: 1 \ Migrated (Slot)            |
    | MailboxEve: 1 \ Scheduled - mailbox        |
    | MailboxEve: 1 \ Scheduled - mailbox (Slot) |
    | MailboxEve: 1 \ Target                     |
    | MailboxEve: 1 \ Target (Slot)              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS16426
Scenario: EvergreenJnr_ApplicationsList_CheckTooltipsForUpdateButtonWhenDateFieldIsEmpty
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "User Dashworks First Seen" filter
	And User select "Equals" Operator value
	Then "UPDATE" Action button have tooltip with "You must enter a date" text
	When User select "Between" Operator value
	Then "UPDATE" Action button have tooltip with "You must enter a start date" text
	When User select "Empty" Operator value
	Then "UPDATE" Action button have tooltip with "Complete all fields before saving this filter" text
	When User select "Not empty" Operator value
	Then "UPDATE" Action button have tooltip with "Complete all fields before saving this filter" text

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS16845
Scenario: EvergreenJnr_MailboxesList_CheckThatApplicationReadinessSubCategoryIsMissingForProjectOfMailboxesLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "readiness" text in Search field at Filters Panel
	And User closes "Project Tasks: EmailMigra" filter category
	And User closes "Project: MailboxEve" filter category
	And User closes "Project: TST" filter category
	And User closes "Project: USEMEFORA1" filter category
	And User closes "Project: zMailboxAu" filter category
	And User closes "Project Tasks: zMailboxAu" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories         |
    | EmailMigra: Readiness |

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS16071
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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17579
Scenario: EvergreenJnr_ApplicationsList_CheckUserPostalCodeOptionsDisplaying
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And user select "User Postal Code" filter
	Then following operator options available:
    | operator            |
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

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS17252 @DAS16485
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterExpressionSectionIsMovedToFilterPanel
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks "Mailbox Pivot (Complex)" list name in left panel
	And User clicks the Filters button
	Then Filter Expression icon displayed within Filter Panel
	When User clicks Filter Expression icon in Filter Panel
	Then Filter Expression displayed within Filter Panel

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194 @DAS17743
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerFilterCategoryHasCorrectSubcategories
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Device Owner" text in Search field at Filters Panel
	And User closes all filters categories
	And User expands "Device Owner" filter category
	Then the following Filters subcategories are presented for open category:
    | Subcategories                          |
    | Device Owner (Saved List)              |
    | Device Owner                           |
    | Device Owner Common Name               |
    | Device Owner Compliance                |
    | Device Owner Compliance                |
    | Device Owner Description               |
    | Device Owner Directory Type            |
    | Device Owner Display Name              |
    | Device Owner Distinguished Name        |
    | Device Owner Domain                    |
    | Device Owner Email Address             |
    | Device Owner Enabled                   |
    | Device Owner Given Name                |
    | Device Owner GUID                      |
    | Device Owner Home Directory            |
    | Device Owner Home Drive                |
    | Device Owner Key                       |
    | Device Owner Last Logon Date           |
    | Device Owner Organizational Unit       |
    | Device Owner Parent Distinguished Name |
    | Device Owner SID                       |
    | Device Owner Surname                   |
    | Device Owner Username                  |
	When User closed "Device Owner" columns category
	And User expands "Device Owner Location" filter category
	Then the following Filters subcategories are presented for open category:
    | Subcategories              |
    | Device Owner Building      |
    | Device Owner City          |
    | Device Owner Country       |
    | Device Owner Floor         |
    | Device Owner Region        |
    | Device Owner Location Name |
    | Device Owner Postal Code   |
    | Device Owner State/County  |
	When User closed "Device Owner Location" columns category
	And User expands "Device Owner Organisation" filter category
	Then the following Filters subcategories are presented for open category:
    | Subcategories                     |
    | Device Owner Cost Centre          |
    | Device Owner Department Code      |
    | Device Owner Department           |
    | Device Owner Department Full Path |
    | Device Owner Department Level 1   |
    | Device Owner Department Level 2   |
    | Device Owner Department Level 3   |
    | Device Owner Department Level 4   |
    | Device Owner Department Level 5   |
    | Device Owner Department Level 6   |
    | Device Owner Department Level 7   |
    | Device Owner Department Name      |
	When User closed "Device Owner Organisation" columns category
	And User expands "Device Owner Custom Fields" filter category
	Then the following Filters subcategories are presented for open category:
    | Subcategories                            |
    | Device Owner General information field 1 |
    | Device Owner General information field 2 |
    | Device Owner General information field 3 |
    | Device Owner General information field 4 |
    | Device Owner General information field 5 |
    | Device Owner Telephone                   |
    | Device Owner User Field 1                |
    | Device Owner User Field 2                |
    | Device Owner Zip Code                    |
	When User clears search textbox in Filters panel
	And User enters "Device Owner R" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories       |
    | Device Owner Region |
	When User clears search textbox in Filters panel
	And User enters "Device Owner S" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories        |
    | Device Owner SID     |
    | Device Owner Surname |
	When User clears search textbox in Filters panel
	And User enters "Device Owner U" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories         |
    | Device Owner Username |
	When User clears search textbox in Filters panel
	And User enters "Device Owner D" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories           |
    | Device Owner Department |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerCustomFieldsFilterCategoryHasCorrectSubcategories
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Device Owner General information field" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories                            |
    | Device Owner General information field 1 |
    | Device Owner General information field 2 |
    | Device Owner General information field 3 |
    | Device Owner General information field 4 |
    | Device Owner General information field 5 |
	When User clears search textbox in Filters panel
	And User enters "Device Owner Telephone" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories          |
    | Device Owner Telephone |
	When User clears search textbox in Filters panel
	And User enters "Device Owner User Field" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories             |
    | Device Owner User Field 1 |
    | Device Owner User Field 2 |
	When User clears search textbox in Filters panel
	And User enters "Device Owner Zip Code" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
    | Subcategories         |
    | Device Owner Zip Code |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194 @DAS16485
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerCustomItemHasCorrectFilterOptions
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And user select "Device Owner Zip Code" filter
	And User select "Does not equal" Operator value
	And User select "Contains" Operator value
	And User select "Does not contain" Operator value
	And User select "egins with" Operator value
	And User select "Does not begin with" Operator value
	And User select "Ends with" Operator value
	And User select "Does not end with" Operator value
	And User select "Empty" Operator value
	And User select "Not empty" Operator value

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17588
Scenario: EvergreenJnr_ApplicationsList_CheckAutomationsCategoryOrder
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	Then Category Automations displayed before projects categories

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17727 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOrderOfFiltersInDeviceHardwareCategory
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Device Hardware" filter category
	Then the following Filters subcategories are displayed for open category:
    | Subcategories                       |
    | Device CPU Architecture             |
    | Device CPU Speed (GHz)              |
    | Device Format                       |
    | Device HDD Total Size (GB)          |
    | Device IP Address                   |
    | Device IP v6 Address                |
    | Device Manufacturer                 |
    | Device Memory (GB)                  |
    | Device Model                        |
    | Device Target Drive Free Space (GB) |
    | Device TPM Enabled                  |
    | Device TPM Version                  |
    | Device Type                         |
    | Device Virtual Machine Host         |

@Evergreen @Devices @Users @Applications @Mailboxes @FiltersDisplay @ColumnsDisplay @DAS17943
Scenario Outline: EvergreenJnr_AdminPage_CheckThaSearchfieldHasProperPlaceholderForFiltersAndColumns
	When User clicks '<PageName>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Filter Searchfield placeholder is 'Search filters'
	When User clicks the Columns button
	Then Columns Searchfield placeholder is 'Search columns'

	Examples:
    | PageName     | ListName         |
    | Devices      | All Devices      |
    | Users        | All Users        |
    | Applications | All Applications |
    | Mailboxes    | All Mailboxes    |