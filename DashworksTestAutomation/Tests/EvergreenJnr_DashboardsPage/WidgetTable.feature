Feature: WidgetTable
	Runs tests for Table Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14685 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget
	When Dashboard with "Dashboard for DAS14685" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Table      | WidgetForDAS14685 | All Applications | Application | Application | Count distinct    | Application ASC |                  | 10        |            |
	Then There are no errors in the browser console
	And User sees widget with the next name "WidgetForDAS14685" on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14920 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccursWhenCreatingDashboardWidgetThatUsesBooleanField
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Secure Boot Enabled  |
	| Windows7Mi: In Scope |
	When User create dynamic list with "14920_List" name on "Devices" page
	And Dashboard with "Dashboard for DAS14920" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title       | List       | SplitBy             | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Drilldown | Layout |
	| Table      | DAS-14920_1 | 14920_List | Secure Boot Enabled |             | Count             | Count ASC |                  | 10        |            |           |        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	And "DAS-14920_1" Widget is displayed to the user
	And "2,190" count is displayed for "False" in the table Widget
	And "2,192" count is displayed for "True" in the table Widget
	And "12,843" count is displayed for "Unknown" in the table Widget
	#Second Widget creation
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title       | List       | SplitBy              | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Table      | DAS-14920_2 | 14920_List | Windows7Mi: In Scope |             | Count             | Count ASC |                  | 10        |            |
	Then There are no errors in the browser console
	And "DAS-14920_2" Widget is displayed to the user
	Then "12,044" count is displayed for "False" in the table Widget
	And "5,181" count is displayed for "True" in the table Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16073 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetIsDisplayedCorrectly
	When Dashboard with "Dashboard for DAS16073" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS16073 | All Devices | Hostname | Count             | Count DESC | Vertical         | 10        |
	Then There are no errors in the browser console
	And "WidgetForDAS16073" Widget is displayed to the user
	Then link is not displayed for the "CAS" value in the Widget
	Then link is not displayed for the "WIN-43TMG2KMRBI" value in the Widget
	Then link is not displayed for the "WIN81PRO" value in the Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetValuesLeadsToApplicationsListFilteredPage
	When Dashboard with "Dashboard for DAS16069_1" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS16069_1 | All Applications | Vendor  | Count             | Count DESC |                  | 500       |
	Then "WidgetForDAS16069_1" Widget is displayed to the user
	And "918" count is displayed for "Microsoft Corporation" in the table Widget
	When User clicks "918" value for "Microsoft Corporation" column
	Then "918" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15208
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetDisplayedFullyInPreviewPane
	When User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title     | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend | Drilldown | Layout |
	| Table      | DAS-15208 | All Devices | Device Type | Device Type | Count distinct    | Device Type ASC | Horizontal       |           |            |           |        |
	Then Widget Preview is displayed to the user
	And Table widget displayed inside preview pane correctly
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DAS16275 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckCapacitySlotsDisplayOrderInDashboards
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                        |
	| Windows7Mi: Pre-Migration \ Scheduled Date (Slot) |
	And User create dynamic list with "Devices_List_DAS16275" name on "Devices" page
	Then "Devices_List_DAS16275" list is displayed to user
	When Dashboard with "DAS16275_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title           | List                  | SplitBy                                           | AggregateFunction | AggregateBy | OrderBy   | MaxValues | TableOrientation | ShowLegend | Layout |
	| Table      | DAS16275_Widget | Devices_List_DAS16275 | Windows7Mi: Pre-Migration \ Scheduled Date (Slot) | Count             |             | Count ASC |           | Vertical         |            |        |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then "DAS16275_Widget" Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue                    |
	| Slot 2018-10-01 to 2018-12-31 |
	| Slot 2018-11-01 - 2020-12-26  |
	| Empty                         |
	When User clicks Ellipsis menu for "DAS16275_Widget" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Count DESC" in the "Order By" Widget dropdown
	When User clicks the "UPDATE" Action button
	Then content in the Widget is displayed in following order:
	| TableValue                    |
	| Empty                         |
	| Slot 2018-11-01 - 2020-12-26  |
	| Slot 2018-10-01 to 2018-12-31 |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15826 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckRingsDisplayOrderInAWidgetOnDashboard
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| UserEvergr: Ring (All Users) |
	And User create dynamic list with "DeviceListForDAS15826" name on "Devices" page
	Then "DeviceListForDAS15826" list is displayed to user
	When Dashboard with "DAS15826_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title           | List                  | SplitBy                      | AggregateFunction | OrderBy                          | TableOrientation | MaxValues |
	| Table      | DAS15826_Widget | DeviceListForDAS15826 | UserEvergr: Ring (All Users) | Count             | UserEvergr: Ring (All Users) ASC | Vertical         |           |
	Then Card "DAS15826_Widget" Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue       |
	| Empty            |
	| Unassigned       |
	| Unassigned2      |
	| Evergreen Ring 1 |
	| Evergreen Ring 2 |
	| Evergreen Ring 3 |
	When User clicks Ellipsis menu for "DAS15826_Widget" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "UserEvergr: Ring (All Users) DESC" in the "Order By" Widget dropdown
	When User clicks the "UPDATE" Action button
	Then Card "DAS15826_Widget" Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue       |
	| Evergreen Ring 3 |
	| Evergreen Ring 2 |
	| Evergreen Ring 1 |
	| Unassigned2      |
	| Unassigned       |
	| Empty            |