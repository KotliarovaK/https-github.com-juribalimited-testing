@retry:1
Feature: ColumnSectionDisplay
	Runs Column Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS10584
Scenario: EvergreenJnr_DevicesList_CheckCategoryHeadingWhenAllColumnsFromCategoryAreAdded
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User add all Columns from specific category
	| CategoryName |
	| Application  |
	Then "Applications" section is not displayed in the Columns panel

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11539
Scenario: EvergreenJnr_DevicesList_CheckThatColumnCategoriesAreClosedAfterClearingAColumnSearchValue
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	Then "9" subcategories is displayed for "Device" category
	When User have reset all columns
	Then "11" subcategories is displayed for "Device" category

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11548
Scenario: EvergreenJnr_MailboxesList_CheckThatCategoryRemainsOpenAfterAddingColumns
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Mailbox" columns category
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
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	Then ColumnName is added to the list
	| ColumnName |
	| Build Date |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForDynamicLists
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Domain' column header
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
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Zip Code   |
	Then ColumnName is added to the list
	| ColumnName |
	| Zip Code   |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @DAS12152 @DAS12553 @DAS12602 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForStaticLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User selects "Create static list" in the Actions dropdown
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
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Windows7Mi: In Scope |
	Then ColumnName is added to the list
	| ColumnName           |
	| Windows7Mi: In Scope |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForDynamicLists
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click on 'Email Address' column header
	Then data in table is sorted by 'Email Address' column in ascending order
	When User create dynamic list with "DynamicList" name on "Mailboxes" page
	Then "DynamicList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| EmailMigra: Scheduled date |
	Then ColumnName is added to the list
	| ColumnName                 |
	| EmailMigra: Scheduled date |
	When User navigates to the "All Mailboxes" list
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| EmailMigra: Scheduled date |
	Then ColumnName is added to the list
	| ColumnName                 |
	| EmailMigra: Scheduled date |

@Evergreen @AllLists @EvergreenJnr_GridActions @ColumnOrder @DAS11463 @Not_Run
Scenario: EvergreenJnr_AllLists_CheckThatColumnsIsNotRemovedAfterDraggingThemOutsideTheAgGrid
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User moves "Hostname" column beyond the Grid
	When User moves "Device Type" column beyond the Grid
	When User moves "Operating System" column beyond the Grid
	When User moves "Owner Display Name" column beyond the Grid
	Then Column is displayed in following order:
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User moves "Username" column beyond the Grid
	When User moves "Domain" column beyond the Grid
	When User moves "Display Name" column beyond the Grid
	When User moves "Distinguished Name" column beyond the Grid
	Then Column is displayed in following order:
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
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User moves "Vendor" column beyond the Grid
	When User moves "Version" column beyond the Grid
	Then Column is displayed in following order:
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
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User moves "Email Address" column beyond the Grid
	When User moves "Mailbox Platform" column beyond the Grid
	When User moves "Mail Server" column beyond the Grid
	When User moves "Mailbox Type" column beyond the Grid
	When User moves "Owner Display Name" column beyond the Grid
	Then Column is displayed in following order:
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

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13181
Scenario: EvergreenJnr_UsersList_ChecksThatColumnsPanelIsDisplayedCorrectlyAfterApplyAnyFilterFromApplicationCustomFieldsCategory
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Owner" filter where type is "Equals" with following Value and Association:
	| Values | Association  |
	| 123    | Used by user |
	Then "Application" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then Maximize button is displayed for "User" category

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticListFromTheAllList" name
	Then "StaticListFromTheAllList" list is displayed to user
	When User navigates to the "All Devices" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YWR8TJU4ZF8V   |
	| 00RUUMAH9OZN9A   |
	And User selects "Add to static list" in the Actions dropdown
	Then "ADD" Action button is disabled
	And User selects "StaticListFromTheAllList" List in Saved List dropdown
	When User clicks the "ADD" Action button
	Then "4" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Compliance         |
	| Import             |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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
	And User selects "Create static list" in the Actions dropdown
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
	And Column is displayed in following order:
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Compliance         |
	| Enabled            |

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	| SelectedRowsName    |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007)      |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 |
	And User selects "Create static list" in the Actions dropdown
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
	And Column is displayed in following order:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	| Compliance  |
	| Import      |

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_ChecksThatAfterAddingRowsToAStaticListFromTheAllListTheColumnsIsDisplayedCorrectlyOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
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
	And User selects "Create static list" in the Actions dropdown
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
	Then "4" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	| Alias              |
	| Import             |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_ChecksThatAfterAddingRowsToAStaticListFromADynamicListTheColumnsIsDisplayedCorrectlyOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User create dynamic list with "DynamicList13059" name on "Devices" page
	When User navigates to the "All Devices" list
	When User clicks the Columns button
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
	| 00BDM1JUR8IF419  |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticListFromADynamicList" name
	Then "StaticListFromADynamicList" list is displayed to user
	When User navigates to the "DynamicList13059" list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YWR8TJU4ZF8V   |
	Then User add selected rows in "StaticListFromADynamicList" list
	Then "2" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Import             |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13059 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_ChecksThatAfterAddingRowsToAStaticListFromAStaticListTheColumnsIsDisplayedCorrectlyOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "FirstStaticList13059" name
	Then "FirstStaticList13059" list is displayed to user
	When User navigates to the "All Devices" list
	When User clicks the Columns button
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
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "SecondStaticList13059" name
	Then "SecondStaticList13059" list is displayed to user
	When User navigates to the "FirstStaticList13059" list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	Then User add selected rows in "SecondStaticList13059" list
	Then "2" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Import             |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13245
