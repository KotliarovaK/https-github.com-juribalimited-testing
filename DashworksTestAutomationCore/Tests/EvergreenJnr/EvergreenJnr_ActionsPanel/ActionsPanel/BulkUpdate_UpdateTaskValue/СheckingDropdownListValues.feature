Feature: СheckingDropdownListValues
	Runs Checking Dropdown List Values related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13355 @DAS13260 @DAS13281
Scenario Outline: EvergreenJnr_AllLists_ChecksThatTextValueHaveOptionToRemoveExistingTextValue
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'One \ <TaskName>' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Value  |
	| Update |
	| Remove |

Examples:
	| PageName     | ColumnName  | RowName                          | TaskName                        |
	| Devices      | Hostname    | 01BQIYGGUW5PRP6                  | Text Computer                   |
	| Users        | Username    | 00DB4000EDD84951993              | Text User- Email Address        |
	| Applications | Application | 32VerSee v.231 en (C:\32VerSee\) | Text Application- Future Groups |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13386
Scenario: EvergreenJnr_DevicesList_CheckThatBulkUpdateOfTasksDoesNotIncludeUnpublishedTasks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	When User enters 'Pre-Migration' text in 'Task' Search field
	Then only below options are displayed in the 'Task' autocomplete
	| Options                                |
	| Pre-Migration \ Forecast Date          |
	| Pre-Migration \ Forecast Code          |
	| Pre-Migration \ Target Date            |
	| Pre-Migration \ Scheduled Date         |
	| Pre-Migration \ Laptop Only Task       |
	| Pre-Migration \ Physical Only Task     |
	| Pre-Migration \ VDI Only Task          |
	| Pre-Migration \ Laptop & Physical Task |
	| Pre-Migration \ Target Code            |
	| Pre-Migration \ Scheduled Code         |
	| Pre-Migration \ Further Information    |
	| Pre-Migration \ Targeting Information  |
	| Pre-Migration \ Laptop & Workstation 2 |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13386 @DAS13477
Scenario: EvergreenJnr_UsersList_CheckThatBulkUpdateOfTasksDoesNotIncludeGroupTasks
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 003F5D8E1A844B1FAA5 |
	| 00A5B910A1004CF5AC4 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'User Scheduled Test (Jo)' option from 'Project' autocomplete
	When User enters 'One' text in 'Task' Search field
	Then 'Task' autocomplete contains following options:
	| Options                                      |
	| One \ Radio Rag only User                    |
	| One \ Radio Rag Date User                    |
	| One \ Radio Rag Date Owner User              |
	| One \ Text User                              |
	| One \ Radio Rag Only User Req A              |
	| One \ Radio Rag Date User Req A              |
	| One \ Radio Rag Date Owner User Req A        |
	| One \ Radio Rag only User Req B              |
	| One \ Radio Rag Date User Req B              |
	| One \ Radio Rag Date Owner User Req B        |
	| One \ Radio Rag Date Owner Req B             |
	| One \ SS Department and Location Enabled     |
	When User enters 'Two' text in 'Task' Search field
	Then 'Task' autocomplete contains following options:
	| Options                                      |
	| Two \ Radio Non Rag only User                |
	| Two \ Radio Non Rag Date User                |
	| Two \ Radio Non Rag Date Owner User          |
	| Two \ Radio Non Rag only User Req A          |
	| Two \ Radio Non Rag Date User Req A          |
	| Two \ Radio Non Rag Date Owner User Req A    |
	| Two \ Radio Non Rag only User Req B          |
	| Two \ Radio Non Rag Date User Req B          |
	| Two \ Radio Non Rag Date Owner Req B         |
	When User enters 'Three' text in 'Task' Search field
	Then 'Task' autocomplete contains following options:
	| Options                                      |
	| Three \ Date User                            |
	| Three \ Date User Req A                      |
	| Three \ Text User Req A                      |
	| Three \ Date User Req B                      |
	| Three \ Text User Req B                      |
	| Three \ SS Enabled                           |
	| Three \ SS Computer Ownership Enabled        |
	| Three \ SS Applications List Enabled         |
	| Three \ SS Project Date Enabled              |
	| Three \ SS Other Options Enabled             |
	| Three \ SS Computer Ownership Complete       |
	| Three \ SS Application List Completed        |
	| Three \ SS Department and Location Completed |
	| Three \ SS Other Options Completed           |
	| Three \ SS Project Date Completed            |
	| Three \ Forecast Date                        |
	| Three \ Target Date                          |
	| Three \ Scheduled Date                       |
	| Three \ Migrated Date                        |
	| Three \ Completed Date                       |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15291 @DAS18368 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots
Scenario: EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlot
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Pre-Migration \ Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '23 Nov 2020' text to 'Date' datepicker
	Then following Values are displayed in the 'Slot' dropdown:
	| Options                      |
	| None                         |
	| Birmingham Morning           |
	| Birmingham Afternoon         |
	| Manchester Morning           |
	| Manchester Afternoon         |
	| London - City Morning        |
	| London - City Afternoon      |
	| London - Southbank Morning   |
	| London - Southbank Afternoon |
	| London Depot 09:00 - 11:00   |
	| London Depot 11:00 - 13:00   |
	| London Depot 13:00 - 15:00   |
	| London Depot 15:00 - 17:00   |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS17103
Scenario: EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdate
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Pre-Migration \ Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '6 Nov 2020' text to 'Date' datepicker
	And User clicks datepicker icon
	And User selects '6' day in the Datepicker
	#Added wait as we need some time fo datepicker to be updated
	And User waits for '3' seconds
	And User clicks datepicker icon
	Then '5' day is displayed green in the Datepicker
	And Datepicker has tooltip with '8' rows for '5' day
	When User selects '5' day in the Datepicker
	Then User sees that 'Capacity Slot' dropdown contains following options:
	| Options                    |
	| Birmingham Morning         |
	| Manchester Morning         |
	| London - City Morning      |
	| London - Southbank Morning |
	| London Depot 09:00 - 11:00 |
	| London Depot 11:00 - 13:00 |
	| London Depot 13:00 - 15:00 |
	| London Depot 15:00 - 17:00 |
	Then following Values are not displayed in the 'Capacity Slot' dropdown:
	| Options              |
	| Manchester Afternoon |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS17580 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePicker
	When User creates new Slot via Api
	| Project                         | SlotName | DisplayName | CapacityType   | ObjectType | Sunday | Tasks                    |
	| User Evergreen Capacity Project | slot1    | slot 1      | Capacity Units | User       | 0      | Stage 2 \ Scheduled Date |
	| User Evergreen Capacity Project | slot2    | slot 2      | Capacity Units | User       | 5      | Stage 2 \ Scheduled Date |
	| User Evergreen Capacity Project | slot3    | slot 3      | Capacity Units | User       |        | Stage 2 \ Scheduled Date |
	And User clicks 'Users' on the left-hand menu
	And User clicks the Actions button
	And User select "Display Name" rows in the grid
	| SelectedRowsName                   |
	| Exchange Online-ApplicationAccount |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Stage 2 \ Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User clicks datepicker icon 
	Then All 'Sunday' days are green in the Datepicker

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @Capacity @Slots @DAS17833 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatFullSlotIsDisplayedWhileRulesShouldHonourTheDateRangeButNotTheTotalCapacity
	When User creates new Slot via Api
	| Project      | SlotName    | DisplayName | CapacityType    | ObjectType | Tuesday | Tasks                     |
	| 2004 Rollout | Slot17833_1 | 17833_1     | Teams and Paths | Device     | 1       | Migration \ Migrated Date |
	| 2004 Rollout | Slot17833_2 | 17833_2     | Teams and Paths | Device     | 2       | Migration \ Migrated Date |
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Migration \ Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	And User selects 'Slot17833_1' in the 'Capacity Slot' dropdown
	When User navigate to the bottom of the Action panel
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	And User clicks refresh button in the browser
	And User clicks the Actions button
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Migration \ Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	Then User sees that 'Capacity Slot' dropdown contains following options:
	| Options    |
	| None       |
	| Slot17833_1|
	| Slot17833_2|