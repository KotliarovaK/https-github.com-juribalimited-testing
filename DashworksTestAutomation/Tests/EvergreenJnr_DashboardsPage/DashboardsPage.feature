Feature: DashboardsPage
	Runs Dashboards Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Dashboards @DAS13114 @DAS13721 @archived
Scenario: EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDevicesPageWithProperItems
	When User clicks "Unknown" section from "Windows 10 Branch" circle chart on Dashboards page
	Then "Devices" list should be displayed to the user
	And "16" rows are displayed in the agGrid

@Evergreen @Dashboards @Widgets @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget
	When User clicks Edit mode trigger on Dashboards page
	And User clicks Ellipsis menu for "Top 10 App Vendors" Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to start    |
	| Move to end      |
	| Move to position |
	| Delete           |

@Evergreen @Dashboards @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection
	When User clicks Edit mode trigger on Dashboards page
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

@Evergreen @Dashboards @Widgets @DAS14358 @DAS12989
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicatedIntoSameSection
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS12989" name
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
	When User clicks Settings button for "Dashboard for DAS12989" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated
	When User clicks Edit mode trigger on Dashboards page
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for Section having "Domain Profile" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by "1" on Dashboards page
	And User sees number of Widgets increased by "4" on Dashboards page
	When User deletes duplicated Section having "Domain Profile" Widget on Dashboards page

@Evergreen @Dashboards @Widgets @Delete_Newly_Created_List @DAS14668
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetsCanBeCreatedWhenUsingSplitByAndAggregateByDateColumn
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| ICSP: i-Schedule |
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	| 00OMQQXWA1DRI6   |
	| 00SH8162NAS524   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TestList_DAS14668" name
	And User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14668" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy          | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_1 | TestList_DAS14668 | ICSP: i-Schedule |             | Count             | Count ASC |                  | 5         |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_1" on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List              | SplitBy          | AggregateBy      | AggregateFunction | OrderBy               | TableOrientation | MaxValues | ShowLegend |
	| Pie        | Test_Widget_DAS14668_2 | TestList_DAS14668 | ICSP: i-Schedule | ICSP: i-Schedule | Count distinct    | ICSP: i-Schedule DESC |                  | 20        |            |
	Then User sees widget with the next name "Test_Widget_DAS14668_2" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14668" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS14586
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatDuplicatingWorksForWidgetsCreatedForAllLists
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "<DashboardName>" name
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
	When User clicks Settings button for "<DashboardName>" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

Examples:
	| DashboardName                       | Type   | Title                                 | List             | SplitBy       | AggregateBy  | AggregateFunctio | OrderBy                        | TitleCloned                            | ShowLegend |
	| Dashboard for DAS14586_devices      | Line   | All Devices Widget For DAS_14586      | All Devices      | Hostname      |              | Count            | Count DESC                     | All Devices Widget For DAS_145862      | false      |
	| Dashboard for DAS14586_users        | Pie    | All Users Widget For DAS_14586        | All Users        | Username      | Display Name | Count distinct   | Username ASC                   | All Users Widget For DAS_145862        | false      |
	| Dashboard for DAS14586_applications | Bar    | All Applications Widget For DAS_14586 | All Applications | Application   |              | Count            | Count DESC                     | All Applications Widget For DAS_145862 | true       |
	| Dashboard for DAS14586_mailboxes    | Column | All Mailboxes Widget For DAS_14586    | All Mailboxes    | Email Address | Mail Server  | Count distinct   | Mail Server Count distinct ASC | All Mailboxes Widget For DAS_145862    | true       |

