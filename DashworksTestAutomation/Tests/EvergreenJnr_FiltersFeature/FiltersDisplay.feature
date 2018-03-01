@retry:1
Feature: FiltersDisplay
	Runs Dynamic Filters Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user   

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10651
Scenario: EvergreenJnr_ApplicationsList_CheckTrue-FalseOptionsAndImagesInFilterInfo
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Hide from End Users" filter
	Then correct true and false options are displayed in filter settings
	When User have created "Equals" filter without column and following options:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	Then Values is displayed in added filter info
	| Values  |
	| true    |
	| false   |
	| Unknown |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10754 @DAS11142 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckSpecialCharactersDisplayInFilterInfo
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Group" filter is not presented in the filters list
	Then "Windows7Mi: Group Key" filter is not presented in the filters list
	Then "Windows7Mi: Team" filter is not presented in the filters list
	Then "Windows7Mi: Team Key" filter is not presented in the filters list

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10776
Scenario: EvergreenJnr_DevicesList_CheckThatEmptyAndNotEmptyOptionsIsAvaildableForObjectKeyFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "AD Object Key" filter
	Then "Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to, Empty, Not empty" option is available for this filter

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS10781 @DAS11573 
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnOptionIsAvailableForFilters
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS11187
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnOptionIsNotAvailableForApplicationCustomFieldsFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Computer Warranty" filter
	Then "Add column" checkbox is not displayed

@Evergreen @AllLisrs @Evergreen_FiltersFeature @FiltersDisplay @DAS10771
Scenario Outline: EvergreenJnr_AllLisrs_CheckThatNoneOptionIsAvailableForFilters
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "None" option is available at first place

