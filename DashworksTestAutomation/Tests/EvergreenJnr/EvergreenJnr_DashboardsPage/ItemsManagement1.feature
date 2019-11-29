Feature: ItemsManagement1
	Runs Section and Widget management tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15200 @DAS17754 @DAS16563
Scenario: EvergreenJnr_DashboardsPage_CheckPrintStylesOnTheDashboardsPage
	Then User sees 'Print' tooltip for 'Print' on the Dashboard
	Then User sees 'Refresh' tooltip for 'Refresh' on the Dashboard
	When User clicks 'print'  button on the Dashboards page
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

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14358 @DAS14618
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget
	When User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD SECTION' button 
	And User clicks Ellipsis menu for 'Top 10 App Vendors' Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to start    |
	| Move to end      |
	| Move to position |
	| Move to section  |
	| Delete           |

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection
	When User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD SECTION' button 
	And User clicks Ellipsis menu for Section having 'Operating System' Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Hide             |
	| 1 column         |
	| 3 column         |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14358 @DAS12989 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicatedIntoSameSection
	When Dashboard with 'Dashboard for DAS12989' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD SECTION' button 
	And User clicks ADD WIDGET button for '1' Section on Dashboards page
	And User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | Section1_WidgetForDAS12989_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User clicks ADD WIDGET button for '2' Section on Dashboards page
	And User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Bar        | Section2_WidgetForDAS12989_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User clicks ADD WIDGET button for '2' Section on Dashboards page
	And User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | Section2_WidgetForDAS12989_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for 'Section1_WidgetForDAS12989_1' Widget on Dashboards page
	And User clicks 'Duplicate' item from Ellipsis menu on Dashboards page
	Then User sees following Widgets in one Section on Dashboards page:
	| WidgetNames                   |
	| Section1_WidgetForDAS12989_1  |
	| Section1_WidgetForDAS12989_12 |
	And User sees following Widgets in one Section on Dashboards page:
	| WidgetNames                  |
	| Section2_WidgetForDAS12989_1 |
	| Section2_WidgetForDAS12989_2 |
	And User sees number of Widgets increased by '1' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14358 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated
	When Dashboard with 'Dashboard for DAS14358' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14358 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for Section having 'WidgetForDAS14358' Widget on Dashboards page
	And User clicks 'Duplicate' item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by '1' on Dashboards page
	And User sees number of Widgets increased by '1' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14586 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists
	When Dashboard with '<DashboardName>' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title   | List   | SplitBy   | AggregateBy   | AggregateFunction  | OrderBy   | MaxValues | ShowLegend   |
	| <Type>     | <Title> | <List> | <SplitBy> | <AggregateBy> | <AggregateFunctio> | <OrderBy> | 10        | <ShowLegend> |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for '<Title>' Widget on Dashboards page
	And User clicks 'Duplicate' item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by '0' on Dashboards page
	And User sees number of Widgets increased by '1' on Dashboards page
	And User sees Widget with '<TitleCloned>' name on Dashboards page
	