@Evergreen @Dashboards @DAS14587 @Widgets
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14587" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Pie        |       | All Devices | Device Type | Hostname    | Count distinct    | Device Type ASC |                  | 10        |            |
	Then Error message with "Widget Title should not be empty" text is displayed on Widget page
	And There are no errors in the browser console
	When User creates new Widget
	| WidgetType | Title                  | List | SplitBy | AggregateBy | AggregateFunction | OrderBy | TableOrientation | MaxValues | ShowLegend |
	|            | Dashboard for DAS14587 |      |         |             |                   |         |                  |           |            |
	Then User sees widget with the next name "Dashboard for DAS14587" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14587" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @Sections @DAS14728 @DAS14263
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetLegendCopiedWhenDuplicatingSection
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14728" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14728 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |                  | 10        | true       |
	And User remembers number of Widgets with Legend on Dashboards page
	And User clicks Ellipsis menu for Section having "WidgetForDAS14728" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Widgets with Legend increased by "1" on Dashboards page
	#Uncomment after DAS14263 implemented
	#When User clicks Settings button for "Dashboard for DAS14728" dashboard
	#When User clicks Manage in the list panel
	#Then Permission panel is displayed to the user
	#When User changes sharing type from "Private" to "Specific users / teams"
	#When User clicks the "ADD TEAMS" Action button
	#When User selects "Team 1061" in the Team dropdown
	#And User select "Admin" in Select Access dropdown
	#When User clicks the "CANCEL" Action button
	When User clicks Settings button for "Dashboard for DAS14728" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @Sections @DAS12978
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheEditMode
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS12978" name
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
	When User clicks Settings button for "Dashboard for DAS12978" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @Sections @DAS12977
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardIsInTheReadOnlyMode
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS12977" name
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
	When User clicks Settings button for "Dashboard for DAS12977" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @Sections @DAS14583
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetStaysOnTopPositionAfterEditing
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14583" name
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
	When User clicks Settings button for "Dashboard for DAS14583" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @DAS14685 @Widgets
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorAppearsWhenCreatingTableWidget
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14685" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Table      | WidgetForDAS14685 | All Applications | Application | Application | Count distinct            | Application ASC |                  | 10        |            |
	Then There are no errors in the browser console
	Then User sees widget with the next name "WidgetForDAS14685" on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14685" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS14855
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageDisplayingWhenDeletingWidget
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14855" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | AggregateBy | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14855 | All Applications | Vendor  | Count             |             | Count ASC |                  | 10        | true       |
	And User clicks Ellipsis menu for "WidgetForDAS14855" Widget on Dashboards page
	And User clicks "Delete" item from Ellipsis menu on Dashboards page
	Then User sees ""WidgetForDAS14855" will be permanently deleted" text in warning message on Dashboards page
	When User clicks Cancel button in Delete Widget warning on Dashboards page
	And User clicks Settings button for "Dashboard for DAS14855" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @DAS14578 @DAS14584 @Widgets
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14578" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                                                                                                       | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend |
	| Table      | Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred and seven | All Applications | Application | Application | Count distinct    | Application ASC | Horizontal       | 10        |            |
	Then User sees widget with the next name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" on Dashboards page
	And Widget name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" has word break style on Dashboards page
	When User clicks Settings button for "Dashboard for DAS14578" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Sections @DAS14610
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageAppearsWhenOpenningNotExistingDashboard
	When User tries to open same page with another item id
	Then User sees "This dashboard does not exist or you do not have access to it" text in warning message on Dashboards submenu pane
	And There are no errors in the browser console

@Evergreen @Dashboards @DAS14911 
Scenario: EvergreenJnr_DashboardsPage_CheckThatOwnerCanBeAddedToSharedUsersAsSpecificUserWithDifferentPermissions
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14911" name
	And User clicks Settings button for "Dashboard for DAS14911" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users"
	And User adds user to list of shared person
	| User          | Permission |
	| Administrator | Admin      |
	Then User "Administrator" was added to shared list with "Admin" permission
	And There are no errors in the browser console
	When User clicks Settings button for "Administrator" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And There are no errors in the browser console
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Edit       |
	Then User "Administrator" was added to shared list with "Edit" permission
	And There are no errors in the browser console
	When User clicks Settings button for "Administrator" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And There are no errors in the browser console
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Read       |
	Then User "Administrator" was added to shared list with "Read Only" permission
	And There are no errors in the browser console
	When User clicks Settings button for "Administrator" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And There are no errors in the browser console
	#teardown
	When User clicks Settings button for "Dashboard for DAS14911" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS14920 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccursWhenCreatingDashboardWidgetThatUsesBooleanField
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Secure Boot Enabled  |
	| Windows7Mi: In Scope |
	When User create dynamic list with "14920_List" name on "Devices" page
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14920" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	When User adds new Widget
	| WidgetType | Title       | List       | SplitBy             | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Drilldown |
	| Table      | DAS-14920_1 | 14920_List | Secure Boot Enabled |             | Count             | Count ASC |                  | 10        |            |           |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	And "DAS-14920_1" Widget is displayed to the user
	And "2,190" count is displayed for "False" in the table Widget
	And "2,192" count is displayed for "True" in the table Widget
	And "12,843" count is displayed for "Unknown" in the table Widget
	#Second Widget creation
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title       | List       | SplitBy              | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Table      | DAS-14920_2 | 14920_List | Windows7Mi: In Scope |             | Count             | Count ASC |                  | 10        |            |
	Then There are no errors in the browser console
	And "DAS-14920_2" Widget is displayed to the user
	Then "12,064" count is displayed for "False" in the table Widget
	And "5,161" count is displayed for "True" in the table Widget
	When User clicks Settings button for "Dashboard for DAS14920" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS15372 @DAS15317 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetThatUsesCpuArchitField
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| CPU Architecture |
	And User clicks Save button on the list panel
	And User create dynamic list with "List15372" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy          | AggregateBy | AggregateFunction | OrderBy              | TableOrientation | MaxValues | ShowLegend | Type | Drilldown |
	| Pie        | WidgetForDAS15372 | List15372 | CPU Architecture | Hostname    | Count distinct    | CPU Architecture ASC |                  | 10        | false      |      |           |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then "WidgetForDAS15372" Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @Dashboards @Widgets @DAS15365 @DAS15352 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingPieWidgetUsedSavedList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Model      |
	And User clicks Save button on the list panel
	And User create dynamic list with "List15365" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Type | Drilldown |
	| Pie        | WidgetForDAS15365 | List15365 | Model   | Model       | Count distinct    | Model ASC |                  | 10        | true       |      |           |
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

