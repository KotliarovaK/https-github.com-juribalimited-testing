Feature: ActionsPanelPart10
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14161
Scenario: EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxScopedProjectAreDisplayedCorrectly
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 016E1B57C2DD4FCC986@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	And User selects "Mailbox Evergreen Capacity Project" Project on Action panel
	And User selects "Unassigned" option in "Bucket" field on Action panel
	Then following values are displayed in "Also Move Users" drop-down on Action panel:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects "Owners only" option in "Also Move Users" drop-down on Action panel
	Then "UPDATE" Action button is active

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14162
Scenario: EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnlyDisplayedEvergreenOrMailboxScopedProjects 
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 016E1B57C2DD4FCC986@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update bucket" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	Then following values are displayed in "Project" drop-down with searchfield on Action panel:
	| Options                            |
	| Email Migration                    |
	| Mailbox Evergreen Capacity Project |

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14164 @DAS16826
Scenario: EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplicationsList
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI             |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	And User selects "Bulk update" in the Actions dropdown
	Then following values are displayed in "Bulk Update Type" drop-down on Action panel:
	| Options              |
	| Update capacity unit |
	| Update path          |
	| Update task value    |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS15291 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckSortOrderForBulkUpdateCapacitySlot
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "1803 Rollout" Project on Action panel
	And User selects "Pre-Migration" Stage on Action panel
	And User selects "Scheduled Date" Task on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "23 Nov 2018" Date on Action panel
	#Ann.Ilchenko 7/17/19 : fixed on 'orbit'
	#Update Capacity Slot sort order
	Then following values are displayed in "Capacity Slot" drop-down on Action panel:
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

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS17103
Scenario: EvergreenJnr_DevicesList_CheckTooltipDisplayingInDatePickerOfBulkUpdate
	When User clicks "Devices" on the left-hand menu
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "1803 Rollout" Project on Action panel
	And User selects "Pre-Migration" Stage on Action panel
	And User selects "Scheduled Date" Task on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "6 Nov 2018" Date on Action panel
	And User clicks datepicker for Action panel
	And User selects "6" day selection
	And User clicks datepicker for Action panel
	Then Day with "5" number displayed green in Datepicker
	And Datepicker has tooltip with "8" rows for value "5"
	When User selects "5" day selection
	Then following values are presented in "Capacity Slot" drop-down on Action panel:
	| Options                    |
	| Birmingham Morning         |
	| London - City Morning      |
	| London - Southbank Morning |
	| London Depot 09:00 - 11:00 |
	| London Depot 11:00 - 13:00 |
	| London Depot 13:00 - 15:00 |
	| London Depot 15:00 - 17:00 |
	And following values are not presented in "Capacity Slot" drop-down on Action panel:
	| Options            |
	| Manchester Morning |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS17580 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckDateColorDisplayingInBulkUpdateDatePicker
	When User creates new Slot via Api
	| Project                         | SlotName | DisplayName | CapacityType   | ObjectType | Sunday | Tasks                   |
	| User Evergreen Capacity Project | slot1    | slot 1      | Capacity Units | User       | 0      | Stage 2 \ Scheduled Date |
	| User Evergreen Capacity Project | slot2    | slot 2      | Capacity Units | User       | 5      | Stage 2 \ Scheduled Date |
	| User Evergreen Capacity Project | slot3    | slot 3      | Capacity Units | User       |        | Stage 2 \ Scheduled Date |
	And User clicks "Users" on the left-hand menu
	And User clicks the Actions button
	And User select "Display Name" rows in the grid
	| SelectedRowsName                   |
	| Exchange Online-ApplicationAccount |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "User Evergreen Capacity Project" Project on Action panel
	And User selects "Stage 2" Stage on Action panel
	And User selects "Scheduled Date" Task on Action panel
	And User selects "Update" Update Date on Action panel
	And User clicks datepicker for Action panel
	Then Column "Sunday" displayed green in Datepicker