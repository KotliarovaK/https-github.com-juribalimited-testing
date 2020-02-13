﻿Feature: СheckingDropdownListValues2
	Runs Checking Dropdown List Values related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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
	| 2004 Rollout | Slot 17639 | 17639       | Teams and Paths | Device     | 10      | Migration \ Migrated Date |
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '2004 Rollout' option from 'Project' autocomplete
	And User selects 'Migration' option from 'Stage' autocomplete
	And User selects 'Migrated Date' option from 'Task' autocomplete
	And User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	Then User sees that 'Capacity Slot' dropdown contains following options:
	| Options    |
	| None       |
	| Slot 17639 |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15618
Scenario: EvergreenJnr_DevicesList_ChecksThatCapacityAffectingNonCapacityEnabledDateTasks
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Migration \ Migrated Date" filter where type is "Not empty" with added column and Date options
	| StartDateInclusive | EndDateInclusive |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| CDQ172G3MZS444   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Migration' option from 'Stage' autocomplete
	When User selects 'Migrated Date' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters next 'Tuesday' day to 'Date' textbox
	When User clicks 'UPDATE' button 
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

@Evergreen @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18270 @DAS18233 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_AdminPage_CheckUpdateDateDropdownValueWithDateTaskOnlyProperties
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