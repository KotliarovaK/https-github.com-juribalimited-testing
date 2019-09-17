Feature: AddWidget
	Runs Widget adding tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14587 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When Dashboard with "Dashboard for DAS14587" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Pie        |       | All Devices | Device Type | Hostname    | Count distinct    | Device Type ASC | 10        |
	Then Error message with "Widget Title should not be empty" text is displayed on Widget page
	And There are no errors in the browser console
	When User creates new Widget
	| WidgetType | Title                  |List        |
	|            | Dashboard for DAS14587 |All Devices |
	Then User sees widget with the next name "Dashboard for DAS14587" on Dashboards page
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14578 @DAS14584 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars
	When Dashboard with "Dashboard for DAS14578" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                                                                                                       | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues |
	| Table      | Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred and seven | All Applications | Application | Application | Count distinct    | Application ASC | Horizontal       | 10        |
	Then User sees widget with the next name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" on Dashboards page
	And Widget name "Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an" has word break style on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15900 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningMessageAppearsOnceWhenSwitchingToDashboardWithoutSavingWidgetChanges
	When Dashboard with "Dashboard for DAS15900" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900 | All Applications | Vendor  | Count             | Count ASC | 10        | true       |
	And User clicks Ellipsis menu for "WidgetForDAS15900" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User adds new Widget
	| WidgetType | Title                    | List        | SplitBy  | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900_Edited | All Devices | Hostname | Count             | Count ASC | 11        | true       |
	When User clicks Show Dashboards panel icon on Dashboards page
	And User clicks first Dashboard in dashboards list
	Then User sees "You have unsaved changes. Are you sure you want to leave the page?" text in alert on Edit Widget page
	When User clicks "NO" button in Unsaved Changes alert
	Then Unsaved Changes alert not displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionSelectionIsBeforeTheAggregateBySelection
	When Dashboard with "Dashboard for DAS15437" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "<WidgetType>" in the "Widget Type" Widget dropdown
	Then Aggregate Function dropdown is placed above the Aggregate By dropdown

Examples: 
	| WidgetType |
	| Pie        |
	| Bar        |
	| Column     |
	| Line       |
	| Donut      |
	| Half donut |
	| Table      |
	| Card       |
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionOrAggregateByDropdownAreMissingForListWidget
	When Dashboard with "Dashboard for DAS15437" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User selects "List" in the "Widget Type" Widget dropdown
	Then "Aggregate Function" dropdown is missing
	And "Aggregate By" dropdown is missing

@Evergreen @EvergreenJnr_DashboardsPage @DAS16958 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatEditWidgetPageCanBeOpenedForWidgetHavingDeletedList
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	And User create dynamic list with "List16958" name on "Devices" page
	And Dashboard with "Dashboard for DAS16958" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title             | List      | SplitBy             | AggregateBy | AggregateFunction | OrderBy                 | MaxValues | ShowLegend |
	| Bar        | WidgetForDAS16958 | List16958 | Secure Boot Enabled | Device Type | Count distinct    | Secure Boot Enabled ASC | 10        | true       |
	And User clicks the "CREATE" Action button
	And Dashboard page loaded
	And User lists were removed by API
	And User clicks refresh button in the browser
	And Dashboard page loaded
	And User clicks Edit mode trigger on Dashboards page
	And User clicks edit option for broken widget on Dashboards page
	Then Message saying that list is unavailable appears in Edit Widget page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16853 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckCheckboxLabelDisplaying
	When Dashboard with "DAS16853_Dashboard" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	Then "Show legend" checkbox has a correct label
	And "Show data labels" checkbox has a correct label
	When User creates new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS16853 | All Devices | Hostname | Count             | Count ASC | 10        | true       |
	When User clicks Ellipsis menu for "WidgetForDAS16853" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	Then "Show legend" checkbox has a correct label
	And "Show data labels" checkbox has a correct label

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17539 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatThereIsNoPossibilityToCreateWidgetBasedOnStaticListWithMissedColumn
	When Project created via API and opened
	| ProjectName | Scope         | ProjectTemplate | Mode               |
	| MlbxTst     | All Mailboxes | None            | Standalone Project |
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "MlbxTst" Project
	Then Project with "MlbxTst" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User updates Project Short Name to "17539Snr" on Senior
	And User clicks "Update" button
	And User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name             | Description | ObjectTypeString |
	| MailboxPath17539 | DAS17539    | Mailbox          |
	And User navigate to Evergreen link
	And User clicks "Mailboxes" on the left-hand menu
	And User clicks the Filters button
	And User add "17539Snr: Path" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| MailboxPath17539 |
	And User clicks the Actions button
	And User select "Email Address" rows in the grid
	| SelectedRowsName |
	| 000F977AC8824FE39B8@bclabs.local   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "TestList_DAS17539" name
	And Projects created by User are removed via API
	And Dashboard with "Dashboard for DAS17539" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User adds new Widget
	| WidgetType | Title                 | List              | SplitBy          | AggregateFunction | OrderBy              |
	| Table      | DAS-TestList_DAS17539 | TestList_DAS17539 | Mailbox Platform | Count             | Mailbox Platform ASC |
	Then Widget Preview is displayed to the user
	And 'This widget refers to a list which has errors' alert is displayed in Preview