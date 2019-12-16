﻿Feature: ItemsManagement2
	Runs Section and Widget management tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15721 @DAS15937 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoMoreSectionsCanBeAddedAfter10WidgetsCreating
	When Dashboard with 'Dashboard for DAS15721' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD SECTION' button 
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 3_Widget | All Devices | 5       | 5          |
	Then '3_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 4_Widget | All Devices | 5       | 5          |
	Then '4_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 5_Widget | All Devices | 5       | 5          |
	Then '5_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 6_Widget | All Devices | 5       | 5          |
	Then '6_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 7_Widget | All Devices | 5       | 5          |
	Then '7_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 8_Widget | All Devices | 5       | 5          |
	Then '8_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 9_Widget | All Devices | 5       | 5          |
	Then '9_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title     | List        | MaxRows | MaxColumns |
	| List       | 10_Widget | All Devices | 5       | 5          |
	Then '10_Widget' Widget is displayed to the user
	#==========================================================#
	And 'ADD WIDGET' button is disabled
	Then 'ADD WIDGET' button has tooltip with 'Maximum number of widgets has been reached for this dashboard' text
	When User clicks Ellipsis menu for '10_Widget' Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to start    |
	| Move to end      |
	| Move to position |
	| Move to section  |
	| Delete           |
	Then 'Duplicate' Ellipsis menu item is disabled on Dashboards page
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14618 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckMovingWidgetsBetweenSections
	When Dashboard with 'Dashboard_DAS14618' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    |
	| Pie        | WidgetForDAS14618 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |
	Then 'WidgetForDAS14618' Widget is displayed to the user
	When User clicks 'ADD SECTION' button 
	And User clicks Ellipsis menu for 'WidgetForDAS14618' Widget on Dashboards page
	And User clicks 'Move to section' item from Ellipsis menu on Dashboards page
	Then Move to Section pop up is displayed to the User
	When User clicks 'CANCEL' button on the Move to Section Pop up
	Then Move to Section pop up is not displayed to the User
	When User clicks Ellipsis menu for 'WidgetForDAS14618' Widget on Dashboards page
	And User clicks 'Move to section' item from Ellipsis menu on Dashboards page
	When User selects '2' section on the Move to Section pop up
	When User clicks 'MOVE' button on the Move to Section Pop up
	When User expands all sections on Dashboards page
	Then 'WidgetForDAS14618' Widget is displayed to the user
	When User clicks Ellipsis menu for 'WidgetForDAS14618' Widget on Dashboards page
	And User clicks 'Move to section' item from Ellipsis menu on Dashboards page
	When User selects '1' section on the Move to Section pop up
	When User clicks 'MOVE' button on the Move to Section Pop up
	Then 'WidgetForDAS14618' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16326 @DAS17150 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckErrorTextAndLinkOnTheWarningMessage
	When Dashboard with 'Dashboard_DAS16326' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List                                 | MaxRows | MaxColumns |
	| List       | Widget_For_DAS16326 | Mailbox List (Complex) - BROKEN LIST | 10      | 10         |
	Then 'Widget_For_DAS16326' Widget is displayed to the user
	Then User sees 'This widget refers to list Mailbox List (Complex) - BROKEN LIST which has errors' text in warning message of 'Widget_For_DAS16326' widget on Dashboards page
	Then 'Mailbox List (Complex) - BROKEN LIST' link is displayed in warning message on Dashboards page
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17551 @DAS17150 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckErrorTextDisplayingWhenListRefersToBrokenList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User removes custom list with "ADevicesList17551" name
	Then list with "ADevicesList17551" name is removed
	When Dashboard with 'Dashboard_DAS16326' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List                   | MaxRows | MaxColumns |
	| List       | Widget_For_DAS17551 | AApplicationsList17551 | 10      | 10         |
	Then 'Widget_For_DAS17551' Widget is displayed to the user
	Then User sees 'This widget refers to list AApplicationsList17551 which has errors' text in warning message of 'Widget_For_DAS17551' widget on Dashboards page
	Then 'AApplicationsList17551' link is displayed in warning message on Dashboards page
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DAS15877 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSettingsDisplayedForDashboard
	When Dashboard with 'Dashboard_DAS15877' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks menu for 'Dashboard_DAS15877' dashboard
	Then User sees dashboard menu with next options
	| OptionsName    |
	| Manage         |
	| Make favourite |
	| Duplicate      |
	| Set default    |
	| Delete         | 

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAnyDashboardCanBeMarkedFavorite
	When User clicks 'Dashboards' on the left-hand menu
	When User clicks 'CREATE DASHBOARD' button 
	When User creates new Dashboard with 'Dashboard_DAS12974' name
	Then Dashboard with 'Dashboard_DAS12974' title displayed in All Dashboards
	When User selects 'Manage' menu for 'Dashboard_DAS12974' dashboard
	When User changes dashboard name to 'Dashboard_DAS12974Updated'
	Then Dashboard with 'Dashboard_DAS12974Updated' title displayed in All Dashboards
	When User sets 'true' as favorite state in dashboard details for 'Dashboard_DAS12974Updated' dashboard
	Then Dashboard with name 'Dashboard_DAS12974Updated' marked as favorite
	When User sets 'false' as favorite state in dashboard details for 'Dashboard_DAS12974Updated' dashboard
	Then Dashboard with name 'Dashboard_DAS12974Updated' not marked as favorite

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAnyDashboardCanBeMarkedAsDefault
	When Dashboard with 'Dashboard_DAS12974Default' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	Then User sees correct tooltip for Show Dashboards panel
	When User clicks Show Dashboards panel icon on Dashboards page
	When User selects 'Manage' menu for 'Dashboard_DAS12974Default' dashboard
	When User clicks Default dashboard checkbox in Dashboard details
	Then Default dashboard checkbox becomes disabled in Dashboard details
	Then Default dashboard checkbox displayed checked in Dashboard details
	Then Dashboard with name 'Dashboard_DAS12974Default' marked as default

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSectionCanBeDeleted
	When Dashboard with 'Dashboard for DAS12974SECTION' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title            | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | DAS12974SECTION1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	Then 'DAS12974SECTION1' Widget is displayed to the user
	When User clicks 'ADD SECTION' button 
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title            | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | DAS12974SECTION2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	Then 'DAS12974SECTION2' Widget is displayed to the user
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks Ellipsis menu for Section having 'DAS12974SECTION1' Widget on Dashboards page
	When User clicks 'Delete' item from Ellipsis menu on Dashboards page
	When User confirms item deleting on Dashboards page
	Then User sees number of Sections increased by '-1' on Dashboards page
	Then User sees number of Widgets increased by '-1' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @DAS12974 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatErrorMessageDisplayedWhenDashboardNameExists
	When Dashboard with 'DAS12974DUPLICATED' name created via API and opened
	When User clicks 'Dashboards' on the left-hand menu
	When User clicks 'CREATE DASHBOARD' button 
	When User types '<DashboardName>' as dashboard title
	Then Warning message with "Dashboard name should be unique" is displayed
	When User types 'extra' as dashboard title

