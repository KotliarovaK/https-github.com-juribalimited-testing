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

@Evergreen @Dashboards @Widgets @DAS14358 @DAS14618
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
	| Move to section  |
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

@Evergreen @Dashboards @Widgets @Sections @DAS14583 @Not_Run
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
	| Table      | WidgetForDAS14685 | All Applications | Application | Application | Count distinct    | Application ASC |                  | 10        |            |
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
	Then User sees "WidgetForDAS14855" will be permanently deleted" text in warning message on Dashboards page
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

@Evergreen @Dashboards @Widgets @DAS15364 @DAS15316 @Delete_Newly_Created_List
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
	And Card widget displayed inside preview pane
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

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15737 @DAS15662 @Delete_Newly_Created_List
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
	Then "Data Label" checkbox is not displayed on the Create Widget page
	When User clicks the "CREATE" Action button
	When User clicks Settings button for "Dashboard for DAS15737" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15721 @DAS15937 @Not_Ready
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

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15900
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

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15918
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

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16138
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetValueLeadsToCorrectFilteredPage
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
	When User selects Save as new list option
	Then "8" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "1803: Scheduled Date is 05 Nov 2018" is displayed in added filter info
	And "Any Device in list 1803 Rollout" is displayed in added filter info

@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16069
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetValuesLeadsToDeviceListFilteredPage
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And user select "Device Type" filter
	And User clicks in search field in the Filter block
	And User enters "Desktop" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| 1803: Scheduled Date |
	And User create dynamic list with "1803 ScheduleDAS16069" name on "Devices" page
	Then "1803 ScheduleDAS16069" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "1803 ProjectDAS16069" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                    | List                  | Type | AggregateBy | AggregateFunction | SplitBy              | OrderBy                  | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Line       | Project ScheduleDAS16069 | 1803 ScheduleDAS16069 |      | Hostname    | Count distinct    | 1803: Scheduled Date | 1803: Scheduled Date ASC |           |            |                  | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "Project ScheduleDAS16069" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	Then Tooltip is displayed for the point of Line widget
	| WidgetName               | NumberOfPoint | Tooltip      |
	| Project ScheduleDAS16069 | 1             | 5 Nov 2018 4 |
	When User clicks point of Line widget
	| WidgetName               | NumberOfPoint | 
	| Project ScheduleDAS16069 | 1             | 
	Then Save as a new list option is available
	And "4" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName           |
	| Hostname             |
	| Device Type          |
	| Operating System     |
	| Owner Display Name   |
	| 1803: Scheduled Date |	

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16069
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetValuesLeadsToApplicationsListFilteredPage
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS16069_1" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List             | SplitBy | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS16069_1 | All Applications | Vendor  | Count             | Count DESC |                  | 500       |
	Then "WidgetForDAS16069_1" Widget is displayed to the user
	And "918" count is displayed for "Microsoft Corporation" in the table Widget
	When User clicks "918" value for "Microsoft Corporation" column
	Then "918" rows are displayed in the agGrid
	And Column is displayed in following order:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16069 @DAS15134 @DAS15355
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetValuesLeadsToApplicationsListFilteredPage
	When User clicks "Applications" on the left-hand menu
	And User clicks the Filters button
	When User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               | 
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	When User removes "Vendor" column by Column panel
	When User removes "Version" column by Column panel
	And User create dynamic list with "1803 App Compliance" name on "Applications" page
	Then "1803 App Compliance" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS16069_2" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS16069" as Widget Title
	And User selects "1803 App Compliance" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	Then Colour Scheme dropdown is not displayed to the user
	When User selects "Text Only" in the "Layout" Widget dropdown
	Then Text Only is displayed for Card widget
	Then "Green" color is displayed for Card Widget
	When User clicks the "CREATE" Action button
	Then Text Only is displayed for Card widget
	Then "Green" color is displayed for Card Widget
	When User clicks Ellipsis menu for "WidgetForDAS16069" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget
	Then "Green" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then "Green" color is displayed for Card Widget
	Then Icon and Text is displayed for Card widget
	When User clicks Ellipsis menu for "WidgetForDAS16069" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget
	Then "Green" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then "Green" color is displayed for Card Widget
	Then Icon Only is displayed for Card widget
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title               | List                | Type      | AggregateBy | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS16069_2 | 1803 App Compliance | Aggregate |             | Count             |         |         |           |            |                  | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS16069_2" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	And User clicks data in card "WidgetForDAS16069_2" widget
	Then Save as a new list option is available
	And "286" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15134 @DAS16263
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIncludeSelectionOfEvergreenColours
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15134" name
	And User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS15134" as Widget Title
	And User selects "All Devices" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	When User selects "Pink" in the Colour Scheme
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS15134" Widget is displayed to the user
	Then "Pink" color is displayed for widget
	When User clicks Ellipsis menu for "WidgetForDAS15134" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Amber" in the Colour Scheme
	When User clicks the "UPDATE" Action button
	Then "Amber" color is displayed for widget
	When User clicks Settings button for "Dashboard for DAS15134" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel
	
