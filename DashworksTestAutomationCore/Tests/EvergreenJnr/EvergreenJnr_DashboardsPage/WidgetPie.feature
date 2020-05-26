Feature: WidgetPie
	Runs tests for Pie Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14668 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                 |
	| Windows7Mi: Pre-Migration \ Scheduled Code |
	When User clicks the Actions button
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	| 00OMQQXWA1DRI6   |
	| 00SH8162NAS524   |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "TestList_DAS14668" name
	When Dashboard with 'Dashboard_14668' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                                    | AggregateFunction | OrderBy   | MaxValues |
	| Pie        | Test_Widget_DAS14668_1 | TestList_DAS14668 | Windows7Mi: Pre-Migration \ Scheduled Code | Count             | Count ASC | 5         |
	Then 'Test_Widget_DAS14668_1' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title                  | List              | SplitBy                                    | AggregateBy                                | AggregateFunction | OrderBy                                         | MaxValues |
	| Pie        | Test_Widget_DAS14668_2 | TestList_DAS14668 | Windows7Mi: Pre-Migration \ Scheduled Code | Windows7Mi: Pre-Migration \ Scheduled Code | Count distinct    | Windows7Mi: Pre-Migration \ Scheduled Code DESC | 20        |
	Then 'Test_Widget_DAS14668_2' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15372 @DAS15317 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetThatUsesCpuArchitField
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| CPU Architecture |
	When User create dynamic list with "List15372" name on "Devices" page
	When User clicks 'Dashboards' on the left-hand menu
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List      | SplitBy          | AggregateBy | AggregateFunction | OrderBy              | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15372 | List15372 | CPU Architecture | Hostname    | Count distinct    | CPU Architecture ASC | 10        | false      |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15372' Widget is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15365 @DAS15352 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingPieWidgetUsedSavedList
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Model      |
	When User create dynamic list with "List15365" name on "Devices" page
	When User clicks 'Dashboards' on the left-hand menu
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Bar' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Column' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Line' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Donut' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Half donut' in the 'WidgetType' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   |
	| Table      | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15662 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckDataLabelsOnTheWidget
	When Dashboard with 'Dashboard_15662' name created via API and opened
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
	When Dashboard with 'Dashboard_15508' name created via API and opened
	When User waits for '3' seconds
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	When User enters 'Widget Name' as Widget Title
	When User selects 'ListWithAllDatatypes' option from 'List' autocomplete
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count' in the 'AggregateFunction' dropdown
	Then 'Aggregate By' dropdown is disabled

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
	When User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	When Dashboard with 'Dashboard_15509' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	When User enters 'Widget Name' as Widget Title
	When User selects 'ListWithAllDatatypes' option from 'List' autocomplete
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
	When User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	When Dashboard with 'Dashboard_15510' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	When User enters 'Widget Name' as Widget Title
	When User selects 'ListWithAllDatatypes' option from 'List' autocomplete
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

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenSumAggregateFunctionIsSelected
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| HDD Total Size (GB) |
	When User create dynamic list with "HddList" name on "Devices" page
	When Dashboard with 'Dashboard_15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	When User enters 'Widget Name' as Widget Title
	When User selects 'HddList' option from 'List' autocomplete
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects '<AggregateFunc>' in the 'AggregateFunction' dropdown
	When User selects 'HDD Total Size (GB)' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                 |
	| Operating System ASC  |
	| Operating System DESC |
	| <Option3>             |
	| <Option4>             |

