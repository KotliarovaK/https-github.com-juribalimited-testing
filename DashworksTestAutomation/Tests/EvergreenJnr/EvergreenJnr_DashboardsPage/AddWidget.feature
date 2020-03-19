Feature: AddWidget
	Runs Widget adding tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14587 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatValidationMessageAppearsWhenSavingWidgetHavingInvalidName
	When Dashboard with 'Dashboard for DAS14587' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Pie        |       | All Devices | Device Type | Hostname    | Count distinct    | Device Type ASC | 10        |
	Then Error message with 'Widget Title should not be empty' text is displayed on Widget page
	And There are no errors in the browser console
	When User creates new Widget
	| WidgetType | Title                  | List        | SplitBy     | AggregateBy | AggregateFunction | OrderBy         |
	| Pie        | Dashboard for DAS14587 | All Devices | Device Type | Hostname    | Count distinct    | Device Type ASC |
	Then 'Dashboard for DAS14587' Widget is displayed to the user
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14578 @DAS14584 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWidgetTitleIsLimitedToOneHundredChars
	When Dashboard with 'Dashboard for DAS14578' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title                                                                                                       | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | TableOrientation | MaxValues |
	| Table      | Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred and seven | All Applications | Application | Application | Count distinct    | Application ASC | Horizontal       | 10        |
	Then 'Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an' Widget is displayed to the user
	Then Widget name 'Line with one hundred and seven chars Line with one hundred and seven chars Line with one hundred an' has word break style on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15900 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningMessageAppearsOnceWhenSwitchingToDashboardWithoutSavingWidgetChanges
	When Dashboard with 'Dashboard for DAS15900' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900 | All Applications | Vendor  | Count             | Count ASC | 10        | true       |
	Then 'WidgetForDAS15900' Widget is displayed to the user
	When User clicks Ellipsis menu for 'WidgetForDAS15900' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User adds new Widget
	| WidgetType | Title                    | List        | SplitBy  | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS15900_Edited | All Devices | Hostname | Count             | Count ASC | 11        | true       |
	When User clicks Show Dashboards panel icon on Dashboards page
	And User clicks first Dashboard in dashboards list
	Then User sees 'You have unsaved changes. Are you sure you want to leave the page?' text in alert on Edit Widget page
	When User clicks 'NO' button in Unsaved Changes alert
	Then Unsaved Changes alert not displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionSelectionIsBeforeTheAggregateBySelection
	When Dashboard with 'Dashboard for DAS15437' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects '<WidgetType>' in the 'WidgetType' dropdown
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
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15437 @DAS14605 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAggregateFunctionOrAggregateByDropdownAreMissingForListWidget
	When Dashboard with 'Dashboard for DAS15437' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	When User selects 'List' in the 'WidgetType' dropdown
	Then 'Aggregate Function' dropdown is missing
	And 'Aggregate By' dropdown is missing
	Then List dropdown has next item categories:
	| item         |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @EvergreenJnr_DashboardsPage @DAS16958 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatEditWidgetPageCanBeOpenedForWidgetHavingDeletedList
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Secure Boot Enabled |
	When User create dynamic list with "List16958" name on "Devices" page
	When Dashboard with 'Dashboard for DAS16958' name created via API and opened
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

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16853 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckCheckboxLabelDisplaying
	When Dashboard with 'DAS16853_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	Then 'Show legend' checkbox has a correct label
	And 'Show data labels' checkbox has a correct label
	When User creates new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS16853 | All Devices | Hostname | Count             | Count ASC | 10        | true       |
	Then 'WidgetForDAS16853' Widget is displayed to the user
	When User clicks Ellipsis menu for 'WidgetForDAS16853' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	Then 'Show legend' checkbox has a correct label
	And 'Show data labels' checkbox has a correct label

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17539 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatThereIsNoPossibilityToCreateWidgetBasedOnStaticListWithMissedColumn
	When Project created via API and opened
	| ProjectName | Scope         | ProjectTemplate | Mode               |
	| MlbxTst     | All Mailboxes | None            | Standalone Project |
	And User clicks 'Projects' on the left-hand menu
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
	And User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User add "17539Snr: Path" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| MailboxPath17539   |
	And User clicks the Actions button
	And User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "TestList_DAS17539" name
	And Projects created by User are removed via API
	And Dashboard with 'Dashboard for DAS17539' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button
	When User adds new Widget
	| WidgetType | Title                 | List              | SplitBy          | AggregateFunction | OrderBy              |
	| Table      | DAS-TestList_DAS17539 | TestList_DAS17539 | Mailbox Platform | Count             | Mailbox Platform ASC |
	Then Widget Preview is displayed to the user
	Then There are no errors in the browser console
	When User clicks 'CREATE' button
	Then User sees 'This widget refers to list TestList_DAS17539 which has errors' text in warning message of 'DAS-TestList_DAS17539' widget on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18151 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDuplicateWidgetsWillNotbeCreatedIfUserClicksFastOnTheCreateButtonSeveralTimes
	When Dashboard with 'DAS18151_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	Then 'Show legend' checkbox has a correct label
	And 'Show data labels' checkbox has a correct label
	When User adds new Widget
	| WidgetType | Title             | List        | SplitBy  | AggregateFunction | OrderBy   | MaxValues | ShowLegend |
	| Pie        | UniqeWidget       | All Devices | Hostname | Count             | Count ASC | 10        | true       |
	And User double clicks 'CREATE' button
	Then 'UniqeWidget' Widget is displayed to the user
	And User sees '1' widgets with 'UniqeWidget' name on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18167 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTheAggregateFunctionAndAggregateByAndOrderFieldsAreEnabledForEditingAndTheWidgetIsDisplayedInThePreviewBlock
	When Dashboard with 'DAS18167_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy  | AggregateFunction   | AggregateBy | OrderBy      | MaxValues |
	| Bar        | WidgetForDAS16853 | 2004 Rollout | Hostname | Count distinct      | Hostname    |Hostname DESC | 10        |
	Then 'WidgetForDAS16853' Widget is displayed to the user
	When  User clicks Ellipsis menu for 'WidgetForDAS16853' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	When User selects 'Count distinct' in the 'AggregateFunction' dropdown
	When User selects 'Hostname' in the 'AggregateBy' dropdown
	Then Widget Preview is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18163 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTheOrderByDropdownIsExpandedWithTheListOfAvailableOptionsForSelecting
	When Dashboard with 'DAS18163_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy  | AggregateFunction   | AggregateBy | OrderBy      | MaxValues |
	| Bar        | WidgetForDAS16853 | 2004 Rollout | Hostname | Count distinct      | Hostname    |Hostname DESC | 10        |
	Then 'WidgetForDAS16853' Widget is displayed to the user
	When User clicks Ellipsis menu for 'WidgetForDAS16853' Widget on Dashboards page
	When User clicks 'Edit' item from Ellipsis menu on Dashboards page
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

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18066 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTheAppropriateFilterWithTheEmptyValueIsApplied
	When Dashboard with 'DAS18167_Dashboard' name created via API and opened
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
	Then Check that filter 'Vendor' with option 'is empty' is added

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16842 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckImageAndTooltipDisplayingForListDropdown
	When Dashboard with 'DAS16842_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
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

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18168 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatAllValuesInTheLegendAndInTheLabelAreDisplayed
    When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| CPU Count  |
	When User create dynamic list with "DAS18168_List" name on "Devices" page
	Then "DAS18168_List" list is displayed to user
	When Dashboard with 'DAS18168_Dashboard' name created via API and opened
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
	| 1            |
	| 2            |
	| 4            |
	| 6            |
	When User clicks 'CREATE' button
	Then 'WidgetForDAS18168' Widget is displayed to the user
	Then There are no errors in the browser console
	Then Data Labels are displayed on the Dashboards page
	Then Data Legends values are displayed in 'WidgetForDAS18168' widget on the Dashboard page
	| LegendsValue |
	| 0            |
	| 1            |
	| 2            |
	| 4            |
	| 6            |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18741 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatRelevantListIsShownAfterTypingAnyCharacters
	When Dashboard with 'DAS18741_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	Then only options having search term 'De' are displayed in 'List' autocomplete

