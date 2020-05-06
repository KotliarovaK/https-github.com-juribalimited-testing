Feature: ColumnSectionDisplay
	Runs Column Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS10584
Scenario: EvergreenJnr_DevicesList_CheckCategoryHeadingWhenAllColumnsFromCategoryAreAdded
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User add all Columns from specific category
	| CategoryName |
	| Application  |
	Then "Applications" section is not displayed in the Columns panel

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11539
Scenario: EvergreenJnr_DevicesList_CheckThatColumnCategoriesAreClosedAfterClearingAColumnSearchValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User enters "date" text in Search field at Columns Panel
	Then Minimize buttons are displayed for all category in Columns panel
	When User clears search textbox in Columns panel
	Then Maximize buttons are displayed for all category in Columns panel

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS10583
Scenario: EvergreenJnr_DevicesList_CheckThatColumnIsNotRemovedAfterApplyFilterForTheSameColumnName
	When User add following columns using URL to the "Devices" page:
	| ColumnName   |
	| Manufacturer |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Manufacturer" filter
	Then "Add Manufacturer column" checkbox is checked
	When User have created "Equals" Lookup filter with column and "Acer" option
	Then "Manufacturer" filter is added to the list
	Then ColumnName is added to the list
	| ColumnName   |
	| Manufacturer |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11480
Scenario: EvergreenJnr_DevicesList_CheckThatAppropriateIconsAreDisplayedForMaximizedAndMinimizeGroups
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then Maximize buttons are displayed for all category in Columns panel
	When User enters "group" text in Search field at Columns Panel
	Then Minimize buttons are displayed for all category in Columns panel

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11668
Scenario: EvergreenJnr_DevicesList_CheckThatAllColumnsAreVisibleInTheirRelevantCategoryAfterResetting
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Import     |
	| Compliance |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then "13" subcategories is displayed for "Device" category
	When User have reset all columns
	Then "15" subcategories is displayed for "Device" category

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11548 @DAS13423
Scenario: EvergreenJnr_MailboxesList_CheckThatCategoryRemainsOpenAfterAddingColumns
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User expands 'Mailbox' category
	When User add "Alias" Column from expanded category
	Then Minimize button is displayed for "Mailbox" category
	When User add "Created Date" Column from expanded category
	Then ColumnName is added to the list
	| ColumnName   |
	| Alias        |
	| Created Date |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768
Scenario: EvergreenJnr_DevicesList_CheckTheColumnCategoriesUpdatesAfterAddingColumn
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	Then ColumnName is added to the list
	| ColumnName |
	| Build Date |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @DAS11951 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForDynamicLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Domain' column header
	Then data in table is sorted by 'Domain' column in ascending order
	When User create dynamic list with "DynamicList" name on "Users" page
	Then "DynamicList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Zip Code   |
	Then ColumnName is added to the list
	| ColumnName |
	| Zip Code   |
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Zip Code   |
	Then ColumnName is added to the list
	| ColumnName |
	| Zip Code   |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @DAS12152 @DAS12553 @DAS12602 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForStaticLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList" name
	Then "StaticList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Windows7Mi: In Scope |
	Then ColumnName is added to the list
	| ColumnName           |
	| Windows7Mi: In Scope |
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Windows7Mi: In Scope |
	Then ColumnName is added to the list
	| ColumnName           |
	| Windows7Mi: In Scope |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @DAS11951 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForDynamicLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks on 'Email Address' column header
	Then data in table is sorted by 'Email Address' column in ascending order
	When User create dynamic list with "DynamicList" name on "Mailboxes" page
	Then "DynamicList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                 |
	| EmailMigra: Pre-Migration \ Scheduled date |
	Then ColumnName is added to the list
	| ColumnName                                 |
	| EmailMigra: Pre-Migration \ Scheduled date |
	When User navigates to the "All Mailboxes" list
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                 |
	| EmailMigra: Pre-Migration \ Scheduled date |
	Then ColumnName is added to the list
	| ColumnName                                 |
	| EmailMigra: Pre-Migration \ Scheduled date |

