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

@Evergreen @Applications @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_CheckTheColumnCategoriesUpdatesAfterAddingColumnForStaticLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
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