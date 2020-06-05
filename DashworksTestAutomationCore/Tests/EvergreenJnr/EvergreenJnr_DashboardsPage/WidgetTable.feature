Feature: WidgetTable
	Runs tests for Table Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14920 @DAS14685 @DAS15208 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccursWhenCreatingDashboardWidgetThatUsesBooleanField
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName           |
	| Secure Boot Enabled  |
	| Windows7Mi: In Scope |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates '14920_List' list
	Then "14920_List" list is displayed to user
	When Dashboard with 'Dashboard for DAS14920' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title       | List       | SplitBy             | AggregateFunction | OrderBy   | MaxValues |
	| Table      | DAS-14920_1 | 14920_List | Secure Boot Enabled | Count             | Count ASC | 10        |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	Then Table widget displayed inside preview pane correctly
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	Then 'DAS-14920_1' Widget is displayed to the user
	Then '2,189' count is displayed for 'False' column in 'DAS-14920_1' table Widget
	Then '2,192' count is displayed for 'True' column in 'DAS-14920_1' table Widget
	Then '12,898' count is displayed for 'Unknown' column in 'DAS-14920_1' table Widget
	#Second Widget creation
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title       | List       | SplitBy              | AggregateFunction | OrderBy   | MaxValues |
	| Table      | DAS-14920_2 | 14920_List | Windows7Mi: In Scope | Count             | Count ASC | 10        |
	Then There are no errors in the browser console
	Then 'DAS-14920_2' Widget is displayed to the user
	Then '12,120' count is displayed for 'False' column in 'DAS-14920_2' table Widget
	Then '5,159' count is displayed for 'True' column in 'DAS-14920_2' table Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16073 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetIsDisplayedCorrectly
	When Dashboard with 'Dashboard_16073' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS16073 | All Devices | Hostname | Count             | Count DESC | Vertical         | 10        |
	Then There are no errors in the browser console
	Then 'WidgetForDAS16073' Widget is displayed to the user
	Then link is not displayed for the 'CAS' value in the Widget
	Then link is not displayed for the 'WIN-43TMG2KMRBI' value in the Widget
	Then link is not displayed for the 'WIN81PRO' value in the Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetValuesLeadsToApplicationsListFilteredPage
	When Dashboard with 'Dashboard for DAS16069_1' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateFunction | OrderBy    | MaxValues |
	| Table      | WidgetForDAS16069_1 | All Applications | Vendor  | Count             | Count DESC | 500       |
	Then 'WidgetForDAS16069_1' Widget is displayed to the user
	Then '918' count is displayed for 'Microsoft Corporation' column in 'WidgetForDAS16069_1' table Widget
	Then User clicks '918' value for 'Microsoft Corporation' column in 'WidgetForDAS16069_1' table widget
	Then "918" rows are displayed in the agGrid
	Then grid headers are displayed in the following order
	| ColumnName         |
	| Application        |
	| Vendor             |
	| Version            |

