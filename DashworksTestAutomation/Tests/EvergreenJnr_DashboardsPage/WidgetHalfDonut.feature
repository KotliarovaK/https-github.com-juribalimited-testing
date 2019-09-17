Feature: WidgetHalfDonut
	Runs tests for Half Donut Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15918
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByShowsCorrectOptionsForHalfDonut
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List         | AggregateFunction | SplitBy                                |
	| Half donut | WidgetForDAS15918 | 1803 Rollout | Count             | 1803: Pre-Migration \ Ready to Migrate |
	Then User sees following options for Order By selector on Create Widget page:
	| items                                       |
	| 1803: Pre-Migration \ Ready to Migrate ASC  |
	| 1803: Pre-Migration \ Ready to Migrate DESC |
	| Count ASC                                   |
	| Count DESC                                  |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	And User create dynamic list with "DAS16167_HddList" name on "Devices" page
	When Dashboard with "DAS16167_HddList" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType   | Title           | List             | SplitBy          | AggregateFunction | AggregateBy         | OrderBy                         |
	| <WidgetType> | HddListDAS16167 | DAS16167_HddList | Operating System | Minimum           | HDD Total Size (GB) | HDD Total Size (GB) Minimum ASC |
	Then Widget Preview is displayed to the user
	And 'All values are 0' message is displayed in Preview
	When User clicks the "CREATE" Action button
	Then "HddListDAS16167" Widget is displayed to the user
	And 'All values are 0' message is displayed in 'HddListDAS16167' widget

Examples: 
	| WidgetType |
	| Pie        |
	| Donut      |
	| Half donut |