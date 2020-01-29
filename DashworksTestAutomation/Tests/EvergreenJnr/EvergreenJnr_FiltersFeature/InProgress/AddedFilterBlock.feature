Feature: AddedFilterBlock
	Runs Filters Info block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS18833
Scenario: EvergreenJnr_DevicesList_CheckDisplayingListAfterAppliyingFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User selects "1803: Owner (Saved List)" filter from "Saved List" category
	And User checks 'Users with Device Count' checkbox
	And User clicks Add New button on the Filter panel
	Then "Owner: 1803 in list Users with Device Count" is displayed in added filter info

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
	When User creates 'TestList5434' dynamic list
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
	And User creates 'TestList5435' dynamic list
	And User navigates to the "All Applications" list
	And User navigates to the "TestList5435" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "User whose Region is Empty has used app" is displayed in added filter info

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
	Then Details panel is displayed to the user
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



@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	And User creates '<CustomList>' dynamic list
	And User navigates to the "<AllList>" list
	And User navigates to the "<CustomList>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "<FilterInfo>" is displayed in added filter info

	Examples:
		| ListName  | FilterName | CustomList   | AllList       | FilterInfo         |
		| Devices   | OS Branch  | TestList5433 | All Devices   | OS Branch is Empty |
		| Mailboxes | Country    | TestList5436 | All Mailboxes | Country is Empty   |


@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @DAS12152 @DAS12602 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThat500ErrorIsNotDisplayedForStaticListAfterRemovingAssociationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
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