Scenario: EvergreenJnr_DevicesList_TheSelectedColumnsCategoryIsDisplayedAfterUsingTheFilterSearch
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User clears search textbox in Filters panel
	Then the following Filters subcategories are displayed for open category:
	| Subcategories      |
	| Device Type        |
	| Hostname           |
	| Operating System   |
	| Owner Display Name |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13245
Scenario: EvergreenJnr_DevicesList_TheSelectedColumnsCategoryIsDisplayedAfterAddingAFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	And Column is displayed in following order:
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

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12861 @DAS13299
Scenario: EvergreenJnr_ApplicationsList_ChecksThatSubcategoriesOnColumnsPanelAreDisplayedInAlphabeticalOrderAfterAddingFilters
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" with added column and following value:
	| Values |
	| 121    |
	Then "Application Key" filter is added to the list
	When User add "Inventory Site" filter where type is "Equals" with added column and "Altiris" Lookup option
	Then "Inventory Site" filter is added to the list
	And Column is displayed in following order:
	| ColumnName      |
	| Application     |
	| Vendor          |
	| Version         |
	| Application Key |
	| Inventory Site  |
	When User clicks Add New button on the Filter panel
	Then the subcategories are displayed for open category in alphabetical order on Filters panel
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then the following subcategories are displayed for Selected Columns category:
	| Subcategories   |
	| Application     |
	| Vendor          |
	| Version         |
	| Application Key |
	| Inventory Site  |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12861
Scenario: EvergreenJnr_UsersList_ChecksThatSubcategoriesOnColumnsPanelAreDisplayedInAlphabeticalOrderAfterAddingDepartmentFilters
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "Finance" Tree List option
	Then Column is displayed in following order:
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Department Name    |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then the following subcategories are displayed for Selected Columns category:
	| Subcategories      |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Department Name    |
	Then User closed "Selected Columns" columns category
	When User add "Department Full Path" Column from expanded category
	Then User is expand "Selected Columns" columns category
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
	Then User closed "Selected Columns" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories        |
	| Department Full Path |
	| Department Name      |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User have reset all filters
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User closed "Selected Columns" columns category
	Then User is expand "Organisation" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories        |
	| Cost Centre          |
	| Department Code      |
	| Department Full Path |
	| Department Name      |

@Evergreen @AllLists @EvergreenJnr_Columns @ColumnSectionDisplay @DAS12922
Scenario: EvergreenJnr_AllLists_LocationAndUserFiltersEqualsOnUsersAndApplicationsTabs	
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| App Count (Used) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Username" column by Column panel
	When User removes "Domain" column by Column panel
	When User removes "Display Name" column by Column panel
	When User removes "Distinguished Name" column by Column panel
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "User (22)" category is displayed on Filters panel
	Then "Location (8)" category is displayed on Filters panel
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "User (24)" category is displayed on Filters panel
	Then "User Location (8)" category is displayed on Filters panel