@Evergreen @AllLists @EvergreenJnr_GridActions @ColumnOrder @DAS11463
Scenario: EvergreenJnr_AllLists_CheckThatColumnsIsNotRemovedAfterDraggingThemOutsideTheAgGrid
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User moves "Hostname" column beyond the Grid
	When User moves "Device Type" column beyond the Grid
	When User moves "Operating System" column beyond the Grid
	When User moves "Owner Display Name" column beyond the Grid
	Then grid headers are displayed in the following order
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is added to the list
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User moves "Username" column beyond the Grid
	When User moves "Domain" column beyond the Grid
	When User moves "Display Name" column beyond the Grid
	When User moves "Distinguished Name" column beyond the Grid
	Then grid headers are displayed in the following order
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is added to the list
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User moves "Vendor" column beyond the Grid
	When User moves "Version" column beyond the Grid
	Then grid headers are displayed in the following order
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is added to the list
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User moves "Email Address" column beyond the Grid
	When User moves "Mailbox Platform" column beyond the Grid
	When User moves "Mail Server" column beyond the Grid
	When User moves "Mailbox Type" column beyond the Grid
	When User moves "Owner Display Name" column beyond the Grid
	Then grid headers are displayed in the following order
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is added to the list
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13181 @DAS13376
Scenario: EvergreenJnr_UsersList_ChecksThatColumnsPanelIsDisplayedCorrectlyAfterApplyAnyFilterFromApplicationCustomFieldsCategory
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Owner" filter where type is "Equals" with following Value and Association:
	| Values | Association  |
	| 123    | Used by user |
	Then "Application Owner" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then Maximize button is displayed for "User" category

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Import     |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	| 00I0COBFWHOF27   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListFromTheAllList" name
	Then "StaticListFromTheAllList" list is displayed to user
	When User navigates to the "All Devices" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YWR8TJU4ZF8V   |
	| 00RUUMAH9OZN9A   |
	And User selects 'Add to static list' in the 'Action' dropdown
	Then 'ADD' button is disabled
	And User selects "StaticListFromTheAllList" List in Saved List dropdown
	When User clicks 'ADD' button 
	Then "4" rows are displayed in the agGrid
	And grid headers are displayed in the following order
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Compliance         |
	| Import             |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Enabled    |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Enabled    |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	| 0072B088173449E3A93 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListFromTheAllList" name
	Then "StaticListFromTheAllList" list is displayed to user
	When User navigates to the "All Users" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 00CFE13AAE104724AF5 |
	| 00DB4000EDD84951993 |
	Then User add selected rows in "StaticListFromTheAllList" list
	Then "4" rows are displayed in the agGrid
	And grid headers are displayed in the following order
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Compliance         |
	| Enabled            |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	| Import     |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                                |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListFromTheAllList" name
	Then "StaticListFromTheAllList" list is displayed to user
	When User navigates to the "All Applications" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName    |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	| 20040610sqlserverck                      |
	Then User add selected rows in "StaticListFromTheAllList" list
	Then "4" rows are displayed in the agGrid
	And grid headers are displayed in the following order
	| ColumnName         |
	| Application        |
	| Vendor             |
	| Version            |
	| Compliance         |
	| Import             |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Cleanup
