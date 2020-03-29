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
	When User waits for '2' seconds
	When User create dynamic list with "AListForDAS16278" name on "Devices" page
	Then "AListForDAS16278" list is displayed to user
	When Dashboard with 'DAS16278_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List             | SplitBy            | AggregateBy         | AggregateFunction | OrderBy                | MaxValues | ShowLegend |
	| Column     | DAS16278_Widget | AListForDAS16278 | Windows7Mi: Status | HDD Total Size (GB) | Sum               | Windows7Mi: Status ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS16278_Widget' Widget is displayed to the user
	Then Line X labels of 'DAS16278_Widget' column widget is displayed in following order:
	| ColumnName    |
	| Onboarded     |
	| Forecast      |
	| Targeted      |
	| Scheduled     |
	| Migrated      |
	| Complete      |
	When User clicks 'Edit' menu option for 'DAS16278_Widget' widget
	When User selects 'Windows7Mi: Status DESC' in the 'OrderBy' dropdown
	When User clicks 'UPDATE' button 
	Then 'DAS16278_Widget' Widget is displayed to the user
	Then Line X labels of 'DAS16278_Widget' column widget is displayed in following order:
	| ColumnName    |
	| Complete      |
	| Migrated      |
	| Scheduled     |
	| Targeted      |
	| Forecast      |
	| Onboarded     |

@Evergreen @EvergreenJnr_DashboardsPage @DAS15780 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatReadinessWidgetHasCorrectseverityOrdering
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName            |
	| DeviceSche: Readiness |
	When User move 'DeviceSche: Readiness' column to 'Hostname' column
	When User move 'Hostname' column to 'Device Type' column
	When User create dynamic list with "ListForDas15780" name on "Devices" page
	Then "ListForDas15780" list is displayed to user
	When Dashboard with '2004 ProjectDAS15780' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title                     | List            | AggregateFunction | SplitBy               | OrderBy                   | Drilldown |
	| Column     | SortOrderCheckForDas15780 | ListForDas15780 | Count             | DeviceSche: Readiness | DeviceSche: Readiness ASC | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'SortOrderCheckForDas15780' Widget is displayed to the user
	Then Line X labels of 'SortOrderCheckForDas15780' column widget is displayed in following order:
	| ColumnName              |
	| Empty                   |
	| Out Of Scope            |
	| Blue                    |
	| Light Blue              |
	| Red                     |
	| Brown                   |
	| Amber                   |
	| Really Extremely Orange |
	| Purple                  |
	| Grey                    |

@Evergreen @EvergreenJnr_DashboardsPage @DAS12983 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeAdded
	When Dashboard with 'Dashboard12983' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When  User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title        | List        | AggregateFunction | SplitBy          | CategoriseBy | DisplayType | OrderBy | AggregateBy | MaxValues |
	| Column     | ColumnWidget | All Devices | Count distinct    | Operating System | Device Type  | Stacked     |Operating System ASC | Hostname    | 2         |
	When User selects the Colour Scheme by color code 'rgb(30, 45, 114)'
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'ColumnWidget' Widget is displayed to the user
	Then Line X labels of 'ColumnWidget' column widget is displayed in following order:
	| ColumnName |
	| Other      |
	| OS X 10.5  |
	Then User sees color code 'rgb(30, 45, 114)' on the 'ColumnWidget' widget

@Evergreen @EvergreenJnr_DashboardsPage @DAS12983 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatColumnWidgetCanBeEdited
	When Dashboard with 'Dashboard12983' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When  User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title          | List        | AggregateFunction | SplitBy          | OrderBy              | AggregateBy | MaxValues |
	| Column     | ColumnWidget#1 | All Devices | Count distinct    | Operating System | Operating System ASC | Hostname    | 2         |
	When User selects the Colour Scheme by index '2'
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'ColumnWidget#1' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'ColumnWidget#1' widget
	When User adds new Widget
	| WidgetType | Title          | List        | AggregateFunction | SplitBy          | OrderBy              | AggregateBy | MaxValues |
	| Pie        | ColumnWidget#2 | All Devices | Count distinct    | Operating System | Operating System ASC | Hostname    | 3         |
	When User selects the Colour Scheme by index '3'
	Then Widget Preview is displayed to the user
	When User clicks 'UPDATE' button 
	Then 'ColumnWidget#2' Widget is displayed to the user