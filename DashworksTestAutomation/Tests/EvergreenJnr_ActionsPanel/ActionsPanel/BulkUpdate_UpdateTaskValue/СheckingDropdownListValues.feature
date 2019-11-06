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
	And User selects 'One' option from 'Stage' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
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
	And User selects 'Pre-Migration' option from 'Stage' autocomplete
	Then only below options are displayed in the 'Task' autocomplete
	| Options                |
	| Forecast Date          |
	| Forecast Code          |
	| Target Date            |
	| Scheduled Date         |
	| Laptop Only Task       |
	| Physical Only Task     |
	| VDI Only Task          |
	| Laptop & Physical Task |
	| Target Code            |
	| Scheduled Code         |
	| Further Information    |
	| Targeting Information  |
	| Laptop & Workstation 2 |

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
	Then only below options are displayed in the 'Stage' autocomplete
	| Options |
	| One     |
	| Two     |
	| Three   |
	When User selects 'One' option from 'Stage' autocomplete
	Then only below options are displayed in the 'Task' autocomplete
	| Options                            |
	| Radio Rag only User                |
	| Radio Rag Date User                |
	| Radio Rag Date Owner User          |
	| Text User                          |
	| Radio Rag Only User Req A          |
	| Radio Rag Date User Req A          |
	| Radio Rag Date Owner User Req A    |
	| Radio Rag only User Req B          |
	| Radio Rag Date User Req B          |
	| Radio Rag Date Owner User Req B    |
	| Radio Rag Date Owner Req B         |
	| SS Department and Location Enabled |

#Ann.Ilchenko 10/2/19: remove 'not run' tag when 'DAS18368' bug will be fixed.
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15291 @DAS18368 @Not_Run
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
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Pre-Migration' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '23 Nov 2018' text to 'Date' datepicker
	Then following Values are displayed in the 'Capacity Slot' dropdown:
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
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Pre-Migration' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User enters '6 Nov 2018' text to 'Date' datepicker
	And User clicks datepicker icon 
	And User selects '6' day in the Datepicker
	#Added wait as we need some time fo datepicker to be updated
	And User waits for three seconds
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
	And User selects 'Stage 2' option from 'Stage' autocomplete
	And User selects 'Scheduled Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	And User clicks datepicker icon 
	Then All 'Sunday' days are green in the Datepicker

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @Capacity @Slots @DAS17833 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatFullSlotIsDisplayedWhileRulesShouldHonourTheDateRangeButNotTheTotalCapacity
	When User creates new Slot via Api
	| Project      | SlotName    | DisplayName | CapacityType    | ObjectType | Tuesday | Tasks                     |
	| 1803 Rollout | Slot17833_1 | 17833_1     | Teams and Paths | Device     | 1       | Migration \ Migrated Date |
	| 1803 Rollout | Slot17833_2 | 17833_2     | Teams and Paths | Device     | 2       | Migration \ Migrated Date |
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	And User selects 'Slot17833_1' in the 'Capacity Slot' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	And User clicks refresh button in the browser
	And User clicks the Actions button
	When User selects all rows on the grid
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	Then User sees that 'Capacity Slot' dropdown contains following options:
	| Options    |
	| None       |
	| Slot17833_1|
	| Slot17833_2|

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS16844
Scenario: EvergreenJnr_DevicesList_CheckThatBulkUpdateOfArchivedItemsWorks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User sets includes archived devices in 'true'
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	And User selects 'Evergreen' in the 'Project or Evergreen' dropdown
	When User selects 'Evergreen Capacity Unit 1' option from 'Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then There are no errors in the browser console
	And Success message with "1 update has been queued" text is displayed on Action panel

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS17639 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatSlotIsDisplayedInDDLIfSelectDateWithUnlimitedCapacity
	When User creates new Slot via Api
	| Project      | SlotName   | DisplayName | CapacityType    | ObjectType | Tuesday | Tasks                     |
	| 1803 Rollout | Slot 17639 | 17639       | Teams and Paths | Device     | 10      | Migration \ Migrated Date |
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	Then User sees that 'Capacity Slot' dropdown contains following options:
	| Options    |
	| None       |
	| Slot 17639 |

#Ann.Ilchenko 3/10/19: fixed on 'radiant'
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15618 @Not_Run
Scenario: EvergreenJnr_DevicesList_ChecksThatCapacityAffectingNonCapacityEnabledDateTasks
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "1803: Migration \ Migrated Date" filter where type is "Not empty" with added column and Date options
	| StartDateInclusive | EndDateInclusive |
	Then "7" rows are displayed in the agGrid
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| CDQ172G3MZS444   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '1803 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	And User selects 'None' in the 'Capacity Slot' dropdown
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18269 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now'
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithDateAndTimeProperties
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Date Computer' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18233 @Not_Ready
#Waiting for 'Update relative to now'
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithRadiobuttonProperties
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Radio Rag Date Owner' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |
	| No change                        |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18270 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithDateTaskOnlyProperties
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One' option from 'Stage' autocomplete
	When User selects 'Date Computer' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Date' dropdown:
	| Options                          |
	| Update                           |
	| Update relative to current value |
	| Update relative to now           |
	| Remove                           |
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	Then 'Days' content is displayed in 'Units' dropdown
	Then 'After current value' content is displayed in 'Before or After' dropdown
	When User enters '999999' text to 'Value' textbox
	Then '100000' content is displayed in 'Value' textbox
	When User enters '-5' text to 'Value' textbox
	Then '1' content is displayed in 'Value' textbox
	Then following Values are displayed in the 'Before or After' dropdown:
	| Options              |
	| Before current value |
	| After current value  |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18281 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateDateDropdownValueWithDateAndTimeTaskProperties
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Barry's User Project' option from 'Project' autocomplete
	When User selects 'Project Dates' option from 'Stage' autocomplete
	When User selects 'Forecast Date' option from 'Task' autocomplete
	When User selects 'Update relative to now' in the 'Update Date' dropdown
	When User enters '12' text to 'Value' textbox
	When User selects 'Days' in the 'Units' dropdown
	Then following Values are displayed in the 'Before or After' dropdown:
	| Options    |
	| Before now |
	| After now  |
	Then 'After now' content is displayed in 'Before or After' dropdown
	When User selects 'Before now' in the 'Before or After' dropdown