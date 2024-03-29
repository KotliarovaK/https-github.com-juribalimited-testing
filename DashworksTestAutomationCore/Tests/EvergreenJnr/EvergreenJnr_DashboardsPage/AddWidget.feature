﻿Feature: AddWidget
	Runs Widget adding tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14587 @DAS14578 @DAS14584 @DAS18151 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When Dashboard with 'Dashboard_14587' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Pie        |       | All Devices | Device Type | Hostname    | Count distinct    | Device Type ASC | 10        |
	Then 'Widget Title should not be empty' text is displayed on inline error banner
	Then There are no errors in the browser console
	When User enters 'Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an' text to 'Title' textbox
	When User double clicks 'CREATE' button
	Then Widget name 'Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an' has word break style on Dashboards page
	Then User sees '1' widgets with 'Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an' name on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20412 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserRedirectToDashboardPageAfterEditingDashboardSection
	When Dashboard with 'Dashboard_20412' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy      | CategorizeBy | AggregateFunction | OrderBy          | ShowLegend |
	| Bar        | WidgetForDAS20412 | 2004 Rollout | 2004: Status | Device Type  | Count             | 2004: Status ASC | true       |
	When User clicks 'Edit' menu option for section with 'WidgetForDAS20412' widget
	When User enters 'titleForDAS20412' text to 'Title' textbox
	When User clicks 'UPDATE' button
	Then 'Section successfully updated' text is displayed on inline success banner
	Then 'WidgetForDAS20412' Widget is displayed to the user
		 
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @DAS16853 @DAS18741 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionSelectionIsPlacedBeforeTheAggregateBySelection
	When Dashboard with 'Dashboard_15437' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Pie' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'Bar' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'Column' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'Line' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'Donut' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'Table' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'Card' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown
	When User selects 'List' in the 'WidgetType' dropdown
	Then 'Aggregate Function' dropdown is not displayed
	Then 'Aggregate By' dropdown is not displayed
	When User selects 'Pie' in the 'WidgetType' dropdown
	Then 'Show legend' checkbox has a correct label
	Then 'Show data labels' checkbox has a correct label
	Then only options having search term 'De' are displayed in 'List' autocomplete

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16842 @DAS14605 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckImageAndTooltipDisplayingForListDropdown
	When Dashboard with 'Dashboard_16842' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	Then List dropdown has next item categories:
	| item         |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |
	Then All items in the 'List' autocomplete have icons
	Then All icon items in the 'List' autocomplete have any of tooltip
	| tooltip |
	| System  |
	| Private |
	| Shared  |
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy  | AggregateFunction   | AggregateBy | OrderBy      |
	| Bar        | WidgetForDAS16842 | 2004 Rollout | Hostname | Count distinct      | Hostname    |Hostname DESC |
	Then 'WidgetForDAS16842' Widget is displayed to the user
	When User clicks the Dashboard Details button
	When User expands the list of shared lists
	Then User sees list icon displayed for 'WidgetForDAS16842' widget in List section of Dashboards Details
	Then User sees list icon displayed with tooltip for 'WidgetForDAS16842' widget in List section of Dashboards Details

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18163 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTheOrderByDropdownIsExpandedWithTheListOfAvailableOptionsForSelecting
	When Dashboard with 'Dashboard_18163' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy  | AggregateFunction   | AggregateBy | OrderBy      | MaxValues |
	| Bar        | WidgetForDAS16853 | 2004 Rollout | Hostname | Count distinct      | Hostname    |Hostname DESC | 10        |
	Then 'WidgetForDAS16853' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'WidgetForDAS16853' widget
	Then following Values are displayed in the 'OrderBy' dropdown:
    | Dropdowns                    |
    | Hostname ASC                 |
    | Hostname DESC                |
    | Hostname Count distinct ASC  |
    | Hostname Count distinct DESC |
	When User selects 'Hostname ASC' in the 'OrderBy' dropdown
	Then 'Hostname ASC' content is displayed in 'OrderBy' dropdown
	When User selects 'Hostname DESC' in the 'OrderBy' dropdown
	Then 'Hostname DESC' content is displayed in 'OrderBy' dropdown
	When User selects 'Hostname Count distinct ASC' in the 'OrderBy' dropdown
	Then 'Hostname Count distinct ASC' content is displayed in 'OrderBy' dropdown
	When User selects 'Hostname DESC' in the 'OrderBy' dropdown
	Then 'Hostname DESC' content is displayed in 'OrderBy' dropdown

