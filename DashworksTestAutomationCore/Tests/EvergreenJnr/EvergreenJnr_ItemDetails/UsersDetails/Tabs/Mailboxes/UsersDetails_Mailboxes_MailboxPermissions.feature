Feature: UsersDetails_Mailboxes_MailboxPermissions
	Runs related tests for Mailboxes > Mailbox Permissions tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17813
Scenario: EvergreenJnr_UsersList_CheckThatToolTipForMailboxPermissionOnMailboxPermissionsTabOnUserObjectPageIsDisplayedCorrectly
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User navigates to the 'Mailboxes' left menu item
	When User navigates to the 'Mailbox Permissions' left submenu item
	When User enters "Exchange 2007" text in the Search field for "Mailbox Platform" column
	Then 'FullAccess' content is displayed in the 'Permission' column
	Then 'FullAccess' tooltip is displayed for 'FullAccess' content in the 'Permission' column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19365 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatAllColumnsAreDisplayedOnMailboxPermissionSubTab
	When User navigates to the 'User' details page for the item with '89026' ID
	Then Details page for '0561008DF1F3412F90B (Haws, Jacquelyn)' item is displayed to the user
	When User navigates to the 'Mailboxes' left menu item
	And User navigates to the 'Mailbox Permissions' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName       |
	| Mailbox Platform |
	| Server           |
	| Email Address    |
	| Display Name     |
	| Via              |
	| Permission       |
	| Folder           |