Scenario: EvergreenJnr_MailboxesList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnMailboxesPage
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Alias      |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Alias      |
	| Import     |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	| 002B5DC7D4D34D5C895@bclabs.local |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListFromTheAllList" name
	Then "StaticListFromTheAllList" list is displayed to user
	When User navigates to the "All Mailboxes" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 00B5CCB89AD0404B965@bclabs.local |
	Then User add selected rows in "StaticListFromTheAllList" list
	And "4" rows are displayed in the agGrid
	And grid headers are displayed in the following order
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	| Alias              |
	| Import             |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatAfterAddingRowsToAStaticListFromADynamicListTheColumnsIsDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User create dynamic list with "DynamicList13059" name on "Devices" page
	And User navigates to the "All Devices" list
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Import     |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YTY8U3ZYP2WT   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListFromADynamicList" name
	Then "StaticListFromADynamicList" list is displayed to user
	When User navigates to the "DynamicList13059" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	Then User add selected rows in "StaticListFromADynamicList" list
	Then "2" rows are displayed in the agGrid
	And grid headers are displayed in the following order
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Import             |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatAfterAddingRowsToAStaticListFromAStaticListTheColumnsIsDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "FirstStaticList13059" name
	Then "FirstStaticList13059" list is displayed to user
	When User navigates to the "All Devices" list
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Import     |
	Then ColumnName is added to the list
	| ColumnName |
	| Import     |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YWR8TJU4ZF8V   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "SecondStaticList13059" name
	Then "SecondStaticList13059" list is displayed to user
	When User navigates to the "FirstStaticList13059" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	Then User add selected rows in "SecondStaticList13059" list
	Then "2" rows are displayed in the agGrid
	And grid headers are displayed in the following order
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Import             |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13245 @DAS15566
Scenario: EvergreenJnr_DevicesList_TheSelectedColumnsCategoryIsDisplayedAfterUsingTheFilterSearch
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then the following Filters subcategories are displayed for open category:
	| Subcategories      |
	| Device Type        |
	| Hostname           |
	| Operating System   |
	| Owner Display Name |
	When User enters "Hostname" text in Search field at Filters Panel
	And User clears search textbox in Filters panel
	Then the following Filters subcategories are displayed for open category:
	| Subcategories      |
	| Device Type        |
	| Hostname           |
	| Operating System   |
	| Owner Display Name |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13245
Scenario: EvergreenJnr_DevicesList_TheSelectedColumnsCategoryIsDisplayedAfterAddingAFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then the following Filters subcategories are displayed for open category:
	| Subcategories      |
	| Device Type        |
	| Hostname           |
	| Operating System   |
	| Owner Display Name |
	When User selects "Compliance" filter from "Device" category
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| Red                |
	When User clicks Add New button on the Filter panel
	Then the following Filters subcategories are displayed for open category:
	| Subcategories      |
	| Compliance         |
	| Device Type        |
	| Hostname           |
	| Operating System   |
	| Owner Display Name |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12861
Scenario: EvergreenJnr_DevicesList_ChecksThatSubcategoriesOnFiltersPanelAreDisplayedInAlphabeticalOrder
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| Compliance   |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then the following subcategories are displayed for Selected Columns category:
	| Subcategories      |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Compliance         |
	And grid headers are displayed in the following order
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Compliance         |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then the subcategories are displayed for open category in alphabetical order on Filters panel

@Evergreen @AllLists @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12940 @DAS13201 @DAS14325
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketAndCapacityUnitSubcategoriesPlacedInEvergreenCategoryInColumnsPanel
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Columns button
	Then "Evergreen" section is displayed in the Columns panel
	When User collapses 'Selected Columns' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Mailboxes    |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12940 @DAS13201 @DAS14325
Scenario: EvergreenJnr_ApplicationsList_CheckThatCapacityUnitSubcategoryPlacedInEvergreenCategoryInColumnsPanel
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Columns button
	Then "Evergreen" section is displayed in the Columns panel
	When User collapses 'Selected Columns' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                   |
	| Criticality                     |
	| Evergreen Capacity Unit         |
	| Evergreen Rationalisation       |
	| Evergreen Target App Compliance |
	| Evergreen Target App Key        |
	| Evergreen Target App Name       |
	| Evergreen Target App Vendor     |
	| Evergreen Target App Version    |
	| Hide From End Users             |
	| In Catalog                      |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12861 @DAS13299
