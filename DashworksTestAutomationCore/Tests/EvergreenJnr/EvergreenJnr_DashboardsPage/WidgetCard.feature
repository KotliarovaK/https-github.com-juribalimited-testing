﻿Feature: WidgetCard
	Runs tests for Card Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15364 @DAS15316 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatErrorIsNotOccurredWhenCreatingCardWidgetUsedCpuVirtField
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                 |
	| CPU Virtualisation Capable |
	When User move 'CPU Virtualisation Capable' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	When User create dynamic list with "List15364" name on "Devices" page
	Then "List15364" list is displayed to user
	When Dashboard with 'Dashboard_15364' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List      | Type       |
	| Card       | WidgetForDAS15364 | List15364 | First Cell |
	Then Widget Preview is displayed to the user
	Then Card widget displayed inside preview pane
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15207 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIsCreatedWhenListIsAnObjectList
	When Dashboard with 'Dashboard_15207' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List        | Type      | AggregateBy | AggregateFunction |
	| Card       | WidgetForDAS15207 | All Devices | Aggregate | Hostname    | Count distinct    |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15207' Widget is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16138 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetValueLeadsToCorrectFilteredPage
	When Dashboard with 'Dashboard_16138' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List         | Type      | AggregateBy                          | AggregateFunction | Drilldown |
	| Card       | WidgetForDAS16138 | 2004 Rollout | Aggregate | 2004: Pre-Migration \ Scheduled Date | First             | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16138' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	When User clicks data in card 'WidgetForDAS16138' widget
	Then "8" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "2004: Pre-Migration \ Scheduled Date is 5 Nov 2020" is displayed in added filter info
	Then "Any Device in list 2004 Rollout" is displayed in added filter info

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16069 @DAS15134 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetValuesLeadsToApplicationsListFilteredPage
	When User navigates to "2004 Rollout" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects 'All Applications' in the 'Application Scope' dropdown
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               | 
	When User Add And "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	When User move 'Compliance' column to 'Application' column
	When User move 'Application' column to 'Vendor' column
	When User clicks on 'Compliance' column header
	When User creates '2004 App Compliance' dynamic list
	Then "2004 App Compliance" list is displayed to user
	When Dashboard with 'Dashboard_16069_2' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title               | List                | Type      | AggregateFunction | Drilldown |
	| Card       | WidgetForDAS16069_2 | 2004 App Compliance | Aggregate | Count             | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16069_2' Widget is displayed to the user	
	When User checks 'Edit mode' slide toggle
	When User clicks data in card 'WidgetForDAS16069_2' widget
	Then "44" rows are displayed in the agGrid

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15355 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatComplianceLayoutCorrectlyDisplayedInWidget
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	When User move 'Compliance' column to 'Application' column
	When User move 'Application' column to 'Vendor' column
	When User clicks on 'Compliance' column header
	When User create dynamic list with "2004 App Compliance" name on "Applications" page
	Then "2004 App Compliance" list is displayed to user
	
	When Dashboard with 'Dashboard_15355' name created via API and opened
	When User checks 'Edit mode' slide toggle

	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List                | Type       |
	| Card       | WidgetForDAS15355 | 2004 App Compliance | First Cell |
	Then Widget Preview is displayed to the user
	Then 'Colour Scheme' dropdown is not displayed
	
	When User selects 'Text Only' in the 'Layout' dropdown
	Then Text Only is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	When User clicks 'CREATE' button
	Then 'WidgetForDAS15355' Widget is displayed to the user
	
	Then Text Only is displayed for Card widget
	Then 'Red' color is displayed for Card Widget
	
	When User clicks 'Edit' menu option for 'WidgetForDAS15355' widget
	When User selects 'Icon and Text' in the 'Layout' dropdown
	Then Icon and Text is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS15355' Widget is displayed to the user
	
	Then 'Red' color is displayed for Card Widget
	Then Icon and Text is displayed for Card widget
	
	When User clicks 'Edit' menu option for 'WidgetForDAS15355' widget
	When User selects 'Icon Only' in the 'Layout' dropdown
	Then Icon Only is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button 
	Then 'WidgetForDAS15355' Widget is displayed to the user

	Then 'Red' color is displayed for Card Widget
	Then Icon Only is displayed for Card widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15134 @DAS16263 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIncludeSelectionOfEvergreenColours
	When Dashboard with 'Dashboard_15134' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List        | Type       |
	| Card       | WidgetForDAS15134 | All Devices | First Cell |
	When User selects 'Pink' in the Colour Scheme
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15134' Widget is displayed to the user
	Then 'Pink' color is displayed for Card Widget
	When User clicks 'Edit' menu option for 'WidgetForDAS15134' widget
	When User selects 'Amber' in the Colour Scheme
	When User clicks 'UPDATE' button 
	Then 'Amber' color is displayed for Card Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15722 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetHavingDateColumnsDisplayedCorrectlyOnDashboard
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "ListForDas15722" name on "Devices" page
	When Dashboard with 'Dashboard_15722' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | Type      | AggregateBy | AggregateFunction | Drilldown |
	| Card       | WidgetForDAS15722 | ListForDas15722 | Aggregate | Build Date  | First             | Yes       |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15722' Widget is displayed to the user
	Then There are no errors in the browser console

