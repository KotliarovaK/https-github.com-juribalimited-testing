﻿Feature: AddWidget
	Runs Widget adding tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14587 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When Dashboard with "Dashboard for DAS14587" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Pie        |       | All Devices | Device Type | Hostname    | Count distinct    | Device Type ASC |                  | 10        |            |
	Then Error message with "Widget Title should not be empty" text is displayed on Widget page
	And There are no errors in the browser console
	When User creates new Widget
	| WidgetType | Title                  | List | SplitBy | AggregateBy | AggregateFunction | OrderBy | TableOrientation | MaxValues | ShowLegend |
	|            | Dashboard for DAS14587 |      |         |             |                   |         |                  |           |            |
	Then User sees widget with the next name "Dashboard for DAS14587" on Dashboards page
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14578 @DAS14584 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars
	When Dashboard with "Dashboard for DAS14578" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                                                                                                       | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Table      | Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred and seven | All Applications | Application | Application | Count distinct    | Application ASC | Horizontal       | 10        |            |
	Then User sees widget with the next name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" on Dashboards page
	And Widget name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" has word break style on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15900 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningMessageAppearsOnceWhenSwitchingToDashboardWithoutSavingWidgetChanges
	When Dashboard with "Dashboard for DAS15900" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | AggregateBy | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900 | All Applications | Vendor  | Count             |             | Count ASC |                  | 10        | true       |
	And User clicks Ellipsis menu for "WidgetForDAS15900" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User adds new Widget
	| WidgetType | Title                    | List        | SplitBy  | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Pie        | WidgetForDAS15900_Edited | All Devices | Hostname |             | Count             | Count ASC |                  | 11        | true       |      |           |        | 
	When User clicks Show Dashboards panel icon on Dashboards page
	And User clicks first Dashboard in dashboards list
	Then User sees "You have unsaved changes. Are you sure you want to leave the page?" text in alert on Edit Widget page
	When User clicks "NO" button in Unsaved Changes alert
	Then Unsaved Changes alert not displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @Delete_Newly_Created_Dashboard
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionSelectionIsBeforeTheAggregateBySelection
	When Dashboard with "Dashboard for DAS15437" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "<WidgetType>" in the "Widget Type" Widget dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown

Examples: 
	| WidgetType |
	| Pie        |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |
	| Table      |
	| Card       |
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionOrAggregateByDropdownAreMissingForListWidget
	When Dashboard with "Dashboard for DAS15437" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "List" in the "Widget Type" Widget dropdown
	Then "Aggregate Function" dropdown is missing
	And "Aggregate By" dropdown is missing

@Evergreen @EvergreenJnr_DashboardsPage @DAS16958 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatEditWidgetPageCanBeOpenedForWidgetHavingDeletedList
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	And User create dynamic list with "List16958" name on "Devices" page
	And Dashboard with "Dashboard for DAS16958" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Bar        | WidgetForDAS16958 | List16958 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC |                  | 10        | true       |      |           |        |
	And User clicks the "CREATE" Action button
	And Dashboard page loaded
	And User lists were removed by API
	And User clicks refresh button in the browser
	And Dashboard page loaded
	And User clicks Edit mode trigger on Dashboards page
	And User clicks edit option for broken widget on Dashboards page
	Then Message saying that list is unavailable appears in Edit Widget page
