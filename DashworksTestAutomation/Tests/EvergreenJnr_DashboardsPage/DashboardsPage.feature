Feature: DashboardsPage
	Runs Dashboards Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Dashboards @DAS13114 @DAS13721 @archived
Scenario: EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDevicesPageWithProperItems
	When User clicks "Unknown" section from "Windows 10 Branch" circle chart on Dashboards page
	Then "Devices" list should be displayed to the user
	And "16" rows are displayed in the agGrid

@Evergreen @Dashboards @DAS14587
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14587" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues | ColorScheme | ShowLegend |
	| Pie        |       | All Devices | Device Type | Hostname    | Count             | Device Type ASC | 10        | Multi       | No         |
	Then Error message with "Widget Title should not be empty" text is displayed on Widget page
	And There are no errors in the browser console
	