@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15920 @DAS15662
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetHavingComplianceColumnsDisplayedCorrectlyOnDashboard
	When User clicks "Users" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                    |
	| Device Application Compliance |
	| Compliance                    |
	And User create dynamic list with "ListForDas15920" name on "Users" page
	Then "ListForDas15920" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "DashboardForDas15920" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                 | List            | Type | AggregateBy | AggregateFunction | SplitBy                       | OrderBy                           | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Line       | LineWidgetForDas15920 | ListForDas15920 |      |             | Count             | Device Application Compliance | Device Application Compliance ASC |           |            |                  | Yes       |
	Then Widget Preview is displayed to the user
	Then "Data Label" checkbox is not displayed on the Create Widget page
	When User clicks the "CREATE" Action button
	Then Card "LineWidgetForDas15920" Widget is displayed to the user
	And Line chart displayed in "LineWidgetForDas15920" widget

@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15722
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetHavingDateColumnsDisplayedCorrectlyOnDashboard
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	And User have opened column settings for "Build Date" column
	And User have select "Pin Left" option from column settings
	And User click on 'Build Date' column header
	And User create dynamic list with "ListForDas15722" name on "Devices" page
	Then "ListForDas15722" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "DashboardForDas15722" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List            | Type      | AggregateBy | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS15722 | ListForDas15722 | Aggregate | Build Date  | First             |         |         |           |            |                  | Yes       |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS15722" Widget is displayed to the user
	And There are no errors in the browser console
	When User clicks Edit mode trigger on Dashboards page
	And User clicks data in card "WidgetForDAS15722" widget
	Then "1" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @Delete_Newly_Created_List @DAS15355
Scenario: EvergreenJnr_DashboardsPage_CheckComplianceFirstCellIconsForCardWidget
	When User clicks "Applications" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	When User removes "Vendor" column by Column panel
	When User removes "Version" column by Column panel
	And User create dynamic list with "DAS15355_Applications_List" name on "Applications" page
	Then "DAS15355_Applications_List" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard_DAS15355" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS15355" as Widget Title
	And User selects "DAS15355_Applications_List" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	When User selects "Text Only" in the "Layout" Widget dropdown
	Then Text Only is displayed for Card widget
	Then "Amber" color is displayed for Card Widget
	When User clicks the "CREATE" Action button
	Then Text Only is displayed for Card widget
	When User clicks Ellipsis menu for "WidgetForDAS15355" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget
	Then "Amber" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then Icon and Text is displayed for Card widget
	When User clicks Ellipsis menu for "WidgetForDAS15355" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget
	Then "Amber" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then Icon Only is displayed for Card widget
	When User clicks Settings button for "Dashboard_DAS15355" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @Delete_Newly_Created_List @DAS15355 @DAS15662
