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

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11548 @DAS13423
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

@Evergreen @AllLists @EvergreenJnr_GridActions @ColumnOrder @DAS11463
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

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13181 @DAS13376
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
	| SelectedRowsName                                                |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
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
	And "4" rows are displayed in the agGrid
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
	And User selects "Create static list" in the Actions dropdown
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
	And User selects "Create static list" in the Actions dropdown
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
	And Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Import             |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS9820 @DAS13296
Scenario: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxColumnsAvailableUnderUserCategoryInColumnsPanelOnUsersPage
	When User clicks "Users" on the left-hand menu
	And User clicks the Columns button
	And User closed "Selected Columns" columns category
	And User is expand "User" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories          |
	| Common Name            |
	| Compliance             |
	| Dashworks First Seen   |
	| Description            |
	| Device Count           |
	| Directory Type         |
	| Email Address          |
	| Enabled                |
	| Given Name             |
	| Group Count            |
	| GUID                   |
	| Home Directory         |
	| Home Drive             |
	| Last Logon Date        |
	| Mailbox Count (Access) |
	| Mailbox Count (Owned) |
	| SID                    |
	| Surname                |
	| User Key               |

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
	And User clears search textbox in Filters panel
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

@Evergreen @AllLists @EvergreenJnr_Columns @ColumnSectionOrder @ColumnSectionDisplay @DAS12940 @DAS13201
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketAndCapacityUnitSubcategoriesPlacedInEvergreenCategoryInColumnsPanel
	When User clicks "<ListName>" on the left-hand menu
	And User clicks the Columns button
	And User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Mailboxes    |

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
	And the following subcategories are displayed for Selected Columns category:
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
	And the following subcategories are displayed for Selected Columns category:
	| Subcategories      |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Department Name    |
	And User closed "Selected Columns" columns category
	When User add "Department Full Path" Column from expanded category
	Then User is expand "Selected Columns" columns category
	And the following subcategories are displayed for Selected Columns category:
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
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	And User closed "Selected Columns" columns category
	And User is expand "Organisation" columns category
	And the following Column subcategories are displayed for open category:
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
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Username" column by Column panel
	And User removes "Domain" column by Column panel
	And User removes "Display Name" column by Column panel
	And User removes "Distinguished Name" column by Column panel
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "User" with "25" category is displayed on Filters panel
	And "Location" with "8" category is displayed on Filters panel
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "User" with "25" category is displayed on Filters panel
	And "User Location" with "8" category is displayed on Filters panel

@Evergreen @Mailboxes @EvergreenJnr_Columns @ColumnSectionDisplay @DAS12910
Scenario: EvergreenJnr_MailboxesList_ChecksThatSubcategoriesOnColumnsPanelIsDisplayedCorrectlyAfterAddingObjectIdFilter
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
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
	And User create custom list with "Object ID != EMPTY" name
	Then "Object ID != EMPTY" list is displayed to user

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13419 @Not_Run
Scenario: EvergreenJnr_DevicesList_ChecksThatColumnsPanelDoesNotIncludeUnpublishedTasks
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And the following subcategories are displayed for "Project Tasks: Windows7Mi" Columns category:
	| Value                                                                                                            |
	| Windows7Mi: A new group task thats long long long long long long long long long long long long long long long!!! |
	| Windows7Mi: Additional Information                                                                               |
	| Windows7Mi: Applications List                                                                                    |
	| Windows7Mi: C&C Computer Test Task 1                                                                             |
	| Windows7Mi: Completed Date                                                                                       |
	| Windows7Mi: Computer Off/On                                                                                      |
	| Windows7Mi: Computer Read Only Task for Project Object                                                           |
	| Windows7Mi: Computer Read Only Task in Bulk Update                                                               |
	| Windows7Mi: Computer Read Only Task in Self Service                                                              |
	| Windows7Mi: Computer Read Only Task in Self Service (Slot)                                                       |
	| Windows7Mi: Date & Time Task                                                                                     |
	| Windows7Mi: Date Workstation Task                                                                                |
	| Windows7Mi: DateTime                                                                                             |
	| Windows7Mi: Forecast Code                                                                                        |
	| Windows7Mi: Forecast Date                                                                                        |
	| Windows7Mi: Forecast Date (Slot)                                                                                 |
	| Windows7Mi: Further Information                                                                                  |
	| Windows7Mi: Group Computer Non Rag Date Owner                                                                    |
	| Windows7Mi: Group Computer Rag Radio Date Owner                                                                  |
	| Windows7Mi: Group Computer Rag Radio Date Owner (Slot)                                                           |
	| Windows7Mi: Group Date Computer Task                                                                             |
	| Windows7Mi: h1                                                                                                   |
	| Windows7Mi: IP Address                                                                                           |
	| Windows7Mi: Laptop & Physical Task                                                                               |
	| Windows7Mi: Laptop & Workstation 2                                                                               |
	| Windows7Mi: Laptop Only Task                                                                                     |
	| Windows7Mi: Laptop Replacement Task                                                                              |
	| Windows7Mi: Mail 1                                                                                               |
	| Windows7Mi: Migrated Date                                                                                        |
	| Windows7Mi: Physical Only Task                                                                                   |
	| Windows7Mi: Radiobutton Task for Workstation                                                                     |
	| Windows7Mi: Scheduled Code                                                                                       |
	| Windows7Mi: Scheduled Date                                                                                       |
	| Windows7Mi: Scheduled Date (Slot)                                                                                |
	| Windows7Mi: Self Service Enabled                                                                                 |
	| Windows7Mi: Send Applications List - Computer Object Task                                                        |
	| Windows7Mi: SS Application List Completed                                                                        |
	| Windows7Mi: SS Application List Enabled (Computer Mode)                                                          |
	| Windows7Mi: SS Computer Ownership Completed                                                                      |
	| Windows7Mi: SS Computer Ownership Enabled                                                                        |
	| Windows7Mi: SS Dept & Location Completed                                                                         |
	| Windows7Mi: SS Dept & Location Enabled                                                                           |
	| Windows7Mi: SS Other Options 1 Enabled                                                                           |
	| Windows7Mi: SS Other Options 2 Completed                                                                         |
	| Windows7Mi: SS Other Options 2 Enabled                                                                           |
	| Windows7Mi: SS Other Options Completed                                                                           |
	| Windows7Mi: SS Project Date Enabled                                                                              |
	| Windows7Mi: SSP Project Date Completed                                                                           |
	| Windows7Mi: Target Code                                                                                          |
	| Windows7Mi: Target Date                                                                                          |
	| Windows7Mi: Targeting Information                                                                                |
	| Windows7Mi: Values but no RAG                                                                                    |
	| Windows7Mi: VDI Only Task                                                                                        |
	| Windows7Mi: Workflow for Devices                                                                                 |
	| Windows7Mi: Workstation Text Task                                                                                |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS13419 @DAS14288 @Not_Run
#Update for missing "Project Tasks: prK" columns category
Scenario: EvergreenJnr_UsersList_ChecksThatFilterPanelDoesNotIncludeUnpublishedTasks
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then User closed "Selected Columns" columns category
	And User is expand "Project Tasks: prK" columns category
	Then the following Filters subcategories are displayed for open category:
	| Subcategories                                   |
	| prK: Email Address CC                           |
	| prK: Email Notifications Allowed?               |
	| prK: Email Override Address                     |
	| prK: Email to be sent - All Placeholders        |
	| prK: Email to be sent - All Placeholders (Slot) |
	| prK: user-group-radb-k                          |