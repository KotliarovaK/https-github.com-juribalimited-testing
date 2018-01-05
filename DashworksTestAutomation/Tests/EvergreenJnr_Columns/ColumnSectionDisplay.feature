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