Scenario: EvergreenJnr_DashboardsPage_CheckReadinessFirstCellIconsForCardWidget
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| 1803: Readiness |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Hostname" column by Column panel
	When User removes "Device Type" column by Column panel
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	And User create dynamic list with "DAS15355_List" name on "Devices" page
	Then "DAS15355_List" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard_DAS15355_1" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS15355_1" as Widget Title
	And User selects "DAS15355_List" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	When User selects "Text Only" in the "Layout" Widget dropdown
	Then Text Only is displayed for Card widget
	Then "Grey" color is displayed for Card Widget
	Then "Data Label" checkbox is not displayed on the Create Widget page
	When User clicks the "CREATE" Action button
	Then Text Only is displayed for Card widget
	Then "Grey" color is displayed for Card Widget
	When User clicks Ellipsis menu for "WidgetForDAS15355_1" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget
	Then "Grey" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then "Grey" color is displayed for Card Widget
	Then Icon and Text is displayed for Card widget
	When User clicks Ellipsis menu for "WidgetForDAS15355_1" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget
	Then "Grey" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then "Grey" color is displayed for Card Widget
	Then Icon Only is displayed for Card widget
	When User clicks Settings button for "Dashboard_DAS15355_1" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15662
Scenario Outline: EvergreenJnr_DashboardsPage_CheckDataLabelsOnTheWidget
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "DAS15662_Dashboard" name
	And User clicks the "ADD WIDGET" Action button
	When User selects "<WidgetType>" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS15662" as Widget Title
	And User selects "All Devices" as Widget List
	When User selects "Hostname" in the "Split By" Widget dropdown
	When User selects "Count" in the "Aggregate Function" Widget dropdown
	When User selects "Count ASC" in the "Order By" Widget dropdown
	When User selects "Data Label" checkbox on the Create Widget page
	Then Data Labels are displayed on the Dashboards page
	Then "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks the "CREATE" Action button
	Then Data Labels are displayed on the Dashboards page
	Then "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks Ellipsis menu for "WidgetForDAS15662" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	And User clicks Ellipsis menu for "WidgetForDAS156622" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	Then "Data Label" checkbox is checked on the Create Widget page
	Then Data Labels are displayed on the Dashboards page
	Then "<DataLabel>" data label is displayed on the Dashboards page
	When User clicks Settings button for "DAS15662_Dashboard" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

Examples:
	| WidgetType | DataLabel      |
	| Pie        | 00RUUMAH9OZN9A |
	| Half donut | 00RUUMAH9OZN9A |
	| Donut      | 00RUUMAH9OZN9A |

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16266
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIsDisplayedCorrectlyWithBlankFirstCell
	When User clicks "Devices" on the left-hand menu
	When User click on 'Owner Display Name' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Hostname" column by Column panel
	When User removes "Device Type" column by Column panel
	When User removes "Operating System" column by Column panel
	And User create dynamic list with "DAS16266_List" name on "Devices" page
	Then "DAS16266_List" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "DAS16266_Dashboard" name
	And User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS16266" as Widget Title
	And User selects "DAS16266_List" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	When User clicks the "CREATE" Action button
	Then Card Widget is blank
	When User clicks Settings button for "DAS16266_Dashboard" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel
	Then Search field in selected Filter is empty

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15200
Scenario: EvergreenJnr_DashboardsPage_CheckPrintStylesOnTheDashboardsPage
	When User clicks "print"  button on the Dashboards page
	Then Print Preview is displayed to the User
	When User selects "A4" option in the "Paper size" dropdown for Print Preview Settings
	Then Print Preview is displayed in A4 format view
	When User selects "Letter" option in the "Paper size" dropdown for Print Preview Settings
	Then Print Preview is displayed in Letter format view
	When User selects "Portrait" option in the "Paper layout" dropdown for Print Preview Settings
	Then Print Preview is displayed in Portrait orientation
	When User selects "Landscape" option in the "Paper layout" dropdown for Print Preview Settings
	Then Print Preview is displayed in Landscape orientation
	When User clicks Cancel button on the Print Preview Settings pop-up

