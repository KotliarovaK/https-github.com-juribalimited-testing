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

@Evergreen @Mailboxes @API @FiltersAndColumns @DAS15899
Scenario: EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists
	Then the following filter subcategories are displayed for 'Project Tasks: MailboxEve' category on 'Mailboxes' page:
	| value                                      |
	| MailboxEve: 1 \ Completed                  |
	| MailboxEve: 1 \ Completed (Slot)           |
	| MailboxEve: 1 \ Forecast                   |
	| MailboxEve: 1 \ Forecast (Slot)            |
	| MailboxEve: 1 \ Migrated                   |
	| MailboxEve: 1 \ Migrated (Slot)            |
	| MailboxEve: 1 \ Scheduled - mailbox        |
	| MailboxEve: 1 \ Scheduled - mailbox (Slot) |
	| MailboxEve: 1 \ Target                     |
	| MailboxEve: 1 \ Target (Slot)              |