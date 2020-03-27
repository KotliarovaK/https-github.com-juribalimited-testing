Feature: WidgetPie
	Runs tests for Pie Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14668 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                 |
	| Windows7Mi: Pre-Migration \ Scheduled Code |
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	| 00OMQQXWA1DRI6   |
	| 00SH8162NAS524   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList_DAS14668" name
	And Dashboard with 'Dashboard for DAS14668' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                                    | AggregateFunction | OrderBy   | MaxValues |
	| Pie        | Test_Widget_DAS14668_1 | TestList_DAS14668 | Windows7Mi: Pre-Migration \ Scheduled Code | Count             | Count ASC | 5         |
	Then 'Test_Widget_DAS14668_1' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                                    | AggregateBy                                | AggregateFunction | OrderBy                                         | MaxValues |
	| Pie        | Test_Widget_DAS14668_2 | TestList_DAS14668 | Windows7Mi: Pre-Migration \ Scheduled Code | Windows7Mi: Pre-Migration \ Scheduled Code | Count distinct    | Windows7Mi: Pre-Migration \ Scheduled Code DESC | 20        |
	Then 'Test_Widget_DAS14668_2' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15372 @DAS15317 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetThatUsesCpuArchitField
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| CPU Architecture |
	And User create dynamic list with "List15372" name on "Devices" page
	And User clicks 'Dashboards' on the left-hand menu
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy          | AggregateBy | AggregateFunction | OrderBy              | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15372 | List15372 | CPU Architecture | Hostname    | Count distinct    | CPU Architecture ASC | 10        | false      |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15372' Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15365 @DAS15352 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingPieWidgetUsedSavedList
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Model      |
	And User create dynamic list with "List15365" name on "Devices" page
	And User clicks 'Dashboards' on the left-hand menu
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects 'Bar' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects 'Column' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects 'Line' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects 'Donut' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User selects 'Half donut' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   |
	| Table      | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15662 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckDataLabelsOnTheWidget
	When Dashboard with 'DAS15662_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType   | Title             | List        | SplitBy  | AggregateFunction | OrderBy   |
	| <WidgetType> | WidgetForDAS15662 | All Devices | Hostname | Count             | Count ASC |
	When User selects 'Show data labels' checkbox on the Create Widget page
	Then Data Labels are displayed on the Preview page
	Then '<DataLabel>' data label is displayed on the Preview page
	When User clicks 'CREATE' button 
	Then Data Labels are displayed on the Dashboards page
	Then '<DataLabel>' data label is displayed on the Dashboards page
	When User clicks 'Duplicate' menu option for 'WidgetForDAS15662' widget
	When User clicks 'Edit' menu option for 'WidgetForDAS156622' widget
	Then 'Show data labels' checkbox is checked
	Then Data Labels are displayed on the Preview page
	Then '<DataLabel>' data label is displayed on the Preview page

Examples:
	| WidgetType | DataLabel      |
	| Pie        | 00RUUMAH9OZN9A |
	| Half donut | 00RUUMAH9OZN9A |
	| Donut      | 00RUUMAH9OZN9A |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15500 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatWhenEditingPieWidgetAggregateFunctionSelectionIsBeforeAggregateBySelection
	When Dashboard with 'Dashboard for DAS15500' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title           | List        | SplitBy  | AggregateFunction | OrderBy      | MaxValues |
	| Pie        | Widget_DAS15500 | All Devices | Hostname | Count             | Hostname ASC | 5         |
	Then 'Widget_DAS15500' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'Widget_DAS15500' widget
	When User selects '<WidgetType>' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown

Examples: 
	| WidgetType |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15508 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingCountAsAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Device Key                           |
	| 2004: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	When User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	When Dashboard with 'All Data Types for DAS15508' name created via API and opened
	When User waits for '3' seconds
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'ListWithAllDatatypes' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count' in the 'AggregateFunction' dropdown
	Then Aggregate By dropdown is disabled

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15509 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingCountDistinctAsAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Device Key                           |
	| 2004: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with 'All Data Types for DAS15509' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'ListWithAllDatatypes' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count distinct' in the 'AggregateFunction' dropdown
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
	| 2004: In Scope                       |
	| Windows7Mi: Communication \ DateTime |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15510 @DAS15511 @DAS15512 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatSelectingAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown	
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Device Key                           |
	| 2004: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with 'All Data Types for DAS15510' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'ListWithAllDatatypes' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects '<AggFunc>' in the 'AggregateFunction' dropdown
	Then User sees following options for Aggregate By selector on Create Widget page:
	| items               |
	| HDD Total Size (GB) |

