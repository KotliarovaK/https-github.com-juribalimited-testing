Feature: FiltersFunctionalityPart09
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user


@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13392
Scenario Outline: EvergreenJnr_AllLists_CheckThatSearchBySharpOrAmpersandSymbolWorksInTextFilter
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values |
	| #&     |
	Then "<FilterName>" filter is added to the list
	And message '<Message>' is displayed to the user

Examples: 
	| ListName     | FilterName  | Message               |
	| Devices      | Hostname    | No devices found      |
	| Users        | Username    | No users found        |
	| Applications | Application | No applications found |
	| Mailboxes    | Mail Server | No mailboxes found    |

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
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

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseDepartmentFilter
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "<SelectedCheckboxes>" Tree List option
	Then "Department" filter is added to the list
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| PageName  | SelectedCheckboxes      | Rows  |
	| Devices   | Application Development | 873   |
	| Users     | Application Development | 1,858 |
	| Mailboxes | Application Development | 1,118 |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12522
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedAfterApplyingGBFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values   |
	| <Values> |
	Then "<RowsCount>" rows are displayed in the agGrid
	And There are no errors in the browser console

Examples: 
	| FilterName                   | Values | RowsCount |
	| Memory (GB)                  | 20.48  | 2         |
	| HDD Total Size (GB)          | 152.77 | 2         |
	| Target Drive Free Space (GB) | 995.54 | 1         |