@Evergreen @Dashboards @Widgets @DAS15364 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingCardWidgetUsedCpuVirtField
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| CPU Virtualisation Capable |
	And User have opened column settings for "CPU Virtualisation Capable" column
	And User have select "Pin Left" option from column settings
	And User clicks Save button on the list panel
	And User create dynamic list with "List15364" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS15364" as Widget Title
	And User selects "List15364" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console

@Evergreen @Dashboards @Widgets @DAS15356 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingWidgetWithSpecificColumns
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Secure Boot Enabled |
	| Manufacturer        |
	| Compliance          |
	And User click on 'Manufacturer' column header
	Then data in table is sorted by 'Manufacturer' column in ascending order
	When User clicks Save button on the list panel
	And User create dynamic list with "List15356" name on "Devices" page
	And User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | TableOrientation | MaxValues | ShowLegend | Type | Drilldown |
	| Bar        | WidgetForDAS15356 | List15356 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC |                  | 10        | true       |      |           |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15432 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsAreDisplayedWhenCreateListWidgetWithStaticList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "Static_List_15432" name
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15432" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15432 | Static_List_15432 | 500     | 10         |
	Then "Widget_For_DAS15432" Widget is displayed to the user
	And There are no errors in the browser console
	When User clicks Settings button for "Dashboard for DAS15432" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS15207
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIsCreatedWhenListIsAnObjectList
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List        | Type      | AggregateBy | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS15207 | All Devices | Aggregate | Hostname    | Count distinct    |         |         |           |            |                  |           |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS15207" Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15413 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatDataFromTheWidgetMatchesTheOriginalDynamicLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| 1803: Application Rationalisation |
	Then ColumnName is added to the list
	| ColumnName                        |
	| 1803: Application Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values    |
	| Microsoft |
	When User create dynamic list with "TestList_DAS15413" name on "Applications" page
	Then "TestList_DAS15413" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15413" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15413 | TestList_DAS15413 | 500     | 10         |
	Then "Widget_For_DAS15413" Widget is displayed to the user
	Then following content is displayed in the "Vendor" column for Widget
	| Values                |
	| Microsoft Corporation |
	When User clicks Settings button for "Dashboard for DAS15413" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15737 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatColourSchemeIsDisplayedForReadinessSplitByInDropdown
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| prK: Application Readiness |
	Then ColumnName is added to the list
	| ColumnName                 |
	| prK: Application Readiness |
	When User create dynamic list with "TestList_DAS15737" name on "Users" page
	Then "TestList_DAS15737" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15737" name
	And User clicks the "ADD WIDGET" Action button
	When User selects "Line" in the "Widget Type" Widget dropdown
	And User enters "DAS15737" as Widget Title
	And User selects "TestList_DAS15737" as Widget List
	When User selects "prK: Application Readiness" in the "Split By" Widget dropdown
	When User selects "Count" in the "Aggregate Function" Widget dropdown
	When User selects "prK: Application Readiness ASC" in the "Order By" Widget dropdown
	And User clicks on the Colour Scheme dropdown
	Then Colour Scheme dropdown is displayed to the user
	When User clicks the "CREATE" Action button
	When User clicks Settings button for "Dashboard for DAS15737" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15721 @DAS15937 @Not_Run
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoMoreSectionsCanBeAddedAfter10WidgetsCreating
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15721" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 1_Widget | All Users | 10      | 10         |
	Then "1_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 2_Widget | All Users | 10      | 10         |
	Then "2_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 3_Widget | All Users | 10      | 10         |
	Then "3_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 4_Widget | All Users | 10      | 10         |
	Then "4_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 5_Widget | All Users | 10      | 10         |
	Then "5_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 6_Widget | All Users | 10      | 10         |
	Then "6_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 7_Widget | All Users | 10      | 10         |
	Then "7_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 8_Widget | All Users | 10      | 10         |
	Then "8_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title    | List      | MaxRows | MaxColumns |
	| List       | 9_Widget | All Users | 10      | 10         |
	Then "9_Widget" Widget is displayed to the user
	#==========================================================#
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title     | List      | MaxRows | MaxColumns |
	| List       | 10_Widget | All Users | 10      | 10         |
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
	| Delete           |
	Then "Duplicate" Ellipsis menu item is disabled on Dashboards page
	When User clicks Settings button for "Dashboard for DAS15721" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16073
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetIsDisplayedCorrectly
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS16073" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS16073 | All Devices | Hostname | Count             | Count DESC | Vertical         | 10        |
	Then There are no errors in the browser console
	And "WidgetForDAS16073" Widget is displayed to the user
	Then link is not displayed for the "CAS" value in the Widget
	Then link is not displayed for the "WIN-43TMG2KMRBI" value in the Widget
	Then link is not displayed for the "WIN81PRO" value in the Widget
	When User clicks Settings button for "Dashboard for DAS16073" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @Widgets @DAS16138