@Evergreen @EvergreenJnr_DashboardsPage @DAS16958 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatEditWidgetPageCanBeOpenedForWidgetHavingDeletedList
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	When User create dynamic list with "List16958" name on "Devices" page
	When Dashboard with 'Dashboard_16958' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS16958 | List16958 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC | 10        | true       |
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16958' Widget is displayed to the user
	When User lists were removed by API
	When User clicks refresh button in the browser
	When Dashboard page loaded
	When User checks 'Edit mode' slide toggle
	When User clicks edit option for broken widget on Dashboards page
	Then Message saying that list is unavailable appears in Edit Widget page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17539 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatThereIsNoPossibilityToCreateWidgetBasedOnStaticListWithMissedColumn
	When Project created via API and opened
	| ProjectName | Scope         | ProjectTemplate | Mode               |
	| MlbxTst     | All Mailboxes | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "MlbxTst" Project
	Then Project with "MlbxTst" name is displayed correctly
	Then "Manage Project Details" page is displayed to the user
	When User updates Project Short Name to "17539Snr" on Senior
	When User clicks "Update" button
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name             | Description | ObjectTypeString |
	| MailboxPath17539 | DAS17539    | Mailbox          |
	When User navigate to Evergreen link
	When User clicks 'Mailboxes' on the left-hand menu
	When User clicks the Filters button
	When User add "17539Snr: Path" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| MailboxPath17539   |
	When User clicks the Actions button
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "TestList_DAS17539" name
	When Dashboard with 'Dashboard_17539' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User adds new Widget
	| WidgetType | Title                 | List              | SplitBy          | AggregateFunction | OrderBy              |
	| Table      | DAS-TestList_DAS17539 | TestList_DAS17539 | Mailbox Platform | Count             | Mailbox Platform ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	When Projects created by User are removed via API
	When User clicks refresh button in the browser
	When User checks 'Edit mode' slide toggle
	Then User sees 'This widget refers to list TestList_DAS17539 which has errors' text in warning message of 'DAS-TestList_DAS17539' widget on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18167 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTheAggregateFunctionAndAggregateByAndOrderFieldsAreEnabledForEditingAndTheWidgetIsDisplayedInThePreviewBlock
	When Dashboard with 'Dashboard_18167' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy  | AggregateFunction   | AggregateBy | OrderBy      | MaxValues |
	| Bar        | WidgetForDAS16853 | 2004 Rollout | Hostname | Count distinct      | Hostname    |Hostname DESC | 10        |
	Then 'WidgetForDAS16853' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'WidgetForDAS16853' widget
	When User selects 'Count distinct' in the 'AggregateFunction' dropdown
	When User selects 'Hostname' in the 'AggregateBy' dropdown
	Then Widget Preview is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18168 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAllValuesInTheLegendAndInTheLabelAreDisplayed
    When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "CPU Count" filter where type is "Equals" with added column and following value:
	| Values |
	| 0      |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'DAS18168_List' list
	Then "DAS18168_List" list is displayed to user
	When Dashboard with 'Dashboard_18168' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User adds new Widget
    | WidgetType | Title             | List          | SplitBy   | AggregateBy | AggregateFunction | OrderBy       | MaxValues | ShowLegend | ShowDataLabels |
    | Pie        | WidgetForDAS18168 | DAS18168_List | CPU Count | Hostname    | Count distinct    | CPU Count ASC | 5         | true       | true           |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	Then Data Labels are displayed on the Preview page
	Then Data Legends values are displayed on the Add Widget page
	| LegendsValue |
	| 0            |
	When User clicks 'CREATE' button
	Then 'WidgetForDAS18168' Widget is displayed to the user
	Then There are no errors in the browser console
	Then Data Labels are displayed on the Dashboards page
	Then Data Legends values are displayed in 'WidgetForDAS18168' widget on the Dashboard page
	| LegendsValue |
	| 0            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18759 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetCanBeCreatedBasedOnGroupsFilteredList
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Group" filter where type is "Equals" without added column and "AU\GAPP-A0121127" Lookup option
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'ListForDAS18759_1' list
	Then "ListForDAS18759_1" list is displayed to user
	When Dashboard with 'Dashboard_18759' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title               | List              | SplitBy  | AggregateFunction | AggregateBy | OrderBy       |
	| Bar        | WidgetForDAS18759_1 | ListForDAS18759_1 | Hostname | Count distinct    | Hostname    | Hostname DESC |
	Then 'WidgetForDAS18759_1' Widget is displayed to the user
	When User clicks the Dashboard Details button
	When User expands the list of shared lists
	Then User sees list icon displayed for 'WidgetForDAS18759_1' widget in List section of Dashboards Details

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20170 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetLegendsNotDuplicatedAfterChangingWidgetType
	When Dashboard with 'Dashboard_20170' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy      | CategorizeBy | AggregateFunction | OrderBy          | ShowLegend |
	| Bar        | WidgetForDAS20170 | 2004 Rollout | 2004: Status | Device Type  | Count             | 2004: Status ASC | true       |
	Then 'WidgetForDAS20170' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'WidgetForDAS20170' widget
	When User updates Widget with following info:
	| WidgetType | Title             |
	| Pie        | WidgetForDAS20170 |
	Then 'WidgetForDAS20170' Widget is displayed to the user
	Then 'WidgetForDAS20170' Widget has no duplicates in Data Legends

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15900 @DAS18054 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningMessageAppearsOnceWhenSwitchingToDashboardWithoutSavingWidgetChanges
	When Dashboard with 'Dashboard_15900' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900 | All Applications | Vendor  | Count             | Count ASC | 10        | true       |
	Then 'WidgetForDAS15900' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'WidgetForDAS15900' widget
	When User adds new Widget
	| WidgetType | Title                    | List        | SplitBy  | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900_Edited | All Devices | Hostname | Count             | Count ASC | 11        | true       |
	When User clicks Profile in Account Dropdown
	Then popup is displayed to User
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup
	When User clicks 'NO' button 
	Then popup is not displayed to User
	When User clicks Profile in Account Dropdown
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup
	When User clicks 'YES' button
	When User waits for '6' seconds
	Then Profile page is displayed to user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16326 @DAS17150 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckErrorTextAndLinkOnTheWarningMessage
	When Dashboard with 'Dashboard_16326' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title               | List                                 | MaxRows | MaxColumns |
	| List       | Widget_For_DAS16326 | Mailbox List (Complex) - BROKEN LIST | 10      | 10         |
	Then 'This widget refers to a list which has errors' message is displayed for 'List' field

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18634 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorDisplayedWhenSlectingWidgetTypeValue
	When Dashboard with 'Dashboard_18634' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Card' in the 'WidgetType' dropdown
	Then There are no errors in the browser console
	When User selects 'List' in the 'WidgetType' dropdown
	Then There are no errors in the browser console

