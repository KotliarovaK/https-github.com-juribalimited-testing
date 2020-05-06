Feature: MailboxesDetails_Users
	Runs related tests for Users tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19637
Scenario: EvergreenJnr_MailboxesList_CheckThatUsersTabDisplayingForObjecWithUnresolvedUsers
	When User navigates to the 'Mailbox' details page for 'julia.bell@juriba.com' item
	When User navigates to the 'Users' left menu item	
	When User navigates to the 'Unresolved Users' left submenu item
	Then 'Unresolved Users' left submenu item with '15' count is displayed
	Then "15" rows found label displays on Details Page
	When User navigates to the 'Mailbox Permissions' left submenu item
	Then table content is present
	Then There are no errors in the browser console
	When User navigates to the 'Folder Permissions' left submenu item
	Then table content is present
	Then There are no errors in the browser console