Scenario: EvergreenJnr_ApplicationsList_ChecksThatSubcategoriesOnColumnsPanelAreDisplayedInAlphabeticalOrderAfterAddingFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" with added column and following value:
	| Values |
	| 121    |
	Then "Application Key" filter is added to the list
	When User add "Inventory Site" filter where type is "Equals" with added column and "Altiris" Lookup option
	Then "Inventory Site" filter is added to the list
	And grid headers are displayed in the following order
	| ColumnName         |
	| Application        |
	| Vendor             |
	| Version            |
	| Application Key    |
	| Inventory Site     |
	When User clicks Add New button on the Filter panel
	Then the subcategories are displayed for open category in alphabetical order on Filters panel
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And the following subcategories are displayed for Selected Columns category:
	| Subcategories      |
	| Application        |
	| Vendor             |
	| Version            |
	| Application Key    |
	| Inventory Site     |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12861
Scenario: EvergreenJnr_UsersList_ChecksThatSubcategoriesOnColumnsPanelAreDisplayedInAlphabeticalOrderAfterAddingDepartmentFilters
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "Finance" Tree List option
	Then grid headers are displayed in the following order
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Department Name    |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And the following subcategories are displayed for Selected Columns category:
	| Subcategories      |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Department Name    |
	When User collapses 'Selected Columns' category
	When User add "Department Full Path" Column from expanded category
	When User expands 'Selected Columns' category
	Then the following subcategories are displayed for Selected Columns category:
	| Subcategories        |
	| Username             |
	| Domain               |
	| Display Name         |
	| Distinguished Name   |
	| Department Name      |
	| Department Full Path |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then the subcategories are displayed for open category in alphabetical order
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes ColumnName column by Column panel
	| ColumnName           |
	| Department Name      |
	| Department Full Path |
	When User collapses 'Selected Columns' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories        |
	| Department Full Path |
	| Department Name      |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User have reset all filters
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When User collapses 'Selected Columns' category
	When User expands 'Organisation' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories        |
	| Cost Centre          |
	| Department Code      |
	| Department Full Path |
	| Department Level 1   |
	| Department Level 2   |
	| Department Level 3   |
	| Department Level 4   |
	| Department Level 5   |
	| Department Level 6   |
	| Department Level 7   |
	| Department Name      |

@Evergreen @AllLists @EvergreenJnr_Columns @ColumnSectionDisplay @DAS12922
Scenario: EvergreenJnr_AllLists_LocationAndUserFiltersEqualsOnUsersAndApplicationsTabs
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| App Count (Used) |
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Username" column by Column panel
	And User removes "Domain" column by Column panel
	And User removes "Display Name" column by Column panel
	And User removes "Distinguished Name" column by Column panel
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "User" with "30" category is displayed on Filters panel
	And "Location" with "8" category is displayed on Filters panel
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "User" with "26" category is displayed on Filters panel
	And "User Location" with "8" category is displayed on Filters panel

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS12910
Scenario: EvergreenJnr_MailboxesList_ChecksThatSubcategoriesOnColumnsPanelIsDisplayedCorrectlyAfterAddingObjectIdFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Object ID" filter where type is "Equals" with added column and following value:
	| Values |
	| 1      |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And the following subcategories are displayed for Selected Columns category:
	| Subcategories         |
	| Email Address         |
	| Mailbox Platform      |
	| Mail Server           |
	| Mailbox Type          |
	| Owner Display Name    |
	| EmailMigra: Object ID |
	And There are no errors in the browser console
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "EmailMigra: Object ID" filter
	And User select "Not empty" Operator value
	And User clicks Save filter button
	And User creates 'Object ID != EMPTY' dynamic list
	Then "Object ID != EMPTY" list is displayed to user

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS14629 @DAS14660 @DAS15167
Scenario: EvergreenJnr_UsersList_CheckThatPrimaryDeviceColumnIsAvailableInTheColumnsPanelForUsersList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User expands 'User' category
	When User add "Primary Device" Column from expanded category
	When User clicks on 'Primary Device' column header
	When User clicks on 'Primary Device' column header
	When  User click content from "Primary Device" column
	Then Details object page is displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS14969 @archived