@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15914
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellSelected
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User Add And "1803: Ready to Migrate" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Ready              |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName             |
	| 1803: Ready to Migrate |
	And User move '1803: Ready to Migrate' column to 'Hostname' column
	And User move 'Hostname' column to 'Device Type' column
	And User create dynamic list with "DeviceListFor15914" name on "Devices" page
	Then "DeviceListFor15914" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15914" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       | AggregateBy | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS15914 | DeviceListFor15914 | First Cell |             |                   |         |         |           |            |                  |           |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows "READY" as First Cell value

@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15544
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetHasCorrectChronologicalOrder
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Service Pack or Build |
	And User create dynamic list with "ListForDas15544" name on "Devices" page
	Then "ListForDas15544" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "1803 ProjectDAS15544" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                     | List            | Type | AggregateBy | AggregateFunction | SplitBy               | OrderBy                   | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Line       | SortOrderCheckForDas15544 | ListForDas15544 |      |             | Count             | Service Pack or Build | Service Pack or Build ASC |           |            |                  | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "SortOrderCheckForDas15544" Widget is displayed to the user
	And Line X labels of "SortOrderCheckForDas15544" widget is displayed in following order:
	| ColumnName             |
	| Empty                  |
	| No Service Pack        |
	| Service Pack 1         |
	| Service Pack 2         |
	| Service Pack 3         |
	| Service Pack 3, v.6055 |
	| Windows 8.0            |
	| Windows 8.1            |
	| 1507                   |
	| 1607                   |

@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16127
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenListHasReadinessColumnFirst
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And user select "1803: Readiness" filter
	And User clicks in search field in the Filter block
	And User enters "Red" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| 1803: Readiness |
	And User move '1803: Readiness' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	And User create dynamic list with "DeviceListFor16127" name on "Devices" page
	Then "DeviceListFor16127" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS16127" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       | AggregateBy | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS16127 | DeviceListFor16127 | First Cell |             |                   |         |         |           |            |                  |           |
	Then Widget Preview is displayed to the user
	And Widget Preview shows "RED" as First Cell value
	And There are no errors in the browser console

@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15765
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellIsEmpty
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 001BAQXT6JWFPI |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| 1803: Scheduled Date |
	And User move '1803: Scheduled Date' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	And User create dynamic list with "DeviceListFor15765" name on "Devices" page
	Then "DeviceListFor15765" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS15765" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       | AggregateBy | AggregateFunction | SplitBy | OrderBy | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Card       | WidgetForDAS15765 | DeviceListFor15765 | First Cell |             |                   |         |         |           |            |                  |           |
	Then Widget Preview is displayed to the user
	And Widget Preview shows "Empty" as First Cell value
	And There are no errors in the browser console

@Evergreen @Dashboards @Widgets @DAS15208
Scenario: EvergreenJnr_DashboardsPage_CheckThatTableWidgetDisplayedFullyInPreviewPane
	When User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title     | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues | ShowLegend | Drilldown |
	| Table      | DAS-15208 | All Devices | Device Type | Device Type | Count distinct    | Device Type ASC | Horizontal       |           |            |           |
	Then Widget Preview is displayed to the user
	And Table widget displayed inside preview pane correctly
	And There are no errors in the browser console
	
@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS15462
Scenario: EvergreenJnr_DashboardsPage_CheckThatLineWidgetTooltipsShowsNameAndCount
	When User clicks "Dashboards" on the left-hand menu
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                      | List        | Type | AggregateBy | AggregateFunction | SplitBy          | OrderBy              | MaxValues | ShowLegend | TableOrientation | Drilldown |
	| Line       | Project AllDevicesDAS15462 | All Devices |      | Hostname    | Count distinct    | Operating System | Operating System ASC |           |            |                  |           |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "Project AllDevicesDAS15462" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	Then Tooltip is displayed for the point of Line widget
	| WidgetName                 | NumberOfPoint | Tooltip     |
	| Project AllDevicesDAS15462 | 2             | OS X 10.5 1 |
	
	@Evergreen @Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS14618