@Evergreen@EvergreenJnr_DashboardsPage @Widgets @DAS15355 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckComplianceFirstCellIconsForCardWidget
	When User clicks 'Applications' on the left-hand menu
	When User add following columns using URL to the "Applications" page:
	| ColumnName |
	| Compliance |
	When User move 'Compliance' column to 'Application' column
	When User move 'Application' column to 'Vendor' column
	When User clicks the Filters button
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Amber              |
	Then 'All Applications' list should be displayed to the user
	When User create dynamic list with "DAS15355_Applications_List" name on "Applications" page
	Then "DAS15355_Applications_List" list is displayed to user
	When Dashboard with 'Dashboard_15355' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List                       | Type       | Layout    |
	| Card       | WidgetForDAS15355 | DAS15355_Applications_List | First Cell | Text Only |
	Then Widget Preview is displayed to the user
	Then Text Only is displayed for Card widget on Preview
	Then 'Amber' color is displayed for Card Widget on Preview
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS15355' Widget is displayed to the user
	Then Text Only is displayed for Card widget
	
	When User clicks 'Edit' menu option for 'WidgetForDAS15355' widget
	When User selects 'Icon and Text' in the 'Layout' dropdown
	Then Icon and Text is displayed for Card widget on Preview
	Then 'Amber' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS15355' Widget is displayed to the user
	Then Icon and Text is displayed for Card widget
	When User clicks 'Edit' menu option for 'WidgetForDAS15355' widget
	When User selects 'Icon Only' in the 'Layout' dropdown
	Then Icon Only is displayed for Card widget on Preview
	Then 'Amber' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS15355' Widget is displayed to the user
	Then Icon Only is displayed for Card widget
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15355 @DAS15662 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckReadinessFirstCellIconsForCardWidget
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Green          |
	When User move '2004: Readiness' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DAS15355_List" name on "Devices" page
	Then "DAS15355_List" list is displayed to user
	When Dashboard with 'Dashboard_DAS15355_1' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title               | List          | Type       | Layout    |
	| Card       | WidgetForDAS15355_1 | DAS15355_List | First Cell | Text Only |
	Then Text Only is displayed for Card widget on Preview
	Then 'Green' color is displayed for Card Widget on Preview
	Then 'Show data labels' checkbox is not displayed
	When User clicks 'CREATE' button
	Then 'WidgetForDAS15355_1' Widget is displayed to the user
	Then Text Only is displayed for Card widget
	Then 'Green' color is displayed for Card Widget
	
	When User clicks 'Edit' menu option for 'WidgetForDAS15355_1' widget
	When User selects 'Icon and Text' in the 'Layout' dropdown
	Then Icon and Text is displayed for Card widget on Preview
	Then 'Green' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS15355_1' Widget is displayed to the user
	Then 'Green' color is displayed for Card Widget
	Then Icon and Text is displayed for Card widget

	When User clicks 'Edit' menu option for 'WidgetForDAS15355_1' widget
	When User selects 'Icon Only' in the 'Layout' dropdown
	Then Icon Only is displayed for Card widget on Preview
	Then 'Green' color is displayed for Card Widget on Preview
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS15355_1' Widget is displayed to the user
	Then 'Green' color is displayed for Card Widget
	Then Icon Only is displayed for Card widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16266 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetIsDisplayedCorrectlyWithBlankFirstCell
	When User clicks 'Devices' on the left-hand menu
	When User clicks on 'Owner Display Name' column header
	When User move 'Owner Display Name' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DAS16266_List" name on "Devices" page
	Then "DAS16266_List" list is displayed to user
	When Dashboard with 'Dashboard_16266' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List          | Type       |
	| Card       | WidgetForDAS16266 | DAS16266_List | First Cell |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows 'Empty' as First Cell value

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15914 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellSelected
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User Add And "2004: Pre-Migration \ Ready to Migrate" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Ready              |
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| 2004: Pre-Migration \ Ready to Migrate |
	When User move '2004: Pre-Migration \ Ready to Migrate' column to 'Hostname' column
	Then 'All Devices' list should be displayed to the user
	When User move 'Hostname' column to 'Device Type' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor15914" name on "Devices" page
	Then "DeviceListFor15914" list is displayed to user
	When Dashboard with 'Dashboard_15914' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS15914 | DeviceListFor15914 | First Cell |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows 'READY' as First Cell value

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16127 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenListHasReadinessColumnFirst
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: Readiness" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| 2004: Readiness |
	When User move '2004: Readiness' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor16127" name on "Devices" page
	Then "DeviceListFor16127" list is displayed to user
	When Dashboard with 'Dashboard_16127' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS16127 | DeviceListFor16127 | First Cell |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows 'GREEN' as First Cell value
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15765 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellIsEmpty
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 001BAQXT6JWFPI |
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| 2004: Pre-Migration \ Scheduled Date |
	When User move '2004: Pre-Migration \ Scheduled Date' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor15765" name on "Devices" page
	Then "DeviceListFor15765" list is displayed to user
	When Dashboard with 'Dashboard_15765' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS15765 | DeviceListFor15765 | First Cell |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows 'Empty' as First Cell value
	Then There are no errors in the browser console
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16336 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsInConsoleAfterAddingApplicationReadinessFirstCellWidget
	When User clicks 'Applications' on the left-hand menu
	When User add following columns using URL to the "Applications" page:
	| ColumnName                        |
	| Havoc(BigD: Application Readiness |
	When User move 'Havoc(BigD: Application Readiness' column to 'Application' column
	When User move 'Application' column to 'Vendor' column
	When User clicks on 'Havoc(BigD: Application Readiness' column header
	Then 'All Applications' list should be displayed to the user
	When User create dynamic list with "DAS16336_Applications_List" name on "Applications" page
	Then "DAS16336_Applications_List" list is displayed to user
	When Dashboard with 'Dashboard_16336' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List                       | Type       | Layout    |
	| Card       | WidgetForDAS16336 | DAS16336_Applications_List | First Cell | Text Only |
	Then Widget Preview is displayed to the user
	Then Text Only is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	
	When User clicks 'CREATE' button
	Then 'WidgetForDAS16336' Widget is displayed to the user
	Then There are no errors in the browser console
	Then Text Only is displayed for Card widget
	Then 'Red' color is displayed for Card Widget

	When User clicks 'Edit' menu option for 'WidgetForDAS16336' widget
	When User selects 'Icon Only' in the 'Layout' dropdown
	Then Icon Only is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS16336' Widget is displayed to the user
	Then There are no errors in the browser console
	Then Icon Only is displayed for Card widget
	Then 'Red' color is displayed for Card Widget
	
	When User clicks 'Edit' menu option for 'WidgetForDAS16336' widget
	When User selects 'Icon and Text' in the 'Layout' dropdown
	Then Icon and Text is displayed for Card widget on Preview
	Then 'Red' color is displayed for Card Widget on Preview
	
	When User clicks 'UPDATE' button
	Then 'WidgetForDAS16336' Widget is displayed to the user
	Then There are no errors in the browser console
	Then 'Red' color is displayed for Card Widget
	Then Icon and Text is displayed for Card widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16325 @DAS15145 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCardWidgetDisplaysCorrectValueWhenFirstCellIsSortedBool
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName     |
	| 2004: In Scope |
	When User move '2004: In Scope' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	When User clicks on '2004: In Scope' column header
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "DeviceListFor16325" name on "Devices" page
	Then "DeviceListFor16325" list is displayed to user
	When Dashboard with 'Dashboard_16325' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List               | Type       |
	| Card       | WidgetForDAS16325 | DeviceListFor16325 | First Cell |
	Then Widget Preview is displayed to the user
	Then Widget Preview shows 'TRUE' as First Cell value
	Then There are no errors in the browser console

@Evergreen@EvergreenJnr_DashboardsPage @Widgets @DAS16347 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetCreatingFromListHavingSortedRingColumn
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| Barry'sUse: Ring (Primary Device Only) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User removes "Owner Display Name" column by Column panel
	When User clicks on 'Barry'sUse: Ring (Primary Device Only)' column header
	When User clicks on 'Barry'sUse: Ring (Primary Device Only)' column header
	Then data in table is sorted by 'Barry'sUse: Ring (Primary Device Only)' column in descending order
	When User clicks Save button on the list panel
	When User create dynamic list with "List16347" name on "Devices" page
	When Dashboard with 'Dashboard_16347' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List      | Type       |
	| Card       | WidgetForDAS16347 | List16347 | First Cell |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15514 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCardSelectingAggregateFunctionShowsFieldsWithCorrectDatatypeInAggregateByDropdown
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                           |
	| Device Key                           |
	| 2004: In Scope                       |
	| HDD Total Size (GB)                  |
	| First Seen Date                      |
	| Windows7Mi: Communication \ DateTime |
	| Compliance                           |
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "ListWithAllDatatypes" name on "Devices" page
	When Dashboard with 'Dashboard_15514' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
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
	When User sets includes archived devices in 'true'
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "List16844" name on "Devices" page
	When Dashboard with 'Dashboard_16844' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List      | Type      | AggregateFunction |
	| Card       | WidgetForDAS16844 | List16844 | Aggregate | Count             |
	Then 'WidgetForDAS16844' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	Then Value '17,427' is displayed in the card 'WidgetForDAS16844' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16844 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatArchivedItemsIncludedInCountWhenReferencingStaticListContainsArchivedItems
	When User clicks 'Devices' on the left-hand menu
	When User sets includes archived devices in 'true'
	When User click on "Hostname" column header on the Admin page
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList16844" name
	When Dashboard with 'Dashboard_16844' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List            | Type      | AggregateFunction |
	| Card       | WidgetForDAS16844 | StaticList16844 | Aggregate | Count             |
	Then 'WidgetForDAS16844' Widget is displayed to the user
	When User checks 'Edit mode' slide toggle
	Then Value '1' is displayed in the card 'WidgetForDAS16844' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnCardWidgetsIfTheSourceListHasNoRows
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values |
	| ZZZZ   |
	When User clicks Save button on the list panel
	Then 'All Devices' list should be displayed to the user
	When User create dynamic list with "ListForDAS16167" name on "Devices" page
	Then "ListForDAS16167" list is displayed to user
	When Dashboard with 'Dashboard_16167' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            | Type       |
	| Card       | WidgetForDAS16167 | ListForDAS16167 | First Cell |
	Then Widget Preview is displayed to the user
	Then 'This list does not contain any rows' message is displayed in Preview
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16167' Widget is displayed to the user
	Then 'This list does not contain any rows' message is displayed in 'WidgetForDAS16167' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS19015 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorDisplayedInPreviewWhenWidgetBAsedOnStickyComplianceColumn
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| Sticky Compliance |
	Then 'All Applications' list should be displayed to the user
	When User create dynamic list with "ApplicationListFor19015" name on "Applications" page
	Then "ApplicationListFor19015" list is displayed to user
	When Dashboard with 'Dashboard_19015' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List                    | Type      | AggregateFunction | AggregateBy       |
	| Card       | WidgetForDAS16325 | ApplicationListFor19015 | Aggregate | Severity          | Sticky Compliance |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18939 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatFilterAppliesWhenDrilledDownCardWidgetBasedOnSeverity
	When Dashboard with 'Dashboard_18939' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List         | Type      | AggregateFunction | AggregateBy                            | Drilldown |
	| Card       | WidgetForDAS18939 | 2004 Rollout | Aggregate | Severity          | 2004: Pre-Migration \ Ready to Migrate | Yes       |
	Then Widget Preview is displayed to the user
	When User clicks 'CREATE' button
	Then 'WidgetForDAS18939' Widget is displayed to the user
	When User clicks text in card widget
	Then table content is present

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS19115 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorDisplayedWhenCreatingWidgetBasedOnEmptyStage
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "zUserAutom: Stage 1" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User waits for '3' seconds
	When User create dynamic list with "DAS19115_List" name on "Devices" page
	Then "DAS19115_List" list is displayed to user
	When Dashboard with 'Dashboard_19115' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List          | Type      | AggregateFunction | AggregateBy         |
	| Card       | WidgetForDAS19115 | DAS19115_List | Aggregate | Severity          | zUserAutom: Stage 1 |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	Then 'WidgetForDAS19115' Widget is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17715 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckCustomFieldsUsingInFilterAndWidgetCreation
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device ComputerCustomField" filter where type is "Not empty" with following Value and Association:
	| Values | Association        |
	|        | Entitled to device |
	#counter can be updated
	Then "842" rows are displayed in the agGrid
	Then There are no errors in the browser console
	When User create dynamic list with "TestList_DAS17715" name on "Applications" page
	Then "TestList_DAS17715" list is displayed to user
	When Dashboard with 'Dashboard_17715' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List              | Type       |
	| Card       | WidgetForDAS17715 | TestList_DAS17715 | First Cell |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20837 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetPreviewDisplayedIfListContainsSortedCompliance
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Owner Compliance |
	When User clicks on 'Owner Compliance' column header
	When User waits for '3' seconds
	When User move 'Owner Compliance' column to 'Hostname' column
	When User move 'Hostname' column to 'Operating System' column
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'Devices_List_DAS20837' list
	Then "Devices_List_DAS20837" list is displayed to user
	When Dashboard with 'Dashboard_20837' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List                  | Type       |
	| Card       | WidgetForDAS20837 | Devices_List_DAS20837 | First Cell |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	Then 'WidgetForDAS20837' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20368 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleOnCardWidgetAfterChangingRadiobuttonTaskToDropDownList
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "R.testProject" Project
	When User navigate to "Tasks" tab
	When User navigate to "R.NewBrandTasks1" Task
	When User selects 'Radiobutton' as Task Value Type on Details page
	When User clicks "Update" button
	When User navigate to Evergreen link
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                  |
	| R.testProj: R.testStage1 \ R.NewBrandTasks1 |
	Then table content is present
	When User create dynamic list with "DevicesList_20368" name on "Devices" page
	Then "DevicesList_20368" list is displayed to user
	When Dashboard with 'Dashboard_20368' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title            | List              | Type      | AggregateFunction | AggregateBy                                 |
	| Card       | CardWidget_20368 | DevicesList_20368 | Aggregate | Severity          | R.testProj: R.testStage1 \ R.NewBrandTasks1 |
	Then 'CardWidget_20368' Widget is displayed to the user
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "R.testProject" Project
	When User navigate to "Tasks" tab
	When User navigate to "R.NewBrandTasks1" Task
	When User selects 'DropDownList' as Task Value Type on Details page
	When User clicks "Update" button
	When User navigate to Evergreen link
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "DevicesList_20368" list
	When User clicks the Columns button
	When User removes "[Missing Column]" column by Column panel
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                  |
	| R.testProj: R.testStage1 \ R.NewBrandTasks1 |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When Dashboard with 'Dashboard_20368' name is opened via API
	When User checks 'Edit mode' slide toggle
	Then User sees 'This widget refers to a column which is not in the list' text in warning message of 'CardWidget_20368' widget on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17433 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatProjectNameWidgetListCanBeUsedInWidget
	When User clicks 'Mailboxes' on the left-hand menu
	When User clicks the Filters button
	When User add "EmailMigra: Name" filter where type is "Equals" with added column and following value:
	| Values                |
	| hamiltkz@rdlabs.local |
	Then table content is present
	When User create dynamic list with "UsersList_17433" name on "Mailboxes" page
	Then "UsersList_17433" list is displayed to user
	When Dashboard with 'Dashboard_17433' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title        | List            | Type      | AggregateFunction |
	| Card       | Widget_17433 | UsersList_17433 | Aggregate | Count             |
	Then 'Widget_17433' Widget is displayed to the user
	Then Value '1' is displayed in the card 'Widget_17433' widget