@Evergreen @EvergreenJnr_DashboardsPage @DAS18054 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserProfilePageOpenedWhenUserNavigatesFromUnsavedWidgetPage
	When Dashboard with 'Dashboard for DAS18054' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List        |
	| Bar        | WidgetForDAS18054 | All Devices |
	When User clicks Profile in Account Dropdown
	Then User sees 'You have unsaved changes. Are you sure you want to leave the page?' text in alert on Edit Widget page
	When User clicks 'YES' button in Unsaved Changes alert
	When User waits for '3' seconds
	When User waits for '3' seconds
	Then Profile page is displayed to user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18759 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetCanBeCreatedBasedOnGroupsFilteredList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Group" filter where type is "Equals" without added column and "AU\GAPP-A0121127" Lookup option
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18759_1" name on "Devices" page
	Then "ListForDAS18759_1" list is displayed to user
	When Dashboard with 'DAS18759_Dashboard' name created via API and opened
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
	When Dashboard with 'DAS20170_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List         | SplitBy      | CategorizeBy | AggregateFunction | OrderBy          | ShowLegend |
	| Bar        | WidgetForDAS20170 | 2004 Rollout | 2004: Status | Device Type  | Count             | 2004: Status ASC | true       |
	Then 'WidgetForDAS20170' Widget is displayed to the user
	When User clicks Ellipsis menu for 'WidgetForDAS20170' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title             |
	| Pie        | WidgetForDAS20170 |
	Then 'WidgetForDAS20170' Widget is displayed to the user
	Then Data Legends values are displayed in 'WidgetForDAS20170' widget on the Dashboard page
	| LegendsValue |
	| Migrated     |
	| Offboarded   |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS20412 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserRedirectToDashboardPageAfterEditingDashboardSection
	When Dashboard with 'DashboardForDAS20412' name created via API and opened
	And User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button
	And User creates new Widget
	| WidgetType | Title             | List         | SplitBy      | CategorizeBy | AggregateFunction | OrderBy          | ShowLegend |
	| Bar        | WidgetForDAS20412 | 2004 Rollout | 2004: Status | Device Type  | Count             | 2004: Status ASC | true       |
	And User clicks Ellipsis menu for Section having 'WidgetForDAS20412' Widget on Dashboards page
	And User clicks 'Edit' item from Ellipsis menu on Dashboards page
	And User enters 'titleForDAS20412' text to 'Title' textbox
	And User clicks 'UPDATE' button
	Then 'Section successfully updated' text is displayed on inline success banner
	Then 'WidgetForDAS20412' Widget is displayed to the user