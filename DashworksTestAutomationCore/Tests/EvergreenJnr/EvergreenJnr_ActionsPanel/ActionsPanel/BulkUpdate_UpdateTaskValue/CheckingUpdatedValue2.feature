Feature: CheckingUpdatedValue2
	Runs Checking Updated Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS19273
Scenario: EvergreenJnr_UsersList_CheckUpdateRelativeToDifferentTaskValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Stage B \ Original Task |
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
	When User selects 'Stage B \ Original Task' option from 'Task' autocomplete
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	When User selects 'Stage C \ Radio Date Slot Device' option from 'Relative Task' autocomplete
	When User navigate to the bottom of the Action panel
	When User enters '5' text to 'Value' textbox
	When User selects 'days before task value' in the 'DateUnit' dropdown
	And User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button
	And User navigate to the top of the Action panel
	Then 'UPDATE' button is displayed on inline tip banner
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "5 Sep 2019" content is displayed for "zDeviceAut: Stage B \ Original Task" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage B \ Original Task' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '10 Sep 2019' text to 'Date' datepicker
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
	Then "10 Sep 2019" content is displayed for "zDeviceAut: Stage B \ Original Task" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18025 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatDateWithTimeDisplayedAfterUpdateTaskValueForRadiobuttonTask
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS18025 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS18025" Project
	When User navigate to "Stages" tab
	When User clicks "Create Stage" button
	When User create Stage
	| StageName  |
	| Stage18025 |
	When User clicks "Create Stage" button
	When User navigate to "Tasks" tab
	When User clicks "Create Task" button
	When User creates Task
	| Name      | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Task18025 | 18025 | Stage18025       | Normal         | Radiobutton     | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateTime       | None                  | true                 | false       | false         | false      | false       |
	When User publishes the task
	When User navigates to "ProjectForDAS18025" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects        |
	| 00KLL9S8NRF0X6 |
	| 00KWQ4J3WKQM0G |
	When User clicks 'UPDATE ALL CHANGES' button 
	Then '2 devices will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Actions button
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6 |
	| 00KWQ4J3WKQM0G |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'ProjectForDAS18025' option from 'Project' autocomplete
	When User selects 'Stage18025 \ Task18025' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	When User clicks the Filters button
	When User add "ProjectFor: Onboarded" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                |
	| ProjectFor: Stage18025 \ Task18025 (Date) |
	Then date in 'ProjectFor: Stage18025 \ Task18025 (Date)' column displayed in datetime format

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS21251 @Yellow_Dwarf
Scenario: EvergreenJnr_AllDevices_CheckBulkUpdateReadOnlyTaskIsNotAvailableToSelect
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	Then 'Computer Read Only Task in Bulk Update' content is not displayed in 'Task' autocomplete after search