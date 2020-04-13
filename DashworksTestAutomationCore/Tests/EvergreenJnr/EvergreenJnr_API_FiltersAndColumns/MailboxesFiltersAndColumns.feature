Feature: MailboxesFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Mailboxes @API @FiltersAndColumns
Scenario: EvergreenJnr_MailboxesList_CheckAllColumns
	Then All columns with correct data are returned from the API for 'Mailboxes' list

@Evergreen @Mailboxes @API @FiltersAndColumns
Scenario: EvergreenJnr_MailboxesList_CheckAllFilters 
	Then All filters with correct data are returned from the API for 'Mailboxes' list

@Evergreen @Mailboxes @API @FiltersAndColumns
Scenario Outline: EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for requests:
	| FilterCategory   | FilterName   | QueryString   |
	| <FilterCategory> | <FilterName> | <QueryString> |

Examples: 
	| FilterCategory | FilterName         | QueryString                                                         |
	| Organization   | Department Level 1 | mailboxes?$filter=(departmentLevelFieldId_1%20EQUALS%20('2'%2C'9')) |
