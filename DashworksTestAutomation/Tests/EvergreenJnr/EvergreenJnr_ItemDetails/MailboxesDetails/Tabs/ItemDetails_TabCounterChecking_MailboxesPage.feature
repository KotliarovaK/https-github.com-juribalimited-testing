Feature: ItemDetails_TabCounterChecking_MailboxesPage
	Runs Item Details TabCounterChecking_MailboxesPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS16905 @DAS16832 @DAS17143 @DAS17521
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	And User sees following parent left menu items
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#Then 'Related' left submenu item is disabled
	#Then 'Notes' left submenu item is disabled
	#Then 'Audit History' left submenu item is disabled
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Email Addresses' left submenu item with some count is displayed
	And 'Mailbox' left submenu item is displayed without count
	And 'Mailbox Owner' left submenu item is displayed without count
	And 'Department and Location' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName            |
	| Evergreen Details     |
	| Project Details       |
	| Mailbox Projects      |
	| Mailbox User Projects |
	#================ checks counters ================#
	And 'Mailbox Projects' left submenu item with some count is displayed
	And 'Mailbox User Projects' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main Users tab ================#
	When User navigates to the 'Users' left menu item
	Then 'Users' left menu have following submenu items:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	And 'Users' left submenu item with some count is displayed
	And 'Groups' left submenu item with some count is displayed
	And 'Unresolved Users' left submenu item with some count is displayed
	And 'Mailbox Permissions' left submenu item is displayed without count
	And 'Folder Permissions' left submenu item is displayed without count
	#================ checks sub-menu for main Trend tab ================#
	When User navigates to the 'Trend' left menu item
	Then 'Trend' left menu have following submenu items:
	| SubTabName            |
	| Email Count           |
	| Mailbox Size          |
	| Associated Item Count |
	| Deleted Item Count    |
	| Deleted Item Size     |
	#================ checks counters ================#
	And 'Email Count' left submenu item is displayed without count
	And 'Mailbox Size' left submenu item is displayed without count
	And 'Associated Item Count' left submenu item is displayed without count
	And 'Deleted Item Count' left submenu item is displayed without count
	And 'Deleted Item Size' left submenu item is displayed without count

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16906 @DAS16832 @DAS17143 @DAS17521
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectMode
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then User sees following parent left menu items
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Email Addresses' left submenu item with some count is displayed
	And 'Mailbox' left submenu item is displayed without count
	And 'Mailbox Owner' left submenu item is displayed without count
	And 'Department and Location' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName            |
	| Evergreen Details     |
	| Project Details       |
	| Mailbox Projects      |
	| Mailbox User Projects |
	#================ checks counters ================#
	And 'Mailbox Projects' left submenu item with some count is displayed
	And 'Mailbox User Projects' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main Users tab ================#
	When User navigates to the 'Users' left menu item
	Then 'Users' left menu have following submenu items:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	And 'Users' left submenu item with some count is displayed
	And 'Groups' left submenu item with some count is displayed
	And 'Unresolved Users' left submenu item with some count is displayed
	And 'Mailbox Permissions' left submenu item is displayed without count
	And 'Folder Permissions' left submenu item is displayed without count
	#================ checks sub-menu for main Trend tab ================#
	When User navigates to the 'Trend' left menu item
	Then 'Trend' left menu have following submenu items:
	| SubTabName            |
	| Email Count           |
	| Mailbox Size          |
	| Associated Item Count |
	| Deleted Item Count    |
	| Deleted Item Size     |
	#================ checks counters ================#
	And 'Email Count' left submenu item is displayed without count
	And 'Mailbox Size' left submenu item is displayed without count
	And 'Associated Item Count' left submenu item is displayed without count
	And 'Deleted Item Count' left submenu item is displayed without count
	And 'Deleted Item Size' left submenu item is displayed without count