Scenario: EvergreenJnr_DashboardsPage_CheckMovingWidgetsBetweenSections
	When User clicks Edit mode trigger on Dashboards page
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
	When User clicks "Dashboards" navigation link on the Admin page
	Then "Device Profile" Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @DAS16336 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsInConsoleAfterAddingApplicationReadinessFirstCellWidget
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| MigrationP: Application Readiness |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	And User removes "Vendor" column by Column panel
	And User removes "Version" column by Column panel
	And User click on 'MigrationP: Application Readiness' column header
	And User create dynamic list with "DAS16336_Applications_List" name on "Applications" page
	Then "DAS16336_Applications_List" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard_DAS16336" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	When User selects "Card" in the "Widget Type" Widget dropdown
	And User enters "WidgetForDAS16336" as Widget Title
	And User selects "DAS16336_Applications_List" as Widget List
	When User selects "First Cell" in the "Type" Widget dropdown
	And User selects "Text Only" in the "Layout" Widget dropdown
	Then Text Only is displayed for Card widget
	And "Amber" color is displayed for Card Widget
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	Then Text Only is displayed for Card widget
	And "Amber" color is displayed for Card Widget
	When User clicks Ellipsis menu for "WidgetForDAS16336" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget
	Then "Amber" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then There are no errors in the browser console
	Then Icon Only is displayed for Card widget
	Then "Amber" color is displayed for Card Widget
	When User clicks Ellipsis menu for "WidgetForDAS16336" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget
	Then "Amber" color is displayed for Card Widget
	When User clicks the "UPDATE" Action button
	Then There are no errors in the browser console
	Then "Amber" color is displayed for Card Widget
	Then Icon and Text is displayed for Card widget
	When User clicks Settings button for "Dashboard_DAS16336" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @Delete_Newly_Created_List @DAS16275
