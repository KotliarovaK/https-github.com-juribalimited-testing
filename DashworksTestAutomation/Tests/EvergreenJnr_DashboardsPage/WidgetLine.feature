﻿Feature: WidgetLine
	Runs tests for Line Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15737 @DAS15662 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdown
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| prK: Application Readiness |
	Then ColumnName is added to the list
	| ColumnName                 |
	| prK: Application Readiness |
	When User create dynamic list with "TestList_DAS15737" name on "Users" page
	Then "TestList_DAS15737" list is displayed to user
	When Dashboard with "Dashboard for DAS15737" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	When User selects "Line" in the "Widget Type" Widget dropdown
	And User enters "DAS15737" as Widget Title
	And User selects "TestList_DAS15737" as Widget List
	When User selects "prK: Application Readiness" in the "Split By" Widget dropdown
	When User selects "Count" in the "Aggregate Function" Widget dropdown
	When User selects "prK: Application Readiness ASC" in the "Order By" Widget dropdown
	And User clicks on the Colour Scheme dropdown
	Then Colour Scheme dropdown is displayed to the user
	Then "Data Label" checkbox is not displayed on the Create Widget page
	When User clicks the "CREATE" Action button

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPage
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And user select "Device Type" filter
	And User clicks in search field in the Filter block
	And User enters "Desktop" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| 1803: Pre-Migration \ Scheduled Date |
	And User create dynamic list with "1803 ScheduleDAS16069" name on "Devices" page
	Then "1803 ScheduleDAS16069" list is displayed to user
	When Dashboard with "1803 ProjectDAS16069" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                    | List                  | Type | AggregateBy | AggregateFunction | SplitBy                              | OrderBy                                  | MaxValues | ShowLegend | TableOrientation | Drilldown | Layout |
	| Line       | Project ScheduleDAS16069 | 1803 ScheduleDAS16069 |      | Hostname    | Count distinct    | 1803: Pre-Migration \ Scheduled Date | 1803: Pre-Migration \ Scheduled Date ASC |           |            |                  | Yes       |        |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "Project ScheduleDAS16069" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	Then Tooltip is displayed for the point of Line widget
	| WidgetName               | NumberOfPoint | Tooltip      |
	| Project ScheduleDAS16069 | 1             | 5 Nov 2018 4 |
	When User clicks point of Line widget
	| WidgetName               | NumberOfPoint | 
	| Project ScheduleDAS16069 | 1             | 
	Then Save as a new list option is available
	And "4" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName                           |
	| Hostname                             |
	| Device Type                          |
	| Operating System                     |
	| Owner Display Name                   |
	| 1803: Pre-Migration \ Scheduled Date |	
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15920 @DAS15662 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboard
	When User clicks "Users" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                    |
	| Device Application Compliance |
	| Compliance                    |
	And User create dynamic list with "ListForDas15920" name on "Users" page
	Then "ListForDas15920" list is displayed to user
	When Dashboard with "DashboardForDas15920" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                 | List            | Type | AggregateBy | AggregateFunction | SplitBy                       | OrderBy                           | MaxValues | ShowLegend | TableOrientation | Drilldown | Layout |
	| Line       | LineWidgetForDas15920 | ListForDas15920 |      |             | Count             | Device Application Compliance | Device Application Compliance ASC |           |            |                  | Yes       |        |
	Then Widget Preview is displayed to the user
	Then "Data Label" checkbox is not displayed on the Create Widget page
	When User clicks the "CREATE" Action button
	Then Card "LineWidgetForDas15920" Widget is displayed to the user
	And Line chart displayed in "LineWidgetForDas15920" widget

@Evergreen @EvergreenJnr_DashboardsPage @DAS15544 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Service Pack or Build |
	And User create dynamic list with "ListForDas15544" name on "Devices" page
	Then "ListForDas15544" list is displayed to user
	When Dashboard with "1803 ProjectDAS15544" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                     | List            | Type | AggregateBy | AggregateFunction | SplitBy               | OrderBy                   | MaxValues | ShowLegend | TableOrientation | Drilldown | Layout |
	| Line       | SortOrderCheckForDas15544 | ListForDas15544 |      |             | Count             | Service Pack or Build | Service Pack or Build ASC |           |            |                  | Yes       |        |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "SortOrderCheckForDas15544" Widget is displayed to the user
	And Line X labels of "SortOrderCheckForDas15544" widget is displayed in following order:
	| ColumnName             |
	| Empty                  |
	| No Service Pack        |
	| Service Pack 1         |
	| Service Pack 2         |
	| Service Pack 3         |
	| Service Pack 3, v.6055 |
	| Windows 8.0            |
	| Windows 8.1            |
	| 1507                   |
	| 1607                   |
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15462
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount
	When User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                      | List        | Type | AggregateBy | AggregateFunction | SplitBy          | OrderBy              | MaxValues | ShowLegend | TableOrientation | Drilldown | Layout |
	| Line       | Project AllDevicesDAS15462 | All Devices |      | Hostname    | Count distinct    | Operating System | Operating System ASC |           |            |                  |           |        |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "Project AllDevicesDAS15462" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	Then Tooltip is displayed for the point of Line widget
	| WidgetName                 | NumberOfPoint | Tooltip     |
	| Project AllDevicesDAS15462 | 2             | OS X 10.5 1 |