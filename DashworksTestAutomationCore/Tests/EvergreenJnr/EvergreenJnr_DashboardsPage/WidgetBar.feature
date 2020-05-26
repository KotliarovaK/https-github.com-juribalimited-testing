Feature: WidgetBar
	Runs tests for Bar Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15356 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumns
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	| Manufacturer        |
	| Compliance          |
	When User clicks on 'Manufacturer' column header
	Then data in table is sorted by 'Manufacturer' column in ascending order
	When User create dynamic list with "List15356" name on "Devices" page
	When Dashboard with 'Dashboard_15356' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS15356 | List15356 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC | 10        | true       |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15356' Widget is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnWidgetsIfTheSourceListHasNoRows
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values |
	| ZZZZ   |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'ListForDAS16167' list
	Then "ListForDAS16167" list is displayed to user
	When Dashboard with 'Dashboard_16167' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType   | Title             | List            | SplitBy          | AggregateFunction | OrderBy              |
	| <WidgetType> | WidgetForDAS16167 | ListForDAS16167 | Operating System | Count             | Operating System ASC |
	Then Widget Preview is displayed to the user
	Then 'This list does not contain any rows' message is displayed in Preview
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16167' Widget is displayed to the user
	Then 'This list does not contain any rows' message is displayed in 'WidgetForDAS16167' widget

Examples: 
	| WidgetType |
	| Pie        |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |
	| Table      |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18100 @DAS19348 @Cleanup
Scenario Outline: EvergreenJnr_CheckThatWidgetBasedOnListHavingNotEmptyOperatorCanBeCreated
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	When User add "<Filter>" filter where type is "<Operator>" with added column and Lookup option
    | SelectedValues |
	When User create dynamic list with "<SavedList>" name on "<ListType>" page
	Then "<SavedList>" list is displayed to user
	When Dashboard with '<DashboardName>' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title        | List        | SplitBy  | AggregateFunction | OrderBy   |
	| Bar        | <WidgetName> | <SavedList> | <Filter> | Count             | <OrderBy> |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then '<WidgetName>' Widget is displayed to the user
	Then There are no errors in the browser console

 Examples:
	| ListType  | ListName      | Filter         | Operator  | SavedList         | DashboardName   | WidgetName        | OrderBy            |
	| Devices   | All Devices   | Import Type    | Not empty | ListForDAS18100_2 | Dashboard_18100 | WidgetForDAS18100 | Import Type ASC    |
	| Mailboxes | All Mailboxes | Recipient Type | Not empty | ListForDAS19348_2 | Dashboard_19348 | WidgetForDAS19348 | Recipient Type ASC |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17360 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckWidgetCanBeCreatedWithDifferentDisplayedType
	When Dashboard with 'Dashboard_17360' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType   | Title             | List        | SplitBy  | CategoriseBy | DisplayType  | AggregateFunction | OrderBy      |
	| <WidgetType> | WidgetForDAS17360 | All Devices | Hostname | Device Type  | <DisplyType> | Count             | Hostname ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	Then 'WidgetForDAS17360' Widget is displayed to the user

Examples:
	| WidgetType | DisplyType |
	| Bar        | Stacked    |
	| Column     | Stacked    |
	| Bar        | Clustered  |
	| Column     | Clustered  |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17360 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckWidgetCanBeCreatedWithoutCategorizeBySet
	When Dashboard with 'Dashboard_17360_1' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType   | Title                | List        | SplitBy  | AggregateFunction | OrderBy      |
	| <WidgetType> | WidgetForDAS17360Cat | All Devices | Hostname | Count             | Hostname ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	Then 'WidgetForDAS17360Cat' Widget is displayed to the user

Examples:
	| WidgetType |
	| Bar        |
	| Column     |