Examples:
	| DashboardName                       | Type   | Title                                 | List             | SplitBy       | AggregateBy  | AggregateFunctio | OrderBy                        | TitleCloned                            | ShowLegend |
	| Dashboard for DAS14586_devices      | Line   | All Devices Widget For DAS_14586      | All Devices      | Hostname      |              | Count            | Count DESC                     | All Devices Widget For DAS_145862      | false      |
	| Dashboard for DAS14586_users        | Pie    | All Users Widget For DAS_14586        | All Users        | Username      | Display Name | Count distinct   | Username ASC                   | All Users Widget For DAS_145862        | false      |
	| Dashboard for DAS14586_applications | Bar    | All Applications Widget For DAS_14586 | All Applications | Application   |              | Count            | Count DESC                     | All Applications Widget For DAS_145862 | true       |
	| Dashboard for DAS14586_mailboxes    | Column | All Mailboxes Widget For DAS_14586    | All Mailboxes    | Email Address | Mail Server  | Count distinct   | Mail Server Count distinct ASC | All Mailboxes Widget For DAS_145862    | true       |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14728 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetLegendCopiedWhenDuplicatingSection
	When Dashboard with 'Dashboard for DAS14728' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14728 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	Then User sees '1' Widgets with Legend on Dashboards page
	When User clicks Ellipsis menu for Section having 'WidgetForDAS14728' Widget on Dashboards page
	And User clicks 'Duplicate' item from Ellipsis menu on Dashboards page
	Then User sees '2' Widgets with Legend on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS12978 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheEditMode
	When Dashboard with 'Dashboard for DAS12978' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS12978 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User clicks refresh button in the browser
	And User clicks Show Dashboards panel icon on Dashboards page
	And User navigates to the "Dashboard for DAS12978" list
	And User clicks Edit mode trigger on Dashboards page
	Then User sees Edit mode trigger is in the On position on Dashboards page
	And User sees Edit mode trigger has blue style on Dashboards page
	And 'CREATE DASHBOARD' button is disabled
	And 'ADD SECTION' button is not disabled
	And 'ADD WIDGET' button is not disabled
	And User sees Collapse/Expand icon enabled for Section having 'WidgetForDAS12978' Widget on Dashboards page
	And User sees Ellipsis icon enabled for Section having 'WidgetForDAS12978' Widget on Dashboards page
	And User sees Ellipsis icon enabled for 'WidgetForDAS12978' Widget on Dashboards page
	When User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS12978_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
    And User clicks Ellipsis menu for 'WidgetForDAS12978_2' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title                      | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy     | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS12978_2_Edited | All Applications | Version | Application | Count distinct    | Version ASC | 10        | true       |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles               |
	| WidgetForDAS12978          |
	| WidgetForDAS12978_2_Edited |
	When User deletes 'WidgetForDAS12978' Widget on Dashboards page
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles               |
	| WidgetForDAS12978_2_Edited |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS12977 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheReadOnlyMode
	When Dashboard with 'Dashboard for DAS12977' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS12977 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User clicks refresh button in the browser
	Then Dashboards sub menu is hidden on Dashboards page
	When User clicks Show Dashboards panel icon on Dashboards page
	Then User sees Dashboards sub menu on Dashboards page
	When User navigates to the "Dashboard for DAS12977" list
	Then 'CREATE DASHBOARD' button is not disabled
	And 'ADD SECTION' button is not displayed
	And 'ADD WIDGET' button is not displayed
	And User sees Edit mode trigger is in the Off position on Dashboards page
	And User sees Edit mode trigger has grey style on Dashboards page
	And User sees Collapse/Expand icon disabled for Section having 'WidgetForDAS12977' Widget on Dashboards page
	And User sees Ellipsis icon disabled for Section having 'WidgetForDAS12977' Widget on Dashboards page
	And User sees Ellipsis icon disabled for 'WidgetForDAS12977' Widget on Dashboards page
	And Dashboards context menu is hidden on Dashboards page
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14583 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetStaysOnTopPositionAfterEditing
	When Dashboard with 'Dashboard for DAS14583' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS14583_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_3 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | false      |
	And User clicks Ellipsis menu for 'WidgetForDAS14583_3' Widget on Dashboards page
	And User clicks 'Move to start' item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for 'WidgetForDAS14583_3' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_3 | All Applications | Vendor  | Vendor      | Count distinct    | Vendor ASC | 10        | false      |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles        |
	| WidgetForDAS14583_3 |
	| WidgetForDAS14583_1 |
	| WidgetForDAS14583_2 |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14855 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageDisplayingWhenDeletingWidget
	When Dashboard with 'Dashboard for DAS14855' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14855 | All Applications | Vendor  | Count             | Count ASC | 10        | true       |
	And User clicks Ellipsis menu for 'WidgetForDAS14855' Widget on Dashboards page
	And User clicks 'Delete' item from Ellipsis menu on Dashboards page
	Then User sees 'WidgetForDAS14855 will be permanently deleted' text in warning message on Dashboards page
	And User sees Widget square colored in amber
	When User clicks Cancel button in Delete Widget warning on Dashboards page
	And User deletes 'WidgetForDAS14855' Widget on Dashboards page
	Then User cant see widget with the next name 'WidgetForDAS14855' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @DAS14610
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageAppearsWhenOpenningNotExistingDashboard
	When User clicks Show Dashboards panel icon on Dashboards page
	When User tries to open same page with '9898998' item id
	Then User sees 'This dashboard does not exist or you do not have access to it' text in warning message on Dashboards submenu pane
	Then There are no errors in the browser console