#waiting for X-Ray updates with filter fixes
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18066 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DashboardsPage_CheckThatTheAppropriateFilterWithTheEmptyValueIsApplied
	When Dashboard with 'Dashboard_18167' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy    | DrillDown | ShowLegend |
	| Pie        | WidgetForDAS18066 | All Applications | Vendor  | Count             | Count DESC | Yes       | true       |
	Then 'WidgetForDAS18066' Widget is displayed to the user
	When User clicks on 'Empty' category of 'WidgetForDAS18066' widget
	Then all cells in the 'Vendor' column are empty
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	#is empty label is missing
	Then Check that filter 'Vendor' with option 'is empty' is added

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15500 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatWhenEditingPieWidgetAggregateFunctionSelectionIsBeforeAggregateBySelection
	When Dashboard with 'Dashboard_15500' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title           | List        | SplitBy  | AggregateFunction | OrderBy      | MaxValues |
	| Pie        | Widget_DAS15500 | All Devices | Hostname | Count             | Hostname ASC | 5         |
	Then 'Widget_DAS15500' Widget is displayed to the user
	When User clicks 'Edit' menu option for 'Widget_DAS15500' widget
	When User selects '<WidgetType>' in the 'WidgetType' dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown

Examples: 
	| WidgetType |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18072 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOrderByFilterChangedInUiPartAfterSelectingAnotherFilter
	When Dashboard with 'Dashboard_18072' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title       | List        | SplitBy     | AggregateFunction | OrderBy          |
	| Pie        | Widget18072 | All Devices | Device Type | Count             | Device Type ASC  |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	Then 'Device Type ASC' option displayed for Widget OrderBy
	When User selects 'Device Type DESC' in the 'Order By' dropdown
	Then 'Device Type DESC' option displayed for Widget OrderBy
	When User selects 'Hostname' in the 'SplitBy' dropdown
	Then 'Hostname DESC' option displayed for Widget OrderBy
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Hostname ASC' in the 'Order By' dropdown
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User selects 'Device Type' in the 'SplitBy' dropdown
	Then 'Device Type ASC' option displayed for Widget OrderBy