@Evergreen @EvergreenJnr_DashboardsPage @DAS16275 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckCapacitySlotsDisplayOrderInDashboards
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                                        |
	| Windows7Mi: Pre-Migration \ Scheduled Date (Slot) |
	When User create dynamic list with "Devices_List_DAS16275" name on "Devices" page
	When Dashboard with 'Dashboard_16275' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy                                           | AggregateFunction | OrderBy   | TableOrientation |
	| Table      | DAS16275_Widget | Devices_List_DAS16275 | Windows7Mi: Pre-Migration \ Scheduled Date (Slot) | Count             | Count ASC | Vertical         |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS16275_Widget' Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue                    |
	| Slot 2018-10-01 to 2018-12-31 |
	| Slot 2018-11-01 - 2020-12-26  |
	| Empty                         |
	When User clicks 'Edit' menu option for 'DAS16275_Widget' widget
	When User selects 'Count DESC' in the 'Order By' dropdown
	When User clicks 'UPDATE' button 
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
	When User create dynamic list with "DeviceListForDAS15826" name on "Devices" page
	When Dashboard with 'Dashboard_15826' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title           | List                  | SplitBy                      | AggregateFunction | OrderBy                          | TableOrientation |
	| Table      | DAS15826_Widget | DeviceListForDAS15826 | UserEvergr: Ring (All Users) | Count             | UserEvergr: Ring (All Users) ASC | Vertical         |
	Then 'DAS15826_Widget' Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue       |
	| Empty            |
	| Unassigned       |
	| Unassigned2      |
	| Evergreen Ring 1 |
	| Evergreen Ring 2 |
	| Evergreen Ring 3 |
	When User clicks 'Edit' menu option for 'DAS15826_Widget' widget
	When User selects 'UserEvergr: Ring (All Users) DESC' in the 'OrderBy' dropdown
	When User clicks 'UPDATE' button 
	Then 'DAS15826_Widget' Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue       |
	| Evergreen Ring 3 |
	| Evergreen Ring 2 |
	| Evergreen Ring 1 |
	| Unassigned2      |
	| Unassigned       |
	| Empty            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15362 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatOrderByFieldIsCorrectWhenFirstAndLastAggregateFunctionIsSelected
	When User clicks 'Users' on the left-hand menu
	When User add following columns using URL to the "Users" page:
	| ColumnName      |
	| Last Logon Date |
	When User create dynamic list with "LastLogout" name on "Users" page
	When Dashboard with 'Dashboard_15362' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Table' in the 'WidgetType' dropdown
	When User enters 'Widget Name' as Widget Title
	When User selects 'LastLogout' option from 'List' autocomplete
	When User selects 'Domain' in the 'SplitBy' dropdown
	When User selects '<AggregateFunc>' in the 'AggregateFunction' dropdown
	When User selects 'Last Logon Date' in the 'AggregateBy' dropdown
	Then User sees following options for Order By selector on Create Widget page:
	| items                                |
	| Domain ASC                           |
	| Domain DESC                          |
	| Last Logon Date <AggregateFunc> ASC  |
	| Last Logon Date <AggregateFunc> DESC |

