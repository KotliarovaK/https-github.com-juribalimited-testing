Feature: ItemsManagement2
	Runs Section and Widget management tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17551 @DAS17150 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckErrorTextDisplayingWhenListRefersToBrokenList
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User create dynamic list with "ADevicesList17551" name on "Devices" page
	Then "ADevicesList17551" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" with following Lookup Value and Association:
	| SelectedValues    | Association        |
	| ADevicesList17551 | Entitled to device |
	When User waits for '3' seconds
	When User create dynamic list with "AApplicationsList17551" name on "Applications" page
	Then "AApplicationsList17551" list is displayed to user
	When Dashboard with 'Dashboard_16326' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List                   | MaxRows | MaxColumns |
	| List       | Widget_For_DAS17551 | AApplicationsList17551 | 10      | 10         |
	Then 'Widget_For_DAS17551' Widget is displayed to the user
	When User clicks 'Devices' on the left-hand menu
	When User clicks 'Delete' option in cogmenu for 'ADevicesList17551' list
	When User confirms list removing
	Then list with "ADevicesList17551" name is removed
	When Dashboard with 'Dashboard_16326' name is opened via API
	When User checks 'Edit mode' slide toggle
	Then User sees 'This widget refers to list AApplicationsList17551 which has errors' text in warning message of 'Widget_For_DAS17551' widget on Dashboards page
	Then 'AApplicationsList17551' link is displayed in warning message on Dashboards page
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAnyDashboardCanBeMarkedFavorite
	When Dashboard with 'Dashboard_12974Favorite' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks the Dashboard Details button
	When User changes dashboard name to 'Dashboard_12974Updated'
	Then 'Dashboard_12974Updated' list is displayed in the Lists panel
	When User selects state 'true' for 'Favourite Dashboard' checkbox
	Then Dashboard with name 'Dashboard_12974Updated' marked as favorite
	When User selects state 'false' for 'Favourite Dashboard' checkbox
	Then Dashboard with name 'Dashboard_12974Updated' not marked as favorite

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAnyDashboardCanBeMarkedAsDefault
	When Dashboard with 'Dashboard_12974Default' name created via API and opened
	When User checks 'Edit mode' slide toggle
	Then User sees correct tooltip for Show Dashboards panel
	When User clicks the Dashboard Details button
	When User selects state 'true' for 'Default Dashboard' checkbox
	Then 'Default Dashboard' checkbox is checked
	Then 'Default Dashboard' checkbox is disabled
	Then Dashboard with name 'Dashboard_12974Default' marked as default

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @DAS20395 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatErrorMessageDisplayedWhenDashboardNameExists
	When Dashboard with 'DAS12974DUPLICATED' name created via API and opened
	When User clicks 'Dashboards' on the left-hand menu
	When User clicks 'CREATE DASHBOARD' button 
	When User enters '<DashboardName>' text to 'Dashboard Name' textbox
	Then Warning message with "Dashboard name should be unique" is displayed
	When User enters '<DashboardName>extra' text to 'Dashboard Name' textbox
	Then Warning message with 'Dashboard name should be unique' text is not displayed
	When User enters '<DashboardName>' text to 'Dashboard Name' textbox
	Then Warning message with "Dashboard name should be unique" is displayed
	When User clicks 'CANCEL' button
	Then Warning message with 'Dashboard name should be unique' text is not displayed

Examples:
	| DashboardName      |
	| DAS12974DUPLICATED |
	| DAS12974duplicated |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17985 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatItsNotPossibleToDeleteWidgetWhenEditModeIsOff
	When Dashboard with 'Dashboard_17985' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List        | MaxRows | MaxColumns |
	| List       | WidgetForDAS17985 | All Devices | 5       | 5          |
	When User clicks 'Delete' menu option for 'WidgetForDAS17985' widget
	Then User sees 'WidgetForDAS17985 will be permanently deleted' text in warning message of 'WidgetForDAS17985' widget on Dashboards page
	When User unchecks 'Edit mode' slide toggle
	Then 'WidgetForDAS17985' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18152 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDuplicateOptionWorksAfterMovingWidget
	When Dashboard with 'Dashboard_18152' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	When User clicks 'Move to end' menu option for '1_Widget' widget
	When User clicks 'Duplicate' menu option for '1_Widget' widget
	Then User sees following Widgets in one Section on Dashboards page:
	| WidgetNames |
	| 2_Widget    |
	| 1_Widget    |
	| 1_Widget2   |

@Evergreen @EvergreenJnr_DashboardsPage	@DAS18483 @Cleanup
Scenario: EvergreenJnr_Dashboard_CheckThatDashboardsCanBeFoundUsingAnyCapsOrSmallLetters
	When Dashboard with 'NEW dashboard' name created via API and opened
	When Dashboard with 'DashboardTest' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User enters "new" text in Search field at List Panel
	Then 'NEW dashboard' list is displayed in the Lists panel
	When User enters "New" text in Search field at List Panel
	Then 'NEW dashboard' list is displayed in the Lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DAS15896
Scenario: EvergreenJnr_Dashboard_CheckThatNumberOfRequestsDontExceedAllowedCount
	Then Number of requests to '/dashboard' is not greater than '11'

@Evergreen @EvergreenJnr_DashboardsPage @DAS20070 @Cleanup
Scenario Outline: EvergreenJnr_Dashboard_CheckThatUpdateButtonIsDisplayedActiveAfterChangingWidgetType
	When Dashboard with '<DashboardName>' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType   | Title        | List        | SplitBy  | AggregateFunction | OrderBy      |
	| <WidgetType> | <WidgetName> | All Devices | Hostname | Count             | Hostname ASC |
	Then '<WidgetName>' Widget is displayed to the user
	When User clicks 'Edit' menu option for '<WidgetName>' widget
	Then 'UPDATE' button is disabled
	When User selects '<UpdatedType>' in the 'Widget Type' dropdown
	Then 'UPDATE' button is not disabled

Examples:
	| DashboardName     | WidgetType | WidgetName | UpdatedType |
	| Dashboard_20070_1 | Column     | DAS20070_1 | Pie         |
	| Dashboard_20070_2 | Pie        | DAS20070_2 | Column      |

@Evergreen @EvergreenJnr_DashboardsPage @DAS20070 @Cleanup
Scenario: EvergreenJnr_Dashboard_CheckThatUpdateButtonIsDisplayedActiveAfterChangingWidgetTypeIfAllFieldsAreFilled
	When Dashboard with 'Dashboard_20070_3' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title      | List        | SplitBy  | CategoriseBy | DisplayType | AggregateFunction | OrderBy      |
	| Column     | DAS20070_3 | All Devices | Hostname | Device Type  | Clustered   | Count             | Hostname ASC |
	Then 'DAS20070_3' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'DAS20070_3' widget
	Then 'UPDATE' button is disabled
	When User selects 'Stacked' in the 'Display Type' dropdown
	Then 'UPDATE' button is not disabled