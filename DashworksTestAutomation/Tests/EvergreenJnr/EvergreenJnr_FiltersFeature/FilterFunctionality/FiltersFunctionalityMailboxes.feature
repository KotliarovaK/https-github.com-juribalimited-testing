Feature: FiltersFunctionalityMailboxes
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS12351
Scenario Outline: EvergreenJnr_MailboxesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnMailboxesPage
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples:
	| FilterName           | SelectedCheckboxes     | Rows |
	| EmailMigra: Category | Mailbox Category A     | 6    |
	| EmailMigra: Path     | Personal Mailbox - VIP | 6    |

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS15291
Scenario: EvergreenJnr_MailboxesList_CheckSlotsSortOrderForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "MailboxEve: 1 \ Scheduled - mailbox (Slot)" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User Add And "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values                    |
	| Spruill, Shea             |
	| Bandyopadhyay, Sudipta    |
	| Balanceactiv, Info        |
	When User clicks on 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column header
	Then Content in the 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column is equal to
	| Content                                            |
	| CA -Mailbox-Nov 1, 2018-Nov 10, 2018               |
	| CA -Mailbox-Nov 11, 2018-Nov 30, 2018              |
	| TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\RT=A\T=Admin |
	When User clicks on 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column header
	Then Content in the 'MailboxEve: 1 \ Scheduled - mailbox (Slot)' column is equal to
	| Content                                            |
	| TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\RT=A\T=Admin |
	| CA -Mailbox-Nov 11, 2018-Nov 30, 2018              |
	| CA -Mailbox-Nov 1, 2018-Nov 10, 2018               |

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS17004
Scenario: EvergreenJnr_MailboxesList_CheckDepartmentLevelFilterItems
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Support            |
	| Technology         |
	Then "6,707" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS11552
Scenario: EvergreenJnr_MailboxesList_CheckThatRelevantDataSetBeDisplayedAfterNavigatingToANewList
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Does not equal" with added column and following checkboxes:
		| SelectedCheckboxes |
		| FALSE              |
		| TRUE               |
	Then "Enabled" filter is added to the list
	And message 'No mailboxes found' is displayed to the user
	When User navigates to the "All Mailboxes" list
	Then 'All Mailboxes' list should be displayed to the user
	And "14,784" rows are displayed in the agGrid