Examples:
	| DashboardName      |
	| DAS12974DUPLICATED |
	| DAS12974duplicated |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17985 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatItsNotPossibleToDeleteWidgetWhenEditModeIsOff
	When Dashboard with 'Dashboard for DAS17985' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS17985 | All Applications | Vendor  | Count             | Count ASC | 10        | true       |
	When User clicks Ellipsis menu for 'WidgetForDAS17985' Widget on Dashboards page
	When User clicks 'Delete' item from Ellipsis menu on Dashboards page
	Then User sees 'WidgetForDAS17985 will be permanently deleted' text in warning message of 'WidgetForDAS17985' widget on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18152 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDuplicateOptionWorksAfterMovingWidget
	When Dashboard with 'Dashboard for DAS18152' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	When User clicks Ellipsis menu for '1_Widget' Widget on Dashboards page
	And User clicks 'Move to end' item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for '1_Widget' Widget on Dashboards page
	And User clicks 'Duplicate' item from Ellipsis menu on Dashboards page
	Then User sees following Widgets in one Section on Dashboards page:
	| WidgetNames |
	| 2_Widget    |
	| 1_Widget    |
	| 1_Widget2   |

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @DAS18080
Scenario: EvergreenJnr_Dashboard_CheckThatThereIsNoPossibilityGoBackGromThePrintPreviewModeAfterClickingTheDashworksLogo
	When User clicks 'print'  button on the Dashboards page
	Then Print Preview is displayed to the User
	And User clicks on Dashworks logo
	Then Print Preview is displayed to the User