Scenario: EvergreenJnr_DashboardsPage_CheckCapacitySlotsDisplayOrderInDashboards
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| Windows7Mi: Scheduled Date (Slot) |
	And User create dynamic list with "Devices_List_DAS16275" name on "Devices" page
	Then "Devices_List_DAS16275" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "DAS16275_Dashboard" name
	Then "New dashboard created" message is displayed
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title           | List                  | SplitBy                           | AggregateFunction | AggregateBy | OrderBy   | MaxValues | TableOrientation | ShowLegend |
	| Table      | DAS16275_Widget | Devices_List_DAS16275 | Windows7Mi: Scheduled Date (Slot) | Count             |             | Count ASC |           | Vertical         |            |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then "DAS16275_Widget" Widget is displayed to the user
	Then content in the Widget is displayed in following order:
	| TableValue                    |
	| Slot 2018-10-01 to 2018-12-31 |
	| Slot 2018-11-01 - 2020-12-26  |
	| Empty                         |
	When User clicks Ellipsis menu for "DAS16275_Widget" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	When User selects "Count DESC" in the "Order By" Widget dropdown
	When User clicks the "UPDATE" Action button
	Then content in the Widget is displayed in following order:
	| TableValue                    |
	| Empty                         |
	| Slot 2018-11-01 - 2020-12-26  |
	| Slot 2018-10-01 to 2018-12-31 |
	When User clicks Settings button for "DAS16275_Dashboard" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @EvergreenJnr_DashboardsPage @DashboardsPage @Dashboards @Widgets @Delete_Newly_Created_List @DAS16380
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageUsingPrivateListForPublicDashboard
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	And User create dynamic list with "First_List_DAS16380" name on "Devices" page
	Then "First_List_DAS16380" list is displayed to user
	When User navigates to the "All Devices" list
	When User click on 'Hostname' column header
	And User create dynamic list with "Second_List_DAS16380" name on "Devices" page
	Then "Second_List_DAS16380" list is displayed to user
	When User clicks "Dashboards" on the left-hand menu
	When User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS16380" name
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List                | MaxRows | MaxColumns |
	| List       | Widget_For_DAS16380 | First_List_DAS16380 | 10      | 10         |
	Then "Widget_For_DAS16380" Widget is displayed to the user
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	When User selects "Everyone can see" permission for "First_List_DAS16380" list on Permissions Pop-up
	And User clicks the "UPDATE & SHARE" Action button
	And User clicks the "ADD WIDGET" Action button
	When User selects "List" in the "Widget Type" Widget dropdown
	And User enters "Widget_For_DAS16380_1" as Widget Title
	And User selects "Second_List_DAS16380" as Widget List
	Then User sees "You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget" warning text below Lists field
	When User clicks Settings button for "Dashboard for DAS16380" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningPopUpDisplayedWhenChangingDashboardPermisson
	#create private list
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841" name on "Devices" page
	Then "DeviceListFor14841" list is displayed to user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841" name
	Then "New dashboard created" message is displayed	
	#add widget
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List               | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841 | DeviceListFor14841 | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#check row data
	And Widget "WidgetForDAS14841" displayed for "DeviceListFor14841" list on Permissions Pop-up
	And Current user displayed for "DeviceListFor14841" list on Permissions Pop-up
	And Current permission "Private" displayed for "DeviceListFor14841" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841" list on Permissions Pop-up
	#the new permissions options
	Then User sees next options of New Permission field for "DeviceListFor14841" list on Permissions Pop-up
	| Options           |
	| Do not change     |
	| Everyone can see  |
	| Everyone can edit |
	#state
	Then Button "UPDATE & SHARE" has enabled property "false" on Permissions Pop-up
	And Button "IGNORE & SHARE" has enabled property "true" on Permissions Pop-up
	And Button "CANCEL" has enabled property "true" on Permissions Pop-up
	#tooltips
	And Button "UPDATE & SHARE" has "Amend widget permissions above" tooltip on Permissions Pop-up
	And Button "IGNORE & SHARE" has "Do not change widget list permissions and share dashboard" tooltip on Permissions Pop-up
	And Button "CANCEL" has "Do not change widget list permissions and do not share dashboard" tooltip on Permissions Pop-up
	#mix
	When User selects "Everyone can see" permission for "DeviceListFor14841" list on Permissions Pop-up
	Then Button "UPDATE & SHARE" has enabled property "true" on Permissions Pop-up
	And Button "UPDATE & SHARE" has "Change widget list permissions and share dashboard" tooltip on Permissions Pop-up
	When User clicks the "CANCEL" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Private" displayed in Dashboard Details
	#teardown
	When User clicks Settings button for "Dashboard for DAS14841" dashboard
	And User clicks Delete button for custom list
	And User clicks Delete button on the warning message in the lists panel

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 
Scenario: EvergreenJnr_DashboardsPage_CheckThatIgnoreAndShareWorksProperlyInWarningPermissionPoup
	#create private list
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_1" name on "Devices" page
	Then "DeviceListFor14841_1" list is displayed to user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841_1" name
	Then "New dashboard created" message is displayed
	#add widget
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_1 | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#act	
	When User selects "Everyone can see" permission for "DeviceListFor14841_1" list on Permissions Pop-up
	And User clicks the "IGNORE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	#teardown
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_1" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Private" sharing option is selected

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 
Scenario: EvergreenJnr_DashboardsPage_CheckThatUpdateAndShareWorksProperlyInWarningPermissionPoup
	#create private list
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName            |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_2" name on "Devices" page
	Then "DeviceListFor14841_2" list is displayed to user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841_2" name
	Then "New dashboard created" message is displayed
	#add widget
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_2 | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#act
	When User selects "Everyone can see" permission for "DeviceListFor14841_2" list on Permissions Pop-up
	And User clicks the "UPDATE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	#teardown
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_2" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Everyone can see" sharing option is selected

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 
Scenario: EvergreenJnr_DashboardsPage_CheckThatUpdateAndShareWorksOnlyForParticularRow
	#create private list#1
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName            |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_3" name on "Devices" page
	Then "DeviceListFor14841_3" list is displayed to user
	#create private list#2
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| OS Architecture |
	And User create dynamic list with "DeviceListFor14841_4" name on "Devices" page
	Then "DeviceListFor14841_4" list is displayed to user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841_3" name
	Then "New dashboard created" message is displayed
	#add widget#1
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_3 | Hostname | Count             | Count DESC |                  |           |
	#add widget#2
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_4 | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#act
	When User selects "Everyone can edit" permission for "DeviceListFor14841_3" list on Permissions Pop-up
	Then Button "UPDATE & SHARE" has enabled property "true" on Permissions Pop-up
	And Button "UPDATE & SHARE" has "Change widget list permissions and share dashboard" tooltip on Permissions Pop-up
	When User clicks the "UPDATE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_3" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Everyone can edit" sharing option is selected
	When User clicks Settings button for "DeviceListFor14841_4" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Private" sharing option is selected

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 @DAS14393
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCantBeChangedForReadOnlySharedList
	When User clicks the Logout button
	And User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create custom list with "DeviceListFor14841_Read" name
	Then "DeviceListFor14841_Read" list is displayed to user
	When User clicks the List Details button
	And User select "Specific users / teams" sharing option
	And User clicks the "ADD USER" Action button
	And User selects the "Automation Admin 10" user for sharing
	And User select "Read" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841_Read" name
	Then "New dashboard created" message is displayed
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List                    | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841_Read | DeviceListFor14841_Read | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	And Widget "WidgetForDAS14841_Read" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And User "Automation Admin 1" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And Current permission "Specific users / teams" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And New Permission dropdown has disabled property "true" for "DeviceListFor14841_Read" list on Permissions Pop-up
	And New Permission dropdown has "You cannot change the permission for this list" tooltip for "DeviceListFor14841_Read" list on Permissions Pop-up

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 @DAS14282
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCanBeChangedForEditSharedList
	When User clicks the Logout button
	And User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create custom list with "DeviceListFor14841_Edit" name
	Then "DeviceListFor14841_Edit" list is displayed to user
	When User clicks the List Details button
	And User select "Specific users / teams" sharing option
	And User clicks the "ADD USER" Action button
	And User selects the "Automation Admin 10" user for sharing
	And User select "Edit" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841_Edit" name
	Then "New dashboard created" message is displayed
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List                    | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841_Edit | DeviceListFor14841_Edit | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	And Widget "WidgetForDAS14841_Edit" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And User "Automation Admin 1" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And Current permission "Specific users / teams" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And New Permission dropdown has disabled property "true" for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And New Permission dropdown has "You cannot change the permission for this list" tooltip for "DeviceListFor14841_Edit" list on Permissions Pop-up