Scenario: EvergreenJnr_DevicesList_ChecksThatColumnsPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	Then Category with counter is displayed on Columns panel
	| Category                   | Number |
	| Project: Windows7Mi        | 19     |
	| Project Owner: Windows7Mi  | 16     |
	| Project Tasks: Windows7Mi  | 91     |
	| Project Stages: Windows7Mi | 7      |
	| Project: UserEvergr        | 17     |
	| Project Owner: UserEvergr  | 16     |
	| Project Tasks: UserEvergr  | 12     |
	| Project Stages: UserEvergr | 1      |
	And Category is not displayed in the Columns panel
	| Category                   |
	| Project: EmailMigra        |
	| Project Tasks: EmailMigra  |
	| Project Stages: EmailMigra |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS14969 @archived
Scenario: EvergreenJnr_UsersList_ChecksThatColumnsPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Users' on the left-hand menu
	And User clicks the Columns button
	Then Category with counter is displayed on Columns panel
	| Category                   | Number |
	| Project: Windows7Mi        | 17     |
	| Project Tasks: Windows7Mi  | 79     |
	| Project Stages: Windows7Mi | 6      |
	| Project: UserEvergr        | 19     |
	| Project Tasks: UserEvergr  | 26     |
	| Project Stages: UserEvergr | 2      |
	| Project: EmailMigra        | 17     |
	| Project Tasks: EmailMigra  | 9      |
	| Project Stages: EmailMigra | 3      |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS14969 @archived
Scenario: EvergreenJnr_ApplicationsList_ChecksThatColumnsPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Columns button
	Then Category with counter is displayed on Columns panel
	| Category                   | Number |
	| Project: Windows7Mi        | 25     |
	| Project Tasks: Windows7Mi  | 24     |
	| Project Stages: Windows7Mi | 2      |
	| Project: UserEvergr        | 25     |
	| Project Tasks: UserEvergr  | 14     |
	| Project Stages: UserEvergr | 1      |
	| Project: EmailMigra        | 25     |
	| Project Tasks: EmailMigra  | 5      |
	| Project Stages: EmailMigra | 1      |
	
