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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| Manufacturer |
	Then ColumnName is added to the list
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
	When User enters "group" text in Search field at Columns Panel
	Then Minimize buttons are displayed for all category in Columns panel
	When User collapses all columns categories
	Then Maximize buttons are displayed for all category in Columns panel

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11668
Scenario: EvergreenJnr_DevicesList_CheckThatAllColumnsAreVisibleInTheirRelevantCategoryAfterResetting
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Import     |
	| Compliance |
	Then ColumnName is added to the list
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
	When User add "Import" Column from expanded category
	Then Minimize button is displayed for "Mailbox" category
	When User add "Enabled" Column from expanded category
	Then ColumnName is added to the list
	| ColumnName |
	| Import     |
	| Enabled    |

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768
Scenario: EvergreenJnr_Devices_CheckTheColumnCategoriesUpdateAfterAddingColumn
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS11768
Scenario: EvergreenJnr_Users_CheckTheColumnCategoriesUpdateAfterAddingColumn
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Zip Code   |
	Then ColumnName is added to the list
	| ColumnName |
	| Zip Code   |
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Zip Code   |