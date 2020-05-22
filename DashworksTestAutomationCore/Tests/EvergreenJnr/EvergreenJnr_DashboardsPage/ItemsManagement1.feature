Feature: ItemsManagement1
	Runs Section and Widget management tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15200 @DAS17754 @DAS16563
Scenario: EvergreenJnr_DashboardsPage_CheckPrintStylesOnTheDashboardsPage
	Then User sees 'Print' tooltip for 'Print' on the Dashboard
	Then User sees 'Refresh' tooltip for 'Refresh' on the Dashboard
	When User clicks 'print' button on the Dashboards page
	Then Print Preview is displayed to the User
	Then There is no breadcrumbs displayed on Dashboard page
	When User selects 'A4' option in the 'Paper Size' dropdown for Print Preview Settings
	Then Print Preview is displayed in 'A4' format and 'Portrait' layout view
	When User selects 'Letter' option in the 'Paper Size' dropdown for Print Preview Settings
	Then Print Preview is displayed in 'Letter' format and 'Portrait' layout view
	When User selects 'Landscape' option in the 'Paper Layout' dropdown for Print Preview Settings
	When User selects 'A4' option in the 'Paper Size' dropdown for Print Preview Settings
	Then Print Preview is displayed in 'A4' format and 'Landscape' layout view
	When User clicks Cancel button on the Print Preview Settings pop-up

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14358 @DAS12989 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicatedIntoSameSection
	When Dashboard with 'Dashboard_12989' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD SECTION' button 
	When User clicks ADD WIDGET button for '1' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | Section1_WidgetForDAS12989_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Bar        | Section2_WidgetForDAS12989_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | Section2_WidgetForDAS12989_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks 'Duplicate' menu option for 'Section1_WidgetForDAS12989_1' widget
	Then User sees following Widgets in one Section on Dashboards page:
	| WidgetNames                   |
	| Section1_WidgetForDAS12989_1  |
	| Section1_WidgetForDAS12989_12 |
	Then User sees following Widgets in one Section on Dashboards page:
	| WidgetNames                  |
	| Section2_WidgetForDAS12989_1 |
	| Section2_WidgetForDAS12989_2 |
	Then User sees number of Widgets increased by '1' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14586 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists
	When Dashboard with '<DashboardName>' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title   | List   | SplitBy   | AggregateBy   | AggregateFunction  | OrderBy   | MaxValues | ShowLegend   |
	| <Type>     | <Title> | <List> | <SplitBy> | <AggregateBy> | <AggregateFunctio> | <OrderBy> | 10        | <ShowLegend> |
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks 'Duplicate' menu option for '<Title>' widget
	Then User sees number of Sections increased by '0' on Dashboards page
	Then User sees number of Widgets increased by '1' on Dashboards page
	Then '<TitleCloned>' Widget is displayed to the user
	
