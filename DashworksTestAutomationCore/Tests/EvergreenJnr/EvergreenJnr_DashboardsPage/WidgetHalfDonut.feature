Feature: WidgetHalfDonut
	Runs tests for Half Donut Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15918
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByShowsCorrectOptionsForHalfDonut
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List         | AggregateFunction | SplitBy                                |
	| Half donut | WidgetForDAS15918 | 2004 Rollout | Count             | 2004: Pre-Migration \ Ready to Migrate |
	Then User sees following options for Order By selector on Create Widget page:
	| items                                       |
	| 2004: Pre-Migration \ Ready to Migrate ASC  |
	| 2004: Pre-Migration \ Ready to Migrate DESC |
	| Count ASC                                   |
	| Count DESC                                  |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIftheWidgetResultsAreAllZero
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	When User create dynamic list with "<WidgetType>List_16167" name on "Devices" page
	When Dashboard with '<WidgetType>Dashboard_16167' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType   | Title           | List                   | SplitBy          | AggregateFunction | AggregateBy         | OrderBy                         |
	| <WidgetType> | HddListDAS16167 | <WidgetType>List_16167 | Operating System | Minimum           | HDD Total Size (GB) | HDD Total Size (GB) Minimum ASC |
	Then Widget Preview is displayed to the user
	Then 'All values are 0' message is displayed in Preview
	When User clicks 'CREATE' button 
	Then 'HddListDAS16167' Widget is displayed to the user
	Then 'All values are 0' message is displayed in 'HddListDAS16167' widget

Examples: 
	| WidgetType |
	| Pie        |
	| Donut      |
	| Half donut |