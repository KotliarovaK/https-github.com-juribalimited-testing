Feature: WidgetPie
	Runs tests for Pie Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14668 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| ICSP: i-stage A \ i-Schedule |
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	| 00OMQQXWA1DRI6   |
	| 00SH8162NAS524   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TestList_DAS14668" name
	And Dashboard with "Dashboard for DAS14668" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                      | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_1 | TestList_DAS14668 | ICSP: i-stage A \ i-Schedule |             | Count             | Count ASC |                  | 5         |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_1" on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                      | AggregateBy                  | AggregateFunction | OrderBy                           | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_2 | TestList_DAS14668 | ICSP: i-stage A \ i-Schedule | ICSP: i-stage A \ i-Schedule | Count distinct    | ICSP: i-stage A \ i-Schedule DESC |                  | 20        |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_2" on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15372 @DAS15317 @Delete_Newly_Created_List @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetThatUsesCpuArchitField
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| CPU Architecture |
	And User create dynamic list with "List15372" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy          | AggregateBy | AggregateFunction | OrderBy              | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Pie        | WidgetForDAS15372 | List15372 | CPU Architecture | Hostname    | Count distinct    | CPU Architecture ASC |                  | 10        | false      |      |           |        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then "WidgetForDAS15372" Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15365 @DAS15352 @Delete_Newly_Created_List @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingPieWidgetUsedSavedList
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Model |
	And User create dynamic list with "List15365" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| Pie        | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC |                  | 10        | true       |      |           |        |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Bar" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Column" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Line" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Donut" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Half donut" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects "Table" in the "Widget Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15662 @Delete_Newly_Created_Dashboard
Scenario Outline: EvergreenJnr_DashboardsPage_CheckDataLabelsOnTheWidget
	When Dashboard with "DAS15662_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType   | Title             | List        | SplitBy  | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Type | Drilldown | Layout |
	| <WidgetType> | WidgetForDAS15662 | All Devices | Hostname |             | Count             | Count ASC |                  |           |            |      |           |        |
	And User selects "Show data labels" checkbox on the Create Widget page
	Then Data Labels are displayed on the Dashboards page
	And "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks the "CREATE" Action button
	Then Data Labels are displayed on the Dashboards page
	And "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks Ellipsis menu for "WidgetForDAS15662" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for "WidgetForDAS156622" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	Then "Show data labels" checkbox is checked on the Create Widget page
	And Data Labels are displayed on the Dashboards page
	And "<DataLabel>" data label is displayed on the Dashboards page

Examples:
	| WidgetType | DataLabel      |
	| Pie        | 00RUUMAH9OZN9A |
	| Half donut | 00RUUMAH9OZN9A |
	| Donut      | 00RUUMAH9OZN9A |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15500 @Delete_Newly_Created_Dashboard
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatWhenEditingPieWidgetAggregateFunctionSelectionIsBeforeAggregateBySelection
	When Dashboard with "Dashboard for DAS15500" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title           | List        | SplitBy  | AggregateBy | AggregateFunction | OrderBy      | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Widget_DAS15500 | All Devices | Hostname |             | Count             | Hostname ASC |                  | 5         |            |
	Then User sees widget with the next name "Widget_DAS15500" on Dashboards page
	When User clicks Ellipsis menu for "Widget_DAS15500" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "<WidgetType>" in the "Widget Type" Widget dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown

Examples: 
	| WidgetType |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15508 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingCountAsAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| Device Key                           |
	| 1803: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with "All Data Types for DAS15508" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "ListWithAllDatatypes" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Count" as Widget Aggregate Function
	Then Aggregate By dropdown is disabled

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15509 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingCountDistinctAsAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| Device Key                           |
	| 1803: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with "All Data Types for DAS15509" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "ListWithAllDatatypes" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Count distinct" as Widget Aggregate Function
	Then User sees following options for Aggregate By selector on Create Widget page:
	| items                                |
	| Device Key                           |
	| Hostname                             |
	| First Seen Date                      |
	| Compliance                           |
	| Device Type                          |
	| HDD Total Size (GB)                  |
	| Operating System                     |
	| Owner Display Name                   |
	| 1803: In Scope                       |
	| Windows7Mi: Communication \ DateTime |


