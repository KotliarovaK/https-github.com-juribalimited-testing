Feature: UsersDetails_Mailboxes_Mailboxes
	Runs related tests for Mailboxes tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19365
Scenario: EvergreenJnr_UsersList_CheckThatAllColumnsAreDisplayedOnMailboxesSubTab
	When User navigates to the 'User' details page for the item with '89026' ID
	Then Details page for '0561008DF1F3412F90B (Haws, Jacquelyn)' item is displayed to the user
	When User navigates to the 'Mailboxes' left menu item
	And User navigates to the 'Mailboxes' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Recipient Type     |
	| Owner Display Name |