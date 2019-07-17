Feature: WidgetBar
	Runs tests for Bar Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15356 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumns
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	| Manufacturer        |
	| Compliance          |
	And User click on 'Manufacturer' column header
	Then data in table is sorted by 'Manufacturer' column in ascending order
	When User create dynamic list with "List15356" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Bar        | WidgetForDAS15356 | List15356 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC |                  | 10        | true       |      |           |        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
