﻿@retry:1
Feature: RemoveColumn
	Runs Remove column related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumnInCustomList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Device Key |
	Then ColumnName is added to the list
	| ColumnName |
	| Device Key |
	When User create custom list with "RemovingSortedColumnInCustomList" name
	Then "RemovingSortedColumnInCustomList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Boot Up Date  |
	Then ColumnName is added to the list
	| ColumnName   |
	| Boot Up Date |
	When User click on 'Device Key' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Device Key" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName |
	| Device Key |
	When User click on 'Boot Up Date' column header
	When User removes sorted column by URL
	| ColumnName   |
	| Boot Up Date |
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingMultipleSortedColumnInCustomList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	Then ColumnName is added to the list
	| ColumnName |
	| Build Date |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| Boot Up Date |
	Then ColumnName is added to the list
	| ColumnName   |
	| Boot Up Date |
	When User sort table by multiple columns
	| ColumnName                   |
	| Boot Up Date                 |
	| Build Date                   |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Build Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName |
	| Build Date |
	Then data in table is sorted by 'Boot Up Date' column in ascending order
	When User removes sorted column by URL
	| ColumnName   |
	| Boot Up Date |
	When User update current custom list
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumnInCustomListThrowFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Directory Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User click on 'Windows7Mi: Category' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Selected Columns" columns category
	When User removes "Windows7Mi: Category" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName           |
	| Windows7Mi: Category |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Category" filter is added to the list
	When User click on 'Directory Type' column header
	When User removes sorted column by URL
	| ColumnName     |
	| Directory Type |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is removed from the list
	| ColumnName     |
	| Directory Type |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Directory Type" filter is added to the list

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumnInDefaultList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	Then ColumnName is added to the list
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User click on 'Boot Up Date' column header
	When User removes "Boot Up Date" column by Column panel
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	When User click on 'Windows7Mi: Date & Time Task' column header
	When User removes sorted column by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingMultipleSortedColumnInDefaultList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	| Build Date                   |
	Then ColumnName is added to the list
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	| Build Date                   |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User sort table by multiple columns
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	| Build Date                   |
	When User removes "Boot Up Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in descending order
	When User removes sorted column by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then data in table is sorted by 'Build Date' column in descending order

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumnInDefaultListThrowFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User add "Directory Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User click on 'Windows7Mi: Category' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Selected Columns" columns category
	When User removes "Windows7Mi: Category" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName           |
	| Windows7Mi: Category |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Category" filter is added to the list
	When User click on 'Directory Type' column header
	When User removes sorted column by URL
	| ColumnName     |
	| Directory Type |
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is removed from the list
	| ColumnName     |
	| Directory Type |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Directory Type" filter is added to the list

@Evergreen @Users @EvergreenJnr_Columns @RemoveColumn @DAS10973
Scenario: EvergreenJnr_UsersList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumn
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |
	Then ColumnName is added to the list
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |
	And "Last Logon Date" column is added to URL
	And "Home Drive" column is added to URL
	When User click on 'Last Logon Date' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Last Logon Date" column by Column panel
	Then "Home Drive" column is added to URL
	When User removes "Home Drive" column by Column panel
	Then "Users" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS11044 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingColumnsFromUrlIsWorksCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in descending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	And User navigates to the "TestList" list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Device Key |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Device Key |
	And "Compliance" column is added to URL
	And "Device Key" column is added to URL
	When User removes all columns by URL
	Then ColumnName is removed from the list
	| ColumnName |
	| Compliance |
	| Device Key |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS11044 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingColumnAndFilterFromUrlWorksCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in descending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	And User navigates to the "TestList" list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Device Key |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Device Key |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	And "9,174" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Red" values is added to URL
	And "Compliance" column is added to URL
	And "Device Key" column is added to URL
	When User removes all filters and columns by url
	Then ColumnName is removed from the list
	| ColumnName |
	| Compliance |
	| Device Key |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS1044 @DAS11506 @Delete_Newly_Created_List @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingColumnAndFilterAndCustomListFromUrlWorksCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in descending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	And User navigates to the "TestList" list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Device Key |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Device Key |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	And "9,174" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Red" values is added to URL
	And "Compliance" column is added to URL
	And "Device Key" column is added to URL
	When User removes all filters and columns and custom list by url
	Then ColumnName is removed from the list
	| ColumnName |
	| Compliance |
	| Device Key |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS11515
Scenario: EvergreenJnr_DevicesList_CheckThatColumnIsDisplayedInColumnsPanelAfterRemovingOneColumnFromTheURL
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| Windows7Mi: SS Project Date Enabled |
	| Owner Common Name                   |
	Then ColumnName is added to the list
	| ColumnName                          |
	| Windows7Mi: SS Project Date Enabled |
	| Owner Common Name                   |
	And "Windows7Mi: SS Project Date Enabled" column is added to URL
	And "Owner Common Name" column is added to URL
	When User removes column by URL
	| ColumnName        |
	| Owner Common Name |
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is removed from the list
	| ColumnName        |
	| Owner Common Name |
	Then "25" subcategories is displayed for "Device Owner" category

@Evergreen @Users @EvergreenJnr_Columns @RemoveColumn @DAS11515 @DAS11506 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatColumnIsDisplayedInColumnsPanelAfterRemovingAllColumnsFromTheURL
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| Last Logon Date                              |
	| Enabled                                      |
	| Windows7Mi: Read Only on Project Object Page |
	Then ColumnName is added to the list
	| ColumnName                                   |
	| Last Logon Date                              |
	| Enabled                                      |
	| Windows7Mi: Read Only on Project Object Page |
	And "Last Logon Date" column is added to URL
	And "Enabled" column is added to URL
	And "Windows7Mi: Read Only on Project Object Page" column is added to URL
	When User removes all columns by URL
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	And ColumnName is removed from the list
	| ColumnName                                   |
	| Last Logon Date                              |
	| Enabled                                      |
	| Windows7Mi: Read Only on Project Object Page |
	And "18" subcategories is displayed for "User" category
	And "42" subcategories is displayed for "Project Tasks: Windows7Mi" category

@Evergreen @Applications @EvergreenJnr_Columns @RemoveColumn @DAS11515
Scenario: EvergreenJnr_ApplicationsList_CheckThatColumnIsDisplayedInColumnsPanelAfterRemovingAColumnWhichAlsoExistsAsAFilter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| Application Key            |
	| Windows7Mi: Technical Test |
	| DAS-1814                   |
	Then ColumnName is added to the list
	| ColumnName                 |
	| Application Key            |
	| Windows7Mi: Technical Test |
	| DAS-1814                   |
	And "Applications" list should be displayed to the user
	And "Application Key" column is added to URL
	And "Windows7Mi: Technical Test" column is added to URL
	And "DAS-1814" column is added to URL
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Technical Test" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Started        |
	| Started            |
	Then "Windows7Mi: Technical Test" filter is added to the list
	And "8" rows are displayed in the agGrid
	When User removes column by URL
	| ColumnName                 |
	| Windows7Mi: Technical Test |
	Then "8" rows are displayed in the agGrid
	And "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And ColumnName is removed from the list
	| ColumnName                 |
	| Windows7Mi: Technical Test |
	And "8" subcategories is displayed for "Project Tasks: Windows7Mi" category

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS11037
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ErrorNotDisplayedAfterRemovingUsernameOrHostnameColumn 
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "<ColumnName>" column by Column panel
	Then "<PageName>" list should be displayed to the user
	And ColumnName is removed from the list
	| ColumnName   |
	| <ColumnName> |

Examples: 
	| PageName | ColumnName |
	| Devices  | Hostname   |
	| Users    | Username   |