@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15510 @DAS15511 @DAS15512 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatSelectingAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown	
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| Device Key                           |
	| 1803: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with "All Data Types for DAS15510" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "ListWithAllDatatypes" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "<AggFunc>" as Widget Aggregate Function
	Then User sees following options for Aggregate By selector on Create Widget page:
	| items               |
	| HDD Total Size (GB) |

Examples: 
	| AggFunc |
	| Sum     |
	| Min     |
	| Max     |
	| Average |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15524 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingCountAsAggregateFunctionShowsFieldsWithCorrectValuesInOrderByDropDown
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| Device Key                           |
	| 1803: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with "All Data Types for DAS15524" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "ListWithAllDatatypes" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Count" as Widget Aggregate Function
	Then Aggregate By dropdown is disabled
	And User sees following options for Order By selector on Create Widget page:
	| items                 |
	| Operating System ASC  |
	| Operating System DESC |
	| Count ASC             |
	| Count DESC            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenCountAggregateFunctionIsSelected
	When Dashboard with "TestDashboardForDAS15362" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "All Devices" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Count" as Widget Aggregate Function
	Then User sees following options for Order By selector on Create Widget page:
	| items                 |
	| Operating System ASC  |
	| Operating System DESC |
	| Count ASC             |
	| Count DESC            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenCountDistinctAggregateFunctionIsSelected
	When Dashboard with "TestDashboardForDAS15362" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "All Devices" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Count distinct" as Widget Aggregate Function
	And User selects "Hostname" as Widget AggregateBy
	Then User sees following options for Order By selector on Create Widget page:
	| items                        |
	| Operating System ASC         |
	| Operating System DESC        |
	| Hostname Count distinct ASC  |
	| Hostname Count distinct DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenSumAggregateFunctionIsSelected
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| HDD Total Size (GB)                  |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with "TestDashboardForDAS15362" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "HddList" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Sum" as Widget Aggregate Function
	And User selects "HDD Total Size (GB)" as Widget AggregateBy
	Then User sees following options for Order By selector on Create Widget page:
	| items                        |
	| Operating System ASC         |
	| Operating System DESC        |
	| HDD Total Size (GB) Sum ASC  |
	| HDD Total Size (GB) Sum DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenMinAggregateFunctionIsSelected
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| HDD Total Size (GB)                  |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with "TestDashboardForDAS15362" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "HddList" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Minimum" as Widget Aggregate Function
	And User selects "HDD Total Size (GB)" as Widget AggregateBy
	Then User sees following options for Order By selector on Create Widget page:
	| items                            |
	| Operating System ASC             |
	| Operating System DESC            |
	| HDD Total Size (GB) Minimum ASC  |
	| HDD Total Size (GB) Minimum DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenMaxAggregateFunctionIsSelected
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| HDD Total Size (GB)                  |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with "TestDashboardForDAS15362" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "HddList" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Maximum" as Widget Aggregate Function
	And User selects "HDD Total Size (GB)" as Widget AggregateBy
	Then User sees following options for Order By selector on Create Widget page:
	| items                            |
	| Operating System ASC             |
	| Operating System DESC            |
	| HDD Total Size (GB) Maximum ASC  |
	| HDD Total Size (GB) Maximum DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenAvgAggregateFunctionIsSelected
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| HDD Total Size (GB)                  |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with "TestDashboardForDAS15362" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "Pie" in the "Widget Type" Widget dropdown
	And User enters "Widget Name" as Widget Title
	And User selects "HddList" as Widget List
	And User selects "Operating System" as Widget Split By
	And User selects "Average" as Widget Aggregate Function
	And User selects "HDD Total Size (GB)" as Widget AggregateBy
	Then User sees following options for Order By selector on Create Widget page:
	| items                            |
	| Operating System ASC             |
	| Operating System DESC            |
	| HDD Total Size (GB) Average ASC  |
	| HDD Total Size (GB) Average DESC |