@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS14969 @archived
Scenario: EvergreenJnr_MailboxesList_ChecksThatColumnsPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Columns button
	Then Category with counter is displayed on Columns panel
	| Category                   | Number |
	| Project: EmailMigra        | 18     |
	| Project Tasks: EmailMigra  | 54     |
	| Project Stages: EmailMigra | 6      |
	| Project: MailboxEve        | 18     |
	| Project Tasks: MailboxEve  | 15     |
	And Category is not displayed in the Columns panel
	| Category                   |
	| Project: Windows7Mi        |
	| Project Tasks: Windows7Mi  |
	| Project Stages: Windows7Mi |
	| Project: UserEvergr        |
	| Project Tasks: UserEvergr  |
	| Project Stages: UserEvergr |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS15140 @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_DevicesList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And User enters "ring" text in Search field at Columns Panel
	Then Category with counter is displayed on Columns panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: 2004       | 1      |
	| Project Rings: ComputerSc | 1      |
	| Project Rings: DeviceSche | 1      |
	| Project Rings: Havoc(BigD | 1      |
	| Project Rings: prK        | 1      |
	| Project Rings: Windows101 | 1      |
	| Project Rings: Windows102 | 1      |
	| Project Rings: Windows10T | 1      |
	| Project Rings: Windows10U | 1      |
	| Project Rings: Windows7Mi | 1      |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS15140 @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_UsersList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Users' on the left-hand menu
	And User clicks the Columns button
	And User enters "ring" text in Search field at Columns Panel
	Then Category with counter is displayed on Columns panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: Barry'sUse | 1      |
	| Project Rings: UserEvergr | 1      |
	| Project Rings: UserSched2 | 1      |
	| Project Rings: UserSchedu | 1      |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS15140 @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_MailboxesList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Columns button
	And User enters "ring" text in Search field at Columns Panel
	Then Category with counter is displayed on Columns panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: EmailMigra | 1      |
	| Project Rings: MailboxEve | 1      |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS15140 @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_ApplicationsList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Columns button
	And User enters "ring" text in Search field at Columns Panel
	Then Category with counter is displayed on Columns panel
	| Category            | Number |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS15899
Scenario: EvergreenJnr_DevicesList_CheckStageNameInTheFiltestForDevicesLists
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	When User enters "DeviceSche: Stage" text in Search field at Columns Panel
	When User collapses 'Selected Columns' category
	When User collapses 'Project Stages: DeviceSche' category
	Then the following Column subcategories are displayed for open category:
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

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS15899
Scenario: EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	When User enters "DeviceSche" text in Search field at Columns Panel
	When User collapses 'Selected Columns' category
	When User collapses 'Project: DeviceSche' category
	When User collapses 'Project Rings: DeviceSche' category
	When User collapses 'Project Stages: DeviceSche' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                               |
	| DeviceSche: Stage 2 \ user DDL task         |
	| DeviceSche: Stage 2 \ user radiobutton task |
	| DeviceSche: Stage 2 \ user text task        |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS15899
Scenario: EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	When User enters "MailboxEve" text in Search field at Columns Panel
	When User collapses 'Selected Columns' category
	When User collapses 'Project: MailboxEve' category
	When User collapses 'Project Rings: MailboxEve' category
	When User collapses 'Project Owner: MailboxEve' category
	Then the following Column subcategories are displayed for open category:
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

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS15899
Scenario: EvergreenJnr_ApplicationsList_CheckStageNameInTheFiltestForApplicationsLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	When User enters "DeviceSche" text in Search field at Columns Panel
	When User collapses 'Selected Columns' category
	When User collapses 'Project: DeviceSche' category
	When User collapses 'Project Owner: DeviceSche' category
	When User collapses 'Project Rings: DeviceSche' category
	When User collapses 'Project Stages: DeviceSche' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                              |
	| DeviceSche: Stage 2 \ app date task        |
	| DeviceSche: Stage 2 \ app radiobutton task |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS18795
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectRingsCategoryCorrectlyPlacedInColumnsPanel
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	When User collapses 'Selected Columns' category
	Then 'Project Rings' category is placed next to the corresponding project group

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS18861
Scenario: EvergreenJnr_MailboxesList_CheckSubcategoriesForOwnerCategoryColumn
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	When User collapses 'Selected Columns' category
	When User expands 'Mailbox Owner' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                   |
	| Owner Common Name               |
	| Owner Compliance                |
	| Owner Description               |
	| Owner Directory Type            |
	| Owner Distinguished Name        |
	| Owner Domain                    |
	| Owner Email Address             |
	| Owner Enabled                   |
	| Owner Given Name                |
	| Owner GUID                      |
	| Owner Home Directory            |
	| Owner Home Drive                |
	| Owner Key                       |
	| Owner Last Logon Date           |
	| Owner Organisational Unit       |
	| Owner Parent Distinguished Name |
	| Owner SID                       |
	| Owner Surname                   |
	| Owner Username                  |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS19721
Scenario: EvergreenJnr_ApplicationsList_CheckThatCriticalityColumnWorks
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName              |
	| Windows7Mi: Criticality |
	Then ColumnName is added to the list
	| ColumnName              |
	| Windows7Mi: Criticality |
	When User clicks on 'Windows7Mi: Criticality' column header
	When User clicks on 'Windows7Mi: Criticality' column header
	Then data in table is sorted by 'Windows7Mi: Criticality' column in descending order
	When User clicks the Columns button
	When User removes "Windows7Mi: Criticality" column by Column panel
	Then ColumnName is removed from the list
	| ColumnName              |
	| Windows7Mi: Criticality |