Scenario: EvergreenJnr_DashboardsPage_CheckThatListCardWidgetLeadsToCorrectPage
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List         | Type      | AggregateBy          | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS16138 | 1803 Rollout | Aggregate | 1803: Scheduled Date | First             |         |         |           |            |                  | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS16138" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	And User clicks data in card "WidgetForDAS16138" widget
	Then Save as a new list option is available
	And "8" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "1803: Scheduled Date is 05 Nov 2018" is displayed in added filter info
	And "Any Device in list 1803 Rollout" is displayed in added filter info

@Evergreen @Dashboards @Widgets @DAS15900
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningMessageAppearsOnceWhenSwitchingToDashboardWithoutSavingWidgetChanges
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15900" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | AggregateBy | OrderBy   | TableOrientation | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900 | All Applications | Vendor  | Count             |             | Count ASC |                  | 10        | true       |
	And User clicks Ellipsis menu for "WidgetForDAS15900" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User adds new Widget
	| WidgetType | Title                    | List        | SplitBy  | AggregateBy | AggregateFunction | OrderBy   | TableOrientation | MaxValues | ShowLegend | Type | Drilldown |
	| Pie        | WidgetForDAS15900_Edited | All Devices | Hostname |             | Count             | Count ASC |                  | 11        | true       |      |           | 
	When User clicks first Dashboard in dashboards list
	Then User sees "You have unsaved changes. Are you sure you want to leave the page?" text in alert on Edit Widget page
	When User clicks "NO" button in Unsaved Changes alert
	Then Unsaved Changes alert not displayed to the user
	#delete test dashboard
	When User clicks Settings button for "Dashboard for DAS15900" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel
	And User clicks "YES" button in Unsaved Changes alert

@Evergreen @Dashboards @Widgets @DAS15918
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByShowsCorrectOptionsForHalfDonut
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List         | Type | AggregateBy | AggregateFunction | SplitBy                | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Half donut | WidgetForDAS15918 | 1803 Rollout |      |             | Count             | 1803: Ready to Migrate |         |           |            |                  |           |
	Then User sees following options for Order By selector on Create Widget page:
	| items                       |
	| 1803: Ready to Migrate ASC  |
	| 1803: Ready to Migrate DESC |
	| Count ASC                   |
	| Count DESC                  |