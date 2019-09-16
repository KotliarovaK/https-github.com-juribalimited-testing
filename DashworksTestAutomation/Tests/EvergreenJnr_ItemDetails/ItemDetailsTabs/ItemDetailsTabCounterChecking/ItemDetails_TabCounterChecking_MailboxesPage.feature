Feature: ItemDetails_TabCounterChecking_MailboxesPage
	Runs Item Details TabCounterChecking_MailboxesPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Ann.Ilchenko 7/18/19: The navigation menu counters are ready in the 'Pulsar' release.
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS16905 @DAS16832 @DAS17143 @DAS17521 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	And User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#Then "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#Then "Notes" sub-tab is displayed with disabled state on left menu on the Details page
	#Then "Audit History" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Email Addresses" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Mailbox Projects      |
	| Mailbox User Projects |
	And "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	And "Mailbox Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox User Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	When User navigates to the 'Users' left menu item
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	And "Users" tab is displayed on left menu on the Details page and contains count of items
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "Unresolved Users" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	When User navigates to the 'Trend' left menu item
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	And "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items

	#Ann.Ilchenko 7/18/19: The navigation menu counters are ready in the 'Pulsar' release.
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16906 @DAS16832 @DAS17143 @DAS17521 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Email Addresses" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Project Details       |
	| Mailbox Projects      |
	| Mailbox User Projects |
	#================ checks counters ================#
	And "Mailbox Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox User Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	When User navigates to the 'Users' left menu item
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	And "Users" tab is displayed on left menu on the Details page and contains count of items
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "Unresolved Users" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	When User navigates to the 'Trend' left menu item
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	And "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items