Examples:
	| DashboardName                | Type   | Title                                 | List             | SplitBy       | AggregateBy  | AggregateFunctio | OrderBy                        | TitleCloned                            | ShowLegend |
	| Dashboard_14586_devices      | Line   | All Devices Widget For DAS_14586      | All Devices      | Hostname      |              | Count            | Count DESC                     | All Devices Widget For DAS_145862      | false      |
	| Dashboard_14586_users        | Pie    | All Users Widget For DAS_14586        | All Users        | Username      | Display Name | Count distinct   | Username ASC                   | All Users Widget For DAS_145862        | false      |
	| Dashboard_14586_applications | Bar    | All Applications Widget For DAS_14586 | All Applications | Application   |              | Count            | Count DESC                     | All Applications Widget For DAS_145862 | true       |
	| Dashboard_14586_mailboxes    | Column | All Mailboxes Widget For DAS_14586    | All Mailboxes    | Email Address | Mail Server  | Count distinct   | Mail Server Count distinct ASC | All Mailboxes Widget For DAS_145862    | true       |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS12978 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheEditMode
	When Dashboard with 'Dashboard_12978' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS12978 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User clicks refresh button in the browser
	When User clicks Show Dashboards panel icon on Dashboards page
	When User navigates to the "Dashboard_12978" list
	When User checks 'Edit mode' slide toggle
	Then User sees Edit mode trigger is in the On position on Dashboards page
	Then User sees Edit mode trigger has blue style on Dashboards page
	Then 'CREATE DASHBOARD' button is not disabled
	Then 'ADD SECTION' button is not disabled
	Then 'ADD WIDGET' button is not disabled
	Then User sees Collapse/Expand icon enabled for Section having 'WidgetForDAS12978' Widget on Dashboards page
	Then User sees Ellipsis icon enabled for Section having 'WidgetForDAS12978' Widget on Dashboards page
	Then User sees Ellipsis icon enabled for 'WidgetForDAS12978' Widget on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS12978_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
    When User clicks 'Edit' menu option for 'WidgetForDAS12978_2' widget
	When User updates Widget with following info:
	| WidgetType | Title                      | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy     | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS12978_2_Edited | All Applications | Version | Application | Count distinct    | Version ASC | 10        | true       |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles               |
	| WidgetForDAS12978          |
	| WidgetForDAS12978_2_Edited |
	When User clicks 'Delete' menu option for 'WidgetForDAS12978' widget
	When User confirms item deleting on Dashboards page
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles               |
	| WidgetForDAS12978_2_Edited |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS12977 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheReadOnlyMode
	When Dashboard with 'Dashboard_12977' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS12977 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User clicks refresh button in the browser
	Then Dashboards sub menu is hidden on Dashboards page
	When User clicks Show Dashboards panel icon on Dashboards page
	Then User sees Dashboards sub menu on Dashboards page
	When User navigates to the "Dashboard_12977" list
	Then 'CREATE DASHBOARD' button is displayed 
	Then 'ADD SECTION' button is not displayed
	Then 'ADD WIDGET' button is not displayed
	Then User sees Edit mode trigger is in the Off position on Dashboards page
	Then User sees Edit mode trigger has grey style on Dashboards page
	Then User sees Ellipsis icon disabled for Section having 'WidgetForDAS12977' Widget on Dashboards page
	Then User sees Ellipsis icon disabled for 'WidgetForDAS12977' Widget on Dashboards page
	When User clicks the Dashboard Details button

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14583 @DAS14358 @DAS14618 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetStaysOnTopPositionAfterEditing
	When Dashboard with 'Dashboard_14583' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS14583_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_3 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | false      |
	When User clicks 'ADD SECTION' button 
	When User clicks menu for section with 'WidgetForDAS14583_3' widget
	Then User sees following items for expanded menu:
	| items            |
	| Edit             |
	| Hide             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	When User clicks Body container
	When User clicks 'Move to start' menu option for 'WidgetForDAS14583_3' widget
	When User clicks 'Edit' menu option for 'WidgetForDAS14583_3' widget
	When User updates Widget with following info:
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_3 | All Applications | Vendor  | Vendor      | Count distinct    | Vendor ASC | 10        | false      |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles        |
	| WidgetForDAS14583_3 |
	| WidgetForDAS14583_1 |
	| WidgetForDAS14583_2 |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14855 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageDisplayingWhenDeletingWidget
	When Dashboard with 'Dashboard_14855' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14855 | All Applications | Vendor  | Count             | Count ASC | 10        | true       |
	When User clicks 'Delete' menu option for 'WidgetForDAS14855' widget
	Then User sees 'WidgetForDAS14855 will be permanently deleted' text in warning message of 'WidgetForDAS14855' widget on Dashboards page
	Then User sees Widget square colored in amber
	When User clicks Cancel button in Delete Widget warning on Dashboards page
	When User clicks 'Delete' menu option for 'WidgetForDAS14855' widget
	When User confirms item deleting on Dashboards page
	Then Widget with the name 'WidgetForDAS14855' is missing

@Evergreen @EvergreenJnr_DashboardsPage @DAS14610
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageAppearsWhenOpenningNotExistingDashboard
	When User clicks Show Dashboards panel icon on Dashboards page
	When User tries to open same page with non existing item id
	Then User sees 'This dashboard does not exist or you do not have access to it' text in warning message on Dashboards submenu pane
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DAS20754 @Cleanup
Scenario: EvergreenJnr_Dashboard_CheckThatCorrectUrlDisplayedForJustCreatedDashboard
	When User clicks 'Dashboards' on the left-hand menu
	When User clicks 'CREATE DASHBOARD' button
	When User creates new Dashboard with '20754_Id_Test_1' name
	Then URL contains '20754_Id_Test_1' dashboard Id
	When User clicks 'Dashboards' on the left-hand menu
	When User clicks 'CREATE DASHBOARD' button
	When User creates new Dashboard with '20754_Id_Test_2' name
	Then URL contains '20754_Id_Test_2' dashboard Id