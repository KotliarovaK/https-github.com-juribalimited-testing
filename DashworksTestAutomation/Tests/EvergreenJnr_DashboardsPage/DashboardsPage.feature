﻿Feature: DashboardsPage
	Runs Dashboards Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Dashboards @DAS13114 @DAS13721 @archived
Scenario: EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDevicesPageWithProperItems
	When User clicks "Unknown" section from "Windows 10 Branch" circle chart on Dashboards page
	Then "Devices" list should be displayed to the user
	And "16" rows are displayed in the agGrid

@Evergreen @Dashboards @Widgets @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget
	When User clicks Edit mode trigger on Dashboards page
	And User clicks Ellipsis menu for "Top 10 App Vendors" Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to start    |
	| Move to end      |
	| Move to position |
	| Delete           |

@Evergreen @Dashboards @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection
	When User clicks Edit mode trigger on Dashboards page
	And User clicks Ellipsis menu for Section having "Operating System" Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Hide             |
	| 1 column         |
	| 3 column         |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |

@Evergreen @Dashboards @Widgets @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicated
	When User clicks Edit mode trigger on Dashboards page
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for "Device Profile" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees Widget with "Cloned - Device Profile" name on Dashboards page
	And User sees number of Widgets increased by "1" on Dashboards page
	When User deletes "Cloned - Device Profile" Widget on Dashboards page

@Evergreen @Dashboards @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated
	When User clicks Edit mode trigger on Dashboards page
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for Section having "Domain Profile" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by "1" on Dashboards page
	And User sees number of Widgets increased by "4" on Dashboards page
	When User deletes duplicated Section having "Domain Profile" Widget on Dashboards page

@Evergreen @Dashboards @Widgets @Delete_Newly_Created_List @DAS14668
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| ICSP: i-Schedule |
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	| 00OMQQXWA1DRI6   |
	| 00SH8162NAS524   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TestList_DAS14668" name
	And User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14668" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy          | AggregateBy      | AggregateFunction | OrderBy              | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_1 | TestList_DAS14668 | ICSP: i-Schedule | ICSP: i-Schedule | Count             | ICSP: i-Schedule ASC |                  | 5         |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_1" on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy          | AggregateBy      | AggregateFunction | OrderBy               | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_2 | TestList_DAS14668 | ICSP: i-Schedule | ICSP: i-Schedule | Count distinct    | ICSP: i-Schedule DESC |                  | 20        |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_2" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14668" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS14586
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14586" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title   | List   | SplitBy   | AggregateBy   | AggregateFunction  | OrderBy   | TableOrientation | MaxValues | ShowLegend   |
	| <Type>     | <Title> | <List> | <SplitBy> | <AggregateBy> | <AggregateFunctio> | <OrderBy> |                  | 10        | <ShowLegend> |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for "<Title>" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by "0" on Dashboards page
	And User sees number of Widgets increased by "1" on Dashboards page
	And User sees Widget with "<TitleCloned>" name on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14586" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

Examples:
	| Type   | Title                                 | List             | SplitBy       | AggregateBy  | AggregateFunctio | OrderBy         | TitleCloned                                    | ShowLegend |
	| Line   | All Devices Widget For DAS_14586      | All Devices      | Hostname      | Device Type  | Count            | Hostname DESC   | Cloned - All Devices Widget For DAS_14586      | false      |
	| Pie    | All Users Widget For DAS_14586        | All Users        | Username      | Display Name | Count distinct   | Username ASC    | Cloned - All Users Widget For DAS_14586        | false      |
	| Bar    | All Applications Widget For DAS_14586 | All Applications | Application   | Vendor       | Count            | Vendor DESC     | Cloned - All Applications Widget For DAS_14586 | true       |
	| Column | All Mailboxes Widget For DAS_14586    | All Mailboxes    | Email Address | Mail Server  | Count distinct   | Mail Server ASC | Cloned - All Mailboxes Widget For DAS_14586    | true       |

@Evergreen @Dashboards @DAS14587 @Widgets
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14587" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Pie        |       | All Devices | Device Type | Hostname    | Count             | Device Type ASC |                  | 10        |            |
	Then Error message with "Widget Title should not be empty" text is displayed on Widget page
	And There are no errors in the browser console
	When User creates new Widget
	| WidgetType | Title                  | List | SplitBy | AggregateBy | AggregateFunction | OrderBy | TableOrientation | MaxValues | ShowLegend |
	|            | Dashboard for DAS14587 |      |         |             |                   |         |                  |           |            |
	Then User sees widget with the next name "Dashboard for DAS14587" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14587" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @Sections @DAS14728
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetLegendCopiedWhenDuplicatingSection
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14728" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14728 | All Applications | Vendor  | Version     | Count             | Vendor ASC |                  | 10        | true       |
	And User remembers number of Widgets with Legend on Dashboards page
	And User clicks Ellipsis menu for Section having "WidgetForDAS14728" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Widgets with Legend increased by "1" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14728" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @Sections @DAS14583
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetStaysOnTopPositionAfterEditing
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14583" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_1 | All Applications | Vendor  | Version     | Count             | Vendor ASC |                  | 10        | true       |
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS14583_2 | All Applications | Vendor  | Version     | Count             | Vendor ASC |                  | 10        | true       |
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_3 | All Applications | Vendor  | Version     | Count             | Vendor ASC |                  | 10        | false      |
	And User clicks Ellipsis menu for "WidgetForDAS14583_3" Widget on Dashboards page
	And User clicks "Move to start" item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for "WidgetForDAS14583_3" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title | List | SplitBy | AggregateBy | AggregateFunction | OrderBy | TableOrientation | MaxValues | ShowLegend |
	|            |       |      |         | Vendor      |                   |         |                  |           |            |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles        |
	| WidgetForDAS14583_3 |
	| WidgetForDAS14583_1 |
	| WidgetForDAS14583_2 |
	When User clicks Settings button for "Dashboard for DAS14583" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @DAS14685 @Widgets
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14685" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Table      | WidgetForDAS14685 | All Applications | Application | Application | Count             | Application ASC |                  | 10        |            |
	Then There are no errors in the browser console
	Then User sees widget with the next name "WidgetForDAS14685" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14685" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @DAS14578 @DAS14584 @Widgets
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14578" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                                                                                                       | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Table      | Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred and seven | All Applications | Application | Application | Count             | Application ASC | Horizontal       | 10        |            |
	Then User sees widget with the next name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" on Dashboards page
	And Widget name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" has word break style on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14578" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel