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
	And "14,884" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS11831
Scenario: EvergreenJnr_MailboxesList_CheckThatResultCounterDoesNotDisappearAfterDeletingTheCharactersInEmailMigraTeamFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Team" filter where type is "Equals" without added column and following value:
		| Values |
		| 55     |
	Then '50 of 55 shown' label is displayed in expanded autocomplete
	When User deletes one character from the Search field
	Then '50' of all shown label is displayed in expanded autocomplete

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS12940
Scenario: EvergreenJnr_MailboxesList_CheckThatDeletedBucketIsNotAvailableInEvergreenBucketFilter
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	And User clicks 'CREATE EVERGREEN BUCKET' button
	And User enters 'Bucket_DAS12940_to_be_deleted' text to 'Bucket Name' textbox
	When User selects 'Admin IT' option from 'Team' autocomplete
	And User clicks 'CREATE' button
	And User select "Bucket" rows in the grid
		| SelectedRowsName              |
		| Bucket_DAS12940_to_be_deleted |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS13201 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatDeletedCapacityUnitIsNotAvailableInEvergreenCapacityUnitFilter
	When User creates new Capacity Unit via api
		| Name                                 | Description | IsDefault |
		| Capacity_Unit_DAS13201_to_be_deleted | 13201       | false     |
	And User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	And User select "Capacity Unit" rows in the grid
		| SelectedRowsName                     |
		| Capacity_Unit_DAS13201_to_be_deleted |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS12547
Scenario: EvergreenJnr_MailboxesList_CheckThatOwnerFloorValuesAreSortedInTheFilterBlock
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Floor" filter
	When User clicks in search field in the Filter block
	Then the values are displayed for "OwnerFloor" filter on "Mailboxes" page in the following order:
		| Value |
		| Empty |
		| 0     |
		| 1     |
		| 2     |
		| 3     |
		| 4     |
		| 5     |
		| 6     |
		| 11    |
		| 12    |
		| 18    |
		| 19    |
		| 20    |
		| 21    |
		| 25    |
		| 26    |
		| 49    |
		| 51    |

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS18367
Scenario: EvergreenJnr_MailboxesList_CheckThatThereIsNoEmptyOptionInInListFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "Mailbox (Saved List)" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

@Evergreen @Evergreen_FiltersFeature @Filter_MailboxesList @DAS19348
Scenario: EvergreenJnr_MailboxesList_CheckThatNewRecipientTypeColumnDisplayedCorrectly
	When User clicks 'Mailboxes' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
		| ColumnName     |
		| Recipient Type |
	Then ColumnName is added to the list
		| ColumnName     |
		| Recipient Type |
	When User clicks the Filters button
	When User add "Recipient Type" filter where type is "Does not equal" without added column and "Empty" Lookup option
	Then "Recipient Type" filter is added to the list
	Then Column headers are displayed in high contrast
	Then Text content of 'Recipient Type' column is displayed in High Contrast
	#translation
	When User language is changed to "Test Language" via API
	Then grid headers are displayed in the following order
		| ColumnName |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |