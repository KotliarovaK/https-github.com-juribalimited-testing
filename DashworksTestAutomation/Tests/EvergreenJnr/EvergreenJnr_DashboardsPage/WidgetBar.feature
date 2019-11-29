﻿Feature: WidgetBar
	Runs tests for Bar Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15356 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumns
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	| Manufacturer        |
	| Compliance          |
	And User clicks on 'Manufacturer' column header
	Then data in table is sorted by 'Manufacturer' column in ascending order
	When User create dynamic list with "List15356" name on "Devices" page
	And User clicks 'Dashboards' on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS15356 | List15356 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceListHasNoRows
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values |
	| ZZZZ   |
	And User clicks Save button on the list panel
	And User create dynamic list with "ListForDAS16167" name on "Devices" page
	Then "ListForDAS16167" list is displayed to user
	When Dashboard with 'DAS16167_Dashboard' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType   | Title             | List            | SplitBy          | AggregateFunction | OrderBy              |
	| <WidgetType> | WidgetForDAS16167 | ListForDAS16167 | Operating System | Count             | Operating System ASC |
	Then Widget Preview is displayed to the user
	And 'This list does not contain any rows' message is displayed in Preview
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16167' Widget is displayed to the user
	And 'This list does not contain any rows' message is displayed in 'WidgetForDAS16167' widget

Examples: 
	| WidgetType |
	| Pie        |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |
	| Table      |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18100 @Cleanup
Scenario: EvergreenJnr_CheckThatWidgetBasedOnListHavingNotEmptyOperatorCanBeCreated
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Import Type" filter where type is "Not empty" with added column and Lookup option
    | SelectedValues |
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18100_2" name on "Devices" page
	Then "ListForDAS18100_2" list is displayed to user
	When Dashboard with 'DAS18100_Dashboard' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List              | SplitBy     | AggregateFunction | OrderBy         |
	| Bar        | WidgetForDAS18100 | ListForDAS18100_2 | Import Type | Count             | Import Type ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS18100' Widget is displayed to the user
	Then There are no errors in the browser console