Feature: ItemsManagement
	Runs Section and Widget management tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15200
Scenario: EvergreenJnr_DashboardsPage_CheckPrintStylesOnTheDashboardsPage
	When User clicks "print"  button on the Dashboards page
	Then Print Preview is displayed to the User
	When User selects "A4" option in the "Paper Size" dropdown for Print Preview Settings
	Then Print Preview is displayed in A4 format view
	When User selects "Letter" option in the "Paper Size" dropdown for Print Preview Settings
	Then Print Preview is displayed in Letter format view
	When User selects "Portrait" option in the "Paper Layout" dropdown for Print Preview Settings
	Then Print Preview is displayed in Portrait orientation
	When User selects "Landscape" option in the "Paper Layout" dropdown for Print Preview Settings
	Then Print Preview is displayed in Landscape orientation
	When User clicks Cancel button on the Print Preview Settings pop-up

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14358 @DAS14618
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD SECTION" Action button
	And User clicks Ellipsis menu for "Top 10 App Vendors" Widget on Dashboards page
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
	And User clicks the "ADD SECTION" Action button
	And User clicks Ellipsis menu for Section having "Operating System" Widget on Dashboards page
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

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14358 @DAS12989 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicatedIntoSameSection
	When Dashboard with "Dashboard for DAS12989" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD SECTION" Action button
	And User clicks "ADD WIDGET" button for "1" Section on Dashboards page
	And User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Section1_WidgetForDAS12989_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User clicks "ADD WIDGET" button for "2" Section on Dashboards page
	And User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Bar        | Section2_WidgetForDAS12989_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User clicks "ADD WIDGET" button for "2" Section on Dashboards page
	And User creates new Widget
	| WidgetType | Title                        | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Section2_WidgetForDAS12989_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for "Section1_WidgetForDAS12989_1" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees following Widgets in one Section on Dashboards page:
	| WidgetNames                   |
	| Section1_WidgetForDAS12989_1  |
	| Section1_WidgetForDAS12989_12 |
	And User sees following Widgets in one Section on Dashboards page:
	| WidgetNames                  |
	| Section2_WidgetForDAS12989_1 |
	| Section2_WidgetForDAS12989_2 |
	And User sees number of Widgets increased by "1" on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14358 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated
	When Dashboard with "Dashboard for DAS14358" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14358 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for Section having "WidgetForDAS14358" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by "1" on Dashboards page
	And User sees number of Widgets increased by "1" on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14586 @Delete_Newly_Created_Dashboard
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists
	When Dashboard with "<DashboardName>" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title   | List   | SplitBy   | AggregateBy   | AggregateFunction  | OrderBy   | TableOrientation | MaxValues | ShowLegend   |
	| <Type>     | <Title> | <List> | <SplitBy> | <AggregateBy> | <AggregateFunctio> | <OrderBy> |                  | 10        | <ShowLegend> |
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for "<Title>" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by "0" on Dashboards page
	And User sees number of Widgets increased by "1" on Dashboards page
	And User sees Widget with "<TitleCloned>" name on Dashboards page
	
