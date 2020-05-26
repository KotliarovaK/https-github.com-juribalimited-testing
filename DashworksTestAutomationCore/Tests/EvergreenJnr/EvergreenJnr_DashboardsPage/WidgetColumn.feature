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
	When Dashboard with 'Dashboard_16278' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List             | SplitBy            | AggregateBy         | AggregateFunction | OrderBy                | MaxValues | ShowLegend |
	| Column     | DAS16278_Widget | AListForDAS16278 | Windows7Mi: Status | HDD Total Size (GB) | Sum               | Windows7Mi: Status ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS16278_Widget' Widget is displayed to the user
	Then Line X labels of 'DAS16278_Widget' column widget is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Targeted   |
	| Scheduled  |
	| Migrated   |
	| Complete   |
	When User clicks 'Edit' menu option for 'DAS16278_Widget' widget
	When User selects 'Windows7Mi: Status DESC' in the 'OrderBy' dropdown
	When User clicks 'UPDATE' button 
	Then 'DAS16278_Widget' Widget is displayed to the user
	Then Line X labels of 'DAS16278_Widget' column widget is displayed in following order:
	| ColumnName |
	| Complete   |
	| Migrated   |
	| Scheduled  |
	| Targeted   |
	| Forecast   |
	| Onboarded  |

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
	When Dashboard with 'Dashboard_15780' name created via API and opened
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
	When Dashboard with 'Dashboard_12983' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When  User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title        | List        | AggregateFunction | SplitBy          | CategoriseBy | DisplayType | OrderBy              | AggregateBy | MaxValues |
	| Column     | ColumnWidget | All Devices | Count distinct    | Operating System | Device Type  | Stacked     | Operating System ASC | Hostname    | 2         |
	When User selects the Colour Scheme by color code 'rgb(143, 20, 64)'
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'ColumnWidget' Widget is displayed to the user
	Then Line X labels of 'ColumnWidget' column widget is displayed in following order:
	| ColumnName |
	| Other      |
	| OS X 10.5  |
	Then User sees color code 'rgb(143, 20, 64)' on the 'ColumnWidget' widget
	
	When User clicks 'Edit' menu option for 'ColumnWidget#1' widget
	When User adds new Widget
	| WidgetType | Title          | List        | AggregateFunction | SplitBy          | OrderBy              | AggregateBy | MaxValues |
	| Pie        | ColumnWidget#2 | All Devices | Count distinct    | Operating System | Operating System ASC | Hostname    | 3         |
	When User selects the Colour Scheme by index '3'
	Then Widget Preview is displayed to the user
	When User clicks 'UPDATE' button 
	Then 'ColumnWidget#2' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @DAS20415 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckFiltersAfterRedirectingFromWidgetData
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User add "UserEvergr: Stage 2 \ Scheduled Date" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	Then "UserEvergr: Stage 2 \ Scheduled Date is not empty" is displayed in added filter info
	When User Add And "UserEvergr: Stage 3 \ Group User Radiobutton RAG Date Owner (Owner)" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	Then "UserEvergr: Stage 3 \ Group User Radiobutton RAG Date Owner (Owner) is not empty" is displayed in added filter info
	When User create dynamic list with "20415_List" name on "Users" page
	And Dashboard with 'Dashboard20415' name created via API and opened
	And User checks 'Edit mode' slide toggle
	And  User clicks 'ADD WIDGET' button
	And User adds new Widget
	| WidgetType | Title        | List       | AggregateFunction | SplitBy                              | CategoriseBy                                                        | DisplayType | OrderBy                                  | DrillDown | ShowLegend |
	| Column     | 20415_Widget | 20415_List | Count             | UserEvergr: Stage 2 \ Scheduled Date | UserEvergr: Stage 3 \ Group User Radiobutton RAG Date Owner (Owner) | Stacked     | UserEvergr: Stage 2 \ Scheduled Date ASC | Yes       | true       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button
	When User clicks on 'Administrator' category of '20415_Widget' widget
	Then URL is 'evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,project_task_56_13245_2_Task,project_task_56_13251_1_owner&$filter=(project_task_56_13245_2_Task%20IS%20NOT%20EMPTY%20()%20AND%20project_task_56_13251_1_ownerId%20IS%20NOT%20EMPTY%20()%20AND%20project_task_56_13245_2_Task%20EQUALS%20('13%20Dec%202018%2012:00')%20AND%20project_task_56_13251_1_ownerId%20EQUALS%20('f98fa56f-e271-47ff-a90e-31e2f02748b3'))'
	And User sees "2" rows in grid
	And Content in the 'UserEvergr: Stage 2 \ Scheduled Date' column is equal to
	| Content           |
	| 13 Dec 2018 12:00 |
	| 13 Dec 2018 12:00 |
	And Content in the 'UserEvergr: Stage 3 \ Group User Radiobutton RAG Date Owner (Owner)' column is equal to
	| Content       |
	| Administrator |
	| Administrator |
	When User clicks 'Dashboards' on the left-hand menu
	And User clicks Show Dashboards panel icon on Dashboards page
	And User opens 'Dashboard20415' dashboard
	And User checks 'Edit mode' slide toggle
	And User clicks 'Edit' menu option for '20415_Widget' widget
	And User selects 'Bar' in the 'Widget Type' dropdown
	And User selects 'Clustered' in the 'Display Type' dropdown
	And User clicks 'UPDATE' button
	And User clicks on 'Unassigned' category of '20415_Widget' widget
	Then 'Unassigned' content is displayed in all 'UserEvergr: Stage 3 \ Group User Radiobutton RAG Date Owner (Owner)' column
	And 'UserEvergr: Stage 2 \ Scheduled Date' column contains following content
	| Content           |
	| 11 Dec 2018 11:00 |
	And User sees "16" rows in grid