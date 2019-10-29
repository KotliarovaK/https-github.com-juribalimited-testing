Feature: WidgetTable
	Runs tests for Table Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14685 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget
	When Dashboard with 'Dashboard for DAS14685' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetForDAS14685 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	Then There are no errors in the browser console
	And User sees widget with the next name 'WidgetForDAS14685' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14920 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccursWhenCreatingDashboardWidgetThatUsesBooleanField
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName           |
	| Secure Boot Enabled  |
	| Windows7Mi: In Scope |
	And User create dynamic list with "14920_List" name on "Devices" page
	And Dashboard with 'Dashboard for DAS14920' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title       | List       | SplitBy             | AggregateFunction | OrderBy   | MaxValues |
	| Table      | DAS-14920_1 | 14920_List | Secure Boot Enabled | Count             | Count ASC | 10        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	And 'DAS-14920_1' Widget is displayed to the user
	And '2,189' count is displayed for 'False' in the table Widget
	And '2,192' count is displayed for 'True' in the table Widget
	And '12,898' count is displayed for 'Unknown' in the table Widget
	#Second Widget creation
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title       | List       | SplitBy              | AggregateFunction | OrderBy   | MaxValues |
	| Table      | DAS-14920_2 | 14920_List | Windows7Mi: In Scope | Count             | Count ASC | 10        |
	Then There are no errors in the browser console
	And 'DAS-14920_2' Widget is displayed to the user
	Then '12,120' count is displayed for 'False' in the table Widget
	And '5,159' count is displayed for 'True' in the table Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16073 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetIsDisplayedCorrectly
	When Dashboard with 'Dashboard for DAS16073' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS16073 | All Devices | Hostname | Count             | Count DESC | Vertical         | 10        |
	Then There are no errors in the browser console
	And 'WidgetForDAS16073' Widget is displayed to the user
	Then link is not displayed for the 'CAS' value in the Widget
	Then link is not displayed for the 'WIN-43TMG2KMRBI' value in the Widget
	Then link is not displayed for the 'WIN81PRO' value in the Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetValuesLeadsToApplicationsListFilteredPage
	When Dashboard with 'Dashboard for DAS16069_1' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateFunction | OrderBy    | MaxValues |
	| Table      | WidgetForDAS16069_1 | All Applications | Vendor  | Count             | Count DESC | 500       |
	Then 'WidgetForDAS16069_1' Widget is displayed to the user
	And '918' count is displayed for 'Microsoft Corporation' in the table Widget
	When User clicks '918' value for 'Microsoft Corporation' column
	Then "918" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName         |
	| Application        |
	| Vendor             |
	| Version            |
	| Owner Display Name |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15208
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetDisplayedFullyInPreviewPane
	When User clicks 'Dashboards' on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title     | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation |
	| Table      | DAS-15208 | All Devices | Device Type | Device Type | Count distinct    | Device Type ASC | Horizontal       |
	Then Widget Preview is displayed to the user
	And Table widget displayed inside preview pane correctly
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DAS16275 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckCapacitySlotsDisplayOrderInDashboards
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                                        |
	| Windows7Mi: Pre-Migration \ Scheduled Date (Slot) |
	And User create dynamic list with "Devices_List_DAS16275" name on "Devices" page
	And Dashboard with 'DAS16275_Dashboard' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title           | List                  | SplitBy                                           | AggregateFunction | OrderBy   | TableOrientation |
	| Table      | DAS16275_Widget | Devices_List_DAS16275 | Windows7Mi: Pre-Migration \ Scheduled Date (Slot) | Count             | Count ASC | Vertical         |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS16275_Widget' Widget is displayed to the user
	And content in the Widget is displayed in following order:
	| TableValue                    |
	| Slot 2018-10-01 to 2018-12-31 |
	| Slot 2018-11-01 - 2020-12-26  |
	| Empty                         |
	When User clicks Ellipsis menu for 'DAS16275_Widget' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User selects 'Count DESC' in the 'Order By' Widget dropdown
	And User clicks 'UPDATE' button 
	Then content in the Widget is displayed in following order:
	| TableValue                    |
	| Empty                         |
	| Slot 2018-11-01 - 2020-12-26  |
	| Slot 2018-10-01 to 2018-12-31 |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15826 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckRingsDisplayOrderInAWidgetOnDashboard
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                   |
	| UserEvergr: Ring (All Users) |
	And User create dynamic list with "DeviceListForDAS15826" name on "Devices" page
	And Dashboard with 'DAS15826_Dashboard' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title           | List                  | SplitBy                      | AggregateFunction | OrderBy                          | TableOrientation |
	| Table      | DAS15826_Widget | DeviceListForDAS15826 | UserEvergr: Ring (All Users) | Count             | UserEvergr: Ring (All Users) ASC | Vertical         |
	Then Card 'DAS15826_Widget' Widget is displayed to the user
	And content in the Widget is displayed in following order:
	| TableValue       |
	| Empty            |
	| Unassigned       |
	| Unassigned2      |
	| Evergreen Ring 1 |
	| Evergreen Ring 2 |
	| Evergreen Ring 3 |
	When User clicks Ellipsis menu for 'DAS15826_Widget' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User selects 'UserEvergr: Ring (All Users) DESC' in the 'Order By' Widget dropdown
	And User clicks 'UPDATE' button 
	Then Card 'DAS15826_Widget' Widget is displayed to the user
	And content in the Widget is displayed in following order:
	| TableValue       |
	| Evergreen Ring 3 |
	| Evergreen Ring 2 |
	| Evergreen Ring 1 |
	| Unassigned2      |
	| Unassigned       |
	| Empty            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15582 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingAggregateFunctionWhereThereAreNoColumnsAvailableShowsWarning
	When Dashboard with 'Dashboard for DAS15582' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	And User selects 'Table' in the 'Widget Type' Widget dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'All Devices' as Widget List
	When User selects 'Operating System' in the 'Split By' Widget dropdown
	When User selects 'Sum' in the 'Aggregate Function' Widget dropdown
	Then User sees 'There are no fields available for this aggregate function' warning text below Lists field

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenFirstAggregateFunctionIsSelected
	When User clicks 'Users' on the left-hand menu
	When User add following columns using URL to the "Users" page:
	| ColumnName                   |
	| Last Logon Date |
	And User create dynamic list with "LastLogout" name on "Users" page
	And Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User selects 'Table' in the 'Widget Type' Widget dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'LastLogout' as Widget List
	And User selects 'Domain' in the 'Split By' Widget dropdown
	When User selects 'First' in the 'Aggregate Function' Widget dropdown
	When User selects 'Last Logon Date' in the 'Aggregate By' Widget dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                      |
	| Domain ASC                 |
	| Domain DESC                |
	| Last Logon Date First ASC  |
	| Last Logon Date First DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenLastAggregateFunctionIsSelected
	When User clicks 'Users' on the left-hand menu
	When User add following columns using URL to the "Users" page:
	| ColumnName                   |
	| Last Logon Date |
	And User create dynamic list with "LastLogout" name on "Users" page
	And Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User selects 'Table' in the 'Widget Type' Widget dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'LastLogout' as Widget List
	And User selects 'Domain' in the 'Split By' Widget dropdown
	When User selects 'Last' in the 'Aggregate Function' Widget dropdown
	When User selects 'Last Logon Date' in the 'Aggregate By' Widget dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                     |
	| Domain ASC                |
	| Domain DESC               |
	| Last Logon Date Last ASC  |
	| Last Logon Date Last DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17599 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckClickthoughNumbersBasedArchivedItemsRedirectsToFilteredListWithEnabledArchivedItems
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in 'true'
	And User create dynamic list with "List17599" name on "Devices" page
	When Dashboard with 'Dashboard for DAS17599' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List      | SplitBy  | AggregateFunction | OrderBy      |
	| Table      | WidgetForDAS17599 | List17599 | Hostname | Count             | Hostname ASC |
	Then 'WidgetForDAS17599' Widget is displayed to the user
	And '82' count is displayed for 'Empty' in the table Widget
	When User clicks '82' value for 'Empty' column
	Then "82" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18145 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoEndlessSpinnerInPreviewIfCreateWidgetUsingSeverityAggregateFunction
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Compliance                           |
	And User create dynamic list with "ListFor18145" name on "Devices" page
	And Dashboard with 'DashboardForDAS18145' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title     | List         | SplitBy          | AggregateBy | AggregateFunction | OrderBy              |
	| Table      | DAS-18145 | ListFor18145 | Operating System | Compliance  | Severity          | Operating System ASC |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18091 @DAS18090 @DAS16516 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckTheEmptyItemIsNotDisplayedOnTheDashboardPageForTheListWithoutArchivedItem
	When Dashboard with 'Dashboard for DAS18091' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List         | SplitBy          | AggregateFunction | AggregateBy                            | OrderBy              |
	| Table      | WidgetForDAS18091 | 1803 Rollout | Operating System | Severity          | 1803: Pre-Migration \ Ready to Migrate | Operating System ASC |
	Then 'WidgetForDAS18091' Widget is displayed to the user
	And There is no 'Empty' column for 'WidgetForDAS18091' widget
	#DAS18090 
	When User clicks 'NOT READY' value for 'Windows 7' column
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Operating System is Windows 7" is displayed in added filter info
	And "Any Device in list 1803 Rollout" is displayed in added filter info
	And "1803: Pre-Migration \ Ready to Migrate is Not Ready" is displayed in added filter info
	#DAS16516
	When User clicks 'Dashboards' on the left-hand menu
	And User clicks Show Dashboards panel icon on Dashboards page
	Then User sees Dashboards sub menu on Dashboards page
	When User navigates to the "Dashboard for DAS18091" list
	And User clicks 'READY' value for 'Windows Vista' column
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Operating System is Windows Vista" is displayed in added filter info
	And "Any Device in list 1803 Rollout" is displayed in added filter info
	And "1803: Pre-Migration \ Ready to Migrate is Ready" is displayed in added filter info

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNewSeverityOptionDisplayedForWidget
	When Dashboard with 'Dashboard for DAS15852' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title     | List         | SplitBy                                | AggregateFunction | AggregateBy                            |
	| Table      | DAS-15852 | 1803 Rollout | 1803: Pre-Migration \ Ready to Migrate | Severity          | 1803: Pre-Migration \ Ready to Migrate |
	Then User sees following options for Order By selector on Create Widget page:
	| items                                               |
	| 1803: Pre-Migration \ Ready to Migrate ASC          |
	| 1803: Pre-Migration \ Ready to Migrate DESC         |
	| 1803: Pre-Migration \ Ready to Migrate Severity ASC |
	| 1803: Pre-Migration \ Ready to Migrate Severity DESC |
	When User selects '1803: Pre-Migration \ Ready to Migrate Severity ASC' in the 'Order By' Widget dropdown
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then Table columns of 'DAS-15852' widget placed in the next order:
	| headers   |
	| Empty     |
	| Unknown   |
	| Not Ready |
	| On Target |
	| Ready     |
	
	When User clicks Ellipsis menu for 'DAS-15852' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	When User selects '1803: Pre-Migration \ Ready to Migrate ASC' in the 'Order By' Widget dropdown
	Then Widget Preview is displayed to the user
	When User clicks 'UPDATE' button
	Then Table columns of 'DAS-15852' widget placed in the next order:
	| headers   |
	| Empty     |
	| Not Ready |
	| On Target |
	| Ready     |
	| Unknown   |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatReadinessValuesAreShownWithTheCorrectColours
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "1803: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	And User clicks Save button on the list panel
	And User create dynamic list with "Devices_List_DAS15852" name on "Devices" page
	Then "Devices_List_DAS15852" list is displayed to user
	When Dashboard with 'DAS15852_Dashboard' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title           | List                  | SplitBy     | AggregateFunction | AggregateBy     | OrderBy                      |
	| Table      | DAS16275_Widget | Devices_List_DAS15852 | Device Type | Severity          | 1803: Readiness | 1803: Readiness Severity ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'Green' color displayed for 'GREEN' value in table 'DAS16275_Widget' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatComplianceValuesAreShownWithTheCorrectColours
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Owner Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	And User clicks Save button on the list panel
	And User create dynamic list with "Devices_List_DAS15852" name on "Devices" page
	Then "Devices_List_DAS15852" list is displayed to user
	When Dashboard with 'DAS15852_Dashboard' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title           | List                  | SplitBy     | AggregateFunction | AggregateBy      | OrderBy                       |
	| Table      | DAS16275_Widget | Devices_List_DAS15852 | Device Type | Severity          | Owner Compliance | Owner Compliance Severity ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'Green' color displayed for 'GREEN' value in table 'DAS16275_Widget' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAggregateFuncAreNotAvailableForColumnsThatDoNotHaveComplianceOrReadiness
	When Dashboard with 'DAS15852_Dashboard' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title           | List        | SplitBy     | AggregateFunction |
	| Table      | DAS16275_Widget | All Devices | Device Type | Severity          |
	Then User sees 'There are no fields available for this aggregate function' warning text below Lists field
	When User adds new Widget
	| WidgetType | Title           | List        | Type      | AggregateFunction |
	| Card       | DAS16275_Widget | All Devices | Aggregate | Severity          |
	Then User sees 'There are no fields available for this aggregate function' warning text below Lists field

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18324 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorsOccurWhenCreatingEditingTableWidgetThatReturnsZeroResults
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "App Count (Entitled)" filter where type is "Equals" with added column and following value:
    | Values |
    | 0      |
	And User Add And "App Count (Used)" filter where type is "Less than" with added column and following value:
    | Values |
    | 1      |
	And User clicks Save button on the list panel
	And User create dynamic list with "AListForDAS18324" name on "Devices" page
	Then "AListForDAS18324" list is displayed to user
	When Dashboard with 'Dashboard for DAS18324' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List             | SplitBy          | AggregateFunction | OrderBy              |
	| Table      | WidgetForDAS18324 | AListForDAS18324 | App Count (Used) | Count             | App Count (Used) ASC |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18327 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatFiltersSectionDisplayedCorrectlyAfterClickingThroughTableWidget
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User Add And "1803: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	| Green              |
	| Amber              |
	When User clicks Save button on the list panel
	When User create dynamic list with "Devices_List_DAS18327" name on "Devices" page
	When Dashboard with 'DAS18327_Dashboard' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy        | AggregateFunction | AggregateBy     | OrderBy            |
	| Table      | DAS18327_Widget | Devices_List_DAS18327 | 1803: In Scope | Severity          | 1803: Readiness | 1803: In Scope ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS18327_Widget' Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'AMBER' value for 'True' column
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Filter Expression icon in Filter Panel
	Then Filter Expression displayed within Filter Panel
	Then "(1803: In Scope = true AND 1803: Readiness = None, Green or Amber)" text is displayed in filter container