Examples: 
	| AggFunc |
	| Sum     |
	| Minimum |
	| Maximum |
	| Average |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15524 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSelectingCountAsAggregateFunctionShowsFieldsWithCorrectValuesInOrderByDropDown
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Device Key                           |
	| 2004: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	And User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with 'All Data Types for DAS15524' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'ListWithAllDatatypes' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count' in the 'AggregateFunction' dropdown
	Then Aggregate By dropdown is disabled
	And User sees following options for Order By selector on Create Widget page:
	| items                 |
	| Operating System ASC  |
	| Operating System DESC |
	| Count ASC             |
	| Count DESC            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenCountAggregateFunctionIsSelected
	When Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'All Devices' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count' in the 'AggregateFunction' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                 |
	| Operating System ASC  |
	| Operating System DESC |
	| Count ASC             |
	| Count DESC            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenCountDistinctAggregateFunctionIsSelected
	When Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'All Devices' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count distinct' in the 'AggregateFunction' dropdown
	When User selects 'Hostname' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                        |
	| Operating System ASC         |
	| Operating System DESC        |
	| Hostname Count distinct ASC  |
	| Hostname Count distinct DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenSumAggregateFunctionIsSelected
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'HddList' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Sum' in the 'AggregateFunction' dropdown
	When User selects 'HDD Total Size (GB)' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                        |
	| Operating System ASC         |
	| Operating System DESC        |
	| HDD Total Size (GB) Sum ASC  |
	| HDD Total Size (GB) Sum DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenMinAggregateFunctionIsSelected
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'HddList' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Minimum' in the 'AggregateFunction' dropdown
	When User selects 'HDD Total Size (GB)' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                            |
	| Operating System ASC             |
	| Operating System DESC            |
	| HDD Total Size (GB) Minimum ASC  |
	| HDD Total Size (GB) Minimum DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenMaxAggregateFunctionIsSelected
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'HddList' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Maximum' in the 'AggregateFunction' dropdown
	When User selects 'HDD Total Size (GB)' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                            |
	| Operating System ASC             |
	| Operating System DESC            |
	| HDD Total Size (GB) Maximum ASC  |
	| HDD Total Size (GB) Maximum DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenAvgAggregateFunctionIsSelected
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	And User create dynamic list with "HddList" name on "Devices" page
	And Dashboard with 'TestDashboardForDAS15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	And User selects 'HddList' as Widget List
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Average' in the 'AggregateFunction' dropdown
	When User selects 'HDD Total Size (GB)' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                            |
	| Operating System ASC             |
	| Operating System DESC            |
	| HDD Total Size (GB) Average ASC  |
	| HDD Total Size (GB) Average DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17467 @DAS17515 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckNameAndLabelAndColorSchemeForEmptyOwnerCompliance
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	| Red                |
	| Amber              |
	| Green              |
	#| None               |
	And User clicks Save button on the list panel
	And User create dynamic list with "ListForDAS17467" name on "Devices" page
	Then "ListForDAS17467" list is displayed to user
	When Dashboard with 'Dashboard for DAS17467' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List            | SplitBy          | AggregateFunction | OrderBy              | ShowLegend |
	| Pie        | WidgetForDAS17467 | ListForDAS17467 | Owner Compliance | Count             | Owner Compliance ASC | true       |
	And User selects 'Show data labels' checkbox on the Create Widget page
	Then Widget Preview is displayed to the user
	And Color Scheme dropdown displayed with 'Compliance' placeholder 
	And Color Scheme dropdown is disabled
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS17467' Widget is displayed to the user
	Then Data Legends values are displayed in 'WidgetForDAS17467' widget on the Dashboard page
	| LegendsValue |
	| Empty        |
	| Ignore       |
	And Label icon displayed gray for 'WidgetForDAS17467' widget
	And There are no errors in the browser console
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17467 @DAS17515 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckColorSchemePlaceholderForReadiness
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Blocked            |
	| Amber              |
	| Green              |
	| Grey               |
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS17467_1" name on "Devices" page
	Then "ListForDAS17467_1" list is displayed to user
	When Dashboard with 'Dashboard for DAS17467_1' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title               | List              | SplitBy         | AggregateFunction | OrderBy             | ShowLegend |
	| Pie        | WidgetForDAS17467_1 | ListForDAS17467_1 | 2004: Readiness | Count             | 2004: Readiness ASC | true       |
	When User selects 'Show data labels' checkbox on the Create Widget page
	Then Widget Preview is displayed to the user
	Then Color Scheme dropdown displayed with 'Readiness' placeholder 
	Then Color Scheme dropdown is disabled
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17515 @DAS17987 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectColorSchemeisUsedWhenWidgetIsSplitByReadinessAndComplianceFields	
    When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| Windows7Mi: Application Readiness |
	| Application Compliance            |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User create dynamic list with "ListForDAS17515" name on "Devices" page
	Then "ListForDAS17515" list is displayed to user
	When Dashboard with 'DAS17515_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | SplitBy                           | AggregateFunction | OrderBy                               | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS17515 | ListForDAS17515 | Windows7Mi: Application Readiness | Count             | Windows7Mi: Application Readiness ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	Then Color Scheme dropdown displayed with 'Readiness' placeholder
	Then Color Scheme dropdown is disabled
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	When User clicks 'Edit' menu option for 'WidgetForDAS17515' widget
	When User selects 'Application Compliance' in the 'SplitBy' dropdown
	Then User sees 'Application Compliance ASC' option for Order By selector on Create Widget page
	Then Color Scheme dropdown displayed with 'Compliance' placeholder 
	Then Color Scheme dropdown is disabled
	When User clicks 'UPDATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18072 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFilterChangedInUiPartAfterSelectingAnotherFilter
	When Dashboard with 'DAS18072_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title       | List        | SplitBy     | AggregateFunction | OrderBy          |
	| Pie        | Widget18072 | All Devices | Device Type | Count             | Device Type ASC  |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	Then 'Device Type ASC' option displayed for Widget OrderBy
	When User selects 'Device Type DESC' in the 'Order By' dropdown
	Then 'Device Type DESC' option displayed for Widget OrderBy
	When User selects 'Hostname' in the 'SplitBy' dropdown
	Then 'Hostname DESC' option displayed for Widget OrderBy
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Hostname ASC' in the 'Order By' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Device Type' in the 'SplitBy' dropdown
	Then 'Device Type ASC' option displayed for Widget OrderBy

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18635 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatPreviewDisplayedForWidgetWhenReadinessSelectedAsSplitBy
	When Dashboard with 'Dashboard for DAS18635' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List                               | SplitBy               | AggregateFunction | OrderBy                   |
	| Pie        | WidgetForDAS18635 | Device Readiness Columns & Filters | UserEvergr: Readiness | Count             | UserEvergr: Readiness ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS18635' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'WidgetForDAS18635' widget
	When User adds new Widget
	| WidgetType | Title             | List                               | SplitBy               | AggregateFunction | AggregateBy | OrderBy                   |
	| Pie        | WidgetForDAS18635 | Device Readiness Columns & Filters | UserEvergr: Readiness | Count distinct    | Device Type | UserEvergr: Readiness ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18574 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckClickingThroughReadinessValueOfPageWidget
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Blocked            |
	| Amber              |
	| Green              |
	| Grey               |
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18574" name on "Devices" page
	Then "ListForDAS18574" list is displayed to user
	When Dashboard with 'Dashboard for DAS18574' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | SplitBy         | AggregateFunction | OrderBy             | ShowLegend |
	| Pie        | WidgetForDAS18574 | ListForDAS18574 | 2004: Readiness | Count             | 2004: Readiness ASC | true       |
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS18574' Widget is displayed to the user
	When User clicks on 'Green' category of 'WidgetForDAS18574' widget
	Then table content is present