Feature: CheckingUpdatedValue1
	Runs Checking Updated Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @DAS20889
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithBeforeCurrentValueUpdateDate
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Relative BU \ DT BU Dev |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU \ DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	When User selects 'days before current value' in the 'Units' dropdown
	And User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "14 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU \ DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	When User selects 'days after current value' in the 'Units' dropdown
	And User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "15 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithNoChangeUpdateValue
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                |
	| zUserAutom: Relative BU \ DT BU Us (Date) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 2176236000044A2CA08 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Us' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	When User refreshes agGrid
	#Then '16 Oct 2019' content is displayed in the 'zUserAutom: Relative BU \ DT BU Us (Date)' column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Us' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	#Then '16 Oct 2019' content is displayed in the 'zUserAutom: Relative BU \ DT BU Us (Date)' column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithAfterCurrentValueUpdate
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zMailboxAu: Relative BU \ DT BU Users (Date) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 06C02CDC00044A7DB59 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Users' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "" content is displayed for "zMailboxAu: Relative BU \ DT BU Users (Date)" column

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @DAS13259 @DAS13260 @DAS13263 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExist
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<ColumnHeader>' column header
	When User create dynamic list with "DynamicList12946" name on "<PageName>" page
	Then "DynamicList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	Then following Values are displayed in the 'Action' dropdown:
	| Value              |
	| Create static list |
	| Bulk update        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then 'UPDATE' button is disabled
	And 'CANCEL' button is not disabled
	When User selects '<ProjectName>' option from 'Project' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
	And User selects '<Value>' in the 'Value' dropdown
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "0 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	Then There are no errors in the browser console

Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName              | TaskName                              | Value                    |
	| Devices      | Hostname      | 001PSUMZYOW581                   | User Scheduled Test (Jo) | Two \ Radio Non Rag only Comp         | Not Applicable           |
	| Users        | Username      | 003F5D8E1A844B1FAA5              | User Scheduled Test (Jo) | Two \ Radio Non Rag only User         | Not Applicable           |
	| Applications | Application   | 7zip                             | User Scheduled Test (Jo) | Two \ Radio Non Rag only App          | Not Applicable           |
	| Mailboxes    | Email Address | 00BDBAEA57334C7C8F4@bclabs.local | Email Migration          | Mobile Devices \ Mobile Device Status | Identified & In Progress |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13293 @DAS13359 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOfThousandsOfRowsUpdateToSuccessfulBannerMessage
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Havoc (Big Data)" Project
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName        |
	| Stage DAS12864_0 |
	When User clicks "Create Stage" button
	When User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name            | Help       | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Task DAS12864_0 | DAS12864_0 | Stage DAS12864_0 | Normal         | Radiobutton     | User             |                          | true               |
	When User publishes the task
	Then selected task was published
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                     |
	| Havoc(BigD: Stage DAS12864_0 \ Task DAS12864_0 |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Havoc(BigD: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Havoc(BigD: In Scope" filter is added to the list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Havoc (Big Data)' option from 'Project' autocomplete
	And User selects 'Stage DAS12864_0 \ Task DAS12864_0' option from 'Task' autocomplete
	And User selects 'Started' in the 'Value' dropdown
	And User clicks 'UPDATE' button 
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then inline success banner is displayed
	#wait for the process to complete
	When User waits for '3' seconds
	When User refreshes agGrid
	When User closes Actions panel
	Then 'Havoc(BigD: Stage DAS12864_0 \ Task DAS12864_0' column contains following content
	| Content |
	| STARTED |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18269 @DAS18245 @Not_Ready
#Waiting for 'Update relative to now'
Scenario: EvergreenJnr_UsersList_CheckRelativeUpdatesToTaskValues
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Relative BU \ DT BU App |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Begins with" with added column and following value:
	| Values |
	| boot   |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU App' option from 'Task' autocomplete
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	When User enters '5' text to 'Value' textbox
	When User selects 'After now' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button 
	Then inline warning banner is displayed
	Then 'UPDATE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with " " text is displayed on Action panel
	When User refreshes agGrid
	Then "+5 days from current" content is displayed for "zDeviceAut: Relative BU \ DT BU App" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19656
Scenario: EvergreenJnr_UsersList_CheckUnitsDropDownUpdateTaskValueForBulkUpdate
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| zDeviceAut: Stage A \ Weekdays BU Task |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage A \ Weekdays BU Task' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '5' text to 'Value' textbox
	When User selects 'weekdays before current value' in the 'Units' dropdown
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "10 Feb 2020" content is displayed for "zDeviceAut: Stage A \ Weekdays BU Task" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage A \ Weekdays BU Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '17 Feb 2020' text to 'Date' datepicker
	And User clicks datepicker icon 
	And User selects '18' day in the Datepicker
	#Added wait as we need some time fo datepicker to be updated
	And User waits for '3' seconds
	And User clicks datepicker icon
	And User selects '17' day in the Datepicker
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "17 Feb 2020" content is displayed for "zDeviceAut: Stage A \ Weekdays BU Task" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19274
Scenario: EvergreenJnr_UsersList_CheckUpdateRelativeToNowValueForBulkUpdate
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                             |
	| zDeviceAut: Stage A \ Weekdays BU Task |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 0QJU500MO3M620 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage A \ Weekdays BU Task' option from 'Task' autocomplete
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	When User enters '0' text to 'Value' textbox
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then current date is displayed for 'zDeviceAut: Stage A \ Weekdays BU Task' column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage A \ Weekdays BU Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '10 Feb 2020' text to 'Date' datepicker
	And User clicks datepicker icon 
	And User selects '11' day in the Datepicker
	#Added wait as we need some time fo datepicker to be updated
	And User waits for '3' seconds
	And User clicks datepicker icon
	And User selects '10' day in the Datepicker
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "10 Feb 2020" content is displayed for "zDeviceAut: Stage A \ Weekdays BU Task" column