Examples:
	| DashboardName                       | Type   | Title                                 | List             | SplitBy       | AggregateBy  | AggregateFunctio | OrderBy                        | TitleCloned                            | ShowLegend |
	| Dashboard for DAS14586_devices      | Line   | All Devices Widget For DAS_14586      | All Devices      | Hostname      |              | Count            | Count DESC                     | All Devices Widget For DAS_145862      | false      |
	| Dashboard for DAS14586_users        | Pie    | All Users Widget For DAS_14586        | All Users        | Username      | Display Name | Count distinct   | Username ASC                   | All Users Widget For DAS_145862        | false      |
	| Dashboard for DAS14586_applications | Bar    | All Applications Widget For DAS_14586 | All Applications | Application   |              | Count            | Count DESC                     | All Applications Widget For DAS_145862 | true       |
	| Dashboard for DAS14586_mailboxes    | Column | All Mailboxes Widget For DAS_14586    | All Mailboxes    | Email Address | Mail Server  | Count distinct   | Mail Server Count distinct ASC | All Mailboxes Widget For DAS_145862    | true       |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14728 @DAS14263 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetLegendCopiedWhenDuplicatingSection
	When Dashboard with "Dashboard for DAS14728" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14728 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User remembers number of Widgets with Legend on Dashboards page
	And User clicks Ellipsis menu for Section having "WidgetForDAS14728" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Widgets with Legend increased by "1" on Dashboards page
	When User clicks Dashboards Details icon on Dashboards page
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users / teams"
	When User clicks the "ADD TEAM" Action button
	When User selects the "Team 1061" team for sharing
	And User select "Admin" in Select Access dropdown
	When User clicks the "CANCEL" button on Dashboard Details
	Then Team/User section in not displayed on Dashboard Details

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS12978 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheEditMode
	When Dashboard with "Dashboard for DAS12978" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS12978 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User clicks refresh button in the browser
	And User clicks Show Dashboards panel icon on Dashboards page
	And User navigates to the "Dashboard for DAS12978" list
	And User clicks Edit mode trigger on Dashboards page
	Then User sees Edit mode trigger is in the On position on Dashboards page
	And User sees Edit mode trigger has blue style on Dashboards page
	And "CREATE DASHBOARD" Action button is disabled
	And "ADD SECTION" Action button is active
	And "ADD WIDGET" Action button is active
	And User sees Collapse/Expand icon enabled for Section having "WidgetForDAS12978" Widget on Dashboards page
	And User sees Ellipsis icon enabled for Section having "WidgetForDAS12978" Widget on Dashboards page
	And User sees Ellipsis icon enabled for "WidgetForDAS12978" Widget on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS12978_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
    And User clicks Ellipsis menu for "WidgetForDAS12978_2" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title                      | List | SplitBy | AggregateBy | AggregateFunction | OrderBy | TableOrientation | MaxValues | ShowLegend |
	|            | WidgetForDAS12978_2_Edited |      | Version | Application |                   |         |                  |           |            |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles               |
	| WidgetForDAS12978          |
	| WidgetForDAS12978_2_Edited |
	When User deletes "WidgetForDAS12978" Widget on Dashboards page
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles               |
	| WidgetForDAS12978_2_Edited |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS12977 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheReadOnlyMode
	When Dashboard with "Dashboard for DAS12977" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS12977 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User clicks refresh button in the browser
	Then Dashboards sub menu is hidden on Dashboards page
	When User clicks Show Dashboards panel icon on Dashboards page
	Then User sees Dashboards sub menu on Dashboards page
	When User navigates to the "Dashboard for DAS12977" list
	Then "CREATE DASHBOARD" Action button is active
	And "ADD SECTION" button is not displayed
	And "ADD WIDGET" button is not displayed
	And User sees Edit mode trigger is in the Off position on Dashboards page
	And User sees Edit mode trigger has grey style on Dashboards page
	And User sees Collapse/Expand icon disabled for Section having "WidgetForDAS12977" Widget on Dashboards page
	And User sees Ellipsis icon disabled for Section having "WidgetForDAS12977" Widget on Dashboards page
	And User sees Ellipsis icon disabled for "WidgetForDAS12977" Widget on Dashboards page
	And Dashboards context menu is hidden on Dashboards page
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14583 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetStaysOnTopPositionAfterEditing
	When Dashboard with "Dashboard for DAS14583" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS14583_2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14583_3 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | false      |
	And User clicks Ellipsis menu for "WidgetForDAS14583_3" Widget on Dashboards page
	And User clicks "Move to start" item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for "WidgetForDAS14583_3" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title | List | SplitBy | AggregateBy | AggregateFunction | OrderBy | TableOrientation | MaxValues | ShowLegend |
	|            |       |      |         | Vendor      |                   |         |                  |           |            |
	Then User sees following Widgets on Dashboards page:
	| WidgetTitles        |
	| WidgetForDAS14583_3 |
	| WidgetForDAS14583_1 |
	| WidgetForDAS14583_2 |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14855 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageDisplayingWhenDeletingWidget
	When Dashboard with "Dashboard for DAS14855" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | AggregateBy | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14855 | All Applications | Vendor  | Count             |             | Count ASC |                  | 10        | true       |
	And User clicks Ellipsis menu for "WidgetForDAS14855" Widget on Dashboards page
	And User clicks "Delete" item from Ellipsis menu on Dashboards page
	Then User sees ""WidgetForDAS14855" will be permanently deleted" text in warning message on Dashboards page
	When User clicks Cancel button in Delete Widget warning on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @DAS14610
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageAppearsWhenOpenningNotExistingDashboard
	When User tries to open same page with "9898998" item id
	Then User sees "This dashboard does not exist or you do not have access to it" text in warning message on Dashboards submenu pane
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15721 @DAS15937 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoMoreSectionsCanBeAddedAfter10WidgetsCreating
	When Dashboard with "Dashboard for DAS15721" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD SECTION" Action button
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then "1_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then "2_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 3_Widget | All Devices | 5       | 5          |
	Then "3_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 4_Widget | All Devices | 5       | 5          |
	Then "4_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 5_Widget | All Devices | 5       | 5          |
	Then "5_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 6_Widget | All Devices | 5       | 5          |
	Then "6_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 7_Widget | All Devices | 5       | 5          |
	Then "7_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 8_Widget | All Devices | 5       | 5          |
	Then "8_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 9_Widget | All Devices | 5       | 5          |
	Then "9_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title     | List        | MaxRows | MaxColumns |
	| List       | 10_Widget | All Devices | 5       | 5          |
	Then "10_Widget" Widget is displayed to the user
	#==========================================================#
	Then "ADD WIDGET" Action button is disabled
	Then "ADD SECTION" Action button is disabled
	Then "ADD WIDGET" Action button have tooltip with "Maximum number of widgets has been reached for this dashboard" text
	When User clicks Ellipsis menu for "10_Widget" Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to start    |
	| Move to end      |
	| Move to position |
	| Move to section  |
	| Delete           |
	Then "Duplicate" Ellipsis menu item is disabled on Dashboards page
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14618
Scenario: EvergreenJnr_DashboardsPage_CheckMovingWidgetsBetweenSections
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD SECTION" Action button
	And User clicks Ellipsis menu for "Device Profile" Widget on Dashboards page
	And User clicks "Move to section" item from Ellipsis menu on Dashboards page
	Then Move to Section pop up is displayed to the User
	When User clicks "CANCEL" button on the Move to Section Pop up
	Then Move to Section pop up is not displayed to the User
	When User clicks Ellipsis menu for "Device Profile" Widget on Dashboards page
	And User clicks "Move to section" item from Ellipsis menu on Dashboards page
	When User selects "2" section on the Move to Section pop up
	When User clicks "MOVE" button on the Move to Section Pop up
	When User expands all sections on Dashboards page
	Then "Device Profile" Widget is displayed to the user
	When User clicks Ellipsis menu for "Device Profile" Widget on Dashboards page
	And User clicks "Move to section" item from Ellipsis menu on Dashboards page
	When User selects "1" section on the Move to Section pop up
	When User clicks "MOVE" button on the Move to Section Pop up
	Then "Device Profile" Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16326 @Delete_Newly_Created_Dashboard @Not_Run