Examples: 
	| AggregateFunc |
	| First         |
	| Last          |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17599 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckClickthoughNumbersBasedArchivedItemsRedirectsToFilteredListWithEnabledArchivedItems
	When User clicks 'Devices' on the left-hand menu
	When User sets includes archived devices in 'true'
	When User create dynamic list with "List17599" name on "Devices" page
	When Dashboard with 'Dashboard_17599' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List      | SplitBy  | AggregateFunction | OrderBy      |
	| Table      | WidgetForDAS17599 | List17599 | Hostname | Count             | Hostname ASC |
	Then 'WidgetForDAS17599' Widget is displayed to the user
	Then '82' count is displayed for 'Empty' column in 'WidgetForDAS17599' table Widget
	Then User clicks '82' value for 'Empty' column in 'WidgetForDAS17599' table widget
	Then "82" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18145 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoEndlessSpinnerInPreviewIfCreateWidgetUsingSeverityAggregateFunction
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Compliance |
	When User create dynamic list with "ListFor18145" name on "Devices" page
	When Dashboard with 'Dashboard_18145' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title     | List         | SplitBy          | AggregateBy | AggregateFunction | OrderBy              |
	| Table      | DAS-18145 | ListFor18145 | Operating System | Compliance  | Severity          | Operating System ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18091 @DAS18090 @DAS16516 @DAS20653 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckTheEmptyItemIsNotDisplayedOnTheDashboardPageForTheListWithoutArchivedItem
	When Dashboard with 'Dashboard_18091' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List         | SplitBy          | AggregateFunction | AggregateBy                            | OrderBy              |
	| Table      | WidgetForDAS18091 | 2004 Rollout | Operating System | Severity          | 2004: Pre-Migration \ Ready to Migrate | Operating System ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS18091' Widget is displayed to the user
	Then There is no 'Empty' column for 'WidgetForDAS18091' widget
	#DAS18090 
	Then User clicks 'NOT READY' value for 'Windows 10' column in 'WidgetForDAS18091' table widget
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Operating System is Windows 10" is displayed in added filter info
	Then "Any Device in list 2004 Rollout" is displayed in added filter info
	Then "2004: Pre-Migration \ Ready to Migrate is Not Ready" is displayed in added filter info

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNewSeverityOptionDisplayedForWidget
	When Dashboard with 'Dashboard_15852' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title     | List         | SplitBy                                | AggregateFunction | AggregateBy                            |
	| Table      | DAS-15852 | 2004 Rollout | 2004: Pre-Migration \ Ready to Migrate | Severity          | 2004: Pre-Migration \ Ready to Migrate |
	Then User sees following options for Order By selector on Create Widget page:
	| items                                                |
	| 2004: Pre-Migration \ Ready to Migrate Severity ASC  |
	| 2004: Pre-Migration \ Ready to Migrate Severity DESC |
	| 2004: Pre-Migration \ Ready to Migrate ASC           |
	| 2004: Pre-Migration \ Ready to Migrate DESC          |
	When User selects '2004: Pre-Migration \ Ready to Migrate Severity ASC' in the 'OrderBy' dropdown
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS-15852' Widget is displayed to the user
	Then Headers of 'DAS-15852' table widget with 'Horizontal' orientation are placed in the next order:
	| headers   |
	| Empty     |
	| Not Ready |
	| On Target |
	| Ready     |
	| Unknown   |
	When User clicks 'Edit' menu option for 'DAS-15852' widget
	When User selects '2004: Pre-Migration \ Ready to Migrate DESC' in the 'OrderBy' dropdown
	Then Widget Preview is displayed to the user
	When User clicks 'UPDATE' button
	Then 'DAS-15852' Widget is displayed to the user
	Then Headers of 'DAS-15852' table widget with 'Horizontal' orientation are placed in the next order:
	| headers   |
	| Ready     |
	| On Target |
	| Not Ready |
	| Unknown   |
	| Empty     |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatReadinessValuesAreShownWithTheCorrectColours
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	When User create dynamic list with "Devices_List_DAS15852" name on "Devices" page
	Then "Devices_List_DAS15852" list is displayed to user
	When Dashboard with 'Dashboard_15852' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy     | AggregateFunction | AggregateBy     | OrderBy             |
	| Table      | DAS16275_Widget | Devices_List_DAS15852 | Device Type | Severity          | 2004: Readiness | 2004: Readiness ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS16275_Widget' Widget is displayed to the user
	Then 'Green' color displayed for 'GREEN' value in table 'DAS16275_Widget' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatComplianceValuesAreShownWithTheCorrectColours
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'Devices_List_DAS15852' list
	Then "Devices_List_DAS15852" list is displayed to user
	When Dashboard with 'Dashboard_15852' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy     | AggregateFunction | AggregateBy      | OrderBy              |
	| Table      | DAS16275_Widget | Devices_List_DAS15852 | Device Type | Severity          | Owner Compliance | Owner Compliance ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button
	Then 'DAS16275_Widget' Widget is displayed to the user
	Then 'Green' color displayed for 'GREEN' value in table 'DAS16275_Widget' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20689 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatEmptyComplianceCorrectlyDisplayedOnPreview
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Owner Compliance |
	When User create dynamic list with "Devices_List_DAS20689" name on "Devices" page
	Then "Devices_List_DAS20689" list is displayed to user
	When Dashboard with 'Dashboard_15852' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy          | AggregateFunction | AggregateBy      | OrderBy              |
	| Table      | DAS20689_Widget | Devices_List_DAS20689 | Owner Compliance | Severity          | Owner Compliance | Owner Compliance ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button
	Then 'DAS20689_Widget' Widget is displayed to the user
	Then 'Empty' value displayed without color in table 'DAS20689_Widget' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15852 @DAS15582 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAggregateFuncAreNotAvailableForColumnsThatDoNotHaveComplianceOrReadiness
	When Dashboard with 'Dashboard_15852' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List        | SplitBy     | AggregateFunction |
	| Table      | DAS16275_Widget | All Devices | Device Type | Severity          |
	Then 'There are no fields available for this aggregate function' error message is displayed for 'Aggregate By' dropdown
	When User adds new Widget
	| WidgetType | Title           | List        | Type      | AggregateFunction |
	| Card       | DAS16275_Widget | All Devices | Aggregate | Severity          |
	Then 'There are no fields available for this aggregate function' error message is displayed for 'Aggregate By' dropdown
	When User adds new Widget
	| WidgetType | Title           | List        | SplitBy          | AggregateFunction |
	| Table      | DAS15582_Widget | All Devices | Operating System | Sum               |
	Then 'There are no fields available for this aggregate function' error message is displayed for 'Aggregate By' dropdown

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18324 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorsOccurWhenCreatingEditingTableWidgetThatReturnsZeroResults
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "App Count (Entitled)" filter where type is "Equals" with added column and following value:
    | Values |
    | 0      |
	When User Add And "App Count (Used)" filter where type is "Less than" with added column and following value:
    | Values |
    | 1      |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'AListForDAS18324' list
	Then "AListForDAS18324" list is displayed to user
	When Dashboard with 'Dashboard_18324' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List             | SplitBy          | AggregateFunction | OrderBy              |
	| Table      | WidgetForDAS18324 | AListForDAS18324 | App Count (Used) | Count             | App Count (Used) ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	Then 'WidgetForDAS18324' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18232 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatComplianceLayoutCorrectlyDisplayedInTableWidget
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	When User creates 'AppCompliance18232' dynamic list
	When User waits for '3' seconds
	Then "AppCompliance18232" list is displayed to user
	When Dashboard with 'Dashboard_18232' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List               | SplitBy    | AggregateFunction | AggregateBy | OrderBy        | MaxValues |
	| Table      | WidgetForDAS18232 | AppCompliance18232 | Compliance | Severity          | Compliance  | Compliance ASC | 1         |
	Then Icon and Text is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	When User clicks 'CREATE' button
	Then 'WidgetForDAS18232' Widget is displayed to the user
	Then Icon and Text is displayed for Card widget
	Then 'Red' color is displayed for Card Widget
	When User clicks 'Edit' menu option for 'WidgetForDAS18232' widget
	When User selects 'Text Only' in the 'Layout' dropdown
	Then Text Only is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS18232' Widget is displayed to the user
	Then Text Only is displayed for Card widget
	Then 'Red' color is displayed for Card Widget
	When User clicks 'Edit' menu option for 'WidgetForDAS18232' widget
	When User selects 'Icon Only' in the 'Layout' dropdown
	Then Icon Only is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS18232' Widget is displayed to the user
	Then Icon Only is displayed for Card widget
	Then 'Red' color is displayed for Card Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS19369 @DAS14400 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOnlyOnboardedObjectsAreDisplayedInTableWidgetBasedOnSeverityAfterSelectingProjectStageTaskReadinessTask
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                             |
	| 2004: Pre-Migration \ Ready to Migrate |
	When User create dynamic list with "19369_List" name on "Devices" page
	When Dashboard with 'Dashboard_19369' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title     | List       | SplitBy     | AggregateFunction | AggregateBy                            | OrderBy         | MaxValues |
	| Table      | DAS-19369 | 19369_List | Device Type | Severity          | 2004: Pre-Migration \ Ready to Migrate | Device Type ASC | 30        |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS-19369' Widget is displayed to the user
	Then Headers of 'DAS-19369' table widget with 'Horizontal' orientation are placed in the next order:
	| headers     |
	| Data Centre |
	| Desktop     |
	| Laptop      |
	| Mobile      |
	| Other       |
	| Virtual     |
	When User clicks 'Edit' menu option for 'DAS-19369' widget
	When User selects 'Vertical' in the 'TableOrientation' dropdown
	When User clicks 'UPDATE' button
	Then 'DAS-19369' Widget is displayed to the user
	Then Headers of 'DAS-19369' table widget with 'Vertical' orientation are placed in the next order:
	| headers     |
	| Data Centre |
	| Desktop     |
	| Laptop      |
	| Mobile      |
	| Other       |
	| Virtual     | 

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS19383 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetCanBeCreatedForListUsingComplienceFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	When User waits for '3' seconds
	When User create dynamic list with "AppCompliance19383" name on "Devices" page
	Then "AppCompliance19383" list is displayed to user
	When Dashboard with 'Dashboard_19383' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List               | SplitBy                | AggregateFunction | AggregateBy            | OrderBy                    | MaxValues |
	| Table      | WidgetForDAS19383 | AppCompliance19383 | Application Compliance | Severity          | Application Compliance | Application Compliance ASC | 1         |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	Then 'WidgetForDAS19383' Widget is displayed to the user

 @Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18777 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetShowsCorrectResultsIfTaskValueAreNotUnique
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Not Applicable |
	| Not Started    |
	When User waits for '3' seconds
	When User create dynamic list with "List for DAS18777" name on "Devices" page
	When Dashboard with 'Dashboard_18777' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title     | List              | SplitBy                                                                                        | AggregateFunction | AggregateBy                                                                                    | OrderBy                                                                                                     |
	| Table      | DAS-18777 | List for DAS18777 | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation | Severity          | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation Severity ASC |
	When User clicks 'CREATE' button 
	Then 'DAS-18777' Widget is displayed to the user
	Then following content is displayed in the 'Not Started' column for Widget
	| Values      |
	| NOT STARTED |
	Then following content is displayed in the 'Not Applicable' column for Widget
	| Values         |
	| NOT APPLICABLE |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS19736 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetBasedOnTaskValueSeverityHasCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                                                                                     |
	| Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation |
	When User create dynamic list with "19736_List" name on "Devices" page
	When Dashboard with 'Dashboard_19736' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title      | List       | SplitBy                                                                                        | AggregateFunction | AggregateBy                                                                                    | OrderBy                                                                                                     | MaxValues |
	| Table      | 19736_List | 19736_List | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation | Severity          | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Radiobutton Task for Workstation Severity ASC | 10        |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then '19736_List' Widget is displayed to the user
	Then Headers of '19736_List' table widget with 'Horizontal' orientation are placed in the next order:
	| headers        |
	| Empty          |
	| Started        |
	| Complete       |
	| Not Applicable |
	| Not Started    |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18631 @DAS18327 @DAS19007 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorDisplayedWhenClickingThroughWidgetBasedOnListWithTwoFiltersSepartedByOr
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User add "2004: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	| Green              |
	| Amber              |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'Devices_List_DAS18631' list
	Then "Devices_List_DAS18631" list is displayed to user
	When Dashboard with 'Dashboard_18631' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy        | AggregateFunction | AggregateBy     | OrderBy            |
	| Table      | DAS18631_Widget | Devices_List_DAS18631 | 2004: In Scope | Severity          | 2004: Readiness | 2004: In Scope ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS18631_Widget' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	Then User clicks 'BLOCKED' value for 'True' column in 'DAS18631_Widget' table widget
	Then There are no errors in the browser console
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Filter Expression icon in Filter Panel
	Then "(2004: In Scope = true AND 2004: In Scope = true) OR (2004: Readiness = Empty, Amber or Green AND 2004: In Scope = true)" text is displayed in filter container

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS21299 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoClicksThroughWorksForTableEmptyValue
	When Dashboard with 'Dashboard_21299' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List         | SplitBy         | AggregateFunction | AggregateBy     | OrderBy                      |
	| Table      | DAS21299_Widget | 2004 Rollout | 2004: Readiness | Severity          | 2004: Readiness | 2004: Readiness Severity ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS21299_Widget' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	Then User clicks 'Empty' value for 'Empty' column in 'DAS21299_Widget' table widget
	Then There are no errors in the browser console
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "2004: Readiness is Empty" is displayed in added filter info
	Then "Any Device in list 2004 Rollout" is displayed in added filter info
	When User clicks Filter Expression icon in Filter Panel
	Then "(2004: Readiness = Empty AND Device (Saved List) IN 2004 Rollout AND 2004: Readiness = Empty)" text is displayed in filter container

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20227 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatProjectTaskMeColumnValueIsDisplayedOnWidgetTable
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Windows7Mi: Pre-Migration \ VDI Only Task (Owner)" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Me                 |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'Devices_List_DAS20227' list
	Then "Devices_List_DAS20227" list is displayed to user
	When Dashboard with 'Dashboard_20227' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy                                           | AggregateFunction | OrderBy                                               |
	| Table      | DAS20227_Widget | Devices_List_DAS20227 | Windows7Mi: Pre-Migration \ VDI Only Task (Owner) | Count             | Windows7Mi: Pre-Migration \ VDI Only Task (Owner) ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button
	Then 'DAS20227_Widget' Widget is displayed to the user
	Then Headers of 'DAS20227_Widget' table widget with 'Horizontal' orientation are placed in the next order:
	| headers       |
	| Empty         |
	| Administrator |
	| Joanne Gall   |
	| Unassigned    |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20027 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardAreOpenedAfterDragAndDropWidgetsRepeatedly
	When Dashboard with 'Dashboard_20027' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetOneDAS20027 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	Then 'WidgetOneDAS20027' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetTwoDAS20027 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	Then 'WidgetTwoDAS20027' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title               | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetThreeDAS20027 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	Then 'WidgetThreeDAS20027' Widget is displayed to the user
	When User move 'WidgetOneDAS20027' widget to 'WidgetThreeDAS20027' widget
	When User move 'WidgetThreeDAS20027' widget to 'WidgetOneDAS20027' widget
	When User move 'WidgetOneDAS20027' widget to 'WidgetThreeDAS20027' widget
	When User move 'WidgetTwoDAS20027' widget to 'WidgetOneDAS20027' widget
	When User move 'WidgetThreeDAS20027' widget to 'WidgetTwoDAS20027' widget
	When User move 'WidgetOneDAS20027' widget to 'WidgetThreeDAS20027' widget
	When User move 'WidgetTwoDAS20027' widget to 'WidgetOneDAS20027' widget
	When User move 'WidgetThreeDAS20027' widget to 'WidgetTwoDAS20027' widget
	When User move 'WidgetOneDAS20027' widget to 'WidgetThreeDAS20027' widget
	When User move 'WidgetTwoDAS20027' widget to 'WidgetOneDAS20027' widget
	When User clicks Show Dashboards panel icon on Dashboards page
	When User opens 'Overview' dashboard
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles       |
	| Device Profile     |
	| Operating Systems  |
	| Top 10 App Vendors |
	| Domain Profile     |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20678 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetCanBeCreatedBasedOnListWithEvergreenRings
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Evergreen Ring" filter where type is "Equals" with added column and Lookup option
	| SelectedValues   |
	| Evergreen Ring 1 |
	| Evergreen Ring 2 |
	When User Add And "Compliance" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'Devices_List_DAS20678' list
	Then "Devices_List_DAS20678" list is displayed to user
	When Dashboard with 'Dashboard_20678' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy        | AggregateFunction | AggregateBy | OrderBy            |
	| Table      | DAS20678_Widget | Devices_List_DAS20678 | Evergreen Ring | Severity          | Compliance  | Evergreen Ring ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS20678_Widget' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20973 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatEvergrinRingBasedListCanBeUsedInWidget
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Evergreen Ring" filter where type is "Equals" with added column and Lookup option
	| SelectedValues   |
	| Evergreen Ring 1 |
	| Evergreen Ring 2 |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'Devices_List_DAS20973' list
	Then "Devices_List_DAS20973" list is displayed to user
	When Dashboard with 'Dashboard_20973' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title           | List                  | SplitBy        | AggregateBy    | AggregateFunction | OrderBy            |
	| Table      | DAS20973_Widget | Devices_List_DAS20973 | Evergreen Ring | Evergreen Ring | Count distinct    | Evergreen Ring ASC |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'DAS20973_Widget' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20996 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckCorrectTableWidgetCreatedBasedOnProjectRings
	When Dashboard with 'Dashboard_20996' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title         | List         | SplitBy    | AggregateFunction | AggregateBy | OrderBy        |
	| Table      | Widget_209961 | 2004 Rollout | 2004: Ring | Count distinct    | Device Key  | 2004: Ring ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'Widget_209961' Widget is displayed to the user
	Then There are no errors in the browser console