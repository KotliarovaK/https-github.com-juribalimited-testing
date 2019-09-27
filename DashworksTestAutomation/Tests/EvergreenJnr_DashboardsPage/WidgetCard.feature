Feature: WidgetCard
	Runs tests for Card Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15364 @DAS15316 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingCardWidgetUsedCpuVirtField
When User add following columns using URL to the "Devices" page:
	| ColumnName                 |
	| CPU Virtualisation Capable |
	And User move 'CPU Virtualisation Capable' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "List15364" name on "Devices" page
	Then "List15364" list is displayed to user
	When Dashboard with "Dashboard for DAS15364" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | Type       |
	| Card       | WidgetForDAS15364 | List15364 | First Cell |
	Then Widget Preview is displayed to the user
	And Card widget displayed inside preview pane
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15207 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIsCreatedWhenListIsAnObjectList
	When Dashboard with "Dashboard for DAS15207" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List        | Type      | AggregateBy | AggregateFunction |
	| Card       | WidgetForDAS15207 | All Devices | Aggregate | Hostname    | Count distinct    |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS15207" Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16138 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetValueLeadsToCorrectFilteredPage
	When Dashboard with "Dashboard for DAS16138" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List         | Type      | AggregateBy                          | AggregateFunction | Drilldown |
	| Card       | WidgetForDAS16138 | 1803 Rollout | Aggregate | 1803: Pre-Migration \ Scheduled Date | First             | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS16138" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	And User clicks data in card "WidgetForDAS16138" widget
	Then Save as a new list option is available
	When User selects Save as new list option
	Then "8" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "1803: Pre-Migration \ Scheduled Date is 5 Nov 2018" is displayed in added filter info
	And "Any Device in list 1803 Rollout" is displayed in added filter info

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @DAS15134 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetValuesLeadsToApplicationsListFilteredPage
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               | 
	And User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	And User move 'Compliance' column to 'Application' column
	And User move 'Application' column to 'Vendor' column
	And User clicks on 'Compliance' column header
	And User create custom list with "1803 App Compliance" name
	Then "1803 App Compliance" list is displayed to user
	When Dashboard with "Dashboard for DAS16069_2" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title               | List                | Type      | AggregateFunction | Drilldown |
	| Card       | WidgetForDAS16069_2 | 1803 App Compliance | Aggregate | Count             | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS16069_2" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	And User clicks data in card "WidgetForDAS16069_2" widget
	Then Save as a new list option is available
	And "43" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15355 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatComplianceLayoutCorrectlyDisplayedInWidget
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               | 
	And User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	And User move 'Compliance' column to 'Application' column
	And User move 'Application' column to 'Vendor' column
	And User clicks on 'Compliance' column header
	And User create custom list with "1803 App Compliance" name
	Then "1803 App Compliance" list is displayed to user
	
	When Dashboard with "Dashboard for DAS15355" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page

	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List                | Type       |
	| Card       | WidgetForDAS15355 | 1803 App Compliance | First Cell |
	Then Colour Scheme dropdown is not displayed to the user
	When User selects "Text Only" in the "Layout" Widget dropdown
	Then Text Only is displayed for Card widget on Preview
	And "Red" color is displayed for Card Widget on Preview
	When User clicks the "CREATE" Action button
	
	Then Text Only is displayed for Card widget
	And "Red" color is displayed for Card Widget
	
	When User clicks Ellipsis menu for "WidgetForDAS15355" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget on Preview
	And "Red" color is displayed for Card Widget on Preview
	When User clicks the "UPDATE" Action button
	
	Then "Red" color is displayed for Card Widget
	And Icon and Text is displayed for Card widget
	
	When User clicks Ellipsis menu for "WidgetForDAS15355" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget on Preview
	And "Red" color is displayed for Card Widget on Preview
	When User clicks the "UPDATE" Action button
	
	Then "Red" color is displayed for Card Widget
	And Icon Only is displayed for Card widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15134 @DAS16263 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIncludeSelectionOfEvergreenColours
	When Dashboard with "Dashboard for DAS15134" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List        | Type       |
	| Card       | WidgetForDAS15134 | All Devices | First Cell |
	And User selects "Pink" in the Colour Scheme
	Then Widget Preview is displayed to the user
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS15134" Widget is displayed to the user
	And "Pink" color is displayed for widget
	When User clicks Ellipsis menu for "WidgetForDAS15134" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Amber" in the Colour Scheme
	And User clicks the "UPDATE" Action button
	Then "Amber" color is displayed for widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15722 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetHavingDateColumnsDisplayedCorrectlyOnDashboard
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "ListForDas15722" name on "Devices" page
	And Dashboard with "DashboardForDas15722" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List            | Type      | AggregateBy | AggregateFunction | Drilldown |
	| Card       | WidgetForDAS15722 | ListForDas15722 | Aggregate | Build Date  | First             | Yes       |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console
	When User clicks the "CREATE" Action button
	Then Card "WidgetForDAS15722" Widget is displayed to the user
	And There are no errors in the browser console
	When User clicks Edit mode trigger on Dashboards page
	When User clicks data in card "WidgetForDAS15722" widget
	Then "1" rows are displayed in the agGrid