Scenario: EvergreenJnr_DashboardsPage_CheckErrorTextAndLinkOnTheWarningMessage
	When Dashboard with "Dashboard_DAS16326" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List                                | MaxRows | MaxColumns |
	| List       | Widget_For_DAS16326 | Device List (Complex) - BROKEN LIST | 10      | 10         |
	Then User sees "This widget refers to list Device List (Complex) - BROKEN LIST which has errors" text in warning message on Dashboards page
	Then "Device List (Complex) - BROKEN LIST" link is displayed in warning message on Dashboards page
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16623
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsAndCorrectTextDisplayedForWidgetHavingBrokenLists
	When User tries to open same page with "625" item id
	Then There are no errors in the browser console
	And User sees "This widget refers to list Users List (Complex) - BROKEN LIST which has errors" text in "1" warning messages on Dashboards page
	And User sees "This widget refers to list Users List (Complex) - BROKEN LIST which has errors" text in "2" warning messages on Dashboards page
	And User sees "This widget refers to list Application List (Complex) - BROKEN LIST which has errors" text in "3" warning messages on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @DAS15877 @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatSettingsDisplayedForDashboard
	When Dashboard with "Dashboard_DAS15877" name created via API and opened
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard_DAS15877" dashboard
	Then User sees dashboard menu with next options
	| OptionsName    |
	| Manage         |
	| Make favourite |
	| Duplicate      |
	| Set default    |
	| Delete         | 