Examples: 
	| AggregateFunc | Option3                         | Option4                          |
	| Sum           | HDD Total Size (GB) Sum ASC     | HDD Total Size (GB) Sum DESC     |
	| Minimum       | HDD Total Size (GB) Minimum ASC | HDD Total Size (GB) Minimum DESC |
	| Maximum       | HDD Total Size (GB) Maximum ASC | HDD Total Size (GB) Maximum DESC |
	| Average       | HDD Total Size (GB) Average ASC | HDD Total Size (GB) Average DESC |
	| Count         | Count ASC                       | Count DESC                       |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenCountAggregateFunctionIsSelected
	When Dashboard with 'Dashboard_15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	When User enters 'Widget Name' as Widget Title
	When User selects 'All Devices' option from 'List' autocomplete
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
	When Dashboard with 'Dashboard_15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	And User enters 'Widget Name' as Widget Title
	When User selects 'All Devices' option from 'List' autocomplete
	When User selects 'Operating System' in the 'SplitBy' dropdown
	When User selects 'Count distinct' in the 'AggregateFunction' dropdown
	When User selects 'Hostname' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                        |
	| Operating System ASC         |
	| Operating System DESC        |
	| Hostname Count distinct ASC  |
	| Hostname Count distinct DESC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17467 @DAS17515 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckNameAndLabelAndColorSchemeForEmptyOwnerCompliance
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	| Red                |
	| Amber              |
	| Green              |
	#| None               |
	When User create dynamic list with "ListForDAS17467" name on "Devices" page
	Then "ListForDAS17467" list is displayed to user
	When Dashboard with 'Dashboard_17467' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | SplitBy          | AggregateFunction | OrderBy              | ShowLegend |
	| Pie        | WidgetForDAS17467 | ListForDAS17467 | Owner Compliance | Count             | Owner Compliance ASC | true       |
	When User selects 'Show data labels' checkbox on the Create Widget page
	Then Widget Preview is displayed to the user
	Then Color Scheme dropdown displayed with 'Compliance' placeholder 
	Then 'Colour Scheme' dropdown is disabled
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS17467' Widget is displayed to the user
	Then Data Legends values are displayed in 'WidgetForDAS17467' widget on the Dashboard page
	| LegendsValue |
	| Empty        |
	| Ignore       |
	Then Label icon displayed gray for 'WidgetForDAS17467' widget
	Then There are no errors in the browser console
	
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
	When User create dynamic list with "ListForDAS17467_1" name on "Devices" page
	Then "ListForDAS17467_1" list is displayed to user
	When Dashboard with 'Dashboard_17467_1' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title               | List              | SplitBy         | AggregateFunction | OrderBy             | ShowLegend |
	| Pie        | WidgetForDAS17467_1 | ListForDAS17467_1 | 2004: Readiness | Count             | 2004: Readiness ASC | true       |
	When User selects 'Show data labels' checkbox on the Create Widget page
	Then Widget Preview is displayed to the user
	Then Color Scheme dropdown displayed with 'Readiness' placeholder 
	Then 'Colour Scheme' dropdown is disabled
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
	When Dashboard with 'Dashboard_17515' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | SplitBy                           | AggregateFunction | OrderBy                               | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS17515 | ListForDAS17515 | Windows7Mi: Application Readiness | Count             | Windows7Mi: Application Readiness ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	Then Color Scheme dropdown displayed with 'Readiness' placeholder
	Then 'Colour Scheme' dropdown is disabled
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	When User clicks 'Edit' menu option for 'WidgetForDAS17515' widget
	When User selects 'Application Compliance' in the 'SplitBy' dropdown
	Then 'Application Compliance ASC' content is displayed in 'Order By' dropdown
	Then Color Scheme dropdown displayed with 'Compliance' placeholder 
	Then 'Colour Scheme' dropdown is disabled
	When User clicks 'UPDATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18635 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatPreviewDisplayedForWidgetWhenReadinessSelectedAsSplitBy
	When Dashboard with 'Dashboard_18635' name created via API and opened
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
	When User create dynamic list with "ListForDAS18574" name on "Devices" page
	Then "ListForDAS18574" list is displayed to user
	When Dashboard with 'Dashboard_18574' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | SplitBy         | AggregateFunction | OrderBy             | ShowLegend |
	| Pie        | WidgetForDAS18574 | ListForDAS18574 | 2004: Readiness | Count             | 2004: Readiness ASC | true       |
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS18574' Widget is displayed to the user
	When User clicks on 'Green' category of 'WidgetForDAS18574' widget
	Then table content is present

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20366 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageDisplayedForWidgetBasedOnListWithMissingColumn
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName      |
	| 2004: Readiness |
	When User create dynamic list with "20366_List" name on "Devices" page
	When Dashboard with 'Dashboard_20366' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
		When User adds new Widget
	| WidgetType | Title             | List       | SplitBy         | AggregateFunction | AggregateBy     | OrderBy             |
	| Pie        | WidgetForDAS20366 | 20366_List | 2004: Readiness | Count distinct    | 2004: Readiness | 2004: Readiness ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS20366' Widget is displayed to the user
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "20366_List" list
	When User clicks the Columns button
	When User removes "2004: Readiness" column by Column panel
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When Dashboard with 'Dashboard for DAS20366' name is opened via API
	When User checks 'Edit mode' slide toggle
	Then User sees 'This widget refers to a column which is not in the list' text in warning message of 'WidgetForDAS20366' widget on Dashboards page
	When User clicks edit option for broken widget on Dashboards page
	Then 'This widget refers to a column which is not in the list' error message is displayed for 'Split By' dropdown
	Then 'This widget refers to a column which is not in the list' error message is displayed for 'Aggregate By' dropdown
	Then Widget Preview is not displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS19721 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCanBeCreatedWithListBasedOnCriticality
	When User clicks 'Applications' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName      |
	| 2004: Readiness |
	When User create dynamic list with "20366_List" name on "Devices" page
	When Dashboard with 'Dashboard_20366' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List       | SplitBy         | AggregateFunction | AggregateBy     | OrderBy             |
	| Pie        | WidgetForDAS20366 | 20366_List | 2004: Readiness | Count distinct    | 2004: Readiness | 2004: Readiness ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS20366' Widget is displayed to the user
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "20366_List" list
	When User clicks the Columns button
	When User removes "2004: Readiness" column by Column panel
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When Dashboard with 'Dashboard for DAS20366' name is opened via API
	When User checks 'Edit mode' slide toggle
	Then User sees 'This widget refers to a column which is not in the list' text in warning message of 'WidgetForDAS20366' widget on Dashboards page
	When User clicks edit option for broken widget on Dashboards page
	Then 'This widget refers to a column which is not in the list' error message is displayed for 'Split By' dropdown
	Then 'This widget refers to a column which is not in the list' error message is displayed for 'Aggregate By' dropdown
	Then Widget Preview is not displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19721 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatWidgetCreationBasedOnListWithCriticality
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Windows7Mi: Criticality" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Core           |
	When User clicks Add New button on the Filter panel
	When User add "Windows7Mi: Criticality" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User creates 'DAS19721_ListDash' dynamic list
	Then "DAS19721_ListDash" list is displayed to user
	When Dashboard with 'Dashboard_19721' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List              | SplitBy                 | AggregateFunction | OrderBy                     | ShowDataLabels |
	| Pie        | WidgetForDAS19721 | DAS19721_ListDash | Windows7Mi: Criticality | Count             | Windows7Mi: Criticality ASC | true           |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS19721' Widget is displayed to the user
	When User clicks on 'Core' data label of 'WidgetForDAS19721' widget
	Then table content is present
	Then 'Core' content is displayed in the 'Windows7Mi: Criticality' column