@retry:1
Feature: RemoveColumn
	Runs Remove column related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumnInCustomList
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Device Key |
	When User create dynamic list with "RemovingSortedColumnInCustomList" name on "Devices" page
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
	When User remove sorted column on "Devices" page by URL
	| ColumnName   |
	| Boot Up Date |
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingMultipleSortedColumnInCustomList
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	When User create dynamic list with "TestList474460" name on "Devices" page
	Then "TestList474460" list is displayed to user
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
	Then date in table is sorted by 'Boot Up Date' column in descending order
	When User remove sorted column on "Devices" page by URL
	| ColumnName   |
	| Boot Up Date |
	When User update current custom list
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @DAS11951 @DAS12351 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingSortedColumnInCustomListThrowFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create dynamic list with "TestList32EDC3" name on "Devices" page
	Then "TestList32EDC3" list is displayed to user
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
	When User remove sorted column on "Devices" page by URL
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
	When User add following columns using URL to the "Devices" page:
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	When User click on 'Boot Up Date' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Boot Up Date" column by Column panel
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	When User click on 'Windows7Mi: Date & Time Task' column header
	When User remove sorted column on "Devices" page by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorPageIsNotDisplayedAfterRemovingMultipleSortedColumnInDefaultList
	When User add following columns using URL to the "Devices" page:
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
	Then date in table is sorted by 'Windows7Mi: Date & Time Task' column in descending order
	When User remove sorted column on "Devices" page by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then date in table is sorted by 'Build Date' column in descending order

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS10966 @DAS10973 @DAS12351
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
	When User remove sorted column on "Devices" page by URL
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
	When User add following columns using URL to the "Users" page:
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |
	Then "Last Logon Date" column is added to URL on "Users" page
	And "Home Drive" column is added to URL on "Users" page
	When User click on 'Last Logon Date' column header
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Last Logon Date" column by Column panel
	Then "Home Drive" column is added to URL on "Users" page
	When User removes "Home Drive" column by Column panel
	Then "Users" list should be displayed to the user
	And ColumnName is removed from the list
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS11044 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingColumnsFromUrlIsWorksCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestListC6636D" name on "Devices" page
	Then "TestListC6636D" list is displayed to user
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
	And "Compliance" column is added to URL on "Devices" page
	And "Device Key" column is added to URL on "Devices" page
	When User removes all columns by URL
	Then ColumnName is removed from the list
	| ColumnName |
	| Compliance |
	| Device Key |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS11044 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingColumnAndFilterFromUrlWorksCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList0E8A84" name on "Devices" page
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
	And "Compliance" filter with "Red" values is added to URL on "Devices" page
	And "Compliance" column is added to URL on "Devices" page
	And "Device Key" column is added to URL on "Devices" page
	When User removes all filters and columns by url
	Then ColumnName is removed from the list
	| ColumnName |
	| Compliance |
	| Device Key |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS1044 @DAS11506 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingColumnAndFilterAndCustomListFromUrlWorksCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList3C5E3C" name on "Devices" page
	Then "TestList3C5E3C" list is displayed to user
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
	And "Compliance" filter with "Red" values is added to URL on "Devices" page
	And "Compliance" column is added to URL on "Devices" page
	And "Device Key" column is added to URL on "Devices" page
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
	And "Windows7Mi: SS Project Date Enabled" column is added to URL on "Devices" page
	And "Owner Common Name" column is added to URL on "Devices" page
	When User remove column on "Devices" page by URL 
	| ColumnName        |
	| Owner Common Name |
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And ColumnName is removed from the list
	| ColumnName        |
	| Owner Common Name |
	And "26" subcategories is displayed for "Device Owner" category

@Evergreen @Users @EvergreenJnr_Columns @RemoveColumn @DAS11515 @DAS11506
Scenario: EvergreenJnr_UsersList_CheckThatColumnIsDisplayedInColumnsPanelAfterRemovingAllColumnsFromTheURL
	When User add following columns using URL to the "Users" page:
	| ColumnName                                   |
	| Last Logon Date                              |
	| Enabled                                      |
	| Windows7Mi: Read Only on Project Object Page |
	Then "Last Logon Date" column is added to URL on "Users" page
	And "Enabled" column is added to URL on "Users" page
	And "Windows7Mi: Read Only on Project Object Page" column is added to URL on "Users" page
	When User removes all columns by URL
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	And ColumnName is removed from the list
	| ColumnName                                   |
	| Last Logon Date                              |
	| Enabled                                      |
	| Windows7Mi: Read Only on Project Object Page |
	And "18" subcategories is displayed for "User" category
	#And "50" subcategories is displayed for "Project Tasks: Windows7Mi" category

@Evergreen @Applications @EvergreenJnr_Columns @RemoveColumn @DAS11515 @DAS12221 @DAS12351
Scenario: EvergreenJnr_ApplicationsList_CheckThatColumnIsDisplayedInColumnsPanelAfterRemovingAColumnWhichAlsoExistsAsAFilter
	When User add following columns using URL to the "Applications" page:
	| ColumnName                 |
	| Application Key            |
	| Windows7Mi: Technical Test |
	Then "Applications" list should be displayed to the user
	And "Application Key" column is added to URL on "Applications" page
	And "Windows7Mi: Technical Test" column is added to URL on "Applications" page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Technical Test" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	#| Not Started        |
	| Started            |
	Then "Windows7Mi: Technical Test" filter is added to the list
	And "4" rows are displayed in the agGrid
	When User remove column on "Applications" page by URL 
	| ColumnName                 |
	| Windows7Mi: Technical Test |
	Then "4" rows are displayed in the agGrid
	And "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And ColumnName is removed from the list
	| ColumnName                 |
	| Windows7Mi: Technical Test |
	And "10" subcategories is displayed for "Project Tasks: Windows7Mi" category

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

@Evergreen @Mailboxes @EvergreenJnr_Columns @RemoveColumn @DAS12513
Scenario: EvergreenJnr_MailboxesList_CheckThatNoErrorsAreDisplayedAfterAddingAndRemovingOwnerEnabledColumnForMailboxes
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Enabled" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then ColumnName is added to the list
	| ColumnName    |
	| Owner Enabled |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Mail Server" column by Column panel
	When User removes "Mailbox Type" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	Then "Mailboxes" list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS12513
Scenario: EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedAfterAddingAndRemovingOwnerEnabledColumnForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Enabled" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then ColumnName is added to the list
	| ColumnName    |
	| Owner Enabled |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	Then "Devices" list should be displayed to the user