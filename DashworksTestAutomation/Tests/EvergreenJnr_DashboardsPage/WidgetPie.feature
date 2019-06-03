Feature: WidgetPie
	Runs tests for Pie Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14668 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| ICSP: i-stage A \ i-Schedule |
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	| 00OMQQXWA1DRI6   |
	| 00SH8162NAS524   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TestList_DAS14668" name
	And Dashboard with "Dashboard for DAS14668" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                      | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_1 | TestList_DAS14668 | ICSP: i-stage A \ i-Schedule |             | Count             | Count ASC |                  | 5         |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_1" on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                      | AggregateBy                  | AggregateFunction | OrderBy                           | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_2 | TestList_DAS14668 | ICSP: i-stage A \ i-Schedule | ICSP: i-stage A \ i-Schedule | Count distinct    | ICSP: i-stage A \ i-Schedule DESC |                  | 20        |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_2" on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15372 @DAS15317 @Delete_Newly_Created_List @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetThatUsesCpuArchitField
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| CPU Architecture |
	And User clicks Save button on the list panel
	And User create dynamic list with "List15372" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy          | AggregateBy | AggregateFunction | OrderBy              | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Pie        | WidgetForDAS15372 | List15372 | CPU Architecture | Hostname    | Count distinct    | CPU Architecture ASC |                  | 10        | false      |      |           |        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then "WidgetForDAS15372" Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15365 @DAS15352 @Delete_Newly_Created_List @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingPieWidgetUsedSavedList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Model      |
	And User clicks Save button on the list panel
	And User create dynamic list with "List15365" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Pie        | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC |                  | 10        | true       |      |           |        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Bar" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Column" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Line" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Donut" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Half donut" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Table" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15662 @Delete_Newly_Created_Dashboard
Scenario Outline: EvergreenJnr_DashboardsPage_CheckDataLabelsOnTheWidget
	When Dashboard with "DAS15662_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	When User selects "<WidgetType>" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS15662" as Widget Title
	And User selects "All Devices" as Widget List
	When User selects "Hostname" in the "Split By" Widget dropdown
	When User selects "Count" in the "Aggregate Function" Widget dropdown
	When User selects "Count ASC" in the "Order By" Widget dropdown
	When User selects "Data Label" checkbox on the Create Widget page
	Then Data Labels are displayed on the Dashboards page
	Then "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks the "CREATE" Action button
	Then Data Labels are displayed on the Dashboards page
	Then "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks Ellipsis menu for "WidgetForDAS15662" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for "WidgetForDAS156622" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	Then "Data Label" checkbox is checked on the Create Widget page
	Then Data Labels are displayed on the Dashboards page
	Then "<DataLabel>" data label is displayed on the Dashboards page

Examples:
	| WidgetType | DataLabel      |
	| Pie        | 00RUUMAH9OZN9A |
	| Half donut | 00RUUMAH9OZN9A |
	| Donut      | 00RUUMAH9OZN9A |
