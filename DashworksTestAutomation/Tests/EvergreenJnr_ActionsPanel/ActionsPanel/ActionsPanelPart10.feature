Feature: ActionsPanelPart10
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14161
Scenario: EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxScopedProjectAreDisplayedCorrectly
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 016E1B57C2DD4FCC986@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Project' in the 'Project or Evergreen' dropdown
	And User selects 'Mailbox Evergreen Capacity Project' option from 'Project' autocomplete
	And User selects 'Unassigned' option from 'Bucket' autocomplete
	Then following Values are displayed in the 'Also Move Users' dropdown:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects 'Owners only' in the 'Also Move Users' dropdown
	Then 'UPDATE' button is not disabled

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14162
Scenario: EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnlyDisplayedEvergreenOrMailboxScopedProjects 
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 016E1B57C2DD4FCC986@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' in the 'Bulk Update Type' dropdown
	And User selects 'Project' in the 'Project or Evergreen' dropdown
	Then 'Project' autocomplete contains following options:
	| Options                            |
	| Email Migration                    |
	| Mailbox Evergreen Capacity Project |

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14164 @DAS16826
Scenario: EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI             |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	And User selects 'Bulk update' in the 'Action' dropdown
	Then following Values are displayed in the 'Bulk Update Type' dropdown:
	| Options              |
	| Update capacity unit |
	| Update custom field  |
	| Update path          |
	| Update task value    |

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
	| Project                         | SlotName | DisplayName | CapacityType   | ObjectType | Sunday | Tasks                   |
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