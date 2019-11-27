Feature: WidgetColumn
	Runs tests for Column Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16278 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckStatusDisplayOrderForColumnWidget
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Windows7Mi: Status  |
	| HDD Total Size (GB) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User create dynamic list with "AListForDAS16278" name on "Devices" page
	Then "AListForDAS16278" list is displayed to user
	When Dashboard with 'DAS16278_Dashboard' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List             | SplitBy            | AggregateBy         | AggregateFunction | OrderBy                | MaxValues | ShowLegend |
	| Column     | DAS16278_Widget | AListForDAS16278 | Windows7Mi: Status | HDD Total Size (GB) | Sum               | Windows7Mi: Status ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS16278_Widget' Widget is displayed to the user
	Then Line X labels of 'DAS16278_Widget' column widget is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	| Forecast      |
	| Targeted      |
	| Scheduled     |
	| Migrated      |
	| Complete      |
	| Offboarded    |
	When User clicks Ellipsis menu for 'DAS16278_Widget' Widget on Dashboards page
	When User clicks 'Edit' item from Ellipsis menu on Dashboards page
	When User selects 'Windows7Mi: Status DESC' in the 'OrderBy' dropdown
	When User clicks 'UPDATE' button 
	Then 'DAS16278_Widget' Widget is displayed to the user
	Then Line X labels of 'DAS16278_Widget' column widget is displayed in following order:
	| ColumnName    |
	| Offboarded    |
	| Complete      |
	| Migrated      |
	| Scheduled     |
	| Targeted      |
	| Forecast      |
	| Onboarded     |
	| Not Onboarded |

@Evergreen @EvergreenJnr_DashboardsPage @DAS15780 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName            |
	| Babel(Engl: Readiness |
	And User move 'Babel(Engl: Readiness' column to 'Hostname' column
	And User move 'Hostname' column to 'Device Type' column
	And User create dynamic list with "ListForDas15780" name on "Devices" page
	Then "ListForDas15780" list is displayed to user
	When Dashboard with '1803 ProjectDAS15780' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title                     | List            | AggregateFunction | SplitBy               | OrderBy                   | Drilldown |
	| Column     | SortOrderCheckForDas15780 | ListForDas15780 | Count             | Babel(Engl: Readiness | Babel(Engl: Readiness ASC | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'SortOrderCheckForDas15780' Widget is displayed to the user
	And Line X labels of 'SortOrderCheckForDas15780' column widget is displayed in following order:
	| ColumnName   |
	| Empty        |
	| Out Of Scope |
	| Blue         |
	| Red          |
	| Amber        |
	| Green        |
	| Grey         |

@Evergreen @EvergreenJnr_DashboardsPage @DAS12983 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded
	When Dashboard with 'Dashboard12983' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When  User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title        | List        | AggregateFunction | SplitBy          | OrderBy              | AggregateBy |
	| Column     | ColumnWidget | All Devices | Count distinct    | Operating System | Operating System ASC | Hostname    |
	When User enters '2' as Widget Max Values
	When User selects the Colour Scheme by index '2'
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'ColumnWidget' Widget is displayed to the user
	Then Line X labels of 'ColumnWidget' column widget is displayed in following order:
	| ColumnName |
	| Other      |
	| OS X 10.5  |

@Evergreen @EvergreenJnr_DashboardsPage @DAS12983 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited
	When Dashboard with 'Dashboard12983' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When  User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title        | List        | AggregateFunction | SplitBy          | OrderBy              | AggregateBy |
	| Column     | ColumnWidget#1 | All Devices | Count distinct    | Operating System | Operating System ASC | Hostname    |
	When User enters '2' as Widget Max Values
	When User selects the Colour Scheme by index '2'
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'ColumnWidget#1' Widget is displayed to the user
	When User clicks Ellipsis menu for 'ColumnWidget#1' Widget on Dashboards page
	When User clicks 'Edit' item from Ellipsis menu on Dashboards page
	When User adds new Widget
	| WidgetType | Title          | List        | AggregateFunction | SplitBy          | OrderBy              | AggregateBy |
	| Pie        | ColumnWidget#2 | All Devices | Count distinct    | Operating System | Operating System ASC | Hostname    |
	When User enters '3' as Widget Max Values
	When User selects the Colour Scheme by index '3'
	Then Widget Preview is displayed to the user
	When User clicks 'UPDATE' button 
	Then 'ColumnWidget#2' Widget is displayed to the user