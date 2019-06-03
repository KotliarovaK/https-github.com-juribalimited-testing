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
	| WidgetType | Title             | List         | Type | AggregateBy | AggregateFunction | SplitBy                                | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown | Layout |
	| Half donut | WidgetForDAS15918 | 1803 Rollout |      |             | Count             | 1803: Pre-Migration \ Ready to Migrate |         |           |            |                  |           |        |
	Then User sees following options for Order By selector on Create Widget page:
	| items                                       |
	| 1803: Pre-Migration \ Ready to Migrate ASC  |
	| 1803: Pre-Migration \ Ready to Migrate DESC |
	| Count ASC                                   |
	| Count DESC                                  |