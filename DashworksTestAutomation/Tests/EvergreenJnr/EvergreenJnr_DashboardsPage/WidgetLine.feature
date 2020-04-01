Feature: WidgetLine
	Runs tests for Line Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15737 @DAS15662 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdown
	When User clicks 'Users' on the left-hand menu
	When User add following columns using URL to the "Users" page:
	| ColumnName                 |
	| prK: Application Readiness |
	And User create dynamic list with "TestList_DAS15737" name on "Users" page
	And Dashboard with 'Dashboard for DAS15737' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Line' in the 'WidgetType' dropdown
	And User enters 'DAS15737' as Widget Title
	When User selects 'TestList_DAS15737' option from 'List' autocomplete
	When User selects 'prK: Application Readiness' in the 'SplitBy' dropdown
	When User selects 'Count' in the 'AggregateFunction' dropdown
	When User selects 'prK: Application Readiness ASC' in the 'OrderBy' dropdown
	When User clicks 'Colour Scheme' dropdown
	Then Colour Scheme dropdown is displayed to the user
	Then 'Show data labels' checkbox is not displayed
	Then 'Show legend' checkbox is not displayed
	When User clicks 'CREATE' button 

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPage
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And user select "Device Type" filter
	And User clicks in search field in the Filter block
	And User enters "Desktop" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| 2004: Pre-Migration \ Scheduled Date |
	And User create dynamic list with "2004 ScheduleDAS16069" name on "Devices" page
	Then "2004 ScheduleDAS16069" list is displayed to user
	When Dashboard with '2004 ProjectDAS16069' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title                    | List                  | AggregateBy | AggregateFunction | SplitBy                              | OrderBy                                  | Drilldown |
	| Line       | Project ScheduleDAS16069 | 2004 ScheduleDAS16069 | Hostname    | Count distinct    | 2004: Pre-Migration \ Scheduled Date | 2004: Pre-Migration \ Scheduled Date ASC | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'Project ScheduleDAS16069' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	Then Tooltip is displayed for the point of Line widget
	| WidgetName               | NumberOfPoint | Tooltip      |
	| Project ScheduleDAS16069 | 1             | 5 Nov 2018 4 |
	When User clicks point of Line widget
	| WidgetName               | NumberOfPoint | 
	| Project ScheduleDAS16069 | 1             | 
	Then "4" rows are displayed in the agGrid
	Then grid headers are displayed in the following order
	| ColumnName                           |
	| Hostname                             |
	| Device Type                          |
	| Operating System                     |
	| Owner Display Name                   |
	| 2004: Pre-Migration \ Scheduled Date |	
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15920 @DAS15662 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboard
	When User clicks 'Users' on the left-hand menu
	When User add following columns using URL to the "Users" page:
	| ColumnName          |
	| Device Application Compliance |
	| Compliance                    |
	And User create dynamic list with "ListForDas15920" name on "Users" page
	And Dashboard with 'DashboardForDas15920' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title                 | List            | AggregateFunction | SplitBy                       | OrderBy                           | Drilldown |
	| Line       | LineWidgetForDas15920 | ListForDas15920 | Count             | Device Application Compliance | Device Application Compliance ASC | Yes       |
	Then Widget Preview is displayed to the user
	Then 'Show data labels' checkbox is not displayed
	When User clicks 'CREATE' button
	Then 'LineWidgetForDas15920' Widget is displayed to the user
	And Line chart displayed in 'LineWidgetForDas15920' widget

@Evergreen @EvergreenJnr_DashboardsPage @DAS15544 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Service Pack or Build |
	And User create dynamic list with "ListForDas15544" name on "Devices" page
	And Dashboard with '2004 ProjectDAS15544' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title                     | List            | AggregateFunction | SplitBy               | OrderBy                   | Drilldown |
	| Line       | SortOrderCheckForDas15544 | ListForDas15544 | Count             | Service Pack or Build | Service Pack or Build ASC | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'SortOrderCheckForDas15544' Widget is displayed to the user
	And Line X labels of 'SortOrderCheckForDas15544' widget is displayed in following order:
	| ColumnName             |
	| Empty                  |
	| No Service Pack        |
	| Service Pack 1         |
	| Service Pack 2         |
	| Service Pack 3         |
	| Service Pack 3, v.6055 |
	| Windows 8.0            |
	| Windows 8.1            |
	| 1507                   |
	| 1607                   |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15462
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount
	When User clicks 'Dashboards' on the left-hand menu
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title                      | List        | AggregateBy | AggregateFunction | SplitBy          | OrderBy              |
	| Line       | Project AllDevicesDAS15462 | All Devices | Hostname    | Count distinct    | Operating System | Operating System ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'Project AllDevicesDAS15462' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	Then Tooltip is displayed for the point of Line widget
	| WidgetName                 | NumberOfPoint | Tooltip     |
	| Project AllDevicesDAS15462 | 2             | OS X 10.5 1 |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17825 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetsShowsGraphDataWhenSplitByReadinessOrComplianceFields
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| Windows7Mi: Application Readiness |
	| Application Compliance            |
	And User create dynamic list with "ListForDAS17825" name on "Devices" page
	Then "ListForDAS17825" list is displayed to user
	When Dashboard with 'DAS17825_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List            | SplitBy                           | AggregateFunction | OrderBy   |
	| Line       | WidgetForDAS17825 | ListForDAS17825 | Windows7Mi: Application Readiness | Count             | Count ASC |
	Then Widget Preview is displayed to the user
	And Color Scheme dropdown displayed with 'Readiness' placeholder
	And Color Scheme dropdown is disabled
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS17825' Widget is displayed to the user
	And Line chart displayed in 'WidgetForDAS17825' widget
	When User clicks 'Edit' menu option for 'WidgetForDAS17825' widget
	When User selects 'Application Compliance' in the 'SplitBy' dropdown
	When User selects 'Application Compliance ASC' in the 'OrderBy' dropdown
	Then Widget Preview is displayed to the user
	And Color Scheme dropdown displayed with 'Compliance' placeholder 
	And Color Scheme dropdown is disabled
	When User clicks 'UPDATE' button 
	Then 'WidgetForDAS17825' Widget is displayed to the user
	And Line chart displayed in 'WidgetForDAS17825' widget