@Evergreen @Dashboards @DashboardsPage @Widgets @Delete_Newly_Created_List @DAS14841 @DAS11120
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCanBeChangedForAdminSharedList
	When User clicks the Logout button
	And User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create custom list with "DeviceListFor14841_Admin" name
	Then "DeviceListFor14841_Admin" list is displayed to user
	When User clicks the List Details button
	And User select "Specific users / teams" sharing option
	And User clicks the "ADD USER" Action button
	And User selects the "Automation Admin 10" user for sharing
	And User select "Admin" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	And User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	#create dashboard
	When User clicks "Dashboards" on the left-hand menu
	And User clicks the "CREATE DASHBOARD" Action button
	And User creates new Dashboard with "Dashboard for DAS14841_Admin" name
	Then "New dashboard created" message is displayed
	When User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                   | List                     | SplitBy  | AggregateFunction | OrderBy    | TableOrientation | MaxValues |
	| Table      | WidgetForDAS14841_Admin | DeviceListFor14841_Admin | Hostname | Count             | Count DESC |                  |           |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	And Widget "WidgetForDAS14841_Admin" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And User "Automation Admin 1" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And Current permission "Specific users / teams" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	When User selects "Everyone can see" permission for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And User clicks the "UPDATE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	#login as user1 and check if list permission changed
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_Admin" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Everyone can see" sharing option is selected
