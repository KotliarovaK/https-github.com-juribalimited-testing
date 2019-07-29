Feature: MailboxesFiltersAndColumns
	Check all Columns and Filters via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Mailboxes @API @FiltersAndColumns
Scenario: EvergreenJnr_MailboxesList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Mailboxes' list
	Then All columns with correct data are returned from the API for 'Mailboxes' list

#Remove Not_Run when queries will be added
@Evergreen @Mailboxes @API @FiltersAndColumns @Not_Run
Scenario: EvergreenJnr_MailboxesList_CheckFiltersAndColumnsResponseData
	Then Positive number of results returned for 'MailboxesQueryUrls' requests