Examples: 
	| PageName     | FilterName           |
	| Devices      | Windows7Mi: Category |
	| Users        | UserSchedu: Category |
	| Applications | Havoc(BigD: Category |
	| Mailboxes    | EmailMigra: Category |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	| Does not equal   | 00BDM1JUR8IF419 | 17,224    | is not              |
	| Contains         | 00B             | 6         | contains            |
	| Does not contain | 00BDM1J         | 17,224    | does not contain    |
	| Begins with      | 00              | 14        | begins with         |
	| Ends with        | 41              | 7         | ends with           |
	| Empty            |                 |           | is empty            |
	| Not empty        |                 | 17,225    | is not empty        |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_UsersList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "<operatorValue>" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <filterOption>     |
	Then "Compliance" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |

Examples: 
	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
	| Equals         | Red          | 9,438     | is                  |
	| Does not equal | Red          | 31,897    | is not              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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

 @Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_MailboxesList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
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
	| Equals         | 8 Mar 2016   | 3         | is                  |
	| Does not equal | 8 Mar 2016   | 14,781    | is not              |
	| Before         | 8 Mar 2016   | 4,699     | is before           |
	| After          | 8 Mar 2016   | 10,076    | is after            |
	| Empty          |              | 6         | is empty            |
	| Not empty      |              | 14,778    | is not empty        |

 @Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS11090
Scenario Outline: EvergreenJnr_DevicesList_CheckThatFilterOperatorsIsCorrectInFilterInfoDatetime
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Date & Time Task" filter where type is "<operatorValue>" with added column and following value:
	| Values         |
	| <filterOption> |
	Then "Windows7Mi: Date & Time Task" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |

Examples: 
	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
	| Equals         | 22 Nov 2012  | 16        | is                  |
	| Does not equal | 22 Nov 2012  | 17,209    | is not              |
	| Before         | 22 Nov 2012  | 1         | is before           |
	| After          | 14 May 2012  | 16        | is after            |
	| Empty          |              | 17,208    | is empty            |
	| Not empty      |              | 17        | is not empty        |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_UsersList_CheckThatFilterOperatorsIsCorrectInFilterInfoEnabled
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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
	| Equals         | TRUE         | 41,228    | is                  |
	| Does not equal | TRUE         | 107       | is not              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS11512 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckThatApplicationSavedListFilterIsWorkingCorrect
	When User add following columns using URL to the "Applications" page:
	| ColumnName      |
	| Application Key |
	When User create dynamic list with "TestList2854B3" name on "Applications" page
	Then "TestList2854B3" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList   | Association        |
	| TestList2854B3 | Not used on device |
	Then "Application" filter is added to the list
	Then "16,565" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values  |
	| in list |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsFilterIsContainsAllExpectedAssociations
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11142 @DAS11665 @Delete_Newly_Created_List @Not_Run
Scenario: EvergreenJnr_ApplicationsList_CheckThatBracketsAreDisplayedCorrectlyInFilterInfo
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                    |
	| wxPython 2.5.3.1 (unicode) for Python 2.3 |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                               |
	| Windows Installer SDK (Version 2.0) (3718.1)         |
	| Janus Systems Controls for Microsoft .NET (TRIAL)    |
	| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Contains" with added column and following value:
	| Values                                      |
	| (Version 6.0) (3672.1)                      |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Ends With" with added column and following value:
	| Values                              |
	| (self-installing)                   |
	Then "Application" filter is added to the list
	When User create custom list with "TestList3065CC" name
	Then "TestList3065CC" list is displayed to user
	And "3" rows are displayed in the agGrid
	When User navigates to the "All Applications" list
	Then "Applications" list should be displayed to the user
	When User navigates to the "TestList3065CC" list
	And User clicks the Filters button
	Then "TestList3065CC" list is displayed to user
	And "3" rows are displayed in the agGrid
	And Edit List menu is not displayed
	And Values is displayed in added filter info
	| Values                                               |
	| wxPython 2.5.3.1 (unicode) for Python 2.3            |
	| Windows Installer SDK (Version 2.0) (3718.1)         |
	| Janus Systems Controls for Microsoft .NET (TRIAL)    |
	| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
	| (Version 6.0) (3672.1)                               |
	| (self-installing)                                    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11142 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatApostrophesAreDisplayedCorrectlyInFilterInfo
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Display Name" filter where type is "Contains" with added column and following value:
	| Values |
	| '      |
	Then "Owner Display Name" filter is added to the list
	And "127" rows are displayed in the agGrid

@Evergreen @Mailboxes @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11351
Scenario Outline: EvergreenJnr_MailboxesList_DevicesList_CheckThatAddColumnOptionIsAvailableForOwnerDepartmentFilter
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
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

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11087
Scenario: EvergreenJnr_DevicesList_CheckThatDateAndTimeFiltersWithEqualsValuesAreWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Date & Time Task" filter where type is "Equals" with added column and following value:
	| Values      |
	| 22 Nov 2012 |
	Then "Windows7Mi: Date & Time Task" filter is added to the list
	Then "16" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11087 @DAS11090
Scenario Outline: EvergreenJnr_DevicesList_CheckThatDateAndTimeFiltersWithDoesNotEqualValuesAreWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Does not equal" with added column and following value:
	| Values  |
	| <Value> |
	Then "<FilterName>" filter is added to the list
	And "<RowCount>" rows are displayed in the agGrid

Examples: 
	| FilterName                   | Value       | RowCount |
	| Windows7Mi: Date & Time Task | 22 Nov 2012 | 17,209   |
	| Build Date                   | 6 Nov 2004  | 17,224   |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11187
Scenario Outline: EvergreenJnr_DevicesList_CheckThatCustomFiltersAreContainsAllExpectedAssociations
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
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
	| Computer Field 1            |
	| Computer Field 2            |
	| Computer Warranty           |
	| ComputerCustomField         |
	| DAS-1814                    |
	| End of Life Date            |
	| Friendly Model Name         |
	| General information field 1 |
	| General information field 2 |
	| General information field 3 |
	| General information field 4 |
	| General information field 5 |
	| Mailbox Filter 1            |
	| Mailbox Filter 2            |
	| Telephone                   |
	| User Field 1                |
	| User Field 2                |
	| Zip Code                    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11165
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedForFilters
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheFiltersContainerIsDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User add "Department Code" filter where type is "Empty" with added column and following value:
	| Values |
	|        |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	Then "Department Code" filter is added to the list
	When User add "Boot Up Date" filter where type is "Before" with added column and "Thu Dec 14 2017" Date filter
	Then "Boot Up Date" filter is added to the list
	When User add "Boot Up Date" filter where type is "After" with added column and "Sun Dec 03 2017" Date filter
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
	And "(Compliance = Unknown, Red, Amber or Green) OR (Import != A01 SMS (Spoof)) OR (Department Code ~ ABC) OR (Department Code !~ ACV) OR (Department Code BEGINS WITH AXZ) OR (Department Code ENDS WITH YQA) OR (Department Code = EMPTY) OR (Department Code != EMPTY) OR (Boot Up Date < 14 Dec 2017) OR (Boot Up Date > 03 Dec 2017) OR (CPU Count > 66) OR (CPU Count >= 12) OR (CPU Count < 31) OR (CPU Count <= 13)" text is displayed in filter container

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10790 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationFiltersBeingAppliedAgainstTheDevicesListAreRestoredCorrectlyAndAreShownInTheFiltersPanel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| 7zip (2015)    | Entitled to device |
	Then "Application" filter is added to the list
	Then "11" rows are displayed in the agGrid
	Then "(Application = 7zip (2015) ASSOCIATION = ("entitled to device"))" text is displayed in filter container
	Then "Application 7zip (2015) is entitled to device" is displayed in added filter info
	When User create dynamic list with "TestList44C8B6" name on "Devices" page
	Then "TestList44C8B6" list is displayed to user
	When User navigates to the "All Devices" list
	When User navigates to the "TestList44C8B6" list
	Then "TestList44C8B6" list is displayed to user
	Then "11" rows are displayed in the agGrid
	And "(Application = 7zip (2015) ASSOCIATION = ("entitled to device"))" text is displayed in filter container
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application 7zip (2015) is entitled to device" is displayed in added filter info

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11539
Scenario: EvergreenJnr_DevicesList_CheckThatFilterCategoriesAreClosedAfterClearingAFilterSearchValue
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User enters "date" text in Search field at Filters Panel
	Then Minimize buttons are displayed for all category in Filters panel
	When User clears search textbox in Filters panel
	Then Maximize buttons are displayed for all category in Filters panel

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_DevicesList_CheckThatRelevantDataSetBeDisplayedAfterEditingFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	Then message 'No devices found' is displayed to the user
	When User click Edit button for "Compliance" filter
	When User change selected checkboxes:
	| Option         | State |
	| Not Applicable | false |
	| Green          | true  |
	Then "71" rows are displayed in the agGrid

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_UsersList_CheckThatRelevantDataSetBeDisplayedAfterResettingFilter
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| UNKNOWN            |
	Then "Enabled" filter is added to the list
	And message 'No users found' is displayed to the user
	When User have reset all filters
	Then "Users" list should be displayed to the user
	And "41,335" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelevantDataSetBeDisplayedAfterRemovingFilter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Import Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| App-V              |
	Then "Import Type" filter is added to the list
	And message 'No applications found' is displayed to the user
	When User have removed "Import Type" filter
	Then "Applications" list should be displayed to the user
	And "2,223" rows are displayed in the agGrid

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_MailboxesList_CheckThatRelevantDataSetBeDisplayedAfterNavigatingToANewList
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| TRUE               |
	Then "Enabled" filter is added to the list
	And message 'No mailboxes found' is displayed to the user
	When User navigates to the "All Mailboxes" list
	Then "Mailboxes" list should be displayed to the user
	And "14,784" rows are displayed in the agGrid

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11467 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatMultipleFilterCriteriaToApplicationNameDisplayedCorrectlyWhenUsingTheContainsOperator
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Contains" with following Value and Association:
	| Values    | Association         |
	| adobe     | Installed on device |
	| microsoft |                     |
	Then "Application whose Name" filter is added to the list
	And "Application whose Name contains adobe or microsoft is installed on device" is displayed in added filter info
	When User create dynamic list with "TestListF9A187" name on "Devices" page
	Then "TestListF9A187" list is displayed to user
	And "10,258" rows are displayed in the agGrid
	And Edit List menu is not displayed
	And "(Application Name ~ (adobe, microsoft) ASSOCIATION = (installed on device))" text is displayed in filter container


@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedForStaticListAfterRemovingAssociationsList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "StaticListTestName" name
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList       | Association        |
	| StaticListTestName | Not used on device |
	Then "Application in list StaticListTestName is not used on device" is displayed in added filter info
	When User create custom list with "TestList8D5C03" name
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	Then User remove list with "StaticListTestName" name on "Applications" page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList8D5C03" list
	Then "TestList8D5C03" list is displayed to user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedForDynamicListAfterRemovingAssociationsList
	When User add following columns using URL to the "Applications" page:
	| ColumnName      |
	| Application Key |
	When User create dynamic list with "TestList5E021D" name on "Applications" page
	Then "TestList5E021D" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList   | Association        |
	| TestList5E021D | Not used on device |
	Then "Application in list TestList5E021D is not used on device" is displayed in added filter info
	When User create dynamic list with "TestList5E021D" name on "Devices" page
	Then "TestList5E021D" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	Then User remove list with "TestList5E021D" name on "Applications" page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList5E021D" list
	Then "TestList5E021D" list is displayed to user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11663
Scenario: EvergreenJnr_DevicesLists_CheckThatRowCountIsNotDisplayedWhenNoObjectsAreFoundAfterApplyingAFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values  |
	| Example |
	Then "Hostname" filter is added to the list
	And "" rows are displayed in the agGrid

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11575
Scenario: EvergreenJnr_DevicesLists_CheckThatFilterLogicForBooleanFieldsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Secure Boot Enabled" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| UNKNOWN            |
	Then "Secure Boot Enabled" filter is added to the list
	Then table data in column is filtered correctly

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11660 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesLists_CheckThatOperatorsForApplicationSavedListFilterIsDisplayedCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName |
	| Compliance |
	When User create dynamic list with "TestSavedList009" name on "Applications" page
	Then "TestSavedList009" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then "In list" option is available for this filter

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FiltersDisplay @DAS11619
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisabledForAlreadySelectedColumn
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11088
Scenario Outline: EvergreenJnr_DevicesList_CheckThatConsoleErrorsAreNotDisplayedForDateFilters
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then There are no errors in the browser console

Examples: 
	| ListName     | FilterName                   |
	| Devices      | Build Date                   |
	| Devices      | Owner Last Logon Date        |
	| Devices      | Windows7Mi: Date & Time Task |
	| Users        | Barry'sUse: Scheduled Date   |
	| Applications | UserSchedu: Date App Req A   |
	| Mailboxes    | Created Date                 |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FiltersDisplay @DAS11829
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisplayedForOrganisationCategoryFilters
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
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

