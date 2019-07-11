Feature: CheckAllColumnsApi
	Check all columns via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @API
Scenario: EvergreenJnr_DevicesList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Devices' list
	Then All columns with correct data are returned from the API for 'Devices' list

@Evergreen @Users @EvergreenJnr_Columns @API
Scenario: EvergreenJnr_UsersList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Users' list
	Then All columns with correct data are returned from the API for 'Users' list

@Evergreen @Users @EvergreenJnr_Columns @API
Scenario: EvergreenJnr_ApplicationsList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Applications' list
	Then All columns with correct data are returned from the API for 'Applications' list

@Evergreen @Mailboxes @EvergreenJnr_Columns @API
Scenario: EvergreenJnr_MailboxesList_CheckAllColumnsAndFilters 
	Then All filters with correct data are returned from the API for 'Mailboxes' list
	Then All columns with correct data are returned from the API for 'Mailboxes' list