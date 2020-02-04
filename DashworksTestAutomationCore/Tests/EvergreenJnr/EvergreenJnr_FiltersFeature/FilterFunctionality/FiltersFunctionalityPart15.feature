Feature: FiltersFunctionalityPart15
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_DevicesList_CheckSlotsSortOrderForDevicesList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "1803: Pre-Migration \ Scheduled Date (Slot)" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Laptop         |
	When User clicks on '1803: Pre-Migration \ Scheduled Date (Slot)' column header
	Then Content in the '1803: Pre-Migration \ Scheduled Date (Slot)' column is equal to
	| Content                    |
	| Birmingham Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| London - City Morning      |
	| London - Southbank Morning |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	When User clicks on '1803: Pre-Migration \ Scheduled Date (Slot)' column header
	Then Content in the '1803: Pre-Migration \ Scheduled Date (Slot)' column is equal to
	| Content                    |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	| London Depot 09:00 - 11:00 |
	| London - Southbank Morning |
	| London - City Morning      |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Manchester Morning         |
	| Birmingham Morning         |

@Evergreen @Applications @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_ApplicationsList_CheckSlotsSortOrderForApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User clicks on 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column is equal to
	| Content            |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 2 |
	When User clicks on 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column is equal to
	| Content            |
	| Application Slot 2 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
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