@Evergreen@EvergreenJnr_DashboardsPage @Widgets @DAS15355 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckComplianceFirstCellIconsForCardWidget
	When User add following columns using URL to the "Applications" page:
	| ColumnName |
	| Compliance |
	And User move 'Compliance' column to 'Application' column
	And User move 'Application' column to 'Vendor' column
	And User clicks the Filters button
	And User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Amber              |
	Then 'All Applications' list should be displayed to the user
	When User create dynamic list with "DAS15355_Applications_List" name on "Applications" page
	Then "DAS15355_Applications_List" list is displayed to user
	When Dashboard with "Dashboard_DAS15355" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List                       | Type       | Layout    |
	| Card       | WidgetForDAS15355 | DAS15355_Applications_List | First Cell | Text Only |
	Then Widget Preview is displayed to the user
	And Text Only is displayed for Card widget on Preview
	And "Amber" color is displayed for Card Widget on Preview
	When User clicks the "CREATE" Action button
	Then Text Only is displayed for Card widget
	
	When User clicks Ellipsis menu for "WidgetForDAS15355" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget on Preview
	And "Amber" color is displayed for Card Widget on Preview
	When User clicks the "UPDATE" Action button
	Then Icon and Text is displayed for Card widget

	When User clicks Ellipsis menu for "WidgetForDAS15355" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget on Preview
	And "Amber" color is displayed for Card Widget on Preview
	When User clicks the "UPDATE" Action button
	Then Icon Only is displayed for Card widget
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15355 @DAS15662 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckReadinessFirstCellIconsForCardWidget
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| 1803: Readiness |
	And User move '1803: Readiness' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	And User clicks on '1803: Readiness' column header
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DAS15355_List" name on "Devices" page
	Then "DAS15355_List" list is displayed to user

	When Dashboard with "Dashboard_DAS15355_1" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title               | List          | Type       | Layout    |
	| Card       | WidgetForDAS15355_1 | DAS15355_List | First Cell | Text Only |
	Then Text Only is displayed for Card widget on Preview
	And "Grey" color is displayed for Card Widget on Preview
	And "Data Label" checkbox is not displayed on the Create Widget page
	When User clicks the "CREATE" Action button
	Then Text Only is displayed for Card widget
	And "Grey" color is displayed for Card Widget
	
	When User clicks Ellipsis menu for "WidgetForDAS15355_1" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget on Preview
	And "Grey" color is displayed for Card Widget on Preview
	When User clicks the "UPDATE" Action button
	Then "Grey" color is displayed for Card Widget
	And Icon and Text is displayed for Card widget

	When User clicks Ellipsis menu for "WidgetForDAS15355_1" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget on Preview
	And "Grey" color is displayed for Card Widget on Preview
	When User clicks the "UPDATE" Action button
	Then "Grey" color is displayed for Card Widget
	And Icon Only is displayed for Card widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16266 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIsDisplayedCorrectlyWithBlankFirstCell
	When User clicks 'Devices' on the left-hand menu
	And User clicks on 'Owner Display Name' column header
	And User move 'Owner Display Name' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DAS16266_List" name on "Devices" page
	Then "DAS16266_List" list is displayed to user
	When Dashboard with "DAS16266_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List          | Type       |
	| Card       | WidgetForDAS16266 | DAS16266_List | First Cell |
	And User clicks the "CREATE" Action button
	Then Widget Preview shows "Empty" as First Cell value

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15914 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellSelected
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User Add And "1803: Pre-Migration \ Ready to Migrate" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Ready              |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| 1803: Pre-Migration \ Ready to Migrate |
	And User move '1803: Pre-Migration \ Ready to Migrate' column to 'Hostname' column
	Then 'All Devices' list should be displayed to the user
	When User move 'Hostname' column to 'Device Type' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor15914" name on "Devices" page
	Then "DeviceListFor15914" list is displayed to user
	When Dashboard with "Dashboard for DAS15914" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS15914 | DeviceListFor15914 | First Cell |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows "READY" as First Cell value

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16127 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenListHasReadinessColumnFirst
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "1803: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| 1803: Readiness |
	And User move '1803: Readiness' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor16127" name on "Devices" page
	Then "DeviceListFor16127" list is displayed to user
	When Dashboard with "Dashboard for DAS16127" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS16127 | DeviceListFor16127 | First Cell |
	Then Widget Preview is displayed to the user
	And Widget Preview shows "GREEN" as First Cell value
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15765 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellIsEmpty
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 001BAQXT6JWFPI |
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| 1803: Pre-Migration \ Scheduled Date |
	And User move '1803: Pre-Migration \ Scheduled Date' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor15765" name on "Devices" page
	Then "DeviceListFor15765" list is displayed to user
	When Dashboard with "Dashboard for DAS15765" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS15765 | DeviceListFor15765 | First Cell |
	Then Widget Preview is displayed to the user
	And Widget Preview shows "Empty" as First Cell value
	And There are no errors in the browser console
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16336 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsInConsoleAfterAddingApplicationReadinessFirstCellWidget
	When User add following columns using URL to the "Applications" page:
	| ColumnName                        |
	| MigrationP: Application Readiness |
	And User move 'MigrationP: Application Readiness' column to 'Application' column
	And User move 'Application' column to 'Vendor' column
	And User clicks on 'MigrationP: Application Readiness' column header
	Then 'All Applications' list should be displayed to the user
	When User create dynamic list with "DAS16336_Applications_List" name on "Applications" page
	Then "DAS16336_Applications_List" list is displayed to user
	When Dashboard with "Dashboard_DAS16336" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List                       | Type       | Layout    |
	| Card       | WidgetForDAS16336 | DAS16336_Applications_List | First Cell | Text Only |
	Then Widget Preview is displayed to the user
	And Text Only is displayed for Card widget on Preview
	And "Really Extremely Orange" color is displayed for Card Widget on Preview
	
	When User clicks the "CREATE" Action button
	Then There are no errors in the browser console
	Then Text Only is displayed for Card widget
	And "Really Extremely Orange" color is displayed for Card Widget

	When User clicks Ellipsis menu for "WidgetForDAS16336" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon Only" in the "Layout" Widget dropdown
	Then Icon Only is displayed for Card widget on Preview
	And "Really Extremely Orange" color is displayed for Card Widget on Preview
	
	When User clicks the "UPDATE" Action button
	Then There are no errors in the browser console
	And Icon Only is displayed for Card widget
	And "Really Extremely Orange" color is displayed for Card Widget
	
	When User clicks Ellipsis menu for "WidgetForDAS16336" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User selects "Icon and Text" in the "Layout" Widget dropdown
	Then Icon and Text is displayed for Card widget on Preview
	And "Really Extremely Orange" color is displayed for Card Widget on Preview
	
	When User clicks the "UPDATE" Action button
	Then There are no errors in the browser console
	And "Really Extremely Orange" color is displayed for Card Widget
	And Icon and Text is displayed for Card widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16325 @DAS15145 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellIsSortedBool
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName     |
	| ICSP: In Scope |
	And User move 'ICSP: In Scope' column to 'Hostname' column
	And User move 'Hostname' column to 'Operating System' column
	And User clicks on 'ICSP: In Scope' column header
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor16325" name on "Devices" page
	Then "DeviceListFor16325" list is displayed to user
	When Dashboard with "Dashboard for DAS16325" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	When User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS16325 | DeviceListFor16325 | First Cell |
	Then Widget Preview is displayed to the user
	And Widget Preview shows "TRUE" as First Cell value
	And There are no errors in the browser console

@Evergreen@EvergreenJnr_DashboardsPage @Widgets @DAS16347 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetCreatingFromListHavingSortedRingColumn
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| Barry'sUse: Ring (Primary Device Only) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	And User clicks on 'Barry'sUse: Ring (Primary Device Only)' column header
	And User clicks on 'Barry'sUse: Ring (Primary Device Only)' column header
	Then data in table is sorted by 'Barry'sUse: Ring (Primary Device Only)' column in descending order
	When User clicks Save button on the list panel
	And User create dynamic list with "List16347" name on "Devices" page
	And Dashboard with "Dashboard_DAS16347" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | Type       |
	| Card       | WidgetForDAS16347 | List16347 | First Cell |
	Then Widget Preview is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15514 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCardSelectingAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Device Key                           |
	| 1803: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	And Dashboard with "All Data Types for DAS15514" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title       | List                 | Type      | AggregateFunction |
	| Card       | Widget Name | ListWithAllDatatypes | Aggregate | <AggFunc>         |
	Then User sees following options for Aggregate By selector on Create Widget page:
	| items                                |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |

Examples: 
	| AggFunc |
	| First   |
	| Last    |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16844 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatArchivedItemsIncludedInCountWhenReferencingDynamicListContainsArchivedItems
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in "true"
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "List16844" name on "Devices" page
	And Dashboard with "Dashboard for DAS16844" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List      | Type      | AggregateFunction |
	| Card       | WidgetForDAS16844 | List16844 | Aggregate | Count             |
	Then "WidgetForDAS16844" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	Then Value '17,427' is displayed in the card 'WidgetForDAS16844' widget
	When User clicks data in card "WidgetForDAS16844" widget
	Then Save as a new list option is available
	And "17,427" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16844 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatArchivedItemsIncludedInCountWhenReferencingStaticListContainsArchivedItems
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in "true"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList16844" name
	And Dashboard with "Dashboard for DAS16844" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List            | Type      | AggregateFunction |
	| Card       | WidgetForDAS16844 | StaticList16844 | Aggregate | Count             |
	Then "WidgetForDAS16844" Widget is displayed to the user
	When User clicks Edit mode trigger on Dashboards page
	Then Value '1' is displayed in the card 'WidgetForDAS16844' widget
	When User clicks data in card "WidgetForDAS16844" widget
	Then "1" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnCardWidgetsIfTheSourceListHasNoRows
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values |
	| ZZZZ   |
	And User clicks Save button on the list panel
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "ListForDAS16167" name on "Devices" page
	Then "ListForDAS16167" list is displayed to user
	When Dashboard with "DAS16167_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List            | Type       |
	| Card       | WidgetForDAS16167 | ListForDAS16167 | First Cell |
	Then Widget Preview is displayed to the user
	And 'This list does not contain any rows' message is displayed in Preview
	When User clicks the "CREATE" Action button
	Then "WidgetForDAS16167" Widget is displayed to the user
	And 'This list does not contain any rows' message is displayed in 'WidgetForDAS16167' widget